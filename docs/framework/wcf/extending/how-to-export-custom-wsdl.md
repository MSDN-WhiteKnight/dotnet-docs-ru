---
description: Дополнительные сведения см. в статье как экспортировать пользовательский язык WSDL.
title: Практическое руководство. Экспорт пользовательской информации WSDL
ms.date: 03/30/2017
ms.assetid: 5c1e4b58-b76b-472b-9635-2f80d42a0734
ms.openlocfilehash: 3893e02807bce3db66e469abd5dc38808f530f01
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99735027"
---
# <a name="how-to-export-custom-wsdl"></a>Практическое руководство. Экспорт пользовательской информации WSDL

В этом разделе рассматривается, как экспортировать пользовательскую информацию WSDL. Для этого будет определен новый атрибут кода с названием `WsdlDocumentationAttribute`, добавляющий пользовательскую информацию в WSDL, создаваемый службой.

## <a name="to-export-custom-wsdl-information"></a>Экспорт пользовательской информации WSDL

1. Реализовать интерфейс <xref:System.ServiceModel.Description.IWsdlExportExtension>. Этот интерфейс может быть реализован на основе класса, реализующего любой из следующих интерфейсов: <xref:System.ServiceModel.Description.IOperationBehavior>, <xref:System.ServiceModel.Description.IContractBehavior> или <xref:System.ServiceModel.Description.IEndpointBehavior>. Он может также быть реализован на основе класса, производного от класса <xref:System.ServiceModel.Channels.BindingElement>. В этом примере интерфейс <xref:System.ServiceModel.Description.IWsdlExportExtension> реализуется на классе атрибутов, реализующем интерфейс <xref:System.ServiceModel.Description.IContractBehavior>.

2. Интерфейс <xref:System.ServiceModel.Description.IWsdlExportExtension> определяет два метода <xref:System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint%28System.ServiceModel.Description.WsdlExporter%2CSystem.ServiceModel.Description.WsdlEndpointConversionContext%29> и <xref:System.ServiceModel.Description.IWsdlExportExtension.ExportContract%28System.ServiceModel.Description.WsdlExporter%2CSystem.ServiceModel.Description.WsdlContractConversionContext%29>. Эти методы позволяют изменять или добавлять (или и изменять, и добавлять) дополнительную информацию в контекст <xref:System.ServiceModel.Description.WsdlContractConversionContext>. В этом примере в методе <xref:System.ServiceModel.Description.IWsdlExportExtension.ExportContract%28System.ServiceModel.Description.WsdlExporter%2CSystem.ServiceModel.Description.WsdlContractConversionContext%29> извлекается коллекция объектов <xref:System.ServiceModel.Description.OperationDescription>, а затем эта коллекция просматривается для проверки наличия атрибута `WsdlDocumentationAttribute`. Если он найден, извлекается текст, связанный с этим атрибутом, создается сводный элемент, который добавляется в элемент `DocumentationElement` операции.

    ```csharp
    public void ExportContract(WsdlExporter exporter, WsdlContractConversionContext context)
    {
        Console.WriteLine("Inside ExportContract");
        if (context.Contract != null)
        {
            // Set the document element; if this is not done first, there is no XmlElement in the
            // DocumentElement property.
            context.WsdlPortType.Documentation = string.Empty;
            // Contract comments.
            XmlDocument owner = context.WsdlPortType.DocumentationElement.OwnerDocument;
            XmlElement summaryElement = Formatter.CreateSummaryElement(owner, this.Text);
            context.WsdlPortType.DocumentationElement.AppendChild(summaryElement);

            foreach (OperationDescription op in context.Contract.Operations)
            {
                Operation operation = context.GetOperation(op);
                object[] opAttrs = op.SyncMethod.GetCustomAttributes(typeof(WsdlDocumentationAttribute), false);
                if (opAttrs.Length == 1)
                {
                    string opComment = ((WsdlDocumentationAttribute)opAttrs[0]).Text;

                    // This.Text returns the string for the operation-level attributes.
                    // Set the doc element; if this is not done first, there is no XmlElement in the
                    // DocumentElement property.
                    operation.Documentation = String.Empty;

                    XmlDocument opOwner = operation.DocumentationElement.OwnerDocument;
                    XmlElement newSummaryElement = Formatter.CreateSummaryElement(opOwner, opComment);
                    operation.DocumentationElement.AppendChild(newSummaryElement);
                }
            }
        }
    }
    ```

## <a name="example"></a>Пример

В следующем примере кода показана полная реализация класса `WsdlDocumentationAttribute`.

```csharp
public class WsdlDocumentationAttribute : Attribute, IContractBehavior, IWsdlExportExtension
{
string text;
       XmlElement customWsdlDocElement = null;
public WsdlDocumentationAttribute(string text)
{ this.text = text;}

       public WsdlDocumentationAttribute(XmlElement wsdlDocElement)
        { this.customWsdlDocElement = wsdlDocElement; }

        public XmlElement WsdlDocElement
        {
            get { return this.customWsdlDocElement; }
            set { this.customWsdlDocElement = value; }
        }
       public string Text
{
get { return this.text; }
set { this.text = value; }
}

     public void ExportContract(WsdlExporter exporter, WsdlContractConversionContext context)
{
          Console.WriteLine("Inside ExportContract");
if (context.Contract != null)
{
                // Set the document element; if this is not done first, there is no XmlElement in the
                // DocumentElement property.
                context.WsdlPortType.Documentation = string.Empty;
                // Contract comments.
                XmlDocument owner = context.WsdlPortType.DocumentationElement.OwnerDocument;
                XmlElement summaryElement = Formatter.CreateSummaryElement(owner, this.Text);
                context.WsdlPortType.DocumentationElement.AppendChild(summaryElement);

                foreach (OperationDescription op in context.Contract.Operations)
                {
                    Operation operation = context.GetOperation(op);
                    object[] opAttrs = op.SyncMethod.GetCustomAttributes(typeof(WsdlDocumentationAttribute), false);
                    if (opAttrs.Length == 1)
                    {
                        string opComment = ((WsdlDocumentationAttribute)opAttrs[0]).Text;

                        // This.Text returns the string for the operation-level attributes.
                        // Set the document element; if this is not done first, there is no XmlElement in the
                        // DocumentElement property.
                        operation.Documentation = String.Empty;

                        XmlDocument opOwner = operation.DocumentationElement.OwnerDocument;
                        XmlElement newSummaryElement = Formatter.CreateSummaryElement(opOwner, opComment);
                        operation.DocumentationElement.AppendChild(newSummaryElement);
                    }
                }
            }
        }

public void ExportEndpoint(WsdlExporter exporter, WsdlEndpointConversionContext context)
        {
            Console.WriteLine("ExportEndpoint called.");
        }

        public void AddBindingParameters(ContractDescription description, ServiceEndpoint endpoint, BindingParameterCollection parameters)
        { return; }

        public void ApplyClientBehavior(ContractDescription description, ServiceEndpoint endpoint, ClientRuntime client)
        { return; }

        public void ApplyDispatchBehavior(ContractDescription description, ServiceEndpoint endpoint, DispatchRuntime dispatch)
        { return; }

        public void Validate(ContractDescription description, ServiceEndpoint endpoint) { return; }
    }

  public class Formatter
  {

#region Utility Functions

    public static XmlElement CreateSummaryElement(XmlDocument owningDoc, string text)
    {
      XmlElement summaryElement = owningDoc.CreateElement("summary");
      summaryElement.InnerText = text;
      return summaryElement;
    }

public static CodeCommentStatementCollection FormatComments(string text)
{
      /*
       * Note that in Visual C# the XML comment format absorbs a
       * documentation element with a line break in the middle. This sample
       * could take an XmlElement and create code comments in which
       * the element never had a line break in it.
      */

      CodeCommentStatementCollection collection = new CodeCommentStatementCollection();
collection.Add(new CodeCommentStatement("From WsdlDocumentation:", true));
collection.Add(new CodeCommentStatement(String.Empty, true));

foreach (string line in WordWrap(text, 80))
{
collection.Add(new CodeCommentStatement(line, true));
}

collection.Add(new CodeCommentStatement(String.Empty, true));
return collection;
}

public static Collection<string> WordWrap(string text, int columnWidth)
{
Collection<string> lines = new Collection<string>();
System.Text.StringBuilder builder = new System.Text.StringBuilder();

string[] words = text.Split(' ');
foreach (string word in words)
{
if ((builder.Length > 0) && ((builder.Length + word.Length + 1) > columnWidth))
{
lines.Add(builder.ToString());
builder = new System.Text.StringBuilder();
}
builder.Append(word);
builder.Append(' ');
}
lines.Add(builder.ToString());

return lines;
}

#endregion

    public static XmlElement CreateReturnsElement(XmlDocument owner, string p)
    {
      XmlElement returnsElement = owner.CreateElement("returns");
      returnsElement.InnerText = p;
      return returnsElement;
    }
  }
```

## <a name="see-also"></a>См. также

- [Метаданные](../feature-details/metadata.md)

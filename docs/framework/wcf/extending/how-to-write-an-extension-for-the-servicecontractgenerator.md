---
description: Дополнительные сведения см. в статье как написать расширение для ServiceContractGenerator.
title: Практическое руководство. Разработка расширения для ServiceContractGenerator
ms.date: 03/30/2017
ms.assetid: 876ca823-bd16-4bdf-9e0f-02092df90e51
ms.openlocfilehash: 29d6d65cc3f9d29009f72b9a0c81b6cb1f472ac9
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99644207"
---
# <a name="how-to-write-an-extension-for-the-servicecontractgenerator"></a>Практическое руководство. Разработка расширения для ServiceContractGenerator

В этом разделе описывается, как разработать расширение для <xref:System.ServiceModel.Description.ServiceContractGenerator>. Это можно сделать путем реализации интерфейса <xref:System.ServiceModel.Description.IOperationContractGenerationExtension> для поведения операции или интерфейса <xref:System.ServiceModel.Description.IServiceContractGenerationExtension> для поведения контракта. Здесь показана реализация интерфейса <xref:System.ServiceModel.Description.IServiceContractGenerationExtension> для поведения контракта.  
  
 <xref:System.ServiceModel.Description.ServiceContractGenerator> создает контракты службы, типы клиента и конфигурации клиента из экземпляров <xref:System.ServiceModel.Description.ServiceEndpoint>, <xref:System.ServiceModel.Description.ContractDescription> и <xref:System.ServiceModel.Channels.Binding>. Как правило, экземпляры <xref:System.ServiceModel.Description.ServiceEndpoint>, <xref:System.ServiceModel.Description.ContractDescription> и <xref:System.ServiceModel.Channels.Binding> импортируются из метаданных службы, а затем используются для создания кода для вызова службы. В данном примере реализация <xref:System.ServiceModel.Description.IWsdlImportExtension> используется для обработки заметок WSDL, а затем для добавления расширений создания кода в импортированные контракты для создания комментариев к сгенерированному коду.  
  
### <a name="to-write-an-extension-for-the-servicecontractgenerator"></a>Разработка расширения для ServiceContractGenerator  
  
1. Реализуйте расширение <xref:System.ServiceModel.Description.IServiceContractGenerationExtension>. Чтобы изменить сгенерированный контракт службы, воспользуйтесь экземпляром <xref:System.ServiceModel.Description.ServiceContractGenerationContext>, переданным методу <xref:System.ServiceModel.Description.IServiceContractGenerationExtension.GenerateContract%28System.ServiceModel.Description.ServiceContractGenerationContext%29>.  
  
    ```csharp
    public void GenerateContract(ServiceContractGenerationContext context)  
    {  
        Console.WriteLine("In generate contract.");  
        context.ContractType.Comments.AddRange(Formatter.FormatComments(commentText));  
    }  
    ```  
  
2. Реализуйте расширение <xref:System.ServiceModel.Description.IWsdlImportExtension> в том же классе. Метод <xref:System.ServiceModel.Description.IWsdlImportExtension.ImportContract%28System.ServiceModel.Description.WsdlImporter%2CSystem.ServiceModel.Description.WsdlContractConversionContext%29> может обработать определенное расширение WSDL (в данном случае заметки WSDL), добавив расширение создания кода в импортированный экземпляр <xref:System.ServiceModel.Description.ContractDescription>.  
  
    ```csharp
    public void ImportContract(WsdlImporter importer, WsdlContractConversionContext context)
    {
        // Contract documentation
        if (context.WsdlPortType.Documentation != null)
        {
            context.Contract.Behaviors.Add(new WsdlDocumentationImporter(context.WsdlPortType.Documentation));
        }
        // Operation documentation
        foreach (Operation operation in context.WsdlPortType.Operations)
        {
            if (operation.Documentation != null)
            {
                OperationDescription operationDescription = context.Contract.Operations.Find(operation.Name);
                if (operationDescription != null)
                {
                    operationDescription.Behaviors.Add(new WsdlDocumentationImporter(operation.Documentation));
                }
            }
        }
    }
    public void BeforeImport(ServiceDescriptionCollection wsdlDocuments, XmlSchemaSet xmlSchemas, ICollection<XmlElement> policy)
    {
        Console.WriteLine("BeforeImport called.");
    }

    public void ImportEndpoint(WsdlImporter importer, WsdlEndpointConversionContext context)
    {
        Console.WriteLine("ImportEndpoint called.");
    }
    ```  
  
3. Добавьте средство импорта WSDL в конфигурацию клиента.  
  
    ```xml  
    <metadata>  
      <wsdlImporters>  
        <extension type="Microsoft.WCF.Documentation.WsdlDocumentationImporter, WsdlDocumentation" />  
      </wsdlImporters>  
    </metadata>  
    ```  
  
4. Создайте объект `MetadataExchangeClient` и вызовите метод `GetMetadata` в коде клиента.  
  
    ```csharp
    var mexClient = new MetadataExchangeClient(metadataAddress);  
    mexClient.ResolveMetadataReferences = true;  
    MetadataSet metaDocs = mexClient.GetMetadata();  
    ```  
  
5. Создайте объект `WsdlImporter` и вызовите метод `ImportAllContracts`.  
  
    ```csharp
    var importer = new WsdlImporter(metaDocs);
    System.Collections.ObjectModel.Collection<ContractDescription> contracts = importer.ImportAllContracts();  
    ```  
  
6. Создайте объект `ServiceContractGenerator` и вызовите метод `GenerateServiceContractType` для каждого контракта.  
  
    ```csharp
    var generator = new ServiceContractGenerator();  
    foreach (ContractDescription contract in contracts)  
    {  
       generator.GenerateServiceContractType(contract);  
    }  
    if (generator.Errors.Count != 0)  
       throw new Exception("There were errors during code compilation.");  
    ```  
  
7. Метод <xref:System.ServiceModel.Description.IServiceContractGenerationExtension.GenerateContract%28System.ServiceModel.Description.ServiceContractGenerationContext%29> автоматически вызывается для каждого поведения контракта, реализующего расширение <xref:System.ServiceModel.Description.IServiceContractGenerationExtension>. Затем этот метод может изменить передаваемый контекст <xref:System.ServiceModel.Description.ServiceContractGenerationContext>. В данном примере добавлены комментарии.  
  
## <a name="see-also"></a>См. также

- [Метаданные](../feature-details/metadata.md)
- [Практическое руководство. Импорт пользовательской информации WSDL](how-to-import-custom-wsdl.md)

---
title: Практическое руководство. Привязка к XDocument, XElement или LINQ для результатов запросов XML
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- data binding [WPF], binding to XDocument
- data binding [WPF], binding to XElement
ms.assetid: 6a629a49-fe1c-465d-b76a-3dcbf4307b64
ms.openlocfilehash: afecb87dcfce1a8c48f1b2108edeae3cfd2aa16f
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59209662"
---
# <a name="how-to-bind-to-xdocument-xelement-or-linq-for-xml-query-results"></a>Практическое руководство. Привязка к XDocument, XElement или LINQ для результатов запросов XML
В этом примере показано, как привязать данные XML <xref:System.Windows.Controls.ItemsControl> с помощью <xref:System.Xml.Linq.XDocument>.  
  
## <a name="example"></a>Пример  
 Следующий код XAML определяет <xref:System.Windows.Controls.ItemsControl> и включает в себя шаблон данных для данных типа `Planet` в `http://planetsNS` пространство имен XML. Тип данных XML, заполняющий пространство имен, должен включать пространство имен, заключенное в фигурные скобки, или (при отображении вместе с расширением разметки XAML) предшествовать пространству имен с escape-последовательностью в фигурных скобках. Этот код привязывается к динамическим свойствам, которые соответствуют <xref:System.Xml.Linq.XContainer.Element%2A> и <xref:System.Xml.Linq.XElement.Attribute%2A> методы <xref:System.Xml.Linq.XElement> класса. Динамические свойства включают XAML для привязки к динамическим свойствам, предоставляющим доступ к именам методов. Дополнительные сведения см. в разделе [Динамические свойства LINQ to XML](/visualstudio/designers/linq-to-xml-dynamic-properties). Обратите внимание на то, что объявление пространства имен по умолчанию для XML не применяется к именам атрибутов.  
  
 [!code-xaml[XLinqExample#StackPanelResources](~/samples/snippets/csharp/VS_Snippets_Wpf/XLinqExample/CSharp/Window1.xaml#stackpanelresources)]  
[!code-xaml[XLinqExample#ItemsControl](~/samples/snippets/csharp/VS_Snippets_Wpf/XLinqExample/CSharp/Window1.xaml#itemscontrol)]  
  
 Следующие вызовы кода C# <xref:System.Xml.Linq.XDocument.Load%2A> и задает контекст данных панели стека для всех подэлементов элемента с именем `SolarSystemPlanets` в `http://planetsNS` пространство имен XML.  
  
 [!code-csharp[XLinqExample#LoadDCFromFile](~/samples/snippets/csharp/VS_Snippets_Wpf/XLinqExample/CSharp/Window1.xaml.cs#loaddcfromfile)]
   
  
 XML-данные могут храниться в виде ресурсов XAML с помощью <xref:System.Windows.Data.ObjectDataProvider>. Полный пример см. в разделе [исходный код L2DBForm.xaml](/visualstudio/designers/l2dbform-xaml-source-code). В следующем примере показано, каким образом код может задавать контекст данных для ресурса объекта.  
  
 [!code-csharp[XLinqExample#LoadDCFromXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/XLinqExample/CSharp/Window1.xaml.cs#loaddcfromxaml)]
   
  
 Динамические свойства, которые сопоставляются с <xref:System.Xml.Linq.XContainer.Element%2A> и <xref:System.Xml.Linq.XElement.Attribute%2A> обеспечивают гибкость в XAML. Код также можно привязать к результатам запроса LINQ для XML. В этом примере он привязывается к результатам запроса, направленного значением элемента.  
  
 [!code-csharp[XLinqExample#BindToResults](~/samples/snippets/csharp/VS_Snippets_Wpf/XLinqExample/CSharp/Window1.xaml.cs#bindtoresults)]
   
  
## <a name="see-also"></a>См. также

- [Общие сведения об источниках привязки](binding-sources-overview.md)
- [Общие сведения о привязке данных WPF с помощью LINQ to XML](/visualstudio/designers/wpf-data-binding-with-linq-to-xml-overview)
- [Привязка данных WPF с использованием примера LINQ to XML](/visualstudio/designers/wpf-data-binding-using-linq-to-xml-example)
- [Динамические свойства LINQ to XML](/visualstudio/designers/linq-to-xml-dynamic-properties)

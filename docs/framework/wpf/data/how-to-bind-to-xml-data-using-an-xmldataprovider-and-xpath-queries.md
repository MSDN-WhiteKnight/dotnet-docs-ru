---
title: Практическое руководство. Привязка к XML-данным с помощью XMLDataProvider и запросов XPath
ms.date: 03/30/2017
helpviewer_keywords:
- XmlDataProvider [WPF], binding to XML data
- data binding [WPF], binding to XML data using XmlDataProvider queries
- binding [WPF], to XML data using XmlDataProvider queries
ms.assetid: 7dcd018f-16aa-4870-8e47-c1b4ea31e574
ms.openlocfilehash: f6cd09279cf23d3273e7a4083950a5f42714c8bf
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59097230"
---
# <a name="how-to-bind-to-xml-data-using-an-xmldataprovider-and-xpath-queries"></a>Практическое руководство. Привязка к XML-данным с помощью XMLDataProvider и запросов XPath
В этом примере показано, как выполнить привязку к [!INCLUDE[TLA#tla_xml](../../../../includes/tlasharptla-xml-md.md)] данных с помощью <xref:System.Windows.Data.XmlDataProvider>.  
  
 С помощью <xref:System.Windows.Data.XmlDataProvider>, базовые данные, может осуществляться через привязку данных в приложении может быть любым деревом [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)] узлов. Другими словами <xref:System.Windows.Data.XmlDataProvider> предоставляет удобный способ использования любого дерева из [!INCLUDE[TLA#tla_xml](../../../../includes/tlasharptla-xml-md.md)] узлов, в качестве источника привязки.  
  
## <a name="example"></a>Пример  
 В следующем примере данные внедряются непосредственно как [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)] *острова данных* в <xref:System.Windows.FrameworkElement.Resources%2A> разделе. Остров данных [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)] должен быть заключен в теги `<x:XData>` и всегда иметь один корневой узел, который в этом примере является *Инвентаризацией*.  
  
> [!NOTE]
>  Корневой узел данных [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)] имеет атрибут **xmlns**, который задает для пространства имен [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)] пустую строку. Это обязательное требование для выполнения запросов XPath к островам данных, встроенным в страницу [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)]. В данном случае [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)], и таким образом, остров данных наследует <xref:System.Windows> пространства имен. По этой причине необходимо задать пространство имен пустым, чтобы запретить определять запросы XPath с пространством <xref:System.Windows> пространства имен, которое неправильно направляло бы запросы.  
  
 [!code-xaml[XMLDataSource#1](~/samples/snippets/csharp/VS_Snippets_Wpf/XmlDataSource/CS/Window1.xaml#1)]  
  
 Как показано в следующем примере, для создания такого же объявления привязки в синтаксисе атрибутов необходимо экранировать специальные символы правильно. Дополнительные сведения см. в разделе [Сущности знаков XML и XAML](../../xaml-services/xml-character-entities-and-xaml.md).  
  
 <xref:System.Windows.Controls.ListBox> Будут показаны следующие элементы, при запуске этого примера. Это *заголовки* всех элементов в группе *Книги* со значением *Stock*, равным *out*, или значением *Number*, равным 3 или больше или равным 8. Обратите внимание, что не *компакт-диска* элементы возвращаются, потому что <xref:System.Windows.Data.XmlDataProvider.XPath%2A> заданное <xref:System.Windows.Data.XmlDataProvider> указывает, что только *книг* элементы должны предоставляться ему (по существу установки фильтра).  
  
 ![XPath Example](./media/xpathexample.PNG "XPathExample")  
  
 В этом примере отображаются названия книг, так как <xref:System.Windows.Data.Binding.XPath%2A> из <xref:System.Windows.Controls.TextBlock> привязки в <xref:System.Windows.DataTemplate> имеет значение "*Title*«. Если вы хотите отображать значение атрибута, например *ISBN*, следует установить для <xref:System.Windows.Data.Binding.XPath%2A> значение "`@ISBN`«.  
  
 Свойства **XPath** в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] обрабатываются методом XmlNode.SelectNodes. Можно изменить запросы **XPath** для получения других результатов. Ниже приведено несколько примеров для <xref:System.Windows.Data.Binding.XPath%2A> запрос к привязанному элементу <xref:System.Windows.Controls.ListBox> из предыдущего примера:  
  
-   `XPath="Book[1]"` Возвращает первый элемент книги («XML в действии»). Обратите внимание, что индексы **XPath** основаны на 1, а не на 0.  
  
-   `XPath="Book[@*]"` Возвращает все элементы книги с любыми атрибутами.  
  
-   `XPath="Book[last()-1]"` Возвращает второй элемент последней книги («Знакомство с Microsoft .NET»).  
  
-   `XPath="*[position()>3]"` Возвращает все элементы книги, за исключением первых трех.  
  
 При запуске **XPath** запрос, он возвращает <xref:System.Xml.XmlNode> или список XmlNodes. <xref:System.Xml.XmlNode> — [!INCLUDE[TLA#tla_clr](../../../../includes/tlasharptla-clr-md.md)] объектом, то есть можно использовать <xref:System.Windows.Data.Binding.Path%2A> свойство для привязки к [!INCLUDE[TLA#tla_clr](../../../../includes/tlasharptla-clr-md.md)] свойства. Вернемся к нашему предыдущему примеру еще раз. Если остальная часть примера остается неизменной и вы изменяете <xref:System.Windows.Controls.TextBlock> привязке следующего, будут отображаться имена возвращенных XMLNodes в <xref:System.Windows.Controls.ListBox>. В этом случае все возвращаемые узлы называются "*книги*".  
  
 [!code-xaml[XmlDataSourceVariation#XmlNodePath](~/samples/snippets/csharp/VS_Snippets_Wpf/XmlDataSourceVariation/CS/Page1.xaml#xmlnodepath)]  
  
 В некоторых приложениях внедрение [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)] в качестве острова данных в источник [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] страницы может быть нецелесообразным, поскольку точное содержимое данных должно быть известно во время компиляции. Поэтому также поддерживается получение данных из внешнего [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)] файла, как показано в следующем примере:  
  
 [!code-xaml[XMLDataSource2#XmlFileExample](~/samples/snippets/csharp/VS_Snippets_Wpf/XmlDataSource2/CS/Window1.xaml#xmlfileexample)]  
  
 Если [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)] данные находятся в удаленном [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)] файл, можно будет определить доступ к данным путем назначения соответствующих [!INCLUDE[TLA2#tla_url](../../../../includes/tla2sharptla-url-md.md)] для <xref:System.Windows.Data.XmlDataProvider.Source%2A> следующим образом:  
  
```xml  
<XmlDataProvider x:Key="BookData" Source="http://MyUrl" XPath="Books"/>  
```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Data.ObjectDataProvider>
- [Привязка к XDocument, XElement или LINQ для результатов запросов XML](how-to-bind-to-xdocument-xelement-or-linq-for-xml-query-results.md)
- [Использование шаблона "Основной/подробности" с иерархическими XML-данными](how-to-use-the-master-detail-pattern-with-hierarchical-xml-data.md)
- [Общие сведения об источниках привязки](binding-sources-overview.md)
- [Общие сведения о привязке данных](data-binding-overview.md)
- [Практические руководства](data-binding-how-to-topics.md)

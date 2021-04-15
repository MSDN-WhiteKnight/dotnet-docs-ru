---
title: Практическое руководство. Использование пространств имен XML в привязке данных
ms.date: 03/30/2017
helpviewer_keywords:
- XML [WPF], namespaces
- data binding [WPF], XML namespaces
- namespaces [WPF], XML
ms.assetid: a47c832f-dc84-48f2-96d5-cde18fc4284b
ms.openlocfilehash: 38bf6e8f88b0325193d49148cd6c33031f7b0a6d
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59149998"
---
# <a name="how-to-use-xml-namespaces-in-data-binding"></a>Практическое руководство. Использование пространств имен XML в привязке данных
## <a name="example"></a>Пример  
 В этом примере демонстрируется обработка пространств имен, указанных в источнике привязки XML.  
  
 Если данные XML имеют следующее определение пространства имен XML.  
  
 `<rss version="2.0" xmlns:dc="http://purl.org/dc/elements/1.1/">`  
  
 Можно использовать <xref:System.Windows.Data.XmlNamespaceMapping> элемент для сопоставления пространства имен, чтобы <xref:System.Windows.Data.XmlNamespaceMapping.Prefix%2A>, как показано в следующем примере. Затем можно использовать <xref:System.Windows.Data.XmlNamespaceMapping.Prefix%2A> для ссылки на XML пространства имен. <xref:System.Windows.Controls.ListBox> В этом примере отображается *title* и *DC: Date* каждого *элемент*.  
  
 [!code-xaml[XmlnsBindSnippet#XmlNamespaceMapping](~/samples/snippets/csharp/VS_Snippets_Wpf/XmlnsBindSnippet/CS/Window1.xaml#xmlnamespacemapping)]  
  
 Обратите внимание, что <xref:System.Windows.Data.XmlNamespaceMapping.Prefix%2A> вами не должно соответствовать использованному в XML источника; Если префикс изменяется в XML источника, то сопоставление по-прежнему работает.  
  
 В данном конкретном примере XML данные поступают из веб-службы, но <xref:System.Windows.Data.XmlNamespaceMapping> элемент также работает со встроенными XML или XML данных во внедренном файле.  
  
## <a name="see-also"></a>См. также

- [Привязка к XML-данным с помощью XMLDataProvider и запросов XPath](how-to-bind-to-xml-data-using-an-xmldataprovider-and-xpath-queries.md)
- [Общие сведения о привязке данных](data-binding-overview.md)
- [Практические руководства](data-binding-how-to-topics.md)

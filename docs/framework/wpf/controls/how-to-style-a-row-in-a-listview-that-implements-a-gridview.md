---
title: Практическое руководство. Стиль строки в элементе ListView, реализующем GridView
ms.date: 03/30/2017
helpviewer_keywords:
- GridView controls [WPF], styling rows
- styling rows in ListViews implementing GridViews [WPF]
- ListView controls [WPF], styling rows with GridViews
ms.assetid: 2e406ba2-70a0-4e62-841f-0934859de76e
ms.openlocfilehash: 9af8d10c7db2d3bbe8b9443402cbb1cfeaa7edb3
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59091464"
---
# <a name="how-to-style-a-row-in-a-listview-that-implements-a-gridview"></a>Практическое руководство. Стиль строки в элементе ListView, реализующем GridView
В этом примере показано, как изменить стиль строки в <xref:System.Windows.Controls.ListView> управления, который реализует <xref:System.Windows.Controls.GridView><xref:System.Windows.Controls.ListView.View%2A> режим.  
  
## <a name="example"></a>Пример  
 Задать стиль строки в <xref:System.Windows.Controls.ListView> управления <xref:System.Windows.Controls.ItemsControl.ItemContainerStyle%2A> на <xref:System.Windows.Controls.ListView> элемента управления. Задать стиль для своих элементов, которые отображаются в виде <xref:System.Windows.Controls.ListViewItem> объектов. <xref:System.Windows.Controls.ItemsControl.ItemContainerStyle%2A> Ссылки <xref:System.Windows.Controls.ControlTemplate> объекты, которые используются для отображения содержимого строки.  
  
 Полный пример, из которого взяты следующие примеры, отображает коллекцию сведений о композициях, хранящихся в базе данных [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)]. Каждая композиция в базе данных имеет поле оценки, и значение этого поля определяет способ отображения строки со сведениями о композиции.  
  
 В следующем примере показано определение <xref:System.Windows.Controls.ItemsControl.ItemContainerStyle%2A> для <xref:System.Windows.Controls.ListViewItem> объектов, представляющих композиции в коллекции композиций. <xref:System.Windows.Controls.ItemsControl.ItemContainerStyle%2A> Ссылки <xref:System.Windows.Controls.ControlTemplate> объекты, определяющие способ отображения строки со сведениями о композиции.  
  
 [!code-xaml[ListViewItemStyleSnippet#ItemContainerStyle](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewItemStyleSnippet/CS/Window1.xaml#itemcontainerstyle)]  
  
 В следующем примере показан <xref:System.Windows.Controls.ControlTemplate> , добавляет текстовую строку `"Strongly Recommended"` в строку. Этот шаблон ссылается на <xref:System.Windows.Controls.ItemsControl.ItemContainerStyle%2A> и отображает, если оценка песни имеет значение 5 (пять). <xref:System.Windows.Controls.ControlTemplate> Включает в себя <xref:System.Windows.Controls.GridViewRowPresenter> объект, который размещает содержимое строки в столбцах в соответствии с определением <xref:System.Windows.Controls.GridView> режим просмотра.  
  
 [!code-xaml[ListViewItemStyleSnippet#ControlTemplate](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewItemStyleSnippet/CS/Window1.xaml#controltemplate)]  
  
 В следующем примере определяется <xref:System.Windows.Controls.GridView>.  
  
 [!code-xaml[ListViewItemStyleSnippet#GridView](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewItemStyleSnippet/CS/Window1.xaml#gridview)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.ListView>
- <xref:System.Windows.Controls.GridView>
- [Практические руководства](listview-how-to-topics.md)
- [Общие сведения об элементе управления ListView](listview-overview.md)
- [Стилизация и использование шаблонов](styling-and-templating.md)

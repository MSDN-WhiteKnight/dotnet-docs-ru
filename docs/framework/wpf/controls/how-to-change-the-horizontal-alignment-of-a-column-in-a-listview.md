---
title: Практическое руководство. Изменение горизонтального выравнивания столбцов в элементе ListView
ms.date: 03/30/2017
helpviewer_keywords:
- ListView controls [WPF], horizontal alignment [WPF]
ms.assetid: b9573e44-9dad-4d14-939c-7859ca372758
ms.openlocfilehash: 528a711c1cf7992bb32c0aa4d6e81d71744c9f80
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59102665"
---
# <a name="how-to-change-the-horizontal-alignment-of-a-column-in-a-listview"></a>Практическое руководство. Изменение горизонтального выравнивания столбцов в элементе ListView
По умолчанию содержимое каждого столбца в <xref:System.Windows.Controls.ListViewItem> по левому краю. Выравнивание каждого столбца можно изменить, указав <xref:System.Windows.DataTemplate> и параметр <xref:System.Windows.FrameworkElement.HorizontalAlignment%2A> свойство на элементе в пределах <xref:System.Windows.DataTemplate>. В этом разделе показано, как <xref:System.Windows.Controls.ListView> выравнивания содержимого по умолчанию и как изменить выравнивание один столбец в <xref:System.Windows.Controls.ListView>.  
  
## <a name="example"></a>Пример  
 В следующем примере, данные в `Title` и `ISBN` столбцы по левому краю.  
  
 [!code-xaml[ListViewHowTos#1](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewHowTos/CSharp/Window1.xaml#1)]  
[!code-xaml[ListViewHowTos#2](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewHowTos/CSharp/Window1.xaml#2)]  
  
 Чтобы изменить выравнивание `ISBN` столбец, необходимо указать, что <xref:System.Windows.Controls.Control.HorizontalContentAlignment%2A> каждого элемента <xref:System.Windows.Controls.ListViewItem> является <xref:System.Windows.HorizontalAlignment.Stretch>так, чтобы элементы в каждом <xref:System.Windows.Controls.ListViewItem> может охватывать или размещаться на всю ширину каждого столбца. Так как <xref:System.Windows.Controls.ListView> привязан к источнику данных, необходимо создать стиль, который задает <xref:System.Windows.Controls.Control.HorizontalContentAlignment%2A>. После этого необходимо использовать <xref:System.Windows.DataTemplate> для отображения содержимого вместо использования <xref:System.Windows.Controls.GridViewColumn.DisplayMemberBinding%2A> свойство. Для отображения `ISBN` каждого шаблона <xref:System.Windows.DataTemplate> просто может содержать <xref:System.Windows.Controls.TextBlock> с его <xref:System.Windows.FrameworkElement.HorizontalAlignment%2A> свойство значение <xref:System.Windows.HorizontalAlignment.Right>.  
  
 В следующем примере определяется стиль и <xref:System.Windows.DataTemplate> необходимо, чтобы сделать `ISBN` столбца по правому краю, а также изменения <xref:System.Windows.Controls.GridViewColumn> ссылка <xref:System.Windows.DataTemplate>.  
  
 [!code-xaml[ListViewHowTos#3](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewHowTos/CSharp/Window1.xaml#3)]  
[!code-xaml[ListViewHowTos#4](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewHowTos/CSharp/Window1.xaml#4)]  
  
## <a name="see-also"></a>См. также

- [Общие сведения о привязке данных](../data/data-binding-overview.md)
- [Общие сведения о шаблонах данных](../data/data-templating-overview.md)
- [Привязка к XML-данным с помощью XMLDataProvider и запросов XPath](../data/how-to-bind-to-xml-data-using-an-xmldataprovider-and-xpath-queries.md)
- [Общие сведения об элементе управления ListView](listview-overview.md)

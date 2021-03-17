---
title: Практическое руководство. Использование шаблонов для задания стиля ListView, использующего GridView
ms.date: 03/30/2017
helpviewer_keywords:
- ListView controls [WPF], styling
ms.assetid: 94bf964b-96c8-4bdf-a0c3-f5271b7cb565
ms.openlocfilehash: 1caa652c4a2a3a7d0a8d40fe703df7a3e8038c9b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59147099"
---
# <a name="how-to-use-templates-to-style-a-listview-that-uses-gridview"></a>Практическое руководство. Использование шаблонов для задания стиля ListView, использующего GridView
В этом примере показано, как использовать <xref:System.Windows.DataTemplate> и <xref:System.Windows.Style> объектов для определения внешнего вида <xref:System.Windows.Controls.ListView> элемента управления, использующего <xref:System.Windows.Controls.GridView> режим просмотра.  
  
## <a name="example"></a>Пример  
 В приведенных ниже примерах <xref:System.Windows.Style> и <xref:System.Windows.DataTemplate> объекты, которые настраивать внешний вид заголовка столбца для <xref:System.Windows.Controls.GridViewColumn>.  
  
 [!code-xaml[ListViewTemplate#GridViewHeaderStyle](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewTemplate/CS/window1.xaml#gridviewheaderstyle)]  
  
 [!code-xaml[ListViewTemplate#GridViewHeaderTemplate](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewTemplate/CS/window1.xaml#gridviewheadertemplate)]  
  
 В следующем примере показано, как использовать эти <xref:System.Windows.Style> и <xref:System.Windows.DataTemplate> объекты для установки <xref:System.Windows.Controls.GridViewColumn.HeaderContainerStyle%2A> и <xref:System.Windows.Controls.GridViewColumn.HeaderTemplate%2A> свойства <xref:System.Windows.Controls.GridViewColumn>. <xref:System.Windows.Controls.GridViewColumn.DisplayMemberBinding%2A> Свойство определяет содержимое ячейки столбца.  
  
 [!code-xaml[ListViewTemplate#GridViewColumnTemplate](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewTemplate/CS/window1.xaml#gridviewcolumntemplate)]  
  
 <xref:System.Windows.Controls.GridViewColumn.HeaderContainerStyle%2A> И <xref:System.Windows.Controls.GridViewColumn.HeaderTemplate%2A> только два из нескольких свойств, которые можно использовать для настройки внешнего вида заголовка столбца для <xref:System.Windows.Controls.GridView> элемента управления. Дополнительные сведения см. в разделе [Общие сведения о стилях заголовков столбцов GridView и шаблонах](gridview-column-header-styles-and-templates-overview.md).  
  
 В следующем примере показано определение <xref:System.Windows.DataTemplate> , настраивает внешний вид ячеек в <xref:System.Windows.Controls.GridViewColumn>.  
  
 [!code-xaml[ListViewTemplate#GridViewCellTemplate](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewTemplate/CS/window1.xaml#gridviewcelltemplate)]  
  
 В следующем примере показано, как использовать этот <xref:System.Windows.DataTemplate> для определения содержимого <xref:System.Windows.Controls.GridViewColumn> ячейки. Этот шаблон используется вместо <xref:System.Windows.Controls.GridViewColumn.DisplayMemberBinding%2A> свойство, которое показано в предыдущем <xref:System.Windows.Controls.GridViewColumn> пример.  
  
 [!code-xaml[ListViewTemplate#CellTemplateProperty](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewTemplate/CS/window1.xaml#celltemplateproperty)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.ListView>
- <xref:System.Windows.Controls.GridView>
- [Общие сведения о GridView](gridview-overview.md)
- [Практические руководства](listview-how-to-topics.md)
- [Общие сведения об элементе управления ListView](listview-overview.md)

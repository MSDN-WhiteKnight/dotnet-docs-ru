---
title: Практическое руководство. Изменение размеров столбцов с помощью разделителя GridSplitter
ms.date: 03/30/2017
helpviewer_keywords:
- grid columns [WPF], resizing
- GridSplitter control [WPF], resizing grid columns
- resizing grid columns [WPF]
ms.assetid: 47b20fe6-7adc-4aa6-9693-b4e184eef74b
ms.openlocfilehash: f743e9ccf8a984a646a4b8f05ee99162e5bc73ad
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59210442"
---
# <a name="how-to-resize-columns-with-a-gridsplitter"></a>Практическое руководство. Изменение размеров столбцов с помощью разделителя GridSplitter
В этом примере показано, как создать вертикальный <xref:System.Windows.Controls.GridSplitter> для перераспределения пространства между двумя столбцами в <xref:System.Windows.Controls.Grid> без изменения размеров <xref:System.Windows.Controls.Grid>.  
  
## <a name="example"></a>Пример  
 **Создание GridSplitter, который накладывается границы столбца**  
  
 Чтобы указать <xref:System.Windows.Controls.GridSplitter> который изменяет размеры соседних столбцов в <xref:System.Windows.Controls.Grid>, задайте <xref:System.Windows.Controls.Grid.Column%2A> присоединенное свойство одного из столбцов, которые вы хотите изменить. Если ваш <xref:System.Windows.Controls.Grid> имеет более одной строки, задайте <xref:System.Windows.Controls.Grid.RowSpan%2A> присоединенное свойство количество строк. Затем установите <xref:System.Windows.FrameworkElement.HorizontalAlignment%2A> свойства <xref:System.Windows.HorizontalAlignment.Left> или <xref:System.Windows.HorizontalAlignment.Right> (указываемое выравнивание зависит от какие два столбца, вы хотите изменить). Наконец, установите <xref:System.Windows.FrameworkElement.VerticalAlignment%2A> свойства <xref:System.Windows.VerticalAlignment.Stretch>.  
  
 [!code-xaml[GridSplitterRowColumn#GridSplitterColumnOverlay](~/samples/snippets/csharp/VS_Snippets_Wpf/GridSplitterRowColumn/CS/Window1.xaml#gridsplittercolumnoverlay)]  
  
 Объект <xref:System.Windows.Controls.GridSplitter> , не имеющий собственного столбца может быть скрыт другими элементами управления в <xref:System.Windows.Controls.Grid>. Дополнительные сведения о том, как предотвратить возникновение этой проблемы, см. в разделе [Проверка видимости GridSplitter](how-to-make-sure-that-a-gridsplitter-is-visible.md).  
  
 **Создание GridSplitter, который занимает столбец**  
  
 Чтобы указать <xref:System.Windows.Controls.GridSplitter> , который занимает столбец в <xref:System.Windows.Controls.Grid>, задайте <xref:System.Windows.Controls.Grid.Column%2A> присоединенное свойство одного из столбцов, которые вы хотите изменить. Если сетка имеет более одной строки, задайте <xref:System.Windows.Controls.Grid.RowSpan%2A> присоединенное свойство количество строк. Затем установите <xref:System.Windows.FrameworkElement.HorizontalAlignment%2A> для <xref:System.Windows.HorizontalAlignment.Center>, задайте <xref:System.Windows.FrameworkElement.VerticalAlignment%2A> свойства <xref:System.Windows.VerticalAlignment.Stretch>и задайте <xref:System.Windows.Controls.ColumnDefinition.Width%2A> столбца, который содержит <xref:System.Windows.Controls.GridSplitter> для <xref:System.Windows.GridLength.Auto%2A>.  
  
 В следующем примере показано, как определить вертикальный <xref:System.Windows.Controls.GridSplitter> который занимает столбец и изменяет размеры столбцов с любой стороны от его.  
  
 [!code-xaml[GridSplitterRowColumn#GridSplitterEntireColumnPart1](~/samples/snippets/csharp/VS_Snippets_Wpf/GridSplitterRowColumn/CS/Window1.xaml#gridsplitterentirecolumnpart1)]  
[!code-xaml[GridSplitterRowColumn#GridSplitterEntireColumnPart2](~/samples/snippets/csharp/VS_Snippets_Wpf/GridSplitterRowColumn/CS/Window1.xaml#gridsplitterentirecolumnpart2)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.GridSplitter>
- [Практические руководства](gridsplitter-how-to-topics.md)

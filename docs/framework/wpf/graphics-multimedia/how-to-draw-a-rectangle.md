---
title: Практическое руководство. Рисование прямоугольника
ms.date: 03/30/2017
helpviewer_keywords:
- drawing [WPF], rectangles
- graphics [WPF], rectangles
- rectangles [WPF], drawing
ms.assetid: beeb57ef-fab5-4446-a38a-1588f97b4c2f
ms.openlocfilehash: 261026b994b432565928b38ff1657115ff7cbe4e
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59217358"
---
# <a name="how-to-draw-a-rectangle"></a>Практическое руководство. Рисование прямоугольника
В этом примере показано, как рисование прямоугольника с помощью <xref:System.Windows.Shapes.Rectangle> элемент.  
  
 Чтобы нарисовать прямоугольник, создайте <xref:System.Windows.Shapes.Rectangle> элемент и указать его <xref:System.Windows.FrameworkElement.Width%2A> и <xref:System.Windows.FrameworkElement.Height%2A>. Чтобы рисовать внутри прямоугольника, задайте его <xref:System.Windows.Shapes.Shape.Fill%2A>. Чтобы предоставить контур прямоугольника, используйте его <xref:System.Windows.Shapes.Shape.Stroke%2A> и <xref:System.Windows.Shapes.Shape.StrokeThickness%2A> свойства.  
  
 Чтобы предоставить прямоугольника скругленные углы, укажите необязательное <xref:System.Windows.Shapes.Rectangle.RadiusX%2A> и <xref:System.Windows.Shapes.Rectangle.RadiusY%2A> свойства. <xref:System.Windows.Shapes.Rectangle.RadiusX%2A> И <xref:System.Windows.Shapes.Rectangle.RadiusY%2A> свойства заданы радиусы осей x и y для эллипса, который используется для скругления углов прямоугольника.  
  
 В следующем примере два <xref:System.Windows.Shapes.Rectangle> рисования элементов <xref:System.Windows.Controls.Canvas>. Первый прямоугольник имеет <xref:System.Windows.Media.Brushes.Blue%2A> внутренними. Второй прямоугольник имеет <xref:System.Windows.Media.Brushes.Blue%2A> внутренних, <xref:System.Windows.Media.Brushes.Black%2A> структуры и скругленными углами.  
  
## <a name="example"></a>Пример  
 [!code-xaml[drawingwithshapeelements#Rectangle1](~/samples/snippets/csharp/VS_Snippets_Wpf/DrawingWithShapeElements/CS/rectangleexample.xaml#rectangle1)]  
  
 Несмотря на то, что в этом примере используется <xref:System.Windows.Controls.Canvas> должен содержать прямоугольники, можно использовать прямоугольник элементов (и все остальные элементы фигуры) с любым <xref:System.Windows.Controls.Panel> или <xref:System.Windows.Controls.Control> , поддерживающий нетекстовое содержимое. На самом деле, прямоугольников особенно полезны для обеспечения части фон <xref:System.Windows.Controls.Grid> панелей. Например, см. в разделе [Общие сведения о таблицах](../advanced/table-overview.md).  
  
 Этот пример является частью большего примера; Полный пример см. в разделе [пример элементов-фигур](https://go.microsoft.com/fwlink/?LinkID=160037).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Shapes.Rectangle>
- [Пример элементов-фигур](https://go.microsoft.com/fwlink/?LinkID=160037)
- [Обзор фигур и базовых средств рисования в приложении WPF](shapes-and-basic-drawing-in-wpf-overview.md)
- [Общие сведения о таблицах](../advanced/table-overview.md)

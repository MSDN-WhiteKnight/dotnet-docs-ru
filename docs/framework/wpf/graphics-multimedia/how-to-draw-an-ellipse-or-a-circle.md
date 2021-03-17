---
title: Практическое руководство. Рисование эллипса или круга
ms.date: 03/30/2017
helpviewer_keywords:
- ellipses [WPF], drawing
- circles [WPF], drawing
- drawing circles [WPF]
- drawing ellipses [WPF]
- graphics [WPF], drawing circles
- graphics [WPF], drawing ellipses
ms.assetid: 99763b8c-bfc8-44be-8231-8a70daf5481a
ms.openlocfilehash: 1393e158c1787dc7d4e44e5e1c90ed2e65666dc3
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59146748"
---
# <a name="how-to-draw-an-ellipse-or-a-circle"></a>Практическое руководство. Рисование эллипса или круга
В этом примере показано, как рисование эллипсов и кругов с помощью <xref:System.Windows.Shapes.Ellipse> элемент. Чтобы нарисовать эллипс, создайте <xref:System.Windows.Shapes.Ellipse> элемент и указать его <xref:System.Windows.FrameworkElement.Width%2A> и <xref:System.Windows.FrameworkElement.Height%2A>. Используйте его <xref:System.Windows.Shapes.Shape.Fill%2A> свойство, чтобы указать <xref:System.Windows.Media.Brush> , используемый для закрашивания внутренней части эллипса. Используйте его <xref:System.Windows.Shapes.Shape.Stroke%2A> свойство, чтобы указать <xref:System.Windows.Media.Brush> , используемый для рисования контура эллипса. <xref:System.Windows.Shapes.Shape.StrokeThickness%2A> Свойство задает толщину контура эллипса.  
  
 Чтобы нарисовать окружность, <xref:System.Windows.FrameworkElement.Width%2A> и <xref:System.Windows.FrameworkElement.Height%2A> из <xref:System.Windows.Shapes.Ellipse> элемент, равный друг с другом.  
  
 В следующем примере рисуется четыре <xref:System.Windows.Shapes.Ellipse> элементы внутри <xref:System.Windows.Controls.Canvas>.  
  
## <a name="example"></a>Пример  
 [!code-xaml[drawingwithshapeelements#EllipseExample1](~/samples/snippets/csharp/VS_Snippets_Wpf/DrawingWithShapeElements/CS/ellipseexample.xaml#ellipseexample1)]  
  
 Несмотря на то, что в этом примере используется <xref:System.Windows.Controls.Canvas> должен содержать кнопку с многоточием, можно использовать элементы эллипса (и все остальные элементы фигуры) с любым <xref:System.Windows.Controls.Panel> или <xref:System.Windows.Controls.Control> , поддерживающий нетекстовое содержимое.  
  
 Этот пример является частью большего примера; Полный пример см. в разделе [пример элементов-фигур](https://go.microsoft.com/fwlink/?LinkID=160037).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Shapes.Ellipse>
- <xref:System.Windows.Shapes.Shape>
- [Пример элементов-фигур](https://go.microsoft.com/fwlink/?LinkID=160037)

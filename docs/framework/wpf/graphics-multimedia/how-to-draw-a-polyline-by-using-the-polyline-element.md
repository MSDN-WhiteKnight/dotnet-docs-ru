---
title: Практическое руководство. Рисование ломаной с помощью элемента Polyline
ms.date: 03/30/2017
helpviewer_keywords:
- connected lines [WPF]
- polylines [WPF], drawing
- graphics [WPF], polylines
- lines [WPF], connected (see polylines)
- drawing [WPF], polylines
ms.assetid: 65db8935-d047-4295-87c4-b427ff3ad293
ms.openlocfilehash: 4f55ecc206be0ef4947923047e796c36131c70ec
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59114850"
---
# <a name="how-to-draw-a-polyline-by-using-the-polyline-element"></a>Практическое руководство. Рисование ломаной с помощью элемента Polyline
В этом примере показано, как рисование ломаной, которая представляет собой последовательность соединенных линий, с помощью <xref:System.Windows.Shapes.Polyline> элемент.  
  
 Чтобы Рисование ломаной, создайте <xref:System.Windows.Shapes.Polyline> элемента и использование его <xref:System.Windows.Shapes.Polyline.Points%2A> свойство, чтобы указать вершины фигуры. Наконец, используйте <xref:System.Windows.Shapes.Shape.Stroke%2A> и <xref:System.Windows.Shapes.Shape.StrokeThickness%2A> свойств, описывающих ломаной линии структуры, так как в строку без штриха является невидимым.  
  
> [!NOTE]
>  Так как <xref:System.Windows.Shapes.Polyline> элемент не является замкнутой фигуры, <xref:System.Windows.Shapes.Shape.Fill%2A> не оказывает никакого влияния, даже если намеренно закрыть контура фигуры. Для создания замкнутой фигуры с <xref:System.Windows.Shapes.Shape.Fill%2A>, использовать <xref:System.Windows.Shapes.Polygon> элемент.  
  
 В следующем примере рисуется два <xref:System.Windows.Shapes.Polyline> элементов внутри <xref:System.Windows.Controls.Canvas>.  
  
## <a name="example"></a>Пример  
 В [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)], допустимым синтаксисом для точек является список с разделителями запятыми координат x и y пар.  
  
 [!code-xaml[drawingwithshapeelements#PolylineExample1](~/samples/snippets/csharp/VS_Snippets_Wpf/DrawingWithShapeElements/CS/polylineexample.xaml#polylineexample1)]  
  
 Несмотря на то, что в этом примере используется <xref:System.Windows.Controls.Canvas> должен содержать ломаные линии, можно использовать элементы polyline (и все остальные элементы фигуры) с любым <xref:System.Windows.Controls.Panel> или <xref:System.Windows.Controls.Control> , поддерживающий нетекстовое содержимое.  
  
 Этот пример является частью большего примера; Полный пример см. в разделе [пример элементов-фигур](https://go.microsoft.com/fwlink/?LinkID=160037).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Shapes.Polyline>
- <xref:System.Windows.Shapes.Polygon>
- <xref:System.Windows.Shapes.Shape>
- [Пример элементов-фигур](https://go.microsoft.com/fwlink/?LinkID=160037)
- [Обзор фигур и базовых средств рисования в приложении WPF](shapes-and-basic-drawing-in-wpf-overview.md)

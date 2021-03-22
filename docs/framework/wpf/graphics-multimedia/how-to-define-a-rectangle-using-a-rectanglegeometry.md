---
title: Практическое руководство. Определение прямоугольника с помощью объекта RectangleGeometry
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- graphics [WPF], rectangles
- rectangles [WPF], creating with RectangleGeometry class
ms.assetid: e40b8a8e-54b8-416b-a9f2-be6dca9fdf0b
ms.openlocfilehash: 146ca7017ee38ad5c1065e59662ac441e7bfbfe2
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59075800"
---
# <a name="how-to-define-a-rectangle-using-a-rectanglegeometry"></a>Практическое руководство. Определение прямоугольника с помощью объекта RectangleGeometry
В этом примере описывается использование <xref:System.Windows.Media.RectangleGeometry> класс, который описывает прямоугольник.  
  
## <a name="example"></a>Пример  
 В следующем примере показано, как создать и отобразить <xref:System.Windows.Media.RectangleGeometry>.  Относительное положение и размеры прямоугольника определяются <xref:System.Windows.Rect> структуры. Относительное положение — `50,50` и высота и ширина — `25` создает квадрат. Прямоугольник закрашивается кистью <xref:System.Windows.Media.Brushes.LemonChiffon%2A> кисть и его контура отрисовывается с <xref:System.Windows.Media.Brushes.Black%2A> штриха с толщиной, равной `1`.  
  
 [!code-xaml[GeometryOverviewSamples_snip#GraphicsMMRectangleGeometryExample](~/samples/snippets/csharp/VS_Snippets_Wpf/GeometryOverviewSamples_snip/CS/GeometryExamples.xaml#graphicsmmrectanglegeometryexample)]  
  
 [!code-csharp[GeometryOverviewSamples_procedural_snip#GraphicsMMRectangleGeometryExample](~/samples/snippets/csharp/VS_Snippets_Wpf/GeometryOverviewSamples_procedural_snip/CSharp/GeometryExamples.cs#graphicsmmrectanglegeometryexample)]
   
  
 ![Практическое руководство](./media/graphicsmm-rectangle.gif "graphicsmm_rectangle")  
RectangleGeometry  
  
 Несмотря на то, что в этом примере используется <xref:System.Windows.Shapes.Path> элемента для визуализации <xref:System.Windows.Media.RectangleGeometry>, существует много способов использовать <xref:System.Windows.Media.RectangleGeometry> объектов. Например <xref:System.Windows.Media.RectangleGeometry> может использоваться для указания <xref:System.Windows.UIElement.Clip%2A> из <xref:System.Windows.UIElement> или <xref:System.Windows.Media.GeometryDrawing.Geometry%2A> из <xref:System.Windows.Media.GeometryDrawing>.  
  
 Другие простые геометрические классы включают <xref:System.Windows.Media.LineGeometry> и <xref:System.Windows.Media.EllipseGeometry>. Эти геометрические объекты, а также более сложные, могут также создаваться с использованием <xref:System.Windows.Media.PathGeometry> или <xref:System.Windows.Media.StreamGeometry>.  
  
## <a name="see-also"></a>См. также

- [Общие сведения о классе Geometry](geometry-overview.md)
- [Создание составной фигуры](how-to-create-a-composite-shape.md)
- [Создание фигуры с помощью объекта PathGeometry](how-to-create-a-shape-by-using-a-pathgeometry.md)

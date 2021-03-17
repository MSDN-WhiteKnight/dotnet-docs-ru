---
title: Практическое руководство. Создание фигуры с помощью объекта PathGeometry
ms.date: 03/30/2017
helpviewer_keywords:
- shapes [WPF], creating with PathGeometry class
- graphics [WPF], shapes
ms.assetid: 49a4a8b7-e738-45be-8dac-b54a6d8f5b21
ms.openlocfilehash: b0ab703596612524881ab892a1095b0f49cd1551
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59159319"
---
# <a name="how-to-create-a-shape-by-using-a-pathgeometry"></a>Практическое руководство. Создание фигуры с помощью объекта PathGeometry
В этом примере демонстрируется создание фигуры с помощью <xref:System.Windows.Media.PathGeometry> класса. <xref:System.Windows.Media.PathGeometry> объекты состоят из одного или нескольких <xref:System.Windows.Media.PathFigure> объектов, каждый из которых <xref:System.Windows.Media.PathFigure> представляет различные «рисунок» или фигуры. Каждый <xref:System.Windows.Media.PathFigure> состоит из одного или нескольких <xref:System.Windows.Media.PathSegment> объектов, каждый из которых представляет переходную часть фигуры. Типы сегментов включают <xref:System.Windows.Media.LineSegment>, <xref:System.Windows.Media.ArcSegment>, и <xref:System.Windows.Media.BezierSegment>.  
  
## <a name="example"></a>Пример  
 В следующем примере используется <xref:System.Windows.Media.PathGeometry> для образования треугольника. <xref:System.Windows.Media.PathGeometry> Отображается с использованием <xref:System.Windows.Shapes.Path> элемент.  
  
 [!code-xaml[GeometrySample#49](~/samples/snippets/csharp/VS_Snippets_Wpf/GeometrySample/CS/pathgeometryexample.xaml#49)]  
  
 На следующем рисунке показана фигура, созданная в предыдущем примере.  
  
 ![PathGeometry](./media/wcpsdk-graphicsmm-pathgeometry-triangle.gif "wcpsdk_graphicsmm_pathgeometry_triangle")  
Треугольник, созданных с помощью PathGeometry  
  
 В предыдущем примере показан способ создания относительно простой фигуры, треугольника. Объект <xref:System.Windows.Media.PathGeometry> можно также использовать для создания более сложных фигур, включая дуги и кривые. Примеры, см. в разделе [Создание эллиптической дуги](how-to-create-an-elliptical-arc.md), [Создание кривой Безье третьего порядка](how-to-create-a-cubic-bezier-curve.md), и [Создание кривой Безье второго порядка](how-to-create-a-quadratic-bezier-curve.md).  
  
 Этот пример является частью большего примера; полный пример см. в разделе [Пример геометрических объектов](https://go.microsoft.com/fwlink/?LinkID=159989).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Shapes.Path>
- <xref:System.Windows.Media.GeometryDrawing>
- [Общие сведения о классе Geometry](geometry-overview.md)
- [Примеры геометрических объектов](https://go.microsoft.com/fwlink/?LinkID=159989)

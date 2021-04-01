---
title: Практическое руководство. Создание кривой Безье третьего порядка
ms.date: 03/30/2017
helpviewer_keywords:
- curves [WPF], cubic Bezier
- Bezier curves [WPF], cubic
- graphics [WPF], cubic Bezier curves
- cubic Bezier curves [WPF]
ms.assetid: 450a3a77-7c57-48b0-a008-0f6051add980
ms.openlocfilehash: 36544abc774b7fe82c2ff47483cfedd6fb13e344
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59115574"
---
# <a name="how-to-create-a-cubic-bezier-curve"></a>Практическое руководство. Создание кривой Безье третьего порядка
В этом примере демонстрируется создание кривой Безье третьего порядка. Создание кривой Безье третьего порядка, используйте <xref:System.Windows.Media.PathGeometry>, <xref:System.Windows.Media.PathFigure>, и <xref:System.Windows.Media.BezierSegment> классы.  Чтобы отобразить результирующей геометрии, используйте <xref:System.Windows.Shapes.Path> элемент, или использовать их с <xref:System.Windows.Media.GeometryDrawing> или <xref:System.Windows.Media.DrawingContext>. В следующих примерах, соединяющей кривой Безье третьего порядка (10, 100) для (300, 100). Кривая имеет контрольные точки (100, 0) и (200, 200).  
  
## <a name="example"></a>Пример  
 [xaml]  
  
 В XAML, можно использовать сокращенный синтаксис разметки для описания пути.  
  
 [!code-xaml[GeometrySample#53](~/samples/snippets/csharp/VS_Snippets_Wpf/GeometrySample/CS/geometryattributesyntaxexample.xaml#53)]  
  
 [xaml]  
  
 В XAML, также можно рисовать кривую Безье третьего порядка, с помощью тегов объектов. Следующий пример эквивалентен предыдущему примеру XAML.  
  
 [!code-xaml[GeometrySample#33](~/samples/snippets/csharp/VS_Snippets_Wpf/GeometrySample/CS/pathgeometryexample.xaml#33)]  
  
 Этот пример является частью большего примера; полный пример см. в разделе [Пример геометрических объектов](https://go.microsoft.com/fwlink/?LinkID=159989).  
  
## <a name="see-also"></a>См. также

- [Создание эллиптической дуги](how-to-create-an-elliptical-arc.md)
- [Создание LineSegment в PathGeometry](how-to-create-a-linesegment-in-a-pathgeometry.md)
- [Создание кривой Безье третьего порядка](how-to-create-a-cubic-bezier-curve.md)
- [Создание кривой Безье второго порядка](how-to-create-a-quadratic-bezier-curve.md)

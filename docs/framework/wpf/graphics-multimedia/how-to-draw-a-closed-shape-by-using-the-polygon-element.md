---
title: Практическое руководство. Рисование замкнутой фигуры с помощью элемента "Многоугольник"
ms.date: 03/30/2017
helpviewer_keywords:
- graphics [WPF], Polygon elements
- closed shapes [WPF], drawing with Polygon elements
- Polygon elements [WPF]
- drawing [WPF], closed shapes with Polygon elements
ms.assetid: 4b0ca008-29ce-48dd-8bc3-f3a20ffca6a6
ms.openlocfilehash: 533c341e2fae528ec896bf38bafa13974af1d127
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57360047"
---
# <a name="how-to-draw-a-closed-shape-by-using-the-polygon-element"></a>Практическое руководство. Рисование замкнутой фигуры с помощью элемента "Многоугольник"
В этом примере показано, как Рисование замкнутой фигуры с помощью <xref:System.Windows.Shapes.Polygon> элемент. Чтобы Рисование замкнутой фигуры, создайте <xref:System.Windows.Shapes.Polygon> элемента и использование его <xref:System.Windows.Shapes.Polygon.Points%2A> свойство, чтобы указать вершины фигуры. Автоматически отображается линия, соединяющая точки первого и последнего. Наконец, укажите <xref:System.Windows.Shapes.Shape.Fill%2A>, <xref:System.Windows.Shapes.Shape.Stroke%2A>, или оба.  
  
## <a name="example"></a>Пример  
 В [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)], допустимым синтаксисом для точек является список с разделителями запятыми координат x и y пар.  
  
 [!code-xaml[drawingwithshapeelements#PolygonExample1](~/samples/snippets/csharp/VS_Snippets_Wpf/DrawingWithShapeElements/CS/polygonexample.xaml#polygonexample1)]  
  
 Несмотря на то, что в примере используется <xref:System.Windows.Controls.Canvas> для хранения многоугольников, можно использовать элементы многоугольника (и все остальные элементы фигуры) с любым <xref:System.Windows.Controls.Panel> или <xref:System.Windows.Controls.Control> , поддерживающий нетекстовое содержимое.  
  
 Этот пример является частью большего примера; Полный пример см. в разделе [пример элементов-фигур](https://go.microsoft.com/fwlink/?LinkID=160037).

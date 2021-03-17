---
title: Практическое руководство. Изменение завершения отрезка в конце линии или сегмента
ms.date: 03/30/2017
helpviewer_keywords:
- Shape elements [WPF], ends
- Shape elements [WPF], caps
- graphics [WPF], Shape caps
ms.assetid: f4bf3416-b3d8-4568-b98e-3eda8f6dbf7a
ms.openlocfilehash: 462e32520393a1c23809cce8eb3c130c13bc882f
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59091308"
---
# <a name="how-to-modify-the-cap-at-the-end-of-a-line-or-segment"></a>Практическое руководство. Изменение завершения отрезка в конце линии или сегмента
В этом примере показано, как способы изменения фигуры в начале или конце открытой <xref:System.Windows.Shapes.Shape> элемент. Изменение завершения отрезка в начале открытой <xref:System.Windows.Shapes.Shape>, использовать его <xref:System.Windows.Shapes.Shape.StrokeStartLineCap%2A> свойство. Изменение завершения отрезка в конце открытой <xref:System.Windows.Shapes.Shape>, использовать его <xref:System.Windows.Shapes.Shape.StrokeEndLineCap%2A> свойство. Для просмотра доступных отрезков, см. в разделе <xref:System.Windows.Media.PenLineCap> перечисления.  
  
> [!NOTE]
>  Это свойство влияет только на открытые фигуры, такие как <xref:System.Windows.Shapes.Line>, <xref:System.Windows.Shapes.Polyline>, или открытый <xref:System.Windows.Shapes.Path> элемент.  
  
 В следующем примере рисуется четыре <xref:System.Windows.Shapes.Polyline> элементы и использует другой набор фигур на концах каждого из них.  
  
## <a name="example"></a>Пример  
 [!code-xaml[drawingwithshapeelements#ShapeLineCaps1](~/samples/snippets/csharp/VS_Snippets_Wpf/DrawingWithShapeElements/CS/linecapsandjoinsexample.xaml#shapelinecaps1)]  
  
 Этот пример является частью большего примера; Полный пример см. в разделе [пример элементов-фигур](https://go.microsoft.com/fwlink/?LinkID=160037).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Shapes.Polyline>
- <xref:System.Windows.Media.PenLineCap>

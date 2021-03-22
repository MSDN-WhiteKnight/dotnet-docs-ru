---
title: Практическое руководство. Создание линии с помощью объекта LineGeometry
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- graphics [WPF], lines
ms.assetid: 41231b22-1f74-4c26-a8e7-a55b29f8f6bd
ms.openlocfilehash: f8c334a54f78aec7af91064a447fd18f23dcfbdc
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59123062"
---
# <a name="how-to-create-a-line-using-a-linegeometry"></a>Практическое руководство. Создание линии с помощью объекта LineGeometry
В этом примере показано, как использовать <xref:System.Windows.Media.LineGeometry> класс, который описывает строку. Объект <xref:System.Windows.Media.LineGeometry> определяется его начальную и конечную точки.  
  
## <a name="example"></a>Пример  
 В следующем примере показано, как создать и отобразить <xref:System.Windows.Media.LineGeometry>.  Объект <xref:System.Windows.Shapes.Path> элемент используется для отображения линии.  Поскольку линия не имеет площади, <xref:System.Windows.Shapes.Path> объекта <xref:System.Windows.Shapes.Shape.Fill%2A> не задан; вместо этого <xref:System.Windows.Shapes.Shape.Stroke%2A> и <xref:System.Windows.Shapes.Shape.StrokeThickness%2A> используются свойства.  
  
 [!code-xaml[GeometryOverviewSamples_snip#GraphicsMMLineGeometryExample](~/samples/snippets/csharp/VS_Snippets_Wpf/GeometryOverviewSamples_snip/CS/GeometryExamples.xaml#graphicsmmlinegeometryexample)]  
  
 [!code-csharp[GeometryOverviewSamples_procedural_snip#GraphicsMMLineGeometryExample](~/samples/snippets/csharp/VS_Snippets_Wpf/GeometryOverviewSamples_procedural_snip/CSharp/GeometryExamples.cs#graphicsmmlinegeometryexample)]
   
  
 ![LineGeometry](./media/graphicsmm-line.gif "graphicsmm_line")  
Объект LineGeometry, соединяющий точки (10,20) и (100,130)  
  
 Другие простые геометрические классы включают <xref:System.Windows.Media.LineGeometry> и <xref:System.Windows.Media.EllipseGeometry>. Эти геометрические объекты, а также более сложные, могут также создаваться с использованием <xref:System.Windows.Media.PathGeometry> или <xref:System.Windows.Media.StreamGeometry>. Дополнительные сведения см. в разделе [Общие сведения о геометрии](geometry-overview.md).  
  
## <a name="see-also"></a>См. также

- [Общие сведения о классе Geometry](geometry-overview.md)
- [Создание составной фигуры](how-to-create-a-composite-shape.md)
- [Создание фигуры с помощью объекта PathGeometry](how-to-create-a-shape-by-using-a-pathgeometry.md)

---
title: Практическое руководство. Скругление углов объекта RectangleGeometry
ms.date: 03/30/2017
helpviewer_keywords:
- corners [WPF], rounding
- RectangleGeometry class [WPF], rounding corners
- graphics [WPF], rounding corners of RectangleGeometry objects [WPF]
- rounding corners of RectangleGeometry objects [WPF]
ms.assetid: 926644bc-1357-4c0b-ac81-694bd090ae87
ms.openlocfilehash: eb2f173bedb903e12b2795264c684524cfa09825
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59089137"
---
# <a name="how-to-round-the-corners-of-a-rectanglegeometry"></a>Практическое руководство. Скругление углов объекта RectangleGeometry
Для скругления углов <xref:System.Windows.Media.RectangleGeometry>, задайте его <xref:System.Windows.Media.RectangleGeometry.RadiusX%2A> и <xref:System.Windows.Media.RectangleGeometry.RadiusY%2A> свойства в значение больше нуля. Чем больше значения, тем больше радиус скругления углов прямоугольника.  
  
## <a name="example"></a>Пример  
 В следующем примере показано несколько <xref:System.Windows.Media.RectangleGeometry> объектов с разными <xref:System.Windows.Media.RectangleGeometry.RadiusX%2A> и <xref:System.Windows.Media.RectangleGeometry.RadiusY%2A> параметры. <xref:System.Windows.Media.RectangleGeometry> Объекты отображаются с помощью <xref:System.Windows.Shapes.Path> элементов.  
  
 [!code-xaml[GeometryOverviewSamples_snip#GraphicsMMRoundedRectangleGeometryExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/GeometryOverviewSamples_snip/CS/RectangleGeometryRoundedCornerExample.xaml#graphicsmmroundedrectanglegeometryexamplewholepage)]  
  
 ![Прямоугольники с разных RadiusX&#47;RadiusY параметры](./media/graphicsmm-rounded.png "graphicsmm_rounded")  
Прямоугольники с закругленными углами  
  
## <a name="see-also"></a>См. также

- [Общие сведения о классе Geometry](geometry-overview.md)
- [Создание составной фигуры](how-to-create-a-composite-shape.md)
- [Создание фигуры с помощью объекта PathGeometry](how-to-create-a-shape-by-using-a-pathgeometry.md)

---
title: Практическое руководство. Создание составного рисунка
ms.date: 03/30/2017
helpviewer_keywords:
- drawings [WPF], composite
- composite drawings [WPF]
- graphics [WPF], composite drawings
ms.assetid: 066eb0ab-5f0e-439d-85c6-dca60af269fc
ms.openlocfilehash: 0af7fbca593627ebe8cd102a02617a27eac50aa5
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59132474"
---
# <a name="how-to-create-a-composite-drawing"></a>Практическое руководство. Создание составного рисунка
В этом примере показано, как использовать <xref:System.Windows.Media.DrawingGroup> для создания сложных рисунков, объединив несколько <xref:System.Windows.Media.Drawing> объектов в один составной рисунок.  
  
## <a name="example"></a>Пример  
 В следующем примере используется <xref:System.Windows.Media.DrawingGroup> Создание составного рисунка из <xref:System.Windows.Media.GeometryDrawing> и <xref:System.Windows.Media.ImageDrawing> объектов. На следующей иллюстрации показан результат выполнения этого примера.  
  
 ![DrawingGroup с множественными отрисовками](./media/graphicsmm-simple.jpg "graphicsmm_simple")  
Составной рисунок, который создается с помощью DrawingGroup  
  
 Обратите внимание, серую границу, которая обозначает границы рисунка.  
  
 [!code-csharp[DrawingMiscSnippets_snip#GraphicsMMSimpleDrawingGroupExample](~/samples/snippets/csharp/VS_Snippets_Wpf/DrawingMiscSnippets_snip/CSharp/DrawingGroupExample.cs#graphicsmmsimpledrawinggroupexample)]
 [!code-xaml[DrawingMiscSnippets_snip#GraphicsMMSimpleDrawingGroupExample](~/samples/snippets/xaml/VS_Snippets_Wpf/DrawingMiscSnippets_snip/XAML/DrawingGroupExample.xaml#graphicsmmsimpledrawinggroupexample)]  
  
 Можно использовать <xref:System.Windows.Media.DrawingGroup> для применения <xref:System.Windows.Media.DrawingGroup.Transform%2A>, <xref:System.Windows.Media.DrawingGroup.Opacity%2A> параметр <xref:System.Windows.Media.DrawingGroup.OpacityMask%2A>, <xref:System.Windows.Media.DrawingGroup.BitmapEffect%2A>, <xref:System.Windows.Media.DrawingGroup.ClipGeometry%2A>, или <xref:System.Windows.Media.DrawingGroup.GuidelineSet%2A> к рисункам. Так как <xref:System.Windows.Media.DrawingGroup> также <xref:System.Windows.Media.Drawing>, он может содержать другие <xref:System.Windows.Media.DrawingGroup> объектов.  
  
 Следующий пример похож на предыдущий, за исключением того, что она использует дополнительные <xref:System.Windows.Media.DrawingGroup> объектов, чтобы применить эффекты для точечных рисунков и маски непрозрачности к некоторым из его рисунков. На следующей иллюстрации показан результат выполнения этого примера.  
  
 ![DrawingGroup с множественными отрисовками](./media/graphicsmm-multiple.jpg "graphicsmm_multiple")  
Составной рисунок, состоящий из нескольких объектов DrawingGroup  
  
 Обратите внимание, серую границу, которая обозначает границы рисунка.  
  
 [!code-csharp[DrawingMiscSnippets_snip#GraphicsMMMultipleDrawingGroupsExample](~/samples/snippets/csharp/VS_Snippets_Wpf/DrawingMiscSnippets_snip/CSharp/DrawingGroupExample.cs#graphicsmmmultipledrawinggroupsexample)]
 [!code-xaml[DrawingMiscSnippets_snip#GraphicsMMMultipleDrawingGroupsExample](~/samples/snippets/xaml/VS_Snippets_Wpf/DrawingMiscSnippets_snip/XAML/DrawingGroupExample.xaml#graphicsmmmultipledrawinggroupsexample)]  
  
 Дополнительные сведения о <xref:System.Windows.Media.Drawing> объектов, см. в разделе [Обзор объектов Drawing](drawing-objects-overview.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.DrawingGroup.BitmapEffect%2A>
- <xref:System.Windows.Media.DrawingGroup.Transform%2A>
- <xref:System.Windows.Media.DrawingGroup.OpacityMask%2A>
- <xref:System.Windows.Media.DrawingGroup.Opacity%2A>
- <xref:System.Windows.Media.DrawingGroup.ClipGeometry%2A>
- <xref:System.Windows.Media.DrawingGroup.GuidelineSet%2A>
- [Обзор объектов Drawing](drawing-objects-overview.md)

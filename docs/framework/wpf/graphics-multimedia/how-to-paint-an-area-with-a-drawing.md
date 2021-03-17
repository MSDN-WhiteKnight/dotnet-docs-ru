---
title: Практическое руководство. Закрашивание области с помощью Drawing
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- brushes [WPF], painting with drawings
- painting [WPF], with drawings
- drawings [WPF], painting with
ms.assetid: c10dc4b1-09b1-41e8-ad14-456b5fb377df
ms.openlocfilehash: 6b204ae631912181333e2559ebadcdc37e7693b7
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57371567"
---
# <a name="how-to-paint-an-area-with-a-drawing"></a>Практическое руководство. Закрашивание области с помощью Drawing
Этот пример показывает, как можно закрасить область рисунком. Чтобы закрасить область рисунком, используйте <xref:System.Windows.Media.DrawingBrush> и одного или нескольких <xref:System.Windows.Media.Drawing> объектов.   В следующем примере используется <xref:System.Windows.Media.DrawingBrush> для закраски объекта рисунком из двух эллипсов.  
  
## <a name="example"></a>Пример  
 [!code-xaml[drawingbrush_snip#DrawingBrushExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/drawingbrush_snip/CS/DrawingBrushExample.xaml#drawingbrushexamplewholepage)]  
  
 [!code-csharp[drawingbrush_procedural_snip#DrawingBrushExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/drawingbrush_procedural_snip/CSharp/DrawingBrushExample.cs#drawingbrushexamplewholepage)]
 [!code-vb[drawingbrush_procedural_snip#DrawingBrushExampleWholePage](~/samples/snippets/visualbasic/VS_Snippets_Wpf/drawingbrush_procedural_snip/VisualBasic/DrawingBrushExample.vb#drawingbrushexamplewholepage)]  
  
 На следующем рисунке показан результат выполнения этого примера.  
  
 ![Результат DrawingBrush](./media/graphicsmm-drawingbrush-simple.png "graphicsmm_drawingbrush_simple")  
  
 (Центр фигуры белого, по причинам, описанным в [управление заливкой составных фигур](how-to-control-the-fill-of-a-composite-shape.md).)  
  
 Установив <xref:System.Windows.Media.DrawingBrush> объекта <xref:System.Windows.Media.TileBrush.Viewport%2A> и <xref:System.Windows.Media.TileBrush.TileMode%2A> свойства, можно создать повторяющийся шаблон. Следующий пример выполняет заливку объекта шаблоном, созданным рисунком из двух эллипсов.  
  
 [!code-xaml[drawingbrush_snip#TiledDrawingBrushExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/drawingbrush_snip/CS/TiledDrawingBrushExample.xaml#tileddrawingbrushexamplewholepage)]  
  
 [!code-csharp[drawingbrush_procedural_snip#TiledDrawingBrushExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/drawingbrush_procedural_snip/CSharp/TiledDrawingBrushExample.cs#tileddrawingbrushexamplewholepage)]
 [!code-vb[drawingbrush_procedural_snip#TiledDrawingBrushExampleWholePage](~/samples/snippets/visualbasic/VS_Snippets_Wpf/drawingbrush_procedural_snip/VisualBasic/TiledDrawingBrushExample.vb#tileddrawingbrushexamplewholepage)]  
  
 На следующем рисунке показан мозаичный <xref:System.Windows.Media.DrawingBrush> выходных данных.  
  
 ![Мозаичный результат работы DrawingBrush](./media/graphicsmm-drawingbrush-tiled.png "graphicsmm_drawingbrush_tiled")  
  
 Дополнительные сведения о кистях для рисования см. в разделе [Рисование с помощью изображений, рисунков и визуальных элементов](painting-with-images-drawings-and-visuals.md). Дополнительные сведения о <xref:System.Windows.Media.Drawing> объектов, см. в разделе [Обзор объектов Drawing](drawing-objects-overview.md).

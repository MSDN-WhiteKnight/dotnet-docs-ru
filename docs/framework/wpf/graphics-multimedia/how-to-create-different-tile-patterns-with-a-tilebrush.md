---
title: Практическое руководство. Создание различных шаблонов мозаики с помощью TileBrush
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- TileBrush [WPF], creating tile patterns
- tile patterns [WPF], creating
- creating [WPF], tile patterns with TileBrush
ms.assetid: 5aa46632-3527-4668-9d8d-0375c8af28aa
ms.openlocfilehash: c1051b234961eee9ae740af2abac3d64c523656c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59227409"
---
# <a name="how-to-create-different-tile-patterns-with-a-tilebrush"></a>Практическое руководство. Создание различных шаблонов мозаики с помощью TileBrush
В этом примере показано, как использовать <xref:System.Windows.Media.TileBrush.TileMode%2A> свойство <xref:System.Windows.Media.TileBrush> для создания шаблона.  
  
 <xref:System.Windows.Media.TileBrush.TileMode%2A> Свойство позволяет указать, как содержимое <xref:System.Windows.Media.TileBrush> является повторяется, то есть, мозаикой для заполнения области вывода. Чтобы создать шаблон, необходимо задать <xref:System.Windows.Media.TileBrush.TileMode%2A> для <xref:System.Windows.Media.TileMode.Tile>, <xref:System.Windows.Media.TileMode.FlipX>, <xref:System.Windows.Media.TileMode.FlipY>, или <xref:System.Windows.Media.TileMode.FlipXY>. Необходимо также задать <xref:System.Windows.Media.TileBrush.Viewport%2A> из <xref:System.Windows.Media.TileBrush> , чтобы он был меньше, чем область закрашивания; в противном случае только одна Плитка производству, независимо от того, который <xref:System.Windows.Media.TileBrush.TileMode%2A> используется параметр.  
  
## <a name="example"></a>Пример  
 В следующем примере создается пять <xref:System.Windows.Media.DrawingBrush> объекты, дает им каждый отдельный <xref:System.Windows.Media.TileBrush.TileMode%2A> параметр и использует их для рисования пяти прямоугольников. Несмотря на то, что в этом примере используется <xref:System.Windows.Media.DrawingBrush> для демонстрации <xref:System.Windows.Media.TileBrush.TileMode%2A> поведение, <xref:System.Windows.Media.TileBrush.TileMode%2A> работает одинаково для всех <xref:System.Windows.Media.TileBrush> объектов, то есть для <xref:System.Windows.Media.ImageBrush>, <xref:System.Windows.Media.VisualBrush>, и <xref:System.Windows.Media.DrawingBrush>.  
  
 На следующей иллюстрации показан результат выполнения этого примера.  
  
 ![TileBrush мозаичного заполнения пример выходных данных](./media/graphicsmm-drawingbrushtilemodeexample.png "graphicsmm_DrawingBrushTileModeExample")  
Шаблоны мозаики, созданные с помощью свойства TileMode  
  
 [!code-csharp[BrushesIntroduction_snip#GraphicsMMDrawingBrushTileModeExample](~/samples/snippets/csharp/VS_Snippets_Wpf/BrushesIntroduction_snip/CSharp/TileModeExample.cs#graphicsmmdrawingbrushtilemodeexample)]
 
 [!code-xaml[BrushesIntroduction_snip#GraphicsMMDrawingBrushTileModeExample](~/samples/snippets/xaml/VS_Snippets_Wpf/BrushesIntroduction_snip/XAML/TileModeExample.xaml#graphicsmmdrawingbrushtilemodeexample)]  
  
## <a name="see-also"></a>См. также

- [Установка размера плитки для объекта TileBrush](how-to-set-the-tile-size-for-a-tilebrush.md)
- [Рисование с помощью объектов Image, Drawing и Visual](painting-with-images-drawings-and-visuals.md)

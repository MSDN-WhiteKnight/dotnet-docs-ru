---
title: Практическое руководство. Заливка области с помощью видео
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- painting with a video [WPF]
- video [WPF], painting with
- brushes [WPF], painting with a video
ms.assetid: 04dd6600-4a6e-4b43-a93e-21cce7dfbcb8
ms.openlocfilehash: be09d1310847cd7214ea795a704c25d994f07b7a
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59151181"
---
# <a name="how-to-paint-an-area-with-a-video"></a>Практическое руководство. Заливка области с помощью видео
В этом примере показано, как заливка области с медиа-носителями. Закраска области с медиа-носителями один из способов является использование <xref:System.Windows.Controls.MediaElement> вместе с <xref:System.Windows.Media.VisualBrush>. Используйте <xref:System.Windows.Controls.MediaElement> для загрузки и воспроизведения мультимедиа и затем использовать его для задания <xref:System.Windows.Media.VisualBrush.Visual%2A> свойство <xref:System.Windows.Media.VisualBrush>. Затем можно использовать <xref:System.Windows.Media.VisualBrush> для закраски области с загруженным мультимедиа.  
  
## <a name="example"></a>Пример  
 В следующем примере используется <xref:System.Windows.Controls.MediaElement> и <xref:System.Windows.Media.VisualBrush> для закрашивания <xref:System.Windows.Controls.TextBlock.Foreground%2A> из <xref:System.Windows.Controls.TextBlock> элемента управления с видео. В этом примере устанавливается <xref:System.Windows.Controls.MediaElement.IsMuted%2A> свойство <xref:System.Windows.Controls.MediaElement> для `true` таким образом, чтобы отключить звук.  
  
 [!code-csharp[Visualbrush_markup_snip#GraphicsMMVideoAsTextBackgroundInline](~/samples/snippets/csharp/VS_Snippets_Wpf/visualbrush_markup_snip/CSharp/PaintWithVideoExample.cs#graphicsmmvideoastextbackgroundinline)]
 
 [!code-xaml[Visualbrush_markup_snip#GraphicsMMVideoAsTextBackgroundInline](~/samples/snippets/xaml/VS_Snippets_Wpf/visualbrush_markup_snip/XAML/PaintWithVideoExample.xaml#graphicsmmvideoastextbackgroundinline)]  
  
## <a name="example"></a>Пример  
 Так как <xref:System.Windows.Media.VisualBrush> наследует от <xref:System.Windows.Media.TileBrush> класс, он предоставляет несколько режимов заполнения. Установив <xref:System.Windows.Media.TileBrush.TileMode%2A> свойство <xref:System.Windows.Media.VisualBrush> для <xref:System.Windows.Media.TileMode.Tile> и установив его <xref:System.Windows.Media.TileBrush.Viewport%2A> свойства со значением меньше, чем область закрашивания, можно создать шаблон заполнения.  
  
 Следующий пример идентичен предыдущему примеру, за исключением случаев, <xref:System.Windows.Media.VisualBrush> создает шаблон из видео.  
  
 [!code-csharp[Visualbrush_markup_snip#GraphicsMMVideoAsTextBackgroundTiledInline](~/samples/snippets/csharp/VS_Snippets_Wpf/visualbrush_markup_snip/CSharp/PaintWithVideoExample.cs#graphicsmmvideoastextbackgroundtiledinline)]
 
 [!code-xaml[Visualbrush_markup_snip#GraphicsMMVideoAsTextBackgroundTiledInline](~/samples/snippets/xaml/VS_Snippets_Wpf/visualbrush_markup_snip/XAML/PaintWithVideoExample.xaml#graphicsmmvideoastextbackgroundtiledinline)]  
  
 Сведения о том, как добавить файл содержимого, такие как файл мультимедиа в приложение, см. в разделе [ресурса приложения WPF, содержимое и файлы данных](../app-development/wpf-application-resource-content-and-data-files.md). При добавлении файла мультимедиа, необходимо добавить его как файл содержимого, а не как файл ресурсов.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.VisualBrush>
- [Рисование с помощью объектов Image, Drawing и Visual](painting-with-images-drawings-and-visuals.md)
- [Общие сведения о TileBrush](tilebrush-overview.md)
- [Общие сведения о мультимедиа](multimedia-overview.md)

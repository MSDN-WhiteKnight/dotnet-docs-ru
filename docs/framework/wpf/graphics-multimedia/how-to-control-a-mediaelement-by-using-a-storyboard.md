---
title: Практическое руководство. Управление элементом MediaElement с помощью раскадровки
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- multimedia [WPF], controlling playback of media with Storyboards
- controlling playback of media [WPF], with Storyboards
- Storyboards [WPF], controlling playback of media with
- media [WPF], controlling playback with Storyboards
- playback of media [WPF], controlling with Storyboards
ms.assetid: 6128ca77-b826-4e36-b968-6f237157c543
ms.openlocfilehash: ae785e11b1da0f2c408b24021ad46ab071419378
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59100318"
---
# <a name="how-to-control-a-mediaelement-by-using-a-storyboard"></a>Практическое руководство. Управление элементом MediaElement с помощью раскадровки
В этом примере показано, как управлять <xref:System.Windows.Controls.MediaElement> с помощью <xref:System.Windows.Media.MediaTimeline> в <xref:System.Windows.Media.Animation.Storyboard>.  
  
## <a name="example"></a>Пример  
 При использовании <xref:System.Windows.Media.MediaTimeline> в <xref:System.Windows.Media.Animation.Storyboard> для управления временем <xref:System.Windows.Controls.MediaElement>, функциональные возможности идентичны функциям других <xref:System.Windows.Media.Animation.Timeline> объекты, такие как анимации. Например <xref:System.Windows.Media.MediaTimeline> использует <xref:System.Windows.Media.Animation.Timeline> свойства, такие как <xref:System.Windows.Media.Animation.Timeline.BeginTime%2A> свойство, чтобы указать, когда должна запускаться <xref:System.Windows.Controls.MediaElement> (запуск воспроизведения мультимедиа). Он также использует <xref:System.Windows.Media.Animation.Timeline.Duration%2A> свойство, чтобы указать продолжительность <xref:System.Windows.Controls.MediaElement> активен (длительность воспроизведения мультимедиа). Дополнительные сведения об использовании <xref:System.Windows.Media.Animation.Timeline> объекты с <xref:System.Windows.Media.Animation.Storyboard>, см. в разделе [Общие сведения о раскадровках](storyboards-overview.md).  
  
 В этом примере демонстрируется создание простого мультимедийного проигрывателя, использующий <xref:System.Windows.Media.MediaTimeline> для управления воспроизведением. Проигрыватель мультимедиа включает воспроизведения, приостановки, возобновления и остановки кнопок. Проигрыватель также имеет <xref:System.Windows.Controls.Slider> элемент управления, который выступает в качестве индикатор хода выполнения.  
  
 В следующем примере создается UI  для проигрывателя.  
  
 [!code-xaml[MediaGallery_snip#MediaTimelineExampleWholePage](~/samples/snippets/visualbasic/VS_Snippets_Wpf/MediaGallery_snip/VB/MediaTimelineExample.xaml#mediatimelineexamplewholepage)]  
  
 В следующем примере создается функция индикатор хода выполнения.  
  
 [!code-csharp[MediaGallery_snip#CodeBehindMediaTimelineExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/MediaGallery_snip/CSharp/MediaTimelineExample.xaml.cs#codebehindmediatimelineexamplewholepage)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.MediaElement>
- <xref:System.Windows.Media.MediaTimeline>
- <xref:System.Windows.Media.Animation.Storyboard>
- [Управление элементом MediaElement (воспроизведение, пауза, остановка, громкость и скорость)](how-to-control-a-mediaelement-play-pause-stop-volume-and-speed.md)
- [Общие сведения о Storyboard](storyboards-overview.md)
- [Общие сведения об анимации по ключевым кадрам](key-frame-animations-overview.md)
- [Общие сведения об эффектах анимации](animation-overview.md)
- [Практические руководства](audio-and-video-how-to-topics.md)
- [Графика и мультимедиа](index.md)

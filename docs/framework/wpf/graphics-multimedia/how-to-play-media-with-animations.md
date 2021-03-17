---
title: Практическое руководство. Воспроизведение мультимедиа с анимацией
ms.date: 03/30/2017
helpviewer_keywords:
- multimedia [WPF], playback with animations
- playback of media [WPF], with animations
- animation [WPF], media playback with
- media [WPF], playback with animations
ms.assetid: 8982b7b7-1c6c-4b24-8801-b328862975f5
ms.openlocfilehash: 200f9d62c67a02088fe5a5789cdb41a04837d430
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59079907"
---
# <a name="how-to-play-media-with-animations"></a>Практическое руководство. Воспроизведение мультимедиа с анимацией
В этом примере показано, как воспроизвести мультимедиа и анимацию одновременно с помощью <xref:System.Windows.Media.MediaTimeline> и <xref:System.Windows.Media.Animation.DoubleAnimationUsingKeyFrames> классы в одном <xref:System.Windows.Media.Animation.Storyboard>.  
  
## <a name="example"></a>Пример  
 Можно использовать один или несколько <xref:System.Windows.Media.MediaTimeline> объекты в <xref:System.Windows.Media.Animation.Storyboard> другим <xref:System.Windows.Media.Animation.Timeline> объекты, такие как анимации.  
  
 В следующем примере задается <xref:System.Windows.Media.Animation.ParallelTimeline.SlipBehavior%2A> свойство <xref:System.Windows.Media.Animation.Storyboard> значение `Slip`, которое указывает, что анимация не выполняется до выполнения мультимедиа (видео в этом примере). Эта возможность может потребоваться, если воспроизведение мультимедиа задерживается из-за времени загрузки.  
  
 [!code-xaml[MediaGallery_snippet#MediaTimelinePlusAnimationExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/MediaGallery_snippet/CSharp/MediaTimelinePlusAnimationExample.xaml#mediatimelineplusanimationexamplewholepage)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.MediaTimeline>
- <xref:System.Windows.Media.Animation.DoubleAnimationUsingKeyFrames>
- <xref:System.Windows.Media.Animation.Storyboard>
- <xref:System.Windows.Media.Animation.ParallelTimeline.SlipBehavior%2A>
- [Практические руководства](audio-and-video-how-to-topics.md)
- [Общие сведения о Storyboard](storyboards-overview.md)
- [Общие сведения об анимации по ключевым кадрам](key-frame-animations-overview.md)
- [Общие сведения об эффектах анимации](animation-overview.md)
- [Графика и мультимедиа](index.md)

---
title: Практическое руководство. Инициирование воспроизведения мультимедиа с помощью пользовательского события
ms.date: 03/30/2017
helpviewer_keywords:
- synchronizing media playback with events [WPF]
- playback of media [WPF], synchronizing with events
- media [WPF], synchronizing playback with events
- multimedia [WPF], synchronizing media playback with events
ms.assetid: c4dbe632-6e7f-4d7f-9df5-98737a758bc3
ms.openlocfilehash: ae8ba54cc852bb85350492c95e3e890aebf6534f
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59150180"
---
# <a name="how-to-trigger-media-playback-with-a-user-event"></a>Практическое руководство. Инициирование воспроизведения мультимедиа с помощью пользовательского события
В этом примере показано, как синхронизировать воспроизведение мультимедиа с событием.  
  
## <a name="example"></a>Пример  
 В следующем примере используется <xref:System.Windows.Controls.MediaElement> управления и <xref:System.Windows.Media.MediaTimeline> класс для воспроизведения звука, возникающее, когда пользователь щелкает <xref:System.Windows.Controls.Button>.  
  
 [!code-xaml[MediaGallery_snippet#SoundFromUserEventExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/MediaGallery_snippet/CSharp/SoundFromUserEventExample.xaml#soundfromusereventexamplewholepage)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.MediaElement>
- <xref:System.Windows.Media.MediaTimeline>
- <xref:System.Windows.EventTrigger.RoutedEvent%2A>
- <xref:System.Windows.Media.Animation.Storyboard>
- [Практические руководства](audio-and-video-how-to-topics.md)
- [Графика и мультимедиа](index.md)

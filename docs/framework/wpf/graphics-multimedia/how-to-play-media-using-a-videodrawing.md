---
title: Практическое руководство. Воспроизведение мультимедиа с помощью объекта VideoDrawing
ms.date: 03/30/2017
helpviewer_keywords:
- playback of media [WPF]
- classes [WPF], MediaPlayer
ms.assetid: 165d47ed-22ce-4ded-aa6a-aa9b7467de87
ms.openlocfilehash: 186c9ae8167dafd09f029418c1d23f81f7a9e906
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59203617"
---
# <a name="how-to-play-media-using-a-videodrawing"></a>Практическое руководство. Воспроизведение мультимедиа с помощью объекта VideoDrawing
Для воспроизведения аудио-или видео, используйте <xref:System.Windows.Media.VideoDrawing> и <xref:System.Windows.Media.MediaPlayer>. Есть два способа загрузки и воспроизведения мультимедиа. Первый заключается в использовании <xref:System.Windows.Media.MediaPlayer> и <xref:System.Windows.Media.VideoDrawing> , а второй способ состоит в создании собственных <xref:System.Windows.Media.MediaTimeline> для использования с <xref:System.Windows.Media.MediaPlayer> и <xref:System.Windows.Media.VideoDrawing>.  
  
> [!NOTE]
>  При распространении мультимедиа с приложением, в отличие от изображений, файл мультимедиа нельзя использовать как ресурс проекта. Вместо этого в файле проекта необходимо выбрать тип мультимедиа `Content` и задать для `CopyToOutputDirectory` значение `PreserveNewest` или `Always`.  
  
## <a name="example"></a>Пример  
 В следующем примере используется <xref:System.Windows.Media.VideoDrawing> и <xref:System.Windows.Media.MediaPlayer> для однократного воспроизведения видеофайла.  
  
 [!code-csharp[DrawingMiscSnippets_snip#VideoDrawingExampleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/DrawingMiscSnippets_snip/CSharp/VideoDrawingExample.cs#videodrawingexampleinline)]  
  
 Чтобы получить дополнительное управление временем для мультимедиа, используйте <xref:System.Windows.Media.MediaTimeline> с <xref:System.Windows.Media.MediaPlayer> и <xref:System.Windows.Media.VideoDrawing> объектов. <xref:System.Windows.Media.MediaTimeline> Позволяет указать, следует ли повторять видео.  
  
## <a name="example"></a>Пример  
 В следующем примере используется <xref:System.Windows.Media.MediaTimeline> с <xref:System.Windows.Media.MediaPlayer> и <xref:System.Windows.Media.VideoDrawing> объекты для воспроизведения видео.  
  
 [!code-csharp[DrawingMiscSnippets_snip#RepeatingVideoDrawingExampleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/DrawingMiscSnippets_snip/CSharp/VideoDrawingExample.cs#repeatingvideodrawingexampleinline)]  
  
 Обратите внимание, что при использовании <xref:System.Windows.Media.MediaTimeline>, интерактивный <xref:System.Windows.Media.Animation.ClockController> возвращаемые <xref:System.Windows.Media.Animation.Clock.Controller%2A> свойство <xref:System.Windows.Media.MediaClock> для управления воспроизведением мультимедиа, а не интерактивные методы <xref:System.Windows.Media.MediaPlayer>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.VideoDrawing>
- [Обзор объектов Drawing](drawing-objects-overview.md)

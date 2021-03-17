---
title: Практическое руководство. Анимация цвета с помощью ключевых кадров
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- colors [WPF], animating with key frames
- animation [WPF], colors with key frames
- key frames [WPF], animating colors with
ms.assetid: ab04ffa6-4de9-4d5b-a3b4-4e35d5b2ef35
ms.openlocfilehash: e579c4beb757ccf58eb1b9ca1f3852a5b96cac1a
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59326090"
---
# <a name="how-to-animate-color-by-using-key-frames"></a>Практическое руководство. Анимация цвета с помощью ключевых кадров
В этом примере демонстрируется анимация <xref:System.Windows.Media.SolidColorBrush.Color%2A> из <xref:System.Windows.Media.SolidColorBrush> с помощью ключевых кадров.  
  
## <a name="example"></a>Пример  
 В следующем примере используется <xref:System.Windows.Media.Animation.ColorAnimationUsingKeyFrames> класс для анимации <xref:System.Windows.Media.SolidColorBrush.Color%2A> свойство <xref:System.Windows.Media.SolidColorBrush>. Эта анимация использует три ключевых кадра следующим образом:  
  
1. В течение первых двух секунд используется экземпляр <xref:System.Windows.Media.Animation.LinearColorKeyFrame> класс для постепенного изменения цвета от зеленого к красному. Линейные ключевые кадры, например <xref:System.Windows.Media.Animation.LinearColorKeyFrame> создать плавный линейный переход между значениями.  
  
2. В конце следующей половины секунды используется экземпляр <xref:System.Windows.Media.Animation.DiscreteColorKeyFrame> класс для быстрого изменения цвета с красного на желтый. Дискретные ключевые кадры, например <xref:System.Windows.Media.Animation.DiscreteColorKeyFrame> создают резкие изменения значений, то есть, изменение цвета в этой части анимации происходит быстро и не плавно.  
  
3. В течение последних двух секунд используется экземпляр <xref:System.Windows.Media.Animation.SplineColorKeyFrame> класс для изменения цвета — это время с желтого обратно на зеленый. Ключевые кадры сплайна, например <xref:System.Windows.Media.Animation.SplineColorKeyFrame> , создают переменный переход между значениями в соответствии со значениями из <xref:System.Windows.Media.Animation.SplineColorKeyFrame.KeySpline%2A> свойство. В этом примере изменение цвета начинается медленно и ускоряется экспоненциально к концу временного сегмента.  
  
 [!code-csharp[keyframes_snip#ColorAnimationUsingKeyFramesWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/keyframes_snip/CSharp/ColorAnimationUsingKeyFramesExample.cs#coloranimationusingkeyframeswholepage)]
 [!code-vb[keyframes_snip#ColorAnimationUsingKeyFramesWholePage](~/samples/snippets/visualbasic/VS_Snippets_Wpf/keyframes_snip/visualbasic/coloranimationusingkeyframesexample.vb#coloranimationusingkeyframeswholepage)]
 [!code-xaml[keyframes_snip#ColorAnimationUsingKeyFramesWholePage](~/samples/snippets/xaml/VS_Snippets_Wpf/keyframes_snip/XAML/ColorAnimationUsingKeyFramesExample.xaml#coloranimationusingkeyframeswholepage)]  
  
 Описание полного примера см. в разделе [Пример анимации по ключевым кадрам](https://go.microsoft.com/fwlink/?LinkID=160012).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.SolidColorBrush.Color%2A>
- <xref:System.Windows.Media.SolidColorBrush>
- <xref:System.Windows.Media.Animation.ColorAnimationUsingKeyFrames>
- [Общие сведения об анимации по ключевым кадрам](key-frame-animations-overview.md)
- [Практические руководства, посвященные анимации по ключевым кадрам](key-frame-animation-how-to-topics.md)

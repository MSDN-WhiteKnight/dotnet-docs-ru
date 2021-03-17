---
title: Практическое руководство. Анимация прямоугольника с помощью ключевых кадров
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- key frames [WPF], animating RectangleGeometry objects with
- RectangleGeometry objects [WPF], animating with key frames
- animation [WPF], RectangleGeometry objects with key frames
ms.assetid: a8b45ceb-0e32-4ba1-928f-df6d30db17c6
ms.openlocfilehash: 03953b79127ffceeb49e4ece2070d09f382448a5
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59311348"
---
# <a name="how-to-animate-a-rectangle-geometry-by-using-key-frames"></a>Практическое руководство. Анимация прямоугольника с помощью ключевых кадров
В этом примере демонстрируется анимация <xref:System.Windows.Media.RectangleGeometry.Rect%2A> свойство <xref:System.Windows.Media.RectangleGeometry> с помощью ключевых кадров.  
  
## <a name="example"></a>Пример  
 В следующем примере используется <xref:System.Windows.Media.Animation.RectAnimationUsingKeyFrames> класс для анимации <xref:System.Windows.Media.RectangleGeometry.Rect%2A> свойство <xref:System.Windows.Media.RectangleGeometry>. Эта анимация использует три ключевых кадра следующим образом:  
  
1. В течение первых двух секунд используется экземпляр <xref:System.Windows.Media.Animation.LinearRectKeyFrame> класс для анимации к плавному изменению в позицию, ширину и высоту прямоугольника. Линейные ключевые кадры, например <xref:System.Windows.Media.Animation.LinearRectKeyFrame> создать плавный линейный переход между значениями.  
  
2. В конце следующей половины секунды используется экземпляр <xref:System.Windows.Media.Animation.DiscreteRectKeyFrame> класс для резкого уменьшения высоты прямоугольника. Дискретные ключевые кадры, например <xref:System.Windows.Media.Animation.DiscreteRectKeyFrame> создают резкие изменения значений, то есть, уменьшение высоты происходит быстро и не плавно.  
  
3. В течение последних двух секунд используется экземпляр <xref:System.Windows.Media.Animation.SplineRectKeyFrame> класс, чтобы изменить прямоугольника обратно на исходный размер и положение. Ключевые кадры сплайна, например <xref:System.Windows.Media.Animation.SplineRectKeyFrame> , создают переменный переход между значениями в соответствии со значениями из <xref:System.Windows.Media.Animation.SplineRectKeyFrame.KeySpline%2A> свойство. В этом примере изменение начинается медленно и ускоряется экспоненциально к концу временного сегмента.  
  
 [!code-csharp[keyframes_snip#RectAnimationUsingKeyFramesWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/keyframes_snip/CSharp/RectAnimationUsingKeyFramesExample.cs#rectanimationusingkeyframeswholepage)]
 [!code-vb[keyframes_snip#RectAnimationUsingKeyFramesWholePage](~/samples/snippets/visualbasic/VS_Snippets_Wpf/keyframes_snip/visualbasic/rectanimationusingkeyframesexample.vb#rectanimationusingkeyframeswholepage)]
 [!code-xaml[keyframes_snip#RectAnimationUsingKeyFramesWholePage](~/samples/snippets/xaml/VS_Snippets_Wpf/keyframes_snip/XAML/RectAnimationUsingKeyFramesExample.xaml#rectanimationusingkeyframeswholepage)]  
  
 Описание полного примера см. в разделе [Пример анимации по ключевым кадрам](https://go.microsoft.com/fwlink/?LinkID=160012).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.RectangleGeometry>
- <xref:System.Windows.Media.RectangleGeometry.Rect%2A>
- <xref:System.Windows.Media.Animation.RectAnimationUsingKeyFrames>
- [Общие сведения об анимации по ключевым кадрам](key-frame-animations-overview.md)
- [Практические руководства, посвященные анимации по ключевым кадрам](key-frame-animation-how-to-topics.md)

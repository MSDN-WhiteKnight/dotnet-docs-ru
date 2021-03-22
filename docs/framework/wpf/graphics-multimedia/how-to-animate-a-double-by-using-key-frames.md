---
title: Практическое руководство. Анимация типа Double с помощью ключевых кадров
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Doubles [WPF], animating with key frames
- animation [WPF], Doubles with key frames
- key frames [WPF], animating Doubles with
ms.assetid: 3a1a7dba-7694-4907-8a2f-3408baebfa82
ms.openlocfilehash: 73cbeab8aee566313bad8e8a18a5500374287de0
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59305589"
---
# <a name="how-to-animate-a-double-by-using-key-frames"></a>Практическое руководство. Анимация типа Double с помощью ключевых кадров
В этом примере демонстрируется анимация значения свойства, которое принимает <xref:System.Double> с помощью ключевых кадров.  
  
## <a name="example"></a>Пример  
 В следующем примере прямоугольник перемещается по экрану. В примере используется <xref:System.Windows.Media.Animation.DoubleAnimationUsingKeyFrames> класс для анимации <xref:System.Windows.Media.TranslateTransform.X%2A> свойство <xref:System.Windows.Media.TranslateTransform> применяется к <xref:System.Windows.Shapes.Rectangle>. Эта анимация, которая бесконечно повторяется, использует три ключевых кадра следующим образом:  
  
1. В течение первых трех секунд используется экземпляр <xref:System.Windows.Media.Animation.LinearDoubleKeyFrame> класс для перемещения прямоугольника вдоль пути с постоянной скоростью из его начальной позиции в позицию 500. Линейные ключевые кадры, например <xref:System.Windows.Media.Animation.LinearDoubleKeyFrame> создать плавный линейный переход между значениями.  
  
2. В конце четвертой секунды используется экземпляр <xref:System.Windows.Media.Animation.DiscreteDoubleKeyFrame> класс для резкого перемещения прямоугольника в следующую позицию. Дискретные ключевые кадры, например <xref:System.Windows.Media.Animation.DiscreteDoubleKeyFrame> , создают скачкообразные переходы между значениями. В этом примере прямоугольник находится в начальной позиции, а затем внезапно появляется в позиции 500.  
  
3. В последних двух секунд используется экземпляр <xref:System.Windows.Media.Animation.SplineDoubleKeyFrame> класс для перемещения прямоугольника обратно в исходное положение. Ключевые кадры сплайна, например <xref:System.Windows.Media.Animation.SplineDoubleKeyFrame> , создают переменный переход между значениями согласно значению <xref:System.Windows.Media.Animation.SplineDoubleKeyFrame.KeySpline%2A> свойство. В этом примере прямоугольник начинает двигаться медленно и ускоряется экспоненциально к концу временного отрезка.  
  
 [!code-csharp[keyframes_snip#AltDoubleAnimationUsingKeyFramesWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/keyframes_snip/CSharp/AltDoubleAnimationUsingKeyFramesExample.cs#altdoubleanimationusingkeyframeswholepage)]
 
 [!code-xaml[keyframes_snip#AltDoubleAnimationUsingKeyFramesWholePage](~/samples/snippets/xaml/VS_Snippets_Wpf/keyframes_snip/XAML/AltDoubleAnimationUsingKeyFramesExample.xaml#altdoubleanimationusingkeyframeswholepage)]  
  
 Описание полного примера см. в разделе [Пример анимации по ключевым кадрам](https://go.microsoft.com/fwlink/?LinkID=160012).  
  
 Для обеспечения согласованности с другими примерами анимации версии кода этого примера используют <xref:System.Windows.Media.Animation.Storyboard> объекта для применения <xref:System.Windows.Media.Animation.DoubleAnimationUsingKeyFrames>. Кроме того, при применении в коде одной анимации, проще использовать <xref:System.Windows.Media.Animation.Animatable.BeginAnimation%2A> метода вместо использования <xref:System.Windows.Media.Animation.Storyboard>. Пример см. в разделе [Анимация свойства без использования раскадровки](how-to-animate-a-property-without-using-a-storyboard.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Animation.DoubleAnimationUsingKeyFrames>
- <xref:System.Windows.Shapes.Rectangle>
- <xref:System.Windows.Media.Animation.LinearDoubleKeyFrame>
- <xref:System.Windows.Media.Animation.DiscreteDoubleKeyFrame>
- <xref:System.Windows.Media.Animation.SplineDoubleKeyFrame>
- [Общие сведения об анимации по ключевым кадрам](key-frame-animations-overview.md)
- [Практические руководства, посвященные анимации по ключевым кадрам](key-frame-animation-how-to-topics.md)

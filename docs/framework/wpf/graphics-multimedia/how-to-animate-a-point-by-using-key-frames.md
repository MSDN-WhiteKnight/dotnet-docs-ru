---
title: Практическое руководство. Анимация точки с помощью ключевых кадров
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- key frames [WPF], animating Points with
- Points [WPF], animating with key frames
- animation [WPF], Points with key frames
ms.assetid: d2e2ef10-0773-4133-856e-d41c09f60ded
ms.openlocfilehash: b706568a0e8221aac737780592882f728f0f9e9c
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59328781"
---
# <a name="how-to-animate-a-point-by-using-key-frames"></a>Практическое руководство. Анимация точки с помощью ключевых кадров
В этом примере показано, как использовать <xref:System.Windows.Media.Animation.PointAnimationUsingKeyFrames> класс для анимации <xref:System.Windows.Point>.  
  
## <a name="example"></a>Пример  
 В следующем примере эллипс перемещается по треугольному пути. В примере используется <xref:System.Windows.Media.Animation.PointAnimationUsingKeyFrames> класс для анимации <xref:System.Windows.Media.EllipseGeometry.Center%2A> свойство <xref:System.Windows.Media.EllipseGeometry>. Эта анимация использует три ключевых кадра следующим образом:  
  
1. В течение первой половины секунды используется экземпляр <xref:System.Windows.Media.Animation.LinearPointKeyFrame> класс для перемещения эллипса вдоль пути с постоянной скоростью из его начальной позиции. Линейные ключевые кадры, например <xref:System.Windows.Media.Animation.LinearPointKeyFrame> Создание smooth линейной интерполяции между значениями.  
  
2. В конце следующей половины секунды используется экземпляр <xref:System.Windows.Media.Animation.DiscretePointKeyFrame> класс для резкого перемещения эллипса вдоль пути в следующую позицию. Дискретные ключевые кадры, например <xref:System.Windows.Media.Animation.DiscretePointKeyFrame> , создают скачкообразные переходы между значениями.  
  
3. В течение последних двух секунд используется экземпляр <xref:System.Windows.Media.Animation.SplinePointKeyFrame> класс для перемещения эллипса обратно в исходное положение. Ключевые кадры сплайна, например <xref:System.Windows.Media.Animation.SplinePointKeyFrame> , создают переменный переход между значениями в соответствии со значениями из <xref:System.Windows.Media.Animation.SplinePointKeyFrame.KeySpline%2A> свойство. В этом примере анимация начинается медленно и ускоряется экспоненциально к концу временного отрезка.  
  
 [!code-csharp[keyframes_snip#PointAnimationUsingKeyFramesWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/keyframes_snip/CSharp/PointAnimationUsingKeyFramesExample.cs#pointanimationusingkeyframeswholepage)]
 
 [!code-xaml[keyframes_snip#PointAnimationUsingKeyFramesWholePage](~/samples/snippets/xaml/VS_Snippets_Wpf/keyframes_snip/XAML/PointAnimationUsingKeyFramesExample.xaml#pointanimationusingkeyframeswholepage)]  
  
 Описание полного примера см. в разделе [Пример анимации по ключевым кадрам](https://go.microsoft.com/fwlink/?LinkID=160012).  
  
 Для обеспечения согласованности с другими примерами анимации версии кода этого примера используют <xref:System.Windows.Media.Animation.Storyboard> объекта для применения <xref:System.Windows.Media.Animation.PointAnimationUsingKeyFrames>. Тем не менее, при применении в коде одной анимации, проще использовать <xref:System.Windows.Media.Animation.Animatable.BeginAnimation%2A> метода вместо использования <xref:System.Windows.Media.Animation.Storyboard>. Пример см. в разделе [Анимация свойства без использования раскадровки](how-to-animate-a-property-without-using-a-storyboard.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Animation.PointAnimationUsingKeyFrames>
- <xref:System.Windows.Media.EllipseGeometry.Center%2A?displayProperty=nameWithType>
- <xref:System.Windows.Media.EllipseGeometry>
- [Общие сведения об анимации по ключевым кадрам](key-frame-animations-overview.md)
- [Практические руководства, посвященные анимации по ключевым кадрам](key-frame-animation-how-to-topics.md)

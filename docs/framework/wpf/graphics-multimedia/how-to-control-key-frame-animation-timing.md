---
title: Практическое руководство. Распределение времени для анимации с полными кадрами
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- key frames [WPF], timing
- timing key-frame animation
ms.assetid: b059216f-7d4b-4ca8-a019-bc287ee7bf16
ms.openlocfilehash: d0ea56b24f8fffeb688d297a675681bce3fdc4e0
ms.sourcegitcommit: 5137208fa414d9ca3c58cdfd2155ac81bc89e917
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/06/2019
ms.locfileid: "57489882"
---
# <a name="how-to-control-key-frame-animation-timing"></a>Практическое руководство. Распределение времени для анимации с полными кадрами

В этом примере показано, как управлять временем ключевые кадры в анимации по полным кадрам. Как и другие виды анимации, имеют покадровой анимации <xref:System.Windows.Media.Animation.Timeline.Duration%2A> свойство. Помимо задания длительности анимации, необходимо указать, какая часть, в течение выделенного для каждого из его ключевых кадров. Чтобы выделить время, необходимо указать <xref:System.Windows.Media.Animation.KeyTime> для каждого ключевого кадра анимации.

<xref:System.Windows.Media.Animation.KeyTime> Для каждого ключевого кадра определяет, когда полного кадра (не указывает продолжительность времени ключевого кадра). Можно указать <xref:System.Windows.Media.Animation.KeyTime> как <xref:System.TimeSpan> значение, в процентах, а также <xref:System.Windows.Media.Animation.KeyTime.Uniform%2A> или <xref:System.Windows.Media.Animation.KeyTime.Paced%2A> специальное значение.

## <a name="example"></a>Пример

В следующем примере используется <xref:System.Windows.Media.Animation.DoubleAnimationUsingKeyFrames> для анимации прямоугольника по экрану. Ключевые кадры время задаются с помощью <xref:System.TimeSpan> значения.

[!code-csharp[keyframes_snip#KeyTimesTimeSpanExample](~/samples/snippets/csharp/VS_Snippets_Wpf/keyframes_snip/CSharp/KeyTimesExample.cs#keytimestimespanexample)]

[!code-xaml[keyframes_snip#KeyTimesTimeSpanExample](~/samples/snippets/xaml/VS_Snippets_Wpf/keyframes_snip/XAML/KeyTimesExample.xaml#keytimestimespanexample)]

На следующем рисунке показано, когда будет достигнуто значение каждого ключевого кадра.

![Ключевые значения достигаются за 3, 4 и 10 секунд](./media/graphicsmm-keyframe-keytime1-timespan.png "graphicsmm_keyframe_keytime1_timespan")

В следующем примере показано анимацию, которая идентична, за исключением того, что время ключевые кадры задаются с помощью значения в процентах.

[!code-csharp[keyframes_snip#KeyTimesPercentageExample](~/samples/snippets/csharp/VS_Snippets_Wpf/keyframes_snip/CSharp/KeyTimesExample.cs#keytimespercentageexample)]

[!code-xaml[keyframes_snip#KeyTimesPercentageExample](~/samples/snippets/xaml/VS_Snippets_Wpf/keyframes_snip/XAML/KeyTimesExample.xaml#keytimespercentageexample)]

На следующем рисунке показано, когда будет достигнуто значение каждого ключевого кадра.

![Ключевые значения достигаются за 3, 4 и 10 секунд](./media/graphicsmm-keyframe-keytime2-percentage.png "graphicsmm_keyframe_keytime2_percentage")

В следующем примере используется <xref:System.Windows.Media.Animation.KeyTime.Uniform%2A> ключевых значений времени.

[!code-csharp[keyframes_snip#KeyTimesUniformExample](~/samples/snippets/csharp/VS_Snippets_Wpf/keyframes_snip/CSharp/KeyTimesExample.cs#keytimesuniformexample)]

[!code-xaml[keyframes_snip#KeyTimesUniformExample](~/samples/snippets/xaml/VS_Snippets_Wpf/keyframes_snip/XAML/KeyTimesExample.xaml#keytimesuniformexample)]

На следующем рисунке показано, когда будет достигнуто значение каждого ключевого кадра.

![Ключевые значения достигаются за 3,3; 6,6 и 9,9 секунды](./media/graphicsmm-keyframe-keytime3-uniform.png "graphicsmm_keyframe_keytime3_uniform")

В последнем примере используются <xref:System.Windows.Media.Animation.KeyTime.Paced%2A> ключевых значений времени.

[!code-csharp[keyframes_snip#KeyTimesPacedExample](~/samples/snippets/csharp/VS_Snippets_Wpf/keyframes_snip/CSharp/KeyTimesExample.cs#keytimespacedexample)]

[!code-xaml[keyframes_snip#KeyTimesPacedExample](~/samples/snippets/xaml/VS_Snippets_Wpf/keyframes_snip/XAML/KeyTimesExample.xaml#keytimespacedexample)]

На следующем рисунке показано, когда будет достигнуто значение каждого ключевого кадра.

![Ключевые значения достигаются за 0, 5 и 10 секунд](./media/graphicsmm-keyframe-keytime4-paced.png "graphicsmm_keyframe_keytime4_paced")

Для простоты версии кода этого примера используются локальные анимации, не раскадровки, поскольку только одна анимация применяется к одному свойству, но примеры, которые могут быть изменены а. Пример, показывающий, как объявить раскадровки в коде, см. в разделе [анимация свойства с помощью раскадровки](how-to-animate-a-property-by-using-a-storyboard.md).

Описание полного примера см. в разделе [Пример анимации по ключевым кадрам](https://go.microsoft.com/fwlink/?LinkID=160012). Дополнительные сведения об анимации см. в разделе [сведения об анимации по ключевым кадрам](key-frame-animations-overview.md).

## <a name="see-also"></a>См. также

- [Общие сведения об анимации по ключевым кадрам](key-frame-animations-overview.md)
- [Общие сведения об эффектах анимации](animation-overview.md)
- [Разделы практического руководства](animation-and-timing-how-to-topics.md)

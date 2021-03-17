---
title: Практическое руководство. Повторение анимации
ms.date: 03/30/2017
helpviewer_keywords:
- RepeatBehavior property of timelines [WPF]
- repeating animating [WPF]
- Timelines RepeatBehavior property [WPF]
- animation [WPF], repeating
ms.assetid: e6f3b068-eeeb-47fd-8d40-8848c31f1e1e
ms.openlocfilehash: a80f72b0e67c13890d4befcbd5ab7c4a92a93fe7
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59150544"
---
# <a name="how-to-repeat-an-animation"></a>Практическое руководство. Повторение анимации
В этом примере показано, как использовать <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A> свойство <xref:System.Windows.Media.Animation.Timeline> чтобы контролировать поведение при повторе анимации.  
  
## <a name="example"></a>Пример  
 <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A> Свойство <xref:System.Windows.Media.Animation.Timeline> определяет, сколько раз анимации повторе его простой длительности. С помощью <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A>, можно указать, что <xref:System.Windows.Media.Animation.Timeline> повторяется для определенное число раз (итераций) или в течение указанного времени. В любом случае анимация пройдет такое столько запусков начала до конца, сколько необходимо для заполнения запрошенное количество или длительность.  
  
 По умолчанию временных шкал установлено число повторов, равным 1,0, это означает, воспроизведение происходит один раз и не повторяется. Тем не менее если задать <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A> свойство <xref:System.Windows.Media.Animation.Timeline> для <xref:System.Windows.Media.Animation.RepeatBehavior.Forever%2A>, временная шкала повторяется бесконечно.  
  
 В следующем примере показано, как использовать <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A> свойства для управления повторением анимации. В примере выполняется анимация <xref:System.Windows.FrameworkElement.Width%2A> свойство пяти прямоугольников, каждый с помощью другой тип поведения повтора.  
  
 [!code-xaml[timingbehaviors_snip#RepeatBehaviorWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/timingbehaviors_snip/CSharp/RepeatBehaviorExample.xaml#repeatbehaviorwholepage)]  
  
 Полный пример см. в разделе [пример поведения анимации времени](https://go.microsoft.com/fwlink/?LinkID=159970).  
  
## <a name="see-also"></a>См. также

- [Накапливание значений анимации в повторяющихся циклах](how-to-accumulate-animation-values-during-repeat-cycles.md)
- [Определение автоматического реверса для шкалы времени](how-to-specify-whether-a-timeline-automatically-reverses.md)
- [Разделы руководства по анимации и таймерам](animation-and-timing-how-to-topics.md)
- [Общие сведения об эффектах анимации](animation-overview.md)
- [Пример поведения анимации времени](https://go.microsoft.com/fwlink/?LinkID=159970)

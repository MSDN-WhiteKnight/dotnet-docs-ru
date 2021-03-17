---
title: Практическое руководство. Определение длительности анимации
ms.date: 03/30/2017
helpviewer_keywords:
- animation [WPF], duration
- Timelines [WPF], description
- duration of animations [WPF]
ms.assetid: 155034ef-7d00-4416-a73c-b1713992d2eb
ms.openlocfilehash: bdae1689ffeb8c54d756b9debbd26d57a052892d
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59198794"
---
# <a name="how-to-set-a-duration-for-an-animation"></a>Практическое руководство. Определение длительности анимации
Объект <xref:System.Windows.Media.Animation.Timeline> представляет сегмент времени и длина этого сегмента определяется временной шкалы <xref:System.Windows.Duration>. Когда <xref:System.Windows.Media.Animation.Timeline> достигает окончания своей длительности, воспроизведение прекращается. Если <xref:System.Windows.Media.Animation.Timeline> имеет дочерние временные шкалы, их воспроизведение также останавливается. В случае анимации <xref:System.Windows.Duration> указывает, сколько требуется для анимации перехода от начального к конечному значению.  
  
 Можно указать <xref:System.Windows.Duration> с определенным, ограниченным временем или специальных значений <xref:System.Windows.Duration.Automatic%2A> или <xref:System.Windows.Duration.Forever%2A>. Длительность анимации должна включать значение времени, так как анимации всегда должны иметь определенную, ограниченную длину — в противном случае анимации не известно, как выполнять переход между значениями. Временные шкалы контейнера (<xref:System.Windows.Media.Animation.TimelineGroup> объекты), такие как <xref:System.Windows.Media.Animation.Storyboard> и <xref:System.Windows.Media.Animation.ParallelTimeline>, имеют по умолчанию продолжительность <xref:System.Windows.Duration.Automatic%2A>, то есть они автоматически завершаются после последнего дочернего останавливает воспроизведение.  
  
 В следующем примере, ширину, высоту и заливки цвет <xref:System.Windows.Shapes.Rectangle> анимируется. Длительность, установленная для временных шкал анимации и контейнер, приводит к эффекты анимации, включая управление скоростью анимации и переопределение продолжительность дочерних шкал времени длительностью временной шкалы контейнера.  
  
## <a name="example"></a>Пример  
 [!code-xaml[timingbehaviors_snip#DurationExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/timingbehaviors_snip/CSharp/DurationExample.xaml#durationexamplewholepage)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Duration>
- [Общие сведения об эффектах анимации](animation-overview.md)

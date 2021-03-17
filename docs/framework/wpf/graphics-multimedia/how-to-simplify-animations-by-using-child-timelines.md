---
title: Практическое руководство. Упрощение анимации с помощью дочерних шкал времени
ms.date: 03/30/2017
helpviewer_keywords:
- simplifying animations by child timelines [WPF]
- animation [WPF], simplifying by child timelines
- child timelines [WPF]
ms.assetid: 8335d770-d13d-42bd-8dfa-63f92c0327e2
ms.openlocfilehash: 21a297208be045eea79d6f5ca6c8eac016d26345
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59096398"
---
# <a name="how-to-simplify-animations-by-using-child-timelines"></a>Практическое руководство. Упрощение анимации с помощью дочерних шкал времени
В этом примере показано, как Упрощение анимации с помощью дочерних <xref:System.Windows.Media.Animation.ParallelTimeline> объектов. Объект <xref:System.Windows.Media.Animation.Storyboard> — это разновидность <xref:System.Windows.Media.Animation.Timeline> , предоставляющий сведения о содержащихся в нем временных шкал. Используйте <xref:System.Windows.Media.Animation.Storyboard> для предоставления временной шкалы, предназначенных для сведения, включая сведения объекта и свойством.  
  
 Чтобы начать анимацию, используйте один или несколько <xref:System.Windows.Media.Animation.ParallelTimeline> объектов в качестве вложенных дочерних элементов <xref:System.Windows.Media.Animation.Storyboard>. Эти <xref:System.Windows.Media.Animation.ParallelTimeline> объекты могут содержать другие анимации и таким образом, что позволяет лучше инкапсулировать временные последовательности в сложных анимациях. Например, при анимации <xref:System.Windows.Controls.TextBlock> и нескольких фигур в одном <xref:System.Windows.Media.Animation.Storyboard>, можно разделить анимации для <xref:System.Windows.Controls.TextBlock> и фигур, помещая каждую из них в отдельную <xref:System.Windows.Media.Animation.ParallelTimeline>. Так как каждый <xref:System.Windows.Media.Animation.ParallelTimeline> имеет свой собственный <xref:System.Windows.Media.Animation.Timeline.BeginTime%2A> и все дочерние элементы <xref:System.Windows.Media.Animation.ParallelTimeline> отсчитываются относительно этого <xref:System.Windows.Media.Animation.Timeline.BeginTime%2A>, время инкапсулируется лучше.  
  
 В следующем примере выполняется анимация двух фрагментов текста (<xref:System.Windows.Controls.TextBlock> объектов) из внутри того же <xref:System.Windows.Media.Animation.Storyboard>. Объект <xref:System.Windows.Media.Animation.ParallelTimeline> инкапсулирует анимации одного из <xref:System.Windows.Controls.TextBlock> объектов.  
  
 **Замечание о производительности:** Несмотря на то, что можно вложить <xref:System.Windows.Media.Animation.Storyboard> временных шкал друг в друга, <xref:System.Windows.Media.Animation.ParallelTimeline>больше подходят для вложения, так как они требуют меньше издержек. ( <xref:System.Windows.Media.Animation.Storyboard> Класс наследует от <xref:System.Windows.Media.Animation.ParallelTimeline> класса.)  
  
## <a name="example"></a>Пример  
 [!code-xaml[Timelines_snip#ParallelTimelineWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/Timelines_snip/CS/ParallelTimelineExample.xaml#paralleltimelinewholepage)]  
  
## <a name="see-also"></a>См. также

- [Общие сведения об эффектах анимации](animation-overview.md)
- [Задание значения свойства HandoffBehavior для анимаций раскадровки](how-to-specify-handoffbehavior-between-storyboard-animations.md)

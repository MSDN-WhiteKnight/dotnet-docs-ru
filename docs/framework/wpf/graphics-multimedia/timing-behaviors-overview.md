---
title: Общие сведения о характере поведения во времени
ms.date: 03/30/2017
helpviewer_keywords:
- timing behaviors [WPF]
- behaviors [WPF], timing
ms.assetid: 5b714d46-bd46-48b8-b467-b4be89ba3091
ms.openlocfilehash: c3403a8602cc874e993bd649851b77d7bf652cce
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59129601"
---
# <a name="timing-behaviors-overview"></a>Общие сведения о характере поведения во времени
В этом разделе описан характер поведения анимаций и других <xref:System.Windows.Media.Animation.Timeline> объектов.  
  
<a name="prerequisites"></a>   
## <a name="prerequisites"></a>Предварительные требования  
 Для понимания этого раздела необходимо ознакомиться с базовыми средствами анимации. Дополнительные сведения см. в разделе [Общие сведения об анимации](animation-overview.md).  
  
<a name="timelinetypes"></a>   
## <a name="timeline-types"></a>Типы временных шкал  
 Объект <xref:System.Windows.Media.Animation.Timeline> представляет сегмент времени. Он предоставляет свойства, с помощью которых вы сможете задать длину этого сегмента, время запуска сегмента, количество повторов сегмента, скорость течения времени в этом сегменте и многое другое.  
  
 Классы, которые унаследованы от класса временной шкалы, предоставляют дополнительные функции, такие как анимация и воспроизведение мультимедиа. [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] предоставляет следующие <xref:System.Windows.Media.Animation.Timeline> типов.  
  
|Тип временной шкалы|Описание|  
|-------------------|-----------------|  
|<xref:System.Windows.Media.Animation.AnimationTimeline>|Абстрактный базовый класс для <xref:System.Windows.Media.Animation.Timeline> объекты, которые формируют выходные значения для анимации свойств.|  
|<xref:System.Windows.Media.MediaTimeline>|Формирует выходные данные из файла мультимедиа.|  
|<xref:System.Windows.Media.Animation.ParallelTimeline>|Это разновидность <xref:System.Windows.Media.Animation.TimelineGroup> что дочерние группы и элементы управления <xref:System.Windows.Media.Animation.Timeline> объектов.|  
|<xref:System.Windows.Media.Animation.Storyboard>|Это разновидность <xref:System.Windows.Media.Animation.ParallelTimeline> , предоставляющий сведения о содержащихся в нем объектов временной шкалы.|  
|<xref:System.Windows.Media.Animation.Timeline>|Абстрактный базовый класс, который определяет поведение во времени.|  
|<xref:System.Windows.Media.Animation.TimelineGroup>|Абстрактный класс для <xref:System.Windows.Media.Animation.Timeline> объектов, которые могут содержать другие <xref:System.Windows.Media.Animation.Timeline> объектов.|  
  
<a name="propertiesthatcontroltimelinelength"></a>   
## <a name="properties-that-control-the-length-of-a-timeline"></a>Свойства, которые управляют длиной временной шкалы  
 Объект <xref:System.Windows.Media.Animation.Timeline> представляет сегмент времени и длину временной шкалы можно описать различными способами. В следующей таблице приведены несколько терминов для описания длины временной шкалы.  
  
|Термин|Описание|Свойства||||  
|----------|-----------------|----------------|-|-|-|  
|Простая длительность|Длительность, необходимая для одной итерации временной шкалы вперед.|<xref:System.Windows.Media.Animation.Timeline.Duration%2A>||||  
|Одно повторение|Время, необходимое для временной шкалы для воспроизведения вперед, после и, если <xref:System.Windows.Media.Animation.Timeline.AutoReverse%2A> свойство имеет значение true, обратная однократного воспроизведения.|<xref:System.Windows.Media.Animation.Timeline.Duration%2A>, <xref:System.Windows.Media.Animation.Timeline.AutoReverse%2A>||||  
|Период активности|Время, необходимое для временной шкалы для выполнения всех повторений, определяемое его <xref:System.Windows.Media.Animation.RepeatBehavior> свойство.|<xref:System.Windows.Media.Animation.Timeline.Duration%2A>значение <xref:System.Windows.Media.Animation.Timeline.AutoReverse%2A>значение <xref:System.Windows.Media.Animation.RepeatBehavior>||||  
  
<a name="duration"></a>   
### <a name="the-duration-property"></a>Свойство Duration  
 Как упоминалось ранее, временная шкала представляет собой сегмент времени. Длина этого сегмента определяется по временной шкале <xref:System.Windows.Media.Animation.Timeline.Duration%2A>. Когда временная шкала достигает окончания своей длительности, воспроизведение прекращается. Если у временной шкалы есть дочерние временные шкалы, их воспроизведение также останавливается. В случае анимации <xref:System.Windows.Media.Animation.Timeline.Duration%2A> указывает, сколько требуется для анимации перехода от начального к конечному значению. Длительность временной шкалы иногда называют его *простой длительности*, чтобы различать длительность одной итерации и общую длительность воспроизведения анимации с учетом повторов. Можно указать длительность, используя значение времени окончания или специальных значений <xref:System.Windows.Duration.Automatic%2A> или <xref:System.Windows.Duration.Forever%2A>. Длительность анимации должна разрешаться <xref:System.Windows.Duration.TimeSpan%2A> значение перехода между значениями.  
  
 В следующем примере показан <xref:System.Windows.Media.Animation.DoubleAnimation> с <xref:System.Windows.Media.Animation.Timeline.Duration%2A> 5 секунд.  
  
 [!code-xaml[animation_ovws_snippet#AnimationWith5SecondDurationInline](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws_snippet/CS/TimingBehaviorsExample1.xaml#animationwith5seconddurationinline)]  
  
 Временные шкалы контейнера, такие как <xref:System.Windows.Media.Animation.Storyboard> и <xref:System.Windows.Media.Animation.ParallelTimeline>, имеют по умолчанию продолжительность <xref:System.Windows.Duration.Automatic%2A>, то есть они автоматически завершаются после последнего дочернего останавливает воспроизведение. В следующем примере показан <xref:System.Windows.Media.Animation.Storyboard> которого <xref:System.Windows.Media.Animation.Timeline.Duration%2A> разрешается в пять секунд, время, необходимое, чтобы все его дочерние <xref:System.Windows.Media.Animation.DoubleAnimation> объектов для обработки.  
  
 [!code-xaml[animation_ovws_snippet#ContainerTimelineExampleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws_snippet/CS/TimingBehaviorsExample1.xaml#containertimelineexampleinline)]  
  
 Установив <xref:System.Windows.Media.Animation.Timeline.Duration%2A> временной шкалы контейнера для <xref:System.Windows.Duration.TimeSpan%2A> значение, можно принудительно воспроизвести длиннее или короче его дочерних <xref:System.Windows.Media.Animation.Timeline> объектов. Если задать <xref:System.Windows.Media.Animation.Timeline.Duration%2A> которого является значение, меньшее, чем длительность дочерних временной шкалы контейнера <xref:System.Windows.Media.Animation.Timeline> объектов, то дочерние <xref:System.Windows.Media.Animation.Timeline> объектов в момент остановки воспроизведения временной шкалы контейнера. В следующем примере задается <xref:System.Windows.Media.Animation.Timeline.Duration%2A> из <xref:System.Windows.Media.Animation.Storyboard> из предыдущих примеров установлена в три секунды. Таким образом первый <xref:System.Windows.Media.Animation.DoubleAnimation> останавливается через три секунды, если объект имеет анимированные ширина целевого прямоугольника до 60.  
  
 [!code-xaml[animation_ovws_snippet#ContainerTimelineWithShorterDurationExampleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws_snippet/CS/TimingBehaviorsExample1.xaml#containertimelinewithshorterdurationexampleinline)]  
  
<a name="repeatinganimations"></a>   
### <a name="the-repeatbehavior-property"></a>Свойство RepeatBehavior  
 <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A> Свойство <xref:System.Windows.Media.Animation.Timeline> определяет, сколько раз он повторе его простой длительности. С помощью <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A> свойство, можно указать, сколько раз воспроизведения временной шкалы (итерация <xref:System.Windows.Media.Animation.RepeatBehavior.Count%2A>) или общая продолжительность времени, воспроизведение должно (повторение <xref:System.Windows.Media.Animation.RepeatBehavior.Duration%2A>). В любом случае анимация пройдет такое количество циклов от начала до конца, которое необходимо для получения необходимого количества повторов или необходимой длительности. По умолчанию временные шкалы имеют число итераций `1.0`, что означает воспроизведение происходит один раз и не повторяется.  
  
 В следующем примере используется <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A> свойства <xref:System.Windows.Media.Animation.DoubleAnimation> воспроизвести дважды ее простой длительности, указав число итераций.  
  
 [!code-xaml[animation_ovws_snippet#TBRepeatBehavior2xExampleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws_snippet/CS/TimingBehaviorsExample1.xaml#tbrepeatbehavior2xexampleinline)]  
  
 В следующем примере используется <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A> свойства <xref:System.Windows.Media.Animation.DoubleAnimation> воспроизведения половина ее простой длительности.  
  
 [!code-xaml[animation_ovws_snippet#TBRepeatBehavior05xExampleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws_snippet/CS/TimingBehaviorsExample1.xaml#tbrepeatbehavior05xexampleinline)]  
  
 Если задать <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A> свойство <xref:System.Windows.Media.Animation.Timeline> для <xref:System.Windows.Media.Animation.RepeatBehavior.Forever%2A>, <xref:System.Windows.Media.Animation.Timeline> повторяется, пока не будет остановлена интерактивно или системой управления временем. В следующем примере используется <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A> свойства <xref:System.Windows.Media.Animation.DoubleAnimation> бесконечного воспроизведения.  
  
 [!code-xaml[animation_ovws_snippet#TBRepeatBehaviorForeverExampleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws_snippet/CS/TimingBehaviorsExample1.xaml#tbrepeatbehaviorforeverexampleinline)]  
  
 Дополнительный пример см. в разделе [Повторение анимации](how-to-repeat-an-animation.md).  
  
<a name="autoreverseproperty"></a>   
### <a name="the-autoreverse-property"></a>Свойство AutoReverse  
 <xref:System.Windows.Media.Animation.Timeline.AutoReverse%2A> Свойство указывает, является ли <xref:System.Windows.Media.Animation.Timeline> будет воспроизводиться в обратном порядке, в конце каждой прямой итерации. В следующем примере задается <xref:System.Windows.Media.Animation.Timeline.AutoReverse%2A> свойство <xref:System.Windows.Media.Animation.DoubleAnimation> для `true`; таким образом, он выполняет анимацию от 0 до 100, а затем от 100 до 0. Суммарное время воспроизведения составляет 10 секунд.  
  
 [!code-xaml[animation_ovws_snippet#TBAutoReverseExampleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws_snippet/CS/TimingBehaviorsExample1.xaml#tbautoreverseexampleinline)]  
  
 При использовании <xref:System.Windows.Media.Animation.RepeatBehavior.Count%2A> указывается значение <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A> из <xref:System.Windows.Media.Animation.Timeline> и <xref:System.Windows.Media.Animation.Timeline.AutoReverse%2A> , свойство <xref:System.Windows.Media.Animation.Timeline> является `true`, простое повторение состоит из одной прямой итерации и одной обратной итерации.  В следующем примере задается <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A> из <xref:System.Windows.Media.Animation.DoubleAnimation> из предыдущего примера для <xref:System.Windows.Media.Animation.RepeatBehavior.Count%2A> двух. В результате <xref:System.Windows.Media.Animation.DoubleAnimation> выполняется в течение 20 секунд: вперед в течение пяти секунд, назад в течение пяти секунд, пересылать на 5 секунд, а затем назад в течение пяти секунд.  
  
 [!code-xaml[animation_ovws_snippet#TBAutoReverseRepeatExampleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws_snippet/CS/TimingBehaviorsExample1.xaml#tbautoreverserepeatexampleinline)]  
  
 Если у контейнера временной шкалы есть дочерние <xref:System.Windows.Media.Animation.Timeline> объекты, они изменяют направление при временной шкалы контейнера. Дополнительные примеры см. в разделе [укажите временной шкалы автоматического реверса](how-to-specify-whether-a-timeline-automatically-reverses.md).  
  
<a name="timelinebegin"></a>   
## <a name="the-begintime-property"></a>Свойство BeginTime  
 <xref:System.Windows.Media.Animation.Timeline.BeginTime%2A> Свойство позволяет указать, при запуске временной шкалы.  Время запуска временной шкалы задается относительно ее родительской временной шкалы. Время запуска в ноль секунд означает, что временная шкала запускается сразу после запуска ее родительской шкалы; любое другое значение задает смещение времени запуска дочерней шкалы от времени запуска родительской. Например, время запуска, равное двум секундам, означает, что временная шкала начнет воспроизведение в момент, когда ее родительская временная шкала достигнет времени в две секунды. По умолчанию время запуска для всех временных шкал установлено в ноль секунд. Можно также задать временной шкалы времени для начала `null`, который препятствует запуску временной шкалы. В [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], укажите значение null с помощью [расширение разметки x: Null](../../xaml-services/x-null-markup-extension.md).  
  
 Обратите внимание, что время начала не применяются при каждом повторении временной шкалы из-за его <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A> параметр. Если же требуется создать анимацию на <xref:System.Windows.Media.Animation.Timeline.BeginTime%2A> 10 секунд и <xref:System.Windows.Media.Animation.RepeatBehavior> из <xref:System.Windows.Media.Animation.RepeatBehavior.Forever%2A>, будет 10-секундная задержка перед воспроизведением анимации в первый раз, но не для каждого успешного повторения. Однако при перезапуске или при повторе родительской временной шкалы возникла бы 10-секундная задержка.  
  
 <xref:System.Windows.Media.Animation.Timeline.BeginTime%2A> Свойство полезно для размещения временных шкал. В следующем примере создается <xref:System.Windows.Media.Animation.Storyboard> , имеет два дочерних <xref:System.Windows.Media.Animation.DoubleAnimation> объектов. Первой анимации <xref:System.Windows.Media.Animation.Timeline.Duration%2A> пяти секунд, а второй — <xref:System.Windows.Media.Animation.Timeline.Duration%2A> 3 секунды. В примере задается <xref:System.Windows.Media.Animation.Timeline.BeginTime%2A> второго <xref:System.Windows.Media.Animation.DoubleAnimation> до 5 секунд, так что она начинает воспроизведение после первого <xref:System.Windows.Media.Animation.DoubleAnimation> заканчивается.  
  
 [!code-xaml[animation_ovws_snippet#TBBeginTimeExampleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws_snippet/CS/TimingBehaviorsExample1.xaml#tbbegintimeexampleinline)]  
  
<a name="fillbehaviorproperty"></a>   
## <a name="the-fillbehavior-property"></a>Свойство FillBehavior  
 Когда <xref:System.Windows.Media.Animation.Timeline> достигает окончания общей активной длительности, <xref:System.Windows.Media.Animation.Timeline.FillBehavior%2A> свойство указывает, является ли она остановлена или сохранит свое последнее значение. Анимации с <xref:System.Windows.Media.Animation.Timeline.FillBehavior%2A> из <xref:System.Windows.Media.Animation.FillBehavior.HoldEnd> «сохраняет» свое выходное значение: анимируемое свойство сохраняет последнее значение анимации. Значение <xref:System.Windows.Media.Animation.FillBehavior.Stop> вызывает, остановки анимации свойства целевого объекта после его окончания.  
  
 В следующем примере создается <xref:System.Windows.Media.Animation.Storyboard> , имеет два дочерних <xref:System.Windows.Media.Animation.DoubleAnimation> объектов. Оба <xref:System.Windows.Media.Animation.DoubleAnimation> объекта анимируют <xref:System.Windows.FrameworkElement.Width%2A> из <xref:System.Windows.Shapes.Rectangle> от 0 до 100. <xref:System.Windows.Shapes.Rectangle> Элементы имеют без анимации <xref:System.Windows.FrameworkElement.Width%2A> со значением 500 [аппаратно-независимых пикселях].  
  
-   <xref:System.Windows.Media.Animation.Timeline.FillBehavior%2A> Свойства первого <xref:System.Windows.Media.Animation.DoubleAnimation> присваивается <xref:System.Windows.Media.Animation.FillBehavior.HoldEnd>, значение по умолчанию. В результате ширина прямоугольника остается равной 100 после <xref:System.Windows.Media.Animation.DoubleAnimation> заканчивается.  
  
-   <xref:System.Windows.Media.Animation.Timeline.FillBehavior%2A> Свойство второго <xref:System.Windows.Media.Animation.DoubleAnimation> присваивается <xref:System.Windows.Media.Animation.FillBehavior.Stop>. В результате <xref:System.Windows.FrameworkElement.Width%2A> второго <xref:System.Windows.Shapes.Rectangle> устанавливается значение 500 после <xref:System.Windows.Media.Animation.DoubleAnimation> заканчивается.  
  
 [!code-xaml[animation_ovws_snippet#TBFillBehaviorExample](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws_snippet/CS/TimingBehaviorsExample1.xaml#tbfillbehaviorexample)]  
  
<a name="speedproperties"></a>   
## <a name="properties-that-control-the-speed-of-a-timeline"></a>Свойства, которые управляют скоростью временной шкалы  
 <xref:System.Windows.Media.Animation.Timeline> Класс предоставляет три свойства для указания скорости:  
  
-   <xref:System.Windows.Media.Animation.Timeline.SpeedRatio%2A> — Указывает соотношение скорости относительно его родительского элемента, скорость течения времени для <xref:System.Windows.Media.Animation.Timeline>. Значения больше единицы увеличения скорости выполнения <xref:System.Windows.Media.Animation.Timeline> и его дочерние <xref:System.Windows.Media.Animation.Timeline> объектов; значения между 0 и 1 — скорость уменьшается. Значение 1 указывает, что <xref:System.Windows.Media.Animation.Timeline> продвижения по тому же тарифу, как его родительский элемент. <xref:System.Windows.Media.Animation.Timeline.SpeedRatio%2A> Контейнера временной шкалы влияет на все его дочерние <xref:System.Windows.Media.Animation.Timeline> объекты.  
  
-   <xref:System.Windows.Media.Animation.Timeline.AccelerationRatio%2A> — Указывает процент <xref:System.Windows.Media.Animation.Timeline.Duration%2A> временной шкалы, затраченный на ускорение. Пример см. в статье [Практическое руководство. Ускорение или замедление анимации](how-to-accelerate-or-decelerate-an-animation.md). 
  
-   <xref:System.Windows.Media.Animation.Timeline.DecelerationRatio%2A> — Указывает процент <xref:System.Windows.Media.Animation.Timeline.Duration%2A> временной шкалы, затраченный на замедление. Пример см. в статье [Практическое руководство. Ускорение или замедление анимации](how-to-accelerate-or-decelerate-an-animation.md).  
  
## <a name="see-also"></a>См. также

- [Общие сведения об эффектах анимации](animation-overview.md)
- [Общие сведения об анимации и системе управления временем](animation-and-timing-system-overview.md)
- [Общие сведения о временных событиях](timing-events-overview.md)
- [Практические руководства](animation-and-timing-how-to-topics.md)
- [Пример поведения анимации времени](https://go.microsoft.com/fwlink/?LinkID=159970)

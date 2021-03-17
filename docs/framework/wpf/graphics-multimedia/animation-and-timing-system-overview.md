---
title: Общие сведения об анимации и системе управления временем
ms.date: 03/30/2017
helpviewer_keywords:
- timing system [WPF]
- animation [WPF]
ms.assetid: 172cd5a8-a333-4c81-9456-fafccc19f382
ms.openlocfilehash: f64431e7804ba6e068a3d05f512c6ead089d7712
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59079322"
---
# <a name="animation-and-timing-system-overview"></a>Общие сведения об анимации и системе управления временем
В этом разделе описывается, как система управления временем использует анимацию, <xref:System.Windows.Media.Animation.Timeline>, и <xref:System.Windows.Media.Animation.Clock> классы для анимации свойств.  
  
<a name="prerequisites"></a>   
## <a name="prerequisites"></a>Предварительные требования  
 Чтобы понять содержимое этого раздела, необходимо знать, как использовать анимацию [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] для анимации свойств, как описано в разделе [Общие сведения об эффектах анимации](animation-overview.md). В нем также можно ознакомиться со свойствами зависимостей. Дополнительные сведения см. в разделе [Общие сведения о свойствах зависимостей](../advanced/dependency-properties-overview.md).  
  
<a name="timelinesandclocks"></a>   
## <a name="timelines-and-clocks"></a>Временные шкалы и часы  
 [Общие сведения об анимации](animation-overview.md) описано как <xref:System.Windows.Media.Animation.Timeline> представляет сегмент времени и анимации — это разновидность <xref:System.Windows.Media.Animation.Timeline> , формирующий значения выходных данных. Сама по себе <xref:System.Windows.Media.Animation.Timeline>, не выполняет никаких действий кроме описания сегмента времени. Он является временной шкалы <xref:System.Windows.Media.Animation.Clock> объект, который не работает. Аналогичным образом, анимация не выполняет анимирования фактически свойства: класс анимации описывает способ вычисления выходные значения, но это <xref:System.Windows.Media.Animation.Clock> , созданных для данной анимации, анимацию и применяет его к свойствам.  
  
 Объект <xref:System.Windows.Media.Animation.Clock> — это специальный тип объекта, который поддерживает состояние времени для выполнения <xref:System.Windows.Media.Animation.Timeline>. Он предоставляет три бита информации, которые необходимы для анимации и системы: <xref:System.Windows.Media.Animation.Clock.CurrentTime%2A>, <xref:System.Windows.Media.Animation.Clock.CurrentProgress%2A>, и <xref:System.Windows.Media.Animation.Clock.CurrentState%2A>. Объект <xref:System.Windows.Media.Animation.Clock> определяет его текущее время, ход выполнения и состояние с помощью поведения времени, описываемого его <xref:System.Windows.Media.Animation.Timeline>: <xref:System.Windows.Media.Animation.Timeline.Duration%2A>, <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A>, <xref:System.Windows.Media.Animation.Timeline.AutoReverse%2A>, и т. д.  
  
 В большинстве случаев <xref:System.Windows.Media.Animation.Clock> создается автоматически для временной шкалы. При анимации с помощью <xref:System.Windows.Media.Animation.Storyboard> или <xref:System.Windows.Media.Animation.Animatable.BeginAnimation%2A> метод, часы автоматически создаются для временной шкалы и анимации и применить к их целевым свойствам. Вы также можете создать <xref:System.Windows.Media.Animation.Clock> явным образом с помощью <xref:System.Windows.Media.Animation.Timeline.CreateClock%2A> метод вашей <xref:System.Windows.Media.Animation.Timeline>. <xref:System.Windows.Media.MediaTimeline.CreateClock%2A?displayProperty=nameWithType> Метод создает часы соответствующего типа для <xref:System.Windows.Media.Animation.Timeline> на котором он вызывается. Если <xref:System.Windows.Media.Animation.Timeline> содержит дочерние временные шкалы, он создает <xref:System.Windows.Media.Animation.Clock> объекты для них. Полученный в результате <xref:System.Windows.Media.Animation.Clock> объекты упорядочиваются в деревья, которые соответствуют структуре <xref:System.Windows.Media.Animation.Timeline> дерева объектов, из которой они созданы.  
  
 Существует различных типа часов для различных типов шкал времени. В следующей таблице показаны <xref:System.Windows.Media.Animation.Clock> типы, которые соответствуют некоторым другим <xref:System.Windows.Media.Animation.Timeline> типов.  
  
|Тип временной шкалы|Тип часов|Назначение часов|  
|-------------------|----------------|-------------------|  
|Анимация (наследует от <xref:System.Windows.Media.Animation.AnimationTimeline>)|<xref:System.Windows.Media.Animation.AnimationClock>|Создает выходные значения для свойства зависимостей.|  
|<xref:System.Windows.Media.MediaTimeline>|<xref:System.Windows.Media.MediaClock>|Обрабатывает файл мультимедиа.|  
|<xref:System.Windows.Media.Animation.ParallelTimeline>|<xref:System.Windows.Media.Animation.ClockGroup>|Группирует и управляет дочерними <xref:System.Windows.Media.Animation.Clock> объектов|  
|<xref:System.Windows.Media.Animation.Storyboard>|<xref:System.Windows.Media.Animation.ClockGroup>|Группирует и управляет дочерними <xref:System.Windows.Media.Animation.Clock> объектов|  
  
 Можно применить любой <xref:System.Windows.Media.Animation.AnimationClock> создаваемых к совместимым свойствам зависимостей с помощью объектов <xref:System.Windows.Media.Animation.IAnimatable.ApplyAnimationClock%2A> метод.  
  
 В сценариях с высокой нагрузкой, например при анимации большого количества сходных объектов, управление использованием <xref:System.Windows.Media.Animation.Clock> использования может дать выигрыш в производительности.  
  
<a name="timemanager"></a>   
## <a name="clocks-and-the-time-manager"></a>Часы и диспетчер времени  
 При анимации объектов в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], это время диспетчер, который управляет <xref:System.Windows.Media.MediaPlayer.Clock%2A> объектами, созданными для временных шкал. Диспетчер времени — это корень дерева объектов <xref:System.Windows.Media.MediaPlayer.Clock%2A>, который управляет потоком времени в этом дереве.  Диспетчер времени создается автоматически для каждого приложения [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] и остается невидимым для разработчика приложения. Диспетчер времени "тикает" много раз в секунду; фактическое число тактов, возникающих каждую секунду, зависит от доступных системных ресурсов. Во время каждой из этих тактов диспетчер времени вычисляет состояние всех <xref:System.Windows.Media.Animation.ClockState.Active> <xref:System.Windows.Media.Animation.Clock> объектов в дереве расчета времени.  
  
 На следующем рисунке показано отношение между диспетчером времени и <xref:System.Windows.Media.Animation.AnimationClock>, а также анимированными свойствами зависимостей.  
  
 ![Время компоненты системы](./media/graphicsmm-clocks-1clock1prop.png "graphicsmm_clocks_1clock1prop")  
Анимирование свойства  
  
 Когда диспетчер времени "тикает", он обновляет время каждого <xref:System.Windows.Media.Animation.ClockState.Active> <xref:System.Windows.Media.Animation.Clock> в приложении. Если <xref:System.Windows.Media.Animation.Clock> — <xref:System.Windows.Media.Animation.AnimationClock>, он использует <xref:System.Windows.Media.Animation.AnimationTimeline.GetCurrentValue%2A> метод <xref:System.Windows.Media.Animation.AnimationTimeline> из которого он был создан для расчета его текущего выходного значения. <xref:System.Windows.Media.Animation.AnimationClock> Предоставляет <xref:System.Windows.Media.Animation.AnimationTimeline> с текущее местное время, входное значение, которое обычно является базовым значением свойства и конечное значение по умолчанию. После получения значения анимированного свойства с помощью <xref:System.Windows.DependencyObject.GetValue%2A> метода или метода доступа CLR, вы получите выходные данные его <xref:System.Windows.Media.Animation.AnimationClock>.  
  
#### <a name="clock-groups"></a>Группы часов  
 Выше описаны различные типы <xref:System.Windows.Media.Animation.Clock> объектов для различных типов шкал времени. На следующем рисунке показано отношение между диспетчером времени <xref:System.Windows.Media.Animation.ClockGroup>, <xref:System.Windows.Media.Animation.AnimationClock>, а также анимированными свойствами зависимостей. Объект <xref:System.Windows.Media.Animation.ClockGroup> создается для временных шкал, которые группируют другие временные шкалы, такие как <xref:System.Windows.Media.Animation.Storyboard> класс, который группирует анимации и другие временные шкалы.  
  
 ![Время компоненты системы](./media/graphicsmm-clocks-2clock1clockgroup2prop.png "graphicsmm_clocks_2clock1clockgroup2prop")  
ClockGroup  
  
#### <a name="composition"></a>Композиция  
 Можно связать несколько часов с одним свойством. При этом каждые часы используют выходное значение предыдущих часов в качестве своего базового значения. На следующем рисунке показаны три <xref:System.Windows.Media.Animation.AnimationClock> объекты, которые применены к тому же свойству. Clock1 использует базовое значение анимируемого свойства в качестве входных данных и для создания выходных данных. Clock2 принимает выходные данные от Clock1 в качестве входных данных и использует их для создания выходных данных. Clock3 принимает выходные данные от Clock2 в качестве входных данных и использует их для создания выходных данных. Когда несколько часов влияют на одно и то же свойство одновременно, считается, что они находятся в цепочке композиции.  
  
 ![Время компоненты системы](./media/graphicsmm-clocks-2clock1prop.png "graphicsmm_clocks_2clock1prop")  
Цепочка композиции  
  
 Обратите внимание, что, несмотря на то, что связь создается между входными и выходными из <xref:System.Windows.Media.Animation.AnimationClock> объекты в цепочке композиции, их поведение времени не меняется. <xref:System.Windows.Media.Animation.Clock> объекты (включая <xref:System.Windows.Media.Animation.AnimationClock> объекты) имеют иерархическую зависимость от их родительских <xref:System.Windows.Media.Animation.Clock> объектов.  
  
 Чтобы применить несколько часов к тому же свойству, используйте <xref:System.Windows.Media.Animation.HandoffBehavior.Compose> <xref:System.Windows.Media.Animation.HandoffBehavior> при применении <xref:System.Windows.Media.Animation.Storyboard>, анимации, или <xref:System.Windows.Media.Animation.AnimationClock>.  
  
#### <a name="ticks-and-event-consolidation"></a>Такты и объединение событий  
 В дополнение к расчету выходных значений тикающий диспетчер времени выполняет и другие операции: он определяет состояние всех часов и вызывает соответствующие события.  
  
 Хотя такты меняются часто, между ними может возникать множество событий. Например <xref:System.Windows.Media.Animation.Clock> может остановлен, запущен и остановлен снова в таком случае его <xref:System.Windows.Media.Animation.Clock.CurrentState%2A> значение будет изменено три раза. В теории <xref:System.Windows.Media.Animation.Clock.CurrentStateInvalidated> событие может вызываться несколько раз в одном такте; Однако механизм времени объединяет события, позволяя <xref:System.Windows.Media.Animation.Clock.CurrentStateInvalidated> событие может вызываться не более одного раза за такт. Это справедливо для всех временных событий: не более одного события каждого типа вызывается для заданного <xref:System.Windows.Media.Animation.Clock> объекта.  
  
 При <xref:System.Windows.Media.Animation.Clock> изменяет состояние и возвращается обратно в исходное состояние между тактами (например после изменения <xref:System.Windows.Media.Animation.ClockState.Active> для <xref:System.Windows.Media.Animation.ClockState.Stopped> и вернуться к <xref:System.Windows.Media.Animation.ClockState.Active>), по-прежнему возникновении связанного события.  
  
 Дополнительные сведения о временных событиях см. в разделе [Общие сведения о временных событиях](timing-events-overview.md).  
  
<a name="currentvaluesbasevaluesofproperties"></a>   
## <a name="current-values-and-base-values-of-properties"></a>Текущие и базовые значения свойств  
 Анимированное свойство может иметь два значения: базовое значение и текущее. При задании свойства с помощью метода доступа CLR или <xref:System.Windows.DependencyObject.SetValue%2A> метод, устанавливается его базовое значение. Если свойство не анимировано, его базовое и текущее значения совпадают.  
  
 При анимации свойства, <xref:System.Windows.Media.Animation.AnimationClock> задает свойства *текущей* значение. Получение значения свойства посредством метода доступа CLR или <xref:System.Windows.DependencyObject.GetValue%2A> метод возвращает выходные данные <xref:System.Windows.Media.Animation.AnimationClock> при <xref:System.Windows.Media.Animation.AnimationClock> — <xref:System.Windows.Media.Animation.ClockState.Active> или <xref:System.Windows.Media.Animation.ClockState.Filling>. Базовое значение этого свойства можно получить с помощью <xref:System.Windows.Media.Animation.IAnimatable.GetAnimationBaseValue%2A> метод.  
  
## <a name="see-also"></a>См. также

- [Общие сведения об эффектах анимации](animation-overview.md)
- [Общие сведения о временных событиях](timing-events-overview.md)
- [Общие сведения о характере поведения во времени](timing-behaviors-overview.md)

---
title: Советы и рекомендации по анимации
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- troubleshooting [WPF], animation
- animations [WPF], FillBehavior property
- troubleshooting animation [WPF]
- animating objects [WPF], troubleshooting
- animation tips and tricks [WPF]
- tips and tricks [WPF], animation
- performance troubleshooting [WPF], animation
- animations [WPF], use of system resources
ms.assetid: e467796b-d5d4-45a6-a108-8c5d7ff69a0f
ms.openlocfilehash: 3a22c83eb739a735d42fa0f670716a0e75bbd54c
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59295956"
---
# <a name="animation-tips-and-tricks"></a>Советы и рекомендации по анимации
При работе с анимацией в [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)], существует ряд советов и приемов, которые анимациям работают лучше и сэкономить разочарований.  
  
<a name="generalissuessection"></a>   
## <a name="general-issues"></a>Общие проблемы  
  
### <a name="animating-the-position-of-a-scroll-bar-or-slider-freezes-it"></a>Анимация расположения полосы прокрутки или ползунка замораживает их  
 Если вы анимируете положение полосы прокрутки или ползунка с помощью анимации, которая имеет <xref:System.Windows.Media.Animation.FillBehavior> из <xref:System.Windows.Media.Animation.FillBehavior.HoldEnd> (значение по умолчанию), пользователь больше не будет иметь возможность перемещения полосы прокрутки или ползунка. Это происходит из-за того, что, хотя анимация завершена, она по-прежнему переопределяет базовое значение целевого свойства. Чтобы остановить анимация не переопределяла текущее значение свойства, удалить его или присвойте ему <xref:System.Windows.Media.Animation.FillBehavior> из <xref:System.Windows.Media.Animation.FillBehavior.Stop>. Дополнительные сведения и пример см. в разделе [Установка свойства после его анимации с помощью раскадровки](how-to-set-a-property-after-animating-it-with-a-storyboard.md).  
  
### <a name="animating-the-output-of-an-animation-has-no-effect"></a>Анимация выходных данных анимации ничего не делает  
 Невозможна анимация объекта, являющегося выходным объектом другой анимации. Например, если вы используете <xref:System.Windows.Media.Animation.ObjectAnimationUsingKeyFrames> для анимации <xref:System.Windows.Shapes.Shape.Fill%2A> из <xref:System.Windows.Shapes.Rectangle> из <xref:System.Windows.Media.RadialGradientBrush> для <xref:System.Windows.Media.SolidColorBrush>, невозможно анимировать никакие свойства <xref:System.Windows.Media.RadialGradientBrush> или <xref:System.Windows.Media.SolidColorBrush>.  
  
### <a name="cant-change-the-value-of-a-property-after-animating-it"></a>Невозможно изменить значение свойства после его анимации  
 В некоторых случаях может получиться так, что вы не сможете изменить значение свойства после его анимации, даже после завершения анимации. Это происходит из-за того, что, хотя анимация завершена, она по-прежнему переопределяет базовое значение свойства. Чтобы остановить анимация не переопределяла текущее значение свойства, удалить его или присвойте ему <xref:System.Windows.Media.Animation.FillBehavior> из <xref:System.Windows.Media.Animation.FillBehavior.Stop>. Дополнительные сведения и пример см. в разделе [Установка свойства после его анимации с помощью раскадровки](how-to-set-a-property-after-animating-it-with-a-storyboard.md).  
  
### <a name="changing-a-timeline-has-no-effect"></a>Изменение временной шкалы ничего не делает  
 Несмотря на то что большинство <xref:System.Windows.Media.Animation.Timeline> анимируемых свойств и могут быть привязаны к данным, изменение значений свойств активного <xref:System.Windows.Media.Animation.Timeline> не дает эффекта. Это потому, что, когда <xref:System.Windows.Media.Animation.Timeline> является начали, система времени создает копию <xref:System.Windows.Media.Animation.Timeline> и использует ее для создания <xref:System.Windows.Media.Animation.Clock> объекта. Изменение исходного объекта не влияет на сделанную системой копию.  
  
 Для <xref:System.Windows.Media.Animation.Timeline> для отражения изменений, необходимо повторно и заменить ранее созданные часы ее часы. Автоматическое повторное создание часов не выполняется. Ниже показано несколько способов применения изменений временной шкалы.  
  
-   Если временная шкала или принадлежит <xref:System.Windows.Media.Animation.Storyboard>, его можно сделать отражать изменения посредством применения его с помощью раскадровки <xref:System.Windows.Media.Animation.BeginStoryboard> или <xref:System.Windows.Media.Animation.Storyboard.Begin%2A> метод. Это имеет побочный эффект в виде перезапуска анимации. В коде, можно использовать <xref:System.Windows.Media.Animation.Storyboard.Seek%2A> резервного метода для возврата раскадровки в предыдущее положение.  
  
-   Если анимация применяется непосредственно к свойству с помощью <xref:System.Windows.Media.Animation.Animatable.BeginAnimation%2A> мы вызываем метод <xref:System.Windows.Media.Animation.Animatable.BeginAnimation%2A> снова метод и передать его анимации, которые были изменены.  
  
-   При работе непосредственно на уровне часов создайте и примените новый набор часов и используйте его для замены предыдущего набора созданных часов.  
  
 Дополнительные сведения о временных шкалах и часах см. в разделе [анимации и общие сведения о характере системы](animation-and-timing-system-overview.md).  
  
### <a name="fillbehaviorstop-doesnt-work-as-expected"></a>FillBehavior.Stop не работает должным образом  
 Иногда при задании <xref:System.Windows.Media.Animation.Timeline.FillBehavior%2A> свойства <xref:System.Windows.Media.Animation.FillBehavior.Stop> кажется, что не происходит, например, когда одна анимация «передает» на другой, так как он имеет <xref:System.Windows.Media.Animation.BeginStoryboard.HandoffBehavior%2A> параметр <xref:System.Windows.Media.Animation.HandoffBehavior.SnapshotAndReplace>.  
  
 В следующем примере создается <xref:System.Windows.Controls.Canvas>, <xref:System.Windows.Shapes.Rectangle> и <xref:System.Windows.Media.TranslateTransform>. <xref:System.Windows.Media.TranslateTransform> Анимируется для перемещения <xref:System.Windows.Shapes.Rectangle> вокруг <xref:System.Windows.Controls.Canvas>.  
  
 [!code-xaml[AnimationTipsAndTricksSample_snip#FillBehaviorTipAnimatedObject](~/samples/snippets/csharp/VS_Snippets_Wpf/AnimationTipsAndTricksSample_snip/CSharp/FillBehaviorTip.xaml#fillbehaviortipanimatedobject)]  
  
 В примерах в этом разделе используются описанные выше объекты для демонстрации нескольких случаев, где <xref:System.Windows.Media.Animation.Timeline.FillBehavior%2A> свойство не работает, как следует из его.  
  
#### <a name="fillbehaviorstop-and-handoffbehavior-with-multiple-animations"></a>FillBehavior="Stop" и HandoffBehavior с несколькими анимациями  
 Иногда кажется, что анимация игнорирует его <xref:System.Windows.Media.Animation.Timeline.FillBehavior%2A> свойство при ее замене второй анимацией. Рассмотрим следующий пример, который создает два <xref:System.Windows.Media.Animation.Storyboard> и использует их для анимации <xref:System.Windows.Media.TranslateTransform> показано в предыдущем примере.  
  
 Первый <xref:System.Windows.Media.Animation.Storyboard>, `B1`, анимирует <xref:System.Windows.Media.TranslateTransform.X%2A> свойство <xref:System.Windows.Media.TranslateTransform> от 0 до 350, который перемещает прямоугольник на 350 пикселей вправо. При анимации достигает окончания своей длительности и прекращает воспроизведение, <xref:System.Windows.Media.TranslateTransform.X%2A> , свойство возвращается к исходному значению, 0. В результате прямоугольник перемещается вправо на 350 пикселей, а затем перепрыгивает обратно в исходное положение.  
  
 [!code-xaml[AnimationTipsAndTricksSample_snip#FillBehaviorTipStoryboardB1Button](~/samples/snippets/csharp/VS_Snippets_Wpf/AnimationTipsAndTricksSample_snip/CSharp/FillBehaviorTip.xaml#fillbehaviortipstoryboardb1button)]  
  
 Второй <xref:System.Windows.Media.Animation.Storyboard>, `B2`, также анимирует <xref:System.Windows.Media.TranslateTransform.X%2A> свойство одной и той же <xref:System.Windows.Media.TranslateTransform>. Так как только <xref:System.Windows.Media.Animation.DoubleAnimation.To%2A> свойство анимации в этом <xref:System.Windows.Media.Animation.Storyboard> не установлен, анимация использует текущее значение анимируемого свойства в качестве своего начального значения.  
  
 [!code-xaml[AnimationTipsAndTricksSample_snip#FillBehaviorTipStoryboardB2Button](~/samples/snippets/csharp/VS_Snippets_Wpf/AnimationTipsAndTricksSample_snip/CSharp/FillBehaviorTip.xaml#fillbehaviortipstoryboardb2button)]  
  
 При нажатии второй кнопки во время первого <xref:System.Windows.Media.Animation.Storyboard> — воспроизведение, можно предположить следующее поведение:  
  
1. Первая раскадровка заканчивается и отправляет прямоугольник в исходное положение, поскольку анимация имеет <xref:System.Windows.Media.Animation.Timeline.FillBehavior%2A> из <xref:System.Windows.Media.Animation.FillBehavior.Stop>.  
  
2. Вторая раскадровка вступает в силу и анимируется от текущей позиции, которая теперь имеет значение 0, до 500.  
  
 **Но это не происходит.** Прямоугольник не прыгает обратно; он продолжает перемещаться вправо. Это происходит потому, что вторая анимация использует текущее значение первой анимации в качестве своего начального значения и анимируется от этого значения до 500. Когда вторая анимация заменяет первый, так как <xref:System.Windows.Media.Animation.HandoffBehavior.SnapshotAndReplace><xref:System.Windows.Media.Animation.HandoffBehavior> используется, <xref:System.Windows.Media.Animation.FillBehavior> первой анимации не имеет значения.  
  
#### <a name="fillbehavior-and-the-completed-event"></a>FillBehavior и завершенное событие  
 В следующем примере показывается другой сценарий, в котором <xref:System.Windows.Media.Animation.FillBehavior.Stop><xref:System.Windows.Media.Animation.Timeline.FillBehavior%2A> не дает эффекта. Опять же, в примере используется раскадровка для анимации <xref:System.Windows.Media.TranslateTransform.X%2A> свойство <xref:System.Windows.Media.TranslateTransform> от 0 до 350. Тем не менее, это время в примере регистрируется для <xref:System.Windows.Media.Animation.Timeline.Completed> событий.  
  
 [!code-xaml[AnimationTipsAndTricksSample_snip#FillBehaviorTipStoryboardCButton](~/samples/snippets/csharp/VS_Snippets_Wpf/AnimationTipsAndTricksSample_snip/CSharp/FillBehaviorTip.xaml#fillbehaviortipstoryboardcbutton)]  
  
 <xref:System.Windows.Media.Animation.Timeline.Completed> Обработчик запускает другой <xref:System.Windows.Media.Animation.Storyboard> которая анимирует то же свойство от его текущего значения до 500.  
  
 [!code-csharp[AnimationTipsAndTricksSample_snip#FillBehaviorTipStoryboardC1CompletedHandler](~/samples/snippets/csharp/VS_Snippets_Wpf/AnimationTipsAndTricksSample_snip/CSharp/FillBehaviorTip.xaml.cs#fillbehaviortipstoryboardc1completedhandler)]
   
  
 Ниже приведена разметка, определяющая вторую <xref:System.Windows.Media.Animation.Storyboard> как ресурс.  
  
 [!code-xaml[AnimationTipsAndTricksSample_snip#FillBehaviorTipResources](~/samples/snippets/csharp/VS_Snippets_Wpf/AnimationTipsAndTricksSample_snip/CSharp/FillBehaviorTip.xaml#fillbehaviortipresources)]  
  
 При запуске <xref:System.Windows.Media.Animation.Storyboard>, можно ожидать <xref:System.Windows.Media.TranslateTransform.X%2A> свойство <xref:System.Windows.Media.TranslateTransform> анимируется от 0 до 350, затем вернется к 0 после ее завершения (поскольку в нем <xref:System.Windows.Media.Animation.FillBehavior> параметр <xref:System.Windows.Media.Animation.FillBehavior.Stop>) и затем будет анимироваться от 0 до 500. Вместо этого <xref:System.Windows.Media.TranslateTransform> выполняет анимацию от 0 до 350, а затем до 500.  
  
 Это порядок, в котором [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] вызывает события и потому, что значения свойств кэшируются и не пересчитываются, если свойство является действительным. <xref:System.Windows.Media.Animation.Timeline.Completed> Событие обрабатывается первым, так как оно было вызвано корневой временной шкалой (первой <xref:System.Windows.Media.Animation.Storyboard>). В настоящее время <xref:System.Windows.Media.TranslateTransform.X%2A> свойство по-прежнему возвращает свое анимированное значение, так как он еще не стало недействительным. Второй <xref:System.Windows.Media.Animation.Storyboard> использует кэшированное значение в качестве своего начального значения и начинает анимацию.  
  
<a name="performancesection"></a>   
## <a name="performance"></a>Производительность  
  
### <a name="animations-continue-to-run-after-navigating-away-from-a-page"></a>Анимация продолжает выполняться после ухода со страницы  
 При переходе от <xref:System.Windows.Controls.Page> , есть работающие анимации, эти анимации продолжают выполняться до <xref:System.Windows.Controls.Page> удаляется сборщиком мусора. В зависимости от используемой системы навигации страница, с которой ушли, может оставаться в памяти неограниченное количество времени, постоянно потребляя ресурсы на анимацию. Это наиболее заметно, когда страница содержит постоянно выполняющиеся анимации ("фоновые").  
  
 По этой причине рекомендуется использовать <xref:System.Windows.FrameworkElement.Unloaded> событий для удаления анимаций, когда вы уходите со страницы.  
  
 Анимацию можно удалить разными способами. Следующие методы можно использовать для удаления анимаций, принадлежащих <xref:System.Windows.Media.Animation.Storyboard>.  
  
-   Чтобы удалить <xref:System.Windows.Media.Animation.Storyboard> вы начали с помощью триггера события, см. в разделе [как: Удаление раскадровки](https://docs.microsoft.com/previous-versions/dotnet/netframework-3.5/ms749412(v=vs.90)).  
  
-   Чтобы использовать код для удаления <xref:System.Windows.Media.Animation.Storyboard>, см. в разделе <xref:System.Windows.Media.Animation.Storyboard.Remove%2A> метод.  
  
 Следующий метод может использоваться независимо от того, как была запущена анимация.  
  
-   Чтобы удалить анимацию из определенного свойства, используйте <xref:System.Windows.Media.Animation.Animatable.BeginAnimation%28System.Windows.DependencyProperty%2CSystem.Windows.Media.Animation.AnimationTimeline%29> метод. Укажите в качестве первого параметра анимируемое свойство и `null` как второй. Это удалит из свойства все часы анимации.  
  
 Дополнительные сведения о различных способах анимации свойств см. в разделе [Общие сведения о методах анимации свойств](property-animation-techniques-overview.md).  
  
### <a name="using-the-compose-handoffbehavior-consumes-system-resources"></a>Использование составного HandoffBehavior потребляет системные ресурсы  
 При применении <xref:System.Windows.Media.Animation.Storyboard>, <xref:System.Windows.Media.Animation.AnimationTimeline>, или <xref:System.Windows.Media.Animation.AnimationClock> к свойству с помощью <xref:System.Windows.Media.Animation.HandoffBehavior.Compose><xref:System.Windows.Media.Animation.HandoffBehavior>любые <xref:System.Windows.Media.Animation.Clock> ранее связанную с ним объекты по-прежнему потребляют ресурсы системы; система управления временем не удаляет эти часы автоматически.  
  
 Чтобы избежать проблем с производительностью при применении большого количества часов через <xref:System.Windows.Media.Animation.HandoffBehavior.Compose>, следует удалять составные часы из анимируемого свойства после их завершения. Есть несколько способов удаления часов.  
  
-   Чтобы удалить все часы из свойства, используйте <xref:System.Windows.Media.Animation.Animatable.ApplyAnimationClock%28System.Windows.DependencyProperty%2CSystem.Windows.Media.Animation.AnimationClock%29> или <xref:System.Windows.Media.Animation.Animatable.BeginAnimation%28System.Windows.DependencyProperty%2CSystem.Windows.Media.Animation.AnimationTimeline%29> метод анимируемого объекта. Укажите в качестве первого параметра анимируемое свойство и `null` как второй. Это удалит из свойства все часы анимации.  
  
-   Чтобы удалить определенные <xref:System.Windows.Media.Animation.AnimationClock> из списка часов, используйте <xref:System.Windows.Media.Animation.Clock.Controller%2A> свойство <xref:System.Windows.Media.Animation.AnimationClock> извлекаемого <xref:System.Windows.Media.Animation.ClockController>, затем вызвать <xref:System.Windows.Media.Animation.ClockController.Remove%2A> метод <xref:System.Windows.Media.Animation.ClockController>. Обычно это делается <xref:System.Windows.Media.Animation.Clock.Completed> обработчик событий для часов. Обратите внимание, что только корневые часы могут управляться <xref:System.Windows.Media.Animation.ClockController>; <xref:System.Windows.Media.Animation.Clock.Controller%2A> свойство дочерних часов вернет `null`. Обратите внимание, что <xref:System.Windows.Media.Animation.Clock.Completed> событие не будет вызываться, если эффективная продолжительность часов — forever.  В этом случае пользователю будет необходимо определить, когда нужно вызывать <xref:System.Windows.Media.Animation.ClockController.Remove%2A>.  
  
 В основном это проблема для анимации объектов, имеющих длинное время жизни.  Когда объект собирается как мусор, его часы отсоединяются и также собираются как мусор.  
  
 Дополнительные сведения об объектах часов см. в разделе [анимации и общие сведения о характере системы](animation-and-timing-system-overview.md).  
  
## <a name="see-also"></a>См. также

- [Общие сведения об эффектах анимации](animation-overview.md)

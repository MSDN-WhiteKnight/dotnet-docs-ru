---
title: Общие сведения о временных событиях
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- timelines [WPF]
- timing events [WPF]
ms.assetid: 597e3280-0867-4359-a97b-5b2f4149e350
ms.openlocfilehash: 91e335f4d5adaa5279fb16805604f2e2848eeb8b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59167171"
---
# <a name="timing-events-overview"></a>Общие сведения о временных событиях
В этом разделе описываются способы использования пяти временных событий, доступных на <xref:System.Windows.Media.Animation.Timeline> и <xref:System.Windows.Media.Animation.Clock> объектов.  
  
## <a name="prerequisites"></a>Предварительные требования  
 Для понимания этого раздела вы должны знать, как создавать и использовать анимации. Чтобы приступить к работе с анимацией, см. в разделе [Общие сведения об анимации](animation-overview.md).  
  
 Существует несколько способов анимирования свойств в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]:  
  
-   **Использование объектов раскадровки** (разметки и кода): Можно использовать <xref:System.Windows.Media.Animation.Storyboard> упорядочить анимации для одного или нескольких объектов и объектов. Например, см. в разделе [анимация свойства с помощью раскадровки](how-to-animate-a-property-by-using-a-storyboard.md).  
  
-   **Использование локальных анимаций** (только в коде): Можно применить <xref:System.Windows.Media.Animation.AnimationTimeline> объекты непосредственно к анимируемым свойствам. Пример см. в разделе [Анимация свойства без использования раскадровки](how-to-animate-a-property-without-using-a-storyboard.md).  
  
-   **Использование часов** (только в коде): Кроме того, можно явно управлять созданием часов и самостоятельно распределять часы для анимации.  Например, см. в разделе [Анимирование свойства с помощью AnimationClock](how-to-animate-a-property-by-using-an-animationclock.md).  
  
 Так как их можно использовать в разметке и коде, в примерах в этом обзоре используются <xref:System.Windows.Media.Animation.Storyboard> объектов. Тем не менее описанные здесь идеи также применяются к другим методам анимирования свойств.  
  
### <a name="what-is-a-clock"></a>Что такое часы?  
 Временная шкала сама по себе просто описывает сегмент времени. Он является временной шкалы <xref:System.Windows.Media.Animation.Clock> объект, который не работает: он обеспечивает связана со временем состояние времени выполнения для временной шкалы. В большинстве случаев, например при использовании раскадровок, часы для временной шкалы создаются автоматически. Вы также можете создать <xref:System.Windows.Media.Animation.Clock> явным образом с помощью <xref:System.Windows.Media.Animation.Timeline.CreateClock%2A> метод. Дополнительные сведения о <xref:System.Windows.Media.Animation.Clock> объектов, см. в разделе [анимации и общие сведения о характере системы](animation-and-timing-system-overview.md).  
  
## <a name="why-use-events"></a>Зачем использовать события?  
 Все интерактивные временные операции являются асинхронными. Исключение составляет лишь поиск, который выравнивается по последнему такту. Точно определить, когда будут выполнены операции, невозможно. При наличии другого кода, который зависит от вашей операции, это может вызвать проблемы. Предположим, что вы хотите остановить временную шкалу, которая анимировала прямоугольник. После остановки временной шкалы вы изменяете цвет прямоугольника.  
  
 [!code-csharp[events_procedural#NeedForEventsFragment](~/samples/snippets/csharp/VS_Snippets_Wpf/events_procedural/CSharp/EventExample.cs#needforeventsfragment)]
   
  
 В предыдущем примере вторая строка кода может быть выполнена до того, как раскадровка будет остановлена. Это вызвано тем, что остановка является асинхронной операцией. При отправке команды на остановку временной шкалы или часов создается своего рода "запрос на остановку". Этот запрос обрабатывается только на следующем такте системы управления временем.  
  
 Для выполнения команд после завершения временной шкалы используйте временные события. В следующем примере для изменения цвета прямоугольника после окончания воспроизведения раскадровки используется обработчик событий.  
  
 [!code-csharp[events_procedural#RegisterForStoryboardCurrentStateInvalidatedEvent](~/samples/snippets/csharp/VS_Snippets_Wpf/events_procedural/CSharp/EventExample.cs#registerforstoryboardcurrentstateinvalidatedevent)]
   
[!code-csharp[events_procedural#StoryboardCurrentStateInvalidatedEvent2](~/samples/snippets/csharp/VS_Snippets_Wpf/events_procedural/CSharp/EventExample.cs#storyboardcurrentstateinvalidatedevent2)]
  
  
 Более полный пример, см. в разделе [получения уведомлений при изменениях состояния часов](how-to-receive-notification-when-clock-state-changes.md).  
  
## <a name="public-events"></a>Открытые события  
 <xref:System.Windows.Media.Animation.Timeline> И <xref:System.Windows.Media.Animation.Clock> классы предоставляют пять временных событий. В следующей таблице перечислены эти события и условия, которые их вызывают.  
  
|событие|Интерактивная операция, вызывающая событие|Другие условия|  
|-----------|--------------------------------------|--------------------|  
|**Завершено**|Переход к заполнению|Часы останавливаются.|  
|**CurrentGlobalSpeedInvalidated**|Пауза, возобновление, поиск, установка соотношения скорости, переход к заполнению|Часы запускаются в обратном направлении, ускоряются, запускаются в обычном направлении или останавливаются.|  
|**CurrentStateInvalidated**|Начало, переход к заполнению, остановка|Часы запускаются, останавливаются, или выполняется заполнение.|  
|**CurrentTimeInvalidated**|Начало, поиск, переход к заполнению, остановка|Часы работают.|  
|**RemoveRequested**|Удалить||  
  
## <a name="ticking-and-event-consolidation"></a>Такты и объединение событий  
 При анимации объектов в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], обработчик синхронизации управляет анимациями. Система управления временем отслеживает ход времени и вычисляет состояние каждой анимации. Она выполняет эти действия несколько раз в секунду. Такие вычислительные проходы называются "тактами".  
  
 Хотя такты меняются часто, между ними может возникать множество событий. Например, временная шкала может быть остановлена, запущена и снова остановлена, в этом случае ее состояние будет изменено три раза. Теоретически событие может вызываться несколько раз в одном такте. Однако система управления временем объединяет события, чтобы каждое событие могло происходить не более одного раза за такт.  
  
## <a name="registering-for-events"></a>Регистрация в событиях  
 Существует два способа регистрации временных событий: их можно зарегистрировать на временной шкале и на часах, созданных на основе временной шкалы. Регистрация события непосредственно на часах достаточно проста, но ее можно выполнить только в коде. Зарегистрировать события на временной шкале можно как в коде, так и в разметке. В следующем разделе описано, как зарегистрировать события часов на временной шкале.  
  
<a name="registeringforclockeventswithatimeline"></a>   
## <a name="registering-for-clock-events-with-a-timeline"></a>Регистрация событий часов на временной шкале  
 Несмотря на то что временной шкалы <xref:System.Windows.Media.Animation.Timeline.Completed>, <xref:System.Windows.Media.Animation.Timeline.CurrentGlobalSpeedInvalidated>, <xref:System.Windows.Media.Animation.Timeline.CurrentStateInvalidated>, <xref:System.Windows.Media.Animation.Timeline.CurrentTimeInvalidated>, и <xref:System.Windows.Media.Animation.Timeline.RemoveRequested> события могут быть связаны с временной шкалой, регистрация для этих событий фактически связывает обработчик событий с <xref:System.Windows.Media.Animation.Clock> созданным для временной шкалы.  
  
 При регистрации для <xref:System.Windows.Media.Animation.Timeline.Completed> события на временной шкале, например, фактически дается система для регистрации <xref:System.Windows.Media.Animation.Clock.Completed> событий всех часов, которая создается для временной шкалы. В коде, необходимо зарегистрировать для этого события перед <xref:System.Windows.Media.Animation.Clock> создается для этой шкалы времени; в противном случае вы не получите уведомление. Это происходит автоматически в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)]; средство синтаксического анализа автоматически регистрирует событие до <xref:System.Windows.Media.Animation.Clock> создается.  
  
## <a name="see-also"></a>См. также

- [Общие сведения об анимации и системе управления временем](animation-and-timing-system-overview.md)
- [Общие сведения об эффектах анимации](animation-overview.md)
- [Общие сведения о характере поведения во времени](timing-behaviors-overview.md)

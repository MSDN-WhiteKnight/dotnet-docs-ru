---
title: Совместное использование циклов обработки сообщений между Win32 и WPF
ms.date: 03/30/2017
helpviewer_keywords:
- Win32 code [WPF], sharing message loops
- message loops [WPF]
- sharing message loops [WPF]
- interoperability [WPF], Win32
ms.assetid: 39ee888c-e5ec-41c8-b11f-7b851a554442
ms.openlocfilehash: 74055ec3facb7db9145c4c0e969d57da24eccbc8
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59115080"
---
# <a name="sharing-message-loops-between-win32-and-wpf"></a>Совместное использование циклов обработки сообщений между Win32 и WPF
В этом разделе описывается, как реализовать цикл обработки сообщений для взаимодействия с [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)], либо с помощью существующих сообщений раскрытия цикл в <xref:System.Windows.Threading.Dispatcher> или создав цикл обработки отдельных сообщений на [!INCLUDE[TLA#tla_win32](../../../../includes/tlasharptla-win32-md.md)] сторона кода взаимодействия.  
  
## <a name="componentdispatcher-and-the-message-loop"></a>Диспетчер компонента и цикл обработки сообщений  
 Обычный сценарий для взаимодействия и поддержки события клавиатуры — для реализации <xref:System.Windows.Interop.IKeyboardInputSink>, или подкласса из классов, которые уже реализуют <xref:System.Windows.Interop.IKeyboardInputSink>, такие как <xref:System.Windows.Interop.HwndSource> или <xref:System.Windows.Interop.HwndHost>. Тем не менее поддержка приемника клавиатуры не рассматриваются все возможные циклам обработки сообщений вы можете столкнуться при отправке и получении сообщений через ваши границы взаимодействия. Чтобы помочь формализовать архитектуру цикла обработки сообщений приложения, [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] предоставляет <xref:System.Windows.Interop.ComponentDispatcher> класс, который определяет простой протокол для цикла обработки сообщений для выполнения.  
  
 <xref:System.Windows.Interop.ComponentDispatcher> — Это статический класс, предоставляющий несколько членов. Область каждого метода неявно привязаны в вызывающий поток. Цикл обработки сообщений должен вызывать некоторые из них [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)] в критические моменты времени (как определено в следующем разделе).  
  
 <xref:System.Windows.Interop.ComponentDispatcher> Предоставляет события, которые может прослушивать других компонентов (таких как приемник ввода от клавиатуры). <xref:System.Windows.Threading.Dispatcher> Класса вызывает соответствующие <xref:System.Windows.Interop.ComponentDispatcher> методов в соответствующей последовательности. Если вы реализуете собственный цикл обработки сообщений, код отвечает за вызов метода <xref:System.Windows.Interop.ComponentDispatcher> методы таким же образом.  
  
 Вызов <xref:System.Windows.Interop.ComponentDispatcher> методы в потоке только будет вызывать обработчики событий, которые были зарегистрированы в этом потоке.  
  
## <a name="writing-message-loops"></a>Написание циклов обработки сообщений  
 Ниже приведен контрольный список <xref:System.Windows.Interop.ComponentDispatcher> членов, которые будет использовать при написании собственного цикла обработки сообщений:  
  
-   <xref:System.Windows.Interop.ComponentDispatcher.PushModal%2A>: ваш цикл обработки сообщений должен вызывать его, чтобы указать, что поток является модальным.  
  
-   <xref:System.Windows.Interop.ComponentDispatcher.PopModal%2A>: ваш цикл обработки сообщений должен вызывать его, чтобы указать, что поток обращается к немодальным.  
  
-   <xref:System.Windows.Interop.ComponentDispatcher.RaiseIdle%2A>: ваш цикл обработки сообщений должен вызывать его, чтобы указать, что <xref:System.Windows.Interop.ComponentDispatcher> должен вызывать <xref:System.Windows.Interop.ComponentDispatcher.ThreadIdle> событий. <xref:System.Windows.Interop.ComponentDispatcher> не вызовут <xref:System.Windows.Interop.ComponentDispatcher.ThreadIdle> Если <xref:System.Windows.Interop.ComponentDispatcher.IsThreadModal%2A> — `true`, но циклы обработки сообщений, можно вызвать <xref:System.Windows.Interop.ComponentDispatcher.RaiseIdle%2A> даже в том случае, если <xref:System.Windows.Interop.ComponentDispatcher> не может отвечать на него в модальном состоянии.  
  
-   <xref:System.Windows.Interop.ComponentDispatcher.RaiseThreadMessage%2A>: ваш цикл обработки сообщений должен вызывать его, чтобы указать, что доступно новое сообщение. Возвращаемое значение отражает ли прослушиватель для <xref:System.Windows.Interop.ComponentDispatcher> сообщение обработано событие. Если <xref:System.Windows.Interop.ComponentDispatcher.RaiseThreadMessage%2A> возвращает `true` (обработано), диспетчер в дальнейшем ничего с сообщением. Если возвращается значение `false`, диспетчер ожидает вызов [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] функция `TranslateMessage`, затем вызвать `DispatchMessage`.  
  
## <a name="using-componentdispatcher-and-existing-message-handling"></a>Использование диспетчера компонента и обработки существующих сообщений  
 Ниже приведен контрольный список <xref:System.Windows.Interop.ComponentDispatcher> членов, которые будет использовать при работе с внутренними запросами WPF цикл обработки сообщений.  
  
-   <xref:System.Windows.Interop.ComponentDispatcher.IsThreadModal%2A>: возвращает ли приложение становится модальным (например, цикл обработки сообщений модальное был отправлен). <xref:System.Windows.Interop.ComponentDispatcher> может отслеживать это состояние, так как класс хранит количество <xref:System.Windows.Interop.ComponentDispatcher.PushModal%2A> и <xref:System.Windows.Interop.ComponentDispatcher.PopModal%2A> вызовы из цикла обработки сообщений.  
  
-   <xref:System.Windows.Interop.ComponentDispatcher.ThreadFilterMessage> и <xref:System.Windows.Interop.ComponentDispatcher.ThreadPreprocessMessage> событий выполните стандартные правила для вызова делегата. Делегаты вызываются в неопределенном порядке, и вызываются все делегаты, даже если первый из них помечает сообщение как обработанное.  
  
-   <xref:System.Windows.Interop.ComponentDispatcher.ThreadIdle>: указывает на соответствующий и эффективное время простоя обработки (нет других ожидающих сообщений для потока). <xref:System.Windows.Interop.ComponentDispatcher.ThreadIdle> не будет вызываться, если поток является модальным.  
  
-   <xref:System.Windows.Interop.ComponentDispatcher.ThreadFilterMessage>: вызывается для всех сообщений, обрабатываемых сообщений.  
  
-   <xref:System.Windows.Interop.ComponentDispatcher.ThreadPreprocessMessage>: вызывается для всех сообщений, которые не были обработаны во время <xref:System.Windows.Interop.ComponentDispatcher.ThreadFilterMessage>.  
  
 Сообщение считается обработанным, если после <xref:System.Windows.Interop.ComponentDispatcher.ThreadFilterMessage> событий или <xref:System.Windows.Interop.ComponentDispatcher.ThreadPreprocessMessage> событий, `handled` параметр, передаваемый по ссылке в данных события является `true`. Обработчики событий должен игнорировать это сообщение, если `handled` является `true`, так как это означает, что другой обработчик обработал сообщение первым. Обработчики событий для обоих событий могут изменить сообщение. Диспетчер должен отправлять измененное сообщение, а не исходное сообщение без изменений. <xref:System.Windows.Interop.ComponentDispatcher.ThreadPreprocessMessage> доставляется всем прослушивателям, но архитектурно том, что только окно верхнего уровня, содержащий HWND, с которой сообщения должны вызвать код в ответ на сообщение.  
  
## <a name="how-hwndsource-treats-componentdispatcher-events"></a>Как HwndSource Рассматривает события диспетчера компонента  
 Если <xref:System.Windows.Interop.HwndSource> является окном верхнего уровня (нет родительского HWND), будет зарегистрирован <xref:System.Windows.Interop.ComponentDispatcher>. Если <xref:System.Windows.Interop.ComponentDispatcher.ThreadPreprocessMessage> возникает, если сообщение предназначено для <xref:System.Windows.Interop.HwndSource> или дочерних окон <xref:System.Windows.Interop.HwndSource> вызовы его <xref:System.Windows.Interop.HwndSource.System%23Windows%23Interop%23IKeyboardInputSink%23TranslateAccelerator%2A>, <xref:System.Windows.Interop.IKeyboardInputSink.TranslateChar%2A>, <xref:System.Windows.Interop.IKeyboardInputSink.OnMnemonic%2A> последовательность приемника клавиатуры.  
  
 Если <xref:System.Windows.Interop.HwndSource> не является окном верхнего уровня (имеет родительский элемент HWND), будет существовать без обработки. Только окно верхнего уровня должен выполнять обработку и оно должно быть окном верхнего уровня с поддержкой приемника клавиатуры как часть любого скрипта взаимодействия.  
  
 Если <xref:System.Windows.Interop.HwndHost.WndProc%2A> на <xref:System.Windows.Interop.HwndSource> вызывается без вызова метода приемника сочетания, приложение получит более высокоуровневые события клавиатуры например <xref:System.Windows.UIElement.KeyDown>. Однако методы приемник не клавиатуры будет вызываться, которые нарушают функции модели ввода клавиатуры, такие как поддержка ключа доступа. Это может произойти, когда цикл обработки сообщений не уведомил соответствующий поток на <xref:System.Windows.Interop.ComponentDispatcher>, либо потому, что родительское HWND не вызвало соответствующие ответы приемника клавиатуры.  
  
 Это сообщение в приемник ввода от клавиатуры не могут отправляться на HWND, обработчики для данного сообщения, добавленные с помощью <xref:System.Windows.Interop.HwndSource.AddHook%2A> метод. Сообщение может быть обработано на уровне загрузки сообщений напрямую и не отправлено `DispatchMessage` функции.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Interop.ComponentDispatcher>
- <xref:System.Windows.Interop.IKeyboardInputSink>
- [Взаимодействие WPF и Win32](wpf-and-win32-interoperation.md)
- [Модель потоков](threading-model.md)
- [Общие сведения о входных данных](input-overview.md)

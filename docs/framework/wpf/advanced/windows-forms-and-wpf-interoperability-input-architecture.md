---
title: Windows Forms и архитектура ввода взаимодействия WPF
ms.date: 03/30/2017
helpviewer_keywords:
- input architecture [WPF interoperability]
- messages [WPF]
- Windows Forms [WPF], interoperability with
- Windows Forms [WPF], WPF interoperation
- interoperability [WPF], Windows Forms
- modeless forms [WPF]
- ElementHost keyboard and messages [WPF]
- keyboard interoperation [WPF]
- WindowsFormsHost keyboard and messages [WPF]
- modeless dialog boxes [WPF]
ms.assetid: 0eb6f137-f088-4c5e-9e37-f96afd28f235
ms.openlocfilehash: 2df754c0c47ea99c0892e0b9365da5589f2eab76
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59335723"
---
# <a name="windows-forms-and-wpf-interoperability-input-architecture"></a>Windows Forms и архитектура ввода взаимодействия WPF
Взаимодействия между WPF и [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] должна иметь обработки ввода сочетания обеих технологий. В этом разделе описывается, как реализовать эти технологии, клавиатуры и обработки сообщений с целью обеспечить корректное взаимодействие в гибридных приложениях.  
  
 В этом разделе содержатся следующие подразделы:  
  
-   Безрежимные формы и диалоговые окна  
  
-   WindowsFormsHost-клавиатура и обработки сообщений  
  
-   ElementHost-клавиатура и обработки сообщений  
  
## <a name="modeless-forms-and-dialog-boxes"></a>Безрежимные формы и диалоговые окна  
 Вызовите <xref:System.Windows.Forms.Integration.WindowsFormsHost.EnableWindowsFormsInterop%2A> метод <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемента для размыкания немодальное форму или диалоговое окно из WPF-приложения на основе.  
  
 Вызовите <xref:System.Windows.Forms.Integration.ElementHost.EnableModelessKeyboardInterop%2A> метод <xref:System.Windows.Forms.Integration.ElementHost> элемента управления, чтобы открыть немодальный WPF странице в [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)]-приложения на основе.  
  
## <a name="windowsformshost-keyboard-and-message-processing"></a>WindowsFormsHost-клавиатура и обработки сообщений  
 Если они размещаются в WPF-приложения, на основе [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] клавиатуры и обработка состоит из следующих сообщений:  
  
-   <xref:System.Windows.Forms.Integration.WindowsFormsHost> Класс получает сообщения из WPF цикл обработки сообщений, который реализован <xref:System.Windows.Interop.ComponentDispatcher> класса.  
  
-   <xref:System.Windows.Forms.Integration.WindowsFormsHost> Класс создает суррогат [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] цикл обработки сообщений, чтобы убедиться, что обычные [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] происходит обработка клавиатуры.  
  
-   <xref:System.Windows.Forms.Integration.WindowsFormsHost> Класс реализует <xref:System.Windows.Interop.IKeyboardInputSink> интерфейс для координации управления фокусом с WPF.  
  
-   <xref:System.Windows.Forms.Integration.WindowsFormsHost> Элементы управления зарегистрироваться и начать их циклы обработки сообщений.  
  
 В следующих разделах эти части процесса более подробно.  
  
### <a name="acquiring-messages-from-the-wpf-message-loop"></a>Получение сообщений из цикла обработки сообщений WPF  
 <xref:System.Windows.Interop.ComponentDispatcher> Класс реализует диспетчер цикла сообщений для WPF. <xref:System.Windows.Interop.ComponentDispatcher> Класс предоставляет обработчики для внешние клиенты могли фильтровать сообщения перед WPF обрабатывает их.  
  
 Взаимодействия реализация обрабатывает <xref:System.Windows.Interop.ComponentDispatcher.ThreadFilterMessage?displayProperty=nameWithType> событие, которое позволяет [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементы управления для обработки сообщений перед WPF элементов управления.  
  
### <a name="surrogate-windows-forms-message-loop"></a>Цикл обработки сообщений суррогат Windows Forms  
 По умолчанию <xref:System.Windows.Forms.Application?displayProperty=nameWithType> класс содержит цикл основного сообщения для [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] приложений. Во время взаимодействия [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] сообщение, цикл не обрабатывает сообщения. Таким образом эта логика должна быть воспроизведена. Обработчик <xref:System.Windows.Interop.ComponentDispatcher.ThreadFilterMessage?displayProperty=nameWithType> событий выполняет следующие действия:  
  
1. Фильтрует сообщения с помощью <xref:System.Windows.Forms.IMessageFilter> интерфейс.  
  
2. Вызывает метод <xref:System.Windows.Forms.Control.PreProcessMessage%2A?displayProperty=nameWithType>.  
  
3. Преобразует и отправляет сообщение, если это необходимо.  
  
4. Передает сообщение для размещения элемента управления, если нет других элементов управления обработки сообщения.  
  
### <a name="ikeyboardinputsink-implementation"></a>Реализация IKeyboardInputSink  
 Суррогатный цикл обработки сообщений обрабатывает управление клавиатуры. Таким образом <xref:System.Windows.Interop.IKeyboardInputSink.TabInto%2A?displayProperty=nameWithType> метод является единственным <xref:System.Windows.Interop.IKeyboardInputSink> член, требующий реализацию в <xref:System.Windows.Forms.Integration.WindowsFormsHost> класса.  
  
 По умолчанию <xref:System.Windows.Interop.HwndHost> возвращает `false` для его <xref:System.Windows.Interop.HwndHost.System%23Windows%23Interop%23IKeyboardInputSink%23TabInto%2A> реализации. Это предотвращает переход из WPF управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элемента управления.  
  
 <xref:System.Windows.Forms.Integration.WindowsFormsHost> Реализация <xref:System.Windows.Interop.IKeyboardInputSink.TabInto%2A?displayProperty=nameWithType> метод выполняет следующие действия:  
  
1. Находит первый или последний [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] управления, содержащийся в <xref:System.Windows.Forms.Integration.WindowsFormsHost> и может получать фокус. Выбор элемента управления зависит от обхода сведений.  
  
2. Устанавливает фокус на элементе управления и возвращает `true`.  
  
3. Если элемент управления не может получать фокус, возвращает `false`.  
  
### <a name="windowsformshost-registration"></a>WindowsFormsHost регистрации  
 Когда дескриптор окна <xref:System.Windows.Forms.Integration.WindowsFormsHost> создается элемент управления, <xref:System.Windows.Forms.Integration.WindowsFormsHost> управления вызывает внутренний статический метод, который регистрирует его присутствие для цикла обработки сообщений.  
  
 Во время регистрации <xref:System.Windows.Forms.Integration.WindowsFormsHost> управления проверяет цикл обработки сообщений. Если не был запущен цикл обработки сообщений, <xref:System.Windows.Interop.ComponentDispatcher.ThreadFilterMessage?displayProperty=nameWithType> будет создан обработчик событий. Цикл обработки сообщений считается запущенным при <xref:System.Windows.Interop.ComponentDispatcher.ThreadFilterMessage?displayProperty=nameWithType> присоединен обработчик событий.  
  
 При уничтожении дескриптор окна, <xref:System.Windows.Forms.Integration.WindowsFormsHost> управления удалит себя из регистрации.  
  
## <a name="elementhost-keyboard-and-message-processing"></a>ElementHost-клавиатура и обработки сообщений  
 Если они размещаются в [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] приложения, WPF клавиатуры и обработка состоит из следующих сообщений:  
  
-   <xref:System.Windows.Interop.HwndSource>, <xref:System.Windows.Interop.IKeyboardInputSink>, и <xref:System.Windows.Interop.IKeyboardInputSite> реализации интерфейсов.  
  
-   Переход с клавишами со стрелками.  
  
-   Клавиши команд и диалоговых окон.  
  
-   [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] Обработка с помощью ускорителя.  
  
 В следующих разделах эти части более подробно.  
  
### <a name="interface-implementations"></a>Реализации интерфейсов  
 В [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)], маршрутизацией сообщений клавиатуры на дескриптор окна элемента управления, имеющий фокус. В <xref:System.Windows.Forms.Integration.ElementHost> элемента управления, эти сообщения направляются в размещенный элемент. Чтобы выполнить это, <xref:System.Windows.Forms.Integration.ElementHost> элемент управления предоставляет <xref:System.Windows.Interop.HwndSource> экземпляра. Если <xref:System.Windows.Forms.Integration.ElementHost> элемент управления имеет фокус, <xref:System.Windows.Interop.HwndSource> экземпляр направляет большинство клавиатуры, чтобы он может обработать WPF <xref:System.Windows.Input.InputManager> класса.  
  
 <xref:System.Windows.Interop.HwndSource> Класс реализует <xref:System.Windows.Interop.IKeyboardInputSink> и <xref:System.Windows.Interop.IKeyboardInputSite> интерфейсов.  
  
 Взаимодействие с клавиатурой зависит от реализации <xref:System.Windows.Interop.IKeyboardInputSite.OnNoMoreTabStops%2A> метод для обработки клавиши TAB "и" стрелка ключа входных данных, который перемещает фокус элементов.  
  
### <a name="tabbing-and-arrow-keys"></a>Между приложениями и клавиш со стрелками  
 [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] Логику выбора сопоставляется <xref:System.Windows.Interop.HwndSource.System%23Windows%23Interop%23IKeyboardInputSink%23TabInto%2A> и <xref:System.Windows.Interop.IKeyboardInputSite.OnNoMoreTabStops%2A> методы, реализуемые ВКЛАДКУ "и" стрелка ключа навигации. Переопределение <xref:System.Windows.Forms.Integration.ElementHost.Select%2A> метод выполняет это сопоставление.  
  
### <a name="command-keys-and-dialog-box-keys"></a>Сочетания клавиш и клавиш диалогового окна  
 Чтобы предоставить WPF возможность первым обработать клавиши для команд и диалоговых окон, [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] команды предварительной обработки подключен к <xref:System.Windows.Interop.IKeyboardInputSink.TranslateAccelerator%2A> метод. Переопределение <xref:System.Windows.Forms.Control.ProcessCmdKey%2A?displayProperty=nameWithType> метод объединяет две технологии.  
  
 С помощью <xref:System.Windows.Interop.IKeyboardInputSink.TranslateAccelerator%2A> метод, размещенные элементы можно обработать сообщение, ключей, например WM_KEYUP WM_KEYDOWN, WM_SYSKEYDOWN или WM_SYSKEYUP, включая ключи команды, например, ввод, ESC, нажатии клавиши TAB. Если сообщение о нажатии клавиши не обработано, оно отправляется вверх [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] иерархии для обработки.  
  
### <a name="accelerator-processing"></a>Обработка с помощью ускорителя  
 Для правильной обработки [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] обработки сочетаний клавиш, которые должны быть подключены к WPF <xref:System.Windows.Input.AccessKeyManager> класса. Кроме того все сообщения WM_CHAR, должны быть правильно направлены в размещенные элементы.  
  
 Так как значение по умолчанию <xref:System.Windows.Interop.HwndSource> реализация <xref:System.Windows.Interop.IKeyboardInputSink.TranslateChar%2A> возвращает метод `false`, сообщения WM_CHAR обрабатываются с использованием следующую логику:  
  
-   <xref:System.Windows.Forms.Control.IsInputChar%2A?displayProperty=nameWithType> Метод переопределяется, чтобы убедиться, что все сообщения WM_CHAR перенаправляются в размещенные элементы.  
  
-   Если клавиша ALT нажата, сообщение является WM_SYSCHAR. [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] не обрабатывает это сообщение с помощью <xref:System.Windows.Forms.Control.IsInputChar%2A> метод. Таким образом <xref:System.Windows.Forms.Control.ProcessMnemonic%2A> переопределяется метод для запроса WPF <xref:System.Windows.Input.AccessKeyManager> для зарегистрированному сочетанию клавиш. При обнаружении зарегистрированному сочетанию клавиш <xref:System.Windows.Input.AccessKeyManager> обрабатывает его.  
  
-   Если не нажата клавиша ALT, WPF <xref:System.Windows.Input.InputManager> класс обрабатывает необработанные входные данные. Если входное значение ускоритель <xref:System.Windows.Input.AccessKeyManager> обрабатывает его. <xref:System.Windows.Input.InputManager.PostProcessInput> Событие обрабатывается для сообщений WM_CHAR, которые не были обработаны.  
  
 Когда пользователь нажимает клавишу ALT, ускоритель визуальные подсказки отображаются на всю форму. Для поддержки этого поведения всех <xref:System.Windows.Forms.Integration.ElementHost> элементов управления в активной форме получают сообщения WM_SYSKEYDOWN, независимо от того, что элемент управления имеет фокус.  
  
 Сообщения отправляются только к <xref:System.Windows.Forms.Integration.ElementHost> элементов управления в активной форме.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Integration.WindowsFormsHost.EnableWindowsFormsInterop%2A>
- <xref:System.Windows.Forms.Integration.ElementHost.EnableModelessKeyboardInterop%2A>
- <xref:System.Windows.Forms.Integration.ElementHost>
- <xref:System.Windows.Forms.Integration.WindowsFormsHost>
- [Пошаговое руководство. Размещение составного элемента управления Windows Forms в приложении WPF](walkthrough-hosting-a-windows-forms-composite-control-in-wpf.md)
- [Пошаговое руководство. Размещение составного элемента управления WPF в форме Windows Forms](walkthrough-hosting-a-wpf-composite-control-in-windows-forms.md)
- [Взаимодействие WPF и Win32](wpf-and-win32-interoperation.md)

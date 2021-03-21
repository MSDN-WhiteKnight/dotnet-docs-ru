---
title: Общие сведения о системе команд
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- interfaces [WPF], ICommandSource
- command library [WPF]
- commands [WPF], definition of
- CommandBindings [WPF]
- ICommandSource interfaces [WPF]
- commanding [WPF]
- CommandManager [WPF]
ms.assetid: bc208dfe-367d-426a-99de-52b7e7511e81
ms.openlocfilehash: 4071f7f08c2b25a2ec551832f57a2b9a7facc91d
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59139039"
---
# <a name="commanding-overview"></a>Общие сведения о системе команд
Система команд <a name="introduction"></a> представляет собой механизм ввода в [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)], обеспечивающий обработку входных данных на более семантическом уровне по сравнению с вводом устройств. Примеры команд включают операции **Копировать**, **Вырезать** и **Вставить**, доступные во многих приложениях.  
  
 В этом обзоре определяется понятие команд в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], классы, входящие в модель команд, и способы использования и создания команд в приложениях.  
  
 В этом разделе содержатся следующие подразделы.  
  
-   [Что представляют собой команды?](#commands_at_10000_feet)  
  
-   [Пример простой команды в WPF](#simple_command)  
  
-   [Четыре основных понятия в системе команд WPF](#Four_main_Concepts)  
  
-   [Библиотека команд](#Command_Library)  
  
-   [Создание настраиваемых команд](#creating_commands)  
  
<a name="commands_at_10000_feet"></a>   
## <a name="what-are-commands"></a>Что представляют собой команды?  
 Команды применяются в различных целях. Первой задачей является отделение семантики и объекта, вызывающего команду, от логики, которая выполняет команду. Это позволяет нескольким и разнородным источникам вызывать одну логику команды, а также настраивать логику команды для различных целевых объектов. Например, операции редактирования **Копировать**, **Вырезать** и **Вставить**, которые встречаются во многих приложениях, могут вызываться с помощью разных действий пользователя, если они реализованы с помощью команд. Приложение может поддерживать вырезание выделенных объектов или текста путем нажатия определенной кнопки, выбора пункта меню или сочетания клавиш, например CTRL+X. С помощью команд можно привязать разные типы действий пользователя к одной логике.  
  
 Другой целью применения команд является указание того, доступно ли действие. Продолжая пример вырезания объекта или текста, действие имеет смысл, только если что-либо выбрано. Если пользователь попытается вырезать объект или текст, не выбрав его, ничего не произойдет. Чтобы уведомить пользователя об этом, во многих приложениях кнопки и пункты меню отключаются, чтобы пользователь понял, что это действие выполнить невозможно. Команда может указывать, возможно ли действие, путем реализации метода <xref:System.Windows.Input.ICommand.CanExecute%2A>. Кнопка может подписаться на событие <xref:System.Windows.Input.ICommand.CanExecuteChanged> и отключаться, если <xref:System.Windows.Input.ICommand.CanExecute%2A> возвращает `false`, или включаться, если <xref:System.Windows.Input.ICommand.CanExecute%2A> возвращает `true`.  
  
 Семантика команды может быть согласованной в разных приложениях и классах, однако логика действия зависит от конкретного объекта, к которому она применяется. Сочетание клавиш CTRL+X вызывает команду **Вырезать** в классах текста, классах изображений и веб-браузерах, однако фактическая логика для выполнения операции **Вырезать** определяется приложением, которое ее выполняет. <xref:System.Windows.Input.RoutedCommand> позволяет клиентам реализовать логику. Текстовый объект может вырезать выделенный текст в буфер обмена, а объект изображения может вырезать выбранное изображение. Когда приложение обрабатывает событие <xref:System.Windows.Input.CommandManager.Executed>, оно имеет доступ к целевому объекту команды и может выполнить соответствующее действие в зависимости от типа целевого объекта.  
  
<a name="simple_command"></a>   
## <a name="simple-command-example-in-wpf"></a>Пример простой команды в WPF  
 Самый простой способ использования команды в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] — использовать предопределенную команду <xref:System.Windows.Input.RoutedCommand> из одного из классов библиотеки команд, элемент управления с собственной поддержкой обработки команд или элемент управления с собственной поддержкой вызова команд.  Команда <xref:System.Windows.Input.ApplicationCommands.Paste%2A> является одной из предопределенных команд в классе <xref:System.Windows.Input.ApplicationCommands>.  Элемент управления <xref:System.Windows.Controls.TextBox> содержит встроенную логику для обработки команды <xref:System.Windows.Input.ApplicationCommands.Paste%2A>.  Класс <xref:System.Windows.Controls.MenuItem> включает собственную поддержку для вызова команд.  
  
 В следующем примере показано, как настроить <xref:System.Windows.Controls.MenuItem> так, что при его выборе вызывается команда <xref:System.Windows.Input.ApplicationCommands.Paste%2A> для <xref:System.Windows.Controls.TextBox>, исходя из фокуса клавиатуры на <xref:System.Windows.Controls.TextBox>.  
  
 [!code-xaml[CommandingOverviewSnippets#CommandingOverviewSimpleCommand](~/samples/snippets/csharp/VS_Snippets_Wpf/CommandingOverviewSnippets/CSharp/Window1.xaml#commandingoverviewsimplecommand)]  
  
 [!code-csharp[CommandingOverviewSnippets#CommandingOverviewCommandTargetCodeBehind](~/samples/snippets/csharp/VS_Snippets_Wpf/CommandingOverviewSnippets/CSharp/Window1.xaml.cs#commandingoverviewcommandtargetcodebehind)]
   
  
<a name="Four_main_Concepts"></a>   
## <a name="four-main-concepts-in-wpf-commanding"></a>Четыре основных понятия в системе команд WPF  
 Модель перенаправляемых команд [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] можно разбить на четыре основных понятия: команда, источник команды, цель команды и привязка команды.  
  
-   *Команда* — это выполняемое действие.  
  
-   *Источник команды* — это объект, который вызывает команду.  
  
-   *Цель команды* — это объект, для которого выполняется команда.  
  
-   *Привязка команды* — это объект, сопоставляющий логику команды с командой.  
  
 В предыдущем примере команда <xref:System.Windows.Input.ApplicationCommands.Paste%2A> является командой, <xref:System.Windows.Controls.MenuItem> — источником команды, <xref:System.Windows.Controls.TextBox> — целевым объектом команды, а привязка команды предоставляется элементом управления <xref:System.Windows.Controls.TextBox>.  Следует отметить, что привязка <xref:System.Windows.Input.CommandBinding> не всегда предоставляется элементом управления, который является целевым классом команды.  Довольно часто <xref:System.Windows.Input.CommandBinding> должен создаваться разработчиком приложения, кроме того, <xref:System.Windows.Input.CommandBinding> может быть присоединен к предку целевого объекта команды.  
  
<a name="Commands"></a>   
### <a name="commands"></a>Команды  
 Команды в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] создаются путем реализации интерфейса <xref:System.Windows.Input.ICommand>.  <xref:System.Windows.Input.ICommand> предоставляет два метода <xref:System.Windows.Input.ICommand.Execute%2A>, и <xref:System.Windows.Input.ICommand.CanExecute%2A>и событие, <xref:System.Windows.Input.ICommand.CanExecuteChanged>. <xref:System.Windows.Input.ICommand.Execute%2A> выполняет действия, связанные с командой. <xref:System.Windows.Input.ICommand.CanExecute%2A> Определяет, может ли команда выполняться для текущего целевого объекта команды. <xref:System.Windows.Input.ICommand.CanExecuteChanged> вызывается, если диспетчер команд, команд, обнаруживает изменения в источнике команды, которые могут сделать недействительной команду, которая вызвана, но еще не выполнена привязкой команды.  Реализация [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] класса <xref:System.Windows.Input.ICommand> — класс <xref:System.Windows.Input.RoutedCommand>, который рассматривается в этом обзоре.  
  
 Основными источниками входных данных в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] являются мышь, клавиатура, рукописный ввод и перенаправленные команды.  Более аппаратно-ориентированные входные данные используют событие <xref:System.Windows.RoutedEvent> для уведомления объектов на странице приложения о том, что произошло событие ввода.  Объект <xref:System.Windows.Input.RoutedCommand> ничем не отличается.  Методы <xref:System.Windows.Input.RoutedCommand.Execute%2A> и <xref:System.Windows.Input.RoutedCommand.CanExecute%2A> класса <xref:System.Windows.Input.RoutedCommand> не содержат логику приложения для команды, но вызывают перенаправленные события, которые проходят и поднимаются по дереву элементов, пока не обнаружат объект с <xref:System.Windows.Input.CommandBinding>.  <xref:System.Windows.Input.CommandBinding> содержит обработчики для этих событий, а также обработчики для выполнения команды.  Дополнительные сведения о маршрутизации событий в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] см. в разделе [Общие сведения о перенаправленных событиях](routed-events-overview.md).  
  
 Метод <xref:System.Windows.Input.RoutedCommand.Execute%2A> для <xref:System.Windows.Input.RoutedCommand> вызывает события <xref:System.Windows.Input.CommandManager.PreviewExecuted> и <xref:System.Windows.Input.CommandManager.Executed> для целевого объекта команды.  Метод <xref:System.Windows.Input.RoutedCommand.CanExecute%2A> для <xref:System.Windows.Input.RoutedCommand> вызывает события <xref:System.Windows.Input.CommandManager.CanExecute> и <xref:System.Windows.Input.CommandManager.PreviewCanExecute> для целевого объекта команды.  Эти события проходят и поднимаются по дереву элементов, пока не будет обнаружен объект, имеющий привязку <xref:System.Windows.Input.CommandBinding> для этой конкретной команды.  
  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] предоставляет набор общих перенаправленных команд, распределенных между несколькими классами: <xref:System.Windows.Input.MediaCommands>, <xref:System.Windows.Input.ApplicationCommands>, <xref:System.Windows.Input.NavigationCommands>, <xref:System.Windows.Input.ComponentCommands>, и <xref:System.Windows.Documents.EditingCommands>.  Эти классы состоят только из объектов <xref:System.Windows.Input.RoutedCommand> и не реализуют логику команды.  За реализацию логики команды отвечает объект, для которого выполняется команда.  
  
<a name="Command_Sources"></a>   
### <a name="command-sources"></a>Источники команд  
 Источник команды — это объект, который вызывает команду.  Примерами источников команды являются <xref:System.Windows.Controls.MenuItem>, <xref:System.Windows.Controls.Button> и <xref:System.Windows.Input.KeyGesture>.  
  
 Источники команд в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] обычно реализуют интерфейс <xref:System.Windows.Input.ICommandSource>.  
  
 <xref:System.Windows.Input.ICommandSource> предоставляет три свойства: <xref:System.Windows.Input.ICommandSource.Command%2A>, <xref:System.Windows.Input.ICommandSource.CommandTarget%2A>, и <xref:System.Windows.Input.ICommandSource.CommandParameter%2A>:  
  
-   <xref:System.Windows.Input.ICommandSource.Command%2A> — Это команда, выполняемая при вызове источника команды.  
  
-   <xref:System.Windows.Input.ICommandSource.CommandTarget%2A> — Это объект, для которого выполняется команда.  Следует отметить, что в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] свойство <xref:System.Windows.Input.ICommandSource.CommandTarget%2A> для <xref:System.Windows.Input.ICommandSource> применимо, только когда <xref:System.Windows.Input.ICommand> — <xref:System.Windows.Input.RoutedCommand>.  Если для <xref:System.Windows.Input.ICommandSource> задано значение <xref:System.Windows.Input.ICommandSource.CommandTarget%2A>, и соответствующая команда — не <xref:System.Windows.Input.RoutedCommand>, целевой объект команды не учитывается. Если <xref:System.Windows.Input.ICommandSource.CommandTarget%2A> не задан, в качестве целевого объекта будет использоваться элемент с фокусом клавиатуры.  
  
-   <xref:System.Windows.Input.ICommandSource.CommandParameter%2A> реализуется ли определяемый пользователем тип, используемый для передачи данных обработчикам команды.  
  
 Классы [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], реализующие <xref:System.Windows.Input.ICommandSource>: <xref:System.Windows.Controls.Primitives.ButtonBase>, <xref:System.Windows.Controls.MenuItem>, <xref:System.Windows.Documents.Hyperlink> и <xref:System.Windows.Input.InputBinding>.  <xref:System.Windows.Controls.Primitives.ButtonBase>, <xref:System.Windows.Controls.MenuItem>, и <xref:System.Windows.Documents.Hyperlink> вызвать команду при щелчке и <xref:System.Windows.Input.InputBinding> вызывает команду при <xref:System.Windows.Input.InputGesture> связанные с она выполняется.  
  
 В следующем примере показано, как использовать <xref:System.Windows.Controls.MenuItem> в <xref:System.Windows.Controls.ContextMenu> в качестве источника команды для команды <xref:System.Windows.Input.ApplicationCommands.Properties%2A>.  
  
 [!code-xaml[CommandingOverviewSnippets#CommandingOverviewCmdSourceXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/CommandingOverviewSnippets/CSharp/Window1.xaml#commandingoverviewcmdsourcexaml)]  
  
 [!code-csharp[CommandingOverviewSnippets#CommandingOverviewCmdSource](~/samples/snippets/csharp/VS_Snippets_Wpf/CommandingOverviewSnippets/CSharp/Window1.xaml.cs#commandingoverviewcmdsource)]
   
  
 Как правило, источник команды будет осуществлять прослушивание события <xref:System.Windows.Input.RoutedCommand.CanExecuteChanged>.  Это событие сообщает источнику команды о том, что возможность выполнения команды для текущего целевого объекта команды может быть изменена.  Источник команды может запрашивать текущее состояние <xref:System.Windows.Input.RoutedCommand> с помощью метода <xref:System.Windows.Input.RoutedCommand.CanExecute%2A>.  Источник команды может затем отключаться, если не удается выполнить команду.  Примером этого является переход <xref:System.Windows.Controls.MenuItem> в неактивное состояние (серый цвет) в случае невозможности выполнить команду.  
  
 <xref:System.Windows.Input.InputGesture> можно использовать в качестве источника команды.  Два типа входных жестов в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]: <xref:System.Windows.Input.KeyGesture> и <xref:System.Windows.Input.MouseGesture>.  <xref:System.Windows.Input.KeyGesture> можно представить как сочетание клавиш, например CTRL + C.  <xref:System.Windows.Input.KeyGesture> состоит из <xref:System.Windows.Input.Key> и набора <xref:System.Windows.Input.ModifierKeys>.  <xref:System.Windows.Input.MouseGesture> состоит из <xref:System.Windows.Input.MouseAction> и необязательного набора <xref:System.Windows.Input.ModifierKeys>.  
  
 Чтобы объект <xref:System.Windows.Input.InputGesture> мог служить источником команды, он должен быть связан с командой. Это можно настроить несколькими способами.  Один из способов — использование <xref:System.Windows.Input.InputBinding>.  
  
 В следующем примере показано, как создать привязку <xref:System.Windows.Input.KeyBinding> между <xref:System.Windows.Input.KeyGesture> и <xref:System.Windows.Input.RoutedCommand>.  
  
 [!code-xaml[CommandingOverviewSnippets#CommandingOverviewXAMLKeyBinding](~/samples/snippets/csharp/VS_Snippets_Wpf/CommandingOverviewSnippets/CSharp/Window1.xaml#commandingoverviewxamlkeybinding)]  
  
 [!code-csharp[CommandingOverviewSnippets#CommandingOverviewKeyBinding](~/samples/snippets/csharp/VS_Snippets_Wpf/CommandingOverviewSnippets/CSharp/Window1.xaml.cs#commandingoverviewkeybinding)]
   
  
 Другой способ связать <xref:System.Windows.Input.InputGesture> с <xref:System.Windows.Input.RoutedCommand> заключается в добавлении <xref:System.Windows.Input.InputGesture> в <xref:System.Windows.Input.InputGestureCollection> для <xref:System.Windows.Input.RoutedCommand>.  
  
 В следующем примере демонстрируется, как добавить <xref:System.Windows.Input.KeyGesture> в <xref:System.Windows.Input.InputGestureCollection> для <xref:System.Windows.Input.RoutedCommand>.  
  
 [!code-csharp[CommandingOverviewSnippets#CommandingOverviewKeyGestureOnCmd](~/samples/snippets/csharp/VS_Snippets_Wpf/CommandingOverviewSnippets/CSharp/Window1.xaml.cs#commandingoverviewkeygestureoncmd)]
   
  
<a name="Command_Binding"></a>   
### <a name="commandbinding"></a>CommandBinding  
 <xref:System.Windows.Input.CommandBinding> привязывает команду к обработчикам событий, которые реализуют команду.  
  
 Класс <xref:System.Windows.Input.CommandBinding> содержит свойство <xref:System.Windows.Input.CommandBinding.Command%2A> и события <xref:System.Windows.Input.CommandBinding.PreviewExecuted>, <xref:System.Windows.Input.CommandBinding.Executed>, <xref:System.Windows.Input.CommandBinding.PreviewCanExecute> и <xref:System.Windows.Input.CommandBinding.CanExecute>.  
  
 <xref:System.Windows.Input.CommandBinding.Command%2A> — Это команда, <xref:System.Windows.Input.CommandBinding> , связанного с.  Обработчики событий, присоединенные к событиям <xref:System.Windows.Input.CommandBinding.PreviewExecuted> и <xref:System.Windows.Input.CommandBinding.Executed>, реализуют логику команды.  Обработчики событий, присоединенные к событиям <xref:System.Windows.Input.CommandBinding.PreviewCanExecute> и <xref:System.Windows.Input.CommandBinding.CanExecute>, определяют, может ли эта команда выполняться для текущего целевого объекта команды.  
  
 В следующем примере демонстрируется создание объекта <xref:System.Windows.Input.CommandBinding> в корневом объекте <xref:System.Windows.Window> приложения.  <xref:System.Windows.Input.CommandBinding> связывает команду <xref:System.Windows.Input.ApplicationCommands.Open%2A> с обработчиками <xref:System.Windows.Input.CommandManager.Executed> и <xref:System.Windows.Input.CommandBinding.CanExecute>.  
  
 [!code-xaml[commandwithhandler#CommandHandlerCommandBinding](~/samples/snippets/csharp/VS_Snippets_Wpf/commandWithHandler/CSharp/Window1.xaml#commandhandlercommandbinding)]  
  
 [!code-csharp[CommandHandlerProcedural#CommandHandlerBindingInit](~/samples/snippets/csharp/VS_Snippets_Wpf/CommandHandlerProcedural/CSharp/Window1.xaml.cs#commandhandlerbindinginit)]
   
  
 Затем создаются объекты <xref:System.Windows.Input.ExecutedRoutedEventHandler> и <xref:System.Windows.Input.CanExecuteRoutedEventHandler>.  <xref:System.Windows.Input.ExecutedRoutedEventHandler> открывает <xref:System.Windows.MessageBox>, где отображается строка, сообщающая о выполнении команды.  <xref:System.Windows.Input.CanExecuteRoutedEventHandler> задает для свойства <xref:System.Windows.Input.CanExecuteRoutedEventArgs.CanExecute%2A> значение `true`.  
  
 [!code-csharp[commandwithhandler#CommandHandlerExecutedHandler](~/samples/snippets/csharp/VS_Snippets_Wpf/commandWithHandler/CSharp/Window1.xaml.cs#commandhandlerexecutedhandler)]
   
  
 [!code-csharp[commandwithhandler#CommandHandlerCanExecuteHandler](~/samples/snippets/csharp/VS_Snippets_Wpf/commandWithHandler/CSharp/Window1.xaml.cs#commandhandlercanexecutehandler)]
   
  
 <xref:System.Windows.Input.CommandBinding> присоединяется к конкретному объекту, например к корневому объекту <xref:System.Windows.Window> приложения или элемента управления.  Объект, к которому присоединяется <xref:System.Windows.Input.CommandBinding>, определяет область привязки.  Например, <xref:System.Windows.Input.CommandBinding>, присоединенный к предку целевого объекта команды, достижим для события <xref:System.Windows.Input.CommandBinding.Executed>, а <xref:System.Windows.Input.CommandBinding>, присоединенный к потомку целевого объекта команды, недостижим.  Это напрямую связано со способом перехода события <xref:System.Windows.RoutedEvent> из объекта, который вызывает событие.  
  
 В некоторых случаях <xref:System.Windows.Input.CommandBinding> присоединяется к целевому объекту команды напрямую, например с помощью класса <xref:System.Windows.Controls.TextBox> и команд <xref:System.Windows.Input.ApplicationCommands.Cut%2A>, <xref:System.Windows.Input.ApplicationCommands.Copy%2A> и <xref:System.Windows.Input.ApplicationCommands.Paste%2A>. Довольно часто, однако, более удобным будет подключение <xref:System.Windows.Input.CommandBinding> к предку целевого объекта команды, такому как главное окно <xref:System.Windows.Window> или объект приложения, особенно в том случае, если одну привязку <xref:System.Windows.Input.CommandBinding> можно использовать для нескольких целей команды.  Это необходимо учитывать при создании инфраструктуры системы команд.  
  
<a name="Commane_Target"></a>   
### <a name="command-target"></a>Цель команды  
 Целью команды является элемент, для которого выполняется команда.  По отношению к <xref:System.Windows.Input.RoutedCommand> целевой объект команды — это элемент, с которого начинается перенаправление <xref:System.Windows.Input.CommandManager.Executed> и <xref:System.Windows.Input.CommandManager.CanExecute>.  Как было отмечено ранее, в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] свойство <xref:System.Windows.Input.ICommandSource.CommandTarget%2A> для <xref:System.Windows.Input.ICommandSource> применимо, только когда <xref:System.Windows.Input.ICommand> — <xref:System.Windows.Input.RoutedCommand>.  Если для <xref:System.Windows.Input.ICommandSource> задано значение <xref:System.Windows.Input.ICommandSource.CommandTarget%2A>, и соответствующая команда — не <xref:System.Windows.Input.RoutedCommand>, целевой объект команды не учитывается.  
  
 Источник команды может явно задавать целевой объект команды.  Если цель команды не определена, в качестве целевого объекта будет использоваться элемент с фокусом клавиатуры.  Одно из преимуществ использования элемента с фокусом клавиатуры в качестве цели команды является то, что это позволяет разработчику приложения использовать один источник команды для вызова команд для нескольких целей без необходимости отслеживания целевого объекта команды.  Например, если <xref:System.Windows.Controls.MenuItem> вызывает команду **Вставить** в приложении, которое имеет элемент управления <xref:System.Windows.Controls.TextBox> и элемент управления <xref:System.Windows.Controls.PasswordBox>, целевым объектом может быть <xref:System.Windows.Controls.TextBox> или <xref:System.Windows.Controls.PasswordBox> в зависимости от того, какой элемент управления имеет фокус клавиатуры.  
  
 В следующем примере показано явное задание цели команды в разметке и в коде программной части.  
  
 [!code-xaml[CommandingOverviewSnippets#CommandingOverviewXAMLCommandTarget](~/samples/snippets/csharp/VS_Snippets_Wpf/CommandingOverviewSnippets/CSharp/Window1.xaml#commandingoverviewxamlcommandtarget)]  
  
 [!code-csharp[CommandingOverviewSnippets#CommandingOverviewCommandTargetCodeBehind](~/samples/snippets/csharp/VS_Snippets_Wpf/CommandingOverviewSnippets/CSharp/Window1.xaml.cs#commandingoverviewcommandtargetcodebehind)]
   
  
<a name="Command_Manager"></a>   
### <a name="the-commandmanager"></a>Диспетчер команд CommandManager  
 <xref:System.Windows.Input.CommandManager> выполняет ряд функций, связанных с командами.  Он предоставляет набор статических методов для добавления обработчиков событий <xref:System.Windows.Input.CommandManager.PreviewExecuted>, <xref:System.Windows.Input.CommandManager.Executed>, <xref:System.Windows.Input.CommandManager.PreviewCanExecute> и <xref:System.Windows.Input.CommandManager.CanExecute> в конкретный элемент и их удаления из него.  Он предоставляет средства для регистрации объектов <xref:System.Windows.Input.CommandBinding> и <xref:System.Windows.Input.InputBinding> для определенного класса.  <xref:System.Windows.Input.CommandManager> также предоставляет средства (с помощью события <xref:System.Windows.Input.CommandManager.RequerySuggested>) для уведомления команды о необходимости вызова события <xref:System.Windows.Input.ICommand.CanExecuteChanged>.  
  
 Метод <xref:System.Windows.Input.CommandManager.InvalidateRequerySuggested%2A> вынуждает <xref:System.Windows.Input.CommandManager> вызвать событие <xref:System.Windows.Input.CommandManager.RequerySuggested>.  Это удобно для ситуаций, когда требуется отключить или включить команду, но отсутствуют условия, о которых известно <xref:System.Windows.Input.CommandManager>.  
  
<a name="Command_Library"></a>   
## <a name="command-library"></a>Библиотека команд  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] предоставляет набор встроенных команд.  Библиотека команд включает следующие классы: <xref:System.Windows.Input.ApplicationCommands>, <xref:System.Windows.Input.NavigationCommands>, <xref:System.Windows.Input.MediaCommands>, <xref:System.Windows.Documents.EditingCommands> и <xref:System.Windows.Input.ComponentCommands>.  Эти классы предоставляют команды, такие как <xref:System.Windows.Input.ApplicationCommands.Cut%2A>, <xref:System.Windows.Input.NavigationCommands.BrowseBack%2A> и <xref:System.Windows.Input.NavigationCommands.BrowseForward%2A>, <xref:System.Windows.Input.MediaCommands.Play%2A>, <xref:System.Windows.Input.MediaCommands.Stop%2A> и <xref:System.Windows.Input.MediaCommands.Pause%2A>.  
  
 Многие из этих команд содержат набор привязок ввода по умолчанию.  Например, если вы задаете обработку приложением команды копирования, вы автоматически получаете привязку CTRL+C. Кроме того, вы получаете привязки для других устройств ввода, таких как ввод с помощью пера и голосовых данных [!INCLUDE[TLA2#tla_tpc](../../../../includes/tla2sharptla-tpc-md.md)].  
  
 При ссылке на команды в различных библиотеках команд с помощью [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)], обычно можно опустить имя класса библиотеки, который предоставляет статическое свойство команды. Как правило, имена команд задаются однозначно в виде строк и существуют типы владельца, которые обеспечивает логическую группировку команд, однако они не являются необходимыми для устранения неоднозначности. Например, можно указать `Command="Cut"` вместо более подробной команды `Command="ApplicationCommands.Cut"`. Этот удобный механизм встроен в обработчик команд [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] (точнее, это поведение преобразователя типов <xref:System.Windows.Input.ICommand>, на который обработчик [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] ссылается во время загрузки).  
  
<a name="creating_commands"></a>   
## <a name="creating-custom-commands"></a>Создание настраиваемых команд  
 Если команды в классах библиотеки команд не соответствуют вашим потребностям, вы можете создать собственные команды.  Настраиваемые команды можно создать двумя способами.  Первый способ подразумевает создание с нуля и реализацию интерфейса <xref:System.Windows.Input.ICommand>.  Другой способ, а также наиболее распространенный подход, — создание <xref:System.Windows.Input.RoutedCommand> или <xref:System.Windows.Input.RoutedUICommand>.  
  
 Пример создания настраиваемой команды <xref:System.Windows.Input.RoutedCommand> см. в разделе [Create a Custom RoutedCommand Sample](https://github.com/Microsoft/WPF-Samples/tree/master/Input%20and%20Commands/CustomRoutedCommand) (Создание примера настраиваемой команды RoutedCommand).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Input.RoutedCommand>
- <xref:System.Windows.Input.CommandBinding>
- <xref:System.Windows.Input.InputBinding>
- <xref:System.Windows.Input.CommandManager>
- [Общие сведения о входных данных](input-overview.md)
- [Общие сведения о перенаправленных событиях](routed-events-overview.md)
- [Реализация ICommandSource](how-to-implement-icommandsource.md)
- [Практическое руководство. Добавление команды в объект MenuItem](https://docs.microsoft.com/previous-versions/dotnet/netframework-3.5/ms741839(v=vs.90))
- [Создание примера настраиваемой команды RoutedCommand](https://github.com/Microsoft/WPF-Samples/tree/master/Input%20and%20Commands/CustomRoutedCommand)

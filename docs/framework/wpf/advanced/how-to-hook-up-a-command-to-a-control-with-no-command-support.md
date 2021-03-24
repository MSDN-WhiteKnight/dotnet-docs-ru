---
title: Практическое руководство. Подключение команды к элементу управления без поддержки команд
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Control class [WPF], attaching a RoutedCommand
- classes [WPF], Control [WPF], attaching a RoutedCommand
- RoutedCommand class [WPF], attaching to a Control
- classes [WPF], RoutedCommand [WPF], attaching to a Control
ms.assetid: dad08f64-700b-46fb-ad3f-fbfee95f0dfe
ms.openlocfilehash: 3ae45c9a9e33a3cb53ada6e1e5430ae0f9e6c198
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59216981"
---
# <a name="how-to-hook-up-a-command-to-a-control-with-no-command-support"></a>Практическое руководство. Подключение команды к элементу управления без поддержки команд
В следующем примере показано, как подключить <xref:System.Windows.Input.RoutedCommand> к <xref:System.Windows.Controls.Control> без встроенной поддержки команды.  Полный пример подключения команд к нескольким источникам см. в примере [Создание примера настраиваемой команды RoutedCommand](https://github.com/Microsoft/WPF-Samples/tree/master/Input%20and%20Commands/CustomRoutedCommand).  
  
## <a name="example"></a>Пример  
 Windows Presentation Foundation (WPF) предоставляет библиотеку стандартных команд, которые регулярно при программировании приложений.  Классы, составляющие библиотеку команд : <xref:System.Windows.Input.ApplicationCommands>, <xref:System.Windows.Input.ComponentCommands>, <xref:System.Windows.Input.NavigationCommands>, <xref:System.Windows.Input.MediaCommands> и <xref:System.Windows.Documents.EditingCommands>.  
  
 Статические объекты <xref:System.Windows.Input.RoutedCommand>, формирующие эти классы, не поддерживают командную логику.  Логика команды связана с командой с <xref:System.Windows.Input.CommandBinding>.  Многие элементы управления в WPF имеют встроенную поддержку определенных команд в библиотеке команд.  <xref:System.Windows.Controls.TextBox>, например, такие как поддерживает многие команды редактирования приложений <xref:System.Windows.Input.ApplicationCommands.Paste%2A>, <xref:System.Windows.Input.ApplicationCommands.Copy%2A>, <xref:System.Windows.Input.ApplicationCommands.Cut%2A>, <xref:System.Windows.Input.ApplicationCommands.Redo%2A>, и <xref:System.Windows.Input.ApplicationCommands.Undo%2A>.  Разработчику приложения не нужно выполнять никаких особых действий, чтобы эти команды заработали с этими элементами управления.  Если <xref:System.Windows.Controls.TextBox> является целевым объектом команды при выполнении команды, он будет обрабатывать команду с помощью класса <xref:System.Windows.Input.CommandBinding>, встроенного в элемент управления.  
  
 В следующем примере показано, как использовать <xref:System.Windows.Controls.Button> в качестве источника команды для команды <xref:System.Windows.Input.ApplicationCommands.Open%2A>.  Создается класс <xref:System.Windows.Input.CommandBinding>, который связывает указанный <xref:System.Windows.Input.CanExecuteRoutedEventHandler> и <xref:System.Windows.Input.CanExecuteRoutedEventHandler> с <xref:System.Windows.Input.RoutedCommand>.  
  
 Сначала создается источник команды.  В качестве источника команды используется <xref:System.Windows.Controls.Button>.  
  
 [!code-xaml[commandWithHandler#CommandHandlerCommandSource](~/samples/snippets/csharp/VS_Snippets_Wpf/commandWithHandler/CSharp/Window1.xaml#commandhandlercommandsource)]  
  
 [!code-csharp[CommandHandlerProcedural#CommandHandlerButtonCommandSource](~/samples/snippets/csharp/VS_Snippets_Wpf/CommandHandlerProcedural/CSharp/Window1.xaml.cs#commandhandlerbuttoncommandsource)]
   
  
 Затем создаются объекты <xref:System.Windows.Input.ExecutedRoutedEventHandler> и <xref:System.Windows.Input.CanExecuteRoutedEventHandler>.  <xref:System.Windows.Input.ExecutedRoutedEventHandler> просто открывает <xref:System.Windows.MessageBox>, чтобы подтвердить выполнение команды.  <xref:System.Windows.Input.CanExecuteRoutedEventHandler> задает для свойства <xref:System.Windows.Input.CanExecuteRoutedEventArgs.CanExecute%2A> значение `true`.  Как правило, обработчик CanExecute проводит более строгую проверку возможности выполнения команды с текущим целевым объектом команды.  
  
 [!code-csharp[commandWithHandler#CommandHandlerBothHandlers](~/samples/snippets/csharp/VS_Snippets_Wpf/commandWithHandler/CSharp/Window1.xaml.cs#commandhandlerbothhandlers)]
   
  
 Наконец, создается класс <xref:System.Windows.Input.CommandBinding> в корневом каталоге <xref:System.Windows.Window> приложения, который связывает обработчик перенаправленных событий с командой <xref:System.Windows.Input.ApplicationCommands.Open%2A>.  
  
 [!code-xaml[commandWithHandler#CommandHandlerCommandBinding](~/samples/snippets/csharp/VS_Snippets_Wpf/commandWithHandler/CSharp/Window1.xaml#commandhandlercommandbinding)]  
  
 [!code-csharp[CommandHandlerProcedural#CommandHandlerBindingInit](~/samples/snippets/csharp/VS_Snippets_Wpf/CommandHandlerProcedural/CSharp/Window1.xaml.cs#commandhandlerbindinginit)]
   
  
## <a name="see-also"></a>См. также

- [Общие сведения о системе команд](commanding-overview.md)
- [Подключение команды к элементу управления с поддержкой команд](how-to-hook-up-a-command-to-a-control-with-command-support.md)

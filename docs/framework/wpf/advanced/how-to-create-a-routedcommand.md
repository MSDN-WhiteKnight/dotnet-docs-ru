---
title: Практическое руководство. Создание маршрутизируемой команды RoutedCommand
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- RoutedCommand class [WPF], creating
ms.assetid: aaf6979f-69ab-406f-979f-5766daa85fa0
ms.openlocfilehash: d433658a3039c262d2f682eff09df646d978018c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59109048"
---
# <a name="how-to-create-a-routedcommand"></a>Практическое руководство. Создание маршрутизируемой команды RoutedCommand
В этом примере показано, как можно создавать пользовательские <xref:System.Windows.Input.RoutedCommand> и способ реализации пользовательской команды путем создания <xref:System.Windows.Input.ExecutedRoutedEventHandler> и <xref:System.Windows.Input.CanExecuteRoutedEventHandler> и присоединения их <xref:System.Windows.Input.CommandBinding>.  Дополнительные сведения о системе команд см. в разделе [сведения о системе команд](commanding-overview.md).  
  
## <a name="example"></a>Пример  
 Первым шагом в создании <xref:System.Windows.Input.RoutedCommand> является определение команды и создание его экземпляра.  
  
 [!code-csharp[CommandingOverviewSnippets#CommandingOverviewCommandDefinition](~/samples/snippets/csharp/VS_Snippets_Wpf/CommandingOverviewSnippets/CSharp/Window1.xaml.cs#commandingoverviewcommanddefinition)]
 [!code-vb[CommandingOverviewSnippets#CommandingOverviewCommandDefinition](~/samples/snippets/visualbasic/VS_Snippets_Wpf/CommandingOverviewSnippets/visualbasic/window1.xaml.vb#commandingoverviewcommanddefinition)]  
  
 Чтобы использовать команду в приложении, необходимо создать обработчики событий, которые определяют, что делает команда  
  
 [!code-csharp[CommandingOverviewSnippets#CommandingOverviewExecuted](~/samples/snippets/csharp/VS_Snippets_Wpf/CommandingOverviewSnippets/CSharp/Window1.xaml.cs#commandingoverviewexecuted)]
 [!code-vb[CommandingOverviewSnippets#CommandingOverviewExecuted](~/samples/snippets/visualbasic/VS_Snippets_Wpf/CommandingOverviewSnippets/visualbasic/window1.xaml.vb#commandingoverviewexecuted)]  
  
 [!code-csharp[CommandingOverviewSnippets#CommandingOverviewCanExecute](~/samples/snippets/csharp/VS_Snippets_Wpf/CommandingOverviewSnippets/CSharp/Window1.xaml.cs#commandingoverviewcanexecute)]
 [!code-vb[CommandingOverviewSnippets#CommandingOverviewCanExecute](~/samples/snippets/visualbasic/VS_Snippets_Wpf/CommandingOverviewSnippets/visualbasic/window1.xaml.vb#commandingoverviewcanexecute)]  
  
 Далее, <xref:System.Windows.Input.CommandBinding> создается, который связывает команду с обработчиками событий. <xref:System.Windows.Input.CommandBinding> Создается с определенным объектом.  Этот объект определяет область <xref:System.Windows.Input.CommandBinding> в дереве элементов  
  
 [!code-xaml[CommandingOverviewSnippets#CommandingOverviewWindowCommandBindingXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/CommandingOverviewSnippets/CSharp/Window1.xaml#commandingoverviewwindowcommandbindingxaml)]  
  
 [!code-csharp[CommandingOverviewSnippets#CommandingOverviewCustomCommandBindingCodeBehind](~/samples/snippets/csharp/VS_Snippets_Wpf/CommandingOverviewSnippets/CSharp/Window1.xaml.cs#commandingoverviewcustomcommandbindingcodebehind)]
 [!code-vb[CommandingOverviewSnippets#CommandingOverviewCustomCommandBindingCodeBehind](~/samples/snippets/visualbasic/VS_Snippets_Wpf/CommandingOverviewSnippets/visualbasic/window1.xaml.vb#commandingoverviewcustomcommandbindingcodebehind)]  
  
 Последним шагом является вызов команды.  Один из способов вызова команды — связать ее с <xref:System.Windows.Input.ICommandSource>, такие как <xref:System.Windows.Controls.Button>.  
  
 [!code-xaml[CommandingOverviewSnippets#CommandingOverviewCustomCommandSourceXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/CommandingOverviewSnippets/CSharp/Window1.xaml#commandingoverviewcustomcommandsourcexaml)]  
  
 [!code-csharp[CommandingOverviewSnippets#CommandingOverviewCustomCommandSourceCodeBehind](~/samples/snippets/csharp/VS_Snippets_Wpf/CommandingOverviewSnippets/CSharp/Window1.xaml.cs#commandingoverviewcustomcommandsourcecodebehind)]
 [!code-vb[CommandingOverviewSnippets#CommandingOverviewCustomCommandSourceCodeBehind](~/samples/snippets/visualbasic/VS_Snippets_Wpf/CommandingOverviewSnippets/visualbasic/window1.xaml.vb#commandingoverviewcustomcommandsourcecodebehind)]  
  
 При нажатии кнопки, <xref:System.Windows.Input.RoutedCommand.Execute%2A> метод пользовательского <xref:System.Windows.Input.RoutedCommand> вызывается.  <xref:System.Windows.Input.RoutedCommand> Вызывает <xref:System.Windows.Input.CommandManager.PreviewExecuted> и <xref:System.Windows.Input.CommandManager.Executed> перенаправленных событий.  Эти события проходят по дереву элементов, ищете <xref:System.Windows.Input.CommandBinding> для этой конкретной команды.  Если <xref:System.Windows.Input.CommandBinding> найден, <xref:System.Windows.Input.ExecutedRoutedEventHandler> связанные с <xref:System.Windows.Input.CommandBinding> вызывается.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Input.RoutedCommand>
- [Общие сведения о системе команд](commanding-overview.md)

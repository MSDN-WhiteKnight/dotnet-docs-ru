---
title: Практическое руководство. Включение команды
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- CommandBindings [WPF]
- commanding [WPF]
ms.assetid: d8016266-58d9-48f7-8298-a86b7ed49fbd
ms.openlocfilehash: bf01066a35672e1996f193abc6d76153e5e9dd46
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59181705"
---
# <a name="how-to-enable-a-command"></a>Практическое руководство. Включение команды
Следующий пример демонстрирует использование команд в Windows Presentation Foundation (WPF).  В примере показано связывание <xref:System.Windows.Input.RoutedCommand> для <xref:System.Windows.Controls.Button>, создание <xref:System.Windows.Input.CommandBinding>и создавать обработчики событий, которые реализуют <xref:System.Windows.Input.RoutedCommand>.  Дополнительные сведения о системе команд см. в разделе [сведения о системе команд](commanding-overview.md).  
  
## <a name="example"></a>Пример  
 В первой части кода создает UI , который состоит из <xref:System.Windows.Controls.Button> и <xref:System.Windows.Controls.StackPanel>и создает <xref:System.Windows.Input.CommandBinding> , связывает обработчики команд с <xref:System.Windows.Input.RoutedCommand>.  
  
 <xref:System.Windows.Input.ICommandSource.Command%2A> Свойство <xref:System.Windows.Controls.Button> связан с <xref:System.Windows.Input.ApplicationCommands.Close%2A> команды.  
  
 <xref:System.Windows.Input.CommandBinding> Добавляется <xref:System.Windows.Input.CommandBindingCollection> корневого <xref:System.Windows.Window>. <xref:System.Windows.Input.CommandBinding.Executed> И <xref:System.Windows.Input.CommandBinding.CanExecute> обработчики событий подключенных к этой привязке и связанные с <xref:System.Windows.Input.ApplicationCommands.Close%2A> команды.  
  
 Без <xref:System.Windows.Input.CommandBinding> отсутствует логика команды, только механизм для вызова команды.  Когда <xref:System.Windows.Controls.Button> нажатии <xref:System.Windows.Input.CommandManager.PreviewExecuted> <xref:System.Windows.RoutedEvent> вызывается для целевого объекта команды, за которым следует <xref:System.Windows.Input.CommandManager.Executed> <xref:System.Windows.RoutedEvent>.  Эти события проходят по дереву элементов, ищете <xref:System.Windows.Input.CommandBinding> для этой конкретной командой.  Стоит отметить, что поскольку <xref:System.Windows.RoutedEvent> проходят и поднимаются по дереву элементов, необходимо соблюдать осторожность, где <xref:System.Windows.Input.CommandBinding> помещается.   Если <xref:System.Windows.Input.CommandBinding> на одноуровневого элемента для целевого объекта команды или другой узел, который не является в маршруте <xref:System.Windows.RoutedEvent>, <xref:System.Windows.Input.CommandBinding> не затрагиваются.  
  
 [!code-xaml[EnableCloseCommand#CloseCommandBinding](~/samples/snippets/csharp/VS_Snippets_Wpf/EnableCloseCommand/CSharp/Window1.xaml#closecommandbinding)]  
  
 [!code-csharp[EnableCloseCommand#CloseCommandBindingCodeBehind](~/samples/snippets/csharp/VS_Snippets_Wpf/EnableCloseCommand/CSharp/Window1.xaml.cs#closecommandbindingcodebehind)]
   
  
 В следующем разделе кода реализует <xref:System.Windows.Input.CommandManager.Executed> и <xref:System.Windows.Input.CommandBinding.CanExecute> обработчики событий.  
  
 <xref:System.Windows.Input.CommandManager.Executed> Обработчик вызывает метод, чтобы закрыть открытый файл.  <xref:System.Windows.Input.CommandBinding.CanExecute> Обработчик вызывает метод, чтобы определить, открыт ли файл.  Если файл был открыт, <xref:System.Windows.Input.CanExecuteRoutedEventArgs.CanExecute%2A> присваивается `true`; в противном случае он становится равным `false`.  
  
 [!code-csharp[EnableCloseCommand#CloseCommandHandler](~/samples/snippets/csharp/VS_Snippets_Wpf/EnableCloseCommand/CSharp/Window1.xaml.cs#closecommandhandler)]
   
  
## <a name="see-also"></a>См. также

- [Общие сведения о системе команд](commanding-overview.md)

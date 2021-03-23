---
title: Практическое руководство. Реализация ICommandSource
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- ICommandSource interfaces [WPF], implementing
ms.assetid: 7452dd39-6e11-44bf-806a-31d87f3772ac
ms.openlocfilehash: 218a17f221598ac29213bd28a0f04adb16bc933b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59107371"
---
# <a name="how-to-implement-icommandsource"></a>Практическое руководство. Реализация ICommandSource
В этом примере показано, как создать источник команды, реализовав <xref:System.Windows.Input.ICommandSource>.  Источник команды — это объект, который знает, как для вызова команды.  <xref:System.Windows.Input.ICommandSource> Интерфейс предоставляет три члена: <xref:System.Windows.Input.ICommandSource.Command%2A>, <xref:System.Windows.Input.ICommandSource.CommandParameter%2A>, и <xref:System.Windows.Input.ICommandSource.CommandTarget%2A>.  <xref:System.Windows.Input.ICommandSource.Command%2A> — Это команда, которая будет вызываться. <xref:System.Windows.Input.ICommandSource.CommandParameter%2A> — Это тип пользовательских данных, который передается из источника команды методу, который обрабатывает команду. <xref:System.Windows.Input.ICommandSource.CommandTarget%2A> — Это объект, для которого выполняется команда.  
  
 В этом примере класс создается который подклассы <xref:System.Windows.Controls.Slider> управления и реализует <xref:System.Windows.Input.ICommandSource>.  
  
## <a name="example"></a>Пример  
 WPF предоставляет ряд классов, которые реализуют <xref:System.Windows.Input.ICommandSource>, такие как <xref:System.Windows.Controls.Button>, <xref:System.Windows.Controls.MenuItem>, и <xref:System.Windows.Controls.ListBoxItem>.  Источник команды определяет, как он вызывает команду.   <xref:System.Windows.Controls.Button> и <xref:System.Windows.Controls.MenuItem> вызывают команду при щелчке.  Объект <xref:System.Windows.Controls.ListBoxItem> вызывает команду при его выборе. Эти классы становится только команды источнику их <xref:System.Windows.Input.ICommandSource.Command%2A> свойству.  
  
 В этом примере команда будет вызываться при перемещении ползунка или, точнее говоря, при <xref:System.Windows.Controls.Primitives.RangeBase.Value%2A> изменении свойства.  
  
 Ниже приведено определение класса.  
  
 [!code-csharp[ImplementICommandSource#ImplementICommandSourceClassDefinition](~/samples/snippets/csharp/VS_Snippets_Wpf/ImplementICommandSource/CSharp/CommandSlider.cs#implementicommandsourceclassdefinition)]
   
  
 Следующим шагом является реализация <xref:System.Windows.Input.ICommandSource> членов.  В этом примере свойства реализуются как <xref:System.Windows.DependencyProperty> объектов.  Это включает свойства для использования привязки данных.  Дополнительные сведения о <xref:System.Windows.DependencyProperty> , представлена в разделе [Общие сведения о свойствах зависимостей](dependency-properties-overview.md).  Дополнительные сведения о привязке данных см. в разделе [Общие сведения о привязке данных](../data/data-binding-overview.md).  
  
 Только <xref:System.Windows.Input.ICommandSource.Command%2A> свойство показан здесь.  
  
 [!code-csharp[ImplementICommandSource#ImplementICommandSourceCommandPropertyDefinition](~/samples/snippets/csharp/VS_Snippets_Wpf/ImplementICommandSource/CSharp/CommandSlider.cs#implementicommandsourcecommandpropertydefinition)]
   
  
 Ниже приведен <xref:System.Windows.DependencyProperty> изменить обратного вызова.  
  
 [!code-csharp[ImplementICommandSource#ImplementICommandSourceCommandChanged](~/samples/snippets/csharp/VS_Snippets_Wpf/ImplementICommandSource/CSharp/CommandSlider.cs#implementicommandsourcecommandchanged)]
   
  
 Следующим шагом является добавление и удаление команды, связанный с источника команды.  <xref:System.Windows.Input.ICommandSource.Command%2A> Свойство не может просто быть перезаписан при добавлении новой команды, так как обработчики событий, связанные с предыдущей командой, если таковая имела место, сначала необходимо удалить.  
  
 [!code-csharp[ImplementICommandSource#ImplementICommandSourceHookUnHookCommands](~/samples/snippets/csharp/VS_Snippets_Wpf/ImplementICommandSource/CSharp/CommandSlider.cs#implementicommandsourcehookunhookcommands)]
   
  
 Последним шагом является создание логики для <xref:System.Windows.Input.ICommand.CanExecuteChanged> обработчика и <xref:System.Windows.Input.ICommand.Execute%2A> метод.  
  
 <xref:System.Windows.Input.ICommand.CanExecuteChanged> Событие сообщает источнику команды, может измениться, возможность команды для выполнения на текущей цели команды.  При получении этого события источник команды обычно вызывает <xref:System.Windows.Input.ICommand.CanExecute%2A> метод о команде.  Если команда не может выполнить на текущей цели команды, источник команды обычно отключается.  Если команда может выполняться для текущего целевого объекта команды, источник команды обычно включает себя.  
  
 [!code-csharp[ImplementICommandSource#ImplementICommandCanExecuteChanged](~/samples/snippets/csharp/VS_Snippets_Wpf/ImplementICommandSource/CSharp/CommandSlider.cs#implementicommandcanexecutechanged)]
   
  
 Последний шаг — <xref:System.Windows.Input.ICommand.Execute%2A> метод.  Если команда является <xref:System.Windows.Input.RoutedCommand>, <xref:System.Windows.Input.RoutedCommand> <xref:System.Windows.Input.RoutedCommand.Execute%2A> метод вызван; в противном случае — значение <xref:System.Windows.Input.ICommand> <xref:System.Windows.Input.ICommand.Execute%2A> вызывается метод.  
  
 [!code-csharp[ImplementICommandSource#ImplementICommandExecute](~/samples/snippets/csharp/VS_Snippets_Wpf/ImplementICommandSource/CSharp/CommandSlider.cs#implementicommandexecute)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Input.ICommandSource>
- <xref:System.Windows.Input.ICommand>
- <xref:System.Windows.Input.RoutedCommand>
- [Общие сведения о системе команд](commanding-overview.md)

---
title: Практическое руководство. Подключение команды к элементу управления с поддержкой команд
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Control class [WPF], attaching a RoutedCommand
- classes [WPF], Control [WPF], attaching a RoutedCommand
- RoutedCommand class [WPF], attaching to a Control
- classes [WPF], RoutedCommand [WPF], attaching to a Control
ms.assetid: 8d8592ae-0c91-469e-a1cd-d179c4544548
ms.openlocfilehash: 981fecf33b60c76ecab760185db7dab4bbb254d7
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59165209"
---
# <a name="how-to-hook-up-a-command-to-a-control-with-command-support"></a>Практическое руководство. Подключение команды к элементу управления с поддержкой команд
В следующем примере показано, как подключить <xref:System.Windows.Input.RoutedCommand> к <xref:System.Windows.Controls.Control> со встроенной поддержкой команды.  Полный пример подключения команд к нескольким источникам см. в примере [Создание примера настраиваемой команды RoutedCommand](https://github.com/Microsoft/WPF-Samples/tree/master/Input%20and%20Commands/CustomRoutedCommand).  
  
## <a name="example"></a>Пример  
 [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] предоставляет библиотеку стандартных команд, которые регулярно при программировании приложений.  Классы, составляющие библиотеку команд : <xref:System.Windows.Input.ApplicationCommands>, <xref:System.Windows.Input.ComponentCommands>, <xref:System.Windows.Input.NavigationCommands>, <xref:System.Windows.Input.MediaCommands> и <xref:System.Windows.Documents.EditingCommands>.  
  
 Статические объекты <xref:System.Windows.Input.RoutedCommand>, формирующие эти классы, не поддерживают командную логику.  Логика команды связана с командой с <xref:System.Windows.Input.CommandBinding>.  Некоторые элементы управления обладают встроенными привязками CommandBinding для некоторых команд.  Этот механизм позволяет сохранять семантику команды даже при изменении ее фактической реализации.  Так, например, класс <xref:System.Windows.Controls.TextBox> обрабатывает команду <xref:System.Windows.Input.ApplicationCommands.Paste%2A> иначе, чем элемент управления, созданный для поддержки изображений, однако базовая идея вставки одного объекта в другой остается неизменной.  Логика команд не может поставляться командой: ее должен поставлять элемент управления или приложение.  
  
 Многие элементы управления в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] имеют встроенную поддержку определенных команд в библиотеке команд.  <xref:System.Windows.Controls.TextBox>, например, такие как поддерживает многие команды редактирования приложений <xref:System.Windows.Input.ApplicationCommands.Paste%2A>, <xref:System.Windows.Input.ApplicationCommands.Copy%2A>, <xref:System.Windows.Input.ApplicationCommands.Cut%2A>, <xref:System.Windows.Input.ApplicationCommands.Redo%2A>, и <xref:System.Windows.Input.ApplicationCommands.Undo%2A>.  Разработчику приложения не нужно выполнять никаких особых действий, чтобы эти команды заработали с этими элементами управления.  Если <xref:System.Windows.Controls.TextBox> является целевым объектом команды при выполнении команды, он будет обрабатывать команду с помощью класса <xref:System.Windows.Input.CommandBinding>, встроенного в элемент управления.  
  
 В следующем примере показано использование <xref:System.Windows.Controls.MenuItem> в качестве источника команды <xref:System.Windows.Input.ApplicationCommands.Paste%2A>, где <xref:System.Windows.Controls.TextBox> является целевым объектом команды.  Вся логика, которая определяет, как <xref:System.Windows.Controls.TextBox> выполняет вставку, встроена в элемент управления <xref:System.Windows.Controls.TextBox>.  
  
 Создается класс <xref:System.Windows.Controls.MenuItem>, и в его свойстве <xref:System.Windows.Controls.MenuItem.Command%2A> задана команда <xref:System.Windows.Input.ApplicationCommands.Paste%2A>.  Для свойства <xref:System.Windows.Controls.MenuItem.CommandTarget%2A> явным образом не задан объект <xref:System.Windows.Controls.TextBox>.  Если свойство <xref:System.Windows.Controls.MenuItem.CommandTarget%2A> не задано, целевым объектом команды будет элемент, который имеет фокус клавиатуры.  Если элемент в фокусе клавиатуры не поддерживает команду <xref:System.Windows.Input.ApplicationCommands.Paste%2A> или не может в настоящее время выполнить команду вставки (например, буфер обмена пуст), то элемент <xref:System.Windows.Controls.MenuItem> будет серым и недоступным для выбора.  
  
 [!code-xaml[MenuItemCommandTask_XAML#MenuItemCommanding](~/samples/snippets/csharp/VS_Snippets_Wpf/MenuItemCommandTask_XAML/CS/Window1.xaml#menuitemcommanding)]  
  
 [!code-csharp[MenuItemCommandTask#MenuItemCommandingCodeBehind](~/samples/snippets/csharp/VS_Snippets_Wpf/MenuItemCommandTask/CSharp/Window1.xaml.cs#menuitemcommandingcodebehind)]
 [!code-vb[MenuItemCommandTask#MenuItemCommandingCodeBehind](~/samples/snippets/visualbasic/VS_Snippets_Wpf/MenuItemCommandTask/VisualBasic/Window1.xaml.vb#menuitemcommandingcodebehind)]  
  
## <a name="see-also"></a>См. также

- [Общие сведения о системе команд](commanding-overview.md)
- [Подключение команды к элементу управления без поддержки команд](how-to-hook-up-a-command-to-a-control-with-no-command-support.md)

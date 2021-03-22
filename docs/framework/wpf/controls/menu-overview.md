---
title: Обзор меню
ms.date: 03/30/2017
helpviewer_keywords:
- Menu control [WPF]
- controls [WPF], Menu
ms.assetid: 67df6de5-db96-4c71-b752-af90729a6537
ms.openlocfilehash: a3250cfd3fd651cb4ed3c4fd6975f5b5c89195f9
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59166378"
---
# <a name="menu-overview"></a>Обзор меню
<xref:System.Windows.Controls.Menu> Класс позволяет организовывать элементы, связанные с командами и обработчиками событий в иерархическом порядке. Каждый <xref:System.Windows.Controls.Menu> элемент содержит коллекцию <xref:System.Windows.Controls.MenuItem> элементов.  

<a name="menu_control"></a>   
## <a name="menu-control"></a>Элемент управления меню  
 <xref:System.Windows.Controls.Menu> Элемент управления представляет список элементов, определяющих команды или параметры для приложения. Как правило, щелкнув <xref:System.Windows.Controls.MenuItem> открывается подменю или вызывает приложение для выполнения команды.  
  
<a name="creating_menus"></a>   
## <a name="creating-menus"></a>Создание меню  
 В следующем примере создается <xref:System.Windows.Controls.Menu> для операций с текстом в <xref:System.Windows.Controls.TextBox>. <xref:System.Windows.Controls.Menu> Содержит <xref:System.Windows.Controls.MenuItem> объектов, использующих <xref:System.Windows.Controls.MenuItem.Command%2A>, <xref:System.Windows.Controls.MenuItem.IsCheckable%2A>, и <xref:System.Windows.Controls.HeaderedItemsControl.Header%2A> свойства и <xref:System.Windows.Controls.MenuItem.Checked>, <xref:System.Windows.Controls.MenuItem.Unchecked>, и <xref:System.Windows.Controls.MenuItem.Click> события.  
  
 [!code-xaml[MenuItemCommandsAndEvents#1](~/samples/snippets/csharp/VS_Snippets_Wpf/MenuItemCommandsAndEvents/CSharp/Window1.xaml#1)]  
  
 [!code-csharp[MenuItemCommandsAndEvents#2](~/samples/snippets/csharp/VS_Snippets_Wpf/MenuItemCommandsAndEvents/CSharp/Window1.xaml.cs#2)]
   
  
<a name="menus_with_shortcutkeys"></a>   
## <a name="menuitems-with-keyboard-shortcuts"></a>Элементы MenuItems с сочетаниями клавиш  
 Сочетания клавиш являются сочетаниями символов, которые могут быть введены с клавиатуры для вызова <xref:System.Windows.Controls.Menu> команды. Например, сочетание клавиш для **копирования** — CTRL+C. Имеется два свойства для использования с сочетания клавиш и элементами меню —<xref:System.Windows.Controls.MenuItem.InputGestureText%2A> или <xref:System.Windows.Controls.MenuItem.Command%2A>.  
  
<a name="menus_inputgesturetext"></a>   
### <a name="inputgesturetext"></a>InputGestureText  
 В следующем примере показано, как использовать <xref:System.Windows.Controls.MenuItem.InputGestureText%2A> свойство, чтобы назначить сочетания клавиш для <xref:System.Windows.Controls.MenuItem> элементов управления. Таким образом можно лишь поместить сочетания клавиш в элемент меню.  Не связывает команду с <xref:System.Windows.Controls.MenuItem>. Приложение должно обработать введенные пользователем данные для выполнения действия.  
  
 [!code-xaml[MenuEvent#6](~/samples/snippets/csharp/VS_Snippets_Wpf/MenuEvent/CSharp/Pane1.xaml#6)]  
  
<a name="menus_commands"></a>   
### <a name="command"></a>Команда  
 В следующем примере показано, как использовать <xref:System.Windows.Controls.MenuItem.Command%2A> свойство, связываемое **откройте** и **Сохранить** команды с параметром <xref:System.Windows.Controls.MenuItem> элементов управления. Не только свойство command связать команду с <xref:System.Windows.Controls.MenuItem>, но также предоставляет жест ввода текста для использования в качестве ярлыка.  
  
 [!code-xaml[MenuEvent#8](~/samples/snippets/csharp/VS_Snippets_Wpf/MenuEvent/CSharp/Pane1.xaml#8)]  
  
 <xref:System.Windows.Controls.MenuItem> Класс также имеет <xref:System.Windows.Controls.MenuItem.CommandTarget%2A> свойство, которое указывает элемент, где происходит действие команды. Если <xref:System.Windows.Controls.MenuItem.CommandTarget%2A> не задано, элемент, имеющий фокус клавиатуры получает команду. Дополнительные сведения о командах см. в разделе [Общие сведения о системе команд](../advanced/commanding-overview.md).  
  
<a name="menu_styling"></a>   
## <a name="menu-styling"></a>Задание стиля меню  
 С помощью стиля элемента управления можно значительно изменить внешний вид и поведение <xref:System.Windows.Controls.Menu> элементы управления без необходимости написания пользовательского элемента управления. В дополнение к установке визуальных свойств также можно применить <xref:System.Windows.Style> к отдельным частям элемента управления, изменить поведение частей элемента управления с помощью свойства, или добавить дополнительные части или изменить макет элемента управления. В следующих примерах показано несколько способов добавления <xref:System.Windows.Style> для <xref:System.Windows.Controls.Menu> элемента управления.  
  
 В первом примере кода определяется <xref:System.Windows.Style> вызывается `Simple` , показано, как использовать текущие параметры системы в стиле. Код назначает `MenuHighlightBrush` цвет в качестве цвета фона меню и `MenuTextBrush` цвет в качестве цвета текста меню. Обратите внимание на использование ключей ресурсов для назначения кистей.  
  
 [!code-xaml[MenuStylesSnippet#1](~/samples/snippets/csharp/VS_Snippets_Wpf/MenuStylesSnippet/CS/app.xaml#1)]  
  
 В следующем примере используется <xref:System.Windows.Trigger> элементы, которые позволяют изменять внешний вид <xref:System.Windows.Controls.MenuItem> в ответ на события, происходящие на <xref:System.Windows.Controls.Menu>. Если навести указатель мыши <xref:System.Windows.Controls.Menu>, цвет переднего плана и изменить характеристики шрифта элементов меню.  
  
 [!code-xaml[MenuStylesSnippet#2](~/samples/snippets/csharp/VS_Snippets_Wpf/MenuStylesSnippet/CS/app.xaml#2)]  
  
## <a name="see-also"></a>См. также

- [Пример коллекции элементов управления WPF](https://go.microsoft.com/fwlink/?LinkID=160053)

---
title: Практическое руководство. Дополнительные возможности объектов ToolStripMenuItem
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- commands [Windows Forms], grouping on menus
- check marks [Windows Forms], adding to menus
- ToolStripMenuItems [Windows Forms], displaying access keys
- menus [Windows Forms], grouping commands
- menu items [Windows Forms], displaying shortcut keys
- ToolStripMenuItems
- separators [Windows Forms], displaying on menus
- menu items [Windows Forms], showing separators
- menu items [Windows Forms], adding check marks
- ToolStripMenuItems [Windows Forms], adding check marks
- menu items [Windows Forms], adding images
- ToolStripSeparators [Windows Forms], displaying on MenuStrips
- menu items [Windows Forms], displaying access keys
- ToolStripMenuItems [Windows Forms], displaying shortcut keys
- ToolStripMenuItems [Windows Forms], adding images
- keyboard shortcuts [Windows Forms], displaying on menus
- images [Windows Forms], adding to menus
- ToolStripMenuItems [Windows Forms], showing separator bars
ms.assetid: aa5f19bb-b545-4378-bfa6-36ba592f0d7c
ms.openlocfilehash: 458347df7e17aabc1e9e21d66ad1b5a96200fe28
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59198560"
---
# <a name="how-to-add-enhancements-to-toolstripmenuitems"></a>Практическое руководство. Дополнительные возможности объектов ToolStripMenuItem
Можно повысить удобство использования <xref:System.Windows.Forms.MenuStrip> и <xref:System.Windows.Forms.ContextMenuStrip> элементы управления одним из следующих способов:  
  
-   Добавьте галочки для обозначения включено или отключить, например, следует ли отображать линейки вдоль поля текстового редактора, или для указания файла в список файлов, отображаемых, например на **окно** меню.  
  
-   Добавление изображений, которые визуально представляют команды меню.  
  
-   Отображать сочетания клавиш, чтобы предоставить альтернативы мыши, клавиатуры для выполнения команды. Например, нажатие клавиш CTRL + C выполняет **копирования** команды.  
  
-   Отображение ключей доступа для предоставления клавиатуры вместо мыши для навигации в меню. Например, нажмите клавиши ALT + F, выбирает **файл** меню.  
  
-   Показать разделители, чтобы сгруппировать связанные команды и сделать меню в более удобном для чтения.  
  
### <a name="to-display-a-check-mark-on-a-menu-command"></a>Чтобы отобразить метку команды меню  
  
-   Задайте его <xref:System.Windows.Forms.ToolStripMenuItem.Checked%2A> свойства `true`.  
  
     Эта команда также задает <xref:System.Windows.Forms.ToolStripMenuItem.CheckState%2A> свойства `true`. Используйте эту процедуру только в том случае, если требуется, чтобы команда меню, подлежащая галочкой по умолчанию, независимо от того, установлен ли флажок.  
  
### <a name="to-display-a-check-mark-that-changes-state-with-each-click"></a>Чтобы отобразить флажок, который изменяет состояние каждого щелчком  
  
-   Команды меню <xref:System.Windows.Forms.ToolStripMenuItem.CheckOnClick%2A> свойства `true`.  
  
### <a name="to-add-an-image-to-a-menu-command"></a>Добавление изображения для команды меню  
  
-   Команды меню <xref:System.Windows.Forms.ToolStripItem.Image%2A> имя изображения. Если <xref:System.Windows.Forms.ToolStripItemDisplayStyle> этой команды меню свойству <xref:System.Windows.Forms.ToolStripItemDisplayStyle.Text> или <xref:System.Windows.Forms.ToolStripItemDisplayStyle.None>, не удается отобразить изображение.  
  
> [!NOTE]
>  Поле изображения также можно Показать метку желанию. Кроме того, можно задать <xref:System.Windows.Forms.ToolStripMenuItem.Checked%2A> свойство изображения `true`, а изображение будет отображаться со штриховой границей вокруг него во время выполнения.  
  
### <a name="to-display-a-shortcut-key-for-a-menu-command"></a>Чтобы отобразить сочетания клавиш для команды меню  
  
-   Команды меню <xref:System.Windows.Forms.ToolStripMenuItem.ShortcutKeys%2A> свойства желаемое сочетание клавиш, например CTRL + O для **откройте** команды меню, а также набор <xref:System.Windows.Forms.ToolStripMenuItem.ShowShortcutKeys%2A> свойства `true`.  
  
### <a name="to-display-custom-shortcut-keys-for-a-menu-command"></a>Чтобы отобразить настраиваемые сочетания клавиш для команды меню  
  
-   Команды меню <xref:System.Windows.Forms.ToolStripMenuItem.ShortcutKeyDisplayString%2A> свойства желаемое сочетание клавиш, например CTRL + SHIFT + O, а не SHIFT + CTRL + O и набор <xref:System.Windows.Forms.ToolStripMenuItem.ShowShortcutKeys%2A> свойства `true`.  
  
### <a name="to-display-an-access-key-for-a-menu-command"></a>Чтобы отобразить ключ доступа для команды меню  
  
-   При задании <xref:System.Windows.Forms.ToolStripItem.Text%2A> свойство для команды меню введите амперсанд (&) перед буквой, чтобы быть подчеркнуты как клавиша доступа. Например, при вводе `&Open` как <xref:System.Windows.Forms.ToolStripItem.Text%2A> свойство пункта меню приведет к команде меню, который отображается в виде <u>O</u>пера.
  
     Чтобы перейти к этой команды меню, нажмите клавишу ALT, чтобы передать фокус <xref:System.Windows.Forms.MenuStrip>и нажмите клавишу доступа для меню. Когда откроется меню и отображаются элементы с помощью ключей доступа, необходимо только клавишу доступа, чтобы выбрать команду меню.  
  
> [!NOTE]
>  Не рекомендуется определять дублирующиеся клавиши доступа, например для определения ALT + F дважды в одной и той же системе меню. Невозможно гарантировать порядок выбора дублирующиеся клавиши доступа.  
  
### <a name="to-display-a-separator-bar-between-menu-commands"></a>Чтобы отобразить строку разделителя между командами меню  
  
-   После определения вашей <xref:System.Windows.Forms.MenuStrip> и элементов, которые он содержит, используйте <xref:System.Windows.Forms.ToolStripItemCollection.AddRange%2A> или <xref:System.Windows.Forms.ToolStripItemCollection.Add%2A> метод для добавления команды меню и <xref:System.Windows.Forms.ToolStripSeparator> элементы управления <xref:System.Windows.Forms.MenuStrip> в том порядке, в.  
  
    ```vb  
    ' This code adds a top-level File menu to the MenuStrip.  
    Me.menuStrip1.Items.Add(New ToolStripMenuItem() _  
    {Me.fileToolStripMenuItem})  
  
    ' This code adds the New and Open menu commands, a separator bar,   
    ' and the Save and Exit menu commands to the top-level File menu,   
    ' in that order.  
    Me.fileToolStripMenuItem.DropDownItems.AddRange(New _  
    ToolStripMenuItem() {Me.newToolStripMenuItem, _  
    Me.openToolStripMenuItem, Me.toolStripSeparator1, _  
    Me.saveToolStripMenuItem, Me.exitToolStripMenuItem})  
    ```  
  
    ```csharp  
    // This code adds a top-level File menu to the MenuStrip.  
    this.menuStrip1.Items.Add(new ToolStripItem[]_  
    {this.fileToolStripMenuItem});  
  
    // This code adds the New and Open menu commands, a separator bar,   
    // and the Save and Exit menu commands to the top-level File menu,   
    // in that order.  
    this.fileToolStripMenuItem.DropDownItems.AddRange(new _  
    ToolStripItem[] {  
    this.newToolStripMenuItem,  
    this.openToolStripMenuItem,  
    this.toolStripSeparator1,  
    this.saveToolStripMenuItem,  
    this.exitToolStripMenuItem});  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.MenuStrip>
- <xref:System.Windows.Forms.ToolStripMenuItem>
- [Общие сведения об элементе управления MenuStrip](menustrip-control-overview-windows-forms.md)

---
title: Практическое руководство. Включение автозаполнения для элементов управления ToolStrip в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- AutoComplete [Windows Forms], examples
- toolbars [Windows Forms], AutoComplete
- examples [Windows Forms], toolbars
- AutoComplete [Windows Forms], enabling in toolbars
- ToolStripComboBox class [Windows Forms], examples
- ToolStrip control [Windows Forms], AutoComplete
ms.assetid: fd66d085-1af1-45d4-930a-cde944da2e16
ms.openlocfilehash: d7919bf87444ef6c4a64ee236356e762da14853f
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59307903"
---
# <a name="how-to-enable-autocomplete-in-toolstrip-controls-in-windows-forms"></a>Практическое руководство. Включение автозаполнения для элементов управления ToolStrip в Windows Forms
В следующей процедуре компонент <xref:System.Windows.Forms.ToolStripLabel> с <xref:System.Windows.Forms.ToolStripComboBox> , можно раскрыть, чтобы показать список элементов, таких как недавно посещенные веб-сайтов. Если пользователь вводит символ, который совпадает с первым символом одного из элементов в списке, сразу же отображается элемент.  
  
> [!NOTE]
>  Автозаполнение `ToolStrip` элементов управления таким же образом, он работает с традиционных элементов управления, такими как <xref:System.Windows.Forms.ComboBox> и <xref:System.Windows.Forms.TextBox>.  
  
### <a name="to-enable-autocomplete-in-a-toolstrip-control"></a>Включение автозаполнения для элемента управления ToolStrip  
  
1. Создание <xref:System.Windows.Forms.ToolStrip> управления и добавлять в нее элементы.  
  
    ```vb  
    ToolStrip1 = New System.Windows.Forms.ToolStrip  
    ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem()_  
        {ToolStripLabel1, ToolStripComboBox1})  
    ```  
  
    ```csharp  
    toolStrip1 = new System.Windows.Forms.ToolStrip();  
    toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]   
        {toolStripLabel1, toolStripComboBox1});  
    ```  
  
2. Задайте <xref:System.Windows.Forms.ToolStripItem.Overflow%2A> свойство метки и поля со списком для <xref:System.Windows.Forms.ToolStripItemOverflow.Never> , чтобы список доступен всегда, независимо от размера формы.  
  
    ```vb  
    ToolStripLabel1.Overflow = _  
        System.Windows.Forms.ToolStripItemOverflow.Never  
    ToolStripComboBox1.Overflow = _  
        System.Windows.Forms.ToolStripItemOverflow.Never  
    ```  
  
    ```csharp  
    toolStripLabel1.Overflow = _  
        System.Windows.Forms.ToolStripItemOverflow.Never  
    toolStripComboBox1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never  
    ```  
  
3. Добавляют к коллекции элементов <xref:System.Windows.Forms.ToolStripComboBox> элемента управления.  
  
    ```vb  
    ToolStripComboBox1.Items.AddRange(New Object() {"First Item", _  
        "Second Item", "Third Item"})  
    ```  
  
    ```csharp  
    toolStripComboBox1.Items.AddRange(new object[] {"First item", "Second item", "Third item"});  
    ```  
  
4. Задайте <xref:System.Windows.Forms.ComboBox.AutoCompleteMode%2A> поля со списком для <xref:System.Windows.Forms.AutoCompleteMode.Append>.  
  
    ```vb  
    ToolStripComboBox1.AutoCompleteMode = _  
        System.Windows.Forms.AutoCompleteMode.Append  
    ```  
  
    ```csharp  
    toolStripComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;  
    ```  
  
5. Задайте <xref:System.Windows.Forms.ComboBox.AutoCompleteSource%2A> поля со списком для <xref:System.Windows.Forms.AutoCompleteSource.ListItems>.  
  
    ```vb  
    ToolStripComboBox1.AutoCompleteSource = _  
        System.Windows.Forms.AutoCompleteSource.ListItems  
    ```  
  
    ```csharp  
    toolStripComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ToolStrip>
- <xref:System.Windows.Forms.ToolStripLabel>
- <xref:System.Windows.Forms.ToolStripComboBox>
- <xref:System.Windows.Forms.ToolStripComboBox.AutoCompleteMode%2A>
- <xref:System.Windows.Forms.ToolStripComboBox.AutoCompleteSource%2A>
- [Общие сведения об элементе управления ToolStrip](toolstrip-control-overview-windows-forms.md)
- [Архитектура элемента управления ToolStrip](toolstrip-control-architecture.md)
- [Технологии, положенные в основу работы элемента управления ToolStrip](toolstrip-technology-summary.md)

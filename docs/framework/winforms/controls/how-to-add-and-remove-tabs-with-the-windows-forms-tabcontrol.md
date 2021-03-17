---
title: Практическое руководство. Добавление и удаление вкладок с помощью элемента управления TabControl в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- tabs [Windows Forms], removing from pages
- TabPage control
- TabControl control [Windows Forms], adding and removing tabs
- tabs [Windows Forms], adding to pages
- tab pages
ms.assetid: 66d4dfca-41e8-44e3-9c80-fb7ac4cb1619
ms.openlocfilehash: 723e05803b1f7d2bc56476248987085dbe5e23f0
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59101605"
---
# <a name="how-to-add-and-remove-tabs-with-the-windows-forms-tabcontrol"></a>Практическое руководство. Добавление и удаление вкладок с помощью элемента управления TabControl в Windows Forms
По умолчанию <xref:System.Windows.Forms.TabControl> управления содержит два <xref:System.Windows.Forms.TabPage> элементов управления. Получить доступ к этим вкладкам через <xref:System.Windows.Forms.TabControl.TabPages%2A> свойство.  
  
### <a name="to-add-a-tab-programmatically"></a>Чтобы добавить вкладку программными средствами  
  
-   Используйте <xref:System.Windows.Forms.TabControl.TabPageCollection.Add%2A> метод <xref:System.Windows.Forms.TabControl.TabPages%2A> свойство.  
  
    ```vb  
    Dim myTabPage As New TabPage()  
    myTabPage.Text = "TabPage" & (TabControl1.TabPages.Count + 1)  
    TabControl1.TabPages.Add(myTabPage)  
    ```  
  
    ```csharp  
    string title = "TabPage " + (tabControl1.TabCount + 1).ToString();  
    TabPage myTabPage = new TabPage(title);  
    tabControl1.TabPages.Add(myTabPage);  
    ```  
  
    ```cpp  
    String^ title = String::Concat("TabPage ",  
       (tabControl1->TabCount + 1).ToString());  
    TabPage^ myTabPage = gcnew TabPage(title);  
    tabControl1->TabPages->Add(myTabPage);  
    ```  
  
### <a name="to-remove-a-tab-programmatically"></a>Чтобы программно удалить вкладку  
  
-   Чтобы удалить выбранных вкладок, используйте <xref:System.Windows.Forms.TabControl.TabPageCollection.Remove%2A> метод <xref:System.Windows.Forms.TabControl.TabPages%2A> свойство.  
  
     -или-  
  
-   Чтобы удалить все вкладки, используйте <xref:System.Windows.Forms.TabControl.TabPageCollection.Clear%2A> метод <xref:System.Windows.Forms.TabControl.TabPages%2A> свойство.  
  
    ```vb  
    ' Removes the selected tab:  
    TabControl1.TabPages.Remove(TabControl1.SelectedTab)  
    ' Removes all the tabs:  
    TabControl1.TabPages.Clear()  
    ```  
  
    ```csharp  
    // Removes the selected tab:  
    tabControl1.TabPages.Remove(tabControl1.SelectedTab);  
    // Removes all the tabs:  
    tabControl1.TabPages.Clear();  
    ```  
  
    ```cpp  
    // Removes the selected tab:  
    tabControl1->TabPages->Remove(tabControl1->SelectedTab);  
    // Removes all the tabs:  
    tabControl1->TabPages->Clear();  
    ```  
  
## <a name="see-also"></a>См. также

- [Общие сведения об элементе управления TabControl](tabcontrol-control-overview-windows-forms.md)
- [Практическое руководство. Добавление элемента управления на вкладку](how-to-add-a-control-to-a-tab-page.md)
- [Практическое руководство. Блокировка доступа ко вкладкам](how-to-disable-tab-pages.md)
- [Практическое руководство. Изменение внешнего вида элемента управления TabControl в Windows Forms](how-to-change-the-appearance-of-the-windows-forms-tabcontrol.md)

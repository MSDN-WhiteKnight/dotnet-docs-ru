---
title: Практическое руководство. Добавление элемента управления в родительское окно MDI (Windows Forms)
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- MenuStrip control [Windows Forms], merging
- MenuStrip control [Windows Forms], appending
- MDI [Windows Forms], merging menu items
ms.assetid: ab70c936-b452-4653-b417-17be57bb795b
ms.openlocfilehash: a335531b090983de4e2b3daccc9f956930cbad6e
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59298946"
---
# <a name="how-to-append-a-menustrip-to-an-mdi-parent-window-windows-forms"></a>Практическое руководство. Добавление элемента управления в родительское окно MDI (Windows Forms)
В некоторых приложениях вид дочернего окна многодокументного интерфейса (MDI) может отличаться от родительского окна MDI. Например, родительским окном MDI может быть электронная таблица, а дочерним окном MDI — диаграмма. В этом случае может потребоваться дополнить содержимое меню родительского окна MDI содержимым меню дочерней MDI-формы, по мере того как активируются дочерние окна MDI различных типов.  
  
 В следующей процедуре используются свойства <xref:System.Windows.Forms.Form.IsMdiContainer%2A>, <xref:System.Windows.Forms.ToolStrip.AllowMerge%2A>, <xref:System.Windows.Forms.MergeAction> и <xref:System.Windows.Forms.ToolStripItem.MergeIndex%2A> для добавления меню дочернего окна MDI в меню родительского окна MDI. При закрытии дочернего окна MDI удаляются пункты меню, добавленные из родительского окна MDI.  
  
 Также см. в разделе [приложений многодокументного интерфейса (MDI)](../advanced/multiple-document-interface-mdi-applications.md).  
  
### <a name="to-append-a-menu-item-to-an-mdi-parent"></a>Добавление пункта меню в родительское окно MDI  
  
1. Создайте форму и присвойте ее свойству <xref:System.Windows.Forms.Form.IsMdiContainer%2A> значение `true`.  
  
2. Добавьте <xref:System.Windows.Forms.MenuStrip> на `Form1` и присвойте свойству <xref:System.Windows.Forms.ToolStrip.AllowMerge%2A> для элемента <xref:System.Windows.Forms.MenuStrip> значение `true`.  
  
3. Задайте <xref:System.Windows.Forms.ToolStripItem.Visible%2A> свойство `Form1`<xref:System.Windows.Forms.MenuStrip> для `false`.  
  
4. Добавьте пункт меню верхнего уровня для `Form1`<xref:System.Windows.Forms.MenuStrip> и задайте его <xref:System.Windows.Forms.Control.Text%2A> свойства `&File`.  
  
5. Добавьте пункт подменю в элемент меню `&File` и присвойте его свойству <xref:System.Windows.Forms.Form.Text%2A> значение `&Open`.  
  
6. Добавьте в проект форму, добавьте <xref:System.Windows.Forms.MenuStrip> в форму и задайте <xref:System.Windows.Forms.ToolStrip.AllowMerge%2A> свойство `Form2`<xref:System.Windows.Forms.MenuStrip> для `true`.  
  
7. Добавьте пункт меню верхнего уровня для `Form2`<xref:System.Windows.Forms.MenuStrip> и задайте его <xref:System.Windows.Forms.Form.Text%2A> свойства `&Special`.  
  
8. Добавьте два подменю к пункту меню `&Special` и присвойте их свойствам <xref:System.Windows.Forms.Form.Text%2A> значения `Command&1` и `Command&2` соответственно.  
  
9. Присвойте свойству <xref:System.Windows.Forms.MergeAction> элементов меню `&Special`, `Command&1` и `Command&2` значение <xref:System.Windows.Forms.MergeAction.Append>.  
  
10. Создайте обработчик событий для <xref:System.Windows.Forms.Control.Click> событие `&New`<xref:System.Windows.Forms.ToolStripMenuItem>.  
  
11. В обработчик событий вставьте код, аналогичный приведенному в следующем примере для создания и отображения новых экземпляров `Form2` в качестве дочерних окон MDI `Form1`.  
  
    ```vb  
    Private Sub openToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openToolStripMenuItem.Click  
        Dim NewMDIChild As New Form2()  
        'Set the parent form of the child window.  
            NewMDIChild.MdiParent = Me  
        'Display the new form.  
            NewMDIChild.Show()  
    End Sub  
    ```  
  
    ```csharp  
    private void openToolStripMenuItem_Click(object sender, EventArgs e)  
    {  
        Form2 newMDIChild = new Form2();  
        // Set the parent form of the child window.  
            newMDIChild.MdiParent = this;  
        // Display the new form.  
            newMDIChild.Show();  
    }  
    ```  
  
12. Поместите код, аналогичный приведенному ниже код в `&Open`<xref:System.Windows.Forms.ToolStripMenuItem> для регистрации обработчика событий.  
  
    ```vb  
    Private Sub openToolStripMenuItem_Click(sender As Object, e As _  
    EventArgs) Handles openToolStripMenuItem.Click  
    ```  
  
    ```csharp  
    this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);  
    ```  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   два элемента управления <xref:System.Windows.Forms.Form> с именами `Form1` и `Form2`;  
  
-   элемент управления <xref:System.Windows.Forms.MenuStrip> на `Form1` с именем `menuStrip1` и элемент управления <xref:System.Windows.Forms.MenuStrip> на `Form2` с именем `menuStrip2`;  
  
-   ссылки на сборки <xref:System?displayProperty=nameWithType> и <xref:System.Windows.Forms?displayProperty=nameWithType>.

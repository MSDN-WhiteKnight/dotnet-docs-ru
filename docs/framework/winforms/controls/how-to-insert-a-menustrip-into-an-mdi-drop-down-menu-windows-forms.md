---
title: Практическое руководство. Вставка элемента MenuStrip в раскрывающемся меню интерфейса MDI (Windows Forms)
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- MenuStrip control [Windows Forms], inserting
- MenuStrip control [Windows Forms], merging
- MDI [Windows Forms], merging menu items
ms.assetid: 0fad444e-26d9-49af-8860-044d9c10d608
ms.openlocfilehash: 1b41699d8da1c99705f6796105dab6f3ab1d727d
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59341638"
---
# <a name="how-to-insert-a-menustrip-into-an-mdi-drop-down-menu-windows-forms"></a>Практическое руководство. Вставка элемента MenuStrip в раскрывающемся меню интерфейса MDI (Windows Forms)
В некоторых приложениях вид дочернего окна многодокументного интерфейса (MDI) может отличаться от родительского окна MDI. Например, родительским окном MDI может быть электронная таблица, а дочерним окном MDI — диаграмма. В этом случае может потребоваться дополнить содержимое меню родительского окна MDI содержимым меню дочерней MDI-формы, по мере того как активируются дочерние окна MDI различных типов.  
  
 В следующей процедуре используется <xref:System.Windows.Forms.Form.IsMdiContainer%2A>, <xref:System.Windows.Forms.ToolStrip.AllowMerge%2A>, <xref:System.Windows.Forms.MergeAction>, и <xref:System.Windows.Forms.ToolStripItem.MergeIndex%2A> свойства, чтобы вставить группу пунктов меню из дочернего меню MDI в в раскрывающегося списка части родительского меню MDI. При закрытии дочернего окна MDI удаляются пункты меню, вставленные из родительского окна MDI.  
  
### <a name="to-insert-a-menustrip-into-an-mdi-drop-down-menu"></a>Чтобы Вставка элемента MenuStrip в раскрывающееся меню интерфейса MDI  
  
1. Создайте форму и присвойте ее свойству <xref:System.Windows.Forms.Form.IsMdiContainer%2A> значение `true`.  
  
2. Добавьте <xref:System.Windows.Forms.MenuStrip> на `Form1` и присвойте свойству <xref:System.Windows.Forms.ToolStrip.AllowMerge%2A> для элемента <xref:System.Windows.Forms.MenuStrip> значение `true`.  
  
3. Добавьте пункт меню верхнего уровня для `Form1`<xref:System.Windows.Forms.MenuStrip> и задайте его <xref:System.Windows.Forms.Control.Text%2A> свойства `&File`.  
  
4. Добавьте три элемента вложенного меню для `&File` пункта меню и задайте их <xref:System.Windows.Forms.ToolStripItem.Text%2A> свойства `&Open`, `&Import from`, и `E&xit`.  
  
5. Добавьте два подменю к `&Import from` подменю и задайте их <xref:System.Windows.Forms.ToolStripItem.Text%2A> свойства `&Word` и `&Excel`.  
  
6. Добавьте в проект форму, добавьте <xref:System.Windows.Forms.MenuStrip> в форму и задайте <xref:System.Windows.Forms.ToolStrip.AllowMerge%2A> свойство `Form2`<xref:System.Windows.Forms.MenuStrip> для `true`.  
  
7. Добавьте пункт меню верхнего уровня для `Form2`<xref:System.Windows.Forms.MenuStrip> и задайте его <xref:System.Windows.Forms.ToolStripItem.Text%2A> свойства `&File`.  
  
8. Добавить подменю `&File` меню `Form2` в следующем порядке: <xref:System.Windows.Forms.ToolStripSeparator>, `&Save`, `Save and &Close`и другой <xref:System.Windows.Forms.ToolStripSeparator>.  
  
9. Задайте <xref:System.Windows.Forms.MergeAction> и <xref:System.Windows.Forms.ToolStripItem.MergeIndex%2A> свойства `Form2` пункты меню, как показано в следующей таблице.  
  
    |Пункт меню Form2|Значение MergeAction|Значение MergeIndex|  
    |---------------------|-----------------------|----------------------|  
    |Файл|MatchOnly|-1|  
    |Separator|Insert|2|  
    |Сохранение|Insert|3|  
    |Сохранить и закрыть|Insert|4|  
    |Separator|Insert|5|  
  
10. Создайте обработчик событий для <xref:System.Windows.Forms.Control.Click> событие `&Open`<xref:System.Windows.Forms.ToolStripMenuItem>.  
  
11. В обработчик событий вставьте код, аналогичный приведенному в следующем примере для создания и отображения новых экземпляров `Form2` в качестве дочерних окон MDI `Form1`.  
  
    ```vb  
    Private Sub openToolStripMenuItem_Click(ByVal sender As System.Object, _  
    ByVal e As System.EventArgs) Handles openToolStripMenuItem.Click  
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
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Создание родительских MDI-форм](../advanced/how-to-create-mdi-parent-forms.md)
- [Практическое руководство. Создание дочерних форм MDI](../advanced/how-to-create-mdi-child-forms.md)
- [Общие сведения об элементе управления MenuStrip](menustrip-control-overview-windows-forms.md)

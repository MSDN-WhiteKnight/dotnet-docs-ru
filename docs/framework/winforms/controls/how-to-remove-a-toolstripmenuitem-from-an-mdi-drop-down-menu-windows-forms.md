---
title: Практическое руководство. Удаление элемента ToolStripMenuItem из раскрывающегося меню MDI (Windows Forms)
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- menu items [Windows Forms], removing from MDI drop-down menus
- MenuStrip control [Windows Forms], merging
- MenuStrip control [Windows Forms], removing
- MDI [Windows Forms], merging menu items
ms.assetid: bdafe60d-82ee-45bc-97fe-eeefca6e54c1
ms.openlocfilehash: 7c84d260783e3a511b5ef6a651c71f1ee55acffe
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59295345"
---
# <a name="how-to-remove-a-toolstripmenuitem-from-an-mdi-drop-down-menu-windows-forms"></a>Практическое руководство. Удаление элемента ToolStripMenuItem из раскрывающегося меню MDI (Windows Forms)
В некоторых приложениях вид дочернего окна многодокументного интерфейса (MDI) может отличаться от родительского окна MDI. Например, родительским окном MDI может быть электронная таблица, а дочерним окном MDI — диаграмма. В этом случае может потребоваться дополнить содержимое меню родительского окна MDI содержимым меню дочерней MDI-формы, по мере того как активируются дочерние окна MDI различных типов.  
  
 В следующей процедуре используется <xref:System.Windows.Forms.Form.IsMdiContainer%2A>, <xref:System.Windows.Forms.ToolStrip.AllowMerge%2A>, <xref:System.Windows.Forms.MergeAction>, и <xref:System.Windows.Forms.ToolStripItem.MergeIndex%2A> свойств, чтобы удалить элемент меню из раскрывающегося списка части родительского меню MDI. Восстановление удаленных пунктов меню родительского меню MDI закрытии дочернего окна MDI.  
  
### <a name="to-remove-a-menustrip-from-an-mdi-drop-down-menu"></a>Для удаления элемента управления из меню MDI  
  
1. Создайте форму и присвойте ее свойству <xref:System.Windows.Forms.Form.IsMdiContainer%2A> значение `true`.  
  
2. Добавьте <xref:System.Windows.Forms.MenuStrip> на `Form1` и присвойте свойству <xref:System.Windows.Forms.ToolStrip.AllowMerge%2A> для элемента <xref:System.Windows.Forms.MenuStrip> значение `true`.  
  
3. Добавьте пункт меню верхнего уровня для `Form1`<xref:System.Windows.Forms.MenuStrip> и задайте его <xref:System.Windows.Forms.Control.Text%2A> свойства `&File`.  
  
4. Добавьте три элемента вложенного меню для `&File` пункта меню и задайте их <xref:System.Windows.Forms.ToolStripItem.Text%2A> свойства `&Open`, `&Import from`, и `E&xit`.  
  
5. Добавьте два подменю к `&Import from` подменю и задайте их <xref:System.Windows.Forms.ToolStripItem.Text%2A> свойства `&Word` и `&Excel`.  
  
6. Добавьте в проект форму, добавьте <xref:System.Windows.Forms.MenuStrip> в форму и задайте <xref:System.Windows.Forms.ToolStrip.AllowMerge%2A> свойство `Form2`<xref:System.Windows.Forms.MenuStrip> для `true`.  
  
7. Добавьте пункт меню верхнего уровня для `Form2`<xref:System.Windows.Forms.MenuStrip> и задайте его <xref:System.Windows.Forms.ToolStripItem.Text%2A> свойства `&File`.  
  
8. Добавить `&Import from` пункт подменю `&File` меню `Form2`и добавьте `&Word` пункт подменю `&File` меню.  
  
9. Задайте <xref:System.Windows.Forms.MergeAction> и <xref:System.Windows.Forms.ToolStripItem.MergeIndex%2A> свойства `Form2` пункты меню, как показано в следующей таблице.  
  
    |Пункт меню Form2|Значение MergeAction|Значение MergeIndex|  
    |---------------------|-----------------------|----------------------|  
    |Файл|MatchOnly|-1|  
    |Импорт из|MatchOnly|-1|  
    |Слово|Удалить|-1|  
  
10. В `Form1`, создайте обработчик событий для <xref:System.Windows.Forms.Control.Click> событие `&Open`<xref:System.Windows.Forms.ToolStripMenuItem>.  
  
11. В обработчик событий вставьте код, аналогичный приведенному в следующем примере кода для создания и отображения новых экземпляров `Form2` качестве дочерних окон MDI `Form1`:  
  
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
    this.openToolStripMenuItem.Click += new _  
    System.EventHandler(this.openToolStripMenuItem_Click);  
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

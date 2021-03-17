---
title: Практическое руководство. Создание списка в окне интерфейса MDI с помощью MenuStrip (Windows Forms)
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- MDI [Windows Forms], creating window lists
- MenuStrip control [Windows Forms], creating window lists
ms.assetid: 04fb414b-811f-4a83-aab6-b4a24646dec5
ms.openlocfilehash: ec0d8af81e320bea3d9d69305f91bd56666ba7cc
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59299648"
---
# <a name="how-to-create-an-mdi-window-list-with-menustrip-windows-forms"></a>Практическое руководство. Создание списка в окне интерфейса MDI с помощью MenuStrip (Windows Forms)
Используйте многодокументного интерфейса (MDI) для создания приложений, которые могут открывать несколько документов, в том же время и скопируйте и вставьте содержимое из одного документа в другой.  
  
 Эта процедура показано, как создать список всех активных дочерних форм в меню родительского окна.  
  
### <a name="to-create-an-mdi-window-list-on-a-menustrip"></a>Чтобы создать список окна интерфейса MDI в элементе управления MenuStrip  
  
1. Создайте форму и присвойте ее свойству <xref:System.Windows.Forms.Form.IsMdiContainer%2A> значение `true`.  
  
2. Добавьте на форму элемент <xref:System.Windows.Forms.MenuStrip>.  
  
3. Добавьте два элемента меню верхнего уровня для <xref:System.Windows.Forms.MenuStrip> и задайте их <xref:System.Windows.Forms.Control.Text%2A> свойства `&File` и `&Window`.  
  
4. Добавьте пункт подменю в элемент меню `&File` и присвойте его свойству <xref:System.Windows.Forms.ToolStripItem.Text%2A> значение `&Open`.  
  
5. Задайте <xref:System.Windows.Forms.MenuStrip.MdiWindowListItem%2A> свойство <xref:System.Windows.Forms.MenuStrip> для `&Window`<xref:System.Windows.Forms.ToolStripMenuItem>.  
  
6. Добавьте форму в проект и добавьте нужный элемент управления, такие как другой <xref:System.Windows.Forms.MenuStrip>.  
  
7. Создайте обработчик событий для <xref:System.Windows.Forms.Control.Click> событие `&New`<xref:System.Windows.Forms.ToolStripMenuItem>.  
  
8. В обработчик событий вставьте код, аналогичный приведенному ниже, чтобы создать и отобразить новые экземпляры `Form2` качестве дочерних окон MDI `Form1`.  
  
    ```vb  
    Private Sub openToolStripMenuItem_Click(ByVal sender As _  
    System.Object, ByVal e As System.EventArgs) Handles _  
    openToolStripMenuItem.Click  
        Dim NewMDIChild As New Form2()  
        'Set the parent form of the child window.  
            NewMDIChild.MdiParent = Me  
        'Display the new form.  
            NewMDIChild.Show()  
    End Sub  
    ```  
  
    ```csharp  
    private void newToolStripMenuItem_Click(object sender, EventArgs e)  
    {  
        Form2 newMDIChild = new Form2();  
        // Set the parent form of the child window.  
            newMDIChild.MdiParent = this;  
        // Display the new form.  
            newMDIChild.Show();  
    }  
    ```  
  
9. Поместите код, аналогичный следующему в `&New`<xref:System.Windows.Forms.ToolStripMenuItem> для регистрации обработчика событий.  
  
    ```vb  
    Private Sub newToolStripMenuItem_Click(sender As Object, e As _  
    EventArgs) Handles newToolStripMenuItem.Click  
    ```  
  
    ```csharp  
    this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);  
    ```  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   два элемента управления <xref:System.Windows.Forms.Form> с именами `Form1` и `Form2`;  
  
-   элемент управления <xref:System.Windows.Forms.MenuStrip> на `Form1` с именем `menuStrip1` и элемент управления <xref:System.Windows.Forms.MenuStrip> на `Form2` с именем `menuStrip2`;  
  
-   ссылки на сборки <xref:System?displayProperty=nameWithType> и <xref:System.Windows.Forms?displayProperty=nameWithType>.  
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Создание родительских MDI-форм](../advanced/how-to-create-mdi-parent-forms.md)
- [Практическое руководство. Создание дочерних форм MDI](../advanced/how-to-create-mdi-child-forms.md)
- [Элемент управления MenuStrip](menustrip-control-windows-forms.md)

---
title: Практическое руководство. Определение активной дочерней MDI-формы
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Clipboard [Windows Forms], copying data to
- MDI [Windows Forms], child windows
- child forms
- MDI [Windows Forms], activating forms
- MDI [Windows Forms], locating focus
ms.assetid: 33880ec3-0207-4c2b-a616-ff140443cc0f
ms.openlocfilehash: 9b70824670b8f47a2346135cb31ad39bd55694d1
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59300610"
---
# <a name="how-to-determine-the-active-mdi-child"></a>Практическое руководство. Определение активной дочерней MDI-формы
В некоторых случаях требуется предоставить это команда, работающая на элементе управления, имеющий фокус на данный момент активной дочерней формы. Например предположим, что вы хотите копировать выделенный текст из текстового поля дочерней формы в буфер обмена. Необходимо создать процедуру, которая копирует выделенный текст в буфер обмена с помощью <xref:System.Windows.Forms.Control.Click> событие копию элемента меню на стандартные меню "Правка".  
  
 Поскольку MDI-приложения можно создать несколько экземпляров того же дочерней формы, процедура должна знать, какую форму для использования. Чтобы указать требуемую форму, используйте <xref:System.Windows.Forms.Form.ActiveMdiChild%2A> свойство, которое возвращает, имеющий фокус, или это было самую последнюю активную дочернюю форму.  
  
 При наличии нескольких элементов управления в форме, необходимо также указать, какой элемент управления является активным. Как и <xref:System.Windows.Forms.Form.ActiveMdiChild%2A> свойство, <xref:System.Windows.Forms.ContainerControl.ActiveControl%2A> возвращает элемент управления с фокусом на активной дочерней формы. Следующая процедура служит примером процедуры копирования, которые могут вызываться из меню дочерней формы, из меню MDI-формы, или кнопку панели инструментов.  
  
### <a name="to-determine-the-active-mdi-child-to-copy-its-text-to-the-clipboard"></a>Для определения активной дочерней MDI-формы (чтобы скопировать его текст в буфер обмена)  
  
1. В методе скопируйте текст активного элемента управления активной дочерней формы в буфер обмена.  
  
    > [!NOTE]
    >  В этом примере предполагается, имеется родительская форма MDI (`Form1`), имеет один или несколько дочерних MDI-окон содержащий <xref:System.Windows.Forms.RichTextBox> элемента управления. Дополнительные сведения см. в разделе [Создание родительских MDI-форм](how-to-create-mdi-parent-forms.md).  
  
    ```vb  
    Public Sub mniCopy_Click(ByVal sender As Object, _  
       ByVal e As System.EventArgs) Handles mniCopy.Click  
  
       ' Determine the active child form.  
       Dim activeChild As Form = Me.ActiveMDIChild  
  
       ' If there is an active child form, find the active control, which  
       ' in this example should be a RichTextBox.  
       If (Not activeChild Is Nothing) Then  
          Dim theBox As RichTextBox = _  
            TryCast(activeChild.ActiveControl, RichTextBox)  
  
          If (Not theBox Is Nothing) Then  
             'Put selected text on Clipboard.  
             Clipboard.SetDataObject(theBox.SelectedText)  
          Else  
             MessageBox.Show("You need to select a RichTextBox.")  
          End If  
       End If  
    End Sub  
    ```  
  
    ```csharp  
    protected void mniCopy_Click (object sender, System.EventArgs e)  
    {  
       // Determine the active child form.  
       Form activeChild = this.ActiveMdiChild;  
  
       // If there is an active child form, find the active control, which  
       // in this example should be a RichTextBox.  
       if (activeChild != null)  
       {    
          try  
          {  
             RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;  
             if (theBox != null)  
             {  
                // Put the selected text on the Clipboard.  
                Clipboard.SetDataObject(theBox.SelectedText);  
  
             }  
          }  
          catch  
          {  
             MessageBox.Show("You need to select a RichTextBox.");  
          }  
       }  
    }  
    ```  
  
## <a name="see-also"></a>См. также

- [Приложения с интерфейсом MDI](multiple-document-interface-mdi-applications.md)
- [Практическое руководство. Создание родительских MDI-форм](how-to-create-mdi-parent-forms.md)
- [Практическое руководство. Создание дочерних форм MDI](how-to-create-mdi-child-forms.md)
- [Практическое руководство. Отправка данных в активную дочернюю MDI-форму](how-to-send-data-to-the-active-mdi-child.md)
- [Практическое руководство. Упорядочение дочерних MDI-форм](how-to-arrange-mdi-child-forms.md)

---
title: Практическое руководство. Управление положением курсора в элементе управления TextBox в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- TextBox control [Windows Forms], insertion point
- insertion points [Windows Forms], TextBox controls
- text boxes [Windows Forms], controlling insertion point
ms.assetid: 5bee7d34-5121-429e-ab1f-d8ff67bc74c1
ms.openlocfilehash: 43fdb023f19aa988dfef3dcd68443d6f59808472
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59341326"
---
# <a name="how-to-control-the-insertion-point-in-a-windows-forms-textbox-control"></a>Практическое руководство. Управление положением курсора в элементе управления TextBox в Windows Forms
Когда форм Windows <xref:System.Windows.Forms.TextBox> управления впервые получает фокус, по умолчанию курсор в текстовое поле находится слева от текста. Пользователь может перемещать курсор с помощью мыши или клавиатуры. Если текстовое поле теряет и затем восстанавливает фокус, курсор будет везде, где пользователь последний раз поместил его.  
  
 В некоторых случаях такое поведение может быть всегда удобен для пользователя. В текстовом редакторе приложение, пользователь может ожидать новые символы, который будет отображаться после любой существующий текст. В приложение для ввода данных пользователь может ожидать новые символы для замены существующих записей. <xref:System.Windows.Forms.TextBoxBase.SelectionStart%2A> И <xref:System.Windows.Forms.TextBoxBase.SelectionLength%2A> свойства позволяют изменить поведение в соответствии с вашими задачами.  
  
### <a name="to-control-the-insertion-point-in-a-textbox-control"></a>Чтобы управление положением курсора в элементе управления TextBox  
  
1. Присвойте свойству <xref:System.Windows.Forms.TextBoxBase.SelectionStart%2A> соответствующее значение. Ноль помещает курсор непосредственно слева от первого символа.  
  
2. (Необязательно) Задать <xref:System.Windows.Forms.TextBoxBase.SelectionLength%2A> свойства длину текста, который вы хотите выбрать.  
  
     Приведенный ниже код всегда возвращает точку вставки на 0. `TextBox1_Enter` Обработчик событий должен быть привязан к элементу управления; Дополнительные сведения, см. в разделе [Создание обработчиков событий в Windows Forms](../creating-event-handlers-in-windows-forms.md).  
  
    ```vb  
    Private Sub TextBox1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Enter  
       TextBox1.SelectionStart = 0  
       TextBox1.SelectionLength = 0  
    End Sub  
    ```  
  
    ```csharp  
    private void textBox1_Enter(Object sender, System.EventArgs e) {  
       textBox1.SelectionStart = 0;  
       textBox1.SelectionLength = 0;  
    }  
    ```  
  
    ```cpp  
    private:  
       void textBox1_Enter(System::Object ^  sender,  
          System::EventArgs ^  e)  
       {  
          textBox1->SelectionStart = 0;  
          textBox1->SelectionLength = 0;  
       }  
    ```  
  
## <a name="making-the-insertion-point-visible-by-default"></a>Как сделать курсор отображается по умолчанию  
 <xref:System.Windows.Forms.TextBox> Курсор отображается по умолчанию в новой форме только если <xref:System.Windows.Forms.TextBox> элемент управления является первым в последовательности табуляции. В противном случае курсор отображается только в том случае, если вы предоставите <xref:System.Windows.Forms.TextBox> фокус с клавиатуры или мыши.  
  
#### <a name="to-make-the-text-box-insertion-point-visible-by-default-on-a-new-form"></a>Чтобы сделать видимым курсор по умолчанию на новую форму  
  
-   Задайте <xref:System.Windows.Forms.TextBox> элемента управления <xref:System.Windows.Forms.Control.TabIndex%2A> свойства `0`.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.TextBox>
- [Общие сведения об элементе управления TextBox](textbox-control-overview-windows-forms.md)
- [Практическое руководство. Создание текстового поля для ввода пароля с помощью элемента управления TextBox в Windows Forms](how-to-create-a-password-text-box-with-the-windows-forms-textbox-control.md)
- [Практическое руководство. Создание текстового поля только для чтения](how-to-create-a-read-only-text-box-windows-forms.md)
- [Практическое руководство. Добавление кавычек в строку](how-to-put-quotation-marks-in-a-string-windows-forms.md)
- [Практическое руководство. Выделение текста в элементе управления TextBox в Windows Forms](how-to-select-text-in-the-windows-forms-textbox-control.md)
- [Практическое руководство. Многострочные элементы управления TextBox в Windows Forms](how-to-view-multiple-lines-in-the-windows-forms-textbox-control.md)
- [Элемент управления TextBox](textbox-control-windows-forms.md)

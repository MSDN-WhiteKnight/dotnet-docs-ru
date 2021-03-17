---
title: Практическое руководство. Выделение текста в элементе управления TextBox в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- TextBox control [Windows Forms], selecting text programmatically
- text boxes [Windows Forms], selecting text programmatically
- text [Windows Forms], selecting in text boxes programmatically
ms.assetid: 8c591546-6a01-45c7-8e03-f78431f903b1
ms.openlocfilehash: 3bb1245cd47084935d632ff345a32058db6074e1
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59321720"
---
# <a name="how-to-select-text-in-the-windows-forms-textbox-control"></a>Практическое руководство. Выделение текста в элементе управления TextBox в Windows Forms
Выделите текст программными средствами в Windows Forms <xref:System.Windows.Forms.TextBox> элемента управления. Например создав функцию, которая ищет текст для определенной строки, можно выбрать текст, который визуально уведомления позицию найденной строки.  
  
### <a name="to-select-text-programmatically"></a>Выделение текста программными средствами  
  
1. Задайте <xref:System.Windows.Forms.TextBoxBase.SelectionStart%2A> свойство в начале текста, который вы хотите выбрать.  
  
     <xref:System.Windows.Forms.TextBoxBase.SelectionStart%2A> Свойство является число, указывающее точку вставки в текстовой строке, причем 0 крайней левой позиции. Если <xref:System.Windows.Forms.TextBoxBase.SelectionStart%2A> свойству присвоено значение меньше, чем количество символов в текстовом поле, курсор помещается после последнего символа.  
  
2. Задать <xref:System.Windows.Forms.TextBoxBase.SelectionLength%2A> свойства длину текста, который вы хотите выбрать.  
  
     <xref:System.Windows.Forms.TextBoxBase.SelectionLength%2A> Свойство — это числовое значение, которое задает ширину курсора. Параметр <xref:System.Windows.Forms.TextBoxBase.SelectionLength%2A> больше нуля, это число выделяемых знаков, начиная с текущей позиции курсора.  
  
3. (Необязательно) Доступ к выделенный текст через <xref:System.Windows.Forms.TextBoxBase.SelectedText%2A> свойство.  
  
     В следующем примере выделяется содержимое текстового поля при элемента управления <xref:System.Windows.Forms.Control.Enter> событием. В этом примере проверяется, если текстовое поле имеет значение <xref:System.Windows.Forms.TextBox.Text%2A> свойство, которое не является `null` или является пустой строкой. Когда текстовое поле получает фокус, выбран текущий текст в текстовом поле. `TextBox1_Enter` Обработчик событий должен быть привязан к элементу управления; Дополнительные сведения, см. в разделе [как: Создание обработчиков событий во время выполнения для форм Windows Forms](../how-to-create-event-handlers-at-run-time-for-windows-forms.md).  
  
     Чтобы протестировать этот пример, нажмите клавишу Tab, пока в текстовом поле имеет фокус. Если щелкнуть в текстовом поле, текст не выбран.  
  
    ```vb  
    Private Sub TextBox1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Enter  
       If (Not String.IsNullOrEmpty(TextBox1.Text)) Then  
          TextBox1.SelectionStart = 0  
          TextBox1.SelectionLength = TextBox1.Text.Length  
       End If  
    End Sub  
    ```  
  
    ```csharp  
    private void textBox1_Enter(object sender, System.EventArgs e){  
       if (!String.IsNullOrEmpty(textBox1.Text))  
       {  
          textBox1.SelectionStart = 0;  
          textBox1.SelectionLength = textBox1.Text.Length;  
       }  
    }  
    ```  
  
    ```cpp  
    private:  
       void textBox1_Enter(System::Object ^ sender,  
          System::EventArgs ^ e) {  
       if (!System::String::IsNullOrEmpty(textBox1->Text))  
       {  
          textBox1->SelectionStart = 0;  
          textBox1->SelectionLength = textBox1->Text->Length;  
       }  
    }  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.TextBox>
- [Общие сведения об элементе управления TextBox](textbox-control-overview-windows-forms.md)
- [Практическое руководство. Управление положением курсора в элементе управления TextBox в Windows Forms](how-to-control-the-insertion-point-in-a-windows-forms-textbox-control.md)
- [Практическое руководство. Создание текстового поля для ввода пароля с помощью элемента управления TextBox в Windows Forms](how-to-create-a-password-text-box-with-the-windows-forms-textbox-control.md)
- [Практическое руководство. Создание текстового поля только для чтения](how-to-create-a-read-only-text-box-windows-forms.md)
- [Практическое руководство. Добавление кавычек в строку](how-to-put-quotation-marks-in-a-string-windows-forms.md)
- [Практическое руководство. Многострочные элементы управления TextBox в Windows Forms](how-to-view-multiple-lines-in-the-windows-forms-textbox-control.md)
- [Элемент управления TextBox](textbox-control-windows-forms.md)

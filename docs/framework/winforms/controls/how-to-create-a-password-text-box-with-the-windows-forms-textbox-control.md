---
title: Практическое руководство. Создание текстового поля для ввода пароля с помощью элемента управления TextBox в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- TextBox control [Windows Forms], entering passwords
- password boxes [Windows Forms], creating
- PasswordChar property in text boxes
- passwords [Windows Forms], input mask
- passwords [Windows Forms], password text box
ms.assetid: d105d6b9-3d50-44cd-80d8-2c0e2f486727
ms.openlocfilehash: ab5df1233c16a7ce076efa817fb14808b588ebcd
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59300987"
---
# <a name="how-to-create-a-password-text-box-with-the-windows-forms-textbox-control"></a>Практическое руководство. Создание текстового поля для ввода пароля с помощью элемента управления TextBox в Windows Forms
Поле пароля представляет собой текстовое поле Windows Forms, который отображает заполнителем, пока пользователь вводит строку.  
  
### <a name="to-create-a-password-text-box"></a>Чтобы создать текстовое поле пароля  
  
1. Задайте <xref:System.Windows.Forms.TextBox.PasswordChar%2A> свойство <xref:System.Windows.Forms.TextBox> элемента управления к определенному символу.  
  
     <xref:System.Windows.Forms.TextBox.PasswordChar%2A> Свойство определяет знак, используемый в текстовом поле. Например, вы звездочки, отображаемый в поле "пароль", укажите * для <xref:System.Windows.Forms.TextBox.PasswordChar%2A> свойства в окне «Свойства». Затем независимо от того, какой символ, который пользователь вводит в текстовое поле, отображается звездочка.  
  
2. (Необязательно) Задайте <xref:System.Windows.Forms.TextBoxBase.MaxLength%2A> свойство. Свойство определяет, сколько символов можно ввести в текстовом поле. При превышении максимальную длину, система выдает звукового сигнала, и текстовое поле не принимает любые дополнительные символы. Обратите внимание на то, что вы не можете это сделать, как максимальная длина пароля может быть использована злоумышленниками, пытающимися угадать пароль.  
  
     В следующем примере кода показано, как инициализировать текстовое поле, которое будет принимать строку длиной до 14 знаков и отображать звездочками вместо строки. `InitializeMyControl` Процедуры не выполняется автоматически; его необходимо вызывать.  
  
    > [!IMPORTANT]
    >  С помощью <xref:System.Windows.Forms.TextBox.PasswordChar%2A> для текстового поля может помочь убедиться, что другие люди не смогут определить пароль пользователя, наблюдая за его вводом. Такая мера предосторожности не влияет на сохранения или передачи пароля, может произойти из-за логики приложения. Поскольку введенный текст никоим образом не зашифрован, необходимо рассматривать его так же, как и другие конфиденциальные данные. Несмотря на то, что он не отображается таким образом, пароль по-прежнему обрабатывается как обычной текстовой строки (Если вы реализовали дополнительные меры безопасности).  
  
    ```vb  
    Private Sub InitializeMyControl()  
       ' Set to no text.  
       TextBox1.Text = ""  
       ' The password character is an asterisk.  
       TextBox1.PasswordChar = "*"  
       ' The control will allow no more than 14 characters.  
       TextBox1.MaxLength = 14  
    End Sub  
    ```  
  
    ```csharp  
    private void InitializeMyControl()  
    {  
       // Set to no text.  
       textBox1.Text = "";  
       // The password character is an asterisk.  
       textBox1.PasswordChar = '*';  
       // The control will allow no more than 14 characters.  
       textBox1.MaxLength = 14;  
    }  
    ```  
  
    ```cpp  
    private:  
       void InitializeMyControl()  
       {  
          // Set to no text.  
          textBox1->Text = "";  
          // The password character is an asterisk.  
          textBox1->PasswordChar = '*';  
          // The control will allow no more than 14 characters.  
          textBox1->MaxLength = 14;  
       }  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.TextBox>
- [Общие сведения об элементе управления TextBox](textbox-control-overview-windows-forms.md)
- [Практическое руководство. Управление положением курсора в элементе управления TextBox в Windows Forms](how-to-control-the-insertion-point-in-a-windows-forms-textbox-control.md)
- [Практическое руководство. Создание текстового поля только для чтения](how-to-create-a-read-only-text-box-windows-forms.md)
- [Практическое руководство. Добавление кавычек в строку](how-to-put-quotation-marks-in-a-string-windows-forms.md)
- [Практическое руководство. Выделение текста в элементе управления TextBox в Windows Forms](how-to-select-text-in-the-windows-forms-textbox-control.md)
- [Практическое руководство. Многострочные элементы управления TextBox в Windows Forms](how-to-view-multiple-lines-in-the-windows-forms-textbox-control.md)
- [Элемент управления TextBox](textbox-control-windows-forms.md)

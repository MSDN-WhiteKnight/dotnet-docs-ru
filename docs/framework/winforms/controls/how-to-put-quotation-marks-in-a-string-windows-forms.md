---
title: Практическое руководство. Добавление кавычек в строку (Windows Forms)
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- quotation marks
- TextBox control [Windows Forms], displaying quotation marks
- quotation marks [Windows Forms], adding to strings in text boxes
ms.assetid: 68bdc3f3-4177-4eab-99cd-cac17a82b515
ms.openlocfilehash: 14180f0326b38872f5d1b112c3d9a87022fb79e9
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59328066"
---
# <a name="how-to-put-quotation-marks-in-a-string-windows-forms"></a>Практическое руководство. Добавление кавычек в строку (Windows Forms)
Бывает, что в строку текста нужно вставить кавычки (" "). Пример:  
  
 Она сказала: "Ты этого заслуживаешь!"  
  
 Кроме того, можно также использовать <xref:Microsoft.VisualBasic.ControlChars.Quote> качестве константы.  
  
### <a name="to-place-quotation-marks-in-a-string-in-your-code"></a>Вставка кавычек в строку в коде  
  
1. В Visual Basic вставьте двойные кавычки в строку как внедренную кавычку. В визуальном элементе C# и [!INCLUDE[vcprvc](../../../../includes/vcprvc-md.md)], вставьте escape-последовательность \\«как внедренную кавычку. Например, для создания представленной выше строки используйте следующий код.  
  
    ```vb  
    Private Sub InsertQuote()  
       TextBox1.Text = "She said, ""You deserve a treat!"" "  
    End Sub  
    ```  
  
    ```csharp  
    private void InsertQuote(){  
       textBox1.Text = "She said, \"You deserve a treat!\" ";  
    }  
    ```  
  
    ```cpp  
    private:  
       void InsertQuote()  
       {  
          textBox1->Text = "She said, \"You deserve a treat!\" ";  
       }  
    ```  
  
     -или-  
  
2. Вставьте для получения кавычки символ ASCII или Юникод. В Visual Basic используйте символ ASCII (34). В визуальном элементе C#, используйте символ Юникод (\u0022).  
  
    ```vb  
    Private Sub InsertAscii()  
       TextBox1.Text = "She said, " & Chr(34) & "You deserve a treat!" & Chr(34)  
    End Sub  
    ```  
  
    ```csharp  
    private void InsertAscii(){  
       textBox1.Text = "She said, " + '\u0022' + "You deserve a treat!" + '\u0022';  
    }  
    ```  
  
    > [!NOTE]
    >  В данном примере использовать \u0022 нельзя, поскольку нельзя использовать универсальное имя символа, обозначающее символ в базовом наборе символов. В противном случае вы получите C3851. Дополнительные сведения см. в разделе [Ошибка компилятора C3851](/cpp/error-messages/compiler-errors-2/compiler-error-c3851).  
  
     -или-  
  
3. Также можно определить для символа константу и при необходимости использовать ее.  
  
    ```vb  
    Const quote As String = """"  
    TextBox1.Text = "She said, " & quote & "You deserve a treat!" & quote  
    ```  
  
    ```csharp  
    const string quote = "\"";  
    textBox1.Text = "She said, " + quote +  "You deserve a treat!"+ quote ;  
    ```  
  
    ```cpp  
    const String^ quote = "\"";  
    textBox1->Text = String::Concat("She said, ",  
       const_cast<String^>(quote), "You deserve a treat!",  
       const_cast<String^>(quote));  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.TextBox>
- <xref:Microsoft.VisualBasic.ControlChars.Quote>
- [Общие сведения об элементе управления TextBox](textbox-control-overview-windows-forms.md)
- [Практическое руководство. Управление положением курсора в элементе управления TextBox в Windows Forms](how-to-control-the-insertion-point-in-a-windows-forms-textbox-control.md)
- [Практическое руководство. Создание текстового поля для ввода пароля с помощью элемента управления TextBox в Windows Forms](how-to-create-a-password-text-box-with-the-windows-forms-textbox-control.md)
- [Практическое руководство. Создание текстового поля только для чтения](how-to-create-a-read-only-text-box-windows-forms.md)
- [Практическое руководство. Выделение текста в элементе управления TextBox в Windows Forms](how-to-select-text-in-the-windows-forms-textbox-control.md)
- [Практическое руководство. Многострочные элементы управления TextBox в Windows Forms](how-to-view-multiple-lines-in-the-windows-forms-textbox-control.md)
- [Элемент управления TextBox](textbox-control-windows-forms.md)

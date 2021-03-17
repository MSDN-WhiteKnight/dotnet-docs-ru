---
title: Практическое руководство. Разрешение операций перетаскивания для элемента управления RichTextBox в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- examples [Windows Forms], text boxes
- drag and drop [Windows Forms], richTextBox control
- text boxes [Windows Forms], drag-and-drop operations
- RichTextBox control [Windows Forms], drag-and-drop operations
ms.assetid: ca167d1c-2014-4cf0-96a0-20598470be3b
ms.openlocfilehash: 5c60fe411fcbf6257c8aaacf1f7400c11c150ddc
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59310282"
---
# <a name="how-to-enable-drag-and-drop-operations-with-the-windows-forms-richtextbox-control"></a>Практическое руководство. Разрешение операций перетаскивания для элемента управления RichTextBox в Windows Forms
Операции перетаскивания для элемента управления <xref:System.Windows.Forms.RichTextBox> Windows Forms выполняются путем обработки событий <xref:System.Windows.Forms.RichTextBox.DragEnter> и <xref:System.Windows.Forms.RichTextBox.DragDrop> . Таким образом, операции перетаскивания для элемента управления <xref:System.Windows.Forms.RichTextBox> являются очень простыми.  
  
### <a name="to-enable-drag-operations-in-a-richtextbox-control"></a>Включение операций перетаскивания в элементе управления RichTextBox  
  
1. Задайте для свойства <xref:System.Windows.Forms.RichTextBox.AllowDrop%2A> элемента управления <xref:System.Windows.Forms.RichTextBox> значение `true`.  
  
2. Напишите код в обработчике событий для события <xref:System.Windows.Forms.RichTextBox.DragEnter> . Используйте инструкцию `if` , чтобы проверить допустимость типа перетаскиваемых данных (в данном случае это текст). Свойство <xref:System.Windows.Forms.DragEventArgs.Effect%2A?displayProperty=nameWithType> может иметь одно из значений перечисления <xref:System.Windows.Forms.DragDropEffects> .  
  
    ```vb  
    Private Sub RichTextBox1_DragEnter(ByVal sender As Object, _   
       ByVal e As System.Windows.Forms.DragEventArgs) _   
       Handles RichTextBox1.DragEnter  
       If (e.Data.GetDataPresent(DataFormats.Text)) Then  
          e.Effect = DragDropEffects.Copy  
       Else  
          e.Effect = DragDropEffects.None  
       End If  
    End Sub  
    ```  
  
    ```csharp  
    private void richTextBox1_DragEnter(object sender,   
    System.Windows.Forms.DragEventArgs e)  
    {  
       if (e.Data.GetDataPresent(DataFormats.Text))   
          e.Effect = DragDropEffects.Copy;  
       else  
          e.Effect = DragDropEffects.None;  
    }  
    ```  
  
    ```cpp  
    private:  
       void richTextBox1_DragEnter(System::Object ^  sender,  
          System::Windows::Forms::DragEventArgs ^  e)  
       {  
          if (e->Data->GetDataPresent(DataFormats::Text))  
             e->Effect = DragDropEffects::Copy;  
          else  
             e->Effect = DragDropEffects::None;  
       }  
    ```  
  
     (Visual C# и [!INCLUDE[vcprvc](../../../../includes/vcprvc-md.md)]) поместите следующий код в конструктор формы для регистрации обработчика событий.  
  
    ```csharp  
    this.richTextBox1.DragEnter += new  
        System.Windows.Forms.DragEventHandler  
        (this.richTextBox1_DragEnter);  
    ```  
  
    ```cpp  
    this->richTextBox1->DragEnter += gcnew  
       System::Windows::Forms::DragEventHandler  
       (this, &Form1::richTextBox1_DragEnter);  
    ```  
  
3. Напишите код для обработки события <xref:System.Windows.Forms.RichTextBox.DragDrop> . Используйте метод <xref:System.Windows.Forms.DataObject.GetData%2A?displayProperty=nameWithType> для получения перетаскиваемых данных.  
  
     В примере ниже код задает перетаскиваемые данные в свойстве <xref:System.Windows.Forms.RichTextBox.Text%2A> элемента управления <xref:System.Windows.Forms.RichTextBox> . Если в элементе управления <xref:System.Windows.Forms.RichTextBox> уже существует текст, перетаскиваемый текст вставляется в точку вставки.  
  
    ```vb  
    Private Sub RichTextBox1_DragDrop(ByVal sender As Object, _   
       ByVal e As System.Windows.Forms.DragEventArgs) _   
       Handles RichTextBox1.DragDrop  
       Dim i As Int16   
       Dim s As String  
  
       ' Get start position to drop the text.  
       i = RichTextBox1.SelectionStart  
       s = RichTextBox1.Text.Substring(i)  
       RichTextBox1.Text = RichTextBox1.Text.Substring(0, i)  
  
       ' Drop the text on to the RichTextBox.  
       RichTextBox1.Text = RichTextBox1.Text + _  
          e.Data.GetData(DataFormats.Text).ToString()  
       RichTextBox1.Text = RichTextBox1.Text + s  
    End Sub  
    ```  
  
    ```csharp  
    private void richTextBox1_DragDrop(object sender,   
    System.Windows.Forms.DragEventArgs e)  
    {  
       int i;  
       String s;  
  
       // Get start position to drop the text.  
       i = richTextBox1.SelectionStart;  
       s = richTextBox1.Text.Substring(i);  
       richTextBox1.Text = richTextBox1.Text.Substring(0,i);  
  
       // Drop the text on to the RichTextBox.  
       richTextBox1.Text = richTextBox1.Text +   
          e.Data.GetData(DataFormats.Text).ToString();  
       richTextBox1.Text = richTextBox1.Text + s;  
    }  
    ```  
  
    ```cpp  
    private:  
       System::Void richTextBox1_DragDrop(System::Object ^  sender,  
          System::Windows::Forms::DragEventArgs ^  e)  
       {  
          int i;  
          String ^s;  
  
       // Get start position to drop the text.  
       i = richTextBox1->SelectionStart;  
       s = richTextBox1->Text->Substring(i);  
       richTextBox1->Text = richTextBox1->Text->Substring(0,i);  
  
       // Drop the text on to the RichTextBox.  
       String ^str = String::Concat(richTextBox1->Text, e->Data  
       ->GetData(DataFormats->Text)->ToString());   
       richTextBox1->Text = String::Concat(str, s);  
       }  
    ```  
  
     (Visual C# и [!INCLUDE[vcprvc](../../../../includes/vcprvc-md.md)]) поместите следующий код в конструктор формы для регистрации обработчика событий.  
  
    ```csharp  
    this.richTextBox1.DragDrop += new  
        System.Windows.Forms.DragEventHandler  
        (this.richTextBox1_DragDrop);  
    ```  
  
    ```cpp  
    this->richTextBox1->DragDrop += gcnew   
       System::Windows::Forms::DragEventHandler  
       (this, &Form1::richTextBox1_DragDrop);  
    ```  
  
### <a name="to-test-the-drag-and-drop-functionality-in-your-application"></a>Тестирование функциональности перетаскивания в приложении  
  
1. Сохраните приложение и выполните его сборку. Пока сборка выполняется, запустите WordPad.  
  
     WordPad — это текстовый редактор, установленный операционной системой Windows, который позволяет выполнять операции перетаскивания. Чтобы открыть его, нажмите кнопку **Пуск** , выберите пункт **Выполнить**, введите `WordPad` в текстовом поле диалогового окна **Выполнить** и затем нажмите кнопку **ОК**.  
  
2. После открытия WordPad введите в нем строку текста. С помощью мыши выделите этот текст и перетащите его в элемент управления <xref:System.Windows.Forms.RichTextBox> в вашем приложении Windows.  
  
     Обратите внимание, что когда вы переводите указатель мыши в элемент управления <xref:System.Windows.Forms.RichTextBox> (и, следовательно, инициируете событие <xref:System.Windows.Forms.RichTextBox.DragEnter> ), курсор изменяется, и можно вставить выделенный текст в элемент управления <xref:System.Windows.Forms.RichTextBox> .  
  
     После отпускания кнопки мыши выделенный текст удаляется (то есть инициируется событие <xref:System.Windows.Forms.RichTextBox.DragDrop> ) и вставляется в элемент управления <xref:System.Windows.Forms.RichTextBox> .  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.RichTextBox>
- [Практическое руководство. Выполнение операции перетаскивания между приложениями](../advanced/how-to-perform-drag-and-drop-operations-between-applications.md)
- [Элемент управления RichTextBox](richtextbox-control-windows-forms.md)
- [Элементы управления для использования в формах Windows Forms](controls-to-use-on-windows-forms.md)

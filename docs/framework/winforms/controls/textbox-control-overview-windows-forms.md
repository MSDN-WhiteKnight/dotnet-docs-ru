---
title: Общие сведения об элементе управления TextBox (Windows Forms)
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
f1_keywords:
- TextBox
helpviewer_keywords:
- TextBox control [Windows Forms], about TextBox controls
- text boxes [Windows Forms], adding
ms.assetid: d1a9c7f5-fa53-480a-a75c-158f8649ea2f
ms.openlocfilehash: a91b67df1071c79707bb20a68efb4d5e6f083ae0
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59162141"
---
# <a name="textbox-control-overview-windows-forms"></a>Общие сведения об элементе управления TextBox (Windows Forms)
Текстовые поля форм Windows Forms используются для получения входных данных от пользователя или для отображения текста. <xref:System.Windows.Forms.TextBox> Управления обычно используется для ввода и редактирования текста, несмотря на то, что его можно также сделать доступным только для чтения. Текстовые поля можно отобразить несколько строк, переноса текста по размеру элемента управления и добавлять основные элементы форматирования. <xref:System.Windows.Forms.TextBox> Элемент управления предоставляет в одном формате, введенные в элементе управления или отображать текст. Чтобы отобразить несколько типов форматированного текста, используйте <xref:System.Windows.Forms.RichTextBox> элемента управления. Дополнительные сведения см. в разделе [Обзор элемента управления RichTextBox](richtextbox-control-overview-windows-forms.md).  
  
## <a name="working-with-the-textbox-control"></a>Работа с элементом управления TextBox  
 Текст, отображаемый элементом управления, содержащийся в <xref:System.Windows.Forms.TextBox.Text%2A> свойство. По умолчанию можно ввести не более 2048 символов в текстовом поле. Если задать <xref:System.Windows.Forms.TextBox.Multiline%2A> свойства `true`, можно ввести текст до 32 КБ. <xref:System.Windows.Forms.TextBox.Text%2A> Свойство можно задать во время разработки в окне свойств во время выполнения в коде, или вводимыми пользователем во время выполнения. Текущее содержимое текстового поля могут быть получены во время выполнения путем чтения <xref:System.Windows.Forms.TextBox.Text%2A> свойство.  
  
 В следующем примере кода задает текст в элементе управления во время выполнения. `InitializeMyControl` Процедуры не выполняется автоматически; его необходимо вызывать.  
  
```vb  
Private Sub InitializeMyControl()  
   ' Put some text into the control first.  
   TextBox1.Text = "This is a TextBox control."  
End Sub  
```  
  
```csharp  
private void InitializeMyControl() {  
   // Put some text into the control first.  
   textBox1.Text = "This is a TextBox control.";  
}  
```  
  
```cpp  
private:  
   void InitializeMyControl()  
   {  
      // Put some text into the control first.  
      textBox1->Text = "This is a TextBox control.";  
   }  
```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.TextBox>
- [Практическое руководство. Управление положением курсора в элементе управления TextBox в Windows Forms](how-to-control-the-insertion-point-in-a-windows-forms-textbox-control.md)
- [Практическое руководство. Создание текстового поля для ввода пароля с помощью элемента управления TextBox в Windows Forms](how-to-create-a-password-text-box-with-the-windows-forms-textbox-control.md)
- [Практическое руководство. Создание текстового поля только для чтения](how-to-create-a-read-only-text-box-windows-forms.md)
- [Практическое руководство. Добавление кавычек в строку](how-to-put-quotation-marks-in-a-string-windows-forms.md)
- [Практическое руководство. Выделение текста в элементе управления TextBox в Windows Forms](how-to-select-text-in-the-windows-forms-textbox-control.md)
- [Практическое руководство. Многострочные элементы управления TextBox в Windows Forms](how-to-view-multiple-lines-in-the-windows-forms-textbox-control.md)
- [Элемент управления TextBox](textbox-control-windows-forms.md)

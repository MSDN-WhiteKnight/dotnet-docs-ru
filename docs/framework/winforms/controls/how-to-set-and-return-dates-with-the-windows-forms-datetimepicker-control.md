---
title: Практическое руководство. Отображение и ввод дат с помощью элемента управления DateTimePicker в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- dates [Windows Forms], setting in DateTimePicker
- DateTimePicker control [Windows Forms], setting and returning dates
- examples [Windows Forms], DateTimePicker control
ms.assetid: a8a48d68-e4b5-426e-9764-51230fc9acd2
ms.openlocfilehash: cc4f0bdf7355cda61e6cb95f5e0b18c4f83aa62b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59081545"
---
# <a name="how-to-set-and-return-dates-with-the-windows-forms-datetimepicker-control"></a>Практическое руководство. Отображение и ввод дат с помощью элемента управления DateTimePicker в Windows Forms
Текущая выбранная дата или время в элементе управления Windows Forms <xref:System.Windows.Forms.DateTimePicker> определяется свойством <xref:System.Windows.Forms.DateTimePicker.Value%2A>. Перед отображением элемента управления можно задать свойство <xref:System.Windows.Forms.DateTimePicker.Value%2A> (например, во время разработки или в виде событий <xref:System.Windows.Forms.Form.Load>) для определения даты, которая изначально будет выбрана в элементе управления. По умолчанию в свойстве <xref:System.Windows.Forms.DateTimePicker.Value%2A> элемента управления установлена текущая дата. Если свойство <xref:System.Windows.Forms.DateTimePicker.Value%2A> элемента управления изменяется в коде, элемент управления автоматически обновляется, отображая новое значение в форме.  
  
 Свойство <xref:System.Windows.Forms.DateTimePicker.Value%2A> возвращает структуру <xref:System.DateTime>, которая является его значением. Существует несколько свойств структуры <xref:System.DateTime>, возвращающих определенные сведения об отображаемой дате. Эти свойства можно использовать только для возврата значения; не используйте их для задания значения.  
  
-   Для значений даты свойства <xref:System.DateTime.Month%2A>, <xref:System.DateTime.Day%2A> и <xref:System.DateTime.Year%2A> возвращают целочисленные значения в единицах времени выбранной даты. Свойство <xref:System.DateTime.DayOfWeek%2A> возвращает значение, указывающее выбранный день недели (возможные значения указаны в перечислении <xref:System.DayOfWeek>).  
  
-   Для значений времени свойства <xref:System.DateTime.Hour%2A>, <xref:System.DateTime.Minute%2A>, <xref:System.DateTime.Second%2A> и <xref:System.DateTime.Millisecond%2A> возвращают целочисленные значения для единиц времени. Чтобы настроить элемент управления для отображения времени, см. в разделе [как: Отображение времени с помощью элемента управления DateTimePicker](how-to-display-time-with-the-datetimepicker-control.md).  
  
### <a name="to-set-the-date-and-time-value-of-the-control"></a>Указание значения даты и времени элемента управления  
  
-   Установите для свойства <xref:System.Windows.Forms.DateTimePicker.Value%2A> значение даты или времени.  
  
    ```vb  
    DateTimePicker1.Value = New DateTime(2001, 10, 20)  
    ```  
  
    ```csharp  
    dateTimePicker1.Value = new DateTime(2001, 10, 20);  
    ```  
  
    ```cpp  
    dateTimePicker1->Value = DateTime(2001, 10, 20);  
    ```  
  
### <a name="to-return-the-date-and-time-value"></a>Возврат значения даты и времени  
  
-   Вызовите свойство <xref:System.Windows.Forms.DateTimePicker.Text%2A> для возврата всего значения в формате элемента управления или вызовите соответствующий метод свойства <xref:System.Windows.Forms.DateTimePicker.Value%2A> для возврата части значения. Используйте <xref:System.Windows.Forms.DateTimePicker.ToString%2A> для преобразования данных в строку, которую можно вывести пользователю.  
  
    ```vb  
    MessageBox.Show("The selected value is ", DateTimePicker1.Text)  
    MessageBox.Show("The day of the week is ",   
       DateTimePicker1.Value.DayOfWeek.ToString)  
    MessageBox.Show("Millisecond is: ",   
       DateTimePicker1.Value.Millisecond.ToString)  
    ```  
  
    ```csharp  
    MessageBox.Show ("The selected value is " +   
       dateTimePicker1.Text);  
    MessageBox.Show ("The day of the week is " +   
       dateTimePicker1.Value.DayOfWeek.ToString());  
    MessageBox.Show("Millisecond is: " +   
       dateTimePicker1.Value.Millisecond.ToString());  
    ```  
  
    ```cpp  
    MessageBox::Show (String::Concat("The selected value is ",  
       dateTimePicker1->Text));  
    MessageBox::Show (String::Concat("The day of the week is ",  
       dateTimePicker1->Value.DayOfWeek.ToString()));  
    MessageBox::Show(String::Concat("Millisecond is: ",  
       dateTimePicker1->Value.Millisecond.ToString()));  
    ```  
  
## <a name="see-also"></a>См. также

- [Элемент управления DateTimePicker](datetimepicker-control-windows-forms.md)
- [Практическое руководство. Отображение даты в пользовательском формате с помощью элемента управления DateTimePicker в Windows Forms](display-a-date-in-a-custom-format-with-wf-datetimepicker-control.md)

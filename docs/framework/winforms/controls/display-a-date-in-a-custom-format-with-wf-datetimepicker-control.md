---
title: Практическое руководство. Отображение даты в пользовательском формате с помощью элемента управления DateTimePicker в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- DateTimePicker control [Windows Forms], display styles
- examples [Windows Forms], DateTimePicker control
- dates [Windows Forms], displaying in DateTimePicker control
ms.assetid: 39767691-2d2b-46b6-a663-b7901e581a6e
ms.openlocfilehash: 08d5a505229cd434dbf82e8ae4624bb418efd379
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59335944"
---
# <a name="how-to-display-a-date-in-a-custom-format-with-the-windows-forms-datetimepicker-control"></a>Практическое руководство. Отображение даты в пользовательском формате с помощью элемента управления DateTimePicker в Windows Forms
Windows Forms <xref:System.Windows.Forms.DateTimePicker> управления обеспечивает гибкость при форматировании отображение дат и времени в элементе управления. <xref:System.Windows.Forms.DateTimePicker.Format%2A> Свойство позволяет выбрать из предопределенных форматов, перечисленных в <xref:System.Windows.Forms.DateTimePickerFormat>. Если ни один из них не подходит для ваших целей, можно создать собственный стиль формата, используя символы форматирования, перечисленные в <xref:System.Windows.Forms.DateTimePicker.CustomFormat%2A>.  
  
### <a name="to-display-a-custom-format"></a>Для отображения в пользовательском формате  
  
1. Задайте для свойства <xref:System.Windows.Forms.DateTimePicker.Format%2A> значение `DateTimePickerFormat.Custom`.  
  
2. Задать <xref:System.Windows.Forms.DateTimePicker.CustomFormat%2A> свойства в строку формата.  
  
    ```vb  
    DateTimePicker1.Format = DateTimePickerFormat.Custom  
    ' Display the date as "Mon 27 Feb 2012".  
    DateTimePicker1.CustomFormat = "ddd dd MMM yyyy"  
    ```  
  
    ```csharp  
    dateTimePicker1.Format = DateTimePickerFormat.Custom;  
    // Display the date as "Mon 27 Feb 2012".  
    dateTimePicker1.CustomFormat = "ddd dd MMM yyyy";  
    ```  
  
    ```cpp  
    dateTimePicker1->Format = DateTimePickerFormat::Custom;  
    // Display the date as "Mon 27 Feb 2012".  
    dateTimePicker1->CustomFormat = "ddd dd MMM yyyy";  
    ```  
  
### <a name="to-add-text-to-the-formatted-value"></a>Добавление текста на отформатированное значение  
  
1. Использовать одинарные кавычки для заключения в них любой символ, который не является символ форматирования, такие как «M» или разделителями, например «:». Например, строка формата отображает текущую дату в формате «сегодня является: 05:30:31 марта пятница 02, 2012" английского языка (США).  
  
    ```vb  
    DateTimePicker1.CustomFormat = "'Today is:' hh:mm:ss dddd MMMM dd, yyyy"  
    ```  
  
    ```csharp  
    dateTimePicker1.CustomFormat = "'Today is:' hh:mm:ss dddd MMMM dd, yyyy";  
    ```  
  
    ```cpp  
    dateTimePicker1->CustomFormat =  
       "'Today is:' hh:mm:ss dddd MMMM dd, yyyy";  
    ```  
  
     В зависимости от языка и региональных параметров, можно изменить любые символы, не заключаются в одинарные кавычки. Например, строка формата отображает текущую дату в формате «сегодня является: 05:30:31 марта пятница 02, 2012" английского языка (США). Обратите внимание на то, что первое двоеточие заключено в одинарные кавычки, поскольку он не используется в разделителя, как в «чч: мм:». В другой язык и региональные параметры, формат может отображаться как «сегодня является: 05.30.31 пятница март 02, 2012".  
  
## <a name="see-also"></a>См. также

- [Элемент управления DateTimePicker](datetimepicker-control-windows-forms.md)
- [Практическое руководство. Отображение и ввод дат с помощью элемента управления DateTimePicker в Windows Forms](how-to-set-and-return-dates-with-the-windows-forms-datetimepicker-control.md)

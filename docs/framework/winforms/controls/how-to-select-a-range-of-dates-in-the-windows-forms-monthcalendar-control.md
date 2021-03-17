---
title: Практическое руководство. Выбор диапазона дат в элементе управления MonthCalendar в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- dates [Windows Forms], selecting range in calendar controls
- examples [Windows Forms], calendar controls
- calendars [Windows Forms], selecting date range
- MonthCalendar control [Windows Forms], selecting date range
ms.assetid: 95d9ab95-b0f8-4c19-9f63-b5cd4593a5d0
ms.openlocfilehash: 82d0499cb40f79a3110b8432fbee66774bcc14a7
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59332239"
---
# <a name="how-to-select-a-range-of-dates-in-the-windows-forms-monthcalendar-control"></a>Практическое руководство. Выбор диапазона дат в элементе управления MonthCalendar в Windows Forms
Важной особенностью Windows Forms <xref:System.Windows.Forms.MonthCalendar> элемент управления является то, что пользователь может выбрать диапазон дат. Эта функция является улучшением функции выбора дат элемента <xref:System.Windows.Forms.DateTimePicker> элемента управления, который позволяет пользователю выбрать значение одной даты и времени. Можно задать диапазон дат или получить диапазон выбора пользователем с помощью свойств объекта <xref:System.Windows.Forms.MonthCalendar> элемента управления. В следующем примере кода показано, как задать диапазон выбора.  
  
### <a name="to-select-a-range-of-dates"></a>Чтобы выбрать диапазон дат  
  
1. Создание <xref:System.DateTime> объектов, представляющих начальную и конечную даты в диапазоне.  
  
    ```vb  
    Dim projectStart As Date = New DateTime(2001, 2, 13)  
    Dim projectEnd As Date = New DateTime(2001, 2, 28)  
    ```  
  
    ```csharp  
    DateTime projectStart = new DateTime(2001, 2, 13);  
    DateTime projectEnd = new DateTime(2001, 2, 28);  
    ```  
  
    ```cpp  
    DateTime projectStart = DateTime(2001, 2, 13);  
    DateTime projectEnd = DateTime(2001, 2, 28);  
    ```  
  
2. Задайте свойство <xref:System.Windows.Forms.MonthCalendar.SelectionRange%2A>.  
  
    ```vb  
    MonthCalendar1.SelectionRange = New SelectionRange(projectStart, projectEnd)  
    ```  
  
    ```csharp  
    monthCalendar1.SelectionRange = new SelectionRange(projectStart, projectEnd);  
    ```  
  
    ```cpp  
    monthCalendar1->SelectionRange = gcnew  
       SelectionRange(projectStart, projectEnd);  
    ```  
  
     – или –  
  
     Задайте свойства <xref:System.Windows.Forms.MonthCalendar.SelectionStart%2A> и <xref:System.Windows.Forms.MonthCalendar.SelectionEnd%2A>.  
  
    ```vb  
    MonthCalendar1.SelectionStart = projectStart  
    MonthCalendar1.SelectionEnd = projectEnd  
    ```  
  
    ```csharp  
    monthCalendar1.SelectionStart = projectStart;  
    monthCalendar1.SelectionEnd = projectEnd;  
    ```  
  
    ```cpp  
    monthCalendar1->SelectionStart = projectStart;  
    monthCalendar1->SelectionEnd = projectEnd;  
    ```  
  
## <a name="see-also"></a>См. также

- [Элемент управления MonthCalendar](monthcalendar-control-windows-forms.md)
- [Практическое руководство. Изменение внешнего вида элемента управления MonthCalendar в Windows Forms](how-to-change-monthcalendar-control-appearance.md)
- [Практическое руководство. Отображение определенных дней полужирным шрифтом в элементе управления MonthCalendar в Windows Forms](display-specific-days-in-bold-with-wf-monthcalendar-control.md)
- [Практическое руководство. Отображение нескольких месяцев в элементе управления MonthCalendar в Windows Forms](display-more-than-one-month-wf-monthcalendar-control.md)

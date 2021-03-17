---
title: Общие сведения об элементе управления MonthCalendar (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- MonthCalendar
helpviewer_keywords:
- calendars [Windows Forms], Windows Forms controls
- calendar controls [Windows Forms], Windows Forms
- MonthCalendar control [Windows Forms], setting the first day of the week
ms.assetid: 788c5325-b721-44ec-95bf-9b680ba0f6a2
ms.openlocfilehash: 8928a78735392920d893661c70554bd35eba2886
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59106240"
---
# <a name="monthcalendar-control-overview-windows-forms"></a>Общие сведения об элементе управления MonthCalendar (Windows Forms)
Windows Forms <xref:System.Windows.Forms.MonthCalendar> управления предоставляет интуитивно понятный графический интерфейс для пользователей, для просмотра и задания сведений о дате. Отображает календарь: сетку, содержащую пронумерованные дни месяца, разбитые на столбцы по дням недели, с помощью выбранного диапазона дат. С помощью кнопок со стрелками с обеих сторон от заголовка месяца можно выбрать другой месяц. В отличие от аналогичного <xref:System.Windows.Forms.DateTimePicker> элемента управления, можно выбрать несколько дат с этим элементом управления. Дополнительные сведения о <xref:System.Windows.Forms.DateTimePicker> управления, см. в разделе [элемента управления DateTimePicker](datetimepicker-control-windows-forms.md).  
  
## <a name="configuring-the-monthcalendar-control"></a>Настройка элемента управления MonthCalendar  
 <xref:System.Windows.Forms.MonthCalendar> Очень гибок в конфигурировании внешнего вида элемента управления. По умолчанию сегодняшняя дата отображается как обведены и также отмечается в нижней части сетки. Эту функцию можно изменить, задав <xref:System.Windows.Forms.MonthCalendar.ShowToday%2A> и <xref:System.Windows.Forms.MonthCalendar.ShowTodayCircle%2A> свойства `false`. Можно также добавить номера недель к календарю, присвоив <xref:System.Windows.Forms.MonthCalendar.ShowWeekNumbers%2A> свойства `true`. Установив <xref:System.Windows.Forms.MonthCalendar.CalendarDimensions%2A> свойство, может быть несколько, отображаемых по горизонтали и вертикали месяцев. По умолчанию отображается воскресенье в качестве первого дня недели, но может быть назначен любой день с помощью <xref:System.Windows.Forms.MonthCalendar.FirstDayOfWeek%2A> свойство.  
  
 Можно также задать для отображения в определенных дат полужирным единовременно, ежегодно или ежемесячно, путем добавления <xref:System.DateTime> объектов <xref:System.Windows.Forms.MonthCalendar.BoldedDates%2A>, <xref:System.Windows.Forms.MonthCalendar.AnnuallyBoldedDates%2A>, и <xref:System.Windows.Forms.MonthCalendar.MonthlyBoldedDates%2A> свойства. Дополнительные сведения см. в разделе [Как Отображение определенных дней полужирным шрифтом с Windows Forms в элементе управления MonthCalendar](display-specific-days-in-bold-with-wf-monthcalendar-control.md).  
  
 Ключевое свойство <xref:System.Windows.Forms.MonthCalendar> элемент управления является <xref:System.Windows.Forms.MonthCalendar.SelectionRange%2A>, диапазон дат в элементе управления. <xref:System.Windows.Forms.MonthCalendar.SelectionRange%2A> Значение не может превышать максимальное число дней, которые могут быть выбраны, установите в <xref:System.Windows.Forms.MonthCalendar.MaxSelectionCount%2A> свойство. Первой и последней даты, пользователь может выбрать определяются <xref:System.Windows.Forms.MonthCalendar.MaxDate%2A> и <xref:System.Windows.Forms.MonthCalendar.MinDate%2A> свойства.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.MonthCalendar>
- [Элемент управления MonthCalendar](monthcalendar-control-windows-forms.md)

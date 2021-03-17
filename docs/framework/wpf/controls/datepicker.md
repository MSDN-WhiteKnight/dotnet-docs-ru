---
title: DatePicker
ms.date: 03/30/2017
helpviewer_keywords:
- controls [WPF], DatePicker
- DatePicker control [WPF]
ms.assetid: 619765c8-8d25-4315-aec2-79aea08fed9f
ms.openlocfilehash: 555bf31b27ba233ffa54438077984b02b5e3084a
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59161346"
---
# <a name="datepicker"></a>DatePicker
<xref:System.Windows.Controls.DatePicker> Управления позволяет пользователю выбрать дату, либо путем ввода его в текстовое поле или с помощью раскрывающегося списка <xref:System.Windows.Controls.Calendar> элемента управления.  
  
 На следующем рисунке показано <xref:System.Windows.Controls.DatePicker>.  
  
 ![Элемент управления DatePicker](./media/ndp-datepicker.png "NDP_DatePicker")  
Элемент управления DatePicker  
  
 Многие из <xref:System.Windows.Controls.DatePicker> свойства элемента управления, для управления его встроенным <xref:System.Windows.Controls.Calendar>и функция идентична эквивалентное свойство в <xref:System.Windows.Controls.Calendar>. В частности <xref:System.Windows.Controls.DatePicker.IsTodayHighlighted%2A?displayProperty=nameWithType>, <xref:System.Windows.Controls.DatePicker.FirstDayOfWeek%2A?displayProperty=nameWithType>, <xref:System.Windows.Controls.DatePicker.BlackoutDates%2A?displayProperty=nameWithType>, <xref:System.Windows.Controls.DatePicker.DisplayDateStart%2A?displayProperty=nameWithType>, <xref:System.Windows.Controls.DatePicker.DisplayDateEnd%2A?displayProperty=nameWithType>, <xref:System.Windows.Controls.DatePicker.DisplayDate%2A?displayProperty=nameWithType>, и <xref:System.Windows.Controls.DatePicker.SelectedDate%2A?displayProperty=nameWithType> свойства работать идентично их <xref:System.Windows.Controls.Calendar> аналоги. Дополнительные сведения см. в разделе <xref:System.Windows.Controls.Calendar>.  
  
 Пользователи могут ввести дату непосредственно в текстовое поле, задающее <xref:System.Windows.Controls.DatePicker.Text%2A> свойство. Если <xref:System.Windows.Controls.DatePicker> невозможно преобразовать введенную строку в допустимую дату, <xref:System.Windows.Controls.DatePicker.DateValidationError> событие будет вызываться. По умолчанию, это вызывает исключение, но обработчик событий для <xref:System.Windows.Controls.DatePicker.DateValidationError> можно задать <xref:System.Windows.Controls.DatePickerDateValidationErrorEventArgs.ThrowException%2A> свойства `false` и предотвратить возникновение исключения.  
  
## <a name="see-also"></a>См. также

- [Элементы управления](index.md)
- [Стилизация и использование шаблонов](styling-and-templating.md)

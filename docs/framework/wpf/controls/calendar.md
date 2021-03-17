---
title: Календарь
ms.date: 03/30/2017
helpviewer_keywords:
- controls [WPF], Calendar
- Calendar control [WPF]
ms.assetid: ee844e4a-eefe-48e2-bd0d-1d82cc5e960b
ms.openlocfilehash: 9a64c6cd6fc1cc53383f2617f7a7a78959e87c4e
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59124791"
---
# <a name="calendar"></a>Календарь
Календарь позволяет пользователю выбрать дату с помощью визуального отображения календаря.  
  
 Объект <xref:System.Windows.Controls.Calendar> элемент управления может использоваться сама по себе или в составе раскрывающегося списка <xref:System.Windows.Controls.DatePicker> элемента управления. Дополнительные сведения см. в разделе <xref:System.Windows.Controls.DatePicker>.  
  
 На следующем рисунке показаны два <xref:System.Windows.Controls.Calendar> элементы управления, одна с выбранными и затемненными датами и без.  
  
 ![Элементы управления календаря](./media/ndp-calendarcontrols.png "NDP_CalendarControls")  
Элементы управления календаря  
  
 Следующая таблица содержит сведения о задачах, которые обычно связаны с <xref:System.Windows.Controls.Calendar>.  
  
|Задача|Реализация|  
|----------|--------------------|  
|Укажите даты, не могут быть выбраны.|Используйте свойство <xref:System.Windows.Controls.Calendar.BlackoutDates%2A>.|  
|У <xref:System.Windows.Controls.Calendar> отображения месяц, год или десятилетие.|Задайте <xref:System.Windows.Controls.Calendar.DisplayMode%2A> свойство месяц, год или десятилетие.|  
|Укажите, является ли пользователь может выбрать дату, диапазон дат или несколько диапазонов дат.|Используйте <xref:System.Windows.Controls.Calendar.SelectionMode%2A>.|  
|Укажите диапазон дат, <xref:System.Windows.Controls.Calendar> отображает.|Используйте <xref:System.Windows.Controls.Calendar.DisplayDateStart%2A> и <xref:System.Windows.Controls.Calendar.DisplayDateEnd%2A> свойства.|  
|Укажите, выделяется ли текущая дата.|Используйте свойство <xref:System.Windows.Controls.Calendar.IsTodayHighlighted%2A>. По умолчанию <xref:System.Windows.Controls.Calendar.IsTodayHighlighted%2A> является `true`.|  
|Изменить размер <xref:System.Windows.Controls.Calendar>.|Используйте <xref:System.Windows.Controls.Viewbox> или задать <xref:System.Windows.FrameworkElement.LayoutTransform%2A> свойства <xref:System.Windows.Media.ScaleTransform>. Обратите внимание, что если задать <xref:System.Windows.FrameworkElement.Width%2A> и <xref:System.Windows.FrameworkElement.Height%2A> свойства <xref:System.Windows.Controls.Calendar>, фактический календарь не изменять свой размер.|  
  
 <xref:System.Windows.Controls.Calendar> Элемент управления предоставляет основные возможности перемещения с помощью мыши или клавиатуры. В следующей таблице перечислены с помощью клавиатуры.  
  
|Сочетание клавиш|<xref:System.Windows.Controls.Calendar.DisplayMode%2A>|Действие|  
|---------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------|------------|  
|СТРЕЛКА|<xref:System.Windows.Controls.CalendarMode.Month>|Изменения <xref:System.Windows.Controls.Calendar.SelectedDate%2A> свойство Если <xref:System.Windows.Controls.Calendar.SelectionMode%2A> не задано значение <xref:System.Windows.Controls.CalendarSelectionMode.None>.|  
|СТРЕЛКА|<xref:System.Windows.Controls.CalendarMode.Year>|Изменяет значение месяца для <xref:System.Windows.Controls.Calendar.DisplayDate%2A> свойство. Обратите внимание, что <xref:System.Windows.Controls.Calendar.SelectedDate%2A> остается неизменным.|  
|СТРЕЛКА|<xref:System.Windows.Controls.CalendarMode.Decade>|Изменяет значение года для <xref:System.Windows.Controls.Calendar.DisplayDate%2A>. Обратите внимание, что <xref:System.Windows.Controls.Calendar.SelectedDate%2A> остается неизменным.|  
|SHIFT + СТРЕЛКА|<xref:System.Windows.Controls.CalendarMode.Month>|Если <xref:System.Windows.Controls.Calendar.SelectionMode%2A> равно <xref:System.Windows.Controls.CalendarSelectionMode.SingleDate> или <xref:System.Windows.Controls.CalendarSelectionMode.None>, расширяет спектр выбранных дат.|  
|ГЛАВНАЯ|<xref:System.Windows.Controls.CalendarMode.Month>|Изменения <xref:System.Windows.Controls.Calendar.SelectedDate%2A> первый день текущего месяца.|  
|ГЛАВНАЯ|<xref:System.Windows.Controls.CalendarMode.Year>|Изменяет значение месяца для <xref:System.Windows.Controls.Calendar.DisplayDate%2A> к первому месяцу года. <xref:System.Windows.Controls.Calendar.SelectedDate%2A> Остается неизменным.|  
|ГЛАВНАЯ|<xref:System.Windows.Controls.CalendarMode.Decade>|Изменяет значение года для <xref:System.Windows.Controls.Calendar.DisplayDate%2A> на первый год десятилетия. <xref:System.Windows.Controls.Calendar.SelectedDate%2A> Остается неизменным.|  
|END|<xref:System.Windows.Controls.CalendarMode.Month>|Изменения <xref:System.Windows.Controls.Calendar.SelectedDate%2A> до последнего дня текущего месяца.|  
|END|<xref:System.Windows.Controls.CalendarMode.Year>|Изменяет значение месяца для <xref:System.Windows.Controls.Calendar.DisplayDate%2A> последний месяц года. <xref:System.Windows.Controls.Calendar.SelectedDate%2A> Остается неизменным.|  
|END|<xref:System.Windows.Controls.CalendarMode.Decade>|Изменяет значение года для <xref:System.Windows.Controls.Calendar.DisplayDate%2A> за прошлый год десятилетия. <xref:System.Windows.Controls.Calendar.SelectedDate%2A> Остается неизменным.|  
|CTRL + СТРЕЛКА ВВЕРХ|Любой|Переходит к следующему большего размера <xref:System.Windows.Controls.Calendar.DisplayMode%2A>. Если <xref:System.Windows.Controls.Calendar.DisplayMode%2A> уже <xref:System.Windows.Controls.CalendarMode.Decade>, никаких действий.|  
|CTRL+СТРЕЛКА ВНИЗ|Любой|Переходит к следующему меньшего размера <xref:System.Windows.Controls.Calendar.DisplayMode%2A>. Если <xref:System.Windows.Controls.Calendar.DisplayMode%2A> уже <xref:System.Windows.Controls.CalendarMode.Month>, никаких действий.|  
|ПРОБЕЛ или ввод|<xref:System.Windows.Controls.CalendarMode.Year> или <xref:System.Windows.Controls.CalendarMode.Decade>|Коммутаторы <xref:System.Windows.Controls.Calendar.DisplayMode%2A> для <xref:System.Windows.Controls.CalendarMode.Month> или <xref:System.Windows.Controls.CalendarMode.Year> представленный элемент, имеющий фокус.|  
  
## <a name="see-also"></a>См. также

- [Элементы управления](index.md)
- [Стилизация и использование шаблонов](styling-and-templating.md)

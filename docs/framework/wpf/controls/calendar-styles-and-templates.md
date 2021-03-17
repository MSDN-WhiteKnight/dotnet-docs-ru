---
title: Стили и шаблоны элемента Calendar
ms.date: 03/30/2017
helpviewer_keywords:
- styles [WPF], Calendar
- templates [WPF], Calendar
- states [WPF], Calendar
- parts [WPF], Calendar
- Calendar [WPF], styles and templates
- ControlTemplate [WPF], Calendar
ms.assetid: f4fcf046-7a8f-41b8-b5a8-534b64e0345c
ms.openlocfilehash: 18bef548b11f1a680c1361027b86f6952bedaad0
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59227126"
---
# <a name="calendar-styles-and-templates"></a>Стили и шаблоны элемента Calendar
В этом разделе описываются стили и шаблоны для <xref:System.Windows.Controls.Calendar> элемента управления. Вы можете изменить значение по умолчанию <xref:System.Windows.Controls.ControlTemplate> предоставить уникальный внешний вид элемента управления. Подробнее см. в разделе [Настройка внешнего вида существующего элемента управления путем создания объекта ControlTemplate](customizing-the-appearance-of-an-existing-control.md).  
  
## <a name="calendar-parts"></a>Элементы календаря  
 В следующей таблице перечислены именованные части <xref:System.Windows.Controls.Calendar> элемента управления.  
  
|Отделение|Тип|Описание|  
|-|-|-|  
|PART_CalendarItem|<xref:System.Windows.Controls.Primitives.CalendarItem>|Текущий отображаемый месяц или год в <xref:System.Windows.Controls.Calendar>.|  
|PART_Root|<xref:System.Windows.Controls.Panel>|Панель, содержащую <xref:System.Windows.Controls.Primitives.CalendarItem>.|  
  
## <a name="calendar-states"></a>Состояния календаря  
 В следующей таблице перечислены визуальные состояния <xref:System.Windows.Controls.Calendar> элемента управления.  
  
|Имя VisualState|Имя VisualStateGroup|Описание|  
|----------------------|---------------------------|-----------------|  
|Valid|ValidationStates|Элемент управления использует <xref:System.Windows.Controls.Validation> класс и <xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> присоединенное свойство `false`.|  
|InvalidFocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления имеет фокус.|  
|InvalidUnfocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления не имеет фокуса.|  
  
## <a name="calendaritem-parts"></a>CalendarItem частей  
 В следующей таблице перечислены именованные части <xref:System.Windows.Controls.Primitives.CalendarItem> элемента управления.  
  
|Отделение|Тип|Описание|  
|-|-|-|  
|PART_Root|<xref:System.Windows.FrameworkElement>|Корневой элемент управления.|  
|PART_PreviousButton|<xref:System.Windows.Controls.Button>|Кнопка, которая отображает предыдущую страницу календаря, при щелчке.|  
|PART_NextButton|<xref:System.Windows.Controls.Button>|Кнопка, которая отображает следующую страницу календаря, при щелчке.|  
|PART_HeaderButton|<xref:System.Windows.Controls.Button>|Кнопка, которая позволяет переключаться между режим месяц, год режим и режим десятилетия.|  
|PART_MonthView|<xref:System.Windows.Controls.Grid>|Размещает содержимое в режиме «month».|  
|PART_YearView|<xref:System.Windows.Controls.Grid>|Размещает содержимое в режиме год или десятилетие.|  
|PART_DisabledVisual|<xref:System.Windows.FrameworkElement>|Перекрытие отключенном состоянии.|  
|DayTitleTemplate|<xref:System.Windows.DataTemplate>|<xref:System.Windows.DataTemplate> , Описывает визуальную структуру.|  
  
## <a name="calendaritem-states"></a>CalendarItem состояний  
 В следующей таблице перечислены визуальные состояния <xref:System.Windows.Controls.Primitives.CalendarItem> элемента управления.  
  
|Имя VisualState|Имя VisualStateGroup|Описание|  
|-|-|-|  
|Состояние норм.|CommonStates|Состояние по умолчанию.|  
|Отключенное состояние|CommonStates|Состояние календаря при <xref:System.Windows.UIElement.IsEnabled%2A> свойство `false`.|  
|Valid|ValidationStates|Элемент управления использует <xref:System.Windows.Controls.Validation> класс и <xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> присоединенное свойство `false`.|  
|InvalidFocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления имеет фокус.|  
|InvalidUnfocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления не имеет фокуса.|  
|Valid|ValidationStates|Элемент управления использует <xref:System.Windows.Controls.Validation> класс и <xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> присоединенное свойство `false`.|  
|InvalidFocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления имеет фокус.|  
|InvalidUnfocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления не имеет фокуса.|  
  
## <a name="calendardaybutton-parts"></a>CalendarDayButton частей  
 <xref:System.Windows.Controls.Primitives.CalendarDayButton> Управления не имеет частей с именами.  
  
## <a name="calendardaybutton-states"></a>CalendarDayButton состояний  
 В следующей таблице перечислены визуальные состояния <xref:System.Windows.Controls.Primitives.CalendarDayButton> элемента управления.  
  
|Имя VisualState|Имя VisualStateGroup|Описание|  
|-|-|-|  
|Норм.|CommonStates|Состояние по умолчанию.|  
|Отключено|CommonStates|<xref:System.Windows.Controls.Primitives.CalendarDayButton> Отключена.|  
|MouseOver|CommonStates|Указатель мыши наведен на <xref:System.Windows.Controls.Primitives.CalendarDayButton>.|  
|Нажато|CommonStates|<xref:System.Windows.Controls.Primitives.CalendarDayButton> Нажата.|  
|Selected|SelectionStates|Кнопка нажата.|  
|Unselected|SelectionStates|Кнопка не выбрана.|  
|CalendarButtonFocused|CalendarButtonFocusStates|Кнопка имеет фокус.|  
|CalendarButtonUnfocused|CalendarButtonFocusStates|Кнопка имеет фокус.|  
|Focused|FocusStates|Кнопка имеет фокус.|  
|Без фокуса ввода|FocusStates|Кнопка имеет фокус.|  
|Активная|ActiveStates|Кнопка активна.|  
|Неактивно|ActiveStates|Кнопка будет неактивна.|  
|RegularDay|DayStates|Кнопки не представляет <xref:System.DateTime.Today%2A?displayProperty=nameWithType>.|  
|Сегодня|DayStates|Кнопка представляет <xref:System.DateTime.Today%2A?displayProperty=nameWithType>.|  
|NormalDay|BlackoutDayStates|Кнопка представляет день, который может быть выбран.|  
|BlackoutDay|BlackoutDayStates|Кнопка представляет день, который не может быть выбран.|  
|Valid|ValidationStates|Элемент управления использует <xref:System.Windows.Controls.Validation> класс и <xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> присоединенное свойство `false`.|  
|InvalidFocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления имеет фокус.|  
|InvalidUnfocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления не имеет фокуса.|  
  
## <a name="calendarbutton-parts"></a>CalendarButton частей  
 <xref:System.Windows.Controls.Primitives.CalendarButton> Управления не имеет частей с именами.  
  
## <a name="calendarbutton-states"></a>CalendarButton состояний  
 В следующей таблице перечислены визуальные состояния <xref:System.Windows.Controls.Primitives.CalendarButton> элемента управления.  
  
|Имя VisualState|Имя VisualStateGroup|Описание|  
|-|-|-|  
|Норм.|CommonStates|Состояние по умолчанию.|  
|Отключено|CommonStates|<xref:System.Windows.Controls.Primitives.CalendarButton> Отключена.|  
|MouseOver|CommonStates|Указатель мыши наведен на <xref:System.Windows.Controls.Primitives.CalendarButton>.|  
|Нажато|CommonStates|<xref:System.Windows.Controls.Primitives.CalendarButton> Нажата.|  
|Selected|SelectionStates|Кнопка нажата.|  
|Unselected|SelectionStates|Кнопка не выбрана.|  
|CalendarButtonFocused|CalendarButtonFocusStates|Кнопка имеет фокус.|  
|CalendarButtonUnfocused|CalendarButtonFocusStates|Кнопка имеет фокус.|  
|Focused|FocusStates|Кнопка имеет фокус.|  
|Без фокуса ввода|FocusStates|Кнопка имеет фокус.|  
|Активная|ActiveStates|Кнопка активна.|  
|Неактивно|ActiveStates|Кнопка будет неактивна.|  
|Valid|ValidationStates|Элемент управления использует <xref:System.Windows.Controls.Validation> класс и <xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> присоединенное свойство `false`.|  
|InvalidFocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления имеет фокус.|  
|InvalidUnfocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления не имеет фокуса.|  
  
## <a name="calendar-controltemplate-example"></a>Пример шаблона элемента управления Calendar  
 В следующем примере показано определение <xref:System.Windows.Controls.ControlTemplate> для <xref:System.Windows.Controls.Calendar> управления и связанных типов.  
  
 [!code-xaml[ControlTemplateExamples#Calendar](~/samples/snippets/csharp/VS_Snippets_Wpf/ControlTemplateExamples/CS/resources/calendar.xaml#calendar)]  
  
 В предыдущем примере используется один или несколько из следующих ресурсов.  
  
 [!code-xaml[ControlTemplateExamples#Resources](~/samples/snippets/csharp/VS_Snippets_Wpf/ControlTemplateExamples/CS/resources/shared.xaml#resources)]  
  
 Полный пример см. в разделе [Пример задания стиля с помощью ControlTemplates](https://github.com/Microsoft/WPF-Samples/tree/master/Styles%20&%20Templates/IntroToStylingAndTemplating).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.FrameworkElement.Style%2A>
- <xref:System.Windows.Controls.ControlTemplate>
- [Стили и шаблоны элемента Control](control-styles-and-templates.md)
- [Настройка элементов управления](control-customization.md)
- [Стилизация и использование шаблонов](styling-and-templating.md)
- [Настройка внешнего вида существующего элемента управления путем создания объекта ControlTemplate](customizing-the-appearance-of-an-existing-control.md)

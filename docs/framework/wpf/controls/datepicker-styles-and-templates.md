---
title: Стили и шаблоны элемента DatePicker
ms.date: 03/30/2017
helpviewer_keywords:
- ControlTemplate [WPF], DatePicker
- DatePicker [WPF], styles and templates
- templates [WPF], DatePicker
- parts [WPF], DatePicker
- styles [WPF], DatePicker
- states [WPF], DatePicker
ms.assetid: c430a657-692f-44bd-a549-2341f92d6115
ms.openlocfilehash: 5c8e199dd7123e1490c8a836a62ffea158797eb8
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59206139"
---
# <a name="datepicker-styles-and-templates"></a>Стили и шаблоны элемента DatePicker
В этом разделе описываются стили и шаблоны для <xref:System.Windows.Controls.DatePicker> элемента управления. Вы можете изменить значение по умолчанию <xref:System.Windows.Controls.ControlTemplate> предоставить уникальный внешний вид элемента управления. Подробнее см. в разделе [Настройка внешнего вида существующего элемента управления путем создания объекта ControlTemplate](customizing-the-appearance-of-an-existing-control.md).  
  
## <a name="datepicker-parts"></a>DatePicker частей  
 В следующей таблице перечислены именованные части <xref:System.Windows.Controls.DatePicker> элемента управления.  
  
|Отделение|Тип|Описание|  
|-|-|-|  
|PART_Root|<xref:System.Windows.Controls.Grid>|Корневой элемент управления.|  
|PART_Button|<xref:System.Windows.Controls.Button>|Кнопка, которая открывает и закрывает <xref:System.Windows.Controls.Calendar>.|  
|PART_TextBox|<xref:System.Windows.Controls.Primitives.DatePickerTextBox>|Текстовое поле для ввода даты.|  
|PART_Popup|<xref:System.Windows.Controls.Primitives.Popup>|Контекстное меню для <xref:System.Windows.Controls.DatePicker> элемента управления.|  
  
## <a name="datepicker-states"></a>DatePicker состояний  
 В следующей таблице перечислены визуальные состояния <xref:System.Windows.Controls.DatePicker> элемента управления.  
  
|Имя VisualState|Имя VisualStateGroup|Описание|  
|-|-|-|  
|Норм.|CommonStates|Состояние по умолчанию.|  
|Отключено|CommonStates|<xref:System.Windows.Controls.DatePicker> Отключена.|  
|Valid|ValidationStates|Элемент управления использует <xref:System.Windows.Controls.Validation> класс и <xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> присоединенное свойство `false`.|  
|InvalidFocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления имеет фокус.|  
|InvalidUnfocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления не имеет фокуса.|  
  
## <a name="datepickertextbox-parts"></a>DatePickerTextBox частей  
 В следующей таблице перечислены именованные части <xref:System.Windows.Controls.Primitives.DatePickerTextBox> элемента управления.  
  
|Отделение|Тип|Описание|  
|-|-|-|  
|PART_Watermark|<xref:System.Windows.Controls.ContentControl>|Элемент, содержащий начальный текст в <xref:System.Windows.Controls.DatePicker>.|  
|PART_ContentElement|<xref:System.Windows.FrameworkElement>|Визуальный элемент, который может содержать <xref:System.Windows.FrameworkElement>. Текст <xref:System.Windows.Controls.TextBox> отображается в этом элементе.|  
  
## <a name="datepickertextbox-states"></a>DatePickerTextBox состояний  
 В следующей таблице перечислены визуальные состояния <xref:System.Windows.Controls.Primitives.DatePickerTextBox> элемента управления.  
  
|Имя VisualState|Имя VisualStateGroup|Описание|  
|-|-|-|  
|Норм.|CommonStates|Состояние по умолчанию.|  
|Отключено|CommonStates|<xref:System.Windows.Controls.Primitives.DatePickerTextBox> Отключена.|  
|MouseOver|CommonStates|Указатель мыши наведен на <xref:System.Windows.Controls.Primitives.DatePickerTextBox>.|  
|ReadOnly|CommonStates|Пользователю запрещено изменять текст в <xref:System.Windows.Controls.Primitives.DatePickerTextBox>.|  
|Focused|FocusStates|Элемент управления имеет фокус.|  
|Без фокуса ввода|FocusStates|Элемент управления не имеет фокуса.|  
|Добавлять водяные знаки|WatermarkStates|Элемент управления отображает начальный текст.  <xref:System.Windows.Controls.Primitives.DatePickerTextBox> Находится в состоянии, когда пользователь не ввел текст и не выбрал дату.|  
|Unwatermarked|WatermarkStates|Пользователь ввел текст в <xref:System.Windows.Controls.Primitives.DatePickerTextBox> или выбрал дату в <xref:System.Windows.Controls.DatePicker>.|  
|Valid|ValidationStates|Элемент управления использует <xref:System.Windows.Controls.Validation> класс и <xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> присоединенное свойство `false`.|  
|InvalidFocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления имеет фокус.|  
|InvalidUnfocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления не имеет фокуса.|  
  
## <a name="datepicker-controltemplate-example"></a>Пример шаблона элемента управления DatePicker  
 В следующем примере показано определение <xref:System.Windows.Controls.ControlTemplate> для <xref:System.Windows.Controls.DatePicker> элемента управления.  
  
 [!code-xaml[ControlTemplateExamples#DatePicker](~/samples/snippets/csharp/VS_Snippets_Wpf/ControlTemplateExamples/CS/resources/datepicker.xaml#datepicker)]  
  
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

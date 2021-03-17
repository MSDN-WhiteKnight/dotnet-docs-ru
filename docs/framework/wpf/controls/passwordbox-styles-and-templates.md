---
title: PasswordBox стили и шаблоны
ms.date: 03/30/2017
helpviewer_keywords:
- styles [WPF], PasswordBox
- templates [WPF], PasswordBox
- ControlTemplate [WPF], PasswordBox
- states [WPF], PasswordBox
- PasswordBox [WPF], styles and templates
- parts [WPF], PasswordBox
ms.assetid: deb52107-959f-4a60-b303-d21a0a933060
ms.openlocfilehash: 7783330dd56ec5b2759e783a6935761eb3587978
ms.sourcegitcommit: 5137208fa414d9ca3c58cdfd2155ac81bc89e917
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/06/2019
ms.locfileid: "57509533"
---
# <a name="passwordbox-styles-and-templates"></a>PasswordBox стили и шаблоны

В этом разделе описываются стили и шаблоны для <xref:System.Windows.Controls.PasswordBox> элемента управления. Вы можете изменить значение по умолчанию <xref:System.Windows.Controls.ControlTemplate> предоставить уникальный внешний вид элемента управления. Подробнее см. в разделе [Настройка внешнего вида существующего элемента управления путем создания объекта ControlTemplate](customizing-the-appearance-of-an-existing-control.md).

## <a name="passwordbox-parts"></a>Части PasswordBox

В следующей таблице перечислены именованные части <xref:System.Windows.Controls.PasswordBox> элемента управления.

|Отделение|Тип|Описание:|
|-|-|-|
|PART_ContentHost|<xref:System.Windows.FrameworkElement>|Визуальный элемент, который может содержать <xref:System.Windows.FrameworkElement>. Текст <xref:System.Windows.Controls.PasswordBox> отображается в этом элементе.|

## <a name="passwordbox-states"></a>Состояния PasswordBox

В следующей таблице перечислены визуальные состояния <xref:System.Windows.Controls.PasswordBox> элемента управления.

|Имя VisualState|Имя VisualStateGroup|Описание|
|-|-|-|
|Норм.|CommonStates|Состояние по умолчанию.|
|MouseOver|CommonStates|Указатель мыши расположен над элементом управления.|
|Отключено|CommonStates|Элемент управления отключен.|
|Focused|FocusStates|Элемент управления имеет фокус.|
|Без фокуса ввода|FocusStates|Элемент управления не имеет фокуса.|
|Valid|ValidationStates|Элемент управления использует <xref:System.Windows.Controls.Validation> класс и <xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> присоединенное свойство `false`.|
|InvalidFocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления имеет фокус.|
|InvalidUnfocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления не имеет фокуса.|

## <a name="passwordbox-controltemplate-example"></a>Пример шаблона элемента управления PasswordBox

В следующем примере показано определение <xref:System.Windows.Controls.ControlTemplate> для <xref:System.Windows.Controls.PasswordBox> элемента управления.

[!code-xaml[ControlTemplateExamples#PasswordBox](~/samples/snippets/csharp/VS_Snippets_Wpf/ControlTemplateExamples/CS/resources/textbox.xaml#passwordbox)]

В предыдущем примере используется один или несколько из следующих ресурсов.

[!code-xaml[ControlTemplateExamples#Resources](~/samples/snippets/csharp/VS_Snippets_Wpf/ControlTemplateExamples/CS/resources/shared.xaml#resources)]

Полный пример см. в разделе [Пример задания стиля с помощью ControlTemplates](https://github.com/Microsoft/WPF-Samples/tree/master/Styles%20&%20Templates/IntroToStylingAndTemplating).

## <a name="see-also"></a>См. также

- <xref:System.Windows.FrameworkElement.Style%2A>
- <xref:System.Windows.Controls.ControlTemplate>
- [Стили и шаблоны элемента управления](control-styles-and-templates.md)
- [Настройка элементов управления](control-customization.md)
- [Стилизация и использование шаблонов](styling-and-templating.md)
- [Настройка внешнего вида существующего элемента управления путем создания объекта ControlTemplate](customizing-the-appearance-of-an-existing-control.md)

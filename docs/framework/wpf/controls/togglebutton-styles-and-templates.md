---
title: Элемент управления ToggleButton стили и шаблоны
ms.date: 03/30/2017
helpviewer_keywords:
- states [WPF], ToggleButton
- ToggleButton [WPF], styles and templates
- ControlTemplate [WPF], ToggleButton
- styles [WPF], ToggleButton
- templates [WPF], ToggleButton
- parts [WPF], ToggleButton
ms.assetid: 54f23f30-4bcb-4f09-8ce4-376a13a255a1
ms.openlocfilehash: 46fd7d07c3904ee752ae3f467f65af4b0c031c84
ms.sourcegitcommit: 5137208fa414d9ca3c58cdfd2155ac81bc89e917
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/06/2019
ms.locfileid: "57509513"
---
# <a name="togglebutton-styles-and-templates"></a>Элемент управления ToggleButton стили и шаблоны

В этом разделе описываются стили и шаблоны для <xref:System.Windows.Controls.Primitives.ToggleButton> элемента управления. Вы можете изменить значение по умолчанию <xref:System.Windows.Controls.ControlTemplate> предоставить уникальный внешний вид элемента управления. Подробнее см. в разделе [Настройка внешнего вида существующего элемента управления путем создания объекта ControlTemplate](customizing-the-appearance-of-an-existing-control.md).

## <a name="togglebutton-parts"></a>Элемент управления ToggleButton частей

<xref:System.Windows.Controls.Primitives.ToggleButton> Управления не имеет частей с именами.

## <a name="togglebutton-states"></a>Элемент управления ToggleButton состояний

В следующей таблице перечислены визуальные состояния <xref:System.Windows.Controls.Primitives.ToggleButton> элемента управления.

|Имя VisualState|Имя VisualStateGroup|Описание:|
|-|-|-|
|Норм.|CommonStates|Состояние по умолчанию.|
|MouseOver|CommonStates|Указатель мыши расположен в элементе управления.|
|Нажато|CommonStates|Элемент управления нажат.|
|Отключено|CommonStates|Элемент управления отключен.|
|Focused|FocusStates|Элемент управления имеет фокус.|
|Без фокуса ввода|FocusStates|Элемент управления не имеет фокуса.|
|Помечено|CheckStates|Свойство <xref:System.Windows.Controls.Primitives.ToggleButton.IsChecked%2A> имеет значение `true`.|
|Unchecked|CheckStates|Свойство <xref:System.Windows.Controls.Primitives.ToggleButton.IsChecked%2A> имеет значение `false`.|
|Неопределенное|CheckStates|<xref:System.Windows.Controls.Primitives.ToggleButton.IsThreeState%2A> — `true`, и <xref:System.Windows.Controls.Primitives.ToggleButton.IsChecked%2A> является `null`.|
|Valid|ValidationStates|Элемент управления использует <xref:System.Windows.Controls.Validation> класс и <xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> присоединенное свойство `false`.|
|InvalidFocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления имеет фокус.|
|InvalidUnfocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления не имеет фокуса.|

> [!NOTE]
> Если не определен визуальное состояние не существует в шаблоне элемента управления, Unchecked визуальное состояние будет использоваться как визуальное состояние по умолчанию.

## <a name="togglebutton-controltemplate-example"></a>Пример шаблона элемента управления ToggleButton

В следующем примере показано определение <xref:System.Windows.Controls.ControlTemplate> для <xref:System.Windows.Controls.Primitives.ToggleButton> элемента управления.

[!code-xaml[ControlTemplateExamples#ToggleButton](~/samples/snippets/csharp/VS_Snippets_Wpf/ControlTemplateExamples/CS/resources/combobox.xaml#togglebutton)]

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

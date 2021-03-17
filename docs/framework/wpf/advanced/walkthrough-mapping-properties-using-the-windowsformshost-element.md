---
title: Пошаговое руководство. Сопоставление свойств с помощью элемента WindowsFormsHost
ms.date: 08/18/2018
dev_langs:
- csharp
- vb
helpviewer_keywords:
- mapping properties [WPF]
- WindowsFormsHost element property mapping [WPF]
ms.assetid: 74809167-bf8e-48b7-a2e7-b4ea08bc7d8c
ms.openlocfilehash: edd9d6f698ba27cacb5e9a5eecab43f58d47b8e1
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59296528"
---
# <a name="walkthrough-mapping-properties-using-the-windowsformshost-element"></a>Пошаговое руководство. Сопоставление свойств с помощью элемента WindowsFormsHost

В этом пошаговом руководстве показано, как использовать <xref:System.Windows.Forms.Integration.WindowsFormsHost.PropertyMap%2A> свойства для сопоставления [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] свойств с соответствующими свойствами вложенного [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элемента управления.

В данном пошаговом руководстве представлены следующие задачи.

-   Создание проекта.

-   Определение макета приложения.

-   Определение нового сопоставления свойства.

-   Удаление сопоставления свойства по умолчанию.

-   Замена сопоставления свойства по умолчанию.

-   Расширение сопоставления свойства по умолчанию.

Полный пример кода для задач, приведенных в этом пошаговом руководстве, см. в разделе [сопоставления свойств с помощью образец элемента WindowsFormsHost](https://go.microsoft.com/fwlink/?LinkID=160019).

Когда вы закончите, можно сопоставить [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] свойств с соответствующими свойствами вложенного [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элемента управления.

## <a name="prerequisites"></a>Предварительные требования

Ниже приведены компоненты, необходимые для выполнения данного пошагового руководства.

-   Visual Studio 2017

## <a name="create-and-set-up-the-project"></a>Создание и настройка проекта

1. Создание **приложение WPF** проект с именем `PropertyMappingWithWfhSample`.

2. В **обозревателе решений**, добавьте ссылку на сборку WindowsFormsIntegration с именем WindowsFormsIntegration.dll.

3. В **обозревателе решений**, добавьте ссылки на сборки System.Drawing и System.Windows.Forms.

## <a name="defining-the-application-layout"></a>Определение макета приложения

[!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]-Основе приложением <xref:System.Windows.Forms.Integration.WindowsFormsHost> для размещения элемента [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элемента управления.

### <a name="to-define-the-application-layout"></a>Определение макета приложения

1. Откройте файл Window1.xaml в [!INCLUDE[wpfdesigner_current_short](../../../../includes/wpfdesigner-current-short-md.md)].

2. Замените существующий код следующим кодом:

     [!code-xaml[PropertyMappingWithWfhSample#1](~/samples/snippets/csharp/VS_Snippets_Wpf/PropertyMappingWithWfhSample/CSharp/PropertyMappingWithWfh/Window1.xaml#1)]

3. Откройте файл Window1.xaml.cs в редакторе кода.

4. В верхней части файла импортируйте указанные ниже пространства имен.

     [!code-csharp[PropertyMappingWithWfhSample#20](~/samples/snippets/csharp/VS_Snippets_Wpf/PropertyMappingWithWfhSample/CSharp/PropertyMappingWithWfh/Window1.xaml.cs#20)]
     [!code-vb[PropertyMappingWithWfhSample#20](~/samples/snippets/visualbasic/VS_Snippets_Wpf/PropertyMappingWithWfhSample/VisualBasic/PropertyMappingWithWfh/Window1.xaml.vb#20)]

## <a name="defining-a-new-property-mapping"></a>Определение нового сопоставления свойства

<xref:System.Windows.Forms.Integration.WindowsFormsHost> Элемент предоставляет несколько стандартных сопоставления свойств. Добавить новое сопоставление свойства путем вызова <xref:System.Windows.Forms.Integration.PropertyMap.Add%2A> метод <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемента <xref:System.Windows.Forms.Integration.WindowsFormsHost.PropertyMap%2A>.

### <a name="to-define-a-new-property-mapping"></a>Определение нового сопоставления свойства

-   Скопируйте следующий код в определение `Window1` класса.

     [!code-csharp[PropertyMappingWithWfhSample#14](~/samples/snippets/csharp/VS_Snippets_Wpf/PropertyMappingWithWfhSample/CSharp/PropertyMappingWithWfh/Window1.xaml.cs#14)]
     [!code-vb[PropertyMappingWithWfhSample#14](~/samples/snippets/visualbasic/VS_Snippets_Wpf/PropertyMappingWithWfhSample/VisualBasic/PropertyMappingWithWfh/Window1.xaml.vb#14)]

     `AddClipMapping` Метод добавляет новое сопоставление для <xref:System.Windows.UIElement.Clip%2A> свойство.

     `OnClipChange` Метод преобразует <xref:System.Windows.UIElement.Clip%2A> свойства [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)]<xref:System.Windows.Forms.Control.Region%2A> свойство.

     `Window1_SizeChanged` Метод обрабатывает окна <xref:System.Windows.FrameworkElement.SizeChanged> событий и изменяет размер отсеченной области по размеру окна приложения.

## <a name="removing-a-default-property-mapping"></a>Удаление сопоставления свойства по умолчанию

Удаление сопоставления свойства по умолчанию путем вызова <xref:System.Windows.Forms.Integration.PropertyMap.Remove%2A> метод <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемента <xref:System.Windows.Forms.Integration.WindowsFormsHost.PropertyMap%2A>.

### <a name="to-remove-a-default-property-mapping"></a>Удаление сопоставления свойства по умолчанию

-   Скопируйте следующий код в определение `Window1` класса.

     [!code-csharp[PropertyMappingWithWfhSample#13](~/samples/snippets/csharp/VS_Snippets_Wpf/PropertyMappingWithWfhSample/CSharp/PropertyMappingWithWfh/Window1.xaml.cs#13)]
     [!code-vb[PropertyMappingWithWfhSample#13](~/samples/snippets/visualbasic/VS_Snippets_Wpf/PropertyMappingWithWfhSample/VisualBasic/PropertyMappingWithWfh/Window1.xaml.vb#13)]

     `RemoveCursorMapping` Метод удаляет сопоставление по умолчанию для <xref:System.Windows.FrameworkElement.Cursor%2A> свойство.

## <a name="replacing-a-default-property-mapping"></a>Замена сопоставления свойства по умолчанию

Замена сопоставления свойства по умолчанию, удалив сопоставление по умолчанию и вызывая метод <xref:System.Windows.Forms.Integration.PropertyMap.Add%2A> метод <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемента <xref:System.Windows.Forms.Integration.WindowsFormsHost.PropertyMap%2A>.

### <a name="to-replace-a-default-property-mapping"></a>Замена сопоставления свойства по умолчанию

-   Скопируйте следующий код в определение `Window1` класса.

     [!code-csharp[PropertyMappingWithWfhSample#12](~/samples/snippets/csharp/VS_Snippets_Wpf/PropertyMappingWithWfhSample/CSharp/PropertyMappingWithWfh/Window1.xaml.cs#12)]
     [!code-vb[PropertyMappingWithWfhSample#12](~/samples/snippets/visualbasic/VS_Snippets_Wpf/PropertyMappingWithWfhSample/VisualBasic/PropertyMappingWithWfh/Window1.xaml.vb#12)]

     `ReplaceFlowDirectionMapping` Метод заменяет сопоставление по умолчанию для <xref:System.Windows.FrameworkElement.FlowDirection%2A> свойство.

     `OnFlowDirectionChange` Метод преобразует <xref:System.Windows.FrameworkElement.FlowDirection%2A> свойства [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)]<xref:System.Windows.Forms.Control.RightToLeft%2A> свойство.

     `cb_CheckedChanged` Метод обрабатывает <xref:System.Windows.Forms.CheckBox.CheckedChanged> событий на <xref:System.Windows.Forms.CheckBox> элемента управления. Он назначает <xref:System.Windows.FrameworkElement.FlowDirection%2A> значение в зависимости от значения <xref:System.Windows.Forms.CheckBox.CheckState%2A> свойство

## <a name="extending-a-default-property-mapping"></a>Расширение сопоставления свойства по умолчанию

Вы можете использовать сопоставление свойства по умолчанию, а также расширить его с помощью собственного сопоставления.

### <a name="to-extend-a-default-property-mapping"></a>Расширение сопоставления свойства по умолчанию

-   Скопируйте следующий код в определение `Window1` класса.

     [!code-csharp[PropertyMappingWithWfhSample#15](~/samples/snippets/csharp/VS_Snippets_Wpf/PropertyMappingWithWfhSample/CSharp/PropertyMappingWithWfh/Window1.xaml.cs#15)]
     [!code-vb[PropertyMappingWithWfhSample#15](~/samples/snippets/visualbasic/VS_Snippets_Wpf/PropertyMappingWithWfhSample/VisualBasic/PropertyMappingWithWfh/Window1.xaml.vb#15)]

     `ExtendBackgroundMapping` Метод добавляет пользовательский преобразователь свойств для существующего <xref:System.Windows.Controls.Control.Background%2A> сопоставление свойств.

     `OnBackgroundChange` Метод присваивает определенное изображение для размещенного элемента управления <xref:System.Windows.Forms.Control.BackgroundImage%2A> свойство. `OnBackgroundChange` Метод вызывается после применения сопоставления свойства по умолчанию.

## <a name="initializing-your-property-mappings"></a>Инициализация сопоставлений свойств

Настройка сопоставлений свойств путем вызова ранее описанных методов в <xref:System.Windows.FrameworkElement.Loaded> обработчик событий.

### <a name="to-initialize-your-property-mappings"></a>Инициализация сопоставлений свойств

1. Скопируйте следующий код в определение `Window1` класса.

     [!code-csharp[PropertyMappingWithWfhSample#11](~/samples/snippets/csharp/VS_Snippets_Wpf/PropertyMappingWithWfhSample/CSharp/PropertyMappingWithWfh/Window1.xaml.cs#11)]
     [!code-vb[PropertyMappingWithWfhSample#11](~/samples/snippets/visualbasic/VS_Snippets_Wpf/PropertyMappingWithWfhSample/VisualBasic/PropertyMappingWithWfh/Window1.xaml.vb#11)]

     `WindowLoaded` Метод обрабатывает <xref:System.Windows.FrameworkElement.Loaded> событий и выполнения следующей инициализации.

    -   Создает [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)]<xref:System.Windows.Forms.CheckBox> элемента управления.

    -   Вызывает методы, ранее определенные в руководстве, для настройки сопоставлений свойств.

    -   Присваивает начальные значения сопоставленным свойствам.

2. Нажмите клавишу **F5**, чтобы выполнить сборку приложения и запустить его. Щелкните флажок, чтобы увидеть эффект <xref:System.Windows.FrameworkElement.FlowDirection%2A> сопоставления. При установке флажка меняется ориентация макета по горизонтали.

## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Integration.WindowsFormsHost.PropertyMap%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.Integration.ElementHost.PropertyMap%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.Integration.WindowsFormsHost>
- [Сопоставление свойств Windows Forms и WPF](windows-forms-and-wpf-property-mapping.md)
- [Проектирование XAML в Visual Studio](/visualstudio/designers/designing-xaml-in-visual-studio)
- [Пошаговое руководство. Размещение элементов управления Windows Forms в WPF](walkthrough-hosting-a-windows-forms-control-in-wpf.md)
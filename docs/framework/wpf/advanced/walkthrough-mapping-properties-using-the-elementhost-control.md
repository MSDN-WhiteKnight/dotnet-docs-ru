---
title: Пошаговое руководство. Сопоставление свойств с помощью элемента управления ElementHost
ms.date: 08/18/2018
dev_langs:
- csharp
- vb
helpviewer_keywords:
- mapping properties [WPF]
- ElementHost control [WPF], mapping properties
ms.assetid: bccd6e0d-2272-4924-9107-ff8ed58b88aa
ms.openlocfilehash: 360f19e558f97e1807b329ad18e429fa893bbf86
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59300922"
---
# <a name="walkthrough-mapping-properties-using-the-elementhost-control"></a>Пошаговое руководство. Сопоставление свойств с помощью элемента управления ElementHost

В этом пошаговом руководстве показано, как использовать <xref:System.Windows.Forms.Integration.ElementHost.PropertyMap%2A> свойства для сопоставления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] свойств с соответствующими свойствами вложенного WPF элемент.

В данном пошаговом руководстве представлены следующие задачи.

-   Создание проекта.

-   Определение нового сопоставления свойства.

-   Удаление сопоставления свойства по умолчанию.

-   Расширение сопоставления свойства по умолчанию.

Полный пример кода для задач, приведенных в этом пошаговом руководстве, см. в разделе [сопоставления свойств с помощью пример элемента управления ElementHost](https://go.microsoft.com/fwlink/?LinkID=160018).

Когда вы закончите, можно сопоставить [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] свойств с соответствующими WPF свойства элемента.

## <a name="prerequisites"></a>Предварительные требования

Ниже приведены компоненты, необходимые для выполнения данного пошагового руководства.

-   Visual Studio 2017

## <a name="creating-the-project"></a>Создание проекта

### <a name="to-create-the-project"></a>Создание проекта

1. Создание **приложения Windows Forms** проект с именем `PropertyMappingWithElementHost`.

2. В **обозревателе решений**, добавьте ссылки на следующие WPF сборок.

    -   PresentationCore

    -   PresentationFramework

    -   WindowsBase

    -   WindowsFormsIntegration

3. Скопируйте следующий код в верхнюю часть `Form1` файл кода.

     [!code-csharp[PropertyMappingWithElementHost#10](~/samples/snippets/csharp/VS_Snippets_Wpf/PropertyMappingWithElementHost/CSharp/PropertyMappingWithElementHost/Form1.cs#10)]
     

4. Откройте `Form1` в конструкторе Windows Forms. Дважды щелкните форму, чтобы добавить обработчик событий для <xref:System.Windows.Forms.Form.Load> событий.

5. Вернитесь к конструктору Windows Forms и добавьте обработчик событий для формы <xref:System.Windows.Forms.Control.Resize> событий. Дополнительные сведения см. в разделе [Как Создание обработчиков событий с помощью конструктора](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/zwwsdtbk(v=vs.100)).

6. Объявите <xref:System.Windows.Forms.Integration.ElementHost> в `Form1` класса.

     [!code-csharp[PropertyMappingWithElementHost#16](~/samples/snippets/csharp/VS_Snippets_Wpf/PropertyMappingWithElementHost/CSharp/PropertyMappingWithElementHost/Form1.cs#16)]
     

## <a name="defining-new-property-mappings"></a>Определение новых сопоставлений свойств

<xref:System.Windows.Forms.Integration.ElementHost> Элемент управления предоставляет несколько стандартных сопоставления свойств. Добавить новое сопоставление свойства путем вызова <xref:System.Windows.Forms.Integration.PropertyMap.Add%2A> метод <xref:System.Windows.Forms.Integration.ElementHost> элемента управления <xref:System.Windows.Forms.Integration.ElementHost.PropertyMap%2A>.

### <a name="to-define-new-property-mappings"></a>Для определения новых сопоставлений свойств

1. Скопируйте следующий код в определение `Form1` класса.

     [!code-csharp[PropertyMappingWithElementHost#12](~/samples/snippets/csharp/VS_Snippets_Wpf/PropertyMappingWithElementHost/CSharp/PropertyMappingWithElementHost/Form1.cs#12)]
     

     `AddMarginMapping` Метод добавляет новое сопоставление для <xref:System.Windows.Forms.Control.Margin%2A> свойство.

     `OnMarginChange` Метод преобразует <xref:System.Windows.Forms.Control.Margin%2A> свойства WPF <xref:System.Windows.FrameworkElement.Margin%2A> свойство.

2. Скопируйте следующий код в определение `Form1` класса.

     [!code-csharp[PropertyMappingWithElementHost#14](~/samples/snippets/csharp/VS_Snippets_Wpf/PropertyMappingWithElementHost/CSharp/PropertyMappingWithElementHost/Form1.cs#14)]
     

     `AddRegionMapping` Метод добавляет новое сопоставление для <xref:System.Windows.Forms.Control.Region%2A> свойство.

     `OnRegionChange` Метод преобразует <xref:System.Windows.Forms.Control.Region%2A> свойства WPF <xref:System.Windows.UIElement.Clip%2A> свойство.

     `Form1_Resize` Метод обрабатывает формы <xref:System.Windows.Forms.Control.Resize> событий и размеров области отсечения в соответствии с размещаемый элемент.

## <a name="removing-a-default-property-mapping"></a>Удаление сопоставления свойства по умолчанию

Удаление сопоставления свойства по умолчанию путем вызова <xref:System.Windows.Forms.Integration.PropertyMap.Remove%2A> метод <xref:System.Windows.Forms.Integration.ElementHost> элемента управления <xref:System.Windows.Forms.Integration.ElementHost.PropertyMap%2A>.

### <a name="to-remove-a-default-property-mapping"></a>Удаление сопоставления свойства по умолчанию

-   Скопируйте следующий код в определение `Form1` класса.

     [!code-csharp[PropertyMappingWithElementHost#13](~/samples/snippets/csharp/VS_Snippets_Wpf/PropertyMappingWithElementHost/CSharp/PropertyMappingWithElementHost/Form1.cs#13)]
     

     `RemoveCursorMapping` Метод удаляет сопоставление по умолчанию для <xref:System.Windows.Forms.Control.Cursor%2A> свойство.

## <a name="extending-a-default-property-mapping"></a>Расширение сопоставления свойства по умолчанию

Вы можете использовать сопоставление свойства по умолчанию, а также расширить его с помощью собственного сопоставления.

### <a name="to-extend-a-default-property-mapping"></a>Расширение сопоставления свойства по умолчанию

-   Скопируйте следующий код в определение `Form1` класса.

     [!code-csharp[PropertyMappingWithElementHost#15](~/samples/snippets/csharp/VS_Snippets_Wpf/PropertyMappingWithElementHost/CSharp/PropertyMappingWithElementHost/Form1.cs#15)]
     

     `ExtendBackColorMapping` Метод добавляет пользовательский преобразователь свойств для существующего <xref:System.Windows.Forms.Control.BackColor%2A> сопоставление свойств.

     `OnBackColorChange` Метод присваивает определенное изображение для размещенного элемента управления <xref:System.Windows.Controls.Control.Background%2A> свойство. `OnBackColorChange` Метод вызывается после применения сопоставления свойства по умолчанию.

## <a name="initialize-your-property-mappings"></a>Инициализация сопоставлений свойств

1. Скопируйте следующий код в определение `Form1` класса.

     [!code-csharp[PropertyMappingWithElementHost#11](~/samples/snippets/csharp/VS_Snippets_Wpf/PropertyMappingWithElementHost/CSharp/PropertyMappingWithElementHost/Form1.cs#11)]
     

     `Form1_Load` Метод обрабатывает <xref:System.Windows.Forms.Form.Load> событий и выполнения следующей инициализации.

    -   Создает WPF <xref:System.Windows.Controls.Button> элемент.

    -   Вызывает методы, ранее определенные в руководстве, для настройки сопоставлений свойств.

    -   Присваивает начальные значения сопоставленным свойствам.

2. Нажмите клавишу F5, чтобы выполнить сборку приложения и запустить его.

## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Integration.ElementHost.PropertyMap%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.Integration.WindowsFormsHost.PropertyMap%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.Integration.WindowsFormsHost>
- [Сопоставление свойств Windows Forms и WPF](windows-forms-and-wpf-property-mapping.md)
- [Проектирование XAML в Visual Studio](/visualstudio/designers/designing-xaml-in-visual-studio)
- [Пошаговое руководство. Размещение составного элемента управления WPF в форме Windows Forms](walkthrough-hosting-a-wpf-composite-control-in-windows-forms.md)
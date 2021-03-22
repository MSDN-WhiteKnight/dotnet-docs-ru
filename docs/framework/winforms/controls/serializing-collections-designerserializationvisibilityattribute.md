---
title: Пошаговое руководство. Сериализация коллекций стандартных типов с использованием атрибута DesignerSerializationVisibilityAttribute
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- serialization [Windows Forms], collections
- standard types [Windows Forms], collections
- collections [Windows Forms], serializing
- collections [Windows Forms], standard types
ms.assetid: 020c9df4-fdc5-4dae-815a-963ecae5668c
ms.openlocfilehash: c113dcf814a252808ae3232751028947c26821ba
ms.sourcegitcommit: 438919211260bb415fc8f96ca3eabc33cf2d681d
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/16/2019
ms.locfileid: "59614146"
---
# <a name="walkthrough-serializing-collections-of-standard-types-with-the-designerserializationvisibilityattribute"></a>Пошаговое руководство. Сериализация коллекций стандартных типов с использованием атрибута DesignerSerializationVisibilityAttribute

Пользовательские элементы управления, иногда будет предоставлять коллекции как свойство. В этом пошаговом руководстве демонстрируется использование <xref:System.ComponentModel.DesignerSerializationVisibilityAttribute> класс для управления способом сериализации коллекции во время разработки. Применение <xref:System.ComponentModel.DesignerSerializationVisibilityAttribute.Content> значение для свойства коллекции гарантирует, что будет сериализовано свойство.

 Чтобы скопировать код из этого раздела единым блоком, см. раздел [Практическое руководство. Сериализация коллекций стандартных типов с использованием атрибута DesignerSerializationVisibilityAttribute](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/ms171833(v=vs.120)).

> [!NOTE]
> Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).

## <a name="prerequisites"></a>Предварительные требования
 Для выполнения данного пошагового руководства требуется:

- Разрешения, необходимые для создания и выполнения проектов приложений Windows Forms на компьютере, на котором установлена Visual Studio.

## <a name="creating-a-control-that-has-a-serializable-collection"></a>Создание элемента управления, который имеет коллекцию сериализуемый
 Первым шагом является создание элемента управления, имеющего сериализуемые коллекции как свойство. Можно изменить содержимое этой коллекции с помощью **редактор коллекции**, к которому можно получить из **свойства** окна.

### <a name="to-create-a-control-with-a-serializable-collection"></a>Создание элемента управления с сериализуемой коллекцией

1. Создайте проект библиотеки элементов управления Windows с именем `SerializationDemoControlLib`. Дополнительные сведения см. в разделе [шаблон библиотеки элементов управления Windows](https://docs.microsoft.com/previous-versions/kxczf775(v=vs.100)).

2. Переименуйте `UserControl1` для `SerializationDemoControl`. Дополнительные сведения см. в разделе [переименование рефакторинга кода символа](/visualstudio/ide/reference/rename).

3. В **свойства** окна, установите для параметра <xref:System.Windows.Forms.Padding.All%2A?displayProperty=nameWithType> свойства `10`.

4. Место <xref:System.Windows.Forms.TextBox> контролировать `SerializationDemoControl`.

5. Выберите элемент управления <xref:System.Windows.Forms.TextBox>. В **свойства** окна, задайте следующие свойства.

    |Свойство|Измените на|
    |--------------|---------------|
    |**Multiline**|`true`|
    |**Dock**|<xref:System.Windows.Forms.DockStyle.Fill>|
    |**ScrollBars**|<xref:System.Windows.Forms.ScrollBars.Vertical>|
    |**ReadOnly**|`true`|

6. В **редактор кода**, объявите поле строкового массива с именем `stringsValue` в `SerializationDemoControl`.

     [!code-cpp[System.ComponentModel.DesignerSerializationVisibilityAttribute#4](~/samples/snippets/cpp/VS_Snippets_Winforms/System.ComponentModel.DesignerSerializationVisibilityAttribute/cpp/form1.cpp#4)]
     [!code-csharp[System.ComponentModel.DesignerSerializationVisibilityAttribute#4](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.DesignerSerializationVisibilityAttribute/CS/form1.cs#4)]
     

7. Определение `Strings` свойство `SerializationDemoControl`.

> [!NOTE]
> <xref:System.ComponentModel.DesignerSerializationVisibilityAttribute.Content> Значение используется для включения сериализации коллекции.

 [!code-cpp[System.ComponentModel.DesignerSerializationVisibilityAttribute#5](~/samples/snippets/cpp/VS_Snippets_Winforms/System.ComponentModel.DesignerSerializationVisibilityAttribute/cpp/form1.cpp#5)]
 [!code-csharp[System.ComponentModel.DesignerSerializationVisibilityAttribute#5](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.DesignerSerializationVisibilityAttribute/CS/form1.cs#5)]
 

1. Нажмите клавишу F5, чтобы собрать проект и запустить элемент управления в **тестовом контейнере элементов управления**.

2. Найти `Strings` свойство в <xref:System.Windows.Forms.PropertyGrid> из **тестовом контейнере элементов управления**. Нажмите кнопку `Strings` свойство, нажмите кнопку обзора (![экрана VisualStudioEllipsesButton](../media/vbellipsesbutton.png "vbEllipsesButton")) кнопку, чтобы открыть **редактор коллекции строк**.

3. Введите несколько строк в **редактор коллекции строк**. Разделяйте их, нажав клавишу ВВОД в конце каждой строки. Нажмите кнопку **ОК** при завершении.

> [!NOTE]
> Строки отображаются в <xref:System.Windows.Forms.TextBox> из `SerializationDemoControl`.

## <a name="serializing-a-collection-property"></a>Сериализация свойства коллекции

Для тестирования поведения сериализации элемента управления, вы поместите его на форму и изменить содержимое коллекции с **редактор коллекции**. Вы увидите состояния сериализации, просмотрев специальный файл конструктора, в который **конструктор Windows Forms** выдает код.

### <a name="to-serialize-a-collection"></a>Для сериализации коллекции

1. Добавьте в решение проект приложения Windows. Задайте для проекта имя `SerializationDemoControlTest`.

2. В **элементов**, найдите вкладку с именем **компоненты SerializationDemoControlLib**. На этой вкладке вы найдете `SerializationDemoControl`. Дополнительные сведения см. в разделе [Пошаговое руководство: Автоматическое заполнение панели элементов пользовательскими компонентами](walkthrough-automatically-populating-the-toolbox-with-custom-components.md).

3. Место `SerializationDemoControl` в форме.

4. Найти `Strings` свойство в **свойства** окна. Нажмите кнопку `Strings` свойство, нажмите кнопку обзора (![экрана VisualStudioEllipsesButton](../media/vbellipsesbutton.png "vbEllipsesButton")) кнопку, чтобы открыть **редактор коллекции строк**.

5. Введите несколько строк в **редактор коллекции строк**. Разделяйте их, нажав клавишу ВВОД в конце каждой строки. Нажмите кнопку **ОК** при завершении.

> [!NOTE]
> Строки отображаются в <xref:System.Windows.Forms.TextBox> из `SerializationDemoControl`.

1. В **обозревателе решений** нажмите кнопку **Показать все файлы**.

2. Откройте **Form1** узла. Ниже это файл с именем **Form1.Designer.cs** или **Form1.Designer.vb**. Это файл, в который **конструктор Windows Forms** выдает код, представляющий состояние разработки формы и его дочерним элементам. Откройте этот файл в **редакторе кода**.

3. Откройте область, называемую **код, созданный конструктором форм Windows** и найдите раздел **serializationDemoControl1**. Под этой метки — это код, представляющий сериализованное состояние элемента управления. Строки, введенного в шаге 5 будут отображаться в операторе присваивания для `Strings` свойство. В следующих примерах кода в C# и Visual Basic, Показывать код, аналогичны тем, что отображается при вводе строки «red», «оранжевый» и «желтый».

    ```csharp
    this.serializationDemoControl1.Strings = new string[] {
            "red",
            "orange",
            "yellow"};
    ```

    ```vb
    Me.serializationDemoControl1.Strings = New String() {"red", "orange", "yellow"}
    ```

4. В **редактор кода**, измените значение свойства <xref:System.ComponentModel.DesignerSerializationVisibilityAttribute> на `Strings` свойства <xref:System.ComponentModel.DesignerSerializationVisibility.Hidden>.

    ```csharp
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    ```

    ```vb
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    ```

5. Перестройте решение и повторите шаги 3 и 4.

> [!NOTE]
> В этом случае **конструктор Windows Forms** не выдает назначения `Strings` свойство.

## <a name="next-steps"></a>Следующие шаги

Когда вы знаете, как для сериализации коллекции стандартных типов, рассмотрите возможность более глубоко интеграции пользовательских элементов управления в среду разработки. Как улучшить интеграцию разработки пользовательских элементов управления в следующих разделах:

- [Архитектура времени разработки](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/c5z9s1h4(v=vs.120))

- [Атрибуты в элементах управления Windows Forms](attributes-in-windows-forms-controls.md)

- [Общие сведения о сериализации конструктора](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/ms171834(v=vs.120))

- [Пошаговое руководство: Создание элемента управления Windows Forms, используются преимущества функций Visual Studio во время разработки](creating-a-wf-control-design-time-features.md)

## <a name="see-also"></a>См. также

- <xref:System.ComponentModel.DesignerSerializationVisibilityAttribute>
- [Общие сведения о сериализации конструктора](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/ms171834(v=vs.120))
- [Практическое руководство. Сериализация коллекций стандартных типов с использованием атрибута DesignerSerializationVisibilityAttribute](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/ms171833(v=vs.120))
- [Пошаговое руководство: Автоматическое заполнение панели элементов пользовательскими компонентами](walkthrough-automatically-populating-the-toolbox-with-custom-components.md)

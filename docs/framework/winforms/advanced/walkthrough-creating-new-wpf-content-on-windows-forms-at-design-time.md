---
title: Пошаговое руководство. Создание нового содержимого WPF в формах Windows Forms во время разработки
ms.date: 08/18/2018
helpviewer_keywords:
- interoperability [Windows Forms], WPF and Windows Forms
- WPF content [Windows Forms], hosting in Windows Forms
- hosting WPF content in Windows Forms
- ElementHost control
- WPF user control [Windows Forms], hosting in Windows Forms
ms.assetid: 2e92d8e8-f0e4-4df7-9f07-2acf35cd798c
ms.openlocfilehash: ed48db399ba47f0e6be96f7bca33d3892b19e433
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57707915"
---
# <a name="walkthrough-creating-new-wpf-content-on-windows-forms-at-design-time"></a>Пошаговое руководство. Создание нового содержимого WPF в формах Windows Forms во время разработки

В этом разделе показано, как создать элемент управления Windows Presentation Foundation (WPF) для использования в приложениях на основе Windows Forms.

В этом пошаговом руководстве выполняются следующие задачи:

- создание проекта;

- создание элемента управления WPF;

- добавление нового элемента управления WPF в форму Windows Forms. Элемент управления WPF размещается в элементе управления <xref:System.Windows.Forms.Integration.ElementHost>.

## <a name="prerequisites"></a>Предварительные требования

Ниже приведены компоненты, необходимые для выполнения данного пошагового руководства.

- Visual Studio 2017

## <a name="creating-the-project"></a>Создание проекта

Первым шагом является создание проекта Windows Forms. Откройте Visual Studio и создайте новый **приложение Windows Forms (.NET Framework)** проект в Visual Basic или Visual C# с именем `HostingWpf`.

> [!NOTE]
> При размещении содержимого WPF поддерживаются только проекты C# и Visual Basic.

## <a name="creating-a-new-wpf-control"></a>Создание элемента управления WPF

Создать элемент управления WPF и добавить его в проект можно так же легко, как добавить в проект любой другой элемент. Конструктор Windows Forms работает с определенного типа элемента управления с именем *составного элемента управления*, или *пользовательский элемент управления*. Подробнее о пользовательских элементах управления WPF см. в разделе <xref:System.Windows.Controls.UserControl>.

> [!NOTE]
> Тип <xref:System.Windows.Controls.UserControl?displayProperty=nameWithType> для элементов управления WPF отличается от типа пользовательских элементов управления, предоставляемого Windows Forms, который также называется <xref:System.Windows.Forms.UserControl?displayProperty=nameWithType>.

### <a name="to-create-a-new-wpf-control"></a>Создание элемента управления WPF

1. В **обозревателе решений**, добавьте новый **Библиотека пользовательских элементов управления WPF (.NET Framework)** проекта к решению. Используйте имя по умолчанию для библиотеки элементов управления (`WpfControlLibrary1`). Имя элемента управления по умолчанию — `UserControl1.xaml`.

     Добавление нового элемента управления происходит следующее:

    - Добавляется файл UserControl1.xaml.

    - Добавляется файл UserControl1.xaml.cs или UserControl1.xaml.vb. Этот файл содержит код программной части для обработчиков событий и иных реализованных компонентов.

    - Добавляются ссылки на сборки WPF.

    - Файл UserControl1.xaml открывается в [!INCLUDE[wpfdesigner_current_long](../../../../includes/wpfdesigner-current-long-md.md)].

2. Убедитесь в том, что элемент `UserControl1` выбран в представлении конструирования. Дополнительные сведения см. в разделе [Как Выберите и перемещать элементы в области конструктора](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/bb514527(v=vs.100)).

3. В **свойства** окна, установите для параметра <xref:System.Windows.FrameworkElement.Width%2A> и <xref:System.Windows.FrameworkElement.Height%2A> свойства **200**.

4. Из **элементов**, перетащите <xref:System.Windows.Controls.TextBox?displayProperty=nameWithType> элемента управления в область конструктора.

5. В **свойства** окна, установите для параметра <xref:System.Windows.Controls.TextBox.Text%2A> свойства **Hosted Content**.

    > [!NOTE]
    > Обычно размещается более сложное содержимое WPF. Элемент управления <xref:System.Windows.Controls.TextBox?displayProperty=nameWithType> используется здесь в целях наглядности.

6. Выполните построение проекта.

## <a name="adding-a-wpf-control-to-a-windows-form"></a>Добавление элемента управления WPF в форму Windows Forms

Новый элемент управления WPF готов к использованию в форме. Windows Forms используется <xref:System.Windows.Forms.Integration.ElementHost> управления для размещения содержимого WPF.

### <a name="to-add-a-wpf-control-to-a-windows-form"></a>Добавление элемента управления WPF в форму Windows Forms

1. Откройте `Form1` в конструкторе Windows Forms.

2. В **элементов**, найдите вкладку **пользовательские элементы управления WPF WPFUserControlLibrary**.

3. Перетащите экземпляр `UserControl1` в форму.

    - Для размещения элемента управления WPF на форме будет автоматически создан элемент управления <xref:System.Windows.Forms.Integration.ElementHost>.

    - <xref:System.Windows.Forms.Integration.ElementHost> Элемент управления называется `elementHost1` и в **свойства** окно, вы увидите его <xref:System.Windows.Forms.Integration.ElementHost.Child%2A> свойству **UserControl1**.

    - В проект добавляются ссылки на сборки WPF.

    - Элемент управления `elementHost1` имеет панель смарт-тегов, на которой приводятся имеющиеся параметры размещения.

4. В **задачи ElementHost** смарт-тега выберите **закрепление в родительском контейнере**.

5. Нажмите клавишу **F5**, чтобы выполнить сборку приложения и запустить его.

## <a name="next-steps"></a>Следующие шаги

Windows Forms и WPF — это разные технологии, но они предназначены для тесного взаимодействия. Чтобы обеспечить богатый внешний вид и поведение в приложениях, попробуйте сделайте следующее:

- Размещение элемента управления Windows Forms на странице WPF. Дополнительные сведения см. в разделе [Пошаговое руководство: Размещение Windows Forms элемента управления в WPF](../../wpf/advanced/walkthrough-hosting-a-windows-forms-control-in-wpf.md).

- Применение стилей оформления Windows Forms к содержимому WPF. Дополнительные сведения см. в разделе [Как Включение визуальных стилей в гибридном приложении](../../wpf/advanced/how-to-enable-visual-styles-in-a-hybrid-application.md).

- Изменение стиля оформления содержимого WPF. Дополнительные сведения см. в разделе [Пошаговое руководство: Применение стилей к содержимому WPF](walkthrough-styling-wpf-content.md).

## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Integration.ElementHost>
- <xref:System.Windows.Forms.Integration.WindowsFormsHost>
- [Миграция и взаимодействие систем](../../wpf/advanced/migration-and-interoperability.md)
- [Использование элементов управления WPF](using-wpf-controls.md)
- [Проектирование XAML в Visual Studio](/visualstudio/designers/designing-xaml-in-visual-studio)

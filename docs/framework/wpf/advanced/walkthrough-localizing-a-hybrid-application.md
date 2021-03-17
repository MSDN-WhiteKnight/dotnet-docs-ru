---
title: Пошаговое руководство. Локализация гибридного приложения
ms.date: 08/18/2018
helpviewer_keywords:
- localization [WPF interoperability]
- hybrid applications [WPF interoperability]
ms.assetid: fbc0c54e-930a-4c13-8e9c-27b83665010a
ms.openlocfilehash: 01530d4ae9779934948bbaff60fbbd392de6e701
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59329301"
---
# <a name="walkthrough-localizing-a-hybrid-application"></a>Пошаговое руководство. Локализация гибридного приложения

В этом пошаговом руководстве показано, как локализовать [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] элементов в [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)]-гибридные приложения на основе.

В данном пошаговом руководстве представлены следующие задачи.

-   Создание [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] узла проекта.

-   Добавление локализуемого содержимого.

-   Включение локализации.

-   Назначение идентификаторов ресурсов.

-   Использование средства LocBaml для создания вспомогательной сборки.

Полный пример кода для задач, приведенных в этом пошаговом руководстве, см. в разделе [локализация гибридного приложения образец](https://go.microsoft.com/fwlink/?LinkID=160015).

Закончив, вы получите локализованное гибридное приложение.

## <a name="prerequisites"></a>Предварительные требования

Ниже приведены компоненты, необходимые для выполнения данного пошагового руководства.

-   Visual Studio 2017

## <a name="creating-the-windows-forms-host-project"></a>Создание ведущего проекта Windows Forms

Первым шагом является создание [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] приложения проекта и добавьте [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] элемент содержимого, которое будет локализовано.

### <a name="to-create-the-host-project"></a>Создание ведущего проекта

1. Создание **приложение WPF** проект с именем `LocalizingWpfInWf`.  (**Файл** > **новый** > **проекта** > **Visual C#** или **Visual Basic**   >  **Классический рабочий стол** > **приложение WPF**).

2. Добавить [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]<xref:System.Windows.Controls.UserControl> элемент с именем `SimpleControl` в проект.

3. Используйте <xref:System.Windows.Forms.Integration.ElementHost> элементу управления размещение `SimpleControl` элемент на форме. Дополнительные сведения см. в разделе [Пошаговое руководство: Размещение составного элемента управления WPF, трехмерного в Windows Forms](walkthrough-hosting-a-3-d-wpf-composite-control-in-windows-forms.md).

## <a name="adding-localizable-content"></a>Добавление локализуемого содержимого

Далее вы добавите [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] метки элемента управления и задайте [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] содержимое элемента Локализованная строка.

### <a name="to-add-localizable-content"></a>Добавление локализуемого содержимого

1. В **обозревателе решений**, дважды щелкните **SimpleControl.xaml** чтобы открыть его в [!INCLUDE[wpfdesigner_current_short](../../../../includes/wpfdesigner-current-short-md.md)].

2. Установка содержимого для <xref:System.Windows.Controls.Button> управления, используя следующий код.

     [!code-xaml[LocalizingWpfInWf#10](~/samples/snippets/csharp/VS_Snippets_Wpf/LocalizingWpfInWf/CSharp/SimpleControl0.xaml#10)]

3. В **обозревателе решений**, дважды щелкните **Form1** чтобы открыть его в конструкторе Windows Forms.

4. Откройте **элементов** и дважды щелкните **метка** для добавления в форму элемент управления label. Задайте для его свойства <xref:System.Windows.Forms.Control.Text%2A> значение `"Hello"`.

5. Нажмите клавишу **F5**, чтобы выполнить сборку приложения и запустить его.

     Оба `SimpleControl` отображать текст, элемент и элемент управления label **«Hello»**.

## <a name="enabling-localization"></a>Включение локализации

Конструктор Windows Forms предоставляет параметры для включения локализации во вспомогательной сборке.

### <a name="to-enable-localization"></a>Включение локализации

1. В **обозревателе решений**, дважды щелкните **Form1.cs** чтобы открыть его в конструкторе Windows Forms.

2. В **свойства** окна, задайте для свойства формы **Localizable** свойства `true`.

3. В **свойства** окна, установите для параметра **языка** свойства **испанский (Испания)**.

4. В конструкторе Windows Forms выберите элемент управления label.

5. В **свойства** окна, установите для параметра <xref:System.Windows.Forms.Control.Text%2A> свойства `"Hola"`.

     Новый файл ресурсов с именем Form1.es-ES.resx будет добавлен в проект.

6. В **обозревателе решений**, щелкните правой кнопкой мыши **Form1.cs** и нажмите кнопку **Просмотр кода** чтобы открыть его в редакторе кода.

7. Скопируйте следующий код в `Form1` конструктор, предшествующий вызову `InitializeComponent`.

     [!code-csharp[LocalizingWpfInWf#2](~/samples/snippets/csharp/VS_Snippets_Wpf/LocalizingWpfInWf/CSharp/Form1.cs#2)]

8. В **обозревателе решений**, щелкните правой кнопкой мыши **LocalizingWpfInWf** и нажмите кнопку **выгрузить проект**.

     Имя проекта помечается **(недоступно)**.

9. Щелкните правой кнопкой мыши **LocalizingWpfInWf**и нажмите кнопку **изменить LocalizingWpfInWf.csproj**.

     Файл проекта откроется в редакторе кода.

10. Скопируйте следующую строку в первый `PropertyGroup` в файле проекта.

    ```xml
    <UICulture>en-US</UICulture>
    ```

11. Сохраните файл проекта и закройте его.

12. В **обозревателе решений**, щелкните правой кнопкой мыши **LocalizingWpfInWf** и нажмите кнопку **перезагрузить проект**.

## <a name="assigning-resource-identifiers"></a>Назначение идентификаторов ресурсов

Вы можете сопоставить локализуемое содержимое со сборками ресурсов с помощью идентификаторов ресурсов. Приложение MsBuild.exe автоматически назначает идентификаторы ресурсов при указании `updateuid` параметр.

### <a name="to-assign-resource-identifiers"></a>Назначение идентификаторов ресурсов

1. Из меню "Пуск" откройте командную строку разработчика для Visual Studio.

2. Используйте приведенную ниже команду для назначения идентификаторов ресурсов вашему локализуемому содержимому.

    ```
    msbuild -t:updateuid LocalizingWpfInWf.csproj
    ```

3. В **обозревателе решений**, дважды щелкните **SimpleControl.xaml** чтобы открыть его в редакторе кода. Вы увидите, что `msbuild` команды добавил `Uid` атрибута ко всем элементам. Это облегчает локализацию через назначение идентификаторов ресурсов.

     [!code-xaml[LocalizingWpfInWf#20](~/samples/snippets/csharp/VS_Snippets_Wpf/LocalizingWpfInWf/CSharp/SimpleControl.xaml#20)]

4. Нажмите клавишу **F6** для сборки решения.

## <a name="using-locbaml-to-produce-a-satellite-assembly"></a>Использование LocBaml для создания вспомогательной сборки

Локализованное содержимое хранится в содержащей только ресурсы *вспомогательную сборку*. Используйте средство командной строки LocBaml.exe, чтобы создать локализованную сборку для вашей [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] содержимого.

### <a name="to-produce-a-satellite-assembly"></a>Создание вспомогательной сборки

1. Скопируйте файл LocBaml.exe в папку проекта obj\Debug. Дополнительные сведения см. в разделе [локализация приложения](how-to-localize-an-application.md).

2. В окне командной строки используйте приведенную ниже команду для извлечения строк ресурсов во временный файл.

    ```
    LocBaml /parse LocalizingWpfInWf.g.en-US.resources /out:temp.csv
    ```

3. Откройте файл temp.csv с помощью Visual Studio или другого текстового редактора. Замените строку `"Hello"` на ее испанский перевод `"Hola"`.

4. Сохраните файл temp.csv.

5. Используйте приведенную ниже команду для создания локализованного файла ресурса.

    ```
    LocBaml /generate /trans:temp.csv LocalizingWpfInWf.g.en-US.resources /out:. /cul:es-ES
    ```

     Файл LocalizingWpfInWf.g.es-ES.resources создается в папке obj\Debug.

6. Используйте приведенную ниже команду для создания локализованной вспомогательной сборки.

    ```
    Al.exe /out:LocalizingWpfInWf.resources.dll /culture:es-ES /embed:LocalizingWpfInWf.Form1.es-ES.resources /embed:LocalizingWpfInWf.g.es-ES.resources
    ```

     Файл LocalizingWpfInWf.resources.dll создается в папке obj\Debug.

7. Скопируйте файл LocalizingWpfInWf.resources.dll в папку проекта bin\Debug\es-ES. Замените существующий файл.

8. Запустите файл LocalizingWpfInWf.exe, который находится в папке проекта bin\Debug. Не выполняйте повторную сборку приложения, чтобы не перезаписать вспомогательную сборку.

     В приложении выводятся локализованные строки вместо английских строк.

## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Integration.ElementHost>
- <xref:System.Windows.Forms.Integration.WindowsFormsHost>
- [Локализация приложения](how-to-localize-an-application.md)
- [Пошаговое руководство. Локализация форм Windows Forms](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/y99d1cd3(v=vs.100))
- [Проектирование XAML в Visual Studio](/visualstudio/designers/designing-xaml-in-visual-studio)

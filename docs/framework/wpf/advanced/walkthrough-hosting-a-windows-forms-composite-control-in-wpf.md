---
title: Пошаговое руководство. Размещение составного элемента управления Windows Forms в приложении WPF
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- hosting Windows Forms control in WPF [WPF]
- composite controls [WPF], hosting in WPF
ms.assetid: 96fcd78d-1c77-4206-8928-3a0579476ef4
ms.openlocfilehash: 90d0e2f3c6ebab070809a4813c87da3539fd14f1
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59337855"
---
# <a name="walkthrough-hosting-a-windows-forms-composite-control-in-wpf"></a>Пошаговое руководство. Размещение составного элемента управления Windows Forms в приложении WPF
[!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] предоставляет среду с широкими возможностями для создания приложений. Тем не менее, если имеются существенные преимущества в [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] код, он может быть более эффективным для повторного использования по крайней мере часть этого кода в вашей [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] приложения, а не переписывание кода с нуля. Наиболее распространенный сценарий — при наличии существующих элементов управления Windows Forms. В некоторых случаях, возможно, у вас даже нет доступа к исходному коду для этих элементов управления. [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] предоставляет простую процедуру размещения таких элементов управления в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] приложения. Например, можно использовать [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] для большей части операций программирования при размещении специализированных <xref:System.Windows.Forms.DataGridView> элементов управления.  
  
 В этом пошаговом руководстве пошагово продемонстрирует приложения, на котором размещена составного элемента управления Windows Forms для поддержки ввода данных в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] приложения. Составной элемент управления упакован в библиотеку DLL. Эта общая процедура может быть расширена для более сложных приложений и элементов управления. В этом пошаговом руководстве должна быть почти идентично повторяет свойства и функциональные возможности для [Пошаговое руководство: Размещение составного элемента управления WPF в Windows Forms](walkthrough-hosting-a-wpf-composite-control-in-windows-forms.md). Основным отличием является то, что сценарий размещения выполняется в обратном порядке.  
  
 Пошаговое руководство состоит из двух разделов. В первом разделе кратко описывается реализация составного элемента управления Windows Forms. Во втором разделе подробно рассматриваются размещение составного элемента управления в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] приложения, получать события из элемента управления и доступ к некоторым свойствам элемента управления.  
  
 В данном пошаговом руководстве представлены следующие задачи.  
  
-   Реализация составного элемента управления Windows Forms.  
  
-   Реализация ведущего приложения WPF.  
  
 Полный пример кода для задач, приведенных в этом пошаговом руководстве, см. в разделе [размещения Windows Forms составного элемента управления в WPF](https://go.microsoft.com/fwlink/?LinkID=159999).  
  
## <a name="prerequisites"></a>Предварительные требования  

Для выполнения шагов, описанных в этом руководстве, вам понадобится Visual Studio.
  
## <a name="implementing-the-windows-forms-composite-control"></a>Реализация составного элемента управления Windows Forms  
 В этом примере составного элемента управления Windows Forms — это форма простого ввода данных. Эта форма принимает имя и адрес пользователя и затем использует пользовательское событие для возвращения сведений в основное приложение. На приведенном ниже рисунке показан отображаемый элемент управления.  

 На следующем рисунке показана составного элемента управления Windows Forms:  

 ![Снимок экрана с простого элемента управления Windows Forms.](./media/walkthrough-hosting-a-windows-forms-composite-control-in-wpf/windows-forms-control.gif)  
  
### <a name="creating-the-project"></a>Создание проекта  
 Для запуска проекта выполните указанные ниже действия.  
  
1. Запустите [!INCLUDE[TLA#tla_visualstu](../../../../includes/tlasharptla-visualstu-md.md)]и откройте **новый проект** диалоговое окно.  
  
2. В категории Windows выберите **Библиотека элементов управления Windows Forms** шаблона.  
  
3. Присвойте проекту имя `MyControls`.  
  
4. Для расположения укажите понятным именем папки верхнего уровня, такие как `WpfHostingWindowsFormsControl`. Позже ведущее приложение будет помещено в эту папку.  
  
5. Нажмите кнопку **ОК**, чтобы создать проект. По умолчанию проект содержит один элемент управления с именем `UserControl1`.  
  
6. В обозревателе решений Переименуйте `UserControl1` для `MyControl1`.  
  
 Проект должен иметь ссылки на перечисленные ниже системные библиотеки DLL. Если какие-либо из этих библиотек DLL не включены по умолчанию, добавьте их в проект.  
  
-   Система  
  
-   System.Data  
  
-   System.Drawing;  
  
-   System.Windows.Forms.  
  
-   System.Xml  
  
### <a name="adding-controls-to-the-form"></a>Добавление элементов управления на форму  
 Чтобы добавить элементы управления в форму, выполните следующие действия.  
  
-   Откройте `MyControl1` в конструкторе.  
  
 Добавьте пять <xref:System.Windows.Forms.Label> элементы управления и соответствующие им <xref:System.Windows.Forms.TextBox> элементами управления, размером и положением, как на предыдущем рисунке, в форме. В примере <xref:System.Windows.Forms.TextBox> именуются элементы управления:  
  
-   `txtName`  
  
-   `txtAddress`  
  
-   `txtCity`  
  
-   `txtState`  
  
-   `txtZip`  
  
 Добавьте два <xref:System.Windows.Forms.Button> элементов управления с меткой **ОК** и **отменить**. В примере используются названия кнопок `btnOK` и `btnCancel`, соответственно.  
  
### <a name="implementing-the-supporting-code"></a>Реализация соответствующего кода  
 Откройте форму в представлении кода. Элемент управления возвращает собранные данные на узел путем вызова пользовательского `OnButtonClick` событий. Данные содержатся в объекте аргумента события. В следующем коде показано объявление события и делегата.  
  
 Добавьте следующий код в класс `MyControl1` .  
  
 [!code-csharp[WpfHostingWindowsFormsControl#2](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfHostingWindowsFormsControl/CSharp/MyControls/MyControl1.cs#2)]
 

 `MyControlEventArgs` Класс содержит информацию, возвращаемую к узлу.

 Добавьте в форму следующий класс.

 [!code-csharp[WpfHostingWindowsFormsControl#3](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfHostingWindowsFormsControl/CSharp/MyControls/MyControl1.cs#3)]
 

 Когда пользователь щелкает **ОК** или **отменить** кнопки, <xref:System.Windows.Forms.Control.Click> создать обработчики событий `MyControlEventArgs` объект, содержащий данные и вызывает `OnButtonClick` событий. Аргумент события, — это единственное различие между двумя обработчиками `IsOK` свойство. Это свойство позволяет основному приложению определить, какая кнопка была нажата. Ему будет присвоено `true` для **ОК** кнопку, и `false` для **отменить** кнопки. В следующем примере кода показаны два обработчика кнопок.

 Добавьте следующий код в класс `MyControl1` .

 [!code-csharp[WpfHostingWindowsFormsControl#4](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfHostingWindowsFormsControl/CSharp/MyControls/MyControl1.cs#4)]
 

### <a name="giving-the-assembly-a-strong-name-and-building-the-assembly"></a>Присвоение сборке строгого имени и построение сборки
 Для этой сборки, на которые ссылается [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] приложения, он должен иметь строгое имя. Для создания строгого имени, создать файл ключа с Sn.exe и добавьте его в проект.

1. Откройте командную строку [!INCLUDE[TLA2#tla_visualstu](../../../../includes/tla2sharptla-visualstu-md.md)]. Чтобы сделать это, нажмите кнопку **запустить** меню, а затем выберите **все программы/Microsoft Visual Studio 2010 Tools и Visual Studio Командная строка Visual Studio**. Откроется окно консоли с настраиваемыми переменными среды.

2. В командной строке, используйте `cd` команду, чтобы перейти в папку проекта.

3. Создайте файл ключа с именем MyControls.snk, выполнив следующую команду.

    ```
    Sn.exe -k MyControls.snk
    ```

4. Чтобы включить файл ключа в проект, щелкните правой кнопкой мыши имя проекта в обозревателе решений и нажмите кнопку **свойства**. В конструкторе проектов щелкните **подписывание** выберите **подписать сборку** установите флажок, а затем перейдите к файлу ключа.

5. Постройте решение. Сборка создаст библиотеку DLL с именем MyControls.dll.

## <a name="implementing-the-wpf-host-application"></a>Реализация ведущего приложения WPF
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] Разместить приложение использует <xref:System.Windows.Forms.Integration.WindowsFormsHost> для размещения элемента управления `MyControl1`. Приложение обрабатывает `OnButtonClick` событий для получения данных из элемента управления. Он также имеет коллекцию переключателей, можно изменять некоторые свойства элемента управления из [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] приложения. Ниже показано готовое приложение.

На следующем рисунке показана полного приложения, включая элемент управления, внедренные в приложении WPF:

 ![Снимок экрана, показывающий элемент управления, встроенный в страницу WPF.](./media/walkthrough-hosting-a-windows-forms-composite-control-in-wpf/windows-presentation-foundation-page-control.gif)

### <a name="creating-the-project"></a>Создание проекта
 Для запуска проекта выполните указанные ниже действия.

1. Откройте [!INCLUDE[TLA2#tla_visualstu](../../../../includes/tla2sharptla-visualstu-md.md)]и выберите **новый проект**.

2. В категории Windows выберите **приложение WPF** шаблона.

3. Присвойте проекту имя `WpfHost`.

4. В качестве расположения укажите ту же папку верхнего уровня, в которой содержится проект MyControls.

5. Нажмите кнопку **ОК**, чтобы создать проект.

 Необходимо также добавить ссылки на библиотеку DLL, содержащую `MyControl1` и других сборок.

1. Щелкните правой кнопкой мыши имя проекта в обозревателе решений и выберите **добавить ссылку**.

2. Нажмите кнопку **Обзор** вкладку и перейдите к папке, которая содержит файл MyControls.dll. В данном пошаговом руководстве это папка MyControls\bin\Debug.

3. Выберите файл MyControls.dll и нажмите кнопку **ОК**.

4. Добавьте ссылку на сборку WindowsFormsIntegration с именем WindowsFormsIntegration.dll.

### <a name="implementing-the-basic-layout"></a>Реализация базового макета
 [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)] Узла приложение реализовано в файле MainWindow.xaml. Этот файл содержит [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] разметку, которая определяет макет и размещает элемент управления Windows Forms. Приложение состоит из трех областей:

-   **Свойства элемента управления** панель, которая содержит коллекцию переключателей, можно использовать для изменения различных свойств размещаемого элемента управления.

-   **Данные из элемента управления** панель, которая содержит несколько <xref:System.Windows.Controls.TextBlock> элементы, которые отображают данные, возвращенные из размещенного элемента управления.

-   Размещенный элемент.

 Базовый макет показан в следующем XAML-коде. Разметка, необходимая для размещения `MyControl1` пропущена в этом примере, но будет рассказано ниже.

 Замените XAML-код в файле MainWindow.xaml следующим. Если вы используете Visual Basic, измените класс на `x:Class="MainWindow"`.

 [!code-xaml[WpfHostingWindowsFormsControl#100](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfHostingWindowsFormsControl/CSharp/WpfHost/Page1.xaml#100)]

 Первый <xref:System.Windows.Controls.StackPanel> элемент содержит несколько наборов <xref:System.Windows.Controls.RadioButton> элементы управления, необходимые для изменения различных свойств размещаемого элемента управления по умолчанию. За которым следует <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент, какие узлы `MyControl1`. Конечный <xref:System.Windows.Controls.StackPanel> элемент содержит несколько <xref:System.Windows.Controls.TextBlock> элементы, отображающие данных, которые возвращаются размещенным элементом управления. Упорядочение элементов и <xref:System.Windows.Controls.DockPanel.Dock%2A> и <xref:System.Windows.FrameworkElement.Height%2A> параметров атрибутов внедрить размещаемого элемента управления в окно без пропусков и искажений.

#### <a name="hosting-the-control"></a>Размещение элемента управления
 Следующей отредактированной версии предыдущего XAML внимание уделяется элементам, которые необходимы для размещения `MyControl1`.

 [!code-xaml[WpfHostingWindowsFormsControl#101](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfHostingWindowsFormsControl/CSharp/WpfHost/Page1.xaml#101)]
[!code-xaml[WpfHostingWindowsFormsControl#102](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfHostingWindowsFormsControl/CSharp/WpfHost/Page1.xaml#102)]

 `xmlns` Атрибут сопоставления пространства имен создает ссылку на `MyControls` пространство имен, содержащее размещенного элемента управления. Это сопоставление позволяет представить `MyControl1` в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] как `<mcl:MyControl1>`.

 Два элемента в коде XAML обрабатывают размещение:

-   `WindowsFormsHost` Представляет <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент, который позволяет размещать элемент управления Windows Forms в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] приложения.

-   `mcl:MyControl1`, которое представляет `MyControl1`, добавляется <xref:System.Windows.Forms.Integration.WindowsFormsHost> дочернюю коллекцию элемента. Таким образом, этот элемент управления Windows Forms отображается как часть [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] , а также могут взаимодействовать с элементом управления из приложения.

### <a name="implementing-the-code-behind-file"></a>Реализация файла кода программной части
 Файл кода, MainWindow.xaml.vb или MainWindow.xaml.cs содержит процедурный код, который реализует функциональность [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)] описано в предыдущем разделе. Основные задачи

-   Присоединение обработчика событий к `MyControl1`в `OnButtonClick` событий.

-   Изменение различных свойств `MyControl1`в зависимости от способа настройки коллекции переключателей.

-   Отображение данных, собранных с помощью элемента управления.

#### <a name="initializing-the-application"></a>Инициализация приложения
 Код инициализации содержится в обработчике событий для окна <xref:System.Windows.FrameworkElement.Loaded> событий и присоединяет обработчик событий к элементу управления `OnButtonClick` событий.

 В файле MainWindow.xaml.vb или MainWindow.xaml.cs, добавьте следующий код, чтобы `MainWindow` класса.

 [!code-csharp[WpfHostingWindowsFormsControl#11](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfHostingWindowsFormsControl/CSharp/WpfHost/Page1.xaml.cs#11)]
 

 Так как [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] описанные ранее добавленный `MyControl1` для <xref:System.Windows.Forms.Integration.WindowsFormsHost> коллекцию дочерних элементов элемента, можно привести <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемента <xref:System.Windows.Forms.Integration.WindowsFormsHost.Child%2A> для получения ссылки на `MyControl1`. Затем можно использовать эту ссылку для присоединения обработчика событий к `OnButtonClick`.

 Помимо предоставления ссылки на элемент управления, <xref:System.Windows.Forms.Integration.WindowsFormsHost> предоставляет ряд свойств элемента управления, которыми можно управлять из приложения. Код инициализации назначает эти значения закрытым глобальным переменным для последующего использования в приложении.

 Таким образом, можно легко получить типы в `MyControls` библиотеки DLL, добавьте следующий `Imports` или `using` в начало файла.

```vb
Imports MyControls
```

```csharp
using MyControls;
```

#### <a name="handling-the-onbuttonclick-event"></a>Обработка события OnButtonClick
 `MyControl1` вызывает `OnButtonClick` событие, когда пользователь нажимает какую-либо из кнопок элемента управления.

 Добавьте следующий код в класс `MainWindow` .

 [!code-csharp[WpfHostingWindowsFormsControl#12](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfHostingWindowsFormsControl/CSharp/WpfHost/Page1.xaml.cs#12)]
 

 Данные в текстовых полях упакованы в `MyControlEventArgs` объекта. Если пользователь нажимает кнопку **ОК** кнопку, обработчик событий извлекает данные и отображает его на панели ниже `MyControl1`.

#### <a name="modifying-the-controls-properties"></a>Изменение свойств элемента управления
 <xref:System.Windows.Forms.Integration.WindowsFormsHost> Элемент предоставляет несколько свойств размещаемого элемента управления по умолчанию. В результате можно изменить внешний вид элемента управления, чтобы он более полно соответствовал стилю приложения. Наборы переключателей на левой панели позволяют пользователю изменять некоторые свойства цвета и шрифта. Каждый набор кнопок имеет обработчик для <xref:System.Windows.Controls.Primitives.ButtonBase.Click> событие, которое определяет пользователя переключателей и меняет соответствующее свойство элемента управления.

 Добавьте следующий код в класс `MainWindow` .

 [!code-csharp[WpfHostingWindowsFormsControl#13](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfHostingWindowsFormsControl/CSharp/WpfHost/Page1.xaml.cs#13)]
   
  
 Выполните сборку и запуск приложения. Добавьте какой-нибудь текст в составной элемент управления Windows Forms и нажмите кнопку **ОК**. Текст отображается в метках. Щелкайте различные переключатели, чтобы увидеть соответствующий эффект в элементе управления.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Integration.ElementHost>
- <xref:System.Windows.Forms.Integration.WindowsFormsHost>
- [Проектирование XAML в Visual Studio](/visualstudio/designers/designing-xaml-in-visual-studio)
- [Пошаговое руководство. Размещение элементов управления Windows Forms в WPF](walkthrough-hosting-a-windows-forms-control-in-wpf.md)
- [Пошаговое руководство. Размещение составного элемента управления WPF в форме Windows Forms](walkthrough-hosting-a-wpf-composite-control-in-windows-forms.md)

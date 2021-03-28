---
title: Пошаговое руководство. Размещение составного элемента управления WPF в форме Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- hosting WPF content in Windows Forms [WPF]
ms.assetid: 0ac41286-4c1b-4b17-9196-d985cb844ce1
ms.openlocfilehash: 75e60a3a9b39c0dd63a24a1e71c4823e7cb0bd74
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59322840"
---
# <a name="walkthrough-hosting-a-wpf-composite-control-in-windows-forms"></a>Пошаговое руководство. Размещение составного элемента управления WPF в форме Windows Forms
Windows Presentation Foundation (WPF) предоставляет среду с широкими возможностями для создания приложений. Тем не менее, если имеются существенные преимущества в [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] код, он может быть более эффективным, расширение существующего [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] приложения с WPF , а не переписывание кода с нуля. Распространенный сценарий — при необходимости внедрения одного или нескольких элементов управления, реализованных с WPF в приложении Windows Forms. Дополнительные сведения о настройке элементов управления WPF, см. в разделе [Настройка элементов управления](../controls/control-customization.md).  
  
 В этом пошаговом руководстве пошагово продемонстрирует приложение, на котором размещена WPF составного элемента управления для ввода данных в приложении Windows Forms. Составной элемент управления упакован в библиотеку DLL. Эта общая процедура может быть расширена для более сложных приложений и элементов управления. В этом пошаговом руководстве должна быть почти идентично повторяет свойства и функциональные возможности для [Пошаговое руководство: Размещение Windows Forms составного элемента управления в WPF](walkthrough-hosting-a-windows-forms-composite-control-in-wpf.md). Основным отличием является то, что сценарий размещения выполняется в обратном порядке.  
  
 Пошаговое руководство состоит из двух разделов. В первом разделе кратко описывается реализация WPF составного элемента управления. Во втором разделе подробно рассматриваются размещение составного элемента управления в приложении Windows Forms, получение событий от него и доступ к некоторым свойствам элемента управления.  
  
 В данном пошаговом руководстве представлены следующие задачи.  
  
-   Реализация составного элемента управления WPF  
  
-   Реализация ведущего приложения Windows Forms  
  
 Полный пример кода для задач, приведенных в этом пошаговом руководстве, см. в разделе [размещение составного элемента управления WPF в Windows Forms образец](https://go.microsoft.com/fwlink/?LinkID=159996).  
  
## <a name="prerequisites"></a>Предварительные требования  

Для выполнения шагов, описанных в этом руководстве, вам понадобится Visual Studio.  
  
## <a name="implementing-the-wpf-composite-control"></a>Реализация составного элемента управления WPF  
 WPF Составного элемента управления, используемый в этом примере представляет собой форму простого ввода данных, который принимает имя и адрес пользователя. Когда пользователь нажимает одну из двух кнопок, чтобы указать, что задача завершена, элемент управления создает пользовательское событие для возвращения сведений в ведущее приложение. На приведенном ниже рисунке показан отображаемый элемент управления. 

 На следующем рисунке показана составного элемента управления WPF: 

 ![Снимок экрана с простой элемент управления WPF.](./media/walkthrough-hosting-a-wpf-composite-control-in-windows-forms/windows-presentation-foundation-composite-control.png)  
  
### <a name="creating-the-project"></a>Создание проекта  
 Для запуска проекта выполните указанные ниже действия.  
  
1. Запустите [!INCLUDE[TLA#tla_visualstu](../../../../includes/tlasharptla-visualstu-md.md)]и откройте **новый проект** диалоговое окно.  
  
2. В Visual C# и категории Windows выберите **Библиотека пользовательских элементов управления WPF** шаблона.  
  
3. Присвойте проекту имя `MyControls`.  
  
4. Для расположения укажите понятным именем папки верхнего уровня, такие как `WindowsFormsHostingWpfControl`. Позже ведущее приложение будет помещено в эту папку.  
  
5. Нажмите кнопку **ОК**, чтобы создать проект. По умолчанию проект содержит один элемент управления с именем `UserControl1`.  
  
6. В обозревателе решений Переименуйте `UserControl1` для `MyControl1`.  
  
 Проект должен иметь ссылки на перечисленные ниже системные библиотеки DLL. Если какие-либо из этих библиотек DLL не включены по умолчанию, добавьте их в проект.  
  
-   PresentationCore  
  
-   PresentationFramework  
  
-   Система  
  
-   WindowsBase  
  
### <a name="creating-the-user-interface"></a>Создание пользовательского интерфейса  
 UI  Для составного элемента управления реализуется с помощью XAML. Составной элемент управления UI состоит из пяти <xref:System.Windows.Controls.TextBox> элементов. Каждый <xref:System.Windows.Controls.TextBox> имеет связанный элемент <xref:System.Windows.Controls.TextBlock> элемент, который служит в качестве метки. Существует два <xref:System.Windows.Controls.Button> элементов внизу **ОК** и **отменить**. При нажатии любой кнопки элемент управления создает пользовательское событие для возвращения сведений в ведущее приложение.  
  
#### <a name="basic-layout"></a>Базовый макет  
 Различные UI элементы содержатся в <xref:System.Windows.Controls.Grid> элемент. Можно использовать <xref:System.Windows.Controls.Grid> для размещения содержимого составного элемента управления практически таким же способом можно использовать `Table` элемент в формате HTML. WPF также имеет <xref:System.Windows.Documents.Table> элемент, но <xref:System.Windows.Controls.Grid> проще и лучше выполняются простые задачи компоновки.  
  
 В приведенном ниже коде XAML показан базовый макет. Этот XAML определяет общую структуру элемента управления, указав число столбцов и строк в <xref:System.Windows.Controls.Grid> элемент.  
  
 В файле MyControl1.xaml замените имеющийся код XAML приведенным ниже кодом.  
  
 [!code-xaml[WindowsFormsHostingWpfControl#101](~/samples/snippets/csharp/VS_Snippets_Wpf/WindowsFormsHostingWpfControl/CSharp/MyControls/Page1.xaml#101)]  
[!code-xaml[WindowsFormsHostingWpfControl#102](~/samples/snippets/csharp/VS_Snippets_Wpf/WindowsFormsHostingWpfControl/CSharp/MyControls/Page1.xaml#102)]  
  
#### <a name="adding-textblock-and-textbox-elements-to-the-grid"></a>Добавление в сетку элементов TextBlock и TextBox  
 Поместить UI элемент в сетку посредством присвоения элемента <xref:System.Windows.Controls.Grid.RowProperty> и <xref:System.Windows.Controls.Grid.ColumnProperty> атрибуты для соответствующего числа строк и столбцов. Следует помнить, что нумерация строк и столбцов ведется от нуля. У вас есть элемент охватывать несколько столбцов, установив его <xref:System.Windows.Controls.Grid.ColumnSpanProperty> атрибута. Дополнительные сведения о <xref:System.Windows.Controls.Grid> элементов, см. в разделе [Создание элемента сетки](../controls/how-to-create-a-grid-element.md).  
  
 Следующий XAML показано составного элемента управления <xref:System.Windows.Controls.TextBox> и <xref:System.Windows.Controls.TextBlock> элементы с их <xref:System.Windows.Controls.Grid.RowProperty> и <xref:System.Windows.Controls.Grid.ColumnProperty> атрибуты, для которых задается правильное расположение элементов в сетке.  
  
 В файле MyControl1.xaml добавьте следующий XAML в <xref:System.Windows.Controls.Grid> элемент.  
  
 [!code-xaml[WindowsFormsHostingWpfControl#103](~/samples/snippets/csharp/VS_Snippets_Wpf/WindowsFormsHostingWpfControl/CSharp/MyControls/Page1.xaml#103)]  
  
#### <a name="styling-the-ui-elements"></a>Создание стилей элементов пользовательского интерфейса  
 Многие элементы в форме для ввода данных имеют одинаковый внешний вид. Это означает, что они имеют одинаковые значения нескольких свойств. Вместо того чтобы задавать атрибуты каждого элемента в отдельности, использует предыдущего XAML <xref:System.Windows.Style> элементы для определения стандартных значений свойств для классов элементов. Такой подход упрощает элемент управления и позволяет изменять внешний вид нескольких элементов посредством одного атрибута стиля.  
  
 <xref:System.Windows.Style> Элементы содержатся в <xref:System.Windows.Controls.Grid> элемента <xref:System.Windows.FrameworkElement.Resources%2A> свойство, поэтому они могут использоваться всеми элементами в элементе управления. Если стиль имеет имя, его применить к элементу, добавив <xref:System.Windows.Style> элементу присвоено имя стиля. Неименованные стили становятся стилями по умолчанию для элемента. Дополнительные сведения о WPF стили, см. в разделе [Стилизация и использование шаблонов](../controls/styling-and-templating.md).  
  
 В следующем XAML показан <xref:System.Windows.Style> элементы для составного элемента управления. Чтобы увидеть, как стили применяются к элементам, см. предыдущий код XAML. Например, последний <xref:System.Windows.Controls.TextBlock> элемент имеет `inlineText` стиля, а последний <xref:System.Windows.Controls.TextBox> элемент использует стиль по умолчанию.  
  
 В файле MyControl1.xaml добавьте следующий XAML сразу после <xref:System.Windows.Controls.Grid> начальный элемент.  
  
 [!code-xaml[WindowsFormsHostingWpfControl#104](~/samples/snippets/csharp/VS_Snippets_Wpf/WindowsFormsHostingWpfControl/CSharp/MyControls/Page1.xaml#104)]  
  
#### <a name="adding-the-ok-and-cancel-buttons"></a>Добавление кнопок OK и "Отмена"  
 Завершающими элементами составного элемента управления являются **ОК** и **отменить** <xref:System.Windows.Controls.Button> элементы, которые занимают первые два столбца последней строки <xref:System.Windows.Controls.Grid>. Эти элементы используют общий обработчик событий, `ButtonClicked`и значение по умолчанию <xref:System.Windows.Controls.Button> стиль, определенный в предыдущем XAML.  
  
 В файле MyControl1.xaml добавьте следующий XAML после последнего <xref:System.Windows.Controls.TextBox> элемент. [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] Часть составного элемента управления завершена.  
  
 [!code-xaml[WindowsFormsHostingWpfControl#105](~/samples/snippets/csharp/VS_Snippets_Wpf/WindowsFormsHostingWpfControl/CSharp/MyControls/Page1.xaml#105)]  
  
### <a name="implementing-the-code-behind-file"></a>Реализация файла кода программной части  
 Файле кода программной части MyControl1.xaml.cs реализует три важные задачи:
  
1. обрабатывает событие, когда пользователь нажимает одну из кнопок;  
  
2. Извлекает данные из <xref:System.Windows.Controls.TextBox> элементов и упаковывает их в объект аргумента пользовательского события.  
  
3. Вызывает пользовательское `OnButtonClick` событие, которое уведомляет ведущее приложение, что пользователь завершил работу и передает данные на узел.  
  
 Элемент управления также предоставляет ряд свойств цвета и шрифтов, которые позволяют изменять внешний вид. В отличие от <xref:System.Windows.Forms.Integration.WindowsFormsHost> класс, который используется для размещения элемента управления Windows Forms, <xref:System.Windows.Forms.Integration.ElementHost> класс предоставляет элемент управления <xref:System.Windows.Controls.Panel.Background%2A> только свойство. Чтобы обеспечить сходство между этим примером кода и примере, рассмотренном в [Пошаговое руководство: Размещение Windows Forms составного элемента управления в WPF](walkthrough-hosting-a-windows-forms-composite-control-in-wpf.md), элемент управления непосредственно предоставляет остальные свойства.  
  
#### <a name="the-basic-structure-of-the-code-behind-file"></a>Базовая структура файла кода программной части  
 Файл с выделенным кодом состоит из одного пространства имен, `MyControls`, который будет содержать два класса `MyControl1` и `MyControlEventArgs`.  
  
```  
namespace MyControls  
{  
  public partial class MyControl1 : Grid  
  {  
    //...  
  }  
  public class MyControlEventArgs : EventArgs  
  {  
    //...  
  }  
}  
```  
  
 Первый класс, `MyControl1`, — это разделяемый класс, содержащий код, который реализует функции UI определены в файле MyControl1.xaml. При синтаксическом анализе файле MyControl1.xaml, [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] преобразуется в тот же разделяемый класс, и два разделяемых класса объединяются для формирования скомпилированного элемента управления. По этой причине имя класса в файле кода программной части должно совпадать с именем класса, назначенным в файле MyControl1.xaml, и наследоваться от корневого элемента управления. Второй класс, `MyControlEventArgs`, является классом аргументов события, который используется для отправки данных на узел.  
  
 Откройте файл MyControl1.xaml.cs. Измените существующее объявление класса, чтобы он присваивается следующее имя и наследует от <xref:System.Windows.Controls.Grid>.  
  
 [!code-csharp[WindowsFormsHostingWpfControl#21](~/samples/snippets/csharp/VS_Snippets_Wpf/WindowsFormsHostingWpfControl/CSharp/MyControls/Page1.xaml.cs#21)]  
  
#### <a name="initializing-the-control"></a>Инициализация элемента управления  
 Приведенный ниже код реализует несколько основных задач:  
  
-   Объявляет частное событие `OnButtonClick`и его связанный делегат `MyControlEventHandler`.  
  
-   создает несколько частных глобальных переменных, хранящих данные пользователя. Эти данные предоставляются через соответствующие свойства;  
  
-   Реализует обработчик `Init`, для элемента управления <xref:System.Windows.FrameworkElement.Loaded> событий. Этот обработчик инициализирует глобальные переменные путем присвоения им значений, определенных в файле MyControl1.xaml. Чтобы сделать это, он использует <xref:System.Windows.FrameworkElement.Name%2A> назначенное типичному <xref:System.Windows.Controls.TextBlock> элемент, `nameLabel`, чтобы получить доступ к параметрам свойства этого элемента.  
  
 Удалите существующий конструктор и добавьте следующий код, чтобы ваши `MyControl1` класса.  
  
 [!code-csharp[WindowsFormsHostingWpfControl#11](~/samples/snippets/csharp/VS_Snippets_Wpf/WindowsFormsHostingWpfControl/CSharp/MyControls/Page1.xaml.cs#11)]  
  
#### <a name="handling-the-buttons-click-events"></a>Обработка событий нажатия кнопки  
 Пользователь указывает, что задача ввода данных завершена, щелкнув пункт **ОК** кнопку или **отменить** кнопки. Обе кнопки используют тот же <xref:System.Windows.Controls.Primitives.ButtonBase.Click> обработчик событий `ButtonClicked`. Обе кнопки имеют имя, `btnOK` или `btnCancel`, который позволяет обработчику определить, какая кнопка была нажата, путем проверки значения `sender` аргумент. Обработчик выполняет следующие действия:  
  
-   Создает `MyControlEventArgs` объект, содержащий данные из <xref:System.Windows.Controls.TextBox> элементов.  
  
-   Если пользователь щелкает **отменить** кнопку наборов `MyControlEventArgs` объекта `IsOK` свойства `false`.  
  
-   Вызывает `OnButtonClick` событие, чтобы указать ведущему приложению, что пользователь завершил работу, и передает обратно собранные данные.  
  
 Добавьте следующий код, чтобы ваши `MyControl1` класса, после того, как `Init` метод.  
  
 [!code-csharp[WindowsFormsHostingWpfControl#12](~/samples/snippets/csharp/VS_Snippets_Wpf/WindowsFormsHostingWpfControl/CSharp/MyControls/Page1.xaml.cs#12)]  
  
#### <a name="creating-properties"></a>Создание свойств  
 Оставшаяся часть класса просто предоставляет свойства, которые соответствуют описанным выше глобальным переменным. При изменении свойства метод доступа set изменяет внешний вид элемента управления путем изменения соответствующих свойств элемента и обновления базовых глобальных переменных.  
  
 Добавьте следующий код, чтобы ваши `MyControl1` класса.  
  
 [!code-csharp[WindowsFormsHostingWpfControl#13](~/samples/snippets/csharp/VS_Snippets_Wpf/WindowsFormsHostingWpfControl/CSharp/MyControls/Page1.xaml.cs#13)]  
  
#### <a name="sending-the-data-back-to-the-host"></a>Отправка данных обратно в ведущее приложение  
 Является последним компонентом в файле `MyControlEventArgs` класс, который используется для отправки собранных данных обратно на узел.  
  
 Добавьте следующий код, чтобы ваши `MyControls` пространства имен. Реализация является простой и далее не рассматривается.  
  
 [!code-csharp[WindowsFormsHostingWpfControl#14](~/samples/snippets/csharp/VS_Snippets_Wpf/WindowsFormsHostingWpfControl/CSharp/MyControls/Page1.xaml.cs#14)]  
  
 Постройте решение. В результате сборки будет создана библиотека DLL с именем MyControls.dll.  
  
<a name="winforms_host_section"></a>   
## <a name="implementing-the-windows-forms-host-application"></a>Реализация ведущего приложения Windows Forms  
 Windows Forms разместить приложение использует <xref:System.Windows.Forms.Integration.ElementHost> объект узла WPF составного элемента управления. Приложение обрабатывает `OnButtonClick` событий для получения данных из составного элемента управления. Приложение также содержит набор переключателей, которые можно использовать для изменения внешнего вида элемента управления. На рисунке ниже показано приложение.  

На следующем рисунке показана составной элемент управления WPF в приложении Windows Forms»  

 ![Scteenshot, показан элемент управления Avalon размещения формы Windows.](./media/walkthrough-hosting-a-wpf-composite-control-in-windows-forms/windows-form-hosting-avalon-control.png)  
  
### <a name="creating-the-project"></a>Создание проекта  
 Для запуска проекта выполните указанные ниже действия.  
  
1. Запустите [!INCLUDE[TLA2#tla_visualstu](../../../../includes/tla2sharptla-visualstu-md.md)]и откройте **новый проект** диалоговое окно.  
  
2. В Visual C# и категории Windows выберите **приложение Windows Forms** шаблона.  
  
3. Присвойте проекту имя `WFHost`.  
  
4. В качестве расположения укажите ту же папку верхнего уровня, в которой содержится проект MyControls.  
  
5. Нажмите кнопку **ОК**, чтобы создать проект.  
  
 Необходимо также добавить ссылки на библиотеку DLL, содержащую `MyControl1` и других сборок.  
  
1. Щелкните правой кнопкой мыши имя проекта в обозревателе решений и выберите **добавить ссылку**.  
  
2. Нажмите кнопку **Обзор** вкладку и перейдите к папке, которая содержит файл MyControls.dll. В данном пошаговом руководстве это папка MyControls\bin\Debug.  
  
3. Выберите файл MyControls.dll и нажмите кнопку **ОК**.  
  
4. Добавьте ссылки на следующие сборки.  
  
    -   PresentationCore  
  
    -   PresentationFramework  
  
    -   System.Xaml  
  
    -   WindowsBase  
  
    -   WindowsFormsIntegration  
  
### <a name="implementing-the-user-interface-for-the-application"></a>Реализация пользовательского интерфейса для приложения  
 Пользовательский интерфейс приложения Windows Forms содержит несколько элементов управления для взаимодействия с составным элементом управления WPF.  
  
1. Откройте приложение Form1 в конструкторе Windows Forms.  
  
2. Увеличьте форму, чтобы разместить элементы управления.  
  
3. В правом верхнем углу формы добавьте <xref:System.Windows.Forms.Panel?displayProperty=nameWithType> управления для хранения WPF составного элемента управления.  
  
4. Добавьте следующий <xref:System.Windows.Forms.GroupBox?displayProperty=nameWithType> элементов управления в форму.  
  
    |name|Текста|  
    |----------|----------|  
    |groupBox1|Цвет фона|  
    |groupBox2|Цвет переднего плана|  
    |groupBox3|Размер шрифта|  
    |groupBox4|Семейство шрифтов|  
    |groupBox5|Стиль шрифта|  
    |groupBox6|Насыщенность шрифта|  
    |groupBox7|Данные из элемента управления|  
  
5. Добавьте следующий <xref:System.Windows.Forms.RadioButton?displayProperty=nameWithType> элементы управления <xref:System.Windows.Forms.GroupBox?displayProperty=nameWithType> элементов управления.  
  
    |GroupBox|name|Текста|  
    |--------------|----------|----------|  
    |groupBox1|radioBackgroundOriginal|До преобразования|  
    |groupBox1|radioBackgroundLightGreen|LightGreen|  
    |groupBox1|radioBackgroundLightSalmon|LightSalmon|  
    |groupBox2|radioForegroundOriginal|До преобразования|  
    |groupBox2|radioForegroundRed|Красный|  
    |groupBox2|radioForegroundYellow|Желтый|  
    |groupBox3|radioSizeOriginal|До преобразования|  
    |groupBox3|radioSizeTen|10|  
    |groupBox3|radioSizeTwelve|12|  
    |groupBox4|radioFamilyOriginal|До преобразования|  
    |groupBox4|radioFamilyTimes|Times New Roman Cyr|  
    |groupBox4|radioFamilyWingDings|WingDings|  
    |groupBox5|radioStyleOriginal|Норм.|  
    |groupBox5|radioStyleItalic|Italic|  
    |groupBox6|radioWeightOriginal|До преобразования|  
    |groupBox6|radioWeightBold|Полужирный|  
  
6. Добавьте следующий <xref:System.Windows.Forms.Label?displayProperty=nameWithType> управляет к последнему <xref:System.Windows.Forms.GroupBox?displayProperty=nameWithType>. Эти элементы управления отображают данные, возвращенные WPF составного элемента управления.  
  
    |GroupBox|name|Текста|  
    |--------------|----------|----------|  
    |groupBox7|lblName|Имя.|  
    |groupBox7|lblAddress|Почтовый адрес:|  
    |groupBox7|lblCity|Город:|  
    |groupBox7|lblState|Состояние:|  
    |groupBox7|lblZip|Почтовый индекс:|  
  
### <a name="initializing-the-form"></a>Инициализация формы  
 Код размещения обычно реализуется в виде <xref:System.Windows.Forms.Form.Load> обработчик событий. В следующем коде показан <xref:System.Windows.Forms.Form.Load> обработчик событий, обработчик для WPF составного элемента управления <xref:System.Windows.FrameworkElement.Loaded> событий и объявления нескольких глобальных переменных, которые будут использоваться позже.  
  
 В конструкторе Windows Forms дважды щелкните форму, чтобы создать <xref:System.Windows.Forms.Form.Load> обработчик событий. В начале файла Form1.cs добавьте следующий код `using` инструкций.  
  
 [!code-csharp[WindowsFormsHostingWpfControl#10](~/samples/snippets/csharp/VS_Snippets_Wpf/WindowsFormsHostingWpfControl/CSharp/WFHost/Form1.cs#10)]  
  
 Замените содержимое существующего `Form1` класса следующим кодом.  
  
 [!code-csharp[WindowsFormsHostingWpfControl#2](~/samples/snippets/csharp/VS_Snippets_Wpf/WindowsFormsHostingWpfControl/CSharp/WFHost/Form1.cs#2)]  
  
 `Form1_Load` Метод в приведенном выше коде показывает общую процедуру размещения WPF управления:  
  
1. Создайте новый <xref:System.Windows.Forms.Integration.ElementHost> объекта.  
  
2. Задайте в качестве <xref:System.Windows.Forms.Control.Dock%2A> свойства <xref:System.Windows.Forms.DockStyle.Fill?displayProperty=nameWithType>.  
  
3. Добавить <xref:System.Windows.Forms.Integration.ElementHost> управления <xref:System.Windows.Forms.Panel> элемента управления <xref:System.Windows.Forms.Control.Controls%2A> коллекции.  
  
4. Создайте экземпляр WPF элемента управления.  
  
5. Размещение составного элемента управления в форме путем назначения элемента управления в <xref:System.Windows.Forms.Integration.ElementHost> элемента управления <xref:System.Windows.Forms.Integration.ElementHost.Child%2A> свойство.  
  
 Остальные две строки в `Form1_Load` метод присоединять обработчики к двум событиям элемента управления:  
  
-   `OnButtonClick` — пользовательское событие, инициируемое составным элементом управления, когда пользователь щелкает **ОК** или **отменить** кнопки. Обработайте событие для получения ответа пользователя и сбора всех введенных им данных.  
  
-   <xref:System.Windows.FrameworkElement.Loaded> — стандартное событие, вызванное объектом WPF когда он находится полностью загружен. Это событие используется здесь потому, что для примера необходима инициализация нескольких глобальных переменных свойствами элемента управления. Во время в формате <xref:System.Windows.Forms.Form.Load> событий, элемент управления не полностью загружен, и по-прежнему установлены эти значения `null`. Необходимо подождать до элемента управления <xref:System.Windows.FrameworkElement.Loaded> событие возникает для доступа к этим свойствам.  
  
 <xref:System.Windows.FrameworkElement.Loaded> В приведенном выше коде показан обработчик событий. `OnButtonClick` Обработчик рассматривается в следующем разделе.  
  
### <a name="handling-onbuttonclick"></a>Обработка события OnButtonClick  
 `OnButtonClick` Событие возникает, когда пользователь щелкает **ОК** или **отменить** кнопки.  
  
 Обработчик событий проверяет аргумента события `IsOK` поля, чтобы определить, какая кнопка была нажата. `lbl` *Данных* переменные соответствуют <xref:System.Windows.Forms.Label> элементов управления, которые были описаны выше. Если пользователь нажимает кнопку **ОК** кнопку, данные из элемента управления <xref:System.Windows.Controls.TextBox> элемента управления назначаются соответствующему <xref:System.Windows.Forms.Label> элемента управления. Если пользователь нажимает кнопку **отменить**, <xref:System.Windows.Forms.Label.Text%2A> значения устанавливаются строки по умолчанию.  
  
 Добавьте следующую кнопку код обработчика событий для нажатия `Form1` класса.  
  
 [!code-csharp[WindowsFormsHostingWpfControl#3](~/samples/snippets/csharp/VS_Snippets_Wpf/WindowsFormsHostingWpfControl/CSharp/WFHost/Form1.cs#3)]  
  
 Выполните сборку и запуск приложения. Добавьте какой-нибудь текст в составной элемент управления WPF и нажмите кнопку **ОК**. Текст отображается в метках. На данном этапе код для обработки переключателей еще не добавлен.  
  
### <a name="modifying-the-appearance-of-the-control"></a>Изменение внешнего вида элемента управления  
 <xref:System.Windows.Forms.RadioButton> Элементов управления в форме позволит пользователю изменять WPF переднего плана и фона составного элемента управления цветов, а также ряд свойств шрифта. Цвет фона предоставляется командлетом <xref:System.Windows.Forms.Integration.ElementHost> объекта. Остальные свойства предоставляются как настраиваемые свойства элемента управления.  
  
 Дважды щелкните каждую <xref:System.Windows.Forms.RadioButton> управления на форму, чтобы создать <xref:System.Windows.Forms.RadioButton.CheckedChanged> обработчики событий. Замените <xref:System.Windows.Forms.RadioButton.CheckedChanged> обработчики событий следующим кодом.  
  
 [!code-csharp[WindowsFormsHostingWpfControl#4](~/samples/snippets/csharp/VS_Snippets_Wpf/WindowsFormsHostingWpfControl/CSharp/WFHost/Form1.cs#4)]  
  
 Выполните сборку и запуск приложения. Щелкайте различные переключатели, чтобы увидеть соответствующий эффект в составном элементе управления WPF.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Integration.ElementHost>
- <xref:System.Windows.Forms.Integration.WindowsFormsHost>
- [Проектирование XAML в Visual Studio](/visualstudio/designers/designing-xaml-in-visual-studio)
- [Пошаговое руководство. Размещение составного элемента управления Windows Forms в приложении WPF](walkthrough-hosting-a-windows-forms-composite-control-in-wpf.md)
- [Пошаговое руководство. Размещение составного трехмерного элемента управления WPF в форме Windows Forms](walkthrough-hosting-a-3-d-wpf-composite-control-in-windows-forms.md)

---
title: Пошаговое руководство. Упорядочение элементов управления Windows Forms в WPF
ms.date: 04/03/2018
dev_langs:
- csharp
- vb
helpviewer_keywords:
- hybrid applications [WPF interoperability]
- arranging controls [WPF]
ms.assetid: a1db8049-15c7-45d6-ae3d-36a6735cb848
ms.openlocfilehash: 5b759baebb7192c1ee94b4aa925198864ba7a31a
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59338778"
---
# <a name="walkthrough-arranging-windows-forms-controls-in-wpf"></a>Пошаговое руководство. Упорядочение элементов управления Windows Forms в WPF
В этом пошаговом руководстве показано, как использовать WPF функции макета для размещения [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементов управления в гибридном приложении.  
  
 В данном пошаговом руководстве представлены следующие задачи.  
  
-   Создание проекта.  
  
-   Использование параметров макета по умолчанию.  
  
-   Изменение размеров в зависимости от содержимого.  
  
-   Использование абсолютного позиционирования.  
  
-   Задание размера явным образом.  
  
-   Установка свойств макета.  
  
-   Описание ограничений z-порядка.  
  
-   Закрепление.  
  
-   Задание видимости.  
  
-   Размещение нерастягиваемых элементов управления.  
  
-   Масштабирование.  
  
-   Поворот.  
  
-   Задание полей и внутренних полей.  
  
-   Использование динамических контейнеров макета.  
  
 Полный пример кода для задач, приведенных в этом пошаговом руководстве, см. в разделе [упорядочение Windows Forms в WPF образец](https://go.microsoft.com/fwlink/?LinkID=159971).  
  
 Когда вы закончите, вы получите представление о [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] возможности разметки в WPF-приложений на основе.  
  
## <a name="prerequisites"></a>Предварительные требования  

Для выполнения шагов, описанных в этом руководстве, вам понадобится Visual Studio.
  
## <a name="creating-the-project"></a>Создание проекта  
  
#### <a name="to-create-and-set-up-the-project"></a>Создание и настройка проекта  
  
1. Создание проекта приложения WPF с именем `WpfLayoutHostingWf`.  
  
2. В обозревателе решений добавьте ссылки на следующие сборки.  
  
    -   WindowsFormsIntegration  
  
    -   System.Windows.Forms.  
  
    -   System.Drawing;  
  
3. Дважды щелкните файл MainWindow.xaml, чтобы открыть его в представлении XAML.  
  
4. В <xref:System.Windows.Window> элемента, добавьте следующий [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] сопоставление пространства имен.  
  
    ```xaml  
    xmlns:wf="clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms"  
    ```  
  
5. В <xref:System.Windows.Controls.Grid> элемент набора <xref:System.Windows.Controls.Grid.ShowGridLines%2A> свойства `true` и определите пять строк и три столбца.  
  
     [!code-xaml[WpfLayoutHostingWfWithXaml#2](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfLayoutHostingWfWithXaml/CSharp/Window1.xaml#2)]  
  
## <a name="using-default-layout-settings"></a>Использование параметров макета по умолчанию  
 По умолчанию <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент обрабатывает макет для размещаемого [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элемента управления.  
  
#### <a name="to-use-default-layout-settings"></a>Использование параметров макета по умолчанию  
  
1. Скопируйте следующий XAML в <xref:System.Windows.Controls.Grid> элемент.  
  
     [!code-xaml[WpfLayoutHostingWfWithXaml#3](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfLayoutHostingWfWithXaml/CSharp/Window1.xaml#3)]  
  
2. Нажмите клавишу F5, чтобы выполнить сборку приложения и запустить его. [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)]<xref:System.Windows.Forms.Button?displayProperty=nameWithType> Появился на <xref:System.Windows.Controls.Canvas>. Размещаемый элемент управления имеет размер в зависимости от содержимого и <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемента изменяются, чтобы вместить размещаемый элемент управления.  
  
## <a name="sizing-to-content"></a>Изменение размеров в зависимости от содержимого  
 <xref:System.Windows.Forms.Integration.WindowsFormsHost> Элемент гарантирует, что размещенного элемента управления изменяется в соответствии с правильного отображения его содержимого.  
  
#### <a name="to-size-to-content"></a>Изменение размеров в соответствии с содержимым  
  
1. Скопируйте следующий XAML в <xref:System.Windows.Controls.Grid> элемент.  
  
     [!code-xaml[WpfLayoutHostingWfWithXaml#4](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfLayoutHostingWfWithXaml/CSharp/Window1.xaml#4)]  
  
2. Нажмите клавишу F5, чтобы выполнить сборку приложения и запустить его. Два новых элемента управления кнопки изменяется для отображения длинных строк текста и размера шрифта правильно и <xref:System.Windows.Forms.Integration.WindowsFormsHost> элементов изменяется, чтобы вместить размещаемые элементы управления.  
  
## <a name="using-absolute-positioning"></a>Использование абсолютного позиционирования  
 Абсолютное позиционирование можно использовать для размещения <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент в любом месте в пользовательском интерфейсе (UI).  
  
#### <a name="to-use-absolute-positioning"></a>Использование абсолютного позиционирования  
  
1. Скопируйте следующий XAML в <xref:System.Windows.Controls.Grid> элемент.  
  
     [!code-xaml[WpfLayoutHostingWfWithXaml#5](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfLayoutHostingWfWithXaml/CSharp/Window1.xaml#5)]  
  
2. Нажмите клавишу F5, чтобы выполнить сборку приложения и запустить его. <xref:System.Windows.Forms.Integration.WindowsFormsHost> Элемент помещается в 20 точках от верхнего края ячейки сетки и в 20 точках от левого края.  
  
## <a name="specifying-size-explicitly"></a>Задание размера явным образом  
 Можно указать размер <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемента с помощью <xref:System.Windows.FrameworkElement.Width%2A> и <xref:System.Windows.FrameworkElement.Height%2A> свойства.  
  
#### <a name="to-specify-size-explicitly"></a>Задание размера явным образом  
  
1. Скопируйте следующий XAML в <xref:System.Windows.Controls.Grid> элемент.  
  
     [!code-xaml[WpfLayoutHostingWfWithXaml#6](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfLayoutHostingWfWithXaml/CSharp/Window1.xaml#6)]  
  
2. Нажмите клавишу F5, чтобы выполнить сборку приложения и запустить его. <xref:System.Windows.Forms.Integration.WindowsFormsHost> Элемент имеет значение размером 50 пикселей в ширину и 70 пикселей в высоту, которая меньше, чем параметры макета по умолчанию. Содержание [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] управления упорядочивается соответствующим образом.  
  
## <a name="setting-layout-properties"></a>Установка свойств макета  
 Всегда значение связанные с макетом свойств размещаемого элемента управления с помощью свойства <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемента. При установке свойств макета непосредственно для размещаемого элемента управления результат не будет соответствовать ожидаемому.  
  
 Установка связанных с макетом свойств размещаемого элемента управления в XAML не оказывает влияния.  
  
#### <a name="to-see-the-effects-of-setting-properties-on-the-hosted-control"></a>Чтобы увидеть влияние задания свойств размещаемого элемента управления  
  
1. Скопируйте следующий XAML в <xref:System.Windows.Controls.Grid> элемент.  
  
     [!code-xaml[WpfLayoutHostingWfWithXaml#7](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfLayoutHostingWfWithXaml/CSharp/Window1.xaml#7)]  
  
2. В обозревателе решений дважды щелкните файл MainWindow.xaml. vb или MainWindow.xaml.cs, чтобы открыть его в редакторе кода.  
  
3. Скопируйте следующий код в `MainWindow` определение класса.  
  
     [!code-csharp[WpfLayoutHostingWfWithXaml#101](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfLayoutHostingWfWithXaml/CSharp/Window1.xaml.cs#101)]
     

4. Нажмите клавишу F5, чтобы выполнить сборку приложения и запустить его.

5. Нажмите кнопку **Click me** кнопки. `button1_Click` Наборам обработчик событий <xref:System.Windows.Forms.Control.Top%2A> и <xref:System.Windows.Forms.Control.Left%2A> свойств размещаемого элемента управления. В результате размещаемого элемента управления в границах <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент. Ведущий элемент занимает то же пространство на экране, но размещаемый элемент управления обрезается. Вместо этого размещаемый элемент управления должен всегда заполнять <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент.

## <a name="understanding-z-order-limitations"></a>Описание ограничений z-порядка
 Отображается <xref:System.Windows.Forms.Integration.WindowsFormsHost> элементы всегда рисуются поверх других элементов WPF, и это не влияет z порядка. Чтобы просмотреть это поведение z порядка, сделайте следующее:

1. Скопируйте следующий XAML в <xref:System.Windows.Controls.Grid> элемент.

     [!code-xaml[WpfLayoutHostingWfWithXaml#8](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfLayoutHostingWfWithXaml/CSharp/Window1.xaml#8)]

2. Нажмите клавишу F5, чтобы выполнить сборку приложения и запустить его. <xref:System.Windows.Forms.Integration.WindowsFormsHost> Окрашивания элемента через элемент метки.

## <a name="docking"></a>Закрепление
 <xref:System.Windows.Forms.Integration.WindowsFormsHost> поддерживает элемент WPF закрепления. Задайте <xref:System.Windows.Controls.DockPanel.Dock%2A> присоединенного свойства, чтобы закрепить размещаемый элемент управления в <xref:System.Windows.Controls.DockPanel> элемент.

#### <a name="to-dock-a-hosted-control"></a>Закрепление размещаемого элемента управления

1. Скопируйте следующий XAML в <xref:System.Windows.Controls.Grid> элемент.

     [!code-xaml[WpfLayoutHostingWfWithXaml#9](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfLayoutHostingWfWithXaml/CSharp/Window1.xaml#9)]

2. Нажмите клавишу F5, чтобы выполнить сборку приложения и запустить его. <xref:System.Windows.Forms.Integration.WindowsFormsHost> Элемент закреплен на правой стороне <xref:System.Windows.Controls.DockPanel> элемент.

## <a name="setting-visibility"></a>Задание видимости
 Можно сделать ваши [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] управления невидимым или свернуть его, задав <xref:System.Windows.UIElement.Visibility%2A> свойство <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент. Если элемент управления невидим, он не отображается, но при этом занимает пространство разметки. Если элемент управления свернут, он не отображается и не занимает пространство разметки.

#### <a name="to-set-the-visibility-of-a-hosted-control"></a>Задание видимости размещаемого элемента управления

1. Скопируйте следующий XAML в <xref:System.Windows.Controls.Grid> элемент.

     [!code-xaml[WpfLayoutHostingWfWithXaml#10](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfLayoutHostingWfWithXaml/CSharp/Window1.xaml#10)]

2. В файле MainWindow.xaml.vb или MainWindow.xaml.cs скопируйте следующий код в определение класса.

     [!code-csharp[WpfLayoutHostingWfWithXaml#102](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfLayoutHostingWfWithXaml/CSharp/Window1.xaml.cs#102)]
     

3. Нажмите клавишу F5, чтобы выполнить сборку приложения и запустить его.

4. Нажмите кнопку **щелкните, чтобы сделать невидимыми** кнопку, чтобы <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент невидимым.

5. Нажмите кнопку **щелкните, чтобы свернуть** кнопку, чтобы скрыть <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемента из макета полностью. Когда [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элемент управления свернут, соседние элементы переупорядочиваются, чтобы занять его место.

## <a name="hosting-a-control-that-does-not-stretch"></a>Размещение нерастягиваемых элементов управления
 Некоторые [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементы управления имеют фиксированный размер и не растягиваются для заполнения доступного пространства в макете. Например <xref:System.Windows.Forms.MonthCalendar> элемент управления отображает месяц в фиксированном пространстве.

#### <a name="to-host-a-control-that-does-not-stretch"></a>Размещение нерастягиваемого элемента управления

1. Скопируйте следующий XAML в <xref:System.Windows.Controls.Grid> элемент.

     [!code-xaml[WpfLayoutHostingWfWithXaml#11](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfLayoutHostingWfWithXaml/CSharp/Window1.xaml#11)]

2. Нажмите клавишу F5, чтобы выполнить сборку приложения и запустить его. <xref:System.Windows.Forms.Integration.WindowsFormsHost> Элемент выравнивается по центру в строке сетки, но он не растягивается для заполнения доступного пространства. Если окно является достаточно большим, можно увидеть два или более месяцев, отображаемых размещаемым <xref:System.Windows.Forms.MonthCalendar> элемента управления, но они выравниваются по центру в строке. WPF Обработчик макетов выравнивает по центру элементы, которые не меняются для заполнения доступного пространства.

## <a name="scaling"></a>Масштабирование
 В отличие от элементов WPF большинство элементов управления Windows Forms не являются непрерывно масштабируемыми. Для предоставления пользовательского масштабирования, переопределить <xref:System.Windows.Forms.Integration.WindowsFormsHost.ScaleChild%2A?displayProperty=nameWithType> метод.

#### <a name="to-scale-a-hosted-control-by-using-the-default-behavior"></a>Масштабирование размещаемого элемента управления с помощью поведения по умолчанию

1. Скопируйте следующий XAML в <xref:System.Windows.Controls.Grid> элемент.

     [!code-xaml[WpfLayoutHostingWfWithXaml#12](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfLayoutHostingWfWithXaml/CSharp/Window1.xaml#12)]

2. Нажмите клавишу F5, чтобы выполнить сборку приложения и запустить его. Размещаемый элемент управления и его окружающие элементы масштабируются с коэффициентом 0,5. Но шрифт размещаемого элемента управления не масштабируется.

<!-- This could use an example of custom scaling. -->

## <a name="rotating"></a>Поворот
 В отличие от элементов WPF элементы управления Windows Forms не поддерживают поворот. <xref:System.Windows.Forms.Integration.WindowsFormsHost> Элемент поворачивается вместе с другими элементами WPF при применении преобразования поворота. Значение поворота, отличное от 180 градусов, вызывает <xref:System.Windows.Forms.Integration.WindowsFormsHost.LayoutError> событий.

#### <a name="to-see-the-effect-of-rotation-in-a-hybrid-application"></a>Чтобы увидеть эффект от поворота в гибридном приложении

1. Скопируйте следующий XAML в <xref:System.Windows.Controls.Grid> элемент.

     [!code-xaml[WpfLayoutHostingWfWithXaml#13](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfLayoutHostingWfWithXaml/CSharp/Window1.xaml#13)]

2. Нажмите клавишу F5, чтобы выполнить сборку приложения и запустить его. Размещаемый элемент управления не повернут, но его соседние элементы повернуты на угол в 180 градусов. Для отображения элементов может потребоваться изменить размер окна.

## <a name="setting-padding-and-margins"></a>Задание отбивки и внутренних полей
 Отступы и рамки в WPF макета похожи на свои аналоги в [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)]. Просто задайте <xref:System.Windows.Controls.Control.Padding%2A> и <xref:System.Windows.FrameworkElement.Margin%2A> свойства <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент.

#### <a name="to-set-padding-and-margins-for-a-hosted-control"></a>Задание отбивки и внутренних полей размещаемого элемента управления

1. Скопируйте следующий XAML в <xref:System.Windows.Controls.Grid> элемент.

     [!code-xaml[WpfLayoutHostingWfWithXaml#14](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfLayoutHostingWfWithXaml/CSharp/Window1.xaml#14)]
    [!code-xaml[WpfLayoutHostingWfWithXaml#15](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfLayoutHostingWfWithXaml/CSharp/Window1.xaml#15)]

2. Нажмите клавишу F5, чтобы выполнить сборку приложения и запустить его. Параметры Отбивки и внутренних полей будут применены к размещаемым [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементов управления таким же образом, они будут применяться в [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)].

## <a name="using-dynamic-layout-containers"></a>Использование динамических контейнеров макета
 [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] предоставляет два динамических контейнера макета, <xref:System.Windows.Forms.FlowLayoutPanel> и <xref:System.Windows.Forms.TableLayoutPanel>. Можно также использовать эти контейнеры в WPF макетов.

#### <a name="to-use-a-dynamic-layout-container"></a>Использование динамических контейнеров макета

1. Скопируйте следующий XAML в <xref:System.Windows.Controls.Grid> элемент.

     [!code-xaml[WpfLayoutHostingWfWithXaml#16](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfLayoutHostingWfWithXaml/CSharp/Window1.xaml#16)]

2. В файле MainWindow.xaml.vb или MainWindow.xaml.cs скопируйте следующий код в определение класса.

     [!code-csharp[WpfLayoutHostingWfWithXaml#103](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfLayoutHostingWfWithXaml/CSharp/Window1.xaml.cs#103)]
     

3. Добавьте вызов метода `InitializeFlowLayoutPanel` в конструкторе.

     [!code-csharp[WpfLayoutHostingWfWithXaml#104](~/samples/snippets/csharp/VS_Snippets_Wpf/WpfLayoutHostingWfWithXaml/CSharp/Window1.xaml.cs#104)]
       
  
4. Нажмите клавишу F5, чтобы выполнить сборку приложения и запустить его. <xref:System.Windows.Forms.Integration.WindowsFormsHost> Элемент заполняет <xref:System.Windows.Controls.DockPanel>, и <xref:System.Windows.Forms.FlowLayoutPanel> упорядочивает его дочерние элементы в используемом по умолчанию <xref:System.Windows.Forms.FlowLayoutPanel.FlowDirection%2A>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Integration.ElementHost>
- <xref:System.Windows.Forms.Integration.WindowsFormsHost>
- [Проектирование XAML в Visual Studio](/visualstudio/designers/designing-xaml-in-visual-studio)
- [Вопросы, связанные с макетом элемента WindowsFormsHost](layout-considerations-for-the-windowsformshost-element.md)
- [Элементы управления упорядочение Windows Forms в WPF](https://go.microsoft.com/fwlink/?LinkID=159971)
- [Пошаговое руководство. Размещение составного элемента управления Windows Forms в приложении WPF](walkthrough-hosting-a-windows-forms-composite-control-in-wpf.md)
- [Пошаговое руководство. Размещение составного элемента управления WPF в форме Windows Forms](walkthrough-hosting-a-wpf-composite-control-in-windows-forms.md)

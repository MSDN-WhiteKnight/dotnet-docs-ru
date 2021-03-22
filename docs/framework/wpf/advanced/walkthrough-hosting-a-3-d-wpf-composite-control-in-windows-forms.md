---
title: Пошаговое руководство. Размещение составного трехмерного элемента управления WPF в форме Windows Forms
ms.date: 08/18/2018
dev_langs:
- csharp
- vb
helpviewer_keywords:
- hosting WPF content in Windows Forms [WPF]
- composite controls [WPF], hosting WPF in
ms.assetid: 486369a9-606a-4a3b-b086-a06f2119c7b0
ms.openlocfilehash: e5b98a33f29759a81ba1cbc1fefbd45c0e5bf736
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59330172"
---
# <a name="walkthrough-hosting-a-3-d-wpf-composite-control-in-windows-forms"></a>Пошаговое руководство. Размещение составного трехмерного элемента управления WPF в форме Windows Forms

В этом пошаговом руководстве показано, как создать [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] составного элемента управления и его размещения в [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементов управления и форм с помощью <xref:System.Windows.Forms.Integration.ElementHost> элемента управления.

В этом пошаговом руководстве будет реализовано [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] <xref:System.Windows.Controls.UserControl> , содержащий два дочерних элемента управления. <xref:System.Windows.Controls.UserControl> Отображает трехмерного конуса (трехмерная). Отрисовка трехмерных объектов стал гораздо проще благодаря [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] чем с [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)]. Таким образом, имеет смысл для размещения [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] <xref:System.Windows.Controls.UserControl> класса для создания трехмерной графики в [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)].

В данном пошаговом руководстве представлены следующие задачи.

-   Создание [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] <xref:System.Windows.Controls.UserControl>.

-   Создание ведущего проекта Windows Forms.

-   Размещение [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] <xref:System.Windows.Controls.UserControl>.

## <a name="prerequisites"></a>Предварительные требования

Ниже приведены компоненты, необходимые для выполнения данного пошагового руководства.

-   Visual Studio 2017

<a name="To_Create_the_UserControl"></a>
## <a name="create-the-usercontrol"></a>Создание пользовательского элемента управления

1. Создание **Библиотека пользовательских элементов управления WPF** проект с именем `HostingWpfUserControlInWf`.

2. Откройте UserControl1.xaml в [!INCLUDE[wpfdesigner_current_short](../../../../includes/wpfdesigner-current-short-md.md)].

3. Замените сгенерированный код следующим кодом:

     [!code-xaml[HostingWpfUserControlInWf#1](~/samples/snippets/csharp/VS_Snippets_Wpf/HostingWpfUserControlInWf/CSharp/HostingWpfUserControlInWf/ConeControl.xaml#1)]

     Этот код определяет <xref:System.Windows.Controls.UserControl?displayProperty=nameWithType> , содержащий два дочерних элемента управления. Первый дочерний элемент управления является <xref:System.Windows.Controls.Label?displayProperty=nameWithType> управления; второй — <xref:System.Windows.Controls.Viewport3D> элемент управления, отображающий трехмерного конуса.

<a name="To_Create_the_Windows_Forms_Host_Project"></a>
## <a name="create-the-host-project"></a>Создание ведущего проекта

1. Добавить **приложение WPF (.NET Framework)** проект с именем `WpfUserControlHost` в решение. Дополнительные сведения см. в разделе [Пошаговое руководство: Создание первого классического приложения WPF](../getting-started/walkthrough-my-first-wpf-desktop-application.md).

2. В **обозревателе решений**, добавьте ссылку на сборку WindowsFormsIntegration с именем WindowsFormsIntegration.dll.

3. Добавьте ссылки на следующие [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] сборки:

    -   PresentationCore

    -   PresentationFramework

    -   WindowsBase

4. Добавьте ссылку на проект `HostingWpfUserControlInWf`.

5. В обозревателе решений задайте `WpfUserControlHost` как проект запуска.

<a name="To_Host_the_Windows_Presentation_Foundation"></a>
## <a name="host-the-usercontrol"></a>Размещение пользовательского элемента управления

1. В конструкторе Windows Forms откройте форму Form1.

2. В окне «Свойства» щелкните **события**, а затем дважды щелкните <xref:System.Windows.Forms.Form.Load> событие, чтобы создать обработчик событий.

     Открывается редактор кода вновь созданным `Form1_Load` обработчик событий.

3. Замените код в файле Form1.cs следующим кодом.

     `Form1_Load` Обработчик событий создает экземпляр класса `UserControl1` и добавляет изображением <xref:System.Windows.Forms.Integration.ElementHost> коллекцию дочерних элементов элемента управления. <xref:System.Windows.Forms.Integration.ElementHost> Элемент управления добавляется в коллекцию дочерних элементов управления в формы.

     [!code-csharp[HostingWpfUserControlInWf#10](~/samples/snippets/csharp/VS_Snippets_Wpf/HostingWpfUserControlInWf/CSharp/WpfUserControlHost/Form1.cs#10)]
     

4. Нажмите клавишу **F5**, чтобы выполнить сборку приложения и запустить его.

## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Integration.ElementHost>
- <xref:System.Windows.Forms.Integration.WindowsFormsHost>
- [Проектирование XAML в Visual Studio](/visualstudio/designers/designing-xaml-in-visual-studio)
- [Пошаговое руководство. Размещение составного элемента управления WPF в форме Windows Forms](walkthrough-hosting-a-wpf-composite-control-in-windows-forms.md)
- [Пошаговое руководство. Размещение составного элемента управления Windows Forms в приложении WPF](walkthrough-hosting-a-windows-forms-composite-control-in-wpf.md)
- [Размещение составного элемента управления WPF в примере Windows Forms](https://go.microsoft.com/fwlink/?LinkID=160001)
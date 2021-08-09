---
title: Пошаговое руководство. Размещение элементов управления Windows Forms в WPF
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- hosting Windows Forms control in WPF [WPF]
ms.assetid: 9cb88415-39b0-4c46-80c4-ff325b674286
ms.openlocfilehash: 4e9b42738ff661425b05a63f2a5e5790c5cbd84b
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59311920"
---
# <a name="walkthrough-hosting-a-windows-forms-control-in-wpf"></a>Пошаговое руководство. Размещение элементов управления Windows Forms в WPF

WPF предоставляет множество элементов управления с богатым набором функций. Тем не менее, иногда можно использовать Windows Forms элементов управления в вашей WPF страниц. Например, может получить значительные преимущества в существующих Windows Forms элементов управления, или имеете Windows Forms элемента управления, предоставляющий уникальную функциональность.

В этом пошаговом руководстве показано, как разместить Windows Forms <xref:System.Windows.Forms.MaskedTextBox?displayProperty=nameWithType> управления WPF страницы с помощью кода.

Полный пример кода для задач, демонстрируемых в этом пошаговом руководстве, см. в разделе [размещение элемента управления Windows Forms в WPF](https://go.microsoft.com/fwlink/?LinkID=160057).

## <a name="prerequisites"></a>Предварительные требования

Для выполнения шагов, описанных в этом руководстве, вам понадобится Visual Studio.

## <a name="hosting-the-windows-forms-control"></a>Размещение элемента управления Windows Forms

### <a name="to-host-the-maskedtextbox-control"></a>Чтобы разместить элемент управления MaskedTextBox, выполните следующие действия.

1. Создание проекта приложения WPF с именем `HostingWfInWpf`.

2. Добавьте ссылки на следующие сборки.

    -   WindowsFormsIntegration

    -   System.Windows.Forms.

3. Откройте файл MainWindow.xaml в [!INCLUDE[wpfdesigner_current_short](../../../../includes/wpfdesigner-current-short-md.md)].

4. Имя <xref:System.Windows.Controls.Grid> элемент `grid1`.

     [!code-xaml[HostingWfInWPF#1](~/samples/snippets/csharp/VS_Snippets_Wpf/HostingWfInWPF/CSharp/HostingWfInWPF/Window1.xaml#1)]

5. В представлении конструирования или XAML, выберите <xref:System.Windows.Window> элемент.

6. В окне «Свойства» щелкните **события** вкладки.

7. Дважды щелкните <xref:System.Windows.FrameworkElement.Loaded> событий.

8. Вставьте следующий код для обработки <xref:System.Windows.FrameworkElement.Loaded> событий.

     [!code-csharp[HostingWfInWPF#10](~/samples/snippets/csharp/VS_Snippets_Wpf/HostingWfInWPF/CSharp/HostingWfInWPF/Window1.xaml.cs#10)]
     

9. В верхней части файла, добавьте следующий код `Imports` или `using` инструкции.

     [!code-csharp[HostingWfInWPF#11](~/samples/snippets/csharp/VS_Snippets_Wpf/HostingWfInWPF/CSharp/HostingWfInWPF/Window1.xaml.cs#11)]
     

10. Нажмите клавишу **F5**, чтобы выполнить сборку приложения и запустить его.

## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Integration.ElementHost>
- <xref:System.Windows.Forms.Integration.WindowsFormsHost>
- [Проектирование XAML в Visual Studio](/visualstudio/designers/designing-xaml-in-visual-studio)
- [Пошаговое руководство. Размещение элемента управления Windows Forms в приложении WPF с помощью XAML](walkthrough-hosting-a-windows-forms-control-in-wpf-by-using-xaml.md)
- [Пошаговое руководство. Размещение составного элемента управления Windows Forms в приложении WPF](walkthrough-hosting-a-windows-forms-composite-control-in-wpf.md)
- [Пошаговое руководство. Размещение составного элемента управления WPF в форме Windows Forms](walkthrough-hosting-a-wpf-composite-control-in-windows-forms.md)
- [Элементы управления Windows Forms и эквивалентные элементы управления WPF](windows-forms-controls-and-equivalent-wpf-controls.md)
- [Размещение элемента управления Windows Forms в WPF](https://go.microsoft.com/fwlink/?LinkID=160057)

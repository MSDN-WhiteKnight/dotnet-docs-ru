---
title: Практическое руководство. Включение визуальных стилей в гибридном приложении
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- hybrid applications [WPF interoperability]
- visual styles [Windows Forms]
ms.assetid: 95de9b9c-d804-405c-b2d1-49a88c1e0fe1
ms.openlocfilehash: 7aa5208a4f378408a01a08a2f4c9dbf2edfa5243
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59323607"
---
# <a name="how-to-enable-visual-styles-in-a-hybrid-application"></a>Практическое руководство. Включение визуальных стилей в гибридном приложении
В этом разделе показано, как включить Microsoft Windows XP визуальные стили на Windows Forms размещение элементов управления в WPF-приложения на основе.  
  
 Если приложение вызывает <xref:System.Windows.Forms.Application.EnableVisualStyles%2A> метод, большая часть вашей Windows Forms элементы управления будут автоматически использовать визуальные стили, если приложение запускается на компьютере Microsoft Windows XP. Дополнительные сведения см. в разделе [отображение элементов управления с использованием стилей оформления](../../winforms/controls/rendering-controls-with-visual-styles.md).  
  
 Полный пример кода для задач, приведенных в этом разделе, см. в разделе [включения визуальных стилей в пример гибридного приложения](https://go.microsoft.com/fwlink/?LinkID=159986).  
  
## <a name="enabling-windows-forms-visual-styles"></a>Включение визуальных стилей Windows Forms  
  
#### <a name="to-enable-windows-forms-visual-styles"></a>Чтобы включить визуальные стили Windows Forms, выполните следующие действия.  
  
1. Создание WPF проект приложения с именем `HostingWfWithVisualStyles`.  
  
2. В обозревателе решений добавьте ссылки на следующие сборки.  
  
    -   WindowsFormsIntegration  
  
    -   System.Windows.Forms.  
  
3. В области элементов дважды щелкните <xref:System.Windows.Controls.Grid> значок, чтобы поместить <xref:System.Windows.Controls.Grid> элемента в рабочей области конструирования.  
  
4. В окне «Свойства» задайте значения <xref:System.Windows.FrameworkElement.Height%2A> и <xref:System.Windows.FrameworkElement.Width%2A> свойства **автоматически**.  
  
5. В представлении конструирования или XAML, выберите <xref:System.Windows.Window>.  
  
6. В окне «Свойства» щелкните **события** вкладки.  
  
7. Дважды щелкните <xref:System.Windows.FrameworkElement.Loaded> событий.
  
8. В файле MainWindow.xaml.vb или MainWindow.xaml.cs вставьте следующий код для обработки <xref:System.Windows.FrameworkElement.Loaded> событий.  
  
     [!code-csharp[HostingWfWithVisualStyles#11](~/samples/snippets/csharp/VS_Snippets_Wpf/HostingWfWithVisualStyles/CSharp/HostingWfWithVisualStyles/Window1.xaml.cs#11)]
       
  
9. Нажмите клавишу F5, чтобы выполнить сборку приложения и запустить его.  
  
     Windows Forms Элемент управления отрисовывается с использованием стилей оформления.  
  
## <a name="disabling-windows-forms-visual-styles"></a>Отключение визуальных стилей Windows Forms  
 Чтобы отключить визуальные стили, просто удалите вызов <xref:System.Windows.Forms.Application.EnableVisualStyles%2A> метод.  
  
#### <a name="to-disable-windows-forms-visual-styles"></a>Чтобы отключить визуальные стили Windows Forms, выполните следующие действия.  
  
1. Откройте файл MainWindow.xaml.vb или MainWindow.xaml.cs в редакторе кода.  
  
2. Закомментируйте вызов <xref:System.Windows.Forms.Application.EnableVisualStyles%2A> метод.  
  
3. Нажмите клавишу F5, чтобы выполнить сборку приложения и запустить его.  
  
     Windows Forms Элемент управления отрисовывается с системным стилем по умолчанию.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Application.EnableVisualStyles%2A>
- <xref:System.Windows.Forms.VisualStyles>
- <xref:System.Windows.Forms.Integration.WindowsFormsHost>
- [Отрисовка элементов управления с применением визуальных стилей](../../winforms/controls/rendering-controls-with-visual-styles.md)
- [Пошаговое руководство. Размещение элементов управления Windows Forms в WPF](walkthrough-hosting-a-windows-forms-control-in-wpf.md)

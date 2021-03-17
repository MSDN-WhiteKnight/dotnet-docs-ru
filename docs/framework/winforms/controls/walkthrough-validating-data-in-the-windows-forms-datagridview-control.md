---
title: Пошаговое руководство. Проверка данных в элементе управления DataGridView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- validating data [Windows Forms], Windows Forms
- data [Windows Forms], validation
- DataGridView control [Windows Forms], data validation
- data grids [Windows Forms], validating data
- data validation [Windows Forms], Windows Forms
- walkthroughs [Windows Forms], DataGridView control
ms.assetid: a4f1d015-2969-430c-8ea2-b612d179c290
ms.openlocfilehash: a4bf0850b28b7101ba76f1c1fedc6633eccb81a1
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59346058"
---
# <a name="walkthrough-validating-data-in-the-windows-forms-datagridview-control"></a>Пошаговое руководство. Проверка данных в элементе управления DataGridView в Windows Forms
При отображении функциональных возможностей ввода данных для пользователей, часто нужно проверить данные, введенные в форму. <xref:System.Windows.Forms.DataGridView> Класс предоставляет удобный способ для выполнения проверки, прежде чем данные передаются в хранилище данных. Можно проверять данные, обрабатывая <xref:System.Windows.Forms.DataGridView.CellValidating> событие, которое вызывается <xref:System.Windows.Forms.DataGridView> при изменении текущей ячейки.  
  
 В этом пошаговом руководстве, вы получите строки из `Customers` таблицы в базе данных Northwind и отобразить их в <xref:System.Windows.Forms.DataGridView> элемента управления. При редактировании ячейки в `CompanyName` столбца и пытается оставьте ячейку, <xref:System.Windows.Forms.DataGridView.CellValidating> обработчик событий проверяет новая строка названия компании, чтобы убедиться, что это не пуста; Если новое значение является пустой строкой, <xref:System.Windows.Forms.DataGridView> предотвратит курсору из ячейки до введения непустой строкой.  
  
 Чтобы скопировать код из этого раздела единым блоком, см. раздел [Практическое руководство. Проверка данных в элементе управления DataGridView Windows Forms](how-to-validate-data-in-the-windows-forms-datagridview-control.md).  
  
## <a name="prerequisites"></a>Предварительные требования  
 Для выполнения данного пошагового руководства требуется:  
  
-   Доступ к серверу с образца базы данных "Борей" SQL Server.  
  
## <a name="creating-the-form"></a>Создание формы  
  
#### <a name="to-validate-data-entered-in-a-datagridview"></a>Чтобы проверить данные, введенные в элементе управления DataGridView  
  
1. Создайте класс, производный от <xref:System.Windows.Forms.Form> и содержит <xref:System.Windows.Forms.DataGridView> управления и <xref:System.Windows.Forms.BindingSource> компонента.  
  
     В следующем примере представлена базовая реализация и включает в себя `Main` метод.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewDataValidation#01](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewDataValidation/CS/datavalidation.cs#01)]
     [!code-vb[System.Windows.Forms.DataGridViewDataValidation#01](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewDataValidation/VB/datavalidation.vb#01)]  
    [!code-csharp[System.Windows.Forms.DataGridViewDataValidation#02](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewDataValidation/CS/datavalidation.cs#02)]
    [!code-vb[System.Windows.Forms.DataGridViewDataValidation#02](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewDataValidation/VB/datavalidation.vb#02)]  
  
2. Реализуйте метод в определении класса формы для обработки сведения о подключении к базе данных.  
  
     Данный пример кода использует `GetData` метод, возвращающий заполненный <xref:System.Data.DataTable> объекта. Убедитесь, что значение `connectionString` переменной значение, которое подходит для вашей базы данных.  
  
    > [!IMPORTANT]
    >  Хранение конфиденциальных сведений (например, пароля) в строке подключения может повлиять на безопасность приложения. Использование проверки подлинности Windows, также известный как встроенная безопасность является более безопасный способ управления доступом к базе данных. Дополнительные сведения см. в разделе [Защита сведений о подключении](../../data/adonet/protecting-connection-information.md).  
  
     [!code-csharp[System.Windows.Forms.DataGridViewDataValidation#30](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewDataValidation/CS/datavalidation.cs#30)]
     [!code-vb[System.Windows.Forms.DataGridViewDataValidation#30](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewDataValidation/VB/datavalidation.vb#30)]  
  
3. Реализовать обработчик для формы <xref:System.Windows.Forms.Form.Load> событие, которое инициализирует <xref:System.Windows.Forms.DataGridView> и <xref:System.Windows.Forms.BindingSource> и устанавливает привязку данных.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewDataValidation#10](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewDataValidation/CS/datavalidation.cs#10)]
     [!code-vb[System.Windows.Forms.DataGridViewDataValidation#10](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewDataValidation/VB/datavalidation.vb#10)]  
  
4. Реализовать обработчики для <xref:System.Windows.Forms.DataGridView> элемента управления <xref:System.Windows.Forms.DataGridView.CellValidating> и <xref:System.Windows.Forms.DataGridView.CellEndEdit> события.  
  
     <xref:System.Windows.Forms.DataGridView.CellValidating> Обработчик событий определяется ли значение ячейки в `CompanyName` столбец пуст. Если значение ячейки не проходит проверку, задайте <xref:System.ComponentModel.CancelEventArgs.Cancel%2A> свойство <xref:System.Windows.Forms.DataGridViewCellValidatingEventArgs?displayProperty=nameWithType> класс `true`. В результате <xref:System.Windows.Forms.DataGridView> управления для предотвращения курсора из ячейки. Задайте <xref:System.Windows.Forms.DataGridViewRow.ErrorText%2A> в строке пояснительный строку. Отобразится значок ошибки появляется всплывающая подсказка, содержащая текст ошибки. В <xref:System.Windows.Forms.DataGridView.CellEndEdit> задать обработчик событий, <xref:System.Windows.Forms.DataGridViewRow.ErrorText%2A> в строке, пустой строкой. <xref:System.Windows.Forms.DataGridView.CellEndEdit> Событие возникает только в том случае, когда ячейка завершается режим редактирования, если он не проходит проверку.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewDataValidation#20](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewDataValidation/CS/datavalidation.cs#20)]
     [!code-vb[System.Windows.Forms.DataGridViewDataValidation#20](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewDataValidation/VB/datavalidation.vb#20)]  
  
## <a name="testing-the-application"></a>Тестирование приложения  
 Теперь можно проверить форму, чтобы убедиться, что она правильно работает.  
  
#### <a name="to-test-the-form"></a>Чтобы проверить форму  
  
-   Скомпилируйте и запустите приложение.  
  
     Вы увидите <xref:System.Windows.Forms.DataGridView> с данными из `Customers` таблицы. Если дважды щелкнуть ячейку в `CompanyName` столбца, можно изменить значение. Если вы удалите все символы, а затем нажать клавишу TAB, чтобы выйти из ячейки, <xref:System.Windows.Forms.DataGridView> позволяет выйти из нее. При вводе непустую строку в ячейку, <xref:System.Windows.Forms.DataGridView> элемент управления позволяет выйти из ячейки.  
  
## <a name="next-steps"></a>Следующие шаги  
 Это приложение позволяет базовое представление о <xref:System.Windows.Forms.DataGridView> возможности элемента управления. Можно настроить внешний вид и поведение <xref:System.Windows.Forms.DataGridView> управления несколькими способами:  
  
-   Изменение стилей границ и заголовка. Дополнительные сведения см. в разделе [Как Изменение границ и линий сетки в Windows Forms элемента управления DataGridView](change-the-border-and-gridline-styles-in-the-datagrid.md).  
  
-   Разрешить или ограничить ввод данных пользователями <xref:System.Windows.Forms.DataGridView> элемента управления. Дополнительные сведения см. в разделе [Как Запретить добавление строк и удаления в Windows Forms элемента управления DataGridView](prevent-row-addition-and-deletion-datagridview.md), и [как: Определение столбцов только для чтения в Windows Forms элемента управления DataGridView](how-to-make-columns-read-only-in-the-windows-forms-datagridview-control.md).  
  
-   Проверьте входные данные пользователя для ошибки, относящиеся к базе данных. Дополнительные сведения см. в разделе [Пошаговое руководство: Обработка ошибок, возникающих во время ввода данных в Windows Forms элемента управления DataGridView](handling-errors-that-occur-during-data-entry-in-the-datagrid.md).  
  
-   Обработка очень больших наборов данных в виртуальном режиме. Дополнительные сведения см. в разделе [Пошаговое руководство: Реализация виртуального режима в Windows Forms элемента управления DataGridView](implementing-virtual-mode-wf-datagridview-control.md).  
  
-   Настройка внешнего вида ячеек. Дополнительные сведения см. в разделе [Как Настройка внешнего вида ячеек элемента управления DataGridView в Windows Forms](customize-the-appearance-of-cells-in-the-datagrid.md) и [как: Настройка шрифтов и цветов в элементе управления DataGridView Windows Forms](how-to-set-font-and-color-styles-in-the-windows-forms-datagridview-control.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.BindingSource>
- [Ввод данных с помощью элемента управления DataGridView в Windows Forms](data-entry-in-the-windows-forms-datagridview-control.md)
- [Практическое руководство. Проверка данных в элементе управления DataGridView в Windows Forms](how-to-validate-data-in-the-windows-forms-datagridview-control.md)
- [Пошаговое руководство. Обработка ошибок, связанных с вводом данных с помощью элемента управления DataGridView, в Windows Forms](handling-errors-that-occur-during-data-entry-in-the-datagrid.md)
- [Защита сведений о подключении](../../data/adonet/protecting-connection-information.md)

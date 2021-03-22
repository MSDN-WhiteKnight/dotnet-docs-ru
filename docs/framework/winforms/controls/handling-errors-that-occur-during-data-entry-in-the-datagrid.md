---
title: Пошаговое руководство. Обработка ошибок, связанных с вводом данных с помощью элемента управления DataGridView, в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- error handling [Windows Forms], dataGridView control
- data grids [Windows Forms], error handling
- DataGridView control [Windows Forms], error handling
- data entry [Windows Forms], error handling
- error handling [Windows Forms], data entry
- walkthroughs [Windows Forms], DataGridView control
ms.assetid: 30a68b85-d3af-4946-83c1-1e2d010d0511
ms.openlocfilehash: 9e803b6450fb8c9ade4adde5bf98fb1c3c62c861
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59313228"
---
# <a name="walkthrough-handling-errors-that-occur-during-data-entry-in-the-windows-forms-datagridview-control"></a>Пошаговое руководство. Обработка ошибок, связанных с вводом данных с помощью элемента управления DataGridView, в Windows Forms
Обработка ошибок из базового хранилища данных — это обязательный компонент для ввода данных приложения. Windows Forms <xref:System.Windows.Forms.DataGridView> управления упрощает этот процесс, предоставляя <xref:System.Windows.Forms.DataGridView.DataError> событие, которое возникает, когда хранилище данных обнаруживает нарушение ограничения или бизнес-правила.  
  
 В этом пошаговом руководстве, вы получите строки из `Customers` таблицы в базе данных Northwind и отобразить их в <xref:System.Windows.Forms.DataGridView> элемента управления. Когда дубликат `CustomerID` значение обнаруживается в новой строке или измененной существующей строке, <xref:System.Windows.Forms.DataGridView.DataError> произойдет событие, которое будет обработано, отображая <xref:System.Windows.Forms.MessageBox> , описывающая исключение.  
  
 Чтобы скопировать код из этого раздела единым блоком, см. раздел [Практическое руководство. Обработка ошибок, возникающих во время ввода данных в Windows Forms элемента управления DataGridView](handle-errors-that-occur-during-data-entry-in-the-datagrid.md).  
  
## <a name="prerequisites"></a>Предварительные требования  
 Для выполнения данного пошагового руководства требуется:  
  
-   Доступ к серверу с образца базы данных "Борей" SQL Server.  
  
## <a name="creating-the-form"></a>Создание формы  
  
#### <a name="to-handle-data-entry-errors-in-the-datagridview-control"></a>Обработка ошибок ввода данных в элементе управления DataGridView  
  
1. Создайте класс, производный от <xref:System.Windows.Forms.Form> и содержит <xref:System.Windows.Forms.DataGridView> управления и <xref:System.Windows.Forms.BindingSource> компонента.  
  
     В следующем примере представлена базовая реализация и включает в себя `Main` метод.  
  
     [!code-csharp[System.Windows.Forms.DataGridView.DataError#01](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.DataError/CS/errorhandling.cs#01)]
       
    [!code-csharp[System.Windows.Forms.DataGridView.DataError#02](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.DataError/CS/errorhandling.cs#02)]
      
  
2. Реализуйте метод в определении класса формы для обработки сведения о подключении к базе данных.  
  
     Данный пример кода использует `GetData` метод, возвращающий заполненный <xref:System.Data.DataTable> объекта. Убедитесь, что значение `connectionString` переменной значение, которое подходит для вашей базы данных.  
  
    > [!IMPORTANT]
    >  Хранение конфиденциальных сведений (например, пароля) в строке подключения может повлиять на безопасность приложения. Использование проверки подлинности Windows (также называемой встроенными средствами безопасности) — более безопасный способ управления доступом к базе данных. Дополнительные сведения см. в разделе [Защита сведений о подключении](../../data/adonet/protecting-connection-information.md).  
  
     [!code-csharp[System.Windows.Forms.DataGridView.DataError#30](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.DataError/CS/errorhandling.cs#30)]
       
  
3. Реализовать обработчик для формы <xref:System.Windows.Forms.Form.Load> событие, которое инициализирует <xref:System.Windows.Forms.DataGridView> и <xref:System.Windows.Forms.BindingSource> и устанавливает привязку данных.  
  
     [!code-csharp[System.Windows.Forms.DataGridView.DataError#10](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.DataError/CS/errorhandling.cs#10)]
       
  
4. Обрабатывать <xref:System.Windows.Forms.DataGridView.DataError> событий на <xref:System.Windows.Forms.DataGridView>.  
  
     Если контекст ошибки операции фиксации, отображающих значение ошибки в <xref:System.Windows.Forms.MessageBox>.  
  
     [!code-csharp[System.Windows.Forms.DataGridView.DataError#20](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.DataError/CS/errorhandling.cs#20)]
       
  
## <a name="testing-the-application"></a>Тестирование приложения  
 Теперь можно проверить форму, чтобы убедиться, что она правильно работает.  
  
#### <a name="to-test-the-form"></a>Чтобы проверить форму  
  
-   Нажмите клавишу F5 для запуска приложения.  
  
     Вы увидите <xref:System.Windows.Forms.DataGridView> заполнения элемента управления данными из таблицы Customers. При вводе повторяющимся значением для `CustomerID` и фиксации изменения, будет автоматически восстановлено значение ячейки, и вы увидите <xref:System.Windows.Forms.MessageBox> , отображающий ошибку ввода данных.  
  
## <a name="next-steps"></a>Следующие шаги  
 Это приложение позволяет базовое представление о <xref:System.Windows.Forms.DataGridView> возможности элемента управления. Можно настроить внешний вид и поведение <xref:System.Windows.Forms.DataGridView> управления несколькими способами:  
  
-   Изменение стилей границ и заголовка. Дополнительные сведения см. в разделе [Как Изменение границ и линий сетки в Windows Forms элемента управления DataGridView](change-the-border-and-gridline-styles-in-the-datagrid.md).  
  
-   Разрешить или ограничить ввод данных пользователями <xref:System.Windows.Forms.DataGridView> элемента управления. Дополнительные сведения см. в разделе [Как Запретить добавление строк и удаления в Windows Forms элемента управления DataGridView](prevent-row-addition-and-deletion-datagridview.md), и [как: Определение столбцов только для чтения в Windows Forms элемента управления DataGridView](how-to-make-columns-read-only-in-the-windows-forms-datagridview-control.md).  
  
-   Проверка пользовательского ввода для <xref:System.Windows.Forms.DataGridView> элемента управления. Дополнительные сведения см. в разделе [Пошаговое руководство: Проверка данных в Windows Forms элемента управления DataGridView](walkthrough-validating-data-in-the-windows-forms-datagridview-control.md).  
  
-   Обработка очень больших наборов данных в виртуальном режиме. Дополнительные сведения см. в разделе [Пошаговое руководство: Реализация виртуального режима в Windows Forms элемента управления DataGridView](implementing-virtual-mode-wf-datagridview-control.md).  
  
-   Настройка внешнего вида ячеек. Дополнительные сведения см. в разделе [Как Настройка внешнего вида ячеек элемента управления DataGridView в Windows Forms](customize-the-appearance-of-cells-in-the-datagrid.md) и [как: Установка стилей ячейки по умолчанию для управления DataGridView в Windows Forms](how-to-set-default-cell-styles-for-the-windows-forms-datagridview-control.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.BindingSource>
- [Ввод данных с помощью элемента управления DataGridView в Windows Forms](data-entry-in-the-windows-forms-datagridview-control.md)
- [Практическое руководство. Обработка ошибок, связанных с вводом данных с помощью элемента управления DataGridView, в Windows Forms](handle-errors-that-occur-during-data-entry-in-the-datagrid.md)
- [Пошаговое руководство. Проверка данных в элементе управления DataGridView в Windows Forms](walkthrough-validating-data-in-the-windows-forms-datagridview-control.md)
- [Защита сведений о подключении](../../data/adonet/protecting-connection-information.md)

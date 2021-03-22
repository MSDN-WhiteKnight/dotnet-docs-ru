---
title: Пошаговое руководство. Создание не связанного с данными элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- data [Windows Forms], displaying without binding to data source
- DataGridView control [Windows Forms], unbound data
- DataGridView control [Windows Forms], displaying data without binding to a data source
- data [Windows Forms], unbound
- walkthroughs [Windows Forms], DataGridView control
ms.assetid: 5a8d6afa-1b4b-4b24-8db8-501086ffdebe
ms.openlocfilehash: 99561490786f3f3569f272138001ea5ad8937410
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59343473"
---
# <a name="walkthrough-creating-an-unbound-windows-forms-datagridview-control"></a>Пошаговое руководство. Создание не связанного с данными элемента управления DataGridView в Windows Forms
Часто можно показать табличные данные, полученные не из базы данных. Например можно отображать содержимое двухмерный массив строк. <xref:System.Windows.Forms.DataGridView> Класс обеспечивает удобный и настраиваемый способ отображения данных без привязки к источнику данных. В этом пошаговом руководстве показано, как для заполнения <xref:System.Windows.Forms.DataGridView> управлять добавлением и удалением строк в режиме «свободный». По умолчанию пользователь может добавлять новые строки. Чтобы запретить добавление строк, задайте <xref:System.Windows.Forms.DataGridView.AllowUserToAddRows%2A> свойство `false`.  
  
 Чтобы скопировать код из этого раздела единым блоком, см. раздел [Практическое руководство. Создание элемента управления DataGridView в Windows свободной формы](how-to-create-an-unbound-windows-forms-datagridview-control.md).  
  
## <a name="creating-the-form"></a>Создание формы  
  
#### <a name="to-use-an-unbound-datagridview-control"></a>Чтобы использовать свободный элемент управления DataGridView  
  
1. Создайте класс, производный от <xref:System.Windows.Forms.Form> и содержит следующие объявления переменных и `Main` метод.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewSimpleUnbound#01](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewSimpleUnbound/CS/simpleunbound.cs#01)]
       
    [!code-csharp[System.Windows.Forms.DataGridViewSimpleUnbound#02](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewSimpleUnbound/CS/simpleunbound.cs#02)]
      
  
2. Реализуйте `SetupLayout` метод в определении класса формы для настройки макета.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewSimpleUnbound#20](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewSimpleUnbound/CS/simpleunbound.cs#20)]
       
  
3. Создание `SetupDataGridView` метод настройки <xref:System.Windows.Forms.DataGridView> столбцами и свойствами.  
  
     Во-первых, этот метод добавляет <xref:System.Windows.Forms.DataGridView> на форму элемент управления <xref:System.Windows.Forms.Control.Controls%2A> коллекции. Далее число столбцов для отображения задается с помощью <xref:System.Windows.Forms.DataGridView.ColumnCount%2A> свойство. Стиль по умолчанию для заголовков столбцов задается параметр <xref:System.Windows.Forms.DataGridViewCellStyle.BackColor%2A>, <xref:System.Windows.Forms.DataGridViewCellStyle.ForeColor%2A>, и <xref:System.Windows.Forms.DataGridViewCellStyle.Font%2A> свойства <xref:System.Windows.Forms.DataGridViewCellStyle> возвращаемые <xref:System.Windows.Forms.DataGridView.ColumnHeadersDefaultCellStyle%2A> свойство.  
  
     Макет и внешний вид свойств, а затем присваиваются имена столбцов. При выходе из этого метода, <xref:System.Windows.Forms.DataGridView> элемент управления готов к заполнению.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewSimpleUnbound#30](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewSimpleUnbound/CS/simpleunbound.cs#30)]
       
  
4. Создание `PopulateDataGridView` метод для добавления строк в <xref:System.Windows.Forms.DataGridView> элемента управления.  
  
     Каждая строка представляет песни и соответствующие сведения.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewSimpleUnbound#40](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewSimpleUnbound/CS/simpleunbound.cs#40)]
       
  
5. С помощью вспомогательных методов можно присоединять обработчики событий.  
  
     Будет обрабатывать **добавить** и **удалить** кнопок <xref:System.Windows.Forms.Control.Click> событий, формы <xref:System.Windows.Forms.Form.Load> событий и <xref:System.Windows.Forms.DataGridView> элемента управления <xref:System.Windows.Forms.DataGridView.CellFormatting> событий.  
  
     Когда **добавить** кнопки <xref:System.Windows.Forms.Control.Click> события новую, пустую строку добавляется <xref:System.Windows.Forms.DataGridView>.  
  
     Когда **удалить** кнопки <xref:System.Windows.Forms.Control.Click> события, выбранная строка удаляется, если это не строка для новых записей, которая позволяет пользователю добавлять новые строки. Эта строка всегда является последней строкой в <xref:System.Windows.Forms.DataGridView> элемента управления.  
  
     Когда формы <xref:System.Windows.Forms.Form.Load> события `SetupLayout`, `SetupDataGridView`, и `PopulateDataGridView` служебные методы вызываются.  
  
     Когда <xref:System.Windows.Forms.DataGridView.CellFormatting> события каждой ячейки в `Date` столбец представляется в формате даты, если значение ячейки не может быть проанализирована.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewSimpleUnbound#10](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewSimpleUnbound/CS/simpleunbound.cs#10)]
       
  
## <a name="testing-the-application"></a>Тестирование приложения  
 Теперь можно проверить форму, чтобы убедиться, что она правильно работает.  
  
#### <a name="to-test-the-form"></a>Чтобы проверить форму  
  
-   Нажмите клавишу F5 для запуска приложения.  
  
     Вы увидите <xref:System.Windows.Forms.DataGridView> элемент управления, отображающий песен, перечисленные в `PopulateDataGridView`. Можно добавить новые строки со **добавить строку** кнопку и можно удалить выбранные строки с **удалить строку** кнопки. Свободные <xref:System.Windows.Forms.DataGridView> управления хранилища данных и его данные не зависят от внешних источников, таких как <xref:System.Data.DataSet> или массив.  
  
## <a name="next-steps"></a>Следующие шаги  
 Это приложение позволяет базовое представление о <xref:System.Windows.Forms.DataGridView> возможности элемента управления. Можно настроить внешний вид и поведение <xref:System.Windows.Forms.DataGridView> управления несколькими способами:  
  
-   Изменение стилей границ и заголовка. Дополнительные сведения см. в разделе [Как Изменение границ и линий сетки в Windows Forms элемента управления DataGridView](change-the-border-and-gridline-styles-in-the-datagrid.md).  
  
-   Разрешить или ограничить ввод данных пользователями <xref:System.Windows.Forms.DataGridView> элемента управления. Дополнительные сведения см. в разделе [Как Запретить добавление строк и удаления в Windows Forms элемента управления DataGridView](prevent-row-addition-and-deletion-datagridview.md), и [как: Определение столбцов только для чтения в Windows Forms элемента управления DataGridView](how-to-make-columns-read-only-in-the-windows-forms-datagridview-control.md).  
  
-   Проверьте входные данные пользователя для ошибки, относящиеся к базе данных. Дополнительные сведения см. в разделе [Пошаговое руководство: Обработка ошибок, возникающих во время ввода данных в Windows Forms элемента управления DataGridView](handling-errors-that-occur-during-data-entry-in-the-datagrid.md).  
  
-   Обработка очень больших наборов данных в виртуальном режиме. Дополнительные сведения см. в разделе [Пошаговое руководство: Реализация виртуального режима в Windows Forms элемента управления DataGridView](implementing-virtual-mode-wf-datagridview-control.md).  
  
-   Настройка внешнего вида ячеек. Дополнительные сведения см. в разделе [Как Настройка внешнего вида ячеек элемента управления DataGridView в Windows Forms](customize-the-appearance-of-cells-in-the-datagrid.md) и [как: Установка стилей ячейки по умолчанию для управления DataGridView в Windows Forms](how-to-set-default-cell-styles-for-the-windows-forms-datagridview-control.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- [Отображение данных с помощью элемента управления DataGridView в Windows Forms](displaying-data-in-the-windows-forms-datagridview-control.md)
- [Практическое руководство. Создание не связанного с данными элемента управления DataGridView в Windows Forms](how-to-create-an-unbound-windows-forms-datagridview-control.md)
- [Режимы отображения данных в элементе управления DataGridView в Windows Forms](data-display-modes-in-the-windows-forms-datagridview-control.md)

---
title: Пошаговое руководство. Создание формы «основной-подробности» с помощью двух элементов управления DataGridView Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- DataGridView control [Windows Forms], master/detail form
- parent-child tables [Windows Forms], displaying on Windows Forms
- master-details lists [Windows Forms], displaying on Windows Forms
- walkthroughs [Windows Forms], DataGridView control
ms.assetid: c5fa29e8-47f7-4691-829b-0e697a691f36
ms.openlocfilehash: a887dacfcb83b4b6ea4cb2690ab09b0d1b20b4fa
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59295800"
---
# <a name="walkthrough-creating-a-masterdetail-form-using-two-windows-forms-datagridview-controls"></a>Пошаговое руководство. Создание главного и подчиненного представлений данных с использованием двух элементов управления DataGridView в Windows Forms
Один из наиболее распространенных сценариев использования <xref:System.Windows.Forms.DataGridView> элемент управления является *"основной/подробности"* формы, в котором отображается отношение "родители потомки" между двумя таблицами базы данных. Выбор строк в главной таблице приводит детализации таблицы с помощью соответствующих дочерних данных.  
  
 Реализация формы «основной/подробности» легко реализовать с помощью взаимодействие между <xref:System.Windows.Forms.DataGridView> управления и <xref:System.Windows.Forms.BindingSource> компонента. В этом пошаговом руководстве вы создадите формы, с использованием двух <xref:System.Windows.Forms.DataGridView> элементов управления и два <xref:System.Windows.Forms.BindingSource> компонентов. В форме будут показаны два связанных таблиц в базе данных "Борей" SQL Server: `Customers` и `Orders`. Когда вы закончите, будет иметь форму, которая показывает всех клиентов в базе данных в базу данных master <xref:System.Windows.Forms.DataGridView> и все заказы для выбранного клиента подробно <xref:System.Windows.Forms.DataGridView>.  
  
 Чтобы скопировать код из этого раздела единым блоком, см. раздел [Практическое руководство. Создание формы «основной/подробности» с помощью двух элементов управления DataGridView Windows Forms](create-a-master-detail-form-using-two-datagridviews.md).  
  
## <a name="prerequisites"></a>Предварительные требования  
 Для выполнения данного пошагового руководства требуется:  
  
-   Доступ к серверу с образца базы данных "Борей" SQL Server.  
  
## <a name="creating-the-form"></a>Создание формы  
  
#### <a name="to-create-a-masterdetail-form"></a>Для создания формы «основной/подробности»  
  
1. Создайте класс, производный от <xref:System.Windows.Forms.Form> и содержит два <xref:System.Windows.Forms.DataGridView> элементов управления и два <xref:System.Windows.Forms.BindingSource> компонентов. Ниже представлена базовая реализация формы и включает в себя `Main` метод. При использовании в конструкторе Visual Studio для создания формы, то можно использовать созданный код конструктора вместо этого кода, обязательно используйте имена, показанные в объявлениях переменных.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewMasterDetails#01](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMasterDetails/CS/masterdetails.cs#01)]
     [!code-vb[System.Windows.Forms.DataGridViewMasterDetails#01](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMasterDetails/VB/masterdetails.vb#01)]  
    [!code-csharp[System.Windows.Forms.DataGridViewMasterDetails#02](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMasterDetails/CS/masterdetails.cs#02)]
    [!code-vb[System.Windows.Forms.DataGridViewMasterDetails#02](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMasterDetails/VB/masterdetails.vb#02)]  
  
2. Реализуйте метод в определении класса формы для обработки подробные сведения о подключении к базе данных. В этом примере используется `GetData` метод, который заполняет <xref:System.Data.DataSet> , добавляет <xref:System.Data.DataRelation> объект набора данных и привязывает <xref:System.Windows.Forms.BindingSource> компонентов. Убедитесь, что переменной `connectionString` присвоено значение, соответствующее базе данных.  
  
    > [!IMPORTANT]
    >  Хранение конфиденциальных сведений (например, пароля) в строке подключения может повлиять на безопасность приложения. Использование проверки подлинности Windows (также называемой встроенными средствами безопасности) — более безопасный способ управления доступом к базе данных. Дополнительные сведения см. в разделе [Защита сведений о подключении](../../data/adonet/protecting-connection-information.md).  
  
     [!code-csharp[System.Windows.Forms.DataGridViewMasterDetails#20](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMasterDetails/CS/masterdetails.cs#20)]
     [!code-vb[System.Windows.Forms.DataGridViewMasterDetails#20](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMasterDetails/VB/masterdetails.vb#20)]  
  
3. Реализовать обработчик для формы <xref:System.Windows.Forms.Form.Load> событие, которое привязывает <xref:System.Windows.Forms.DataGridView> элементы управления <xref:System.Windows.Forms.BindingSource> компоненты и вызывает метод `GetData` метод. Следующий пример содержит код, который изменяет размер <xref:System.Windows.Forms.DataGridView> столбцы в соответствии с отображаемых данных.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewMasterDetails#10](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMasterDetails/CS/masterdetails.cs#10)]
     [!code-vb[System.Windows.Forms.DataGridViewMasterDetails#10](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMasterDetails/VB/masterdetails.vb#10)]  
  
## <a name="testing-the-application"></a>Тестирование приложения  
 Теперь можно проверить форму, чтобы убедиться, что она правильно работает.  
  
#### <a name="to-test-the-form"></a>Чтобы проверить форму  
  
-   Скомпилируйте и запустите приложение.  
  
     Вы увидите два <xref:System.Windows.Forms.DataGridView> элементы управления, друг с другом. В верхней части — это клиенты из базы данных Northwind `Customers` таблицы, а внизу находятся `Orders` соответствующий выбранному клиенту. При выборе различные строки в верхнем <xref:System.Windows.Forms.DataGridView>, содержимое нижнего <xref:System.Windows.Forms.DataGridView> соответствующим образом изменить.  
  
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
- [Отображение данных с помощью элемента управления DataGridView в Windows Forms](displaying-data-in-the-windows-forms-datagridview-control.md)
- [Практическое руководство. Создание главного и подчиненного представлений данных с использованием двух элементов управления DataGridView в Windows Forms](create-a-master-detail-form-using-two-datagridviews.md)
- [Защита сведений о подключении](../../data/adonet/protecting-connection-information.md)

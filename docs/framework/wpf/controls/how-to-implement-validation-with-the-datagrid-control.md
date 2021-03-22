---
title: Практическое руководство. Реализация проверки с помощью элемента управления DataGrid
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- DataGrid [WPF], validation
- validation [WPF], DataGrid
ms.assetid: ec6078a8-1e42-4648-b414-f4348e81bda1
ms.openlocfilehash: 00d09c62aae67e3438816409c95ccf96050b3206
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59305961"
---
# <a name="how-to-implement-validation-with-the-datagrid-control"></a>Практическое руководство. Реализация проверки с помощью элемента управления DataGrid
<xref:System.Windows.Controls.DataGrid> Элемент управления позволяет выполнять проверку на уровне строк и ячеек. Когда пользователь обновляет значение проверки на уровне ячейки проверяются отдельные свойства объекта привязки данных. Когда пользователь вносит изменения в строку проверки на уровне строк проверяются целые объекты данных. Также можно реализовать визуальную реакцию на ошибки проверки или использовать визуальную обратную связь по умолчанию, <xref:System.Windows.Controls.DataGrid> предоставляет элемент управления.  
  
 Следующие процедуры описывают способы применения правил проверки к <xref:System.Windows.Controls.DataGrid> привязки и настраивать визуальную обратную связь.  
  
### <a name="to-validate-individual-cell-values"></a>Чтобы проверить значения отдельных ячеек  
  
-   Укажите одно или несколько правил проверки для привязки, используемой со столбцом. Это аналогично проверке данных в простые элементы управления, как описано в разделе [Общие сведения о привязке данных](../data/data-binding-overview.md).  
  
     В следующем примере показан <xref:System.Windows.Controls.DataGrid> элемента управления с четырьмя столбцами, которые привязаны к различным свойствам бизнес-объекта. Укажите трех столбцов <xref:System.Windows.Controls.ExceptionValidationRule> , задав <xref:System.Windows.Data.Binding.ValidatesOnExceptions%2A> свойства `true`.  
  
     [!code-xaml[DataGrid_Validation#BasicXaml](~/samples/snippets/csharp/VS_Snippets_Wpf/datagrid_validation/cs/window1.xaml#basicxaml)]  
  
     Когда пользователь вводит недопустимое значение (например, отличный от integer в столбце идентификатор курса), появится красная граница вокруг ячейки. Вы можете изменить эти отзывы проверки по умолчанию, как описано в следующей процедуре.  
  
### <a name="to-customize-cell-validation-feedback"></a>Настройка сигнала о проверке ячейки  
  
-   Значение столбца <xref:System.Windows.Controls.DataGridBoundColumn.EditingElementStyle%2A> свойство на стиль, соответствующий столбец редактирования элемента управления. Так как элементы управления создаются во время выполнения, нельзя использовать <xref:System.Windows.Controls.Validation.ErrorTemplate%2A?displayProperty=nameWithType> присоединенного свойства, как с помощью простых элементов управления.  
  
     В следующем примере обновляется предыдущего примера, добавив стиля ошибки, применяемое для трех столбцов с помощью правил проверки. Когда пользователь вводит недопустимое значение, стиль изменяет цвет фона ячейки и добавляет всплывающей подсказки. Обратите внимание на использование триггера, чтобы определить, имеется ли ошибка проверки. Это необходимо, поскольку в настоящее время отсутствует специальный шаблон ошибок для ячеек.  
  
     [!code-xaml[DataGrid_Validation#CellValidationXaml](~/samples/snippets/csharp/VS_Snippets_Wpf/datagrid_validation/cs/mainwindow.xaml#cellvalidationxaml)]  
  
     Можно реализовать дополнительную настройку, заменив <xref:System.Windows.Controls.DataGridColumn.CellStyle%2A> используемый столбцом.  
  
### <a name="to-validate-multiple-values-in-a-single-row"></a>Для проверки нескольких значений в одной строке  
  
1. Реализуйте <xref:System.Windows.Controls.ValidationRule> подкласса, который проверяет несколько свойств объекта привязки данных. В вашей <xref:System.Windows.Controls.ValidationRule.Validate%2A> привести реализацию метода `value` значение параметра для <xref:System.Windows.Data.BindingGroup> экземпляра. Вы можете обращаться к объекту данных, используя <xref:System.Windows.Data.BindingGroup.Items%2A> свойство.  
  
     В следующем примере демонстрируется этот процесс проверки ли `StartDate` значение свойства для `Course` объекта более ранняя, чем его `EndDate` значение свойства.  
  
     [!code-csharp[DataGrid_Validation#CourseValidationRule](~/samples/snippets/csharp/VS_Snippets_Wpf/datagrid_validation/cs/mainwindow.xaml.cs#coursevalidationrule)]
       
  
2. Добавить правило проверки к <xref:System.Windows.Controls.DataGrid.RowValidationRules%2A?displayProperty=nameWithType> коллекции. <xref:System.Windows.Controls.DataGrid.RowValidationRules%2A> Свойство обеспечивает прямой доступ к <xref:System.Windows.Data.BindingGroup.ValidationRules%2A> свойство <xref:System.Windows.Data.BindingGroup> экземпляр, который группирует все привязки, используемые элементом управления.  
  
     В следующем примере задается <xref:System.Windows.Controls.DataGrid.RowValidationRules%2A> свойства в XAML. <xref:System.Windows.Controls.ValidationRule.ValidationStep%2A> Свойству <xref:System.Windows.Controls.ValidationStep.UpdatedValue> таким образом, чтобы проверка осуществляется только после обновления объект привязанных данных.  
  
     [!code-xaml[DataGrid_Validation#RowValidationRulesXaml](~/samples/snippets/csharp/VS_Snippets_Wpf/datagrid_validation/cs/mainwindow.xaml#rowvalidationrulesxaml)]  
  
     Когда пользователь указывает дату окончания, более ранняя, чем дата начала, в заголовке строки появляется красный восклицательный знак (!). Вы можете изменить эти отзывы проверки по умолчанию, как описано в следующей процедуре.  
  
### <a name="to-customize-row-validation-feedback"></a>Настройка сигнала о проверке строки  
  
-   Задайте свойство <xref:System.Windows.Controls.DataGrid.RowValidationErrorTemplate%2A?displayProperty=nameWithType>. Это свойство позволяет настраивать сигнала о проверке строки для отдельных <xref:System.Windows.Controls.DataGrid> элементов управления. Могут также влиять на несколько элементов управления с помощью неявный стиль строки для установки <xref:System.Windows.Controls.DataGridRow.ValidationErrorTemplate%2A?displayProperty=nameWithType> свойство.  
  
     В следующем примере заменяется сигнала о проверке строки по умолчанию с более заметный индикатор. Когда пользователь вводит недопустимое значение, красный круг с белым восклицательным знаком отображается в заголовке строки. Эта операция выполняется для ошибок проверки строк и ячеек. Сообщение об ошибке отображается во всплывающей подсказке.  
  
     [!code-xaml[DataGrid_Validation#RowValidationFeedbackXaml](~/samples/snippets/csharp/VS_Snippets_Wpf/datagrid_validation/cs/mainwindow.xaml#rowvalidationfeedbackxaml)]  
  
## <a name="example"></a>Пример  
 Следующий пример приводится полная демонстрация проверки ячеек и строк. `Course` Класс предоставляет образец данных объект, реализующий <xref:System.ComponentModel.IEditableObject> для поддержки транзакций. <xref:System.Windows.Controls.DataGrid> Элемент управления взаимодействует с <xref:System.ComponentModel.IEditableObject> чтобы пользователи могли отменить изменения, нажав клавишу ESC.  
  
> [!NOTE]
>  Если вы используете Visual Basic, в первой строке файла MainWindow.XAML, замените `x:Class="DataGridValidation.MainWindow"` с `x:Class="MainWindow"`.  
  
 Чтобы протестировать проверку, попробуйте сделайте следующее:  
  
-   В столбце идентификатор курса введите значение отличный от integer.  
  
-   В столбце даты окончания введите дату, более ранняя, чем дата начала.  
  
-   Удаление значения в идентификатор курса, Дата начала или дата окончания.  
  
-   Чтобы отменить недопустимое значение для ячейки, поместите курсор в ячейку и нажмите клавишу ESC.  
  
-   Чтобы отменить изменения для всей строки, когда текущая ячейка находится в режиме редактирования, дважды нажмите клавишу ESC.  
  
-   При возникновении ошибки проверки, наведите указатель мыши на индикатор в заголовке строки, чтобы просмотреть сообщение об ошибке.  
  
 [!code-csharp[DataGrid_Validation#FullCode](~/samples/snippets/csharp/VS_Snippets_Wpf/datagrid_validation/cs/mainwindow.xaml.cs#fullcode)]
   
  
 [!code-xaml[DataGrid_Validation#FullXaml](~/samples/snippets/csharp/VS_Snippets_Wpf/datagrid_validation/cs/mainwindow.xaml#fullxaml)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.DataGrid>
- [DataGrid](datagrid.md)
- [Привязка данных](../data/data-binding-wpf.md)
- [Реализация проверки привязки](../data/how-to-implement-binding-validation.md)
- [Реализация логики проверки для пользовательских объектов](../data/how-to-implement-validation-logic-on-custom-objects.md)

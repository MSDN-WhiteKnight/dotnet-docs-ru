---
title: Практическое руководство. Проверки входных данных с помощью элемента управления DataGrid в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- DataGrid control [Windows Forms], examples
- user input [Windows Forms], validating
- examples [Windows Forms], DataGrid control
- DataGrid control [Windows Forms], validating input
- validation [Windows Forms], user input
ms.assetid: f1e9c3a0-d0a1-4893-a615-b4b0db046c63
ms.openlocfilehash: dc8c8f157e6673c1bddc68bfb511683e6d2b99be
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57720336"
---
# <a name="how-to-validate-input-with-the-windows-forms-datagrid-control"></a>Практическое руководство. Проверки входных данных с помощью элемента управления DataGrid в Windows Forms

> [!NOTE]
> Элемент управления <xref:System.Windows.Forms.DataGridView> заменяет элемент управления <xref:System.Windows.Forms.DataGrid> и расширяет его функциональные возможности; однако при необходимости элемент управления <xref:System.Windows.Forms.DataGrid> можно сохранить для обратной совместимости и использования в будущем. Дополнительные сведения см. в разделе [Различия элементов управления DataGridView и DataGrid в Windows Forms](differences-between-the-windows-forms-datagridview-and-datagrid-controls.md).

Существует два типа проверки входных данных, доступных для Windows Forms <xref:System.Windows.Forms.DataGrid> элемента управления. Если пользователь пытается получить введите значение, которое относится к типу данных неприемлемой для ячейки, например, строку в целое число, новое неправильное значение заменяется старое значение. Такого рода проверку входных данных выполняется автоматически и не могут быть изменены.

Проверки входных данных другого типа может использоваться для отклонения любых недопустимых значений, например 0 значение в поле, которое должно быть больше или равно 1, либо неподходящей строки. Это делается в наборе данных, написав обработчик событий для <xref:System.Data.DataTable.ColumnChanging> или <xref:System.Data.DataTable.RowChanging> событий. В примере ниже используется <xref:System.Data.DataTable.ColumnChanging> события так, как недопустимые значения запрещены для столбца «Продукт» в частности. Можно использовать <xref:System.Data.DataTable.RowChanging> событие для проверки, что значение столбца «Дата окончания» более поздней, чем столбец «Дата начала» в той же строке.

## <a name="to-validate-user-input"></a>Проверка вводимых пользователем данных

1. Написание кода для обработки <xref:System.Data.DataTable.ColumnChanging> событий для соответствующей таблицы. При обнаружении несоответствия вводимых данных, вызвать <xref:System.Data.DataRow.SetColumnError%2A> метод <xref:System.Data.DataRow> объекта.

    ```vb
    Private Sub Customers_ColumnChanging(ByVal sender As Object, _
    ByVal e As System.Data.DataColumnChangeEventArgs)
       ' Only check for errors in the Product column
       If (e.Column.ColumnName.Equals("Product")) Then
          ' Do not allow "Automobile" as a product.
          If CType(e.ProposedValue, String) = "Automobile" Then
             Dim badValue As Object = e.ProposedValue
             e.ProposedValue = "Bad Data"
             e.Row.RowError = "The Product column contains an error"
             e.Row.SetColumnError(e.Column, "Product cannot be " & _
             CType(badValue, String))
          End If
       End If
    End Sub
    ```

    ```csharp
    //Handle column changing events on the Customers table
    private void Customers_ColumnChanging(object sender, System.Data.DataColumnChangeEventArgs e) {

       //Only check for errors in the Product column
       if (e.Column.ColumnName.Equals("Product")) {

          //Do not allow "Automobile" as a product
          if (e.ProposedValue.Equals("Automobile")) {
             object badValue = e.ProposedValue;
             e.ProposedValue = "Bad Data";
             e.Row.RowError = "The Product column contains an error";
             e.Row.SetColumnError(e.Column, "Product cannot be " + badValue);
          }
       }
    }
    ```

2. Подключите обработчик событий к событию.

    Поместите следующий код либо в формы <xref:System.Windows.Forms.Form.Load> события или его конструктор.

    ```vb
    ' Assumes the grid is bound to a dataset called customersDataSet1
    ' with a table called Customers.
    ' Put this code in the form's Load event or its constructor.
    AddHandler customersDataSet1.Tables("Customers").ColumnChanging, AddressOf Customers_ColumnChanging
    ```

    ```csharp
    // Assumes the grid is bound to a dataset called customersDataSet1
    // with a table called Customers.
    // Put this code in the form's Load event or its constructor.
    customersDataSet1.Tables["Customers"].ColumnChanging += new DataColumnChangeEventHandler(this.Customers_ColumnChanging);
    ```

## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGrid>
- <xref:System.Data.DataTable.ColumnChanging>
- <xref:System.Data.DataRow.SetColumnError%2A>
- [Элемент управления DataGrid](datagrid-control-windows-forms.md)

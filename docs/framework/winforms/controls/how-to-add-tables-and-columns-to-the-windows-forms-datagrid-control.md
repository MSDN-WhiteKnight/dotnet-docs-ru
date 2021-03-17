---
title: Практическое руководство. Добавление таблиц и столбцов в элемент управления DataGrid в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- columns [Windows Forms], adding to DataGrid control
- tables [Windows Forms], adding to DataGrid control
- DataGrid control [Windows Forms], adding tables and columns
ms.assetid: 2fe661b9-aa06-49b9-a314-a0d3cbfdcb4d
ms.openlocfilehash: cc364f3609f8041378b0b03b8e1bc8f312fade18
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59319915"
---
# <a name="how-to-add-tables-and-columns-to-the-windows-forms-datagrid-control"></a>Практическое руководство. Добавление таблиц и столбцов в элемент управления DataGrid в Windows Forms
> [!NOTE]
>  Элемент управления <xref:System.Windows.Forms.DataGridView> заменяет элемент управления <xref:System.Windows.Forms.DataGrid> и расширяет его функциональные возможности; однако при необходимости элемент управления <xref:System.Windows.Forms.DataGrid> можно сохранить для обратной совместимости и использования в будущем. Дополнительные сведения см. в разделе [Различия элементов управления DataGridView и DataGrid в Windows Forms](differences-between-the-windows-forms-datagridview-and-datagrid-controls.md).  
  
 Можно отобразить данные в Windows Forms <xref:System.Windows.Forms.DataGrid> элемента управления в таблицах и столбцах, создав **DataGridTableStyle** объектов и добавления их в **GridTableStylesCollection** объект, являющийся получить доступ через <xref:System.Windows.Forms.DataGrid> элемента управления **TableStyles** свойство. Каждая таблица отображает содержимое таблицы данных указывается в **DataGridTableStyle** объекта **MappingName** свойство. По умолчанию стиля таблицы стили столбцов, не указано, отображается все столбцы этой таблицы данных. Можно ограничить, какие столбцы из таблицы должны отображаться, добавив **DataGridColumnStyle** объектов **GridColumnStylesCollection** объекта, доступном через  **GridColumnStyles** свойства каждого **DataGridTableStyle** объекта.  
  
### <a name="to-add-a-table-and-column-to-a-datagrid-programmatically"></a>Добавление таблиц и столбцов в элемент управления DataGrid программными средствами  
  
1. Для отображения данных в таблице, необходимо сначала привязать <xref:System.Windows.Forms.DataGrid> элемента управления к набору данных. Дополнительные сведения см. в разделе [Как Привязка элемента управления DataGrid в Windows Forms к источнику данных](how-to-bind-the-windows-forms-datagrid-control-to-a-data-source.md).  
  
    > [!CAUTION]
    >  Указывая программно стили столбцов, всегда создавайте **DataGridColumnStyle** объектов и добавить их к **GridColumnStylesCollection** объект перед добавлением  **Styl DataGridTableStyle** объектов **GridTableStylesCollection** объекта. При добавлении пустого **DataGridTableStyle** в коллекцию **DataGridColumnStyle** объекты создаются автоматически для вас. Следовательно, будет создано исключение при попытке добавить новый **DataGridColumnStyle** объекты с повторяющимися **MappingName** значения **GridColumnStylesCollection**объекта.  
  
2. Объявите новый стиль таблицы и присвойте ему имя сопоставления.  
  
    ```vb  
    Dim ts1 As New DataGridTableStyle()  
    ts1.MappingName = "Customers"  
    ```  
  
    ```csharp  
    DataGridTableStyle ts1 = new DataGridTableStyle();  
    ts1.MappingName = "Customers";  
    ```  
  
    ```cpp  
    DataGridTableStyle* ts1 = new DataGridTableStyle();  
    ts1->MappingName = S"Customers";  
    ```  
  
3. Объявите новый стиль столбца и задайте его имя сопоставления и другие свойства.  
  
    ```vb  
    Dim myDataCol As New DataGridBoolColumn()  
    myDataCol.HeaderText = "My New Column"  
    myDataCol.MappingName = "Current"  
    ```  
  
    ```csharp  
    DataGridBoolColumn myDataCol = new DataGridBoolColumn();  
    myDataCol.HeaderText = "My New Column";  
    myDataCol.MappingName = "Current";  
    ```  
  
    ```cpp  
    DataGridBoolColumn^ myDataCol = gcnew DataGridBoolColumn();  
    myDataCol->HeaderText = "My New Column";  
    myDataCol->MappingName = "Current";  
    ```  
  
4. Вызовите **добавить** метод **GridColumnStylesCollection** объект для добавления столбца стиль таблицы  
  
    ```vb  
    ts1.GridColumnStyles.Add(myDataCol)  
    ```  
  
    ```csharp  
    ts1.GridColumnStyles.Add(myDataCol);  
    ```  
  
    ```cpp  
    ts1->GridColumnStyles->Add(myDataCol);  
    ```  
  
5. Вызовите **добавить** метод **GridTableStylesCollection** объект добавляемый стиль таблицы в сетке данных.  
  
    ```vb  
    DataGrid1.TableStyles.Add(ts1)  
    ```  
  
    ```csharp  
    dataGrid1.TableStyles.Add(ts1);  
    ```  
  
    ```cpp  
    dataGrid1->TableStyles->Add(ts1);  
    ```  
  
## <a name="see-also"></a>См. также

- [Элемент управления DataGrid](datagrid-control-windows-forms.md)
- [Практическое руководство. Удаление или скрытие столбцов элемента управления DataGrid в Windows Forms](how-to-delete-or-hide-columns-in-the-windows-forms-datagrid-control.md)

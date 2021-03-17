---
title: Практическое руководство. Удаление или скрытие столбцов элемента управления DataGrid в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- data grids [Windows Forms], deleting columns
- DataGrid control [Windows Forms], deleting columns
- data grids [Windows Forms], hiding columns
- columns [Windows Forms], hiding
- columns [Windows Forms], deleting in data grids
- DataGrid control [Windows Forms], hiding columns
ms.assetid: bcd0dd96-6687-4c48-b0e1-d5287b93ac91
ms.openlocfilehash: d3f1f013cbb5e41c997014f556602b01bab62914
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59297516"
---
# <a name="how-to-delete-or-hide-columns-in-the-windows-forms-datagrid-control"></a>Практическое руководство. Удаление или скрытие столбцов элемента управления DataGrid в Windows Forms
> [!NOTE]
>  Элемент управления <xref:System.Windows.Forms.DataGridView> заменяет элемент управления <xref:System.Windows.Forms.DataGrid> и расширяет его функциональные возможности; однако при необходимости элемент управления <xref:System.Windows.Forms.DataGrid> можно сохранить для обратной совместимости и использования в будущем. Дополнительные сведения см. в разделе [Различия элементов управления DataGridView и DataGrid в Windows Forms](differences-between-the-windows-forms-datagridview-and-datagrid-controls.md).  
  
 Можно программно удалить или скрыть столбцы в Windows Forms <xref:System.Windows.Forms.DataGrid> элемента управления с помощью свойств и методов <xref:System.Windows.Forms.GridColumnStylesCollection> и <xref:System.Windows.Forms.DataGridColumnStyle> объектов (которые являются членами <xref:System.Windows.Forms.DataGridTableStyle> класса).  
  
 Удаленные или скрытые столбцы по-прежнему существуют в источнике данных привязывается к сетке и по-прежнему может осуществляться программными средствами. Они просто больше не отображается в элементе управления datagrid.  
  
> [!NOTE]
>  Если приложение не осуществляет доступ к определенным столбцам данных, и нежелательно, чтобы они отображались в сетке данных, то это скорее всего, не обязательно включать их в источнике данных, в первую очередь.  
  
### <a name="to-delete-a-column-from-the-datagrid-programmatically"></a>Чтобы программно удалить столбец из элемента управления DataGrid  
  
1. В области объявлений формы объявить новый экземпляр класса <xref:System.Windows.Forms.DataGridTableStyle> класса.  
  
2. Задайте <xref:System.Windows.Forms.DataGridTableStyle.MappingName%2A?displayProperty=nameWithType> свойство к таблице в источнике данных, который вы хотите применить стиль. В следующем примере используется <xref:System.Windows.Forms.DataGrid.DataMember%2A?displayProperty=nameWithType> свойство, которое предполагается, что уже задан.  
  
3. Добавьте новые <xref:System.Windows.Forms.DataGridTableStyle> объект в коллекцию стилей таблиц элемента управления datagrid.  
  
4. Вызовите <xref:System.Windows.Forms.GridColumnStylesCollection.RemoveAt%2A> метод <xref:System.Windows.Forms.DataGrid>в <xref:System.Windows.Forms.DataGridTableStyle.GridColumnStyles%2A> коллекции, указав индекс столбца для удаления.  
  
    ```vb  
    ' Declare a new DataGridTableStyle in the  
    ' declarations area of your form.  
    Dim ts As DataGridTableStyle = New DataGridTableStyle()  
  
    Sub DeleteColumn()  
       ' Set the DataGridTableStyle.MappingName property  
       ' to the table in the data source to map to.  
       ts.MappingName = DataGrid1.DataMember  
  
       ' Add it to the datagrid's TableStyles collection  
       DataGrid1.TableStyles.Add(ts)  
  
       ' Delete the first column (index 0)  
       DataGrid1.TableStyles(0).GridColumnStyles.RemoveAt(0)  
    End Sub  
    ```  
  
    ```csharp  
    // Declare a new DataGridTableStyle in the  
    // declarations area of your form.  
    DataGridTableStyle ts = new DataGridTableStyle();  
  
    private void deleteColumn()  
    {  
       // Set the DataGridTableStyle.MappingName property  
       // to the table in the data source to map to.  
       ts.MappingName = dataGrid1.DataMember;  
  
       // Add it to the datagrid's TableStyles collection  
       dataGrid1.TableStyles.Add(ts);  
  
       // Delete the first column (index 0)  
       dataGrid1.TableStyles[0].GridColumnStyles.RemoveAt(0);  
    }  
    ```  
  
### <a name="to-hide-a-column-in-the-datagrid-programmatically"></a>Чтобы скрыть столбец в сетке данных программными средствами  
  
1. В области объявлений формы объявить новый экземпляр класса <xref:System.Windows.Forms.DataGridTableStyle> класса.  
  
2. Задайте <xref:System.Windows.Forms.DataGridTableStyle.MappingName%2A> свойство <xref:System.Windows.Forms.DataGridTableStyle> в таблицу в источнике данных, который вы хотите применить стиль. В следующем примере кода используется <xref:System.Windows.Forms.DataGrid.DataMember%2A?displayProperty=nameWithType> свойство, которое предполагается, что уже задан.  
  
3. Добавьте новые <xref:System.Windows.Forms.DataGridTableStyle> объект в коллекцию стилей таблиц элемента управления datagrid.  
  
4. Скрыть столбец, задав его `Width` значение 0, указывающее индекс столбца для столбца.  
  
    ```vb  
    ' Declare a new DataGridTableStyle in the  
    ' declarations area of your form.  
    Dim ts As DataGridTableStyle = New DataGridTableStyle()  
  
    Sub HideColumn()  
       ' Set the DataGridTableStyle.MappingName property  
       ' to the table in the data source to map to.  
       ts.MappingName = DataGrid1.DataMember  
  
       ' Add it to the datagrid's TableStyles collection  
       DataGrid1.TableStyles.Add(ts)  
  
       ' Hide the first column (index 0)  
       DataGrid1.TableStyles(0).GridColumnStyles(0).Width = 0  
    End Sub  
    ```  
  
    ```csharp  
    // Declare a new DataGridTableStyle in the  
    // declarations area of your form.  
    DataGridTableStyle ts = new DataGridTableStyle();  
  
    private void hideColumn()  
    {  
       // Set the DataGridTableStyle.MappingName property  
       // to the table in the data source to map to.  
       ts.MappingName = dataGrid1.DataMember;  
  
       // Add it to the datagrid's TableStyles collection  
       dataGrid1.TableStyles.Add(ts);  
  
       // Hide the first column (index 0)  
       dataGrid1.TableStyles[0].GridColumnStyles[0].Width = 0;  
    }  
    ```  
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Изменение данных, отображаемых во время выполнения, в элементе управления DataGrid в Windows Forms](change-displayed-data-at-run-time-wf-datagrid-control.md)
- [Практическое руководство. Добавление таблиц и столбцов в элемент управления DataGrid в Windows Forms](how-to-add-tables-and-columns-to-the-windows-forms-datagrid-control.md)

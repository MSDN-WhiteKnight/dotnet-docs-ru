---
title: Практическое руководство. Создание списков «основной-подробности» с помощью элемента управления DataGrid в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- master-details lists
- DataGrid control [Windows Forms], master-details lists
- related tables [Windows Forms], displaying in DataGrid control
ms.assetid: 20388c6a-94f9-4d96-be18-8c200491247f
ms.openlocfilehash: 92b4a7d9513ce0ec9b7c02f57c23fa4267fb26ad
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59302417"
---
# <a name="how-to-create-masterdetail-lists-with-the-windows-forms-datagrid-control"></a>Практическое руководство. Создание основных или подробных списков с помощью элемента управления DataGrid в Windows Forms
> [!NOTE]
>  Элемент управления <xref:System.Windows.Forms.DataGridView> заменяет элемент управления <xref:System.Windows.Forms.DataGrid> и расширяет его функциональные возможности; однако при необходимости элемент управления <xref:System.Windows.Forms.DataGrid> можно сохранить для обратной совместимости и использования в будущем. Дополнительные сведения см. в разделе [Различия элементов управления DataGridView и DataGrid в Windows Forms](differences-between-the-windows-forms-datagridview-and-datagrid-controls.md).  
  
 Если ваш <xref:System.Data.DataSet> содержит ряд связанных таблиц, можно использовать два <xref:System.Windows.Forms.DataGrid> элементы управления для отображения данных в формате "основной/подробности". Один <xref:System.Windows.Forms.DataGrid> назначен в качестве основной сеткой, а второй для сетки сведений. При выборе записи в главном списке все связанные дочерние записи отображаются в списке сведений. Например если ваш <xref:System.Data.DataSet> содержит таблицу "Клиенты" и связанную таблицу Orders, нужно указать таблицы клиентов на основной сетки и таблицу Orders, чтобы быть в таблице сведений. При выборе клиента в основной сетке все заказы, связанные с клиентом в таблице Orders будет отображаться в таблице сведений.  
  
### <a name="to-set-a-masterdetail-relationship-programmatically"></a>Чтобы установить отношение «основной/подробности» программными средствами  
  
1. Создайте два новых <xref:System.Windows.Forms.DataGrid> элементы управления и задавать их свойства.  
  
2. Добавление таблиц в наборе данных.  
  
3. Объявите переменную типа <xref:System.Data.DataRelation> для представления связи, вы хотите создать.  
  
4. Создайте экземпляр связи, указав имя для связи и указав таблицу, столбец и элемент, который будет связывать две таблицы.  
  
5. Добавить связь с <xref:System.Data.DataSet> объекта <xref:System.Data.DataSet.Relations%2A> коллекции.  
  
6. Используйте <xref:System.Windows.Forms.DataGrid.SetDataBinding%2A> метод <xref:System.Windows.Forms.DataGrid> для каждой сетки для привязки <xref:System.Data.DataSet>.  
  
     В следующем примере демонстрируется задание отношение «основной/подробности» между таблицами Customers и Orders в ранее созданный <xref:System.Data.DataSet> (`ds`).  
  
    ```vb  
    Dim myDataRelation As DataRelation  
    myDataRelation = New DataRelation _  
       ("CustOrd", ds.Tables("Customers").Columns("CustomerID"), _  
       ds.Tables("Orders").Columns("CustomerID"))  
    ' Add the relation to the DataSet.  
    ds.Relations.Add(myDataRelation)  
    GridOrders.SetDataBinding(ds, "Customers")  
    GridDetails.SetDataBinding(ds, "Customers.CustOrd")  
    ```  
  
    ```csharp  
    DataRelation myDataRelation;  
    myDataRelation = new DataRelation("CustOrd", ds.Tables["Customers"].Columns["CustomerID"], ds.Tables["Orders"].Columns["CustomerID"]);  
    // Add the relation to the DataSet.  
    ds.Relations.Add(myDataRelation);  
    GridOrders.SetDataBinding(ds,"Customers");  
    GridDetails.SetDataBinding(ds,"Customers.CustOrd");  
    ```  
  
    ```cpp  
    DataRelation^ myDataRelation;  
    myDataRelation = gcnew DataRelation("CustOrd",  
       ds->Tables["Customers"]->Columns["CustomerID"],  
       ds->Tables["Orders"]->Columns["CustomerID"]);  
    // Add the relation to the DataSet.  
    ds->Relations->Add(myDataRelation);  
    GridOrders->SetDataBinding(ds, "Customers");  
    GridDetails->SetDataBinding(ds, "Customers.CustOrd");  
    ```  
  
## <a name="see-also"></a>См. также

- [Элемент управления DataGrid](datagrid-control-windows-forms.md)
- [Общие сведения об элементе управления DataGrid](datagrid-control-overview-windows-forms.md)
- [Практическое руководство. Привязка элемента управления DataGrid в Windows Forms к источнику данных](how-to-bind-the-windows-forms-datagrid-control-to-a-data-source.md)

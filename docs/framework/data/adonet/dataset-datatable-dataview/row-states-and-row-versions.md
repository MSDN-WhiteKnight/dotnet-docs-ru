---
description: 'Дополнительные сведения: состояния строк и версии строк'
title: Состояния и версии строк
ms.date: 07/19/2018
dev_langs:
- csharp
- vb
ms.assetid: 2e6642c9-bfc6-425c-b3a7-e4912ffa6c1f
ms.openlocfilehash: 7d436ffcfcf59f5daa4fc6eaa9f9018b92e5c608
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99651682"
---
# <a name="row-states-and-row-versions"></a>Состояния и версии строк

ADO.NET управляет строками таблиц с помощью состояний и версий строк. Состояние строки указывает на статус строки, а версии строк хранят значения изменения строки, включая текущее, исходное и применяемое по умолчанию значения. Например, после внесения изменения в столбец строки эта строка будет иметь состояние `Modified` и две версии: `Current`, содержащую текущие значения, и `Original`, содержащую значения этой строки до изменения столбца.  
  
 Каждый объект <xref:System.Data.DataRow> имеет свойство <xref:System.Data.DataRow.RowState%2A>, которое отображает текущее состояние строки. В следующей таблице кратко описано каждое из значений перечисления `RowState`.  
  
|Значение перечисления RowState|Описание|  
|--------------------|-----------------|  
|<xref:System.Data.DataRowState.Unchanged>|Не было выполнено никаких изменений с момента последнего вызова метода `AcceptChanges` или с момента создания строки методом `DataAdapter.Fill`.|  
|<xref:System.Data.DataRowState.Added>|Строка добавлена к таблице, но метод `AcceptChanges` не вызывался.|  
|<xref:System.Data.DataRowState.Modified>|Изменены некоторые элементы строки.|  
|<xref:System.Data.DataRowState.Deleted>|Строка удалена из таблицы, но метод `AcceptChanges` не вызывался.|  
|<xref:System.Data.DataRowState.Detached>|Строка не принадлежит ни к одной коллекции `DataRowCollection`. Свойство `RowState` только что созданной строки имеет значение `Detached`. После добавления новой строки `DataRow` к коллекции `DataRowCollection` с помощью вызова метода `Add` свойству `RowState` присваивается значение `Added`.<br /><br /> Значение `Detached` также присваивается строке, удаленной из `DataRowCollection` с помощью метода `Remove` или путем последовательного вызова методов `Delete` и `AcceptChanges`.|  
  
 Если метод `AcceptChanges` вызывается для <xref:System.Data.DataSet>, <xref:System.Data.DataTable> или <xref:System.Data.DataRow>, удаляются все строки со значением состояния `Deleted`. Оставшимся строкам присваивается состояние `Unchanged`, а значения в версии строки `Original` перезаписываются значениями версии строки `Current`. Если вызывается метод `RejectChanges`, удаляются все строки со значением состояния `Added`. Оставшимся строкам присваивается состояние `Unchanged`, а значения в версии строки `Current` перезаписываются значениями версии строки `Original`.  
  
 Можно просматривать разные версии строки, передавая параметр <xref:System.Data.DataRowVersion> со ссылкой на столбец, как показано в следующем примере.  
  
```vb  
Dim custRow As DataRow = custTable.Rows(0)  
Dim custID As String = custRow("CustomerID", DataRowVersion.Original).ToString()  
```  
  
```csharp  
DataRow custRow = custTable.Rows[0];  
string custID = custRow["CustomerID", DataRowVersion.Original].ToString();  
```  
  
 В следующей таблице кратко описано каждое из значений перечисления `DataRowVersion`.  
  
|Значение DataRowVersion|Описание|  
|--------------------------|-----------------|  
|<xref:System.Data.DataRowVersion.Current>|Текущие значения строки. Эта версия не существует для строк, у которых `RowState` равно `Deleted`.|  
|<xref:System.Data.DataRowVersion.Default>|Версия по умолчанию для конкретной строки. Версия по умолчанию для строки `Added`, `Modified` и `Deleted` представляет собой `Current`. Версия по умолчанию для строки `Detached` - `Proposed`.|  
|<xref:System.Data.DataRowVersion.Original>|Исходные значения строки. Эта версия не существует для строк, у которых `RowState` равно `Added`.|  
|<xref:System.Data.DataRowVersion.Proposed>|Предложенные значения строки. Эта версия строки существует в течение операции изменения строки или для строки, не содержащейся в коллекции `DataRowCollection`.|  
  
 Можно проверить, имеет ли `DataRow` конкретную версию строки, вызвав метод <xref:System.Data.DataRow.HasVersion%2A> и передав ему `DataRowVersion` в качестве аргумента. Например, `DataRow.HasVersion(DataRowVersion.Original)` возвратит значение `false` для только что добавленных строк перед тем, как был вызван метод `AcceptChanges`.  
  
 В следующем примере кода показаны значения во всех удаленных строках таблицы. Строки `Deleted` не имеют версии строки `Current`, поэтому для доступа к значениям столбцов необходимо передать аргумент `DataRowVersion.Original`.  
  
```vb  
Dim catTable As DataTable = catDS.Tables("Categories")  
  
Dim delRows() As DataRow = catTable.Select(Nothing, Nothing, DataViewRowState.Deleted)  
  
Console.WriteLine("Deleted rows:" & vbCrLf)  
  
Dim catCol As DataColumn  
Dim delRow As DataRow  
  
For Each catCol In catTable.Columns  
  Console.Write(catCol.ColumnName & vbTab)  
Next  
Console.WriteLine()  
  
For Each delRow In delRows  
  For Each catCol In catTable.Columns  
    Console.Write(delRow(catCol, DataRowVersion.Original) & vbTab)  
  Next  
  Console.WriteLine()  
Next  
```  
  
```csharp  
DataTable catTable = catDS.Tables["Categories"];  
  
DataRow[] delRows = catTable.Select(null, null, DataViewRowState.Deleted);  
  
Console.WriteLine("Deleted rows:\n");  
  
foreach (DataColumn catCol in catTable.Columns)  
  Console.Write(catCol.ColumnName + "\t");  
Console.WriteLine();  
  
foreach (DataRow delRow in delRows)  
{  
  foreach (DataColumn catCol in catTable.Columns)  
    Console.Write(delRow[catCol, DataRowVersion.Original] + "\t");  
  Console.WriteLine();  
}  
```  
  
## <a name="see-also"></a>См. также

- [Управление данными в таблице данных](manipulating-data-in-a-datatable.md)
- [Наборы данных, таблицы данных и объекты DataView](index.md)
- [Объекты DataAdapter и DataReader](../dataadapters-and-datareaders.md)
- [Общие сведения об ADO.NET](../ado-net-overview.md)

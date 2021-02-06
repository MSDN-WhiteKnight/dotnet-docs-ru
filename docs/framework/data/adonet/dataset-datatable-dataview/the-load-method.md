---
description: 'Дополнительные сведения: метод Load'
title: Метод Load
ms.date: 03/30/2017
dev_langs:
- vb
ms.assetid: e22e5812-89c6-41f0-9302-bb899a46dbff
ms.openlocfilehash: a14008597d88ad4af93c3646998244d94b5561d7
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99651526"
---
# <a name="the-load-method"></a>Метод Load

Метод <xref:System.Data.DataTable.Load%2A> используется для загрузки в таблицу <xref:System.Data.DataTable> строк из источника данных. Это перегруженный метод, который в простейшей форме принимает один параметр — **DataReader**. В этой форме он просто загружает **таблицу данных DataTable** со строками. При необходимости можно указать параметр **loadOption** для управления добавлением данных в **таблицу DataTable**.  
  
 Параметр **loadOption** особенно полезен в случаях, когда объект **DataTable** уже содержит строки данных, поскольку он описывает, как входящие данные из источника данных будут объединены с данными, уже находящихся в таблице. Например, **пресервекуррентвалуес** (значение по умолчанию) указывает, что в случаях, когда строка помечена как **добавленная** в **таблицу** данных, **исходное** значение или каждый столбец задается в соответствии с содержимым соответствующей строки из источника. **Текущее** значение будет хранить значения, назначенные при добавлении строки, а **RowState** строки будет **изменено**.  
  
 В следующей таблице приведено краткое описание значений перечисления <xref:System.Data.LoadOption>.  
  
|Значение LoadOption|Описание|  
|----------------------|-----------------|  
|**OverwriteRow**|Если входящие строки имеют то же значение **PrimaryKey** , что и строка, уже находящиеся в **DataTable**, то **исходные** и **текущие** значения каждого столбца заменяются значениями во входной строке, а для свойства **RowState** устанавливается значение **без изменений**.<br /><br /> Строки из источника данных, которые еще не существуют в **DataTable** , добавляются со значением **RowState** без **изменений**.<br /><br /> Этот параметр в силе обновляет содержимое **таблицы DataTable** , чтобы оно соответствовало содержимому источника данных.|  
|**PreserveCurrentValues (значение по умолчанию)**|Если входящие строки имеют то же значение **PrimaryKey** , что и строка, уже находящиеся в **DataTable**, то **исходное** значение устанавливается на содержимое входящей строки, а **Текущее** значение не изменяется.<br /><br /> При **добавлении** или **изменении** **RowState** оно **изменяется на изменено**.<br /><br /> Если параметр **RowState** **удален**, он остается **удаленным**.<br /><br /> Строки из источника данных, которые еще не существуют в **DataTable** , добавляются, а для **RowState** устанавливается значение **без изменений**.|  
|**UpdateCurrentValues**|Если входящие строки имеют то же значение **PrimaryKey** , что и строка, уже находящиеся в **DataTable**, **Текущее** значение копируется в **исходное** значение, а **Текущее** значение затем устанавливается в содержимое входящей строки.<br /><br /> Если свойство **RowState** в **таблице DataTable** было **добавлено**, то свойство **RowState** остается **добавленным**. Для строк, помеченных как **измененные** или **Удаленные**, свойство **RowState** **изменяется**.<br /><br /> Строки из источника данных, которые еще не существуют в **DataTable** , добавляются, а для свойства **RowState** устанавливается значение **added**.|  
  
 В следующем примере метод **Load** используется для вывода списка дней рождения сотрудников в базе данных **Northwind** .  
  
```vb  
Private Sub LoadBirthdays(ByVal connectionString As String)  
    ' Assumes that connectionString is a valid connection string  
    ' to the Northwind database on SQL Server.  
    Dim queryString As String = _  
    "SELECT LastName, FirstName, BirthDate " & _  
      " FROM dbo.Employees " & _  
      "ORDER BY BirthDate, LastName, FirstName"  
  
    ' Open and fill a DataSet.
    Dim adapter As SqlDataAdapter = New SqlDataAdapter( _  
        queryString, connectionString)  
    Dim employees As New DataSet  
    adapter.Fill(employees, "Employees")  
  
    ' Create a SqlDataReader for use with the Load Method.  
    Dim reader As DataTableReader = employees.GetDataReader()  
  
    ' Create an instance of DataTable and assign the first  
    ' DataTable in the DataSet.Tables collection to it.  
    Dim dataTableEmp As DataTable = employees.Tables(0)  
  
    ' Fill the DataTable with data by calling Load and  
    ' passing the SqlDataReader.  
    dataTableEmp.Load(reader, LoadOption.OverwriteRow)  
  
    ' Loop through the rows collection and display the values  
    ' in the console window.  
    Dim employeeRow As DataRow  
    For Each employeeRow In dataTableEmp.Rows  
        Console.WriteLine("{0:MM\\dd\\yyyy}" & ControlChars.Tab & _  
          "{1}, {2}", _  
          employeeRow("BirthDate"), _  
          employeeRow("LastName"), _  
          employeeRow("FirstName"))  
    Next employeeRow  
  
    ' Keep the window opened to view the contents.  
    Console.ReadLine()  
End Sub  
```  
  
## <a name="see-also"></a>См. также

- [Управление данными в таблице данных](manipulating-data-in-a-datatable.md)
- [Общие сведения об ADO.NET](../ado-net-overview.md)

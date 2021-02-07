---
description: 'Дополнительные сведения: ограничения схемы'
title: Ограничения схемы
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: 73d2980e-e73c-4987-913a-8ddc93d09144
ms.openlocfilehash: 74ddfe5b8aaf9b8193e0c0b2a929ccde333eac26
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99719049"
---
# <a name="schema-restrictions"></a>Ограничения схемы

Вторым необязательным параметром метода **GetSchema** являются ограничения, используемые для ограничения объема возвращаемых сведений о схеме, передаваемые методу **GetSchema** в виде массива строк. Позиция в массиве определяет значения, которые можно передать, и она эквивалентна номеру ограничения.  
  
 Например, в приведенной ниже таблице описываются ограничения, поддерживаемые коллекцией схемы Tables, использующей поставщик данных .NET Framework для SQL Server. Дополнительные ограничения для коллекций схем SQL Server перечислены в конце данного раздела.  
  
|Имя ограничения|имени параметра|Значение ограничения по умолчанию|Номер ограничения|  
|----------------------|--------------------|-------------------------|------------------------|  
|Каталог|@Catalog|TABLE_CATALOG|1|  
|Владелец|@Owner|TABLE_SCHEMA|2|  
|Таблица|@Name|TABLE_NAME|3|  
|TableType|@TableType|TABLE_TYPE|4|  
  
## <a name="specifying-restriction-values"></a>Указание значений ограничения  

 Чтобы использовать одно из ограничений коллекции схем Tables, необходимо создать массив строк с четырьмя элементами, затем поместить значение в элемент, совпадающий с номером ограничения. Например, чтобы ограничить таблицы, возвращаемые методом **GetSchema** только таблицами из схемы "Sales", перед передачей массива методу **GetSchema** присвойте второму элементу массива значение "Sales".  
  
> [!NOTE]
> Коллекции ограничений для `SqlClient` и `OracleClient` имеют дополнительный столбец `ParameterName`. Столбец ограничения по умолчанию оставлен для обратной совместимости, но не учитывается. Чтобы свести к минимуму вероятности проведения атак путем внедрения кода SQL, при указании значений ограничений следует использовать параметризированные запросы, а не замену строк.  
  
> [!NOTE]
> Количество элементов в массиве должно быть меньше или равно количеству ограничений, поддерживаемых специальной коллекцией схем, в противном случае возникнет исключение <xref:System.ArgumentException>. Их может быть меньше максимального количества ограничений. Предполагается, что отсутствующие ограничения имеют значение NULL (без ограничений).  
  
 Можно запросить управляемый поставщик платформа .NET Framework, чтобы определить список поддерживаемых ограничений, вызвав метод **GetSchema** с именем коллекции схем ограничений, которая является "ограничениями". Будет возвращен объект <xref:System.Data.DataTable> со списком имен коллекций и ограничений, значениями ограничений по умолчанию и номерами ограничений.  
  
### <a name="example"></a>Пример  

 В следующих примерах показано, как использовать <xref:System.Data.SqlClient.SqlConnection.GetSchema%2A> метод поставщика данных платформа .NET Framework для класса SQL Server, <xref:System.Data.SqlClient.SqlConnection> чтобы получить сведения о схеме всех таблиц, содержащихся в образце базы данных **AdventureWorks** , а также ограничить сведения, возвращаемые только таблицам в схеме Sales:  
  
```vb  
Imports System.Data.SqlClient  
  
Module Module1  
Sub Main()  
  Dim connectionString As String = _  
    "Data Source=(local);Database=AdventureWorks;" & _  
       "Integrated Security=true;";  
  
  Dim restrictions(3) As String  
  Using connection As New SqlConnection(connectionString)  
    connection.Open()  
  
    'Specify the restrictions.  
    restrictions(1) = "Sales"  
    Dim table As DataTable = connection.GetSchema("Tables", _  
       restrictions)  
  
    ' Display the contents of the table.  
      For Each row As DataRow In table.Rows  
         For Each col As DataColumn In table.Columns  
            Console.WriteLine("{0} = {1}", col.ColumnName, row(col))  
         Next  
         Console.WriteLine("============================")  
      Next  
    Console.WriteLine("Press any key to continue.")  
    Console.ReadKey()  
  End Using  
End Sub  
End Module  
```  
  
```csharp  
using System;  
using System.Data;  
using System.Data.SqlClient;  
  
class Program  
{  
  static void Main()  
  {  
    string connectionString =
       "Data Source=(local);Database=AdventureWorks;" +  
       "Integrated Security=true;";  
    using (SqlConnection connection =  
       new SqlConnection(connectionString))  
    {  
        connection.Open();  
  
        // Specify the restrictions.  
        string[] restrictions = new string[4];  
        restrictions[1] = "Sales";  
        System.Data.DataTable table = connection.GetSchema(  
          "Tables", restrictions);  
  
        // Display the contents of the table.  
        foreach (System.Data.DataRow row in table.Rows)  
        {  
            foreach (System.Data.DataColumn col in table.Columns)  
            {  
                Console.WriteLine("{0} = {1}",
                  col.ColumnName, row[col]);  
            }  
            Console.WriteLine("============================");  
        }  
        Console.WriteLine("Press any key to continue.");  
        Console.ReadKey();  
    }  
  }  
  
  private static string GetConnectionString()  
  {  
     // To avoid storing the connection string in your code,  
     // you can retrieve it from a configuration file.  
     return "Data Source=(local);Database=AdventureWorks;" +  
        "Integrated Security=true;";  
  }  
  
  private static void DisplayData(System.Data.DataTable table)  
  {  
     foreach (System.Data.DataRow row in table.Rows)  
     {  
        foreach (System.Data.DataColumn col in table.Columns)  
        {  
           Console.WriteLine("{0} = {1}", col.ColumnName, row[col]);  
        }  
     Console.WriteLine("============================");  
     }  
  }  
}  
```  
  
## <a name="sql-server-schema-restrictions"></a>Ограничения схемы SQL Server  

 В приведенных ниже таблицах перечислены ограничения коллекций схем SQL Server.  
  
### <a name="users"></a>Пользователи  
  
|Имя ограничения|имени параметра|Значение ограничения по умолчанию|Номер ограничения|  
|----------------------|--------------------|-------------------------|------------------------|  
|User_Name|@Name|name|1|  
  
### <a name="databases"></a>Базы данных  
  
|Имя ограничения|имени параметра|Значение ограничения по умолчанию|Номер ограничения|  
|----------------------|--------------------|-------------------------|------------------------|  
|Имя|@Name|Имя|1|  
  
### <a name="tables"></a>Таблицы  
  
|Имя ограничения|имени параметра|Значение ограничения по умолчанию|Номер ограничения|  
|----------------------|--------------------|-------------------------|------------------------|  
|Каталог|@Catalog|TABLE_CATALOG|1|  
|Владелец|@Owner|TABLE_SCHEMA|2|  
|Таблица|@Name|TABLE_NAME|3|  
|TableType|@TableType|TABLE_TYPE|4|  
  
### <a name="columns"></a>Столбцы  
  
|Имя ограничения|имени параметра|Значение ограничения по умолчанию|Номер ограничения|  
|----------------------|--------------------|-------------------------|------------------------|  
|Каталог|@Catalog|TABLE_CATALOG|1|  
|Владелец|@Owner|TABLE_SCHEMA|2|  
|Таблица|@Table|TABLE_NAME|3|  
|Столбец|@Column|COLUMN_NAME|4|  
  
### <a name="structuredtypemembers"></a>StructuredTypeMembers  
  
|Имя ограничения|имени параметра|Значение ограничения по умолчанию|Номер ограничения|  
|----------------------|--------------------|-------------------------|------------------------|  
|Каталог|@Catalog|TABLE_CATALOG|1|  
|Владелец|@Owner|TABLE_SCHEMA|2|  
|Таблица|@Table|TABLE_NAME|3|  
|Столбец|@Column|COLUMN_NAME|4|  
  
### <a name="views"></a>Представления  
  
|Имя ограничения|имени параметра|Значение ограничения по умолчанию|Номер ограничения|  
|----------------------|--------------------|-------------------------|------------------------|  
|Каталог|@Catalog|TABLE_CATALOG|1|  
|Владелец|@Owner|TABLE_SCHEMA|2|  
|Таблица|@Table|TABLE_NAME|3|  
  
### <a name="viewcolumns"></a>ViewColumns  
  
|Имя ограничения|имени параметра|Значение ограничения по умолчанию|Номер ограничения|  
|----------------------|--------------------|-------------------------|------------------------|  
|Каталог|@Catalog|VIEW_CATALOG|1|  
|Владелец|@Owner|VIEW_SCHEMA|2|  
|Таблица|@Table|VIEW_NAME|3|  
|Столбец|@Column|COLUMN_NAME|4|  
  
### <a name="procedureparameters"></a>ProcedureParameters  
  
|Имя ограничения|имени параметра|Значение ограничения по умолчанию|Номер ограничения|  
|----------------------|--------------------|-------------------------|------------------------|  
|Каталог|@Catalog|SPECIFIC_CATALOG|1|  
|Владелец|@Owner|SPECIFIC_SCHEMA|2|  
|Имя|@Name|SPECIFIC_NAME|3|  
|Параметр|@Parameter|PARAMETER_NAME|4|  
  
### <a name="procedures"></a>Процедуры  
  
|Имя ограничения|имени параметра|Значение ограничения по умолчанию|Номер ограничения|  
|----------------------|--------------------|-------------------------|------------------------|  
|Каталог|@Catalog|SPECIFIC_CATALOG|1|  
|Владелец|@Owner|SPECIFIC_SCHEMA|2|  
|Имя|@Name|SPECIFIC_NAME|3|  
|Тип|@Type|ROUTINE_TYPE|4|  
  
### <a name="indexcolumns"></a>IndexColumns  
  
|Имя ограничения|имени параметра|Значение ограничения по умолчанию|Номер ограничения|  
|----------------------|--------------------|-------------------------|------------------------|  
|Каталог|@Catalog|db_name()|1|  
|Владелец|@Owner|user_name()|2|  
|Таблица|@Table|o.name|3|  
|ConstraintName|@ConstraintName|x.name|4|  
|Столбец|@Column|c.name|5|  
  
### <a name="indexes"></a>Индексы  
  
|Имя ограничения|имени параметра|Значение ограничения по умолчанию|Номер ограничения|  
|----------------------|--------------------|-------------------------|------------------------|  
|Каталог|@Catalog|db_name()|1|  
|Владелец|@Owner|user_name()|2|  
|Таблица|@Table|o.name|3|  
  
### <a name="userdefinedtypes"></a>UserDefinedTypes  
  
|Имя ограничения|имени параметра|Значение ограничения по умолчанию|Номер ограничения|  
|----------------------|--------------------|-------------------------|------------------------|  
|assembly_name|@AssemblyName|assemblies.name|1|  
|udt_name|@UDTName|types.assembly_class|2|  
  
### <a name="foreignkeys"></a>ForeignKeys  
  
|Имя ограничения|имени параметра|Значение ограничения по умолчанию|Номер ограничения|  
|----------------------|--------------------|-------------------------|------------------------|  
|Каталог|@Catalog|CONSTRAINT_CATALOG|1|  
|Владелец|@Owner|CONSTRAINT_SCHEMA|2|  
|Таблица|@Table|TABLE_NAME|3|  
|Имя|@Name|CONSTRAINT_NAME|4|  
  
## <a name="sql-server-2008-schema-restrictions"></a>Ограничения схемы SQL Server 2008  

 В приведенных ниже таблицах перечислены ограничения коллекций схем SQL Server 2008. Эти ограничения действуют, начиная с версии .NET Framework 3.5 с пакетом обновления 1 (SP1) и SQL Server 2008. Они не поддерживаются в предыдущих версиях .NET Framework и SQL Server.  
  
### <a name="columnsetcolumns"></a>ColumnSetColumns  
  
|Имя ограничения|имени параметра|Значение ограничения по умолчанию|Номер ограничения|  
|----------------------|--------------------|-------------------------|------------------------|  
|Каталог|@Catalog|TABLE_CATALOG|1|  
|Владелец|@Owner|TABLE_SCHEMA|2|  
|Таблица|@Table|TABLE_NAME|3|  
  
### <a name="allcolumns"></a>AllColumns  
  
|Имя ограничения|имени параметра|Значение ограничения по умолчанию|Номер ограничения|  
|----------------------|--------------------|-------------------------|------------------------|  
|Каталог|@Catalog|TABLE_CATALOG|1|  
|Владелец|@Owner|TABLE_SCHEMA|2|  
|Таблица|@Table|TABLE_NAME|3|  
|Столбец|@Column|COLUMN_NAME|4|  
  
## <a name="see-also"></a>См. также раздел

- [Общие сведения об ADO.NET](ado-net-overview.md)

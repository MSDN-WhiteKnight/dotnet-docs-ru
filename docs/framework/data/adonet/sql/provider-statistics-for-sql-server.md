---
description: Дополнительные сведения см. в статье статистика поставщика для SQL Server
title: Статистика поставщика для SQL Server
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: 429c9d09-92ac-46ec-829a-fbff0a9575a2
ms.openlocfilehash: ece5a6214d438ecac64e8738755d5fb5d0ed7245
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99767600"
---
# <a name="provider-statistics-for-sql-server"></a>Статистика поставщика для SQL Server

Начиная с .NET Framework 2.0, поставщик данных .NET Framework для SQL Server поддерживает получение статистики во время выполнения. Для включения статистики задайте для свойства <xref:System.Data.SqlClient.SqlConnection.StatisticsEnabled%2A> объекта <xref:System.Data.SqlClient.SqlConnection> значение `True` после создания допустимого объекта подключения. После включения статистики ее можно просмотреть как "моментальный снимок во времени". Для этого нужно извлечь ссылку <xref:System.Collections.IDictionary> с помощью метода <xref:System.Data.SqlClient.SqlConnection.RetrieveStatistics%2A> объекта <xref:System.Data.SqlClient.SqlConnection>. Выполните перечисление списка в виде набора записей пар "имя-значение" в словаре. Эти пары "имя-значение" не упорядочены. В любой момент можно вызвать метод <xref:System.Data.SqlClient.SqlConnection.ResetStatistics%2A> объекта <xref:System.Data.SqlClient.SqlConnection>, чтобы сбросить счетчики. Если сбор статистики не включен, исключение не создается. Кроме того, если <xref:System.Data.SqlClient.SqlConnection.RetrieveStatistics%2A> вызывается без вызова метода <xref:System.Data.SqlClient.SqlConnection.StatisticsEnabled%2A> перед этим, то полученные значения являются начальными значениями для каждой записи. Если вы включите статистику, запустите приложение на некоторое время, а затем отключите статистику, то полученные значения будут отражать значения, собранные до момента отключения статистики. Все статистические значения собираются отдельно для каждого подключения.  
  
## <a name="statistical-values-available"></a>Доступные статистические значения  

 В настоящее время доступны 18 различных элементов от поставщика Microsoft SQL Server. Доступ ко множеству элементов производится через свойство **Count** ссылки интерфейса <xref:System.Collections.IDictionary>, возвращенной <xref:System.Data.SqlClient.SqlConnection.RetrieveStatistics%2A>. Для всех счетчиков статистики поставщика используется тип среды CLR <xref:System.Int64> (**long** в C# и Visual Basic) с внутренним представлением длиной 64 бита. Максимальное значение типа данных **int64**, определенное полем **int64.MaxValue**, равно ((2^63)-1)). Если значения для счетчиков достигли этого максимального значения, они больше не должны считаться точными. Это означает, что **int64.MaxValue**-1((2^63)-2) по существу является максимальным действительным значением любого статистического показателя.  
  
> [!NOTE]
> Словарь используется для возврата статистики поставщика, так как число, имена и порядок возвращаемой статистики могут измениться в будущем. Приложения не должны полагаться на определенное значение в словаре, но вместо этого должны проверять, есть ли значение и ветвь соответственно.  
  
 В следующей таблице описаны доступные текущие статистические значения. Обратите внимание, что имена ключей для отдельных значений в региональных версиях Microsoft .NET Framework не локализованы.  
  
|Имя ключа|Описание|  
|--------------|-----------------|  
|`BuffersReceived`|Возвращает число пакетов потока табличных данных (TDS), полученных поставщиком из SQL Server после начала использования приложением поставщика и включения статистики.|  
|`BuffersSent`|Возвращает число пакетов TDS, отправленных в SQL Server поставщиком после включения статистики. Для больших команд может потребоваться несколько буферов. Например, если на сервер отправляется большая команда и требуется шесть пакетов, `ServerRoundtrips` увеличивается на единицу, а `BuffersSent` — на шесть.|  
|`BytesReceived`|Возвращает число байтов данных в пакетах TDS, полученных поставщиком от SQL Server после начала использования приложением поставщика и включения статистики.|  
|`BytesSent`|Возвращает число байтов данных, отправленных в SQL Server в пакетах TDS после начала использования приложением поставщика и включения статистики.|  
|`ConnectionTime`|Время в миллисекундах, в течение которого было открыто соединение после включения статистики (или полное время соединения, если статистика была включена до открытия соединения).|  
|`CursorOpens`|Возвращает число открытий курсора через подключение после начала использования приложением поставщика и включения статистики.<br /><br /> Обратите внимание, что результаты только для чтения и последовательного доступа, возвращаемые инструкциями SELECT, не считаются курсорами и поэтому не влияют на этот счетчик.|  
|`ExecutionTime`|Возвращает совокупное количество времени в миллисекундах, которое поставщик потратил на обработку после включения статистики, с учетом того времени, которое потрачено на ожидание ответов от сервера, а также времени, потраченного на выполнение кода самим поставщиком.<br /><br /> К классам, включающим код времени, относятся:<br /><br /> SqlConnection<br /><br /> SqlCommand<br /><br /> SqlDataReader;<br /><br /> SqlDataAdapter;<br /><br /> SqlTransaction<br /><br /> SqlCommandBuilder.<br /><br /> Чтобы критические для производительности элементы были максимально мелкими, для следующих элементов не фиксируется время:<br /><br /> SqlDataReader;<br /><br /> оператор this[] (все перегрузки);<br /><br /> GetBoolean<br /><br /> GetChar<br /><br /> GetDateTime<br /><br /> GetDecimal<br /><br /> GetDouble<br /><br /> GetFloat<br /><br /> GetGuid<br /><br /> GetInt16<br /><br /> GetInt32<br /><br /> GetInt64<br /><br /> GetName<br /><br /> GetOrdinal<br /><br /> GetSqlBinary<br /><br /> GetSqlBoolean<br /><br /> GetSqlByte<br /><br /> GetSqlDateTime<br /><br /> GetSqlDecimal<br /><br /> GetSqlDouble<br /><br /> GetSqlGuid<br /><br /> GetSqlInt16<br /><br /> GetSqlInt32<br /><br /> GetSqlInt64<br /><br /> GetSqlMoney<br /><br /> GetSqlSingle<br /><br /> GetSqlString<br /><br /> GetString<br /><br /> IsDBNull|  
|`IduCount`|Возвращает общее число инструкций INSERT, DELETE и UPDATE, выполненных через подключение после начала использования приложением поставщика и включения статистики.|  
|`IduRows`|Возвращает общее число строк, затронутых инструкциями INSERT, DELETE и UPDATE, которые выполнялись через подключение после начала использования приложением поставщика и включения статистики.|  
|`NetworkServerTime`|Возвращает совокупное количество времени в миллисекундах, которое поставщик потратил на ожидание ответов от сервера после начала использования приложением поставщика и включения статистики.|  
|`PreparedExecs`|Возвращает число подготовленных команд, выполненных через подключение после начала использования приложением поставщика и включения статистики.|  
|`Prepares`|Возвращает число инструкций, подготовленных через подключение после начала использования приложением поставщика и включения статистики.|  
|`SelectCount`|Возвращает число инструкций SELECT, выполненных через подключение после начала использования приложением поставщика и включения статистики. Сюда входят инструкции FETCH для получения строк из курсоров, а счетчик для инструкций SELECT обновляется по достижении конца <xref:System.Data.SqlClient.SqlDataReader>.|  
|`SelectRows`|Возвращает число строк, выбранных после начала использования приложением поставщика и включения статистики. Этот счетчик отражает все строки, формируемые инструкциями SQL, даже те, которые фактически не использовались вызывающим объектом. Например, закрытие читателя данных до считывания всего результирующего набора не повлияет на число. Сюда входят строки, полученные из курсоров с помощью инструкций FETCH.|  
|`ServerRoundtrips`|Возвращает число команд, отправленных серверу в рамках подключения, и получения ответа после начала использования приложением поставщика и включения статистики.|  
|`SumResultSets`|Возвращает количество результирующих наборов, которые применялись после начала использования приложением поставщика и включения статистики. Например, это может быть любой результирующий набор, возвращаемый клиенту. Для курсоров каждая операция выборки или получения записи блока считается независимым результирующим набором.|  
|`Transactions`|Возвращает число пользовательских транзакций, запущенных после начала использования приложением поставщика и включения статистики (в том числе откаты). Если подключение работает при включенной автоматической фиксации, каждая команда считается транзакцией.<br /><br /> Этот счетчик увеличивает число транзакций, как только выполняется инструкция BEGIN TRAN, независимо от того, была ли транзакция позже зафиксирована или подвержена откату.|  
|`UnpreparedExecs`|Возвращает число неподготовленных инструкций, выполненных через подключение после начала использования приложением поставщика и включения статистики.|  
  
### <a name="retrieving-a-value"></a>Получение значения  

 В следующем консольном приложении показано, как включить статистику для подключения, получить четыре отдельных статистических значения и записать их в окно консоли.  
  
> [!NOTE]
> В следующем примере используется образец базы данных **AdventureWorks**, входящий в состав SQL Server. В строке подключения в примере кода предполагается, что база данных установлена и доступна на локальном компьютере. При необходимости измените строку подключения для вашей среды.  
  
```vb  
Option Strict On  
  
Imports System  
Imports System.Collections  
Imports System.Data  
Imports System.Data.SqlClient  
  
Module Module1  
  
  Sub Main()  
    Dim connectionString As String = GetConnectionString()  
  
    Using awConnection As New SqlConnection(connectionString)  
      ' StatisticsEnabled is False by default.  
      ' It must be set to True to start the
      ' statistic collection process.  
      awConnection.StatisticsEnabled = True  
  
      Dim productSQL As String = "SELECT * FROM Production.Product"  
      Dim productAdapter As _  
          New SqlDataAdapter(productSQL, awConnection)  
  
      Dim awDataSet As New DataSet()  
  
      awConnection.Open()  
  
      productAdapter.Fill(awDataSet, "ProductTable")  
  
      ' Retrieve the current statistics as  
      ' a collection of values at this point  
      ' and time.  
      Dim currentStatistics As IDictionary = _  
          awConnection.RetrieveStatistics()  
  
      Console.WriteLine("Total Counters: " & _  
          currentStatistics.Count.ToString())  
      Console.WriteLine()  
  
      ' Retrieve a few individual values  
      ' related to the previous command.  
      Dim bytesReceived As Long = _  
          CLng(currentStatistics.Item("BytesReceived"))  
      Dim bytesSent As Long = _  
          CLng(currentStatistics.Item("BytesSent"))  
      Dim selectCount As Long = _  
          CLng(currentStatistics.Item("SelectCount"))  
      Dim selectRows As Long = _  
          CLng(currentStatistics.Item("SelectRows"))  
  
      Console.WriteLine("BytesReceived: " & bytesReceived.ToString())  
      Console.WriteLine("BytesSent: " & bytesSent.ToString())  
      Console.WriteLine("SelectCount: " & selectCount.ToString())  
      Console.WriteLine("SelectRows: " & selectRows.ToString())  
  
      Console.WriteLine()  
      Console.WriteLine("Press any key to continue")  
      Console.ReadLine()  
    End Using  
  
  End Sub  
  
  Function GetConnectionString() As String  
    ' To avoid storing the connection string in your code,  
    ' you can retrieve it from a configuration file.  
    Return "Data Source=localhost;Integrated Security=SSPI;" & _  
      "Initial Catalog=AdventureWorks"  
  End Function  
End Module  
```  
  
```csharp  
using System;  
using System.Collections;  
using System.Collections.Generic;  
using System.Data;  
using System.Data.SqlClient;  
  
namespace CS_Stats_Console_GetValue  
{  
  class Program  
  {  
    static void Main(string[] args)  
    {  
      string connectionString = GetConnectionString();  
  
      using (SqlConnection awConnection =
        new SqlConnection(connectionString))  
      {  
        // StatisticsEnabled is False by default.  
        // It must be set to True to start the
        // statistic collection process.  
        awConnection.StatisticsEnabled = true;  
  
        string productSQL = "SELECT * FROM Production.Product";  
        SqlDataAdapter productAdapter =
          new SqlDataAdapter(productSQL, awConnection);  
  
        DataSet awDataSet = new DataSet();  
  
        awConnection.Open();  
  
        productAdapter.Fill(awDataSet, "ProductTable");  
        // Retrieve the current statistics as  
        // a collection of values at this point  
        // and time.  
        IDictionary currentStatistics =  
          awConnection.RetrieveStatistics();  
  
        Console.WriteLine("Total Counters: " +  
          currentStatistics.Count.ToString());  
        Console.WriteLine();  
  
        // Retrieve a few individual values  
        // related to the previous command.  
        long bytesReceived =  
            (long) currentStatistics["BytesReceived"];  
        long bytesSent =  
            (long) currentStatistics["BytesSent"];  
        long selectCount =  
            (long) currentStatistics["SelectCount"];  
        long selectRows =  
            (long) currentStatistics["SelectRows"];  
  
        Console.WriteLine("BytesReceived: " +  
            bytesReceived.ToString());  
        Console.WriteLine("BytesSent: " +  
            bytesSent.ToString());  
        Console.WriteLine("SelectCount: " +  
            selectCount.ToString());  
        Console.WriteLine("SelectRows: " +  
            selectRows.ToString());  
  
        Console.WriteLine();  
        Console.WriteLine("Press any key to continue");  
        Console.ReadLine();  
      }  
  
    }  
    private static string GetConnectionString()  
    {  
      // To avoid storing the connection string in your code,  
      // you can retrieve it from a configuration file.  
      return "Data Source=localhost;Integrated Security=SSPI;" +
        "Initial Catalog=AdventureWorks";  
    }  
  }  
}  
```  
  
### <a name="retrieving-all-values"></a>Получение всех значений  

 В следующем консольном приложении показано, как включить статистику для подключения, получить все доступные статистические значения с помощью перечислителя и записать их в окно консоли.  
  
> [!NOTE]
> В следующем примере используется образец базы данных **AdventureWorks**, входящий в состав SQL Server. В строке подключения в примере кода предполагается, что база данных установлена и доступна на локальном компьютере. При необходимости измените строку подключения для вашей среды.  
  
```vb  
Option Strict On  
  
Imports System  
Imports System.Collections  
Imports System.Data  
Imports System.Data.SqlClient  
  
Module Module1  
  Sub Main()  
    Dim connectionString As String = GetConnectionString()  
  
    Using awConnection As New SqlConnection(connectionString)  
      ' StatisticsEnabled is False by default.  
      ' It must be set to True to start the
      ' statistic collection process.  
      awConnection.StatisticsEnabled = True  
  
      Dim productSQL As String = "SELECT * FROM Production.Product"  
      Dim productAdapter As _  
          New SqlDataAdapter(productSQL, awConnection)  
  
      Dim awDataSet As New DataSet()  
  
      awConnection.Open()  
  
      productAdapter.Fill(awDataSet, "ProductTable")  
  
      ' Retrieve the current statistics as  
      ' a collection of values at this point  
      ' and time.  
      Dim currentStatistics As IDictionary = _  
          awConnection.RetrieveStatistics()  
  
      Console.WriteLine("Total Counters: " & _  
          currentStatistics.Count.ToString())  
      Console.WriteLine()  
  
      Console.WriteLine("Key Name and Value")  
  
      ' Note the entries are unsorted.  
      For Each entry As DictionaryEntry In currentStatistics  
        Console.WriteLine(entry.Key.ToString() & _  
            ": " & entry.Value.ToString())  
      Next  
  
      Console.WriteLine()  
      Console.WriteLine("Press any key to continue")  
      Console.ReadLine()  
    End Using  
  
  End Sub  
  
  Function GetConnectionString() As String  
    ' To avoid storing the connection string in your code,  
    ' you can retrieve it from a configuration file.  
    Return "Data Source=localhost;Integrated Security=SSPI;" & _  
      "Initial Catalog=AdventureWorks"  
  End Function  
End Module  
```  
  
```csharp  
using System;  
using System.Collections;  
using System.Collections.Generic;  
using System.Text;  
using System.Data;  
using System.Data.SqlClient;  
  
namespace CS_Stats_Console_GetAll  
{  
  class Program  
  {  
    static void Main(string[] args)  
    {  
      string connectionString = GetConnectionString();  
  
      using (SqlConnection awConnection =
        new SqlConnection(connectionString))  
      {  
        // StatisticsEnabled is False by default.  
        // It must be set to True to start the
        // statistic collection process.  
        awConnection.StatisticsEnabled = true;  
  
        string productSQL = "SELECT * FROM Production.Product";  
        SqlDataAdapter productAdapter =  
            new SqlDataAdapter(productSQL, awConnection);  
  
        DataSet awDataSet = new DataSet();  
  
        awConnection.Open();  
  
        productAdapter.Fill(awDataSet, "ProductTable");  
  
        // Retrieve the current statistics as  
        // a collection of values at this point  
        // and time.  
        IDictionary currentStatistics =  
            awConnection.RetrieveStatistics();  
  
        Console.WriteLine("Total Counters: " +  
            currentStatistics.Count.ToString());  
        Console.WriteLine();  
  
        Console.WriteLine("Key Name and Value");  
  
        // Note the entries are unsorted.  
        foreach (DictionaryEntry entry in currentStatistics)  
        {  
          Console.WriteLine(entry.Key.ToString() +  
              ": " + entry.Value.ToString());  
        }  
  
        Console.WriteLine();  
        Console.WriteLine("Press any key to continue");  
        Console.ReadLine();  
      }  
  
    }  
    private static string GetConnectionString()  
    {  
      // To avoid storing the connection string in your code,  
      // you can retrieve it from a configuration file.  
      return "Data Source=localhost;Integrated Security=SSPI;" +
        "Initial Catalog=AdventureWorks";  
    }  
  }  
}  
```  
  
## <a name="see-also"></a>См. также

- [SQL Server и ADO.NET](index.md)
- [Общие сведения об ADO.NET](../ado-net-overview.md)

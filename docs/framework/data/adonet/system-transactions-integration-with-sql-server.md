---
description: Дополнительные сведения см. в статье интеграция System. Transactions с SQL Server
title: Интеграция System.Transactions с SQL Server
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: b555544e-7abb-4814-859b-ab9cdd7d8716
ms.openlocfilehash: 977ff18600256613dabc0212c2f7aa1bc2650408
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99766781"
---
# <a name="systemtransactions-integration-with-sql-server"></a>Интеграция System.Transactions с SQL Server

В платформа .NET Framework версии 2,0 появилась платформа транзакций, доступ к которой можно получить через <xref:System.Transactions> пространство имен. Эта платформа предоставляет транзакции в виде, который полностью интегрирован в платформа .NET Framework, включая ADO.NET.  
  
 Помимо улучшенных способов программирования, <xref:System.Transactions> и ADO.NET могут работать вместе для координации оптимизации при работе с транзакциями. Повышаемая транзакция — это упрощенная (локальная) транзакция, которая по необходимости может быть автоматически повышена до полностью распределенной транзакции.  
  
 Начиная с ADO.NET 2,0, <xref:System.Data.SqlClient> поддерживает продвижение транзакций при работе с SQL Server. Повышаемая транзакция не вызывает дополнительную нагрузку распределенной транзакции, если таковая не требуется. Повышаемые транзакции выполняются автоматически и не требуют вмешательства разработчика.  
  
 Операции повышения доступны только при использовании платформа .NET Framework поставщика данных для SQL Server ( `SqlClient` ) с SQL Server.  
  
## <a name="creating-promotable-transactions"></a>Создание повышаемых транзакций  

 Поставщик платформа .NET Framework для SQL Server предоставляет поддержку для продвижения транзакций, которые обрабатываются с помощью классов в <xref:System.Transactions> пространстве имен платформа .NET Framework. Повышаемые транзакции оптимизируют работу с распределенными транзакциями за счет отсрочки создания распределенной транзакции до того момента, когда она будет необходима. Если требуется только один диспетчер ресурсов, то распределенная транзакция не создается.  
  
> [!NOTE]
> В частично доверенном сценарии при повышении транзакции до распределенной требуется право доступа <xref:System.Transactions.DistributedTransactionPermission> .  
  
## <a name="promotable-transaction-scenarios"></a>Сценарии использования повышаемых транзакций  

 Как правило, для распределенных транзакций требуются значительные системные ресурсы, поскольку они управляются координатором распределенных транзакций (Майкрософт), который интегрирует все диспетчеры ресурсов, используемые в транзакции. Повышаемая транзакция — это особая форма транзакции <xref:System.Transactions>, эффективно делегирующая работу простой транзакции SQL Server. <xref:System.Transactions>, <xref:System.Data.SqlClient> и SQL Server координируют работу, выполняемую при обработке транзакции, при необходимости повышая ее до полностью распределенной транзакции.  
  
 Преимущество использования повышаемых транзакций заключается в том, что при открытии соединения с помощью активной транзакции <xref:System.Transactions.TransactionScope> и отсутствии других открытых соединений такая транзакция фиксируется как упрощенная, что позволяет избежать излишних затрат ресурсов на полностью распределенную транзакцию.  
  
### <a name="connection-string-keywords"></a>Ключевые слова в строке подключения  

 В свойстве <xref:System.Data.SqlClient.SqlConnection.ConnectionString%2A> поддерживается использование ключевого слова `Enlist`, которое указывает, будет ли клиент <xref:System.Data.SqlClient> обнаруживать контексты транзакций и автоматически прикреплять соединение к распределенной транзакции. Если `Enlist=true`, то соединение автоматически прикрепляется к текущему контексту транзакции открывающего потока. Если `Enlist=false`, то соединение `SqlClient` не будет взаимодействовать с распределенной транзакцией. Значение `Enlist` по умолчанию - true. Если ключевое слово `Enlist` в строке соединения не задано, то соединение автоматически прикрепляется к распределенной транзакции, если она будет обнаружена при открытии соединения.  
  
 Ключевые слова `Transaction Binding` в строке соединения <xref:System.Data.SqlClient.SqlConnection> управляют связью соединения с прикрепленной транзакцией `System.Transactions` . Эта связь также доступна через свойство <xref:System.Data.SqlClient.SqlConnectionStringBuilder.TransactionBinding%2A> построителя <xref:System.Data.SqlClient.SqlConnectionStringBuilder>.  
  
 В следующей таблице описаны возможные значения.  
  
|Ключевое слово|Описание|  
|-------------|-----------------|  
|Implicit Unbind|Это значение используется по умолчанию. Соединение отсоединяется от транзакции по ее завершении, вновь переходя в режим автоматической фиксации.|  
|Explicit Unbind|Соединение остается прикрепленным к транзакции до ее закрытия. Соединение будет потеряно, если связанная с ним транзакция не активна или не соответствует <xref:System.Transactions.Transaction.Current%2A>.|  
  
## <a name="using-transactionscope"></a>Использование класса TransactionScope  

 Класс <xref:System.Transactions.TransactionScope> делает блок кода транзакционным, неявно прикрепляя соединения к распределенной транзакции. В конце блока <xref:System.Transactions.TransactionScope.Complete%2A> перед тем, как выйти из него, необходимо вызвать метод <xref:System.Transactions.TransactionScope> . При выходе из этого блока вызывается метод <xref:System.Transactions.TransactionScope.Dispose%2A> . При возникновении исключения, в результате которого исполнение кода выходит за пределы области, транзакция считается прерванной.  
  
 Рекомендуется использовать блок `using` , чтобы гарантировать вызов метода <xref:System.Transactions.TransactionScope.Dispose%2A> для объекта <xref:System.Transactions.TransactionScope> при выходе из блока using. Неудачная попытка зафиксировать или откатить незавершенные транзакции может значительно снизить производительность, поскольку время ожидания по умолчанию для объекта <xref:System.Transactions.TransactionScope> составляет одну минуту. Если инструкция `using` не используется, необходимо явно выполнить все действия в блоке `Try` и вызвать метод <xref:System.Transactions.TransactionScope.Dispose%2A> в блоке `Finally`.  
  
 Если в объекте <xref:System.Transactions.TransactionScope>возникает исключение, транзакция помечается как несогласованная и прерывается. При удалении объекта <xref:System.Transactions.TransactionScope> будет произведен ее откат. Если исключений не возникает, то участвующие транзакции будут зафиксированы.  
  
> [!NOTE]
> Класс `TransactionScope` создает транзакцию с уровнем изоляции <xref:System.Transactions.Transaction.IsolationLevel%2A>, равным `Serializable` по умолчанию. В зависимости от приложения уровень изоляции можно понижать во избежание большого количества состязаний данных в приложении.  
  
> [!NOTE]
> В рамках распределенных транзакций рекомендуется выполнять только операции обновления, вставки и удаления, поскольку они потребляют значительные ресурсы базы данных. Инструкции выборки могут без необходимости блокировать ресурсы базы данных, и в некоторых случаях для выборки может потребоваться использование транзакций. Любые не связанные с базой данных действия должны выполняться за пределами области транзакции, если только в ней не задействованы другие диспетчеры ресурсов транзакций. Хотя исключение в области транзакции не позволяет зафиксировать транзакцию, класс <xref:System.Transactions.TransactionScope> не имеет возможности отката каких-либо изменений, внесенных кодом за пределами области самой транзакции. При необходимости предпринять какие-либо действия, когда производится откат транзакции, следует написать собственную реализацию интерфейса <xref:System.Transactions.IEnlistmentNotification> и явно прикрепить его к транзакции.  
  
## <a name="example"></a>Пример  

 Для работы с <xref:System.Transactions> необходима ссылка на файл System.Transactions.dll.  
  
 Следующая функция показывает, как создать повышаемую транзакцию для двух разных экземпляров SQL Server, представленных двумя разными объектами <xref:System.Data.SqlClient.SqlConnection> , которые заключены в оболочку с помощью блок <xref:System.Transactions.TransactionScope> . В коде создается блок <xref:System.Transactions.TransactionScope> с инструкцией `using` и открывается первое соединение, которое автоматически прикрепляется к транзакции <xref:System.Transactions.TransactionScope>. Изначально транзакция прикрепляется как упрощенная, а не полностью распределенная транзакция. Второе соединение прикрепляется к транзакции <xref:System.Transactions.TransactionScope> , только если при выполнении команды в первом соединении не возникает исключения. При открытии второго соединения транзакция автоматически повышается до полностью распределенной. Вызывается метод <xref:System.Transactions.TransactionScope.Complete%2A> , который фиксирует транзакцию, только если не возникло ни одного исключения. Если в любой точке блока <xref:System.Transactions.TransactionScope> возникло исключение, метод `Complete` вызван не будет и при удалении транзакции <xref:System.Transactions.TransactionScope> в конце ее блока `using` будет произведен откат распределенной транзакции.  
  
```csharp  
// This function takes arguments for the 2 connection strings and commands in order  
// to create a transaction involving two SQL Servers. It returns a value > 0 if the  
// transaction committed, 0 if the transaction rolled back. To test this code, you can
// connect to two different databases on the same server by altering the connection string,  
// or to another RDBMS such as Oracle by altering the code in the connection2 code block.  
static public int CreateTransactionScope(  
    string connectString1, string connectString2,  
    string commandText1, string commandText2)  
{  
    // Initialize the return value to zero and create a StringWriter to display results.  
    int returnValue = 0;  
    System.IO.StringWriter writer = new System.IO.StringWriter();  
  
    // Create the TransactionScope in which to execute the commands, guaranteeing  
    // that both commands will commit or roll back as a single unit of work.  
    using (TransactionScope scope = new TransactionScope())  
    {  
        using (SqlConnection connection1 = new SqlConnection(connectString1))  
        {  
            try  
            {  
                // Opening the connection automatically enlists it in the
                // TransactionScope as a lightweight transaction.  
                connection1.Open();  
  
                // Create the SqlCommand object and execute the first command.  
                SqlCommand command1 = new SqlCommand(commandText1, connection1);  
                returnValue = command1.ExecuteNonQuery();  
                writer.WriteLine("Rows to be affected by command1: {0}", returnValue);  
  
                // if you get here, this means that command1 succeeded. By nesting  
                // the using block for connection2 inside that of connection1, you  
                // conserve server and network resources by opening connection2
                // only when there is a chance that the transaction can commit.
                using (SqlConnection connection2 = new SqlConnection(connectString2))  
                    try  
                    {  
                        // The transaction is promoted to a full distributed  
                        // transaction when connection2 is opened.  
                        connection2.Open();  
  
                        // Execute the second command in the second database.  
                        returnValue = 0;  
                        SqlCommand command2 = new SqlCommand(commandText2, connection2);  
                        returnValue = command2.ExecuteNonQuery();  
                        writer.WriteLine("Rows to be affected by command2: {0}", returnValue);  
                    }  
                    catch (Exception ex)  
                    {  
                        // Display information that command2 failed.  
                        writer.WriteLine("returnValue for command2: {0}", returnValue);  
                        writer.WriteLine("Exception Message2: {0}", ex.Message);  
                    }  
            }  
            catch (Exception ex)  
            {  
                // Display information that command1 failed.  
                writer.WriteLine("returnValue for command1: {0}", returnValue);  
                writer.WriteLine("Exception Message1: {0}", ex.Message);  
            }  
        }  
  
        // If an exception has been thrown, Complete will not
        // be called and the transaction is rolled back.  
        scope.Complete();  
    }  
  
    // The returnValue is greater than 0 if the transaction committed.  
    if (returnValue > 0)  
    {  
        writer.WriteLine("Transaction was committed.");  
    }  
    else  
    {  
        // You could write additional business logic here, notify the caller by  
        // throwing a TransactionAbortedException, or log the failure.  
        writer.WriteLine("Transaction rolled back.");  
    }  
  
    // Display messages.  
    Console.WriteLine(writer.ToString());  
  
    return returnValue;  
}  
```  
  
```vb  
' This function takes arguments for the 2 connection strings and commands in order  
' to create a transaction involving two SQL Servers. It returns a value > 0 if the  
' transaction committed, 0 if the transaction rolled back. To test this code, you can
' connect to two different databases on the same server by altering the connection string,  
' or to another RDBMS such as Oracle by altering the code in the connection2 code block.  
Public Function CreateTransactionScope( _  
  ByVal connectString1 As String, ByVal connectString2 As String, _  
  ByVal commandText1 As String, ByVal commandText2 As String) As Integer  
  
    ' Initialize the return value to zero and create a StringWriter to display results.  
    Dim returnValue As Integer = 0  
    Dim writer As System.IO.StringWriter = New System.IO.StringWriter  
  
    ' Create the TransactionScope in which to execute the commands, guaranteeing  
    ' that both commands will commit or roll back as a single unit of work.  
    Using scope As New TransactionScope()  
        Using connection1 As New SqlConnection(connectString1)  
            Try  
                ' Opening the connection automatically enlists it in the
                ' TransactionScope as a lightweight transaction.  
                connection1.Open()  
  
                ' Create the SqlCommand object and execute the first command.  
                Dim command1 As SqlCommand = New SqlCommand(commandText1, connection1)  
                returnValue = command1.ExecuteNonQuery()  
                writer.WriteLine("Rows to be affected by command1: {0}", returnValue)  
  
                ' If you get here, this means that command1 succeeded. By nesting  
                ' the Using block for connection2 inside that of connection1, you  
                ' conserve server and network resources by opening connection2
                ' only when there is a chance that the transaction can commit.
                Using connection2 As New SqlConnection(connectString2)  
                    Try  
                        ' The transaction is promoted to a full distributed  
                        ' transaction when connection2 is opened.  
                        connection2.Open()  
  
                        ' Execute the second command in the second database.  
                        returnValue = 0  
                        Dim command2 As SqlCommand = New SqlCommand(commandText2, connection2)  
                        returnValue = command2.ExecuteNonQuery()  
                        writer.WriteLine("Rows to be affected by command2: {0}", returnValue)  
  
                    Catch ex As Exception  
                        ' Display information that command2 failed.  
                        writer.WriteLine("returnValue for command2: {0}", returnValue)  
                        writer.WriteLine("Exception Message2: {0}", ex.Message)  
                    End Try  
                End Using  
  
            Catch ex As Exception  
                ' Display information that command1 failed.  
                writer.WriteLine("returnValue for command1: {0}", returnValue)  
                writer.WriteLine("Exception Message1: {0}", ex.Message)  
            End Try  
        End Using  
  
        ' If an exception has been thrown, Complete will
        ' not be called and the transaction is rolled back.  
        scope.Complete()  
    End Using  
  
    ' The returnValue is greater than 0 if the transaction committed.  
    If returnValue > 0 Then  
        writer.WriteLine("Transaction was committed.")  
    Else  
        ' You could write additional business logic here, notify the caller by  
        ' throwing a TransactionAbortedException, or log the failure.  
       writer.WriteLine("Transaction rolled back.")  
     End If  
  
    ' Display messages.  
    Console.WriteLine(writer.ToString())  
  
    Return returnValue  
End Function  
```  
  
## <a name="see-also"></a>См. также раздел

- [Транзакции и параллелизм](transactions-and-concurrency.md)
- [Общие сведения об ADO.NET](ado-net-overview.md)

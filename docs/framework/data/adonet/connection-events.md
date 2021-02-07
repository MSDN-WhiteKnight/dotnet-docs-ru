---
description: 'Дополнительные сведения: события подключения'
title: События подключения
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: 5a29de74-acfc-4134-8616-829dd7ce0710
ms.openlocfilehash: fcf131e41ce90db11e84fd241744e348f4ca739e
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99663811"
---
# <a name="connection-events"></a>События подключения

Все поставщики данных платформа .NET Framework имеют объекты **соединения** с двумя событиями, которые можно использовать для получения информационных сообщений из источника данных или для определения, изменилось ли состояние **соединения** . В следующей таблице описываются события объекта **Connection**.  
  
|Событие|Описание|  
|-----------|-----------------|  
|**InfoMessage**|Возникает, когда из источника данных возвращается информационное сообщение. Информационные сообщения - это сообщения из источника данных, которые не приводят к формированию исключения.|  
|**StateChange**|Возникает при изменении состояния объекта **Connection**.|  
  
## <a name="working-with-the-infomessage-event"></a>Работа с событием InfoMessage  

 При помощи события <xref:System.Data.SqlClient.SqlConnection.InfoMessage> объекта <xref:System.Data.SqlClient.SqlConnection> можно получать предупреждения и информационные сообщения из источника данных SQL Server. Ошибки со степенью серьезности от 11 до 16, возвращаемые из источника данных, вызывают формирование исключения. Однако событие <xref:System.Data.SqlClient.SqlConnection.InfoMessage> также можно использовать, чтобы получать сообщения из источника данных, которые не связаны с ошибками. В случае с Microsoft SQL Server любая ошибка с серьезностью 10 или меньше считается информационным сообщением, их можно отслеживать при помощи события <xref:System.Data.SqlClient.SqlConnection.InfoMessage>. Дополнительные сведения см. в статье [Степени серьезности ошибок компонента Database Engine](/sql/relational-databases/errors-events/database-engine-error-severities).
  
 Событие <xref:System.Data.SqlClient.SqlConnection.InfoMessage> принимает объект <xref:System.Data.SqlClient.SqlInfoMessageEventArgs>, в свойстве **Errors** которого содержится коллекция сообщений из источника данных. У объектов **Error** этой коллекции можно запрашивать номер ошибки и текст сообщения, а также сведения об источнике ошибки. Поставщик данных .NET Framework для SQL Server также указывает сведения о базе данных, хранимой процедуре и номере строки, из которой поступило сообщение.  
  
### <a name="example"></a>Пример  

 В следующем примере кода показано, как добавлять обработчик для события <xref:System.Data.SqlClient.SqlConnection.InfoMessage>.  
  
```vb  
' Assumes that connection represents a SqlConnection object.  
  AddHandler connection.InfoMessage, _  
    New SqlInfoMessageEventHandler(AddressOf OnInfoMessage)  
  
Private Shared Sub OnInfoMessage(sender As Object, _  
  args As SqlInfoMessageEventArgs)  
  Dim err As SqlError  
  For Each err In args.Errors  
    Console.WriteLine("The {0} has received a severity {1}, _  
       state {2} error number {3}\n" & _  
      "on line {4} of procedure {5} on server {6}:\n{7}", _  
      err.Source, err.Class, err.State, err.Number, err.LineNumber, _  
    err.Procedure, err.Server, err.Message)  
  Next  
End Sub  
```  
  
```csharp  
// Assumes that connection represents a SqlConnection object.  
  connection.InfoMessage +=
    new SqlInfoMessageEventHandler(OnInfoMessage);  
  
protected static void OnInfoMessage(  
  object sender, SqlInfoMessageEventArgs args)  
{  
  foreach (SqlError err in args.Errors)  
  {  
    Console.WriteLine(  
  "The {0} has received a severity {1}, state {2} error number {3}\n" +  
  "on line {4} of procedure {5} on server {6}:\n{7}",  
   err.Source, err.Class, err.State, err.Number, err.LineNumber,
   err.Procedure, err.Server, err.Message);  
  }  
}  
```  
  
## <a name="handling-errors-as-infomessages"></a>Обработка ошибок как событий InfoMessages  

 Событие <xref:System.Data.SqlClient.SqlConnection.InfoMessage> обычно вызывается только для информационных и предупреждающих сообщений, которые отправляются с сервера. Однако когда возникает реальная ошибка, выполнение методов **ExecuteNonQuery** или **ExecuteReader**, которые инициировали серверную операцию, приостанавливается с формированием исключения.  
  
 Если требуется продолжить обработку остальных инструкций команды несмотря ни на какие ошибки, выдаваемые сервером, следует задать свойству <xref:System.Data.SqlClient.SqlConnection.FireInfoMessageEventOnUserErrors%2A> объекта <xref:System.Data.SqlClient.SqlConnection> значение `true`. В этом случае соединение вызовет для ошибок событие <xref:System.Data.SqlClient.SqlConnection.InfoMessage>, а не будет формировать исключение и прерывать обработку. После этого клиентское приложение сможет обработать это событие и отреагировать на условия ошибки.  
  
> [!NOTE]
> Ошибка со степенью серьезности 17 и выше, в результате которой сервер прекращает обработку команды, должна обрабатываться как исключение. В этом случае исключение формируется независимо от того, как обрабатывается ошибка в событии <xref:System.Data.SqlClient.SqlConnection.InfoMessage>.  
  
## <a name="working-with-the-statechange-event"></a>Работа с событием StateChange  

 Событие **StateChange** возникает при изменении состояния объекта **Connection**. Событие **StateChange** воспринимается объектом <xref:System.Data.StateChangeEventArgs>, который позволяет определять состояние объекта **Connection** при помощи свойств **OriginalState** и **CurrentState**. Свойство **OriginalState** является перечислением <xref:System.Data.ConnectionState>, которое указывает состояние объекта **Connection** до его изменения. Свойство **CurrentState** является перечислением <xref:System.Data.ConnectionState>, которое указывает состояние объекта **Connection** после его изменения.  
  
 В следующем примере кода событие **StateChange** используется, чтобы написать сообщение в консольном окне при изменении состояния объекта **Connection**.  
  
```vb  
' Assumes connection represents a SqlConnection object.  
  AddHandler connection.StateChange, _  
    New StateChangeEventHandler(AddressOf OnStateChange)  
  
Protected Shared Sub OnStateChange( _  
  sender As Object, args As StateChangeEventArgs)  
  
  Console.WriteLine( _  
  "The current Connection state has changed from {0} to {1}.", _  
  args.OriginalState, args.CurrentState)  
End Sub  
```  
  
```csharp  
// Assumes connection represents a SqlConnection object.  
  connection.StateChange  += new StateChangeEventHandler(OnStateChange);  
  
protected static void OnStateChange(object sender,
  StateChangeEventArgs args)  
{  
  Console.WriteLine(  
    "The current Connection state has changed from {0} to {1}.",  
      args.OriginalState, args.CurrentState);  
}  
```  
  
## <a name="see-also"></a>См. также

- [Подключение к источнику данных](connecting-to-a-data-source.md)
- [Общие сведения об ADO.NET](ado-net-overview.md)

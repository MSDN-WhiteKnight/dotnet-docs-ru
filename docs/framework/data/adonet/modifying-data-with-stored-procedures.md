---
description: 'Дополнительные сведения: изменение данных с помощью хранимых процедур'
title: Изменение данных с помощью хранимых процедур
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: 7d8e9a46-1af6-4a02-bf61-969d77ae07e0
ms.openlocfilehash: 66a4aa9577c71605bde0152a142a65dfa81a31d7
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99786229"
---
# <a name="modifying-data-with-stored-procedures"></a>Изменение данных с помощью хранимых процедур

Хранимые процедуры могут принимать данные в виде входных параметров и возвращать их в виде выходных параметров, результирующих наборов или возвращаемых значений. Образец, приведенный ниже, показывает, как ADO.NET отправляет и получает входные и выходные параметры, а также возвращаемые значения. Пример добавляет в таблицу новую запись, где столбец первичного ключа является столбцом идентификаторов в базе данных SQL Server.  
  
> [!NOTE]
> При использовании хранимых процедур SQL Server для изменения или удаления данных с помощью <xref:System.Data.SqlClient.SqlDataAdapter> убедитесь, что в определении хранимой процедуры не указана инструкция SET NOCOUNT ON. В таком случае возвращается число затронутых строк, равное нулю, что `DataAdapter` интерпретирует как конфликт параллелизма. Это событие вызовет исключение <xref:System.Data.DBConcurrencyException>.  
  
## <a name="example"></a>Пример  

 Пример использует следующую хранимую процедуру для вставки новой категории в таблицу **Northwind** **Categories**. Хранимая процедура принимает значение столбца **CategoryName** в качестве входного параметра и с помощью функции SCOPE_IDENTITY() получает новое значения поля идентификатора **CategoryID** и возвращает его в выходном параметре. Оператор RETURN использует @ROWCOUNT функцию @ для возврата количества вставленных строк.  
  
```sql
CREATE PROCEDURE dbo.InsertCategory  
  @CategoryName nvarchar(15),  
  @Identity int OUT  
AS  
INSERT INTO Categories (CategoryName) VALUES(@CategoryName)  
SET @Identity = SCOPE_IDENTITY()  
RETURN @@ROWCOUNT  
```  
  
 Следующий пример кода использует хранимую процедуру `InsertCategory`, показанную выше, в качестве источника для свойства <xref:System.Data.SqlClient.SqlDataAdapter.InsertCommand%2A> класса <xref:System.Data.SqlClient.SqlDataAdapter>. Выходной параметр `@Identity` будет отражен в наборе данных <xref:System.Data.DataSet> после вставки записи в базу данных при вызове метода `Update` объекта <xref:System.Data.SqlClient.SqlDataAdapter>. Код также получает возвращаемое значение.  
  
> [!NOTE]
> При использовании параметра <xref:System.Data.OleDb.OleDbDataAdapter> необходимо указать параметры с параметром с параметром <xref:System.Data.ParameterDirection> **ReturnValue** перед другими параметрами.  
  
 [!code-csharp[DataWorks SqlClient.SprocIdentityReturn#1](../../../../samples/snippets/csharp/VS_Snippets_ADO.NET/DataWorks SqlClient.SprocIdentityReturn/CS/source.cs#1)]
 [!code-vb[DataWorks SqlClient.SprocIdentityReturn#1](../../../../samples/snippets/visualbasic/VS_Snippets_ADO.NET/DataWorks SqlClient.SprocIdentityReturn/VB/source.vb#1)]  
  
## <a name="see-also"></a>См. также

- [Извлечение и изменение данных в ADO.NET](retrieving-and-modifying-data.md)
- [Объекты DataAdapter и DataReader](dataadapters-and-datareaders.md)
- [Выполнение команды](executing-a-command.md)
- [Общие сведения об ADO.NET](ado-net-overview.md)

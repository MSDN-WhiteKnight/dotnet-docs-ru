---
description: 'Дополнительные сведения: возврат или пропуск элементов в последовательности'
title: Возврат или пропуск элементов последовательности
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: 81a31acd-e0f1-4bca-9a12-fa1ad5752374
ms.openlocfilehash: 6eba93562d4c6a8ffa4150453deed88844d4e297
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99695142"
---
# <a name="return-or-skip-elements-in-a-sequence"></a>Возврат или пропуск элементов последовательности

Для возвращения заданного числа элементов последовательности и пропуска оставшихся используется оператор <xref:System.Linq.Queryable.Take%2A>.  
  
 Для пропуска заданного числа элементов последовательности и возвращения оставшихся используется оператор <xref:System.Linq.Queryable.Skip%2A>.  
  
> [!NOTE]
> На методы <xref:System.Linq.Enumerable.Take%2A> и <xref:System.Linq.Enumerable.Skip%2A> накладываются некоторые ограничения при их использовании в запросах для SQL Server 2000. Дополнительные сведения см. в записи "пропуск и получение исключений в SQL Server 2000" раздела [Устранение неполадок](troubleshooting.md).  
  
 [!INCLUDE[vbtecdlinq](../../../../../../includes/vbtecdlinq-md.md)] Преобразует с <xref:System.Linq.Queryable.Skip%2A> помощью вложенного запроса с `NOT EXISTS` предложением SQL. Это преобразование имеет следующие ограничения.  
  
- Необходимо задать значение аргумента. Не поддерживаются множественные наборы, даже упорядоченные.  
  
- Созданный запрос может быть сложнее, чем запрос, созданный для основного запроса, к которому применен <xref:System.Linq.Queryable.Skip%2A>. Это может стать причиной снижения производительности или даже привести к превышению времени ожидания.  
  
## <a name="example"></a>Пример  

 В следующем примере для выбора первых пяти принятых на работу `Take` используется метод `Employees`. Обратите внимание, что коллекция сначала сортируется по `HireDate`.  
  
 [!code-csharp[DLinqQueryExamples#16](../../../../../../samples/snippets/csharp/VS_Snippets_Data/DLinqQueryExamples/cs/Program.cs#16)]
 [!code-vb[DLinqQueryExamples#16](../../../../../../samples/snippets/visualbasic/VS_Snippets_Data/DLinqQueryExamples/vb/Module1.vb#16)]  
  
## <a name="example"></a>Пример  

 В следующем примере для выбора всех <xref:System.Linq.Queryable.Skip%2A>, за исключением 10 самых дорогих, используется метод `Products`.  
  
 [!code-csharp[DLinqQueryExamples#17](../../../../../../samples/snippets/csharp/VS_Snippets_Data/DLinqQueryExamples/cs/Program.cs#17)]
 [!code-vb[DLinqQueryExamples#17](../../../../../../samples/snippets/visualbasic/VS_Snippets_Data/DLinqQueryExamples/vb/Module1.vb#17)]  
  
## <a name="example"></a>Пример  

 В следующем примере для пропуска первых 50 и возвращения следующих за ними 10 записей методы <xref:System.Linq.Queryable.Skip%2A> и <xref:System.Linq.Queryable.Take%2A> объединяются.  
  
 [!code-csharp[DLinqQueryExamples#18](../../../../../../samples/snippets/csharp/VS_Snippets_Data/DLinqQueryExamples/cs/Program.cs#18)]
 [!code-vb[DLinqQueryExamples#18](../../../../../../samples/snippets/visualbasic/VS_Snippets_Data/DLinqQueryExamples/vb/Module1.vb#18)]  
  
 Методы <xref:System.Linq.Queryable.Take%2A> и <xref:System.Linq.Queryable.Skip%2A> правильно определяются только для упорядоченных наборов. Семантика для неупорядоченных наборов или множественных наборов не определена.  
  
 Из-за ограничений, накладываемых на упорядочение в SQL, [!INCLUDE[vbtecdlinq](../../../../../../includes/vbtecdlinq-md.md)] предпринимает попытку переместить упорядочение аргументов оператора <xref:System.Linq.Queryable.Take%2A> или <xref:System.Linq.Queryable.Skip%2A>в результат оператора.  
  
> [!NOTE]
> Преобразование отличается для SQL Server 2000 и SQL Server 2005. Если вы планируете использовать <xref:System.Linq.Queryable.Skip%2A> с запросом любой сложности, используйте SQL Server 2005.  
  
 Рассмотрим следующий [!INCLUDE[vbtecdlinq](../../../../../../includes/vbtecdlinq-md.md)] запрос для SQL Server 2000:  
  
 [!code-csharp[DLinqQueryExamples#19](../../../../../../samples/snippets/csharp/VS_Snippets_Data/DLinqQueryExamples/cs/Program.cs#19)]
 [!code-vb[DLinqQueryExamples#19](../../../../../../samples/snippets/visualbasic/VS_Snippets_Data/DLinqQueryExamples/vb/Module1.vb#19)]  
  
 [!INCLUDE[vbtecdlinq](../../../../../../includes/vbtecdlinq-md.md)] перемещает упорядочение в конец кода SQL, как показано далее.  
  
```sql
SELECT TOP 1 [t0].[CustomerID], [t0].[CompanyName],  
FROM [Customers] AS [t0]  
WHERE (NOT (EXISTS(  
    SELECT NULL AS [EMPTY]  
    FROM (  
        SELECT TOP 1 [t1].[CustomerID]  
        FROM [Customers] AS [t1]  
        WHERE [t1].[City] = @p0  
        ORDER BY [t1].[CustomerID]  
        ) AS [t2]  
    WHERE [t0].[CustomerID] = [t2].[CustomerID]  
    ))) AND ([t0].[City] = @p1)  
ORDER BY [t0].[CustomerID]  
```  
  
 При связывании методов <xref:System.Linq.Queryable.Take%2A> и <xref:System.Linq.Queryable.Skip%2A> друг с другом все указанные операции упорядочения должны быть согласованы. В противном случае результаты не определены.  
  
 Методы <xref:System.Linq.Queryable.Take%2A> и <xref:System.Linq.Queryable.Skip%2A> правильно определяются для неотрицательных постоянных целочисленных аргументов, соответствующих спецификации SQL.  
  
## <a name="see-also"></a>См. также

- [Примеры запросов](query-examples.md)
- [Трансляция стандартных операторов запросов](standard-query-operator-translation.md)

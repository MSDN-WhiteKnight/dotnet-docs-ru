---
description: 'Дополнительные сведения о: DEREF (Entity SQL)'
title: DEREF (Entity SQL)
ms.date: 03/30/2017
ms.assetid: 4c78e833-b260-453d-9bf4-eb39857dd0fa
ms.openlocfilehash: 9d0f29123c1459c6eab21ea9cd860b5c9e77f591
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99724730"
---
# <a name="deref-entity-sql"></a>DEREF (Entity SQL)

Разыменовывает значение ссылки и выдает результат разыменования.  
  
## <a name="syntax"></a>Синтаксис  
  
```sql  
SELECT DEREF ( o.expression ) FROM Table AS o;
```  
  
## <a name="arguments"></a>Аргументы  

 `expression`  
 Любое допустимое выражение запроса, возвращающее коллекцию.  
  
## <a name="return-value"></a>Возвращаемое значение  

 Значение сущности, на которую указывает ссылка.  
  
## <a name="remarks"></a>Remarks  

 Оператор DEREF разыменовывает значение ссылки и выдает результат разыменования. Например, если `r` является ссылкой на тип ref \<T> , `Deref(r)` то является выражением типа `T` , который возвращает сущность, на которую ссылается `r` . Если ссылка имеет значение null или висячее значение (т. е. цель ссылки не существует), то результатом оператора DEREF будет значение null.  
  
## <a name="example"></a>Пример  

 В следующем запросе [!INCLUDE[esql](../../../../../../includes/esql-md.md)] оператор DEREF используется для разыменования значения ссылки и возврата результата разыменования. Запрос основан на модели AdventureWorks Sales. Для компиляции и запуска этого запроса выполните следующие шаги.  
  
1. Выполните процедуру, описанную в разделе [инструкции. выполнение запроса, возвращающего тип PrimitiveType результаты](../how-to-execute-a-query-that-returns-primitivetype-results.md).  
  
2. Передайте методу ExecutePrimitiveTypeQuery следующий запрос в качестве аргумента.  
  
 [!code-sql[DP EntityServices Concepts#DEREF](~/samples/snippets/tsql/VS_Snippets_Data/dp entityservices concepts/tsql/entitysql.sql#deref)]  
  
## <a name="see-also"></a>См. также

- [Справочник по Entity SQL](entity-sql-reference.md)
- [ЗНАЧ](ref-entity-sql.md)
- [CREATEREF](createref-entity-sql.md)
- [KEY](key-entity-sql.md)
- [Допускающие значения NULL структурированные типы](nullable-structured-types-entity-sql.md)

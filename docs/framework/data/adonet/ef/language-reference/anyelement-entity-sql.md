---
description: 'Дополнительные сведения о: ANYELEMENT (Entity SQL)'
title: ANYELEMENT (Entity SQL)
ms.date: 03/30/2017
ms.assetid: 475a9ad6-8c8d-4f49-9970-af273e5360f1
ms.openlocfilehash: 3330c1b0bed69084bc83c5a689762ff529539d54
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99697157"
---
# <a name="anyelement-entity-sql"></a>ANYELEMENT (Entity SQL)

Извлекает элемент из многозначной коллекции.  
  
## <a name="syntax"></a>Синтаксис  
  
```csharp
ANYELEMENT ( expression )  
```  
  
## <a name="arguments"></a>Аргументы  

 `expression`  
 Любое допустимое выражение запроса, возвращающее коллекцию, из которой извлекается элемент.  
  
## <a name="return-value"></a>Возвращаемое значение  

 Единственный элемент коллекции или произвольный элемент, если в коллекции их несколько. Если коллекция пустая, возвращается значение `null`. Если `collection` является коллекцией типа `Collection<T>` , то `ANYELEMENT(collection)` является допустимым выражением, результатом которого является экземпляр типа `T` .  
  
## <a name="remarks"></a>Remarks  

 Оператор ANYELEMENT извлекает произвольный элемент из многозначной коллекции. Например, в следующем примере извлекается один элемент из набора `Customers`.  
  
```csharp
ANYELEMENT(Customers)  
```  
  
## <a name="example"></a>Пример  

 В следующем запросе [!INCLUDE[esql](../../../../../../includes/esql-md.md)] оператор ANYELEMENT используется для извлечения элемента из многозначной коллекции. Запрос основан на модели AdventureWorks Sales. Для компиляции и запуска этого запроса выполните следующие шаги.  
  
1. Выполните процедуру из статьи [How to: Execute a Query that Returns StructuralType Results](../how-to-execute-a-query-that-returns-structuraltype-results.md).  
  
2. Передайте следующий запрос в качестве аргумента методу `ExecuteStructuralTypeQuery` :  
  
 [!code-csharp[DP EntityServices Concepts 2#ANYELEMENT](../../../../../../samples/snippets/csharp/VS_Snippets_Data/dp entityservices concepts 2/cs/entitysql.cs#anyelement)]  
  
## <a name="see-also"></a>См. также

- [Справочник по Entity SQL](entity-sql-reference.md)
- [Допускающие значения NULL структурированные типы](nullable-structured-types-entity-sql.md)

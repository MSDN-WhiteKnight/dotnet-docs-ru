---
description: 'Дополнительные сведения: Entity SQL обзор'
title: Общие сведения об Entity SQL
ms.date: 03/30/2017
ms.assetid: f0bb8120-e709-40a3-ac1e-5520dc47477d
ms.openlocfilehash: eb337ff3894b24d787d829838c9cf12c934a823c
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99724613"
---
# <a name="entity-sql-overview"></a>Общие сведения об Entity SQL

[!INCLUDE[esql](../../../../../../includes/esql-md.md)] — Это язык, подобный SQL, который позволяет запрашивать концептуальные модели в Entity Framework. Концептуальные модели представляют данные как сущности и связи, а также [!INCLUDE[esql](../../../../../../includes/esql-md.md)] позволяют запрашивать эти сущности и связи в формате, привычном для тех, кто использовал SQL.  

 Entity Framework работает с поставщиками данных, специфичными для хранилища, для преобразования универсальных типов [!INCLUDE[esql](../../../../../../includes/esql-md.md)] в запросы, зависящие от хранилища. Поставщик EntityClient предоставляет способ выполнения команды языка [!INCLUDE[esql](../../../../../../includes/esql-md.md)] на модели сущностей и получения разнообразных типов данных, в том числе скалярных результатов, результирующих наборов и графов объектов. При создании объекта <xref:System.Data.EntityClient.EntityCommand> можно указать имя хранимой процедуры или текст запроса, присвоив строку запроса на языке [!INCLUDE[esql](../../../../../../includes/esql-md.md)] его свойству <xref:System.Data.EntityClient.EntityCommand.CommandText%2A?displayProperty=nameWithType>. <xref:System.Data.EntityClient.EntityDataReader> предоставляет доступ к результатам выполнения <xref:System.Data.EntityClient.EntityCommand> к модели EDM. Для выполнения команды, возвращающей значение <xref:System.Data.EntityClient.EntityDataReader>, нужно вызвать метод <xref:System.Data.EntityClient.EntityCommand.ExecuteReader%2A>.  
  
 Помимо поставщика EntityClient, Entity Framework позволяет [!INCLUDE[esql](../../../../../../includes/esql-md.md)] выполнять запросы к концептуальной модели и возвращать данные в виде строго типизированных объектов CLR, являющихся экземплярами типов сущностей. Дополнительные сведения см. в разделе [Работа с объектами](../working-with-objects.md).  
  
 В этом разделе приведены основные сведения о языке [!INCLUDE[esql](../../../../../../includes/esql-md.md)].  
  
## <a name="in-this-section"></a>В этом разделе  

 [Отличия Entity SQL от Transact-SQL](how-entity-sql-differs-from-transact-sql.md)  
  
 [Краткий справочник по Entity SQL](entity-sql-quick-reference.md)  
  
 [Система типов](type-system-entity-sql.md)  
  
 [Определения типов](type-definitions-entity-sql.md)  
  
 [Сборка типов](constructing-types-entity-sql.md)  
  
 [Кэширование плана запроса](query-plan-caching-entity-sql.md)  
  
 [Пространства имен](namespaces-entity-sql.md)  
  
 [Идентификаторы](identifiers-entity-sql.md)  
  
 [Параметры](parameters-entity-sql.md)  
  
 [Переменные](variables-entity-sql.md)  
  
 [Неподдерживаемые выражения](unsupported-expressions-entity-sql.md)  
  
 [Литералы](literals-entity-sql.md)  
  
 [Литералы NULL и вывод типов](null-literals-and-type-inference-entity-sql.md)  
  
 [Набор символов ввода](input-character-set-entity-sql.md)  
  
 [Выражения запросов](query-expressions-entity-sql.md)  
  
 [Функции](functions-entity-sql.md)  
  
 [Приоритет операторов](operator-precedence-entity-sql.md)  
  
 [Разбивка на страницы](paging-entity-sql.md)  
  
 [Семантика сравнения](comparison-semantics-entity-sql.md)  
  
 [Составление вложенных запросов Entity SQL](composing-nested-entity-sql-queries.md)  
  
 [Допускающие значения NULL структурированные типы](nullable-structured-types-entity-sql.md)  
  
## <a name="see-also"></a>См. также

- [Справочник по Entity SQL](entity-sql-reference.md)
- [Язык Entity SQL](entity-sql-language.md)
- [Спецификации CSDL, SSDL и MSL](/ef/ef6/modeling/designer/advanced/edmx/csdl-spec)

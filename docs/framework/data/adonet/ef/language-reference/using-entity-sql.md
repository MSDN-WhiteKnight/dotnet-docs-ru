---
description: 'Дополнительные сведения: использование (Entity SQL)'
title: USING (Entity SQL)
ms.date: 03/30/2017
ms.assetid: 20f58b8f-6070-4456-b7e8-5ff3d6269273
ms.openlocfilehash: 084ab56f25041377dd6a0a35dd743122f482eeba
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99795057"
---
# <a name="using-entity-sql"></a>USING (Entity SQL)

Задает пространства имен, используемые в выражении запроса.  
  
## <a name="syntax"></a>Синтаксис  
  
```sql  
USING [ alias = ] namespace  
```  
  
## <a name="arguments"></a>Аргументы  

 `alias`  
 Задает более короткий псевдоним, с помощью которого можно уточнить применяемое пространство имен.  
  
 `namespace`  
 Любое допустимое пространство имен.  
  
## <a name="example"></a>Пример  

 В следующем запросе Entity SQL используется оператор USING для задания пространства имен, используемого в выражении запроса. Для компиляции и запуска этого запроса выполните следующие шаги.  
  
1. Выполните процедуру, описанную в разделе [инструкции. выполнение запроса, возвращающего тип PrimitiveType результаты](../how-to-execute-a-query-that-returns-primitivetype-results.md).  
  
2. Передайте следующий запрос в качестве аргумента методу `ExecutePrimitiveTypeQuery` :  
  
```csharp
using SqlServer; RAND()  
```  
  
## <a name="see-also"></a>См. также

- [Пространства имен](namespaces-entity-sql.md)
- [Справочник по Entity SQL](entity-sql-reference.md)

---
description: 'Дополнительные сведения о функции: FUNCTION (Entity SQL)'
title: FUNCTION (Entity SQL)
ms.date: 03/30/2017
ms.assetid: 0bb88992-37ed-4991-ace5-55be612a2c4d
ms.openlocfilehash: d61aafce03dc7b82b678f1eb107afb79c6c3ed2f
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99786320"
---
# <a name="function-entity-sql"></a>FUNCTION (Entity SQL)

Определяет функцию в рамках команды запроса Entity SQL.  
  
## <a name="syntax"></a>Синтаксис  
  
```sql  
FUNCTION function-name  
( [ { parameter_name <type_definition>
        [ ,...n ]  
  ]  
) AS ( function_expression )
  
<type_definition>::=  
    { data_type | COLLECTION ( <type_definition> )
                | REF ( data_type )
                | ROW ( row_expression )
        }
```  
  
## <a name="arguments"></a>Аргументы  

 `function-name`  
 Имя функции.  
  
 `parameter-name`  
 Имя параметра функции.  
  
 `function_expression`  
 Допустимое выражение Entity SQL, представляющее функцию. Команда в функции может действовать, используя параметры `parameter_name` , переданные функции.  
  
 `data_type`  
 Имя поддерживаемого типа.  
  
 Коллекция (<type_definition `>` )  
 Выражение, возвращающее коллекцию поддерживаемых типов, строк или ссылок.  
  
 REF **(** `data_type` **)**  
 Выражение, возвращающее ссылку на тип сущности.  
  
 ROW **(** `row_expression` **)**  
 Выражение, возвращающее анонимные структурно типизированные записи из одного или нескольких значений. Дополнительные сведения см. в разделе [ROW](row-entity-sql.md).  
  
## <a name="remarks"></a>Remarks  

 Объявить встроенными можно несколько функций с одинаковыми именами при условии, что эти функции имеют различные сигнатуры. Для получения дополнительной информации см. [Function Overload Resolution](function-overload-resolution-entity-sql.md).  
  
 Встроенная функция может быть вызвана командой SQL только после определения ее в этой команде. Однако встроенная функция может быть вызвана в пределах другой встроенной функции как до, так и после определения вызываемой функции. В следующем примере функция A вызывает функцию B до того, как функция B была определена.  
  
 `Function A() as ('A calls B. ' + B())`  
  
 `Function B() as ('B was called.')`  
  
 `A()`  
  
 Дополнительные сведения см. в статье [Практическое руководство. Вызов пользовательской функции](/previous-versions/dotnet/netframework-4.0/dd490951(v=vs.100)).  
  
 Функции также могут быть объявлены внутри самой модели. Функции, объявленные в модели, выполняются так же, как и функции, объявленные встроенными в команде. Дополнительные сведения см. в разделе [определяемые пользователем функции](user-defined-functions-entity-sql.md).  
  
## <a name="example"></a>Пример  

 В следующей команде Entity SQL определяется функция `Products` , использующая целочисленное значение для фильтрации возвращаемых продуктов.  
  
 [!code-sql[DP EntityServices Concepts#FUNCTION1](~/samples/snippets/tsql/VS_Snippets_Data/dp entityservices concepts/tsql/entitysql.sql#function1)]  
  
## <a name="example"></a>Пример  

 В следующей команде Entity SQL определяется функция `StringReturnsCollection` , использующая коллекцию строк для фильтрации возвращаемых контактов.  
  
 [!code-sql[DP EntityServices Concepts#FUNCTION2](~/samples/snippets/tsql/VS_Snippets_Data/dp entityservices concepts/tsql/entitysql.sql#function2)]  
  
## <a name="see-also"></a>См. также

- [Справочник по Entity SQL](entity-sql-reference.md)
- [Язык Entity SQL](entity-sql-language.md)

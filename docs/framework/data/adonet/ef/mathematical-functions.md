---
description: 'Дополнительные сведения: математические функции'
title: Математические функции
ms.date: 03/30/2017
ms.assetid: b040c7cb-156d-40f2-9152-61065b18148c
ms.openlocfilehash: 6bf1f116d6d88a8a188dc31cab91fbf26bdaea36
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99795031"
---
# <a name="mathematical-functions"></a>Математические функции

Поставщик данных для SQL Server платформы .NET Framework (SqlClient) предоставляет математические функции, производящие вычисления на входящих значениях, предоставляемых в качестве аргументов, и возвращающие результат в виде числовых значений. Эти функции находятся в пространстве имен SqlServer, которое доступно при использовании SqlClient. Свойство пространства имен поставщика позволяет платформе Entity Framework узнать, какой префикс используется поставщиком для конкретных конструкций, таких как типы или функции. В следующей таблице описаны математические функции SqlClient.  
  
## <a name="absexpression"></a>ABS (выражение)

Возвращает абсолютное значение.

**Аргументы**

`expression`: значение типа `Int32`, `Int64`, `Double` или `Decimal`.

**Возвращаемое значение**

Абсолютное значение заданного выражения.

**Пример**

`SqlServer.ABS(-2)`

## <a name="acosexpression"></a>ACOS (выражение)

Возвращает значение арккосинуса указанного выражения.

**Аргументы**

`expression` — значение в формате `Double`.

**Возвращаемое значение**

Объект `Double`.

**Пример**

`SqlServer.ACOS(.9)`

## <a name="asinexpression"></a>ASIN (выражение)

Возвращает значение арксинуса указанного выражения.

**Аргументы**

`expression` — значение в формате `Double`.

**Возвращаемое значение**

Объект `Double`.

**Пример**

`SqlServer.ASIN(.9)`

## <a name="atanexpression"></a>ATAN (выражение)

Возвращает значение арктангенса указанного числового выражения.

**Аргументы**

`expression` — значение в формате `Double`.

**Возвращаемое значение**

Объект `Double`.

**Пример**

`SqlServer.ATAN(9)`

## <a name="atn2expression-expression"></a>ATN2 (выражение, выражение)

Возвращает угол в радианах, тангенс которого находится в диапазоне между двумя заданными числовыми выражениями.

**Аргументы**

`expression` — значение в формате `Double`.

**Возвращаемое значение**

Объект `Double`.

**Пример**

`SqlServer.ATN2(9, 8)`

## <a name="ceilingexpression"></a>CEILING (выражение)

Преобразует указанное выражение в наименьшее целое число, большее или равное данному выражению.

**Аргументы**

`expression`: значение типа `Int32`, `Int64`, `Double` или `Decimal`.

**Возвращаемое значение**

`Int32`,, `Int64` `Double` Или `Decimal` .

**Пример**

[!code-sql[DP EntityServices Concepts#SQLSERVER_CEILING](~/samples/snippets/tsql/VS_Snippets_Data/dp entityservices concepts/tsql/entitysql.sql#sqlserver_ceiling)]

## <a name="cosexpression"></a>COS (выражение)

Вычисляет тригонометрический косинус указанного угла в радианах.

**Аргументы**

`expression` — значение в формате `Double`.

**Возвращаемое значение**

Объект `Double`.

**Пример**

`SqlServer.COS(45)`

## <a name="cotexpression"></a>COT (выражение)

Вычисляет тригонометрический котангенс указанного угла в радианах.

**Аргументы**

`expression` — значение в формате `Double`.

**Возвращаемое значение**

Объект `Double`.

**Пример**

`SqlServer.COT(60)`
  
## <a name="degreesradians"></a>ГРАДУСы (радианы)

Возвращает соответствующее значение угла в градусах.

**Аргументы**

`expression`: значение типа `Int32`, `Int64`, `Double` или `Decimal`.

**Возвращаемое значение**

`Int32`,, `Int64` `Double` Или `Decimal` .

**Пример**

`SqlServer.DEGREES(3.1)`

## <a name="expexpression"></a>EXP (выражение)

Вычисляет экспоненту заданного числового выражения.

**Аргументы**

`expression` — значение в формате `Double`.

**Возвращаемое значение**

Объект `Double`.

**Пример**`SqlServer.EXP(1)`

## <a name="floorexpression"></a>FLOOR (выражение)

Преобразует указанное выражение в наибольшее целое число, меньшее или равное данному выражению.

**Аргументы**

`expression` — значение в формате `Double`.

**Возвращаемое значение**

Объект `Double`.

**Пример**

[!code-sql[DP EntityServices Concepts#SQLSERVER_FLOOR](~/samples/snippets/tsql/VS_Snippets_Data/dp entityservices concepts/tsql/entitysql.sql#sqlserver_floor)]

## <a name="logexpression"></a>LOG (выражение)

Вычисляет натуральный логарифм заданного выражения типа `float`.

**Аргументы**

`expression` — значение в формате `Double`.

**Возвращаемое значение**

Объект `Double`.

**Пример**

`SqlServer.LOG(100)`

## <a name="log10expression"></a>LOG10 (выражение)

Возвращает десятичный логарифм указанного выражения типа `Double`.

**Аргументы**

`expression` — значение в формате `Double`.

**Возвращаемое значение**

Объект `Double`.

**Пример**

`SqlServer.LOG10(100)`

## <a name="pi"></a>PI ()

Возвращает константу «пи» в виде значения типа `Double`.

**Возвращаемое значение**

Объект `Double`.

**Пример**

`SqlServer.PI()`

## <a name="powernumeric_expression-power_expression"></a>МОЩНОСТЬ (numeric_expression, power_expression)

Вычисляет значение указанного выражения, возведенного в заданную степень.

**Аргументы**

|  |  |
|--|--|
|`numeric_expression`| `Int32`,, `Int64` `Double` Или `Decimal` .|
|`power_expression`| Объект `Double` , представляющий степень, до которой вызывается `numeric_expression` .|

**Возвращаемое значение**

Значение заданного выражения `numeric_expression` в указанной степени `power_expression`.

**Пример**

`SqlServer.POWER(2,7)`

## <a name="radiansexpression"></a>РАДИАНы (выражение)

Преобразует градусы в радианы.

**Аргументы**

`expression`: значение типа `Int32`, `Int64`, `Double` или `Decimal`.

**Возвращаемое значение**

`Int32`,, `Int64` `Double` Или `Decimal` .

**Пример**

`SqlServer.RADIANS(360.0)`

## <a name="randseed"></a>RAND ([начальное значение])

Возвращает случайное значение от 0 до 1.

**Аргументы**

Начальное значение в виде `Int32` . Если начальное значение не задано, то компонент SQL Server Database Engine присваивает случайно выбранное начальное значение. Для указанного начального значения возвращаемый результат всегда будет один и тот же.

**Возвращаемое значение**

Случайное значение типа `Double` от 0 до 1.

**Пример**

`SqlServer.RAND()`
  
## <a name="roundnumeric_expression-lengthfunction"></a>ROUND (numeric_expression, длина [, функция])

Возвращает числовое выражение, округленное до указанной длины или точности.

**Аргументы**

|  |  |
|--|--|
|`numeric_expression`| `Int32`,, `Int64` `Double` Или `Decimal` .
|`length`| Значение типа `Int32`, указывающее точность, до которой должно быть округлено значение аргумента `numeric_expression`. Если аргумент `length` является положительным числом, значение `numeric_expression` округляется до числа десятичных разрядов, указанных аргументом `length`. Если аргумент `length` является отрицательным числом, значение `numeric_expression` округляется слева от десятичной запятой, как указано аргументом `length`.|
|`function` | Необязательный элемент. Объект `Int32` , представляющий тип выполняемой операции. Если функция опущена или имеет значение 0 (по умолчанию), `numeric_expression` то параметр округляется. Если указано значение, отличное от 0, `numeric_expression` усекается. |

**Возвращаемое значение**

Значение заданного выражения `numeric_expression` в указанной степени `power_expression`.

**Пример**

`SqlServer.ROUND(748.58, -3)`

## <a name="signexpression"></a>SIGN (выражение)

Возвращает положительное (+1), нулевое (0) или отрицательное (-1) значение, обозначающее знак заданного выражения.

**Аргументы**

`expression`: `Int32`, `Int64`, `Double` или `Decimal`

**Возвращаемое значение**

`Int32`,, `Int64` `Double` Или `Decimal` .

**Пример**

`SqlServer.SIGN(-10)`

## <a name="sinexpression"></a>SIN (выражение)

Вычисляет тригонометрический синус заданного угла в радианах и возвращает выражение типа `Double`.

**Аргументы**

`expression` — значение в формате `Double`.

**Возвращаемое значение**

Объект `Double`.

**Пример**`SqlServer.SIN(20)`

## <a name="sqrtexpression"></a>SQRT (выражение)

Возвращает квадратный корень указанного выражения.

**Аргументы**

`expression` — значение в формате `Double`.

**Возвращаемое значение**

Объект `Double`.

**Пример**`SqlServer.SQRT(3600)`

## <a name="squareexpression"></a>SQUARE (выражение)

Возвращает значение указанного выражения в квадрате.

**Аргументы**

`expression` — значение в формате `Double`.

**Возвращаемое значение**

Объект `Double`.

**Пример**

`SqlServer.SQUARE(25)`

## <a name="tanexpression"></a>TAN (выражение)

Вычисляет тангенс заданного выражения.

**Аргументы**

`expression`: `Double`

**Возвращаемое значение**

`Double`

**Пример**

`SqlServer.TAN(45.0)`
  
## <a name="see-also"></a>См. также

- [Математические функции (Transact-SQL)](/sql/t-sql/functions/mathematical-functions-transact-sql)
- [Функции SqlClient для Entity Framework](sqlclient-for-ef-functions.md)

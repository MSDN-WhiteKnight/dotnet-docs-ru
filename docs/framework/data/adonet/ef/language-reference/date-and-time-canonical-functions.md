---
description: 'Дополнительные сведения: канонические функции даты и времени'
title: Канонические функции даты и времени
ms.date: 03/30/2017
ms.assetid: 9628b74f-1585-436a-b385-8b02ed0cdd63
ms.openlocfilehash: 3c57edc613e5ef871aa3359ef7609e6c0892efc4
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99724795"
---
# <a name="date-and-time-canonical-functions"></a>Канонические функции даты и времени

Язык [!INCLUDE[esql](../../../../../../includes/esql-md.md)] включает канонические функции даты и времени.  
  
## <a name="remarks"></a>Remarks  

 В следующей таблице показаны [!INCLUDE[esql](../../../../../../includes/esql-md.md)] канонические функции даты и времени. `datetime` является <xref:System.DateTime> значением.  
  
|Компонент|Описание|  
|--------------|-----------------|  
|`AddNanoseconds(expression,number)`|Добавляет указанное количество `number` наносекунд к значению `expression`.<br /><br /> **Аргументы**<br /><br /> `expression`: `DateTime`, `DateTimeOffset` или `Time`.<br /><br /> `number`: `Int32`.<br /><br /> **Возвращаемое значение**<br /><br /> Тип параметра `expression`.|  
|`AddMicroseconds(expression,number)`|Добавляет указанное количество `number` микросекунд к значению `expression`.<br /><br /> **Аргументы**<br /><br /> `expression`: `DateTime`, `DateTimeOffset` или `Time`.<br /><br /> `number`: `Int32`.<br /><br /> **Возвращаемое значение**<br /><br /> Тип параметра `expression`.|  
|`AddMilliseconds(expression,number)`|Добавляет указанное количество `number` миллисекунд к значению `expression`.<br /><br /> **Аргументы**<br /><br /> `expression`: `DateTime`, `DateTimeOffset` или `Time`.<br /><br /> `number`: `Int32`.<br /><br /> **Возвращаемое значение**<br /><br /> Тип параметра `expression`.|  
|`AddSeconds(expression,number)`|Добавляет указанное количество `number` секунд к значению `expression`.<br /><br /> **Аргументы**<br /><br /> `expression`: `DateTime`, `DateTimeOffset` или `Time`.<br /><br /> `number`: `Int32`.<br /><br /> **Возвращаемое значение**<br /><br /> Тип параметра `expression`.|  
|`AddMinutes(expression,number)`|Добавляет указанное количество `number` минут к значению `expression`.<br /><br /> **Аргументы**<br /><br /> `expression`: `DateTime`, `DateTimeOffset` или `Time`.<br /><br /> `number`: `Int32`.<br /><br /> **Возвращаемое значение**<br /><br /> Тип параметра `expression`.|  
|`AddHours(expression,number)`|Добавляет указанное количество `number` часов к значению `expression`.<br /><br /> **Аргументы**<br /><br /> `expression`: `DateTime`, `DateTimeOffset` или `Time`.<br /><br /> `number`: `Int32`.<br /><br /> **Возвращаемое значение**<br /><br /> Тип параметра `expression`.|  
|`AddDays(expression,number)`|Добавляет указанное количество `number` дней к значению `expression`.<br /><br /> **Аргументы**<br /><br /> `expression`: `DateTime` или `DateTimeOffset`.<br /><br /> `number`: `Int32`.<br /><br /> **Возвращаемое значение**<br /><br /> Тип параметра `expression`.|  
|`AddMonths(expression,number)`|Добавляет указанное количество `number` месяцев к значению `expression`.<br /><br /> **Аргументы**<br /><br /> `expression`: `DateTime` или `DateTimeOffset`.<br /><br /> `number`: `Int32`.<br /><br /> **Возвращаемое значение**<br /><br /> Тип параметра `expression`.|  
|`AddYears(expression,number)`|Добавляет указанное количество `number` лет к значению `expression`.<br /><br /> **Аргументы**<br /><br /> `expression`: `DateTime` или `DateTimeOffset`.<br /><br /> `number`: `Int32`.<br /><br /> **Возвращаемое значение**<br /><br /> Тип параметра `expression`.|  
|`CreateDateTime(year,month,day,hour,minute,second)`|Возвращает текущие дату и время сервера в часовом поясе сервера в виде нового значения `DateTime`.<br /><br /> **Аргументы**<br /><br /> `year`, `month`, `day`, `hour`, `minute`, `Int16` и `Int32`.<br /><br /> `second`: `Double`.<br /><br /> **Возвращаемое значение**<br /><br /> Объект `DateTime`.|  
|`CreateDateTimeOffset(year,month,day,hour,minute,second,tzoffset)`|Возвращает текущие дату и время сервера относительно времени в формате UTC в виде нового значения `DateTimeOffset`.<br /><br /> **Аргументы**<br /><br /> `year`, `month`, `day`, `hour`, `minute`, `tzoffset`: `Int32`.<br /><br /> `second`: `Double`.<br /><br /> **Возвращаемое значение**<br /><br /> Объект `DateTimeOffset`.|  
|`CreateTime(hour,minute,second)`|Возвращает текущее время в виде нового значения `Time`.<br /><br /> **Аргументы**<br /><br /> `hour`, `minute` и `Int32`.<br /><br /> `second`: `Double`.<br /><br /> **Возвращаемое значение**<br /><br /> Объект `Time`.|  
|`CurrentDateTime()`|Возвращает текущую дату и время сервера в часовом поясе сервера как значение типа `DateTime`.<br /><br /> **Возвращаемое значение**<br /><br /> Объект `DateTime`.|  
|`CurrentDateTimeOffset()`|Возвращает текущие дату, время и смещение в виде значения `DateTimeOffset`.<br /><br /> **Возвращаемое значение**<br /><br /> Объект `DateTimeOffset`.|  
|`CurrentUtcDateTime()`|Возвращает текущие дату и время сервера по Гринвичу в виде значения типа <xref:System.DateTime>.<br /><br /> **Возвращаемое значение**<br /><br /> Объект `DateTime`.|  
|`Day(expression)`|Возвращает относящуюся к числу месяца часть значения `expression` в качестве значения типа `Int32` от 1 до 31.<br /><br /> **Аргументы**<br /><br /> Значение типа `DateTime` и `DateTimeOffset`.<br /><br /> **Возвращаемое значение**<br /><br /> Объект `Int32`.<br /><br /> **Пример**<br /><br /> `-- The following example returns 12.`<br /><br /> `Day(cast('03/12/1998' as DateTime))`|  
|`DayOfYear(expression)`|Возвращает относящуюся к дню года часть значения `expression` в виде значения типа `Int32` от 1 до 366, где значение 366 возвращается для последнего дня високосного года.<br /><br /> **Аргументы**<br /><br /> `DateTime` или `DateTimeOffset`.<br /><br /> **Возвращаемое значение**<br /><br /> Объект `Int32`.|  
|`DiffNanoseconds(startExpression,endExpression)`|Возвращает разность между `startExpression` и `endExpression` в наносекундах.<br /><br /> **Аргументы**<br /><br /> `startExpression`, `endExpression`, `DateTime`, `DateTimeOffset` или `Time` **Примечание.** `startExpression` и `endExpression` должны иметь один и тот же тип.   <br /><br /> **Возвращаемое значение**<br /><br /> Объект `Int32`.|  
|`DiffMilliseconds(startExpression,endExpression)`|Возвращает разность между `startExpression` и `endExpression` в миллисекундах.<br /><br /> **Аргументы**<br /><br /> `startExpression`, `endExpression`, `DateTime`, `DateTimeOffset` или `Time` **Примечание.** `startExpression` и `endExpression` должны иметь один и тот же тип.   <br /><br /> **Возвращаемое значение**<br /><br /> Объект `Int32`.|  
|`DiffMicroseconds(startExpression,endExpression)`|Возвращает разность между `startExpression` и `endExpression` в микросекундах.<br /><br /> **Аргументы**<br /><br /> `startExpression`, `endExpression`, `DateTime`, `DateTimeOffset` или `Time` **Примечание.** `startExpression` и `endExpression` должны иметь один и тот же тип.   <br /><br /> **Возвращаемое значение**<br /><br /> Объект `Int32`.|  
|`DiffSeconds(startExpression,endExpression)`|Возвращает разность между `startExpression` и `endExpression` в секундах.<br /><br /> **Аргументы**<br /><br /> `startExpression`, `endExpression`, `DateTime`, `DateTimeOffset` или `Time` **Примечание.** `startExpression` и `endExpression` должны иметь один и тот же тип.   <br /><br /> **Возвращаемое значение**<br /><br /> Объект `Int32`.|  
|`DiffMinutes(startExpression,endExpression)`|Возвращает разность между `startExpression` и `endExpression` в минутах.<br /><br /> **Аргументы**<br /><br /> `startExpression`, `endExpression`, `DateTime`, `DateTimeOffset` или `Time` **Примечание.** `startExpression` и `endExpression` должны иметь один и тот же тип.   <br /><br /> **Возвращаемое значение**<br /><br /> Объект `Int32`.|  
|`DiffHours(startExpression,endExpression)`|Возвращает разность между `startExpression` и `endExpression` в часах.<br /><br /> **Аргументы**<br /><br /> `startExpression`, `endExpression`, `DateTime`, `DateTimeOffset` или `Time` **Примечание.** `startExpression` и `endExpression` должны иметь один и тот же тип.   <br /><br /> **Возвращаемое значение**<br /><br /> Объект `Int32`.|  
|`DiffDays(startExpression,endExpression)`|Возвращает разность между `startExpression` и `endExpression` в днях.<br /><br /> **Аргументы**<br /><br /> `startExpression`, `endExpression`: `DateTime` или `DateTimeOffset`. **Примечание.** `startExpression` и `endExpression` должны иметь один и тот же тип.   <br /><br /> **Возвращаемое значение**<br /><br /> Объект `Int32`.|  
|`DiffMonths(startExpression,endExpression)`|Возвращает разность между `startExpression` и `endExpression` в месяцах.<br /><br /> **Аргументы**<br /><br /> `startExpression`, `endExpression`: `DateTime` или `DateTimeOffset`. **Примечание.** `startExpression` и `endExpression` должны иметь один и тот же тип.   <br /><br /> **Возвращаемое значение**<br /><br /> Объект `Int32`.|  
|`DiffYears(startExpression,endExpression)`|Возвращает разность между `startExpression` и `endExpression` в годах.<br /><br /> **Аргументы**<br /><br /> `startExpression`, `endExpression`: `DateTime` или `DateTimeOffset`. **Примечание.** `startExpression` и `endExpression` должны иметь один и тот же тип.   <br /><br /> **Возвращаемое значение**<br /><br /> Объект `Int32`.|  
|`GetTotalOffsetMinutes(datetimeoffset)`|Возвращает число минут, на которые `datetimeoffset` смещено относительно времени по Гринвичу (GMT). Обычно это значение находится в диапазоне от +780 до -780 (плюс-минус 13 ч). **Примечание.**  Эта функция поддерживается только в SQL Server 2008. <br /><br /> **Аргументы**<br /><br /> Объект `DateTimeOffset`.<br /><br /> **Возвращаемое значение**<br /><br /> Объект `Int32`.|  
|`Hour(expression)`|Возвращает для `expression` значение часа типа `Int32` от 0 до 23.<br /><br /> **Аргументы**<br /><br /> Значение типа `DateTime, Time` и `DateTimeOffset`.<br /><br /> **Пример**<br /><br /> `-- The following example returns 22.`<br /><br /> `Hour(cast('22:35:5' as DateTime))`|  
|`Millisecond(expression)`|Возвращает для `expression` значение миллисекунд типа `Int32` от 0 до 999.<br /><br /> **Аргументы**<br /><br /> Значение типа `DateTime, Time` и `DateTimeOffset`.<br /><br /> **Возвращаемое значение**<br /><br /> Объект `Int32`.|  
|`Minute(expression)`|Возвращает для `expression` значение минут типа `Int32` от 0 до 59.<br /><br /> **Аргументы**<br /><br /> `DateTime, Time` или `DateTimeOffset`.<br /><br /> **Возвращаемое значение**<br /><br /> Объект `Int32`.<br /><br /> **Пример**<br /><br /> `-- The following example returns 35`<br /><br /> `Minute(cast('22:35:5' as DateTime))`|  
|`Month(expression)`|Возвращает для `expression` значение месяца типа `Int32` от 1 до 12.<br /><br /> **Аргументы**<br /><br /> `DateTime` или `DateTimeOffset`.<br /><br /> **Возвращаемое значение**<br /><br /> Объект `Int32`.<br /><br /> **Пример**<br /><br /> `-- The following example returns 3.`<br /><br /> `Month(cast('03/12/1998' as DateTime))`|  
|`Second(expression)`|Возвращает для `expression` значение секунд типа `Int32` от 0 до 59.<br /><br /> **Аргументы**<br /><br /> Значение типа `DateTime, Time` и `DateTimeOffset`.<br /><br /> **Возвращаемое значение**<br /><br /> Объект `Int32`.<br /><br /> **Пример**<br /><br /> `-- The following example returns 5`<br /><br /> `Second(cast('22:35:5' as DateTime))`|  
|`TruncateTime(expression)`|Возвращает значение `expression` с усеченным значением времени.<br /><br /> **Аргументы**<br /><br /> `DateTime` или `DateTimeOffset`.<br /><br /> **Возвращаемое значение**<br /><br /> Тип параметра `expression`.|  
|`Year(expression)`|Возвращает часть года в `expression` виде `Int32` `YYYY` .<br /><br /> **Аргументы**<br /><br /> Значение типа `DateTime` и `DateTimeOffset`.<br /><br /> **Возвращаемое значение**<br /><br /> Объект `Int32`.<br /><br /> **Пример**<br /><br /> `-- The following example returns 1998.`<br /><br /> `Year(cast('03/12/1998' as DateTime))`|  
  
 Эти функции возвращают `null` при получении на входе `null`.  
  
 Эквивалентную функциональность предоставляет управляемый поставщик клиента Microsoft SQL. Дополнительные сведения см. в разделе [SqlClient для функций Entity Framework](../sqlclient-for-ef-functions.md).  
  
## <a name="see-also"></a>См. также

- [Канонические функции](canonical-functions.md)

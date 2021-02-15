---
description: 'Дополнительные сведения: параметры процедуры и аргументы (Visual Basic)'
title: Параметры и аргументы процедуры
ms.date: 07/20/2015
helpviewer_keywords:
- procedures [Visual Basic], arguments
- procedures [Visual Basic], argument lists
- values [Visual Basic], passing to procedures
- arguments [Visual Basic], passing
- procedures [Visual Basic], parameters
- Visual Basic code, argument lists
- Visual Basic code, procedures
- parameters [Visual Basic], Visual Basic procedures
- parameters [Visual Basic], lists
- arguments [Visual Basic], Visual Basic procedures
- arguments [Visual Basic], procedures
- parameter lists [Visual Basic]
- Visual Basic code, parameter lists
- argument lists [Visual Basic]
- procedures [Visual Basic], parameter lists
ms.assetid: ff275aff-aa13-40df-bd4c-63486db8c1e9
ms.openlocfilehash: c2239c76450f503e74dbf5f191cd212e05d11600
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100423164"
---
# <a name="procedure-parameters-and-arguments-visual-basic"></a>Параметры и аргументы процедуры (Visual Basic)

В большинстве случаев для процедуры требуются некоторые сведения о обстоятельствах, в которых она была вызвана. Процедура, выполняющая повторяющиеся или общие задачи, использует разные сведения для каждого вызова. Эти сведения состоят из переменных, констант и выражений, которые передаются в процедуру при ее вызове.  
  
 *Параметр* представляет значение, которое процедура предполагает указать при ее вызове. В объявлении процедуры определяются ее параметры.  
  
 Можно определить процедуру без параметров, один параметр или несколько. Часть определения процедуры, указывающая параметры, называется *списком параметров*.  
  
 *Аргумент* представляет значение, указываемое в параметре процедуры при вызове процедуры. Вызывающий код предоставляет аргументы при вызове процедуры. Часть вызова процедуры, указывающая аргументы, называется *списком аргументов*.  
  
 На следующем рисунке показан код, вызывающий процедуру `safeSquareRoot` из двух различных мест. Первый вызов передает значение переменной `x` (4,0) в параметр `number` , а возвращаемое значение в `root` (2,0) присваивается переменной `y` . Второй вызов передает литеральное значение 9,0 в `number` , а затем присваивает возвращаемое значение (3,0) переменной `z` .  
  
 ![Схема, показывающая передачу аргумента в параметр](./media/procedure-parameters-and-arguments/pass-argument-parameter.gif)  
  
 Дополнительные сведения см. в разделе [различия между параметрами и аргументами](./differences-between-parameters-and-arguments.md).  
  
## <a name="parameter-data-type"></a>Тип данных параметра  

 Тип данных для параметра определяется с помощью `As` предложения в его объявлении. Например, следующая функция принимает строку и целое число.  
  
 [!code-vb[VbVbcnProcedures#32](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbcnProcedures/VB/Class1.vb#32)]  
  
 Если параметр проверки типов ([оператор Option строго](../../../language-reference/statements/option-strict-statement.md)) является `Off,` `As` предложением необязательным, за исключением того, что если какой-либо параметр использует его, все параметры должны использовать его. Если проверка типа имеет значение `On` , `As` предложение является обязательным для всех параметров процедуры.  
  
 Если вызывающий код должен предоставить аргумент с типом данных, отличным от типа соответствующего параметра, например, `Byte` в качестве `String` параметра, необходимо выполнить одно из следующих действий.  
  
- Указывайте только аргументы с типами данных, которые расширяются до типа данных параметра;  
  
- Задайте значение `Option Strict Off` , разрешающее неявные сужающие преобразования;  
  
- Используйте ключевое слово преобразования для явного преобразования типа данных.  
  
### <a name="type-parameters"></a>Параметры типа  

 *Универсальная процедура* также определяет один или несколько *параметров типа* в дополнение к обычным параметрам. Универсальная процедура позволяет вызывающему коду передавать различные типы данных при каждом вызове процедуры, чтобы можно было адаптировать типы данных к требованиям каждого отдельного вызова. См. раздел [Generic Procedures in Visual Basic](../data-types/generic-procedures.md).  
  
## <a name="see-also"></a>См. также раздел

- [Процедуры](./index.md)
- [Подпрограммы](./sub-procedures.md)
- [Процедуры функций](./function-procedures.md)
- [Процедуры свойств](./property-procedures.md)
- [Процедуры операторов](./operator-procedures.md)
- [Практическое руководство. Определение параметра для процедуры](./how-to-define-a-parameter-for-a-procedure.md)
- [Практическое руководство. Передача аргументов в процедуру](./how-to-pass-arguments-to-a-procedure.md)
- [Передача аргументов по значению и по ссылке](./passing-arguments-by-value-and-by-reference.md)
- [Перегрузка процедур](./procedure-overloading.md)
- [Преобразование типов в Visual Basic](../data-types/type-conversions.md)

---
description: 'Дополнительные сведения о: BC40027: тип возвращаемого значения функции "" несовместим с <procedurename> CLS'
title: Тип возвращаемого значения функции <procedurename> несовместим с CLS
ms.date: 07/20/2015
f1_keywords:
- bc40027
- vbc40027
helpviewer_keywords:
- BC40027
ms.assetid: 33c088c7-48e7-400c-920e-6d8967e1f3fc
ms.openlocfilehash: df0cdb10ebc62a833cef89d3e82bc1ed756c556e
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99675121"
---
# <a name="bc40027-return-type-of-function-procedurename-is-not-cls-compliant"></a>BC40027: тип возвращаемого значения функции "" несовместим с \<procedurename> CLS

`Function`Процедура помечена как `<CLSCompliant(True)>` , но возвращает тип, помеченный как `<CLSCompliant(False)>` , не помечен или не может быть указан, поскольку является несоответствующим типом.

 Для соответствия требованиям, описанным в статье [Независимость от языка и независимые от языка компоненты](../../../standard/language-independence-and-language-independent-components.md) (CLS), процедура должна использовать только типы, совместимые с CLS. Это касается типов параметров, типа возвращаемого значения и типов всех локальных переменных.

 Следующие типы данных Visual Basic несовместимы с CLS:

- [Тип данных SByte](../data-types/sbyte-data-type.md)

- [Тип данных UInteger](../data-types/uinteger-data-type.md)

- [Тип данных ULong](../data-types/ulong-data-type.md)

- [Тип данных UShort](../data-types/ushort-data-type.md)

 При применении атрибута <xref:System.CLSCompliantAttribute> к программному элементу вы задаете для параметра `isCompliant` атрибута значение `True` или `False` , чтобы указать совместимость или несовместимость. Для этого параметра нет значения по умолчанию, и вы должны предоставить значение.

 Если вы не применяете <xref:System.CLSCompliantAttribute> к элементу, он считается несовместимым.

 По умолчанию данное сообщение является предупреждением. Сведения о сокрытии предупреждений или обработке предупреждений как ошибок см. в разделе [Configuring Warnings in Visual Basic](/visualstudio/ide/configuring-warnings-in-visual-basic).

 **Идентификатор ошибки:** BC40027

## <a name="to-correct-this-error"></a>Исправление ошибки

- Если `Function` процедура должна возвращать этот конкретный тип, удалите <xref:System.CLSCompliantAttribute> . Процедура не может быть совместимой с CLS.

- Если `Function` процедура должна быть совместимой с CLS, измените тип возвращаемого значения на ближайший CLS-совместимый тип. Например, вместо `UInteger` вы можете использовать `Integer` , если вам не нужен диапазон значений, превышающий 2 147 483 647. Если вам нужен расширенный диапазон, вы можете заменить `UInteger` на `Long`.

- При взаимоработе с автоматизацией или COM-объектами Помните, что некоторые типы имеют разную ширину данных, чем в платформа .NET Framework. Например, данные типа `int` часто являются 16-битными в других средах. Если вы возвращаете 16-разрядное целое число в такой компонент, объявите его как `Short` вместо `Integer` в управляемом коде Visual Basic.

---
description: 'Дополнительные сведения о: BC40032: базовый тип <typename> перечисления несовместим с CLS'
title: Базовый тип <typename> перечисления несовместим с CLS
ms.date: 07/20/2015
f1_keywords:
- vbc40032
- bc40032
helpviewer_keywords:
- BC40032
ms.assetid: 32bf1949-fd73-456c-a323-bf1ffe1320ed
ms.openlocfilehash: aebee5a9e0cd7f2e780d0171ad59dcfd4fd1d940
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99674796"
---
# <a name="bc40032-underlying-type-typename-of-enum-is-not-cls-compliant"></a>BC40032: базовый тип \<typename> перечисления несовместим с CLS

Тип данных, указанный для этого перечисления, не входит в [независимость от языка и Language-Independent компонентов](../../../standard/language-independence-and-language-independent-components.md) (CLS). Это не ошибка в компоненте, так как платформа .NET Framework и Visual Basic поддерживают этот тип данных. Однако другой компонент, написанный в строго CLS-совместимом коде, может не поддерживать этот тип данных. Такой компонент, возможно, не сможет успешно взаимодействовать с компонентом.

 Следующие типы данных Visual Basic несовместимы с CLS:

- [Тип данных SByte](../data-types/sbyte-data-type.md)

- [Тип данных UInteger](../data-types/uinteger-data-type.md)

- [Тип данных ULong](../data-types/ulong-data-type.md)

- [Тип данных UShort](../data-types/ushort-data-type.md)

 По умолчанию данное сообщение является предупреждением. Дополнительные сведения о скрытии предупреждений или обработке предупреждений как ошибок см. в разделе [Configuring Warnings in Visual Basic](/visualstudio/ide/configuring-warnings-in-visual-basic).

 **Идентификатор ошибки:** BC40032

## <a name="to-correct-this-error"></a>Исправление ошибки

- Если компонент работает только с другими компонентами платформа .NET Framework или не взаимодействует с другими компонентами, изменять ничего не нужно.

- Если вы взаимодействуете с компонентом, не написанным для платформа .NET Framework, вы можете определить, поддерживает ли этот тип данных либо с помощью отражения, либо из документации. Если это так, вам не нужно ничего менять.

- При взаимоработе с компонентом, который не поддерживает этот тип данных, необходимо заменить его ближайшим CLS-совместимым типом. Например, вместо `UInteger` вы можете использовать `Integer` , если вам не нужен диапазон значений, превышающий 2 147 483 647. Если вам нужен расширенный диапазон, вы можете заменить `UInteger` на `Long`.

- При взаимоработе с автоматизацией или COM-объектами Помните, что некоторые типы имеют разную ширину данных, чем в платформа .NET Framework. Например, данные типа `uint` часто являются 16-битными в других средах. При передаче 16-разрядного аргумента в такой компонент объявите его как `UShort` вместо `UInteger` в управляемом коде Visual Basic.

## <a name="see-also"></a>См. также

- [Reflection (Visual Basic)](../../programming-guide/concepts/reflection.md) (Отражение (Visual Basic))
- [Отражение](../../../framework/reflection-and-codedom/reflection.md)

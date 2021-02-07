---
description: 'Дополнительные сведения о: BC40041: тип несовместим с <typename> CLS'
title: Тип <typename> несовместим с CLS
ms.date: 07/20/2015
f1_keywords:
- bc40041
- vbc40041
helpviewer_keywords:
- BC40041
ms.assetid: 634132c2-5646-44aa-98c6-f773e2e63882
ms.openlocfilehash: a1e807dba64f2fce70b0fb39147087d91ca80fbc
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99675043"
---
# <a name="bc40041-type-typename-is-not-cls-compliant"></a>BC40041: тип несовместим с \<typename> CLS

Переменная, свойство или возвращаемое значение функции объявлены с типом данных, который не является CLS-совместимым.

 Чтобы приложение было совместимо с [независимостьм от языка и Language-Independent компонентами](../../../standard/language-independence-and-language-independent-components.md) (CLS), оно должно использовать только совместимые с CLS типы.

 Следующие типы данных Visual Basic несовместимы с CLS:

- [Тип данных SByte](../data-types/sbyte-data-type.md)

- [Тип данных UInteger](../data-types/uinteger-data-type.md)

- [Тип данных ULong](../data-types/ulong-data-type.md)

- [Тип данных UShort](../data-types/ushort-data-type.md)

 **Идентификатор ошибки:** BC40041

## <a name="to-correct-this-error"></a>Исправление ошибки

- Если приложение должно быть совместимо с CLS, измените тип данных этого элемента на ближайший CLS-совместимый тип. Например, вместо `UInteger` вы можете использовать `Integer` , если вам не нужен диапазон значений, превышающий 2 147 483 647. Если вам нужен расширенный диапазон, вы можете заменить `UInteger` на `Long`.

- Если приложение не обязательно должно быть CLS-совместимым, вам не нужно ничего менять. Однако следует помнить о несоответствии.

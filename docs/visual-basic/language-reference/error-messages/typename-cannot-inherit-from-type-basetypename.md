---
description: 'Дополнительные сведения о: BC30910: " <typename> " не может наследовать от <type> " <basetypename> ", так как он расширяет доступ к базе <type> за пределами сборки'
title: <typename> не может наследоваться от <type><basetypename>, поскольку он расширяет доступ базового типа <type> за пределы сборки
ms.date: 07/20/2015
f1_keywords:
- vbc30910
- bc30910
helpviewer_keywords:
- BC30910
ms.assetid: 68fc05c5-5d55-4742-9a3b-ea04312594f4
ms.openlocfilehash: 332bfcbe9345f03605d6e1d6ded4a3e931ed491f
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99641100"
---
# <a name="bc30910-typename-cannot-inherit-from-type-basetypename-because-it-expands-the-access-of-the-base-type-outside-the-assembly"></a>BC30910: " \<typename> " не может наследовать от \<type> " \<basetypename> ", так как он расширяет доступ к базе \<type> за пределами сборки

Класс или интерфейс наследует от базового класса или интерфейса, но имеет менее четкий уровень доступа.

 Например, `Public` интерфейс наследует от `Friend` интерфейса, или `Protected` класс наследует от `Private` класса. Это предоставляет базовый класс или интерфейс для доступа за пределами предполагаемого уровня.

 **Идентификатор ошибки:** BC30910

## <a name="to-correct-this-error"></a>Исправление ошибки

- Измените уровень доступа производного класса или интерфейса, чтобы он был по крайней мере максимальным по отношению к базовому классу или интерфейсу.

     -или-

- Если требуется менее четкий уровень доступа, удалите `Inherits` оператор. Наследование от более ограниченного базового класса или интерфейса невозможно.

## <a name="see-also"></a>См. также

- [Оператор Class](../statements/class-statement.md)
- [Оператор Interface](../statements/interface-statement.md)
- [Inherits Statement](../statements/inherits-statement.md)
- [Уровни доступа в Visual Basic](../../programming-guide/language-features/declared-elements/access-levels.md)

---
description: 'Дополнительные сведения о: BC31102: метод доступа set свойства " <propertyname> " недоступен'
title: Метод доступа Set свойства <propertyname> недоступен
ms.date: 07/20/2015
f1_keywords:
- vbc31102
- bc31102
helpviewer_keywords:
- BC31102
ms.assetid: 6f7b31b7-3656-4ae1-8851-90f5f4c6950a
ms.openlocfilehash: da4d29933ca140bd9fa1a15758b64667013a8032
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99675082"
---
# <a name="bc31102-set-accessor-of-property-propertyname-is-not-accessible"></a>BC31102: метод доступа "Set" Свойства " \<propertyname> " недоступен

Оператор пытается сохранить значение свойства, если оно не имеет доступа к `Set` процедуре свойства.

 Если [инструкция SET](../statements/set-statement.md) помечена более ограниченным уровнем доступа, чем его [Инструкция Property](../statements/property-statement.md), попытка установить значение свойства может завершиться ошибкой в следующих случаях:

- `Set`Инструкция помечена как [закрытая](../modifiers/private.md) , а вызывающий код находится за пределами класса или структуры, в которой определено свойство.

- `Set`Инструкция помечена как [protected](../modifiers/protected.md) и вызывающий код не находится в классе или структуре, в которой определено свойство, и в производном классе.

- `Set`Инструкция помечена как [Friend](../modifiers/friend.md) , а вызывающий код — не в той сборке, в которой определено свойство.

 **Идентификатор ошибки:** BC31102

## <a name="to-correct-this-error"></a>Исправление ошибки

- Если вы управляете исходным кодом, определяющим свойство, попробуйте объявить `Set` процедуру с тем же уровнем доступа, что и само свойство.

- Если у вас нет контроля над исходным кодом, определяющим свойство, или необходимо ограничить `Set` уровень доступа к процедуре больше, чем само свойство, попробуйте переместить инструкцию, устанавливающую значение свойства, в область кода, имеющую Улучшенный доступ к свойству.

## <a name="see-also"></a>См. также

- [Процедуры свойств](../../programming-guide/language-features/procedures/property-procedures.md)
- [Практическое руководство. Объявление свойства со смешанным уровнем доступа](../../programming-guide/language-features/procedures/how-to-declare-a-property-with-mixed-access-levels.md)

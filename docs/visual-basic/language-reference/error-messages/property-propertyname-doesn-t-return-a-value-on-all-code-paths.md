---
description: 'Дополнительные сведения о: BC42107: свойство " <propertyname> " не возвращает значение для всех ветвей кода'
title: Свойство ''<propertyname>'' возвращает значение не для всех ветвей кода
ms.date: 07/20/2015
f1_keywords:
- bc42107
- vbc42107
helpviewer_keywords:
- BC42107
ms.assetid: 06800966-9c3b-4844-9f13-83ac95607d32
ms.openlocfilehash: 9aa0d6fea1feeaf7503f5f8831fbd3de910a4822
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99774893"
---
# <a name="bc42107-property-propertyname-doesnt-return-a-value-on-all-code-paths"></a>BC42107: свойство " \<propertyname> " не возвращает значение для всех ветвей кода

Свойство " \<propertyname> " не возвращает значение для всех ветвей кода. Во время выполнения может возникнуть исключение, связанное с пустой ссылкой, когда используется результат.

Процедура свойства `Get` имеет по крайней мере один возможный путь в коде, который не возвращает значение.

 Получить значение из процедуры свойства можно `Get` одним из следующих способов.

- Присвойте значение имени свойства, а затем выполните `Exit Property` инструкцию.

- Присвойте значение имени свойства, а затем выполните `End Get` инструкцию.

- Включите значение в [оператор return](../statements/return-statement.md).

Если элемент управления передается в `Exit Property` или `End Get` и вы не присвоили какое бы то ни было значение имени свойства, `Get` процедура возвращает значение по умолчанию для типа данных свойства. Дополнительные сведения см. в разделе «поведение» в [операторе Function](../statements/function-statement.md).

По умолчанию данное сообщение является предупреждением. Дополнительные сведения о скрытии предупреждений или обработке предупреждений как ошибок см. в разделе [Configuring Warnings in Visual Basic](/visualstudio/ide/configuring-warnings-in-visual-basic).

**Идентификатор ошибки:** BC42107

## <a name="to-correct-this-error"></a>Исправление ошибки

- Проверьте логику потока управления и убедитесь, что значение присваивается перед каждой инструкцией, которая вызывает возврат.

  Проще гарантировать, что каждый возврат из процедуры возвращает значение, если всегда используется `Return` оператор. В этом случае последняя инструкция `End Get` должна быть `Return` оператором.

## <a name="see-also"></a>См. также

- [Процедуры свойств](../../programming-guide/language-features/procedures/property-procedures.md)
- [Property Statement](../statements/property-statement.md)
- [Оператор Get](../statements/get-statement.md)

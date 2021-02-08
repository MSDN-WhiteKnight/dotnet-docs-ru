---
description: 'Дополнительные сведения о: BC42105: функция " <procedurename> " не возвращает значение для всех ветвей кода'
title: Функция <procedurename> возвращает значение не для всех путей выполнения
ms.date: 07/20/2015
f1_keywords:
- bc42105
- vbc42105
helpviewer_keywords:
- BC42105
ms.assetid: b6929bf4-a365-4a70-8dc9-6b0fc09e1468
ms.openlocfilehash: 2d0fa99906606228595a0c0d45f58dae0b269b77
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99796175"
---
# <a name="bc42105-function-procedurename-doesnt-return-a-value-on-all-code-paths"></a>BC42105: функция " \<procedurename> " не возвращает значение для всех ветвей кода

Функция " \<procedurename> " не возвращает значение для всех ветвей кода. У вас отсутствует оператор "return"?

 `Function`Процедура имеет по крайней мере один возможный путь в коде, который не возвращает значение.

 Получить значение из `Function` процедуры можно одним из следующих способов.

- Включите значение в [оператор return](../statements/return-statement.md).

- Присвойте значение `Function` имени процедуры, а затем выполните `Exit Function` инструкцию.

- Присвойте значение `Function` имени процедуры, а затем выполните `End Function` инструкцию.

 Если элемент управления передается в `Exit Function` или `End Function` и вы не назначили какое бы то ни было значение имени процедуры, процедура возвращает значение по умолчанию для возвращаемого типа данных. Дополнительные сведения см. в разделе «поведение» в [операторе Function](../statements/function-statement.md).

 По умолчанию данное сообщение является предупреждением. Дополнительные сведения о скрытии предупреждений или обработке предупреждений как ошибок см. в разделе [Configuring Warnings in Visual Basic](/visualstudio/ide/configuring-warnings-in-visual-basic).

 **Идентификатор ошибки:** BC42105

## <a name="to-correct-this-error"></a>Исправление ошибки

- Проверьте логику потока управления и убедитесь, что значение присваивается перед каждой инструкцией, которая вызывает возврат.

     Проще гарантировать, что каждый возврат из процедуры возвращает значение, если всегда используется `Return` оператор. В этом случае последняя инструкция `End Function` должна быть `Return` оператором.

## <a name="see-also"></a>См. также

- [Процедуры функций](../../programming-guide/language-features/procedures/function-procedures.md)
- [Оператор Function](../statements/function-statement.md)
- [Страница "Компиляция" в конструкторе проектов (Visual Basic)](/visualstudio/ide/reference/compile-page-project-designer-visual-basic)

---
title: Руководство по программированию на C#. Модификаторы доступа
description: Все типы и члены в C# имеют уровень доступности, определяющий возможность их использования из другого кода. Ознакомьтесь с этим списком модификаторов доступа.
ms.date: 03/08/2020
helpviewer_keywords:
- C# Language, access modifiers
- access modifiers [C#], about
ms.assetid: 6e81ee82-224f-4a12-9baf-a0dca2656c5b
ms.openlocfilehash: 168965a3d7f5c3d2436bfdc25edb6c78cdabbc05
ms.sourcegitcommit: 9c589b25b005b9a7f87327646020eb85c3b6306f
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/06/2021
ms.locfileid: "102258342"
---
# <a name="access-modifiers-c-programming-guide"></a>Модификаторы доступа (Руководство по программированию в C#)

Все типы и члены типов имеют уровень доступности. Он определяет возможность их использования из другого кода в вашей или в других сборках. Следующие модификаторы доступа позволяют указать доступность типа или члена при объявлении:

- [public](../../language-reference/keywords/public.md): Доступ к типу или члену возможен из любого другого кода в той же сборке или другой сборке, ссылающейся на него.
- [private](../../language-reference/keywords/private.md): доступ к типу или члену возможен только из кода в том же объекте `class` или `struct`.
- [protected](../../language-reference/keywords/protected.md): доступ к типу или члену возможен только из кода в том же объекте `class` либо в `class`, производном от этого `class`.
- [internal](../../language-reference/keywords/internal.md): Доступ к типу или члену возможен из любого кода в той же сборке, но не из другой сборки.
- [protected internal](../../language-reference/keywords/protected-internal.md): доступ к типу или члену возможен из любого кода в той сборке, где он был объявлен, или из производного `class` в другой сборке.
- [private protected](../../language-reference/keywords/private-protected.md): доступ к типу или члену возможен только из его объявляющей сборки из кода в том же `class` либо в типе, производном от этого `class`.

В следующих примерах показано, как изменить модификаторы доступа для типа или члена типа:

[!code-csharp[PublicAccess](~/samples/snippets/csharp/objectoriented/accessmodifiers.cs#PublicAccess)]

Не все модификаторы доступа подходят для всех типов или членов во всех контекстах. В некоторых случаях доступность члена типа ограничивается доступностью содержащего его типа.

## <a name="class-record-and-struct-accessibility"></a>Доступность классов, записей и структур  

Классы, записи и структуры, объявленные непосредственно в пространстве имен (другими словами, не вложенные в другие классы или структуры), могут быть `public` или `internal`. Если модификатор доступа не указан, по умолчанию используется `internal`.

Члены структуры, включая вложенные классы и структуры, могут быть объявлены как `public`, `internal` или `private`. Члены класса, включая вложенные классы и структуры, могут быть `public`, `protected internal`, `protected`, `internal`, `private protected` или `private`. Члены класса и структуры, включая вложенные классы и структуры, по умолчанию имеют доступ `private`. Закрытые вложенные типы недоступны за пределами типа, в котором содержатся.

Производные классы записи не могут быть более доступными, чем соответствующие базовые типы. Невозможно объявить открытый класс `B`, производный от внутреннего класса `A`. Если бы это было возможно, класс `A` стал бы открытым, так как все члены `protected` или `internal` класса `A` были бы доступны из производного класса.

Доступ к внутренним типам можно предоставить некоторым другим сборкам с помощью `InternalsVisibleToAttribute`. Дополнительные сведения см. в разделе [Дружественные сборки](../../../standard/assembly/friend.md).

## <a name="class-record-and-struct-member-accessibility"></a>Доступность членов классов, записей и структур  

Члены классов и записей (включая вложенные классы, записи и структуры) можно объявлять с любым из шести типов доступа. Члены структуры не могут быть объявлены как `protected`, `protected internal` или `private protected`, так как структуры не поддерживают наследование.

Как правило, уровень доступности члена не может быть выше уровня доступности типа, в который он входит. При этом член `public` внутреннего класса может быть доступен за пределами сборки, если он реализует методы интерфейса или переопределяет виртуальные методы, определенные в открытом базовом классе.

Тип любого поля, свойства или события члена должен иметь по меньшей мере такой же уровень доступности, как у самого члена. Точно так же тип возвращаемого значения и типы параметров любого метода, индексатора или делегата должен иметь по меньшей мере такой же уровень доступности, как у самого члена. Например, невозможно иметь метод `public` `M`, возвращающий класс `C`, если только `C` также не является `public`. Аналогичным образом, невозможно иметь свойство `protected` типа `A`, если `A` объявлен как `private`.

Пользовательские операторы всегда должны объявляться как `public` и `static`. Для получения дополнительной информации см. раздел [Перегрузка операторов](../../language-reference/operators/operator-overloading.md).

Методы завершения не могут иметь модификаторы доступа.

Чтобы настроить уровень доступа для члена `class`,`record` или `struct`, добавьте в объявление этого члена соответствующее ключевое слово, как показано в следующем примере.

[!code-csharp[MethodAccess](~/samples/snippets/csharp/objectoriented/accessmodifiers.cs#MethodAccess)]

## <a name="other-types"></a>Другие типы

Интерфейсы, объявляемые непосредственно в пространстве имен, могут быть `public` или `internal`. Как и в случае с классами и структурами, для интерфейсов по умолчанию задается доступ `internal`. Члены интерфейса по умолчанию являются `public`, так как интерфейс как раз и создан для того, чтобы обеспечить другим типам доступ к классу или структуре. Объявления членов интерфейса могут включать любой модификатор доступа. Это удобнее всего использовать для статических методов, чтобы предоставить общие реализации, необходимые всем объектам, реализующим класс.

Члены перечисления всегда являются `public`, и модификаторы доступа к ним не применяются.

Делегаты ведут себя как классы и структуры. По умолчанию они имеют доступ `internal`, если объявляются непосредственно в пространстве имен, и доступ `private`, если являются вложенными.

## <a name="c-language-specification"></a>Спецификация языка C#

[!INCLUDE[CSharplangspec](~/includes/csharplangspec-md.md)]  

## <a name="see-also"></a>См. также

- [Руководство по программированию на C#](../index.md)
- [Классы и структуры](./index.md)
- [Интерфейсы](../interfaces/index.md)
- [private](../../language-reference/keywords/private.md)
- [public](../../language-reference/keywords/public.md)
- [internal](../../language-reference/keywords/internal.md)
- [protected](../../language-reference/keywords/protected.md)
- [protected internal](../../language-reference/keywords/protected-internal.md)
- [private protected](../../language-reference/keywords/private-protected.md)
- [class](../../language-reference/keywords/class.md)
- [struct](../../language-reference/builtin-types/struct.md)
- [interface](../../language-reference/keywords/interface.md)

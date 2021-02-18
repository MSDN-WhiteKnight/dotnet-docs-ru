---
description: Выражение nameof. Справочник по C#
title: Выражение nameof. Справочник по C#
ms.date: 04/23/2020
f1_keywords:
- nameof_CSharpKeyword
- nameof
helpviewer_keywords:
- nameof expression [C#]
ms.assetid: 33601bf3-cc2c-4496-846d-f9679bccf2a7
ms.openlocfilehash: 568127a64efc02717b34fbd9d1e508e2e40596fd
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100464395"
---
# <a name="nameof-expression-c-reference"></a>Выражение nameof (справочник по C#)

Выражение `nameof` создает имя, тип или элемент переменной в качестве строковой константы:

[!code-csharp-interactive[nameof expression](snippets/shared/NameOfOperator.cs#Examples)]

Как показано в предыдущем примере, при использовании типа и пространства имен созданное имя не является [полным](~/_csharplang/spec/basic-concepts.md#fully-qualified-names).

Если используются [буквальные идентификаторы](../tokens/verbatim.md), символ `@` не является частью имени, как показано в следующем примере.

[!code-csharp-interactive[nameof verbatim](snippets/shared/NameOfOperator.cs#Verbatim)]

Значение выражения `nameof` вычисляется во время компиляции, и это не влияет на время выполнения.

С помощью выражения `nameof` можно сделать код проверки аргументов более удобным:

[!code-csharp[nameof and argument check](snippets/shared/NameOfOperator.cs#ExceptionMessage)]

Выражение `nameof` доступно в C# версии 6 и выше.

## <a name="c-language-specification"></a>Спецификация языка C#

См. подробнее о [выражениях nameof](~/_csharplang/spec/expressions.md#nameof-expressions) в [спецификации языка C#](~/_csharplang/spec/introduction.md).

## <a name="see-also"></a>См. также

- [справочник по C#](../index.md)
- [Операторы и выражения C#](index.md)

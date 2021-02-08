---
description: 'Дополнительные сведения о: BC30451: имя " <name> " не объявлено'
title: Имя <name> не объявлено
ms.date: 10/10/2018
f1_keywords:
- bc30451
- vbc30451
helpviewer_keywords:
- BC30451
ms.assetid: 765f099b-e21e-47c6-a906-a065444e56b3
ms.openlocfilehash: 8d76bcfd18b277a5f542f363cb906496680bae29
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99795746"
---
# <a name="bc30451-name-name-is-not-declared"></a>BC30451: имя " \<name> " не объявлено

Оператор ссылается на программный элемент, но компилятор не может найти элемент с таким же именем.

 **Идентификатор ошибки:** BC30451

## <a name="to-correct-this-error"></a>Исправление ошибки

1. Проверьте правильность написания в ссылающемся операторе. Visual Basic не учитывает регистр, но любые другие вариации в написании считаются совершенно разными именами. Обратите внимание, что символ подчеркивания (`_`) является частью имени и, следовательно, частью орфографии.

2. Убедитесь, что у вас есть оператор доступа к членам ( `.` ) между объектом и его членом. Например, если у вас есть элемент управления <xref:System.Windows.Forms.TextBox> с именем `TextBox1`, то для доступа к его свойству <xref:System.Windows.Forms.TextBoxBase.Text%2A> следует ввести `TextBox1.Text`. Если вместо этого ввести `TextBox1Text`, будет создано другое имя.

3. Если орфография верна и синтаксис любого доступного члена объекта правильный, убедитесь, что элемент был объявлен. Дополнительные сведения см. в разделе [объявленные элементы](../../programming-guide/language-features/declared-elements/index.md).

4. Если элемент программирования был объявлен, убедитесь, что он находится в области. Если инструкция, ссылающаяся на инструкцию, находится за пределами области, объявляющего программный элемент, может потребоваться уточнение имени элемента. Для получения дополнительной информации см. [Scope in Visual Basic](../../programming-guide/language-features/declared-elements/scope.md).

5. Если вы не используете полностью определенный тип или тип и имя члена (например, код ссылается на свойство, как `MethodInfo.Name` вместо `System.Reflection.MethodInfo.Name` ), добавьте [оператор Imports](../statements/imports-statement-net-namespace-and-type.md).

6. Если вы пытаетесь скомпилировать проект в стиле пакета SDK (проект с \* VBPROJ-файлом, который начинается со строки `<Project Sdk="Microsoft.NET.Sdk">` ), а сообщение об ошибке ссылается на тип или член сборки Microsoft.VisualBasic.dll, настройте приложение для компиляции со ссылкой на библиотеку времени выполнения Visual Basic. По умолчанию подмножество библиотеки внедряется в сборку в проекте в стиле пакета SDK.

   Например, следующий пример не удается скомпилировать, так как <xref:Microsoft.VisualBasic.CompilerServices.Conversions.ChangeType%2A?displayProperty=fullName> не удается найти метод. Он не внедряется в подмножество Visual Basic среды выполнения, входящей в состав приложения.

   [!code-vb[BC30451](~/samples/snippets/visualbasic/language-reference/error-messages/bc30451/program1.vb?highlight=7)]

   Чтобы устранить эту ошибку, добавьте `<VBRuntime>Default</VBRuntime>` элемент в раздел Projects `<PropertyGroup>` , как показано в следующем Visual Basic файле проекта.

   [!code-xml[BC30451](~/samples/snippets/visualbasic/language-reference/error-messages/bc30451/vbruntime.vbproj?highlight=6)]

## <a name="see-also"></a>См. также

- [Сводка по объявлениям и константам](../keywords/declarations-and-constants-summary.md)
- [Соглашения об именах Visual Basic](../../programming-guide/program-structure/naming-conventions.md)
- [Declared Element Names](../../programming-guide/language-features/declared-elements/declared-element-names.md)
- [References to Declared Elements](../../programming-guide/language-features/declared-elements/references-to-declared-elements.md)

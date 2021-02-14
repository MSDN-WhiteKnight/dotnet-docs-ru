---
description: 'Дополнительные сведения: повышение типа (Visual Basic)'
title: Повышение типа
ms.date: 07/20/2015
helpviewer_keywords:
- declared elements [Visual Basic], scope
- visibility [Visual Basic], declared elements
- Partial keyword [Visual Basic], unexpected results with type promotion
- scope [Visual Basic], declared elements
- scope [Visual Basic], Visual Basic
- type promotion
- declared elements [Visual Basic], visibility
ms.assetid: 035eeb15-e4c5-4288-ab3c-6bd5d22f7051
ms.openlocfilehash: fd8a30fb7e442d82222ae55daabf70bd8e532138
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100434723"
---
# <a name="type-promotion-visual-basic"></a>Повышение типа (Visual Basic)

При объявлении программного элемента в модуле Visual Basic повышает его область до пространства имен, содержащего модуль. Это называется *повышением типа*.  
  
 В следующем примере показано определение каркаса для модуля и два члена этого модуля.  
  
 [!code-vb[VbVbalrDeclaredElements#1](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrDeclaredElements/VB/Class1.vb#1)]  
  
 В `projModule` элементы программирования, объявленные на уровне модуля, помещаются в `projNamespace` . В предыдущем примере `basicEnum` и `innerClass` были повышены, но `numberSub` не являются, поскольку не объявлены на уровне модуля.  
  
## <a name="effect-of-type-promotion"></a>Результат повышения типа  

 Результатом повышения типа является то, что Уточняющая строка не обязательно должна включать имя модуля. Следующий пример выполняет два вызова процедуры в предыдущем примере.  
  
 [!code-vb[VbVbalrDeclaredElements#2](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrDeclaredElements/VB/Class1.vb#2)]  
  
 В предыдущем примере первый вызов использует полные строки квалификации. Однако это необязательно из-за продвижения типа. Второй вызов также обращается к членам модуля, не включая `projModule` в строки квалификации.  
  
## <a name="defeat-of-type-promotion"></a>Отмена повышения типа  

 Если пространство имен уже содержит член с тем же именем, что и у члена модуля, повышение типа для этого члена модуля будет недоступно. В следующем примере показано определение схемы перечисления и модуля в пределах одного пространства имен.  
  
 [!code-vb[VbVbalrDeclaredElements#3](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrDeclaredElements/VB/Class1.vb#3)]  
  
 В предыдущем примере Visual Basic не может повысить уровень до класса, `abc` `thisNameSpace` так как на уровне пространства имен уже существует перечисление с тем же именем. Для доступа `abcSub` необходимо использовать полную строку квалификации `thisNamespace.thisModule.abc.abcSub` . Однако класс `xyz` по-прежнему становится более продвинутым, и к нему можно получить доступ `xyzSub` с помощью более короткой уточняющей строки `thisNamespace.xyz.xyzSub` .  
  
### <a name="defeat-of-type-promotion-for-partial-types"></a>Отмена повышения типа для разделяемых типов  

 Если класс или структура внутри модуля использует ключевое слово [partial](../../../language-reference/modifiers/partial.md) , то продвижение типов автоматически отменяется для этого класса или структуры, независимо от того, имеет ли пространство имен член с таким же именем. Другие элементы в модуле по-прежнему имеют право на повышение типа.  
  
 **Последствия.** Отмена повышения типа частичного определения может привести к непредвиденным результатам и даже к ошибкам компилятора. В следующем примере показана скелетная часть определений класса, один из которых находится внутри модуля.  
  
 [!code-vb[VbVbalrDeclaredElements#4](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrDeclaredElements/VB/Class1.vb#4)]  
  
 В предыдущем примере разработчик может ожидать, что компилятор объединит два разделяемых определения `sampleClass` . Однако компилятор не учитывает продвижение для частичного определения внутри `sampleModule` . В результате он пытается скомпилировать два отдельных и разных класса с именами, `sampleClass` но с разными путями уточнения.  
  
 Компилятор объединяет частичные определения, только если их полные пути идентичны.  
  
## <a name="recommendations"></a>Рекомендации  

 Следующие рекомендации являются хорошей практикой программирования.  
  
- **Уникальные имена.** При наличии полного контроля над именованием программных элементов всегда рекомендуется использовать уникальные имена везде. Идентичные имена нуждаются в дополнительной квалификации и могут усложнить чтение кода. Они также могут привести к незначительным ошибкам и непредвиденным результатам.  
  
- **Полное уточнение.** При работе с модулями и другими элементами в одном пространстве имен наиболее надежный подход заключается в том, чтобы всегда использовать полную квалификацию для всех программных элементов. Если повышение типа для члена модуля не используется и вы не полностью уточняете этот член, вы можете случайно получить доступ к другому программному элементу.  
  
## <a name="see-also"></a>См. также раздел

- [Оператор Module](../../../language-reference/statements/module-statement.md)
- [Оператор Namespace](../../../language-reference/statements/namespace-statement.md)
- [Partial](../../../language-reference/modifiers/partial.md)
- [Область видимости в Visual Basic](scope.md)
- [Практическое руководство. Управление областью действия переменной](how-to-control-the-scope-of-a-variable.md)
- [References to Declared Elements](references-to-declared-elements.md)

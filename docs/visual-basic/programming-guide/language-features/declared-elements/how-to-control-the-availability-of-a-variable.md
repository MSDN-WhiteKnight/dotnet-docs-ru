---
description: Дополнительные сведения см. в статье как управлять доступностью переменной (Visual Basic).
title: Практическое руководство. Управление доступностью переменной
ms.date: 07/20/2015
helpviewer_keywords:
- access levels, declared elements
- Private keyword [Visual Basic], accessing variables
- access levels, variables
- Public keyword [Visual Basic], accessing variables
- Friend keyword [Visual Basic], accessing variables
- variables [Visual Basic], access level
- declared elements [Visual Basic], access level
- Protected keyword [Visual Basic], accessing variables
ms.assetid: eaf4f073-7922-43ce-ae1e-90ff376ae947
ms.openlocfilehash: 3fa21a804008f31da9003aa847752f749154d602
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100429888"
---
# <a name="how-to-control-the-availability-of-a-variable-visual-basic"></a>Практическое руководство. Управление доступностью переменной (Visual Basic)

Для управления доступностью переменной можно указать ее *уровень доступа*. Уровень доступа определяет, какой код имеет разрешение на чтение или запись в переменную.  
  
- *Переменные-члены* (определенные на уровне модуля и вне любой процедуры) по умолчанию имеют открытый доступ, что означает любой код, который может видеть, что они имеют доступ к ним. Это можно изменить, указав модификатор доступа.  
  
- *Локальные переменные* (определенные внутри процедуры) номинально имеют общий доступ, хотя доступ к ним могут получить только код внутри их процедуры. Нельзя изменить уровень доступа локальной переменной, но можно изменить уровень доступа процедуры, содержащей ее.  
  
 Дополнительные сведения см. [в разделе уровни доступа в Visual Basic](access-levels.md).  
  
## <a name="private-and-public-access"></a>Частный и открытый доступ  
  
#### <a name="to-make-a-variable-accessible-only-from-within-its-module-class-or-structure"></a>Предоставление доступа к переменной только внутри модуля, класса или структуры  
  
1. Поместите [оператор Dim](../../../language-reference/statements/dim-statement.md) для переменной внутри модуля, класса или структуры, но вне любой процедуры.  
  
2. Включите в оператор ключевое слово [Private](../../../language-reference/modifiers/private.md) `Dim` .  
  
     Можно выполнять чтение или запись в переменную из любого места внутри модуля, класса или структуры, но не за ее пределами.  
  
#### <a name="to-make-a-variable-accessible-from-any-code-that-can-see-it"></a>Чтобы сделать переменную доступной из любого кода, который может ее увидеть  
  
1. Для переменной-члена поместите `Dim` оператор для переменной внутри модуля, класса или структуры, но вне любой процедуры.  
  
2. Включите в оператор ключевое слово [Public](../../../language-reference/modifiers/public.md) `Dim` .  
  
     Можно выполнять чтение или запись в переменную из любого кода, который взаимодействует со сборкой.  
  
 -или-  
  
1. Для локальной переменной поместите `Dim` инструкцию для переменной внутри процедуры.  
  
2. Не включайте `Public` ключевое слово в `Dim` оператор.  
  
     Можно выполнять чтение или запись в переменную из любого места внутри процедуры, но не за ее пределами.  
  
## <a name="protected-and-friend-access"></a>Защищенный и дружественный доступ  

 Уровень доступа переменной можно ограничить своим классом и любыми производными классами или сборкой. Можно также указать объединение этих ограничений, которое разрешает доступ из кода в любом производном классе или в любом другом месте в одной сборке. Это объединение можно указать, объединив `Protected` `Friend` Ключевые слова и в том же объявлении.  
  
#### <a name="to-make-a-variable-accessible-only-from-within-its-class-and-any-derived-classes"></a>Предоставление доступа к переменной только внутри ее класса и любых производных классов  
  
1. Поместите `Dim` оператор для переменной внутри класса, но вне любой процедуры.  
  
2. Включите в оператор ключевое слово [protected](../../../language-reference/modifiers/protected.md) `Dim` .  
  
     Можно выполнять чтение или запись в переменную из любого места внутри класса, а также из любого класса, производного от него, но не за пределами класса в цепочке наследования.  
  
#### <a name="to-make-a-variable-accessible-only-from-within-the-same-assembly"></a>Предоставление переменной доступа только из той же сборки  
  
1. Поместите `Dim` оператор для переменной внутри модуля, класса или структуры, но вне любой процедуры.  
  
2. Включите в оператор ключевое слово [Friend](../../../language-reference/modifiers/friend.md) `Dim` .  
  
     Можно выполнять чтение или запись в переменную из любого места внутри модуля, класса или структуры, а также из любого кода в той же сборке, но не за пределами сборки.  
  
## <a name="example"></a>Пример  

 В следующем примере показаны объявления переменных с `Public` `Protected` `Friend` `Protected Friend` уровнями доступа,,, и `Private` . Обратите внимание, что если `Dim` инструкция задает уровень доступа, ключевое слово включать не нужно `Dim` .  
  
```vb  
Public Class classForEverybody  
Protected Class classForMyHeirs  
Friend stringForThisProject As String  
Protected Friend stringForProjectAndHeirs As String  
Private numberForMeOnly As Integer  
```  
  
## <a name="net-framework-security"></a>Безопасность .NET Framework  

 Чем более ограниченный уровень доступа переменной, тем меньше вероятность того, что вредоносный код может неправильно использовать его.  
  
## <a name="see-also"></a>См. также раздел

- [Уровни доступа в Visual Basic](access-levels.md)
- [Оператор Dim](../../../language-reference/statements/dim-statement.md)
- [Общедоступная](../../../language-reference/modifiers/public.md)
- [Защищенный](../../../language-reference/modifiers/protected.md)
- [Friend](../../../language-reference/modifiers/friend.md)
- [Частная](../../../language-reference/modifiers/private.md)

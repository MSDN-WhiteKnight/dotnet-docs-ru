---
description: Дополнительные сведения о операторе IsTrue (Visual Basic)
title: Оператор IsTrue
ms.date: 07/20/2015
f1_keywords:
- vb.istrue
helpviewer_keywords:
- IsTrue operator [Visual Basic]
- OrElse operator [Visual Basic]
ms.assetid: b6cec0f2-61b1-4331-a7f0-4d07ee3179d6
ms.openlocfilehash: 50b618c888ce988da5241041fb2f728e0a581c70
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99665657"
---
# <a name="istrue-operator-visual-basic"></a>Оператор IsTrue (Visual Basic)

Определяет, является ли выражение `True` .  
  
 `IsTrue`В коде нельзя вызывать явным образом, но компилятор Visual Basic может использовать его для создания кода из `OrElse` предложений. Если вы определяете класс или структуру, а затем используете переменную этого типа в `OrElse` предложении, необходимо определить `IsTrue` для этого класса или структуры.  
  
 Компилятор рассматривает `IsTrue` операторы и `IsFalse` как *парную пару*. Это означает, что при определении одного из них необходимо также определить другой.  
  
## <a name="compiler-use-of-istrue"></a>Использование IsTrue компилятором  

 После определения класса или структуры можно использовать переменную этого типа в `For` `If` `Else If` операторе,, или `While` , или в `When` предложении. В этом случае компилятору требуется оператор, который преобразует тип в `Boolean` значение, чтобы можно было проверить условие. Он выполняет поиск подходящего оператора в следующем порядке:  
  
1. Оператор расширяющего преобразования из класса или структуры в `Boolean` .  
  
2. Оператор расширяющего преобразования из класса или структуры в `Boolean?` .  
  
3. `IsTrue`Оператор для класса или структуры.  
  
4. Суженное преобразование в `Boolean?` , не охватывающее преобразование из `Boolean` в `Boolean?` .  
  
5. Оператор сужения преобразования из класса или структуры в `Boolean` .  
  
 Если не было определено преобразование в `Boolean` `IsTrue` оператор или, компилятор сообщает об ошибке.  
  
> [!NOTE]
> `IsTrue`Оператор можно *перегрузить*, что означает, что класс или структура может переопределить свое поведение, если его операнд имеет тип этого класса или структуры. Если код использует этот оператор для такого класса или структуры, убедитесь, что вы понимаете его переопределенное поведение. Для получения дополнительной информации см. [Operator Procedures](../../programming-guide/language-features/procedures/operator-procedures.md).  
  
## <a name="example"></a>Пример  

 В следующем примере кода определяется структура структуры, включающей определения для `IsFalse` `IsTrue` операторов и.  
  
 [!code-vb[VbVbalrOperators#28](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrOperators/VB/Class1.vb#28)]  
  
## <a name="see-also"></a>См. также

- [Оператор IsFalse](isfalse-operator.md)
- [Практическое руководство. Определение оператора](../../programming-guide/language-features/procedures/how-to-define-an-operator.md)
- [Оператор OrElse](orelse-operator.md)

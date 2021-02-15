---
description: Дополнительные сведения о объявлении переменных см. в Visual Basic
title: Объявление переменной
ms.date: 07/20/2015
helpviewer_keywords:
- variables [Visual Basic], declaring
- member variables [Visual Basic], declarations
- Dim statement [Visual Basic], variable declaration
- declaring variables [Visual Basic]
- variables [Visual Basic], scope
- variables [Visual Basic], data types
- data types [Visual Basic], variable declarations
- lifetime [Visual Basic], variables
- variables [Visual Basic], lifetime
- access levels [Visual Basic], variables
- scope [Visual Basic], declaration statements
- variables [Visual Basic], access level
- local variables [Visual Basic], declarations
- scope [Visual Basic], variables
ms.assetid: d8f10226-92b1-480f-9f53-df377b2d7e15
ms.openlocfilehash: ef0e7bc7a99f320bd40788ef019b05c7ebf4ce46
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100462702"
---
# <a name="variable-declaration-in-visual-basic"></a>Объявление переменной в Visual Basic

Переменная объявляется для указания ее имени и характеристик. Оператор объявления для переменных является [оператором Dim](../../../language-reference/statements/dim-statement.md). Его расположение и содержимое определяют характеристики переменной.  
  
 Правила именования переменных и рекомендации см. в разделе [Имена объявленных элементов](../declared-elements/declared-element-names.md).  
  
## <a name="declaration-levels"></a>Уровни объявления  
  
### <a name="local-and-member-variables"></a>Локальные и переменные членов  

 *Локальная переменная* — это одна из процедур, объявленная в процедуре. *Переменная-член* является членом типа Visual Basic; Он объявляется на уровне модуля, внутри класса, структуры или модуля, но не внутри какой-либо процедуры, внутренней для этого класса, структуры или модуля.  
  
### <a name="shared-and-instance-variables"></a>Переменные Shared и instance  

 В классе или структуре категория переменной-члена зависит от того, является ли она общей. Если он объявлен с ключевым словом [Shared](../../../language-reference/modifiers/shared.md) , то это *Общая переменная*, которая существует в одной копии, совместно используемой всеми экземплярами класса или структуры.  
  
 В противном случае это *переменная экземпляра*, и ее отдельная копия создается для каждого экземпляра класса или структуры. Данная копия переменной экземпляра доступна только для экземпляра класса или структуры, в которой он был создан. Он не зависит от копии переменной экземпляра в любом другом экземпляре класса или структуры.  
  
## <a name="declaring-data-type"></a>Объявление типа данных  

 Предложение [as](../../../language-reference/statements/as-clause.md) в операторе объявления позволяет определить тип данных или тип объекта объявляемой переменной. Для переменной можно указать любой из следующих типов:  
  
- Простейший тип данных, например `Boolean` , `Long` или `Decimal`  
  
- Составной тип данных, например массив или структура  
  
- Тип объекта или класс, определенный либо в приложении, либо в другом приложении  
  
- Класс платформа .NET Framework, например <xref:System.Windows.Forms.Label> или <xref:System.Windows.Forms.TextBox>  
  
- Тип интерфейса, например <xref:System.IComparable> или <xref:System.IDisposable>  
  
 В одной инструкции можно объявить несколько переменных без повторения типа данных. В следующих инструкциях переменные `i` , `j` и `k` объявляются как тип `Integer` , и `l` `m` как, и и, `Long` `x` `y` как `Single` :  
  
```vb  
Dim i, j, k As Integer  
' All three variables in the preceding statement are declared as Integer.  
Dim l, m As Long, x, y As Single  
' In the preceding statement, l and m are Long, x and y are Single.  
```  
  
 Дополнительные сведения о типах данных см. в разделе [типы данных](../data-types/index.md). Дополнительные сведения об объектах см. в разделе [объекты и классы](../objects-and-classes/index.md) и [программирование с помощью компонентов](/previous-versions/visualstudio/visual-studio-2013/0ffkdtkf(v=vs.120)).  
  
## <a name="local-type-inference"></a>Вывод локального типа  

 *Определение типа* используется для определения типов данных локальных переменных, объявленных без `As` предложения. Компилятор выводит тип переменной из типа выражения инициализации. Это позволяет объявлять переменные без явного указания типа. В следующем примере оба типа `num1` и `num2` строго типизированы как целые числа.  
  
 [!code-vb[VbVbalrTypeInference#1](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrTypeInference/VB/Class1.vb#1)]  
  
 Если требуется использовать вывод локального типа, `Option Infer` необходимо задать значение `On` . Дополнительные сведения см. в разделах [Вывод локального типа](local-type-inference.md) и [Оператор Option Infer](../../../language-reference/statements/option-infer-statement.md).  
  
## <a name="characteristics-of-declared-variables"></a>Характеристики объявленных переменных  

 Время *существования* переменной — это период времени, в течение которого она доступна для использования. Как правило, переменная существует, пока не будет существовать элемент, объявляющий ее (например, процедуру или класс). Если переменная не должна продолжаться за пределами времени существования содержащего его элемента, не нужно делать ничего особенного в объявлении. Если переменная должна продолжать существовать дольше, чем содержащая ее элемент, можно включить `Static` `Shared` ключевое слово или в `Dim` инструкцию. Дополнительные сведения см. [в разделе время существования в Visual Basic](../declared-elements/lifetime.md).  
  
 *Областью действия* переменной является набор всего кода, который может ссылаться на него без уточнения его имени. Область переменной определяется тем, где она объявлена. Код, расположенный в данном регионе, может использовать переменные, определенные в этом регионе, без уточнения их имен. Для получения дополнительной информации см. [Scope in Visual Basic](../declared-elements/scope.md).  
  
 *Уровень доступа* переменной — это область кода, имеющая разрешение на доступ к нему. Это определяется модификатором доступа (например, [открытым](../../../language-reference/modifiers/public.md) или [закрытым](../../../language-reference/modifiers/private.md)), который используется в `Dim` инструкции. Дополнительные сведения см. [в разделе уровни доступа в Visual Basic](../declared-elements/access-levels.md).  
  
## <a name="see-also"></a>См. также раздел

- [Практическое руководство. Создание новой переменной](how-to-create-a-new-variable.md)
- [Практическое руководство. Запись данных в переменную и их извлечение из переменной](how-to-move-data-into-and-out-of-a-variable.md)
- [Типы данных](../../../language-reference/data-types/index.md)
- [Защищенный](../../../language-reference/modifiers/protected.md)
- [Friend](../../../language-reference/modifiers/friend.md)
- [статически.](../../../language-reference/modifiers/static.md)
- [Характеристики объявленных элементов](../declared-elements/declared-element-characteristics.md)
- [Вывод локального типа](local-type-inference.md)
- [Оператор Option Infer](../../../language-reference/statements/option-infer-statement.md)

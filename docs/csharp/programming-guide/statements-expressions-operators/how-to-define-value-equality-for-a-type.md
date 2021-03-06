---
title: Как определить равенство значений для класса или структуры. Руководство по программированию на C#
description: Узнайте, как определить равенство значений для класса или структуры. Изучите примеры кода и ознакомьтесь с дополнительными ресурсами.
ms.date: 07/20/2015
helpviewer_keywords:
- overriding Equals method [C#]
- object equivalence [C#]
- Equals method [C#], overriding
- value equality [C#]
- equivalence [C#]
ms.assetid: 4084581e-b931-498b-9534-cf7ef5b68690
ms.openlocfilehash: a63fd8d11d0241063364e0156ee73a86aaeb7b35
ms.sourcegitcommit: 9c589b25b005b9a7f87327646020eb85c3b6306f
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/06/2021
ms.locfileid: "102259568"
---
# <a name="how-to-define-value-equality-for-a-class-or-struct-c-programming-guide"></a>Как определить равенство значений для класса или структуры (руководство по программированию на C#)

При определении [записи](../classes-and-structs/records.md) компилятор автоматически реализует равенство значений. При определении класса или структуры необходимо решить, имеет ли смысл создавать пользовательское определение равенства значений (или эквивалентности) для этого типа. Обычно правила определения равенства реализуются, если объекты этого типа будут добавляться в коллекции или если они в первую очередь предназначены для хранения набора полей или свойств. В основу определения равенства значений можно положить сравнение всех полей и свойств в типе или только их части.

В любом случае (как для классов, так и для структур) реализация должна соответствовать следующим пяти гарантиям эквивалентности (для следующих правил предполагается, что `x`, `y` и `z` не равны NULL).  
  
1. `x.Equals(x)` возвращает `true`. Это называется свойством рефлексивности.  
  
2. `x.Equals(y)` возвращает то же значение, что и `y.Equals(x)`. Это называется свойством симметрии.  
  
3. Если `(x.Equals(y) && y.Equals(z))` возвращает `true`, `x.Equals(z)` возвращает `true`. Это называется свойством транзитивности.  
  
4. Последовательные вызовы `x.Equals(y)` возвращают одно и то же значение до тех пор, пока объекты, на которые ссылаются x и y, не будут изменены.  
  
5. Любое значение, отличное от NULL, не равно NULL. Однако среда CLR проверяет наличие значений NULL для всех вызовов методов и выдает исключение `NullReferenceException`, если ссылка `this` будет равна NULL. Поэтому `x.Equals(y)` выдает исключение, когда `x` имеет значение NULL. Это нарушает правила 1 или 2 в зависимости от аргумента для `Equals`.

Любая определяемая вами структура имеет заданную по умолчанию реализацию равенства значений, которая наследуется от переопределения <xref:System.ValueType?displayProperty=nameWithType> метода <xref:System.Object.Equals%28System.Object%29?displayProperty=nameWithType>. Эта реализация использует отражение для проверки всех полей и свойств в типе. Хотя эта реализация возвращает верный результат, она отличается невысокой скоростью по сравнению с пользовательской реализацией, которую можно написать специально для конкретного типа.  
  
Детали реализации равенства значений для классов и структур различаются. Однако для реализации равенства как для классов, так и для структур, необходимо выполнить одни и те же базовые действия.  
  
1. Переопределите [виртуальный](../../language-reference/keywords/virtual.md) метод <xref:System.Object.Equals%28System.Object%29?displayProperty=nameWithType>. В большинстве случаев пользовательская реализация `bool Equals( object obj )` должна вызывать относящийся к конкретному типу метод `Equals`, который является реализацией интерфейса <xref:System.IEquatable%601?displayProperty=nameWithType>. (См. шаг 2.)  
  
2. Реализуйте интерфейс <xref:System.IEquatable%601?displayProperty=nameWithType>, предоставив метод `Equals` для конкретного типа. Именно на этом этапе происходит фактическое сравнение значений. Например, функцию равенства можно определить путем сравнения только одного из двух полей в типе. Не вызывайте исключения из `Equals`. Только для классов: этот метод должен проверять только те поля, которые объявлены в классе. Он должен вызывать метод `base.Equals` для проверки полей в базовом классе. (Не делайте этого, если тип наследуется напрямую от <xref:System.Object>, поскольку реализация <xref:System.Object> для <xref:System.Object.Equals%28System.Object%29?displayProperty=nameWithType> выполняет проверку равенства ссылок.)  
  
3. Необязательно, но рекомендуется: перегрузите операторы [==](../../language-reference/operators/equality-operators.md#equality-operator-) и [!=](../../language-reference/operators/equality-operators.md#inequality-operator-).  
  
4. Переопределите <xref:System.Object.GetHashCode%2A?displayProperty=nameWithType> таким образом, чтобы два объекта с равными значениями создавали одинаковый хэш-код.  
  
5. Необязательные: Для поддержки определений "больше" и "меньше" реализуйте для типа интерфейс <xref:System.IComparable%601>, а также перегрузите операторы [<=](../../language-reference/operators/comparison-operators.md#less-than-or-equal-operator-) и [>=](../../language-reference/operators/comparison-operators.md#greater-than-or-equal-operator-).  

> [!NOTE]
> Начиная с версии C# 9.0 можно использовать записи для получения семантики равенства значений без ненужного стандартного кода.

## <a name="class-example"></a>Пример класса

В следующем примере показана реализация равенства значений в классе (ссылочный тип).

[!code-csharp[csProgGuideStatements#19](~/samples/snippets/csharp/VS_Snippets_VBCSharp/csProgGuideStatements/CS/Statements.cs#19)]

В классах (ссылочных типах) реализация по умолчанию обоих методов <xref:System.Object.Equals%28System.Object%29?displayProperty=nameWithType> выполняет проверку равенства ссылок, а не значений. Когда разработчик переопределяет виртуальный метод, его задача заключается в том, чтобы реализовать семантику равенства значений.

К объектам класса можно применять операторы `==` и `!=`, даже если они не были перегружены в классе. Однако по умолчанию они служат для проверки равенства ссылок. При перегрузке в классе метода `Equals` необходимо перегрузить операторы `==` и `!=`, но это необязательно.

## <a name="struct-example"></a>Пример структуры

В следующем примере показана реализация равенства значений в структуре (тип значения).

[!code-csharp[csProgGuideStatements#20](~/samples/snippets/csharp/VS_Snippets_VBCSharp/csProgGuideStatements/CS/Statements.cs#20)]
  
Для структур реализация по умолчанию <xref:System.Object.Equals%28System.Object%29?displayProperty=nameWithType> (представляет собой переопределенную версию в <xref:System.ValueType?displayProperty=nameWithType>) выполняет проверку равенства значений посредством отражения, сравнивая значения каждого поля в типе. Когда разработчик переопределяет виртуальный метод `Equals` в структуре, его задача состоит в том, чтобы найти более эффективный способ проверки равенства значений и, если это возможно, реализовать сравнение только на основании части полей или свойств структуры.
  
Операторы [==](../../language-reference/operators/equality-operators.md#equality-operator-) и [!=](../../language-reference/operators/equality-operators.md#inequality-operator-) нельзя применять к структурам, если только они не были явным образом перегружены для конкретной структуры.

## <a name="see-also"></a>См. также

- [Сравнения на равенство](equality-comparisons.md)
- [Руководство по программированию на C#](../index.md)

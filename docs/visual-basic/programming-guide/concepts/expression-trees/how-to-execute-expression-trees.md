---
description: Дополнительные сведения см. в статье как выполнять деревья выражений (Visual Basic)
title: Практическое руководство. Выполнение деревьев выражений
ms.date: 07/20/2015
ms.assetid: 9dfb5ab3-f48f-417e-975f-f8f6f1cdc18d
ms.openlocfilehash: debd850f35d8239c20d9b848a43dafd76ac19bbc
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100430707"
---
# <a name="how-to-execute-expression-trees-visual-basic"></a>Практическое руководство. Выполнение деревьев выражений (Visual Basic)

В этом разделе показано, как выполнить дерево выражения. В результате выполнения дерева выражения может возвращаться значение или просто выполняться действие, такое как вызов метода.  
  
 Можно выполнять только деревья выражений, представляющие лямбда-выражения. Деревья выражений, представляющие лямбда-выражения, имеют тип <xref:System.Linq.Expressions.LambdaExpression> или <xref:System.Linq.Expressions.Expression%601>. Для выполнения таких деревьев выражений вызовите метод <xref:System.Linq.Expressions.LambdaExpression.Compile%2A>, чтобы создать исполняемый делегат, а затем вызовите делегат.  
  
> [!NOTE]
> Если тип делегата неизвестен, то есть лямбда-выражение имеет тип <xref:System.Linq.Expressions.LambdaExpression>, а не тип <xref:System.Linq.Expressions.Expression%601>, необходимо вызвать метод <xref:System.Delegate.DynamicInvoke%2A> для делегата, а не напрямую.  
  
 Если дерево выражения не представляет лямбда-выражение, можно создать новое лямбда-выражение, в качестве тела которого будет использоваться исходное дерево выражения. Для этого следует вызвать метод <xref:System.Linq.Expressions.Expression.Lambda%60%601%28System.Linq.Expressions.Expression%2CSystem.Collections.Generic.IEnumerable%7BSystem.Linq.Expressions.ParameterExpression%7D%29>. Затем можно выполнить лямбда-выражение, как описано ранее в этом разделе.  
  
## <a name="example"></a>Пример  

 В приведенном ниже примере кода показано, как путем создания и выполнения лямбда-выражения выполнить дерево выражения, которое представляет возведение числа в степень. Выводится результат, представляющий число, возведенное в степень.  
  
```vb  
' The expression tree to execute.  
Dim be As BinaryExpression = Expression.Power(Expression.Constant(2.0R), Expression.Constant(3.0R))  
  
' Create a lambda expression.  
Dim le As Expression(Of Func(Of Double)) = Expression.Lambda(Of Func(Of Double))(be)  
  
' Compile the lambda expression.  
Dim compiledExpression As Func(Of Double) = le.Compile()  
  
' Execute the lambda expression.  
Dim result As Double = compiledExpression()  
  
' Display the result.  
MsgBox(result)  
  
' This code produces the following output:  
' 8  
```  
  
## <a name="compile-the-code"></a>Компиляция кода  
  
- Включите пространство имен System.Linq.Expressions.  
  
## <a name="see-also"></a>См. также

- [Expression Trees (Visual Basic)](index.md) (Деревья выражений (Visual Basic))
- [Практическое руководство. Изменение деревьев выражений (Visual Basic)](how-to-modify-expression-trees.md)

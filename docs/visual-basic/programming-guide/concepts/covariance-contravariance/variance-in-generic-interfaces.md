---
description: Дополнительные сведения см. в статье вариативность в универсальных интерфейсах (Visual Basic)
title: Вариативность в универсальных интерфейсах
ms.date: 07/20/2015
ms.assetid: cf4096d0-4bb3-45a9-9a6b-f01e29a60333
ms.openlocfilehash: 42257f80cb929756583b1e488cd315450b9db35e
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100469842"
---
# <a name="variance-in-generic-interfaces-visual-basic"></a>Вариативность в универсальных интерфейсах (Visual Basic)

В платформе .NET Framework 4 появилась поддержка вариативности для нескольких существующих универсальных интерфейсов. Поддержка вариативности позволяет выполнять неявное преобразование классов, реализующих эти интерфейсы. Сейчас вариативными являются следующие интерфейсы.

- <xref:System.Collections.Generic.IEnumerable%601> (T является ковариантным)

- <xref:System.Collections.Generic.IEnumerator%601> (T является ковариантным)

- <xref:System.Linq.IQueryable%601> (T является ковариантным)

- <xref:System.Linq.IGrouping%602> (`TKey` и `TElement` являются ковариантными)

- <xref:System.Collections.Generic.IComparer%601> (T является контравариантным)

- <xref:System.Collections.Generic.IEqualityComparer%601> (T является контравариантным)

- <xref:System.IComparable%601> (T является контравариантным)

Ковариация позволяет методу иметь тип возвращаемого значения, степень наследования которого больше, чем указано в параметре универсального типа интерфейса. Чтобы продемонстрировать функцию ковариации, рассмотрим следующие универсальные интерфейсы: `IEnumerable(Of Object)` и `IEnumerable(Of String)`. Интерфейс `IEnumerable(Of String)` не наследует интерфейс `IEnumerable(Of Object)`. При этом тип `String` наследует тип `Object`, и в некоторых случаях может потребоваться назначить объекты этих интерфейсов друг другу. Это показано в следующем примере кода.

```vb
Dim strings As IEnumerable(Of String) = New List(Of String)
Dim objects As IEnumerable(Of Object) = strings
```

В более ранних версиях платформа .NET Framework этот код вызывает ошибку компиляции в Visual Basic с `Option Strict On` . Но теперь можно использовать `strings` вместо `objects`, как показано в предыдущем примере, поскольку интерфейс <xref:System.Collections.Generic.IEnumerable%601> является ковариантным.

Контравариантность позволяет методу иметь типы аргументов, степень наследования которых меньше, чем указано в параметре универсального типа интерфейса. Чтобы продемонстрировать функцию контравариантности, предположим, что создан класса `BaseComparer` для сравнения экземпляров класса `BaseClass`. Класс `BaseComparer` реализует интерфейс `IEqualityComparer(Of BaseClass)`. Поскольку теперь интерфейс <xref:System.Collections.Generic.IEqualityComparer%601> является контравариантным, для сравнения экземпляров классов, наследующих класс `BaseClass`, можно использовать класс `BaseComparer`. Это показано в следующем примере кода.

```vb
' Simple hierarchy of classes.
Class BaseClass
End Class

Class DerivedClass
    Inherits BaseClass
End Class

' Comparer class.
Class BaseComparer
    Implements IEqualityComparer(Of BaseClass)

    Public Function Equals1(ByVal x As BaseClass,
                            ByVal y As BaseClass) As Boolean _
                            Implements IEqualityComparer(Of BaseClass).Equals
        Return (x.Equals(y))
    End Function

    Public Function GetHashCode1(ByVal obj As BaseClass) As Integer _
        Implements IEqualityComparer(Of BaseClass).GetHashCode
        Return obj.GetHashCode
    End Function
End Class
Sub Test()
    Dim baseComparer As IEqualityComparer(Of BaseClass) = New BaseComparer
    ' Implicit conversion of IEqualityComparer(Of BaseClass) to
    ' IEqualityComparer(Of DerivedClass).
    Dim childComparer As IEqualityComparer(Of DerivedClass) = baseComparer
End Sub
```

Дополнительные примеры см. [в разделе Использование вариативности в интерфейсах для универсальных коллекций (Visual Basic)](using-variance-in-interfaces-for-generic-collections.md).

Вариативность в универсальных интерфейсах поддерживается только для ссылочных типов. Типы значений не поддерживают вариативность. Например, `IEnumerable(Of Integer)` нельзя неявно преобразовать в `IEnumerable(Of Object)`, так как типом значения является integer.

```vb
Dim integers As IEnumerable(Of Integer) = New List(Of Integer)
' The following statement generates a compiler error
' with Option Strict On, because Integer is a value type.
' Dim objects As IEnumerable(Of Object) = integers
```

Кроме того, важно помнить, что классы, которые реализуют вариативные интерфейсы, сами являются инвариантными. Например, несмотря на то, что <xref:System.Collections.Generic.List%601> реализует ковариантный интерфейс <xref:System.Collections.Generic.IEnumerable%601>, неявно преобразовать `List(Of Object)` в `List(Of String)` нельзя. Это показано в следующем примере кода.

```vb
' The following statement generates a compiler error
' because classes are invariant.
' Dim list As List(Of Object) = New List(Of String)

' You can use the interface object instead.
Dim listObjects As IEnumerable(Of Object) = New List(Of String)
```

## <a name="see-also"></a>См. также

- [Использование вариативности в интерфейсах для универсальных коллекций (Visual Basic)](using-variance-in-interfaces-for-generic-collections.md)
- [Создание вариативных универсальных интерфейсов (Visual Basic)](creating-variant-generic-interfaces.md)
- [Универсальные интерфейсы](../../../../standard/generics/interfaces.md)
- [Вариативность в делегатах (Visual Basic)](variance-in-delegates.md)

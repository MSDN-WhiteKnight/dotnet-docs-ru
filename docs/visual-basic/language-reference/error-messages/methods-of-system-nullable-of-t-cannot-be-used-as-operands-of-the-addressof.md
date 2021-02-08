---
description: 'Дополнительные сведения о: BC32126: методы "System. Nullable (Of T)" не могут использоваться в качестве операндов оператора "AddressOf".'
title: Методы System.Nullable(Of T) нельзя использовать в качестве операндов оператора AddressOf
ms.date: 07/20/2015
f1_keywords:
- vbc32126
- bc32126
helpviewer_keywords:
- BC32126
ms.assetid: 2325668b-e2ad-40ee-a1ec-30450236c20d
ms.openlocfilehash: 5ddf2f11bab3193423a3294a7f96afe68f0e5dce
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99795798"
---
# <a name="bc32126-methods-of-systemnullableof-t-cannot-be-used-as-operands-of-the-addressof-operator"></a>BC32126: методы "System. Nullable (Of T)" не могут использоваться в качестве операндов оператора "AddressOf"

Оператор использует `AddressOf` оператор с операндом, представляющим процедуру <xref:System.Nullable%601> структуры.

 **Идентификатор ошибки:** BC32126

## <a name="to-correct-this-error"></a>Исправление ошибки

- Замените имя процедуры в `AddressOf` предложении операндом, который не является членом <xref:System.Nullable%601> .

- Напишите класс, который заключает в оболочку метод <xref:System.Nullable%601> , который требуется использовать. В следующем примере `NullableWrapper` класс определяет новый метод с именем `GetValueOrDefault` . Поскольку этот новый метод не является членом <xref:System.Nullable%601> , он может быть применен к `nullInstance` экземпляру типа, допускающему значение null, для формирования аргумента для `AddressOf` .

```vb
Module Module1

    Delegate Function Deleg() As Integer

    Sub Main()
        Dim nullInstance As New Nullable(Of Integer)(1)

        Dim del As Deleg

        ' GetValueOrDefault is a method of the Nullable generic
        ' type. It cannot be used as an operand of AddressOf.
        ' del = AddressOf nullInstance.GetValueOrDefault

        ' The following line uses the GetValueOrDefault method
        ' defined in the NullableWrapper class.
        del = AddressOf (New NullableWrapper(
            Of Integer)(nullInstance)).GetValueOrDefault

        Console.WriteLine(del.Invoke())
    End Sub

    Class NullableWrapper(Of T As Structure)
        Private m_Value As Nullable(Of T)

        Sub New(ByVal Value As Nullable(Of T))
            m_Value = Value
        End Sub

        Public Function GetValueOrDefault() As T
            Return m_Value.Value
        End Function
    End Class
End Module
```

## <a name="see-also"></a>См. также

- <xref:System.Nullable%601>
- [Оператор AddressOf](../operators/addressof-operator.md)
- [Типы значений, допускающие значение NULL](../../programming-guide/language-features/data-types/nullable-value-types.md)
- [Generic Types in Visual Basic](../../programming-guide/language-features/data-types/generic-types.md)

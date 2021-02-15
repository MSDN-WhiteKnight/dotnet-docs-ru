---
description: 'Дополнительные сведения: объявление переменной объекта (Visual Basic)'
title: Объявление объектной переменной
ms.date: 07/20/2015
helpviewer_keywords:
- early binding [Visual Basic]
- declarations [Visual Basic], class
- classes [Visual Basic], declaring
- binding [Visual Basic], late and early
- object variables [Visual Basic], declaring
- variables [Visual Basic], object
- declaring variables [Visual Basic], object variables
- declaring classes [Visual Basic]
- late binding [Visual Basic]
ms.assetid: 2a5a41a3-1aa8-4236-b1f0-2382af7bf715
ms.openlocfilehash: 853f9e775976022e52121c164884fd91ef0a831c
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100463719"
---
# <a name="object-variable-declaration-visual-basic"></a>Объявление переменных объектов (Visual Basic)

Для объявления объектной переменной используется стандартный оператор объявления. Для типа данных указывается либо `Object` (то есть [тип данных Object](../../../language-reference/data-types/object-data-type.md)), либо более конкретный класс, из которого будет создан объект.  
  
 Объявление переменной как аналогично объявлению `Object` ее как <xref:System.Object?displayProperty=nameWithType> .  
  
 При объявлении переменной с конкретным классом объектов он может получить доступ ко всем методам и свойствам, предоставляемым этим классом, и классами, от которых он наследуется. Если объявить переменную с <xref:System.Object> , она может обращаться только к членам <xref:System.Object> класса, если не `Option Strict Off` разрешить позднее связывание.  
  
## <a name="declaration-syntax"></a>Синтаксис объявления  

 Для объявления объектной переменной используйте следующий синтаксис:  
  
```vb  
Dim variablename As [New] { objectclass | Object }  
```  
  
 В объявлении также можно указать [открытые](../../../language-reference/modifiers/public.md), [защищенные](../../../language-reference/modifiers/protected.md), [дружественные](../../../language-reference/modifiers/friend.md), `Protected Friend` [частные](../../../language-reference/modifiers/private.md), [Общие](../../../language-reference/modifiers/shared.md)или [статические](../../../language-reference/modifiers/static.md) . Допустимы следующие примеры объявлений:  
  
```vb  
Private objA As Object  
Static objB As System.Windows.Forms.Label  
Dim objC As System.OperatingSystem  
```  
  
## <a name="late-binding-and-early-binding"></a>Позднее связывание и раннее связывание  

 Иногда конкретный класс неизвестен, пока не будет запущен код. В этом случае необходимо объявить объектную переменную с `Object` типом данных. При этом создается общая ссылка на объект любого типа, а конкретный класс назначается во время выполнения. Это называется *поздним связыванием*. Позднее связывание требует дополнительного времени выполнения. Он также ограничивает ваш код методами и свойствами класса, назначенного ему последним. Это может вызвать ошибки времени выполнения, если код пытается получить доступ к членам другого класса.  
  
 Когда вы узнаете конкретный класс во время компиляции, следует объявить переменную объекта для этого класса. Этот принцип называется *раннее связывание*. Раннее связывание повышает производительность и гарантирует доступ кода ко всем методам и свойствам конкретного класса. В приведенных выше примерах объявлений, если переменная `objA` использует только объекты класса <xref:System.Windows.Forms.Label?displayProperty=nameWithType> , `As System.Windows.Forms.Label` в его объявлении следует указать.  
  
### <a name="advantages-of-early-binding"></a>Преимущества раннего связывания  

 Объявление объектной переменной в качестве конкретного класса дает несколько преимуществ:  
  
- Автоматическая проверка типов  
  
- Гарантированный доступ ко всем членам указанного класса  
  
- Поддержка Microsoft IntelliSense в редакторе кода  
  
- Улучшенная удобочитаемость кода  
  
- Меньше ошибок в коде  
  
- Ошибки, перехваченные во время компиляции, а не во время выполнения  
  
- Ускорение выполнения кода  
  
## <a name="access-to-object-variable-members"></a>Доступ к членам переменных объектов  

 Если параметр `Option Strict` включен `On` , переменная объекта может обращаться только к методам и свойствам класса, с которым он объявлен. Это показано в следующем примере.  
  
```vb  
' Option statements must precede all other source file lines.  
Option Strict On  
' Imports statement must precede all declarations in the source file.  
Imports System.Windows.Forms  
Public Sub accessMembers()  
    Dim p As Object  
    Dim q As System.Windows.Forms.Label  
    p = New System.Windows.Forms.Label  
    q = New System.Windows.Forms.Label  
    Dim j, k As Integer  
    ' The following statement generates a compiler ERROR.  
    j = p.Left  
    ' The following statement retrieves the left edge of the label in pixels.  
    k = q.Left  
End Sub  
```  
  
 В этом примере `p` может использовать только члены класса <xref:System.Object> без свойства `Left` . С другой стороны, `q` был объявлен с типом <xref:System.Windows.Forms.Label>, поэтому он может использовать все методы и свойства класса <xref:System.Windows.Forms.Label> в пространстве имен <xref:System.Windows.Forms> .  
  
## <a name="flexibility-of-object-variables"></a>Гибкость объектных переменных  

 При работе с объектами в иерархии наследования можно выбрать, какой класс использовать для объявления переменных объекта. При выборе этого варианта необходимо сбалансировать гибкость назначения объектов для доступа к членам класса. Например, рассмотрим иерархию наследования, которая ведет к <xref:System.Windows.Forms.Form?displayProperty=nameWithType> классу:  
  
 <xref:System.Object>  
  
 &nbsp;&nbsp;<xref:System.MarshalByRefObject>  
  
 &nbsp;&nbsp;&nbsp;&nbsp;<xref:System.ComponentModel.Component>  
  
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<xref:System.Windows.Forms.Control>  
  
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<xref:System.Windows.Forms.ScrollableControl>  
  
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<xref:System.Windows.Forms.ContainerControl>  
  
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<xref:System.Windows.Forms.Form>  
  
 Предположим, что приложение определяет класс формы с именем `specialForm` , который наследует от класса <xref:System.Windows.Forms.Form> . Можно объявить переменную объекта, которая ссылается специально на `specialForm` , как показано в следующем примере.  
  
```vb  
Public Class specialForm  
    Inherits System.Windows.Forms.Form  
    ' Insert code defining methods and properties of specialForm.  
End Class  
Dim nextForm As New specialForm  
```  
  
 Объявление в предыдущем примере ограничивает переменную `nextForm` на объекты класса `specialForm` , но также делает все методы и свойства `specialForm` доступными для `nextForm` , а также все члены всех классов, от которых `specialForm` наследуется.  
  
 Можно сделать переменную объекта более общей, объявив ее <xref:System.Windows.Forms.Form> как тип, как показано в следующем примере.  
  
```vb  
Dim anyForm As System.Windows.Forms.Form  
```  
  
 Объявление в предыдущем примере позволяет назначить любую форму в приложении `anyForm` . Однако несмотря на то, что `anyForm` имеет доступ ко всем членам класса <xref:System.Windows.Forms.Form> , он не может использовать дополнительные методы или свойства, определенные для определенных форм, таких как `specialForm` .  
  
 Все члены базового класса доступны для производных классов, но дополнительные члены производного класса недоступны для базового класса.  
  
## <a name="see-also"></a>См. также раздел

- [Объектные переменные](object-variables.md)
- [Присваивание объектных переменных](object-variable-assignment.md)
- [Значения объектных переменных](object-variable-values.md)
- [Практическое руководство. Объявление объектной переменной в Visual Basic и присвоение ей объекта](how-to-declare-an-object-variable-and-assign-an-object-to-it.md)
- [Практическое руководство. Доступ к членам объекта](how-to-access-members-of-an-object.md)
- [Создание оператора](../../../language-reference/operators/new-operator.md)
- [Оператор Option Strict](../../../language-reference/statements/option-strict-statement.md)
- [Вывод локального типа](local-type-inference.md)

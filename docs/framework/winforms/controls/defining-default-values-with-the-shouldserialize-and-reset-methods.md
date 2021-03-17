---
title: Определение значений по умолчанию с помощью методов ShouldSerialize и Reset
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- custom controls [Windows Forms], property methods
- ShouldPersist method
ms.assetid: 7b6c5e00-3771-46b4-9142-5a80d5864a5e
ms.openlocfilehash: f1f5a668c5d4f52ef7dd9f60a31c04f2173165f6
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59090619"
---
# <a name="defining-default-values-with-the-shouldserialize-and-reset-methods"></a>Определение значений по умолчанию с помощью методов ShouldSerialize и Reset
`ShouldSerialize` и `Reset` — необязательные методы, которые могут использоваться для свойства, в том случае, если свойство не имеет значения по умолчанию. Если свойство имеет значение по умолчанию, необходимо применить <xref:System.ComponentModel.DefaultValueAttribute> и вместо этого укажите значение по умолчанию для конструктора класса атрибутов. Любой из этих механизмов обеспечивает следующие возможности в конструкторе:  
  
-   Свойство предоставляет визуальную индикацию в обозревателе свойств, если он был изменен со значения по умолчанию.  
  
-   Пользователь может щелкнуть свойства и выберите **Сброс** восстановить значение свойства к значению по умолчанию.  
  
-   Конструктор создает более эффективный код.  
  
    > [!NOTE]
    >  Либо применить <xref:System.ComponentModel.DefaultValueAttribute> или предоставить `Reset` *PropertyName* и `ShouldSerialize` *PropertyName* методы. Не используйте их вместе.  
  
 `Reset` *PropertyName* метод задает свойство к значению по умолчанию, как показано в следующем фрагменте кода.  
  
```vb  
Public Sub ResetMyFont()  
   MyFont = Nothing  
End Sub  
```  
  
```csharp  
public void ResetMyFont() {  
   MyFont = null;  
}  
```  
  
> [!NOTE]
>  Если свойство не является `Reset` метод, не помечен атрибутом <xref:System.ComponentModel.DefaultValueAttribute>и не имеет значения по умолчанию, указанного в его объявлении `Reset` для этого свойства отключен в контекстном меню **свойства** окна конструктора Windows Forms в Visual Studio.  
  
 Конструкторы, такой как Visual Studio используют `ShouldSerialize` *PropertyName* метод проверьте, изменено ли значение свойства по умолчанию и создание кода в форме, только если свойство изменяется, что позволяет более эффективный код поколение. Пример:  
  
```vb  
'Returns true if the font has changed; otherwise, returns false.  
' The designer writes code to the form only if true is returned.  
Public Function ShouldSerializeMyFont() As Boolean  
   Return Not (thefont Is Nothing)  
End Function  
```  
  
```csharp  
// Returns true if the font has changed; otherwise, returns false.  
// The designer writes code to the form only if true is returned.  
public bool ShouldSerializeMyFont() {  
   return thefont != null;  
}  
```  
  
 Полный пример кода ниже.  
  
```vb  
Option Explicit  
Option Strict  
  
Imports System  
Imports System.Windows.Forms  
Imports System.Drawing  
  
Public Class MyControl  
   Inherits Control  
  
   ' Declare an instance of the Font class  
   ' and set its default value to Nothing.  
   Private thefont As Font = Nothing  
  
   ' The MyFont property.   
   Public Property MyFont() As Font  
      ' Note that the Font property never  
      ' returns null.  
      Get  
         If Not (thefont Is Nothing) Then  
            Return thefont  
         End If  
         If Not (Parent Is Nothing) Then  
            Return Parent.Font  
         End If  
         Return Control.DefaultFont  
      End Get  
      Set  
         thefont = value  
      End Set  
   End Property  
  
   Public Function ShouldSerializeMyFont() As Boolean  
      Return Not (thefont Is Nothing)  
   End Function  
  
   Public Sub ResetMyFont()  
      MyFont = Nothing  
   End Sub  
End Class  
```  
  
```csharp  
using System;  
using System.Windows.Forms;  
using System.Drawing;  
  
public class MyControl : Control {  
   // Declare an instance of the Font class  
   // and set its default value to null.  
   private Font thefont = null;  
  
   // The MyFont property.      
   public Font MyFont {  
      // Note that the MyFont property never  
      // returns null.  
      get {  
         if (thefont != null) return thefont;  
         if (Parent != null) return Parent.Font;  
         return Control.DefaultFont;  
      }  
      set {  
         thefont = value;  
      }  
   }  
  
   public bool ShouldSerializeMyFont() {  
      return thefont != null;  
   }  
  
   public void ResetMyFont() {  
      MyFont = null;  
   }  
}  
```  
  
 В данном случае, даже в том случае, если значение переменной закрытого обращается к `MyFont` свойство `null`, браузер свойств не отображается `null`; вместо этого он отображает <xref:System.Windows.Forms.Control.Font%2A> свойство родительского объекта, если это не `null`, или значение по умолчанию <xref:System.Windows.Forms.Control.Font%2A> значения, определенного в <xref:System.Windows.Forms.Control>. Таким образом, значение по умолчанию для `MyFont` нельзя просто установить и <xref:System.ComponentModel.DefaultValueAttribute> не может использоваться для этого свойства. Вместо этого `ShouldSerialize` и `Reset` методы должны быть реализованы для `MyFont` свойство.  
  
## <a name="see-also"></a>См. также

- [Свойства элементов управления Windows Forms](properties-in-windows-forms-controls.md)
- [Определение свойства](defining-a-property-in-windows-forms-controls.md)
- [События изменения свойств](property-changed-events.md)

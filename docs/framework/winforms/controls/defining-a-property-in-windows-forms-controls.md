---
title: Определение свойства элемента управления Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- properties [Windows Forms], defining in code
- custom controls [Windows Forms], defining properties in code
ms.assetid: c2eb8277-a842-4d99-89a9-647b901a0434
ms.openlocfilehash: 905578454b0bc6b5e74202d15c91645fed0fd461
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59143251"
---
# <a name="defining-a-property-in-windows-forms-controls"></a>Определение свойства элемента управления Windows Forms
Обзор свойств см. в разделе [Общие сведения о свойствах](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/65zdfbdt(v=vs.120)). При определении свойства обратите внимание на приведенные ниже соображения:  
  
-   К определяемым свойствам необходимо применять атрибуты. Атрибуты указывают, как конструктор должен отображать свойство. Дополнительные сведения см. в разделе [Атрибуты времени разработки для компонентов](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/tk67c2t8(v=vs.120)).  
  
-   Если изменение свойства влияет на визуальное отображение элемента управления, вызовите <xref:System.Windows.Forms.Control.Invalidate%2A> метода (который элемент управления наследует от <xref:System.Windows.Forms.Control>) из `set` метода доступа. <xref:System.Windows.Forms.Control.Invalidate%2A> в свою очередь вызывает <xref:System.Windows.Forms.Control.OnPaint%2A> метод, который перерисовывает элемент управления. Несколько вызовов <xref:System.Windows.Forms.Control.Invalidate%2A> привести один вызов <xref:System.Windows.Forms.Control.OnPaint%2A> для повышения эффективности.  
  
-   Библиотека классов .NET Framework предоставляет преобразователи типов для общих типов данных, таких как целые числа, десятичные числа, логические значения и прочие. Преобразователь типов обычно предназначен для преобразования строки в значение (из строковых данных в данные другого типа). Общие типы данных связаны с преобразователями типов по умолчанию, которые преобразуют значения в строки, а строки — в соответствующие типы данных. При определении свойства, являющегося пользовательским (то есть, нестандартным) типом данных необходимо применить атрибут, указывающий преобразователь типов для связи с этим свойством. Также можно использовать атрибут, чтобы связать пользовательский редактор типов пользовательского интерфейса со свойством. Редактор типов пользовательского интерфейса предоставляет пользовательский интерфейс для редактирования свойства или типа данных. Палитра — это пример редактора типов пользовательского интерфейса. Примеры атрибутов приведены в конце этого раздела.  
  
    > [!NOTE]
    >  Если преобразователь типов или редактор типов пользовательского интерфейса недоступны для пользовательского свойства, можно реализовать один из них, как описано в разделе [Расширение поддержки времени разработки](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/37899azc(v=vs.120)).  
  
 В следующем фрагменте кода определяется пользовательское свойство с именем `EndColor` для пользовательского элемента управления `FlashTrackBar`.  
  
```vb  
Public Class FlashTrackBar  
   Inherits Control  
   ...  
   ' Private data member that backs the EndColor property.  
   Private _endColor As Color = Color.LimeGreen  
  
   ' The Category attribute tells the designer to display  
   ' it in the Flash grouping.   
   ' The Description attribute provides a description of  
   ' the property.   
   <Category("Flash"), _  
   Description("The ending color of the bar.")>  _  
   Public Property EndColor() As Color  
      ' The public property EndColor accesses _endColor.  
      Get  
         Return _endColor  
      End Get  
      Set  
         _endColor = value  
         If Not (baseBackground Is Nothing) And showGradient Then  
            baseBackground.Dispose()  
            baseBackground = Nothing  
         End If  
         ' The Invalidate method calls the OnPaint method, which redraws    
         ' the control.  
         Invalidate()  
      End Set  
   End Property  
   ...  
End Class  
```  
  
```csharp  
public class FlashTrackBar : Control {  
   ...  
   // Private data member that backs the EndColor property.  
   private Color endColor = Color.LimeGreen;  
   // The Category attribute tells the designer to display  
   // it in the Flash grouping.   
   // The Description attribute provides a description of  
   // the property.   
   [  
   Category("Flash"),  
   Description("The ending color of the bar.")  
   ]  
   // The public property EndColor accesses endColor.  
   public Color EndColor {  
      get {  
         return endColor;  
      }  
      set {  
         endColor = value;  
         if (baseBackground != null && showGradient) {  
            baseBackground.Dispose();  
            baseBackground = null;  
         }  
         // The Invalidate method calls the OnPaint method, which redraws   
         // the control.  
         Invalidate();  
      }  
   }  
   ...  
}  
```  
  
 В следующем фрагменте кода преобразователь типов и редактор типов пользовательского интерфейса связывается со свойством `Value`. В этом случае `Value` должно быть целым числом и имеет преобразователь типов по умолчанию, но <xref:System.ComponentModel.TypeConverterAttribute> атрибут применяется пользовательский преобразователь типов (`FlashTrackBarValueConverter`), позволяющий конструктору отображать его в процентах. Редактор типов пользовательского интерфейса, `FlashTrackBarValueEditor`, позволяет визуально отображать проценты. В этом примере также показано, что преобразователь типов или редактор, заданный <xref:System.ComponentModel.TypeConverterAttribute> или <xref:System.ComponentModel.EditorAttribute> атрибут переопределяет преобразователь по умолчанию.  
  
```vb  
<Category("Flash"), _  
TypeConverter(GetType(FlashTrackBarValueConverter)), _  
Editor(GetType(FlashTrackBarValueEditor), _  
GetType(UITypeEditor)), _  
Description("The current value of the track bar.  You can enter an actual value or a percentage.")>  _  
Public ReadOnly Property Value() As Integer  
...  
End Property  
```  
  
```csharp  
[  
Category("Flash"),   
TypeConverter(typeof(FlashTrackBarValueConverter)),  
Editor(typeof(FlashTrackBarValueEditor), typeof(UITypeEditor)),  
Description("The current value of the track bar.  You can enter an actual value or a percentage.")  
]  
public int Value {  
...  
}  
```  
  
## <a name="see-also"></a>См. также

- [Свойства элементов управления Windows Forms](properties-in-windows-forms-controls.md)
- [Определение значений по умолчанию с помощью методов ShouldSerialize и Reset](defining-default-values-with-the-shouldserialize-and-reset-methods.md)
- [События изменения свойств](property-changed-events.md)
- [Атрибуты в элементах управления Windows Forms](attributes-in-windows-forms-controls.md)

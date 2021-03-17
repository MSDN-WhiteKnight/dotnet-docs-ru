---
title: Элементы управления, разработанные пользователем
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- custom controls [Windows Forms], user-drawn
- OnPaint method [Windows Forms]
- user-drawn controls [Windows Forms]
ms.assetid: 034af4b5-457f-4160-a937-22891817faa8
ms.openlocfilehash: 06513fc44782c78d2d69b82130542949519c0107
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59158448"
---
# <a name="user-drawn-controls"></a>Элементы управления, разработанные пользователем
.NET Framework дает возможность легко разрабатывать собственные элементы управления. Вы можете создать пользовательский элемент управления, который представляет собой набор стандартных элементов управления, связанных с помощью кода, или можно разработать собственный элемент управления с нуля вверх. Можно даже использовать наследование создать элемент управления, который наследует от существующего элемента управления и добавить его функциональные возможности. Какой бы подход, вы используете, платформа .NET Framework предоставляет функциональные возможности для создания пользовательского интерфейса для любого элемента управления, которые можно создать.  
  
 Рисование элемента управления достигается путем выполнения кода в элементе управления <xref:System.Windows.Forms.Control.OnPaint%2A> метод. Единственным аргументом <xref:System.Windows.Forms.Control.OnPaint%2A> метод <xref:System.Windows.Forms.PaintEventArgs> объект, предоставляющий все сведения и функциональные возможности, необходимые для подготовки к просмотру элемента управления. <xref:System.Windows.Forms.PaintEventArgs> Предоставляет два объекта-участника, которые будут использоваться при подготовке к просмотру элемента управления в виде свойств:  
  
-   <xref:System.Windows.Forms.PaintEventArgs.ClipRectangle%2A> Объект - прямоугольник, представляющий часть элемента управления, который будет заменен. Это может быть весь элемент управления или части элемента управления в зависимости от того, как элемент управления отображается.  
  
-   <xref:System.Drawing.Graphics> объект - инкапсулирует несколько графических объектов и методов, которые предоставляют функциональные возможности, необходимые для рисования элемента управления.  
  
 Дополнительные сведения о <xref:System.Drawing.Graphics> объекта и как его использовать, см. в разделе [как: Создание объектов Graphics для рисования](../advanced/how-to-create-graphics-objects-for-drawing.md).  
  
 <xref:System.Windows.Forms.Control.OnPaint%2A> Событие каждый раз, когда рисуется элемент управления или обновляется на экране и <xref:System.Windows.Forms.PaintEventArgs.ClipRectangle%2A> представляет прямоугольник, в котором рисования, будет иметь место. Если весь элемент управления необходимо обновить, <xref:System.Windows.Forms.PaintEventArgs.ClipRectangle%2A> будет представлять размер всего элемента управления. Если только часть элемента управления должен быть обновлен, однако <xref:System.Windows.Forms.PaintEventArgs.ClipRectangle%2A> объект будет представлять только область, которая должна быть перерисована. Примером такого случая может быть, если элемент управления частично закрыт другим элементом управления или формы в пользовательском интерфейсе.  
  
 При наследовании от <xref:System.Windows.Forms.Control> , необходимо переопределить <xref:System.Windows.Forms.Control.OnPaint%2A> метод и предоставить код отрисовки графики в пределах. Если вы хотите предоставить пользовательский графический интерфейс для пользовательского элемента управления или наследуемого элемента управления, это можно также сделать путем переопределения <xref:System.Windows.Forms.Control.OnPaint%2A> метод. Ниже приведен пример:  
  
```vb  
Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)  
   ' Call the OnPaint method of the base class.  
   MyBase.OnPaint(e)  
  
   ' Declare and instantiate a drawing pen.  
   Using myPen As System.Drawing.Pen = New System.Drawing.Pen(Color.Aqua)  
      ' Draw an aqua rectangle in the rectangle represented by the control.  
      e.Graphics.DrawRectangle(myPen, New Rectangle(Me.Location, Me.Size))  
   End Using
End Sub  
```  
  
```csharp  
protected override void OnPaint(PaintEventArgs e)  
{  
   // Call the OnPaint method of the base class.  
   base.OnPaint(e);  
  
   // Declare and instantiate a new pen.  
   using (System.Drawing.Pen myPen = new System.Drawing.Pen(Color.Aqua))  
   {
      // Draw an aqua rectangle in the rectangle represented by the control.  
      e.Graphics.DrawRectangle(myPen, new Rectangle(this.Location,   
         this.Size));  
   }
}  
```  
  
 Предыдущий пример демонстрирует отрисовки элемента управления с очень простой графическое представление. Он вызывает <xref:System.Windows.Forms.Control.OnPaint%2A> метод базового класса, он создает <xref:System.Drawing.Pen> объекта для рисования, и наконец рисуется эллипс в прямоугольнике, определяется <xref:System.Windows.Forms.Control.Location%2A> и <xref:System.Windows.Forms.Control.Size%2A> элемента управления. Несмотря на то, что большая часть кода отрисовки будет намного более сложным, в этом примере демонстрируется использование <xref:System.Drawing.Graphics> объект, содержащийся в <xref:System.Windows.Forms.PaintEventArgs> объекта. Обратите внимание, что если вы наследуете от класса, который уже имеет графическое представление, например <xref:System.Windows.Forms.UserControl> или <xref:System.Windows.Forms.Button>и не хотите включить это представление в рендеринг, не следует вызывать базовый класс <xref:System.Windows.Forms.Control.OnPaint%2A> метод.  
  
 Код в <xref:System.Windows.Forms.Control.OnPaint%2A> метод вашего элемента управления будет выполняться при первом рисовании элемента управления, и каждый раз, когда произойдет его обновление. Чтобы убедиться, что элемент управления перерисовывается при каждом изменении его размера, добавьте следующую строку в конструктор элемента управления:  
  
```vb  
SetStyle(ControlStyles.ResizeRedraw, True)  
```  
  
```csharp  
SetStyle(ControlStyles.ResizeRedraw, true);  
```  
  
> [!NOTE]
>  Используйте <xref:System.Windows.Forms.Control.Region%2A?displayProperty=nameWithType> свойство для реализации непрямоугольных управления.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Control.Region%2A>
- <xref:System.Windows.Forms.ControlStyles>
- <xref:System.Drawing.Graphics>
- <xref:System.Windows.Forms.Control.OnPaint%2A>
- <xref:System.Windows.Forms.PaintEventArgs>
- [Практическое руководство. Создание графических объектов для рисования](../advanced/how-to-create-graphics-objects-for-drawing.md)
- [Составные элементы управления](constituent-controls.md)
- [Создание собственных элементов управления](varieties-of-custom-controls.md)

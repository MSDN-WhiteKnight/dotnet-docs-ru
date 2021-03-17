---
title: Практическое руководство. Копирование пикселов для уменьшения эффекта дрожания изображения в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- bitblt
- graphics [Windows Forms], copying
- flicker [Windows Forms], reducing in Windows Forms
- graphics [Windows Forms], reducing flicker
- pixels [Windows Forms], copying
- flicker
- bit-block transfer
ms.assetid: 33b76910-13a3-4521-be98-5c097341ae3b
ms.openlocfilehash: e3d1c2b681e98dc7c45467683924dd4022eb377e
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59094038"
---
# <a name="how-to-copy-pixels-for-reducing-flicker-in-windows-forms"></a>Практическое руководство. Копирование пикселов для уменьшения эффекта дрожания изображения в Windows Forms
При анимации простой график, могут появиться мерцание или другие нежелательные визуальные эффекты. Чтобы ограничить эту проблему рекомендуется использовать процесс «bitblt» на рисунок. BitBlt является «битов перемещение» данных о цвете из исходного прямоугольника из пикселей в конечный прямоугольник пикселей.  
  
 С помощью Windows Forms, bitblt осуществляется с помощью <xref:System.Drawing.Graphics.CopyFromScreen%2A> метод <xref:System.Drawing.Graphics> класса. В параметры метода указать источник и назначения (в виде точек), размер области для копирования и объект graphics, используемый для рисования новой фигуры.  
  
 В приведенном ниже примере фигуры рисуется в форме в его <xref:System.Windows.Forms.Control.Paint> обработчик событий. Затем <xref:System.Drawing.Graphics.CopyFromScreen%2A> метод используется для копирования фигуры.  
  
> [!NOTE]
>  Свойства формы <xref:System.Windows.Forms.Control.DoubleBuffered%2A> свойства `true` будет выполнять код с графическим интерфейсом в <xref:System.Windows.Forms.Control.Paint> событие быть двойной буферизацией. Хотя это не приведет к любой ощутимого производительность при использовании приведенный ниже код, то это следует учитывать при работе с кодом более сложных манипуляций с графикой.  
  
## <a name="example"></a>Пример  
  
```vb  
Private Sub Form1_Paint(ByVal sender As Object, ByVal e As _  
    System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint  
    ' Draw a circle with a bar on top.  
        e.Graphics.FillEllipse(Brushes.DarkBlue, New Rectangle _  
             (10, 10, 60, 60))  
        e.Graphics.FillRectangle(Brushes.Khaki, New Rectangle _  
             (20, 30, 60, 10))  
    ' Copy the graphic to a new location.  
        e.Graphics.CopyFromScreen(New Point(10, 10), New Point _  
             (100, 100), New Size(70, 70))  
End Sub  
```  
  
```csharp  
private void Form1_Paint(System.Object sender,  
    System.Windows.Forms.PaintEventArgs e)  
        {  
        e.Graphics.FillEllipse(Brushes.DarkBlue, new  
            Rectangle(10,10,60,60));  
        e.Graphics.FillRectangle(Brushes.Khaki, new  
            Rectangle(20,30,60,10));  
        e.Graphics.CopyFromScreen(new Point(10, 10), new Point(100, 100),   
            new Size(70, 70));  
}  
```  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Приведенный выше код выполняется в форме <xref:System.Windows.Forms.Control.Paint> обработчик событий, чтобы изображение остается при перерисовке формы. Таким образом, не следует вызывать методы, связанные с графики в <xref:System.Windows.Forms.Form.Load> обработчик событий, так как не будет перерисовываться будет Если скрыта другой формой или изменении размера формы.  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.CopyPixelOperation>
- <xref:System.Drawing.Graphics.FillRectangle%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.Control.OnPaint%2A?displayProperty=nameWithType>
- [Объекты Graphics и Drawing в Windows Forms](graphics-and-drawing-in-windows-forms.md)
- [Рисование линий и фигур с помощью пера](using-a-pen-to-draw-lines-and-shapes.md)

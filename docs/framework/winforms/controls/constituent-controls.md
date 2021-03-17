---
title: Составные элементы управления
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- custom controls [Windows Forms], constituent controls
- constituent controls [Windows Forms]
- user controls [Windows Forms], constituent controls
ms.assetid: 5565e720-198b-4bbd-a2bd-c447ba641798
ms.openlocfilehash: 76a5a4f9b02a71616d247a1bb0f03cc0aec1d70d
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59224881"
---
# <a name="constituent-controls"></a>Составные элементы управления
Элементы управления, составляющие пользовательский элемент управления, или *составные элементы управления*, как они иначе называются, обеспечивают относительную гибкость, когда речь идет об отрисовке пользовательской графики. Все элементы управления Windows Forms обрабатывают собственную отрисовку, используя собственный <xref:System.Windows.Forms.Control.OnPaint%2A> метод. Так как этот метод защищен, он недоступен для разработчика и поэтому не может быть заблокирован при рисовании элемента управления. Это, однако, не означает, что нельзя добавить код, влияющий на внешний вид составных элементов управления. Дополнительную отрисовку можно выполнить путем добавления обработчика событий. Например, предположим, вы создаете <xref:System.Windows.Forms.UserControl> с помощью кнопки с именем `MyButton`. Если вы хотели бы отрисовки, которые не предоставляются классом <xref:System.Web.UI.WebControls.Button>, необходимо добавить код в пользовательский элемент управления, аналогичную следующей:  
  
```vb  
Public Sub MyPaint(ByVal sender as Object, e as PaintEventArgs) Handles _  
   MyButton.Paint  
   'Additional rendering code goes here  
End Sub  
```  
  
```csharp  
// Add the event handler to the button's Paint event.  
MyButton.Paint +=   
   new System.Windows.Forms.PaintEventHandler (this.MyPaint);  
// Create the custom painting method.  
protected void MyPaint (object sender,   
System.Windows.Forms.PaintEventArgs e)  
{  
   // Additional rendering code goes here.  
}  
```  
  
> [!NOTE]
>  Некоторые Windows Forms элементы управления, такие как <xref:System.Windows.Forms.TextBox>, рисуются непосредственно с Windows. В таком случае <xref:System.Windows.Forms.Control.OnPaint%2A> никогда не вызывается метод, и таким образом, приведенном выше примере никогда не будет вызываться.  
  
 При этом создается метод, который выполняется каждый раз при выполнении события `MyButton.Paint`, таким образом, добавляя дополнительное графическое представление для элемента управления. Обратите внимание, что это не блокирует выполнение `MyButton.OnPaint` и поэтому все операции рисования, обычно выполняемые кнопкой, по-прежнему будут выполняться наряду с настраиваемым рисованием. Дополнительные сведения о технологии GDI+ и настраиваемой отрисовке см. в разделе [Создание графических изображений с помощью GDI+](../advanced/how-to-create-graphics-objects-for-drawing.md). При необходимости получения уникального представления элемента управления оптимальным решением будет создание наследуемого элемента управления и написание для него собственного кода отрисовки. Дополнительные сведения см. в разделе [Элементы управления, разработанные пользователем](user-drawn-controls.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.UserControl>
- <xref:System.Windows.Forms.Control.OnPaint%2A>
- [Элементы управления, разработанные пользователем](user-drawn-controls.md)
- [Практическое руководство. Создание графических объектов для рисования](../advanced/how-to-create-graphics-objects-for-drawing.md)
- [Создание собственных элементов управления](varieties-of-custom-controls.md)

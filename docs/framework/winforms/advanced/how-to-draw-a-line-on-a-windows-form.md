---
title: Практическое руководство. Рисований линий в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
f1_keywords:
- Graphics.DrawLine
helpviewer_keywords:
- examples [Windows Forms], drawing lines on forms
- drawing [Windows Forms], lines
- lines [Windows Forms], drawing
- drawing lines
ms.assetid: 55c1dbeb-75d0-430c-9814-a24b8971ad8c
ms.openlocfilehash: aab04b9236175cedd154b817db5a6f6450503105
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59074453"
---
# <a name="how-to-draw-a-line-on-a-windows-form"></a>Практическое руководство. Рисований линий в Windows Forms
Этот пример рисует линию на форме. Как правило, рисование на форме осуществляют, обрабатывая событие <xref:System.Windows.Forms.Control.Paint> формы и выполняя отрисовку с использованием свойства <xref:System.Windows.Forms.PaintEventArgs.Graphics%2A> объекта <xref:System.Windows.Forms.PaintEventArgs>, как показано в следующем примере  
  
## <a name="example"></a>Пример  
 [!code-csharp[System.Drawing.UsingAPen#11](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.UsingAPen/CS/Class1.cs#11)]
 [!code-vb[System.Drawing.UsingAPen#11](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.UsingAPen/VB/Class1.vb#11)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs>`e`, который является параметром <xref:System.Windows.Forms.Control.Paint> обработчик событий.  
  
## <a name="robust-programming"></a>Отказоустойчивость  
 Следует всегда вызывать <xref:System.IDisposable.Dispose%2A> для любых объектов, которые потребляют системные ресурсы, например объектов <xref:System.Drawing.Pen>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Graphics.DrawLine%2A>
- <xref:System.Windows.Forms.Control.OnPaint%2A>
- [Приступая к программированию графики](getting-started-with-graphics-programming.md)
- [Рисование линий и фигур с помощью пера](using-a-pen-to-draw-lines-and-shapes.md)
- [Объекты Graphics и Drawing в Windows Forms](graphics-and-drawing-in-windows-forms.md)

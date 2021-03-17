---
title: Практическое руководство. Рисование прямоугольников с помощью пера
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- rectangles [Windows Forms], drawing
- pens [Windows Forms], drawing rectangles
ms.assetid: 54a7fa14-3ad8-4d64-b424-2a12005b250c
ms.openlocfilehash: 0e51a1e3a2d14754147dbd36f170127a7e978acd
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59074616"
---
# <a name="how-to-use-a-pen-to-draw-rectangles"></a>Практическое руководство. Рисование прямоугольников с помощью пера
Рисование прямоугольников, вам потребуется <xref:System.Drawing.Graphics> объекта и <xref:System.Drawing.Pen> объекта. <xref:System.Drawing.Graphics> Предоставляет <xref:System.Drawing.Graphics.DrawRectangle%2A> метод и <xref:System.Drawing.Pen> объект сохраняет функции, строки, таких как цвет и ширину.  
  
## <a name="example"></a>Пример  
 В следующем примере рисуется прямоугольник с его верхнего левого угла в (10, 10). Прямоугольник имеет ширину 100 и высотой 50. Второй аргумент, переданный <xref:System.Drawing.Pen.%23ctor%2A> конструктор указывает, что толщина пера равно 5 пикселям.  
  
 При рисовании прямоугольника перо располагается по центру прямоугольника границ. Поскольку ширины пера равно 5, сторон прямоугольника являются формируемого 5 пикселов шириной 1 пиксель рисуется по самой границе, рисуются 2 пикселя внутри, и 2 пикселя рисуются с внешней стороны. Дополнительные сведения о см. в разделе [как: Значение толщины и выравнивания пера](how-to-set-pen-width-and-alignment.md).  
  
 На следующем рисунке показан полученный прямоугольник. Пунктирные линии показывают, где был бы нарисован прямоугольник, если ширина пера был один пиксель. Увеличенное верхнего левого угла прямоугольника показывает, что жирные черные линии центрируются по эти пунктирные линии.  
  
 ![Снимок экрана, показывающий изображенного прямоугольника с черным и пунктирные линии.](./media/how-to-use-a-pen-to-draw-rectangles/drawn-rectangle-black-lines-dotted-lines.gif)  
  
 [!code-csharp[System.Drawing.UsingAPen#21](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.UsingAPen/CS/Class1.cs#21)]
 [!code-vb[System.Drawing.UsingAPen#21](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.UsingAPen/VB/Class1.vb#21)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs>`e`, который является параметром <xref:System.Windows.Forms.Control.Paint> обработчик событий.  
  
## <a name="see-also"></a>См. также

- [Рисование линий и фигур с помощью пера](using-a-pen-to-draw-lines-and-shapes.md)

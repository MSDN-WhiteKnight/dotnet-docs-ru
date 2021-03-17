---
title: Практическое руководство. Рисование последовательности B&#233;сплайны Безье
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- splines [Windows Forms], drawing Bezier
- Bezier splines [Windows Forms], drawing sequence of
ms.assetid: 37a0bedb-20c2-4cf0-91fa-a5509e826b30
ms.openlocfilehash: 976787f5830282a581d05a9c24d1f83dceca4b25
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59168159"
---
# <a name="how-to-draw-a-sequence-of-b233zier-splines"></a>Практическое руководство. Рисование последовательности B&#233;сплайны Безье
Можно использовать <xref:System.Drawing.Graphics.DrawBeziers%2A> метод <xref:System.Drawing.Graphics> класса, чтобы нарисовать последовательность подключенных сплайнов Безье.  
  
## <a name="example"></a>Пример  
 В следующем примере рисуется кривой, которая состоит из двух подключенных сплайнов Безье. Конечная точка первого сплайна Безье является начальной точкой второй сплайна Безье.  
  
 На следующем рисунке показан подключенных сплайнов и семь точек:  
  
 ![Рисунок, показывающий соединенные сплайны и семь точек.](./media/how-to-draw-a-sequence-of-bezier-splines/bezier-spline-seven-points.png)  
  
 [!code-csharp[System.Drawing.ConstructingDrawingCurves#11](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.ConstructingDrawingCurves/CS/Class1.cs#11)]
 [!code-vb[System.Drawing.ConstructingDrawingCurves#11](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.ConstructingDrawingCurves/VB/Class1.vb#11)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs> `e`, который является параметром <xref:System.Windows.Forms.Control.Paint> обработчик событий.  
  
## <a name="see-also"></a>См. также

- [Объекты Graphics и Drawing в Windows Forms](graphics-and-drawing-in-windows-forms.md)
- [Сплайны Безье в GDI+](bezier-splines-in-gdi.md)
- [Построение и рисование кривых](constructing-and-drawing-curves.md)

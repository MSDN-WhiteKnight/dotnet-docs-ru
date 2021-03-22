---
title: Практическое руководство. Рисование фундаментальных сплайнов
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- cardinal splines [Windows Forms], drawing
- drawing [Windows Forms], cardinal splines
- graphics [Windows Forms], cardinal splines
ms.assetid: a4a41e80-4461-4b47-b6bd-2c5e68881994
ms.openlocfilehash: 2f03177bf97936a2ca9558972d4d82fa3e07463c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59204956"
---
# <a name="how-to-draw-cardinal-splines"></a>Практическое руководство. Рисование фундаментальных сплайнов
Фундаментальный сплайн представляет кривую, проходящую через заданные точки. Чтобы нарисовать фундаментальный сплайн, создайте <xref:System.Drawing.Graphics> и передать адрес массив точек для <xref:System.Drawing.Graphics.DrawCurve%2A> метод.  
  
### <a name="drawing-a-bell-shaped-cardinal-spline"></a>Рисование колоколообразной фундаментального сплайна  
  
-   Следующий пример выводит колоколообразной фундаментальный сплайн, проходящий через пять определенных точек. На следующем рисунке кривой и пять точек.  
  
     ![Схема, показывающая колоколообразной фундаментальный сплайн.](./media/how-to-draw-cardinal-splines/bell-shaped-cardinal-spline.png)  
  
 [!code-csharp[System.Drawing.ConstructingDrawingCurves#21](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.ConstructingDrawingCurves/CS/Class1.cs#21)]
   
  
### <a name="drawing-a-closed-cardinal-spline"></a>Рисование замкнутую кривую Кардинала  
  
-   Используйте <xref:System.Drawing.Graphics.DrawClosedCurve%2A> метод <xref:System.Drawing.Graphics> классе для рисования замкнутый фундаментальный сплайн. В замкнутой фундаментальной кривой продолжается с помощью последней точки в массиве и подключается с первой точки в массиве. В следующем примере рисуется замкнутый фундаментальный сплайн, проходящий через шесть определенных точек. На следующем рисунке показан замкнутый сплайн и шесть точек:  
  
 ![Схема, показывающая замкнутый фундаментальный сплайн.](./media/how-to-draw-cardinal-splines/closed-cardinal-spine.png)  
  
 [!code-csharp[System.Drawing.ConstructingDrawingCurves#22](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.ConstructingDrawingCurves/CS/Class1.cs#22)]
   
  
### <a name="changing-the-bend-of-a-cardinal-spline"></a>Изменение изгиба фундаментального сплайна  
  
-   Изменить способ изгиб фундаментального сплайна, передав аргумент натяжение <xref:System.Drawing.Graphics.DrawCurve%2A> метод. В следующем примере рисуется три фундаментальные сплайны, которые проходят через тот же набор точек. Ниже представлены три сплайна вместе со значениями натяжение. Обратите внимание, что если натяжение равно 0, точки соединенных прямых линий.  
  
 ![Схема, показывающая три фундаментальные сплайны.](./media/how-to-draw-cardinal-splines/three-cardinal-splines.png)  
  
 [!code-csharp[System.Drawing.ConstructingDrawingCurves#23](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.ConstructingDrawingCurves/CS/Class1.cs#23)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример предназначен для работы с Windows Forms, и они требуют <xref:System.Windows.Forms.PaintEventArgs> `e`, который является параметром <xref:System.Windows.Forms.Control.Paint> обработчик событий.  
  
## <a name="see-also"></a>См. также

- [Прямые и кривые линии и фигуры](lines-curves-and-shapes.md)
- [Построение и рисование кривых](constructing-and-drawing-curves.md)

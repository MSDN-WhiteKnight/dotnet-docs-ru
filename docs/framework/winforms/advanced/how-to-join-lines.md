---
title: Практическое руководство. Соединение линий
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- miter line join style
- bevel line join style
- line join
- drawing [Windows Forms], joining lines
- GraphicsPath object
- round line join style
- lines [Windows Forms], joining
- graphics [Windows Forms], joining lines
ms.assetid: 9fc480c2-3c75-4fd1-8ab5-296a99e820e2
ms.openlocfilehash: 445d7f12f57137c6b06a074eeaf0574eb027a723
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59174919"
---
# <a name="how-to-join-lines"></a>Практическое руководство. Соединение линий
Соединение линий — это общая область, сформированное две строки, в которых заканчивается достигают или перекрываться. [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] предоставляет три стиля соединения линий: фацетное соединение, рельеф и округления. Стиль соединения линий — это свойство <xref:System.Drawing.Pen> класса. При указании стиль соединения линий для <xref:System.Drawing.Pen> объекта, что стиль будет применяться для всех соединенных линий в любом <xref:System.Drawing.Drawing2D.GraphicsPath> объекта, отображаются с помощью этого пера.  
  
 Ниже показаны результаты в примере скошенные строки соединения.  
  
 ![Рисунок, показывающий соединяемых строк.](./media/how-to-join-lines/joined-beveled-lines.gif)  
  
## <a name="example"></a>Пример  
 Можно указать стиль соединения линий с помощью <xref:System.Drawing.Pen.LineJoin%2A> свойство <xref:System.Drawing.Pen> класса. В примере скошенное соединение линий между горизонтальной и вертикальной линией. В следующем коде значение <xref:System.Drawing.Drawing2D.LineJoin.Bevel> назначенные <xref:System.Drawing.Pen.LineJoin%2A> свойства является членом <xref:System.Drawing.Drawing2D.LineJoin> перечисления. Другие члены <xref:System.Drawing.Drawing2D.LineJoin> перечисления являются <xref:System.Drawing.Drawing2D.LineJoin.Miter> и <xref:System.Drawing.Drawing2D.LineJoin.Round>.  
  
 [!code-csharp[System.Drawing.UsingAPen#31](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.UsingAPen/CS/Class1.cs#31)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs> `e`, который является параметром <xref:System.Windows.Forms.Control.Paint> обработчик событий.  
  
## <a name="see-also"></a>См. также

- [Рисование линий и фигур с помощью пера](using-a-pen-to-draw-lines-and-shapes.md)

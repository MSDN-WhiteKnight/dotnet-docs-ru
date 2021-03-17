---
title: Перья, линии и прямоугольники в GDI+
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- lines
- GDI+, lines
- drawing [Windows Forms], rectangles
- rectangles
- drawing [Windows Forms], lines
- GDI+, pens
- examples [Windows Forms], drawing lines and shapes
- examples [Windows Forms], pens
- GDI+, rectangles
- examples [Windows Forms], GDI+
- lines [Windows Forms], dashed
ms.assetid: 30b25aae-e3eb-4479-bdb8-187cf651fc84
ms.openlocfilehash: 84752773c0b56d9684dc31620d463d4ddccf9dad
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59078230"
---
# <a name="pens-lines-and-rectangles-in-gdi"></a>Перья, линии и прямоугольники в GDI+
Чтобы нарисовать линии с [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] необходимо создать <xref:System.Drawing.Graphics> объекта и <xref:System.Drawing.Pen> объекта. <xref:System.Drawing.Graphics> Объект предоставляет методы, которые фактически выполняют рисование, и <xref:System.Drawing.Pen> объект сохраняет атрибуты, такие как цвет, ширину и стиль.  
  
## <a name="drawing-a-line"></a>Рисование линии  
 Чтобы нарисовать линию, вызовите <xref:System.Drawing.Graphics.DrawLine%2A> метод <xref:System.Drawing.Graphics> объекта. <xref:System.Drawing.Pen> Объект передается в качестве одного из аргументов <xref:System.Drawing.Graphics.DrawLine%2A> метод. В следующем примере рисуется линию из точки (4, 2) в точку ("12", "6"):  
  
 [!code-csharp[LinesCurvesAndShapes#41](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#41)]
 [!code-vb[LinesCurvesAndShapes#41](~/samples/snippets/visualbasic/VS_Snippets_Winforms/LinesCurvesAndShapes/VB/Class1.vb#41)]  
  
 <xref:System.Drawing.Graphics.DrawLine%2A> — перегруженный метод <xref:System.Drawing.Graphics> класса, поэтому существует несколько способов передачи аргументов. Например, можно создать два <xref:System.Drawing.Point> и передать <xref:System.Drawing.Point> объектов в качестве аргументов <xref:System.Drawing.Graphics.DrawLine%2A> метод:  
  
 [!code-csharp[LinesCurvesAndShapes#42](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#42)]
 [!code-vb[LinesCurvesAndShapes#42](~/samples/snippets/visualbasic/VS_Snippets_Winforms/LinesCurvesAndShapes/VB/Class1.vb#42)]  
  
## <a name="constructing-a-pen"></a>Создание объекта Pen  
 Можно указать несколько атрибутов, при создании <xref:System.Drawing.Pen> объекта. Например, один `Pen` конструктор позволяет указать цвет и ширину. В следующем примере рисуется синяя линия от ширины 2 от (0, 0) для (60, 30):  
  
 [!code-csharp[LinesCurvesAndShapes#43](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#43)]
 [!code-vb[LinesCurvesAndShapes#43](~/samples/snippets/visualbasic/VS_Snippets_Winforms/LinesCurvesAndShapes/VB/Class1.vb#43)]  
  
## <a name="dashed-lines-and-line-caps"></a>Пунктирные линии и завершения отрезков  
 <xref:System.Drawing.Pen> Объект также предоставляет свойства, такие как <xref:System.Drawing.Pen.DashStyle%2A>, можно использовать для указания свойства линии. В следующем примере рисуется пунктирная линия с (100, 50) к (300, 80):  
  
 [!code-csharp[LinesCurvesAndShapes#44](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#44)]
 [!code-vb[LinesCurvesAndShapes#44](~/samples/snippets/visualbasic/VS_Snippets_Winforms/LinesCurvesAndShapes/VB/Class1.vb#44)]  
  
 Можно использовать свойства <xref:System.Drawing.Pen> объекта можно задать многие атрибуты линии. <xref:System.Drawing.Pen.StartCap%2A> И <xref:System.Drawing.Pen.EndCap%2A> свойства определяют внешний вид концах линии; может заканчиваться неструктурированный square, треугольником, или пользовательской фигуры. <xref:System.Drawing.Pen.LineJoin%2A> Свойство позволяет указать ли соединенных линий углом (присоединение с острые углы), скошенные, округленное или обрезается. Ниже показаны строки с использованием различных стилей завершения и соединения.  
  
 ![Строки](./media/aboutgdip02-art04.gif "Aboutgdip02_art04")  
  
## <a name="drawing-a-rectangle"></a>Рисование прямоугольника  
 Рисование прямоугольников с [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] похоже на рисование линий. Чтобы нарисовать прямоугольник, вам потребуется <xref:System.Drawing.Graphics> объекта и <xref:System.Drawing.Pen> объекта. <xref:System.Drawing.Graphics> Предоставляет <xref:System.Drawing.Graphics.DrawRectangle%2A> метод и <xref:System.Drawing.Pen> объект сохраняет атрибуты, такие как толщины и цвета. <xref:System.Drawing.Pen> Объект передается в качестве одного из аргументов <xref:System.Drawing.Graphics.DrawRectangle%2A> метод. В следующем примере рисуется прямоугольник с его верхнего левого угла в (100, 50), ширины 80, а высота — 40:  
  
 [!code-csharp[LinesCurvesAndShapes#45](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#45)]
 [!code-vb[LinesCurvesAndShapes#45](~/samples/snippets/visualbasic/VS_Snippets_Winforms/LinesCurvesAndShapes/VB/Class1.vb#45)]  
  
 <xref:System.Drawing.Graphics.DrawRectangle%2A> — перегруженный метод <xref:System.Drawing.Graphics> класса, поэтому существует несколько способов передачи аргументов. Например, можно создать <xref:System.Drawing.Rectangle> и передать <xref:System.Drawing.Rectangle> объект <xref:System.Drawing.Graphics.DrawRectangle%2A> метод в качестве аргумента:  
  
 [!code-csharp[LinesCurvesAndShapes#46](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#46)]
 [!code-vb[LinesCurvesAndShapes#46](~/samples/snippets/visualbasic/VS_Snippets_Winforms/LinesCurvesAndShapes/VB/Class1.vb#46)]  
  
 Объект <xref:System.Drawing.Rectangle> содержит методы и свойства для обработки и сбора сведений о прямоугольника. Например <xref:System.Drawing.Rectangle.Inflate%2A> и <xref:System.Drawing.Rectangle.Offset%2A> методы изменять размер и положение прямоугольника. <xref:System.Drawing.Rectangle.IntersectsWith%2A> Метод указывает, является ли прямоугольник пересекается с другим указанным прямоугольником и <xref:System.Drawing.Rectangle.Contains%2A> метод указывает, является ли заданная точка находится внутри прямоугольника.  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Graphics?displayProperty=nameWithType>
- <xref:System.Drawing.Pen?displayProperty=nameWithType>
- <xref:System.Drawing.Rectangle?displayProperty=nameWithType>
- [Практическое руководство. Создание пера](how-to-create-a-pen.md)
- [Практическое руководство. Рисований линий в Windows Forms](how-to-draw-a-line-on-a-windows-form.md)
- [Практическое руководство. Рисование линии или контурной фигуры](how-to-draw-an-outlined-shape.md)

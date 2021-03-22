---
title: Замкнутые и незамкнутые кривые в GDI+
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- curves [Windows Forms], filling
- GDI+, curves
- curves [Windows Forms], drawing
- curves
ms.assetid: 08d2cc9a-dc9d-4eed-bcbb-2c8e2ca5d3ae
ms.openlocfilehash: 33a8954296a7e63637ad5e210fb30fba1a3fdd53
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59165117"
---
# <a name="open-and-closed-curves-in-gdi"></a>Замкнутые и незамкнутые кривые в GDI+
На следующем рисунке показано две кривые: открытая и закрытая.  
  
 ![Замкнутые и незамкнутые кривые](./media/aboutgdip02-art24.gif "Aboutgdip02_art24")  
  
## <a name="managed-interface-for-curves"></a>Управляемый интерфейс для кривых  
 Замкнутых кривых есть внутренняя область, поэтому могут заполняться с помощью кисти. <xref:System.Drawing.Graphics> В класс [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] предоставляет следующие методы для заполнения замкнутые фигуры и кривых: <xref:System.Drawing.Graphics.FillRectangle%2A>, <xref:System.Drawing.Graphics.FillEllipse%2A>, <xref:System.Drawing.Graphics.FillPie%2A>, <xref:System.Drawing.Graphics.FillPolygon%2A>, <xref:System.Drawing.Graphics.FillClosedCurve%2A>, <xref:System.Drawing.Graphics.FillPath%2A>, и <xref:System.Drawing.Graphics.FillRegion%2A>. При вызове одного из этих методов, необходимо передать тип кисти (<xref:System.Drawing.SolidBrush>, <xref:System.Drawing.Drawing2D.HatchBrush>, <xref:System.Drawing.TextureBrush>, <xref:System.Drawing.Drawing2D.LinearGradientBrush>, или <xref:System.Drawing.Drawing2D.PathGradientBrush>) в качестве аргумента.  
  
 <xref:System.Drawing.Graphics.FillPie%2A> Метод является дополнением к <xref:System.Drawing.Graphics.DrawArc%2A> метод. Так же, как <xref:System.Drawing.Graphics.DrawArc%2A> метод рисует части контура эллипса, <xref:System.Drawing.Graphics.FillPie%2A> метод заполняет часть внутреннюю часть эллипса. В следующем примере рисуется дуга и заполняет внутреннюю часть эллипса соответствующей части:  
  
 [!code-csharp[LinesCurvesAndShapes#21](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#21)]
   
  
 Ниже показан дуги и заполненный круг.  
  
 ![Замкнутые и незамкнутые кривые](./media/aboutgdip02-art25.gif "Aboutgdip02_art25")  
  
 <xref:System.Drawing.Graphics.FillClosedCurve%2A> Метод является дополнением к <xref:System.Drawing.Graphics.DrawClosedCurve%2A> метод. Оба метода автоматически закрывать кривой, подключившись к начальной точке конечной точки. В следующем примере рисуется кривую, проходящих через (0, 0), (60, 20) и (40, 50). Затем кривой автоматически закрывается, подключив (40, 50) до начальной точки (0, 0), а внутренняя область заполняется сплошным цветом.  
  
 [!code-csharp[LinesCurvesAndShapes#22](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#22)]
   
  
 <xref:System.Drawing.Graphics.FillPath%2A> Метод заполняет внутреннюю часть различных частей пути. Если часть пути, не образует замкнутую кривую, <xref:System.Drawing.Graphics.FillPath%2A> метод автоматически закрывает этот самый кусок путь до его заполнения. В следующем примере рисует и заполняет путь, который состоит из дуги, фундаментальный сплайн, строка и сектора:  
  
 [!code-csharp[LinesCurvesAndShapes#23](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#23)]
   
  
 Ниже показан путь с и без сплошной заливки. Обратите внимание, что текст в строке контуров символов, но не заполнено, <xref:System.Drawing.Graphics.DrawPath%2A> метод. Это <xref:System.Drawing.Graphics.FillPath%2A> метод закрашиваются символов в строке.  
  
 ![Строка в пути](./media/aboutgdip02-art26.gif "Aboutgdip02_art26")  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Drawing2D.GraphicsPath?displayProperty=nameWithType>
- <xref:System.Drawing.Pen?displayProperty=nameWithType>
- <xref:System.Drawing.Point?displayProperty=nameWithType>
- [Прямые и кривые линии и фигуры](lines-curves-and-shapes.md)
- [Практическое руководство. Создание графических объектов для рисования](how-to-create-graphics-objects-for-drawing.md)
- [Построение и рисование контуров](constructing-and-drawing-paths.md)

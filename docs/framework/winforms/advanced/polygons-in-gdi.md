---
title: Многоугольники в GDI+
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- polygons
- drawing [Windows Forms], polygons
- GDI+, polygons
ms.assetid: a72213d2-d69a-4c2b-a75c-be7b20390c13
ms.openlocfilehash: 2b1e3d387e4d056d9187c54dcef560544206c370
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59132630"
---
# <a name="polygons-in-gdi"></a>Многоугольники в GDI+
Многоугольник — замкнутой фигуры с тремя или более прямые стороны. Например треугольник — это многоугольник с трех сторон, прямоугольник — это многоугольник с четырех сторон и пятиугольник — это многоугольник с пятью сторонами. На следующем рисунке несколько многоугольников.  
  
 ![Многоугольники](./media/aboutgdip02-art07.gif "Aboutgdip02_art07")  
  
## <a name="drawing-a-polygon"></a>Рисование многоугольника  
 Чтобы нарисовать прямоугольник, вам потребуется <xref:System.Drawing.Graphics> объекта, <xref:System.Drawing.Pen> объекта, а также массив <xref:System.Drawing.Point> (или <xref:System.Drawing.PointF>) объектов. <xref:System.Drawing.Graphics> Предоставляет <xref:System.Drawing.Graphics.DrawPolygon%2A> метод. <xref:System.Drawing.Pen> Объект сохраняет атрибуты, например, ширина и цвет линии, используемый для визуализации многоугольника, а также массив <xref:System.Drawing.Point> объектов содержит все точки, чтобы быть соединенных прямых линий. <xref:System.Drawing.Pen> Объект и массив <xref:System.Drawing.Point> объекты передаются как аргументы для <xref:System.Drawing.Graphics.DrawPolygon%2A> метод. В следующем примере рисуется три стороны многоугольника. Обратите внимание, что только три точки в `myPointArray`: (0, 0), (50, 30) и (30, 60). <xref:System.Drawing.Graphics.DrawPolygon%2A> Метод автоматически закрывает многоугольника путем рисования линии из (30, 60) обратно к начальной точке (0, 0).  
  
 [!code-csharp[LinesCurvesAndShapes#111](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#111)]
   
  
 На следующем рисунке многоугольника.  
  
 ![Многоугольник](./media/aboutgdip02-art08.gif "Aboutgdip02_art08")  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Graphics?displayProperty=nameWithType>
- <xref:System.Drawing.Pen?displayProperty=nameWithType>
- [Прямые и кривые линии и фигуры](lines-curves-and-shapes.md)
- [Практическое руководство. Создание пера](how-to-create-a-pen.md)

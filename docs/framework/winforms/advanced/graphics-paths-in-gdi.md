---
title: Контуры в GDI+
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- graphics [Windows Forms], paths
- GDI+, drawing paths
- paths [Windows Forms], drawing
- drawing [Windows Forms], paths
ms.assetid: a5500dec-666c-41fd-9da3-2169dd89c5eb
ms.openlocfilehash: c9a43065210f5ef0fffcae01cc7eb88349696b6b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59140508"
---
# <a name="graphics-paths-in-gdi"></a>Контуры в GDI+
Пути сформированном путем объединения линии, прямоугольники и простой кривых. Как следует из [Общие сведения о векторной графики](vector-graphics-overview.md) что следующих основных блоков оказались наиболее подходят для рисования изображений:  
  
-   Прямых линий  
  
-   Прямоугольники  
  
-   Многоточие  
  
-   Дуги  
  
-   Многоугольники  
  
-   Фундаментальные сплайны  
  
-   Сплайны Безье  
  
 В GDI + <xref:System.Drawing.Drawing2D.GraphicsPath> объект позволяет собирать последовательность из этих блоков в единое целое. Вся последовательность линии, прямоугольники, многоугольники и кривых могут быть нарисована за одно обращение <xref:System.Drawing.Graphics.DrawPath%2A> метод <xref:System.Drawing.Graphics> класса. Ниже показан путь, полученное путем объединения строки, дуги, сплайна Безье и фундаментальный сплайн.  
  
 ![Путь](./media/aboutgdip02-art14.gif "Aboutgdip02_art14")  
  
## <a name="using-a-path"></a>С помощью пути  
 <xref:System.Drawing.Drawing2D.GraphicsPath> Класс предоставляет следующие методы для создания последовательность элементов для отрисовки: <xref:System.Drawing.Drawing2D.GraphicsPath.AddLine%2A>, <xref:System.Drawing.Drawing2D.GraphicsPath.AddRectangle%2A>, <xref:System.Drawing.Drawing2D.GraphicsPath.AddEllipse%2A>, <xref:System.Drawing.Drawing2D.GraphicsPath.AddArc%2A>, <xref:System.Drawing.Drawing2D.GraphicsPath.AddPolygon%2A>, <xref:System.Drawing.Drawing2D.GraphicsPath.AddCurve%2A> (для фундаментальные сплайны), и <xref:System.Drawing.Drawing2D.GraphicsPath.AddBezier%2A>. Каждый из этих методов перегружена; то есть каждый метод поддерживает несколько различными списками параметров. Например, один из вариантов <xref:System.Drawing.Drawing2D.GraphicsPath.AddLine%2A> метод получает четырех целых чисел, а в другом варианте <xref:System.Drawing.Drawing2D.GraphicsPath.AddLine%2A> метод получает два <xref:System.Drawing.Point> объектов.  
  
 Методы для добавления линии, прямоугольники и сплайны Безье в пути имеют вспомогательные методы, выполняющие добавьте несколько элементов пути за один вызов: <xref:System.Drawing.Drawing2D.GraphicsPath.AddLines%2A>, <xref:System.Drawing.Drawing2D.GraphicsPath.AddRectangles%2A>, и <xref:System.Drawing.Drawing2D.GraphicsPath.AddBeziers%2A>. Кроме того <xref:System.Drawing.Drawing2D.GraphicsPath.AddCurve%2A> и <xref:System.Drawing.Drawing2D.GraphicsPath.AddArc%2A> методы существуют вспомогательные методы <xref:System.Drawing.Drawing2D.GraphicsPath.AddClosedCurve%2A> и <xref:System.Drawing.Drawing2D.GraphicsPath.AddPie%2A>, которые расширяют секции замкнутой кривой или круговой путь.  
  
 Чтобы нарисовать контур, вам потребуется <xref:System.Drawing.Graphics> объекта, <xref:System.Drawing.Pen> объекта и <xref:System.Drawing.Drawing2D.GraphicsPath> объекта. <xref:System.Drawing.Graphics> Предоставляет <xref:System.Drawing.Graphics.DrawPath%2A> метод и <xref:System.Drawing.Pen> объект сохраняет атрибуты, например, ширина и цвет линии, используемый для визуализации путь. <xref:System.Drawing.Drawing2D.GraphicsPath> Объект сохраняет последовательность линий и кривых линий, составляющих путь. <xref:System.Drawing.Pen> Объекта и <xref:System.Drawing.Drawing2D.GraphicsPath> объекта передаются как аргументы для <xref:System.Drawing.Graphics.DrawPath%2A> метод. В следующем примере рисуется путь, который состоит из строки, эллипс и сплайн Безье:  
  
 [!code-csharp[LinesCurvesAndShapes#101](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#101)]
   
  
 На следующем рисунке путь.  
  
 ![Путь](./media/aboutgdip02-art15.gif "Aboutgdip02_art15")  
  
 Помимо добавления линии, прямоугольники и кривые к пути, можно добавить пути к пути. Это позволяет объединять существующие пути для формирования больших и сложных путей.  
  
 [!code-csharp[LinesCurvesAndShapes#102](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#102)]
   
  
 Два других элемента, можно добавить в путь: строку и сектор. Сектор — часть внутреннюю часть эллипса. В следующем примере создается путь из дуги, фундаментальный сплайн, строка и сектора:  
  
 [!code-csharp[LinesCurvesAndShapes#103](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#103)]
   
  
 На следующем рисунке путь. Обратите внимание, что путь не обязательно должен быть подключен; arc, фундаментальный сплайн, строка и круговой разделены.  
  
 ![Пути](./media/aboutgdip02-art16.gif "Aboutgdip02_Art16")  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Drawing2D.GraphicsPath?displayProperty=nameWithType>
- <xref:System.Drawing.Point?displayProperty=nameWithType>
- [Прямые и кривые линии и фигуры](lines-curves-and-shapes.md)
- [Практическое руководство. Создание графических объектов для рисования](how-to-create-graphics-objects-for-drawing.md)
- [Построение и рисование контуров](constructing-and-drawing-paths.md)

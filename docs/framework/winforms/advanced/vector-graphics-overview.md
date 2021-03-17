---
title: Общие сведения о векторной графике
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- inclusive-inclusive endpoints
- coordinate systems
- graphics [Windows Forms], vector graphics
ms.assetid: 0195df81-66be-452d-bb53-5a582ebfdc09
ms.openlocfilehash: d424254839db6c403bafe779f475c0e344918a5e
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59087967"
---
# <a name="vector-graphics-overview"></a>Общие сведения о векторной графике
[!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] Рисует линии, прямоугольники и других фигур в системе координат. Можно выбрать из различных систем координат, но система координат по умолчанию имеет начало координат в левом верхнем углу ось x вправо, а ось y направлена вниз. Единицы измерения в системе координат по умолчанию является пиксель.  
  
## <a name="the-building-blocks-of-gdi"></a>Стандартные блоки GDI +  
 ![Векторная графика](./media/aboutgdip02-art01.gif "AboutGdip02_Art01")  
  
 Монитор компьютера создает его отображение на прямоугольный массив точек, называемых элементами изображения. Разное количество пикселей, отображаемых на экране монитора к другому, а количество пикселей, которые отображаются на отдельных мониторе обычно можно в некоторой степени пользователем.  
  
 ![Векторная графика](./media/aboutgdip02-art02.gif "AboutGdip02_Art02")  
  
 При использовании [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] Чтобы нарисовать линию, прямоугольник или кривой, предоставляют ключевая информация об элементе для отрисовки. Например можно указать строку, предоставляя две точки, и можно указать, предоставляя точку, высоту и ширину прямоугольника. [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] работает в сочетании с программным обеспечением драйвера экрана, чтобы определить, какие точек должен быть включен для отображения линии, прямоугольника или кривой. На следующем рисунке пиксели, которые включены для отображения линии из точки (4, 2) в точку ("12", "8").  
  
 ![Векторная графика](./media/aboutgdip02-art03.gif "AboutGdip02_Art03")  
  
 Со временем некоторые основные стандартные блоки оказались наиболее удобно для создания двухмерных изображений. Эти стандартные блоки, которые поддерживаются системой [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)], приведены в следующем списке:  
  
-   Прямых линий  
  
-   Прямоугольники  
  
-   Многоточие  
  
-   Дуги  
  
-   Многоугольники  
  
-   Фундаментальные сплайны  
  
-   сплайны Безье  
  
## <a name="methods-for-drawing-with-a-graphics-object"></a>Методы для рисования с помощью графических объектов  
 <xref:System.Drawing.Graphics> В класс [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] предоставляет следующие методы для рисования элементов в списке выше: <xref:System.Drawing.Graphics.DrawLine%2A>, <xref:System.Drawing.Graphics.DrawRectangle%2A>, <xref:System.Drawing.Graphics.DrawEllipse%2A>, <xref:System.Drawing.Graphics.DrawPolygon%2A>, <xref:System.Drawing.Graphics.DrawArc%2A>, <xref:System.Drawing.Graphics.DrawCurve%2A> (для фундаментальные сплайны), и <xref:System.Drawing.Graphics.DrawBezier%2A>. Каждый из этих методов перегружена; то есть каждый метод поддерживает несколько различными списками параметров. Например, один из вариантов <xref:System.Drawing.Graphics.DrawLine%2A> метод получает <xref:System.Drawing.Pen> объекта и четырех целых чисел, а другой вариант <xref:System.Drawing.Graphics.DrawLine%2A> метод получает <xref:System.Drawing.Pen> и два <xref:System.Drawing.Point> объектов.  
  
 Методы для рисования линий, прямоугольников и сплайнов Безье иметь вспомогательные методы, выполняющие нарисовать несколько элементов за один вызов: <xref:System.Drawing.Graphics.DrawLines%2A>, <xref:System.Drawing.Graphics.DrawRectangles%2A>, и <xref:System.Drawing.Graphics.DrawBeziers%2A>. Кроме того <xref:System.Drawing.Graphics.DrawCurve%2A> метод имеет вспомогательный метод, <xref:System.Drawing.Graphics.DrawClosedCurve%2A>, что точка кривой, подключившись к начальной конечной точки кривой закрывается.  
  
 Все методы рисования <xref:System.Drawing.Graphics> используют с <xref:System.Drawing.Pen> объекта. Чтобы нарисовать что-либо, необходимо создать по крайней мере два объекта: <xref:System.Drawing.Graphics> объекта и <xref:System.Drawing.Pen> объекта. <xref:System.Drawing.Pen> Объект сохраняет атрибуты, такие как толщины и цвета, рисуемого элемента. <xref:System.Drawing.Pen> Объект передается в качестве одного из аргументов метод рисования. Например, один из вариантов <xref:System.Drawing.Graphics.DrawLine%2A> метод получает <xref:System.Drawing.Pen> объекта и четырех целых чисел, как показано в следующем примере, который рисует прямоугольник с шириной 100, высотой 50 и координатами верхнего левого угла (20, 10):  
  
 [!code-csharp[LinesCurvesAndShapes#11](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#11)]
 [!code-vb[LinesCurvesAndShapes#11](~/samples/snippets/visualbasic/VS_Snippets_Winforms/LinesCurvesAndShapes/VB/Class1.vb#11)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Graphics?displayProperty=nameWithType>
- <xref:System.Drawing.Pen?displayProperty=nameWithType>
- [Прямые и кривые линии и фигуры](lines-curves-and-shapes.md)
- [Практическое руководство. Создание графических объектов для рисования](how-to-create-graphics-objects-for-drawing.md)

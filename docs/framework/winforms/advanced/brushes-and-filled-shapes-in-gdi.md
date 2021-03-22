---
title: Кисти и закрашенные фигуры в GDI+
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- brushes [Windows Forms], GDI+
- filled shapes [Windows Forms], GDI+
- shapes [Windows Forms], GDI+
- GDI+, brushes
- GDI+, filled shapes
- gradient brushes
- brushes [Windows Forms], gradient
ms.assetid: e863e2a7-0294-4130-99b6-f1ea3201e7cd
ms.openlocfilehash: 683b5966f993ac3a69c8bf7c1233b6df3d65e19a
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59115314"
---
# <a name="brushes-and-filled-shapes-in-gdi"></a>Кисти и закрашенные фигуры в GDI+
Замкнутые фигуры, например прямоугольник или эллипс, состоит из структуры и внутренней частью. Контур рисуется с помощью пера и внутренняя область заполняется с помощью кисти. [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] предоставляет несколько классов кисти для заливки фигур, закрытых: <xref:System.Drawing.SolidBrush>, <xref:System.Drawing.Drawing2D.HatchBrush>, <xref:System.Drawing.TextureBrush>, <xref:System.Drawing.Drawing2D.LinearGradientBrush>, и <xref:System.Drawing.Drawing2D.PathGradientBrush>. Все эти классы наследуют <xref:System.Drawing.Brush> класса. Ниже показан прямоугольник заполняется сплошной кистью и эллипс, заполненный кистей штриховки.  
  
 ![Заполнить фигур](./media/aboutgdip02-art17.gif "Aboutgdip02_art17")  
  
## <a name="solid-brushes"></a>Сплошные кисти  
 Для заполнения замкнутой фигуры, требуется экземпляр <xref:System.Drawing.Graphics> класс и <xref:System.Drawing.Brush>. Экземпляр <xref:System.Drawing.Graphics> класс предоставляет методы, такие как <xref:System.Drawing.Graphics.FillRectangle%2A> и <xref:System.Drawing.Graphics.FillEllipse%2A>и <xref:System.Drawing.Brush> сохраняет атрибуты заливки, таких как цвет и шаблон. <xref:System.Drawing.Brush> Передается в качестве одного из аргументов метода fill. В следующем примере кода показано, как заливка эллипса сплошным красным цветом.  
  
 [!code-csharp[LinesCurvesAndShapes#121](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#121)]
   
  
> [!NOTE]
>  В приведенном выше примере кисть, которая имеет тип <xref:System.Drawing.SolidBrush>, который наследует от <xref:System.Drawing.Brush>.  
  
## <a name="hatch-brushes"></a>Кистей штриховки  
 При заполнении формы штриховой кистью задаются цвет переднего плана, цветом фона и стиль штриховки. Цвет переднего плана — это цвет штриховки.  
  
 [!code-csharp[LinesCurvesAndShapes#122](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#122)]
   
  
 [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] предоставляет более чем 50 стилей штриховки. на следующем рисунке показано три стили представляют собой <xref:System.Drawing.Drawing2D.HatchStyle.Horizontal>, <xref:System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal>, и <xref:System.Drawing.Drawing2D.HatchStyle.Cross>.  
  
 ![Заполнить фигур](./media/aboutgdip02-art18.gif "Aboutgdip02_art18")  
  
## <a name="texture-brushes"></a>Текстурные кисти  
 С помощью кисти текстуры вы можете заполнить фигуры с шаблоном, хранящиеся в точечном рисунке. Предположим, например, приведенный ниже рисунок хранится на диске в файле с именем `MyTexture.bmp`.  
  
 ![Заполнить форму](./media/aboutgdip02-art19.gif "Aboutgdip02_Art19")  
  
 В следующем примере кода показано, как заливка эллипса, повторив рисунка, сохраненного в `MyTexture.bmp`.  
  
 [!code-csharp[LinesCurvesAndShapes#123](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#123)]
   
  
 На следующем рисунке заполненного эллипса.  
  
 ![Заполнить форму](./media/aboutgdip02-art20.gif "AboutGdip02_Art20")  
  
## <a name="gradient-brushes"></a>Градиентные кисти  
 [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] предоставляет два типа градиентных кистей: линейный и путь. Кисти линейного градиента можно использовать для заливки фигуры цвет, который постепенно через фигуры по горизонтали, вертикали или по диагонали. В следующем примере кода показано, как заливка эллипса с горизонтальной градиентную кисть, которая поменяет цвет с синего на зеленый, при переходе от левого края эллипса по правому краю.  
  
 [!code-csharp[LinesCurvesAndShapes#124](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#124)]
   
  
 На следующем рисунке заполненного эллипса.  
  
 ![Заполнить форму](./media/aboutgdip02-art21.gif "AboutGdip02_Art21")  
  
 Чтобы изменить цвет, при перемещении в центре фигуры к границе можно настроить кисти градиента контура.  
  
 ![Заполнить форму](./media/aboutgdip02-art22.gif "AboutGdip02_Art22")  
  
 Градиентные кисти путь отличаются достаточной гибкостью. Кисти градиента, используемый для заполнения в приведенном ниже рисунке последовательно от красного в центре для каждого из трех различных цветов в вершины треугольника.  
  
 ![Заполнить форму](./media/aboutgdip02-art23.gif "AboutGdip02_Art23")  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.SolidBrush?displayProperty=nameWithType>
- <xref:System.Drawing.Drawing2D.HatchBrush?displayProperty=nameWithType>
- <xref:System.Drawing.TextureBrush?displayProperty=nameWithType>
- <xref:System.Drawing.Drawing2D.LinearGradientBrush?displayProperty=nameWithType>
- [Прямые и кривые линии и фигуры](lines-curves-and-shapes.md)
- [Практическое руководство. Рисование заполненного прямоугольника в Windows Forms](how-to-draw-a-filled-rectangle-on-a-windows-form.md)
- [Практическое руководство. Рисование заполненного эллипса в Windows Forms](how-to-draw-a-filled-ellipse-on-a-windows-form.md)

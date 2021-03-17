---
title: B&#233;Безье сплайны в GDI +
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Bezier splines
- splines [Windows Forms], Bezier
- GDI+, Bezier splines
ms.assetid: 5774ce1e-87d4-4bc7-88c4-4862052781b8
ms.openlocfilehash: ff4e9eb18610b70c88e057d3d44020321bbb9f4f
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59107332"
---
# <a name="b233zier-splines-in-gdi"></a>B&#233;Безье сплайны в GDI +
Сплайн Безье — кривой, определяемый четырьмя точками: двумя конечными точками (p1 и p2) и двумя контрольными точками (c1 и c2). Кривая начинается с p1 и заканчивается в точке p2. Кривая проходит через контрольные точки, но контрольные точки действуют как магниты, который извлекает кривой определенные инструкции и влияние на способ изгиба кривой. Ниже показан кривую Безье, а также его конечные точки и точки управления.  
  
 ![Сплайны Безье](./media/aboutgdip02-art11a.gif "Aboutgdip02_art11a")  
  
 Кривая начинается в точке p1 и переходит к контрольной точки c1. Касательной к кривой в p1 — это линия, проведенная через p1 до c1. Касательной в конечной точке p2 — это линия, проведенная через c2 на p2.  
  
## <a name="drawing-bzier-splines"></a>Рисование сплайнов Безье  
 Чтобы нарисовать сплайн Безье, вам потребуется экземпляр <xref:System.Drawing.Graphics> класс и <xref:System.Drawing.Pen>. Экземпляр <xref:System.Drawing.Graphics> класс предоставляет <xref:System.Drawing.Graphics.DrawBezier%2A> метод и <xref:System.Drawing.Pen> сохраняет атрибуты, например, ширина и цвет линии, используемый для отображения кривой. <xref:System.Drawing.Pen> Передается в качестве одного из аргументов для <xref:System.Drawing.Graphics.DrawBezier%2A> метод. Остальные аргументы, передаваемые <xref:System.Drawing.Graphics.DrawBezier%2A> метод: конечные точки и точки управления. В следующем примере рисуется сплайн Безье с начальной точки (0, 0), управлять точками (40, 20) и (80, 150) и конечную точку (100, 10):  
  
 [!code-csharp[LinesCurvesAndShapes#71](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#71)]
 [!code-vb[LinesCurvesAndShapes#71](~/samples/snippets/visualbasic/VS_Snippets_Winforms/LinesCurvesAndShapes/VB/Class1.vb#71)]  
  
 Кривой, контрольные точки и две касательные на следующем рисунке.  
  
 ![Сплайны Безье](./media/aboutgdip02-art12.gif "Aboutgdip02_art12")  
  
 Сплайны Безье изначально были разработаны Пьер Безье для использования в автомобильной промышленности. Они оказались будут полезны во многих типах автоматизированного проектирования и также используются для определения контуры шрифтов. Сплайны Безье можно создавать множество различных фигур, некоторые из которых показаны на следующем рисунке.  
  
 ![Пути](./media/aboutgdip02-art13.gif "Aboutgdip02_art13")  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Graphics?displayProperty=nameWithType>
- <xref:System.Drawing.Pen?displayProperty=nameWithType>
- [Прямые и кривые линии и фигуры](lines-curves-and-shapes.md)
- [Построение и рисование кривых](constructing-and-drawing-curves.md)
- [Практическое руководство. Создание графических объектов для рисования](how-to-create-graphics-objects-for-drawing.md)
- [Практическое руководство. Создание пера](how-to-create-a-pen.md)

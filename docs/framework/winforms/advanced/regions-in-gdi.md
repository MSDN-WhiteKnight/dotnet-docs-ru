---
title: Области в GDI+
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- GDI+, regions
- drawing [Windows Forms], regions
- regions
ms.assetid: 52184f9b-16dd-4bbd-85be-029112644ceb
ms.openlocfilehash: 33d4f4ecca7b9d777fa4eab5b6d031de10f03ccc
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59076033"
---
# <a name="regions-in-gdi"></a>Области в GDI+
Регион – часть области отображения устройства вывода. Регионах может быть простое (один прямоугольник) или сложными (набор многоугольников и замкнутых кривых). На следующем рисунке показано два региона: один создан на основе прямоугольника, а другой создан на основе пути.  
  
 ![Регионы](./media/aboutgdip02-art27.gif "AboutGdip02_Art27")  
  
## <a name="using-regions"></a>Использование областей  
 Области часто используются для обрезки и проверка нажатия. Обрезка заключается ограничение Рисование определенной области отображаемой области, обычно это область, необходимо обновить. Проверка попадания включает в себя проверку, чтобы определить, находится ли курсор в определенной области экрана при нажатии кнопки мыши.  
  
 Можно создать область от прямоугольника или путь. Можно также создавать сложные области путем объединения существующих областей. <xref:System.Drawing.Region> Класс предоставляет следующие методы для объединения областей: <xref:System.Drawing.Region.Intersect%2A>, <xref:System.Drawing.Region.Union%2A>, <xref:System.Drawing.Region.Xor%2A>, <xref:System.Drawing.Region.Exclude%2A>, и <xref:System.Drawing.Region.Complement%2A>.  
  
 Пересечение двух областей — набор всех точек, которые находятся в обоих регионах. Объединение — это набор всех точек, принадлежащих одной или другой или обоих регионах. Дополнение области — это набор всех точек, которые не находятся в регионе. На следующем рисунке пересечение и объединение двух областей, показанный на предыдущем рисунке.  
  
 ![Регионы](./media/aboutgdip02-art28.gif "AboutGdip02_Art28")  
  
 <xref:System.Drawing.Region.Xor%2A> , Примененный к паре регионов, создается область, содержащую все точки, принадлежащие к одной области или другой, но не оба. <xref:System.Drawing.Region.Exclude%2A> Метод, примененный к паре областей, выдает область, содержащую все точки в первом регионе, которые не являются второго региона. На следующем рисунке показан регионов, возникающие в результате применения <xref:System.Drawing.Region.Xor%2A> и <xref:System.Drawing.Region.Exclude%2A> методы в двух регионах, приведенном в начале этого раздела.  
  
 ![Регионы](./media/aboutgdip02-art29.gif "AboutGdip02_Art29")  
  
 Для заполнения области, вам потребуется <xref:System.Drawing.Graphics> объекта, <xref:System.Drawing.Brush> объекта и <xref:System.Drawing.Region> объекта. <xref:System.Drawing.Graphics> Предоставляет <xref:System.Drawing.Graphics.FillRegion%2A> метод и <xref:System.Drawing.Brush> объект сохраняет атрибуты, такие как цвета или узора заливки. Следующий пример заполняет область сплошным цветом.  
  
 [!code-csharp[LinesCurvesAndShapes#61](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#61)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Region?displayProperty=nameWithType>
- [Прямые и кривые линии и фигуры](lines-curves-and-shapes.md)
- [Использование областей](using-regions.md)

---
title: Ограничение поверхности для рисования в GDI+
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- GDI+, clipping
- clipping [Windows Forms], using GDI+
- GDI+, restricting drawing surface
ms.assetid: 8b5f71d9-d2f0-4540-9c41-740f90fd4c26
ms.openlocfilehash: d0508166f905b45789ce638b03d0747dd6fa904e
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59074967"
---
# <a name="restricting-the-drawing-surface-in-gdi"></a>Ограничение поверхности для рисования в GDI+
Обрезка заключается в ограничении Рисование прямоугольника или области. На следующем рисунке строку «Hello», была выполнена Обрезка область в форме сердца.  
  
 ![Ограничение поверхности для рисования](./media/aboutgdip02-art30.gif "AboutGdip02_Art30")  
  
## <a name="clipping-with-regions"></a>Задание области обрезки  
 Регионы могут создаваться из пути и пути могут содержать границы строк, поэтому контурного текста можно использовать для обрезки. Ниже показан набор концентрических эллипсов, была выполнена Обрезка внутреннюю часть текстовой строки.  
  
 ![Ограничение поверхности для рисования](./media/aboutgdip02-art31.gif "AboutGdip02_Art31")  
  
 Для рисования с использованием обрезки, создание <xref:System.Drawing.Graphics> , задать его <xref:System.Drawing.Graphics.Clip%2A> свойство и затем вызвать методы рисования этого же <xref:System.Drawing.Graphics> объекта:  
  
 [!code-csharp[LinesCurvesAndShapes#91](~/samples/snippets/csharp/VS_Snippets_Winforms/LinesCurvesAndShapes/CS/Class1.cs#91)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Graphics?displayProperty=nameWithType>
- <xref:System.Drawing.Region?displayProperty=nameWithType>
- [Прямые и кривые линии и фигуры](lines-curves-and-shapes.md)
- [Использование областей](using-regions.md)

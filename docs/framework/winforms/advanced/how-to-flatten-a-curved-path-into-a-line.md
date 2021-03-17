---
title: Практическое руководство. Спрямление участков кривой
ms.date: 03/30/2017
helpviewer_keywords:
- graphics [Windows Forms], flattening curves into lines
- curves [Windows Forms], flattening
- GraphicsPath object
- paths [Windows Forms], flattening
- drawing [Windows Forms], flattening curves
ms.assetid: e654b8de-25f4-4735-9208-42e4514a589c
ms.openlocfilehash: a151b4244e14d3704fd5fa1c55de92211981232f
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59215161"
---
# <a name="how-to-flatten-a-curved-path-into-a-line"></a>Практическое руководство. Спрямление участков кривой
Объект <xref:System.Drawing.Drawing2D.GraphicsPath> объект хранит последовательность, линий и сплайнов Безье. Различные типы кривых (эллипсы, дуги, фундаментальные сплайны) можно добавить в путь, но каждую кривую преобразуется в кривую Безье, перед его сохранением в пути. Спрямление путь заключается в преобразовании всех сплайнов Безье в пути в последовательность прямых линий. Ниже показан путь до и после выравнивания.  
  
 ![Прямые линии и кривые](./media/aboutgdip02-art32a.gif "AboutGdip02_Art32A")  
  
### <a name="to-flatten-a-path"></a>Спрямление контура  
  
-   Вызовите <xref:System.Drawing.Drawing2D.GraphicsPath.Flatten%2A> метод <xref:System.Drawing.Drawing2D.GraphicsPath> объекта. <xref:System.Drawing.Drawing2D.GraphicsPath.Flatten%2A> Метод получает аргумент спрямления, который указывает максимальное расстояние между уплощенный путь и исходный путь.  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Drawing2D.GraphicsPath?displayProperty=nameWithType>
- [Прямые и кривые линии и фигуры](lines-curves-and-shapes.md)
- [Построение и рисование контуров](constructing-and-drawing-paths.md)

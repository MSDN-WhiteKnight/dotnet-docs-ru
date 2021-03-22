---
title: Практическое руководство. Создание изображений из прямых и кривых линий и геометрических фигур
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- figures [Windows Forms], creating from shapes
- figures [Windows Forms], creating from lines
ms.assetid: 82fd56c7-b443-4765-9b7c-62ce030656ec
ms.openlocfilehash: eeaf478375e08734b20d83b6f3c8030732495013
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59224914"
---
# <a name="how-to-create-figures-from-lines-curves-and-shapes"></a>Практическое руководство. Создание изображений из прямых и кривых линий и геометрических фигур
Чтобы создать изображение, создайте <xref:System.Drawing.Drawing2D.GraphicsPath>, а затем вызывать методы, такие как <xref:System.Drawing.Drawing2D.GraphicsPath.AddLine%2A> и <xref:System.Drawing.Drawing2D.GraphicsPath.AddCurve%2A>, чтобы добавить путь к примитивы.  
  
## <a name="example"></a>Пример  
 В следующих примерах кода создаются путей, содержащих данные:  
  
-   В первом примере создается путь, состоящий из одной фигуры. Рисунок состоит из одного дуги. Дуга имеет угол поворота, равный-180 градусов, который является против часовой стрелки в системе координат по умолчанию.  
  
-   Во втором примере создается путь, состоящий из двух фигур. Первая фигура является дуги, за которым следует строка. Вторая – это линия, за которым следует строка кривую следует. Первая фигура останется открытым, а второй замкнутой.  
  
 [!code-csharp[System.Drawing.ConstructingDrawingPaths#21](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.ConstructingDrawingPaths/CS/Class1.cs#21)]
   
  
 [!code-csharp[System.Drawing.ConstructingDrawingPaths#22](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.ConstructingDrawingPaths/CS/Class1.cs#22)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример предназначен для работы с Windows Forms, и они требуют <xref:System.Windows.Forms.PaintEventArgs> `e`, который является параметром <xref:System.Windows.Forms.Control.Paint> обработчик событий.  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Drawing2D.GraphicsPath>
- [Построение и рисование контуров](constructing-and-drawing-paths.md)
- [Рисование линий и фигур с помощью пера](using-a-pen-to-draw-lines-and-shapes.md)

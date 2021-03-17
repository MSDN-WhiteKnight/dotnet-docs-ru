---
title: Практическое руководство. Задание толщины и выравнивания пера
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- pens [Windows Forms], setting width
- pens [Windows Forms], setting alignment
ms.assetid: a202af36-4d31-4401-a126-b232f51db581
ms.openlocfilehash: bc2ac2587554215ef3b2c2580413fbbb894aa687
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59074980"
---
# <a name="how-to-set-pen-width-and-alignment"></a>Практическое руководство. Задание толщины и выравнивания пера
При создании <xref:System.Drawing.Pen>, указать толщину пера в качестве одного из аргументов конструктора. Можно также изменить ширину пера <xref:System.Drawing.Pen.Width%2A> свойство <xref:System.Drawing.Pen> класса.  
  
 Теоретической линии имеет ширину 0. При рисовании линии, одну точку, пиксели центрируются по теоретической линии. Если нарисовать линию, является более чем одному пикселю, пиксели либо центрируются по теоретической линии появятся или к одной стороне от теоретической линии. Можно задать свойство выравнивания из <xref:System.Drawing.Pen> чтобы определить положение точек, рисуемых при помощи этого пера по отношению к теоретической линии.  
  
 Значения <xref:System.Drawing.Drawing2D.PenAlignment.Center>, <xref:System.Drawing.Drawing2D.PenAlignment.Outset>, и <xref:System.Drawing.Drawing2D.PenAlignment.Inset> , отображаемые в следующих примерах кода являются членами <xref:System.Drawing.Drawing2D.PenAlignment> перечисления.  
  
 В следующем примере кода рисует линию дважды: один раз черным пером толщиной в 1 и один раз с помощью зеленого пера шириной 10.  
  
### <a name="to-vary-the-width-of-a-pen"></a>Для изменения ширины пера  
  
-   Установите для параметра <xref:System.Drawing.Pen.Alignment%2A> свойства <xref:System.Drawing.Drawing2D.PenAlignment.Center> (по умолчанию) будет что рисование зеленым пером пикселей по теоретической линии. Ниже показан итоговый строки.  
  
     ![Черный тонкой линии зеленым цветом.](./media/how-to-set-pen-width-and-alignment/green-pixels-centered-line.gif)  
  
     В следующем примере рисуется прямоугольник дважды: один раз черным пером толщиной в 1 и один раз с помощью зеленого пера шириной 10.  
  
     [!code-csharp[System.Drawing.UsingAPen#41](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.UsingAPen/CS/Class1.cs#41)]
     [!code-vb[System.Drawing.UsingAPen#41](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.UsingAPen/VB/Class1.vb#41)]  
  
### <a name="to-change-the-alignment-of-a-pen"></a>Изменение выравнивания пера  
  
-   Установите для параметра <xref:System.Drawing.Pen.Alignment%2A> свойства <xref:System.Drawing.Drawing2D.PenAlignment.Center> будет что рисование зеленым пером пикселей по границ прямоугольника.  
  
     На следующем рисунке показан полученный прямоугольник.
  
     ![Прямоугольник, нарисованных при помощи черный тонких линий, выделенная зеленым цветом.](./media/how-to-set-pen-width-and-alignment/green-pixels-centered-rectangle.gif)  
  
     [!code-csharp[System.Drawing.UsingAPen#42](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.UsingAPen/CS/Class1.cs#42)]
     [!code-vb[System.Drawing.UsingAPen#42](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.UsingAPen/VB/Class1.vb#42)]  
  
### <a name="to-create-an-inset-pen"></a>Для создания вложенного пера  
  
-   Измените выравнивание зеленого пера, изменив третья инструкция в предыдущем примере кода следующим образом:  
  
     [!code-csharp[System.Drawing.UsingAPen#43](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.UsingAPen/CS/Class1.cs#43)]
     [!code-vb[System.Drawing.UsingAPen#43](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.UsingAPen/VB/Class1.vb#43)]  
  
     Теперь пикселов в ширину зеленая линия отображаются внутри прямоугольника, как показано на следующем рисунке:
  
     ![Прямоугольник, нарисованных при помощи черных линий, связывающих жирной зеленой линией внутри.](./media/how-to-set-pen-width-and-alignment/green-pixels-inside-rectangle.gif)  
  
## <a name="see-also"></a>См. также

- [Рисование линий и фигур с помощью пера](using-a-pen-to-draw-lines-and-shapes.md)
- [Объекты Graphics и Drawing в Windows Forms](graphics-and-drawing-in-windows-forms.md)

---
title: Практическое руководство. Мозаичное заполнение фигуры заданным изображением
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- texture brushes [Windows Forms], tiling images with
- images [Windows Forms], filling shapes with
- shapes [Windows Forms], tiling with images
- bitmaps [Windows Forms], filling shapes with
ms.assetid: 6d407891-6e5c-4495-a546-3da5604e9fb8
ms.openlocfilehash: ad7b8737a63028e533cadfa6db56b063eb943f22
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59221542"
---
# <a name="how-to-tile-a-shape-with-an-image"></a>Практическое руководство. Мозаичное заполнение фигуры заданным изображением
Так же, как плиток можно поместить рядом друг с другом пола, прямоугольные изображения можно поместить рядом друг с другом заполнить фигуру. Для мозаичного внутренней части фигуры, используйте кисть текстуры. При построении <xref:System.Drawing.TextureBrush> объекта, один из аргументов, передать конструктору <xref:System.Drawing.Image> объекта. При использовании текстуры кисть для закрашивания внутренней части фигуры, фигура заполняется повторяющиеся копии этого образа.  
  
 Свойство mode wrap <xref:System.Drawing.TextureBrush> определяет способ ориентации изображения при его повторяется в пределах прямоугольной сетки. Можно выполнить всего плитки отображаются в сетке же ориентацию или внесения зеркальное отображение изображения от позиции одной сетки к другому. Зеркальное отображение может быть горизонтальным, vertical или both. В следующих примерах демонстрируется мозаики с использованием различных типов зеркального отображения.  
  
### <a name="to-tile-an-image"></a>Мозаичное заполнение изображением  
  
-   В этом примере используется на следующем рисунке 75 × 75 для мозаичного заполнения прямоугольника размером 200 × 200.  
  
 ![Плитка 1](./media/tile1.gif "tile1")  
  
-   Ниже показано, как выполняется мозаичное заполнение прямоугольника с изображением. Обратите внимание, что все плитки же ориентацию; нет в зеркального отражения.  
  
 ![Плитки 2](./media/tile2.gif "tile2")  
  
 [!code-csharp[System.Drawing.UsingABrush#31](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.UsingABrush/CS/Class1.cs#31)]
 [!code-vb[System.Drawing.UsingABrush#31](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.UsingABrush/VB/Class1.vb#31)]  
  
### <a name="to-flip-an-image-horizontally-while-tiling"></a>Изображения по горизонтали мозаичное  
  
-   В этом примере используется одно изображение размером 75 × 75 для заполнения прямоугольника размером 200 × 200. Режим переноса присваивается переворачивание изображения по горизонтали. Ниже показано, как выполняется мозаичное заполнение прямоугольника с изображением. Обратите внимание на то, что при переходе от одного элемента к другому в данной строке, является перевернуть изображение по горизонтали.  
  
 ![Плитку 3](./media/tile3.gif "tile3")  
  
 [!code-csharp[System.Drawing.UsingABrush#32](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.UsingABrush/CS/Class1.cs#32)]
 [!code-vb[System.Drawing.UsingABrush#32](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.UsingABrush/VB/Class1.vb#32)]  
  
### <a name="to-flip-an-image-vertically-while-tiling"></a>Изображения по вертикали мозаичное  
  
-   В этом примере используется одно изображение размером 75 × 75 для заполнения прямоугольника размером 200 × 200. Режим переноса присваивается переворачивание изображения по вертикали.  
  
     [!code-csharp[System.Drawing.UsingABrush#33](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.UsingABrush/CS/Class1.cs#33)]
     [!code-vb[System.Drawing.UsingABrush#33](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.UsingABrush/VB/Class1.vb#33)]  
  
### <a name="to-flip-an-image-horizontally-and-vertically-while-tiling"></a>Отражение изображения по горизонтали и вертикали мозаичное  
  
-   В этом примере используется одно изображение размером 75 × 75 для мозаичного заполнения прямоугольника размером 200 × 200. Режим переноса присваивается переворачивание изображения по горизонтали и вертикали. Ниже показано, как выполняется мозаичное заполнение прямоугольник в изображении. Обратите внимание, что при переходе от одного элемента к другому в данной строке, является перевернуть изображение по горизонтали, а при переходе от элемента к другому в указанном столбце, изображение отражаются по вертикали.  
  
 ![Плитку 5](./media/tile5.gif "tile5")  
  
 [!code-csharp[System.Drawing.UsingABrush#34](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.UsingABrush/CS/Class1.cs#34)]
 [!code-vb[System.Drawing.UsingABrush#34](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.UsingABrush/VB/Class1.vb#34)]  
  
## <a name="see-also"></a>См. также

- [Использование кисти для заливки фигур](using-a-brush-to-fill-shapes.md)

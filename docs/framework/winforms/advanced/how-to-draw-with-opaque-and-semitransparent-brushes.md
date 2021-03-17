---
title: Практическое руководство. Рисование непрозрачными и полупрозрачными кистями
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- semi-transparent shapes [Windows Forms], drawing
- transparency [Windows Forms], semi-transparent shapes
- alpha blending [Windows Forms], brush
- brushes [Windows Forms], using semi-transparent
ms.assetid: a4f6f6b8-3bc8-440a-84af-d62ef0f8ff40
ms.openlocfilehash: a302b8bf978afcead5768fadeb6336c1ece986ec
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59100936"
---
# <a name="how-to-draw-with-opaque-and-semitransparent-brushes"></a>Практическое руководство. Рисование непрозрачными и полупрозрачными кистями
При заливке формы необходимо передать объект <xref:System.Drawing.Brush> одному из методов заливки класса <xref:System.Drawing.Graphics>. Единственным параметром конструктора <xref:System.Drawing.SolidBrush.%23ctor%2A> является объект <xref:System.Drawing.Color>. Чтобы залить непрозрачную фигуру, следует установить значение альфа-компонента цвета в 255. Чтобы залить полупрозрачную фигуру, установите значение альфа-компонента в интервале от 1 до 254.  
  
 При заполнении полупрозрачной фигуры цвет фигуры смешивается с цветами фона. Альфа-компонент определяет степень смешивания цветов фигуры и фона. При значениях альфа, близких к 0, цвет фона имеет больший приоритет, при значениях альфа, близких к 255, больший приоритет имеет цвет фигуры.  
  
## <a name="example"></a>Пример  
 В следующем примере рисуется растровое изображение, а затем осуществляется заливка трех эллипсов, перекрывающих растровое изображение. Для первого эллипса используется значение альфа-компонента, равное 255, поэтому он непрозрачен. Для второго и третьего эллипсов используется значение альфа-компонента, равное 128, поэтому они полупрозрачные и сквозь эллипсы видно фоновое изображение. Вызов, который устанавливает свойство <xref:System.Drawing.Graphics.CompositingQuality%2A>, вынуждает выполнить наложение для третьего эллипса совместно с гамма-коррекцией.  

 [!code-csharp[System.Drawing.AlphaBlending#31](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.AlphaBlending/CS/Class1.cs#31)]
 [!code-vb[System.Drawing.AlphaBlending#31](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.AlphaBlending/VB/Class1.vb#31)]  

 На следующем рисунке показан вывода следующего кода: 
  
 ![Рисунок, показывающий непрозрачных и полупрозрачных выходных данных.](./media/how-to-draw-with-opaque-and-semitransparent-brushes/compositingquality-ellipse-semitransparent.png)  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs>`e`, который является параметром <xref:System.Windows.Forms.PaintEventHandler>.  
  
## <a name="see-also"></a>См. также

- [Объекты Graphics и Drawing в Windows Forms](graphics-and-drawing-in-windows-forms.md)
- [Альфа-смешение цвета для линий и заливок](alpha-blending-lines-and-fills.md)
- [Практическое руководство. Установка степени прозрачности фона элемента управления](../controls/how-to-give-your-control-a-transparent-background.md)
- [Практическое руководство. Рисование непрозрачных и полупрозрачных линий](how-to-draw-opaque-and-semitransparent-lines.md)

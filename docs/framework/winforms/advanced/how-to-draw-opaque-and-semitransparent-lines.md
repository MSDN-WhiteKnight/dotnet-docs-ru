---
title: Практическое руководство. Рисование непрозрачных и полупрозрачных линий
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- drawing [Windows Forms], lines
- transparency [Windows Forms], lines
- lines [Windows Forms], drawing alpha blended
- alpha blending [Windows Forms], drawing lines
ms.assetid: 8f2508af-f495-4223-b5cc-646cbbb520eb
ms.openlocfilehash: 7408722dc13e83828cfca3f0615a2730e3c53461
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59188270"
---
# <a name="how-to-draw-opaque-and-semitransparent-lines"></a>Практическое руководство. Рисование непрозрачных и полупрозрачных линий
При рисовании линии необходимо передать методу <xref:System.Drawing.Graphics.DrawLine%2A> класса <xref:System.Drawing.Graphics> объект <xref:System.Drawing.Pen>. Одним из параметров конструктора <xref:System.Drawing.Pen.%23ctor%2A> является объект <xref:System.Drawing.Color>. Чтобы нарисовать непрозрачную линию, установите альфа-компонент цвета равным 255. Чтобы нарисовать полупрозрачную линию, установите значение альфа-компонента в диапазоне от 1 до 254.  
  
 При рисовании полупрозрачной линии на некотором фоне цвет линии смешивается с цветами фона. Альфа-компонент определяет результат смешивания цветов линии и фона. При близких к нулю значениях альфа цвета фона выделяются в большей степени, а при значениях альфа, близких к 255, в большей степени выделяется цвет линии.  
  
## <a name="example"></a>Пример  
 В примере ниже рисуется растровое изображение, а затем рисуются три линии, использующие растровое изображение в качестве фона. Цвет первой линии имеет альфа-компонент, равный 255, поэтому она является непрозрачной. Для второй и третьей линий используется альфа-компонент, равный 128, поэтому они являются полупрозрачными и сквозь них можно видеть фоновое изображение. Оператор, устанавливающий значение свойства <xref:System.Drawing.Graphics.CompositingQuality%2A>, указывает, что смешивание цветов для третьей линии должно совмещаться с гамма-коррекцией.  
  
 [!code-csharp[System.Drawing.AlphaBlending#11](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.AlphaBlending/CS/Class1.cs#11)]
 [!code-vb[System.Drawing.AlphaBlending#11](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.AlphaBlending/VB/Class1.vb#11)]  
  
 На следующем рисунке показан вывода следующего кода:  
  
 ![Рисунок, показывающий непрозрачных и полупрозрачных выходных данных](./media/how-to-draw-opaque-and-semitransparent-lines/opaque-semitransparent-lines.png)  

## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs>`e`, который является параметром <xref:System.Windows.Forms.Control.Paint> обработчик событий.  
  
## <a name="see-also"></a>См. также

- [Альфа-смешение цвета для линий и заливок](alpha-blending-lines-and-fills.md)
- [Практическое руководство. Установка степени прозрачности фона элемента управления](../controls/how-to-give-your-control-a-transparent-background.md)
- [Практическое руководство. Рисование непрозрачными и полупрозрачными кистями](how-to-draw-with-opaque-and-semitransparent-brushes.md)

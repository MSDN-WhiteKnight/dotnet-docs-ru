---
title: Практическое руководство. Использование матрицы цветов для задания значений прозрачности в изображениях
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- images [Windows Forms], using color matrices for semi-transparent
- transparency [Windows Forms], color matrices
- matrices [Windows Forms], alpha values
- bitmaps [Windows Forms], using color matrices for semi-transparent
ms.assetid: a27121e6-f7e9-4c09-84e2-f05aa9d2a1bb
ms.openlocfilehash: 79937f0801a790d4ff1ab327aaaf45ef1b881827
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59199548"
---
# <a name="how-to-use-a-color-matrix-to-set-alpha-values-in-images"></a>Практическое руководство. Использование матрицы цветов для задания значений прозрачности в изображениях
<xref:System.Drawing.Bitmap> Класс (который наследуется от <xref:System.Drawing.Image> класс) и <xref:System.Drawing.Imaging.ImageAttributes> предоставляют функциональные возможности для получения и установки значения в пикселях. Можно использовать <xref:System.Drawing.Imaging.ImageAttributes> значений для изменения альфа-канал для всего изображения, или можно вызвать <xref:System.Drawing.Bitmap.SetPixel%2A> метод <xref:System.Drawing.Bitmap> класса для изменения значений отдельных пикселей.  
  
## <a name="example"></a>Пример  
 <xref:System.Drawing.Imaging.ImageAttributes> Класс имеет множество свойств, которые можно использовать для изменения образов во время отрисовки. В следующем примере <xref:System.Drawing.Imaging.ImageAttributes> объект используется для задания альфа-значения до 80 процентов от они были. Это делается путем инициализации матрицы цветов и альфа-канал, значение в матрице 0,8 масштабирования. Передается адрес цветовой матрице <xref:System.Drawing.Imaging.ImageAttributes.SetColorMatrix%2A> метод <xref:System.Drawing.Imaging.ImageAttributes> объекта и <xref:System.Drawing.Imaging.ImageAttributes> объект передается <xref:System.Drawing.Graphics.DrawString%2A> метод <xref:System.Drawing.Graphics> объекта.  
  
 Во время отрисовки, до 80 процентов от их первоначальных преобразуются альфа-значения в точечном рисунке. Результатом в образ, который смешивается с фоном. Как показано на следующем рисунке, растровое изображение выглядит прозрачным; Появится сплошная черная линия через него.  
  
 ![Альфа-смешение цвета с помощью матрицы](./media/image2.png "изображение2")  
  
 Когда изображение на белой части в фоновом режиме, оно смешивается с белым цветом. Пересечения черная линия, изображение изображения смешивается с черным цветом.  
  
 [!code-csharp[System.Drawing.AlphaBlending#21](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.AlphaBlending/CS/Class1.cs#21)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs>`e`, который является параметром <xref:System.Windows.Forms.PaintEventHandler>.  
  
## <a name="see-also"></a>См. также

- [Объекты Graphics и Drawing в Windows Forms](graphics-and-drawing-in-windows-forms.md)
- [Альфа-смешение цвета для линий и заливок](alpha-blending-lines-and-fills.md)

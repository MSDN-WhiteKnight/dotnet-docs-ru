---
title: Практическое руководство. Заливка фигуры текстурой, созданной на основе изображения
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- images [Windows Forms], using with brushes
- bitmaps [Windows Forms], using texture
- shapes [Windows Forms], filling with images
ms.assetid: 508da5a6-2433-4d2b-9680-eaeae4e96e3b
ms.openlocfilehash: 099bc9f5359f19439f308f28a6766d470956daea
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59177324"
---
# <a name="how-to-fill-a-shape-with-an-image-texture"></a>Практическое руководство. Заливка фигуры текстурой, созданной на основе изображения
Можно заполнить замкнутой фигуры текстурой, созданной с помощью <xref:System.Drawing.Image> класс и <xref:System.Drawing.TextureBrush> класса.  
  
## <a name="example"></a>Пример  
 В следующем примере заполняется эллипс с изображением. Код создает <xref:System.Drawing.Image> объекта, а затем передает адрес объекта <xref:System.Drawing.Image> объект в качестве аргумента для <xref:System.Drawing.TextureBrush.%23ctor%2A> конструктор. Третья инструкция изменяет масштаб изображения, а четвертый оператор выполняет заливку эллипса повторяющиеся копии масштабированное изображение.  
  
 В следующем коде <xref:System.Drawing.TextureBrush.Transform%2A> свойство содержит преобразование, которое применяется к изображению перед его рисованием. Предположим, что исходное изображение имеет 640 пикселей в ширину и высоту 480 пикселей. Преобразование сжимает изображение до 75 × 75, задав значения масштабирования по горизонтали и вертикали.  
  
> [!NOTE]
>  В следующем примере размер изображения равно 75 × 75 и размер эллипса — 150 × 250. Так как изображение меньше заполняемой эллипса, эллипса выполняется мозаичное заполнение с использованием образа. Достигнут мозаичное заполнение означает, что изображение повторяется горизонтально и вертикально до границы фигуры. Дополнительные сведения о мозаичного заполнения, см. в разделе [как: Мозаичное заполнение фигуры заданным изображением](how-to-tile-a-shape-with-an-image.md).  
  
 [!code-csharp[System.Drawing.UsingABrush#21](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.UsingABrush/CS/Class1.cs#21)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs> `e`, который является параметром <xref:System.Windows.Forms.Control.Paint> обработчик событий.  
  
## <a name="see-also"></a>См. также

- [Использование кисти для заливки фигур](using-a-brush-to-fill-shapes.md)

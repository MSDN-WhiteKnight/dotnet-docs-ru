---
title: Практическое руководство. Рисование существующего точечного рисунка на экране
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- bitmaps [Windows Forms], displaying in Windows Forms
- bitmaps [Windows Forms], loading in Windows Forms applications
- images [Windows Forms], displaying on Windows Forms
ms.assetid: 5bc558d7-b326-4050-a834-b8600da0de95
ms.openlocfilehash: 90511adf9caffe7952e270d6fe32dd85162a29d7
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59089183"
---
# <a name="how-to-draw-an-existing-bitmap-to-the-screen"></a>Практическое руководство. Рисование существующего точечного рисунка на экране
Существующий образ рисования на экране. Сначала необходимо создать <xref:System.Drawing.Bitmap> , используя конструктор точечного рисунка, который принимает имя файла, <xref:System.Drawing.Bitmap.%23ctor%28System.String%29>. Этот конструктор поддерживает изображения с нескольких форматов, включая BMP, GIF, JPEG, PNG и TIFF. После создания <xref:System.Drawing.Bitmap> , передать, <xref:System.Drawing.Bitmap> объект <xref:System.Drawing.Graphics.DrawImage%2A> метод <xref:System.Drawing.Graphics> объекта.  
  
## <a name="example"></a>Пример  
 В этом примере создается <xref:System.Drawing.Bitmap> объект из файла в формате JPEG и затем рисует растровое изображение с его верхнего левого угла в (60, 10).  
  
 На следующем рисунке показан точечный рисунок рисуется в указанном расположении:  
  
 ![Снимок экрана, показывающий изображение в указанной позиции.](./media/how-to-draw-an-existing-bitmap-to-the-screen/bitmap-specified-position.png)  
  
 [!code-csharp[System.Drawing.WorkingWithImages#21](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.WorkingWithImages/CS/Class1.cs#21)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs> `e`, который является параметром <xref:System.Windows.Forms.Control.Paint> обработчик событий.  
  
## <a name="see-also"></a>См. также

- [Объекты Graphics и Drawing в Windows Forms](graphics-and-drawing-in-windows-forms.md)
- [Работа с растровыми и векторными изображениями](working-with-images-bitmaps-icons-and-metafiles.md)

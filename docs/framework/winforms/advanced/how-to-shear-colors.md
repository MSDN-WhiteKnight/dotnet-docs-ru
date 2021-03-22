---
title: Практическое руководство. Сдвиг цветов
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- colors [Windows Forms], transforming with color matrices
- colors [Windows Forms], shearing
ms.assetid: 0a424171-5b8b-45c4-afef-e9720a6c3e22
ms.openlocfilehash: bf645cf88c4905cd5cf47c2a6c7af088fa428c8a
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59076254"
---
# <a name="how-to-shear-colors"></a>Практическое руководство. Сдвиг цветов
Пропорциональное изменение увеличивает или уменьшает компонент цвета, обратно пропорционально значению другого компонента цвета. Например рассмотрим преобразования, где красный компонент увеличивается на половину значения синего компонента. При таком преобразовании цвет (0,2, 0,5, 1) станет (0,7, 0,5, 1). Новое значение красного компонента — 0,2 + (1/2)(1) = 0,7.  
  
## <a name="example"></a>Пример  
 В следующем примере создается <xref:System.Drawing.Image> объекта из файла ColorBars4.bmp. Затем код применяет наклон преобразование, описанное в предыдущем абзаце для каждого пикселя в изображении.  
  
 Ниже показан исходное изображение в левой части и преобразованное изображение справа: 
  
 ![Две клетки с цветной полосы side-by-side иллюстрирующая исходного изображения, а преобразованное изображение.](./media/how-to-shear-colors/original-image-sheared-image.png)  
  
 Ниже перечислены эти векторы четырех полос до и после преобразования.  
  
|До преобразования|Обрезается|  
|--------------|-------------|  
|(0, 0, 1, 1)|(0.5, 0, 1, 1)|  
|(0.5, 1, 0.5, 1)|(0.75, 1, 0.5, 1)|  
|(1, 1, 0, 1)|(1, 1, 0, 1)|  
|(0.4, 0.4, 0.4, 1)|(0.6, 0.4, 0.4, 1)|  
  
 [!code-csharp[System.Drawing.Misc3#9](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.Misc3/CS/Form1.cs#9)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs>`e`, который является параметром <xref:System.Windows.Forms.Control.Paint> обработчик событий. Замените `ColorBars.bmp` в вашей системе путь и имя образа.  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Imaging.ColorMatrix>
- <xref:System.Drawing.Imaging.ImageAttributes>
- [Объекты Graphics и Drawing в Windows Forms](graphics-and-drawing-in-windows-forms.md)
- [Перекрашивание изображений](recoloring-images.md)

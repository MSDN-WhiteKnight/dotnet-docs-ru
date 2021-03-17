---
title: Практическое руководство. Загрузка и отображение метафайлов
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- examples [Windows Forms], metafiles
- metafiles [Windows Forms], displaying
ms.assetid: 60af1714-f148-4d85-a739-0557965ffa73
ms.openlocfilehash: 39b7251b2789c7410e1d59b4aa7990a2f73055fe
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59229359"
---
# <a name="how-to-load-and-display-metafiles"></a>Практическое руководство. Загрузка и отображение метафайлов
<xref:System.Drawing.Imaging.Metafile> Класс, унаследованный от <xref:System.Drawing.Image> класса, предоставляет методы для записи, отображения и анализа векторных изображений.  
  
## <a name="example"></a>Пример  
 Чтобы отобразить векторного изображения (метафайла) на экране, вам потребуется <xref:System.Drawing.Imaging.Metafile> объекта и <xref:System.Drawing.Graphics> объекта. Передать имя файла (или потока) <xref:System.Drawing.Imaging.Metafile> конструктор. После создания <xref:System.Drawing.Imaging.Metafile> , передать, <xref:System.Drawing.Imaging.Metafile> объект <xref:System.Drawing.Graphics.DrawImage%2A> метод <xref:System.Drawing.Graphics> объекта.  
  
 В примере создается <xref:System.Drawing.Imaging.Metafile> объект из файла EMF (расширенный метафайл) и затем рисует изображение с его верхнего левого угла в (60, 10).  
  
 Ниже показан метафайла, содержащейся в указанном расположении.  
  
 ![Положение изображения](./media/imageposition2.png "imageposition2")  
  
 [!code-csharp[System.Drawing.WorkingWithImages#41](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.WorkingWithImages/CS/Class1.cs#41)]
 [!code-vb[System.Drawing.WorkingWithImages#41](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.WorkingWithImages/VB/Class1.vb#41)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs> `e`, который является параметром <xref:System.Windows.Forms.Control.Paint> обработчик событий.  
  
## <a name="see-also"></a>См. также

- [Работа с растровыми и векторными изображениями](working-with-images-bitmaps-icons-and-metafiles.md)

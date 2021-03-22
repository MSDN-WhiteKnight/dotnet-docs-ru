---
title: Практическое руководство. Использование режима интерполяции для управления качеством изображений при масштабировании
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- interpolation mode [Windows Forms], controlling image quality
- images [Windows Forms], scaling
- images [Windows Forms], controlling quality
ms.assetid: fde9bccf-8aa5-4b0d-ba4b-788740627b02
ms.openlocfilehash: 75f5077c2d969f026a28834144c219f289843dd6
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59080986"
---
# <a name="how-to-use-interpolation-mode-to-control-image-quality-during-scaling"></a>Практическое руководство. Использование режима интерполяции для управления качеством изображений при масштабировании
Режим интерполяции <xref:System.Drawing.Graphics> влияет на способ [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] масштабирует (растягивает и сжимает) изображения. <xref:System.Drawing.Drawing2D.InterpolationMode> Перечисление определяет различные режимы интерполяции, некоторые из которых приведены в следующем списке:  
  
-   <xref:System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor>  
  
-   <xref:System.Drawing.Drawing2D.InterpolationMode.Bilinear>  
  
-   <xref:System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear>  
  
-   <xref:System.Drawing.Drawing2D.InterpolationMode.Bicubic>  
  
-   <xref:System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic>  
  
 Чтобы растянуть изображение, каждый пиксель исходного изображения должен быть сопоставлен группе точек увеличенного изображения. Чтобы сжать изображение, группы точек исходного изображения должны сопоставляться отдельным точкам уменьшенного изображения. Эффективность алгоритмов, которые выполняют эти сопоставления определяет качество масштабированное изображение. Алгоритмы, создающие масштабированные изображения более высокого качества, как правило, требуют большего времени обработки. В приведенном выше списке <xref:System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor> режим низкое качество и <xref:System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic> режим высочайшего качества.  
  
 Чтобы задать режим интерполяции, назначить один из членов <xref:System.Drawing.Drawing2D.InterpolationMode> перечисления <xref:System.Drawing.Graphics.InterpolationMode%2A> свойство <xref:System.Drawing.Graphics> объекта.  
  
## <a name="example"></a>Пример  
 В следующем примере изображение рисуется и затем сжимается с использованием трех различных способов интерполяции.  
  
 Ниже показан исходный образ и три меньшего размера изображения.  
  
 ![Снимок экрана, показывающий изображение с отличными параметрами вставки.](./media/how-to-use-interpolation-mode-to-control-image-quality-during-scaling/varied-interpolation-settings.png)  
  
 [!code-csharp[System.Drawing.WorkingWithImages#81](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.WorkingWithImages/CS/Class1.cs#81)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs> `e`, который является параметром <xref:System.Windows.Forms.Control.Paint> обработчик событий.  
  
## <a name="see-also"></a>См. также

- [Работа с растровыми и векторными изображениями с использованием классов Image, Bitmap и Metafile](images-bitmaps-and-metafiles.md)
- [Работа с растровыми и векторными изображениями](working-with-images-bitmaps-icons-and-metafiles.md)

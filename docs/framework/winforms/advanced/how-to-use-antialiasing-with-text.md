---
title: Практическое руководство. Сглаживание текста
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- strings [Windows Forms], smoothing drawn
- antialiasing [Windows Forms], using with text
- text [Windows Forms], smoothing
- text [Windows Forms], antialiasing
- strings [Windows Forms], antialiasing when drawing
ms.assetid: 48fc34f3-f236-4b01-a0cb-f0752e6d22ae
ms.openlocfilehash: 24d1b1dfbe955bcfa98a16c3be592ab837ec0182
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59227617"
---
# <a name="how-to-use-antialiasing-with-text"></a>Практическое руководство. Сглаживание текста
*Сглаживание* ссылается на сглаживания неровные края графических элементов и текста для улучшения их внешнего вида и удобства чтения. Управляемые [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] классы, можно отображать текст со сглаживанием высокого качества, а также текст низкого качества. Как правило более качественная визуализация занимает больше времени обработки, чем менее качественная. Чтобы задать уровень качества текста, задайте <xref:System.Drawing.Graphics.TextRenderingHint%2A> свойство <xref:System.Drawing.Graphics> к одному из элементов <xref:System.Drawing.Text.TextRenderingHint> перечисления  
  
## <a name="example"></a>Пример  
 В следующем примере кода выводит текст с двумя различными уровнями качества.  
  
 [!code-csharp[System.Drawing.FontsAndText#21](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.FontsAndText/CS/Class1.cs#21)]
 [!code-vb[System.Drawing.FontsAndText#21](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.FontsAndText/VB/Class1.vb#21)]  
 
 На следующем рисунке показан результат выполнения примера кода:  
  
 ![Снимок экрана: текст с двумя различными уровнями качества.](./media/how-to-use-antialiasing-with-text/antialiasing-text-quality-settings.png)  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример кода предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs> `e`, который является параметром <xref:System.Windows.Forms.PaintEventHandler>.  
  
## <a name="see-also"></a>См. также

- [Шрифты и текст](using-fonts-and-text.md)

---
title: Практическое руководство. Вывод текста по вертикали
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- text [Windows Forms], drawing vertical
- Windows Forms, drawing vertical text
- strings [Windows Forms], drawing vertical
- vertical text [Windows Forms], drawing
ms.assetid: 50c69046-4188-47d9-b949-cc2610ffd337
ms.openlocfilehash: 75f5d8faa4dc4b7e022cd6de2e6db49f4fa9030c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59190227"
---
# <a name="how-to-create-vertical-text"></a>Практическое руководство. Вывод текста по вертикали
Можно использовать <xref:System.Drawing.StringFormat> для указания, что текст должен выводиться по вертикали, а не по горизонтали.  
  
## <a name="example"></a>Пример  
 В следующем примере присваивается значение <xref:System.Drawing.StringFormatFlags.DirectionVertical> для <xref:System.Drawing.StringFormat.FormatFlags%2A> свойство <xref:System.Drawing.StringFormat> объекта. Что <xref:System.Drawing.StringFormat> объект передается <xref:System.Drawing.Graphics.DrawString%2A> метод <xref:System.Drawing.Graphics> класса. Значение <xref:System.Drawing.StringFormatFlags.DirectionVertical> является членом <xref:System.Drawing.StringFormatFlags> перечисления.  
  
 На следующем рисунке показано текста по вертикали: 
  
 ![Рисунок, показывающий вертикального шрифта текста.](./media/how-to-create-vertical-text/vertical-font-text-graphic.png)  
  
 [!code-csharp[System.Drawing.FontsAndText#31](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.FontsAndText/CS/Class1.cs#31)]
 [!code-vb[System.Drawing.FontsAndText#31](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.FontsAndText/VB/Class1.vb#31)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
  
-   Предыдущий пример предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs>`e` , который является параметром <xref:System.Windows.Forms.PaintEventHandler>.  
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Рисование текста с использованием GDI](how-to-draw-text-with-gdi.md)

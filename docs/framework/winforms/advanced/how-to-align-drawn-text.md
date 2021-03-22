---
title: Практическое руководство. Выравнивание рисуемого текста
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- text [Windows Forms], aligning
- Windows Forms, aligning drawn text
ms.assetid: 83c10a81-1a90-4b5c-98aa-2c6c4b280079
ms.openlocfilehash: 0e77e4d8eeb9d7a07115b89525ac80074afeb6e8
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59323275"
---
# <a name="how-to-align-drawn-text"></a>Практическое руководство. Выравнивание рисуемого текста
При выполнении пользовательского рисования, часто можно формируемого выравнивание текста по центру формы или элемента управления. Выровнять текст, отображаемый с <xref:System.Drawing.Graphics.DrawString%2A> или <xref:System.Windows.Forms.TextRenderer.DrawText%2A> методы создания нужный объект форматирования и установив соответствующие параметры форматирования.  
  
### <a name="to-draw-centered-text-with-gdi-drawstring"></a>Для рисования по центру текста с помощью GDI + (DrawString)  
  
1. Используйте <xref:System.Drawing.StringFormat> с соответствующим <xref:System.Drawing.Graphics.DrawString%2A> метод, чтобы задать текст, выровненный по центру.  
  
     [!code-csharp[System.Drawing.AlignDrawnText#10](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.AlignDrawnText/CS/Form1.cs#10)]
       
  
### <a name="to-draw-centered-text-with-gdi-drawtext"></a>Для рисования по центру текста с использованием GDI (DrawText)  
  
1. Используйте <xref:System.Windows.Forms.TextFormatFlags> перечисления для упаковки, а также по вертикали и горизонтали Центрирование текста с соответствующим <xref:System.Windows.Forms.TextRenderer.DrawText%2A> метод.  
  
     [!code-csharp[System.Drawing.AlignDrawnText#20](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.AlignDrawnText/CS/Form1.cs#20)]
       
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример кода предназначен для работы с Windows Forms, и они требуют <xref:System.Windows.Forms.PaintEventArgs>`e`, который является параметром <xref:System.Windows.Forms.PaintEventHandler>.  
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Рисование текста с использованием GDI](how-to-draw-text-with-gdi.md)
- [Шрифты и текст](using-fonts-and-text.md)
- [Практическое руководство. Разработка шрифтов и их семейств](how-to-construct-font-families-and-fonts.md)

---
title: Практическое руководство. Рисование текста с использованием GDI
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- GDI [Windows Forms], drawing text [Windows Forms]
- text [Windows Forms], drawing with TextRenderer
- drawing [Windows Forms], text
- Windows Forms, drawing text with GDI
ms.assetid: 2a19fe5d-2ace-451c-94db-01cb1118ef7b
ms.openlocfilehash: d4bf72998c798040451b814a7f0287bca65f5300
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59073329"
---
# <a name="how-to-draw-text-with-gdi"></a>Практическое руководство. Рисование текста с использованием GDI
С помощью <xref:System.Windows.Forms.TextRenderer.DrawText%2A> метод в <xref:System.Windows.Forms.TextRenderer> класс, вы может обращаться к [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)] функциональные возможности для рисования текста в форме или элементе управления. [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)] отрисовка текста обычно обеспечивает более высокую производительность и более точно текста, чем измерение [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)].  
  
> [!NOTE]
>  <xref:System.Windows.Forms.TextRenderer.DrawText%2A> Методы <xref:System.Windows.Forms.TextRenderer> класса не поддерживаются для печати. При печати, всегда используйте <xref:System.Drawing.Graphics.DrawString%2A> методы <xref:System.Drawing.Graphics> класса.  
  
## <a name="example"></a>Пример  
 В следующем примере кода показано, как отображается текст на нескольких строках внутри прямоугольника с помощью <xref:System.Windows.Forms.TextRenderer.DrawText%2A> метод.  
  
 [!code-csharp[System.Windows.Forms.TextRendererExamples#7](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.TextRendererExamples/CS/Form1.cs#7)]
   
  
 Для вывода текста с <xref:System.Windows.Forms.TextRenderer> класса, вам потребуется <xref:System.Drawing.IDeviceContext>, такие как <xref:System.Drawing.Graphics> и <xref:System.Drawing.Font>, расположение для рисования текста и цвет, в котором оно должно отображаться. При необходимости можно указать с помощью форматирования текста <xref:System.Windows.Forms.TextFormatFlags> перечисления.  
  
 Дополнительные сведения о получении <xref:System.Drawing.Graphics>, см. в разделе [как: Создание объектов Graphics для рисования](how-to-create-graphics-objects-for-drawing.md). Дополнительные сведения о построении <xref:System.Drawing.Font>, см. в разделе [как: Шрифты и их семейств](how-to-construct-font-families-and-fonts.md).  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример кода предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs>`e`, который является параметром <xref:System.Windows.Forms.PaintEventHandler>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.TextRenderer>
- <xref:System.Drawing.Font>
- <xref:System.Drawing.Color>
- <xref:System.Drawing.Color>
- [Шрифты и текст](using-fonts-and-text.md)

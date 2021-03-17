---
title: Практическое руководство. Установка позиций табуляции для выводимого текста
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- text [Windows Forms], drawing with tab stops
- tabs [Windows Forms], drawn text
ms.assetid: 64878f98-39ba-4303-b63f-0859ab682eeb
ms.openlocfilehash: 68dbebfc4fab773fe749f9443d0c61883099d2ab
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59197494"
---
# <a name="how-to-set-tab-stops-in-drawn-text"></a>Практическое руководство. Установка позиций табуляции для выводимого текста
Позиции табуляции для текста можно задать путем вызова <xref:System.Drawing.StringFormat.SetTabStops%2A> метод <xref:System.Drawing.StringFormat> объекта и неудачами, <xref:System.Drawing.StringFormat> объект <xref:System.Drawing.Graphics.DrawString%2A> метод <xref:System.Drawing.Graphics> класса.  
  
> [!NOTE]
>  <xref:System.Windows.Forms.TextRenderer?displayProperty=nameWithType> Делает, поддерживают добавление позиций табуляции для отображаемого текста, несмотря на то, что вы можете развернуть существующую вкладку перестает использовать <xref:System.Windows.Forms.TextFormatFlags.ExpandTabs?displayProperty=nameWithType> флаг.  
  
## <a name="example"></a>Пример  
 В следующем примере позициями табуляции в 150, 250 и 350. Затем код отображает список имен и результатов теста с вкладками.  
  
 На следующем рисунке показано текста:  
  
 ![Снимок экрана, показывающий список с вкладками имена и баллы.](./media/how-to-set-tab-stops-in-drawn-text/tab-list-names-test-scores.png)  
  
 Следующий код передаются два аргумента <xref:System.Drawing.StringFormat.SetTabStops%2A> метод. Вторым аргументом является массив, содержащий смещения позиций табуляции. Первый аргумент, переданный <xref:System.Drawing.StringFormat.SetTabStops%2A> равно 0, это означает, что первое смещение в массиве измеряется начиная с позиции 0, левого края ограничивающего прямоугольника.  
  
 [!code-csharp[System.Drawing.FontsAndText#41](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.FontsAndText/CS/Class1.cs#41)]
 [!code-vb[System.Drawing.FontsAndText#41](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.FontsAndText/VB/Class1.vb#41)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
  
-   Предыдущий пример предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs> `e`, который является параметром <xref:System.Windows.Forms.PaintEventHandler>.  
  
## <a name="see-also"></a>См. также

- [Шрифты и текст](using-fonts-and-text.md)
- [Практическое руководство. Рисование текста с использованием GDI](how-to-draw-text-with-gdi.md)

---
title: Шрифты и текст
ms.date: 03/30/2017
helpviewer_keywords:
- GDI [Windows Forms], drawing text [Windows Forms]
- text [Windows Forms], drawing in Windows Forms
- examples [Windows Forms], fonts and text
- fonts [Windows Forms], using in Windows Forms
- strings [Windows Forms], drawing in Windows Forms
ms.assetid: d43640f3-da94-4df2-a29d-a9d021a1c069
ms.openlocfilehash: c9fe16752223203806c7d3828f632aad0cab0c28
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57703375"
---
# <a name="using-fonts-and-text"></a>Шрифты и текст
Существует несколько классов, предоставляемых [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] и [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)] для рисования текста в формах Windows Forms. [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] <xref:System.Drawing.Graphics> Содержит несколько <xref:System.Drawing.Graphics.DrawString%2A> методы, которые позволяют указать различные свойства текста, таких как местоположение, ограничивающий прямоугольник, шрифт и формат. Кроме того, можно нарисовать и измерить текст с [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)] с помощью статического <xref:System.Windows.Forms.TextRenderer.DrawText%2A> и <xref:System.Windows.Forms.TextRenderer.MeasureText%2A> методы `TextRenderer` класса. [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)] Методы также позволяют указывать расположение, шрифт и формат. Вы также можете выбрать [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)] или [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] для прорисовки текста; Однако [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)] обычно обеспечит более высокую производительность и более точные измерения текста. Другие классы, которые влияют на отрисовку текста включают `FontFamily`, `Font`, <xref:System.Drawing.StringFormat>, и `TextFormatFlags`.  
  
## <a name="in-this-section"></a>В этом разделе  
 [Практическое руководство. Шрифты и их семейств](how-to-construct-font-families-and-fonts.md)  
 Демонстрируется создание `Font` и `FontFamily` объектов.  
  
 [Практическое руководство. Рисование текста в указанном расположении](how-to-draw-text-at-a-specified-location.md)  
 Рисование текста в нужном месте с помощью [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] и [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)].  
  
 [Практическое руководство. Многострочный вывод текста в прямоугольнике](how-to-draw-wrapped-text-in-a-rectangle.md)  
 Рисование текста в прямоугольнике с помощью [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] и [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)].  
  
 [Практическое руководство. Рисование текста с использованием GDI](how-to-draw-text-with-gdi.md)  
 Демонстрирует использование [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)] для рисования текста.  
  
 [Практическое руководство. Выравнивание рисуемого текста](how-to-align-drawn-text.md)  
 Показано, как следует форматировать [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] и [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)] текста.  
  
 [Практическое руководство. Вывод текста по вертикали](how-to-create-vertical-text.md)  
 Рисование текста, выровненного по вертикали с [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)].  
  
 [Практическое руководство. Установка позиций табуляции для выводимого текста](how-to-set-tab-stops-in-drawn-text.md)  
 Рисование текста с позициями табуляции с [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)].  
  
 [Практическое руководство. Перебор установленных шрифтов](how-to-enumerate-installed-fonts.md)  
 Объясняется, как список установленных шрифтов.  
  
 [Практическое руководство. Создание частной коллекции шрифтов](how-to-create-a-private-font-collection.md)  
 Описывает создание <xref:System.Drawing.Text.PrivateFontCollection> объекта.  
  
 [Практическое руководство. Получение метрик шрифтов](how-to-obtain-font-metrics.md)  
 Демонстрируется получение метрик шрифтов, такие как восхождение клетки и спуска.  
  
 [Практическое руководство. Сглаживание текста](how-to-use-antialiasing-with-text.md)  
 В данной статье описывается использование сглаживание при рисовании текста.  
  
## <a name="reference"></a>Ссылка  
 <xref:System.Drawing.Font>  
 Описывает данный класс и содержит ссылки на все его члены.  
  
 <xref:System.Drawing.FontFamily>  
 Описывает данный класс и содержит ссылки на все его члены.  
  
 <xref:System.Drawing.Text.PrivateFontCollection>  
 Описывает данный класс и содержит ссылки на все его члены.  
  
 <xref:System.Windows.Forms.TextRenderer>  
 Описывает данный класс и содержит ссылки на все его члены.  
  
 <xref:System.Windows.Forms.TextFormatFlags>  
 Описывает данный класс и содержит ссылки на все его члены.

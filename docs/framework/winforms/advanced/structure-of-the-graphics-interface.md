---
title: Структура интерфейса Graphics
ms.date: 03/30/2017
helpviewer_keywords:
- GDI+, using managed interface
- graphics [Windows Forms], class structure
ms.assetid: 010a1e46-656b-40a1-8d5d-87aa05ee1243
ms.openlocfilehash: 9dfffe8ea3f76d89823dfe2ef6bd0e4f3accf8f1
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59106786"
---
# <a name="structure-of-the-graphics-interface"></a>Структура интерфейса Graphics
Интерфейс управляемых классов для [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] содержит около 60 классов, 50 перечислений и 8 структур. <xref:System.Drawing.Graphics> Класс является основой [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] функциональные возможности; это класс, который фактически рисует линий, кривых, фигур, изображений и текста.  
  
## <a name="important-classes"></a>Важные классы  
 Многие классы работают вместе с <xref:System.Drawing.Graphics> класса. Например <xref:System.Drawing.Graphics.DrawLine%2A> метод получает <xref:System.Drawing.Pen> объект, который содержит атрибуты линии для отрисовки (цвет, ширину, штриха и т.п). <xref:System.Drawing.Graphics.FillRectangle%2A> Метод может получить указатель на <xref:System.Drawing.Drawing2D.LinearGradientBrush> объект, который работает с <xref:System.Drawing.Graphics> объекта для заполнения прямоугольника постепенного изменения цвета. <xref:System.Drawing.Font> и <xref:System.Drawing.StringFormat> объектов влияют на способ <xref:System.Drawing.Graphics> объект Рисует текст. Объект <xref:System.Drawing.Drawing2D.Matrix> объект хранит и управляет мировое преобразование объекта <xref:System.Drawing.Graphics> объект, который используется для поворота, масштабирования и отражать изображения.  
  
 [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] предоставляет несколько структур (например, <xref:System.Drawing.Rectangle>, <xref:System.Drawing.Point>, и <xref:System.Drawing.Size>) для хранения графических данных. Кроме того некоторые классы служат главным образом как структурированные типы данных. Например <xref:System.Drawing.Imaging.BitmapData> класс — это вспомогательный объект для <xref:System.Drawing.Bitmap> класса и <xref:System.Drawing.Drawing2D.PathData> класс — это вспомогательный объект для <xref:System.Drawing.Drawing2D.GraphicsPath> класса.  
  
 [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] определяет несколько перечислений, которые являются коллекциями связанных констант. Например <xref:System.Drawing.Drawing2D.LineJoin> перечисление содержит элементы <xref:System.Drawing.Drawing2D.LineJoin.Bevel>, <xref:System.Drawing.Drawing2D.LineJoin.Miter>, и <xref:System.Drawing.Drawing2D.LineJoin.Round>, которые определяют стили, которые могут использоваться для соединения двух строк.  
  
## <a name="see-also"></a>См. также

- [Общие сведения о графике](graphics-overview-windows-forms.md)
- [Управляемый код GDI+](about-gdi-managed-code.md)
- [Использование управляемых графических классов](using-managed-graphics-classes.md)

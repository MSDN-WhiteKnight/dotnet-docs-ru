---
title: Практическое руководство. Штриховая заливка фигуры
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- patterns [Windows Forms], adding to shapes
- shapes [Windows Forms], filling with patterns
- brushes [Windows Forms], using hatch brushes
ms.assetid: 9c8300ff-187b-404f-af1f-ebd499f5b16f
ms.openlocfilehash: f5399c4151b335090f4b93be041375b8c2781afa
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59118122"
---
# <a name="how-to-fill-a-shape-with-a-hatch-pattern"></a>Практическое руководство. Штриховая заливка фигуры
Шаблон штриховки осуществляется из двух цветов: один для фона и один для строк, которые образуют узор на фоне. Для заполнения замкнутой фигуры, штриховая, использовать <xref:System.Drawing.Drawing2D.HatchBrush> объекта. Следующий пример демонстрирует Штриховая заливка эллипса:  
  
## <a name="example"></a>Пример  
 <xref:System.Drawing.Drawing2D.HatchBrush.%23ctor%2A> Конструктор принимает три аргумента: стиль штриховки, цвет штриховой линии и цвет фона. Стиль штриховки может быть любое значение от <xref:System.Drawing.Drawing2D.HatchStyle> перечисления. Существует более пятидесяти элементов в <xref:System.Drawing.Drawing2D.HatchStyle> перечисления; часть из них элементы показаны в следующем списке:  
  
-   <xref:System.Drawing.Drawing2D.HatchStyle.Horizontal>  
  
-   <xref:System.Drawing.Drawing2D.HatchStyle.Vertical>  
  
-   <xref:System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal>  
  
-   <xref:System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal>  
  
-   <xref:System.Drawing.Drawing2D.HatchStyle.Cross>  
  
-   <xref:System.Drawing.Drawing2D.HatchStyle.DiagonalCross>  
  
 На следующем рисунке заполненного эллипса.  
  
 ![Шаблон штриховки](./media/hatch1.png "hatch1")  
  
 [!code-csharp[System.Drawing.UsingABrush#41](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.UsingABrush/CS/Class1.cs#41)]
 [!code-vb[System.Drawing.UsingABrush#41](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.UsingABrush/VB/Class1.vb#41)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs>`e`, который является параметром <xref:System.Windows.Forms.Control.Paint> обработчик событий.  
  
## <a name="see-also"></a>См. также

- [Использование кисти для заливки фигур](using-a-brush-to-fill-shapes.md)

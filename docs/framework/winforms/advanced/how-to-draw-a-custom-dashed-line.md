---
title: Практическое руководство. Рисование пользовательских пунктирных линий
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- lines [Windows Forms], custom
- lines [Windows Forms], drawing
- lines [Windows Forms], dashed
ms.assetid: cd0ed96a-cce4-47b9-b58a-3bae2e3d1bee
ms.openlocfilehash: 8dc1ad41cf8067bea5b811ca126ad29f5a600f69
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59109191"
---
# <a name="how-to-draw-a-custom-dashed-line"></a>Практическое руководство. Рисование пользовательских пунктирных линий
[!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] предоставляет несколько стили штрихов, которые перечислены в <xref:System.Drawing.Drawing2D.DashStyle> перечисления. Если эти стандартные штриха не соответствуют вашим потребностям, можно создать пользовательские штриха.  
  
## <a name="example"></a>Пример  
 Рисование пользовательских пунктирных линий, поместите длины штрихов и промежутков в массиве и назначить массив в качестве значения <xref:System.Drawing.Pen.DashPattern%2A> свойство <xref:System.Drawing.Pen> объекта. В следующем примере рисуется пользовательских пунктирных линий на основе массива `{5, 2, 15, 4}`. Если элементы массива умножить на ширину пера, 5, вы получаете `{25, 10, 75, 20}`. Отображаемые дефисы альтернативный длиной от 25 до 75, и пробелы альтернативные длиной от 10 до 20.  
  
 Ниже показан итоговый пунктирная линия. Обратите внимание, что это должно быть короче 25 единиц, таким образом, чтобы конец линии в последний штрих (405, 5).  
  
 ![Рисунок, показывающий пунктирной линией. ](./media/how-to-draw-a-custom-dashed-line/dashed-line-illustration.gif "pens6")  
  
 [!code-csharp[System.Drawing.UsingAPen#51](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.UsingAPen/CS/Class1.cs#51)]
 [!code-vb[System.Drawing.UsingAPen#51](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.UsingAPen/VB/Class1.vb#51)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Создайте форму Windows и обработки формы <xref:System.Windows.Forms.Control.Paint> событий. Вставьте приведенный выше код в <xref:System.Windows.Forms.Control.Paint> обработчик событий.  
  
## <a name="see-also"></a>См. также

- [Рисование линий и фигур с помощью пера](using-a-pen-to-draw-lines-and-shapes.md)

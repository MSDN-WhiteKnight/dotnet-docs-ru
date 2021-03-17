---
title: Практическое руководство. Использование режима комбинирования для управления альфа-смешением
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- alpha blending [Windows Forms], compositing
- colors [Windows Forms], blending
- colors [Windows Forms], controlling transparency
ms.assetid: f331df2d-b395-4b0a-95be-24fec8c9bbb5
ms.openlocfilehash: 15cb111a68cedaec011e88fa4916c292786d16b4
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59210702"
---
# <a name="how-to-use-compositing-mode-to-control-alpha-blending"></a>Практическое руководство. Использование режима комбинирования для управления альфа-смешением
Могут возникнуть ситуации, когда нужно создать в битовом изображении, который имеет следующие характеристики:  
  
-   Цвета имеют альфа-значения, которые меньше 255.  
  
-   Не выполняется альфа-смешение цветов друг с другом при создании точечного рисунка.  
  
-   При отображении завершения растрового изображения, цвета в битовой карте, альфа-смешением с фоновыми цветами на устройстве отображения.  
  
 Чтобы создать такой точечный рисунок, создайте пустой <xref:System.Drawing.Bitmap> объекта, а затем постройте <xref:System.Drawing.Graphics> на его основе объект. Установка режима комбинирования для <xref:System.Drawing.Graphics> объект <xref:System.Drawing.Drawing2D.CompositingMode.SourceCopy?displayProperty=nameWithType>.  
  
## <a name="example"></a>Пример  
 В следующем примере создается <xref:System.Drawing.Graphics> на основе <xref:System.Drawing.Bitmap> объекта. Код использует <xref:System.Drawing.Graphics> вместе с двумя полупрозрачными кистями (альфа-канал = 160) для рисования изображения на точечный рисунок. Код заполняет красного и зеленого эллипса, с помощью полупрозрачными кистями. Зеленый эллипс перекрывается красным эллипсом, но зеленый и красный значок не смешиваются, потому что режим комбинирования <xref:System.Drawing.Graphics> имеет значение <xref:System.Drawing.Drawing2D.CompositingMode.SourceCopy>.  
  
 Точечный рисунок рисуется на экране дважды: один раз на белом фоне и один раз на многоцветном фоне. Пиксели растрового изображения, которые являются частью двух эллипсов имеют альфа-составляющей 160, поэтому многоточие смешиваются с фоновыми цветами на экране.  
  
 Ниже показаны выходные данные примера кода. Обратите внимание, что многоточие смешиваются с фоном, но не смешиваются друг с другом.  
  
 ![Схема отображение многоточие смешением с фоном, не друг с другом.](./media/how-to-use-compositing-mode-to-control-alpha-blending/ellipses-blended-background.png)  
  
 В примере кода содержит следующую инструкцию:  
  
 [!code-csharp[System.Drawing.AlphaBlending#41](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.AlphaBlending/CS/Class1.cs#41)]
 [!code-vb[System.Drawing.AlphaBlending#41](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.AlphaBlending/VB/Class1.vb#41)]  
  
 Если требуется многоточие смешивались друг с другом, а также с фоном, измените этот оператор следующим:  
  
 [!code-csharp[System.Drawing.AlphaBlending#42](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.AlphaBlending/CS/Class1.cs#42)]
 [!code-vb[System.Drawing.AlphaBlending#42](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.AlphaBlending/VB/Class1.vb#42)]  
  
 Ниже показан результат выполнения обновленного кода.  
  
 ![Схема, показывающая многоточие смешением друг с другом и с фоном.](./media/how-to-use-compositing-mode-to-control-alpha-blending/blend-ellipses-background.png)  
  
 [!code-csharp[System.Drawing.AlphaBlending#43](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.AlphaBlending/CS/Class1.cs#43)]
 [!code-vb[System.Drawing.AlphaBlending#43](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.AlphaBlending/VB/Class1.vb#43)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs>`e`, который является параметром <xref:System.Windows.Forms.PaintEventHandler>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Color.FromArgb%2A>
- [Альфа-смешение цвета для линий и заливок](alpha-blending-lines-and-fills.md)

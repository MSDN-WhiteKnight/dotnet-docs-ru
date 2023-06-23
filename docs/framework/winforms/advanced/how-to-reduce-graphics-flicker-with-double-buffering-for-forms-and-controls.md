---
title: Практическое руководство. Уменьшение эффекта дрожания изображения посредством двойной буферизации для форм и элементов управления
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- flicker [Windows Forms], reducing in Windows Forms
- graphics [Windows Forms], reducing double-buffered flicker
ms.assetid: 91083d3a-653f-4f15-a467-0f37b2aa39d6
ms.openlocfilehash: ef05b72b33d3f28d1811389dfae65554a1567d43
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59096957"
---
# <a name="how-to-reduce-graphics-flicker-with-double-buffering-for-forms-and-controls"></a>Практическое руководство. Уменьшение эффекта дрожания изображения посредством двойной буферизации для форм и элементов управления
Двойная буферизация использует буфер памяти для решения проблем мерцания, связанных с несколькими операциями рисования. Если двойная буферизация включена, все операции рисования сначала обрабатываются в буфере памяти вместо области рисования на экране. После завершения всех операций рисования буфер памяти копируется непосредственно в связанную с ним область рисования. Поскольку на экране выполняется лишь одна графическая операция, исключается мерцание со сложными операциями рисования. Для большинства приложений по умолчанию двойной буферизации .NET Framework обеспечит лучшие результаты. Стандартные элементы управления Windows Forms являются двойной буферизации по умолчанию. Вы можете включить двойную буферизацию в формах и элементах управления двумя способами. Можно либо установить <xref:System.Windows.Forms.Control.DoubleBuffered%2A> свойства `true`, либо путем вызова <xref:System.Windows.Forms.Control.SetStyle%2A> метод, чтобы задать <xref:System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer> флаг `true`. Оба метода включает двойной буферизации по умолчанию для формы или элемента управления и обеспечения отрисовки графики без мерцания. Вызов <xref:System.Windows.Forms.Control.SetStyle%2A> рекомендуется только для пользовательских элементов управления, для которых вы написали весь код отрисовки.  
  
 Для более сложных сценариях буферизации, например при анимации или сложном управлении памятью можно реализовать свою собственную логику для двойной буферизации. Дополнительные сведения см. в разделе [Как Управление буферизацией графики](how-to-manually-manage-buffered-graphics.md).  
  
### <a name="to-reduce-flicker"></a>Чтобы снизить мерцание  
  
-   Задайте для свойства <xref:System.Windows.Forms.Control.DoubleBuffered%2A> значение `true`.  
  
     [!code-csharp[System.Windows.Forms.LegacyBufferedGraphics#31](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.LegacyBufferedGraphics/CS/Class1.cs#31)]
       
  
 \- или -  
  
-   Вызовите <xref:System.Windows.Forms.Control.SetStyle%2A> метод, чтобы задать <xref:System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer> флаг `true`.  
  
     [!code-csharp[System.Windows.Forms.LegacyBufferedGraphics#32](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.LegacyBufferedGraphics/CS/Class1.cs#32)]
       
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Control.DoubleBuffered%2A>
- <xref:System.Windows.Forms.Control.SetStyle%2A>
- [Двойная буферизация графики](double-buffered-graphics.md)
- [Объекты Graphics и Drawing в Windows Forms](graphics-and-drawing-in-windows-forms.md)

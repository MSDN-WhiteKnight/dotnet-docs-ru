---
title: Практическое руководство. Анимирование значения BorderThickness
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- border thickness [WPF], animating changes to
- animation [WPF], changes to border thickness
ms.assetid: fd021978-f74b-4e7b-a7f7-3987dcad9e0f
ms.openlocfilehash: 10e177d1f6d6add4638ce14af900e75d7e363890
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59150739"
---
# <a name="how-to-animate-a-borderthickness-value"></a>Практическое руководство. Анимирование значения BorderThickness
В этом примере показано, как анимировать изменения толщины границы с помощью <xref:System.Windows.Media.Animation.ThicknessAnimation> класса.  
  
## <a name="example"></a>Пример  
 Следующий пример анимирует толщины границы с помощью <xref:System.Windows.Media.Animation.ThicknessAnimation>. В примере используется <xref:System.Windows.Controls.Border.BorderThickness%2A> свойство <xref:System.Windows.Controls.Border>.  
  
 [!code-csharp[BasicAnimations_snip#ThicknessAnimationWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/BasicAnimations_snip/CSharp/ThicknessAnimationExample.cs#thicknessanimationwholepage)]
 [!code-vb[BasicAnimations_snip#ThicknessAnimationWholePage](~/samples/snippets/visualbasic/VS_Snippets_Wpf/BasicAnimations_snip/VisualBasic/ThicknessAnimationExample.vb#thicknessanimationwholepage)]  
  
 Полный пример см. в разделе [Коллекция примеров анимации](https://go.microsoft.com/fwlink/?LinkID=159969).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Animation.ThicknessAnimation>
- <xref:System.Windows.Controls.Border.BorderThickness%2A>
- <xref:System.Windows.Controls.Border>
- [Общие сведения об эффектах анимации](../graphics-multimedia/animation-overview.md)
- [Разделы руководства по анимации и таймерам](../graphics-multimedia/animation-and-timing-how-to-topics.md)
- [Анимация толщины границы с помощью ключевых кадров](../graphics-multimedia/how-to-animate-the-thickness-of-a-border-by-using-key-frames.md)

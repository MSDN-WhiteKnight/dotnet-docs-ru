---
title: Практическое руководство. Анимация расположения объекта с помощью PointAnimation
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- graphics [WPF], animation
- animation [WPF], PointAnimation
ms.assetid: 42310977-cc90-438a-8a47-0345898e01be
ms.openlocfilehash: 1ef3f77e551affaa7e61d2aabf95f10c29275417
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59111310"
---
# <a name="how-to-animate-the-position-of-an-object-by-using-pointanimation"></a>Практическое руководство. Анимация расположения объекта с помощью PointAnimation
В этом примере показано, как использовать <xref:System.Windows.Media.Animation.PointAnimation> класс для анимации объекта вдоль <xref:System.Windows.Shapes.Path>.  
  
## <a name="example"></a>Пример  
 В следующем примере эллипс перемещается <xref:System.Windows.Shapes.Path> из одной точки на экране в другой. Пример анимирует положение <xref:System.Windows.Media.EllipseGeometry> с помощью <xref:System.Windows.Media.Animation.PointAnimation> для анимации <xref:System.Windows.Media.EllipseGeometry.Center%2A> свойство.  
  
 [!code-csharp[BasicAnimations_snip#PointAnimationWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/BasicAnimations_snip/CSharp/PointAnimationExample.cs#pointanimationwholepage)]
 [!code-vb[BasicAnimations_snip#PointAnimationWholePage](~/samples/snippets/visualbasic/VS_Snippets_Wpf/BasicAnimations_snip/VisualBasic/PointAnimationExample.vb#pointanimationwholepage)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Animation.PointAnimation>
- <xref:System.Windows.Shapes.Path>
- <xref:System.Windows.Media.EllipseGeometry>
- <xref:System.Windows.Media.EllipseGeometry.Center%2A>
- [Общие сведения об эффектах анимации](animation-overview.md)
- [Графика и мультимедиа](index.md)
- [Разделы практического руководства, посвященные графике](graphics-how-to-topics.md)
- [Разделы руководства по анимации и таймерам](animation-and-timing-how-to-topics.md)

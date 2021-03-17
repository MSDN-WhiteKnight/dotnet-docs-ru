---
title: Практическое руководство. Анимация объекта вдоль контура (точечная анимация)
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- animation [WPF], objects along paths (point animation)
- point animation [WPF]
ms.assetid: 1fa3f817-35bc-41a1-b366-f5a20b70da0c
ms.openlocfilehash: 4ef28118975d02500916676ca50e0f9622c7a3e2
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59129594"
---
# <a name="how-to-animate-an-object-along-a-path-point-animation"></a>Практическое руководство. Анимация объекта вдоль контура (точечная анимация)
В этом примере показано, как использовать <xref:System.Windows.Media.Animation.PointAnimationUsingPath> анимируемого объекта <xref:System.Windows.Point> вдоль изогнутого пути.  
  
## <a name="example"></a>Пример  
 В следующем примере выполняется перемещение <xref:System.Windows.Media.EllipseGeometry> вдоль пути, определенного с <xref:System.Windows.Media.PathGeometry>. Эллипс <xref:System.Windows.Media.EllipseGeometry.Center%2A> свойство, которое принимает <xref:System.Windows.Point> значение, указывающее его положение; для перемещения эллипса, можно анимировать его <xref:System.Windows.Media.EllipseGeometry.Center%2A> свойство. В примере используется <xref:System.Windows.Media.Animation.PointAnimationUsingPath> для анимации <xref:System.Windows.Media.EllipseGeometry> объекта <xref:System.Windows.Media.EllipseGeometry.Center%2A> свойство.  
  
 [!code-xaml[PathAnimationGallery_snippet#PointAnimationUsingPathWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/PathAnimationGallery_snippet/CS/pointanimationusingpathexample.xaml#pointanimationusingpathwholepage)]  
  
 [!code-csharp[PathAnimationGallery_procedural_snip#PointAnimationUsingPathWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/PathAnimationGallery_procedural_snip/CSharp/PointAnimationUsingPathExample.cs#pointanimationusingpathwholepage)]
 [!code-vb[PathAnimationGallery_procedural_snip#PointAnimationUsingPathWholePage](~/samples/snippets/visualbasic/VS_Snippets_Wpf/PathAnimationGallery_procedural_snip/VisualBasic/PointAnimationUsingPathExample.vb#pointanimationusingpathwholepage)]  
  
 Полный пример см. в разделе [Пример анимации вдоль пути](https://go.microsoft.com/fwlink/?LinkID=160028).  
  
 В версии кода в предыдущем примере используется <xref:System.Windows.Media.Animation.Storyboard> для анимации <xref:System.Windows.Media.EllipseGeometry>, несмотря на то, что была применена всего одна анимация. Объект <xref:System.Windows.Media.Animation.Storyboard> часто является самым простым способом применения нескольких анимаций, так как эти анимации можно управлять тем же <xref:System.Windows.Media.Animation.Storyboard>. Тем не менее, более простой способ применения одной анимации к свойству, при использовании кода является использование <xref:System.Windows.Media.Animation.Animatable.BeginAnimation%2A> метод. Пример см. в разделе [Анимация свойства без использования раскадровки](how-to-animate-a-property-without-using-a-storyboard.md).  
  
## <a name="see-also"></a>См. также

- [Пример анимации вдоль пути](https://go.microsoft.com/fwlink/?LinkID=160028)
- [Общие сведения об эффектах анимации](animation-overview.md)
- [Практические руководства, посвященные анимации пути](path-animation-how-to-topics.md)

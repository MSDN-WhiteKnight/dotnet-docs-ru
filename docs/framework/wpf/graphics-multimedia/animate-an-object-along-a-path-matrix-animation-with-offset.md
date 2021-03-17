---
title: Практическое руководство. Анимация объектов по всему пути (матричная анимации с накоплением смещения)
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- offset accumulation [WPF]
- animation [WPF], objects along paths (matrix animation with offset accumulation)
- matrix animation with offset accumulation [WPF]
ms.assetid: 1bca90ef-9832-4128-8ed6-62908e7ec146
ms.openlocfilehash: 3e7b892e2a2215d26512850477844d71bce7fe09
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59207374"
---
# <a name="how-to-animate-an-object-along-a-path-matrix-animation-with-offset-accumulation"></a>Практическое руководство. Анимация объектов по всему пути (матричная анимации с накоплением смещения)
В этом примере показано, как использовать <xref:System.Windows.Media.Animation.MatrixAnimationUsingPath> класс для анимации объекта вдоль пути и с накоплением смещения анимацией значения при повторении.  
  
## <a name="example"></a>Пример  
 В следующем примере используется <xref:System.Windows.Media.Animation.MatrixAnimationUsingPath> анимируемого объекта <xref:System.Windows.Media.MatrixTransform.Matrix%2A> свойство <xref:System.Windows.Media.MatrixTransform> , примененного к кнопке. В результате кнопка перемещается вдоль изогнутого пути.  
  
 Кроме того, в этом примере <xref:System.Windows.Media.Animation.MatrixAnimationUsingPath.IsOffsetCumulative%2A> свойства `true`, который вызывает смещения анимированной матрицы накапливаться при повторе анимации. Поскольку смещение накапливается, при повторении анимации кнопка перемещается все дальше по экрану, а не возвращается в начальную позицию.  
  
 [!code-xaml[PathAnimationGallery_snippet#MatrixAnimationUsingPathOffsetCumulativeWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/PathAnimationGallery_snippet/CS/matrixanimationusingpathexampleoffsetcumulative.xaml#matrixanimationusingpathoffsetcumulativewholepage)]  
  
 [!code-csharp[PathAnimationGallery_procedural_snip#MatrixAnimationUsingPathOffsetCumulativeWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/PathAnimationGallery_procedural_snip/CSharp/MatrixAnimationUsingPathExampleOffsetCumulative.cs#matrixanimationusingpathoffsetcumulativewholepage)]
 [!code-vb[PathAnimationGallery_procedural_snip#MatrixAnimationUsingPathOffsetCumulativeWholePage](~/samples/snippets/visualbasic/VS_Snippets_Wpf/PathAnimationGallery_procedural_snip/VisualBasic/MatrixAnimationUsingPathExampleOffsetCumulative.vb#matrixanimationusingpathoffsetcumulativewholepage)]  
  
 Обратите внимание, что, несмотря на то что <xref:System.Windows.Media.Animation.MatrixAnimationUsingPath.IsOffsetCumulative%2A> свойство приводит к накоплению значений смещения, оно не вызывает накопления значений поворота. Чтобы сделать накопления значений поворота, установите анимации <xref:System.Windows.Media.Animation.MatrixAnimationUsingPath.DoesRotateWithTangent%2A> и <xref:System.Windows.Media.Animation.MatrixAnimationUsingPath.IsAngleCumulative%2A> свойства `true`.  
  
 Полный пример см. в разделе [Пример анимации вдоль пути](https://go.microsoft.com/fwlink/?LinkID=160028). Пример, показывающий, как анимировать <xref:System.Windows.Media.Matrix> значение вдоль пути без накопления смещения, см. в разделе [анимация объекта вдоль пути (матричная анимация)](how-to-animate-an-object-along-a-path-matrix-animation.md).  
  
## <a name="see-also"></a>См. также

- [Общие сведения об эффектах анимации](animation-overview.md)
- [Практические руководства, посвященные анимации пути](path-animation-how-to-topics.md)

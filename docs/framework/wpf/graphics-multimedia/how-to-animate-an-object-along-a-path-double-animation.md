---
title: Практическое руководство. Анимация объекта вдоль контура (двойная анимация)
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- animation [WPF], objects along paths (double animation)
- double animation [WPF]
ms.assetid: 5a3c4a99-f303-42ad-a52a-e4794bb1798e
ms.openlocfilehash: 54f345bbe6b513e3593cbf45ba190d4a44228424
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59101449"
---
# <a name="how-to-animate-an-object-along-a-path-double-animation"></a>Практическое руководство. Анимация объекта вдоль контура (двойная анимация)
В этом примере показано, как использовать <xref:System.Windows.Media.Animation.DoubleAnimationUsingPath> класс для перемещения объекта вдоль пути, определенного с <xref:System.Windows.Media.PathGeometry>.  
  
## <a name="example"></a>Пример  
 В следующем примере используется два <xref:System.Windows.Media.Animation.DoubleAnimationUsingPath> объекты для перемещения прямоугольника вдоль геометрического пути:  
  
-   Первый <xref:System.Windows.Media.Animation.DoubleAnimationUsingPath> анимирует <xref:System.Windows.Media.TranslateTransform.X%2A> из <xref:System.Windows.Media.TranslateTransform> примененного к прямоугольнику. В результате прямоугольник перемещается горизонтально вдоль пути.  
  
-   Второй <xref:System.Windows.Media.Animation.DoubleAnimationUsingPath> анимирует <xref:System.Windows.Media.TranslateTransform.Y%2A> из <xref:System.Windows.Media.TranslateTransform> примененного к прямоугольнику. В результате прямоугольник перемещается вертикально вдоль пути.  
  
 [!code-xaml[PathAnimationGallery_snippet#DoubleAnimationUsingPathWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/PathAnimationGallery_snippet/CS/doubleanimationusingpathexample.xaml#doubleanimationusingpathwholepage)]  
  
 [!code-csharp[PathAnimationGallery_procedural_snip#DoubleAnimationUsingPathWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/PathAnimationGallery_procedural_snip/CSharp/DoubleAnimationUsingPathExample.cs#doubleanimationusingpathwholepage)]
 [!code-vb[PathAnimationGallery_procedural_snip#DoubleAnimationUsingPathWholePage](~/samples/snippets/visualbasic/VS_Snippets_Wpf/PathAnimationGallery_procedural_snip/VisualBasic/DoubleAnimationUsingPathExample.vb#doubleanimationusingpathwholepage)]  
  
 Полный пример см. в разделе [Пример анимации вдоль пути](https://go.microsoft.com/fwlink/?LinkID=160028).  
  
 Другой способ перемещения объекта с помощью геометрического пути является использование <xref:System.Windows.Media.Animation.MatrixAnimationUsingPath> объекта. Например, см. в разделе [анимация объекта вдоль пути (матричная анимация)](how-to-animate-an-object-along-a-path-matrix-animation.md).  
  
## <a name="see-also"></a>См. также

- [Общие сведения об эффектах анимации](animation-overview.md)
- [Практические руководства, посвященные анимации пути](path-animation-how-to-topics.md)

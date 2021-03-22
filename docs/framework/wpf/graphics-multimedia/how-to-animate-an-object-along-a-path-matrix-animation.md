---
title: Практическое руководство. Анимация объекта вдоль контура (матричная анимация)
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- animation [WPF], objects along paths (matrix animation)
- matrix animation [WPF]
ms.assetid: 7000e697-1414-468c-b915-cf66062fc49e
ms.openlocfilehash: ab15126680b7d8c6936246a7dae2f67c7541233b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59190929"
---
# <a name="how-to-animate-an-object-along-a-path-matrix-animation"></a>Практическое руководство. Анимация объекта вдоль контура (матричная анимация)
В этом примере показано, как использовать <xref:System.Windows.Media.Animation.MatrixAnimationUsingPath> класс для анимации объекта вдоль пути, который определяется <xref:System.Windows.Media.PathGeometry>.  
  
## <a name="example"></a>Пример  
 Следующий пример анимирует объект вдоль пути следующим образом:  
  
-   Применяет <xref:System.Windows.Media.MatrixTransform> к объекту, чтобы переместить его.  
  
-   Определяет путь с помощью <xref:System.Windows.Media.PathGeometry>.  
  
-   Создает <xref:System.Windows.Media.Animation.MatrixAnimationUsingPath> и использует его для анимации <xref:System.Windows.Media.Matrix> свойство <xref:System.Windows.Media.MatrixTransform>. <xref:System.Windows.Media.Animation.MatrixAnimationUsingPath> Принимает <xref:System.Windows.Media.PathGeometry> и использует их для создания <xref:System.Windows.Media.Matrix> значения.  
  
 [!code-xaml[PathAnimationGallery_snippet#MatrixAnimationUsingPathWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/PathAnimationGallery_snippet/CS/matrixanimationusingpathexample.xaml#matrixanimationusingpathwholepage)]  
  
 [!code-csharp[PathAnimationGallery_procedural_snip#MatrixAnimationUsingPathWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/PathAnimationGallery_procedural_snip/CSharp/MatrixAnimationUsingPathExample.cs#matrixanimationusingpathwholepage)]
   
  
 Полный пример см. в разделе [Пример анимации вдоль пути](https://go.microsoft.com/fwlink/?LinkID=160028). Дополнительные сведения о геометрических путях см. в разделе [Общие сведения о геометрии](geometry-overview.md).  
  
## <a name="see-also"></a>См. также

- [Общие сведения об эффектах анимации](animation-overview.md)
- [Пример анимации вдоль пути](https://go.microsoft.com/fwlink/?LinkID=160028)
- [Практические руководства, посвященные анимации пути](path-animation-how-to-topics.md)

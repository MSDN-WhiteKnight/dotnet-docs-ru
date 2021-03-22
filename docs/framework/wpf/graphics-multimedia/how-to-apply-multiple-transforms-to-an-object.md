---
title: Практическое руководство. Применение нескольких преобразований к объекту
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- grouping Transform objects [WPF]
- Transform objects [WPF], grouping
- graphics [WPF], grouping Transform objects
- TransformGroup [WPF]
ms.assetid: 98cd1921-12bc-4bf5-8193-529228fb7402
ms.openlocfilehash: 26dcd4a64fc7aa2c3cb9cc599ceaef292efb1b6a
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59192768"
---
# <a name="how-to-apply-multiple-transforms-to-an-object"></a>Практическое руководство. Применение нескольких преобразований к объекту
В этом примере показано, как использовать <xref:System.Windows.Media.TransformGroup> для группировки двух или более <xref:System.Windows.Media.Transform> объектов в один составной <xref:System.Windows.Media.Transform>.  
  
## <a name="example"></a>Пример  
 В следующем примере используется <xref:System.Windows.Media.TransformGroup> для применения <xref:System.Windows.Media.ScaleTransform> и <xref:System.Windows.Media.RotateTransform> для <xref:System.Windows.Controls.Button>.  
  
 [!code-xaml[Transforms_snip#MultipleTransformExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/Transforms_snip/CS/MultipleTransformExample.xaml#multipletransformexamplewholepage)]  
  
 [!code-csharp[Transforms_Procedural_snip#MultipleTransformsCodeExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/Transforms_Procedural_snip/CSharp/MultipleTransformsExample.cs#multipletransformscodeexamplewholepage)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.UIElement.RenderTransform%2A>
- <xref:System.Windows.Media.TransformGroup>
- [Общие сведения о классах Transform](transforms-overview.md)
- [Пример двумерных преобразований](https://go.microsoft.com/fwlink/?LinkID=158252)

---
title: Практическое руководство. Закраска области с линейным градиентом
ms.date: 03/30/2017
helpviewer_keywords:
- linear gradients [WPF], painting with
- brushes [WPF], painting with linear gradients
- painting [WPF], with linear gradients
ms.assetid: 00e0cd04-48c0-4ec5-850e-d321beb37a34
ms.openlocfilehash: c48ff13811d784ecc7042b73b964a9e6f2d42a34
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57367249"
---
# <a name="how-to-paint-an-area-with-a-linear-gradient"></a>Практическое руководство. Закраска области с линейным градиентом
В этом примере показано, как использовать <xref:System.Windows.Media.LinearGradientBrush> класс для закраски области с линейным градиентом. В следующем примере <xref:System.Windows.Shapes.Shape.Fill%2A> из <xref:System.Windows.Shapes.Rectangle> отрисовывается с диагонального линейного градиента, которая переходит с желтого красного, синего и зеленого.  
  
## <a name="example"></a>Пример  
 [!code-xaml[GradientBrushExamples_snip#DiagonalGradient1XAML](~/samples/snippets/xaml/VS_Snippets_Wpf/GradientBrushExamples_snip/XAML/LinearGradientBrushExample.xaml#diagonalgradient1xaml)]  
  
 [!code-csharp[GradientBrushExamples_snip#DiagonalGradient1CSharp](~/samples/snippets/csharp/VS_Snippets_Wpf/GradientBrushExamples_snip/CSharp/LinearGradientBrushExample.cs#diagonalgradient1csharp)]  
  
 На следующем рисунке показан градиент, созданный в предыдущем примере.  
  
 ![Диагональный линейный градиент](./media/graphicsmm-diagonallgb.jpg "graphicsmm_DiagonalLGB")  
  
 Чтобы создать горизонтальный линейный градиент, измените <xref:System.Windows.Media.LinearGradientBrush.StartPoint%2A> и <xref:System.Windows.Media.LinearGradientBrush.EndPoint%2A> из <xref:System.Windows.Media.LinearGradientBrush> к (0,0.5) и (1,0.5). В следующем примере <xref:System.Windows.Shapes.Rectangle> отрисовывается с горизонтального линейного градиента.  
  
 [!code-xaml[GradientBrushExamples_snip#HorizontalGradient1XAML](~/samples/snippets/xaml/VS_Snippets_Wpf/GradientBrushExamples_snip/XAML/LinearGradientBrushExample.xaml#horizontalgradient1xaml)]  
  
 [!code-csharp[GradientBrushExamples_snip#HorizontalGradient1CSharp](~/samples/snippets/csharp/VS_Snippets_Wpf/GradientBrushExamples_snip/CSharp/LinearGradientBrushExample.cs#horizontalgradient1csharp)]  
  
 На следующем рисунке показан градиент, созданный в предыдущем примере.  
  
 ![Горизонтальный линейный градиент](./media/graphicsmm-horizontallgb.jpg "graphicsmm_HorizontalLGB")  
  
 Чтобы создать Вертикальный линейный градиент, измените <xref:System.Windows.Media.LinearGradientBrush.StartPoint%2A> и <xref:System.Windows.Media.LinearGradientBrush.EndPoint%2A> из <xref:System.Windows.Media.LinearGradientBrush> на (0.5,0) и (0.5,1). В следующем примере <xref:System.Windows.Shapes.Rectangle> окрашен Вертикальный линейный градиент.  
  
 [!code-xaml[GradientBrushExamples_snip#VerticalGradient1XAML](~/samples/snippets/xaml/VS_Snippets_Wpf/GradientBrushExamples_snip/XAML/LinearGradientBrushExample.xaml#verticalgradient1xaml)]  
  
 [!code-csharp[GradientBrushExamples_snip#VerticalGradient1CSharp](~/samples/snippets/csharp/VS_Snippets_Wpf/GradientBrushExamples_snip/CSharp/LinearGradientBrushExample.cs#verticalgradient1csharp)]  
  
 На следующем рисунке показан градиент, созданный в предыдущем примере.  
  
 ![Вертикальный линейный градиент](./media/graphicsmm-verticallgb.jpg "graphicsmm_VerticalLGB")  
  
> [!NOTE]
>  В примерах этого раздела используется система координат по умолчанию для определения начальной и конечной точек. Система координат по умолчанию определяется относительно ограничивающего прямоугольника: 0 указывает 0 процентов ограничивающего прямоугольника, а 1 указывает 100 процентов ограничивающего прямоугольника. Эту систему координат можно изменить, задав <xref:System.Windows.Media.GradientBrush.MappingMode%2A> в соответствии с значением <xref:System.Windows.Media.BrushMappingMode.Absolute?displayProperty=nameWithType>. Абсолютная система координат не привязана к ограничивающему прямоугольнику. Значения интерпретируются непосредственно в локальной области.  
  
 Дополнительные примеры см. в разделе [пример использования кистей](https://go.microsoft.com/fwlink/?LinkID=159973). Дополнительные сведения о градиенты и других типов кистей см. в разделе [закраске сплошным цветом и градиентом Обзор](painting-with-solid-colors-and-gradients-overview.md).

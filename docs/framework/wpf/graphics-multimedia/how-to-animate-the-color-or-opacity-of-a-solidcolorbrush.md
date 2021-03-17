---
title: Практическое руководство. Анимация цвета или прозрачности объекта SolidColorBrush
ms.date: 03/30/2017
helpviewer_keywords:
- SolidColorBrush [WPF], animating color of
- colors [WPF], animating
- opacity [WPF], animating
- animation [WPF], color of SolidColorBrush
- animation [WPF], opacity of SolidColorBrush
- SolidColorBrush [WPF], animating opacity of
ms.assetid: d9154354-843f-4713-bad1-35bb0ba6eaeb
ms.openlocfilehash: e440cf49b8b16051361650f9659dc6006c2e7b56
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59072163"
---
# <a name="how-to-animate-the-color-or-opacity-of-a-solidcolorbrush"></a>Практическое руководство. Анимация цвета или прозрачности объекта SolidColorBrush
В этом примере демонстрируется анимация <xref:System.Windows.Media.SolidColorBrush.Color%2A> и <xref:System.Windows.Media.Brush.Opacity%2A> из <xref:System.Windows.Media.SolidColorBrush>.  
  
## <a name="example"></a>Пример  
 В следующем примере используется три анимации для анимирования <xref:System.Windows.Media.SolidColorBrush.Color%2A> и <xref:System.Windows.Media.Brush.Opacity%2A> из <xref:System.Windows.Media.SolidColorBrush>.  
  
-   Первая анимация, <xref:System.Windows.Media.Animation.ColorAnimation>, изменяет цвет кисти на <xref:System.Windows.Media.Colors.Gray%2A> когда указатель мыши перемещается прямоугольник.  
  
-   Следующая анимация, другой <xref:System.Windows.Media.Animation.ColorAnimation>, изменяет цвет кисти на <xref:System.Windows.Media.Colors.Orange%2A> когда указатель мыши покидает прямоугольник.  
  
-   Последняя анимация, <xref:System.Windows.Media.Animation.DoubleAnimation>, изменяет непрозрачность кисти на 0.0 при нажатии левой кнопки мыши.  
  
 [!code-csharp[brushanimations_snip#SolidColorBrushAnimationExample](~/samples/snippets/csharp/VS_Snippets_Wpf/brushanimations_snip/CSharp/SolidColorBrushExample.cs#solidcolorbrushanimationexample)]  
  
 Более полный пример, в котором показано, как анимировать различные типы кисти, см. в разделе [пример использования кистей](https://go.microsoft.com/fwlink/?LinkID=159973). Дополнительные сведения об анимации см. в разделе [Общие сведения об анимации](animation-overview.md).  
  
 Для обеспечения согласованности с другими примерами анимации версии кода этого примера используют <xref:System.Windows.Media.Animation.Storyboard> объекта для применения соответствующих анимаций. Тем не менее, при применении в коде одной анимации, проще использовать <xref:System.Windows.Media.Animation.Animatable.BeginAnimation%2A> метода вместо использования <xref:System.Windows.Media.Animation.Storyboard>. Пример см. в разделе [Анимация свойства без использования раскадровки](how-to-animate-a-property-without-using-a-storyboard.md).  
  
## <a name="see-also"></a>См. также

- [Общие сведения об эффектах анимации](animation-overview.md)
- [Общие сведения о Storyboard](storyboards-overview.md)
- [Пример использования кистей](https://go.microsoft.com/fwlink/?LinkID=159973)

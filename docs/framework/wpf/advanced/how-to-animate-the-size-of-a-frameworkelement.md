---
title: Практическое руководство. Анимация размера элемента FrameworkElement
ms.date: 03/30/2017
helpviewer_keywords:
- animation [WPF], FrameworkElement size
- FrameworkElement [WPF], animating size of
ms.assetid: d4cd5a13-c20d-4a6f-a2ba-14f2c9ce4cef
ms.openlocfilehash: d1995deec5ab2c9bf405911af43b4d242d599119
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57360996"
---
# <a name="how-to-animate-the-size-of-a-frameworkelement"></a>Практическое руководство. Анимация размера элемента FrameworkElement
Чтобы анимация размера элемента <xref:System.Windows.FrameworkElement>, можно анимировать его <xref:System.Windows.FrameworkElement.Width%2A> и <xref:System.Windows.FrameworkElement.Height%2A> свойства или использовать анимированное <xref:System.Windows.Media.ScaleTransform>.  
  
 В следующем примере анимируется размер двух кнопок с помощью этих двух подходов. Размер одной кнопки изменяется, анимируя его <xref:System.Windows.FrameworkElement.Width%2A> свойства, а другой изменяется посредством анимации <xref:System.Windows.Media.ScaleTransform> применяется к его <xref:System.Windows.UIElement.RenderTransform%2A> свойство. Каждая кнопка содержит текст. Первоначально отображается текст, соответствующим образом в обеих кнопок, но искажается при изменении размера кнопок, текст в второй кнопки.  
  
## <a name="example"></a>Пример  
 [!code-xaml[transformanimations_snip#1](~/samples/snippets/xaml/VS_Snippets_Wpf/transformanimations_snip/XAML/AnimatingSizeExample.xaml#1)]  
  
 При преобразовании элемента, преобразуются весь элемент и его содержимым. При непосредственном изменении размера элемента, как в случае первой кнопки, содержимое этого элемента не изменяются, если их размер и положение зависят от размера родительского элемента.  
  
 Анимация размера элемента, применяя анимированного преобразования к его <xref:System.Windows.UIElement.RenderTransform%2A> свойство обеспечивает более высокую производительность, чем анимировать его <xref:System.Windows.FrameworkElement.Width%2A> и <xref:System.Windows.FrameworkElement.Height%2A> напрямую, так как <xref:System.Windows.UIElement.RenderTransform%2A> свойство не вызывает прохода макета.  
  
 Дополнительные сведения об анимации свойств см. в разделе [Общие сведения об анимации](../graphics-multimedia/animation-overview.md). Дополнительные сведения о преобразованиях см. в разделе [Общие сведения о преобразованиях](../graphics-multimedia/transforms-overview.md).

---
title: Практическое руководство. Анимация прозрачности элемента или кисти
ms.date: 03/30/2017
helpviewer_keywords:
- opacity [WPF], animating
- animation [WPF], Opacity property
ms.assetid: 572af23b-39dd-48d1-9db5-4bca56a4b3d3
ms.openlocfilehash: f07138a0b68fff050133d477074571c60cd8651e
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57363375"
---
# <a name="how-to-animate-the-opacity-of-an-element-or-brush"></a>Практическое руководство. Анимация прозрачности элемента или кисти
Чтобы сделать это элемент платформы исчезновения и появления, можно анимировать его <xref:System.Windows.UIElement.Opacity%2A> можно анимировать свойство или вы <xref:System.Windows.Media.Brush.Opacity%2A> свойство <xref:System.Windows.Media.Brush> (или кисти) используется для рисования. Анимация прозрачности элемента делает его исчезновения и появления его дочерних элементов, но анимация кисть, которая используется для рисования элемента дает возможность более точного Плавное какая часть элемента. Например можно анимировать непрозрачность кисти, используемый для рисования фона кнопки. Это приведет к фона кнопки для и исчезновения представления, оставив его текст полной непрозрачности.  
  
> [!NOTE]
>  Анимация <xref:System.Windows.Media.Brush.Opacity%2A> из <xref:System.Windows.Media.Brush> дает выигрыш в производительности, чем анимация <xref:System.Windows.UIElement.Opacity%2A> свойства элемента.  
  
 В следующем примере две кнопки, применяется анимация, таким образом, чтобы они исчезновения и появления. Непрозрачность первый <xref:System.Windows.Controls.Button> анимируется от `1.0` для `0.0` через <xref:System.Windows.Media.Animation.Timeline.Duration%2A> 5 секунд. Вторая кнопка также анимируется, но непрозрачность SolidColorBrush используется для закрашивания его <xref:System.Windows.Controls.Control.Background%2A> анимируется вместо того, чтобы вся кнопка прозрачность. При выполнении примера первая кнопка полностью исчезает и появляется, хотя исчезает и появляется только фон второй кнопки. Текст и границы остаются полностью непрозрачными.  
  
## <a name="example"></a>Пример  
 [!code-xaml[timingbehaviors_snip#10](~/samples/snippets/csharp/VS_Snippets_Wpf/timingbehaviors_snip/CSharp/OpacityAnimationExample.xaml#10)]  
  
 В этом примере отсутствует код. Полный пример также показано, как анимация прозрачности <xref:System.Windows.Media.Color> в <xref:System.Windows.Media.LinearGradientBrush>.  Полный пример см. в разделе [Анимация прозрачности элемента-пример](https://github.com/Microsoft/WPF-Samples/tree/master/Animation/OpacityAnimation).

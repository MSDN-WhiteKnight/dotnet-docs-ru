---
title: Практическое руководство. Анимирование свойства с помощью AnimationClock
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- animation [WPF], properties [WPF], with AnimationClocks
- AnimationClocks [WPF]
ms.assetid: e6542021-714c-4675-9567-04f1c7380834
ms.openlocfilehash: 4fa9efc593461d26eabaee5e2f62c1a17da1b543
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59201368"
---
# <a name="how-to-animate-a-property-by-using-an-animationclock"></a>Практическое руководство. Анимирование свойства с помощью AnimationClock
В этом примере показано, как использовать <xref:System.Windows.Media.Animation.Clock> объектов для анимации свойства.  
  
 Есть три способа анимации свойства зависимостей:  
  
-   Создание <xref:System.Windows.Media.Animation.AnimationTimeline> и свяжите ее с этим свойством с помощью <xref:System.Windows.Media.Animation.Storyboard>.  
  
-   Использование объекта <xref:System.Windows.Media.Animation.Animatable.BeginAnimation%2A> метод для применения одного <xref:System.Windows.Media.Animation.AnimationTimeline> к целевому свойству.  
  
-   Создание <xref:System.Windows.Media.Animation.AnimationClock> из <xref:System.Windows.Media.Animation.AnimationTimeline> и применить его к свойству.  
  
 <xref:System.Windows.Media.Animation.Storyboard> объекты и <xref:System.Windows.Media.Animation.Animatable.BeginAnimation%2A> метод позволяют анимировать свойства без явного создания и распределения часов (примеры см. в разделе [анимация свойства с помощью раскадровки](how-to-animate-a-property-by-using-a-storyboard.md) и [анимация свойства без С помощью раскадровки](how-to-animate-a-property-without-using-a-storyboard.md)); часы создаются и распространяются автоматически.  
  
## <a name="example"></a>Пример  
 В следующем примере показано, как создать <xref:System.Windows.Media.Animation.AnimationClock> и применить его к двум похожим свойствам.  
  
 [!code-csharp[timingbehaviors_procedural_snip#GraphicsMMCreateAnimationClockWholeClass](~/samples/snippets/csharp/VS_Snippets_Wpf/timingbehaviors_procedural_snip/CSharp/AnimationClockExample.cs#graphicsmmcreateanimationclockwholeclass)]
 [!code-vb[timingbehaviors_procedural_snip#GraphicsMMCreateAnimationClockWholeClass](~/samples/snippets/visualbasic/VS_Snippets_Wpf/timingbehaviors_procedural_snip/visualbasic/animationclockexample.vb#graphicsmmcreateanimationclockwholeclass)]  
  
 Пример, показывающий, как управлять в интерактивном режиме <xref:System.Windows.Media.Animation.Clock> после ее запуска, см. в разделе [управление часами в интерактивном режиме](how-to-interactively-control-a-clock.md).  
  
## <a name="see-also"></a>См. также

- [Анимация свойства с помощью раскадровки](how-to-animate-a-property-by-using-a-storyboard.md)
- [Анимация свойства без использования раскадровки](how-to-animate-a-property-without-using-a-storyboard.md)
- [Общие сведения о методах анимации свойств](property-animation-techniques-overview.md)

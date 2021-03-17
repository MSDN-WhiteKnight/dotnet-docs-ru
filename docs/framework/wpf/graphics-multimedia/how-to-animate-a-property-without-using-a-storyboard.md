---
title: Практическое руководство. Анимация свойства без использования раскадровки
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- non-Storyboard animation
- local animation [WPF]
- animation [WPF], non-Storyboard (local)
ms.assetid: d411db70-4df7-487d-82bc-95a7c1b2e7f8
ms.openlocfilehash: 93609cdeb4d879cbec0f90096e4fa2c131a2ec5e
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59091711"
---
# <a name="how-to-animate-a-property-without-using-a-storyboard"></a>Практическое руководство. Анимация свойства без использования раскадровки
В этом примере показан один из способов применения анимации к свойству без использования <xref:System.Windows.Media.Animation.Storyboard>.  
  
> [!NOTE]
>  Эта функциональность недоступна в [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)]. Дополнительные сведения об анимации свойств в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] см. в разделе [Анимация свойства с помощью раскадровки](how-to-animate-a-property-by-using-a-storyboard.md).  
  
 Чтобы применить локальную анимацию к свойству, используйте <xref:System.Windows.UIElement.BeginAnimation%2A> метод. Этот метод принимает два параметра: <xref:System.Windows.DependencyProperty> , который указывает свойство для анимации и анимацию, применяемую к этому свойству.  
  
## <a name="example"></a>Пример  
 В следующем примере показано, как анимировать ширину и цвет фона для <xref:System.Windows.Controls.Button>.  
  
 [!code-cpp[animateproperty#11](~/samples/snippets/cpp/VS_Snippets_Wpf/animateproperty/CPP/LocalAnimationExample.cpp#11)]
 [!code-csharp[animateproperty#11](~/samples/snippets/csharp/VS_Snippets_Wpf/animateproperty/CSharp/LocalAnimationExample.cs#11)]
 [!code-vb[animateproperty#11](~/samples/snippets/visualbasic/VS_Snippets_Wpf/animateproperty/VisualBasic/LocalAnimationExample.vb#11)]  
  
 Широкий набор классов анимации в <xref:System.Windows.Media.Animation> существует пространство имен для анимации различных типов свойств. Дополнительные сведения об анимации свойств см. в разделе [Общие сведения об эффектах анимации](animation-overview.md). Дополнительные сведения о свойствах зависимостей (тип свойств, приведенных в этих примерах) и их функциях см. в разделе [Общие сведения о свойствах зависимостей](../advanced/dependency-properties-overview.md).  
  
 Существуют другие способы анимации без использования <xref:System.Windows.Media.Animation.Storyboard> объектов; Дополнительные сведения см. в разделе [Общие сведения о методах анимации свойств](property-animation-techniques-overview.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Animation.AnimationTimeline>
- <xref:System.Windows.Media.Animation.Animatable.BeginAnimation%2A>
- <xref:System.Windows.Media.Animation>
- <xref:System.Windows.Media.Animation.Storyboard>
- [Общие сведения о методах анимации свойств](property-animation-techniques-overview.md)
- [Общие сведения об эффектах анимации](animation-overview.md)

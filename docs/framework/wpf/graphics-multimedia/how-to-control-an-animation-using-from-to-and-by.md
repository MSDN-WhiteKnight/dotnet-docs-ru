---
title: Практическое руководство. Управление анимацией с помощью From, To и By
ms.date: 03/30/2017
helpviewer_keywords:
- animation [WPF], From/to/by
- basic animation [WPF]
- animation [WPF], basic animation
- From/to/by animation
ms.assetid: 59afba57-6fc1-44c8-987e-8a5f4142adad
ms.openlocfilehash: 56522ee5bd4391e43c261558b2fa622234c9ea3b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59073276"
---
# <a name="how-to-control-an-animation-using-from-to-and-by"></a>Практическое руководство. Управление анимацией с помощью From, To и By
«From/To/By» или «простая анимация» создает переход между двумя целевыми значениями (см. в разделе [Общие сведения об анимации](animation-overview.md) введение в различные виды анимации). Чтобы задать целевые значения для простой анимации, используйте его <xref:System.Windows.Media.Animation.DoubleAnimation.From%2A>, <xref:System.Windows.Media.Animation.DoubleAnimation.To%2A>, и <xref:System.Windows.Media.Animation.DoubleAnimation.By%2A> свойства.  В следующей таблице перечислены как <xref:System.Windows.Media.Animation.DoubleAnimation.From%2A>, <xref:System.Windows.Media.Animation.DoubleAnimation.To%2A>, и <xref:System.Windows.Media.Animation.DoubleAnimation.By%2A> свойства могут быть использованы вместе или отдельно, чтобы определить целевой объект анимации значения.  
  
|Заданные свойства|Результирующее поведение|  
|--------------------------|------------------------|  
|<xref:System.Windows.Media.Animation.DoubleAnimation.From%2A>|Анимация выполняется от значения, указанного в <xref:System.Windows.Media.Animation.DoubleAnimation.From%2A> свойство к базовому значению анимируемого свойства или предыдущей анимации выходного значения, в зависимости от того, как настроена предыдущая анимация.|  
|<xref:System.Windows.Media.Animation.DoubleAnimation.From%2A> и <xref:System.Windows.Media.Animation.DoubleAnimation.To%2A>|Анимация выполняется от значения, указанного в <xref:System.Windows.Media.Animation.DoubleAnimation.From%2A> присваивается значение, заданное параметром <xref:System.Windows.Media.Animation.DoubleAnimation.To%2A> свойство.|  
|<xref:System.Windows.Media.Animation.DoubleAnimation.From%2A> и <xref:System.Windows.Media.Animation.DoubleAnimation.By%2A>|Анимация выполняется от значения, указанного в <xref:System.Windows.Media.Animation.DoubleAnimation.From%2A> свойства к значению, указанному на сумму <xref:System.Windows.Media.Animation.DoubleAnimation.From%2A> и <xref:System.Windows.Media.Animation.DoubleAnimation.By%2A> свойства.|  
|<xref:System.Windows.Media.Animation.DoubleAnimation.To%2A>|Анимация продвигается от базового значения анимируемого свойства или значение к значению, заданному в выходных данных предыдущей анимации <xref:System.Windows.Media.Animation.DoubleAnimation.To%2A> свойство.|  
|<xref:System.Windows.Media.Animation.DoubleAnimation.By%2A>|Анимация выполняется от базового значения анимируемого свойства или предыдущей анимации выходного значения к сумме этого значения и значения, указанного в <xref:System.Windows.Media.Animation.DoubleAnimation.By%2A> свойство.|  
  
> [!NOTE]
>  Не задавайте одновременно <xref:System.Windows.Media.Animation.DoubleAnimation.To%2A> свойство и <xref:System.Windows.Media.Animation.DoubleAnimation.By%2A> свойство для одной анимации.  
  
 Чтобы применить другие методы интерполяции или выполнять анимацию между более чем двумя целевыми значениями, используйте анимацию по ключевым кадрам. См. в разделе [сведения об анимации по ключевым кадрам](key-frame-animations-overview.md) Дополнительные сведения.  
  
 Сведения о применении нескольких анимаций к одному свойству см. в разделе [сведения об анимации по ключевым кадрам](key-frame-animations-overview.md).  
  
 В приведенном ниже примере показаны различные эффекты параметра <xref:System.Windows.Media.Animation.DoubleAnimation.To%2A>, <xref:System.Windows.Media.Animation.DoubleAnimation.By%2A>, и <xref:System.Windows.Media.Animation.DoubleAnimation.From%2A> анимации свойств.  
  
## <a name="example"></a>Пример  
 [!code-xaml[BasicAnimations_snippet#AnimationTargetValuesWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/BasicAnimations_snippet/CS/AnimationTargetValuesExample.xaml#animationtargetvalueswholepage)]  
  
## <a name="see-also"></a>См. также

- [Общие сведения об эффектах анимации](animation-overview.md)
- [Общие сведения об анимации по ключевым кадрам](key-frame-animations-overview.md)
- [FROM, To и пример целевых значений анимации](https://go.microsoft.com/fwlink/?LinkID=159988)

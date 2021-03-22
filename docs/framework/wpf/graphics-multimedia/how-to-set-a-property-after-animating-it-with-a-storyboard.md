---
title: Практическое руководство. Определение свойства после его анимации с помощью раскадровки
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- animation [WPF], changing property values after
ms.assetid: 79466556-4dbf-40bd-9c1e-a77613b07077
ms.openlocfilehash: 2e1389392c6465ed56b2c71e53b2e3c1947acbe2
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59188322"
---
# <a name="how-to-set-a-property-after-animating-it-with-a-storyboard"></a>Практическое руководство. Определение свойства после его анимации с помощью раскадровки
В некоторых случаях может оказаться, что не удается изменить значение свойства после его анимации.  
  
## <a name="example"></a>Пример  
 В следующем примере <xref:System.Windows.Media.Animation.Storyboard> используется для анимации цвета <xref:System.Windows.Media.SolidColorBrush>. Раскадровка активируется при нажатии кнопки. <xref:System.Windows.Media.Animation.Timeline.Completed> Событие обрабатывается таким образом, чтобы программа уведомляется при <xref:System.Windows.Media.Animation.ColorAnimation> завершения.  
  
 [!code-xaml[timingbehaviors_snip#GraphicsMMButton1Declaration](~/samples/snippets/csharp/VS_Snippets_Wpf/timingbehaviors_snip/CSharp/AnimateThenSetPropertyExample.xaml#graphicsmmbutton1declaration)]  
  
## <a name="example"></a>Пример  
 После <xref:System.Windows.Media.Animation.ColorAnimation> завершения, программа выполняет попытку изменить цвет кисти на синий.  
  
 [!code-csharp[timingbehaviors_snip#GraphicsMMButton1Handler](~/samples/snippets/csharp/VS_Snippets_Wpf/timingbehaviors_snip/CSharp/AnimateThenSetPropertyExample.xaml.cs#graphicsmmbutton1handler)]
   
  
 Приведенный выше код не выполняет никаких действий: кисть остается желтой, что является значением, предоставляемые <xref:System.Windows.Media.Animation.ColorAnimation> , анимировать кисть. Значение базового свойства (базовое значение) фактически изменяется на синий. Тем не менее эффективно, или текущий, значение остается желтый поскольку <xref:System.Windows.Media.Animation.ColorAnimation> по-прежнему переопределяет базовое значение. Если требуется базовое значение снова становятся действительное значение, необходимо остановить влияние свойства анимации. Существует три способа это сделать с помощью анимации раскадровки:  
  
-   Анимации <xref:System.Windows.Media.Animation.Timeline.FillBehavior%2A> свойства <xref:System.Windows.Media.Animation.FillBehavior.Stop>  
  
-   Удаление всей раскадровки.  
  
-   Удалите анимацию из отдельного свойства.  
  
## <a name="set-the-animations-fillbehavior-property-to-stop"></a>Значение Stop анимации FillBehavior-свойство  
 Установив <xref:System.Windows.Media.Animation.Timeline.FillBehavior%2A> для <xref:System.Windows.Media.Animation.FillBehavior.Stop>, определяют для остановки влияет на целевое свойство после достижения конца активного периода.  
  
 [!code-xaml[timingbehaviors_snip#GraphicsMMButton2Declaration](~/samples/snippets/csharp/VS_Snippets_Wpf/timingbehaviors_snip/CSharp/AnimateThenSetPropertyExample.xaml#graphicsmmbutton2declaration)]  
  
 [!code-csharp[timingbehaviors_snip#GraphicsMMButton2Handler](~/samples/snippets/csharp/VS_Snippets_Wpf/timingbehaviors_snip/CSharp/AnimateThenSetPropertyExample.xaml.cs#graphicsmmbutton2handler)]
   
  
## <a name="remove-the-entire-storyboard"></a>Удаление раскадровки  
 С помощью <xref:System.Windows.Media.Animation.RemoveStoryboard> триггера или <xref:System.Windows.Media.Animation.Storyboard.Remove%2A?displayProperty=nameWithType> метод, вы указываете анимаций раскадровки для остановки, влияя на их целевые свойства. Разница между этим подходом и установкой <xref:System.Windows.Media.Animation.Timeline.FillBehavior%2A> свойство является то, что можно удалить раскадровку в любое время, хотя <xref:System.Windows.Media.Animation.Timeline.FillBehavior%2A> свойство действует только при анимации достигает конца активного периода.  
  
 [!code-xaml[timingbehaviors_snip#GraphicsMMButton3Declaration](~/samples/snippets/csharp/VS_Snippets_Wpf/timingbehaviors_snip/CSharp/AnimateThenSetPropertyExample.xaml#graphicsmmbutton3declaration)]  
  
 [!code-csharp[timingbehaviors_snip#GraphicsMMButton3Handler](~/samples/snippets/csharp/VS_Snippets_Wpf/timingbehaviors_snip/CSharp/AnimateThenSetPropertyExample.xaml.cs#graphicsmmbutton3handler)]
   
  
## <a name="remove-an-animation-from-an-individual-property"></a>Удалить анимацию из отдельного свойства  
 Другим способом остановки влияния свойство анимации является использование <xref:System.Windows.Media.Animation.Animatable.BeginAnimation%28System.Windows.DependencyProperty%2CSystem.Windows.Media.Animation.AnimationTimeline%29> метод анимируемого объекта. Укажите в качестве первого параметра анимируемое свойство и `null` как второй.  
  
 [!code-xaml[timingbehaviors_snip#GraphicsMMButton4Declaration](~/samples/snippets/csharp/VS_Snippets_Wpf/timingbehaviors_snip/CSharp/AnimateThenSetPropertyExample.xaml#graphicsmmbutton4declaration)]  
  
 [!code-csharp[timingbehaviors_snip#GraphicsMMButton4Handler](~/samples/snippets/csharp/VS_Snippets_Wpf/timingbehaviors_snip/CSharp/AnimateThenSetPropertyExample.xaml.cs#graphicsmmbutton4handler)]
   
  
 Этот способ также подходит для анимаций без раскадровки.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Animation.Timeline.FillBehavior%2A>
- <xref:System.Windows.Media.Animation.Storyboard.Remove%2A?displayProperty=nameWithType>
- <xref:System.Windows.Media.Animation.RemoveStoryboard>
- [Общие сведения об эффектах анимации](animation-overview.md)
- [Общие сведения о методах анимации свойств](property-animation-techniques-overview.md)

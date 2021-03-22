---
title: Практическое руководство. Анимация свойства с помощью раскадровки
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- animation [WPF], Storyboards
- Storyboards [WPF], animation
ms.assetid: f4a314e9-1da2-4367-85fc-1232487efa7a
ms.openlocfilehash: f6064368b4f5e4fa8324b4039d734d4430cd9174
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57364714"
---
# <a name="how-to-animate-a-property-by-using-a-storyboard"></a>Практическое руководство. Анимация свойства с помощью раскадровки
В этом примере показано, как использовать <xref:System.Windows.Media.Animation.Storyboard> для анимации свойств. Для анимации свойства, с помощью <xref:System.Windows.Media.Animation.Storyboard>, создать анимацию для каждого свойства, которое вы хотите анимировать, а также создать <xref:System.Windows.Media.Animation.Storyboard> для хранения анимации.  
  
 Тип свойства определяет тип используемой анимации. Например, для анимации свойства, которое принимает <xref:System.Double> значения, используйте <xref:System.Windows.Media.Animation.DoubleAnimation>. <xref:System.Windows.Media.Animation.Storyboard.TargetName%2A> И <xref:System.Windows.Media.Animation.Storyboard.TargetProperty> присоединенные свойства укажите объект и свойство, к которому применяется анимация.  
  
 Чтобы запустить раскадровку [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)], использовать <xref:System.Windows.Media.Animation.BeginStoryboard> действия и <xref:System.Windows.EventTrigger>. <xref:System.Windows.EventTrigger> Начинает <xref:System.Windows.Media.Animation.BeginStoryboard> действие, когда событие, определяемое его <xref:System.Windows.EventTrigger.RoutedEvent%2A> происходит свойство. <xref:System.Windows.Media.Animation.BeginStoryboard> Началом действия <xref:System.Windows.Media.Animation.Storyboard>.  
  
 В следующем примере используется <xref:System.Windows.Media.Animation.Storyboard> объектов для анимации двух <xref:System.Windows.Controls.Button> элементов управления. Для первой кнопки изменяется в размерах, его <xref:System.Windows.FrameworkElement.Width%2A> анимируется. Для изменения цвета второй кнопки <xref:System.Windows.Media.SolidColorBrush.Color%2A> свойство <xref:System.Windows.Media.SolidColorBrush> используется для задания <xref:System.Windows.Controls.Control.Background%2A> кнопки, анимировано.  
  
## <a name="example"></a>Пример  
 [!code-xaml[AnimatePropertyStoryboards#1](~/samples/snippets/xaml/VS_Snippets_Wpf/AnimatePropertyStoryboards/XAML/StoryboardExample.xaml#1)]  
  
> [!NOTE]
>  Несмотря на то, что анимация может ориентироваться и <xref:System.Windows.FrameworkElement> объект, например <xref:System.Windows.Controls.Control> или <xref:System.Windows.Controls.Panel>и <xref:System.Windows.Freezable> объект, например <xref:System.Windows.Media.Brush> или <xref:System.Windows.Media.Transform>, только элементы структуры имеют <xref:System.Windows.FrameworkElement.Name%2A> свойство. Для назначения имени объекту freezable, чтобы его можно было использовать в анимации, следует использовать [директиву x:Name](../../xaml-services/x-name-directive.md), как показано в предыдущем примере.  
  
 Если используется код, необходимо создать <xref:System.Windows.NameScope> для <xref:System.Windows.FrameworkElement> и зарегистрируйте имена объектов для анимации с помощью <xref:System.Windows.FrameworkElement>. Для запуска анимаций в коде, используйте <xref:System.Windows.Media.Animation.BeginStoryboard> действие с <xref:System.Windows.EventTrigger>. При необходимости можно использовать обработчик событий и <xref:System.Windows.Media.Animation.Storyboard.Begin%2A> метод <xref:System.Windows.Media.Animation.Storyboard>. В следующем примере показано, как использовать метод <xref:System.Windows.Media.Animation.Storyboard.Begin%2A>.  
  
 [!code-csharp[AnimatePropertyStoryboards#11](~/samples/snippets/csharp/VS_Snippets_Wpf/AnimatePropertyStoryboards/CSharp/StoryboardExample.cs#11)]
   
  
 Дополнительные сведения об анимации и раскадровках см. в разделе [Общие сведения об эффектах анимации](animation-overview.md).  
  
 Если используется код, вы не ограничены использованием <xref:System.Windows.Media.Animation.Storyboard> объектов для анимации свойств. Дополнительные сведения и примеры см. в разделах [Анимация свойств без использования раскадровки](how-to-animate-a-property-without-using-a-storyboard.md) и [Анимация свойств с помощью AnimationClock](how-to-animate-a-property-by-using-an-animationclock.md).

---
title: Общие сведения о методах анимации свойств
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- animation [WPF], properties [WPF], methods for
- properties [WPF], methods for animating
ms.assetid: 74f61413-f8c0-4e75-bf04-951886426c8b
ms.openlocfilehash: ebee350f69b5c5e4f9d38c452b9c87bf003528ee
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59317913"
---
# <a name="property-animation-techniques-overview"></a>Общие сведения о методах анимации свойств
В этом разделе описываются различные подходы к анимации свойств: раскадровки, локальные анимации, часы и покадровая анимация.  
  
<a name="prerequisites"></a>   
## <a name="prerequisites"></a>Предварительные требования  
 Для понимания этого раздела необходимо ознакомиться с базовыми средствами анимации, которые описаны в разделе [Общие сведения об эффектах анимации](animation-overview.md).  
  
<a name="summary"></a>   
## <a name="different-ways-to-animate"></a>Различные способы анимации  
 Так как существует множество различных сценариев для анимации свойств, [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] предоставляет несколько подходов к анимации свойств.  
  
 Для каждого подхода в следующей таблице указано, можно ли применять его к конкретным экземплярам, использовать в стилях, в шаблонах элементов управления или в шаблонах данных, можно ли использовать его в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] и позволяет ли этот подход интерактивно управлять анимацией.  Применение к конкретным экземплярам подразумевает применение анимации или раскадровки непосредственно к экземплярам объектов, а не в стилях, шаблонах элементов управления или шаблонах данных.  
  
|Подход к анимации|Сценарии|Поддерживает XAML|Интерактивное управление|  
|-------------------------|---------------|-------------------|--------------------------------|  
|Раскадровка|Для каждого экземпляра, <xref:System.Windows.Style>, <xref:System.Windows.Controls.ControlTemplate>, <xref:System.Windows.DataTemplate>|Да|Да|  
|Локальная анимация|Применение к конкретным экземплярам|Нет|Нет|  
|Часы|Применение к конкретным экземплярам|Нет|Да|  
|Покадровая анимация|Применение к конкретным экземплярам|Нет|Н/Д|  
  
<a name="storyboard_animations"></a>   
## <a name="storyboard-animations"></a>Раскадровка  
 Используйте <xref:System.Windows.Media.Animation.Storyboard> при необходимости определить и применить анимации с помощью [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)], интерактивного управления анимациями после запуска, создания сложного дерева анимаций или анимации в <xref:System.Windows.Style>, <xref:System.Windows.Controls.ControlTemplate> или <xref:System.Windows.DataTemplate>. Для объекта анимируется с <xref:System.Windows.Media.Animation.Storyboard>, он должен быть <xref:System.Windows.FrameworkElement> или <xref:System.Windows.FrameworkContentElement>, или он должен использоваться для задания <xref:System.Windows.FrameworkElement> или <xref:System.Windows.FrameworkContentElement>. Дополнительные сведения см. в разделе [Общие сведения о раскадровке](storyboards-overview.md).  
  
 Объект <xref:System.Windows.Media.Animation.Storyboard> — это специальный тип контейнера <xref:System.Windows.Media.Animation.Timeline> , предоставляющей сведения об анимации, которую она содержит. Для анимации с <xref:System.Windows.Media.Animation.Storyboard>, выполните следующие три действия.  
  
1. Объявите <xref:System.Windows.Media.Animation.Storyboard> и одну или несколько анимаций.  
  
2. Используйте <xref:System.Windows.Media.Animation.Storyboard.TargetName%2A> и <xref:System.Windows.Media.Animation.Storyboard.TargetProperty> присоединенного свойства для указания целевого объекта и свойства каждой анимации.  
  
3. (Только код) Определение <xref:System.Windows.NameScope> для <xref:System.Windows.FrameworkElement> или <xref:System.Windows.FrameworkContentElement>. Зарегистрируйте имена объектов для анимации с помощью <xref:System.Windows.FrameworkElement> или <xref:System.Windows.FrameworkContentElement>.  
  
4. Начать <xref:System.Windows.Media.Animation.Storyboard>.  
  
 Начиная <xref:System.Windows.Media.Animation.Storyboard> анимация применяется к анимируемым свойствам и запускает их. Существует два способа, чтобы начать <xref:System.Windows.Media.Animation.Storyboard>: можно использовать <xref:System.Windows.Media.Animation.Storyboard.Begin%2A> метод <xref:System.Windows.Media.Animation.Storyboard> класс, или же можно использовать <xref:System.Windows.Media.Animation.BeginStoryboard> действие. Единственным способом для анимации в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] заключается в использовании <xref:System.Windows.Media.Animation.BeginStoryboard> действие. Объект <xref:System.Windows.Media.Animation.BeginStoryboard> действие может использоваться в <xref:System.Windows.EventTrigger>, свойство <xref:System.Windows.Trigger>, или <xref:System.Windows.DataTrigger>.  
  
 В следующей таблице показаны различные где каждого <xref:System.Windows.Media.Animation.Storyboard> начать прием поддерживается: для каждого экземпляра, стиль, шаблон элемента управления и шаблон данных.  
  
|Раскадровка запускается с помощью метода...|Применение к конкретным экземплярам|Стиль|Шаблон элемента управления|Шаблон данных|Пример|  
|--------------------------------|-------------------|-----------|----------------------|-------------------|-------------|  
|<xref:System.Windows.Media.Animation.BeginStoryboard> и <xref:System.Windows.EventTrigger>|Да|Да|Да|Да|[Анимация свойства с помощью раскадровки](how-to-animate-a-property-by-using-a-storyboard.md)|  
|<xref:System.Windows.Media.Animation.BeginStoryboard> и свойство <xref:System.Windows.Trigger>|Нет|Да|Да|Да|[Запуск анимации при изменении значения свойства](how-to-trigger-an-animation-when-a-property-value-changes.md)|  
|<xref:System.Windows.Media.Animation.BeginStoryboard> и <xref:System.Windows.DataTrigger>|Нет|Да|Да|Да|[Практическое руководство. Запуск анимации при изменении данных](https://docs.microsoft.com/previous-versions/dotnet/netframework-3.5/aa970679(v=vs.90))|  
|<xref:System.Windows.Media.Animation.Storyboard.Begin%2A> метод|Да|Нет|Нет|Нет|[Анимация свойства с помощью раскадровки](how-to-animate-a-property-by-using-a-storyboard.md)|  
  
 Дополнительные сведения о <xref:System.Windows.Media.Animation.Storyboard> объектов, см. в разделе [Общие сведения о раскадровках](storyboards-overview.md).  
  
## <a name="local-animations"></a>Локальная анимация  
 Локальные анимации предоставляют удобный способ для анимации свойства зависимостей любого <xref:System.Windows.Media.Animation.Animatable> объекта. Используйте локальную анимацию, когда необходимо применить одну анимацию к свойству и не требуется интерактивно управлять анимацией после ее запуска. В отличие от <xref:System.Windows.Media.Animation.Storyboard> анимации, локальной анимации можно анимировать объект, не связанный с <xref:System.Windows.FrameworkElement> или <xref:System.Windows.FrameworkContentElement>. Также не нужно определять <xref:System.Windows.NameScope> для этого типа анимации.  
  
 Локальные анимации могут использоваться только в коде. Их нельзя определить в стилях, шаблонах элементов управления и шаблонах данных. После запуска локальной анимации управлять ей в интерактивном режиме нельзя.  
  
 Для анимации с помощью локальной анимации выполните следующие действия.  
  
1. Создание <xref:System.Windows.Media.Animation.AnimationTimeline> объекта.  
  
2. Используйте <xref:System.Windows.Media.Animation.Animatable.BeginAnimation%2A> метод объекта, который вы хотите анимировать, чтобы применить <xref:System.Windows.Media.Animation.AnimationTimeline> к свойству, которое можно указать.  
  
 В следующем примере показано, как анимировать ширину и цвет фона для <xref:System.Windows.Controls.Button>.  
  
 
 [!code-csharp[animateproperty#11](~/samples/snippets/csharp/VS_Snippets_Wpf/animateproperty/CSharp/LocalAnimationExample.cs#11)]
   
  
## <a name="clock-animations"></a>Часы  
 Используйте <xref:System.Windows.Media.MediaPlayer.Clock%2A> объектов при необходимости выполнить анимацию без использования <xref:System.Windows.Media.Animation.Storyboard> и вы хотите создать сложные деревья временных или интерактивно управлять анимацией после запуска. Можно использовать объекты Clock для анимации свойства зависимостей любого <xref:System.Windows.Media.Animation.Animatable> объекта.  
  
 Нельзя использовать <xref:System.Windows.Media.Animation.Clock> объекты непосредственно для анимации в стилях, управлять шаблонами и шаблонах данных. (Анимации и системы времени фактически используют <xref:System.Windows.Media.Animation.Clock> объектов для анимации в стили, шаблоны элементов управления и шаблонах данных, но необходимо создать эти <xref:System.Windows.Media.Animation.Clock> объекты из <xref:System.Windows.Media.Animation.Storyboard>. Дополнительные сведения о связи между <xref:System.Windows.Media.Animation.Storyboard> объектов и <xref:System.Windows.Media.Animation.Clock> объектов, см. в разделе [анимации и общие сведения о характере системы](animation-and-timing-system-overview.md).)  
  
 Для применения одного <xref:System.Windows.Media.Animation.Clock> к свойству, выполните следующие действия.  
  
1. Создание <xref:System.Windows.Media.Animation.AnimationTimeline> объекта.  
  
2. Используйте <xref:System.Windows.Media.Animation.AnimationTimeline.CreateClock%2A> метод <xref:System.Windows.Media.Animation.AnimationTimeline> для создания <xref:System.Windows.Media.Animation.AnimationClock>.  
  
3. Используйте <xref:System.Windows.Media.Animation.Animatable.ApplyAnimationClock%2A> метод объекта, который вы хотите анимировать, чтобы применить <xref:System.Windows.Media.Animation.AnimationClock> к указанному свойству.  
  
 В следующем примере показано, как создать <xref:System.Windows.Media.Animation.AnimationClock> и применить его к двум похожим свойствам.  
  
 [!code-csharp[timingbehaviors_procedural_snip#GraphicsMMCreateAnimationClockWholeClass](~/samples/snippets/csharp/VS_Snippets_Wpf/timingbehaviors_procedural_snip/CSharp/AnimationClockExample.cs#graphicsmmcreateanimationclockwholeclass)]
   
  
 Чтобы создать дерево временной шкалы и использовать его анимации свойств, выполните следующие действия.  
  
1. Используйте <xref:System.Windows.Media.Animation.ParallelTimeline> и <xref:System.Windows.Media.Animation.AnimationTimeline> объекты для создания дерева времени.  
  
2. Используйте <xref:System.Windows.Media.Animation.TimelineGroup.CreateClock%2A> корневого <xref:System.Windows.Media.Animation.ParallelTimeline> для создания <xref:System.Windows.Media.Animation.ClockGroup>.  
  
3. Итерации по <xref:System.Windows.Media.Animation.ClockGroup.Children%2A> из <xref:System.Windows.Media.Animation.ClockGroup> и примените его дочерние <xref:System.Windows.Media.Animation.Clock> объектов. Для каждого <xref:System.Windows.Media.Animation.AnimationClock> дочерний элемент, используйте <xref:System.Windows.Media.Animation.Animatable.ApplyAnimationClock%2A> метод объекта, который вы хотите анимировать, чтобы применить <xref:System.Windows.Media.Animation.AnimationClock> к указанному свойству  
  
 Дополнительные сведения об объектах часов см. в разделе [Общие сведения об анимации и системе управления временем](animation-and-timing-system-overview.md).  
  
## <a name="per-frame-animation-bypass-the-animation-and-timing-system"></a>Покадровая анимация: Обход анимации и системы управления временем  
 Этот подход следует использовать, если требуется полностью обойти систему анимации WPF [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]. Один из сценариев для такого подхода — анимация физики, при которой на каждом шаге анимации требуется пересчитывать объекты на основе последнего набора итераций объектов.  
  
 Покадровую анимацию нельзя определить в стилях, шаблонах элементов управления или шаблонах данных.  
  
 Чтобы анимировать фрейм за фреймом, сначала зарегистрироваться для <xref:System.Windows.Media.CompositionTarget.Rendering> события объекта, который содержит объекты, которые требуется анимировать. Метод обработчика событий вызывается один раз для каждого кадра. Каждый раз, когда [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] выполняет маршалинг сохраненных данных отрисовки в визуальном дереве через дерево композиции, вызывается метод обработчика событий.  
  
 В обработчике событий выполняются все вычисления, необходимые для эффекта анимации, и задаются свойства объектов, которые требуется анимировать с этими значениями.  
  
 Чтобы получить время представления для текущего кадра, <xref:System.EventArgs> связанный с данным событий может быть приведен как <xref:System.Windows.Media.RenderingEventArgs>, которые обеспечивают <xref:System.Windows.Media.RenderingEventArgs.RenderingTime%2A> времени отрисовки свойство, которое можно использовать для получения текущего кадра.  
  
 Дополнительные сведения см. в разделе <xref:System.Windows.Media.CompositionTarget.Rendering> страницы.  
  
## <a name="see-also"></a>См. также

- [Общие сведения об эффектах анимации](animation-overview.md)
- [Общие сведения о Storyboard](storyboards-overview.md)
- [Общие сведения об анимации и системе управления временем](animation-and-timing-system-overview.md)
- [Общие сведения о свойствах зависимости](../advanced/dependency-properties-overview.md)

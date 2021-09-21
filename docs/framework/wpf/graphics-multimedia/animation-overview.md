---
title: Общие сведения об эффектах анимации
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Storyboards [WPF], animations
- animations [WPF], overview
ms.assetid: bd9ce563-725d-4385-87c9-d7ee38cf79ea
ms.openlocfilehash: 530f6cb8fbe80df3ad374f8ad0e4836be82830a9
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59337738"
---
# <a name="animation-overview"></a>Общие сведения об эффектах анимации
<a name="introduction"></a>
Windows Presentation Foundation (WPF) предоставляет мощный набор функций графикой и макетом, которые позволяют создавать привлекательные пользовательские интерфейсы и документы. Применение анимации позволяет сделать пользовательский интерфейс еще более наглядным и удобным в использовании. Используйте анимацию цвета фона или объекта <xref:System.Windows.Media.Transform>, можно создать экранных эффектов перехода или отображения визуальных подсказок.  
  
 Данный обзор представляет введение в WPF анимации и системы. Этот раздел посвящен анимации из WPF объектов с помощью раскадровок.  

<a name="introducinganimations"></a>   
## <a name="introducing-animations"></a>Введение в анимацию  
 Анимация — это имитация изменений, которая обеспечивается быстрым показом серии слегка отличающихся друг от друга изображений. Мозг человека воспринимает набор изображений как одну непрерывно изменяющуюся картинку. В фильме эта имитация создается за счет применения камер, записывающих множество фотографий (кадров) в секунду. При воспроизведении кадров проектором зрители видят движущееся изображение.  
  
 Анимация на компьютере выполняется по аналогичному принципу. Например, программа, в которой реализуется исчезновение прямоугольника, может работать следующим образом.  
  
-   В программе создается таймер.  
  
-   Через заданные временные интервалы проверяется значение таймера для определения истекшего времени.  
  
-   При каждой проверке значения таймера вычисляется текущее значение непрозрачности для прямоугольника в зависимости от прошедшего времени.  
  
-   Затем программа обновляет прямоугольник с использованием нового значения и перерисовывает его.  
  
 До версии WPF, Microsoft Windows разработчикам приходится создавать и управлять собственные системы управления временем либо использовать специальные пользовательские библиотеки. WPF включает в себя эффективная система контроля времени, предоставляется с помощью управляемого кода и XAML и которые тесно интегрированы в WPF framework. WPF анимация упрощает анимацию элементов управления и других графических объектов.  
  
 WPF обрабатывает все внутренние процессы управления системой времени и перерисовки экрана эффективно. Предоставляются классы контроля времени, позволяющие сосредоточиться на создаваемых эффектах, а не на механике их реализации. WPF также упрощает создание собственной анимации, предоставляя доступ к базовым классам анимации, из которых пользовательские классы могут наследовать, для создания пользовательской анимации. По сравнению со стандартными пользовательские классы анимации обеспечивают большое преимущество в производительности.  
  
<a name="thewpftimingsystem"></a>   
## <a name="wpf-property-animation-system"></a>Система анимации свойств WPF  
 Если вы понимаете основные понятия системы управления временем WPF анимация может быть проще в использовании. Наиболее важно то, что в WPF, анимация объектов осуществляется путем применения анимации к свойствам этих объектов. Например, чтобы увеличить размер элемента среды, следует анимировать его <xref:System.Windows.FrameworkElement.Width%2A> и <xref:System.Windows.FrameworkElement.Height%2A> свойства. Чтобы скрыть объект из представления, следует анимировать его <xref:System.Windows.UIElement.Opacity%2A> свойство.  
  
 Свойство, поддерживающее анимацию, должно удовлетворять следующим трем требованиям.  
  
-   Свойство является свойством зависимостей.  
  
-   Он должен входить в класс, наследуемый от <xref:System.Windows.DependencyObject> и реализует <xref:System.Windows.Media.Animation.IAnimatable> интерфейс.  
  
-   Доступен совместимый тип анимации. (Если WPF не предоставляет его, вы можете создать свой собственный. См. в разделе [Общие сведения о пользовательской анимации](custom-animations-overview.md).)  
  
 WPF содержит множество объектов, имеющих <xref:System.Windows.Media.Animation.IAnimatable> свойства. Элементы управления, например <xref:System.Windows.Controls.Button> и <xref:System.Windows.Controls.TabControl>, а также <xref:System.Windows.Controls.Panel> и <xref:System.Windows.Shapes.Shape> объекты наследуют от <xref:System.Windows.DependencyObject>. Большинство их свойств являются свойствами зависимостей.  
  
 Анимацию можно использовать практически везде, где используются стили и шаблоны элементов управления. Анимация не обязательно должна быть визуальной; можно анимировать и объекты, не являющиеся частью пользовательского интерфейса, если они соответствуют описанным в этом разделе условиям.  
  
<a name="storyboardwalkthrough"></a>   
## <a name="example-make-an-element-fade-in-and-out-of-view"></a>Пример Сделать элемент исчезания и  
 В этом примере показано, как использовать WPF анимации для анимации значения свойства зависимостей. Она использует <xref:System.Windows.Media.Animation.DoubleAnimation>, который является типом анимации, создающий <xref:System.Double> значения для анимации <xref:System.Windows.UIElement.Opacity%2A> свойство <xref:System.Windows.Shapes.Rectangle>. В результате <xref:System.Windows.Shapes.Rectangle> исчезает и появляется.  
  
 В первой части примера создается <xref:System.Windows.Shapes.Rectangle> элемент. Описанные ниже шаги показывают, как создание анимации и применить его в прямоугольник <xref:System.Windows.UIElement.Opacity%2A> свойство.
  
 Далее показано, как создать <xref:System.Windows.Shapes.Rectangle> элемент <xref:System.Windows.Controls.StackPanel> в XAML.  
  
 [!code-xaml[animation_ovws2#RectangleOpacityFadeExampleXaml_1](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws2/CSharp/Window1.xaml#rectangleopacityfadeexamplexaml_1)]  
  
 Далее показано, как создать <xref:System.Windows.Shapes.Rectangle> элемент <xref:System.Windows.Controls.StackPanel> в коде.  
  
 [!code-csharp[animation_ovws2#RectangleOpacityFadeExampleCode_1](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws2/CSharp/Class1.cs#rectangleopacityfadeexamplecode_1)]
   
  
<a name="opacity_animation_step1"></a>   
### <a name="part-1-create-a-doubleanimation"></a>Часть 1. Создание объекта DoubleAnimation  
 Одним из способов создания исчезновения и появления элемента является анимация его <xref:System.Windows.UIElement.Opacity%2A> свойство. Так как <xref:System.Windows.UIElement.Opacity%2A> свойство имеет тип <xref:System.Double>, вам потребуется анимацию, создающую значения типа double. Объект <xref:System.Windows.Media.Animation.DoubleAnimation> является одна анимация. Объект <xref:System.Windows.Media.Animation.DoubleAnimation> создает переход между двумя значениями типа double. Чтобы указать начальное значение, необходимо задать его <xref:System.Windows.Media.Animation.DoubleAnimation.From%2A> свойство. Чтобы задать конечное значение, задайте его <xref:System.Windows.Media.Animation.DoubleAnimation.To%2A> свойство.  
  
1. Значение непрозрачности `1.0` делает объект полностью непрозрачным, а значение непрозрачности `0.0` полностью невидимым. Чтобы реализовать анимацию перехода от `1.0` для `0.0` задаются его <xref:System.Windows.Media.Animation.DoubleAnimation.From%2A> свойства `1.0` и его <xref:System.Windows.Media.Animation.DoubleAnimation.To%2A> свойства `0.0`. Далее показано, как создать <xref:System.Windows.Media.Animation.DoubleAnimation> в XAML.  
  
     [!code-xaml[animation_ovws2#RectangleOpacityFadeExampleXaml_2](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws2/CSharp/Window1.xaml#rectangleopacityfadeexamplexaml_2)]  
  
     Далее показано, как создать <xref:System.Windows.Media.Animation.DoubleAnimation> в коде.  
  
     [!code-csharp[animation_ovws2#RectangleOpacityFadeExampleCode_2](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws2/CSharp/Class1.cs#rectangleopacityfadeexamplecode_2)]
       
  
2. Далее необходимо указать <xref:System.Windows.Media.Animation.Timeline.Duration%2A>. <xref:System.Windows.Media.Animation.Timeline.Duration%2A> Анимации определяет время, необходимое для перехода от начального к конечному значению. Далее показано, как задать <xref:System.Windows.Media.Animation.Timeline.Duration%2A> значение пяти секунд в XAML.  
  
     [!code-xaml[animation_ovws2#RectangleOpacityFadeExampleXaml_3](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws2/CSharp/Window1.xaml#rectangleopacityfadeexamplexaml_3)]  
  
     Далее показано, как задать <xref:System.Windows.Media.Animation.Timeline.Duration%2A> значение пяти секунд в коде.  
  
     [!code-csharp[animation_ovws2#RectangleOpacityFadeExampleCode_3](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws2/CSharp/Class1.cs#rectangleopacityfadeexamplecode_3)]
       
  
3. В предыдущем примере была анимации, которая переходит из `1.0` для `0.0`, чего исчезают из полностью непрозрачными реализуется целевого элемента. Чтобы отобразить элемент обратно в представление после его исчезновения, установите <xref:System.Windows.Media.Animation.Timeline.AutoReverse%2A> свойство для анимации, которую `true`. Чтобы циклически повторять анимацию бесконечно, задайте его <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A> свойства <xref:System.Windows.Media.Animation.RepeatBehavior.Forever%2A>. Далее показано, как задать <xref:System.Windows.Media.Animation.Timeline.AutoReverse%2A> и <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A> свойства в XAML.  
  
     [!code-xaml[animation_ovws2#RectangleOpacityFadeExampleXaml_4](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws2/CSharp/Window1.xaml#rectangleopacityfadeexamplexaml_4)]  
  
     Далее показано, как задать <xref:System.Windows.Media.Animation.Timeline.AutoReverse%2A> и <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A> свойства в коде.  
  
     [!code-csharp[animation_ovws2#RectangleOpacityFadeExampleCode_4](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws2/CSharp/Class1.cs#rectangleopacityfadeexamplecode_4)]
       
  
<a name="opacity_animation_step2"></a>   
### <a name="part-2-create-a-storyboard"></a>Часть 2. Создать раскадровку  
 Чтобы применить анимацию к объекту, создайте <xref:System.Windows.Media.Animation.Storyboard> и использовать <xref:System.Windows.Media.Animation.Storyboard.TargetName%2A> и <xref:System.Windows.Media.Animation.Storyboard.TargetProperty> присоединенного свойства для указания объекта и анимируемое свойство.  
  
1. Создание <xref:System.Windows.Media.Animation.Storyboard> и добавьте ее в качестве дочернего. Далее показано, как создать <xref:System.Windows.Media.Animation.Storyboard> в XAML.  
  
     [!code-xaml[animation_ovws2#RectangleOpacityFadeExampleXaml_5](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws2/CSharp/Window1.xaml#rectangleopacityfadeexamplexaml_5)]    
  
     Чтобы создать <xref:System.Windows.Media.Animation.Storyboard> в коде объявите <xref:System.Windows.Media.Animation.Storyboard> переменных на уровне класса.  
  
     [!code-csharp[animation_ovws2#RectangleOpacityFadeExampleCode_100](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws2/CSharp/MainWindow.xaml.cs#rectangleopacityfadeexamplecode_100)]
       
  
     Затем инициализируйте <xref:System.Windows.Media.Animation.Storyboard> и добавьте ее в качестве дочернего.  
  
     [!code-csharp[animation_ovws2#RectangleOpacityFadeExampleCode_101](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws2/CSharp/MainWindow.xaml.cs#rectangleopacityfadeexamplecode_101)]
       
  
2. <xref:System.Windows.Media.Animation.Storyboard> Должен знать, где применяется анимация. Используйте <xref:System.Windows.Media.Animation.Storyboard.TargetName%2A?displayProperty=nameWithType> присоединенного свойства для указания объекта для анимации. Далее показано, как задать целевое имя <xref:System.Windows.Media.Animation.DoubleAnimation> для `MyRectangle` в XAML.  
  
     [!code-xaml[animation_ovws2#RectangleOpacityFadeExampleXaml_6](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws2/CSharp/Window1.xaml#rectangleopacityfadeexamplexaml_6)]  
  
     Далее показано, как задать целевое имя <xref:System.Windows.Media.Animation.DoubleAnimation> для `MyRectangle` в коде.  
  
     [!code-csharp[animation_ovws2#RectangleOpacityFadeExampleCode_102](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws2/CSharp/MainWindow.xaml.cs#rectangleopacityfadeexamplecode_102)]
       
  
3. Используйте <xref:System.Windows.Media.Animation.Storyboard.TargetProperty> вложенное свойство, чтобы указать анимируемое свойство. Далее показано, как настроить анимацию к целевому объекту <xref:System.Windows.UIElement.Opacity%2A> свойство <xref:System.Windows.Shapes.Rectangle> в XAML.
  
     [!code-xaml[animation_ovws2#RectangleOpacityFadeExampleXaml_7](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws2/CSharp/Window1.xaml#rectangleopacityfadeexamplexaml_7)]  
  
     Далее показано, как настроить анимацию к целевому объекту <xref:System.Windows.UIElement.Opacity%2A> свойство <xref:System.Windows.Shapes.Rectangle> в коде.  
  
     [!code-csharp[animation_ovws2#RectangleOpacityFadeExampleCode_103](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws2/CSharp/MainWindow.xaml.cs#rectangleopacityfadeexamplecode_103)]
       
  
 Дополнительные сведения о <xref:System.Windows.Media.Animation.Storyboard.TargetProperty> синтаксис и Дополнительные примеры см. в разделе [Общие сведения о раскадровках](storyboards-overview.md).  
  
<a name="opacity_animation_step3"></a>   
### <a name="part-3-xaml-associate-the-storyboard-with-a-trigger"></a>Часть 3 (XAML). Связать раскадровки с триггером  
 Самый простой способ применить и запустить <xref:System.Windows.Media.Animation.Storyboard> в XAML является использование триггера событий. В этом разделе показано, как связать <xref:System.Windows.Media.Animation.Storyboard> с триггером в XAML.  
  
1. Создание <xref:System.Windows.Media.Animation.BeginStoryboard> и свяжите с ним раскадровки. Объект <xref:System.Windows.Media.Animation.BeginStoryboard> — это разновидность <xref:System.Windows.TriggerAction> , применения и запуска <xref:System.Windows.Media.Animation.Storyboard>.  
  
     [!code-xaml[animation_ovws_snippet#RectangleOpacityFadeExampleInline_3](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws_snippet/CS/RectangleOpacityFadeExample.xaml#rectangleopacityfadeexampleinline_3)]  
  
2. Создание <xref:System.Windows.EventTrigger> и добавьте <xref:System.Windows.Media.Animation.BeginStoryboard> для его <xref:System.Windows.EventTrigger.Actions%2A> коллекции. Задайте <xref:System.Windows.EventTrigger.RoutedEvent%2A> свойство <xref:System.Windows.EventTrigger> на перенаправленное событие, которое вы хотите начать <xref:System.Windows.Media.Animation.Storyboard>. (Дополнительные сведения о перенаправленных событиях см. в разделе [Routed Events Overview](../advanced/routed-events-overview.md).)  
  
     [!code-xaml[animation_ovws_snippet#RectangleOpacityFadeExampleInline_2](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws_snippet/CS/RectangleOpacityFadeExample.xaml#rectangleopacityfadeexampleinline_2)]  
  
3. Добавить <xref:System.Windows.EventTrigger> для <xref:System.Windows.FrameworkElement.Triggers%2A> коллекции прямоугольника.  
  
     [!code-xaml[animation_ovws_snippet#RectangleOpacityFadeExampleInline_1](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws_snippet/CS/RectangleOpacityFadeExample.xaml#rectangleopacityfadeexampleinline_1)]  
  
<a name="opacity_animation_step3code"></a>   
### <a name="part-3-code-associate-the-storyboard-with-an-event-handler"></a>Часть 3 (код). Связывание раскадровки с обработчиком событий  
 Самый простой способ применить и запустить <xref:System.Windows.Media.Animation.Storyboard> в коде является использование обработчика событий. В этом разделе показано, как связать <xref:System.Windows.Media.Animation.Storyboard> с обработчиком событий в коде.  
  
1. Зарегистрируйтесь для <xref:System.Windows.FrameworkElement.Loaded> событий прямоугольника.  
  
     [!code-csharp[animation_ovws2#RectangleOpacityFadeExampleCode_104](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws2/CSharp/MainWindow.xaml.cs#rectangleopacityfadeexamplecode_104)]
       
  
2. Объявите обработчик событий. В обработчике событий используйте <xref:System.Windows.Media.Animation.Storyboard.Begin%2A> метод для применения раскадровки.  
  
     [!code-csharp[animation_ovws2#RectangleOpacityFadeExampleCode_105](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws2/CSharp/MainWindow.xaml.cs#rectangleopacityfadeexamplecode_105)]
       
  
### <a name="complete-example"></a>Полный пример  
 Ниже показано, как создать прямоугольник, который исчезает и в XAML появляется.  
  
 [!code-xaml[animation_ovws2#RectangleOpacityFadeExampleXaml](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws2/CSharp/MainWindow.xaml#rectangleopacityfadeexamplexaml)]  
  
 Далее показано, как создать прямоугольник, который исчезает и появляется, в коде.  
  
 [!code-csharp[animation_ovws2#RectangleOpacityFadeExampleCode](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws2/CSharp/MainWindow.xaml.cs#rectangleopacityfadeexamplecode)]
   
  
<a name="animationtypes"></a>   
## <a name="animation-types"></a>Типы анимации  
 Поскольку анимация создает значения свойств, для различных типов свойств существуют различные типы анимации. Для анимации свойства, которое принимает <xref:System.Double>, такие как <xref:System.Windows.FrameworkElement.Width%2A> свойства элемента, используйте анимацию, создающую <xref:System.Double> значения. Для анимации свойства, которое принимает <xref:System.Windows.Point>, используйте анимацию, создающую <xref:System.Windows.Point> значений и т. д. Из-за количества различных типов свойств, имеется несколько классов анимации в <xref:System.Windows.Media.Animation> пространства имен. Имена классов следуют строгому соглашению, благодаря чему их легко различать.  
  
-   \<*Тип*> анимации  
  
     Такая анимация называется "базовой" (или From/To/By) и производится либо от начального до конечного значения, либо посредством добавления значения смещения к начальному значению.  
  
    -   Чтобы установить начальное значение, присвойте значение свойству From анимации.  
  
    -   Чтобы установить конечное значение, присвойте значение свойству To анимации.  
  
    -   Чтобы установить значение смещения, присвойте значение свойству By анимации.  
  
     В примерах этого раздела используются анимации этого класса, поскольку они являются наиболее простыми в использовании. Анимации From/To/By подробно описываются в обзоре класса анимации.  
  
-   \<*Тип*> AnimationUsingKeyFrames  
  
     Анимация с использованием ключевых кадров является более эффективным средством, чем анимация класса From/To/By, поскольку при ее использовании можно задать любое число конечных значений, а также управлять методами их интерполяции. Некоторые типы могут быть анимированы только с помощью анимации с ключевыми кадрами. По ключевым кадрам описываются подробно в [сведения об анимации по ключевым кадрам](key-frame-animations-overview.md).  
  
-   \<*Тип*> AnimationUsingPath  
  
     Анимация с использованием пути позволяет использовать геометрический путь для создания анимации значений.  
  
-   \<*Тип*> AnimationBase  
  
     Абстрактный класс, при реализации которого анимируется \< *тип*> значение. Этот класс служит базовым классом для \< *тип*> анимации и \< *тип*> AnimationUsingKeyFrames классы. Эти классы используются непосредственно только для создания пользовательской анимации. В противном случае используйте \< *тип*> Animation или KeyFrame\<*тип*> анимации.  
  
 В большинстве случаев требуется использовать \< *тип*> классы анимации, например <xref:System.Windows.Media.Animation.DoubleAnimation> и <xref:System.Windows.Media.Animation.ColorAnimation>.  
  
 В следующей таблице приведены несколько общих типов анимации, а также некоторые свойства, с которыми они используются.  
  
|Тип свойства|Соответствующая базовая (From/To/By) анимация|Соответствующая анимация с ключевыми кадрами|Соответствующая анимация с использованием пути|Пример использования|  
|-------------------|----------------------------------------------------|---------------------------------------|----------------------------------|-------------------|  
|<xref:System.Windows.Media.Color>|<xref:System.Windows.Media.Animation.ColorAnimation>|<xref:System.Windows.Media.Animation.ColorAnimationUsingKeyFrames>|Нет|Анимация <xref:System.Windows.Media.SolidColorBrush.Color%2A> из <xref:System.Windows.Media.SolidColorBrush> или <xref:System.Windows.Media.GradientStop>.|  
|<xref:System.Double>|<xref:System.Windows.Media.Animation.DoubleAnimation>|<xref:System.Windows.Media.Animation.DoubleAnimationUsingKeyFrames>|<xref:System.Windows.Media.Animation.DoubleAnimationUsingPath>|Анимация <xref:System.Windows.FrameworkElement.Width%2A> из <xref:System.Windows.Controls.DockPanel> или <xref:System.Windows.FrameworkElement.Height%2A> из <xref:System.Windows.Controls.Button>.|  
|<xref:System.Windows.Point>|<xref:System.Windows.Media.Animation.PointAnimation>|<xref:System.Windows.Media.Animation.PointAnimationUsingKeyFrames>|<xref:System.Windows.Media.Animation.PointAnimationUsingPath>|Анимация <xref:System.Windows.Media.EllipseGeometry.Center%2A> положение элемента <xref:System.Windows.Media.EllipseGeometry>.|  
|<xref:System.String>|Нет|<xref:System.Windows.Media.Animation.StringAnimationUsingKeyFrames>|Нет|Анимация <xref:System.Windows.Controls.TextBlock.Text%2A> из <xref:System.Windows.Controls.TextBlock> или <xref:System.Windows.Controls.ContentControl.Content%2A> из <xref:System.Windows.Controls.Button>.|  
  
<a name="animationsaretimelines"></a>   
### <a name="animations-are-timelines"></a>Анимации представляет собой шкалу времени  
 Все типы анимации наследуют от <xref:System.Windows.Media.Animation.Timeline> класса; таким образом, все анимации будут специализированными типами шкалы времени. Объект <xref:System.Windows.Media.Animation.Timeline> определяет сегмент времени. Можно указать *характер поведения* временной шкалы: ее <xref:System.Windows.Media.Animation.Timeline.Duration%2A>, сколько раз это и даже скорость течения времени для него.  
  
 Поскольку анимация принадлежит <xref:System.Windows.Media.Animation.Timeline>, он также представляет сегмент времени. Анимации также вычисляются выходные значения по мере прохождения заданных сегментов времени (или <xref:System.Windows.Media.Animation.Timeline.Duration%2A>). По мере выполнения (воспроизведения) анимации обновляется свойство, с которым она связана.  
  
 Три часто используются свойства времени <xref:System.Windows.Media.Animation.Timeline.Duration%2A>, <xref:System.Windows.Media.Animation.Timeline.AutoReverse%2A>, и <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A>.  
  
#### <a name="the-duration-property"></a>Свойство Duration  
 Как упоминалось ранее, временная шкала представляет собой сегмент времени. Длина этого сегмента определяется <xref:System.Windows.Media.Animation.Timeline.Duration%2A> временной шкалы, которое обычно задается с помощью <xref:System.Windows.Duration.TimeSpan%2A> значение. По достижении конца временной шкалы времени ее выполнение завершается.  
  
 Анимация использует его <xref:System.Windows.Media.Animation.Timeline.Duration%2A> свойство для определения текущего значения. Если вы не укажете <xref:System.Windows.Media.Animation.Timeline.Duration%2A> значение для анимации, он использует 1 секунды, по умолчанию.  
  
 Следующий синтаксис показывает упрощенную версию XAML синтаксис для атрибута <xref:System.Windows.Media.Animation.Timeline.Duration%2A> свойство.  
  
*часы* `:` *минуты* `:` *секунды*
  
 В следующей таблице показаны несколько <xref:System.Windows.Duration> параметры и возвращаемые ими значения.  
  
|Параметр|Возвращаемое значение|  
|-------------|---------------------|  
|0:0:5.5|5,5 секунды.|  
|0:30:5.5|30 минут и 5,5 секунды.|  
|1:30:5.5|1 час, 30 минут и 5,5 секунды.|  
  
 Один из способов для указания <xref:System.Windows.Duration> в коде является использование <xref:System.TimeSpan.FromSeconds%2A> метод для создания <xref:System.TimeSpan>, чего объявляется новая <xref:System.Windows.Duration> структуры с помощью, <xref:System.TimeSpan>.  
  
 Дополнительные сведения о <xref:System.Windows.Duration> значения и полный XAML синтаксис, см. в разделе <xref:System.Windows.Duration> структуры.  
  
#### <a name="autoreverse"></a>Свойство AutoReverse  
 <xref:System.Windows.Media.Animation.Timeline.AutoReverse%2A> Свойство указывает, является ли воспроизведение временной шкалы по достижении конца ее <xref:System.Windows.Media.Animation.Timeline.Duration%2A>. Если значение этого свойства анимации значение `true`, обращает анимации при достижении конца ее <xref:System.Windows.Media.Animation.Timeline.Duration%2A>воспроизведение от конечного значения к начальному значению. По умолчанию это свойство имеет `false`.  
  
#### <a name="repeatbehavior"></a>RepeatBehavior  
 <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A> Свойство определяет количество воспроизведений временной шкалы. По умолчанию временные шкалы имеют число итераций `1.0`, означающее, воспроизведение происходит один раз и не повторяется.  
  
 Дополнительные сведения об этих и других свойствах см. в разделе [Общие сведения о характере поведения](timing-behaviors-overview.md).  
  
<a name="applyanimationstoproperty"></a>   
## <a name="applying-an-animation-to-a-property"></a>Применение анимации к свойству  
 В предыдущих разделах описаны различные типы анимации и их свойства времени. В этом подразделе показано, как применить анимацию к свойству. <xref:System.Windows.Media.Animation.Storyboard> объекты предоставляют один из способов применения анимации к свойствам. Объект <xref:System.Windows.Media.Animation.Storyboard> — *временной шкалы контейнера* , предоставляющей сведения об анимации, которую она содержит.  
  
### <a name="targeting-objects-and-properties"></a>Целевые объекты и свойства  
 <xref:System.Windows.Media.Animation.Storyboard> Класс предоставляет <xref:System.Windows.Media.Animation.Storyboard.TargetName%2A> и <xref:System.Windows.Media.Animation.Storyboard.TargetProperty> присоединенных свойств. Эти свойства определяют анимируемые объекты. Чтобы использовать объект в качестве целевого объекта анимации, обычно следует присвоить ему имя.  
  
 Назначение имени для <xref:System.Windows.FrameworkElement> отличается от присваивания имени <xref:System.Windows.Freezable> объекта. Большинство элементов управления и панелей являются элементами среды. Однако большинство чисто графических объектов, в том числе кисти, преобразования и геометрические объекты, являются фиксируемыми объектами. Если вы не уверены, является ли тип <xref:System.Windows.FrameworkElement> или <xref:System.Windows.Freezable>, см. **иерархии наследования** разделе данной справочной документации.  
  
-   Чтобы сделать <xref:System.Windows.FrameworkElement> целевого объекта анимации, присвойте его имя, задав его <xref:System.Windows.FrameworkElement.Name%2A> свойство. В коде, необходимо также использовать <xref:System.Windows.FrameworkElement.RegisterName%2A> метод для регистрации имени элемента на странице, к которой он принадлежит.  
  
-   Чтобы сделать <xref:System.Windows.Freezable> объект целевого объекта анимации в XAML, использовании [директива x: Name](../../xaml-services/x-name-directive.md) присвоить имя. В коде, можно просто использовать <xref:System.Windows.FrameworkElement.RegisterName%2A> метод для регистрации объекта на странице, к которой он принадлежит.  
  
 В последующих разделах приводится пример присваивания имени элементу в XAML и кода. Более подробные сведения об именовании и определение целевых объектов см. в разделе [Общие сведения о раскадровках](storyboards-overview.md).  
  
### <a name="applying-and-starting-storyboards"></a>Применение и запуск раскадровки  
 Чтобы запустить раскадровку XAML, необходимо связать его с <xref:System.Windows.EventTrigger>. <xref:System.Windows.EventTrigger> Является объектом, описывающим, какие действия следует предпринять при возникновении указанного события. Одно из этих действий может быть <xref:System.Windows.Media.Animation.BeginStoryboard> действие, которое используется для запуска раскадровки. Триггеры событий по концепции аналогичны обработчикам событий, так как они позволяют задать реакцию приложения на конкретное событие. В отличие от обработчиков событий триггеры событий могут быть полностью описаны в XAML; никакой другой код является обязательным.  
  
 Чтобы запустить <xref:System.Windows.Media.Animation.Storyboard> в коде, можно использовать <xref:System.Windows.EventTrigger> или использовать <xref:System.Windows.Media.Animation.Storyboard.Begin%2A> метод <xref:System.Windows.Media.Animation.Storyboard> класса.  
  
<a name="controllingstoryboards"></a>   
## <a name="interactively-control-a-storyboard"></a>Интерактивное управление раскадровкой  
 В предыдущем примере показан запуск <xref:System.Windows.Media.Animation.Storyboard> при наступлении определенного события. Вы можете управлять в интерактивном режиме <xref:System.Windows.Media.Animation.Storyboard> после ее запуска: можно приостановить, возобновить, остановить, перейти к периоду заполнения, поиска и удалить <xref:System.Windows.Media.Animation.Storyboard>. Дополнительные сведения и пример, в котором показано, как управлять в интерактивном режиме <xref:System.Windows.Media.Animation.Storyboard>, см. в разделе [Общие сведения о раскадровках](storyboards-overview.md).  
  
<a name="fillbehaviorsection"></a>   
## <a name="what-happens-after-an-animation-ends"></a>Что происходит по завершении анимации?  
 <xref:System.Windows.Media.Animation.FillBehavior> Свойство определяет поведение временной шкалы по ее завершении. По умолчанию запускается временная шкала <xref:System.Windows.Media.Animation.ClockState.Filling> при ее окончании. Анимации, которая является <xref:System.Windows.Media.Animation.ClockState.Filling> содержит конечное значение.  
  
 <xref:System.Windows.Media.Animation.DoubleAnimation> В предыдущем примере не заканчивается, поскольку его <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A> свойству <xref:System.Windows.Media.Animation.RepeatBehavior.Forever%2A>. В следующем примере прямоугольник анимируется с помощью аналогичной анимации. В отличие от предыдущего примера <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A> и <xref:System.Windows.Media.Animation.Timeline.AutoReverse%2A> свойств этой анимации остаются значения по умолчанию. Таким образом, анимация выполняется от 1 до 0 в течение пяти секунд, а затем останавливается.  
  
 [!code-xaml[animation_ovws_snippet#FillBehaviorExampleRectangleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws_snippet/CS/FillBehaviorExample.xaml#fillbehaviorexamplerectangleinline)]  
  
 [!code-csharp[animation_ovws_procedural_snip#FillBehaviorExampleRectangleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws_procedural_snip/CSharp/FillBehaviorExample.cs#fillbehaviorexamplerectangleinline)]
   
  
 Так как его <xref:System.Windows.Media.Animation.Timeline.FillBehavior%2A> не был изменен со значения по умолчанию, который является <xref:System.Windows.Media.Animation.FillBehavior.HoldEnd>, анимации сохраняется ее конечное значение 0, по ее завершении. Таким образом <xref:System.Windows.UIElement.Opacity%2A> прямоугольника в 0 после анимация завершается. Если задать <xref:System.Windows.UIElement.Opacity%2A> прямоугольника с другим значением, видимых не произойдет, поскольку по-прежнему управляется анимацией <xref:System.Windows.UIElement.Opacity%2A> свойство.  
  
 Один из способов, чтобы возвратить управление анимированным свойством в коде является использование <xref:System.Windows.Media.Animation.Animatable.BeginAnimation%2A> метод и указать значение null для <xref:System.Windows.Media.Animation.AnimationTimeline> параметра. Дополнительные сведения и пример см. в разделе [Установка свойства после его анимации с помощью раскадровки](how-to-set-a-property-after-animating-it-with-a-storyboard.md).  
  
 Обратите внимание, что, несмотря на то, что установка значения свойства, имеет <xref:System.Windows.Media.Animation.ClockState.Active> или <xref:System.Windows.Media.Animation.ClockState.Filling> анимации, по-видимому, не влияют, измените значение свойства. Дополнительные сведения см. в разделе [анимации и общие сведения о характере системы](animation-and-timing-system-overview.md).  
  
<a name="databindingAndAnimatingAnimationsSection"></a>   
## <a name="data-binding-and-animating-animations"></a>Привязка данных и анимирование анимации  
 Большинство свойств анимации могут быть связаны с данными либо анимированы. Например, можно анимировать <xref:System.Windows.Media.Animation.Timeline.Duration%2A> свойство <xref:System.Windows.Media.Animation.DoubleAnimation>. Однако в связи с особенностями работы системы времени поведение привязки данных или анимированных анимаций отличается от других случаев привязки данных и анимирования объектов. Чтобы понять их поведение, следует понять значение применения анимации к свойству.  
  
 В примере в предыдущем разделе, демонстрируется порядок анимации <xref:System.Windows.UIElement.Opacity%2A> прямоугольника. При загрузке прямоугольника в предыдущем примере его обработчик событий применяет <xref:System.Windows.Media.Animation.Storyboard>. Система времени создает копию объекта <xref:System.Windows.Media.Animation.Storyboard> и его анимации. Эти копии фиксируются (доступным только для чтения) и <xref:System.Windows.Media.Animation.Clock> на их основе создаются объекты. Эти объекты используются для выполнения фактических действий по анимации целевых свойств.  
  
 В системе времени создаются часы для <xref:System.Windows.Media.Animation.DoubleAnimation> и применяет его к объекту и свойству, которое определяется <xref:System.Windows.Media.Animation.Storyboard.TargetName%2A> и <xref:System.Windows.Media.Animation.Storyboard.TargetProperty> из <xref:System.Windows.Media.Animation.DoubleAnimation>. В этом случае система времени применяет часы к <xref:System.Windows.UIElement.Opacity%2A> свойство объекта, который называется «MyRectangle.»  
  
 Несмотря на то, что часы также создаются для <xref:System.Windows.Media.Animation.Storyboard>, часы не применяются к его свойствам. Он предназначен для управления его дочерних часами, которая создается для <xref:System.Windows.Media.Animation.DoubleAnimation>.  
  
 Для отражения анимацией привязки данных или изменений анимации следует обновить ее часы. Автоматическое повторное создание часов не выполняется. Чтобы отразить изменения в анимации, повторно примените соответствующую раскадровку с помощью <xref:System.Windows.Media.Animation.BeginStoryboard> или <xref:System.Windows.Media.Animation.Storyboard.Begin%2A> метод. При использовании любого из этих методов анимация запускается повторно. В коде, можно использовать <xref:System.Windows.Media.Animation.Storyboard.Seek%2A> метод для раскадровки обратно в предыдущее положение.  
  
 Для примера данных, привязанного к анимации, см. в разделе [Key Spline Animation Sample](https://go.microsoft.com/fwlink/?LinkID=160011). Дополнительные сведения о работе анимации и системы времени см. в разделе [анимации и общие сведения о характере системы](animation-and-timing-system-overview.md).  
  
<a name="otherWaysToAnimateSection"></a>   
## <a name="other-ways-to-animate"></a>Другие способы анимации  
 В примерах этого раздела демонстрируется анимация с помощью раскадровок. При использовании кода можно выполнять анимацию различными способами. Дополнительные сведения см. в разделе [Общие сведения о методах анимации свойств](property-animation-techniques-overview.md).  
  
<a name="animation_samples"></a>   
## <a name="animation-samples"></a>Примеры анимации  
 В следующих примерах описывается порядок добавления анимации в приложения.  
  
-   [FROM, To и пример целевых значений анимации](https://go.microsoft.com/fwlink/?LinkID=159988)  
  
     Описание различных параметров анимации From/To/By.  
  
-   [Пример поведения анимации времени](https://go.microsoft.com/fwlink/?LinkID=159970)  
  
     Описание способов управления поведением анимации во времени. В этом примере также описывается порядок привязки данных для конечного значения анимации.  
  
<a name="related_topics"></a>   
## <a name="related-topics"></a>См. также  
  
|Заголовок|Описание|  
|-----------|-----------------|  
|[Общие сведения об анимации и системе управления временем](animation-and-timing-system-overview.md)|Описывает, как система управления временем использует <xref:System.Windows.Media.Animation.Timeline> и <xref:System.Windows.Media.Animation.Clock> классы, которые позволяют создавать анимации.|  
|[Советы и рекомендации по анимации](animation-tips-and-tricks.md)|Список полезных советов по устранению проблем с анимацией, например проблем производительности.|  
|[Общие сведения о пользовательской анимации](custom-animations-overview.md)|Описание способов расширения системы анимации полными кадрами, классами анимации и покадровым обратным вызовом.|  
|Общие сведения об анимациях From/To/By|Описание способов создания анимации, которая переходит между двумя значениями.|  
|[Общие сведения об анимации по ключевым кадрам](key-frame-animations-overview.md)|Описание способов создания анимации с несколькими целевыми значениями, включая возможность управления методом интерполяции.|  
|[Функции плавности](easing-functions.md)|Описание способов применения математических формул к анимациям для получения реалистичного поведения, такого как подскок.|  
|[Общие сведения об анимация с использованием пути](path-animations-overview.md)|Описание способов перемещения или поворота объекта по сложному пути.|  
|[Общие сведения о методах анимации свойств](property-animation-techniques-overview.md)|Описание анимации свойств с помощью раскадровок, локальных анимаций, часов и покадровой анимации.|  
|[Общие сведения о Storyboard](storyboards-overview.md)|Описание способов использования раскадровок с несколькими временными шкалами для создания сложных анимаций.|  
|[Общие сведения о характере поведения во времени](timing-behaviors-overview.md)|Описывает <xref:System.Windows.Media.Animation.Timeline> типов и свойств, используемых в анимации.|  
|[Общие сведения о временных событиях](timing-events-overview.md)|Описывает события, доступные на <xref:System.Windows.Media.Animation.Timeline> и <xref:System.Windows.Media.Animation.Clock> объектов для выполнения кода в точках временной шкалы, такие как начать, приостановить, возобновить, пропустить или остановить.|  
|[Практические руководства](animation-and-timing-how-to-topics.md)|Примеры кода для использования анимаций и временных шкал в приложении.|  
|[Разделы руководства, посвященные часам](clocks-how-to-topics.md)|Примеры кода для использования <xref:System.Windows.Media.Animation.Clock> объекта в приложении.|  
|[Практические руководства, посвященные анимации по ключевым кадрам](key-frame-animation-how-to-topics.md)|Примеры кода для использования покадровой анимации в приложении.|  
|[Практические руководства, посвященные анимации пути](path-animation-how-to-topics.md)|Примеры кода для применения анимации с использованием пути в приложении.|  
  
<a name="reference"></a>   
## <a name="reference"></a>Ссылка  
 <xref:System.Windows.Media.Animation.Timeline>  
  
 <xref:System.Windows.Media.Animation.Storyboard>  
  
 <xref:System.Windows.Media.Animation.BeginStoryboard>  
  
 <xref:System.Windows.Media.Animation.Clock>

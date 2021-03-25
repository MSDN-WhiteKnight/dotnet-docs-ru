---
title: Общие сведения о Storyboard
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Storyboard syntax [WPF]
- syntax [WPF], Storyboard
- timelines [WPF]
ms.assetid: 1a698c3c-30f1-4b30-ae56-57e8a39811bd
ms.openlocfilehash: 6b178ac6b93205afebb1bea45f1b7e94826cb670
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59124843"
---
# <a name="storyboards-overview"></a>Общие сведения о Storyboard
В этом разделе показано, как использовать <xref:System.Windows.Media.Animation.Storyboard> объектов для создания и применения анимаций. Он описывает, как интерактивно манипулировать <xref:System.Windows.Media.Animation.Storyboard> объектов и описывает синтаксис косвенного выбора свойств.  
  
<a name="prerequisites"></a>   
## <a name="prerequisites"></a>Предварительные требования  
 Для понимания этого раздела необходимо ознакомиться с различными типами анимации и их основными возможностями. Общие сведения об анимации см. в разделе [Общие сведения об эффектах анимации](animation-overview.md). Вы также должны знать, как использовать вложенные свойства. Дополнительные сведения о вложенных свойствах см. в разделах [Общие сведения о вложенных свойствах](../advanced/attached-properties-overview.md).  
  
<a name="whatisatimeline"></a>   
## <a name="what-is-a-storyboard"></a>Что такое раскадровка?  
 Анимация — не единственный удобный тип временной шкалы. Существуют другие классы временной шкалы, с помощью которых вы сможете создать наборы временных шкал и применить временные шкалы к свойствам. Временные шкалы контейнера являются производными от <xref:System.Windows.Media.Animation.TimelineGroup> класса и включать <xref:System.Windows.Media.Animation.ParallelTimeline> и <xref:System.Windows.Media.Animation.Storyboard>.  
  
 Объект <xref:System.Windows.Media.Animation.Storyboard> — это тип временной шкалы контейнера, который содержит сведения для временных шкал, он содержит. Раскадровка может содержать любой тип <xref:System.Windows.Media.Animation.Timeline>, включая другие временные шкалы контейнера и анимации. <xref:System.Windows.Media.Animation.Storyboard> объекты позволяют объединять временные шкалы, которые влияют на различные объекты и свойства в одно дерево временной шкалы, упрощая организацию и управление сложным поведением времени. Например, предположим, что вам необходима кнопка, которая выполняет следующие три действия.  
  
-   Увеличивается и изменяет цвет, когда пользователь выбирает кнопку.  
  
-   Сжимается, а затем увеличивается до исходного размера, когда пользователь нажимает на кнопку.  
  
-   Сжимается и изменяет яркость до 50-процентной прозрачности, если кнопка становится недоступной.  
  
 В этом случае у вас есть несколько наборов анимаций, которые применяются к одному объекту и которые требуется воспроизводить в разное время в зависимости от состояния кнопки. <xref:System.Windows.Media.Animation.Storyboard> объекты позволяют упорядочить анимации и применить их в группах для одного или нескольких объектов.  
  
<a name="wherecanyouuseastoryboard"></a>   
## <a name="where-can-you-use-a-storyboard"></a>Где можно использовать раскадровку?  
 Объект <xref:System.Windows.Media.Animation.Storyboard> может использоваться для анимации свойства зависимостей анимируемых классов (Дополнительные сведения о том, что делает класс анимируемым, см. в разделе [Общие сведения об анимации](animation-overview.md)). Однако поскольку раскадровка является функцией уровня платформы, объект должен принадлежать к <xref:System.Windows.NameScope> из <xref:System.Windows.FrameworkElement> или <xref:System.Windows.FrameworkContentElement>.  
  
 Например, можно использовать <xref:System.Windows.Media.Animation.Storyboard> для следующих целей:  
  
-   Анимация <xref:System.Windows.Media.SolidColorBrush> (не являющийся элементом платформы), который закрашивает фон кнопки (разновидность <xref:System.Windows.FrameworkElement>),  
  
-   Анимация <xref:System.Windows.Media.SolidColorBrush> (не являющийся элементом платформы), которая закрашивает заполнения <xref:System.Windows.Media.GeometryDrawing> (не являющийся элементом платформы) отображается с помощью <xref:System.Windows.Controls.Image> (<xref:System.Windows.FrameworkElement>).  
  
-   В коде, анимация <xref:System.Windows.Media.SolidColorBrush> объявляется с помощью класса, который также содержит <xref:System.Windows.FrameworkElement>, если <xref:System.Windows.Media.SolidColorBrush> зарегистрировано, его имя <xref:System.Windows.FrameworkElement>.  
  
 Тем не менее, невозможно использовать <xref:System.Windows.Media.Animation.Storyboard> для анимации <xref:System.Windows.Media.SolidColorBrush> , не зарегистрировало его именем <xref:System.Windows.FrameworkElement> или <xref:System.Windows.FrameworkContentElement>, или который не использовался, чтобы задать свойство <xref:System.Windows.FrameworkElement> или <xref:System.Windows.FrameworkContentElement>.  
  
<a name="applyanimationswithastoryboard"></a>   
## <a name="how-to-apply-animations-with-a-storyboard"></a>Применение анимации с помощью раскадровки  
 Чтобы использовать <xref:System.Windows.Media.Animation.Storyboard> для создания и применения анимаций, можно добавить анимации в качестве дочерних временных шкал объекта <xref:System.Windows.Media.Animation.Storyboard>. <xref:System.Windows.Media.Animation.Storyboard> Класс предоставляет <xref:System.Windows.Media.Animation.Storyboard.TargetName%2A?displayProperty=nameWithType> и <xref:System.Windows.Media.Animation.Storyboard.TargetProperty?displayProperty=nameWithType> присоединенных свойств. Эти свойства используются для указания целевого объекта и целевого свойства анимации.  
  
 Чтобы применить анимацию к целевым объектам, началом <xref:System.Windows.Media.Animation.Storyboard> с помощью действия триггера или метода. В [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)], использовании <xref:System.Windows.Media.Animation.BeginStoryboard> со <xref:System.Windows.EventTrigger>, <xref:System.Windows.Trigger>, или <xref:System.Windows.DataTrigger>. В коде, можно также использовать <xref:System.Windows.Media.Animation.Storyboard.Begin%2A> метод.  
  
 В следующей таблице показаны различные где каждого <xref:System.Windows.Media.Animation.Storyboard> начать прием поддерживается: для каждого экземпляра, стиль, шаблон элемента управления и шаблон данных. Применение к конкретным экземплярам подразумевает применение анимации или раскадровки непосредственно к экземплярам объектов, а не в стилях, шаблонах элементов управления или шаблонах данных.  
  
|Раскадровка запускается с помощью метода...|Применение к конкретным экземплярам|Стиль|Шаблон элемента управления|Шаблон данных|Пример|  
|--------------------------------|-------------------|-----------|----------------------|-------------------|-------------|  
|<xref:System.Windows.Media.Animation.BeginStoryboard> и <xref:System.Windows.EventTrigger>|Да|Да|Да|Да|[Анимация свойства с помощью раскадровки](how-to-animate-a-property-by-using-a-storyboard.md)|  
|<xref:System.Windows.Media.Animation.BeginStoryboard> и свойство <xref:System.Windows.Trigger>|Нет|Да|Да|Да|[Запуск анимации при изменении значения свойства](how-to-trigger-an-animation-when-a-property-value-changes.md)|  
|<xref:System.Windows.Media.Animation.BeginStoryboard> и <xref:System.Windows.DataTrigger>|Нет|Да|Да|Да|[Практическое руководство. Запуск анимации при изменении данных](https://docs.microsoft.com/previous-versions/dotnet/netframework-3.5/aa970679(v=vs.90))|  
|<xref:System.Windows.Media.Animation.Storyboard.Begin%2A> метод|Да|Нет|Нет|Нет|[Анимация свойства с помощью раскадровки](how-to-animate-a-property-by-using-a-storyboard.md)|  
  
 В следующем примере используется <xref:System.Windows.Media.Animation.Storyboard> для анимации <xref:System.Windows.FrameworkElement.Width%2A> из <xref:System.Windows.Shapes.Rectangle> элемент и <xref:System.Windows.Media.SolidColorBrush.Color%2A> из <xref:System.Windows.Media.SolidColorBrush> используется для рисования <xref:System.Windows.Shapes.Rectangle>.  
  
 [!code-xaml[storyboards_ovw_snip_XAML#1](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip_XAML/CS/StoryboardsExample.xaml#1)]  
  
 [!code-csharp[storyboards_ovw_snip#100](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip/CSharp/StoryboardsExample.cs#100)]  
  
 В следующих разделах описываются <xref:System.Windows.Media.Animation.Storyboard.TargetName%2A> и <xref:System.Windows.Media.Animation.Storyboard.TargetProperty> присоединенных свойств более подробно.  
  
<a name="targetingelementsandfreezables"></a>   
## <a name="targeting-framework-elements-framework-content-elements-and-freezables"></a>Элементы целевой платформы, элементы содержимого платформы и объекты Freezable  
 В предыдущем разделе упоминалось, что для поиска целевого объекта анимации необходимо знать имя целевого объекта и анимируемое свойство. Указание свойства для анимации выполняется очень легко: просто задайте <xref:System.Windows.Media.Animation.Storyboard.TargetProperty?displayProperty=nameWithType> именем анимируемое свойство.  Укажите имя объекта, свойство которого вы хотите анимировать, установив <xref:System.Windows.Media.Animation.Storyboard.TargetName%2A?displayProperty=nameWithType> свойство анимации.  
  
 Для <xref:System.Windows.Setter.TargetName%2A> работы свойства целевого объекта должен иметь имя. Назначение имени для <xref:System.Windows.FrameworkElement> или <xref:System.Windows.FrameworkContentElement> в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] отличается от присваивания имени <xref:System.Windows.Freezable> объекта.  
  
 Элементами платформы являются классы, наследующие от <xref:System.Windows.FrameworkElement> класса. Примеры элементов платформы включают <xref:System.Windows.Window>, <xref:System.Windows.Controls.DockPanel>, <xref:System.Windows.Controls.Button>, и <xref:System.Windows.Shapes.Rectangle>. По существу все окна, панели и элементы управления являются элементами. Элементами содержимого платформы являются классы, наследующие от <xref:System.Windows.FrameworkContentElement> класса. Примеры элементов содержимого платформы включают <xref:System.Windows.Documents.FlowDocument> и <xref:System.Windows.Documents.Paragraph>. Если вы не уверены, что этот элемент является элементом платформы или элементом содержимого платформы, проверьте, есть ли у этого элемента свойство Name. Если есть, скорее всего, это элемент платформы или элемент содержимого платформы. Чтобы убедиться в этом, обратитесь к разделу "Иерархия наследования" на странице типа элемента.  
  
 Чтобы включить целевые элементом платформы или элемента содержимого платформы в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)], можно задать его <xref:System.Windows.FrameworkElement.Name%2A> свойство. В коде, необходимо также использовать <xref:System.Windows.NameScope.RegisterName%2A> метод, чтобы зарегистрировать имя элемента в элементе, для которого вы создали <xref:System.Windows.NameScope>.  
  
 В следующем примере, взятом из предыдущего примера, назначает имя `MyRectangle` <xref:System.Windows.Shapes.Rectangle>, тип <xref:System.Windows.FrameworkElement>.  
  
 [!code-xaml[storyboards_ovw_snip_XAML#2](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip_XAML/CS/StoryboardsExample.xaml#2)]  
  
 [!code-csharp[storyboards_ovw_snip#102](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip/CSharp/StoryboardsExample.cs#102)]  
  
 После того как элемент получил имя, вы можете анимировать свойство этого элемента.  
  
 [!code-xaml[storyboards_ovw_snip_XAML#5](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip_XAML/CS/StoryboardsExample.xaml#5)]  
  
 [!code-csharp[storyboards_ovw_snip#105](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip/CSharp/StoryboardsExample.cs#105)]  
  
 <xref:System.Windows.Freezable> типы являются классы, наследующие от <xref:System.Windows.Freezable> класса. Примеры <xref:System.Windows.Freezable> включают <xref:System.Windows.Media.SolidColorBrush>, <xref:System.Windows.Media.RotateTransform>, и <xref:System.Windows.Media.GradientStop>.  
  
 Чтобы включить целевые <xref:System.Windows.Freezable> с помощью анимации в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)], использовании [директива x: Name](../../xaml-services/x-name-directive.md) присвоить имя. В коде используйте <xref:System.Windows.NameScope.RegisterName%2A> метод для регистрации имени элемента, для которого вы создали <xref:System.Windows.NameScope>.  
  
 В следующем примере назначается имя, <xref:System.Windows.Freezable> объекта.  
  
 [!code-xaml[storyboards_ovw_snip_XAML#3](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip_XAML/CS/StoryboardsExample.xaml#3)]  
  
 [!code-csharp[storyboards_ovw_snip#103](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip/CSharp/StoryboardsExample.cs#103)]  
  
 Затем этот объект можно выбрать в качестве целевого с помощью анимации.  
  
 [!code-xaml[storyboards_ovw_snip_XAML#7](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip_XAML/CS/StoryboardsExample.xaml#7)]  
  
 [!code-csharp[storyboards_ovw_snip#107](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip/CSharp/StoryboardsExample.cs#107)]  
  
 <xref:System.Windows.Media.Animation.Storyboard> объекты используются области видимости имен для разрешения <xref:System.Windows.Media.Animation.Storyboard.TargetName%2A> свойство. Дополнительные сведения об областях видимости имен WPF см. в разделе [Области видимости имен XAML в WPF](../advanced/wpf-xaml-namescopes.md). Если <xref:System.Windows.Media.Animation.Storyboard.TargetName%2A> свойства указан, элемент, на котором она была определена, или, в случае стили, оформленного элемент целевым объектом для анимации.  
  
 Иногда имя не может быть назначен <xref:System.Windows.Freezable> объекта. Например если <xref:System.Windows.Freezable> объявлен как ресурс или используется для задания значения свойства в стиле, ему нельзя присвоить имя. Так как у объекта нет имени, к нему нельзя обратиться напрямую, но можно обратиться косвенно. В следующих разделах описано, как обращаться к целевым объектам косвенно.  
  
<a name="pathsyntaxforchangeable"></a>   
## <a name="indirect-targeting"></a>Косвенное обращение  
 Иногда <xref:System.Windows.Freezable> не может применяться непосредственно с помощью анимации, например, при <xref:System.Windows.Freezable> объявлен как ресурс или используется для задания значения свойства в стиле. В таких случаях, несмотря на то, что вы не можете выбрать напрямую, можно анимировать <xref:System.Windows.Freezable> объекта. Вместо того чтобы задавать <xref:System.Windows.Media.Animation.Storyboard.TargetName%2A> свойство с именем <xref:System.Windows.Freezable>, присвойте ему имя элемента, к которому <xref:System.Windows.Freezable> «принадлежит». Например <xref:System.Windows.Media.SolidColorBrush> присваивается <xref:System.Windows.Shapes.Shape.Fill%2A> прямоугольника элемент принадлежит этому прямоугольника. Чтобы анимировать кисть, необходимо установить анимации <xref:System.Windows.Media.Animation.Storyboard.TargetProperty> в цепи свойства, которое начинается с свойство элемента платформы или элемента содержимого платформы <xref:System.Windows.Freezable> использовалась для установки и заканчивается <xref:System.Windows.Freezable> анимируемое свойство.  
  
 [!code-xaml[storyboards_ovw_snip_XAML#33](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip_XAML/CS/IndirectTargetingExample.xaml#33)]  
  
 [!code-csharp[storyboards_ovw_snip#134](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip/CSharp/IndirectTargetingExample.xaml.cs#134)]  
  
 Обратите внимание, что, если <xref:System.Windows.Freezable> является фиксированной, будет создан клон и этот клон будет анимироваться. Если это происходит, исходный объект <xref:System.Windows.Media.Animation.Animatable.HasAnimatedProperties%2A> свойство продолжает возвращать `false`, так как исходный объект фактически не анимируется. Дополнительные сведения о клонировании см. в разделе [Freezable Общие сведения об объектах](../advanced/freezable-objects-overview.md).  
  
 Обратите внимание, что при косвенном обращении к целевым объектам можно обращаться к объектам, которых не существует. Например, можно предположить, что <xref:System.Windows.Controls.Control.Background%2A> для конкретной кнопки было установлено с помощью <xref:System.Windows.Media.SolidColorBrush> и попробуете анимировать его свойство Color, когда на самом деле <xref:System.Windows.Media.LinearGradientBrush> использовалась для установки фона кнопки. В этих случаях исключение не вызывается; анимация не имеет видимого эффекта, так как <xref:System.Windows.Media.LinearGradientBrush> не реагирует на изменения в <xref:System.Windows.Media.SolidColorBrush.Color%2A> свойство.  
  
 В следующих разделах более подробно описан синтаксис косвенного обращения к целевым объектам.  
  
<a name="xamlsyntaxchangeableproperty"></a>   
### <a name="indirectly-targeting-a-property-of-a-freezable-in-xaml"></a>Косвенное обращение к свойству объекта Freezable в XAML  
 Чтобы обратиться к свойству объекта freezable в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)], используйте следующий синтаксис.  
  
| |  
|-|  
|*ElementPropertyName* `.` *FreezablePropertyName*|  
  
 Where  
  
-   *ElementPropertyName* свойство <xref:System.Windows.FrameworkElement> которого <xref:System.Windows.Freezable> используется для задания, и  
  
-   *FreezablePropertyName* свойство <xref:System.Windows.Freezable> для анимации.  
  
 Ниже показано, как анимировать <xref:System.Windows.Media.SolidColorBrush.Color%2A> из <xref:System.Windows.Media.SolidColorBrush> используемый для задания  
  
 <xref:System.Windows.Shapes.Shape.Fill%2A> элемента прямоугольника.  
  
 [!code-xaml[storyboards_ovw_snip_XAML#32](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip_XAML/CS/IndirectTargetingExample.xaml#32)]  
  
 Иногда требуется обратиться к объекту Freezable, который содержится в коллекции или массиве.  
  
 Чтобы обратиться к объекту Freezable, который содержится в коллекции, используйте следующий синтаксис пути.  
  
| |  
|-|  
|*ElementPropertyName* `.Children[` *CollectionIndex* `].` *FreezablePropertyName*|  
  
 Где *CollectionIndex* — индекс объекта в массиве или коллекции.  
  
 Например, предположим, что у прямоугольника есть <xref:System.Windows.Media.TransformGroup> ресурс, применяемый к его <xref:System.Windows.UIElement.RenderTransform%2A> свойство и вы хотите анимировать одно из преобразований, он содержит.  
  
 [!code-xaml[storyboards_ovw_snip_XAML#34](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip_XAML/CS/IndirectTargetingExample.xaml#34)]  
  
 Ниже показано, как анимировать <xref:System.Windows.Media.RotateTransform.Angle%2A> свойство <xref:System.Windows.Media.RotateTransform> показано в предыдущем примере.  
  
 [!code-xaml[storyboards_ovw_snip_XAML#35](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip_XAML/CS/IndirectTargetingExample.xaml#35)]  
  
<a name="targetingpropertyofchangeableincode"></a>   
### <a name="indirectly-targeting-a-property-of-a-freezable-in-code"></a>Косвенное обращение к свойству объекта Freezable в коде  
 В коде создайте <xref:System.Windows.PropertyPath> объекта. При создании <xref:System.Windows.PropertyPath>, указать <xref:System.Windows.PropertyPath.Path%2A> и <xref:System.Windows.PropertyPath.PathParameters%2A>.  
  
 Чтобы создать <xref:System.Windows.PropertyPath.PathParameters%2A>, необходимо создать массив типа <xref:System.Windows.DependencyProperty> , содержащий список поля идентификаторов свойств зависимостей. — Первое поле идентификатора свойства <xref:System.Windows.FrameworkElement> или <xref:System.Windows.FrameworkContentElement> , <xref:System.Windows.Freezable> используется для задания. Следующее поле идентификатора представляет свойство <xref:System.Windows.Freezable> к целевому объекту. Представьте себе, как цепочку свойств, который подключается <xref:System.Windows.Freezable> для <xref:System.Windows.FrameworkElement> объекта.  
  
 Ниже приведен пример цепочки свойств зависимостей, предназначенное <xref:System.Windows.Media.SolidColorBrush.Color%2A> из <xref:System.Windows.Media.SolidColorBrush> присваивается <xref:System.Windows.Shapes.Shape.Fill%2A> элемента прямоугольника.  
  
 [!code-csharp[storyboards_ovw_snip#135](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip/CSharp/IndirectTargetingExample.xaml.cs#135)]  
  
 Необходимо также указать <xref:System.Windows.PropertyPath.Path%2A>. Объект <xref:System.Windows.PropertyPath.Path%2A> — <xref:System.String> , сообщающий <xref:System.Windows.PropertyPath.Path%2A> как интерпретировать его <xref:System.Windows.PropertyPath.PathParameters%2A>. Для этого используется следующий синтаксис.  
  
| |  
|-|  
|`(` *OwnerPropertyArrayIndex* `).(` *FreezablePropertyArrayIndex* `)`|  
  
 Where  
  
-   *OwnerPropertyArrayIndex* — это индекс <xref:System.Windows.DependencyProperty> массив, содержащий идентификатор <xref:System.Windows.FrameworkElement> свойство объекта, <xref:System.Windows.Freezable> используется для задания, и  
  
-   *FreezablePropertyArrayIndex* — это индекс <xref:System.Windows.DependencyProperty> массив, содержащий идентификатор свойства к целевому объекту.  
  
 В следующем примере показан <xref:System.Windows.PropertyPath.Path%2A> , будет сопровождать <xref:System.Windows.PropertyPath.PathParameters%2A> определенный в предыдущем примере.
  
 [!code-csharp[storyboards_ovw_snip#PropertyChainAndPath](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip/CSharp/IndirectTargetingExample.xaml.cs#propertychainandpath)]  
  
 В следующем примере объединяются кода в предыдущих примерах для анимации <xref:System.Windows.Media.SolidColorBrush.Color%2A> из <xref:System.Windows.Media.SolidColorBrush> присваивается <xref:System.Windows.Shapes.Shape.Fill%2A> элемента прямоугольника.  
  
 [!code-csharp[storyboards_ovw_snip#137](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip/CSharp/IndirectTargetingExample.xaml.cs#137)]  
  
 Иногда требуется обратиться к объекту Freezable, который содержится в коллекции или массиве. Например, предположим, что у прямоугольника есть <xref:System.Windows.Media.TransformGroup> ресурс, применяемый к его <xref:System.Windows.UIElement.RenderTransform%2A> свойство и вы хотите анимировать одно из преобразований, он содержит.  
  
 [!code-xaml[storyboards_ovw_snip#142](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip/CSharp/IndirectTargetingExample.xaml#142)]  
  
 Целевой объект <xref:System.Windows.Freezable> содержится в коллекции, используйте следующий синтаксис пути.  
  
| |  
|-|  
|`(` *OwnerPropertyArrayIndex* `).(` *CollectionChildrenPropertyArrayIndex* `)` `[` *CollectionIndex* `].(` *FreezablePropertyArrayIndex* `)`|  
  
 Где *CollectionIndex* — индекс объекта в массиве или коллекции.  
  
 Целевой объект <xref:System.Windows.Media.RotateTransform.Angle%2A> свойство <xref:System.Windows.Media.RotateTransform>, во втором преобразовании в <xref:System.Windows.Media.TransformGroup>, следует ввести следующую <xref:System.Windows.PropertyPath.Path%2A> и <xref:System.Windows.PropertyPath.PathParameters%2A>.  
  
 [!code-csharp[storyboards_ovw_snip#139](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip/CSharp/IndirectTargetingExample.xaml.cs#139)]  
  
 В примере показан полный код для анимации <xref:System.Windows.Media.RotateTransform.Angle%2A> из <xref:System.Windows.Media.RotateTransform> внутри <xref:System.Windows.Media.TransformGroup>.  
  
 [!code-csharp[storyboards_ovw_snip#138](~/samples/snippets/csharp/VS_Snippets_Wpf/storyboards_ovw_snip/CSharp/IndirectTargetingExample.xaml.cs#138)]  
  
### <a name="indirectly-targeting-with-a-freezable-as-the-starting-point"></a>Косвенное обращение с использованием объекта Freezable в качестве начальной точки  
 Предыдущих разделах мы описали косвенное обращение к <xref:System.Windows.Freezable> , начав с <xref:System.Windows.FrameworkElement> или <xref:System.Windows.FrameworkContentElement> и создав цепочку свойств до <xref:System.Windows.Freezable> подчиненных свойств. Можно также использовать <xref:System.Windows.Freezable> качестве отправной точки и косвенно обращаться к одному из его <xref:System.Windows.Freezable> подсвойства. Одно дополнительное ограничение применяется при использовании <xref:System.Windows.Freezable> отправной точки для косвенного: начальный <xref:System.Windows.Freezable> и каждый <xref:System.Windows.Freezable> не должны фиксироваться между ним и косвенно целевых подчиненных свойств.  
  
<a name="controllable_storyboards"></a>   
## <a name="interactively-controlling-a-storyboard-in-xaml"></a>Интерактивное управление раскадровкой в XAML  
 Чтобы запустить раскадровку XAML, использовании <xref:System.Windows.Media.Animation.BeginStoryboard> запуска действия. <xref:System.Windows.Media.Animation.BeginStoryboard> распределяет анимации объектов и свойств и запускает раскадровку. (Дополнительные сведения об этом процессе см. в разделе [анимации и общие сведения о характере системы](animation-and-timing-system-overview.md).) Если вы предоставите <xref:System.Windows.Media.Animation.BeginStoryboard> имя, указав его <xref:System.Windows.Media.Animation.BeginStoryboard.Name%2A> свойство, можно упростить управляемой раскадровки. Вы можете затем интерактивно управлять раскадровкой после ее запуска. Ниже приведен список действий для управляемой раскадровки, которые используются совместно с триггерами событий для управления раскадровкой.  
  
-   <xref:System.Windows.Media.Animation.PauseStoryboard>: Приостанавливает раскадровку.  
  
-   <xref:System.Windows.Media.Animation.ResumeStoryboard>: Возобновляет приостановленную раскадровку.  
  
-   <xref:System.Windows.Media.Animation.SetStoryboardSpeedRatio>: Изменяет скорость раскадровки.  
  
-   <xref:System.Windows.Media.Animation.SkipStoryboardToFill>: Перемещает раскадровку в конец ее периода заполнения, если он имеется.  
  
-   <xref:System.Windows.Media.Animation.StopStoryboard>: Останавливает раскадровку.  
  
-   <xref:System.Windows.Media.Animation.RemoveStoryboard>: Удаляет раскадровку.  
  
 В следующем примере показано использование действий для интерактивного управления раскадровкой.  
  
 [!code-xaml[animation_ovws_snip#ControllableStoryboardExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws_snip/CS/ControllableStoryboardExample.xaml#controllablestoryboardexamplewholepage)]  
  
<a name="controllable_storyboards_procedural"></a>   
## <a name="interactively-controlling-a-storyboard-by-using-code"></a>Интерактивное управление раскадровкой с помощью кода  
 В предыдущих примерах было показано, как анимировать свойства с помощью действий триггера. В коде, можно также управлять раскадровкой с помощью интерактивных методов класса <xref:System.Windows.Media.Animation.Storyboard> класса. Для <xref:System.Windows.Media.Animation.Storyboard> чтобы сделать интерактивными в коде, необходимо использовать соответствующую перегрузку раскадровки <xref:System.Windows.Media.Animation.Storyboard.Begin%2A> метод и указать `true` чтобы сделать раскадровку управляемой. См. в разделе <xref:System.Windows.Media.Animation.Storyboard.Begin%28System.Windows.FrameworkElement%2CSystem.Boolean%29> дополнительную информацию.  
  
 В следующем списке приведены методы, которые можно использовать для управления <xref:System.Windows.Media.Animation.Storyboard> после ее запуска:  
  
-   <xref:System.Windows.Media.Animation.Storyboard.Pause%2A>  
  
-   <xref:System.Windows.Media.Animation.Storyboard.Resume%2A>  
  
-   <xref:System.Windows.Media.Animation.Storyboard.Seek%2A>  
  
-   <xref:System.Windows.Media.Animation.Storyboard.SkipToFill%2A>  
  
-   <xref:System.Windows.Media.Animation.Storyboard.Stop%2A>  
  
-   <xref:System.Windows.Media.Animation.Storyboard.Remove%2A>  
  
 С помощью этих методов удобен тем, что не нужно создавать <xref:System.Windows.Trigger> или <xref:System.Windows.TriggerAction> объектов; нужна ссылка на управляемый <xref:System.Windows.Media.Animation.Storyboard> требуется работать.  
  
 **Примечание.** Все интерактивные действия, выполняемые <xref:System.Windows.Media.Animation.Clock>и поэтому на <xref:System.Windows.Media.Animation.Storyboard> произойдет при следующем такте, который произойдет незадолго перед следующей операцией рендеринга. Например, если вы используете <xref:System.Windows.Media.Animation.Storyboard.Seek%2A> метод для перехода к следующей точке анимации, значение свойства не изменится сразу же, вместо этого изменяется значение при следующем такте.  
  
 Приведенный ниже показано, как применять анимации с помощью интерактивных методов класса и управлять <xref:System.Windows.Media.Animation.Storyboard> класса.  
  
 [!code-csharp[animation_ovws_procedural_snip#ControllableStoryboardExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/animation_ovws_procedural_snip/CSharp/ControllableStoryboardExample.cs#controllablestoryboardexamplewholepage)]
   
  
<a name="usingstoryboardsinstyles"></a>   
## <a name="animate-in-a-style"></a>Анимация с использованием стилей  
 Можно использовать <xref:System.Windows.Media.Animation.Storyboard> объектов для определения анимаций в <xref:System.Windows.Style>. Анимации с помощью <xref:System.Windows.Media.Animation.Storyboard> в <xref:System.Windows.Style> похоже на использование <xref:System.Windows.Media.Animation.Storyboard> в другом месте, со следующими тремя исключениями:  
  
-   Вы не укажете <xref:System.Windows.Media.Animation.Storyboard.TargetName%2A>; <xref:System.Windows.Media.Animation.Storyboard> всегда указывает элемент, к которому <xref:System.Windows.Style> применяется. Целевой объект <xref:System.Windows.Freezable> объекты, следует использовать косвенное обращение. Дополнительные сведения о косвенном обращении см. в разделе [косвенное обращение](#pathsyntaxforchangeable) раздел.  
  
-   Нельзя указать <xref:System.Windows.EventTrigger.SourceName%2A> для <xref:System.Windows.EventTrigger> или <xref:System.Windows.Trigger>.  
  
-   Нельзя использовать динамический ресурс ссылки или выражения привязки данных для задания <xref:System.Windows.Media.Animation.Storyboard> или значений свойств анимации. Это потому, что весь код внутри <xref:System.Windows.Style> должен быть поточно ориентированными, и система управления должна <xref:System.Windows.Freezable.Freeze%2A><xref:System.Windows.Media.Animation.Storyboard> объектов, чтобы сделать их потокобезопасными. Объект <xref:System.Windows.Media.Animation.Storyboard> нельзя зафиксировать, если его или ее дочерние временные шкалы содержат динамические ресурсы ссылки или выражения привязки данных. Дополнительные сведения о фиксации и других <xref:System.Windows.Freezable> функции, см. в разделе [Freezable Общие сведения об объектах](../advanced/freezable-objects-overview.md).  
  
-   В [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)], нельзя объявлять обработчики событий для <xref:System.Windows.Media.Animation.Storyboard> или событий анимации.  
  
 Пример, показывающий, как определить раскадровку в стиле, см. в разделе [анимация с использованием стилей](how-to-animate-in-a-style.md) пример.  
  
<a name="defineAStoryboardInAControlTemplateSection"></a>   
## <a name="animate-in-a-controltemplate"></a>Анимация в ControlTemplate  
 Можно использовать <xref:System.Windows.Media.Animation.Storyboard> объектов для определения анимаций в <xref:System.Windows.Controls.ControlTemplate>. Анимации с помощью <xref:System.Windows.Media.Animation.Storyboard> в <xref:System.Windows.Controls.ControlTemplate> похоже на использование <xref:System.Windows.Media.Animation.Storyboard> в другом месте, со следующими двумя исключениями:  
  
-   <xref:System.Windows.Media.Animation.Storyboard.TargetName%2A> Могут ссылаться только на дочерние объекты <xref:System.Windows.Controls.ControlTemplate>. Если <xref:System.Windows.Media.Animation.Storyboard.TargetName%2A> не указан, элемент, в который целевым объектом для анимации <xref:System.Windows.Controls.ControlTemplate> применяется.  
  
-   <xref:System.Windows.EventTrigger.SourceName%2A> Для <xref:System.Windows.EventTrigger> или <xref:System.Windows.Trigger> могут ссылаться только на дочерние объекты <xref:System.Windows.Controls.ControlTemplate>.  
  
-   Нельзя использовать динамический ресурс ссылки или выражения привязки данных для задания <xref:System.Windows.Media.Animation.Storyboard> или значений свойств анимации. Это потому, что весь код внутри <xref:System.Windows.Controls.ControlTemplate> должен быть поточно ориентированными, и система управления должна <xref:System.Windows.Freezable.Freeze%2A><xref:System.Windows.Media.Animation.Storyboard> объектов, чтобы сделать их потокобезопасными. Объект <xref:System.Windows.Media.Animation.Storyboard> нельзя зафиксировать, если его или ее дочерние временные шкалы содержат динамические ресурсы ссылки или выражения привязки данных. Дополнительные сведения о фиксации и других <xref:System.Windows.Freezable> функции, см. в разделе [Freezable Общие сведения об объектах](../advanced/freezable-objects-overview.md).  
  
-   В [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)], нельзя объявлять обработчики событий для <xref:System.Windows.Media.Animation.Storyboard> или событий анимации.  
  
 Пример, показывающий, как определить раскадровку в <xref:System.Windows.Controls.ControlTemplate>, см. в разделе [анимация в ControlTemplate](how-to-animate-in-a-controltemplate.md) пример.  
  
<a name="animateWhenAPropertyValueChanges"></a>   
## <a name="animate-when-a-property-value-changes"></a>Анимация при изменении значения свойства  
 В стилях и шаблонах элементов можно использовать объекты триггеров для запуска раскадровки при изменении свойства. Примеры, см. в разделе [триггер анимации при изменении значения свойства](how-to-trigger-an-animation-when-a-property-value-changes.md) и [анимация в ControlTemplate](how-to-animate-in-a-controltemplate.md).  
  
 Анимации с помощью свойства <xref:System.Windows.Trigger> объекты ведут себя в сложнее, чем <xref:System.Windows.EventTrigger> анимации или анимации к использованию <xref:System.Windows.Media.Animation.Storyboard> методы.  Они «переходной» с анимацией определены другими <xref:System.Windows.Trigger> объектов, но compose с <xref:System.Windows.EventTrigger> и анимациями, запускаемыми.  
  
## <a name="see-also"></a>См. также

- [Общие сведения об эффектах анимации](animation-overview.md)
- [Общие сведения о методах анимации свойств](property-animation-techniques-overview.md)
- [Общие сведения об объектах класса Freezable](../advanced/freezable-objects-overview.md)

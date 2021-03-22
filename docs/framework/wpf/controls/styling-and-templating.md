---
title: Стилизация и использование шаблонов
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- triggers [WPF]
- styles [WPF], referencing
- event triggers [WPF]
- styles [WPF], prerequisites
- styles [WPF], declaring
- styles [WPF], overview
- styles [WPF], extending
- styles [WPF], triggers
- styles [WPF], event triggers
ms.assetid: 481765e5-5467-4a75-9f7b-e10e2ac410d9
ms.openlocfilehash: 3fae4993a13b02ad998668f644a80ba7c07196fa
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59132303"
---
# <a name="styling-and-templating"></a>Стилизация и использование шаблонов
[!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] Стилизация и использование шаблонов относятся к набору возможностей (стили, шаблоны, триггеры и раскадровки), которые позволяют разработчикам и дизайнерам создавать визуально привлекательные эффекты и создавать согласованный внешний вид своего продукта. Несмотря на то что разработчики и дизайнеры могут создавать внешний вид отдельно для каждого приложения, надежная модель стилизации и использования шаблонов необходима для поддержки и совместного использования внешнего вида как внутри одного приложения, так и в ряде приложений. [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] предоставляет такую модель.  
  
 Еще одной возможностью модели стилизации [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] является разделение представления и логики. Это означает, что дизайнеры могут создавать внешний вид приложения только с помощью [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] в то же самое время, когда разработчики работают над логикой программы, используя языки C# или Visual Basic.  
  
 В этом обзоре основное внимание уделяется аспектам стилизации и использования шаблонов приложения и не рассматриваются концепции привязки данных. Подробнее о привязке данных см. в разделе [Общие сведения о привязке данных](../data/data-binding-overview.md).  
  
 Также важно иметь представление о ресурсах, которые позволяют повторно использовать стили и шаблоны. Дополнительные сведения о ресурсах см. в разделе [Ресурсы XAML](../advanced/xaml-resources.md).

<a name="styling_and_templating_sample"></a>   
## <a name="styling-and-templating-sample"></a>Пример стилизации и использования шаблонов  
 В примерах кода, приведенных в этом обзоре, используется простой пример фото, показанный ниже:  
  
 ![Стилизированный ListView](./media/stylingintro-triggers.png "StylingIntro_triggers")  
  
 В этом простом примере фото стилизация и шаблоны применяются для создания привлекательного интерфейса. Пример содержит два <xref:System.Windows.Controls.TextBlock> элементов и <xref:System.Windows.Controls.ListBox> элемента управления, привязанный к списку изображений. Полный пример см. в разделе [Вводная часть примера стилизации и использования шаблонов](https://github.com/Microsoft/WPF-Samples/tree/master/Styles%20&%20Templates/IntroToStylingAndTemplating).  
  
<a name="styling_basics"></a>   
## <a name="style-basics"></a>Основы стилей  
 Можно представить себе <xref:System.Windows.Style> как удобный способ применения набора значений свойств к более чем одного элемента. Например, рассмотрим следующие <xref:System.Windows.Controls.TextBlock> элементов и их внешний вид по умолчанию:  
  
 [!code-xaml[StylingIntroSample_snippet#TextBlocks](~/samples/snippets/csharp/VS_Snippets_Wpf/StylingIntroSample_snippet/CSharp/Window1.xaml#textblocks)]  
  
 ![Снимок экрана стилей](./media/stylingintro-textblocksbefore.PNG "StylingIntro_TextBlocksBefore")  
  
 Можно изменить внешний вид по умолчанию, задав свойства, такие как <xref:System.Windows.Controls.Control.FontSize%2A> и <xref:System.Windows.Controls.Control.FontFamily%2A>, на каждом <xref:System.Windows.Controls.TextBlock> напрямую. Тем не менее если вы хотите, чтобы ваши <xref:System.Windows.Controls.TextBlock> элементов совместно использовать некоторые свойства, можно создать <xref:System.Windows.Style> в `Resources` части вашей [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файл, как показано ниже:  
  
 [!code-xaml[StylingIntroSnippet#Resources](~/samples/snippets/csharp/VS_Snippets_Wpf/StylingIntroSnippet/CS/window1.xaml#resources)]  
[!code-xaml[StylingIntroSnippet#tb1](~/samples/snippets/csharp/VS_Snippets_Wpf/StylingIntroSnippet/CS/window1.xaml#tb1)]  
[!code-xaml[StylingIntroSnippet#Resources2](~/samples/snippets/csharp/VS_Snippets_Wpf/StylingIntroSnippet/CS/window1.xaml#resources2)]  
  
 При задании <xref:System.Windows.Style.TargetType%2A> стиля <xref:System.Windows.Controls.TextBlock> , стиль применяется ко всем <xref:System.Windows.Controls.TextBlock> элементы в окне.  
  
 Теперь <xref:System.Windows.Controls.TextBlock> элементов будет выглядеть следующим образом:  
  
 ![Снимок экрана стилей](./media/stylingintro-textblocksbasestyle.PNG "StylingIntro_TextBlocksBaseStyle")  
  
### <a name="extending-styles"></a>Расширение стилей  
 Возможно, вам необходимо два <xref:System.Windows.Controls.TextBlock> элементы, чтобы совместно использовать некоторые свойства, такие как <xref:System.Windows.Controls.Control.FontFamily%2A> и выровнять по центру <xref:System.Windows.FrameworkElement.HorizontalAlignment%2A>, и при этом текст «Мои рисунки» обладал некоторыми дополнительными свойствами. Это можно сделать, создав новый стиль на основе первого стиля, как показано ниже:  
  
 [!code-xaml[StylingIntroSnippet#Resources](~/samples/snippets/csharp/VS_Snippets_Wpf/StylingIntroSnippet/CS/window1.xaml#resources)]  
[!code-xaml[StylingIntroSnippet#tb2](~/samples/snippets/csharp/VS_Snippets_Wpf/StylingIntroSnippet/CS/window1.xaml#tb2)]  
[!code-xaml[StylingIntroSnippet#Resources2](~/samples/snippets/csharp/VS_Snippets_Wpf/StylingIntroSnippet/CS/window1.xaml#resources2)]  
  
 Обратите внимание, что предыдущий стиль получил атрибут `x:Key`. Чтобы применить стиль, вы установите <xref:System.Windows.FrameworkElement.Style%2A> свойство вашей <xref:System.Windows.Controls.TextBlock> для `x:Key` значение, как показано ниже:  
  
 [!code-xaml[StylingIntroSnippet#UIText](~/samples/snippets/csharp/VS_Snippets_Wpf/StylingIntroSnippet/CS/window1.xaml#uitext)]  
  
 Это <xref:System.Windows.Controls.TextBlock> теперь имеет стиль <xref:System.Windows.FrameworkElement.HorizontalAlignment%2A> значение <xref:System.Windows.HorizontalAlignment.Center>, <xref:System.Windows.Controls.TextBlock.FontFamily%2A> значение `Comic Sans MS`, <xref:System.Windows.Controls.TextBlock.FontSize%2A> значение 26 и <xref:System.Windows.Controls.TextBlock.Foreground%2A> значение <xref:System.Windows.Media.LinearGradientBrush> показано в примере. Обратите внимание, что этот параметр переопределяет <xref:System.Windows.Controls.Control.FontSize%2A> значение базового стиля. Если имеется более одного <xref:System.Windows.Setter> одного свойства <xref:System.Windows.Style>, <xref:System.Windows.Setter> то есть объявленный последнего имеет больший приоритет.  
  
 Ниже показано <xref:System.Windows.Controls.TextBlock> элементов будет выглядеть так:  
  
 ![Стилизированный TextBlocks](./media/stylingintro-textblocks.png "StylingIntro_TextBlocks")  
  
 Это `TitleText` стиля расширяет стиль, который был создан для <xref:System.Windows.Controls.TextBlock> типа. Можно также расширить стиль, имеющий атрибут `x:Key`, используя значение атрибута `x:Key`. Например, см. пример для <xref:System.Windows.Style.BasedOn%2A> свойство.  
  
### <a name="relationship-of-the-targettype-property-and-the-xkey-attribute"></a>Связь свойства TargetType и атрибута x:Key  
 Как показано в первом примере, установка <xref:System.Windows.Style.TargetType%2A> свойства `TextBlock` без присвоения стилю `x:Key` вызывает стиль, применяемый ко всем <xref:System.Windows.Controls.TextBlock> элементов. В этом случае для `x:Key` неявно устанавливается значение `{x:Type TextBlock}`. Это означает, что если явно задать `x:Key` значение, отличное от `{x:Type TextBlock}`, <xref:System.Windows.Style> применяется не ко всем <xref:System.Windows.Controls.TextBlock> элементов автоматически. Вместо этого необходимо применить стиль (с помощью `x:Key` значение) для <xref:System.Windows.Controls.TextBlock> элементы явным образом. Если стиль находится в разделе ресурсов и не устанавливайте <xref:System.Windows.Style.TargetType%2A> свойство в стиле, то необходимо предоставить `x:Key`.  
  
 Помимо предоставления значение по умолчанию для `x:Key`, <xref:System.Windows.Style.TargetType%2A> свойство задает тип, к которому применяются свойства метода задания. Если вы не укажете <xref:System.Windows.Style.TargetType%2A>, необходимо уточнить свойства в вашей <xref:System.Windows.Setter> объектов с именем класса, используя синтаксис `Property="ClassName.Property"`. Например, вместо того чтобы задавать `Property="FontSize"`, необходимо задать <xref:System.Windows.Setter.Property%2A> для `"TextBlock.FontSize"` или `"Control.FontSize"`.  
  
 Также обратите внимание, что многие элементы управления [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] являются сочетанием других элементов управления [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]. Если создать стиль, который применяется ко всем элементам управления типа, можно получить непредвиденные результаты. Например, если создать стиль, предназначенный <xref:System.Windows.Controls.TextBlock> введите в <xref:System.Windows.Window>, стиль применяется ко всем <xref:System.Windows.Controls.TextBlock> элементов управления в окне, даже если <xref:System.Windows.Controls.TextBlock> является частью другого элемента управления, такие как <xref:System.Windows.Controls.ListBox>.  
  
### <a name="styles-and-resources"></a>Стили и ресурсы  
 Можно использовать стиль для любого элемента, который является производным от <xref:System.Windows.FrameworkElement> или <xref:System.Windows.FrameworkContentElement>. Наиболее распространенный способ объявления стиля — это его объявление в качестве ресурса в разделе `Resources` файла [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)], как было показано в предыдущих примерах. Так как стили являются ресурсами, для них действуют те же правила области видимости, которые применяются ко всем ресурсам. Область, в которой объявлен стиль, влияет на область применения стиля. Например, если объявить стиль в корневом элементе файла [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] определения приложения, стиль может использоваться в любом месте приложения. Если вы создаете приложение навигации и объявляете стиль в одном из файлов [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] приложения, стиль можно будет использовать только в этом файле [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)]. Подробнее о правилах видимости ресурсов см. в разделе [Ресурсы XAML](../advanced/xaml-resources.md).  
  
 Кроме того, дополнительные сведения о стилях и ресурсах можно найти в разделе [Совместно используемые ресурсы и темы](#styling_themes) данного обзора.  
  
### <a name="setting-styles-programmatically"></a>Программная установка стилей  
 Чтобы программным способом назначить именованный стиль элементу, Возьмите этот стиль из коллекции ресурсов и его назначение этого элемента <xref:System.Windows.FrameworkElement.Style%2A> свойство. Обратите внимание, что элементы в коллекции ресурсов имеют тип <xref:System.Object>. Таким образом, необходимо привести полученный стиль для <xref:System.Windows.Style> перед назначением его <xref:System.Windows.FrameworkElement.Style%2A> свойство. Например, чтобы задать определенный `TitleText` стиль над <xref:System.Windows.Controls.TextBlock> с именем `textblock1`, выполните следующие действия:  
  
 [!code-csharp[StylingIntroSample_snippet#Code](~/samples/snippets/csharp/VS_Snippets_Wpf/StylingIntroSample_snippet/CSharp/Window1.xaml.cs#code)]
   
  
 Обратите внимание, что после применения стиля он фиксируется и не может быть изменен. Если необходимо динамически изменить стиль, который уже был применен, нужно создать новый стиль для замены существующего. Дополнительные сведения см. в описании свойства <xref:System.Windows.Style.IsSealed%2A>.  
  
 Можно создать объект, который выбирает стиль, который нужно применить, основываясь на собственной логике. Например, см. пример для <xref:System.Windows.Controls.StyleSelector> класса.  
  
<a name="styling_binding_dynamicresource"></a>   
### <a name="bindings-dynamic-resources-and-event-handlers"></a>Привязки, динамические ресурсы и обработчики событий  
 Обратите внимание, что свойство `Setter.Value` можно использовать для задания [привязки расширения разметки](../advanced/binding-markup-extension.md) или [расширения разметки DynamicResource](../advanced/dynamicresource-markup-extension.md). Дополнительные сведения см. в примерах для <xref:System.Windows.Setter.Value%2A?displayProperty=nameWithType> свойство.  
  
 На данный момент этот обзор касается только использования методов задания для установки значений свойств. В стиле также можно задать обработчики событий. Дополнительные сведения см. в разделе <xref:System.Windows.EventSetter>.  
  
<a name="styling_datatemplates"></a>   
## <a name="data-templates"></a>Шаблоны данных  
 В этом примере приложения есть <xref:System.Windows.Controls.ListBox> элемента управления, привязанный к списку фотографий:  
  
 [!code-xaml[StylingIntroSnippet#UIListBox](~/samples/snippets/csharp/VS_Snippets_Wpf/StylingIntroSnippet/CS/window1.xaml#uilistbox)]  
  
 Это <xref:System.Windows.Controls.ListBox> в данный момент выглядит следующим образом:  
  
 ![ListBox до применения шаблона](./media/stylingintro-listboxbefore.png "StylingIntro_ListBoxBefore")  
  
 Большинство элементов управления имеют некое содержимое, и это содержимое часто поступает из данных, к которым осуществляется привязка. В этом примере такими данными является список фотографий. В [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], использовании <xref:System.Windows.DataTemplate> для определения визуального представления данных. По сути, что вы поместите в <xref:System.Windows.DataTemplate> определяет вид данных в отображаемом приложении.  
  
 В нашем примере приложения каждый пользовательский объект `Photo` имеет свойство `Source` строкового типа, которое задает путь к файлу изображения. Сейчас объекты фотографий отображаются как пути к файлам.  
  
 Чтобы фотографии отображались как изображения, создании <xref:System.Windows.DataTemplate> как ресурс:  
  
 [!code-xaml[StylingIntroSnippet#Resources](~/samples/snippets/csharp/VS_Snippets_Wpf/StylingIntroSnippet/CS/window1.xaml#resources)]  
[!code-xaml[StylingIntroSnippet#DataTemplate](~/samples/snippets/csharp/VS_Snippets_Wpf/StylingIntroSnippet/CS/window1.xaml#datatemplate)]  
[!code-xaml[StylingIntroSnippet#Resources2](~/samples/snippets/csharp/VS_Snippets_Wpf/StylingIntroSnippet/CS/window1.xaml#resources2)]  
  
 Обратите внимание, что <xref:System.Windows.DataTemplate.DataType%2A> очень похоже на свойство <xref:System.Windows.Style.TargetType%2A> свойство <xref:System.Windows.Style>. Если ваш <xref:System.Windows.DataTemplate> находится в разделе ресурсов, при указании <xref:System.Windows.DataTemplate.DataType%2A> свойство с типом и не назначаете ему `x:Key`, <xref:System.Windows.DataTemplate> будет применяться при каждом отображении этого типа. У вас всегда есть возможность назначения <xref:System.Windows.DataTemplate> с `x:Key` и затем задать его в качестве `StaticResource` для свойства, принимающие <xref:System.Windows.DataTemplate> типы, такие как <xref:System.Windows.Controls.ItemsControl.ItemTemplate%2A> свойство или <xref:System.Windows.Controls.ContentControl.ContentTemplate%2A> свойство.  
  
 По сути <xref:System.Windows.DataTemplate> в приведенном выше примере определяет, что при имеется `Photo` объекта, он должен быть <xref:System.Windows.Controls.Image> в <xref:System.Windows.Controls.Border>. С этим <xref:System.Windows.DataTemplate>, наше приложение теперь выглядит следующим образом:  
  
 ![Фотоизображение](./media/stylingintro-photosasimages.png "StylingIntro_PhotosAsImages")  
  
 Модель использования шаблонов данных предоставляет и другие возможности. Например, при отображении данных коллекции, содержащей другие коллекции с помощью <xref:System.Windows.Controls.HeaderedItemsControl> введите, например <xref:System.Windows.Controls.Menu> или <xref:System.Windows.Controls.TreeView>, имеется <xref:System.Windows.HierarchicalDataTemplate>. Другой возможностью шаблонов данных является <xref:System.Windows.Controls.DataTemplateSelector>, который позволяет выбрать <xref:System.Windows.DataTemplate> для использования на основе пользовательской логики. Дополнительные сведения см. в разделе [Общие сведения о шаблонах данных](../data/data-templating-overview.md), в котором более подробно рассматриваются различные возможности использования шаблонов данных.  
  
<a name="styling_controltemplates"></a>   
## <a name="control-templates"></a>Шаблоны элементов управления  
 В [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], <xref:System.Windows.Controls.ControlTemplate> элемента управления определяет внешний вид элемента управления. Можно изменить структуру и внешний вид элемента управления, определив новый <xref:System.Windows.Controls.ControlTemplate> для элемента управления. Во многих случаях это является достаточно гибким средством, и вам не придется писать собственные пользовательские элементы управления. Подробнее см. в разделе [Настройка внешнего вида существующего элемента управления путем создания объекта ControlTemplate](customizing-the-appearance-of-an-existing-control.md).  
  
<a name="styling_triggers"></a>   
## <a name="triggers"></a>Триггеры  
 Триггер задает значения свойств или активирует различные действия (например, анимацию) при изменении значения свойства или при возникновении какого-либо события. <xref:System.Windows.Style>, <xref:System.Windows.Controls.ControlTemplate>, и <xref:System.Windows.DataTemplate> все имеют `Triggers` свойство, которое может содержать набор триггеров. Существуют различные типы триггеров.  
  
### <a name="property-triggers"></a>Триггеры свойств  
 Объект <xref:System.Windows.Trigger> , задает значения свойств или активирует действия на основе значения свойства, называется триггером свойства.  
  
 Чтобы продемонстрировать использование триггеров свойств, вы можете сделать каждую <xref:System.Windows.Controls.ListBoxItem> частично прозрачным, если он выбран. Следующий стиль устанавливает <xref:System.Windows.UIElement.Opacity%2A> значение <xref:System.Windows.Controls.ListBoxItem> для `0.5`. Когда <xref:System.Windows.Controls.ListBoxItem.IsSelected%2A> свойство `true`, но при этом <xref:System.Windows.UIElement.Opacity%2A> присваивается `1.0`:  
  
 [!code-xaml[StylingIntroSample_snippet#Triggers](~/samples/snippets/csharp/VS_Snippets_Wpf/StylingIntroSample_snippet/CSharp/Window1.xaml#triggers)]  
[!code-xaml[StylingIntroSample_snippet#EndTriggers](~/samples/snippets/csharp/VS_Snippets_Wpf/StylingIntroSample_snippet/CSharp/Window1.xaml#endtriggers)]  
  
 В этом примере используется <xref:System.Windows.Trigger> для задания значения свойства, но Обратите внимание, что <xref:System.Windows.Trigger> класс также имеет <xref:System.Windows.TriggerBase.EnterActions%2A> и <xref:System.Windows.TriggerBase.ExitActions%2A> свойства, позволяющие триггера для выполнения действия.  
  
 Обратите внимание, что <xref:System.Windows.FrameworkElement.MaxHeight%2A> свойство <xref:System.Windows.Controls.ListBoxItem> присваивается `75`. На следующем рисунке третий элемент является выбранным:  
  
 ![Стилизированный ListView](./media/stylingintro-triggers.png "StylingIntro_triggers")  
  
### <a name="eventtriggers-and-storyboards"></a>Объекты EventTrigger и раскадровки  
 Другой тип триггера — <xref:System.Windows.EventTrigger>, которая запускает набор действий в зависимости от возникновения события. Например, следующая <xref:System.Windows.EventTrigger> объекта задают, когда указатель мыши попадает <xref:System.Windows.Controls.ListBoxItem>, <xref:System.Windows.FrameworkElement.MaxHeight%2A> анимирует свойство в значение `90` через `0.2` второй период. Когда указатель мыши перемещается за пределы этого элемента, свойство возвращается к исходному значению в течение `1` сек. Обратите внимание на то, как это не требуется указывать <xref:System.Windows.Media.Animation.DoubleAnimation.To%2A> значение <xref:System.Windows.ContentElement.MouseLeave> анимации. Анимация сама может отслеживать исходное значение.  
  
 [!code-xaml[StylingIntroSample_snippet#EventTriggers](~/samples/snippets/csharp/VS_Snippets_Wpf/StylingIntroSample_snippet/CSharp/Window1.xaml#eventtriggers)]  
  
 Подробнее см. в разделе [Общие сведения о раскадровках](../graphics-multimedia/storyboards-overview.md).  
  
 На следующем рисунке указатель мыши указывает на третий элемент:  
  
 ![Снимок экрана стилей](./media/stylingintro-eventtriggers.png "StylingIntro_EventTriggers")  
  
### <a name="multitriggers-datatriggers-and-multidatatriggers"></a>Объекты MultiTrigger, DataTrigger и MultiDataTrigger  
 В дополнение к <xref:System.Windows.Trigger> и <xref:System.Windows.EventTrigger>, существуют другие типы триггеров. <xref:System.Windows.MultiTrigger> позволяет задавать значения свойств на основе нескольких условий. Использовании <xref:System.Windows.DataTrigger> и <xref:System.Windows.MultiDataTrigger> Если это свойство условия имеет привязкой к данным.  
  
<a name="styling_themes"></a>   
## <a name="shared-resources-and-themes"></a>Общие ресурсы и темы  
 Типичное приложение Windows Presentation Foundation (WPF) может иметь несколько ресурсов пользовательского интерфейса (UI), которые применяются в рамках всего приложения. В совокупности этот набор ресурсов можно рассматривать как тему приложения. Windows Presentation Foundation (WPF) обеспечивает поддержку для упаковки ресурсов пользовательского интерфейса как тему с помощью словаря ресурсов, который инкапсулируется как <xref:System.Windows.ResourceDictionary> класса.  
  
 Темы Windows Presentation Foundation (WPF) определяются с помощью механизмов стилизации и шаблонов, предоставляющей Windows Presentation Foundation (WPF) для настройки отображения любого элемента.  
  
 Ресурсы темы Windows Presentation Foundation (WPF), хранятся в словарях внедренных ресурсов. Эти словари ресурсов должны быть внедрены в подписанную сборку и могут быть внедрены либо в ту же сборку, что и сам код, либо в параллельную сборку. В случае библиотеки PresentationFramework.dll, сборку, которая содержит элементы управления Windows Presentation Foundation (WPF), ресурсы тем находятся в ряде side-by-side сборок.  
  
 Тема становится последним местом поиска стиля элемента. Как правило, процесс поиска начинается с прохода вверх по дереву элементов в поисках соответствующего ресурса, затем выполняется поиск в коллекции ресурсов приложения и, наконец, в последнюю очередь осуществляется запрос к системе. Это дает разработчикам приложений возможность переопределить стиль для любого объекта на уровне дерева или приложения до достижения темы.  
  
 Словари ресурсов, оформленные в виде отдельных файлов, позволяют повторно использовать тему в нескольких приложениях. Также можно создать изменяемые темы, определив несколько словарей ресурсов, которые обеспечивают одни и те же типы ресурсов, но с разными значениями. Переопределение этих стилей или других ресурсов на уровне приложения является рекомендуемым способом смены тем приложения.  
  
 Для совместного использования набора ресурсов, включая стили и шаблоны в приложениях, можно создать [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файл и определить <xref:System.Windows.ResourceDictionary>. Например, посмотрите на следующую иллюстрацию — часть [примера "Стилизация с помощью ControlTemplate"](https://github.com/Microsoft/WPF-Samples/tree/master/Styles%20&%20Templates/IntroToStylingAndTemplating):

![Примеры шаблонов элементов управления](./media/stylingintro-controltemplateexamples.png "StylingIntro_ControlTemplateExamples")  
  
 Если взглянуть на файлы [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] в примере, можно заметить, что все файлы имеют следующий код:  
  
 [!code-xaml[ControlTemplateExamples#MergedDictionaries](~/samples/snippets/csharp/VS_Snippets_Wpf/ControlTemplateExamples/CS/resources/button.xaml#mergeddictionaries)]  
  
 Это совместное использование `shared.xaml`, который определяет <xref:System.Windows.ResourceDictionary> , содержащий набор стилей и ресурсов кисти, позволяющий элементам управления, в примере, чтобы иметь согласованный вид.  
  
 Подробнее см. в разделе [Объединенные словари ресурсов](../advanced/merged-resource-dictionaries.md).  
  
 Если вы создаете тему для пользовательского элемента управления, ознакомьтесь с разделом "Внешняя библиотека элементов управления" в материале [Общие сведения о разработке элементов управления](control-authoring-overview.md).  
  
## <a name="see-also"></a>См. также

- [URI типа "pack" в WPF](../app-development/pack-uris-in-wpf.md)
- [Практическое руководство. Поиск элемента, созданного шаблоном ControlTemplate](how-to-find-controltemplate-generated-elements.md)
- [Поиск элементов, созданных с использованием шаблона DataTemplate](../data/how-to-find-datatemplate-generated-elements.md)

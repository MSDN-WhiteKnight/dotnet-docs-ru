---
title: Общие сведения о мультимедиа
ms.date: 03/30/2017
helpviewer_keywords:
- multimedia [WPF]
- media [WPF]
ms.assetid: feb25b15-d741-4ac3-818f-1b19f63a3562
ms.openlocfilehash: 66cb28fce9485898711b9029baf8a17dd9b2c011
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59340494"
---
# <a name="multimedia-overview"></a>Общие сведения о мультимедиа
Мультимедийные возможности Windows Presentation Foundation (WPF) позволяют интегрировать аудио и видео в приложения для расширения возможностей пользователя. В этом разделе представлены мультимедийные возможности WPF.  

<a name="mediaapi"></a>   
## <a name="media-api"></a>API мультимедиа  
 <xref:System.Windows.Controls.MediaElement> И <xref:System.Windows.Media.MediaPlayer> классы используются для представления аудио и видео содержимого. Этими классами можно управлять в интерактивном режиме или с помощью часов. Эти классы можно использовать в элементе управления 10 в [!INCLUDE[TLA#tla_wmp](../../../../includes/tlasharptla-wmp-md.md)] для воспроизведения мультимедиа. Выбор класса зависит от сценария.  
  
 <xref:System.Windows.Controls.MediaElement> — <xref:System.Windows.UIElement> , поддерживаемый [макета](../advanced/layout.md) и могут быть использованы в качестве содержимого многими элементами управления. Его можно также использовать в XAML наряду с программным кодом. <xref:System.Windows.Media.MediaPlayer>, с другой стороны, предназначен для <xref:System.Windows.Media.Drawing> объектов и не поддерживается разметкой. Носитель, загруженный с помощью <xref:System.Windows.Media.MediaPlayer> может быть представлено только с помощью <xref:System.Windows.Media.VideoDrawing> или путем непосредственного взаимодействия с <xref:System.Windows.Media.DrawingContext>. <xref:System.Windows.Media.MediaPlayer> не может использоваться в XAML.  
  
 Дополнительные сведения о графических объектах и контексте рисования см. в разделе [Обзор объектов Drawing](drawing-objects-overview.md).  
  
> [!NOTE]
>  При распространении мультимедиа вместе с приложением файл мультимедиа нельзя использовать как ресурс проекта. Вместо этого в файле проекта необходимо выбрать тип мультимедиа `Content` и задать для `CopyToOutputDirectory` значение `PreserveNewest` или `Always`.  
  
<a name="mediaplaybackmodes"></a>   
## <a name="media-playback-modes"></a>Режимы воспроизведения мультимедиа  
  
> [!NOTE]
>  Оба <xref:System.Windows.Controls.MediaElement> и <xref:System.Windows.Media.MediaPlayer> содержат похожие члены. Ссылки в этом разделе, относятся к <xref:System.Windows.Controls.MediaElement> членов класса. Если не указано иное, члены, связанные в <xref:System.Windows.Controls.MediaElement> класс можно найти также в <xref:System.Windows.Media.MediaPlayer> класса.  
  
 Чтобы понимать принципы воспроизведения мультимедиа в Windows Presentation Foundation (WPF), необходимо знание о различных режимах, в которых может воспроизводиться содержимое мультимедиа. Оба <xref:System.Windows.Controls.MediaElement> и <xref:System.Windows.Media.MediaPlayer> можно использовать в двух различных режимах, независимом режиме и режиме часов. Режим мультимедиа определяется <xref:System.Windows.Controls.MediaElement.Clock%2A> свойство. Когда <xref:System.Windows.Controls.MediaElement.Clock%2A> является `null`, объект мультимедиа находится в независимом режиме. Когда <xref:System.Windows.Controls.MediaElement.Clock%2A> — не null, объект мультимедиа находится в режиме часов. По умолчанию объекты мультимедиа находятся в независимом режиме.  
  
### <a name="independent-mode"></a>Независимый режим  
 В независимом режиме содержимое мультимедиа управляет своим воспроизведением. Независимый режим имеет следующие параметры.  
  
-   Параметр мультимедиа <xref:System.Uri> можно указывать непосредственно.  
  
-   Воспроизведением мультимедиа можно управлять напрямую.  
  
-   Параметр мультимедиа <xref:System.Windows.Controls.MediaElement.Position%2A> и <xref:System.Windows.Controls.MediaElement.SpeedRatio%2A> свойства можно изменить.  
  
 Содержимое мультимедиа загружается, либо присвоив <xref:System.Windows.Controls.MediaElement> объекта <xref:System.Windows.Controls.MediaElement.Source%2A> свойства или путем вызова <xref:System.Windows.Media.MediaPlayer> объекта <xref:System.Windows.Media.MediaPlayer.Open%2A> метод.  
  
 Для управления воспроизведением мультимедиа в независимом режиме можно использовать управляющие методы объекта мультимедиа. Методы управления, доступные <xref:System.Windows.Controls.MediaElement.Play%2A>, <xref:System.Windows.Controls.MediaElement.Pause%2A>, <xref:System.Windows.Controls.MediaElement.Close%2A>, и <xref:System.Windows.Controls.MediaElement.Stop%2A>. Для <xref:System.Windows.Controls.MediaElement>, с помощью этих методов для интерактивного управления доступен только тогда, когда <xref:System.Windows.Controls.MediaElement.LoadedBehavior%2A> присваивается <xref:System.Windows.Controls.MediaState.Manual>. Эти методы недоступны, если объект мультимедиа находится в режиме часов.  
  
 Пример использования независимого режима см. в разделе [Управление элементом MediaElement (воспроизведение, пауза, стоп, громкость и скорость)](how-to-control-a-mediaelement-play-pause-stop-volume-and-speed.md).  
  
### <a name="clock-mode"></a>Режим часов  
 В режиме часов <xref:System.Windows.Media.MediaTimeline> управляет воспроизведением мультимедиа. Режим часов имеет следующие характеристики.  
  
-   Параметр мультимедиа <xref:System.Uri> задано косвенно через <xref:System.Windows.Media.MediaTimeline>.  
  
-   Воспроизведением мультимедиа можно управлять с помощью часов. Нельзя использовать управляющие методы объекта мультимедиа.  
  
-   Содержимое мультимедиа загружается, задав <xref:System.Windows.Media.MediaTimeline> объекта <xref:System.Windows.Media.MediaTimeline.Source%2A> свойством, создания часов по временной шкале и назначением часов объекту мультимедиа. Содержимое мультимедиа загружается таким образом при <xref:System.Windows.Media.MediaTimeline> внутри <xref:System.Windows.Media.Animation.Storyboard> целевых объектов <xref:System.Windows.Controls.MediaElement>.  
  
 Для управления воспроизведением мультимедиа в режиме часов <xref:System.Windows.Media.Animation.ClockController> необходимо использовать управляющие методы. Объект <xref:System.Windows.Media.Animation.ClockController> получается из <xref:System.Windows.Media.Animation.ClockController> свойство <xref:System.Windows.Media.MediaClock>. Если вы попытаетесь использовать управляющие методы элемента <xref:System.Windows.Controls.MediaElement> или <xref:System.Windows.Media.MediaPlayer> объекта в режиме часов <xref:System.InvalidOperationException> будет создано.  
  
 Дополнительные сведения о часах и временных шкалах см. в разделе [Общие сведения об эффектах анимации](animation-overview.md).  
  
 Пример использования режима часов см. в разделе [Управление элементом MediaElement с помощью раскадровки](how-to-control-a-mediaelement-by-using-a-storyboard.md).  
  
<a name="mediaelement"></a>   
## <a name="mediaelement-class"></a>Класс MediaElement  
 Добавление мультимедиа в приложение является простым добавлением <xref:System.Windows.Controls.MediaElement> управления UI  приложения и предоставляя <xref:System.Uri> на носитель, которые требуется включить. Все типы мультимедиа, поддерживаемые [!INCLUDE[TLA#tla_wmp](../../../../includes/tlasharptla-wmp-md.md)] 10, также поддерживаются в Windows Presentation Foundation (WPF). В следующем примере показано простое использование класса <xref:System.Windows.Controls.MediaElement> в XAML.  
  
 [!code-xaml[MediaElement_snip#SimpleMediaElementUsageWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/MediaElement_snip/CSharp/SimpleUsage.xaml#simplemediaelementusagewholepage)]  
  
 В этом примере содержимое мультимедиа воспроизводится автоматически по мере его загрузки. После завершения воспроизведения содержимое мультимедиа закрывается, а все ресурсы мультимедиа освобождаются (включая видеопамять). Это поведение по умолчанию <xref:System.Windows.Controls.MediaElement> объекта и определяется <xref:System.Windows.Controls.MediaElement.LoadedBehavior%2A> и <xref:System.Windows.Controls.MediaElement.UnloadedBehavior%2A> свойства.  
  
### <a name="controlling-a-mediaelement"></a>Управление объектом MediaElement  
 <xref:System.Windows.Controls.MediaElement.LoadedBehavior%2A> И <xref:System.Windows.Controls.MediaElement.UnloadedBehavior%2A> свойства управляют поведением <xref:System.Windows.Controls.MediaElement> при <xref:System.Windows.FrameworkElement.IsLoaded%2A> — `true` или `false`, соответственно. <xref:System.Windows.Controls.MediaState> Свойствам присваивается влияют на поведение воспроизведения мультимедиа. Например, значение по умолчанию <xref:System.Windows.Controls.MediaElement.LoadedBehavior%2A> — <xref:System.Windows.Controls.MediaState.Play> и значение по умолчанию <xref:System.Windows.Controls.MediaElement.UnloadedBehavior%2A> является <xref:System.Windows.Controls.MediaState.Close>. Это означает, что как только <xref:System.Windows.Controls.MediaElement> загружается и выполняется предварительная проба, начинается воспроизведение мультимедиа. После завершения воспроизведения содержимое мультимедиа закрывается и освобождаются все ресурсы мультимедиа.  
  
 <xref:System.Windows.Controls.MediaElement.LoadedBehavior%2A> И <xref:System.Windows.Controls.MediaElement.UnloadedBehavior%2A> свойства не единственный способ управления воспроизведением мультимедиа. В режиме часов, могут управлять часы <xref:System.Windows.Controls.MediaElement> и интерактивные управляющие методы получают управление, если <xref:System.Windows.Controls.MediaElement.LoadedBehavior%2A> является <xref:System.Windows.Controls.MediaState.Manual>. <xref:System.Windows.Controls.MediaElement> обрабатывает конкуренцию за управление, вычисляя следующие приоритеты.  
  
1. <xref:System.Windows.Controls.MediaElement.UnloadedBehavior%2A>. В случае, когда содержимое мультимедиа выгружается. Это гарантирует, что все ресурсы мультимедиа освобождаются по умолчанию, даже если <xref:System.Windows.Media.MediaClock> связан с <xref:System.Windows.Controls.MediaElement>.  
  
2. <xref:System.Windows.Media.MediaClock>. В случае, когда содержимое мультимедиа имеет <xref:System.Windows.Controls.MediaElement.Clock%2A>. Если содержимое мультимедиа выгружается, <xref:System.Windows.Media.MediaClock> вступят в силу, пока <xref:System.Windows.Controls.MediaElement.UnloadedBehavior%2A> является <xref:System.Windows.Controls.MediaState.Manual>. Режим часов всегда переопределяет загруженное правило поведения объекта <xref:System.Windows.Controls.MediaElement>.  
  
3. <xref:System.Windows.Controls.MediaElement.LoadedBehavior%2A>. В случае, когда содержимое мультимедиа загружается.  
  
4. Интерактивные управляющие методы. В случае, если <xref:System.Windows.Controls.MediaElement.LoadedBehavior%2A> является <xref:System.Windows.Controls.MediaState.Manual>. Методы управления, доступные <xref:System.Windows.Controls.MediaElement.Play%2A>, <xref:System.Windows.Controls.MediaElement.Pause%2A>, <xref:System.Windows.Controls.MediaElement.Close%2A>, и <xref:System.Windows.Controls.MediaElement.Stop%2A>.  
  
### <a name="displaying-a-mediaelement"></a>Отображение объекта MediaElement  
 Для отображения <xref:System.Windows.Controls.MediaElement> он должен иметь содержимое, преобразовываемое и будет иметь его <xref:System.Windows.FrameworkElement.ActualWidth%2A> и <xref:System.Windows.FrameworkElement.ActualHeight%2A> свойства установлено в ноль до загрузки содержимого. Для содержимого, в составе которого есть только звук, эти свойства всегда имеют нулевое значение. Для видео после <xref:System.Windows.Controls.MediaElement.MediaOpened> события <xref:System.Windows.FrameworkElement.ActualWidth%2A> и <xref:System.Windows.FrameworkElement.ActualHeight%2A> сообщат размер загружаемого носителя. Это означает, что пока содержимое мультимедиа загружается, <xref:System.Windows.Controls.MediaElement> не занимает физического пространства в UI  Если <xref:System.Windows.FrameworkElement.Width%2A> или <xref:System.Windows.FrameworkElement.Height%2A> свойств.  
  
 Установка <xref:System.Windows.FrameworkElement.Width%2A> и <xref:System.Windows.FrameworkElement.Height%2A> свойства приведут к с носителя растягиваются для заполнения области, предоставленной для <xref:System.Windows.Controls.MediaElement>. Для сохранения файла мультимедиа исходные пропорции, либо <xref:System.Windows.FrameworkElement.Width%2A> или <xref:System.Windows.FrameworkElement.Height%2A> свойство должно иметь значение, но не оба. Установка <xref:System.Windows.FrameworkElement.Width%2A> и <xref:System.Windows.FrameworkElement.Height%2A> свойства приведут к отображению в элементе фиксированного размера, который может быть нежелательно содержимого мультимедиа.  
  
 Чтобы избежать отображения элемента фиксированного размера, Windows Presentation Foundation (WPF) может сделать предварительную пробу содержимого мультимедиа. Это сделать, задав <xref:System.Windows.Controls.MediaElement.LoadedBehavior%2A> либо <xref:System.Windows.Controls.MediaState.Play> или <xref:System.Windows.Controls.MediaState.Pause>. В <xref:System.Windows.Controls.MediaState.Pause> state, мультимедиа будет сделана предварительная проба и будет показан первый кадр. В <xref:System.Windows.Controls.MediaState.Play> state, будет сделана предварительная проба и начнет воспроизведение мультимедиа.  
  
<a name="mediaplayer"></a>   
## <a name="mediaplayer-class"></a>Класс MediaPlayer  
 Тогда как <xref:System.Windows.Controls.MediaElement> класс — это элемент платформы <xref:System.Windows.Media.MediaPlayer> класс предназначен для использования в <xref:System.Windows.Media.Drawing> объектов. Графические объекты используются в том случае, когда можно пожертвовать возможностями уровня среды ради улучшения производительности или при необходимости <xref:System.Windows.Freezable> функции. <xref:System.Windows.Media.MediaPlayer> позволяет воспользоваться преимуществами этих функций, предоставляя мультимедийного содержимого в приложениях. Как и <xref:System.Windows.Controls.MediaElement>, <xref:System.Windows.Media.MediaPlayer> можно использовать в независимом или режиме часов, но может не иметь <xref:System.Windows.Controls.MediaElement> выгрузки и загрузки состояния объекта. Это уменьшает сложность управления воспроизведением <xref:System.Windows.Media.MediaPlayer>.  
  
### <a name="controlling-mediaplayer"></a>Управление объектом MediaPlayer  
 Так как <xref:System.Windows.Media.MediaPlayer> — без отслеживания состояния, существуют только два способа управления воспроизведением мультимедиа.  
  
1. Интерактивные управляющие методы. В случае независимого режима (`null`<xref:System.Windows.Media.MediaPlayer.Clock%2A> свойство).  
  
2. <xref:System.Windows.Media.MediaClock>. В случае, когда содержимое мультимедиа имеет <xref:System.Windows.Media.MediaPlayer.Clock%2A>.  
  
### <a name="displaying-a-mediaplayer"></a>Отображение объекта MediaPlayer  
 С технической точки зрения <xref:System.Windows.Media.MediaPlayer> невозможно, так как он не имеет физического представления. Тем не менее, его можно использовать для отображения содержимого мультимедиа в <xref:System.Windows.Media.Drawing> с помощью <xref:System.Windows.Media.VideoDrawing> класса. В следующем примере показано использование <xref:System.Windows.Media.VideoDrawing> для отображения мультимедиа.  
  
 [!code-csharp[DrawingMiscSnippets_snip#VideoDrawingExampleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/DrawingMiscSnippets_snip/CSharp/VideoDrawingExample.cs#videodrawingexampleinline)]  
  
 См. в разделе [Обзор объектов Drawing](drawing-objects-overview.md) Дополнительные сведения о <xref:System.Windows.Media.Drawing> объектов.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.DrawingGroup>
- [Макет](../advanced/layout.md)
- [Практические руководства](audio-and-video-how-to-topics.md)

---
title: 'Оптимизация производительности: Другие рекомендации'
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Terminal Services rendering [WPF]
- opacity [WPF]
- hit-test objects [WPF]
- ScrollBarVisibility enumeration [WPF]
- brushes [WPF], performance
ms.assetid: d028cc65-7e97-4a4f-9859-929734eaf40d
ms.openlocfilehash: 56d3e3cad09b46090a11b884f3ac590e8d4ba23a
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59224290"
---
# <a name="optimizing-performance-other-recommendations"></a>Оптимизация производительности: Другие рекомендации
<a name="introduction"></a> В этом разделе содержатся рекомендации по улучшению производительности в дополнение к описанным в разделах статьи [Улучшение производительности приложений WPF](optimizing-wpf-application-performance.md).  
  
 В этом разделе содержатся следующие подразделы.  
  
-   [Сравнение прозрачности кисти с прозрачностью элементов](#Opacity)  
  
-   [Переход к объекту](#Navigation_Objects)  
  
-   [Проверка попадания курсора мыши на больших трехмерных поверхностях](#Hit_Testing)  
  
-   [Событие CompositionTarget.Rendering](#CompositionTarget_Rendering_Event)  
  
-   [Избегайте использования ScrollBarVisibility=Auto](#Avoid_Using_ScrollBarVisibility)  
  
-   [Настройка службы кэширования шрифтов для сокращения времени загрузки](#FontCache)  
  
<a name="Opacity"></a>   
## <a name="opacity-on-brushes-versus-opacity-on-elements"></a>Сравнение прозрачности кисти с прозрачностью элементов  
 При использовании <xref:System.Windows.Media.Brush> присвоить <xref:System.Windows.Shapes.Shape.Fill%2A> или <xref:System.Windows.Shapes.Shape.Stroke%2A> элемента, лучше задать <xref:System.Windows.Media.Brush.Opacity%2A?displayProperty=nameWithType> преимущества, а не параметр элемента <xref:System.Windows.UIElement.Opacity%2A> свойство. Изменение элемента <xref:System.Windows.UIElement.Opacity%2A> свойство может привести к WPF создание временной поверхности.  
  
<a name="Navigation_Objects"></a>   
## <a name="navigation-to-object"></a>Переход к объекту  
 <xref:System.Windows.Navigation.NavigationWindow> Объект является производным от <xref:System.Windows.Window> и расширяет его поддержкой навигации по содержимому, главным образом путем объединения <xref:System.Windows.Navigation.NavigationService> и журнала. Вы можете обновить клиентскую область <xref:System.Windows.Navigation.NavigationWindow> , если указать [!INCLUDE[TLA#tla_uri](../../../../includes/tlasharptla-uri-md.md)] или объект. В следующем примере демонстрируются оба способа.  
  
 [!code-csharp[Performance#PerformanceSnippet14](~/samples/snippets/csharp/VS_Snippets_Wpf/Performance/CSharp/TestNavigation.xaml.cs#performancesnippet14)]
   
  
 Каждый <xref:System.Windows.Navigation.NavigationWindow> объект имеет журнал, в котором записывается история переходов данного пользователя в этом окне. Одной из целей создания журнала является возможность разрешить пользователям повторять действия.  
  
 При навигации с помощью [!INCLUDE[TLA#tla_uri](../../../../includes/tlasharptla-uri-md.md)] журнал сохраняет только ссылку [!INCLUDE[TLA#tla_uri](../../../../includes/tlasharptla-uri-md.md)]. Это означает, что каждый раз при повторном посещении страницы она динамически перестраивается за время, зависящее от сложности страницы. В этом случае затраты на хранение журнала незначительны, а скорость воссоздания страниц является потенциально высокой.  
  
 При переходе с помощью объекта в журнал сохраняется полное визуальное дерево объекта. Это означает, что при каждом повторном посещении страницы она отображается немедленно без необходимости реконструирования. В этом случае затраты на хранение журнала высоки, а скорость воссоздания страниц низкая.  
  
 При использовании <xref:System.Windows.Navigation.NavigationWindow> объекта, необходимо будет следует учитывать влияние журналирования на производительность приложения. Дополнительные сведения см. в разделе [Общие сведения о переходах](../app-development/navigation-overview.md).  
  
<a name="Hit_Testing"></a>   
## <a name="hit-testing-on-large-3d-surfaces"></a>Проверка попадания курсора мыши на больших трехмерных поверхностях  
 Проверка попадания курсора мыши на больших трехмерных поверхностях является операцией, очень затратной по производительности и загрузке процессора. Особенно это относится к анимированным трехмерным поверхностям. Если проверка попадания курсора на этих поверхностях не требуется, то ее следует отключить. Объекты, которые являются производными от <xref:System.Windows.UIElement> могут отключить проверку, задав <xref:System.Windows.UIElement.IsHitTestVisible%2A> свойства `false`.  
  
<a name="CompositionTarget_Rendering_Event"></a>   
## <a name="compositiontargetrendering-event"></a>Событие CompositionTarget.Rendering  
 <xref:System.Windows.Media.CompositionTarget.Rendering?displayProperty=nameWithType> Событие вызывает WPF для поддержки постоянной анимации. Если это событие используется, отключайте его при каждой возможности.  
  
<a name="Avoid_Using_ScrollBarVisibility"></a>   
## <a name="avoid-using-scrollbarvisibilityauto"></a>Избегайте использования ScrollBarVisibility=Auto  
 По возможности избегайте использования <xref:System.Windows.Controls.ScrollBarVisibility.Auto?displayProperty=nameWithType> значение `HorizontalScrollBarVisibility` и `VerticalScrollBarVisibility` свойства. Эти свойства определяются для <xref:System.Windows.Controls.RichTextBox>, <xref:System.Windows.Controls.ScrollViewer>, и <xref:System.Windows.Controls.TextBox> объектов и как присоединенное свойство для <xref:System.Windows.Controls.ListBox> объекта. Вместо этого задайте <xref:System.Windows.Controls.ScrollBarVisibility> для <xref:System.Windows.Controls.ScrollBarVisibility.Disabled>, <xref:System.Windows.Controls.ScrollBarVisibility.Hidden>, или <xref:System.Windows.Controls.ScrollBarVisibility.Visible>.  
  
 <xref:System.Windows.Controls.ScrollBarVisibility.Auto> Значение предназначен для случаев, когда пространство ограничено и полосы прокрутки должны отображаться, только когда это необходимо. Например, может быть полезно использовать это <xref:System.Windows.Controls.ScrollBarVisibility> со значением <xref:System.Windows.Controls.ListBox> 30 элементов, в отличие от <xref:System.Windows.Controls.TextBox> с сотнями строк текста.  
  
<a name="FontCache"></a>   
## <a name="configure-font-cache-service-to-reduce-start-up-time"></a>Настройка службы кэширования шрифтов для сокращения времени загрузки  
 Служба кэширования шрифтов [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] используется для совместной обработки данных шрифтов приложениями [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)]. Первое запускаемое приложение [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] запускает эту службу, если она еще не запущена. Если вы используете [!INCLUDE[TLA#tla_winvista](../../../../includes/tlasharptla-winvista-md.md)], можно задать службы «Windows Presentation Foundation (WPF) Font Cache 3.0.0.0» из «Вручную» (по умолчанию) «Автоматически (отложенный запуск)», чтобы уменьшить длительность начального запуска [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] приложений.  
  
## <a name="see-also"></a>См. также

- [Планирование производительности приложения](planning-for-application-performance.md)
- [Использование преимуществ оборудования](optimizing-performance-taking-advantage-of-hardware.md)
- [Разметка и разработка](optimizing-performance-layout-and-design.md)
- [Двумерная графика и изображения](optimizing-performance-2d-graphics-and-imaging.md)
- [Поведение объекта](optimizing-performance-object-behavior.md)
- [Ресурсы приложений](optimizing-performance-application-resources.md)
- [Текста](optimizing-performance-text.md)
- [Привязка данных](optimizing-performance-data-binding.md)
- [Советы и рекомендации по анимации](../graphics-multimedia/animation-tips-and-tricks.md)

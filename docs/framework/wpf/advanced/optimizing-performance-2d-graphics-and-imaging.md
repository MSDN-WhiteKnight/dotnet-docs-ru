---
title: 'Оптимизация производительности: Двумерная графика и изображения'
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- graphics [WPF], performance
- drawing [WPF], optimizing performance
- imaging [WPF], optimizing performance
- shapes [WPF], optimizing performance
- 2-D graphics [WPF]
- images [WPF], optimizing performance
ms.assetid: e335601e-28c8-4d64-ba27-778fffd55f72
ms.openlocfilehash: 4fca9231872a268470c9bcfa73e7a0c0a26d300c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59074993"
---
# <a name="optimizing-performance-2d-graphics-and-imaging"></a>Оптимизация производительности: Двумерная графика и изображения
[!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] предоставляет широкий спектр двумерная графика и возможность обработки изображений, которые можно оптимизировать для требований приложения. Этот раздел содержит сведения об оптимизации производительности в этих областях.  

<a name="Drawing_and_Shapes"></a>   
## <a name="drawing-and-shapes"></a>Рисование и фигуры  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] предоставляет оба <xref:System.Windows.Media.Drawing> и <xref:System.Windows.Shapes.Shape> объектов для представления графического контента. Тем не менее <xref:System.Windows.Media.Drawing> объекты являются более простыми конструкциями, чем <xref:System.Windows.Shapes.Shape> объектов и обеспечивают лучшие показатели производительности.  
  
 Объект <xref:System.Windows.Shapes.Shape> позволяет нарисовать графическую фигуру на экране. Так как они являются производными от <xref:System.Windows.FrameworkElement> класс, <xref:System.Windows.Shapes.Shape> объекты могут использоваться внутри панелей и большинства элементов управления.  
  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] предоставляет несколько уровней доступа к графикой и службам рендеринга. На верхнем уровне <xref:System.Windows.Shapes.Shape> объекты просты в использовании и предоставляют множество полезных функций, таких как макет и обработка событий. [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] предоставляет ряд готовых к использованию фигуры. Все объекты фигур наследуются от <xref:System.Windows.Shapes.Shape> класса. Доступные объекты фигур включают <xref:System.Windows.Shapes.Ellipse>, <xref:System.Windows.Shapes.Line>, <xref:System.Windows.Shapes.Path>, <xref:System.Windows.Shapes.Polygon>, <xref:System.Windows.Shapes.Polyline>, и <xref:System.Windows.Shapes.Rectangle>.  
  
 <xref:System.Windows.Media.Drawing> объекты, с другой стороны, не являющихся производными от <xref:System.Windows.FrameworkElement> класса и предоставляют упрощенную реализацию отрисовки фигур, изображений и текста.  
  
 Существует четыре типа <xref:System.Windows.Media.Drawing> объектов:  
  
-   <xref:System.Windows.Media.GeometryDrawing> Рисует фигуру.  
  
-   <xref:System.Windows.Media.ImageDrawing> Рисует изображение.  
  
-   <xref:System.Windows.Media.GlyphRunDrawing> Рисует текст.  
  
-   <xref:System.Windows.Media.DrawingGroup> Рисует другие рисунки. Для объединения рисунков в один составной используйте группирование рисунков.  
  
 <xref:System.Windows.Media.GeometryDrawing> Объект используется для отрисовки геометрического содержимого. <xref:System.Windows.Media.Geometry> Класс и конкретные классы, производные от него, такие как <xref:System.Windows.Media.CombinedGeometry>, <xref:System.Windows.Media.EllipseGeometry>, и <xref:System.Windows.Media.PathGeometry>, предоставляют средства для отрисовки двумерной графики, а также предоставляет возможности попадания и поддержки обрезки. Геометрические объекты можно использовать, например, для определения области элемента управления или для определения области усечения, применяемой к изображению. Геометрические объекты могут быть простыми, такими как прямоугольники и круги, или сложными, созданными из двух или более геометрических объектов. Более сложные геометрические области можно создать путем объединения <xref:System.Windows.Media.PathSegment>-производных объектов, таких как <xref:System.Windows.Media.ArcSegment>, <xref:System.Windows.Media.BezierSegment>, и <xref:System.Windows.Media.QuadraticBezierSegment>.  
  
 В рабочей области <xref:System.Windows.Media.Geometry> класс и <xref:System.Windows.Shapes.Shape> класс весьма похожи. Оба используются в рендеринге двумерной графики и оба имеют аналогичные конкретные классы, которые являются производными от них, например, <xref:System.Windows.Media.EllipseGeometry> и <xref:System.Windows.Shapes.Ellipse>. Однако существуют важные различия между этими двумя наборами классов. Например <xref:System.Windows.Media.Geometry> класса отсутствуют некоторые функциональные возможности <xref:System.Windows.Shapes.Shape> класса, такие как возможность рисования самого себя. Чтобы нарисовать геометрический объект, для выполнения операции рисования должен использоваться другой класс, например DrawingContext, Drawing или Path (стоит отметить, что Path является Shape). Свойства рендеринга, такие как заливка (fill), штрих (stroke) и толщина штриха (stroke thickness), находятся в классе, который рисует этот геометрический объект, в то время как объект Shape содержит эти свойства. Чтобы понять это различие, представьте, что геометрический объект определяет область, например круг, а объект Shape определяет область, определяет, как эта область заполняется и обводится, а также участвует в системе макета.  
  
 Так как <xref:System.Windows.Shapes.Shape> объекты являются производными от <xref:System.Windows.FrameworkElement> класса, с их помощью можно добавить значительно увеличить потребление памяти в приложении. Если вам действительно не нужен <xref:System.Windows.FrameworkElement> функции для вашего графического контента, рассмотрите возможность использования упрощенных <xref:System.Windows.Media.Drawing> объектов.  
  
 Дополнительные сведения о <xref:System.Windows.Media.Drawing> объектов, см. в разделе [Обзор объектов Drawing](../graphics-multimedia/drawing-objects-overview.md).  
  
<a name="StreamGeometry_Objects"></a>   
## <a name="streamgeometry-objects"></a>Объекты StreamGeometry  
 <xref:System.Windows.Media.StreamGeometry> Объект — это Упрощенная альтернатива <xref:System.Windows.Media.PathGeometry> для создания геометрических фигур. Используйте <xref:System.Windows.Media.StreamGeometry> для описания сложной геометрии. <xref:System.Windows.Media.StreamGeometry> оптимизирован для обработки большого количества <xref:System.Windows.Media.PathGeometry> объектов и выполняется быстрее по сравнению с использованием нескольких отдельных <xref:System.Windows.Media.PathGeometry> объектов.  
  
 В следующем примере синтаксис атрибутов для создания треугольного <xref:System.Windows.Media.StreamGeometry> в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)].  
  
 [!code-xaml[GeometriesMiscSnippets_snip#StreamGeometryTriangleExampleWholePage](~/samples/snippets/xaml/VS_Snippets_Wpf/GeometriesMiscSnippets_snip/XAML/StreamGeometryExample.xaml#streamgeometrytriangleexamplewholepage)]  
  
 Дополнительные сведения о <xref:System.Windows.Media.StreamGeometry> объектов, см. в разделе [Создание фигуры с помощью StreamGeometry](../graphics-multimedia/how-to-create-a-shape-using-a-streamgeometry.md).  
  
<a name="DrawingVisual_Objects"></a>   
## <a name="drawingvisual-objects"></a>объекты DrawingVisual  
 <xref:System.Windows.Media.DrawingVisual> Объект — это упрощенный класс, который используется для отрисовки фигур, изображений и текста. Этот класс считается упрощенным, так как не предоставляет средств для работы с разметкой и обработку событий, что повышает его производительность. Поэтому этот класс идеально подходит для фоновых рисунков или клипов. Дополнительные сведения см. в разделе [Использование объектов DrawingVisual](../graphics-multimedia/using-drawingvisual-objects.md).  
  
<a name="Images"></a>   
## <a name="images"></a>Изображений  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] Создание образов значительно улучшилась по сравнению с возможностями обработки изображений в предыдущих версиях [!INCLUDE[TLA#tla_mswin](../../../../includes/tlasharptla-mswin-md.md)]. Возможности обработки изображений, например вывод растрового изображения или использование изображения в общем элементе управления, в основном управлялись интерфейсом графических устройств (GDI) Microsoft Windows или Microsoft Windows GDI и программным интерфейсом (API). Эти API обеспечивали базовые функции обработки изображений, но в них отсутствовали такие возможности, как поддержка расширяемости кодеков и изображений высокого качества. API обработки изображений WPF был переработан для преодоления недостатков GDI и GDI+ и теперь предоставляет новый набор API для отображения и использования изображений в приложениях.  
  
 При использовании изображений учитывайте следующие рекомендации, позволяющие повысить производительность.  
  
-   Если в приложении требуется отображение эскизов, рассмотрите возможность создания версий изображений уменьшенного размера. По умолчанию [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] загружает изображение и преобразует его до полного размера. Если требуется только эскиз изображения, [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] напрасно преобразует изображение до полного размера, а затем масштабирует его до размера эскиза. Чтобы избежать этой лишней нагрузки, можно либо запросить в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] преобразование изображения в размер эскиза, либо настроить [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] для загрузки изображения размера эскиза.  
  
-   Всегда преобразуйте изображение в нужный размер, а не размер по умолчанию. Как упоминалось выше, запросите в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] преобразование изображения в нужный размер, а не в полный размер по умолчанию. Вы уменьшите не только рабочий набор приложения, но также и время ожидания выполнения.  
  
-   Если это возможно, объединяйте изображения в одно изображение, например диафильм, состоящий из нескольких изображений.  
  
-   Более подробную информацию см. в разделе [Общие сведения об обработке изображений](../graphics-multimedia/imaging-overview.md).  
  
### <a name="bitmapscalingmode"></a>BitmapScalingMode  
 При анимации масштабирования любого растрового изображения алгоритм повторной дискретизации изображения высокого качества по умолчанию иногда может использовать столько системных ресурсов, чтобы привести к снижению частоты кадров анимации и задержкам. Установив <xref:System.Windows.Media.RenderOptions.BitmapScalingMode%2A> свойство <xref:System.Windows.Media.RenderOptions> объект <xref:System.Windows.Media.BitmapScalingMode.LowQuality> можно создавать более плавную анимацию при масштабировании растрового изображения. <xref:System.Windows.Media.BitmapScalingMode.LowQuality> Указывает режим [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] механизм визуализации для переключения с помощью алгоритма, оптимизированного по качеству алгоритм, оптимизированный по скорости, при обработке изображений.  
  
 В следующем примере показано, как задать <xref:System.Windows.Media.BitmapScalingMode> для объекта изображения.  
  
 [!code-csharp[RenderOptions#RenderOptionsSnippet2](~/samples/snippets/csharp/VS_Snippets_Wpf/RenderOptions/CSharp/Window1.xaml.cs#renderoptionssnippet2)]
   
  
### <a name="cachinghint"></a>CachingHint  
 По умолчанию [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] не кэширует готовое для просмотра содержимое <xref:System.Windows.Media.TileBrush> объекты, такие как <xref:System.Windows.Media.DrawingBrush> и <xref:System.Windows.Media.VisualBrush>. В статических сценариях, где ни содержимое, ни использование <xref:System.Windows.Media.TileBrush> в сцене изменяется, это имеет смысл, так как экономит видеопамять. Не выполняет как смысла, если <xref:System.Windows.Media.TileBrush> со статическим содержимым используется в нестатическим способом — например, когда статический <xref:System.Windows.Media.DrawingBrush> или <xref:System.Windows.Media.VisualBrush> сопоставляется с поверхности поворота трехмерного объекта. По умолчанию [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] повторно отрисовывает все содержимое <xref:System.Windows.Media.DrawingBrush> или <xref:System.Windows.Media.VisualBrush> для каждого кадра, даже если содержимое не изменяется.  
  
 Установив <xref:System.Windows.Media.RenderOptions.CachingHint%2A> свойство <xref:System.Windows.Media.RenderOptions> объект <xref:System.Windows.Media.CachingHint.Cache> может повысить производительность благодаря использованию кэшированных версий объектов мозаичной кисти.  
  
 <xref:System.Windows.Media.RenderOptions.CacheInvalidationThresholdMinimum%2A> И <xref:System.Windows.Media.RenderOptions.CacheInvalidationThresholdMaximum%2A> значения свойств являются относительными значениями размера, определяющими <xref:System.Windows.Media.TileBrush> объект должен быть создан повторно из-за изменения масштаба. Например, установив <xref:System.Windows.Media.RenderOptions.CacheInvalidationThresholdMaximum%2A> свойства в кэше для 2.0 <xref:System.Windows.Media.TileBrush> только необходимо повторно создать при его размер вдвое превысит размер текущего кэша.  
  
 В следующем примере показано, как использование параметра указания кэширования для <xref:System.Windows.Media.DrawingBrush>.  
  
 [!code-csharp[RenderOptions#RenderOptionsSnippet3](~/samples/snippets/csharp/VS_Snippets_Wpf/RenderOptions/CSharp/Window1.xaml.cs#renderoptionssnippet3)]
   
  
## <a name="see-also"></a>См. также

- [Улучшение производительности приложений WPF](optimizing-wpf-application-performance.md)
- [Планирование производительности приложения](planning-for-application-performance.md)
- [Использование преимуществ оборудования](optimizing-performance-taking-advantage-of-hardware.md)
- [Разметка и разработка](optimizing-performance-layout-and-design.md)
- [Поведение объекта](optimizing-performance-object-behavior.md)
- [Ресурсы приложений](optimizing-performance-application-resources.md)
- [Текста](optimizing-performance-text.md)
- [Привязка данных](optimizing-performance-data-binding.md)
- [Дополнительные рекомендации по повышению производительности](optimizing-performance-other-recommendations.md)
- [Советы и рекомендации по анимации](../graphics-multimedia/animation-tips-and-tricks.md)

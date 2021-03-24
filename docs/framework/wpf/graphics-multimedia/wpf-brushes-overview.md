---
title: Общие сведения о кистях WPF
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- brushes [WPF], about brushes
ms.assetid: ecea1955-420b-45c6-bf43-c1404c072c41
ms.openlocfilehash: 14e3d095d50f41e5b20a79d76c464bcf28c99327
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59132214"
---
# <a name="wpf-brushes-overview"></a>Общие сведения о кистях WPF
Все элементы, видимые на экране отображается, так как они нарисованы кистью. Например кисть используется для описания фона кнопки, основного цвета текста и заливки фигуры. В этом разделе понятия рисования с помощью Windows Presentation Foundation (WPF) кисти и приводятся примеры. Кисти позволяют заполнять объекты [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)] различными изображениями, начиная с просто сплошного цвета и заканчивая сложными наборами шаблонов и изображений.  
  
<a name="paintingwithbrush"></a>   
## <a name="painting-with-a-brush"></a>Рисование с помощью кисти  
 Объект <xref:System.Windows.Media.Brush> «заполняет» область его выходные данные. Различных кистей имеют разные типы выходных данных. Некоторые кисти закрашивают область сплошным цветом, другие пользователи с градиентом, шаблон, изображения или рисования. Ниже показаны примеры каждого из <xref:System.Windows.Media.Brush> типов.  
  
 ![Типы кистей](./media/graphicsmm-brushtypes.jpg "graphicsmm_brushtypes")  
Примеры кисти  
  
 Большинство визуальных объектов дают возможность задать способ рисования. В следующей таблице перечислены некоторые распространенные объекты и свойства, с помощью которых можно использовать <xref:System.Windows.Media.Brush>.  
  
|Класс|Свойства кисти|  
|-----------|----------------------|  
|<xref:System.Windows.Controls.Border>|<xref:System.Windows.Controls.Border.BorderBrush%2A>, <xref:System.Windows.Controls.Border.Background%2A>|  
|<xref:System.Windows.Controls.Control>|<xref:System.Windows.Controls.Control.Background%2A>, <xref:System.Windows.Controls.Control.Foreground%2A>|  
|<xref:System.Windows.Controls.Panel>|<xref:System.Windows.Controls.Panel.Background%2A>|  
|<xref:System.Windows.Media.Pen>|<xref:System.Windows.Media.Pen.Brush%2A>|  
|<xref:System.Windows.Shapes.Shape>|<xref:System.Windows.Shapes.Shape.Fill%2A>, <xref:System.Windows.Shapes.Shape.Stroke%2A>|  
|<xref:System.Windows.Controls.TextBlock>|<xref:System.Windows.Controls.TextBlock.Background%2A>|  
  
 В следующих разделах описываются различные <xref:System.Windows.Media.Brush> типы, а также приведены примеры каждого из них.  
  
<a name="paintwithsolidcolorbrush"></a>   
## <a name="paint-with-a-solid-color"></a>Заливкой сплошным цветом  
 Объект <xref:System.Windows.Media.SolidColorBrush> закрашивает область сплошным <xref:System.Windows.Media.Color>. Существует множество способов указания <xref:System.Windows.Media.SolidColorBrush.Color%2A> из <xref:System.Windows.Media.SolidColorBrush>: например, можно указать его альфа-, красный, синий и зеленый каналы или использовать один из цветов, предоставленных <xref:System.Windows.Media.Colors> класса.  
  
 В следующем примере используется <xref:System.Windows.Media.SolidColorBrush> для закрашивания <xref:System.Windows.Shapes.Shape.Fill%2A> из <xref:System.Windows.Shapes.Rectangle>. На следующем рисунке показан закрашенный прямоугольник.  
  
 ![Прямоугольник, закрашенный с использованием SolidColorBrush](./media/graphicsmm-brush-ovw-solidcolorbrush.png "graphicsmm_brush_ovw_solidcolorbrush")  
Прямоугольник, закрашенный с использованием SolidColorBrush  
  
 [!code-csharp[BrushesIntroduction_snip#GraphicsMMSolidColorBrushExampleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/BrushesIntroduction_snip/CSharp/BrushTypesExample.cs#graphicsmmsolidcolorbrushexampleinline)]
 
 [!code-xaml[BrushesIntroduction_snip#GraphicsMMSolidColorBrushExampleInline](~/samples/snippets/xaml/VS_Snippets_Wpf/BrushesIntroduction_snip/XAML/BrushTypesExample.xaml#graphicsmmsolidcolorbrushexampleinline)]  
  
 Дополнительные сведения о <xref:System.Windows.Media.SolidColorBrush> , представлена в разделе [закраске сплошным цветом и градиентом Обзор](painting-with-solid-colors-and-gradients-overview.md).  
  
<a name="paintwithlineargradientbrush"></a>   
## <a name="paint-with-a-linear-gradient"></a>Рисование с линейным градиентом  
 Объект <xref:System.Windows.Media.LinearGradientBrush> закрашивает область с линейным градиентом. Линейный градиент сочетает несколько цветов через строку оси градиента. Использовании <xref:System.Windows.Media.GradientStop> объекты для указания цветов в градиенте и их положения.  
  
 В следующем примере используется <xref:System.Windows.Media.LinearGradientBrush> для закрашивания <xref:System.Windows.Shapes.Shape.Fill%2A> из <xref:System.Windows.Shapes.Rectangle>. На следующем рисунке показан закрашенный прямоугольник.  
  
 ![Прямоугольник, закрашенный с помощью LinearGradientBrush](./media/graphicsmm-brush-ovw-lineargradientbrush.jpg "graphicsmm_brush_ovw_lineargradientbrush")  
Прямоугольник, закрашенный с помощью LinearGradientBrush  
  
 [!code-csharp[BrushesIntroduction_snip#GraphicsMMLinearGradientBrushExampleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/BrushesIntroduction_snip/CSharp/BrushTypesExample.cs#graphicsmmlineargradientbrushexampleinline)]
 
 [!code-xaml[BrushesIntroduction_snip#GraphicsMMLinearGradientBrushExampleInline](~/samples/snippets/xaml/VS_Snippets_Wpf/BrushesIntroduction_snip/XAML/BrushTypesExample.xaml#graphicsmmlineargradientbrushexampleinline)]  
  
 Дополнительные сведения о <xref:System.Windows.Media.LinearGradientBrush> , представлена в разделе [закраске сплошным цветом и градиентом Обзор](painting-with-solid-colors-and-gradients-overview.md).  
  
<a name="paintwithradialgradientbrush"></a>   
## <a name="paint-with-a-radial-gradient"></a>Рисование с применением радиального градиента  
 Объект <xref:System.Windows.Media.RadialGradientBrush> закрашивает область с применением радиального градиента. Радиальный градиент сочетает несколько цветов через окружность. Как и в <xref:System.Windows.Media.LinearGradientBrush> , использовать <xref:System.Windows.Media.GradientStop> объекты для указания цветов в градиенте и их положения.  
  
 В следующем примере используется <xref:System.Windows.Media.RadialGradientBrush> для закрашивания <xref:System.Windows.Shapes.Shape.Fill%2A> из <xref:System.Windows.Shapes.Rectangle>. На следующем рисунке показан закрашенный прямоугольник.  
  
 ![Прямоугольник, закрашенный с использованием RadialGradientBrush](./media/graphicsmm-brush-ovw-radialgradientbrush.jpg "graphicsmm_brush_ovw_radialgradientbrush")  
Прямоугольник, закрашенный с использованием RadialGradientBrush  
  
 [!code-csharp[BrushesIntroduction_snip#GraphicsMMRadialGradientBrushExampleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/BrushesIntroduction_snip/CSharp/BrushTypesExample.cs#graphicsmmradialgradientbrushexampleinline)]
 
 [!code-xaml[BrushesIntroduction_snip#GraphicsMMRadialGradientBrushExampleInline](~/samples/snippets/xaml/VS_Snippets_Wpf/BrushesIntroduction_snip/XAML/BrushTypesExample.xaml#graphicsmmradialgradientbrushexampleinline)]  
  
 Дополнительные сведения о <xref:System.Windows.Media.RadialGradientBrush> , представлена в разделе [закраске сплошным цветом и градиентом Обзор](painting-with-solid-colors-and-gradients-overview.md).  
  
<a name="paintwithimage"></a>   
## <a name="paint-with-an-image"></a>Рисование с помощью изображения  
 <xref:System.Windows.Media.ImageBrush> Закрашивает область с <xref:System.Windows.Media.ImageSource>.  
  
 В следующем примере используется <xref:System.Windows.Media.ImageBrush> для закрашивания <xref:System.Windows.Shapes.Shape.Fill%2A> из <xref:System.Windows.Shapes.Rectangle>. На следующем рисунке показан закрашенный прямоугольник.  
  
 ![Прямоугольник, закрашенный с ImageBrush](./media/graphicsmm-brush-ovw-imagebrush.jpg "graphicsmm_brush_ovw_imagebrush")  
Прямоугольник, закрашенный с помощью образа  
  
 [!code-csharp[BrushesIntroduction_snip#GraphicsMMImageBrushExampleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/BrushesIntroduction_snip/CSharp/BrushTypesExample.cs#graphicsmmimagebrushexampleinline)]
 
 [!code-xaml[BrushesIntroduction_snip#GraphicsMMImageBrushExampleInline](~/samples/snippets/xaml/VS_Snippets_Wpf/BrushesIntroduction_snip/XAML/BrushTypesExample.xaml#graphicsmmimagebrushexampleinline)]  
  
 Дополнительные сведения о <xref:System.Windows.Media.ImageBrush> , представлена в разделе [Рисование с помощью изображений, рисунков и визуальных элементов](painting-with-images-drawings-and-visuals.md).  
  
<a name="paintwithdrawing"></a>   
## <a name="paint-with-a-drawing"></a>Рисования с помощью рисунка  
 Объект <xref:System.Windows.Media.DrawingBrush> закрашивает область с <xref:System.Windows.Media.Drawing>. Объект <xref:System.Windows.Media.Drawing> может содержать фигуры, изображения, текста и мультимедиа.  
  
 В следующем примере используется <xref:System.Windows.Media.DrawingBrush> для закрашивания <xref:System.Windows.Shapes.Shape.Fill%2A> из <xref:System.Windows.Shapes.Rectangle>. На следующем рисунке показан закрашенный прямоугольник.  
  
 ![Прямоугольник, закрашенный с помощью DrawingBrush](./media/graphicsmm-brush-ovw-drawingbrush.jpg "graphicsmm_brush_ovw_drawingbrush")  
Прямоугольник, закрашенный с помощью DrawingBrush  
  
 [!code-csharp[BrushesIntroduction_snip#GraphicsMMDrawingBrushExampleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/BrushesIntroduction_snip/CSharp/BrushTypesExample.cs#graphicsmmdrawingbrushexampleinline)]
 
 [!code-xaml[BrushesIntroduction_snip#GraphicsMMDrawingBrushExampleInline](~/samples/snippets/xaml/VS_Snippets_Wpf/BrushesIntroduction_snip/XAML/BrushTypesExample.xaml#graphicsmmdrawingbrushexampleinline)]  
  
 Дополнительные сведения о <xref:System.Windows.Media.DrawingBrush> , представлена в разделе [Рисование с помощью изображений, рисунков и визуальных элементов](painting-with-images-drawings-and-visuals.md).  
  
<a name="paintwithvisual"></a>   
## <a name="paint-with-a-visual"></a>Рисование с помощью Visual  
 Объект <xref:System.Windows.Media.VisualBrush> закрашивает область с <xref:System.Windows.Media.Visual> объекта. Примеры визуальных объектов <xref:System.Windows.Controls.Button>, <xref:System.Windows.Controls.Page>, и <xref:System.Windows.Controls.MediaElement>. Объект <xref:System.Windows.Media.VisualBrush> также позволяет переносить содержимое из одной части приложения в другую область; это очень полезно для создания эффектов отражения или увеличении части экрана.  
  
 В следующем примере используется <xref:System.Windows.Media.VisualBrush> для закрашивания <xref:System.Windows.Shapes.Shape.Fill%2A> из <xref:System.Windows.Shapes.Rectangle>. На следующем рисунке показан закрашенный прямоугольник.  
  
 ![Прямоугольник, закрашенный с использованием VisualBrush](./media/graphicsmm-brush-ovw-visualbrush.jpg "graphicsmm_brush_ovw_visualbrush")  
Прямоугольник, закрашенный с использованием VisualBrush  
  
 [!code-csharp[BrushesIntroduction_snip#GraphicsMMVisualBrushExampleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/BrushesIntroduction_snip/CSharp/BrushTypesExample.cs#graphicsmmvisualbrushexampleinline)]
 
 [!code-xaml[BrushesIntroduction_snip#GraphicsMMVisualBrushExampleInline](~/samples/snippets/xaml/VS_Snippets_Wpf/BrushesIntroduction_snip/XAML/BrushTypesExample.xaml#graphicsmmvisualbrushexampleinline)]  
  
 Дополнительные сведения о <xref:System.Windows.Media.VisualBrush> , представлена в разделе [Рисование с помощью изображений, рисунков и визуальных элементов](painting-with-images-drawings-and-visuals.md).  
  
<a name="paintwithpredefinedbrushesandsystemcolors"></a>   
## <a name="paint-using-predefined-and-system-brushes"></a>Рисование с помощью готовых и системных кистей  
 Для удобства Windows Presentation Foundation (WPF) предоставляет набор предопределенных, и система кистей, можно использовать для рисования объектов.  
  
-   Список доступных стандартных кистей, см. в разделе <xref:System.Windows.Media.Brushes> класса. Пример, демонстрирующий использование стандартной кисти, см. в разделе [закрасить область сплошным цветом](how-to-paint-an-area-with-a-solid-color.md).  
  
-   Список доступных системных кистей, см. в разделе <xref:System.Windows.SystemColors> класса. Например, см. в разделе [Закраска области с помощью системной кисти](how-to-paint-an-area-with-a-system-brush.md).  
  
<a name="commonbrushfeatures"></a>   
## <a name="common-brush-features"></a>Общие средства кисти  
 <xref:System.Windows.Media.Brush> объекты предоставляют <xref:System.Windows.Media.Brush.Opacity%2A> свойство, которое может использоваться для сделать кисти прозрачным или полупрозрачным. <xref:System.Windows.Media.Brush.Opacity%2A> Значение 0, делает кисть полностью прозрачной, а <xref:System.Windows.Media.Brush.Opacity%2A> значение 1, делает кисть полностью непрозрачными. В следующем примере используется <xref:System.Windows.Media.Brush.Opacity%2A> свойства <xref:System.Windows.Media.SolidColorBrush> непрозрачности 25 процентов.  
  
 [!code-xaml[BrushOverviewExamples_snip#OpacityExample1XAML](~/samples/snippets/xaml/VS_Snippets_Wpf/BrushOverviewExamples_snip/XAML/OpacityExample.xaml#opacityexample1xaml)]  
  
 [!code-csharp[BrushOverviewExamples_snip#OpacityExample1CSharp](~/samples/snippets/csharp/VS_Snippets_Wpf/BrushOverviewExamples_snip/CSharp/OpacityExample.cs#opacityexample1csharp)]  
  
 Если кисть, которая содержит полупрозрачные цвета, значение непрозрачности цвета объединяется путем умножения значение непрозрачности кисти. Например если кисти имеет значение 0,5 и цвет, используемый в кисть, которая также имеет значение 0,5, выходной цвет имеет значение непрозрачности 0,25.  
  
> [!NOTE]
>  Более эффективно, чтобы изменить значение непрозрачности кисти, а не для изменения прозрачности всего элемента с помощью его <xref:System.Windows.UIElement.Opacity%2A?displayProperty=nameWithType> свойство.  
  
 Поворот, масштабирование, наклон и преобразует содержимое кисти с помощью его <xref:System.Windows.Media.Brush.Transform%2A> или <xref:System.Windows.Media.Brush.RelativeTransform%2A> свойства. Дополнительные сведения см. в разделе [Общие сведения о преобразованиях кистей](brush-transformation-overview.md).  
  
 Так как они <xref:System.Windows.Media.Animation.Animatable> объектов, <xref:System.Windows.Media.Brush> объекты могут быть анимированы. Более подробную информацию см. в разделе [Общие сведения об эффектах анимации](animation-overview.md).  
  
<a name="freezable_features"></a>   
### <a name="freezable-features"></a>Возможности объектов Freezable  
 Так как он наследует от <xref:System.Windows.Freezable> класс, <xref:System.Windows.Media.Brush> класс предоставляет ряд специальных возможностей: <xref:System.Windows.Media.Brush> объекты могут быть объявлены как [ресурсы](../advanced/xaml-resources.md)совместно использоваться несколькими объектами и клонировать. Кроме того все <xref:System.Windows.Media.Brush> за исключением <xref:System.Windows.Media.VisualBrush> можно делать доступными только для чтения с целью повышения производительности и делать потокобезопасными.  
  
 Дополнительные сведения о различных возможностях, предоставляемых <xref:System.Windows.Freezable> объектов, см. в разделе [Freezable Общие сведения об объектах](../advanced/freezable-objects-overview.md).  
  
 Дополнительные сведения о том, почему <xref:System.Windows.Media.VisualBrush> объектов не может быть зафиксировано, см. в разделе <xref:System.Windows.Media.VisualBrush> страница "тип".  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Brush>
- <xref:System.Windows.Media.Brushes>
- [Общие сведения о закраске сплошным цветом и градиентом](painting-with-solid-colors-and-gradients-overview.md)
- [Рисование с помощью объектов Image, Drawing и Visual](painting-with-images-drawings-and-visuals.md)
- [Общие сведения об объектах класса Freezable](../advanced/freezable-objects-overview.md)
- [Пример использования кистей](https://go.microsoft.com/fwlink/?LinkID=159973)
- [Пример использования кистей](https://go.microsoft.com/fwlink/?LinkID=160005)
- [Пример использования VisualBrush](https://go.microsoft.com/fwlink/?LinkID=160049)
- [Практические руководства](brushes-how-to-topics.md)
- [Дополнительные рекомендации по повышению производительности](../advanced/optimizing-performance-other-recommendations.md)

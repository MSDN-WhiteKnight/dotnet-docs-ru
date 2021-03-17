---
title: Общие сведения о TileBrush
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- TileBrush [WPF]
- brushes [WPF], TileBrush
ms.assetid: aa4a7b7e-d09d-44c2-8d61-310c50e08d68
ms.openlocfilehash: a610acfef416a978ab8ecd9a561a135ecf3611cc
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59125309"
---
# <a name="tilebrush-overview"></a>Общие сведения о TileBrush
<xref:System.Windows.Media.TileBrush> объекты обеспечивают высокую степень контроля над закрашивание области с изображением, <xref:System.Windows.Media.Drawing>, или <xref:System.Windows.Media.Visual>. В этом разделе описывается использование <xref:System.Windows.Media.TileBrush> функции позволяют получить больший контроль над тем, как <xref:System.Windows.Media.ImageBrush>, <xref:System.Windows.Media.DrawingBrush>, или <xref:System.Windows.Media.VisualBrush> закрашивает область.  

<a name="prerequisite"></a>   
## <a name="prerequisites"></a>Предварительные требования  
 Для понимания этого раздела, полезно понять, как использовать основные функции этого <xref:System.Windows.Media.ImageBrush>, <xref:System.Windows.Media.DrawingBrush>, или <xref:System.Windows.Media.VisualBrush> класса. Введение в этих типов, см. в разделе [Рисование с помощью изображений, рисунков и визуальных элементов](painting-with-images-drawings-and-visuals.md).  
  
<a name="tilebrush"></a>   
## <a name="painting-an-area-with-tiles"></a>Заполнение области с помощью мозаики  
 <xref:System.Windows.Media.ImageBrush>, <xref:System.Windows.Media.DrawingBrush>, являются <xref:System.Windows.Media.VisualBrush> типов <xref:System.Windows.Media.TileBrush> объектов. Мозаичная кисть позволяет тщательно контролировать заполнение области для изображений, рисунков и визуальных элементов. Например, можно заполнить область не одним растянутым изображением, а элементами мозаики, которые образуют узор.  
  
 Заполнение области с помощью мозаичной кисти включает три компонента: содержимое, базовый элемент мозаики и область вывода.  
  
 ![Компоненты TileBrush](./media/wcpsdk-mmgraphics-defaultcontentprojection2.png "wcpsdk_mmgraphics_defaultcontentprojection2")  
Компоненты TileBrush с одним элементом мозаики  
  
 ![Компоненты мозаичного TileBrush](./media/graphicsmm-tiledprojection.png "graphicsmm_tiledprojection")  
Компоненты TileBrush с TileMode, имеющим значение Tile  
  
 Область вывода представляет области, такие как <xref:System.Windows.Shapes.Shape.Fill%2A> из <xref:System.Windows.Shapes.Ellipse> или <xref:System.Windows.Controls.Control.Background%2A> из <xref:System.Windows.Controls.Button>. В следующих разделах описываются два остальных компонента <xref:System.Windows.Media.TileBrush>.  
  
<a name="brushcontent"></a>   
## <a name="brush-content"></a>Содержимое кисти  
 Существует три разных типа <xref:System.Windows.Media.TileBrush> и каждый закрашивает различным типом содержимого.  
  
-   Если используется кисть <xref:System.Windows.Media.ImageBrush>, это содержимое является изображением <xref:System.Windows.Media.ImageBrush.ImageSource%2A> свойство определяет содержимое <xref:System.Windows.Media.ImageBrush>.  
  
-   Если используется кисть <xref:System.Windows.Media.DrawingBrush>, это содержимое является рисунка. <xref:System.Windows.Media.DrawingBrush.Drawing%2A> Свойство определяет содержимое <xref:System.Windows.Media.DrawingBrush>.  
  
-   Если используется кисть <xref:System.Windows.Media.VisualBrush>, это содержимое является визуальный элемент. <xref:System.Windows.Media.VisualBrush.Visual%2A> Свойство определяет содержание <xref:System.Windows.Media.VisualBrush>.  
  
 Можно указать положение и размеры <xref:System.Windows.Media.TileBrush> содержимого с помощью <xref:System.Windows.Media.TileBrush.Viewbox%2A> свойство, несмотря на то, что довольно часто, чтобы оставить <xref:System.Windows.Media.TileBrush.Viewbox%2A> присвоено значение по умолчанию. По умолчанию <xref:System.Windows.Media.TileBrush.Viewbox%2A> полностью содержит содержимое кисти. Дополнительные сведения о настройке <xref:System.Windows.Controls.Viewbox>, см. в разделе <xref:System.Windows.Controls.Viewbox> страницу свойств.  
  
<a name="thebasetile"></a>   
## <a name="the-base-tile"></a>Базовый элемент мозаики  
 Объект <xref:System.Windows.Media.TileBrush> проецирует свое содержимое на базовый элемент мозаики. <xref:System.Windows.Media.TileBrush.Stretch%2A> Свойства элементов управления как <xref:System.Windows.Media.TileBrush> содержимое растягивается для заполнения базового элемента мозаики. <xref:System.Windows.Media.TileBrush.Stretch%2A> Свойство принимает следующие значения, определенные <xref:System.Windows.Media.Stretch> перечисления:  
  
-   <xref:System.Windows.Media.Stretch.None>: Содержимое кисти не растягивается для заполнения плитки.  
  
-   <xref:System.Windows.Media.Stretch.Fill>: Содержимое кисти масштабируется по размерам плитки. Поскольку высота и ширина содержимого масштабируются независимо друг от друга, исходные пропорции содержимого могут не сохраняться. То есть содержимое кисти может быть деформировано для полного заполнения выводимого элемента.  
  
-   <xref:System.Windows.Media.Stretch.Uniform>: Содержимое кисти масштабируется таким образом, чтобы полностью уместиться внутри фрагмента. Пропорции содержимого сохраняются.  
  
-   <xref:System.Windows.Media.Stretch.UniformToFill>: Содержимое кисти масштабируется таким образом, чтобы полностью заполнить область вывода при этом сохранить исходные пропорции содержимого.  
  
 На следующем рисунке показан другой <xref:System.Windows.Media.TileBrush.Stretch%2A> параметры.  
  
 ![Различные параметры растяжения TileBrush](./media/img-mmgraphics-stretchenum.jpg "img_mmgraphics_stretchenum")  
  
 В следующем примере содержимое <xref:System.Windows.Media.ImageBrush> таким образом, она не растягивается для заполнения области вывода.  
  
 [!code-xaml[BrushOverviewExamples_snip#GraphicsMMNoStretchExample](~/samples/snippets/xaml/VS_Snippets_Wpf/BrushOverviewExamples_snip/XAML/StretchExample.xaml#graphicsmmnostretchexample)]  
  
 [!code-csharp[BrushOverviewExamples_procedural_snip#GraphicsMMNoStretchExample](~/samples/snippets/csharp/VS_Snippets_Wpf/BrushOverviewExamples_procedural_snip/CSharp/StretchExample.cs#graphicsmmnostretchexample)]
 [!code-vb[BrushOverviewExamples_procedural_snip#GraphicsMMNoStretchExample](~/samples/snippets/visualbasic/VS_Snippets_Wpf/BrushOverviewExamples_procedural_snip/visualbasic/stretchexample.vb#graphicsmmnostretchexample)]  
  
 По умолчанию <xref:System.Windows.Media.TileBrush> создает один элемент (базовый элемент мозаики) и растягивает этот элемент, чтобы полностью заполнить область вывода. Размер и положение базового элемента мозаики можно изменить, задав <xref:System.Windows.Media.TileBrush.Viewport%2A> и <xref:System.Windows.Media.TileBrush.ViewportUnits%2A> свойства.  
  
<a name="basetilesize"></a>   
### <a name="base-tile-size"></a>Размер базового элемента мозаики  
 <xref:System.Windows.Media.TileBrush.Viewport%2A> Свойство определяет размер и положение базовый элемент мозаики и <xref:System.Windows.Media.TileBrush.ViewportUnits%2A> определяет свойство ли <xref:System.Windows.Media.TileBrush.Viewport%2A> задается с помощью абсолютных или относительных координат. Относительные координаты задаются относительно размера области вывода. Точка (0, 0) представляет левый верхний угол области вывода, а точка (1, 1) — правый нижний угол области вывода. Чтобы указать, что <xref:System.Windows.Media.TileBrush.Viewport%2A> свойство использует абсолютные координаты, задайте <xref:System.Windows.Media.TileBrush.ViewportUnits%2A> свойства <xref:System.Windows.Media.BrushMappingMode.Absolute>.  
  
 На следующем рисунке показано различие в выходных данных между <xref:System.Windows.Media.TileBrush> с абсолютных и относительных <xref:System.Windows.Media.TileBrush.ViewportUnits%2A>. Обратите внимание, что на каждом рисунке показан шаблон мозаики. В следующем разделе описано, как задать шаблон заполнения.  
  
 ![Абсолютные и относительные единицы окна просмотра](./media/absolute-and-relative-viewports.png "absolute_and_relative_viewports")  
  
 В следующем примере с помощью изображения создается элемент с шириной и высотой 50 %. Базовый элемент мозаики расположен в точке (0, 0) области вывода.  
  
 [!code-xaml[BrushOverviewExamples_snip#GraphicsMMRelativeViewportUnitsExample1](~/samples/snippets/xaml/VS_Snippets_Wpf/BrushOverviewExamples_snip/XAML/TileSizeExample.xaml#graphicsmmrelativeviewportunitsexample1)]  
  
 [!code-csharp[BrushOverviewExamples_procedural_snip#GraphicsMMRelativeViewportUnitsExample1](~/samples/snippets/csharp/VS_Snippets_Wpf/BrushOverviewExamples_procedural_snip/CSharp/TileSizeExample.cs#graphicsmmrelativeviewportunitsexample1)]
 [!code-vb[BrushOverviewExamples_procedural_snip#GraphicsMMRelativeViewportUnitsExample1](~/samples/snippets/visualbasic/VS_Snippets_Wpf/BrushOverviewExamples_procedural_snip/visualbasic/tilesizeexample.vb#graphicsmmrelativeviewportunitsexample1)]  
  
 В следующем примере задаются плитках <xref:System.Windows.Media.ImageBrush> на 25 на 25 аппаратно-независимых пикселях. Так как <xref:System.Windows.Media.TileBrush.ViewportUnits%2A> абсолютны, <xref:System.Windows.Media.ImageBrush> всегда будут иметь 25 на 25 пикселей, независимо от размера закрашиваемой области.  
  
 [!code-xaml[BrushOverviewExamples_snip#GraphicsMMAbsoluteViewportUnitsExample1](~/samples/snippets/xaml/VS_Snippets_Wpf/BrushOverviewExamples_snip/XAML/TileSizeExample.xaml#graphicsmmabsoluteviewportunitsexample1)]  
  
 [!code-csharp[BrushOverviewExamples_procedural_snip#GraphicsMMAbsoluteViewportUnitsExample1](~/samples/snippets/csharp/VS_Snippets_Wpf/BrushOverviewExamples_procedural_snip/CSharp/TileSizeExample.cs#graphicsmmabsoluteviewportunitsexample1)]
 [!code-vb[BrushOverviewExamples_procedural_snip#GraphicsMMAbsoluteViewportUnitsExample1](~/samples/snippets/visualbasic/VS_Snippets_Wpf/BrushOverviewExamples_procedural_snip/visualbasic/tilesizeexample.vb#graphicsmmabsoluteviewportunitsexample1)]  
  
<a name="tilingbehavior"></a>   
### <a name="tiling-behavior"></a>Поведение элементов при заполнении  
 Объект <xref:System.Windows.Media.TileBrush> создает шаблон заполнения, когда его базового фрагмента мозаики не полностью заполняет область вывода и режим заполнения затем <xref:System.Windows.Media.TileMode.None> указан. Когда мозаичной кисти не полностью заполняет область вывода, его <xref:System.Windows.Media.TileBrush.TileMode%2A> свойство указывает, должен ли базовый мозаичный элемент дублироваться для заполнения области вывода, и если да, то как. <xref:System.Windows.Media.TileBrush.TileMode%2A> Свойство принимает следующие значения, определенные <xref:System.Windows.Media.TileMode> перечисления:  
  
-   <xref:System.Windows.Media.TileMode.None>: Только базовый мозаичный элемент рисуется.  
  
-   <xref:System.Windows.Media.TileMode.Tile>: Базовый мозаичный элемент рисуется, и оставшаяся область заполняется повторами базового элемента мозаики таким образом, правого края одну плитку Примыкает к левой границей следующей и аналогично для верхней и нижней границ.  
  
-   <xref:System.Windows.Media.TileMode.FlipX>: Так же, как <xref:System.Windows.Media.TileMode.Tile>, но Чередующиеся столбцы элементов отражаются по горизонтали.  
  
-   <xref:System.Windows.Media.TileMode.FlipY>: Так же, как <xref:System.Windows.Media.TileMode.Tile>, но чередующиеся строки элементов отражаются по вертикали.  
  
-   <xref:System.Windows.Media.TileMode.FlipXY>: Комбинация <xref:System.Windows.Media.TileMode.FlipX> и <xref:System.Windows.Media.TileMode.FlipY>.  
  
 На следующем рисунке показаны различные режимы заполнения.  
  
 ![Различные параметры TileMode для TileBrush](./media/img-mmgraphics-tilemodes.gif "img_mmgraphics_tilemodes")  
  
 В следующем примере изображение используется для заполнения прямоугольника размерами 100 на 100 пикселей. Установив кисти <xref:System.Windows.Media.TileBrush.Viewport%2A> было задано 0,0,0.25,0.25, базовый элемент кисти будет выполнен 1/4 от области вывода. Кисть, которая <xref:System.Windows.Media.TileBrush.TileMode%2A> присваивается <xref:System.Windows.Media.TileMode.FlipXY>. Таким образом прямоугольник заполняется строками из элементов мозаики.  
  
 [!code-xaml[BrushOverviewExamples_snip#GraphicsMMFlipXYExample](~/samples/snippets/xaml/VS_Snippets_Wpf/BrushOverviewExamples_snip/XAML/TilingExample.xaml#graphicsmmflipxyexample)]  
  
 [!code-csharp[BrushOverviewExamples_procedural_snip#GraphicsMMFlipXYExample](~/samples/snippets/csharp/VS_Snippets_Wpf/BrushOverviewExamples_procedural_snip/CSharp/TilingExample.cs#graphicsmmflipxyexample)]
 [!code-vb[BrushOverviewExamples_procedural_snip#GraphicsMMFlipXYExample](~/samples/snippets/visualbasic/VS_Snippets_Wpf/BrushOverviewExamples_procedural_snip/visualbasic/tilingexample.vb#graphicsmmflipxyexample)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.ImageBrush>
- <xref:System.Windows.Media.DrawingBrush>
- <xref:System.Windows.Media.VisualBrush>
- <xref:System.Windows.Media.TileBrush>
- [Рисование с помощью объектов Image, Drawing и Visual](painting-with-images-drawings-and-visuals.md)
- [Практические руководства](brushes-how-to-topics.md)
- [Общие сведения об объектах класса Freezable](../advanced/freezable-objects-overview.md)
- [Пример использования кистей](https://go.microsoft.com/fwlink/?LinkID=160005)
- [Пример использования VisualBrush](https://go.microsoft.com/fwlink/?LinkID=160049)

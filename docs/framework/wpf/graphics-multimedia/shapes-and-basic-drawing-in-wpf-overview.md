---
title: Обзор фигур и базовых средств рисования в приложении WPF
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- shapes [WPF], about shapes
- basic drawing [WPF]
- vector drawing [WPF], overview
- vectors [WPF], drawing
- Shape objects [WPF]
ms.assetid: 66d7a6d6-e3b6-47bc-8dfe-8a1b26f7d901
ms.openlocfilehash: 1ce0e661d88b7c4d5719c4f11ef0912c5bacb587
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59189138"
---
# <a name="shapes-and-basic-drawing-in-wpf-overview"></a>Обзор фигур и базовых средств рисования в приложении WPF
В этом разделе приводится обзор рисования с помощью <xref:System.Windows.Shapes.Shape> объектов. Объект <xref:System.Windows.Shapes.Shape> — это разновидность <xref:System.Windows.UIElement> , позволяет нарисовать фигуру на экране. Так как они являются элементами пользовательского интерфейса, <xref:System.Windows.Shapes.Shape> объекты могут использоваться внутри <xref:System.Windows.Controls.Panel> элементы и элементы управления.  
  
 [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] предоставляет несколько уровней доступа к графикой и службам рендеринга. На верхнем уровне <xref:System.Windows.Shapes.Shape> объекты просты в использовании и предоставляют множество полезных функций, таких как макет и участие в [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] системой событий.  

<a name="shapes"></a>   
## <a name="shape-objects"></a>Объекты фигур  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] предоставляет ряд готовых к использованию <xref:System.Windows.Shapes.Shape> объектов.  Все объекты фигур наследуются от <xref:System.Windows.Shapes.Shape> класса. Доступные объекты фигур включают <xref:System.Windows.Shapes.Ellipse>, <xref:System.Windows.Shapes.Line>, <xref:System.Windows.Shapes.Path>, <xref:System.Windows.Shapes.Polygon>, <xref:System.Windows.Shapes.Polyline>, и <xref:System.Windows.Shapes.Rectangle>. <xref:System.Windows.Shapes.Shape> объекты используют перечисленные ниже общие свойства.  
  
-   <xref:System.Windows.Shapes.Shape.Stroke%2A>: Описывает способ рисования контура фигуры.  
  
-   <xref:System.Windows.Shapes.Shape.StrokeThickness%2A>: Определяет толщину контура фигуры.  
  
-   <xref:System.Windows.Shapes.Shape.Fill%2A>: Описывает способ рисования внутренней части фигуры.  
  
-   Свойства данных, определяющие координаты и вершины, измеряются в аппаратно-независимых пикселях.  
  
 Так как они являются производными от <xref:System.Windows.UIElement>, объекты фигур можно использовать внутри панелей и большинства элементов управления. <xref:System.Windows.Controls.Canvas> Панели особенно хорошо подходит для создания сложных рисунков, так как она поддерживает абсолютное позиционирование дочерних объектов.  
  
 <xref:System.Windows.Shapes.Line> Класс позволяет нарисовать линию между двумя точками. В следующем примере показано несколько способов указания координат линии и свойств штриха.  
  
 [!code-xaml[drawingwithshapeelements#LineExample1](~/samples/snippets/csharp/VS_Snippets_Wpf/DrawingWithShapeElements/CS/lineexample.xaml#lineexample1)]  
  
 [!code-cpp[shapesprocedural#ShapesProceduralLine](~/samples/snippets/cpp/VS_Snippets_Wpf/ShapesProcedural/CPP/ShapesProcedural.cpp#shapesproceduralline)]
 [!code-csharp[shapesprocedural#ShapesProceduralLine](~/samples/snippets/csharp/VS_Snippets_Wpf/ShapesProcedural/Csharp/ShapesProcedural.cs#shapesproceduralline)]
   
  
 На следующем рисунке показано создаваемые <xref:System.Windows.Shapes.Line>.  
  
 ![Рисунок линии](./media/shape-ovw-line2.gif "shape_ovw_line2")  
  
 Несмотря на то что <xref:System.Windows.Shapes.Line> предоставляют <xref:System.Windows.Shapes.Shape.Fill%2A> , его установка не оказывает никакого влияния поскольку <xref:System.Windows.Shapes.Line> нет области.  
  
 Еще одна распространенная фигура — <xref:System.Windows.Shapes.Ellipse>.  Создание <xref:System.Windows.Shapes.Ellipse> путем определения фигуры <xref:System.Windows.FrameworkElement.Width%2A> и <xref:System.Windows.FrameworkElement.Height%2A> свойства. Чтобы нарисовать круг, укажите <xref:System.Windows.Shapes.Ellipse> которого <xref:System.Windows.FrameworkElement.Width%2A> и <xref:System.Windows.FrameworkElement.Height%2A> значения равны.  
  
 [!code-xaml[ShapeOverviews#ShapesOVW1](~/samples/snippets/csharp/VS_Snippets_Wpf/ShapeOverviews/CS/Window1.xaml#shapesovw1)]  
  
 [!code-csharp[brushesmiscsnippets_procedural_snip#SetBackgroundColorOfShapeCodeExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/BrushesMiscSnippets_procedural_snip/CSharp/SetBackgroundColorOfShapeExample.cs#setbackgroundcolorofshapecodeexamplewholepage)]
   
  
 Ниже показан пример отображаемого объекта <xref:System.Windows.Shapes.Ellipse>.  
  
 ![Рисунок эллипса](./media/shape-ovw-ellipse2.png "shape_ovw_ellipse2")  
  
<a name="paths"></a>   
## <a name="using-paths-and-geometries"></a>Использование путей и геометрических фигур  
 <xref:System.Windows.Shapes.Path> Класс позволяет рисовать кривые и сложные фигуры. Эти кривые и сложные фигуры описываются с помощью <xref:System.Windows.Media.Geometry> объектов. Чтобы использовать <xref:System.Windows.Shapes.Path>, создании <xref:System.Windows.Media.Geometry> и использовать его для задания <xref:System.Windows.Shapes.Path> объекта <xref:System.Windows.Shapes.Path.Data%2A> свойство.  
  
 Существуют разнообразные <xref:System.Windows.Media.Geometry> объектов для выбора. <xref:System.Windows.Media.LineGeometry>, <xref:System.Windows.Media.RectangleGeometry>, И <xref:System.Windows.Media.EllipseGeometry> классы описывают относительно простые фигуры. Для создания более сложных фигур или кривых используйте <xref:System.Windows.Media.PathGeometry>.  
  
<a name="pathgeometry"></a>   
### <a name="pathgeometry-and-pathsegments"></a>Классы PathGeometry и PathSegment  
 <xref:System.Windows.Media.PathGeometry> объекты состоят из одного или нескольких <xref:System.Windows.Media.PathFigure> объектов, каждый из которых <xref:System.Windows.Media.PathFigure> представляет различные «рисунок» или фигуры. Каждый <xref:System.Windows.Media.PathFigure> состоит из одного или нескольких <xref:System.Windows.Media.PathSegment> объектов, каждый из которых представляет переходную часть фигуры. Следующие типы сегмента: <xref:System.Windows.Media.LineSegment>, <xref:System.Windows.Media.BezierSegment>, и <xref:System.Windows.Media.ArcSegment>.  
  
 В следующем примере <xref:System.Windows.Shapes.Path> используется для рисования кривой Безье второго порядка.  
  
 [!code-xaml[geometrysample#34](~/samples/snippets/csharp/VS_Snippets_Wpf/GeometrySample/CS/pathgeometryexample.xaml#34)]  
  
 На следующем рисунке показана преобразованная для просмотра фигура.  
  
 ![Рисунок пути](./media/shape-ovw-path2.gif "shape_ovw_path2")  
  
 Дополнительные сведения о <xref:System.Windows.Media.PathGeometry> , а другой <xref:System.Windows.Media.Geometry> классов, см. в разделе [Общие сведения о геометрии](geometry-overview.md).  
  
<a name="pathdatastring"></a>   
### <a name="xaml-abbreviated-syntax"></a>Сокращенный синтаксис XAML  
 В [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)], также могут использовать специальный сокращенный синтаксис для описания <xref:System.Windows.Shapes.Path>. В следующем примере сокращенный синтаксис используется для рисования сложной фигуры.  
  
```xaml  
      <Path Stroke="DarkGoldenRod" StrokeThickness="3"   
Data="M 100,200 C 100,25 400,350 400,175 H 280" />  
```  
  
 На следующем рисунке показана росчерка <xref:System.Windows.Shapes.Path>.  
  
 ![Рисунок пути](./media/shape-ovw-path.PNG "shape_ovw_path")  
  
 <xref:System.Windows.Shapes.Path.Data%2A> Строки атрибута начинается с помощью команды «moveto», обозначена буквой M, которая устанавливает начальную точку для пути в системе координат <xref:System.Windows.Controls.Canvas>. <xref:System.Windows.Shapes.Path> данные параметры зависят от регистра. Заглавная буква M указывает абсолютное положение новой текущей точки. Строчная буква m указывала бы относительные координаты. Первый сегмент представляет собой кубическую кривую Безье, которая начинается в точке (100, 200) и заканчивается в точке (400, 175). Эта кривая нарисована с помощью двух контрольных точек (100, 25) и (400, 350). Этот сегмент указывает команда C в <xref:System.Windows.Shapes.Path.Data%2A> строке атрибута. Опять же, заглавная буква C указывает абсолютный путь; строчная буква c указывает относительный путь.  
  
 Второй сегмент начинается с команды lineto H, которая рисует горизонтальную линию от предыдущей точки пути (400, 175) до новой точки (280, 175). Поскольку это команда по горизонтали «lineto», указанное значение является *x*-координации.  
  
 Полный синтаксис пути, см. в разделе <xref:System.Windows.Shapes.Path.Data%2A> ссылку и [Создание фигуры с помощью PathGeometry](how-to-create-a-shape-by-using-a-pathgeometry.md).  
  
<a name="fillpaint"></a>   
## <a name="painting-shapes"></a>Заполнение фигур  
 <xref:System.Windows.Media.Brush> объекты используются для закрашивания фигуры <xref:System.Windows.Shapes.Shape.Stroke%2A> и <xref:System.Windows.Shapes.Shape.Fill%2A>. В следующем примере, обводки и заполнения <xref:System.Windows.Shapes.Ellipse> указаны. Обратите внимание, что значения свойств кисти могут задаваться только в формате ключевого слова или шестнадцатеричного значения цвета. Дополнительные сведения о доступных ключевых словах цветов см. в разделе свойств <xref:System.Windows.Media.Colors> в класс <xref:System.Windows.Media> пространства имен.  
  
```xaml
<Canvas Background="LightGray">   
   <Ellipse  
      Canvas.Top="50"  
      Canvas.Left="50"  
      Fill="#FFFFFF00"  
      Height="75"  
      Width="75"  
      StrokeThickness="5"  
      Stroke="#FF0000FF"/>  
</Canvas>  
```  
  
 На следующем рисунке показано создаваемые <xref:System.Windows.Shapes.Ellipse>.  
  
 ![Эллипс](./media/shape-ovw-ellipsefill.PNG "shape_ovw_ellipsefill")  
  
 Кроме того, можно использовать синтаксис элемента свойства для явного создания <xref:System.Windows.Media.SolidColorBrush> объекта и заполнить фигуру сплошным цветом.  
  
```xaml
<!-- This polygon shape uses pre-defined color values for its Stroke and  
     Fill properties.   
     The SolidColorBrush's Opacity property affects the fill color in   
     this case by making it slightly transparent (opacity of 0.4) so   
     that it blends with any underlying color. -->  
  
<Polygon  
    Points="300,200 400,125 400,275 300,200"  
    Stroke="Purple"   
    StrokeThickness="2">  
    <Polygon.Fill>  
       <SolidColorBrush Color="Blue" Opacity="0.4"/>  
    </Polygon.Fill>  
</Polygon>  
```  
  
 На рисунке ниже показана фигура, преобразованная для просмотра.  
  
 ![Иллюстрация SolidColorBrush](./media/shape-ovw-solidcolorbrush.PNG "shape_ovw_solidcolorbrush")  
  
 Для заполнения фигуры также можно использовать штриховку, градиенты, изображения, шаблоны и многое другое. Дополнительные сведения см. в разделе [закраске сплошным цветом и градиентом Обзор](painting-with-solid-colors-and-gradients-overview.md).  
  
<a name="stretchableshapessection"></a>   
## <a name="stretchable-shapes"></a>Растягиваемые фигуры  
 <xref:System.Windows.Shapes.Line>, <xref:System.Windows.Shapes.Path>, <xref:System.Windows.Shapes.Polygon>, <xref:System.Windows.Shapes.Polyline>, И <xref:System.Windows.Shapes.Rectangle> классы имеют <xref:System.Windows.Shapes.Shape.Stretch%2A> свойство. Данное свойство определяет, каким образом <xref:System.Windows.Shapes.Shape> содержимое объекта (рисуемой фигуры) растягивается для заполнения <xref:System.Windows.Shapes.Shape> пространство макета. Объект <xref:System.Windows.Shapes.Shape> пространство макета — это объем пространства <xref:System.Windows.Shapes.Shape> выделяется системой макета, из-за явного <xref:System.Windows.FrameworkElement.Width%2A> и <xref:System.Windows.FrameworkElement.Height%2A> параметр или из-за его <xref:System.Windows.FrameworkElement.HorizontalAlignment%2A> и <xref:System.Windows.FrameworkElement.VerticalAlignment%2A> параметры. Дополнительные сведения о макете в Windows Presentation Foundation, см. в разделе [макета](../advanced/layout.md) Обзор.  
  
 Свойство Stretch принимает одно из следующих значений.  
  
-   <xref:System.Windows.Media.Stretch.None>: <xref:System.Windows.Shapes.Shape> Содержимое объекта не растягивается.  
  
-   <xref:System.Windows.Media.Stretch.Fill>: <xref:System.Windows.Shapes.Shape> Содержимое объекта растягивается для заполнения пространства макета.  Пропорции не сохраняются.  
  
-   <xref:System.Windows.Media.Stretch.Uniform>: <xref:System.Windows.Shapes.Shape> Содержимое объекта растягивается максимально для заполнения пространства макета с сохранением исходных пропорций.  
  
-   <xref:System.Windows.Media.Stretch.UniformToFill>: <xref:System.Windows.Shapes.Shape> Содержимое объекта растягивается для полного заполнения пространства макета с сохранением исходных пропорций.  
  
 Обратите внимание, что, когда <xref:System.Windows.Shapes.Shape> растяжении содержимого объекта <xref:System.Windows.Shapes.Shape> рисования контура объекта после растяжения.  
  
 В следующем примере <xref:System.Windows.Shapes.Polygon> используется для рисования создается очень маленький треугольник от (0,0), (0,1) и (1,1). <xref:System.Windows.Shapes.Polygon> Объекта <xref:System.Windows.FrameworkElement.Width%2A> и <xref:System.Windows.FrameworkElement.Height%2A> устанавливаются в значение 100, и ее переноса задано значение Fill. В результате <xref:System.Windows.Shapes.Polygon> содержимое объекта (треугольник) растягивается для заполнения большее пространство.  
  
```xaml
<Polygon  
  Points="0,0 0,1 1,1"  
  Fill="Blue"  
  Width="100"  
  Height="100"  
  Stretch="Fill"  
  Stroke="Black"  
  StrokeThickness="2" />  
```

```csharp
PointCollection myPointCollection = new PointCollection();  
myPointCollection.Add(new Point(0,0));  
myPointCollection.Add(new Point(0,1));  
myPointCollection.Add(new Point(1,1));  
  
Polygon myPolygon = new Polygon();  
myPolygon.Points = myPointCollection;  
myPolygon.Fill = Brushes.Blue;  
myPolygon.Width = 100;  
myPolygon.Height = 100;  
myPolygon.Stretch = Stretch.Fill;  
myPolygon.Stroke = Brushes.Black;  
myPolygon.StrokeThickness = 2;  
```

<a name="transforms"></a>   
## <a name="transforming-shapes"></a>Преобразование фигур  
 <xref:System.Windows.Media.Transform> Класс предоставляет средства для преобразования фигур на двумерной плоскости.  Различные виды преобразования включают поворот (<xref:System.Windows.Media.RotateTransform>), масштабирование (<xref:System.Windows.Media.ScaleTransform>), наклон (<xref:System.Windows.Media.SkewTransform>) и преобразование (<xref:System.Windows.Media.TranslateTransform>).  
  
 Распространенным преобразованием фигуры является поворот.  Для поворота фигуры создайте <xref:System.Windows.Media.RotateTransform> и укажите его <xref:System.Windows.Media.RotateTransform.Angle%2A>. <xref:System.Windows.Media.RotateTransform.Angle%2A> 45, элемент поворачивается на 45 градусов по часовой стрелке; углом 90, поворачивает элемент на 90 градусов по часовой стрелке, и т. д. Задайте <xref:System.Windows.Media.RotateTransform.CenterX%2A> и <xref:System.Windows.Media.RotateTransform.CenterY%2A> свойства, если вы хотите контролировать точку, вокруг которой вращается элемент. Эти значения свойств выражаются в системе координат преобразуемого элемента. <xref:System.Windows.Media.RotateTransform.CenterX%2A> и <xref:System.Windows.Media.RotateTransform.CenterY%2A> имеют нулевые значения по умолчанию. Наконец, примените <xref:System.Windows.Media.RotateTransform> к элементу. Если вы не хотите, чтобы преобразование влияло на макет, задайте фигуры <xref:System.Windows.UIElement.RenderTransform%2A> свойство.  
  
 В следующем примере <xref:System.Windows.Media.RotateTransform> используется для поворота фигуры 45 градусов относительно верхнего левого угла фигуры (0,0).  
  
 [!code-xaml[transformssample#14](~/samples/snippets/csharp/VS_Snippets_Wpf/transformsSample/CS/RotateTransformExample.xaml#14)]  
  
 В следующем примере другая фигура поворачивается на 45 градусов, но на этот раз — вокруг точки (25, 50).  
  
 [!code-xaml[transformssample#15](~/samples/snippets/csharp/VS_Snippets_Wpf/transformsSample/CS/RotateTransformExample.xaml#15)]  
  
 На следующем рисунке показаны результаты двух преобразований.  
  
 ![Поворот на 45 градусов вокруг различных точек](./media/wcpsdk-graphicsmm-rotatetransform45degrees.gif "wcpsdk_graphicsmm_rotatetransform45degrees")  
  
 В предыдущих примерах к каждому объекту фигуры применяется одно преобразование. Чтобы применить несколько преобразований к фигуре (или любой другой элемент пользовательского интерфейса), используйте <xref:System.Windows.Media.TransformGroup>.  
  
## <a name="see-also"></a>См. также

- [Двумерная графика и изображения](../advanced/optimizing-performance-2d-graphics-and-imaging.md)
- [Общие сведения о закраске сплошным цветом и градиентом](painting-with-solid-colors-and-gradients-overview.md)
- [Общие сведения о классе Geometry](geometry-overview.md)
- [Пошаговое руководство. Создание классического приложения WPF](../getting-started/walkthrough-my-first-wpf-desktop-application.md)
- [Общие сведения об эффектах анимации](animation-overview.md)

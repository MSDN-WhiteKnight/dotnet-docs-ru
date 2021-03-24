---
title: Общие сведения о классах Transform
ms.date: 03/30/2017
helpviewer_keywords:
- transformations [WPF], about transformations
- classes [WPF], 2-D transform
- transform classes [WPF], 2-D
- 2-D transform classes
- FrameworkElement objects [WPF], rotating
- FrameworkElement objects [WPF], skewing
- FrameworkElement objects [WPF], translating
- Transforms [WPF], about Transforms
- FrameworkElement objects [WPF], scaling
ms.assetid: 8f153d5e-ed61-4aa5-a7cd-286f0c427a13
ms.openlocfilehash: 6f7cbd91be83c96b25248f87ddc377159ba39b64
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59162208"
---
# <a name="transforms-overview"></a>Общие сведения о классах Transform
В этом разделе описывается использование [!INCLUDE[TLA#tla_2d](../../../../includes/tlasharptla-2d-md.md)] <xref:System.Windows.Media.Transform> классы для поворота, масштабирования, сдвига и наклона <xref:System.Windows.FrameworkElement> объектов.  

<a name="whatIsATransformSection"></a>   
## <a name="what-is-a-transform"></a>Что такое преобразование?  
 Объект <xref:System.Windows.Media.Transform> определяет способ сопоставления или преобразования точек из одного пространства координат в другом пространстве координат. Это сопоставление описывается с помощью матрицы преобразования <xref:System.Windows.Media.Matrix>, который является коллекцией из трех строк и трех столбцов со <xref:System.Double> значения.  
  
> [!NOTE]
>  Windows Presentation Foundation (WPF) использует строки матрицы. Векторы представляют собой массивы на основе строк, а не на основе столбцов.  
  
 В следующей таблице показана структура матрицы WPF.  
  
### <a name="a-2-d-transformation-matrix"></a>Матрица двумерного преобразования  
  
||||  
|-|-|-|  
|<xref:System.Windows.Media.Matrix.M11%2A><br /><br /> По умолчанию: 1.0|<xref:System.Windows.Media.Matrix.M12%2A><br /><br /> По умолчанию: 0,0|0,0|  
|<xref:System.Windows.Media.Matrix.M21%2A><br /><br /> По умолчанию: 0,0|<xref:System.Windows.Media.Matrix.M22%2A><br /><br /> По умолчанию: 1.0|0,0|  
|<xref:System.Windows.Media.Matrix.OffsetX%2A><br /><br /> По умолчанию: 0,0|<xref:System.Windows.Media.Matrix.OffsetY%2A><br /><br /> По умолчанию: 0,0|1.0|  
  
 Изменяя значения элементов матрицы, можно поворачивать, масштабировать, наклонять и перемещать объект. Например, если вы измените значение в первом столбце третьей строки ( <xref:System.Windows.Media.Matrix.OffsetX%2A> значение) до 100, можно будет использовать его, чтобы переместить объект на 100 единиц по оси x. Если изменить значение во втором столбце второй строки на 3, можно использовать его для растяжения объекта в три раза больше по сравнению с текущим размером. Если изменить оба значения, объект будет перемещен на 100 единиц по оси X, а его ширина будет увеличена в 3 раза. Так как Windows Presentation Foundation (WPF) поддерживает только аффинные преобразования, в правом столбце всегда равны 0, 0, 1.  
  
 Несмотря на то, что Windows Presentation Foundation (WPF) позволяет напрямую управлять значениями элементов матрицы, она также предоставляет несколько <xref:System.Windows.Media.Transform> классы, которые позволяют преобразовывать объект, не зная структуры матрицы. Например <xref:System.Windows.Media.ScaleTransform> класс позволяет масштабировать объект, задав его <xref:System.Windows.Media.ScaleTransform.ScaleX%2A> и <xref:System.Windows.Media.ScaleTransform.ScaleY%2A> свойства, вместо изменения матрицы преобразования. Аналогичным образом <xref:System.Windows.Media.RotateTransform> класс позволяет повернуть объект, просто установив его <xref:System.Windows.Media.RotateTransform.Angle%2A> свойство.  
  
<a name="transformClassesSection"></a>   
## <a name="transform-classes"></a>Классы преобразования  
 Windows Presentation Foundation (WPF) предоставляет следующие [!INCLUDE[TLA#tla_2d](../../../../includes/tlasharptla-2d-md.md)] <xref:System.Windows.Media.Transform> классы для распространенных операций преобразования:  
  
|Класс|Описание|Пример|Рисунки|  
|-----------|-----------------|-------------|------------------|  
|<xref:System.Windows.Media.RotateTransform>|Поворачивает элемент на указанный <xref:System.Windows.Media.RotateTransform.Angle%2A>.|[Вращение объекта](how-to-rotate-an-object.md)|![Иллюстрация вращения](./media/graphicsmm-thumbnails-rotate.png "graphicsmm_thumbnails_rotate")|  
|<xref:System.Windows.Media.ScaleTransform>|Масштабирует элемент с указанным <xref:System.Windows.Media.ScaleTransform.ScaleX%2A> и <xref:System.Windows.Media.ScaleTransform.ScaleY%2A> суммы.|[Масштабирование элемента](how-to-scale-an-element.md)|![Иллюстрация масштабирования](./media/graphicsmm-thumbnails-scale.png "graphicsmm_thumbnails_scale")|  
|<xref:System.Windows.Media.SkewTransform>|Наклоняет элемент в соответствии с указанным <xref:System.Windows.Media.SkewTransform.AngleX%2A> и <xref:System.Windows.Media.SkewTransform.AngleY%2A> суммы.|[Наклон элемента](how-to-skew-an-element.md)|![Иллюстрация наклона](./media/graphicsmm-thumbnails-skew.png "graphicsmm_thumbnails_skew")|  
|<xref:System.Windows.Media.TranslateTransform>|Перемещает (преобразует) элемента заданным <xref:System.Windows.Media.TranslateTransform.X%2A> и <xref:System.Windows.Media.TranslateTransform.Y%2A> суммы.|[Перемещение элемента](how-to-translate-an-element.md)|![Иллюстрация перемещения](./media/graphicsmm-thumbnails-translate.png "graphicsmm_thumbnails_translate")|  
  
 Для создания более сложных преобразований, Windows Presentation Foundation (WPF) предоставляет следующие два класса:  
  
|Класс|Описание|Пример|  
|-----------|-----------------|-------------|  
|<xref:System.Windows.Media.TransformGroup>|Группирует несколько <xref:System.Windows.Media.TransformGroup> объекты в единую <xref:System.Windows.Media.Transform> , затем можно применить для преобразования свойств.|[Применение нескольких преобразований к объекту](how-to-apply-multiple-transforms-to-an-object.md)|  
|<xref:System.Windows.Media.MatrixTransform>|Создает пользовательские преобразования, которые не предоставляются с использованием других <xref:System.Windows.Media.Transform> классы. При использовании <xref:System.Windows.Media.MatrixTransform>, напрямую управлять матрицу.|[Использование MatrixTransform для создания пользовательских преобразований](how-to-use-a-matrixtransform-to-create-custom-transforms.md)|  
  
 Windows Presentation Foundation (WPF) также предоставляет [!INCLUDE[TLA#tla_3d](../../../../includes/tlasharptla-3d-md.md)] преобразования. Дополнительные сведения см. в описании класса <xref:System.Windows.Media.Media3D.Transform3D>.  
  
<a name="transformationproperties"></a>   
## <a name="common-transformation-properties"></a>Общие свойства преобразования  
 Один из способов преобразования объекта — объявить соответствующий <xref:System.Windows.Media.Transform> введите и применить его к свойству преобразования объекта. У различных типов объектов есть различные типы свойств преобразования. В следующей таблице перечислены несколько часто используемых типов Windows Presentation Foundation (WPF) и их свойства преобразования.  
  
|Тип|Свойства преобразования|  
|----------|-------------------------------|  
|<xref:System.Windows.Media.Brush>|<xref:System.Windows.Media.Brush.Transform%2A>, <xref:System.Windows.Media.Brush.RelativeTransform%2A>|  
|<xref:System.Windows.Media.ContainerVisual>|<xref:System.Windows.Media.ContainerVisual.Transform%2A>|  
|<xref:System.Windows.Media.DrawingGroup>|<xref:System.Windows.Media.DrawingGroup.Transform%2A>|  
|<xref:System.Windows.FrameworkElement>|<xref:System.Windows.UIElement.RenderTransform%2A>, <xref:System.Windows.FrameworkElement.LayoutTransform%2A>|  
|<xref:System.Windows.Media.Geometry>|<xref:System.Windows.Media.Geometry.Transform%2A>|  
|<xref:System.Windows.Media.TextEffect>|<xref:System.Windows.Media.TextEffect.Transform%2A>|  
|<xref:System.Windows.UIElement>|<xref:System.Windows.UIElement.RenderTransform%2A>|  
  
<a name="transformcenter"></a>   
## <a name="transformations-and-coordinate-systems"></a>Преобразования и системы координат  
 При преобразовании объекта преобразуется не только объект, но и пространство координат, в котором он существует. По умолчанию преобразование центрируется в начало системы координат целевого объекта: (0,0). Единственное исключение — <xref:System.Windows.Media.TranslateTransform>; <xref:System.Windows.Media.TranslateTransform> нет свойств центра задать, так как результат преобразования не так же, независимо от того, где по центру.  
  
 В следующем примере используется <xref:System.Windows.Media.RotateTransform> для поворота <xref:System.Windows.Shapes.Rectangle> элемент, тип <xref:System.Windows.FrameworkElement>, на 45 градусов относительно центральной точки по умолчанию (0, 0). На следующем рисунке показан результат поворота.  
  
 ![FrameworkElement, повернутый на 45 градусов о &#40;0,0&#41;](./media/graphicsmm-fe-rotated-about-upperleft-corner.png "graphicsmm_FE_rotated_about_upperleft_corner")  
Элемент Rectangle, повернутый на 45 градусов относительно точки (0,0)  
  
 [!code-xaml[Transforms_snip#TransformsFERotatedAboutTopLeft](~/samples/snippets/csharp/VS_Snippets_Wpf/Transforms_snip/CS/CoordinateSystemExample.xaml#transformsferotatedabouttopleft)]  
  
 По умолчанию элемент поворачивается относительно левого верхнего угла: (0, 0). <xref:System.Windows.Media.RotateTransform>, <xref:System.Windows.Media.ScaleTransform>, И <xref:System.Windows.Media.SkewTransform> классы предоставляют свойства CenterX и CenterY, которые позволяют указать точку, в которой применяется преобразование.  
  
 В следующем примере также используется <xref:System.Windows.Media.RotateTransform> для поворота <xref:System.Windows.Shapes.Rectangle> элемент на 45 градусов; тем не менее, это время <xref:System.Windows.Media.RotateTransform.CenterX%2A> и <xref:System.Windows.Media.RotateTransform.CenterY%2A> свойств, чтобы <xref:System.Windows.Media.RotateTransform> имеет центр (25, 25). На следующем рисунке показан результат поворота.  
  
 ![Геометрическая фигура, повернутая на 45 градусов о &#40;25, 25&#41;](./media/graphicsmm-fe-rotated-about-center.png "graphicsmm_FE_rotated_about_center")  
Элемент Rectangle, повернутый на 45 градусов относительно точки (25, 25)  
  
 [!code-xaml[Transforms_snip#TransformsFERotatedAboutCenter](~/samples/snippets/csharp/VS_Snippets_Wpf/Transforms_snip/CS/CoordinateSystemExample.xaml#transformsferotatedaboutcenter)]  
  
<a name="layoutTransformsAndRenderTransformsSection"></a>   
## <a name="transforming-a-frameworkelement"></a>Преобразование элемента FrameworkElement  
 Применение преобразований к <xref:System.Windows.FrameworkElement>, создание <xref:System.Windows.Media.Transform> и примените его к одному из двух свойств, <xref:System.Windows.FrameworkElement> класс предоставляет:  
  
-   <xref:System.Windows.FrameworkElement.LayoutTransform%2A> — Преобразование, которое применяется перед проходом разметки. После применения преобразования система разметки обрабатывает преобразованные размер и положение элемента.  
  
-   <xref:System.Windows.UIElement.RenderTransform%2A> — Преобразование, которое изменяет внешний вид элемента, но применяется после завершения прохода макета. С помощью <xref:System.Windows.UIElement.RenderTransform%2A> вместо свойства <xref:System.Windows.FrameworkElement.LayoutTransform%2A> можно добиться повышения производительности.  
  
 Какое свойство следует использовать? Из-за преимуществ производительности, которые он предоставляет, используйте <xref:System.Windows.UIElement.RenderTransform%2A> свойство всякий раз, когда возможно, особенно при использовании анимации <xref:System.Windows.Media.Transform> объектов. Используйте <xref:System.Windows.FrameworkElement.LayoutTransform%2A> свойство при масштабирования, поворота и наклона, а вам нужны родительского элемента, чтобы изменить размер элемента. Обратите внимание, что, если они используются с <xref:System.Windows.FrameworkElement.LayoutTransform%2A> свойства <xref:System.Windows.Media.TranslateTransform> объектов, по-видимому, не влияют на элементы. Это вызвано тем, что система разметки возвращает преобразуемый элемент в исходное положение в ходе обработки.  
  
 Дополнительные сведения о разметке в Windows Presentation Foundation (WPF) см. в разделе [Общие сведения о разметке](../advanced/layout.md).  
  
<a name="exampleRotateAnElement45degSection"></a>   
## <a name="example-rotate-a-frameworkelement-45-degrees"></a>Пример Поворот элемента FrameworkElement на 45 градусов  
 В следующем примере используется <xref:System.Windows.Media.RotateTransform> для поворота кнопки по часовой стрелке на 45 градусов. Кнопка находится в <xref:System.Windows.Controls.StackPanel> , имеет две другие кнопки.  
  
 По умолчанию <xref:System.Windows.Media.RotateTransform> поворачивается вокруг точки (0, 0). Так как в примере не задана центральная точка, то кнопка поворачивается вокруг точки (0, 0), т. е. левого верхнего угла. <xref:System.Windows.Media.RotateTransform> Применяется к <xref:System.Windows.UIElement.RenderTransform%2A> свойство. На рисунке ниже показан результат преобразования.  
  
 ![Кнопка, преобразованная с использованием RenderTransform](./media/graphicsmm-rendertransformwithdefaultcenter.png "graphicsmm_RenderTransformWithDefaultCenter")  
Поворот на 45 градусов по часовой стрелке вокруг левого верхнего угла  
  
 [!code-xaml[Transforms_snip#GraphicsMMRotateButtonExample1](~/samples/snippets/csharp/VS_Snippets_Wpf/Transforms_snip/CS/ButtonRotateTransformExample.xaml#graphicsmmrotatebuttonexample1)]  
  
 В следующем примере также используется <xref:System.Windows.Media.RotateTransform> для поворота кнопки на 45 градусов по часовой стрелке, но он также задает <xref:System.Windows.UIElement.RenderTransformOrigin%2A> кнопки значение (0,5, 0,5). Значение <xref:System.Windows.UIElement.RenderTransformOrigin%2A> свойство задается относительно размера кнопки. В результате кнопка поворачивается вокруг центра, а не вокруг левого верхнего угла. На рисунке ниже показан результат преобразования.  
  
 ![Кнопка, преобразованная относительно ее центра](./media/graphicsmm-rendertransformrelativecenter.png "graphicsmm_RenderTransformRelativeCenter")  
Поворот на 45 градусов по часовой стрелке вокруг центра  
  
 [!code-xaml[Transforms_snip#GraphicsMMRotateButtonExample2](~/samples/snippets/csharp/VS_Snippets_Wpf/Transforms_snip/CS/ButtonRotateTransformExample.xaml#graphicsmmrotatebuttonexample2)]  
  
 В следующем примере используется <xref:System.Windows.FrameworkElement.LayoutTransform%2A> вместо свойства <xref:System.Windows.UIElement.RenderTransform%2A> свойство для поворота кнопки.  При этом преобразование влияет на разметку кнопки, что приводит к запуску полного прохода системы разметки. Так как размер кнопки был изменен, то после поворота кнопки также изменяется ее положение. На рисунке ниже показан результат преобразования.  
  
 ![Кнопка, преобразованная с использованием LayoutTransform](./media/graphicsmm-layouttransform.png "graphicsmm_LayoutTransform")  
Поворот кнопки с использованием LayoutTransform  
  
 [!code-xaml[Transforms_snip#GraphicsMMRotateButtonExample3](~/samples/snippets/csharp/VS_Snippets_Wpf/Transforms_snip/CS/ButtonRotateTransformExample.xaml#graphicsmmrotatebuttonexample3)]  
  
<a name="animate_transforms"></a>   
## <a name="animating-transformations"></a>Анимация преобразований  
 Так как они наследуют от <xref:System.Windows.Media.Animation.Animatable> класса <xref:System.Windows.Media.Transform> классы могут быть анимированы. Для анимации <xref:System.Windows.Media.Transform>, примените анимацию совместимого типа к свойству для анимации.  
  
 В следующем примере используется <xref:System.Windows.Media.Animation.Storyboard> и <xref:System.Windows.Media.Animation.DoubleAnimation> с <xref:System.Windows.Media.RotateTransform> вносить <xref:System.Windows.Controls.Button> вращаться при ее нажатии.  
  
 [!code-xaml[Transforms_snip#GraphicsMMAnimatedRotateButtonExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/Transforms_snip/CS/ButtonAnimatedRotateTransformExample.xaml#graphicsmmanimatedrotatebuttonexamplewholepage)]  
  
 Полный пример см. в разделе [Примеры двумерных преобразований](https://go.microsoft.com/fwlink/?LinkID=158252). Дополнительные сведения об анимации см. в разделе [Общие сведения об эффектах анимации](animation-overview.md).  
  
<a name="freezable_features"></a>   
## <a name="freezable-features"></a>Возможности объектов Freezable  
 Так как он наследует от <xref:System.Windows.Freezable> класс, <xref:System.Windows.Media.Transform> предоставляет ряд специальных возможностей: <xref:System.Windows.Media.Transform> объекты могут быть объявлены как [ресурсы](../advanced/xaml-resources.md), общие для нескольких объектов, делать доступными только для чтения с целью повышения производительности, клонировать и делать потокобезопасными. Дополнительные сведения о различных функциях, предоставляемых <xref:System.Windows.Freezable> объектов, см. в разделе [Freezable Общие сведения об объектах](../advanced/freezable-objects-overview.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Transform>
- <xref:System.Windows.Media.Matrix>
- [Практические руководства](transformations-how-to-topics.md)
- [Пример двумерных преобразований](https://go.microsoft.com/fwlink/?LinkID=158252)

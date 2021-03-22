---
title: Общие сведения о преобразованиях объекта Brush
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- brushes [WPF], transformation properties
- properties [WPF], transformation
- transformation properties of brushes [WPF]
ms.assetid: 8b9bfc09-12fd-4cd5-b445-99949f27bc39
ms.openlocfilehash: 39b3ad9bebfc56002f77ad6e9026a4446c95455b
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59298335"
---
# <a name="brush-transformation-overview"></a>Общие сведения о преобразованиях объекта Brush
Класс Brush предоставляет два свойства для преобразований: <xref:System.Windows.Media.Brush.Transform%2A> и <xref:System.Windows.Media.Brush.RelativeTransform%2A>. Эти свойства позволяют выполнять поворот, масштабирование, наклон и преобразовывать содержимое кисти. В этом разделе описываются различия между этими двумя свойствами и приводятся примеры их использования.  
  
<a name="prerequisites"></a>   
## <a name="prerequisites"></a>Предварительные требования  
 Чтобы разобраться в этом разделе, пользователь должен понимать возможности преобразуемой кисти. Для <xref:System.Windows.Media.LinearGradientBrush> и <xref:System.Windows.Media.RadialGradientBrush>, см. в разделе [закраске сплошным цветом и градиентом Обзор](painting-with-solid-colors-and-gradients-overview.md). Для <xref:System.Windows.Media.ImageBrush>, <xref:System.Windows.Media.DrawingBrush>, или <xref:System.Windows.Media.VisualBrush>, см. в разделе [Рисование с помощью изображений, рисунков и визуальных элементов](painting-with-images-drawings-and-visuals.md). Также необходимо иметь представление о двумерных преобразованиях, описанных в разделе [Общие сведения о преобразованиях](transforms-overview.md).  
  
<a name="transformversusrelativetransform"></a>   
## <a name="differences-between-the-transform-and-relativetransform-properties"></a>Различия между свойствами Transform и RelativeTransform  
 При применении преобразования к кисти <xref:System.Windows.Media.Brush.Transform%2A> свойство, необходимо знать размер закрашиваемой области, если вы хотите преобразовать содержимое кисти относительно ее центра. Предположим, что область рисования имеет ширину 200 аппаратно-независимых пикселей и высоту 150 пикселей.  Если вы использовали <xref:System.Windows.Media.RotateTransform> Чтобы повернуть кисть выходных данных на 45 градусов относительно ее центра, то <xref:System.Windows.Media.RotateTransform> <xref:System.Windows.Media.RotateTransform.CenterX%2A> 100 и <xref:System.Windows.Media.RotateTransform.CenterY%2A> числа 75.  
  
 При применении преобразования к кисти <xref:System.Windows.Media.Brush.RelativeTransform%2A> свойство, это преобразование применяется к кисти перед сопоставлением ее выходного значения закрашиваемой области. Следующий список описывает порядок обработки и преобразования содержимого кисти.  
  
1. Обработка содержимого кисти. Для <xref:System.Windows.Media.GradientBrush>, это означает определение области градиента. Для <xref:System.Windows.Media.TileBrush>, <xref:System.Windows.Media.TileBrush.Viewbox%2A> сопоставляется <xref:System.Windows.Media.TileBrush.Viewport%2A>. Это становится результатом работы кисти.  
  
2. Проекция результата работы кисти на прямоугольник преобразования 1 x 1.  
  
3. Применение кисти <xref:System.Windows.Media.Brush.RelativeTransform%2A>, если он имеется.  
  
4. Проекция преобразованного результата работы на закрашиваемую область.  
  
5. Применение кисти <xref:System.Windows.Media.Transform>, если он имеется.  
  
 Так как <xref:System.Windows.Media.Brush.RelativeTransform%2A> применяется при сопоставлении кисти результата прямоугольнику 1 x 1, центра преобразования и значения смещения считаются относительными. Например, если вы использовали <xref:System.Windows.Media.RotateTransform> Чтобы повернуть кисть выходных данных на 45 градусов относительно ее центра, то <xref:System.Windows.Media.RotateTransform> <xref:System.Windows.Media.RotateTransform.CenterX%2A> 0,5 и <xref:System.Windows.Media.RotateTransform.CenterY%2A> 0,5.  
  
 На следующем рисунке показан результат выполнения нескольких кистей, повернутых на 45 градусов с помощью <xref:System.Windows.Media.Brush.RelativeTransform%2A> и <xref:System.Windows.Media.Brush.Transform%2A> свойства.  
  
 ![Свойства RelativeTransform и Transform](./media/graphicsmm-brushrelativetransform-transform-small.png "graphicsmm_brushrelativetransform_transform_small")  
  
<a name="relativetransformandtilebrush"></a>   
## <a name="using-relativetransform-with-a-tilebrush"></a>Использование RelativeTransform с TileBrush  
 Так как мозаичные кисти являются более сложные, чем другие, применение <xref:System.Windows.Media.Brush.RelativeTransform%2A> одно может привести к непредвиденным результатам. Например, рассмотрим следующий рисунок.  
  
 ![Исходное изображение](./media/graphicsmm-reltransform-1-original-image.jpg "graphicsmm_reltransform_1_original_image")  
  
 В следующем примере используется <xref:System.Windows.Media.ImageBrush> для закраски прямоугольной области приведенным выше изображением. Он применяется <xref:System.Windows.Media.RotateTransform> для <xref:System.Windows.Media.ImageBrush> объекта <xref:System.Windows.Media.Brush.RelativeTransform%2A> свойство, которое задает его <xref:System.Windows.Media.TileBrush.Stretch%2A> свойства <xref:System.Windows.Media.Stretch.UniformToFill>, которого необходимо сохранять пропорции изображения при его растяжении для полного заполнения прямоугольника.  
  
 [!code-xaml[BrushOverviewExamples_snip#GraphicsMMRelativeTransformExample2Inline](~/samples/snippets/xaml/VS_Snippets_Wpf/BrushOverviewExamples_snip/XAML/RelativeTransformIllustration.xaml#graphicsmmrelativetransformexample2inline)]  
  
 В этом примере выводятся следующие данные:  
  
 ![Преобразованный результат работы](./media/graphicsmm-reltransform-6-output.png "graphicsmm_reltransform_6_output")  
  
 Обратите внимание на то, что изображение искажено, даже если кисти <xref:System.Windows.Media.TileBrush.Stretch%2A> было присвоено <xref:System.Windows.Media.Stretch.UniformToFill>. Это потому, что относительное преобразование применяется после кисти <xref:System.Windows.Media.TileBrush.Viewbox%2A> сопоставляется с его <xref:System.Windows.Media.TileBrush.Viewport%2A>. В следующем списке описан каждый шаг процесса:  
  
1. Проект содержимого кисти (<xref:System.Windows.Media.TileBrush.Viewbox%2A>) на базовую плитку (<xref:System.Windows.Media.TileBrush.Viewport%2A>) с помощью кисти <xref:System.Windows.Media.TileBrush.Stretch%2A> параметр.  
  
     ![Растягивание Viewbox для заполнения Viewport](./media/graphicsmm-reltransform-2-viewbox-to-viewport.png "graphicsmm_reltransform_2_viewbox_to_viewport")  
  
2. Проекция базового мозаичного элемента на прямоугольник преобразования 1 x 1.  
  
     ![Сопоставление Viewport и прямоугольника преобразования](./media/graphicsmm-reltransform-3-output-to-transform.png "graphicsmm_reltransform_3_output_to_transform")  
  
3. Применить <xref:System.Windows.Media.RotateTransform>.  
  
     ![Применение относительного преобразования](./media/graphicsmm-reltransform-4-transform-rotate.png "graphicsmm_reltransform_4_transform_rotate")  
  
4. Проекция преобразованного базового мозаичного элемента на закрашиваемую область.  
  
     ![Проекция преобразованной кисти на закрашиваемую область](./media/graphicsmm-reltransform-5-transform-to-output.png "graphicsmm_reltransform_5_transform_to_output")  
  
<a name="rotateexample"></a>   
## <a name="example-rotate-an-imagebrush-45-degrees"></a>Пример Поворот ImageBrush на 45 градусов  
 В следующем примере применяется <xref:System.Windows.Media.RotateTransform> для <xref:System.Windows.Media.Brush.RelativeTransform%2A> свойство <xref:System.Windows.Media.ImageBrush>. <xref:System.Windows.Media.RotateTransform> Объекта <xref:System.Windows.Media.RotateTransform.CenterX%2A> и <xref:System.Windows.Media.RotateTransform.CenterY%2A> заданы оба свойства 0,5, относительные координаты центра содержимого точка. В результате содержимое кисти поворачивается относительно ее центра.  
  
 [!code-csharp[BrushesIntroduction_snip#ImageBrushRelativeTransformExample](~/samples/snippets/csharp/VS_Snippets_Wpf/BrushesIntroduction_snip/CSharp/BrushTransformExample.cs#imagebrushrelativetransformexample)]
 
 [!code-xaml[BrushesIntroduction_snip#ImageBrushRelativeTransformExample](~/samples/snippets/xaml/VS_Snippets_Wpf/BrushesIntroduction_snip/XAML/BrushTransformExample.xaml#imagebrushrelativetransformexample)]  
  
 В следующем примере также применяется <xref:System.Windows.Media.RotateTransform> для <xref:System.Windows.Media.ImageBrush>, но использует <xref:System.Windows.Media.Brush.Transform%2A> вместо свойства <xref:System.Windows.Media.Brush.RelativeTransform%2A> свойство. Чтобы повернуть кисть относительно ее центра, <xref:System.Windows.Media.RotateTransform> объекта <xref:System.Windows.Media.RotateTransform.CenterX%2A> и <xref:System.Windows.Media.RotateTransform.CenterY%2A> должны быть указаны в абсолютных координатах. Так как прямоугольник, закрашиваемый с помощью кисти, имеет размеры 175 на 90 пикселей, его центральная точка будет иметь координаты (87,5, 45).  
  
 [!code-csharp[BrushesIntroduction_snip#ImageBrushTransformExample](~/samples/snippets/csharp/VS_Snippets_Wpf/BrushesIntroduction_snip/CSharp/BrushTransformExample.cs#imagebrushtransformexample)]
 
 [!code-xaml[BrushesIntroduction_snip#ImageBrushTransformExample](~/samples/snippets/xaml/VS_Snippets_Wpf/BrushesIntroduction_snip/XAML/BrushTransformExample.xaml#imagebrushtransformexample)]  
  
 На следующем рисунке показана кисть без преобразования, с преобразованием, примененным к <xref:System.Windows.Media.Brush.RelativeTransform%2A> свойство и с преобразованием, примененным к <xref:System.Windows.Media.Brush.Transform%2A> свойство.  
  
 ![Параметры RelativeTransform и Transform для кисти](./media/wcpsdk-graphicsmm-transformandrelativetransform.png "wcpsdk_graphicsmm_transformandrelativetransform")  
  
 Данный пример является частью большого примера. Полный пример см. в разделе [Пример использования кистей](https://go.microsoft.com/fwlink/?LinkID=159973). Более подробные сведения о кистях см. в разделе [Общие сведения о кистях WPF](wpf-brushes-overview.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Brush.Transform%2A>
- <xref:System.Windows.Media.Brush.RelativeTransform%2A>
- <xref:System.Windows.Media.Transform>
- <xref:System.Windows.Media.Brush>
- [Общие сведения о закраске сплошным цветом и градиентом](painting-with-solid-colors-and-gradients-overview.md)
- [Рисование с помощью объектов Image, Drawing и Visual](painting-with-images-drawings-and-visuals.md)
- [Общие сведения о классах Transform](transforms-overview.md)

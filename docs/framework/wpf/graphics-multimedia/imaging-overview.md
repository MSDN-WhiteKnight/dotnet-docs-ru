---
title: Общие сведения об обработке изображений
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- metadata [WPF], images
- displaying images [WPF]
- Imaging API [WPF]
- image metadata [WPF]
- converting images [WPF]
- encoding image formats [WPF]
- format decoding for images [WPF]
- painting with images [WPF]
- stretching images [WPF]
- images [WPF], about imaging
- format encoding for images [WPF]
- cropping images [WPF]
- decoding image formats [WPF]
- rotating images [WPF]
ms.assetid: 72aad87a-e6f3-4937-94cd-a18b7766e990
ms.openlocfilehash: dba2f8b07134560abd77832293ce2a81e55e4875
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59209714"
---
# <a name="imaging-overview"></a>Общие сведения об обработке изображений
В этом разделе содержатся общие сведения о платформе Компонент обработки изображений WPF. Обработка изображений в WPF позволяет разработчикам для отображения, преобразование и форматирование изображений.  

<a name="_wpfImaging"></a>   
## <a name="wpf-imaging-component"></a>Компонент обработки изображений WPF  
 Обработка изображений в WPF предоставляет значительные усовершенствования возможностей обработки изображений в Microsoft Windows. Возможности обработки изображений, например вывод растрового изображения или использование изображения на общем элементе управления были ранее реализованы с помощью библиотек Windows GDI и Microsoft Windows GDI+. Эти библиотеки API обеспечивают базовые функции обработки изображений, но в них отсутствуют такие возможности, как поддержка расширяемости кодеков и изображений высокого качества. Обработка изображений в WPF предназначен для преодоления недостатков GDI и GDI+ и предоставляет новый набор API для отображения и использования изображений в приложениях.  
  
 Существует два способа доступа к Обработка изображений в WPF API — управляемый компонент и неуправляемый компонент. Неуправляемый компонент предоставляет следующие возможности.  
  
-   Модель расширяемости для новых или собственных форматов изображений.  
  
-   Повышение производительности и безопасности при работе с собственными форматами изображений, включая [!INCLUDE[TLA#tla_bmp](../../../../includes/tlasharptla-bmp-md.md)], [!INCLUDE[TLA#tla_jpegorg](../../../../includes/tlasharptla-jpegorg-md.md)], [!INCLUDE[TLA#tla_png](../../../../includes/tlasharptla-png-md.md)], [!INCLUDE[TLA#tla_tiff](../../../../includes/tlasharptla-tiff-md.md)], [!INCLUDE[TLA#tla_wdp](../../../../includes/tlasharptla-wdp-md.md)], [!INCLUDE[TLA#tla_gif](../../../../includes/tlasharptla-gif-md.md)] и формат значка (ICO).  
  
-   Сохранение изображений с большой глубиной цвета — до 8 бит на канал (32 бита на пиксель).  
  
-   Неразрушающее масштабирование, обрезка и повороты.  
  
-   Упрощенное управление цветом.  
  
-   Поддержка собственных метаданных в файле.  
  
-   Управляемый компонент использует неуправляемую инфраструктуру для обеспечения плавной интеграции изображений с другими функциями WPF, такими как UI , анимация и графика. Управляемый компонент также использует преимущества Windows Presentation Foundation (WPF) работы с образами модели расширяемости кодека которая позволяет автоматически распознавать новые форматы изображений в WPF приложений.  
  
 Большинство управляемых Обработка изображений в WPF API находятся в <xref:System.Windows.Media.Imaging?displayProperty=nameWithType> пространства имен, хотя несколько важных типов, таких как <xref:System.Windows.Media.ImageBrush> и <xref:System.Windows.Media.ImageDrawing> находятся в <xref:System.Windows.Media?displayProperty=nameWithType> пространства имен и <xref:System.Windows.Controls.Image> находится в <xref:System.Windows.Controls?displayProperty=nameWithType> пространства имен.  
  
 В этом разделе содержатся дополнительные сведения об управляемом компоненте. Дополнительные сведения о неуправляемом компоненте API см. в документации по [неуправляемому компоненту обработки изображений WPF](/windows/desktop/wic/-wic-lh).  
  
<a name="_imageformats"></a>   
## <a name="wpf-image-formats"></a>Форматы изображений в WPF  
 Для кодирования и декодирования конкретного формата мультимедиа используются кодеки. Обработка изображений в WPF включает в себя кодек для BMP, JPEG, PNG, TIFF, Windows Media Photo, GIF и значок форматы изображений. Каждый из этих кодеков позволяет приложениям декодировать и, за исключением формата ICON, кодировать изображения соответствующих форматов.  
  
 <xref:System.Windows.Media.Imaging.BitmapSource> важным классом, используемым для декодирования и кодирования изображений. Это основной строительный блок конвейера Обработка изображений в WPF. Он представляет отдельный постоянный набор точек определенного размера и разрешения. Объект <xref:System.Windows.Media.Imaging.BitmapSource> можно отдельных кадров из многокадрового изображения, или он может быть результатом преобразования, выполненного на <xref:System.Windows.Media.Imaging.BitmapSource>. Он является родителем многих основных классов, используемых в WPF imaging, такие как <xref:System.Windows.Media.Imaging.BitmapFrame>.  
  
 Объект <xref:System.Windows.Media.Imaging.BitmapFrame> используется для хранения растровых данных формата изображения. Многие форматы изображения поддерживают использование только одного <xref:System.Windows.Media.Imaging.BitmapFrame>, хотя форматы, такие как GIF и TIFF поддерживают несколько кадров в изображении. Кадры используются декодерами в качестве входных данных и передаются кодировщикам для создания файлов изображений.  
  
 В следующем примере показано, как <xref:System.Windows.Media.Imaging.BitmapFrame> создается на основе <xref:System.Windows.Media.Imaging.BitmapSource> и затем добавляются TIFF изображения.  
  
 [!code-csharp[BitmapFrameExample#10](~/samples/snippets/csharp/VS_Snippets_Wpf/BitmapFrameExample/CSharp/BitmapFrame.cs#10)]
   
  
### <a name="image-format-decoding"></a>Декодирование изображений разных форматов  
 Декодирование изображения — это преобразование изображения в некотором формате в данные изображения, которые могут быть использованы системой. Данные изображения затем могут использоваться для отображения, обработки или кодирования в другой формат. Выбор декодера зависит от формата изображения. Выбор кодека производится автоматически, если не указан определенный декодер. Примеры в разделе [Отображение изображений в WPF](#_displayingimages) демонстрируют автоматическое декодирование. Декодеры пользовательских форматов, разработанные с помощью неуправляемых интерфейсов Обработка изображений в WPF и зарегистрированные в системе, автоматически участвуют в выборе декодера. Благодаря этому пользовательские форматы могут автоматически отображаться в приложениях WPF.  
  
 В следующем примере показано использование декодера точечных рисунков для декодирования изображения формата BMP.  
  
 
 [!code-csharp[BmpBitmapDecoderEncoder#5](~/samples/snippets/csharp/VS_Snippets_Wpf/BmpBitmapDecoderEncoder/CSharp/BitmapFrame.cs#5)]
   
  
### <a name="image-format-encoding"></a>Кодирование изображений разных форматов  
 Кодирование изображения — это преобразование данных изображения в определенный формат. Кодированные данные изображения могут затем быть использованы для создания новых файлов изображений. Обработка изображений в WPF предоставляет кодировщики для каждого из описанных выше форматов изображения.  
  
 В следующем примере показано использование кодировщика для сохранения вновь созданного точечного рисунка.  
  
 
 [!code-csharp[BmpBitmapDecoderEncoder#3](~/samples/snippets/csharp/VS_Snippets_Wpf/BmpBitmapDecoderEncoder/CSharp/BitmapFrame.cs#3)]
   
  
<a name="_displayingimages"></a>   
## <a name="displaying-images-in-wpf"></a>Отображение изображений в WPF  
 Существует несколько способов отображения изображений в приложении Windows Presentation Foundation (WPF). Изображения могут отображаться с помощью <xref:System.Windows.Controls.Image> элемента управления, нарисованный в визуального элемента с помощью <xref:System.Windows.Media.ImageBrush>, или отображаются с помощью <xref:System.Windows.Media.ImageDrawing>.  
  
### <a name="using-the-image-control"></a>Использование элемента управления Image  
 <xref:System.Windows.Controls.Image> — Это элемент платформы и основной способ отображения изображений в приложениях. В XAML, <xref:System.Windows.Controls.Image> можно использовать в двух способов; синтаксис атрибутов или синтаксис свойств. В следующем примере показано, как можно отобразить изображение размером 200 пикселей в ширину, используя синтаксис атрибута и синтаксис тега свойства. Дополнительные сведения о синтаксисе атрибутов и синтаксисе свойств см. в разделе [Общие сведения о свойствах зависимостей](../advanced/dependency-properties-overview.md).  
  
 [!code-xaml[ImageElementExample_snip#ImageSimpleExampleInlineMarkup](~/samples/snippets/csharp/VS_Snippets_Wpf/ImageElementExample_snip/CSharp/ImageSimpleExample.xaml#imagesimpleexampleinlinemarkup)]  
  
 Во многих примерах используется <xref:System.Windows.Media.Imaging.BitmapImage> объект для ссылки на файл изображения. <xref:System.Windows.Media.Imaging.BitmapImage> является специализированным <xref:System.Windows.Media.Imaging.BitmapSource> , оптимизированный для XAML загрузки и простой способ отображения изображений в качестве <xref:System.Windows.Controls.Image.Source%2A> из <xref:System.Windows.Controls.Image> элемента управления.  
  
 В следующем примере показано, как построить изображение шириной 200 пикселей с использованием кода.  
  
> [!NOTE]
>  <xref:System.Windows.Media.Imaging.BitmapImage> реализует <xref:System.ComponentModel.ISupportInitialize> интерфейс для оптимизации инициализации на нескольких свойствах. Изменения свойств происходят только во время инициализации объекта. Вызовите <xref:System.Windows.Media.Imaging.BitmapImage.BeginInit%2A> для обозначения начала инициализации и <xref:System.Windows.Media.Imaging.BitmapImage.EndInit%2A> для обозначения завершения инициализации. После инициализации изменения свойств игнорируются.  
  
 [!code-csharp[ImageElementExample_snip#ImageSimpleExampleInlineCode1](~/samples/snippets/csharp/VS_Snippets_Wpf/ImageElementExample_snip/CSharp/ImageSimpleExample.xaml.cs#imagesimpleexampleinlinecode1)]
   
  
#### <a name="rotating-converting-and-cropping-images"></a>Вращение, преобразование и обрезка изображений  
 WPF позволяет пользователям осуществлять преобразования изображений с помощью свойств объекта <xref:System.Windows.Media.Imaging.BitmapImage> или с помощью дополнительных <xref:System.Windows.Media.Imaging.BitmapSource> объекты, такие как <xref:System.Windows.Media.Imaging.CroppedBitmap> или <xref:System.Windows.Media.Imaging.FormatConvertedBitmap>. С помощью этих преобразований можно масштабировать или поворачивать изображения, изменять формат пикселей изображения и обрезать изображения.  
  
 Вращение изображения осуществляется с помощью <xref:System.Windows.Media.Imaging.BitmapImage.Rotation%2A> свойство <xref:System.Windows.Media.Imaging.BitmapImage>. Вращение возможно только с шагом 90 градусов. В следующем примере изображение поворачивается на 90 градусов.  
  
 [!code-xaml[ImageElementExample#TransformedXAML2](~/samples/snippets/csharp/VS_Snippets_Wpf/ImageElementExample/CSharp/TransformedImageExample.xaml#transformedxaml2)]  
  
 [!code-csharp[ImageElementExample#TransformedCSharp1](~/samples/snippets/csharp/VS_Snippets_Wpf/ImageElementExample/CSharp/TransformedImageExample.xaml.cs#transformedcsharp1)]
   
  
 Преобразование изображения к другому формату, такие как серого выполняется с помощью <xref:System.Windows.Media.Imaging.FormatConvertedBitmap>. В следующих примерах изображения преобразуются в <xref:System.Windows.Media.PixelFormats.Gray4%2A>.  
  
 [!code-xaml[ImageElementExample_snip#ConvertedXAML2](~/samples/snippets/csharp/VS_Snippets_Wpf/ImageElementExample_snip/CSharp/FormatConvertedExample.xaml#convertedxaml2)]  
  
 [!code-csharp[ImageElementExample_snip#ConvertedCSharp1](~/samples/snippets/csharp/VS_Snippets_Wpf/ImageElementExample_snip/CSharp/FormatConvertedExample.xaml.cs#convertedcsharp1)]
   
  
 Чтобы обрезать изображение, либо <xref:System.Windows.UIElement.Clip%2A> свойство <xref:System.Windows.Controls.Image> или <xref:System.Windows.Media.Imaging.CroppedBitmap> может использоваться. Как правило, если вы просто хотите отобразить часть изображения, <xref:System.Windows.UIElement.Clip%2A> следует использовать. Если вам нужно закодировать и сохранить обрезанное изображения, <xref:System.Windows.Media.Imaging.CroppedBitmap> следует использовать. В следующем примере изображение обрезается с помощью свойства Clip с помощью <xref:System.Windows.Media.EllipseGeometry>.  
  
 [!code-xaml[ImageElementExample_snip#CroppedXAMLUsingClip1](~/samples/snippets/csharp/VS_Snippets_Wpf/ImageElementExample_snip/CSharp/CroppedImageExample.xaml#croppedxamlusingclip1)]  
  
 [!code-csharp[ImageElementExample_snip#CroppedCSharpUsingClip1](~/samples/snippets/csharp/VS_Snippets_Wpf/ImageElementExample_snip/CSharp/CroppedImageExample.xaml.cs#croppedcsharpusingclip1)]
   
  
#### <a name="stretching-images"></a>Растягивание изображений  
 <xref:System.Windows.Controls.Image.Stretch%2A> Свойство определяет, как изображение растягивается для заполнения его контейнера. <xref:System.Windows.Controls.Image.Stretch%2A> Свойство принимает следующие значения, определенные <xref:System.Windows.Media.Stretch> перечисления:  
  
-   <xref:System.Windows.Media.Stretch.None>: Изображение не растягивается для заполнения области вывода. Если изображение больше, чем область вывода, изображение заполняет область вывода с обрезкой тех частей, которые не входят.  
  
-   <xref:System.Windows.Media.Stretch.Fill>: Изображение масштабируется в соответствии с области вывода. Так как высота и ширина изображения масштабируются независимо друг от друга, исходные пропорции изображения могут не сохраниться. То есть изображение может быть деформировано для полного заполнения контейнера вывода.  
  
-   <xref:System.Windows.Media.Stretch.Uniform>: Изображение масштабируется таким образом, чтобы полностью уместиться внутри области вывода. Пропорции изображения сохраняются.  
  
-   <xref:System.Windows.Media.Stretch.UniformToFill>: Изображение масштабируется таким образом, чтобы полностью заполнить область вывода при этом сохранить исходные пропорции изображения.  
  
 В следующем примере применяется, каждое из доступных <xref:System.Windows.Media.Stretch> перечислений для <xref:System.Windows.Controls.Image>.  
  
 Ниже показаны выходные данные из примера и демонстрируется влияние различных <xref:System.Windows.Controls.Image.Stretch%2A> параметров изображения.  
  
 ![Различные параметры растяжения TileBrush](./media/img-mmgraphics-stretchenum.jpg "img_mmgraphics_stretchenum")  
Различные параметры растяжения  
  
 [!code-xaml[ImageElementExample_snip#ImageStretchExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/ImageElementExample_snip/CSharp/ImageStretchExample.xaml#imagestretchexamplewholepage)]  
  
### <a name="painting-with-images"></a>Закрашивание с помощью изображений  
 Изображения могут также отображаться в приложении путем рисования с помощью <xref:System.Windows.Media.Brush>. Кисти позволяют заполнять объекты UI различными изображениями, начиная с просто сплошного цвета и заканчивая сложными наборами шаблонов и изображений. Для заполнения изображением используйте <xref:System.Windows.Media.ImageBrush>. <xref:System.Windows.Media.ImageBrush> — Это разновидность <xref:System.Windows.Media.TileBrush> , определяющей содержимое как растровое изображение. <xref:System.Windows.Media.ImageBrush> Отображает одно изображение, которое определяется ее <xref:System.Windows.Media.ImageBrush.ImageSource%2A> свойство. Способом растяжения изображения, выравнивания и заполнения мозаикой можно управлять, что позволяет избегать искажений, создавать шаблоны и применять другие эффекты. На следующем рисунке показан некоторые эффекты, которые могут быть обеспечены <xref:System.Windows.Media.ImageBrush>.  
  
 ![Примеры вывода ImageBrush](./media/wcpsdk-mmgraphics-imagebrushexamples.gif "wcpsdk_mmgraphics_imagebrushexamples")  
Используя кисти изображения, можно заполнять фигуры, элементы управления, текст и многое другое  
  
 Следующий пример демонстрирует рисования фона кнопки с образа с помощью <xref:System.Windows.Media.ImageBrush>.  
  
 [!code-xaml[UsingImageBrush#4](~/samples/snippets/csharp/VS_Snippets_Wpf/UsingImageBrush/CS/PaintingWithImages.xaml#4)]  
  
 Дополнительные сведения о <xref:System.Windows.Media.ImageBrush> и закрашивании изображений см. в разделе [Рисование с помощью изображений, рисунков и визуальных элементов](painting-with-images-drawings-and-visuals.md).  
  
<a name="_metadata"></a>   
## <a name="image-metadata"></a>Метаданные изображений  
 Некоторые файлы изображений содержат метаданные, описывающие содержимое или характеристики файла. Например, большинство цифровых фотоаппаратов создают изображения, содержащие метаданные об изготовителе и модели фотоаппарата, использованного для создания изображения. В разных форматах изображения метаданные обрабатываются по-разному. Платформа Обработка изображений в WPF предоставляет универсальный способ хранения и извлечения метаданных для всех поддерживаемых форматов изображения.  
  
 Доступ к метаданным предоставляется через <xref:System.Windows.Media.Imaging.BitmapSource.Metadata%2A> свойство <xref:System.Windows.Media.Imaging.BitmapSource> объекта. <xref:System.Windows.Media.Imaging.BitmapSource.Metadata%2A> Возвращает <xref:System.Windows.Media.Imaging.BitmapMetadata> объекта, который содержит все метаданные, содержащиеся в изображении. Эти данные могут представлять собой одну схему метаданных или комбинацию различных схем. Обработка изображений в WPF поддерживает следующие схемы метаданных изображения: [!INCLUDE[TLA#tla_exif](../../../../includes/tlasharptla-exif-md.md)], текст (текстовые данные PNG), [!INCLUDE[TLA#tla_ifd](../../../../includes/tlasharptla-ifd-md.md)], [!INCLUDE[TLA#tla_iptc](../../../../includes/tlasharptla-iptc-md.md)], и [!INCLUDE[TLA#tla_xmp](../../../../includes/tlasharptla-xmp-md.md)].  
  
 Для упрощения процесса чтения метаданных <xref:System.Windows.Media.Imaging.BitmapMetadata> предоставляет несколько именованных свойств, которые легко доступны такие как <xref:System.Windows.Media.Imaging.BitmapMetadata.Author%2A>, <xref:System.Windows.Media.Imaging.BitmapMetadata.Title%2A>, и <xref:System.Windows.Media.Imaging.BitmapMetadata.CameraModel%2A>. Многие из этих именованных свойств могут также использоваться для записи метаданных. Дополнительная поддержка чтения метаданных обеспечивается благодаря использованию считывателя запросов метаданных. <xref:System.Windows.Media.Imaging.BitmapMetadata.GetQuery%2A> Метод используется для извлечения считывателя запросов метаданных, предоставляя строки запроса, такие как *«/ app1/exif /»*. В следующем примере <xref:System.Windows.Media.Imaging.BitmapMetadata.GetQuery%2A> используется для получения текста, хранящегося в *«/ Text/Description»* расположение.  
  
 
 [!code-csharp[BitmapMetadata#GetQuery](~/samples/snippets/csharp/VS_Snippets_Wpf/BitMapMetadata/CSharp/BitmapMetadata.cs#getquery)]
   
  
 Для написания метаданных используется мастер написания запросов метаданных. <xref:System.Windows.Media.Imaging.BitmapMetadata.SetQuery%2A> Получает запрос и задает требуемое значение. В следующем примере <xref:System.Windows.Media.Imaging.BitmapMetadata.SetQuery%2A> используется для записи текста, хранящегося в *«/ Text/Description»* расположение.  
  
 
 [!code-csharp[BitmapMetadata#SetQuery](~/samples/snippets/csharp/VS_Snippets_Wpf/BitMapMetadata/CSharp/BitmapMetadata.cs#setquery)]
   
  
<a name="_extensibility"></a>   
## <a name="codec-extensibility"></a>Расширяемость кодеков  
 Основной особенностью Обработка изображений в WPF является модель расширяемости для новых кодеков изображений. Эти неуправляемые интерфейсы позволяют разработчикам кодеков интегрировать кодеки в WPF. Благодаря этому новые форматы изображений могут автоматически использоваться приложениями WPF.  
  
 Пример расширяемости API см. в разделе [Пример кодека Win32](https://go.microsoft.com/fwlink/?LinkID=160052). В этом примере показано создание декодера и кодировщика для пользовательского формата изображения.  
  
> [!NOTE]
>  Чтобы система могла распознать кодек, он должен иметь цифровую подпись.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Imaging.BitmapSource>
- <xref:System.Windows.Media.Imaging.BitmapImage>
- <xref:System.Windows.Controls.Image>
- <xref:System.Windows.Media.Imaging.BitmapMetadata>
- [Двумерная графика и изображения](../advanced/optimizing-performance-2d-graphics-and-imaging.md)
- [Пример кодека Win32](https://go.microsoft.com/fwlink/?LinkID=160052)

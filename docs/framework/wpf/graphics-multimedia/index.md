---
title: Графика и мультимедиа
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- media [WPF], features
- video effects [WPF]
- sound effects [WPF]
- animation [WPF], features
- graphics features [WPF]
- transition effects [WPF]
ms.assetid: 1817d9dc-3d6c-46cb-afc8-63b0bae35e37
ms.openlocfilehash: 58ee58577b9ff71112103abb4d33c8b85d3c806f
ms.sourcegitcommit: 859b2ba0c74a1a5a4ad0d59a3c3af23450995981
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/11/2019
ms.locfileid: "59481357"
---
# <a name="graphics-and-multimedia"></a>Графика и мультимедиа

<a name="introduction"></a>
[!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] обеспечивает поддержку мультимедиа, векторную графику, анимацию и композицию содержимого, что упрощает для разработчиков создание интересных пользовательских интерфейсов и содержимого. С помощью [!INCLUDE[TLA#tla_visualstu](../../../../includes/tlasharptla-visualstu-md.md)] можно создать векторную графику или сложную анимацию и интегрировать мультимедиа в приложения.

В этом разделе представлены возможности графики, анимации и мультимедиа в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], которые позволяют добавлять в приложения рисунки, эффекты перехода, звук и видео.

> [!NOTE]
> Использование типов WPF в службе Windows настоятельно не рекомендуется. При попытке использовать типы WPF в службе Windows, службы могут не работать должным образом.

<a name="whats_new_with_graphics_and_multimedia_in_wpf_4"></a>

## <a name="whats-new-with-graphics-and-multimedia-in-wpf-4"></a>Новые графические и мультимедийные возможности в WPF 4

В части графики и анимации были сделаны некоторые изменения.

- Округление макета

  Когда граница объекта попадает в середину пикселя устройства, не зависящая от разрешения система графики может создавать артефакты отрисовки, например нечеткие или полупрозрачные границы. Предыдущие версии WPF для обработки таких случаев включали функцию привязки пикселей. В Silverlight 2 появилось округление макета, являющееся другим способом перемещения элементов так, чтобы границы попадали между пикселями. Теперь WPF поддерживает округление макета с помощью <xref:System.Windows.FrameworkElement.UseLayoutRounding%2A> вложенного свойства зависимостей <xref:System.Windows.FrameworkElement>.

- Кэшированная композиция

  С помощью нового <xref:System.Windows.Media.BitmapCache> и <xref:System.Windows.Media.BitmapCacheBrush> классы, можно кэшировать сложной частью визуального дерева как растровое изображение и значительно уменьшить время отрисовки. Растровое изображение продолжает реагировать на действия пользователя, например на щелчки мыши, и им можно рисовать на других элементах, как любой кистью.

- Поддержка построителя текстур 3

  WPF 4 строится на основе <xref:System.Windows.Media.Effects.ShaderEffect> реализованной в WPF 3.5 SP1, позволяя приложениям записывать эффекты с помощью построителя текстуры (PS) версии 3.0. Шейдерная модель PS 3.0 сложнее, чем PS 2.0, что позволяет реализовать гораздо больше эффектов на поддерживаемом оборудовании.

- Функции плавности

  Можно усовершенствовать анимацию с помощью функций плавности, которые обеспечивают дополнительный контроль над поведением анимации. Например, можно применить <xref:System.Windows.Media.Animation.ElasticEase> к анимации, чтобы придать анимации быстроту. Дополнительные сведения см. в описании типов плавности <xref:System.Windows.Media.Animation> пространства имен.

<a name="graphics_and_rendering"></a>

## <a name="graphics-and-rendering"></a>Графика и отрисовка

WPF включает поддержку двумерной графики высокого качества. Возможности включают кисти, геометрические объекты, изображения, фигуры и преобразования. Дополнительные сведения см. в разделе [Графика](graphics.md). Отрисовка графических элементов основана на <xref:System.Windows.Media.Visual> класса. Структура визуальных объектов на экране описывается визуальным деревом. Дополнительные сведения см. в разделе [Общие сведения об отрисовке графики в WPF](wpf-graphics-rendering-overview.md).

### <a name="2-d-shapes"></a>Двумерные фигуры

[!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] предоставляет библиотеку часто используемые, векторных [!INCLUDE[TLA2#tla_2d](../../../../includes/tla2sharptla-2d-md.md)] фигур, таких как прямоугольники и эллипсы, которые показаны на следующем рисунке.

![Схема отображение эллипсы и прямоугольники.](./media/index/two-deminsional-shapes-ellipses-rectangles.png)

Эти встроенные фигуры [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] являются не просто фигурами: это программируемые элементы, в которых реализованы многие возможности, ожидаемые от наиболее распространенных элементов управления, включая клавиатуру и мышь. В следующем примере показано, как обрабатывать <xref:System.Windows.UIElement.MouseUp> события, возникающего при щелчке <xref:System.Windows.Shapes.Ellipse> элемент.

```xaml
<Window
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  x:Class="Window1" >
  <Ellipse Fill="LightBlue" MouseUp="ellipseButton_MouseUp" />
</Window>
```

```csharp
public partial class Window1  : Window
{
    void ellipseButton_MouseUp(object sender, MouseButtonEventArgs e)
    {
        MessageBox.Show("You clicked the ellipse!");
    }
}
```

```vb
Partial Public Class Window1
    Inherits Window
    Private Sub ellipseButton_MouseUp(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
        MessageBox.Show("You clicked the ellipse!")
    End Sub
End Class
```

На следующем рисунке показан результат выполнения предыдущей разметки [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] и кода.

![Окно сообщения, сообщение, «You clicked the ellipse!»](./media/index/messagebox-text-output.png)

Более подробную информацию см. в разделе [Обзор фигур и базовых средств рисования в приложении WPF](shapes-and-basic-drawing-in-wpf-overview.md). Вводный пример см. в разделе [Пример элементов-фигур](https://go.microsoft.com/fwlink/?LinkID=160037).

### <a name="2-d-geometries"></a>Двумерные геометрические объекты

Когда фигур [!INCLUDE[TLA2#tla_2d](../../../../includes/tla2sharptla-2d-md.md)], предоставляемых [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)], недостаточно, можно использовать поддержку [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] геометрических фигур и путей для создания собственных. Ниже показано, как можно использовать геометрические объекты для создания фигур (например, кисти рисования) и обрезки других элементов [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)].

![Снимок экрана, показывающий, как можно использовать геометрические объекты для создания фигур.](./media/index/use-geometries-create-shapes.png)

Более подробную информацию см. в разделе [Общие сведения о классе Geometry](geometry-overview.md). Вводный пример в разделе [Примеры геометрических объектов](https://go.microsoft.com/fwlink/?LinkID=159989).

### <a name="2-d-effects"></a>Двумерные эффекты

[!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] предоставляет библиотеку [!INCLUDE[TLA2#tla_2d](../../../../includes/tla2sharptla-2d-md.md)] классы, которые можно использовать для создания различных эффектов. Возможности отрисовки в [!INCLUDE[TLA2#tla_2d](../../../../includes/tla2sharptla-2d-md.md)] для [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] позволяют рисовать элементы [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)], имеющие градиентные заливки, растровые изображения, рисунки и видео, а также управлять ими с помощью вращения, масштабирования и наклона. На следующем рисунке приведен пример многих эффектов, которых можно добиться с помощью кисти [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)].

![Иллюстрация различных кистей WPF и элементов заливкой.](./media/index/brushes-paint-elements.png)

Более подробную информацию см. в разделе [Общие сведения о кистях WPF](wpf-brushes-overview.md). Вводный пример см. в разделе [Пример использования кистей](https://go.microsoft.com/fwlink/?LinkID=159973).

<a name="rendering"></a>

## <a name="3-d-rendering"></a>Трехмерная отрисовка

[!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] предоставляет набор [!INCLUDE[TLA2#tla_3d](../../../../includes/tla2sharptla-3d-md.md)] возможности отрисовки, которые интегрируются с [!INCLUDE[TLA2#tla_2d](../../../../includes/tla2sharptla-2d-md.md)] поддержки графики в [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] в порядке для создания более интересного макета, [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)]и визуализации данных. С одной стороны, [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] позволяет отрисовывать изображения [!INCLUDE[TLA2#tla_2d](../../../../includes/tla2sharptla-2d-md.md)] на поверхностях фигур [!INCLUDE[TLA2#tla_3d](../../../../includes/tla2sharptla-3d-md.md)], что показано на рисунке ниже.

![Снимок экрана: пример, показывающий трехмерных фигур с помощью различных текстур.](./media/index/visual-three-dimensional-shape.png)

Более подробную информацию см. в разделе [Обзор трехмерной графики](3-d-graphics-overview.md). Вводный пример см. в разделе [Пример трехмерных тел](https://go.microsoft.com/fwlink/?LinkID=159964).

<a name="animation"></a>

## <a name="animation"></a>Анимация

Использование анимации позволяет применять к элементам управления и графическим элементам такие эффекты, как увеличение, дрожание, вращение и исчезание, создавать интересные эффекты смены страниц и другие эффекты. Поскольку [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] позволяет анимировать большинство свойств, можно анимировать не только большинство объектов [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)], но и использовать [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] для анимации пользовательских объектов.

![Снимок экрана анимированного куба.](./media/index/animate-custom-objects.png)

Более подробную информацию см. в разделе [Общие сведения об эффектах анимации](animation-overview.md). Вводный пример в разделе [Коллекция примеров анимации](https://go.microsoft.com/fwlink/?LinkID=159969).

<a name="media"></a>

## <a name="media"></a>Мультимедиа

Изображения, видео и аудио являются мультимедийными способами передачи информации и взаимодействия с пользователями.

### <a name="images"></a>Изображений

Изображения, которые включают значки, фоновые рисунки и даже части анимаций, являются одним из основных элементов большинства приложений. Так как с изображениями приходится работать часто, [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] предоставляет возможность работать с ними различными способами. На следующем рисунке показан один из таких способов.

![Снимок экрана стилей](../controls/./media/stylingintro-eventtriggers.png "StylingIntro_EventTriggers")

Более подробную информацию см. в разделе [Общие сведения об обработке изображений](imaging-overview.md).

### <a name="video-and-audio"></a>Видео и звук

Одна из основных особенностей графических возможностей [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] — встроенная поддержка работы с мультимедиа, что включает видео и аудио. Следующий пример демонстрирует вставку в приложение медиапроигрывателя.

```xaml
<MediaElement Source="media\numbers.wmv" Width="450" Height="250" />
```

<xref:System.Windows.Controls.MediaElement> позволяет воспроизводить видео и аудио и достаточно расширяемым для простого создания пользовательских [!INCLUDE[TLA2#tla_ui#plural](../../../../includes/tla2sharptla-uisharpplural-md.md)].

Дополнительные сведения см. в разделе [Общие сведения о мультимедиа](multimedia-overview.md).

## <a name="see-also"></a>См. также

- <xref:System.Windows.Media>
- <xref:System.Windows.Media.Animation>
- <xref:System.Windows.Media.Media3D>
- [Двумерная графика и изображения](../advanced/optimizing-performance-2d-graphics-and-imaging.md)
- [Обзор фигур и базовых средств рисования в приложении WPF](shapes-and-basic-drawing-in-wpf-overview.md)
- [Общие сведения о закраске сплошным цветом и градиентом](painting-with-solid-colors-and-gradients-overview.md)
- [Рисование с помощью объектов Image, Drawing и Visual](painting-with-images-drawings-and-visuals.md)
- [Разделы руководства по анимации и таймерам](animation-and-timing-how-to-topics.md)
- [Обзор трехмерной графики](3-d-graphics-overview.md)
- [Общие сведения о мультимедиа](multimedia-overview.md)

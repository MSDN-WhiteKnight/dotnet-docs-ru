---
title: Практическое руководство. Установка размера плитки для объекта TileBrush
ms.date: 03/30/2017
helpviewer_keywords:
- TileBrush [WPF], size of tile properties
- Viewport property of TileBrush [WPF]
ms.assetid: 04f41090-1b46-4e36-832f-d27d28708b8c
ms.openlocfilehash: 80b5dfc668464df829db593668bea8a9a4ec09e4
ms.sourcegitcommit: bce0586f0cccaae6d6cbd625d5a7b824d1d3de4b
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/02/2019
ms.locfileid: "58839700"
---
# <a name="how-to-set-the-tile-size-for-a-tilebrush"></a>Практическое руководство. Установка размера плитки для объекта TileBrush

В этом примере показано, как установить размер мозаики для <xref:System.Windows.Media.TileBrush>. По умолчанию <xref:System.Windows.Media.TileBrush> создает один фрагмент, который полностью заполняет область закрашивания. Это поведение можно переопределить, задав <xref:System.Windows.Media.TileBrush.Viewport%2A> и <xref:System.Windows.Media.TileBrush.ViewportUnits%2A> свойства.

<xref:System.Windows.Media.TileBrush.Viewport%2A> Свойство определяет размер мозаики для <xref:System.Windows.Media.TileBrush>. По умолчанию значение <xref:System.Windows.Media.TileBrush.Viewport%2A> свойство является относительно размера закрашиваемой области. Чтобы сделать <xref:System.Windows.Media.TileBrush.Viewport%2A> свойство указывать абсолютный размер мозаики, задайте <xref:System.Windows.Media.TileBrush.ViewportUnits%2A> свойства <xref:System.Windows.Media.BrushMappingMode.Absolute>.

## <a name="example"></a>Пример

В следующем примере используется <xref:System.Windows.Media.ImageBrush>, тип <xref:System.Windows.Media.TileBrush>, для заполнения прямоугольника мозаикой. В примере каждая Плитка 50% на 50 процентов от области вывода (прямоугольник). В результате прямоугольник заполняется четырьмя проекциями изображения.

На следующем рисунке показан результат выполнения этого примера:

![Прямоугольник с четырьмя вишнями Демонстрация мозаики с использованием кисти изображения.](./media/how-to-set-the-tile-size-for-a-tilebrush/rectangle-tile-image-brush.png)

[!code-csharp[UsingImageBrush_snip#RelativeTileSizeExample](~/samples/snippets/csharp/VS_Snippets_Wpf/UsingImageBrush_snip/CSharp/TileSizeExample.cs#relativetilesizeexample)]

В следующем примере создается <xref:System.Windows.Media.ImageBrush>, задает его <xref:System.Windows.Media.TileBrush.Viewport%2A> для `0,0,25,25` и его <xref:System.Windows.Media.TileBrush.ViewportUnits%2A> для <xref:System.Windows.Media.BrushMappingMode.Absolute>и используется для закрашивания другого прямоугольника. В результате кисть создает мозаику размером 25 пикселей в ширину и 25 пикселей в высоту.

На следующем рисунке показан результат выполнения этого примера:

![Прямоугольник с вишнями сорок восемь, демонстрирующий Мозаичная кисть TileBrush с окном просмотра.](./media/how-to-set-the-tile-size-for-a-tilebrush/25-x-25-viewport-tilebrush.png)

[!code-csharp[UsingImageBrush_snip#AbsoluteTileSizeExample](~/samples/snippets/csharp/VS_Snippets_Wpf/UsingImageBrush_snip/CSharp/TileSizeExample.cs#absolutetilesizeexample)]

Следующий пример является частью большого примера. Полный пример см. в разделе [пример использования кистей](https://go.microsoft.com/fwlink/?LinkID=160005).

Несмотря на то, что в этом примере используется <xref:System.Windows.Media.ImageBrush> класс, <xref:System.Windows.Media.TileBrush.Viewport%2A> и <xref:System.Windows.Media.TileBrush.ViewportUnits%2A> свойства ведут себя идентично для других <xref:System.Windows.Media.TileBrush> объектов, то есть для <xref:System.Windows.Media.DrawingBrush> и <xref:System.Windows.Media.VisualBrush>. Дополнительные сведения о <xref:System.Windows.Media.ImageBrush> , а другой <xref:System.Windows.Media.TileBrush> объектов, см. в разделе [Рисование с помощью изображений, рисунков и визуальных элементов](painting-with-images-drawings-and-visuals.md).

## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.TileBrush>
- [Заполнение с использованием изображений, рисунков и визуальных элементов](painting-with-images-drawings-and-visuals.md)
- [Создание различных шаблонов мозаики с помощью TileBrush](how-to-create-different-tile-patterns-with-a-tilebrush.md)

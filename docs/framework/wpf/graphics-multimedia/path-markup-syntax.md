---
title: Синтаксис разметки пути
ms.date: 03/30/2017
helpviewer_keywords:
- attribute usage in XAML [WPF]
- XAML [WPF], attribute usage
- graphics [WPF], PathGeometry class
- XAML [WPF], object element usage
ms.assetid: b8586241-a02d-486e-9223-e1e98e047f41
ms.openlocfilehash: 32eefba26b5e04370599e4c97767b6662cfd1c13
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59082494"
---
# <a name="path-markup-syntax"></a>Синтаксис разметки пути
Путями, рассматриваются в [фигур и базовых средств рисования в WPF Обзор](shapes-and-basic-drawing-in-wpf-overview.md) и [Общие сведения о геометрии](geometry-overview.md), однако в этом разделе подробно описываются сложной и мощной мини-язык, который можно использовать для указания пути более [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)].  
  
<a name="prerequisites"></a>   
## <a name="prerequisites"></a>Предварительные требования  
 Для понимания этого раздела необходимо ознакомиться с основным функциям <xref:System.Windows.Media.Geometry> объектов. Дополнительные сведения см. в разделе [Общие сведения о геометрии](geometry-overview.md).  
  
<a name="abouthisdocument"></a>   
## <a name="streamgeometry-and-pathfigurecollection-mini-languages"></a>Мини-языки StreamGeometry и PathFigureCollection  
 WPF предоставляет два класса, обеспечивающих мини языки для описания геометрических путей: <xref:System.Windows.Media.StreamGeometry> и <xref:System.Windows.Media.PathFigureCollection>.  
  
-   Использовании <xref:System.Windows.Media.StreamGeometry> мини-язык, при задании свойства типа <xref:System.Windows.Media.Geometry>, такие как <xref:System.Windows.UIElement.Clip%2A> свойство <xref:System.Windows.UIElement> или <xref:System.Windows.Shapes.Path.Data%2A> свойство <xref:System.Windows.Shapes.Path> элемент. В следующем примере синтаксис атрибутов для создания <xref:System.Windows.Media.StreamGeometry>.  
  
     [!code-xaml[GeometrySample_snip_XAML#GraphicsMMStreamGeometryAttributeSyntaxInline](~/samples/snippets/csharp/VS_Snippets_Wpf/GeometrySample_snip_XAML/CS/MiniLanguageExample.xaml#graphicsmmstreamgeometryattributesyntaxinline)]  
  
-   Использовании <xref:System.Windows.Media.PathFigureCollection> мини-язык, при задании <xref:System.Windows.Media.PathGeometry.Figures%2A> свойство <xref:System.Windows.Media.PathGeometry>. В следующем примере синтаксис атрибутов для создания <xref:System.Windows.Media.PathFigureCollection> для <xref:System.Windows.Media.PathGeometry>.  
  
     [!code-xaml[GeometrySample_snip_XAML#GraphicsMMPathFigureCollectionAttributeSyntaxInline](~/samples/snippets/csharp/VS_Snippets_Wpf/GeometrySample_snip_XAML/CS/MiniLanguageExample.xaml#graphicsmmpathfigurecollectionattributesyntaxinline)]  
  
 Как видно из предыдущих примеров мини-языки очень похожи. Это всегда можно использовать <xref:System.Windows.Media.PathGeometry> в любой ситуации, когда можно использовать <xref:System.Windows.Media.StreamGeometry>; поэтому какой из них следует использовать? Используйте <xref:System.Windows.Media.StreamGeometry> при не требуется изменять путь после его создания; используйте <xref:System.Windows.Media.PathGeometry> Если вам нужно изменить путь.  
  
 Дополнительные сведения о различиях между <xref:System.Windows.Media.PathGeometry> и <xref:System.Windows.Media.StreamGeometry> объектов, см. в разделе [Общие сведения о геометрии](geometry-overview.md).  
  
### <a name="a-note-about-white-space"></a>Примечание о пробелах  
 В следующих разделах для краткости в примерах синтаксиса показан один пробел, но допускается использовать по нескольку пробелов везде, где указан один пробел.  
  
 Два числа не обязательно должны быть разделены запятыми или пробелы, но это может быть выполнено, только если результирующая строка получается неоднозначной. Например `2..3` фактически представляет два числа: "2." и 3. Аналогичным образом `2-3` «2» и «-3". Пробелы до и после команд ставить необязательно.  
  
### <a name="syntax"></a>Синтаксис  
 [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] Атрибута синтаксис для использования <xref:System.Windows.Media.StreamGeometry> состоит из необязательного <xref:System.Windows.Media.FillRule> значение и один или несколько следующих описаний.  
  
|Использование атрибута XAML на StreamGeometry|  
|-----------------------------------------|  
|`<` *Объект* *свойство* `="`[ `fillRule`] `figureDescription`[ `figureDescription`] * `" ... />`|  
  
 [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] Атрибута синтаксис для использования <xref:System.Windows.Media.PathFigureCollection> состоит из одного или нескольких описаний.  
  
|Использование атрибута XAML на PathFigureCollection|  
|-----------------------------------------------|  
|`<` *Объект* *свойство* `="` `figureDescription`[ `figureDescription`] * `" ... />`|  
  
|Термин|Описание|  
|----------|-----------------|  
|*fillRule*|<xref:System.Windows.Media.FillRule?displayProperty=nameWithType><br /><br /> Указывает, является ли <xref:System.Windows.Media.StreamGeometry> использует <xref:System.Windows.Media.FillRule.EvenOdd> или <xref:System.Windows.Media.FillRule.Nonzero><xref:System.Windows.Media.PathGeometry.FillRule%2A>.<br /><br /> -   `F0` Указывает <xref:System.Windows.Media.FillRule.EvenOdd> правило заполнения.<br />-   `F1` Указывает <xref:System.Windows.Media.FillRule.Nonzero> правило заполнения.<br /><br /> Если опустить эту команду, во вложенном пути используется поведение по умолчанию, которое является <xref:System.Windows.Media.FillRule.EvenOdd>. Если эта команда используется, ее необходимо размещать вначале.|  
|*figureDescription*|Фигура, состоящая из команды перемещения, команд рисования и необязательной команды закрытия.<br /><br /> `moveCommand` `drawCommands`  `[` `closeCommand` `]`|  
|*moveCommand*|Команда перемещения, которая указывает начальную точку фигуры. См. в разделе [команда перемещения](#themovecommand) раздел.|  
|*drawCommands*|Одна или несколько команд рисования, описывающих содержимое фигуры. См. в разделе [команда рисования](#drawcommands) раздел.|  
|*closeCommand*|Необязательная команда, которая закрывает фигуру. См. в разделе [команда закрытия](#closecommand) раздел.|  
  
<a name="themovecommand"></a>   
## <a name="move-command"></a>Команда перемещения  
 Задает начальную точку новой фигуры.  
  
|Синтаксис|  
|------------|  
|`M` *startPoint*<br /><br /> -или-<br /><br /> `m` *startPoint*|  
  
|Термин|Описание|  
|----------|-----------------|  
|*startPoint*|<xref:System.Windows.Point?displayProperty=nameWithType><br /><br /> Начальная точка новой фигуры.|  
  
 Верхнерегистровая `M` указывает, что `startPoint` значение является абсолютным; строчных букв `m` указывает, что `startPoint` — это смещение к предыдущей точке, или (0,0), если он не существует. Если после команды перемещения указано несколько точек, будет нарисована линия к этим точкам, как в случае указания команды рисования линии.  
  
<a name="drawcommands"></a>   
## <a name="draw-commands"></a>Команды рисования  
 Команда рисования может состоять из нескольких команд формы. Имеются следующие команды формы: линия, горизонтальная линия, вертикальная линия, кривая Безье третьего порядка, кривая Безье второго порядка, гладкая кривая Безье третьего порядка, гладкая кривая Безье второго порядка и эллиптическая дуга.  
  
 Все команды можно вводить как прописными, так и строчными буквами. Прописными буквами определяются абсолютные значения, а строчными —относительные. Контрольная точка для этого сегмента указывается относительно конечной точки в предыдущем примере. При последовательном вводе нескольких команд одного типа, можно опустить Повторяющийся заголовок команды; например `L 100,200 300,400` эквивалентен `L 100,200 L 300,400`. В следующей таблице описаны **переместить** и **рисования** команды.  
  
### <a name="line-command"></a>Команда рисования линии  
 Создает прямую линию между текущей и заданной конечной точками. `l 20 30` и `L 20,30` — примеры допустимых **строки** команды.  
  
|Синтаксис|  
|------------|  
|`L` *Конечная точка*<br /><br /> -или-<br /><br /> `l` *Конечная точка*|  
  
|Термин|Описание|  
|----------|-----------------|  
|*Конечная точка*|<xref:System.Windows.Point?displayProperty=nameWithType><br /><br /> Конечная точка строки.|  

Верхнерегистровая `L` указывает, что `endPoint` значение является абсолютным; строчных букв `l` указывает, что `endPoint` — это смещение к предыдущей точке, или (0,0), если он не существует.

### <a name="horizontal-line-command"></a>Команда рисования горизонтальной линии  
 Создает горизонтальную линию между текущей точкой и заданной координатой X. `H 90` приведен пример допустимой команды горизонтальной линии.

|Синтаксис|  
|------------|  
|`H`  *x*<br /><br /> -или-<br /><br /> `h`  *x*|  
  
|Термин|Описание|  
|----------|-----------------|  
|*x*|<xref:System.Double?displayProperty=nameWithType><br /><br /> Координата X конечной точки линии.|  
  
Верхнерегистровая `H` указывает, что `x` значение является абсолютным; строчных букв `h` указывает, что `x` — это смещение к предыдущей точке, или (0,0), если он не существует.
  
### <a name="vertical-line-command"></a>Команда рисования вертикальной линии  
 Создает вертикальную линию между текущей точкой и заданной координатой Y. `v 90` приведен пример допустимой команды вертикальной линии.

|Синтаксис|  
|------------|  
|`V`  *y*<br /><br /> -или-<br /><br /> `v`  *y*|  
  
|Термин|Описание|  
|----------|-----------------|  
|*y*|<xref:System.Double?displayProperty=nameWithType><br /><br /> Координата Y конечной точки линии.|  

Верхнерегистровая `V` указывает, что `y` значение является абсолютным; строчных букв `v` указывает, что `y` — это смещение к предыдущей точке, или (0,0), если он не существует.  
    
### <a name="cubic-bezier-curve-command"></a>Команда рисования кривой Безье третьего порядка  
 Создает кривую Безье третьего порядка между текущей точкой и заданной конечной точкой с помощью двух заданных контрольных точек (`controlPoint`1 и `controlPoint`2). `C 100,200 200,400 300,200` приведен пример команды допустимым кривой.  
  
|Синтаксис|  
|------------|  
|`C` `controlPoint`1`controlPoint`2`endPoint`<br /><br /> -или-<br /><br /> `c` `controlPoint`1`controlPoint`2`endPoint`|  
  
|Термин|Описание|  
|----------|-----------------|  
|`controlPoint`1|<xref:System.Windows.Point?displayProperty=nameWithType><br /><br /> Первая контрольная точка кривой, которая определяет начальную касательную к кривой.|  
|`controlPoint`2|<xref:System.Windows.Point?displayProperty=nameWithType><br /><br /> Вторая контрольная точка кривой, которая определяет конечную касательную к кривой.|  
|`endPoint`|<xref:System.Windows.Point?displayProperty=nameWithType><br /><br /> Точка для рисования кривой.|  
  
### <a name="quadratic-bezier-curve-command"></a>Команда рисования кривой Безье второго порядка  
 Создает кривую Безье второго порядка между текущей точкой и заданной конечной точкой с использованием заданной контрольной точки (`controlPoint`). `q 100,200 300,200` приведен пример допустимой команды кривой Безье второго порядка.  
  
|Синтаксис|  
|------------|  
|`Q` `controlPoint` `endPoint`<br /><br /> -или-<br /><br /> `q` `controlPoint` `endPoint`|  
  
|Термин|Описание|  
|----------|-----------------|  
|`controlPoint`|<xref:System.Windows.Point?displayProperty=nameWithType><br /><br /> Контрольная точка кривой, которая определяет начальную и конечную касательные к кривой.|  
|`endPoint`|<xref:System.Windows.Point?displayProperty=nameWithType><br /><br /> Точка для рисования кривой.|  
  
### <a name="smooth-cubic-bezier-curve-command"></a>Команда рисования гладкой кривой Безье третьего порядка  
 Создает кривую Безье третьего порядка между текущей и заданной конечной точками. Предполагается, что первая контрольная точка является отражением второй контрольной точки предыдущей команды относительно текущей точки. Если нет предыдущей команды или если предыдущая команда не является командой рисования кривой Безье третьего порядка или командой рисования гладкой кривой Безье третьего порядка, считается, что первая контрольная точка совпадает с текущей точкой. Вторая контрольная точка, контрольная точка конца кривой, задается `controlPoint`2. Например `S 100,200 200,300` — это допустимая команда гладкой кривой Безье третьего порядка.  
  
|Синтаксис|  
|------------|  
|`S` `controlPoint`2`endPoint`<br /><br /> -или-<br /><br /> `s` `controlPoint`2`endPoint`|  
  
|Термин|Описание|  
|----------|-----------------|  
|`controlPoint`2|<xref:System.Windows.Point?displayProperty=nameWithType><br /><br /> Контрольная точка кривой, которая определяет конечную касательную к кривой.|  
|`endPoint`|<xref:System.Windows.Point?displayProperty=nameWithType><br /><br /> Точка для рисования кривой.|  
  
### <a name="smooth-quadratic-bezier-curve-command"></a>Команда рисования гладкой кривой Безье второго порядка  
 Создает кривую Безье второго порядка между текущей и заданной конечной точками. Предполагается, что контрольная точка является отражением контрольной точки предыдущей команды относительно текущей точки. Если нет предыдущей команды или если предыдущая команда не является командой рисования кривой Безье второго порядка или командой рисования гладкой кривой Безье второго порядка, считается, что контрольная точка совпадает с текущей точкой.  
  
|Синтаксис|  
|------------|  
|`T` `controlPoint` `endPoint`<br /><br /> -или-<br /><br /> `t` `controlPoint` `endPoint`|  
  
|Термин|Описание|  
|----------|-----------------|  
|`controlPoint`|<xref:System.Windows.Point?displayProperty=nameWithType><br /><br /> Контрольная точка кривой, которая определяет начальную касательную к кривой.|  
|`endPoint`|<xref:System.Windows.Point?displayProperty=nameWithType><br /><br /> Точка для рисования кривой.|  
  
### <a name="elliptical-arc-command"></a>Команда рисования эллиптической дуги  
 Создает эллиптическую дугу между текущей и заданной конечной точками.  
  
|Синтаксис|  
|------------|  
|`A` `size` `rotationAngle` `isLargeArcFlag` `sweepDirectionFlag` `endPoint`<br /><br /> -или-<br /><br /> `a` `size` `rotationAngle` `isLargeArcFlag` `sweepDirectionFlag` `endPoint`|  
  
|Термин|Описание|  
|----------|-----------------|  
|`size`|<xref:System.Windows.Size?displayProperty=nameWithType><br /><br /> Радиусы арки X и Y.|  
|`rotationAngle`|<xref:System.Double?displayProperty=nameWithType><br /><br /> Поворот эллипса в градусах.|  
|`isLargeArcFlag`|Значение 1, если угол дуги должен быть 180 градусов или больше, в противном случае — значение 0.|  
|`sweepDirectionFlag`|Значение 1, если дуга рисуется в направлении положительного угла, в противном случае — значение 0.|  
|`endPoint`|<xref:System.Windows.Point?displayProperty=nameWithType><br /><br /> Точка, в которую рисуется дуга.|  
  
<a name="closecommand"></a>   
## <a name="the-close-command"></a>Команда закрытия  
 Заканчивает текущую фигуру и создает линию, соединяющую текущую точку с начальной точкой фигуры. Эта команда создает соединительную линию (угол) между последним и первым сегментами фигуры.  
  
|Синтаксис|  
|------------|  
|`Z`<br /><br /> -или-<br /><br /> `z`|  

<a name="pointsyntax"></a>   
## <a name="point-syntax"></a>Синтаксис точки  
 Описывает x и y координаты точки где (0,0) находится в левом верхнем углу.
  
|Синтаксис|  
|------------|  
|`x` `,` `y`<br /><br /> -или-<br /><br /> `x` `y`|  
  
|Термин|Описание|  
|----------|-----------------|  
|`x`|<xref:System.Double?displayProperty=nameWithType><br /><br /> Координата X точки.|  
|`y`|<xref:System.Double?displayProperty=nameWithType><br /><br /> Координата Y точки.|  
  
<a name="specialvalues"></a>   
## <a name="special-values"></a>Специальные значения  
 Вместо стандартных числовых значений можно использовать следующие специальные значения. Эти значения чувствительны к регистру.  
  
 Бесконечность  
 Представляет <xref:System.Double.PositiveInfinity?displayProperty=nameWithType>.  
  
 -бесконечность  
 Представляет <xref:System.Double.NegativeInfinity?displayProperty=nameWithType>.  
  
 NaN  
 Представляет <xref:System.Double.NaN?displayProperty=nameWithType>.  
  
 Можно также использовать экспоненциальное представление чисел. Например `+1.e17` является допустимым значением.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Shapes.Path>
- <xref:System.Windows.Media.StreamGeometry>
- <xref:System.Windows.Media.PathGeometry>
- <xref:System.Windows.Media.PathFigureCollection>
- [Обзор фигур и базовых средств рисования в приложении WPF](shapes-and-basic-drawing-in-wpf-overview.md)
- [Общие сведения о классе Geometry](geometry-overview.md)
- [Практические руководства](geometries-how-to-topics.md)

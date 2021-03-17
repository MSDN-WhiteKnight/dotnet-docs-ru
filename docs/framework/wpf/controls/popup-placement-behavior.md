---
title: Поведение при размещении контекстного меню
ms.date: 03/30/2017
helpviewer_keywords:
- popups [WPF]
- Popup control [WPF], placing
- placing popups [WPF]
- positioning popups [WPF]
ms.assetid: fbf642e9-f670-4efd-a7af-a67468a1c8e1
ms.openlocfilehash: 911c2064e34ed8d0a341ffd9a52f852eab677e0a
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59161504"
---
# <a name="popup-placement-behavior"></a>Поведение при размещении контекстного меню
Объект <xref:System.Windows.Controls.Primitives.Popup> управления отображает содержимое в отдельном окне, расположенном поверх приложения. Можно указать положение <xref:System.Windows.Controls.Primitives.Popup> по отношению к элементу управления, мыши или экрана с помощью <xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A>, <xref:System.Windows.Controls.Primitives.Popup.Placement%2A>, <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A>, <xref:System.Windows.Controls.Primitives.Popup.HorizontalOffset%2A>, и <xref:System.Windows.Controls.Primitives.Popup.VerticalOffset%2A> свойства.  Эти свойства совместной работы позволяют гибко указывать положение <xref:System.Windows.Controls.Primitives.Popup>.  
  
> [!NOTE]
>  <xref:System.Windows.Controls.ToolTip> И <xref:System.Windows.Controls.ContextMenu> классы также определяют эти пять свойств и ведут себя точно так же.  

<a name="Positioning"></a>   
## <a name="positioning-the-popup"></a>Размещение всплывающего окна  
 Размещение <xref:System.Windows.Controls.Primitives.Popup> может быть относительно <xref:System.Windows.UIElement> или на весь экран.  В следующем примере создается четыре <xref:System.Windows.Controls.Primitives.Popup> элементов управления, относящихся к <xref:System.Windows.UIElement>— в данном случае это изображение. Все <xref:System.Windows.Controls.Primitives.Popup> элементы управления имеют <xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> свойство значение `image1`, но каждый <xref:System.Windows.Controls.Primitives.Popup> имеет другое значение свойства размещения.  
  
 [!code-xaml[PopupPositionSnippet#3](~/samples/snippets/csharp/VS_Snippets_Wpf/PopupPositionSnippet/CS/Window1.xaml#3)]  
  
 На следующем рисунке показано изображение и <xref:System.Windows.Controls.Primitives.Popup> элементов управления  
  
 ![Изображение с четырьмя элементами управления всплывающих окон](./media/popup-placement-behavior/popup-placement-intro.png "изображение с четырьмя всплывающими окнами")    
  
 В этом простом примере показано, как задать <xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> и <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> свойства, но с помощью <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A>, <xref:System.Windows.Controls.Primitives.Popup.HorizontalOffset%2A>, и <xref:System.Windows.Controls.Primitives.Popup.VerticalOffset%2A> свойства, у вас есть еще большего контроля над where <xref:System.Windows.Controls.Primitives.Popup> находится.  
  
<a name="Definitions"></a>   
## <a name="definitions-of-terms-the-anatomy-of-a-popup"></a>Определения терминов: Анатомия всплывающего окна  
 Следующие термины полезны в понимании того как <xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A>, <xref:System.Windows.Controls.Primitives.Popup.Placement%2A>, <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A>, <xref:System.Windows.Controls.Primitives.Popup.HorizontalOffset%2A>, и <xref:System.Windows.Controls.Primitives.Popup.VerticalOffset%2A> свойства связаны друг с другом и <xref:System.Windows.Controls.Primitives.Popup>:  
  
-   Целевой объект  
  
-   Целевая область  
  
-   Исходная точка  
  
-   Точка выравнивания всплывающего окна  
  
 Эти термины предоставляют удобный способ для ссылки на различные аспекты <xref:System.Windows.Controls.Primitives.Popup> элементов управления, связанного с ним.  
  
### <a name="target-object"></a>Целевой объект  
 *Целевой объект* является элементом, <xref:System.Windows.Controls.Primitives.Popup> связан. Если <xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> свойство задано, оно указывает целевой объект.  Если <xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> не задано и <xref:System.Windows.Controls.Primitives.Popup> имеет родительский элемент, родительский объект — целевой объект.  Если не <xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> значение и отсутствует родитель отсутствует целевой объект и <xref:System.Windows.Controls.Primitives.Popup> располагается относительно экрана.  
  
 В следующем примере создается <xref:System.Windows.Controls.Primitives.Popup> то есть дочерний <xref:System.Windows.Controls.Canvas>.  В примере задается <xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> свойство <xref:System.Windows.Controls.Primitives.Popup>. Значение по умолчанию для <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> — <xref:System.Windows.Controls.Primitives.PlacementMode.Bottom?displayProperty=nameWithType>, поэтому <xref:System.Windows.Controls.Primitives.Popup> отображается под <xref:System.Windows.Controls.Canvas>.  
  
 [!code-xaml[PopupPositionSnippet#1](~/samples/snippets/csharp/VS_Snippets_Wpf/PopupPositionSnippet/CS/Window1.xaml#1)]  
  
 На следующем рисунке показано, что <xref:System.Windows.Controls.Primitives.Popup> расположено относительно <xref:System.Windows.Controls.Canvas>.  
  
 ![Элемент управления Popup без PlacementTarget](./media/popup-placement-behavior/popup-placement-no-placement-target.png "всплывающее окно без PlacementTarget.")  

 В следующем примере создается <xref:System.Windows.Controls.Primitives.Popup> то есть дочерний <xref:System.Windows.Controls.Canvas>, но на этот раз <xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> присваивается `ellipse1`, поэтому появится всплывающее окно под <xref:System.Windows.Shapes.Ellipse>.  
  
 [!code-xaml[PopupPositionSnippet#2](~/samples/snippets/csharp/VS_Snippets_Wpf/PopupPositionSnippet/CS/Window1.xaml#2)]  
  
 На следующем рисунке показано, что <xref:System.Windows.Controls.Primitives.Popup> расположено относительно <xref:System.Windows.Shapes.Ellipse>.  
  
 ![Размещение всплывающего окна относительно эллипса](./media/popup-placement-behavior/popup-placement-with-placement-target.png "всплывающее окно с PlacementTarget")    
  
> [!NOTE]
>  Для <xref:System.Windows.Controls.ToolTip>, значение по умолчанию <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> является <xref:System.Windows.Controls.Primitives.PlacementMode.Mouse>.  Для <xref:System.Windows.Controls.ContextMenu>, значение по умолчанию <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> является <xref:System.Windows.Controls.Primitives.PlacementMode.MousePoint>. Эти значения описаны дальше, в разделе "Совместная работа свойств".  
  
### <a name="target-area"></a>Целевая область  
 *Целевая область* — это область на экране, <xref:System.Windows.Controls.Primitives.Popup> определяется относительно. В предыдущих примерах <xref:System.Windows.Controls.Primitives.Popup> выравнивается в пределах границ целевого объекта, но в некоторых случаях <xref:System.Windows.Controls.Primitives.Popup> выравнивается по другим границам, даже если <xref:System.Windows.Controls.Primitives.Popup> есть целевой объект.  Если <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> свойству, целевая область отличается от границ целевого объекта.  
  
 В следующем примере создается два <xref:System.Windows.Controls.Canvas> объектов, каждый из которых содержит <xref:System.Windows.Shapes.Rectangle> и <xref:System.Windows.Controls.Primitives.Popup>.  В обоих случаях целевым объектом для <xref:System.Windows.Controls.Primitives.Popup> является <xref:System.Windows.Controls.Canvas>. <xref:System.Windows.Controls.Primitives.Popup> В первом <xref:System.Windows.Controls.Canvas> имеет <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> задано с помощью его <xref:System.Windows.Rect.X%2A>, <xref:System.Windows.Rect.Y%2A>, <xref:System.Windows.Rect.Width%2A>, и <xref:System.Windows.Rect.Height%2A> свойства, значение 50, 50, 50 и 100 соответственно. <xref:System.Windows.Controls.Primitives.Popup> Во втором <xref:System.Windows.Controls.Canvas> имеет <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> значение.  Таким образом первый <xref:System.Windows.Controls.Primitives.Popup> находится ниже <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> , а второй <xref:System.Windows.Controls.Primitives.Popup> находится ниже <xref:System.Windows.Controls.Canvas>. Каждый <xref:System.Windows.Controls.Canvas> также содержит <xref:System.Windows.Shapes.Rectangle> , имеет те же границы как <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> для первого <xref:System.Windows.Controls.Primitives.Popup>.  Обратите внимание, что <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> не создает видимого элемента в приложении; в примере создается <xref:System.Windows.Shapes.Rectangle> для представления <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A>.  
  
 [!code-xaml[PopupPositionSnippet#4](~/samples/snippets/csharp/VS_Snippets_Wpf/PopupPositionSnippet/CS/Window1.xaml#4)]  
  
 На следующем рисунке показан результат примера, приведенного выше.  
  
 ![Всплывающее окно с PlacementRectangle и без](./media/popup-placement-behavior/popup-placement-placement-rectangle.png "контекстного меню с PlacementRectangle и без него.")  

### <a name="target-origin-and-popup-alignment-point"></a>Исходная точка и точка выравнивания всплывающего окна  
 *Исходная точка* и *точка выравнивания всплывающего окна* являются опорными точками на целевой области и всплывающем окне соответственно, которые используются для позиционирования. Можно использовать <xref:System.Windows.Controls.Primitives.Popup.HorizontalOffset%2A> и <xref:System.Windows.Controls.Primitives.Popup.VerticalOffset%2A> свойства для смещения всплывающего окна из целевой области.  <xref:System.Windows.Controls.Primitives.Popup.HorizontalOffset%2A> И <xref:System.Windows.Controls.Primitives.Popup.VerticalOffset%2A> относительны началом координат целевого объекта и точкой выравнивания всплывающего окна. Значение <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> свойство определяет, где находятся точка выравнивания всплывающего окна целевой объект.  
  
 В следующем примере создается <xref:System.Windows.Controls.Primitives.Popup> и задает <xref:System.Windows.Controls.Primitives.Popup.HorizontalOffset%2A> и <xref:System.Windows.Controls.Primitives.Popup.VerticalOffset%2A> свойства до 20.  <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> Свойству <xref:System.Windows.Controls.Primitives.PlacementMode.Bottom> (по умолчанию), поэтому исходная точка расположена в левом нижнем углу целевой области, и точка выравнивания всплывающего окна находится в левом верхнем углу <xref:System.Windows.Controls.Primitives.Popup>.  
  
 [!code-xaml[PopupPositionSnippet#5](~/samples/snippets/csharp/VS_Snippets_Wpf/PopupPositionSnippet/CS/Window1.xaml#5)]  
  
 На следующем рисунке показан результат примера, приведенного выше.  
  
 ![Размещение всплывающего окна в точке выравнивания начала цели](./media/popup-placement-behavior/popup-placement-target-origin-alignment-point.png "всплывающее окно с HorizontalOffset и VerticalOffset.")    
  
<a name="How"></a>   
## <a name="how-the-properties-work-together"></a>Совместная работа свойств  
 Значения <xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A>, <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A>, и <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> следует учитывать друг с другом, чтобы выяснить, правильную целевую область, исходная точка и точка выравнивания всплывающего окна.  Например если значение <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> — <xref:System.Windows.Controls.Primitives.PlacementMode.Mouse>, отсутствует целевой объект <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> игнорируется, и целевая область находится в границах указателя мыши. С другой стороны Если <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> — <xref:System.Windows.Controls.Primitives.PlacementMode.Bottom>, <xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> или родительский элемент определяет целевой объект и <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> определяет целевую область.  
  
 В следующей таблице описаны целевой объект, целевая область, исходная точка и точка выравнивания всплывающего окна и указывает ли <xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> и <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> используются для каждого <xref:System.Windows.Controls.Primitives.PlacementMode> значение перечисления.  
  
|PlacementMode|Целевой объект|Целевая область|Исходная точка|Точка выравнивания всплывающего окна|  
|-------------------|-------------------|-----------------|-------------------|---------------------------|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.Absolute>|Неприменимо. <xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> учитывается.|Экран или <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> если он задан.  <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> Расположен относительно экрана.|Левый верхний угол целевой области.|В левом верхнем углу <xref:System.Windows.Controls.Primitives.Popup>.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.AbsolutePoint>|Неприменимо. <xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> учитывается.|Экран или <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> если он задан.  <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> Расположен относительно экрана.|Левый верхний угол целевой области.|В левом верхнем углу <xref:System.Windows.Controls.Primitives.Popup>.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.Bottom>|<xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> или родительский элемент.|Целевой объект, или <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> если он задан.  <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> Относительно целевого объекта.|Левый нижний угол целевой области.|В левом верхнем углу <xref:System.Windows.Controls.Primitives.Popup>.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.Center>|<xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> или родительский элемент.|Целевой объект, или <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> если он задан.  <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> Относительно целевого объекта.|Центр целевой области.|Центр <xref:System.Windows.Controls.Primitives.Popup>.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.Custom>|<xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> или родительский элемент.|Целевой объект, или <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> если он задан.  <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> Относительно целевого объекта.|Определяется <xref:System.Windows.Controls.Primitives.CustomPopupPlacementCallback>.|Определяется <xref:System.Windows.Controls.Primitives.CustomPopupPlacementCallback>.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.Left>|<xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> или родительский элемент.|Целевой объект, или <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> если он задан.  <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> Относительно целевого объекта.|Левый верхний угол целевой области.|В правом верхнем углу <xref:System.Windows.Controls.Primitives.Popup>.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.Mouse>|Неприменимо. <xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> учитывается.|Границы указателя мыши. <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> учитывается.|Левый нижний угол целевой области.|В левом верхнем углу <xref:System.Windows.Controls.Primitives.Popup>.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.MousePoint>|Неприменимо. <xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> учитывается.|Границы указателя мыши. <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> учитывается.|Левый верхний угол целевой области.|В левом верхнем углу <xref:System.Windows.Controls.Primitives.Popup>.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.Relative>|<xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> или родительский элемент.|Целевой объект, или <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> если он задан.  <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> Относительно целевого объекта.|Левый верхний угол целевой области.|В левом верхнем углу <xref:System.Windows.Controls.Primitives.Popup>.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.RelativePoint>|<xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> или родительский элемент.|Целевой объект, или <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> если он задан.  <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> Относительно целевого объекта.|Левый верхний угол целевой области.|В левом верхнем углу <xref:System.Windows.Controls.Primitives.Popup>.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.Right>|<xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> или родительский элемент.|Целевой объект, или <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> если он задан.  <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> Относительно целевого объекта.|Правый верхний угол целевой области.|В левом верхнем углу <xref:System.Windows.Controls.Primitives.Popup>.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.Top>|<xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> или родительский элемент.|Целевой объект, или <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> если он задан.  <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A> Относительно целевого объекта.|Левый верхний угол целевой области.|В нижнем левом углу <xref:System.Windows.Controls.Primitives.Popup>.|  
  
 На следующих рисунках <xref:System.Windows.Controls.Primitives.Popup>, целевая область, исходная точка и выравнивания всплывающего окна точки для каждого <xref:System.Windows.Controls.Primitives.PlacementMode> значение. На каждом рисунке целевая область закрашена желтым, а <xref:System.Windows.Controls.Primitives.Popup> — синий.  
  
 ![Всплывающее окно с абсолютным или AbsolutePoint размещением](./media/popup-placement-behavior/popup-placement-absolute.png "размещение по абсолютным или AbsolutePoint.")    
  
 ![Всплывающее окно с нижним размещением](./media/popup-placement-behavior/popup-placement-bottom.png "размещение по нижнему краю.")   
  
 ![Всплывающее окно с размещением по центру](./media/popup-placement-behavior/popup-placement-center.png "размещения — центр.")    
  
 ![Всплывающее окно с левым размещением](./media/popup-placement-behavior/popup-placement-left.png "размещение по левому краю.")   
  
 ![Всплывающее окно с размещением относительны мыши](./media/popup-placement-behavior/popup-placement-mouse.png "размещение по мыши.")  
  
 ![Всплывающее окно с размещением MousePoint](./media/popup-placement-behavior/popup-placement-mousepoint.png "размещение относительно MousePoint.")  
  
 ![Всплывающее окно с относительным или RelativePoint размещением](./media/popup-placement-behavior/popup-placement-relative.png "размещения является относительным или RelativePoint.")    
  
 ![Всплывающее окно с правым размещением](./media/popup-placement-behavior/popup-placement-right.png "размещение по правому краю.")    
  
 ![Всплывающее окно с верхним размещением](./media/popup-placement-behavior/popup-placement-top.png "размещение по верхнему краю.")    
  
<a name="When"></a>   
## <a name="when-the-popup-encounters-the-edge-of-the-screen"></a>Когда всплывающее окно достигает края экрана  
 По соображениям безопасности <xref:System.Windows.Controls.Primitives.Popup> не могут быть скрыты за краем экрана. Одно из следующих трех действий происходит при <xref:System.Windows.Controls.Primitives.Popup> края экрана:  
  
-   Всплывающее окно располагается вдоль края экрана, который мог бы скрыть <xref:System.Windows.Controls.Primitives.Popup>.  
  
-   Всплывающее окно использует другую точку выравнивания.  
  
-   Всплывающее окно использует другую исходную точку и точку выравнивания.  
  
 Эти параметры будут описаны далее в данном разделе.  
  
 Поведение <xref:System.Windows.Controls.Primitives.Popup> при обнаружении края экрана зависит от значения <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> свойства, а какие граница, всплывающее окно достигают экрана. В следующей таблице представлены поведения при <xref:System.Windows.Controls.Primitives.Popup> края экрана для каждого <xref:System.Windows.Controls.Primitives.PlacementMode> значение.  
  
|PlacementMode|Верхний край|Нижний край|Левый край|Правый край|  
|-------------------|--------------|-----------------|---------------|----------------|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.Absolute>|Выравнивание по верхнему краю.|Выравнивание по нижнему краю.|Выравнивание по левому краю.|Выравнивание по правому краю.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.AbsolutePoint>|Выравнивание по верхнему краю.|Точка выравнивания всплывающего окна изменяется на нижний левый угол элемента <xref:System.Windows.Controls.Primitives.Popup>.|Выравнивание по левому краю.|Точка выравнивания всплывающего окна изменяется на верхний правый угол элемента <xref:System.Windows.Controls.Primitives.Popup>.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.Bottom>|Выравнивание по верхнему краю.|Началом координат целевого объекта изменяется в левый верхний угол целевой области, а точка выравнивания всплывающего окна изменяется в нижний левый угол <xref:System.Windows.Controls.Primitives.Popup>.|Выравнивание по левому краю.|Выравнивание по правому краю.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.Center>|Выравнивание по верхнему краю.|Выравнивание по нижнему краю.|Выравнивание по левому краю.|Выравнивание по правому краю.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.Left>|Выравнивание по верхнему краю.|Выравнивание по нижнему краю.|Исходная точка изменяется на верхний правый угол целевой области и точкой выравнивания всплывающего окна изменяется в верхний левый угол <xref:System.Windows.Controls.Primitives.Popup>.|Выравнивание по правому краю.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.Mouse>|Выравнивание по верхнему краю.|Началом координат целевого объекта изменяется в левый верхний угол целевой области (границы указателя мыши), а точка выравнивания всплывающего окна изменяется в нижний левый угол <xref:System.Windows.Controls.Primitives.Popup>.|Выравнивание по левому краю.|Выравнивание по правому краю.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.MousePoint>|Выравнивание по верхнему краю.|Точка выравнивания всплывающего окна изменяется на нижний левый угол элемента <xref:System.Windows.Controls.Primitives.Popup>.|Выравнивание по левому краю.|Точка выравнивания всплывающего окна переходит в верхний правый угол всплывающего окна.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.Relative>|Выравнивание по верхнему краю.|Выравнивание по нижнему краю.|Выравнивание по левому краю.|Выравнивание по правому краю.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.RelativePoint>|Выравнивание по верхнему краю.|Точка выравнивания всплывающего окна изменяется на нижний левый угол элемента <xref:System.Windows.Controls.Primitives.Popup>.|Выравнивание по левому краю.|Точка выравнивания всплывающего окна переходит в верхний правый угол всплывающего окна.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.Right>|Выравнивание по верхнему краю.|Выравнивание по нижнему краю.|Выравнивание по левому краю.|Началом координат целевого объекта изменяется в левый верхний угол целевой области, а точка выравнивания всплывающего окна изменяется в верхний правый угол <xref:System.Windows.Controls.Primitives.Popup>.|  
|<xref:System.Windows.Controls.Primitives.PlacementMode.Top>|Началом координат целевого объекта изменяется в левый нижний угол целевой области, а точка выравнивания всплывающего окна изменяется в верхний левый угол <xref:System.Windows.Controls.Primitives.Popup>. По сути, это то же самое, как и при <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> является <xref:System.Windows.Controls.Primitives.PlacementMode.Bottom>.|Выравнивание по нижнему краю.|Выравнивание по левому краю.|Выравнивание по правому краю.|  
  
### <a name="aligning-to-the-screen-edge"></a>Выравнивание по краю экрана  
 Объект <xref:System.Windows.Controls.Primitives.Popup> может выровняться по краю экрана путем изменения расположения, так что всего <xref:System.Windows.Controls.Primitives.Popup> отображается на экране.  В этом случае расстояние между точкой выравнивания всплывающего окна, целевой объект может отличаться от значения <xref:System.Windows.Controls.Primitives.Popup.HorizontalOffset%2A> и <xref:System.Windows.Controls.Primitives.Popup.VerticalOffset%2A>. Когда <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> — <xref:System.Windows.Controls.Primitives.PlacementMode.Absolute>, <xref:System.Windows.Controls.Primitives.PlacementMode.Center>, или <xref:System.Windows.Controls.Primitives.PlacementMode.Relative>, <xref:System.Windows.Controls.Primitives.Popup> выравнивается по каждому краю экрана.  Например, предположим, что <xref:System.Windows.Controls.Primitives.Popup> имеет <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> присвоено <xref:System.Windows.Controls.Primitives.PlacementMode.Relative> и <xref:System.Windows.Controls.Primitives.Popup.VerticalOffset%2A> равным 100.  Если нижний край экрана скрывает полностью или частично <xref:System.Windows.Controls.Primitives.Popup>, <xref:System.Windows.Controls.Primitives.Popup> выравнивается вдоль нижнего края экрана и расстояние по вертикали между началом координат целевого объекта и всплывающее окно точка выравнивания находится меньше 100. Эта ситуация представлена на рисунке ниже.  
  
 ![Всплывающее окно, выравниваемое по краю экрана](./media/popup-placement-behavior/popup-placement-relative-screen-edge.png "всплывающее окно выравнивается по границе экрана.")    
  
### <a name="changing-the-popup-alignment-point"></a>Изменение точки выравнивания всплывающего окна  
 Если <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> — <xref:System.Windows.Controls.Primitives.PlacementMode.AbsolutePoint>, <xref:System.Windows.Controls.Primitives.PlacementMode.RelativePoint>, или <xref:System.Windows.Controls.Primitives.PlacementMode.MousePoint>, точка выравнивания всплывающего окна изменяется, когда всплывающее окно достигают нижнего или правого края экрана.  
  
 На следующем рисунке показано, что если нижний край экрана скрывает полностью или частично <xref:System.Windows.Controls.Primitives.Popup>, точка выравнивания всплывающего окна находится в нижнем левом углу <xref:System.Windows.Controls.Primitives.Popup>.  
  
 ![Новая точка выравнивания относительно нижнего края экрана](./media/popup-placement-behavior/popup-placement-relative-point-screen-edge.png "всплывающее окно достигает нижнего края экрана и меняет положение точки выравнивания.")  

 На следующем рисунке показано, что при <xref:System.Windows.Controls.Primitives.Popup> скрыт с правого края экрана, точка выравнивания всплывающего окна находится в правом верхнем углу <xref:System.Windows.Controls.Primitives.Popup>.  
  
 ![Новая точка выравнивания всплывающего окна края экрана](./media/popup-placement-behavior/popup-placement-relative-point-right-screen-edge.png "всплывающее окно достигает правого края экрана и меняет положение точки выравнивания.")    
  
 Если <xref:System.Windows.Controls.Primitives.Popup> достигает нижнего и правого краев экрана, точка выравнивания всплывающего окна находится в правом верхнем углу <xref:System.Windows.Controls.Primitives.Popup>.  
  
### <a name="changing-the-target-origin-and-popup-alignment-point"></a>Изменение положения исходной точки и точки выравнивания всплывающего окна  
 Когда <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> — <xref:System.Windows.Controls.Primitives.PlacementMode.Bottom>, <xref:System.Windows.Controls.Primitives.PlacementMode.Left>, <xref:System.Windows.Controls.Primitives.PlacementMode.Mouse>, <xref:System.Windows.Controls.Primitives.PlacementMode.Right>, или <xref:System.Windows.Controls.Primitives.PlacementMode.Top>, выравнивания всплывающего окна целевой точки изменений при обнаружении края экрана.  Зависит от края экрана, который вызывает изменение положения <xref:System.Windows.Controls.Primitives.PlacementMode> значение.  
  
 На следующем рисунке показано, что при <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> — <xref:System.Windows.Controls.Primitives.PlacementMode.Bottom> и <xref:System.Windows.Controls.Primitives.Popup> достигает нижнего края экрана, исходная точка расположена в левом верхнем углу целевой области, и точка выравнивания всплывающего окна находится в нижнем левом углу <xref:System.Windows.Controls.Primitives.Popup>.  
  
 ![Новая точка выравнивания относительно нижнего края экрана](./media/popup-placement-behavior/popup-placement-bottom-screen-edge.png "размещение по нижнему краю и всплывающее окно достигают нижнего края экрана.")    
  
 На следующем рисунке показано, что при <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> — <xref:System.Windows.Controls.Primitives.PlacementMode.Left> и <xref:System.Windows.Controls.Primitives.Popup> встречает левый край экрана, исходная точка расположена в правом верхнем углу целевой области, и точка выравнивания всплывающего окна находится в левом верхнем углу <xref:System.Windows.Controls.Primitives.Popup>.  
  
 ![Новая точка выравнивания относительно левого края экрана](./media/popup-placement-behavior/popup-placement-left-screen-edge.png "размещение по левому краю и всплывающее окно достигают левого края экрана.")  
  
 На следующем рисунке показано, что при <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> — <xref:System.Windows.Controls.Primitives.PlacementMode.Right> и <xref:System.Windows.Controls.Primitives.Popup> встречает правый край экрана, исходная точка расположена в левом верхнем углу целевой области, и точка выравнивания всплывающего окна находится в правом верхнем углу <xref:System.Windows.Controls.Primitives.Popup>.  
  
 ![Новая точка выравнивания относительно правого края экрана](./media/popup-placement-behavior/popup-placement-right-screen-edge.png "размещение по правому краю и всплывающее окно достигают правого края экрана.")  

 На следующем рисунке показано, что при <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> — <xref:System.Windows.Controls.Primitives.PlacementMode.Top> и <xref:System.Windows.Controls.Primitives.Popup> встречает верхний край экрана, исходная точка расположена в левом нижнем углу целевой области, и точка выравнивания всплывающего окна находится в левом верхнем углу <xref:System.Windows.Controls.Primitives.Popup>.  
  
 ![Новая точка выравнивания относительно верхнего края экрана](./media/popup-placement-behavior/popup-placement-top-screen-edge.png "размещение по верхнему краю и всплывающее окно достигают верхнего края экрана.")  
  
 На следующем рисунке показано, что при <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> — <xref:System.Windows.Controls.Primitives.PlacementMode.Mouse> и <xref:System.Windows.Controls.Primitives.Popup> достигает нижнего края экрана, исходная точка расположена в левом верхнем углу целевой области (границы указателя мыши), а также выравнивания всплывающего окна точка находится в нижнем левом углу <xref:System.Windows.Controls.Primitives.Popup>.  
  
 ![Новая точка выравнивания относительно мыши возле края экрана](./media/popup-placement-behavior/popup-placement-mouse-screen-edge.png "размещение относительно мыши и всплывающее окно достигают нижнего края экрана.")    
  
### <a name="customizing-popup-placement"></a>Настройка размещения контекстного меню  
 Точка выравнивания всплывающего окна целевой можно настроить, задав <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> свойства <xref:System.Windows.Controls.Primitives.PlacementMode.Custom>. Затем определите <xref:System.Windows.Controls.Primitives.CustomPopupPlacementCallback> делегат, который возвращает набор возможных точек размещения и основные оси (в порядке предпочтения) для <xref:System.Windows.Controls.Primitives.Popup>. Точка, в которой отображается наибольшую часть <xref:System.Windows.Controls.Primitives.Popup> выбран.  Положение <xref:System.Windows.Controls.Primitives.Popup> изменяется автоматически в том случае, если <xref:System.Windows.Controls.Primitives.Popup> скрыто за краем экрана. См. пример в разделе [Указание пользовательского расположения контекстного меню](how-to-specify-a-custom-popup-position.md).  
  
## <a name="see-also"></a>См. также

- [Пример размещения всплывающего окна](https://github.com/dotnet/samples/tree/master/snippets/csharp/VS_Snippets_Wpf/PopupPositionSnippet/CS)

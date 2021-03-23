---
title: Общие сведения о панелях
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- Panel control [WPF], about Panel control
- controls [WPF], Panel
ms.assetid: f73644af-9941-4611-8754-6d4cef03fc44
ms.openlocfilehash: 946e0f5ee90235498b8089732ae526ab6f35665c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59157876"
---
# <a name="panels-overview"></a>Общие сведения о панелях
<xref:System.Windows.Controls.Panel> элементы являются компонентами, которые управляют отображением элементов — их размер и измерения, их положение и расположение их дочернего содержимого. [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] Предоставляет ряд предопределенных <xref:System.Windows.Controls.Panel> элементы, а также возможность создания пользовательских <xref:System.Windows.Controls.Panel> элементов.  
  
 В этом разделе содержатся следующие подразделы.  
  
-   [Класс Panel](#Panels_view_from_10000_feet)  
  
-   [Общие члены элементов Panel](#Panels_declared_members)  
  
-   [Производные элементы Panel](#Panels_derived_elements)  
  
-   [Панели пользовательского интерфейса](#Panels_main_UI_elements)  
  
-   [Вложенные элементы Panel](#Panels_nested_panel_elements)  
  
-   [Пользовательские элементы Panel](#Panels_custom_panel_elements)  
  
-   [Поддержка локализации и глобализации](#Panels_global_localization)  
  
<a name="Panels_view_from_10000_feet"></a>   
## <a name="the-panel-class"></a>Класс Panel  
 <xref:System.Windows.Controls.Panel> является базовым классом для всех элементов, которые предоставляют макет поддерживает в [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)]. Производные <xref:System.Windows.Controls.Panel> элементы используются для размещения и упорядочения элементов в [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] и кода.  
  
 WPF включает полный набор реализаций производных панели, позволяющих использовать множество сложных макетов. Эти производные классы предоставляют свойства и методы, с помощью которых реализуется большинство стандартных сценариев [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)]. Разработчики, которые не смогли найти поведение упорядочение дочерних, удовлетворяющих их потребности могут создать новые макеты путем переопределения <xref:System.Windows.FrameworkElement.ArrangeOverride%2A> и <xref:System.Windows.FrameworkElement.MeasureOverride%2A> методы. Дополнительные сведения о поведении пользовательских макетов см. в разделе [Пользовательские элементы Panel](#Panels_custom_panel_elements).  
  
<a name="Panels_declared_members"></a>   
## <a name="panel-common-members"></a>Общие члены элементов Panel  
 Все <xref:System.Windows.Controls.Panel> элементы поддерживают базовые изменения размеров и положения свойств, определенных <xref:System.Windows.FrameworkElement>, в том числе <xref:System.Windows.FrameworkElement.Height%2A>, <xref:System.Windows.FrameworkElement.Width%2A>, <xref:System.Windows.FrameworkElement.HorizontalAlignment%2A>, <xref:System.Windows.FrameworkElement.VerticalAlignment%2A>, <xref:System.Windows.FrameworkElement.Margin%2A>, и <xref:System.Windows.FrameworkElement.LayoutTransform%2A>. Дополнительные сведения о свойствах, которые определяются изменения положения <xref:System.Windows.FrameworkElement>, см. в разделе [выравнивание, Margins и Padding Обзор](../advanced/alignment-margins-and-padding-overview.md).  
  
 <xref:System.Windows.Controls.Panel> предоставляет дополнительные свойства, которые очень важны в понимании и использовании макета. <xref:System.Windows.Controls.Panel.Background%2A> Свойство используется для заполнения области между границами производного элемента панели с <xref:System.Windows.Media.Brush>. <xref:System.Windows.Controls.Panel.Children%2A> Представляет коллекцию дочерних элементов, <xref:System.Windows.Controls.Panel> включает в себя. <xref:System.Windows.Controls.Panel.InternalChildren%2A> представляет содержимое <xref:System.Windows.Controls.Panel.Children%2A> коллекции, а также элементы, созданные привязкой данных. Оба свойства состоят <xref:System.Windows.Controls.UIElementCollection> дочерних элементов, размещенных в родительском элементе <xref:System.Windows.Controls.Panel>.  
  
 Панель также предоставляет <xref:System.Windows.Controls.Panel.ZIndex%2A?displayProperty=nameWithType> присоединенного свойства, который может использоваться для получения многослойного в производном <xref:System.Windows.Controls.Panel>. Элементы панели <xref:System.Windows.Controls.Panel.Children%2A> коллекции с более высоким <xref:System.Windows.Controls.Panel.ZIndex%2A?displayProperty=nameWithType> значение отображаются перед элементами с более низким <xref:System.Windows.Controls.Panel.ZIndex%2A?displayProperty=nameWithType> значение. Это особенно полезно для панелей такие как <xref:System.Windows.Controls.Canvas> и <xref:System.Windows.Controls.Grid> что позволяет дочерним элементам совместно использовать одну систему координат.  
  
 <xref:System.Windows.Controls.Panel> также определяет <xref:System.Windows.Controls.Panel.OnRender%2A> метод, который может использоваться для переопределения поведения представления по умолчанию <xref:System.Windows.Controls.Panel>.  
  
#### <a name="attached-properties"></a>Вложенные свойства  
 Производные элементы панели широко используют вложенные свойства. Вложенное свойство представляет собой особую форму свойства зависимости, не имеющего обычной "оболочки" свойства [!INCLUDE[TLA#tla_clr](../../../../includes/tlasharptla-clr-md.md)]. Вложенные свойства имеют специальный синтаксис в языке [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)], с которым можно познакомиться в некоторых из следующих примеров.  
  
 Одной из целей вложенного свойства является предоставление возможности дочерним элементам хранить уникальные значения свойства, фактически определенные в родительском элементе. Случаем применения данной возможности является уведомление родительского элемента со стороны дочерних элементов о способе их представления в [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)], что очень полезно при создании макета приложения. Дополнительные сведения см. в разделе [Общие сведения о вложенных свойствах](../advanced/attached-properties-overview.md).  
  
<a name="Panels_derived_elements"></a>   
## <a name="derived-panel-elements"></a>Производные элементы Panel  
 Многие объекты являются производными от <xref:System.Windows.Controls.Panel>, но не все из них предназначены для использования в качестве поставщиков корневого макета. Существует шесть определенных классов панелей (<xref:System.Windows.Controls.Canvas>, <xref:System.Windows.Controls.DockPanel>, <xref:System.Windows.Controls.Grid>, <xref:System.Windows.Controls.StackPanel>, <xref:System.Windows.Controls.VirtualizingStackPanel>, и <xref:System.Windows.Controls.WrapPanel>), предназначенных специально для создания приложений [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)].  
  
 Каждый элемент панели имеет собственные специальные возможности, представленные в следующей таблице.  
  
|Имя элемента|Панель пользовательского интерфейса?|Описание|  
|------------------|---------------|-----------------|  
|<xref:System.Windows.Controls.Canvas>|Да|Определяет область, внутри которой можно явным образом разместить дочерние элементы с помощью координатах по отношению к <xref:System.Windows.Controls.Canvas> области.|  
|<xref:System.Windows.Controls.DockPanel>|Да|Определяет область, в которой можно горизонтально либо вертикально упорядочивать дочерние элементы относительно друг друга.|  
|<xref:System.Windows.Controls.Grid>|Да|Определяет область с таблицей переменного размера, состоящей из столбцов и строк. Дочерние элементы <xref:System.Windows.Controls.Grid> может быть настроено с помощью <xref:System.Windows.FrameworkElement.Margin%2A> свойство.|  
|<xref:System.Windows.Controls.StackPanel>|Да|Выравнивает дочерние элементы в одну линию, ориентированную горизонтально или вертикально.|  
|<xref:System.Windows.Controls.Primitives.TabPanel>|Нет|Обрабатывает макет кнопок вкладки в <xref:System.Windows.Controls.TabControl>.|  
|<xref:System.Windows.Controls.Primitives.ToolBarOverflowPanel>|Нет|Упорядочивает содержимое в <xref:System.Windows.Controls.ToolBar> элемента управления.|  
|<xref:System.Windows.Controls.Primitives.UniformGrid>|Нет|<xref:System.Windows.Controls.Primitives.UniformGrid> используется для упорядочивания дочерних элементов в сетке с ячейками одинакового размера.|  
|<xref:System.Windows.Controls.VirtualizingPanel>|Нет|Предоставляет базовый класс для панелей, которые могут "виртуализировать" дочерние коллекции.|  
|<xref:System.Windows.Controls.VirtualizingStackPanel>|Да|Упорядочивает и виртуализирует одну строку содержимого, ориентированную горизонтально или вертикально.|  
|<xref:System.Windows.Controls.WrapPanel>|Да|<xref:System.Windows.Controls.WrapPanel> Размещает дочерние элементы последовательно слева направо, перенося содержимое на следующую строку на границе содержащего поля. Дальнейшее упорядочивание происходит последовательно сверху вниз или слева направо в зависимости от значения <xref:System.Windows.Controls.WrapPanel.Orientation%2A> свойство.|  
  
<a name="Panels_main_UI_elements"></a>   
## <a name="user-interface-panels"></a>Панели пользовательского интерфейса  
 Существует шесть классов панелей, доступных в WPF , оптимизированы для поддержки [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)] сценариев: <xref:System.Windows.Controls.Canvas>, <xref:System.Windows.Controls.DockPanel>, <xref:System.Windows.Controls.Grid>, <xref:System.Windows.Controls.StackPanel>, <xref:System.Windows.Controls.VirtualizingStackPanel>, и <xref:System.Windows.Controls.WrapPanel>. Эти элементы панели являются простыми в использовании, гибкими и достаточно широкими для большинства приложений.  
  
 Каждый производный <xref:System.Windows.Controls.Panel> элемент рассматривает ограничения размеров по-разному. Основные сведения о том, как <xref:System.Windows.Controls.Panel> обрабатывает ограничения в горизонтальном или вертикальном направлении, может сделать макет более предсказуемой.  
  
|**Имя панели**|**Оси x**|**Измерение y**|  
|--------------------|----------------------|----------------------|  
|<xref:System.Windows.Controls.Canvas>|Ограничено содержимым|Ограничено содержимым|  
|<xref:System.Windows.Controls.DockPanel>|Ограничено|Ограничено|  
|<xref:System.Windows.Controls.StackPanel> (Вертикальная ориентация)|Ограничено|Ограничено содержимым|  
|<xref:System.Windows.Controls.StackPanel> (Горизонтальная ориентация)|Ограничено содержимым|Ограничено|  
|<xref:System.Windows.Controls.Grid>|Ограничено|Ограничено, кроме случаев где <xref:System.Windows.GridUnitType.Auto> применяется к строкам и столбцам|  
|<xref:System.Windows.Controls.WrapPanel>|Ограничено содержимым|Ограничено содержимым|  
  
 С более подробными описаниями и примерами использования каждого из этих элементов можно ознакомиться ниже.  
  
<a name="Panels_overview_Canvas_subsection"></a>   
### <a name="canvas"></a>Canvas  
 <xref:System.Windows.Controls.Canvas> Элемент позволяет размещать содержимое в соответствии с абсолютными *x -* и *y -* координаты. Элементы могут быть нарисованы в уникальном месте или, если элементы занимают одни координаты, порядок, в котором они отображаются в разметке, определяется порядком, в котором нарисованы эти элементы.  
  
 <xref:System.Windows.Controls.Canvas> предоставляет самую гибкую поддержку макета любого <xref:System.Windows.Controls.Panel>. Для определения области холста используются свойства высоты и ширины и элементам внутри назначаются абсолютные координаты относительно области родительского <xref:System.Windows.Controls.Canvas>. Четыре вложенных свойства, <xref:System.Windows.Controls.Canvas.Left%2A?displayProperty=nameWithType>, <xref:System.Windows.Controls.Canvas.Top%2A?displayProperty=nameWithType>, <xref:System.Windows.Controls.Canvas.Right%2A?displayProperty=nameWithType> и <xref:System.Windows.Controls.Canvas.Bottom%2A?displayProperty=nameWithType>, точное управление расположением объекта внутри <xref:System.Windows.Controls.Canvas>, позволяя разработчику для размещения и упорядочения элементов на экране.  
  
#### <a name="cliptobounds-within-a-canvas"></a>Свойство ClipToBounds в элементе Canvas  
 <xref:System.Windows.Controls.Canvas> можно расположить дочерние элементы в любом месте на экране, даже в координатах, находящихся за пределами определены собственные <xref:System.Windows.FrameworkElement.Height%2A> и <xref:System.Windows.FrameworkElement.Width%2A>. Кроме того <xref:System.Windows.Controls.Canvas> не влияет размер его дочерних элементов. Таким образом, это возможно для дочернего элемента может быть нарисован поверх других элементов за пределами ограничивающего прямоугольника родительского <xref:System.Windows.Controls.Canvas>. По умолчанию <xref:System.Windows.Controls.Canvas> является разрешение дочерним элементам отображаться за пределами границ родительского <xref:System.Windows.Controls.Canvas>. Если такое поведение нежелательно, <xref:System.Windows.UIElement.ClipToBounds%2A> можно присвоить свойство `true`. В результате <xref:System.Windows.Controls.Canvas> отсечения до собственного размера. <xref:System.Windows.Controls.Canvas> является единственным элементом макета, позволяет дочерним элементам отображаться вне границ элемента.  
  
 Такое поведение графически показано в [примере сравнения свойств ширины](https://go.microsoft.com/fwlink/?LinkID=160050).  
  
#### <a name="defining-and-using-a-canvas"></a>Определение и использование Canvas  
 Объект <xref:System.Windows.Controls.Canvas> можно легко создать с помощью [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] или кода. Следующий пример демонстрирует, как использовать <xref:System.Windows.Controls.Canvas> для размещения содержимого по абсолютным. Этот код рисует три квадрата со стороной в 100 пикселей. Первый квадрат — красный и координаты (*x, y*) его левого верхнего угла имеют значение (0, 0). Второй квадрат — зеленый, и его левый верхний угол имеет координаты (100, 100). Он находится ниже и правее первого квадрата. Третий квадрат — синий, его левый верхний угол имеет координаты (50, 50); таким образом, он пересекается с правым нижним углом первого квадрата и левым верхним углом второго. Так как третий квадрат накладывается последним, он будет отображаться поверх первых двух квадратов — то есть пересекающиеся участки принимают цвет третьей фигуры.  
  
 [!code-csharp[CanvasOvwSample#1](~/samples/snippets/csharp/VS_Snippets_Wpf/CanvasOvwSample/CSharp/Canvas_Ovw_Sample.cs#1)]
 
 [!code-xaml[CanvasOvwSample#1](~/samples/snippets/xaml/VS_Snippets_Wpf/CanvasOvwSample/XAML/default.xaml#1)]  
  
 Скомпилированное приложение возвращает новый [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)], который выглядит следующим образом.  
  
 ![Обычный элемент Canvas.](./media/panel-intro-canvas.PNG "panel_intro_canvas")  
  
<a name="Panels_overview_DockPanel_subsection"></a>   
### <a name="dockpanel"></a>DockPanel  
 <xref:System.Windows.Controls.DockPanel> Элемент использует <xref:System.Windows.Controls.DockPanel.Dock%2A?displayProperty=nameWithType> присоединенного свойства, заданные в дочерних элементах содержимого для размещения содержимого у границ контейнера. Когда <xref:System.Windows.Controls.DockPanel.Dock%2A?displayProperty=nameWithType> присваивается <xref:System.Windows.Controls.Dock.Top> или <xref:System.Windows.Controls.Dock.Bottom>, оно располагает дочерние элементы выше или ниже друг с другом. Когда <xref:System.Windows.Controls.DockPanel.Dock%2A?displayProperty=nameWithType> присваивается <xref:System.Windows.Controls.Dock.Left> или <xref:System.Windows.Controls.Dock.Right>, оно располагает дочерние элементы слева или справа от друг с другом. <xref:System.Windows.Controls.DockPanel.LastChildFill%2A> Свойство определяет положение последнего элемента, добавленного в качестве дочернего элемента <xref:System.Windows.Controls.DockPanel>.  
  
 Можно использовать <xref:System.Windows.Controls.DockPanel> для размещения группы связанных элементов управления, таких как набор кнопок. Кроме того, можно использовать его для создания разделенного на панели [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)], похожего на интерфейс [!INCLUDE[TLA#tla_outlook](../../../../includes/tlasharptla-outlook-md.md)].  
  
#### <a name="sizing-to-content"></a>Изменение размеров в зависимости от содержимого  
 Если его <xref:System.Windows.FrameworkElement.Height%2A> и <xref:System.Windows.FrameworkElement.Width%2A> свойства не указаны, <xref:System.Windows.Controls.DockPanel> размеры его содержимого. Размер может увеличиваться или уменьшаться, чтобы вместить его дочерние элементы. Тем не менее, если заданы эти свойства и больше нет свободного места для следующего указанного дочернего элемента <xref:System.Windows.Controls.DockPanel> не отображает этот дочерний элемент и последующие дочерние элементы и не измеряет последующие дочерние элементы.  
  
#### <a name="lastchildfill"></a>LastChildFill  
 По умолчанию последний дочерний узел данного <xref:System.Windows.Controls.DockPanel> элемент «заполнит» оставшееся незанятое пространство. Если такое поведение нежелательно, задайте <xref:System.Windows.Controls.DockPanel.LastChildFill%2A> свойства `false`.  
  
#### <a name="defining-and-using-a-dockpanel"></a>Определение и использование DockPanel  
 В следующем примере демонстрируется разделение пространства с помощью <xref:System.Windows.Controls.DockPanel>. Пять <xref:System.Windows.Controls.Border> элементы добавляются как дочерние элементы родительского узла <xref:System.Windows.Controls.DockPanel>. Каждый из них использует свое свойство размещения <xref:System.Windows.Controls.DockPanel> для разделения пространства. Последний элемент "заполняет" оставшееся незанятое пространство.  
  
 
 [!code-csharp[DockPanelOvwSample#1](~/samples/snippets/csharp/VS_Snippets_Wpf/DockPanelOvwSample/CSharp/DockPanel_Ovw_Sample.cs#1)]
 
 [!code-xaml[DockPanelOvwSample#1](~/samples/snippets/xaml/VS_Snippets_Wpf/DockPanelOvwSample/XAML/default.xaml#1)]  
  
 Скомпилированное приложение возвращает новый [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)], который выглядит следующим образом.  
  
 ![Обычный сценарий DockPanel.](./media/panel-intro-dockpanel.PNG "panel_intro_dockpanel")  
  
<a name="Panels_overview_Grid_subsection"></a>   
### <a name="grid"></a>Grid  
 <xref:System.Windows.Controls.Grid> Элемент объединяет возможности абсолютного позиционирования и управления табличными данными. Объект <xref:System.Windows.Controls.Grid> позволяет легко изменять положение и стиль элементов. <xref:System.Windows.Controls.Grid> позволяет определить группы столбцов и строк, гибкий и предоставляет возможность распространять информацию о размере между несколькими <xref:System.Windows.Controls.Grid> элементов.  
  
#### <a name="how-is-grid-different-from-table"></a>Чем Grid отличается от Table?  
 <xref:System.Windows.Documents.Table> и <xref:System.Windows.Controls.Grid> совместно использовать некоторые общие функциональные возможности, но каждый из них лучше всего подходит для различных сценариев. Объект <xref:System.Windows.Documents.Table> предназначен для использования в потоковом содержимом (см. в разделе [Общие](../advanced/flow-document-overview.md) Дополнительные сведения о потоковом содержимом). Сетки лучше всего использовать внутри форм (по сути в любом месте вне потокового содержимого). В рамках <xref:System.Windows.Documents.FlowDocument>, <xref:System.Windows.Documents.Table> поддерживает поток такие возможности, как разбиение на страницы, Перекомпоновка столбцов и Выбор содержимого при <xref:System.Windows.Controls.Grid> — нет. Объект <xref:System.Windows.Controls.Grid> с другой стороны лучше всего использовать за пределами <xref:System.Windows.Documents.FlowDocument> по многим причинам, в том числе <xref:System.Windows.Controls.Grid> добавляет элементы на основе индекса строк и столбцов, <xref:System.Windows.Documents.Table> — нет. <xref:System.Windows.Controls.Grid> Элемент позволяет создавать слои дочернего содержимого, позволяя более чем одного элемента существовать внутри одной «ячейки». <xref:System.Windows.Documents.Table> не поддерживает слои. Дочерние элементы <xref:System.Windows.Controls.Grid> можно абсолютно позиционировать относительно области границ их «ячейки». <xref:System.Windows.Documents.Table> не поддерживает эту функцию. Наконец <xref:System.Windows.Controls.Grid> легче, чем <xref:System.Windows.Documents.Table>.  
  
#### <a name="sizing-behavior-of-columns-and-rows"></a>Поведение столбцов и строк при изменении их размера  
 Столбцы и строки, определенные в <xref:System.Windows.Controls.Grid> можно воспользоваться преимуществами <xref:System.Windows.GridUnitType.Star> изменения размера, чтобы пропорционально распределить оставшееся пространство. Когда <xref:System.Windows.GridUnitType.Star> выбран в качестве высоты или ширины строки или столбца, что столбец или строка получает пропорциональную часть оставшегося доступного пространства. Это отличается от <xref:System.Windows.GridUnitType.Auto>, который распределяет пространство равномерно с учетом размера содержимого столбца или строки. Это значение выражается как `*` или `2*` при использовании языка [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)]. В первом случае строка или столбец будет получать определенное доступное пространство, а во втором случае — в два раза больше. При объединении этой методики для пропорционального распределения пространства с <xref:System.Windows.FrameworkElement.HorizontalAlignment%2A> и <xref:System.Windows.FrameworkElement.VerticalAlignment%2A> значение `Stretch` имеется возможность разделения пространства макета в процентах от пространства экрана. <xref:System.Windows.Controls.Grid> является единственной панелью макета, может распределять пространство таким образом.  
  
#### <a name="defining-and-using-a-grid"></a>Определение и использование Grid  
 В следующем примере демонстрируется построение [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)] аналогичного используемому в диалоговом окне Run, доступном в меню "Пуск" [!INCLUDE[TLA#tla_mswin](../../../../includes/tlasharptla-mswin-md.md)].  
  
 [!code-csharp[GridRunDialog#1](~/samples/snippets/csharp/VS_Snippets_Wpf/GridRunDialog/CSharp/window1.xaml.cs#1)]
   
  
 Скомпилированное приложение возвращает новый [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)], который выглядит следующим образом.  
  
 ![Обычный элемент сетки.](./media/avalon-run-dialog.PNG "avalon_run_dialog")  
  
<a name="Panels_overview_StackPanel_subsection"></a>   
### <a name="stackpanel"></a>StackPanel  
 Объект <xref:System.Windows.Controls.StackPanel> позволяет «выстраивать» элементы в определенном направлении. По умолчанию направление стека является вертикальным. <xref:System.Windows.Controls.StackPanel.Orientation%2A> Свойство может использоваться для управления потоком содержимого.  
  
#### <a name="stackpanel-vs-dockpanel"></a>Сравнение StackPanel и DockPanel  
 Несмотря на то что <xref:System.Windows.Controls.DockPanel> можно также «стопку» дочерних элементов, <xref:System.Windows.Controls.DockPanel> и <xref:System.Windows.Controls.StackPanel> не дают аналогичных результатов в некоторых случаях использования. Например, порядок дочерних элементов может повлиять на их размер в <xref:System.Windows.Controls.DockPanel> , но не в <xref:System.Windows.Controls.StackPanel>. Это обусловлено <xref:System.Windows.Controls.StackPanel> направлении стека в <xref:System.Double.PositiveInfinity>, тогда как <xref:System.Windows.Controls.DockPanel> измеряет только доступный размер.  
  
 Следующий пример демонстрирует это ключевое различие.  
  
 
 [!code-csharp[StackPanelOvw4#1](~/samples/snippets/csharp/VS_Snippets_Wpf/StackPanelOvw4/CSharp/StackPanel_Ovw_Sample4.cs#1)]
 
 [!code-xaml[StackPanelOvw4#1](~/samples/snippets/xaml/VS_Snippets_Wpf/StackPanelOvw4/XAML/default.xaml#1)]  
  
 На этом рисунке видна разница в поведении отрисовки.  
  
 ![Снимок экрана: Сравнение StackPanel и снимок экрана DockPanel](./media/layout-smiley-stackpanel.PNG "layout_smiley_stackpanel")  
  
#### <a name="defining-and-using-a-stackpanel"></a>Определение и использование StackPanel  
 Следующий пример демонстрирует, как использовать <xref:System.Windows.Controls.StackPanel> для создания набора вертикально расположенных кнопок. Для горизонтального расположения задайте <xref:System.Windows.Controls.StackPanel.Orientation%2A> свойства <xref:System.Windows.Controls.Orientation.Horizontal>.  
  
 [!code-csharp[StackPanel_ovw2#1](~/samples/snippets/csharp/VS_Snippets_Wpf/StackPanel_ovw2/CSharp/StackPanel_Ovw_Sample2.cs#1)]
   
  
 Скомпилированное приложение возвращает новый [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)], который выглядит следующим образом.  
  
 ![Обычный элемент StackPanel.](./media/panel-intro-stackpanel.PNG "panel_intro_stackpanel")  
  
<a name="Panels_overview_VirtualizingStackPanel_subsection"></a>   
#### <a name="virtualizingstackpanel"></a>VirtualizingStackPanel  
 WPF также предоставляет разновидность <xref:System.Windows.Controls.StackPanel> элемент, который автоматически «виртуализирует» привязкой к данным дочернего содержимого. В данном контексте слово "виртуализация" означает способ, с помощью которого подмножество элементов создается из большего количества элементов данных в зависимости от того, какие из элементов отображаются на экране. Как для памяти, так и для процессора затратно создавать большое число элементов пользовательского интерфейса, при том что только несколько из них могут отображаться на экране одновременно. <xref:System.Windows.Controls.VirtualizingStackPanel> (с помощью функций, предоставляемых <xref:System.Windows.Controls.VirtualizingPanel>) подсчитывает видимые элементы и работает с <xref:System.Windows.Controls.ItemContainerGenerator> из <xref:System.Windows.Controls.ItemsControl> (такие как <xref:System.Windows.Controls.ListBox> или <xref:System.Windows.Controls.ListView>) создавать только элементы для видимых элементов.  
  
 <xref:System.Windows.Controls.VirtualizingStackPanel> Элемент автоматически устанавливается как узел элементов для элементов управления, такие как <xref:System.Windows.Controls.ListBox>. При размещении данных присоединенной коллекции, содержимое будет автоматически виртуализировано, до тех пор, пока оно находится в границах <xref:System.Windows.Controls.ScrollViewer>. Это значительно повышает производительность при размещении большого числа дочерних элементов.  
  
 Следующая разметка демонстрирует использование <xref:System.Windows.Controls.VirtualizingStackPanel> качестве узла элементов. <xref:System.Windows.Controls.VirtualizingStackPanel.IsVirtualizingProperty?displayProperty=nameWithType> Присоединенное свойство должно быть присвоено `true` (по умолчанию) для виртуализации, возникает.  
  
 [!code-xaml[VirtualizingStackPanel_Intro#1](~/samples/snippets/csharp/VS_Snippets_Wpf/VirtualizingStackPanel_Intro/CS/default.xaml#1)]  
  
<a name="Panels_overview_WrapPanel"></a>   
### <a name="wrappanel"></a>WrapPanel  
 <xref:System.Windows.Controls.WrapPanel> используется для размещения дочерних элементов в последовательности слева направо, перенося содержимое на следующую строку при достижении границы родительского контейнера. Содержимое может быть ориентировано горизонтально или вертикально. <xref:System.Windows.Controls.WrapPanel> полезно, когда [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)] сценариев. Его также можно использовать для установления единого размера для всех его дочерних элементов.  
  
 Следующий пример демонстрирует создание <xref:System.Windows.Controls.WrapPanel> для отображения <xref:System.Windows.Controls.Button> элементов управления, которые переносятся при достижении границы контейнера.  
  
 
 [!code-csharp[WrapPanel_Intro#1](~/samples/snippets/csharp/VS_Snippets_Wpf/WrapPanel_Intro/CSharp/WrapPanel_Code.cs#1)]
 
 [!code-xaml[WrapPanel_Intro#1](~/samples/snippets/xaml/VS_Snippets_Wpf/WrapPanel_Intro/XAML/default.xaml#1)]  
  
 Скомпилированное приложение возвращает новый [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)], который выглядит следующим образом.  
  
 ![Обычный элемент WrapPanel.](./media/wrappanel-element.PNG "WrapPanel_Element")  
  
<a name="Panels_nested_panel_elements"></a>   
## <a name="nested-panel-elements"></a>Вложенные элементы Panel  
 <xref:System.Windows.Controls.Panel> элементы могут быть вложены друг к другу для создания сложных макетов. Это может оказаться очень полезным в ситуациях, где одно <xref:System.Windows.Controls.Panel> идеально подходит для части [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)], но не может удовлетворить потребности другой части [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)].  
  
 Практически не существует ограничения объема вложения, которое может поддерживать приложение, но лучше ограничить приложение использованием только тех панелей, которые действительно необходимы для макета. Во многих случаях <xref:System.Windows.Controls.Grid> элемент может использоваться вместо вложенных панелей благодаря его гибкости в качестве контейнера макета. Это может повысить производительность приложения, убирая ненужные элементы из дерева.  
  
 Следующий пример демонстрирует создание [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)] , использующего преимущества вложенных <xref:System.Windows.Controls.Panel> элементы, чтобы получить определенный макет. В данном конкретном случае <xref:System.Windows.Controls.DockPanel> элемент используется для предоставления [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)] структурировать и вложенными <xref:System.Windows.Controls.StackPanel> элементов, <xref:System.Windows.Controls.Grid>и <xref:System.Windows.Controls.Canvas> используются для размещения дочерних элементов внутри родительского <xref:System.Windows.Controls.DockPanel>.  
  
 [!code-csharp[Nested_Panels#1](~/samples/snippets/csharp/VS_Snippets_Wpf/Nested_Panels/CSharp/nestedpanels.cs#1)]
   
  
 Скомпилированное приложение возвращает новый [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)], который выглядит следующим образом.  
  
 ![Пользовательский интерфейс, использующий вложенные панели.](./media/nested-panels.PNG "nested_panels")  
  
<a name="Panels_custom_panel_elements"></a>   
## <a name="custom-panel-elements"></a>Пользовательские элементы Panel  
 Хотя WPF предоставляет целый ряд гибких элементов управления макетом, настраиваемый макет, также поведения можно достигнуть путем переопределения <xref:System.Windows.FrameworkElement.ArrangeOverride%2A> и <xref:System.Windows.FrameworkElement.MeasureOverride%2A> методы. Пользовательские изменения размеров и положения могут быть выполнены путем определения нового поведения размещения с помощью этих методов переопределения.  
  
 Аналогичным образом, пользовательские расширения функциональности макета на основе производных классов (таких как <xref:System.Windows.Controls.Canvas> или <xref:System.Windows.Controls.Grid>) можно задать путем переопределения их <xref:System.Windows.FrameworkElement.ArrangeOverride%2A> и <xref:System.Windows.FrameworkElement.MeasureOverride%2A> методы.  
  
 Следующая разметка демонстрирует создание пользовательского <xref:System.Windows.Controls.Panel> элемент. Этот новый <xref:System.Windows.Controls.Panel>, определенная как `PlotPanel`, поддерживает размещение дочерних элементов с использованием жестко *x -* и *y -* координаты. В этом примере <xref:System.Windows.Shapes.Rectangle> элемент (не показан) находится в точке с координатами 50 (*x*) до 50 (*y*).  
  
 
 [!code-csharp[PlotPanel#1](~/samples/snippets/csharp/VS_Snippets_Wpf/PlotPanel/CSharp/PlotPanel.cs#1)]
   
  
 Более сложные реализации пользовательских панелей можно найти в разделе [примера создания пользовательской панели с переносом содержимого](https://go.microsoft.com/fwlink/?LinkID=159979).  
  
<a name="Panels_global_localization"></a>   
## <a name="localizationglobalization-support"></a>Поддержка локализации и глобализации  
 WPF поддерживает ряд функций, которые помогают в создании локализуемого [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)].  
  
 Все элементы панели изначально поддерживают <xref:System.Windows.FrameworkElement.FlowDirection%2A> свойство, которое может использоваться для динамического содержимого на основе параметров языкового стандарта или языка пользователя. Дополнительные сведения см. в разделе <xref:System.Windows.FrameworkElement.FlowDirection%2A>.  
  
 <xref:System.Windows.Window.SizeToContent%2A> Свойство предоставляет механизм, который позволяет разработчикам приложений предвидеть потребности локализованного [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)]. С помощью <xref:System.Windows.SizeToContent.WidthAndHeight> значение этого свойства родительского <xref:System.Windows.Window> всегда динамически изменяет размер в соответствии с размером и не ограничивается искусственных ограничений высоты или ширины.  
  
 <xref:System.Windows.Controls.DockPanel>, <xref:System.Windows.Controls.Grid>, и <xref:System.Windows.Controls.StackPanel> — это хороший выбор для локализуемых [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)]. <xref:System.Windows.Controls.Canvas> Тем не менее, является не лучшим выбором, так как он размещает содержимое абсолютно, что затрудняет локализацию.  
  
 Дополнительные сведения о создании приложений WPF с локализуемыми [!INCLUDE[TLA#tla_ui#plural](../../../../includes/tlasharptla-uisharpplural-md.md)] см. в разделе [Обзор использования автоматической разметки](../advanced/use-automatic-layout-overview.md).  
  
## <a name="see-also"></a>См. также

- [Пошаговое руководство. Создание классического приложения WPF](../getting-started/walkthrough-my-first-wpf-desktop-application.md)
- [Пример коллекции макетов WPF](https://go.microsoft.com/fwlink/?LinkID=160054)
- [Макет](../advanced/layout.md)
- [Пример коллекции элементов управления WPF](https://go.microsoft.com/fwlink/?LinkID=160053)
- [Общие сведения о свойствах Alignment, Margin, Padding](../advanced/alignment-margins-and-padding-overview.md)
- [Создание пользовательского содержимого пример](https://go.microsoft.com/fwlink/?LinkID=159979)
- [Общие сведения о вложенных свойствах зависимостей](../advanced/attached-properties-overview.md)
- [Обзор использования автоматической разметки](../advanced/use-automatic-layout-overview.md)
- [Разметка и разработка](../advanced/optimizing-performance-layout-and-design.md)

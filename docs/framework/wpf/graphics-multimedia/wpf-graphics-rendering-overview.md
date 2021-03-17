---
title: Общие сведения об отрисовке графики в WPF
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- graphics [WPF], rendering
- rendering graphics [WPF]
ms.assetid: 6dec9657-4d8c-4e46-8c54-40fb80008265
ms.openlocfilehash: a0400ce32dc6dab2585a8d5e76ff8d416fae24c8
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59101371"
---
# <a name="wpf-graphics-rendering-overview"></a>Общие сведения об отрисовке графики в WPF
В этом разделе приведены общие сведения о визуальном слое [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]. Основное внимание в нем уделено роли класса <xref:System.Windows.Media.Visual> в поддержке отрисовки в модели [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)].  

<a name="role_of_visual_object"></a>   
## <a name="role-of-the-visual-object"></a>Роль объекта Visual  
 Класс <xref:System.Windows.Media.Visual> — это базовая абстракция, и каждый объект <xref:System.Windows.FrameworkElement> является производным от него. Эта абстракция также служит точкой входа для написания новых элементов управления [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], и во многих случаях ее можно рассматривать как аналог дескриптора окна (HWND) в модели приложений Win32.  
  
 Объект <xref:System.Windows.Media.Visual> — это основной объект [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], главная роль которого заключается в поддержке отрисовки. Элементы управления пользовательского интерфейса, такие как <xref:System.Windows.Controls.Button> и <xref:System.Windows.Controls.TextBox>, являются производными от класса <xref:System.Windows.Media.Visual> и используют его для сохранения данных отрисовки. Объект <xref:System.Windows.Media.Visual> обеспечивает поддержку следующих функций:  
  
-   Отображение выходных данных: Визуализация сохраненного, сериализованного содержимого визуального элемента.  
  
-   Преобразования. Выполнение преобразования визуального элемента.  
  
-   Отсечение: Позволяет указать область отсечения для визуального элемента.  
  
-   Проверка нажатия: Определяет, содержится ли координата или геометрическая фигура в пределах границ визуального объекта.  
  
-   Расчеты ограничивающих прямоугольников: Определение ограничивающего прямоугольника визуального объекта.  
  
 Однако объект <xref:System.Windows.Media.Visual> не включает поддержку функций, не относящихся к отрисовке, например:  
  
-   Обработка событий  
  
-   Макет  
  
-   Стили  
  
-   Привязка данных  
  
-   Глобализация  
  
 <xref:System.Windows.Media.Visual> указывается в виде открытого абстрактный класс, из которого должны наследоваться дочерние классы. На следующем рисунке показана иерархия визуальных объектов, которые предоставляются в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)].  
  
 ![Схема классов, производных от Visual-объекта](./media/wpf-graphics-rendering-overview/classes-derived-visual-object.png)    
  
### <a name="drawingvisual-class"></a>Класс DrawingVisual  
 <xref:System.Windows.Media.DrawingVisual> — упрощенный класс, используемый для отрисовки фигур, изображений и текста. Этот класс считается упрощенным, так как не предоставляет средств для работы с разметкой и обработку событий, что повышает его производительность. Поэтому этот класс идеально подходит для фоновых рисунков или клипов. <xref:System.Windows.Media.DrawingVisual> может быть использован для создания пользовательского визуального объекта. Дополнительные сведения см. в разделе [Использование объектов DrawingVisual](using-drawingvisual-objects.md).  
  
### <a name="viewport3dvisual-class"></a>Класс Viewport3DVisual  
 <xref:System.Windows.Media.Media3D.Viewport3DVisual> обеспечивает связь между двухмерными <xref:System.Windows.Media.Visual> и объектами <xref:System.Windows.Media.Media3D.Visual3D>. Класс <xref:System.Windows.Media.Media3D.Visual3D> является базовым классом для всех трехмерных визуальных элементов. Для <xref:System.Windows.Media.Media3D.Viewport3DVisual> необходимо определить значения <xref:System.Windows.Media.Media3D.Viewport3DVisual.Camera%2A> и <xref:System.Windows.Media.Media3D.Viewport3DVisual.Viewport%2A>. Камера (Camera) позволяет просмотреть сцену. Окно просмотра (Viewport) определяет, где проекция преобразуется в двумерную поверхность. Дополнительные сведения о трехмерной графике в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] см. в разделе [Общие сведения о трехмерной графике](3-d-graphics-overview.md).  
  
### <a name="containervisual-class"></a>Класс ContainerVisual  
 Класс <xref:System.Windows.Media.ContainerVisual> используется как контейнер для коллекции объектов <xref:System.Windows.Media.Visual>. Класс <xref:System.Windows.Media.DrawingVisual> является производным от класса <xref:System.Windows.Media.ContainerVisual>, поэтому он может содержать коллекцию визуальных объектов.  
  
### <a name="drawing-content-in-visual-objects"></a>Рисование содержимого в объектах Visual  
 Объект <xref:System.Windows.Media.Visual> хранит свои данные отрисовки в виде **списка инструкций векторной графики**. Каждый элемент в списке инструкций представляет низкоуровневый набор графических данных и связанных ресурсов в сериализованном формате. Существует четыре различных типа данных отрисовки, которые могут включать графическое содержимое.  
  
|Тип содержимого для отрисовки|Описание|  
|--------------------------|-----------------|  
|Векторная графика|Представляет векторные графические данные и все связанные сведения о <xref:System.Windows.Media.Brush> и <xref:System.Windows.Media.Pen>.|  
|Изображение|Представляет изображение в пределах области, определяемой <xref:System.Windows.Rect>.|  
|Глиф|Представляет рисунок, отображающий объект <xref:System.Windows.Media.GlyphRun>, который представляет собой последовательность глифов для указанного ресурса шрифта. Таким образом представляется текст.|  
|Видео|Представляет рисунок, отображающий видео.|  
  
 <xref:System.Windows.Media.DrawingContext> позволяет заполнять <xref:System.Windows.Media.Visual> визуальным содержимым. При использовании команд рисования объекта <xref:System.Windows.Media.DrawingContext> фактически происходит сохранение набора данных отрисовки, которые позже будут использоваться графической системой; рисование на экране в режиме реального времени не выполняется.  
  
 При создании элементов управления [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], например <xref:System.Windows.Controls.Button>, элемент управления неявно создает данные для своей отрисовки. Например, установка свойства <xref:System.Windows.Controls.ContentControl.Content%2A> элемента управления <xref:System.Windows.Controls.Button> заставляет его сохранить представление отрисовки для глифа.  
  
 Объект <xref:System.Windows.Media.Visual> описывает свое содержимое в виде одного или нескольких объектов <xref:System.Windows.Media.Drawing>, содержащихся в <xref:System.Windows.Media.DrawingGroup>. Объект <xref:System.Windows.Media.DrawingGroup> также описывает маски непрозрачности, преобразования, эффекты для точечных рисунков и другие операции, которые применяются к его содержимому. <xref:System.Windows.Media.DrawingGroup> При отрисовке содержимого операции, применяются в следующем порядке: <xref:System.Windows.Media.DrawingGroup.OpacityMask%2A>, <xref:System.Windows.Media.DrawingGroup.Opacity%2A>, <xref:System.Windows.Media.DrawingGroup.BitmapEffect%2A>, <xref:System.Windows.Media.DrawingGroup.ClipGeometry%2A>, <xref:System.Windows.Media.DrawingGroup.GuidelineSet%2A>, а затем <xref:System.Windows.Media.DrawingGroup.Transform%2A>.  
  
 Ниже показан порядок, в котором операции <xref:System.Windows.Media.DrawingGroup> применяются при отрисовке.  
  
 ![Порядок операций для DrawingGroup](./media/graphcismm-drawinggroup-order.png "graphcismm_drawinggroup_order")  
Порядок операций для DrawingGroup  
  
 Дополнительные сведения см. в разделе [Обзор объектов Drawing](drawing-objects-overview.md).  
  
#### <a name="drawing-content-at-the-visual-layer"></a>Отображение содержимого на визуальном уровне  
 Вы никогда непосредственно не создаете экземпляр <xref:System.Windows.Media.DrawingContext>, однако можете получить контекст рисования с помощью определенных методов, например <xref:System.Windows.Media.DrawingGroup.Open%2A?displayProperty=nameWithType> и <xref:System.Windows.Media.DrawingVisual.RenderOpen%2A?displayProperty=nameWithType>. В следующем примере <xref:System.Windows.Media.DrawingContext> извлекается из <xref:System.Windows.Media.DrawingVisual> и используется для рисования прямоугольника.  
  
 [!code-csharp[drawingvisualsample#101](~/samples/snippets/csharp/VS_Snippets_Wpf/DrawingVisualSample/CSharp/Window1.xaml.cs#101)]
 [!code-vb[drawingvisualsample#101](~/samples/snippets/visualbasic/VS_Snippets_Wpf/DrawingVisualSample/visualbasic/window1.xaml.vb#101)]  
  
#### <a name="enumerating-drawing-content-at-the-visual-layer"></a>Перечисление содержимого рисования на визуальном уровне  
 Наряду с другими своими возможностями, объекты <xref:System.Windows.Media.Drawing> также предоставляют объектную модель для перечисления содержимого <xref:System.Windows.Media.Visual>.  
  
> [!NOTE]
>  При перечислении содержимого визуального элемента извлекаются объекты <xref:System.Windows.Media.Drawing>, а не базовое представление данных отрисовки в виде списка инструкций векторной графики.  
  
 В следующем примере метод <xref:System.Windows.Media.VisualTreeHelper.GetDrawing%2A> используется для извлечения значения <xref:System.Windows.Media.DrawingGroup> из <xref:System.Windows.Media.Visual> и перечисления содержимого группы.  
  
 [!code-csharp[DrawingMiscSnippets_snip#GraphicsMMRetrieveDrawings](~/samples/snippets/csharp/VS_Snippets_Wpf/DrawingMiscSnippets_snip/CSharp/EnumerateDrawingsExample.xaml.cs#graphicsmmretrievedrawings)]  
  
<a name="how_visual_objects_are_used_to_build_controls"></a>   
## <a name="how-visual-objects-are-used-to-build-controls"></a>Использование визуальных объектов для создания элементов управления  
 Многие из объектов в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] состоят из других визуальных объектов, то есть они могут содержать различные иерархии объектов-потомков. Многие элементы пользовательского интерфейса в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], например элементы управления, состоят из множества визуальных объектов, которые представляют различные типы отрисовываемых элементов. Например, элемент управления <xref:System.Windows.Controls.Button> может содержать ряд других объектов, в том числе <xref:Microsoft.Windows.Themes.ClassicBorderDecorator>, <xref:System.Windows.Controls.ContentPresenter> и <xref:System.Windows.Controls.TextBlock>.  
  
 В следующем коде показано определение элемента управления <xref:System.Windows.Controls.Button> в разметке.  
  
 [!code-xaml[VisualsOverview#VisualsOverviewSnippet1](~/samples/snippets/csharp/VS_Snippets_Wpf/VisualsOverview/CSharp/Window1.xaml#visualsoverviewsnippet1)]  
  
 Если бы мы перечислили визуальные объекты, составляющие стандартный элемент управления <xref:System.Windows.Controls.Button>, обнаружилась бы показанная ниже иерархия визуальных объектов:  
  
 ![Схема иерархии визуального дерева](./media/wpf-graphics-rendering-overview/visual-object-diagram.gif) 
  
 Элемент управления <xref:System.Windows.Controls.Button> содержит элемент <xref:Microsoft.Windows.Themes.ClassicBorderDecorator>, который, в свою очередь, содержит элемент <xref:System.Windows.Controls.ContentPresenter>. Элемент <xref:Microsoft.Windows.Themes.ClassicBorderDecorator> отвечает за рисование границ и фона для <xref:System.Windows.Controls.Button>. Элемент <xref:System.Windows.Controls.ContentPresenter> отвечает за отображение содержимого <xref:System.Windows.Controls.Button>. В данном случае, поскольку отображается текст, элемент <xref:System.Windows.Controls.ContentPresenter> содержит элемент <xref:System.Windows.Controls.TextBlock>. Тот факт, что элемент управления <xref:System.Windows.Controls.Button> использует <xref:System.Windows.Controls.ContentPresenter>, означает, что его содержимое можно представить в виде других элементов, например <xref:System.Windows.Controls.Image>, или геометрического объекта, например <xref:System.Windows.Media.EllipseGeometry>.  
  
### <a name="control-templates"></a>Шаблоны элементов управления  
 Ключевую роль в развертывании элементов управления в иерархию играет <xref:System.Windows.Controls.ControlTemplate>. Шаблон элемента управления определяет его визуальную иерархию по умолчанию. При явной ссылке на элемент управления вы неявно ссылаетесь на его визуальную иерархию. Для изменения внешнего вида элемента управления вы можете переопределить значения по умолчанию для его шаблона. Например, можно изменить значение цвета фона элемента управления <xref:System.Windows.Controls.Button> так, чтобы использовалось значение линейного градиента цвета вместо значения сплошного цвета. Дополнительные сведения см. в разделе [Стили и шаблоны кнопок](../controls/button-styles-and-templates.md).  
  
 Элемент пользовательского интерфейса, такие как <xref:System.Windows.Controls.Button> управления, содержит несколько списков инструкций векторной графики, которые описывают полностью определяют отрисовку элемента управления. В следующем коде показано определение элемента управления <xref:System.Windows.Controls.Button> в разметке.  
  
 [!code-xaml[VisualsOverview#VisualsOverviewSnippet2](~/samples/snippets/csharp/VS_Snippets_Wpf/VisualsOverview/CSharp/Window1.xaml#visualsoverviewsnippet2)]  
  
 Если перечислить визуальные объекты и списки инструкций векторной графики, которые составляют элемент управления <xref:System.Windows.Controls.Button>, обнаружится показанная ниже иерархия объектов:  
  
 ![Схема визуального дерева и отрисовки данных](./media/wpf-graphics-rendering-overview/visual-tree-rendering-data.png)  
  
 Элемент управления <xref:System.Windows.Controls.Button> содержит элемент <xref:Microsoft.Windows.Themes.ClassicBorderDecorator>, который, в свою очередь, содержит элемент <xref:System.Windows.Controls.ContentPresenter>. <xref:Microsoft.Windows.Themes.ClassicBorderDecorator> Элемент отвечает за рисование всех отдельных графических элементов, составляющих границу и фон кнопки. Элемент <xref:System.Windows.Controls.ContentPresenter> отвечает за отображение содержимого <xref:System.Windows.Controls.Button>. В этом случае, поскольку выполняется отображение изображения, <xref:System.Windows.Controls.ContentPresenter> элемент содержит <xref:System.Windows.Controls.Image> элемент.  
  
 При работе с иерархией визуальных объектов и списками инструкций векторной графики следует учитывать несколько моментов.  
  
-   Порядок иерархии представляет порядок отрисовки графической информации. От корневого визуального элемента проход дочерних элементов осуществляется слева направо и сверху вниз. Если у элемента есть дочерние визуальные элементы, они проходятся до элементов того же уровня.  
  
-   Неконечные элементы в иерархии, например <xref:System.Windows.Controls.ContentPresenter>, используются для хранения дочерних элементов — они не содержат списков инструкций.  
  
-   Если визуальный элемент содержит как список инструкций векторной графики, так и визуальные дочерние объекты, то список инструкций в родительском визуальном элементе выполняется перед тем, как будут прорисованы любые визуальные дочерние объекты.  
  
-   Элементы в списке инструкций векторной графики обрабатываются слева направо.  
  
<a name="visual_tree"></a>   
## <a name="visual-tree"></a>Визуальное дерево  
 Визуальное дерево содержит все визуальные элементы, содержащиеся в пользовательском интерфейсе приложения. Поскольку визуальный элемент содержит сохраняемую графическую информацию, визуальное дерево можно представить как граф сцены, содержащий все сведения об отрисовке, необходимые для формирования данных, выводимых на устройство отображения. Это дерево представляет собой совокупность всех визуальных элементов, создаваемых непосредственно в приложении (в коде или в разметке). Визуальное дерево также содержит все визуальные элементы, создаваемые путем расширения шаблона элементов, например элементы управления и объекты данных.  
  
 В следующем коде показан элемент <xref:System.Windows.Controls.StackPanel>, определенный в разметке.  
  
 [!code-xaml[VisualsOverview#VisualsOverviewSnippet3](~/samples/snippets/csharp/VS_Snippets_Wpf/VisualsOverview/CSharp/Window1.xaml#visualsoverviewsnippet3)]  
  
 Если перечислить визуальные объекты, которые составляют элемент <xref:System.Windows.Controls.StackPanel> в примере разметки, обнаружится показанная ниже иерархия визуальных объектов:  
  
 ![Схема иерархии визуального дерева](./media/wpf-graphics-rendering-overview/visual-tree-hierarchy.gif)  
  
### <a name="rendering-order"></a>Порядок отрисовки  
 Визуальное дерево определяет порядок отрисовки визуальных элементов и графических объектов [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]. Обработка начинается с корневого визуального элемента, самого верхнего узла в визуальном дереве. Затем обрабатываются дочерние элементы корневого визуального элемента слева направо. Если у визуального элемента есть дочерние элементы, они обрабатываются перед элементами, находящимися на одном уровне с визуальным элементом. Это означает, что содержимое дочерних визуальных элементов отображается перед содержимым самого визуального элемента.  
  
 ![Схема порядка отрисовки визуального дерева](./media/wpf-graphics-rendering-overview/visual-tree-rendering-order.gif) 
  
### <a name="root-visual"></a>Корневой визуальный элемент  
 **Корневой визуальный элемент** — это самый верхний элемент в иерархии визуального дерева. В большинстве приложений базовым классом корневого визуального элемента является либо <xref:System.Windows.Window>, либо <xref:System.Windows.Navigation.NavigationWindow>. Однако при размещении визуальных объектов в приложении Win32 корневым визуальным элементом будет самый верхний визуальный элемент в окне Win32. Дополнительные сведения см. в статье [Руководство по размещению визуальных объектов в приложении Win32](tutorial-hosting-visual-objects-in-a-win32-application.md).  
  
### <a name="relationship-to-the-logical-tree"></a>Связь с логическом деревом  
 Логическое дерево в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] представляет элементы приложения во время выполнения. Хотя этим деревом нельзя управлять напрямую, с помощью этой схемы удобно представить наследование свойств и маршрутизацию событий. В отличие от визуального дерева, логическое дерево может представлять и невизуальные объекты, например <xref:System.Windows.Documents.ListItem>. Во многих случаях логическое дерево приближается к определению разметки приложения. В следующем коде показан элемент <xref:System.Windows.Controls.DockPanel>, определенный в разметке.  
  
 [!code-xaml[VisualsOverview#VisualsOverviewSnippet5](~/samples/snippets/csharp/VS_Snippets_Wpf/VisualsOverview/CSharp/Window1.xaml#visualsoverviewsnippet5)]  
  
 Если перечислить логические объекты, которые составляют элемент <xref:System.Windows.Controls.DockPanel> в примере разметки, обнаружится иерархия логических объектов, показанная ниже:  
  
 ![Диаграмма дерева](./media/tree1-wcp.gif "Tree1_wcp")  
Схема логического дерева  
  
 Визуальное дерево и логическое дерево синхронизируются с текущим набором элементов приложения, отражая добавление, удаление или изменение элементов. Однако эти деревья отражают различные представления приложения. В отличие от визуального дерева, в логическом дереве не ракрываются <xref:System.Windows.Controls.ContentPresenter> элементов управления. Это означает, что между логическим деревом и визуальным деревом для одного и того же набора объектов нет прямого однозначного соответствия. На самом деле, вызов метода <xref:System.Windows.LogicalTreeHelper.GetChildren%2A> объекта **LogicalTreeHelper** и метода <xref:System.Windows.Media.VisualTreeHelper.GetChild%2A> объекта **VisualTreeHelper** с одним и тем же элементом в качестве параметра дает разные результаты.  
  
 Дополнительные сведения о логическом дереве см. в разделе [Деревья в WPF](../advanced/trees-in-wpf.md).  
  
### <a name="viewing-the-visual-tree-with-xamlpad"></a>Просмотр визуального дерева с помощью XamlPad  
 Средство [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] XamlPad позволяет просматривать и изучать визуальное дерево, соответствующее текущему содержимому [!INCLUDE[TLA#tla_titlexaml](../../../../includes/tlasharptla-titlexaml-md.md)]. Для отображения визуального дерева нажмите кнопку **Показать визуальное дерево**. Ниже показано расширение содержимого [!INCLUDE[TLA#tla_titlexaml](../../../../includes/tlasharptla-titlexaml-md.md)] в узлы визуального дерева на панели **Обозреватель визуального дерева** XamlPad.  
  
 ![Панель обозревателя визуального дерева в XamlPad](./media/wpf-graphics-rendering-overview/visual-tree-explorer.png)  

 Обратите внимание, что каждый из элементов управления <xref:System.Windows.Controls.Label>, <xref:System.Windows.Controls.TextBox> и <xref:System.Windows.Controls.Button> отображает отдельную иерархию визуальных объектов в панели **Обозреватель визуального дерева** XamlPad. Это обусловлено тем, что элементы управления [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] имеют шаблон <xref:System.Windows.Controls.ControlTemplate>, который содержит визуальное дерево этого элемента управления. При явной ссылке на элемент управления вы неявно ссылаетесь на его визуальную иерархию.  
  
### <a name="profiling-visual-performance"></a>Профилирование производительности для объекта Visual  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] предоставляет набор средств профилирования производительности, позволяющие анализировать поведение времени выполнения приложения и определить, какие оптимизации производительности, которые можно применить. Средство Visual Profiler предоставляет подробные данные о производительности в удобном графическом формате, сопоставляя их напрямую с визуальным деревом приложения. На этом снимке экрана показан раздел **Использование ЦП** средства Visual Profiler. В этом разделе вы можете получить точное представление об использовании объектом служб [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], таких как отрисовка и разметка.  
  
 ![Visual Profiler отображает выходные данные](./media/wpfperf-visualprofiler-04.png "WPFPerf_VisualProfiler_04")  
Отображение данных Visual Profiler  
  
<a name="visual_rendering_behavior"></a>   
## <a name="visual-rendering-behavior"></a>Поведение отрисовки для объекта Visual  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] включает несколько возможностей, влияющих на отрисовку визуальных объектов: графика, векторная графика и аппаратно независимая графика.  
  
### <a name="retained-mode-graphics"></a>Абстрактный графический режим  
 Для понимания роли объекта Visual необходимо хорошо представлять различие между системами с **непосредственным** и **абстрактным** графическими режимами. В стандартном приложении Win32 на основе GDI или GDI+ используется непосредственный графический режим. Это означает, что приложение отвечает за перерисовку той части клиентской области, которая стала недействительной из-за таких действий, как изменение размера окна или изменение внешнего вида объекта.  
  
 ![Схема последовательности отрисовки Win32](./media/wpf-graphics-rendering-overview/win32-rendering-squence.png)  
  
 В [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], напротив, используется абстрактный графический режим. Это означает, что в объектах приложения, у которых есть внешний облик, определяется набор сериализованных графических данных. После определения графических данных система отвечает на все запросы перерисовки для отрисовки объектов приложения. Даже во время выполнения можно изменять или создавать объекты приложения, при этом система будет обрабатывать запросы на перерисовку. Преимущество абстрактного режима состоит в том, что данные отрисовки всегда сохраняются приложением в сериализованном виде, при этом за отрисовку отвечает система. На следующей схеме показано, как приложение полагается на [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] в обработке запросов на отрисовку.  
  
 ![Схема последовательности отрисовки WPF](./media/wpf-graphics-rendering-overview/wpf-rendering-sequence.png)  

#### <a name="intelligent-redrawing"></a>Интеллектуальная перерисовка  
 Одним из основных преимуществ использования абстрактного графического режима является то, что [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] может эффективно оптимизировать элементы приложения, которые требуют перерисовки. Даже при наличии сложной сцены с различными уровнями прозрачности разработчикам обычно не нужно писать специальный код для оптимизации перерисовки. Сравните это с программированием для Win32, в котором можно потратить значительные усилия на оптимизацию приложения, уменьшая объем перерисовки в области обновления. Пример сложного случая оптимизации перерисовки для приложений Win32 см. в разделе [Перерисовка в области обновления](/windows/desktop/gdi/redrawing-in-the-update-region).  
  
### <a name="vector-graphics"></a>Векторная графика  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] использует **векторную графику** качестве формата данных отрисовки. Векторная графика, к которой относятся масштабируемые векторные рисунки (SVG), метафайлы Windows (WMF) и шрифты TrueType, хранит данные отрисовки и передает их в виде списка инструкций, которые описывают, как воссоздать изображение с помощью графических примитивов. Например, шрифты TrueType — это контурные шрифты, которые описывают набор линий, кривых и команд, а не массив точек. Одним из основных преимуществ векторной графики является возможность масштабирования до любого размера и разрешения.  
  
 В отличие от векторной графики в растровой графике данные отрисовки представлены в попиксельном виде для определенного разрешения. Одним из ключевых различий между растровой и векторной графикой является соответствие исходному изображению. Например, при изменении размера исходного изображения в растровой графике изображение растягивается, тогда как в векторной — масштабируется с сохранением качества.  
  
 На следующем рисунке показано исходное изображение, которое было увеличено в 3 раза (масштаб 300 %). Обратите внимание на искажения, которые появляются при растяжении исходного изображения в растровом формате по сравнению с векторным.  
  
 ![Различия между растровой и векторной графикой](./media/wpf-graphics-rendering-overview/raster-vector-differences.png)  
  
 В следующем примере показано определение двух элементов <xref:System.Windows.Shapes.Path>. Во втором элементе с помощью <xref:System.Windows.Media.ScaleTransform> к инструкциям отрисовки первого элемента применяется операция изменения размера на 300 %. Обратите внимание, что инструкции отрисовки в элементе <xref:System.Windows.Shapes.Path> остаются без изменений.  
  
 [!code-xaml[VectorGraphicsSnippets#VectorGraphicsSnippet1](~/samples/snippets/csharp/VS_Snippets_Wpf/VectorGraphicsSnippets/CS/PageOne.xaml#vectorgraphicssnippet1)]  
  
### <a name="about-resolution-and-device-independent-graphics"></a>О разрешении и аппаратно независимой графике  
 Существуют два фактора, которые определяют размер текста и графики на экране: разрешение и количество точек на дюйм. Разрешение определяет число пикселей, отображаемых на экране. Чем выше разрешение, тем меньше размер пикселей и тем меньше отображаемые объекты и текст. Изображение на мониторе с разрешением 1024 x 768 значительно уменьшится, если изменить разрешение на 1600 x 1200.  
  
 Другой системный параметр, количество точек на дюйм, описывает размер дюйма экрана в пикселях. Для большинства систем [!INCLUDE[TLA#tla_mswin](../../../../includes/tlasharptla-mswin-md.md)] количество точек на дюйм составляет 96, т. е. на одном дюйме экрана находится 96 пикселей. При повышении количества точек на дюйм экранный дюйм увеличивается, при понижении — уменьшается. Это означает, что дюйм экрана не совпадает с размером настоящего дюйма, по крайней мере в большинстве систем. При увеличении количества точек на дюйм изображения и текст становятся больше, так как увеличивается размер экранного дюйма. Увеличение количества точек на дюйм может сделать текст более удобным для чтения, особенно при высоких разрешениях.  
  
 Не все приложения поддерживают количество точек на дюйм: в некоторых приложениях в качестве основной единицы измерения используются аппаратно зависимые пиксели, и изменение количества точек на дюйм не влияет на такие приложения. Во многих других приложениях количество точек на дюйм используется при описании размеров шрифта, но для остальных элементов используются пиксели. Слишком маленькое или слишком большое количество точек на дюйм может вызвать проблемы с разметкой для этих приложений, так как размер текста приложения будет изменяться с изменением системного количества точек на дюйм, тогда как интерфейс приложения изменяться не будет. Для приложений, разработанных с помощью [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], эта проблема устранена.  
  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] поддерживает автоматическое масштабирование с помощью аппаратно независимых пикселей в качестве основной единицы измерения, вместо аппаратно зависимые пиксели; изображения и текст масштабируются правильно без дополнительных усилий от разработчика приложения. На следующем рисунке показан пример отображения текста и графики [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] с различными параметрами количества точек на дюйм.  
  
 ![Изображения и текст с различными параметрами DPI](./media/graphicsmm-dpi-setting-examples.png "graphicsmm_dpi_setting_examples")  
Изображения и текст с различными параметрами количества точек на дюйм  
  
<a name="visualtreehelper_class"></a>   
## <a name="visualtreehelper-class"></a>Класс VisualTreeHelper  
 Класс <xref:System.Windows.Media.VisualTreeHelper> — это статический вспомогательный класс, предоставляющий низкоуровневые функции для программирования на уровне визуального объекта, что полезно в определенных случаях, например при разработке пользовательских элементов управления высокой производительности. В большинстве случаев высокоуровневые объекты [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], например <xref:System.Windows.Controls.Canvas> и <xref:System.Windows.Controls.TextBlock>, обладают большей гибкостью и простотой использования.  
  
### <a name="hit-testing"></a>Проверка нажатия  
 Класс <xref:System.Windows.Media.VisualTreeHelper> предоставляет методы проверки нажатия визуальных объектов, если поддержка проверки нажатия по умолчанию не соответствует вашим потребностям. Можно использовать методы <xref:System.Windows.Media.VisualTreeHelper.HitTest%2A> класса <xref:System.Windows.Media.VisualTreeHelper>, чтобы определить, находится ли геометрический объект или значение координат точки в пределах границ заданного объекта, например элемента управления или графического элемента. Например, с помощью проверки нажатия можно определить, попадает ли щелчок мыши в пределах ограничивающего прямоугольника объекта в окружность. Также можно переопределить реализацию проверки нажатия по умолчанию и выполнять собственные вычисления для проверки нажатия.  
  
 Дополнительные сведения о проверке нажатия см. в разделе [Проверка нажатия на визуальном уровне](hit-testing-in-the-visual-layer.md).  
  
### <a name="enumerating-the-visual-tree"></a>Перечисление визуального дерева  
 Класс <xref:System.Windows.Media.VisualTreeHelper> предоставляет функциональные возможности для перечисления элементов визуального дерева. Чтобы извлечь родительский объект, вызовите метод <xref:System.Windows.Media.VisualTreeHelper.GetParent%2A>. Чтобы получить дочерний элемент или прямого потомка визуального объекта, вызовите метод <xref:System.Windows.Media.VisualTreeHelper.GetChild%2A>. Этот метод возвращает дочерний элемент <xref:System.Windows.Media.Visual> родительского элемента по указанному индексу.  
  
 В следующем примере показано, как перечислить всех потомков визуального объекта. Этот метод можно использовать для сериализации всех данных отрисовки в иерархии визуального объекта.  
  
 [!code-csharp[VisualsOverview#101](~/samples/snippets/csharp/VS_Snippets_Wpf/VisualsOverview/CSharp/Window1.xaml.cs#101)]
 [!code-vb[VisualsOverview#101](~/samples/snippets/visualbasic/VS_Snippets_Wpf/VisualsOverview/visualbasic/window1.xaml.vb#101)]  
  
 В большинстве случаев логическое дерево более удобно для представления элементов приложения [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]. Хотя логическое дерево нельзя изменить напрямую, с помощью этой схемы удобно представить наследование свойств и маршрутизацию событий. В отличие от визуального дерева, логическое дерево может представлять и невизуальные объекты, например <xref:System.Windows.Documents.ListItem>. Дополнительные сведения о логическом дереве см. в разделе [Деревья в WPF](../advanced/trees-in-wpf.md).  
  
 Класс <xref:System.Windows.Media.VisualTreeHelper> предоставляет методы для получения ограничивающего прямоугольника визуальных объектов. Ограничивающий прямоугольник визуального объекта возвращается методом <xref:System.Windows.Media.VisualTreeHelper.GetContentBounds%2A>. Ограничивающий прямоугольник всех потомков визуального объекта, включая сам визуальный объект, возвращается методом <xref:System.Windows.Media.VisualTreeHelper.GetDescendantBounds%2A>. В следующем коде показано, как вычислить ограничивающий прямоугольник для визуального объекта и всех его потомков.  
  
 [!code-csharp[VisualsOverview#102](~/samples/snippets/csharp/VS_Snippets_Wpf/VisualsOverview/CSharp/Window1.xaml.cs#102)]
 [!code-vb[VisualsOverview#102](~/samples/snippets/visualbasic/VS_Snippets_Wpf/VisualsOverview/visualbasic/window1.xaml.vb#102)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Visual>
- <xref:System.Windows.Media.VisualTreeHelper>
- <xref:System.Windows.Media.DrawingVisual>
- [Двумерная графика и изображения](../advanced/optimizing-performance-2d-graphics-and-imaging.md)
- [Проверка попадания на визуальном уровне](hit-testing-in-the-visual-layer.md)
- [Использование объектов DrawingVisual](using-drawingvisual-objects.md)
- [Учебник. Размещение визуальных объектов в приложении Win32](tutorial-hosting-visual-objects-in-a-win32-application.md)
- [Улучшение производительности приложений WPF](../advanced/optimizing-wpf-application-performance.md)

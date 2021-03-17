---
title: Элементы управления
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- controls [WPF], about WPF controls
ms.assetid: 3f255a8a-35a8-4712-9065-472ff7d75599
ms.openlocfilehash: 5abafe1edfdbac1966a98d5eef28265e6504c868
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59154418"
---
# <a name="controls"></a>Элементы управления
<a name="introduction"></a>
[!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] содержит большинство распространенных компонентов пользовательского интерфейса, которые используются практически во всех приложениях Windows, таких как <xref:System.Windows.Controls.Button>, <xref:System.Windows.Controls.Label>, <xref:System.Windows.Controls.TextBox>, <xref:System.Windows.Controls.Menu> и <xref:System.Windows.Controls.ListBox>. Исторически эти объекты называются элементами управления. Хотя пакет SDK для [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] продолжает использовать термин "элемент управления" для общего обозначения любого класса, который представляет видимый объект в приложении, важно отметить, что класс не обязательно должен наследовать от класса <xref:System.Windows.Controls.Control>, чтобы иметь визуальное представление. Классы, наследующие от класса <xref:System.Windows.Controls.Control>, содержат шаблон <xref:System.Windows.Controls.ControlTemplate>, позволяющий пользователю элемента управления существенно изменить внешний вид элемента управления, не создавая новый подкласс. В этом разделе описано, как элементы управления (и наследующие от класса <xref:System.Windows.Controls.Control>, и не наследующие от него) обычно используются в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)].  

<a name="creating_an_instance_of_a_control"></a>   
## <a name="creating-an-instance-of-a-control"></a>Создание экземпляра элемента управления  
Элемент управления можно добавить в приложение с помощью [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] или кода. В следующем примере показано, как создать простое приложение, которое запрашивает у пользователя имя и фамилию. В этом примере создается шесть элементов управления: две метки, два текстовых поля и две кнопки в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)]. Все элементы управления могут быть созданы аналогичным образом. 
  
 [!code-xaml[ControlsOverview#1](~/samples/snippets/csharp/VS_Snippets_Wpf/ControlsOverview/CSharp/Window1.xaml#1)]  
  
 В следующем примере создается такое же приложение в коде. Для краткости создание <xref:System.Windows.Controls.Grid>, `grid1`, было исключено из примера. `grid1` имеет те же определения столбцов и строк, как показано в предыдущем примере [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)].  
  
 [!code-csharp[ControlsOverview#2](~/samples/snippets/csharp/VS_Snippets_Wpf/ControlsOverview/CSharp/AppInCode.xaml.cs#2)]
 [!code-vb[ControlsOverview#2](~/samples/snippets/visualbasic/VS_Snippets_Wpf/ControlsOverview/VisualBasic/AppInCode.xaml.vb#2)]  
  
<a name="changing_the_appearance_of_a_control"></a>   
## <a name="changing-the-appearance-of-a-control"></a>Изменение внешнего вида элемента управления  
 Обычно внешний вид элемента управления изменяется в соответствии с внешним видом приложения. Можно изменить внешний вид элемента управления, выполнив одно из следующих действий (в зависимости от того, чего нужно достичь):  
  
-   Изменить значение свойства элемента управления.  
  
-   Создать <xref:System.Windows.Style> для элемента управления.  
  
-   Создать новый <xref:System.Windows.Controls.ControlTemplate> для элемента управления.  
  
### <a name="changing-a-controls-property-value"></a>Изменение значения свойства элемента управления  
 Многие элементы управления имеют свойства, которые позволяют изменять внешний вид элемента управления, например <xref:System.Windows.Controls.Control.Background%2A> у <xref:System.Windows.Controls.Button>. Можно задать значение свойства как в  [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)], так и в коде. В следующем примере задаются свойства <xref:System.Windows.Controls.Control.Background%2A>, <xref:System.Windows.Controls.Control.FontSize%2A> и <xref:System.Windows.Controls.Control.FontWeight%2A> у <xref:System.Windows.Controls.Button> в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)].  
  
 [!code-xaml[ControlsOverview#3](~/samples/snippets/csharp/VS_Snippets_Wpf/ControlsOverview/CSharp/AppInCode.xaml#3)]  
  
 Следующий пример устанавливает те же самые свойства в коде.  
  
 [!code-csharp[ControlsOverview#4](~/samples/snippets/csharp/VS_Snippets_Wpf/ControlsOverview/CSharp/AppInCode.xaml.cs#4)]
 [!code-vb[ControlsOverview#4](~/samples/snippets/visualbasic/VS_Snippets_Wpf/ControlsOverview/VisualBasic/AppInCode.xaml.vb#4)]  
  
### <a name="creating-a-style-for-a-control"></a>Создание стиля для элемента управления  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] дает возможность группового определения внешнего вида элементов управления путем создания <xref:System.Windows.Style> вместо установки свойств для каждого экземпляра в приложении. В следующем примере создается <xref:System.Windows.Style>, который применяется к каждому элементу <xref:System.Windows.Controls.Button> в приложении. Определения <xref:System.Windows.Style> обычно размещаются в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] в <xref:System.Windows.ResourceDictionary>, например в свойстве <xref:System.Windows.FrameworkElement.Resources%2A> объекта <xref:System.Windows.FrameworkElement>. 
  
 [!code-xaml[ControlsOverview#5](~/samples/snippets/csharp/VS_Snippets_Wpf/ControlsOverview/CSharp/AppInCode.xaml#5)]  
  
 Можно также применить стиль только к определенным элементам управления определенного типа, присвоив стилю ключ и указав этот ключ в свойстве `Style` элемента управления. Дополнительные сведения о стилях см. в разделе [Стилизация и использование шаблонов](styling-and-templating.md).  
  
### <a name="creating-a-controltemplate"></a>Создание шаблона ControlTemplate  
 Объект <xref:System.Windows.Style> позволяет одновременно задать свойства для нескольких элементов управления, но иногда может потребоваться настроить внешний вид <xref:System.Windows.Controls.Control> за пределами того, что можно сделать созданием <xref:System.Windows.Style>. Классы, наследующие от <xref:System.Windows.Controls.Control>, имеют шаблон <xref:System.Windows.Controls.ControlTemplate>, который определяет структуру и внешний вид элемента <xref:System.Windows.Controls.Control>. Свойство <xref:System.Windows.Controls.Control.Template%2A> класса <xref:System.Windows.Controls.Control> является открытым, поэтому вы можете задать для элемента <xref:System.Windows.Controls.Control> свой <xref:System.Windows.Controls.ControlTemplate>, отличающийся от его шаблона по умолчанию. Часто можно указать новый шаблон <xref:System.Windows.Controls.ControlTemplate> для <xref:System.Windows.Controls.Control> вместо наследования от элемента управления для настройки внешнего вида <xref:System.Windows.Controls.Control>. 
  
 Рассмотрим очень популярный элемент управления, <xref:System.Windows.Controls.Button>. Основное поведение <xref:System.Windows.Controls.Button> позволяет приложению выполнить определенное действие, когда пользователь щелкает этот элемент. По умолчанию <xref:System.Windows.Controls.Button> в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] отображается как приподнятый прямоугольник. При разработке приложения может возникнуть необходимость использовать это поведение <xref:System.Windows.Controls.Button>, то есть, обработку события нажатия кнопки, но при этом изменить внешний вид кнопки в большей степени, чем позволяет изменение ее свойств. В этом случае можно создать новый шаблон <xref:System.Windows.Controls.ControlTemplate>. 
  
 В следующем примере создается <xref:System.Windows.Controls.ControlTemplate> для <xref:System.Windows.Controls.Button>. <xref:System.Windows.Controls.ControlTemplate> создает <xref:System.Windows.Controls.Button> со скругленными углами и градиентным фоном.  <xref:System.Windows.Controls.ControlTemplate> содержит <xref:System.Windows.Controls.Border>, <xref:System.Windows.Controls.Border.Background%2A> которого — <xref:System.Windows.Media.LinearGradientBrush> с двумя объектами <xref:System.Windows.Media.GradientStop>. Первый <xref:System.Windows.Media.GradientStop> использует привязку данных для привязки свойства <xref:System.Windows.Media.GradientStop.Color%2A> объекта <xref:System.Windows.Media.GradientStop> к цвету фона кнопки.  При задании свойства <xref:System.Windows.Controls.Control.Background%2A> элемента управления <xref:System.Windows.Controls.Button> цвет этого значения будет использоваться как первый <xref:System.Windows.Media.GradientStop>. Дополнительные сведения о привязке данных см. в разделе [Общие сведения о привязке данных](../data/data-binding-overview.md). В примере также создается <xref:System.Windows.Trigger>, который изменяет внешний вид <xref:System.Windows.Controls.Button>, когда <xref:System.Windows.Controls.Primitives.ButtonBase.IsPressed%2A> принимает значение `true`.
  
 [!code-xaml[ControlsOverview#6](~/samples/snippets/csharp/VS_Snippets_Wpf/ControlsOverview/CSharp/Window1.xaml#6)]  
[!code-xaml[ControlsOverview#7](~/samples/snippets/csharp/VS_Snippets_Wpf/ControlsOverview/CSharp/AppInCode.xaml#7)]  
  
> [!NOTE]
>  Свойству <xref:System.Windows.Controls.Control.Background%2A> элемента управления <xref:System.Windows.Controls.Button> должно быть присвоено значение <xref:System.Windows.Media.SolidColorBrush> для правильной работы примера.  
  
<a name="subscribing_to_events"></a>   
## <a name="subscribing-to-events"></a>Подписка на события  
 Можно подписаться на событие элемента управления с помощью [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] или кода, но обработать событие можно только в коде.  В следующем примере показано, как подписаться на событие `Click` элемента управления <xref:System.Windows.Controls.Button>.  
  
 [!code-xaml[ControlsOverview#10](~/samples/snippets/csharp/VS_Snippets_Wpf/ControlsOverview/CSharp/Window1.xaml#10)]  
  
 [!code-csharp[ControlsOverview#8](~/samples/snippets/csharp/VS_Snippets_Wpf/ControlsOverview/CSharp/AppInCode.xaml.cs#8)]
 [!code-vb[ControlsOverview#8](~/samples/snippets/visualbasic/VS_Snippets_Wpf/ControlsOverview/VisualBasic/AppInCode.xaml.vb#8)]  
  
 В следующем примере показана обработка события `Click` элемента управления <xref:System.Windows.Controls.Button>.  
  
 [!code-csharp[ControlsOverview#9](~/samples/snippets/csharp/VS_Snippets_Wpf/ControlsOverview/CSharp/AppInCode.xaml.cs#9)]
 [!code-vb[ControlsOverview#9](~/samples/snippets/visualbasic/VS_Snippets_Wpf/ControlsOverview/VisualBasic/AppInCode.xaml.vb#9)]  
  
<a name="rich_content_in_controls"></a>   
## <a name="rich-content-in-controls"></a>Форматированное содержимое в элементах управления  
 Большинство классов, наследующих от класса <xref:System.Windows.Controls.Control>, могут включать форматированное содержимое. Например, <xref:System.Windows.Controls.Label> может содержать любой объект, будь то строка, <xref:System.Windows.Controls.Image> или <xref:System.Windows.Controls.Panel>. Следующие классы обеспечивают поддержку форматированного содержимого и служат базовыми классами для большинства элементов управления в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]. 
  
- <xref:System.Windows.Controls.ContentControl>. Примеры классов, которые наследуют от этого класса: <xref:System.Windows.Controls.Label>, <xref:System.Windows.Controls.Button> и <xref:System.Windows.Controls.ToolTip>.  
  
- <xref:System.Windows.Controls.ItemsControl>. Примеры классов, которые наследуют от этого класса: <xref:System.Windows.Controls.ListBox>, <xref:System.Windows.Controls.Menu> и <xref:System.Windows.Controls.Primitives.StatusBar>. 
  
-   <xref:System.Windows.Controls.HeaderedContentControl>. Примеры классов, которые наследуют от этого класса: <xref:System.Windows.Controls.TabItem>, <xref:System.Windows.Controls.GroupBox> и <xref:System.Windows.Controls.Expander>.  
  
-   <xref:System.Windows.Controls.HeaderedItemsControl>. Примеры классов, которые наследуют от этого класса: <xref:System.Windows.Controls.MenuItem>, <xref:System.Windows.Controls.TreeViewItem> и <xref:System.Windows.Controls.ToolBar>.   

 Дополнительные сведения об этих базовых классах см. в разделе [Модель содержимого WPF](wpf-content-model.md).  
  
## <a name="see-also"></a>См. также

- [Стилизация и использование шаблонов](styling-and-templating.md)
- [Категории элементов управления](controls-by-category.md)
- [Библиотека элементов управления](control-library.md)
- [Общие сведения о шаблонах данных](../data/data-templating-overview.md)
- [Общие сведения о привязке данных](../data/data-binding-overview.md)
- [Ввод](../advanced/input-wpf.md)
- [Включение команды](../advanced/how-to-enable-a-command.md)
- [Пошаговые руководства. Создание пользовательской анимированной кнопки](walkthroughs-create-a-custom-animated-button.md)
- [Настройка элементов управления](control-customization.md)

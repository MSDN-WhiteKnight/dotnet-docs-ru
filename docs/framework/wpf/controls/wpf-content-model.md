---
title: Модель содержимого WPF
ms.date: 03/30/2017
helpviewer_keywords:
- UIElement class [WPF], displaying content
- content model [WPF], controls
- controls [WPF], displaying text
- content display [WPF], controls
- controls [WPF], formatting text
- displaying content [WPF]
- arbitrary content classes [WPF], content model
- ContentControl class [WPF], displaying content
ms.assetid: 214da5ef-547a-4cf8-9b07-4aa8a0e52cdd
ms.openlocfilehash: 4f866e0366a7781c287b3ebae7b668c2b296a5cc
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59134612"
---
# <a name="wpf-content-model"></a>Модель содержимого WPF
Windows Presentation Foundation (WPF) — это презентационная платформа, которая предоставляет множество элементов и типов, схожих с элементами управления основной целью которого является отображение различных типов содержимого. Чтобы определить, какой элемент управления использовать или от какого элемента управления выполнять наследование, вы должны понимать, какие виды объектов лучше всего может отображать конкретный элемент управления.  
  
 В этом разделе приводятся обобщенные сведения о модели содержимого для элементов управления WPF и типов, схожих с элементами управления. Модель содержимого описывает, какое содержимое может использоваться в элементе управления. Также в этом разделе перечисляются свойства содержимого для каждой модели содержимого. Свойство содержимого — это свойство, которое используется для хранения содержимого объекта.  

<a name="classes_that_contain_arbitrary_content"></a>   
## <a name="classes-that-contain-arbitrary-content"></a>Классы с произвольным содержимым  
 Некоторые элементы управления могут содержать объекты любого типа, например строку, <xref:System.DateTime> объекта, или <xref:System.Windows.UIElement> являющийся контейнером для дополнительных элементов. Например <xref:System.Windows.Controls.Button> может содержать изображение и некоторый текст; или <xref:System.Windows.Controls.CheckBox> может содержать значение <xref:System.DateTime.Now%2A?displayProperty=nameWithType>.  
  
 WPF имеется четыре класса, которые могут содержать произвольное содержимое. В следующей таблице перечислены классы, которые наследуют от <xref:System.Windows.Controls.Control>.  
  
|Класс с произвольным содержимым|Content|  
|-------------------------------------------|-------------|  
|<xref:System.Windows.Controls.ContentControl>|Один произвольный объект.|  
|<xref:System.Windows.Controls.HeaderedContentControl>|Заголовок и один элемент, которые являются произвольными объектами.|  
|<xref:System.Windows.Controls.ItemsControl>|Коллекция произвольных объектов.|  
|<xref:System.Windows.Controls.HeaderedItemsControl>|Заголовок и коллекция элементов, являющиеся произвольными объектами.|  
  
 Элементы управления, производные от этих классов, могут содержать тот же тип содержимого и обрабатывать содержимое аналогичным образом. На следующем рисунке показан один элемент управления из каждой модели содержимого, который содержит изображение и некоторый текст:  
  
 ![Снимок экрана, показывающий четыре различных элементов управления, один из каждой модели содержимого.](./media/wpf-content-model/control-content-model-image-text.png)  
  
### <a name="controls-that-contain-a-single-arbitrary-object"></a>Элементы управления, содержащие один произвольный объект  
 <xref:System.Windows.Controls.ContentControl> Класса содержит один элемент произвольного содержимого. Его свойство содержимого — <xref:System.Windows.Controls.ContentControl.Content%2A>. Следующие элементы управления наследуют <xref:System.Windows.Controls.ContentControl> и используют его модель содержимого:  
  
-   <xref:System.Windows.Controls.Button>  
  
-   <xref:System.Windows.Controls.Primitives.ButtonBase>  
  
-   <xref:System.Windows.Controls.CheckBox>  
  
-   <xref:System.Windows.Controls.ComboBoxItem>  
  
-   <xref:System.Windows.Controls.ContentControl>  
  
-   <xref:System.Windows.Controls.Frame>  
  
-   <xref:System.Windows.Controls.GridViewColumnHeader>  
  
-   <xref:System.Windows.Controls.GroupItem>  
  
-   <xref:System.Windows.Controls.Label>  
  
-   <xref:System.Windows.Controls.ListBoxItem>  
  
-   <xref:System.Windows.Controls.ListViewItem>  
  
-   <xref:System.Windows.Navigation.NavigationWindow>  
  
-   <xref:System.Windows.Controls.RadioButton>  
  
-   <xref:System.Windows.Controls.Primitives.RepeatButton>  
  
-   <xref:System.Windows.Controls.ScrollViewer>  
  
-   <xref:System.Windows.Controls.Primitives.StatusBarItem>  
  
-   <xref:System.Windows.Controls.Primitives.ToggleButton>  
  
-   <xref:System.Windows.Controls.ToolTip>  
  
-   <xref:System.Windows.Controls.UserControl>  
  
-   <xref:System.Windows.Window>  
  
 На следующем рисунке показано четыре кнопки, <xref:System.Windows.Controls.ContentControl.Content%2A> присваивается строка <xref:System.DateTime> объекта, <xref:System.Windows.Shapes.Rectangle>и <xref:System.Windows.Controls.Panel> , содержащий <xref:System.Windows.Shapes.Ellipse> и <xref:System.Windows.Controls.TextBlock>:  
  
 ![Снимок экрана, показаны четыре кнопки с различными типами содержимого.](./media/wpf-content-model/control-content-model-buttons.png)  
  
 Например, как задать <xref:System.Windows.Controls.ContentControl.Content%2A> свойство, см. в разделе <xref:System.Windows.Controls.ContentControl>.  
  
### <a name="controls-that-contain-a-header-and-a-single-arbitrary-object"></a>Элементы управления, содержащие заголовок и один произвольный объект  
 <xref:System.Windows.Controls.HeaderedContentControl> Класс наследует от <xref:System.Windows.Controls.ContentControl> и отображает содержимое с заголовком. Он наследует свойство content <xref:System.Windows.Controls.ContentControl.Content%2A>, из <xref:System.Windows.Controls.ContentControl> и определяет <xref:System.Windows.Controls.HeaderedContentControl.Header%2A> свойство, имеющее тип <xref:System.Object>; таким образом, оба могут быть произвольными объектами.  
  
 Следующие элементы управления наследуют <xref:System.Windows.Controls.HeaderedContentControl> и используют его модель содержимого:  
  
-   <xref:System.Windows.Controls.Expander>  
  
-   <xref:System.Windows.Controls.GroupBox>  
  
-   <xref:System.Windows.Controls.TabItem>  
  
 На следующем рисунке показаны два <xref:System.Windows.Controls.TabItem> объектов. Первый <xref:System.Windows.Controls.TabItem> имеет <xref:System.Windows.UIElement> объектов как <xref:System.Windows.Controls.HeaderedContentControl.Header%2A> и <xref:System.Windows.Controls.ContentControl.Content%2A>. <xref:System.Windows.Controls.HeaderedContentControl.Header%2A> Присваивается <xref:System.Windows.Controls.StackPanel> , содержащий <xref:System.Windows.Shapes.Ellipse> и <xref:System.Windows.Controls.TextBlock>. <xref:System.Windows.Controls.ContentControl.Content%2A> Присваивается <xref:System.Windows.Controls.StackPanel> , содержащий <xref:System.Windows.Controls.TextBlock> и <xref:System.Windows.Controls.Label>. Второй <xref:System.Windows.Controls.TabItem> имеет строку в <xref:System.Windows.Controls.HeaderedContentControl.Header%2A> и <xref:System.Windows.Controls.TextBlock> в <xref:System.Windows.Controls.ContentControl.Content%2A>.  
  
 ![TabControl, который использует различные типы в свойстве Header.](./media/wpf-content-model/control-content-model-tab.png)  
  
 Пример создания <xref:System.Windows.Controls.TabItem> объектов, см. в разделе <xref:System.Windows.Controls.HeaderedContentControl>.  
  
### <a name="controls-that-contain-a-collection-of-arbitrary-objects"></a>Элементы управления, содержащие коллекцию произвольных объектов  
 <xref:System.Windows.Controls.ItemsControl> Класс наследует от <xref:System.Windows.Controls.Control> и может содержать несколько элементов, таких как строки, объекты или другие элементы. Его свойства содержимого — <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A> и <xref:System.Windows.Controls.ItemsControl.Items%2A>. <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A> обычно используется для заполнения <xref:System.Windows.Controls.ItemsControl> со сбором данных. Если вы не хотите использовать коллекцию для заполнения <xref:System.Windows.Controls.ItemsControl>, можно добавить элементы с помощью <xref:System.Windows.Controls.ItemsControl.Items%2A> свойство.  
  
 Следующие элементы управления наследуют <xref:System.Windows.Controls.ItemsControl> и используют его модель содержимого:  
  
-   <xref:System.Windows.Controls.Menu>  
  
-   <xref:System.Windows.Controls.Primitives.MenuBase>  
  
-   <xref:System.Windows.Controls.ContextMenu>  
  
-   <xref:System.Windows.Controls.ComboBox>  
  
-   <xref:System.Windows.Controls.ItemsControl>  
  
-   <xref:System.Windows.Controls.ListBox>  
  
-   <xref:System.Windows.Controls.ListView>  
  
-   <xref:System.Windows.Controls.TabControl>  
  
-   <xref:System.Windows.Controls.TreeView>  
  
-   <xref:System.Windows.Controls.Primitives.Selector>  
  
-   <xref:System.Windows.Controls.Primitives.StatusBar>  
  
 На следующем рисунке показано <xref:System.Windows.Controls.ListBox> , содержащий следующие типы элементов:  
  
-   Строка.  
  
-   Объект <xref:System.DateTime>.  
  
-   Объект <xref:System.Windows.UIElement>.  
  
-   Объект <xref:System.Windows.Controls.Panel> , содержащий <xref:System.Windows.Shapes.Ellipse> и <xref:System.Windows.Controls.TextBlock>.  
  
 ![Снимок экрана с ListBox с четырьмя типами содержимого.](./media/wpf-content-model/control-content-model-listbox.png)  
  
### <a name="controls-that-contain-a-header-and-a-collection-of-arbitrary-objects"></a>Элементы управления, содержащие заголовок и коллекцию произвольных объектов  
 <xref:System.Windows.Controls.HeaderedItemsControl> Класс наследует от <xref:System.Windows.Controls.ItemsControl> и может содержать несколько элементов, таких как строки, объекты, или другие элементы и заголовок. Он наследует <xref:System.Windows.Controls.ItemsControl> свойства, содержимого <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A>, и <xref:System.Windows.Controls.ItemsControl.Items%2A>, и он определяет <xref:System.Windows.Controls.HeaderedItemsControl.Header%2A> свойство, которое может быть произвольный объект.  
  
 Следующие элементы управления наследуют <xref:System.Windows.Controls.HeaderedItemsControl> и используют его модель содержимого:  
  
-   <xref:System.Windows.Controls.MenuItem>  
  
-   <xref:System.Windows.Controls.ToolBar>  
  
-   <xref:System.Windows.Controls.TreeViewItem>  
  
<a name="classes_that_contain_a_collection_of_uielement_objects"></a>   
## <a name="classes-that-contain-a-collection-of-uielement-objects"></a>Классы, содержащие коллекцию объектов UIElement  
 <xref:System.Windows.Controls.Panel> Класс размещение и упорядочивание дочерних <xref:System.Windows.UIElement> объектов. Его свойство содержимого — <xref:System.Windows.Controls.Panel.Children%2A>.  
  
 Следующие классы наследуют от <xref:System.Windows.Controls.Panel> класса и используют его модель содержимого:  
  
-   <xref:System.Windows.Controls.Canvas>  
  
-   <xref:System.Windows.Controls.DockPanel>  
  
-   <xref:System.Windows.Controls.Grid>  
  
-   <xref:System.Windows.Controls.Primitives.TabPanel>  
  
-   <xref:System.Windows.Controls.Primitives.ToolBarOverflowPanel>  
  
-   <xref:System.Windows.Controls.Primitives.ToolBarPanel>  
  
-   <xref:System.Windows.Controls.Primitives.UniformGrid>  
  
-   <xref:System.Windows.Controls.StackPanel>  
  
-   <xref:System.Windows.Controls.VirtualizingPanel>  
  
-   <xref:System.Windows.Controls.VirtualizingStackPanel>  
  
-   <xref:System.Windows.Controls.WrapPanel>  
  
 Дополнительные сведения см. в разделе [Общие сведения о панелях](panels-overview.md).  
  
<a name="classes_that_affects_the_appearance_of_a_uielement"></a>   
## <a name="classes-that-affect-the-appearance-of-a-uielement"></a>Классы, влияющие на внешний вид объекта UIElement  
 <xref:System.Windows.Controls.Decorator> Класс применяет визуальные эффекты или вокруг один дочерний элемент <xref:System.Windows.UIElement>. Его свойство содержимого — <xref:System.Windows.Controls.Decorator.Child%2A>. Следующие классы наследуют от <xref:System.Windows.Controls.Decorator> и используют его модель содержимого:  
  
-   <xref:System.Windows.Documents.AdornerDecorator>  
  
-   <xref:System.Windows.Controls.Border>  
  
-   <xref:System.Windows.Controls.Primitives.BulletDecorator>  
  
-   <xref:Microsoft.Windows.Themes.ButtonChrome>  
  
-   <xref:Microsoft.Windows.Themes.ClassicBorderDecorator>  
  
-   <xref:System.Windows.Controls.InkPresenter>  
  
-   <xref:Microsoft.Windows.Themes.ListBoxChrome>  
  
-   <xref:Microsoft.Windows.Themes.SystemDropShadowChrome>  
  
-   <xref:System.Windows.Controls.Viewbox>  
  
 На следующем рисунке показано <xref:System.Windows.Controls.TextBox> с (снабжен) <xref:System.Windows.Controls.Border> вокруг него.  
  
 ![TextBox с черной границей](./media/layout-border-around-textbox.png "Layout_Border_around_TextBox")  
Элемент управления TextBlock с границей вокруг него  
  
<a name="classes_that_provides_visual_feedback_about_a_uielement"></a>   
## <a name="classes-that-provide-visual-feedback-about-a-uielement"></a>Классы, предоставляющие визуальную обратную связь об объекте UIElement  
 <xref:System.Windows.Documents.Adorner> Предоставляет пользователю визуальные подсказки. Например, использовать <xref:System.Windows.Documents.Adorner> для добавления функциональных обработчиков к элементам или предоставления сведения о состоянии об элементе управления. <xref:System.Windows.Documents.Adorner> Класс предоставляет платформу, которые можно создавать собственные декоративные элементы. WPF не предоставляет никаких реализованных декоративных элементов. Дополнительные сведения см. в разделе [Общие сведения о декоративных элементах](adorners-overview.md).  
  
<a name="classes_that_enable_users_to_enter_text"></a>   
## <a name="classes-that-enable-users-to-enter-text"></a>Классы, позволяющие пользователям вводить текст  
 WPF предоставляет три основных элемента управления, которые позволяют пользователям вводить текст. Каждый из этих элементов управления отображает текст по-разному. В следующей таблице приведены эти три элемента управления с поддержкой ввода текста, их возможности по отображению текста и свойства, которые содержат текст этого элемента управления.  
  
|Элемент управления|В каком виде отображается текст|Свойство содержимого|  
|-------------|--------------------------|----------------------|  
|<xref:System.Windows.Controls.TextBox>|Обычный текст|<xref:System.Windows.Controls.TextBox.Text%2A>|  
|<xref:System.Windows.Controls.RichTextBox>|Форматированный текст|<xref:System.Windows.Controls.RichTextBox.Document%2A>|  
|<xref:System.Windows.Controls.PasswordBox>|Скрытый текст (символы скрыты)|<xref:System.Windows.Controls.PasswordBox.Password%2A>|  
  
<a name="classes_that_display_text"></a>   
## <a name="classes-that-display-your-text"></a>Классы, отображающие пользовательский текст  
 Некоторые классы могут использоваться для отображения простого или форматированного текста. Можно использовать <xref:System.Windows.Controls.TextBlock> для отображения текста небольшого объема. Если вы хотите отображать большие объемы текста, используйте <xref:System.Windows.Controls.FlowDocumentReader>, <xref:System.Windows.Controls.FlowDocumentPageViewer>, или <xref:System.Windows.Controls.FlowDocumentScrollViewer> элементов управления.  
  
 <xref:System.Windows.Controls.TextBlock> Имеет два свойства содержимого: <xref:System.Windows.Controls.TextBlock.Text%2A> и <xref:System.Windows.Controls.TextBlock.Inlines%2A>. Если вы хотите отображать текст с единообразным форматированием <xref:System.Windows.Controls.TextBlock.Text%2A> свойство является оптимальным решением. Если вы планируете использовать разное форматирование текста, используйте <xref:System.Windows.Controls.TextBlock.Inlines%2A> свойство. <xref:System.Windows.Controls.TextBlock.Inlines%2A> Свойство — это коллекция <xref:System.Windows.Documents.Inline> объекты, которые определяют способ форматирования текста.  
  
 В следующей таблице перечислены свойства содержимого для <xref:System.Windows.Controls.FlowDocumentReader>, <xref:System.Windows.Controls.FlowDocumentPageViewer>, и <xref:System.Windows.Controls.FlowDocumentScrollViewer> классы.  
  
|Элемент управления|Свойство содержимого|Тип свойства содержимого|  
|-------------|----------------------|---------------------------|  
|<xref:System.Windows.Controls.FlowDocumentPageViewer>|Document|<xref:System.Windows.Documents.IDocumentPaginatorSource>|  
|<xref:System.Windows.Controls.FlowDocumentReader>|Document|<xref:System.Windows.Documents.FlowDocument>|  
|<xref:System.Windows.Controls.FlowDocumentScrollViewer>|Document|<xref:System.Windows.Documents.FlowDocument>|  
  
 <xref:System.Windows.Documents.FlowDocument> Реализует <xref:System.Windows.Documents.IDocumentPaginatorSource> интерфейс; таким образом, все три класса могут принимать <xref:System.Windows.Documents.FlowDocument> как содержимое.  
  
<a name="classes_that_format_text"></a>   
## <a name="classes-that-format-your-text"></a>Классы, выполняющие форматирование пользовательского текста  
 <xref:System.Windows.Documents.TextElement> и связанные с ним классы позволяют вам форматировать текст. <xref:System.Windows.Documents.TextElement> объекты содержат и форматируют текст в <xref:System.Windows.Controls.TextBlock> и <xref:System.Windows.Documents.FlowDocument> объектов. Два основных типа <xref:System.Windows.Documents.TextElement> объекты являются <xref:System.Windows.Documents.Block> элементов и <xref:System.Windows.Documents.Inline> элементов. Объект <xref:System.Windows.Documents.Block> представляет блок текста, например, абзац или список. <xref:System.Windows.Documents.Inline> Элемент представляет собой часть текста в блоке. Многие <xref:System.Windows.Documents.Inline> классы задают форматирование текста, к которому они применяются. Каждый <xref:System.Windows.Documents.TextElement> имеет собственную модель содержимого. Подробнее см. в разделе [Общие сведения о модели содержимого TextElement](../advanced/textelement-content-model-overview.md).  
  
## <a name="see-also"></a>См. также

- [Дополнительно](../advanced/index.md)

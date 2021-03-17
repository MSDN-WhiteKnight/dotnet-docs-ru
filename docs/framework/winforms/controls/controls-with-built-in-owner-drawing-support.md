---
title: Элементы управления Windows Forms со встроенной поддержки рисования владельцем
ms.date: 03/30/2017
helpviewer_keywords:
- drawing [Windows Forms], owner
- drawing [Windows Forms], custom
- controls [Windows Forms], changing appearance
- custom drawing
- owner drawing
ms.assetid: 3823d01e-9610-43e6-864d-99f9b7c2b351
ms.openlocfilehash: 1807170b2f5df2333ec3b271a11f9b929c1e7993
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59087187"
---
# <a name="controls-with-built-in-owner-drawing-support"></a>Элементы управления Windows Forms со встроенной поддержки рисования владельцем
Рисование владельцем в Windows Forms, иначе называемое пользовательским рисованием, — это способ изменения внешнего вида определенных элементов управления.  
  
> [!NOTE]
>  Слово «control» этого раздела используется для обозначения классов, производные от <xref:System.Windows.Forms.Control> или <xref:System.ComponentModel.Component>.  
  
 Как правило, Windows обрабатывает Рисование автоматически, используя параметры свойства, такие как <xref:System.Windows.Forms.Control.BackColor%2A> для определения внешнего вида элемента управления. При рисовании владельцем можно перехватить процесс рисования, изменив элементы внешнего вида, которые недоступны при использовании свойств. Например, многие элементы управления позволяют задавать цвет отображаемого текста, но вы ограничены одним цветом. Рисование владельцем позволяет, например, отображать часть текста черным цветом, а другую часть — красным.  
  
 На практике рисование владельцем аналогично рисованию графических элементов в форме. Например, можно использовать графические методы в обработчике для формы <xref:System.Windows.Forms.Control.Paint> событий для эмуляции `ListBox` элемента управления, но вам пришлось бы писать собственный код для обработки взаимодействия с пользователем. При рисовании владельцем элемент управления использует ваш код для рисования своего содержимого, но в остальном сохраняет все свои внутренние возможности. Графические методы можно использовать для рисования каждого элемента в элементе управления или для настройки некоторых аспектов каждого элемента при использовании внешнего вида по умолчанию для других аспектов каждого элемента.  
  
## <a name="owner-drawing-in-windows-forms-controls"></a>Рисование владельцем в элементах управления Windows Forms  
 Чтобы выполнить рисование владельцем в элементах управления, поддерживающих эту функцию, вы, как правило, задаете одно свойство и обрабатываете одно или несколько событий.  
  
 Большинство элементов управления, поддерживающих рисование владельцем, имеют свойство `OwnerDraw` или `DrawMode`, указывающее, будет ли элемент управления вызывать связанные с рисованием события при рисовании себя.  
  
 Элементы управления, которые не имеют свойства `OwnerDraw` или `DrawMode`, включают элемент управления `DataGridView`, предоставляющий происходящие автоматически события рисования, и элемент управления `ToolStrip`, рисуемый с помощью внешнего класса отрисовки, имеющего собственные события, связанные с рисованием.  
  
 Существует много различных типов событий рисования, однако типичное событие рисования возникает для рисования отдельного элемента внутри элемента управления. Обработчик событий получает объект `EventArgs`, который содержит сведения о рисуемом элементе, и инструменты, которые можно использовать для рисования. Например, этот объект обычно содержит номер индекса элемента в его родительской коллекции <xref:System.Drawing.Rectangle> указывает границы отображения элемента и <xref:System.Drawing.Graphics> объект для вызова методов рисования. Для некоторых событий объект `EventArgs` предоставляет дополнительные сведения об элементе и методах, которые можно вызвать для рисования некоторых аспектов элемента по умолчанию, таких как фон или прямоугольник фокуса.  
  
 Чтобы создать элемент управления для повторного использования, содержащий настройки рисования владельцем, создайте новый класс, производный от класса элемента управления, который поддерживает рисование владельцем. Вместо обработки событий рисования включите код рисования владельцем в переопределения для соответствующего метода или методов `On`*ИмяСобытия* в новом классе. Убедитесь в том, что в этом случае вызывается метод или методы `On`*ИмяСобытия* базового класса, чтобы пользователи элемента управления могли обрабатывать события рисования владельцем и выполнять дополнительные настройки.  
  
 Следующие элементы управления Windows Forms поддерживают рисование владельцем во всех версиях .NET Framework.  
  
-   <xref:System.Windows.Forms.ListBox>  
  
-   <xref:System.Windows.Forms.ComboBox>  
  
-   <xref:System.Windows.Forms.MenuItem> (используемые <xref:System.Windows.Forms.MainMenu> и <xref:System.Windows.Forms.ContextMenu>)  
  
-   <xref:System.Windows.Forms.TabControl>  
  
 Следующие элементы управления поддерживают рисование владельцем только в [!INCLUDE[dnprdnext](../../../../includes/dnprdnext-md.md)].  
  
-   <xref:System.Windows.Forms.ToolTip>  
  
-   <xref:System.Windows.Forms.ListView>  
  
-   <xref:System.Windows.Forms.TreeView>  
  
 Следующие элементы управления поддерживают рисование владельцем и являются новыми в [!INCLUDE[dnprdnext](../../../../includes/dnprdnext-md.md)].  
  
-   <xref:System.Windows.Forms.DataGridView>  
  
-   <xref:System.Windows.Forms.ToolStrip>  
  
 В следующих разделах приводятся дополнительные сведения для каждого из этих элементов управления.  
  
### <a name="listbox-and-combobox-controls"></a>Элементы управления ListBox и ComboBox  
 <xref:System.Windows.Forms.ListBox> И <xref:System.Windows.Forms.ComboBox> элементы управления позволяют рисовать отдельные элементы в элементе управления одного или разного размера.  
  
> [!NOTE]
>  Несмотря на то что <xref:System.Windows.Forms.CheckedListBox> элемент управления является производным от <xref:System.Windows.Forms.ListBox> элемента управления, он не поддерживает рисование владельцем.  
  
 Для рисования каждого элемента тот же размер, задайте `DrawMode` свойства <xref:System.Windows.Forms.DrawMode.OwnerDrawFixed> и обрабатывать `DrawItem` событий.  
  
 Для рисования каждого элемента с использованием другого размера, задайте `DrawMode` свойства <xref:System.Windows.Forms.DrawMode.OwnerDrawVariable> и обработать `MeasureItem` и `DrawItem` события. Событие `MeasureItem` позволяет указать размер элемента, прежде чем возникнет событие `DrawItem` для этого элемента.  
  
 Дополнительные сведения, включая примеры кода, см. в следующих разделах.  
  
-   <xref:System.Windows.Forms.ListBox.DrawMode%2A?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Forms.ListBox.MeasureItem?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Forms.ListBox.DrawItem?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Forms.ComboBox.DrawMode%2A?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Forms.ComboBox.MeasureItem?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Forms.ComboBox.DrawItem?displayProperty=nameWithType>  
  
-   [Практическое руководство. Индивидуальное форматирование строк, отображаемых в элементе управления ComboBox](how-to-create-variable-sized-text-in-a-combobox-control.md)  
  
### <a name="menuitem-component"></a>Компонент MenuItem  
 <xref:System.Windows.Forms.MenuItem> Компонент представляет собой отдельный пункт меню в <xref:System.Windows.Forms.MainMenu> или <xref:System.Windows.Forms.ContextMenu> компонента.  
  
 Для рисования <xref:System.Windows.Forms.MenuItem>, задайте его `OwnerDraw` свойства `true` и обработать его `DrawItem` событий. Чтобы изменять размер элемента меню перед возникновением события `DrawItem`, требуется обработка события `MeasureItem` элемента.  
  
 Дополнительные сведения, включая примеры кода, см. в следующих разделах справочника.  
  
-   <xref:System.Windows.Forms.MenuItem.OwnerDraw%2A?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Forms.MenuItem.DrawItem?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Forms.MenuItem.MeasureItem?displayProperty=nameWithType>  
  
### <a name="tabcontrol-control"></a>Элемент управления TabControl  
 <xref:System.Windows.Forms.TabControl> Элемент управления позволяет рисовать отдельные вкладки в элементе управления. Рисование владельцем влияет только на вкладки; <xref:System.Windows.Forms.TabPage> содержимое не затрагиваются.  
  
 Для рисования каждой вкладки <xref:System.Windows.Forms.TabControl>, задайте `DrawMode` свойства <xref:System.Windows.Forms.TabDrawMode.OwnerDrawFixed> и обрабатывать `DrawItem` событий. Это событие возникает один раз для каждой вкладки, только если вкладка видна в элементе управления.  
  
 Дополнительные сведения, включая примеры кода, см. в следующих разделах справочника.  
  
-   <xref:System.Windows.Forms.TabControl.DrawMode%2A?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Forms.TabControl.DrawItem?displayProperty=nameWithType>  
  
### <a name="tooltip-component"></a>Компонент ToolTip  
 <xref:System.Windows.Forms.ToolTip> Компонент позволяет рисовать всю подсказку, когда она появится.  
  
 Для рисования <xref:System.Windows.Forms.ToolTip>, задайте его `OwnerDraw` свойства `true` и обработать его `Draw` событий. Чтобы настроить размер <xref:System.Windows.Forms.ToolTip> перед `Draw` происходит событие, обрабатывать `Popup` событий и набор <xref:System.Windows.Forms.PopupEventArgs.ToolTipSize%2A> свойство в обработчике событий.  
  
 Дополнительные сведения, включая примеры кода, см. в следующих разделах справочника.  
  
-   <xref:System.Windows.Forms.ToolTip.OwnerDraw%2A?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Forms.ToolTip.Draw?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Forms.ToolTip.Popup?displayProperty=nameWithType>  
  
### <a name="listview-control"></a>Элемент управления ListView  
 <xref:System.Windows.Forms.ListView> Управления позволяет рисовать отдельные элементы, подпункты и заголовки столбцов в элементе управления.  
  
 Чтобы включить рисование владельцем в элементе управления, задайте для свойства `OwnerDraw` значение `true`.  
  
 Для рисования каждого пункта в элементе управления обработайте событие `DrawItem`.  
  
 Для рисования каждого подпункта или столбца заголовка в элементе управления при <xref:System.Windows.Forms.ListView.View%2A> свойству <xref:System.Windows.Forms.View.Details>, обрабатывать `DrawSubItem` и `DrawColumnHeader` события.  
  
 Дополнительные сведения, включая примеры кода, см. в следующих разделах справочника.  
  
-   <xref:System.Windows.Forms.ListView.OwnerDraw%2A?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Forms.ListView.DrawItem?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Forms.ListView.DrawSubItem?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Forms.ListView.DrawColumnHeader?displayProperty=nameWithType>  
  
### <a name="treeview-control"></a>Элемент управления TreeView  
 <xref:System.Windows.Forms.TreeView> Элемент управления позволяет рисовать отдельные узлы в элементе управления.  
  
 Чтобы рисовать только текст, отображаемый в каждом узле, задайте `DrawMode` свойства <xref:System.Windows.Forms.TreeViewDrawMode.OwnerDrawText> и обрабатывать `DrawNode` событий для рисования текста.  
  
 Чтобы рисовать все элементы каждого узла, задайте `DrawMode` свойства <xref:System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll> и обрабатывать `DrawNode` событий для рисования любых требуемых, такие как текст, значки, флажки, знаки плюс и минус и линий, соединяющих узлы элементов.  
  
 Дополнительные сведения, включая примеры кода, см. в следующих разделах справочника.  
  
-   <xref:System.Windows.Forms.TreeView.DrawMode%2A?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Forms.TreeView.DrawNode?displayProperty=nameWithType>  
  
### <a name="datagridview-control"></a>Элемент управления DataGridView  
 <xref:System.Windows.Forms.DataGridView> Управления позволяет рисовать отдельные ячейки и строки в элементе управления.  
  
 Для рисования отдельных ячеек обработайте событие `CellPainting`.  
  
 Для рисования отдельных строк или элементов строк обработайте одно или оба события `RowPrePaint` и `RowPostPaint`. Событие `RowPrePaint` возникает до рисования ячеек в строке, а событие `RowPostPaint` — после их рисования. Можно обрабатывать оба события и событие `CellPainting` для рисования фона строки, отдельных ячеек и переднего плана строки по отдельности. Кроме того, можно предоставить особые настройки в нужных местах и использовать отображение по умолчанию для других элементов строки.  
  
 Дополнительные сведения, включая примеры кода, см. в следующих разделах.  
  
-   <xref:System.Windows.Forms.DataGridView.CellPainting>  
  
-   <xref:System.Windows.Forms.DataGridView.RowPrePaint>  
  
-   <xref:System.Windows.Forms.DataGridView.RowPostPaint>  
  
-   [Практическое руководство. Настройка внешнего вида ячеек элемента управления DataGridView в Windows Forms](customize-the-appearance-of-cells-in-the-datagrid.md)  
  
-   [Практическое руководство. Настройка внешнего вида строк элемента управления DataGridView в Windows Forms](customize-the-appearance-of-rows-in-the-datagrid.md)  
  
### <a name="toolstrip-control"></a>Элемент управления ToolStrip  
 <xref:System.Windows.Forms.ToolStrip> и производные элементы управления позволяют настраивать все аспекты их внешнего вида.  
  
 Для обеспечения пользовательской отрисовки для <xref:System.Windows.Forms.ToolStrip> элементов управления `Renderer` свойство <xref:System.Windows.Forms.ToolStrip>, <xref:System.Windows.Forms.ToolStripManager>, <xref:System.Windows.Forms.ToolStripPanel>, или <xref:System.Windows.Forms.ToolStripContentPanel> для `ToolStripRenderer` и обработать один или несколько из большого числа событий рисования, предоставляемых `ToolStripRenderer` класса. Можно также задать `Renderer` свойство к экземпляру свой собственный класс производным от `ToolStripRenderer`, <xref:System.Windows.Forms.ToolStripProfessionalRenderer>, или <xref:System.Windows.Forms.ToolStripSystemRenderer> , который реализует или переопределяет определенные `On` *EventName* методы.  
  
 Дополнительные сведения, включая примеры кода, см. в следующих разделах.  
  
-   <xref:System.Windows.Forms.ToolStripRenderer>  
  
-   [Практическое руководство. Создание и определение пользовательского средства визуализации для элемента управления ToolStrip в Windows Forms](create-and-set-a-custom-renderer-for-the-toolstrip-control-in-wf.md)  
  
-   [Практическое руководство. Пользовательская прорисовка элемента управления ToolStrip](how-to-custom-draw-a-toolstrip-control.md)  
  
## <a name="see-also"></a>См. также

- [Элементы управления для использования в формах Windows Forms](controls-to-use-on-windows-forms.md)

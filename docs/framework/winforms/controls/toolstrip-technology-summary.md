---
title: Технологии, положенные в основу работы элемента управления ToolStrip
ms.date: 03/30/2017
helpviewer_keywords:
- ToolStrip control [Windows Forms], technology summary
- status bars [Windows Forms], technology summary
- toolbars [Windows Forms], technology summary
- menus [Windows Forms], technology summary
ms.assetid: e8d61973-7af9-429f-9df5-05a899c15a7b
ms.openlocfilehash: b6537faa3be7ee28a934927fc95100a34a64e176
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59120967"
---
# <a name="toolstrip-technology-summary"></a>Технологии, положенные в основу работы элемента управления ToolStrip
В этом разделе содержится сводная информация о системе управления `ToolStrip` и классах, поддерживающих ее использование.  
  
 Элемент управления `ToolStrip` и связанные с ним классы обеспечивают комплексное решение для создания панелей инструментов, строк состояния и меню.  
  
## <a name="namespaces"></a>Пространства имен  
 <xref:System.Windows.Forms?displayProperty=nameWithType>  
  
## <a name="background"></a>Фон  
 Панели инструментов с расширенными возможностями, имеющие единообразный и профессиональный вид и поведение, можно создавать с помощью элемента управления `ToolStrip` и связанных с ним классов. Элемент управления `ToolStrip` и классы имеют следующие усовершенствования по сравнению с предыдущими элементами управления.  
  
-   Более согласованная модель событий.  
  
-   Более согласованное поведение во время разработки, есть списки задач и редакторы коллекций элементов.  
  
-   Пользовательская отрисовка благодаря классам `ToolStripManager` и `ToolStripRenderer`.  
  
-   Встроенное нависание (совместное использование горизонтального или вертикального пространства в области инструментов при прикреплении) благодаря классам `ToolStripContainer` и `ToolStripPanel`.  
  
-   Изменение порядка следования элементов с помощью свойства <xref:System.Windows.Forms.ToolStrip.AllowItemReorder%2A> во время разработки и во время выполнения.  
  
-   Перенос элементов в меню области переполнения с помощью свойства <xref:System.Windows.Forms.ToolStrip.CanOverflow%2A>.  
  
-   Полностью настраиваемое расположение элемента управления благодаря классам `ToolStripContainer`, `ToolStripPanel` и `ToolStripContentPanel`.  
  
-   Размещение `ToolStrip` с помощью стандартных или пользовательских элементов управления `ToolStripControlHost`.  
  
-   Объединение элементов управления `ToolStrip` с помощью `ToolStripPanel`.  
  
 `ToolStrip` — это расширяемый базовый класс для `MenuStrip`, `ContextMenuStrip`, и `StatusStrip`. Эти элементы управления являются контейнерами <xref:System.Windows.Forms.ToolStripItem>, которые наследуют общие характеристики поведения и обработки событий, расширяя их таким образом, чтобы каждая реализация использовала ту функциональность, которая для нее подходит. Элементы управления, которые являются производными от <xref:System.Windows.Forms.ToolStripItem>, перечислены в следующей таблице. Базовый класс `ToolStrip` обрабатывает отрисовку, пользовательский ввод и события перетаскивания этих элементов управления.  
  
 Элементы управления `ToolStrip`, `MenuStrip`, `ContextMenuStrip` и `StatusStrip` заменяют панель инструментов, меню, контекстное меню и элементы управления строки состояния предыдущих версий, в то же время те элементы управления сохраняются для обеспечения обратной совместимости.  
  
## <a name="toolstrip-classes-at-a-glance"></a>Краткий обзор классов элемента управления ToolStrip  
 В следующей таблице показаны классы ToolStrip, сгруппированные по технологическим областям.  
  
|Технологическая область|Класс|  
|---------------------|-----------|  
|Контейнеры панели инструментов, меню и строки состояния|<xref:System.Windows.Forms.ToolStrip><br /><br /> <xref:System.Windows.Forms.MenuStrip><br /><br /> <xref:System.Windows.Forms.ContextMenuStrip><br /><br /> <xref:System.Windows.Forms.StatusStrip><br /><br /> <xref:System.Windows.Forms.ToolStripDropDownMenu>|  
|Элементы ToolStrip|<xref:System.Windows.Forms.ToolStripLabel><br /><br /> <xref:System.Windows.Forms.ToolStripDropDownItem><br /><br /> <xref:System.Windows.Forms.ToolStripMenuItem><br /><br /> <xref:System.Windows.Forms.ToolStripButton><br /><br /> <xref:System.Windows.Forms.ToolStripStatusLabel><br /><br /> <xref:System.Windows.Forms.ToolStripSeparator><br /><br /> <xref:System.Windows.Forms.ToolStripControlHost><br /><br /> <xref:System.Windows.Forms.ToolStripComboBox><br /><br /> <xref:System.Windows.Forms.ToolStripTextBox><br /><br /> <xref:System.Windows.Forms.ToolStripProgressBar><br /><br /> <xref:System.Windows.Forms.ToolStripDropDownButton><br /><br /> <xref:System.Windows.Forms.ToolStripSplitButton>|  
|Расположение|<xref:System.Windows.Forms.ToolStripContainer><br /><br /> <xref:System.Windows.Forms.ToolStripContentPanel><br /><br /> <xref:System.Windows.Forms.ToolStripPanel>|  
|Представление и отрисовка|<xref:System.Windows.Forms.ToolStripManager><br /><br /> <xref:System.Windows.Forms.ToolStripRenderer><br /><br /> <xref:System.Windows.Forms.ToolStripProfessionalRenderer><br /><br /> <xref:System.Windows.Forms.ToolStripRenderMode><br /><br /> <xref:System.Windows.Forms.ToolStripManagerRenderMode>|  
  
## <a name="toolstrip-design-time-features"></a>Компоненты времени разработки элемента управления ToolStrip  
 Семейство элементов управления <xref:System.Windows.Forms.ToolStrip> предоставляет богатый набор средств и шаблонов для реализации локального редактирования и определения базиса пользовательского интерфейса, благодаря чему можно быстро создать работающее приложение.  
  
### <a name="task-dialog-boxes"></a>Диалоговые окна задач  
 Если в конструкторе Visual Studio щелкнуть смарт-тег на элементе управления, откроется список задач, обеспечивающий удобный доступ ко многим часто используемым командам.  
  
-   [Диалоговое окно задач MenuStrip](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/ms233645(v=vs.100))  
  
-   [Диалоговое окно задач ToolStrip](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/ms233648(v=vs.100))  
  
-   [Диалоговое окно задач ContextMenuStrip](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/ms233646(v=vs.100))  
  
-   [Диалоговое окно задач StatusStrip](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/ms233642(v=vs.100))  
  
-   [Диалоговое окно задач ToolStripContainer](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/ms233647(v=vs.100))  
  
### <a name="items-collection-editors"></a>Редакторы коллекций элементов  
 В Visual Studio, щелкнув **изменение элементов** в задаче списке или щелкните правой кнопкой мыши элемент управления и выберите **изменение элементов** в контекстном меню, откроется редактор коллекции для элемента управления. Редакторы коллекций позволяют добавлять, удалять и изменять порядок следования элементов, которые содержит данный элемент управления. Можно также просмотреть и изменить свойства элемента управления и его элементов.  
  
-   [Редактор коллекции элементов MenuStrip](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/ms233625(v=vs.100))  
  
-   [Редактор коллекции элементов StatusStrip](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/ms233631(v=vs.100))  
  
-   [Редактор коллекции элементов ContextMenuStrip](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/ms233641(v=vs.100))  
  
-   [Редактор набора элементов ToolStrip](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/ms233643(v=vs.100))  
  
## <a name="hosting-controls"></a>Размещение элементов управления  
 Класс <xref:System.Windows.Forms.ToolStripControlHost> предоставляет встроенные оболочки для элементов управления <xref:System.Windows.Forms.ToolStripComboBox>, <xref:System.Windows.Forms.ToolStripTextBox> и <xref:System.Windows.Forms.ToolStripProgressBar>. Также в <xref:System.Windows.Forms.ToolStripControlHost> можно разместить любой другой существующий или COM-элемент управления.  
  
 Пример размещения элементов управления, см. в разделе [как: Заключение элемента управления Windows Forms с помощью ToolStripControlHost](how-to-wrap-a-windows-forms-control-with-toolstripcontrolhost.md).  
  
## <a name="rendering"></a>Отрисовка  
 <xref:System.Windows.Forms.ToolStrip> классы реализуют механизм отрисовки, который существенно отличается от других элементов управления Windows Forms. Этот механизм позволяет с легкостью применять стили и темы.  
  
 Чтобы применить стиль к <xref:System.Windows.Forms.ToolStrip> и всем содержащимся в нем элементам <xref:System.Windows.Forms.ToolStripItem>, не нужно обрабатывать событие <xref:System.Windows.Forms.ToolStripItem.Paint> для каждого элемента. Вместо этого можно задать для свойства <xref:System.Windows.Forms.ToolStrip.RenderMode%2A> одно из значений <xref:System.Windows.Forms.ToolStripRenderMode>, отличных от <xref:System.Windows.Forms.ToolStripRenderMode.Custom>. Кроме того, можно задать <xref:System.Windows.Forms.ToolStrip.Renderer%2A> непосредственно для любого класса, наследуемого от класса <xref:System.Windows.Forms.ToolStripRenderer>. При задании этого свойства автоматически устанавливается параметр <xref:System.Windows.Forms.ToolStrip.RenderMode%2A>.  
  
 Тот же стиль можно применить к нескольким элементам <xref:System.Windows.Forms.ToolStrip> в одном приложении, задав для <xref:System.Windows.Forms.ToolStrip.RenderMode%2A> значение <xref:System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode> и для свойства <xref:System.Windows.Forms.ToolStripManager.RenderMode%2A> или <xref:System.Windows.Forms.ToolStripManager.Renderer%2A> необходимое значение <xref:System.Windows.Forms.ToolStripManagerRenderMode> или <xref:System.Windows.Forms.ToolStripRenderer> соответственно.  
  
 Примеры отрисовки см. в разделе [как: Создание и определение пользовательского средства визуализации, для элемента управления ToolStrip в Windows Forms](create-and-set-a-custom-renderer-for-the-toolstrip-control-in-wf.md).  
  
## <a name="styles-and-themes"></a>Стили и темы  
 <xref:System.Windows.Forms.ToolStrip> и связанные с ним классы предоставляют простой способ поддержки визуальных стилей и настраиваемого внешнего вида, не требуется переопределять <xref:System.Windows.Forms.ToolStripItem.OnPaint%2A> методы для каждого элемента. Используйте <xref:System.Windows.Forms.ToolStripItem.DisplayStyle%2A> и свойства <xref:System.Windows.Forms.ToolStrip.RenderMode%2A> и <xref:System.Windows.Forms.ToolStrip.Renderer%2A>.  
  
## <a name="rafting-and-docking"></a>Нависание и закрепление  
 Для элементов управления <xref:System.Windows.Forms.ToolStrip> можно использовать нависание, закрепление или абсолютное позиционирование. <xref:System.Windows.Forms.ToolStrip> элементы располагаются <xref:System.Windows.Forms.ToolStrip.LayoutEngine%2A> контейнера.  
  
 *Нависание* — это возможность совместного использования горизонтального или вертикального пространства панели инструментов. Форма Windows может иметь контейнер <xref:System.Windows.Forms.ToolStripContainer>, который в свою очередь содержит панели на левой, правой, верхней и нижней сторонах формы для размещения и нависания элементов управления <xref:System.Windows.Forms.ToolStrip>, <xref:System.Windows.Forms.MenuStrip> и <xref:System.Windows.Forms.StatusStrip>. Несколько элементов управления <xref:System.Windows.Forms.ToolStrip> располагаются по вертикали, если поместить их в левый или правый контейнер <xref:System.Windows.Forms.ToolStripContainer>. Они располагаются по горизонтали, если поместить их в верхний или нижний контейнер <xref:System.Windows.Forms.ToolStripContainer>. Для размещения традиционных элементов управления в форме может использоваться центральная панель <xref:System.Windows.Forms.ToolStripContentPanel> из контейнера <xref:System.Windows.Forms.ToolStripContainer>.  
  
 Все элементы управления <xref:System.Windows.Forms.ToolStripContainer> непосредственно доступны для выбора во время разработки и могут быть удалены. Контейнер <xref:System.Windows.Forms.ToolStripContainer> может расширяться и сворачиваться и изменять размеры элементов управления, которые он содержит.  
  
 *Закрепление* понимается расположение элемента управления на формы слева, справа, сверху или снизу.  
  
 Преимуществом нависания над закреплением является то, что элементы управления <xref:System.Windows.Forms.ToolStrip>, <xref:System.Windows.Forms.MenuStrip> и <xref:System.Windows.Forms.StatusStrip> могут совместно использовать горизонтальное или вертикальное пространство с другими элементами управления.  
  
 Вместо использования нависания большинство элементов управления <xref:System.Windows.Forms.ToolStrip> можно закрепить на форме, как и другие элементы управления. Можно также указать, что элемент управления <xref:System.Windows.Forms.ToolStrip> свободно размещается на форме, удалив его из его контейнера <xref:System.Windows.Forms.ToolStripContainer> и задав для его свойства `Dock` значение `None`, либо указать абсолютное положение, задав соответствующее свойство <xref:System.Windows.Forms.Control.Location%2A>. См. практическое руководство по [ Перемещение элемента ToolStrip из контейнера ToolStripContainer в форму](how-to-move-a-toolstrip-out-of-a-toolstripcontainer-onto-a-form.md).  
  
 Использование одного или нескольких элементов управления <xref:System.Windows.Forms.ToolStripPanel> обеспечивает большую гибкость, особенно для приложений многодокументного интерфейса (MDI), либо если нет необходимости в контейнере <xref:System.Windows.Forms.ToolStripContainer>. <xref:System.Windows.Forms.ToolStripPanel> предоставляет место для закрепления и нависания только для элементов управления <xref:System.Windows.Forms.ToolStrip>, а не традиционных элементов управления. По умолчанию <xref:System.Windows.Forms.ToolStripPanel> не отображается в конструкторе **элементов**, но можно поместить туда, щелкнув правой кнопкой мыши **элементов**и нажмите кнопку **Выбор элементов**. Программно обращаться к <xref:System.Windows.Forms.ToolStripPanel> можно так же, как и к любому другому классу.  
  
 Элементы управления <xref:System.Windows.Forms.ToolStrip>, <xref:System.Windows.Forms.MenuStrip> и <xref:System.Windows.Forms.StatusStrip> поддерживают области переполнения, аналогичные панелям инструментов Microsoft Office.  
  
## <a name="see-also"></a>См. также

- [Общие сведения об элементе управления ToolStrip](toolstrip-control-overview-windows-forms.md)
- [Архитектура элемента управления ToolStrip](toolstrip-control-architecture.md)

---
title: Масштабирование элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- DataGridView control [Windows Forms], row sharing
- data grids [Windows Forms], best practices
- DataGridView control [Windows Forms], shared rows
- DataGridView control [Windows Forms], best practices
- best practices [Windows Forms], dataGridView control
- DataGridView control [Windows Forms], scaling
ms.assetid: 8321a8a6-6340-4fd1-b475-fa090b905aaf
ms.openlocfilehash: 76ac31e9082216d0024160c51a7495855eee5601
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59142148"
---
# <a name="best-practices-for-scaling-the-windows-forms-datagridview-control"></a>Масштабирование элемента управления DataGridView в Windows Forms
<xref:System.Windows.Forms.DataGridView> Управления предназначен для обеспечения максимальной масштабируемости. Если требуется для отображения больших объемов данных, необходимо следовать рекомендациям, приведенным в этом разделе, чтобы избежать использования большого объема памяти или замедления работы пользовательский интерфейс (UI). В этом разделе обсуждаются следующие вопросы:  
  
-   Эффективное использование стилей для ячейки  
  
-   Эффективное использование контекстных меню  
  
-   Использование автоматического изменения размеров эффективно  
  
-   Эффективное использование выбранные коллекции ячеек, строк и столбцов  
  
-   Использование общих строк  
  
-   Предотвращение строкам  
  
 Если у вас есть особые требования к производительности, можно реализовать виртуальный режим и предоставить собственные операции управления данными. Дополнительные сведения см. в разделе [режимы отображения данных в элементе управления DataGridView Windows Forms](data-display-modes-in-the-windows-forms-datagridview-control.md).  
  
## <a name="using-cell-styles-efficiently"></a>Эффективное использование стилей для ячейки  
 Каждой ячейки, строки и столбца может иметь свои собственные сведения о стиле. Сведения о стиле хранится в <xref:System.Windows.Forms.DataGridViewCellStyle> объектов. Создание объектов стиля ячеек для множества отдельных <xref:System.Windows.Forms.DataGridView> элементы могут быть неэффективным, особенно при работе с большими объемами данных. Чтобы избежать снижения производительности, следуйте приведенным ниже рекомендациям:  
  
-   Не рекомендуется устанавливать свойства стиля ячейки для отдельных <xref:System.Windows.Forms.DataGridViewCell> или <xref:System.Windows.Forms.DataGridViewRow> объектов. Сюда входят строки объекта, заданного параметром <xref:System.Windows.Forms.DataGridView.RowTemplate%2A> свойство. Каждой новой строки, которая клонируется из шаблона строки получит свою собственную копию объекта стиля шаблона ячейки. Для максимальной масштабируемости, задайте свойства стиля ячейки в <xref:System.Windows.Forms.DataGridView> уровень. Например, задать <xref:System.Windows.Forms.DataGridView.DefaultCellStyle%2A?displayProperty=nameWithType> свойства, а не <xref:System.Windows.Forms.DataGridViewCell.Style%2A?displayProperty=nameWithType> свойство.  
  
-   Если некоторые ячейки требуется форматирования, отличные от форматирования по умолчанию, используйте тот же <xref:System.Windows.Forms.DataGridViewCellStyle> экземпляра на группы ячеек, строк или столбцов. Избегайте прямого задания свойств типа <xref:System.Windows.Forms.DataGridViewCellStyle> на отдельных ячеек, строк и столбцов. Пример совместного использования стиля ячеек, см. в разделе [как: Установка стилей ячейки по умолчанию для управления DataGridView в Windows Forms](how-to-set-default-cell-styles-for-the-windows-forms-datagridview-control.md). Можно также избежать снижения производительности при задании стили ячеек по отдельности, обрабатывая <xref:System.Windows.Forms.DataGridView.CellFormatting> обработчик событий. Пример см. в статье [Практическое руководство. Настройка форматирования данных в элементе управления DataGridView Windows Forms](how-to-customize-data-formatting-in-the-windows-forms-datagridview-control.md).  
  
-   При определении стиля ячейки, используйте <xref:System.Windows.Forms.DataGridViewCell.InheritedStyle%2A?displayProperty=nameWithType> свойства, а не <xref:System.Windows.Forms.DataGridViewCell.Style%2A?displayProperty=nameWithType> свойство. Доступ к <xref:System.Windows.Forms.DataGridViewCell.Style%2A> свойство создает новый экземпляр класса <xref:System.Windows.Forms.DataGridViewCellStyle> , если свойство не уже используется. Кроме того этот объект может не содержать полные сведения о стиле для ячейки, если некоторые стили наследуются от строк, столбцов или элемента управления. Дополнительные сведения о наследовании стилей ячеек, см. в разделе [стили ячеек элемента управления DataGridView Windows Forms в](cell-styles-in-the-windows-forms-datagridview-control.md).  
  
## <a name="using-shortcut-menus-efficiently"></a>Эффективное использование контекстных меню  
 Каждой ячейки, строки и столбца может иметь собственное контекстное меню. Контекстные меню в <xref:System.Windows.Forms.DataGridView> управления представлены <xref:System.Windows.Forms.ContextMenuStrip> элементов управления. Как и в объекты стиля ячейки, Создание контекстного меню для множества отдельных <xref:System.Windows.Forms.DataGridView> элементов может отрицательно сказаться на производительности. Чтобы избежать потерь производительности, следуйте приведенным ниже рекомендациям:  
  
-   Избегайте создания контекстных меню для отдельных ячеек и строк. Это включает в себя шаблон строки, который копируется вместе с его контекстное меню, когда новые строки добавляются к элементу управления. Для максимальной масштабируемости, используйте только элемента управления <xref:System.Windows.Forms.Control.ContextMenuStrip%2A> свойство, чтобы указать одно контекстное меню для всего элемента управления.  
  
-   Если требуется несколько контекстных меню для нескольких строк или ячеек, обрабатывать <xref:System.Windows.Forms.DataGridView.CellContextMenuStripNeeded> или <xref:System.Windows.Forms.DataGridView.RowContextMenuStripNeeded> события. Эти события позволяют управлять объектами контекстного меню самостоятельно, что позволяет настроить производительность.  
  
## <a name="using-automatic-resizing-efficiently"></a>Использование автоматического изменения размеров эффективно  
 Строк, столбцов и заголовков может автоматически изменяться при изменении содержимого ячеек, все содержимое ячейки отображаются без обрезки. Изменение режима изменения размеров можно также изменить размер строк, столбцов и заголовков. Чтобы определить правильный размер <xref:System.Windows.Forms.DataGridView> элемент управления должен проверить значение каждой ячейки, в нем. При работе с большими наборами данных этого анализа может отрицательно повлиять на производительность элемента управления при выполнении автоматического изменения размеров. Чтобы избежать снижения производительности, следуйте приведенным ниже рекомендациям:  
  
-   Избегайте использования автоматического изменения размеров на <xref:System.Windows.Forms.DataGridView> элемента управления с большим набором строк. При использовании автоматического изменения размеров, только изменения размера на основе отображаемых строк. Используйте только те строки, отображаемые в виртуальном режиме, а также.  
  
    -   Для строк и столбцов, используйте `DisplayedCells` или `DisplayedCellsExceptHeaders` поле <xref:System.Windows.Forms.DataGridViewAutoSizeRowsMode>, <xref:System.Windows.Forms.DataGridViewAutoSizeColumnsMode>, и <xref:System.Windows.Forms.DataGridViewAutoSizeColumnMode> перечисления.  
  
    -   Заголовки строк, используйте <xref:System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders> или <xref:System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader> поле <xref:System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode> перечисления.  
  
-   Для максимальной масштабируемости выключите автоматического изменения размеров и используйте программного изменения размеров.  
  
 Дополнительные сведения см. в разделе [параметров изменения размеров элемента управления DataGridView Windows Forms в](sizing-options-in-the-windows-forms-datagridview-control.md).  
  
## <a name="using-the-selected-cells-rows-and-columns-collections-efficiently"></a>Эффективное использование выделенных ячеек, строк и столбцов коллекций  
 <xref:System.Windows.Forms.DataGridView.SelectedCells%2A> Коллекции, неэффективно с большой выбор. <xref:System.Windows.Forms.DataGridView.SelectedRows%2A> И <xref:System.Windows.Forms.DataGridView.SelectedColumns%2A> коллекции также могут быть неэффективным, хотя и в меньшей степени, так как существует много меньше строк, чем ячеек в стандартном <xref:System.Windows.Forms.DataGridView> элемента управления и гораздо меньше столбцов, чем строк. Чтобы избежать снижения производительности при работе с этими коллекциями, следуйте приведенным ниже рекомендациям:  
  
-   Чтобы определить ли все ячейки в <xref:System.Windows.Forms.DataGridView> были выбраны перед обращением к содержимое <xref:System.Windows.Forms.DataGridView.SelectedCells%2A> коллекции, проверьте возвращаемое значение <xref:System.Windows.Forms.DataGridView.AreAllCellsSelected%2A> метод. Обратите внимание, что этого метода может привести к строкам. Дополнительные сведения см. в следующем разделе.  
  
-   Избегайте использования <xref:System.Collections.ICollection.Count%2A> свойство <xref:System.Windows.Forms.DataGridViewSelectedCellCollection?displayProperty=nameWithType> для определения числа выделенных ячеек. Вместо этого используйте <xref:System.Windows.Forms.DataGridView.GetCellCount%2A?displayProperty=nameWithType> метод и передать <xref:System.Windows.Forms.DataGridViewElementStates.Selected?displayProperty=nameWithType> значение. Аналогичным образом использовать <xref:System.Windows.Forms.DataGridViewRowCollection.GetRowCount%2A?displayProperty=nameWithType> и <xref:System.Windows.Forms.DataGridViewColumnCollection.GetColumnCount%2A?displayProperty=nameWithType> методы, чтобы определить количество выбранных элементов, а не доступ к коллекции выбранных строк и столбцов.  
  
-   Избегайте режимы выбора на основе ячеек. Вместо этого задайте <xref:System.Windows.Forms.DataGridView.SelectionMode%2A?displayProperty=nameWithType> свойства <xref:System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect?displayProperty=nameWithType> или <xref:System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect?displayProperty=nameWithType>.  
  
## <a name="using-shared-rows"></a>Использование общих строк  
 Эффективного использования памяти производится в <xref:System.Windows.Forms.DataGridView> управления с помощью общих строк. Строки будут совместно использовать как можно больше сведений о об их внешний вид и поведение, предоставив экземпляров <xref:System.Windows.Forms.DataGridViewRow> класса.  
  
 Хотя общий доступ к экземпляру строки сохраняет в памяти, строк можно легко строкам. Например каждый раз, когда пользователь взаимодействует непосредственно с ячейкой, соответствующей строке блокируется. Так как это является обязательной, указаниям, изложенным в этом разделе полезны только в том случае, при работе с очень большими объемами данных, и только в том случае, если пользователи будут взаимодействовать с относительно небольшая часть данных при каждом запуске программы.  
  
 Строки не могут совместно использоваться несвязанного <xref:System.Windows.Forms.DataGridView> элемента управления, если какие-либо ячейки содержат значения. Когда <xref:System.Windows.Forms.DataGridView> управления привязан к внешнему источнику данных или при реализации виртуального режима и предоставить свой собственный источник данных, значения ячеек, хранятся за пределами элемента управления, а не в объектах ячеек, что строк для совместного использования.  
  
 Объект строки могут совместно только в том случае, если можно определить состояние всех его ячеек из состояния строки и состояний столбцов, содержащих ячейки. При изменении состояния ячейки, чтобы он больше не могут быть выведены от состояния ее строки и столбца, строки не может использоваться.  
  
 Например строки не может использоваться в любом из следующих ситуаций:  
  
-   Строка содержит один выбранной ячейки, который не находится в выбранном столбце.  
  
-   Строка содержит ячейку с его <xref:System.Windows.Forms.DataGridViewCell.ToolTipText%2A> или <xref:System.Windows.Forms.DataGridViewCell.ContextMenuStrip%2A> заданными свойствами.  
  
-   Строка содержит <xref:System.Windows.Forms.DataGridViewComboBoxCell> с его <xref:System.Windows.Forms.DataGridViewComboBoxCell.Items%2A> набор свойств.  
  
 В связанном или виртуальном режиме, вы можете предоставить всплывающие подсказки и контекстные меню для отдельных ячеек, обрабатывая <xref:System.Windows.Forms.DataGridView.CellToolTipTextNeeded> и <xref:System.Windows.Forms.DataGridView.CellContextMenuStripNeeded> события.  
  
 <xref:System.Windows.Forms.DataGridView> Управления автоматически будет пытаться использовать общие строки каждый раз, когда строки добавляются к <xref:System.Windows.Forms.DataGridViewRowCollection>. Чтобы убедиться, что строки являются общими, следуйте приведенным ниже рекомендациям:  
  
-   Избегайте вызова `Add(Object[])` перегрузки <xref:System.Windows.Forms.DataGridViewRowCollection.Add%2A> метод и `Insert(Object[])` перегрузки <xref:System.Windows.Forms.DataGridViewRowCollection.Insert%2A> метод <xref:System.Windows.Forms.DataGridView.Rows%2A?displayProperty=nameWithType> коллекции. Эти перегрузки автоматически создавать строки с монопольным доступом.  
  
-   Убедитесь, что строки, заданной в <xref:System.Windows.Forms.DataGridView.RowTemplate%2A?displayProperty=nameWithType> свойство может использоваться в следующих случаях:  
  
    -   При вызове `Add()` или `Add(Int32)` перегруженные версии <xref:System.Windows.Forms.DataGridViewRowCollection.Add%2A> метод или `Insert(Int32,Int32)` перегрузки <xref:System.Windows.Forms.DataGridViewRowCollection.Insert%2A> метод <xref:System.Windows.Forms.DataGridView.Rows%2A?displayProperty=nameWithType> коллекции.  
  
    -   При увеличении значения <xref:System.Windows.Forms.DataGridView.RowCount%2A?displayProperty=nameWithType> свойство.  
  
    -   При задании <xref:System.Windows.Forms.DataGridView.DataSource%2A?displayProperty=nameWithType> свойство.  
  
-   Убедитесь, что к строке, указанной `indexSource` параметр может использоваться при вызове <xref:System.Windows.Forms.DataGridViewRowCollection.AddCopy%2A>, <xref:System.Windows.Forms.DataGridViewRowCollection.AddCopies%2A>, <xref:System.Windows.Forms.DataGridViewRowCollection.InsertCopy%2A>, и <xref:System.Windows.Forms.DataGridViewRowCollection.InsertCopies%2A> методы <xref:System.Windows.Forms.DataGridView.Rows%2A?displayProperty=nameWithType> коллекции.  
  
-   Убедитесь, что указанной строки или строк могут использоваться при вызове `Add(DataGridViewRow)` перегрузки <xref:System.Windows.Forms.DataGridViewRowCollection.Add%2A> метод, <xref:System.Windows.Forms.DataGridViewRowCollection.AddRange%2A> метод, `Insert(Int32,DataGridViewRow)` перегрузки <xref:System.Windows.Forms.DataGridViewRowCollection.Insert%2A> метод и <xref:System.Windows.Forms.DataGridViewRowCollection.InsertRange%2A> метод <xref:System.Windows.Forms.DataGridView.Rows%2A?displayProperty=nameWithType>коллекции.  
  
 Чтобы определить, является ли общим строки, используйте <xref:System.Windows.Forms.DataGridViewRowCollection.SharedRow%2A?displayProperty=nameWithType> метод для извлечения объекта строки, а затем проверить объекта <xref:System.Windows.Forms.DataGridViewBand.Index%2A> свойство. Общие строки всегда имеют <xref:System.Windows.Forms.DataGridViewBand.Index%2A> значение свойства равно – 1.  
  
## <a name="preventing-rows-from-becoming-unshared"></a>Предотвращение строкам  
 Общие строки может привести к блокированию код или действия пользователя. Чтобы избежать снижения производительности, следует избегать, вызывая к строкам. При разработке приложений, можно обрабатывать одновременно <xref:System.Windows.Forms.DataGridView.RowUnshared> событие, чтобы определить, когда строкам строк. Это полезно при отладке проблем с общий доступ к строкам.  
  
 Для предотвращения строк строкам, следуйте приведенным ниже рекомендациям:  
  
-   Следует избегать индексирования <xref:System.Windows.Forms.DataGridView.Rows%2A> коллекции или перебирать его с `foreach` цикла. Не потребуется обычно прямой доступ к строкам. <xref:System.Windows.Forms.DataGridView> методы, которые работают в строках принимать аргументы индекс строки, а не экземпляров строк. Кроме того обработчики для событий, связанных со строками, получают объектов аргументов событий с помощью свойств строки, которые можно использовать для операций со строками, не вызывая их к строкам.  
  
-   Если вам требуется доступ к объекту строки, используйте <xref:System.Windows.Forms.DataGridViewRowCollection.SharedRow%2A?displayProperty=nameWithType> метод и передайте фактический индекс строки. Обратите внимание, что изменения объекта совместно используемой строкой, извлекаемых с помощью этого метода будет изменять все строки, которые совместно используют этот объект. Строки для новых записей не используется совместно с других строк, тем не менее, поэтому он не будут затронуты при изменении любых других строк. Обратите внимание, что различные строки, представленной в общей строке могут иметь различные контекстные меню. Чтобы получить правильный контекстное меню из экземпляра общей строки, используйте <xref:System.Windows.Forms.DataGridViewRow.GetContextMenuStrip%2A> метод и передайте фактический индекс строки. Если доступ к совместно используемой <xref:System.Windows.Forms.DataGridViewRow.ContextMenuStrip%2A> свойство вместо этого он будет использовать индекс совместно используемой строкой-1 и не получает соответствующее контекстное меню.  
  
-   Следует избегать индексирования <xref:System.Windows.Forms.DataGridViewRow.Cells%2A?displayProperty=nameWithType> коллекции. Прямой доступ к ячейке приведет к ее родительской строки к строкам, создания нового <xref:System.Windows.Forms.DataGridViewRow>. Обработчики для событий, связанных с ячейки получают объектов аргументов событий со своими свойствами ячейки, которые можно использовать для операций с ячейками, не вызывая к строкам. Можно также использовать <xref:System.Windows.Forms.DataGridView.CurrentCellAddress%2A> свойство для извлечения индексы строки и столбца текущей ячейки без прямого доступа к ячейке.  
  
-   Избегайте режимы выбора на основе ячеек. Эти режимы привести к строкам. Вместо этого задайте <xref:System.Windows.Forms.DataGridView.SelectionMode%2A?displayProperty=nameWithType> свойства <xref:System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect?displayProperty=nameWithType> или <xref:System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect?displayProperty=nameWithType>.  
  
-   Не обрабатывают <xref:System.Windows.Forms.DataGridViewRowCollection.CollectionChanged?displayProperty=nameWithType> или <xref:System.Windows.Forms.DataGridView.RowStateChanged?displayProperty=nameWithType> события. Эти события привести к строкам. Кроме того, не следует вызывать <xref:System.Windows.Forms.DataGridViewRowCollection.OnCollectionChanged%2A?displayProperty=nameWithType> или <xref:System.Windows.Forms.DataGridView.OnRowStateChanged%2A?displayProperty=nameWithType> методы, которые инициируют эти события.  
  
-   Не обращаются к <xref:System.Windows.Forms.DataGridView.SelectedCells%2A?displayProperty=nameWithType> коллекции при <xref:System.Windows.Forms.DataGridView.SelectionMode%2A?displayProperty=nameWithType> свойство имеет значение <xref:System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect>, <xref:System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect>, <xref:System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect>, или <xref:System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect>. В результате все выбранные строки к строкам.  
  
-   Не вызывайте <xref:System.Windows.Forms.DataGridView.AreAllCellsSelected%2A?displayProperty=nameWithType> метод. Этого метода может привести к строкам.  
  
-   Не вызывайте <xref:System.Windows.Forms.DataGridView.SelectAll%2A?displayProperty=nameWithType> метод при <xref:System.Windows.Forms.DataGridView.SelectionMode%2A?displayProperty=nameWithType> свойство имеет значение <xref:System.Windows.Forms.DataGridViewSelectionMode.CellSelect>. В результате все строки к строкам.  
  
-   Не устанавливайте <xref:System.Windows.Forms.DataGridViewCell.ReadOnly%2A> или <xref:System.Windows.Forms.DataGridViewCell.Selected%2A> свойство ячейки для `false` Если присвоить соответствующее свойство в столбце `true`. В результате все строки к строкам.  
  
-   Не открывайте <xref:System.Windows.Forms.DataGridViewRowCollection.List%2A?displayProperty=nameWithType> свойство. В результате все строки к строкам.  
  
-   Не вызывайте `Sort(IComparer)` перегрузки <xref:System.Windows.Forms.DataGridView.Sort%2A> метод. Сортировка с использованием пользовательского модуля сравнения вызывает всех строк.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- [Оптимизация производительности элемента управления DataGridView в Windows Forms](performance-tuning-in-the-windows-forms-datagridview-control.md)
- [Виртуальный режим элемента управления DataGridView в Windows Forms](virtual-mode-in-the-windows-forms-datagridview-control.md)
- [Режимы отображения данных в элементе управления DataGridView в Windows Forms](data-display-modes-in-the-windows-forms-datagridview-control.md)
- [Стили ячеек элемента управления DataGridView в Windows Forms](cell-styles-in-the-windows-forms-datagridview-control.md)
- [Практическое руководство. Установка стилей ячейки по умолчанию для элемента управления DataGridView в Windows Forms](how-to-set-default-cell-styles-for-the-windows-forms-datagridview-control.md)
- [Изменение размеров управления DataGridView в Windows Forms](sizing-options-in-the-windows-forms-datagridview-control.md)

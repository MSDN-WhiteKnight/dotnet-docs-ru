---
title: Установка режимов сортировки для столбцов элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- data grids [Windows Forms], sort modes
- DataGridView control [Windows Forms], sort mode
ms.assetid: 43715887-2df9-4da7-bcf1-b9c7c842b2bf
ms.openlocfilehash: b8f6048946d367dd79b1ce0d23d84446ffdb1115
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59106670"
---
# <a name="column-sort-modes-in-the-windows-forms-datagridview-control"></a>Установка режимов сортировки для столбцов элемента управления DataGridView в Windows Forms
<xref:System.Windows.Forms.DataGridView> столбцы имеют три режима сортировки. Режим сортировки для каждого столбца указывается с помощью <xref:System.Windows.Forms.DataGridViewColumn.SortMode%2A> свойство столбца, который может быть присвоено одно из следующих <xref:System.Windows.Forms.DataGridViewColumnSortMode> значений перечисления.  
  
|`DataGridViewColumnSortMode` value|Описание|  
|----------------------------------------|-----------------|  
|<xref:System.Windows.Forms.DataGridViewColumnSortMode.Automatic>|По умолчанию для столбцов текстовых полей. Если заголовки столбцов не используются для выбора, щелкнув заголовок столбца автоматически сортирует <xref:System.Windows.Forms.DataGridView> по этому столбцу и отображает глиф, указывающее порядок сортировки.|  
|<xref:System.Windows.Forms.DataGridViewColumnSortMode.NotSortable>|По умолчанию для столбцов не — текстовое поле. Этот столбец можно отсортировать программным образом. Тем не менее он не предназначен для сортировки, поэтому место не резервируется для глифа сортировки.|  
|<xref:System.Windows.Forms.DataGridViewColumnSortMode.Programmatic>|Этот столбец можно отсортировать программным способом и резервируется место для глифа сортировки.|  
  
 Может потребоваться изменить режим сортировки для столбца, который по умолчанию используется <xref:System.Windows.Forms.DataGridViewColumnSortMode.NotSortable> если он содержит значения, которые могут быть осмысленно упорядочены. Например если у вас есть столбец базы данных, содержащий числа, представляющие состояния элементов, можно отобразить эти числа как соответствующие значки путем привязки к столбцу базы данных столбец типа image. Затем можно преобразовать числовые значения ячеек в графические значения в обработчике <xref:System.Windows.Forms.DataGridView.CellFormatting?displayProperty=nameWithType> событий. В этом случае параметр <xref:System.Windows.Forms.DataGridViewColumn.SortMode%2A> свойства <xref:System.Windows.Forms.DataGridViewColumnSortMode.Automatic> будет пользователи могли сортировать столбец. Автоматическая сортировка будет включить пользователей для группирования элементов, которые имеют то же состояние, даже если соответствующие номера состояниям нет естественным последовательности. Столбцы "флажок" — еще один пример, где автоматическую сортировку для группировки элементов, в том же состоянии.  
  
 Можно сортировать <xref:System.Windows.Forms.DataGridView> программно по значениям в любом столбце или в нескольких столбцах, независимо от того, <xref:System.Windows.Forms.DataGridViewColumn.SortMode%2A> параметры. Программная сортировка полезно в том случае, когда вы хотите предоставить собственный пользовательский интерфейс (UI) для сортировки или когда требуется реализовать пользовательская сортировка. Предоставление собственного пользовательского интерфейса сортировки полезно, например, при задании <xref:System.Windows.Forms.DataGridView> режим выбора, чтобы включить выбор заголовка столбца. Таким образом, несмотря на то, что заголовки столбцов не может использоваться для сортировки, необходимо все заголовки, чтобы отобразить соответствующий глиф сортировки, поэтому следует задать <xref:System.Windows.Forms.DataGridViewColumn.SortMode%2A> свойства <xref:System.Windows.Forms.DataGridViewColumnSortMode.Programmatic>.  
  
 Установка режима программная сортировка столбцов автоматически не отображают глифа сортировки. Для этих столбцов, вы должны отображать глиф самостоятельно, задав <xref:System.Windows.Forms.DataGridViewColumnHeaderCell.SortGlyphDirection%2A?displayProperty=nameWithType> свойство. Это необходимо, чтобы обеспечить гибкость в пользовательской сортировки. Например, при сортировке <xref:System.Windows.Forms.DataGridView> по нескольким столбцам, может потребоваться отобразить нескольких или ни одного глифа сортировки.  
  
 Несмотря на то, что программная сортировка <xref:System.Windows.Forms.DataGridView> по любому столбцу, некоторые столбцы, например столбцы кнопок, может не содержать значения, которые могут быть осмысленно упорядочены. Для этих столбцов <xref:System.Windows.Forms.DataGridViewColumn.SortMode%2A> значение свойства <xref:System.Windows.Forms.DataGridViewColumnSortMode.NotSortable> указывает, что он не будут использоваться для сортировки, поэтому нет необходимости, чтобы зарезервировать место для глифа сортировки.  
  
 Когда <xref:System.Windows.Forms.DataGridView> — сортировка, можно определить столбец для сортировки и порядок сортировки путем проверки значения <xref:System.Windows.Forms.DataGridView.SortedColumn%2A> и <xref:System.Windows.Forms.DataGridView.SortOrder%2A> свойства. Эти значения не имеют смысла после операцию пользовательской сортировки. Дополнительные сведения о пользовательской сортировке см. в статье в разделе пользовательская сортировка далее в этом разделе.  
  
 Когда <xref:System.Windows.Forms.DataGridView> сортировке элемента управления, содержащего связанные и несвязанные столбцы, автоматическое сохранение значений в несвязанных столбцов невозможно. Для сохранения этих значений, необходимо реализовать виртуальный режим, задав <xref:System.Windows.Forms.DataGridView.VirtualMode%2A> свойства `true` и обработка <xref:System.Windows.Forms.DataGridView.CellValueNeeded> и <xref:System.Windows.Forms.DataGridView.CellValuePushed> события. Дополнительные сведения см. в разделе [Как Реализация виртуального режима в Windows Forms элемента управления DataGridView](how-to-implement-virtual-mode-in-the-windows-forms-datagridview-control.md). Сортировка по несвязанных столбцов в связанном режиме не поддерживается.  
  
## <a name="programmatic-sorting"></a>Программная сортировка  
 Можно сортировать <xref:System.Windows.Forms.DataGridView> программным образом путем вызова его <xref:System.Windows.Forms.DataGridView.Sort%2A> метод.  
  
 `Sort(DataGridViewColumn,ListSortDirection)` Перегрузки <xref:System.Windows.Forms.DataGridView.Sort%2A> альбома <xref:System.Windows.Forms.DataGridViewColumn> и <xref:System.ComponentModel.ListSortDirection> значение перечисления в качестве параметров. Эта перегрузка может использоваться при сортировке по столбцам со значениями, могут быть осмысленно упорядочены, но вы не хотите настроить для автоматической сортировки. Когда вызывают эту перегрузку и передать в столбце с <xref:System.Windows.Forms.DataGridViewColumn.SortMode%2A> значение свойства <xref:System.Windows.Forms.DataGridViewColumnSortMode.Automatic?displayProperty=nameWithType>, <xref:System.Windows.Forms.DataGridView.SortedColumn%2A> и <xref:System.Windows.Forms.DataGridView.SortOrder%2A> свойства устанавливаются автоматически, и соответствующий глиф сортировки отображается в заголовке столбца.  
  
> [!NOTE]
>  Когда <xref:System.Windows.Forms.DataGridView> управления привязан к внешнему источнику данных, задав <xref:System.Windows.Forms.DataGridView.DataSource%2A> свойства `Sort(DataGridViewColumn,ListSortDirection)` перегруженный метод не работает для несвязанных столбцов. Кроме того, когда <xref:System.Windows.Forms.DataGridView.VirtualMode%2A> свойство `true`, можно вызвать эту перегрузку только для привязанных столбцов. Чтобы определить, является ли столбец с привязкой к данным, проверьте <xref:System.Windows.Forms.DataGridViewColumn.IsDataBound%2A> значение свойства. Сортировка несвязанных столбцов в связанном режиме не поддерживается.  
  
## <a name="custom-sorting"></a>Пользовательская сортировка  
 Вы можете настроить <xref:System.Windows.Forms.DataGridView> с помощью `Sort(IComparer)` перегрузки <xref:System.Windows.Forms.DataGridView.Sort%2A> метод или путем обработки <xref:System.Windows.Forms.DataGridView.SortCompare> событий.  
  
 `Sort(IComparer)` Перегруженный метод принимает экземпляр класса, реализующего <xref:System.Collections.IComparer> интерфейсом в виде параметра. Эта перегрузка может использоваться, если вы хотите пользовательской сортировки; Например, когда значения в столбце нет естественного порядка сортировки или когда естественного порядка сортировки не подходит. В этом случае нельзя использовать автоматическую сортировку, но вы по-прежнему можете пользователям сортировать, щелкая заголовки столбцов. Эту перегрузку можно вызвать в обработчике <xref:System.Windows.Forms.DataGridView.ColumnHeaderMouseClick> событие, если заголовки столбцов не используется для выбора.  
  
> [!NOTE]
>  `Sort(IComparer)` Перегруженный метод работает, только если <xref:System.Windows.Forms.DataGridView> управления не привязан к внешнему источнику данных и <xref:System.Windows.Forms.DataGridView.VirtualMode%2A> свойство имеет значение `false`. Для настройки сортировки для столбцов, привязанных к внешнему источнику данных, необходимо использовать операции сортировки, предоставляемых источником данных. В виртуальном режиме необходимо предоставить свои собственные операции сортировки для несвязанных столбцов.  
  
 Чтобы использовать `Sort(IComparer)` перегрузку метода, необходимо создать свой собственный класс, реализующий <xref:System.Collections.IComparer> интерфейс. Этот интерфейс требует класс для реализации <xref:System.Collections.IComparer.Compare%2A?displayProperty=nameWithType> метод, к которому <xref:System.Windows.Forms.DataGridView> передает <xref:System.Windows.Forms.DataGridViewRow> объектов в качестве входных данных, когда `Sort(IComparer)` вызове перегрузки метода. Таким образом вы можете вычислить правильный порядок строк на основе значений в любом столбце.  
  
 `Sort(IComparer)` Перегруженный метод не устанавливает <xref:System.Windows.Forms.DataGridView.SortedColumn%2A> и <xref:System.Windows.Forms.DataGridView.SortOrder%2A> свойства, поэтому всегда необходимо устанавливать <xref:System.Windows.Forms.DataGridViewColumnHeaderCell.SortGlyphDirection%2A?displayProperty=nameWithType> свойство для отображения глифа сортировки.  
  
 Как альтернативу `Sort(IComparer)` перегрузку метода, вы можете предоставить пользовательская сортировка по реализации обработчика для <xref:System.Windows.Forms.DataGridView.SortCompare> событий. Это событие происходит, когда пользователь щелкает заголовки столбцов, настроенных для автоматической сортировки или при вызове `Sort(DataGridViewColumn,ListSortDirection)` перегрузки <xref:System.Windows.Forms.DataGridView.Sort%2A> метод. Это событие возникает для каждой пары строк в элементе управления, что дает возможность определить их правильном порядке.  
  
> [!NOTE]
>  <xref:System.Windows.Forms.DataGridView.SortCompare> Событие не происходит, когда <xref:System.Windows.Forms.DataGridView.DataSource%2A> свойству или когда <xref:System.Windows.Forms.DataGridView.VirtualMode%2A> свойство имеет значение `true`.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridView.Sort%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.SortedColumn%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.SortOrder%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewColumn.SortMode%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewColumnHeaderCell.SortGlyphDirection%2A?displayProperty=nameWithType>
- [Сортировка данных в элементе управления DataGridView в Windows Forms](sorting-data-in-the-windows-forms-datagridview-control.md)
- [Практическое руководство. Определение режимов сортировки для столбцов элемента управления DataGridView в Windows Forms](set-the-sort-modes-for-columns-wf-datagridview-control.md)
- [Практическое руководство. Настройка сортировки данных элемента управления DataGridView в Windows Forms](how-to-customize-sorting-in-the-windows-forms-datagridview-control.md)

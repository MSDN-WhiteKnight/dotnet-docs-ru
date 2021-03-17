---
title: Виртуальный режим элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- DataGridView control [Windows Forms], virtual mode
ms.assetid: feae5d43-2848-4b1a-8ea7-77085dc415b5
ms.openlocfilehash: f284835578221ad1fe859f260e37bb829cd64b2d
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59124726"
---
# <a name="virtual-mode-in-the-windows-forms-datagridview-control"></a>Виртуальный режим элемента управления DataGridView в Windows Forms
Виртуальный режим можно управлять взаимодействием между <xref:System.Windows.Forms.DataGridView> управления и пользовательские данные кэша. Чтобы реализовать виртуальный режим, задать <xref:System.Windows.Forms.DataGridView.VirtualMode%2A> свойства `true` и обрабатывать один или несколько событий, описанных в этом разделе. Как правило, будет обрабатывать по крайней мере `CellValueNeeded` событие, которое позволяет производить поиск значения в кэше данных элемента управления.  
  
## <a name="bound-mode-and-virtual-mode"></a>Связанный и виртуальный режим  
 Виртуальный режим необходим, только в том случае, если вам нужно дополнить или заменить связанный режим. В режиме привязки задаются <xref:System.Windows.Forms.DataGridView.DataSource%2A> свойства и элемента управления автоматически загружает данные из указанного источника и передает, пользователь изменяет в него. Можно управлять, отображаемые привязанные столбцы, а сам источник данных, обычно обрабатывает операции, такие как сортировка.  
  
## <a name="supplementing-bound-mode"></a>Расширение связанного режима  
 Связанный режим можно расширить путем отображения связанных и несвязанных столбцов. Это иногда называется «смешанный режим» и может использоваться для отображения таких операций, как вычисляемые значения или пользовательского интерфейса (UI) управляет.  
  
 Поскольку непривязанные столбцы относятся к источнику данных, они игнорируются при операции сортировки источника данных. Таким образом, при использовании сортировки в смешанном режиме, необходимо управлять несвязанными данными в локальном кэше и реализовать виртуальный режим, чтобы <xref:System.Windows.Forms.DataGridView> управления взаимодействовать с ним.  
  
 Дополнительные сведения об использовании виртуального режима для сохранения значений в несвязанных столбцов см. в примерах <xref:System.Windows.Forms.DataGridViewCheckBoxColumn.ThreeState%2A?displayProperty=nameWithType> свойство и <xref:System.Windows.Forms.DataGridViewComboBoxColumn?displayProperty=nameWithType> класса справочные разделы.  
  
## <a name="replacing-bound-mode"></a>Замещение связанного режима  
 Если связанный режим не удовлетворяет требованиям к производительности, вы можете управлять данными в пользовательском кэше посредством обработчиков событий в виртуальном режиме. Например, можно использовать виртуальный режим реализовать механизм, который извлекает только загрузки данных just-in-time столько данных из базы данных сети необходим для обеспечения оптимальной производительности. Этот сценарий является особенно полезна при работе с большими объемами данных через медленное сетевое подключение, так и с клиентскими компьютерами, которые имеют ограниченный объем оперативной памяти или дисковое пространство.  
  
 Дополнительные сведения об использовании виртуального режима в сценарии just-in-time, см. в разделе [реализация виртуального режима с JIT-загрузкой данных в элементе управления DataGridView Windows Forms](implementing-virtual-mode-jit-data-loading-in-the-datagrid.md).  
  
## <a name="virtual-mode-events"></a>Виртуальный режим события  
 Если ваши данные только для чтения, `CellValueNeeded` событий может быть единственным событием, вам потребуется обрабатывать. Дополнительные события виртуального режима позволяют включения определенных функций, таких как пользовательские изменения, добавления и удаления и строк транзакций на уровне строк.  
  
 Некоторые стандартные <xref:System.Windows.Forms.DataGridView> события (например, события, происходящие при добавлении пользователей или удаления строк или значений ячеек редактировать, синтаксический анализ, проверять или в формате) полезны в виртуальном режиме. Также можно обрабатывать события, которые позволяют поддерживать значения, обычно не хранящиеся в связанного источника данных, таких как текст подсказки для ячейки, ячейки и текст ошибки строки, ячейки и строки контекстное меню данных и данных высоты строк.  
  
 Дополнительные сведения о реализация виртуального режима для управления данными чтения и записи с областью фиксации на уровне строк, см. в разделе [Пошаговое руководство: Реализация виртуального режима в Windows Forms элемента управления DataGridView](implementing-virtual-mode-wf-datagridview-control.md).  
  
 Пример реализации виртуального режима с областью фиксации на уровне ячейки, см. в разделе <xref:System.Windows.Forms.DataGridView.VirtualMode%2A> свойство справочном разделе.  
  
 Следующие события возникают только при <xref:System.Windows.Forms.DataGridView.VirtualMode%2A> свойству `true`.  
  
|событие|Описание|  
|-----------|-----------------|  
|<xref:System.Windows.Forms.DataGridView.CellValueNeeded>|Используется элементом управления, извлекаемого из кэша данных для отображения значения ячейки. Это событие происходит только для ячеек в несвязанных столбцов.|  
|<xref:System.Windows.Forms.DataGridView.CellValuePushed>|Используется элементом управления для сохранения введенного пользователем для ячейки в кэш данных. Это событие происходит только для ячеек в несвязанных столбцов.<br /><br /> Вызовите <xref:System.Windows.Forms.DataGridView.UpdateCellValue%2A> метод при изменении кэшированное значение за пределами <xref:System.Windows.Forms.DataGridView.CellValuePushed> обработчик событий можно убедиться, что текущее значение отображается в элементе управления и применить любой режима автоматического изменения размеров в данный момент.|  
|<xref:System.Windows.Forms.DataGridView.NewRowNeeded>|Используется элементом управления для указания необходимости для новой строки в кэше данных.|  
|<xref:System.Windows.Forms.DataGridView.RowDirtyStateNeeded>|Используется элементом управления, чтобы определить, имеются ли в строке все незафиксированные изменения.|  
|<xref:System.Windows.Forms.DataGridView.CancelRowEdit>|Используется элементом управления для указания, что строке должны быть возвращены значения из кэша.|  
  
 Следующие события полезны в виртуальном режиме, но может использоваться вне зависимости от <xref:System.Windows.Forms.DataGridView.VirtualMode%2A> значение свойства.  
  
|События|Описание|  
|------------|-----------------|  
|<xref:System.Windows.Forms.DataGridView.UserDeletingRow><br /><br /> <xref:System.Windows.Forms.DataGridView.UserDeletedRow><br /><br /> <xref:System.Windows.Forms.DataGridView.RowsRemoved><br /><br /> <xref:System.Windows.Forms.DataGridView.RowsAdded>|Используется элементом управления, чтобы указать, когда строки удаляются или добавлен, что соответствующим образом обновить кэш данных.|  
|<xref:System.Windows.Forms.DataGridView.CellFormatting><br /><br /> <xref:System.Windows.Forms.DataGridView.CellParsing><br /><br /> <xref:System.Windows.Forms.DataGridView.CellValidating><br /><br /> <xref:System.Windows.Forms.DataGridView.CellValidated><br /><br /> <xref:System.Windows.Forms.DataGridView.RowValidating><br /><br /> <xref:System.Windows.Forms.DataGridView.RowValidated>|Используется элементом управления для форматирования значений ячеек для отображения, а также для анализа и проверки пользовательского ввода.|  
|<xref:System.Windows.Forms.DataGridView.CellToolTipTextNeeded>|Используется элементом управления для извлечения текста всплывающей подсказки для ячейки при <xref:System.Windows.Forms.DataGridView.DataSource%2A> свойству или <xref:System.Windows.Forms.DataGridView.VirtualMode%2A> свойство `true`.<br /><br /> Всплывающие подсказки для ячеек, отображаются только тогда, когда <xref:System.Windows.Forms.DataGridView.ShowCellToolTips%2A> свойство имеет значение `true`.|  
|<xref:System.Windows.Forms.DataGridView.CellErrorTextNeeded><br /><br /> <xref:System.Windows.Forms.DataGridView.RowErrorTextNeeded>|Используется элементом управления, чтобы получить текст ошибки ячейки или строки при <xref:System.Windows.Forms.DataGridView.DataSource%2A> свойству или <xref:System.Windows.Forms.DataGridView.VirtualMode%2A> свойство `true`.<br /><br /> Вызовите <xref:System.Windows.Forms.DataGridView.UpdateCellErrorText%2A> метод или <xref:System.Windows.Forms.DataGridView.UpdateRowErrorText%2A> при изменении текст ошибки ячейки или строки, чтобы убедиться, что текущее значение отображается в элементе управления.<br /><br /> Глиф ошибки ячейки и строки отображаются при <xref:System.Windows.Forms.DataGridView.ShowCellErrors%2A> и <xref:System.Windows.Forms.DataGridView.ShowRowErrors%2A> значений свойств, `true`.|  
|<xref:System.Windows.Forms.DataGridView.CellContextMenuStripNeeded><br /><br /> <xref:System.Windows.Forms.DataGridView.RowContextMenuStripNeeded>|Используется элементом управления для извлечения ячейки или строки <xref:System.Windows.Forms.ContextMenuStrip> при управления <xref:System.Windows.Forms.DataGridView.DataSource%2A> свойству или <xref:System.Windows.Forms.DataGridView.VirtualMode%2A> свойство `true`.|  
|<xref:System.Windows.Forms.DataGridView.RowHeightInfoNeeded><br /><br /> <xref:System.Windows.Forms.DataGridView.RowHeightInfoPushed>|Используется элементом управления для извлечения или сохранения сведений о высоте строки в кэше данных. Вызовите <xref:System.Windows.Forms.DataGridView.UpdateRowHeightInfo%2A> метод при изменении сведений о высоте кэшированной строке за пределами <xref:System.Windows.Forms.DataGridView.RowHeightInfoPushed> обработчик событий, чтобы убедиться, что текущее значение используется при отображении элемента управления.|  
  
## <a name="best-practices-in-virtual-mode"></a>Рекомендации в виртуальном режиме  
 Если вы реализуете виртуального режима для эффективной работы с большими объемами данных, также требуется убедиться, что вы работаете эффективно <xref:System.Windows.Forms.DataGridView> самого элемента управления. Дополнительные сведения об эффективном использовании стилей для ячейки, автоматическое изменение размеров, выбранные параметры и общий доступ к строкам, см. в разделе [масштабирование элемента управления DataGridView в Windows Forms](best-practices-for-scaling-the-windows-forms-datagridview-control.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridView.VirtualMode%2A>
- [Оптимизация производительности элемента управления DataGridView в Windows Forms](performance-tuning-in-the-windows-forms-datagridview-control.md)
- [Масштабирование элемента управления DataGridView в Windows Forms](best-practices-for-scaling-the-windows-forms-datagridview-control.md)
- [Пошаговое руководство. Реализация виртуального режима для элемента управления DataGridView в Windows Forms](implementing-virtual-mode-wf-datagridview-control.md)
- [Реализация виртуального режима с JIT-загрузкой данных для элемента управления DataGridView в Windows Forms](implementing-virtual-mode-jit-data-loading-in-the-datagrid.md)

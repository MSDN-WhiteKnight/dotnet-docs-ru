---
title: Стили ячеек элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- DataGridView control [Windows Forms], cell styles
- cells [Windows Forms], styles
- data grids [Windows Forms], cell styles
ms.assetid: dbb75ed6-8804-4232-8382-f9920c2e380c
ms.openlocfilehash: 41794c5ecadbcdc0b38c7c73afc7c010a4ea6989
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59300025"
---
# <a name="cell-styles-in-the-windows-forms-datagridview-control"></a>Стили ячеек элемента управления DataGridView в Windows Forms
Каждая ячейка в <xref:System.Windows.Forms.DataGridView> элемент управления может иметь свой собственный стиль, включая формат текста, цвет фона, цвет переднего плана и шрифта. Как правило Однако несколько ячеек будет обладают одинаковым стилем.  
  
 Группы ячеек, которые совместно используют стили могут включать все ячейки в пределах конкретных строк или столбцов, все ячейки, содержащие конкретные значения или все ячейки в элементе управления. Так как эти группы перекрываются, каждая ячейка может получать данные своего стиля из более чем в одном месте. Например, может потребоваться каждая ячейка <xref:System.Windows.Forms.DataGridView> элемент управления же шрифт, но только ячейки в столбцах для использования формат денежной единицы и только ячейки валюты с отрицательными числами для использования красный цвет.  
  
## <a name="the-datagridviewcellstyle-class"></a>Класс DataGridViewCellStyle  
 <xref:System.Windows.Forms.DataGridViewCellStyle> Класс содержит следующие свойства, относящиеся к стилю:  
  
-   <xref:System.Windows.Forms.DataGridViewCellStyle.BackColor%2A> и <xref:System.Windows.Forms.DataGridViewCellStyle.ForeColor%2A>  
  
-   <xref:System.Windows.Forms.DataGridViewCellStyle.SelectionBackColor%2A> и <xref:System.Windows.Forms.DataGridViewCellStyle.SelectionForeColor%2A>  
  
-   <xref:System.Windows.Forms.DataGridViewCellStyle.Font%2A>  
  
 Этот класс также содержит следующие свойства, связанные с форматированием:  
  
-   <xref:System.Windows.Forms.DataGridViewCellStyle.Format%2A> и <xref:System.Windows.Forms.DataGridViewCellStyle.FormatProvider%2A>  
  
-   <xref:System.Windows.Forms.DataGridViewCellStyle.NullValue%2A> и <xref:System.Windows.Forms.DataGridViewCellStyle.DataSourceNullValue%2A>  
  
-   <xref:System.Windows.Forms.DataGridViewCellStyle.WrapMode%2A>  
  
-   <xref:System.Windows.Forms.DataGridViewCellStyle.Alignment%2A>  
  
-   <xref:System.Windows.Forms.DataGridViewCellStyle.Padding%2A>  
  
 Дополнительные сведения об этих свойствах и другие свойства стиля ячейки, см. в разделе <xref:System.Windows.Forms.DataGridViewCellStyle> справочную документацию и разделы, перечисленные в разделе также см. в разделе ниже.  
  
## <a name="using-datagridviewcellstyle-objects"></a>Использование объектов DataGridViewCellStyle  
 Вы можете получить <xref:System.Windows.Forms.DataGridViewCellStyle> объектов из различных свойств <xref:System.Windows.Forms.DataGridView>, <xref:System.Windows.Forms.DataGridViewColumn>, <xref:System.Windows.Forms.DataGridViewRow>, и <xref:System.Windows.Forms.DataGridViewCell> классы и их производных классов. Если одно из этих свойств еще не было задано, его значение было получено создаст новый <xref:System.Windows.Forms.DataGridViewCellStyle> объекта. Можно также создать свои собственные <xref:System.Windows.Forms.DataGridViewCellStyle> объектов и назначить их этих свойств.  
  
 Можно избежать дублирования информации о стилях, предоставив <xref:System.Windows.Forms.DataGridViewCellStyle> объектов между несколькими <xref:System.Windows.Forms.DataGridView> элементов. Так как стили заданы элемента управления, столбца и фильтра строк уровней вниз через каждый уровень на уровне ячейки, можно избежать дублирования стилей, задав только те свойства стиля на каждом уровне, отличные от более высоких уровнях. Это описывается более подробно в следующем разделе наследования стиля.  
  
 В следующей таблице перечислены основные свойства, устанавливающие или получающие <xref:System.Windows.Forms.DataGridViewCellStyle> объектов.  
  
|Свойство|Классы|Описание|  
|--------------|-------------|-----------------|  
|`DefaultCellStyle`|<xref:System.Windows.Forms.DataGridView>, <xref:System.Windows.Forms.DataGridViewColumn>, <xref:System.Windows.Forms.DataGridViewRow>и производные классы|Возвращает или задает стили по умолчанию, используемые все ячейки в весь элемент управления, включая ячейки заголовков, в столбце или в строке.|  
|<xref:System.Windows.Forms.DataGridView.RowsDefaultCellStyle%2A>|<xref:System.Windows.Forms.DataGridView>|Возвращает или задает стили ячеек по умолчанию, используемые во всех строк в элементе управления. Сюда не входят ячейки заголовков.|  
|<xref:System.Windows.Forms.DataGridView.AlternatingRowsDefaultCellStyle%2A>|<xref:System.Windows.Forms.DataGridView>|Возвращает или задает стили ячеек по умолчанию, используемые чередующихся строк в элементе управления. Используется для создания эффекта бухгалтерской книги.|  
|<xref:System.Windows.Forms.DataGridView.RowHeadersDefaultCellStyle%2A>|<xref:System.Windows.Forms.DataGridView>|Возвращает или задает стили ячеек по умолчанию, используемые заголовки строк элемента управления. Переопределить текущей темы, если стили оформления включены.|  
|<xref:System.Windows.Forms.DataGridView.ColumnHeadersDefaultCellStyle%2A>|<xref:System.Windows.Forms.DataGridView>|Возвращает или задает стили ячеек по умолчанию, используемые заголовков столбцов элемента управления. Переопределить текущей темы, если стили оформления включены.|  
|<xref:System.Windows.Forms.DataGridViewCell.Style%2A>|<xref:System.Windows.Forms.DataGridViewCell> и производные классы|Возвращает или задает стили, заданные на уровне ячейки. Эти стили переопределить унаследованные от более высоких уровней.|  
|`InheritedStyle`|<xref:System.Windows.Forms.DataGridViewCell>, <xref:System.Windows.Forms.DataGridViewRow>, <xref:System.Windows.Forms.DataGridViewColumn>и производные классы|Получает все стили, примененных в настоящий момент для ячейки, строки или столбца, включая стили, унаследованные от более высоких уровнях.|  
  
 Как упоминалось выше, получение значения свойства стиля автоматически создает новый экземпляр <xref:System.Windows.Forms.DataGridViewCellStyle> объекта, если свойство не было задано ранее. Чтобы избежать без необходимости создания этих объектов, строк и столбцов классы имеют <xref:System.Windows.Forms.DataGridViewBand.HasDefaultCellStyle%2A> свойство, которое можно проверить, чтобы определить ли <xref:System.Windows.Forms.DataGridViewBand.DefaultCellStyle%2A> свойства. Аналогично, классы ячейки имеют <xref:System.Windows.Forms.DataGridViewCell.HasStyle%2A> свойство, указывающее ли <xref:System.Windows.Forms.DataGridViewCell.Style%2A> свойства.  
  
 Каждое из свойств стиля имеет соответствующий *PropertyName* `Changed` событий на <xref:System.Windows.Forms.DataGridView> элемента управления. Для строк, столбцов и свойств ячеек, имя события начинается с "`Row`«,»`Column`«, или"`Cell`"(например, <xref:System.Windows.Forms.DataGridView.RowDefaultCellStyleChanged>). Каждое из этих событий происходит, когда соответствующее свойство стиля присваивается другой <xref:System.Windows.Forms.DataGridViewCellStyle> объекта. Эти события не происходят при извлечении <xref:System.Windows.Forms.DataGridViewCellStyle> объекта из свойства стиля и изменении значений его свойств. Реагировать на изменения к самим объектам стиль ячейки, обрабатывать <xref:System.Windows.Forms.DataGridView.CellStyleContentChanged> событий.  
  
## <a name="style-inheritance"></a>Наследование стилей  
 Каждый <xref:System.Windows.Forms.DataGridViewCell> получает его внешний вид, от его <xref:System.Windows.Forms.DataGridViewCell.InheritedStyle%2A> свойство. <xref:System.Windows.Forms.DataGridViewCellStyle> Объект, возвращаемый этим свойством наследует значения из иерархии свойств типа <xref:System.Windows.Forms.DataGridViewCellStyle>. Эти свойства перечислены ниже в порядке, в котором <xref:System.Windows.Forms.DataGridViewCell.InheritedStyle%2A> для верхнего колонтитула ячеек получает свои значения.  
  
1. <xref:System.Windows.Forms.DataGridViewCell.Style%2A?displayProperty=nameWithType>  
  
2. <xref:System.Windows.Forms.DataGridViewRow.DefaultCellStyle%2A?displayProperty=nameWithType>  
  
3. <xref:System.Windows.Forms.DataGridView.AlternatingRowsDefaultCellStyle%2A?displayProperty=nameWithType> (только для ячеек в строках нечетных)  
  
4. <xref:System.Windows.Forms.DataGridView.RowsDefaultCellStyle%2A?displayProperty=nameWithType>  
  
5. <xref:System.Windows.Forms.DataGridViewColumn.DefaultCellStyle%2A?displayProperty=nameWithType>  
  
6. <xref:System.Windows.Forms.DataGridView.DefaultCellStyle%2A?displayProperty=nameWithType>  
  
 Для ячеек заголовков строк и столбцов <xref:System.Windows.Forms.DataGridViewCell.InheritedStyle%2A> свойство заполняется значениями из следующего списка исходных свойств в заданном порядке.  
  
1. <xref:System.Windows.Forms.DataGridViewCell.Style%2A?displayProperty=nameWithType>  
  
2. <xref:System.Windows.Forms.DataGridView.ColumnHeadersDefaultCellStyle%2A?displayProperty=nameWithType> или <xref:System.Windows.Forms.DataGridView.RowHeadersDefaultCellStyle%2A?displayProperty=nameWithType>  
  
3. <xref:System.Windows.Forms.DataGridView.DefaultCellStyle%2A?displayProperty=nameWithType>  
  
 Следующая диаграмма иллюстрирует этот процесс.  
  
 ![Свойства типа DataGridViewCellStyle](./media/cell-styles-in-the-windows-forms-datagridview-control/datagridviewcells-inheritance-diagram.gif "DataGridViewCells диаграмма наследования")  
  
 Также можно получить доступ к стилям, унаследованным от определенных строк и столбцов. Столбец <xref:System.Windows.Forms.DataGridViewColumn.InheritedStyle%2A> свойство наследует значения от следующие свойства.  
  
1. <xref:System.Windows.Forms.DataGridViewColumn.DefaultCellStyle%2A?displayProperty=nameWithType>  
  
2. <xref:System.Windows.Forms.DataGridView.DefaultCellStyle%2A?displayProperty=nameWithType>  
  
 Строки <xref:System.Windows.Forms.DataGridViewRow.InheritedStyle%2A> свойство наследует значения от следующие свойства.  
  
1. <xref:System.Windows.Forms.DataGridViewRow.DefaultCellStyle%2A?displayProperty=nameWithType>  
  
2. <xref:System.Windows.Forms.DataGridView.AlternatingRowsDefaultCellStyle%2A?displayProperty=nameWithType> (только для ячеек в строках нечетных)  
  
3. <xref:System.Windows.Forms.DataGridView.RowsDefaultCellStyle%2A?displayProperty=nameWithType>  
  
4. <xref:System.Windows.Forms.DataGridView.DefaultCellStyle%2A?displayProperty=nameWithType>  
  
 Для каждого свойства <xref:System.Windows.Forms.DataGridViewCellStyle> объект, возвращаемый `InheritedStyle` свойство, значение свойства получено из первого стиля ячейки в соответствующем списке, имеющий соответствующее свойство присвоено значение, отличное от <xref:System.Windows.Forms.DataGridViewCellStyle> класса значения по умолчанию.  
  
 В следующей таблице показано как <xref:System.Windows.Forms.DataGridViewCellStyle.ForeColor%2A> унаследован от столбца, в котором значение свойства ячейка.  
  
|свойство типа `DataGridViewCellStyle`|Пример `ForeColor` значение для полученного объекта|  
|----------------------------------------------|----------------------------------------------------|  
|<xref:System.Windows.Forms.DataGridViewCell.Style%2A?displayProperty=nameWithType>|<xref:System.Drawing.Color.Empty?displayProperty=nameWithType>|  
|<xref:System.Windows.Forms.DataGridViewRow.DefaultCellStyle%2A?displayProperty=nameWithType>|<xref:System.Drawing.Color.Red%2A?displayProperty=nameWithType>|  
|<xref:System.Windows.Forms.DataGridView.AlternatingRowsDefaultCellStyle%2A?displayProperty=nameWithType>|<xref:System.Drawing.Color.Empty?displayProperty=nameWithType>|  
|<xref:System.Windows.Forms.DataGridView.RowsDefaultCellStyle%2A?displayProperty=nameWithType>|<xref:System.Drawing.Color.Empty?displayProperty=nameWithType>|  
|<xref:System.Windows.Forms.DataGridViewColumn.DefaultCellStyle%2A?displayProperty=nameWithType>|<xref:System.Drawing.Color.DarkBlue%2A?displayProperty=nameWithType>|  
|<xref:System.Windows.Forms.DataGridView.DefaultCellStyle%2A?displayProperty=nameWithType>|<xref:System.Drawing.Color.Black%2A?displayProperty=nameWithType>|  
  
 В этом случае <xref:System.Drawing.Color.Red%2A?displayProperty=nameWithType> значение из строки ячейки является первым действительным значением в списке. Это становится <xref:System.Windows.Forms.DataGridViewCellStyle.ForeColor%2A> значение свойства ячейки <xref:System.Windows.Forms.DataGridViewCell.InheritedStyle%2A>.  
  
 На следующей схеме показано как разные <xref:System.Windows.Forms.DataGridViewCellStyle> свойства могут наследовать значения из различных мест.  
  
 ![Свойство DataGridView&#45;наследование значения](./media/cell-styles-in-the-windows-forms-datagridview-control/datagridviewcells-value-inheritance-diagram.gif "схема наследования DataGridViewCells значение")  
  
 Используя преимущества наследования стиля, можно предоставить соответствующие стили для всего элемента управления без необходимости указывать те же данные в нескольких местах.  
  
 Несмотря на то, что ячейки заголовка участвуют в наследовании style, как описано, объекты, возвращаемые <xref:System.Windows.Forms.DataGridView.ColumnHeadersDefaultCellStyle%2A> и <xref:System.Windows.Forms.DataGridView.RowHeadersDefaultCellStyle%2A> свойства <xref:System.Windows.Forms.DataGridView> элемент управления имеет исходные значения свойств, которые переопределяют значения свойств объекта, возвращаемого <xref:System.Windows.Forms.DataGridView.DefaultCellStyle%2A> свойство. Если необходимо, чтобы свойства, заданные для объекта, возвращаемого <xref:System.Windows.Forms.DataGridView.DefaultCellStyle%2A> свойство для применения к заголовки строк и столбцов, необходимо задать соответствующие свойства объектов, возвращенных <xref:System.Windows.Forms.DataGridView.ColumnHeadersDefaultCellStyle%2A> и <xref:System.Windows.Forms.DataGridView.RowHeadersDefaultCellStyle%2A> указанного свойства по умолчанию для <xref:System.Windows.Forms.DataGridViewCellStyle> класса.  
  
> [!NOTE]
>  Если стили оформления включены, заголовки строк и столбцов (за исключением <xref:System.Windows.Forms.DataGridView.TopLeftHeaderCell%2A>) автоматически определяются текущей темы, заменяя все стили, указанные для этих свойств.  
  
 <xref:System.Windows.Forms.DataGridViewButtonColumn>, <xref:System.Windows.Forms.DataGridViewImageColumn>, И <xref:System.Windows.Forms.DataGridViewCheckBoxColumn> типы также инициализируют некоторые значения объекта, возвращаемого в столбце <xref:System.Windows.Forms.DataGridViewColumn.DefaultCellStyle%2A> свойство. Дополнительные сведения см. в справочной документации для этих типов.  
  
## <a name="setting-styles-dynamically"></a>Динамическая установка стилей  
 Чтобы настроить стили ячеек с определенными значениями, Реализуйте обработчик <xref:System.Windows.Forms.DataGridView.CellFormatting?displayProperty=nameWithType> событий. Обработчики для этого события получают аргумент <xref:System.Windows.Forms.DataGridViewCellFormattingEventArgs> типа. Этот объект содержит свойства, позволяющие определить значение ячейки, подлежащего форматированию вместе с ним месте в <xref:System.Windows.Forms.DataGridView> элемента управления. Этот объект также содержит <xref:System.Windows.Forms.DataGridViewCellFormattingEventArgs.CellStyle%2A> свойство, которое инициализируется значение <xref:System.Windows.Forms.DataGridViewCell.InheritedStyle%2A> свойство форматируемой ячейки. Можно изменить свойства стиля ячейки, чтобы указать сведения о стиле, подходящие для значения ячейки и расположение.  
  
> [!NOTE]
>  <xref:System.Windows.Forms.DataGridView.RowPrePaint> И <xref:System.Windows.Forms.DataGridView.RowPostPaint> события также получения <xref:System.Windows.Forms.DataGridViewCellStyle> данных объектов событий, но в их случае это копия строки <xref:System.Windows.Forms.DataGridViewRow.InheritedStyle%2A> свойство только для чтения и изменения не влияют на элемент управления.  
  
 Можно также динамически изменять стили вид отдельных ячеек в ответ на события например <xref:System.Windows.Forms.DataGridView.CellMouseEnter?displayProperty=nameWithType> и <xref:System.Windows.Forms.DataGridView.CellMouseLeave> события. Например, в обработчике <xref:System.Windows.Forms.DataGridView.CellMouseEnter> событий, можно сохранить текущее значение цвет фона ячейки (извлечь с помощью ячейки <xref:System.Windows.Forms.DataGridViewCell.Style%2A> свойства), установите его в новый цвет, который будут выделите ячейку, при наведении указателя мыши. В обработчике <xref:System.Windows.Forms.DataGridView.CellMouseLeave> событий, вы сможете восстановить цвет фона в исходное значение.  
  
> [!NOTE]
>  Кэширование значений, хранящихся в ячейки <xref:System.Windows.Forms.DataGridViewCell.Style%2A> свойство важно независимо от установленного значения определенного стиля. Если временно заменить параметр стиля, его восстановление в исходное состояние «не установлено» гарантирует, что ячейки вернется к наследовать этот параметр стиля с более высокого уровня. Если вам нужно определить текущий стиль, установленный для ячейки независимо от того, наследуется ли стиль, используем свойство ячейки <xref:System.Windows.Forms.DataGridViewCell.InheritedStyle%2A> свойство.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridViewCellStyle>
- <xref:System.Windows.Forms.DataGridView.AlternatingRowsDefaultCellStyle%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.ColumnHeadersDefaultCellStyle%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.DefaultCellStyle%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.RowHeadersDefaultCellStyle%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.RowsDefaultCellStyle%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewBand.InheritedStyle%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewRow.InheritedStyle%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewColumn.InheritedStyle%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewBand.DefaultCellStyle%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewCell.InheritedStyle%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewCell.Style%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.CellFormatting?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.CellStyleContentChanged?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.RowPrePaint?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.RowPostPaint?displayProperty=nameWithType>
- [Базовое форматирование и оформление элемента управления DataGridView в Windows Forms](basic-formatting-and-styling-in-the-windows-forms-datagridview-control.md)
- [Практическое руководство. Установка стилей ячейки по умолчанию для элемента управления DataGridView в Windows Forms](how-to-set-default-cell-styles-for-the-windows-forms-datagridview-control.md)
- [Форматирование данных в элементе управления DataGridView в Windows Forms](data-formatting-in-the-windows-forms-datagridview-control.md)

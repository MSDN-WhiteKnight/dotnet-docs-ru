---
title: Изменение размеров управления DataGridView в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- DataGridView control [Windows Forms], row sizing
- data grids [Windows Forms], column sizing
- DataGridView control [Windows Forms], column sizing
- DataGridView control [Windows Forms], sizing options
- data grids [Windows Forms], row sizing
- data grids [Windows Forms], sizing options
ms.assetid: a5620a9c-0d06-41e3-8934-c25ddb16c9e6
ms.openlocfilehash: 2f76bbca3d4b6e642c0eec2129c4a2abee752655
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59197845"
---
# <a name="sizing-options-in-the-windows-forms-datagridview-control"></a>Изменение размеров управления DataGridView в Windows Forms
<xref:System.Windows.Forms.DataGridView> размер во многих случаях можно изменить строк, столбцов и заголовков. В следующей таблице показаны эти случаи.  
  
|вхождения|Описание|  
|----------------|-----------------|  
|Изменение размера пользователем|Пользователи могут изменять размеры, перетащив или дважды щелкнув строки, столбца или заголовок разделителей.|  
|Изменение размеров элемента управления|В режиме заполнения столбцов изменение ширины столбцов при изменении ширины элемента управления; Например, когда элемент управления подключено к ее родительской формы и пользователем размера формы.|  
|Изменение значения ячейки|В режимах автоматического изменения размеров на основе содержимого размеры изменяются в соответствии с новой отображаемых значений.|  
|Вызов метода|Программное изменение размеров на основе содержимого позволяет добиться гибкой корректировки размеров на основе значений ячеек во время вызова метода.|  
|Значение свойства|Можно также задать значения определенных высоты и ширины.|  
  
 По умолчанию изменение размеров пользователем включено, отключено автоматическое изменение размеров и обрезаются значения ячеек, которые шире, чем их столбцов.  
  
 Ниже приведены сценарии можно использовать для изменения поведения по умолчанию или использовать параметры конкретного изменения размера для достижения определенного эффектов.  
  
|Сценарий|Реализация|  
|--------------|--------------------|  
|Использование режима заполнения столбца для отображения различить по размеру данных в относительно небольшое количество столбцов, которые занимают всю ширину элемента управления без отображения горизонтальной полосы прокрутки.|Задайте для свойства <xref:System.Windows.Forms.DataGridView.AutoSizeColumnsMode%2A> значение <xref:System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill>.|  
|Использование режима заполнения столбца с отображают значения разного размера.|Задайте для свойства <xref:System.Windows.Forms.DataGridView.AutoSizeColumnsMode%2A> значение <xref:System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill>. Инициализируйте относительную ширину столбцов путем присвоения столбцу <xref:System.Windows.Forms.DataGridViewColumn.FillWeight%2A> свойства или путем вызова элемента управления <xref:System.Windows.Forms.DataGridView.AutoResizeColumns%2A> метод после заполнения элемента управления данными.|  
|Использование режима заполнения столбца со значениями различной важности.|Задайте для свойства <xref:System.Windows.Forms.DataGridView.AutoSizeColumnsMode%2A> значение <xref:System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill>. Значение велико <xref:System.Windows.Forms.DataGridViewColumn.MinimumWidth%2A> значения для столбцов, которые всегда должна отображаться часть данных или использовать параметр изменения размера, отличное от заполнения режиме для определенных столбцов.|  
|Использование режима заполнения, чтобы избежать отображения фон элемента управления.|Задайте <xref:System.Windows.Forms.DataGridViewColumn.AutoSizeMode%2A> свойства последнего столбца для <xref:System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill> и использовать другие параметры изменения размеров для других столбцов. Если другие столбцы использовать слишком много дискового пространства, задайте <xref:System.Windows.Forms.DataGridViewColumn.MinimumWidth%2A> свойства последнего столбца.|  
|Отобразить столбец фиксированной ширины, например значка или столбец идентификатора.|Задайте <xref:System.Windows.Forms.DataGridViewColumn.AutoSizeMode%2A> для <xref:System.Windows.Forms.DataGridViewAutoSizeColumnMode.None> и <xref:System.Windows.Forms.DataGridViewColumn.Resizable%2A> для <xref:System.Windows.Forms.DataGridViewTriState.False> для столбца. Инициализируйте его ширину, задав <xref:System.Windows.Forms.DataGridViewColumn.Width%2A> свойства или путем вызова элемента управления <xref:System.Windows.Forms.DataGridView.AutoResizeColumn%2A> метод после заполнения элемента управления данными.|  
|Автоматическое изменение размеров при каждом изменении содержимого ячейки во избежание обрезки и оптимизировать использование места.|Задание автоматического изменения размера свойству значение, представляющее режим изменения размеров на основе содержимого. Чтобы избежать снижения производительности при работе с большими объемами данных, используйте режим изменения размеров, которая вычисляет отображаются только строки.|  
|Изменение размеров в зависимости от значений в отображаемых строках, чтобы избежать снижения производительности при работе с большим количеством строк.|Используйте соответствующее перечисление режим изменения размеров значения с автоматическое или программное изменение размера. Чтобы изменение размеров в зависимости значения во вновь отображаемых строках при прокрутке, вызовите метод изменения размеров <xref:System.Windows.Forms.DataGridView.Scroll> обработчик событий. Для настройки двойного щелчка пользователем изменение размера таким образом, чтобы только значения в отображаемых строках определения нового размера, вызовите метод изменения размеров <xref:System.Windows.Forms.DataGridView.RowDividerDoubleClick> или <xref:System.Windows.Forms.DataGridView.ColumnDividerDoubleClick> обработчик событий.|  
|Изменение размеров, чтобы вместить содержимое ячейки только в определенное время, чтобы избежать снижения производительности или включить изменение размера пользователем.|Вызовите метод изменения размеров на основе содержимого в обработчике событий. Например, использовать <xref:System.Windows.Forms.DataGridView.DataBindingComplete> событий для инициализации размеров после привязки и обработки <xref:System.Windows.Forms.DataGridView.CellValidated> или <xref:System.Windows.Forms.DataGridView.CellValueChanged> событий для контроля размера, чтобы компенсировать изменений пользователем, или изменений в связанном источнике данных.|  
|Изменение высоты строк для многострочного содержимого ячеек.|Убедитесь, что ширина столбцов подходит для отображения абзацы текста и использовать изменения размера автоматического или программный строк на основе содержимого для изменения высоты. Также убедитесь, что ячейки с многострочным содержимым отображаются с помощью <xref:System.Windows.Forms.DataGridViewCellStyle.WrapMode%2A> стиля значение из ячейки <xref:System.Windows.Forms.DataGridViewTriState.True>.<br /><br /> Как правило для сохранения ширины столбцов или задать для них определенную ширину до высоты строк используется автоматический режим изменения размеров.|  
  
## <a name="resizing-with-the-mouse"></a>Изменение размеров с помощью мыши  
 По умолчанию пользователь может изменять размер строк, столбцов и заголовков, которые не использовать режим автоматического изменения размеров на основе значений ячеек. Чтобы запретить пользователям изменение размеров в других режимах, например в режиме заполнения столбцов, задайте одно или несколько из следующих <xref:System.Windows.Forms.DataGridView> свойства:  
  
-   <xref:System.Windows.Forms.DataGridView.AllowUserToResizeColumns%2A>  
  
-   <xref:System.Windows.Forms.DataGridView.AllowUserToResizeRows%2A>  
  
-   <xref:System.Windows.Forms.DataGridView.ColumnHeadersHeightSizeMode%2A>  
  
-   <xref:System.Windows.Forms.DataGridView.RowHeadersWidthSizeMode%2A>  
  
 Вы можете также запретить пользователям изменять размеры отдельных строк или столбцов, задав их <xref:System.Windows.Forms.DataGridViewBand.Resizable%2A> свойства. По умолчанию <xref:System.Windows.Forms.DataGridViewBand.Resizable%2A> зависит от значения свойства <xref:System.Windows.Forms.DataGridView.AllowUserToResizeColumns%2A> значение свойства для столбцов и <xref:System.Windows.Forms.DataGridView.AllowUserToResizeRows%2A> значение свойства для строк. Если явно задать <xref:System.Windows.Forms.DataGridViewBand.Resizable%2A> для <xref:System.Windows.Forms.DataGridViewTriState.True> или <xref:System.Windows.Forms.DataGridViewTriState.False>, но при этом указанное значение переопределяет значение элемента управления — для строки или столбца. Задайте <xref:System.Windows.Forms.DataGridViewBand.Resizable%2A> для <xref:System.Windows.Forms.DataGridViewTriState.NotSet> восстановить наследование.  
  
 Так как <xref:System.Windows.Forms.DataGridViewTriState.NotSet> восстанавливает наследование значения, <xref:System.Windows.Forms.DataGridViewBand.Resizable%2A> не будет возвращать <xref:System.Windows.Forms.DataGridViewTriState.NotSet> пока строка или столбец не был добавлен к <xref:System.Windows.Forms.DataGridView> элемента управления. Если вам нужно определить ли <xref:System.Windows.Forms.DataGridViewBand.Resizable%2A> унаследовано значение свойства строки или столбца, и проверьте его <xref:System.Windows.Forms.DataGridViewElement.State%2A> свойство. Если <xref:System.Windows.Forms.DataGridViewElement.State%2A> значение включает <xref:System.Windows.Forms.DataGridViewElementStates.ResizableSet> флаг, <xref:System.Windows.Forms.DataGridViewBand.Resizable%2A> значение свойства не является унаследованным.  
  
## <a name="automatic-sizing"></a>Автоматическое изменение размеров  
 Существует два типа автоматического изменения размеров в <xref:System.Windows.Forms.DataGridView> управления: режим заполнения столбца и автоматического изменения размеров на основе содержимого.  
  
 Режим заполнения столбца приводит к видимых столбцов в элементе управления для заполнения отображаемой области элемента управления. Дополнительные сведения об этом режиме см. в разделе [режим заполнения столбцов в элементе управления DataGridView Windows Forms](column-fill-mode-in-the-windows-forms-datagridview-control.md).  
  
 Можно также настроить строк, столбцов и заголовков на автоматическое изменение размеров в соответствии с содержимым ячейки. В этом случае изменение размера происходит при каждом изменении содержимого ячейки.  
  
> [!NOTE]
>  Если необходимо сохранить значения ячеек в кэше пользовательских данных в виртуальном режиме, автоматическое изменение размеров происходит, когда пользователь редактирует значение ячейки, но не возникает, если кэшированное значение за пределами <xref:System.Windows.Forms.DataGridView.CellValuePushed> обработчик событий. В этом случае вызов <xref:System.Windows.Forms.DataGridView.UpdateCellValue%2A> способ принудительного обновления отображения ячейки и применить текущих режимов автоматического изменения размеров элемента управления.  
  
 При включении автоматического изменения размеров на основе содержимого только для одного измерения —, есть, для строк, а не столбцы или столбцы, а не строки, и <xref:System.Windows.Forms.DataGridViewCellStyle.WrapMode%2A> является также включен, размер изменяется при каждом изменении другого измерения. Например, если строки, но не столбцов настроены для автоматического изменения размера и <xref:System.Windows.Forms.DataGridViewCellStyle.WrapMode%2A> — включена, пользователи смогут перетаскивать разделители столбцов, изменение ширины столбца и высоты строк автоматически настроит для по-прежнему полностью отображения содержимого ячейки.  
  
 Если вы настраиваете строк и столбцов для автоматического изменения размеров на основе содержимого и <xref:System.Windows.Forms.DataGridViewCellStyle.WrapMode%2A> включен, <xref:System.Windows.Forms.DataGridView> управления настроит размеры при изменении содержимого ячейки и будет использовать соотношения высоты и ширины ячейки, при вычислении новых размеров.  
  
 Чтобы настроить режим изменения размеров для заголовков и строк и столбцов, которые не переопределяют значение элемента управления, задайте одно или несколько из следующих <xref:System.Windows.Forms.DataGridView> свойства:  
  
-   <xref:System.Windows.Forms.DataGridView.ColumnHeadersHeightSizeMode%2A>  
  
-   <xref:System.Windows.Forms.DataGridView.RowHeadersWidthSizeMode%2A>  
  
-   <xref:System.Windows.Forms.DataGridView.AutoSizeColumnsMode%2A>  
  
-   <xref:System.Windows.Forms.DataGridView.AutoSizeRowsMode%2A>  
  
 Чтобы переопределить режим изменения размеров столбца элемента управления для отдельного столбца, задайте его <xref:System.Windows.Forms.DataGridViewColumn.AutoSizeMode%2A> присваивается значение, отличное от <xref:System.Windows.Forms.DataGridViewAutoSizeColumnMode.NotSet>. Режим изменения размеров для столбца фактически определяется его <xref:System.Windows.Forms.DataGridViewColumn.InheritedAutoSizeMode%2A> свойство. Значение этого свойства основан на столбце <xref:System.Windows.Forms.DataGridViewColumn.AutoSizeMode%2A> значение свойства, если это значение не <xref:System.Windows.Forms.DataGridViewAutoSizeColumnMode.NotSet>в этом случае элемента управления <xref:System.Windows.Forms.DataGridView.AutoSizeColumnsMode%2A> значение наследуется.  
  
 Используйте по содержимому автоматическое изменение размеров с осторожностью при работе с большими объемами данных. Чтобы избежать снижения производительности, используйте режима автоматического изменения размеров, которые вычисляют размеров на основе только отображаемых строк, а не анализ каждой строки в элементе управления. Для достижения максимальной производительности используйте программное изменение размеров, таким образом, можно изменить размер в определенное время, например сразу же после новых данных загружается.  
  
 Режимы автоматического изменения размеров на основе содержимого не влияют на строки, столбцы или заголовки, которые скрыты, задав строку или столбец <xref:System.Windows.Forms.DataGridViewBand.Visible%2A> свойство или элемент управления <xref:System.Windows.Forms.DataGridView.RowHeadersVisible%2A> или <xref:System.Windows.Forms.DataGridView.ColumnHeadersVisible%2A> свойства `false`. Например если столбец является скрытым после подбираться автоматически в соответствии с большого значения ячейки, скрытый столбец будет не изменять свой размер при удалении строки, содержащей большим значением ячейки. Автоматическое изменение размеров не происходит при изменении видимости, поэтому изменение столбца <xref:System.Windows.Forms.DataGridViewColumn.Visible%2A> обратно на `true` не приведет к пересчету его размера, в зависимости от его текущего содержимого.  
  
 Программное изменение размеров на основе содержимого влияет на строки, столбцы и заголовки независимо от их видимости.  
  
## <a name="programmatic-resizing"></a>Программное изменение размеров  
 При отключении автоматического изменения размера, можно программно установить точную ширину или высоту строк, столбцов или заголовки через следующие свойства:  
  
-   <xref:System.Windows.Forms.DataGridView.RowHeadersWidth%2A?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Forms.DataGridView.ColumnHeadersHeight%2A?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Forms.DataGridViewRow.Height%2A?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Forms.DataGridViewColumn.Width%2A?displayProperty=nameWithType>  
  
 Можно также программно изменить размер строк, столбцов и заголовков по их содержимому, используя следующие методы:  
  
-   <xref:System.Windows.Forms.DataGridView.AutoResizeColumn%2A>  
  
-   <xref:System.Windows.Forms.DataGridView.AutoResizeColumns%2A>  
  
-   <xref:System.Windows.Forms.DataGridView.AutoResizeColumnHeadersHeight%2A>  
  
-   <xref:System.Windows.Forms.DataGridView.AutoResizeRow%2A>  
  
-   <xref:System.Windows.Forms.DataGridView.AutoResizeRows%2A>  
  
-   <xref:System.Windows.Forms.DataGridView.AutoResizeRowHeadersWidth%2A>  
  
 Эти методы изменяют размеры строк, столбцов, или один раз заголовки не настроены на постоянное изменение размеров. Новые размеры вычисляются автоматически, чтобы отобразить все содержимое ячейки без обрезки. Если программно изменить размеры столбцов, имеющих <xref:System.Windows.Forms.DataGridViewColumn.InheritedAutoSizeMode%2A> значения свойств <xref:System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill>, тем не менее, рассчитанных значений ширины по содержимому используются для пропорционального изменения <xref:System.Windows.Forms.DataGridViewColumn.FillWeight%2A> значения свойств и фактически столбец, значения ширины Затем рассчитывается в соответствии с этим новым соотношениям, таким образом, все столбцы заполняли доступную область отображения элемента управления.  
  
 Программное изменение размеров позволяет избежать снижения производительности при постоянное изменение размеров. Это также полезно для предоставления исходные размеры пользователь изменять размер строк, столбцов и заголовков и режима заполнения.  
  
 Обычно, будет вызывать методы программного изменения размеров в определенное время. Например программно изменить размеры всех столбцов сразу после загрузки данных, или может программно изменить размеры конкретной строки после изменения определенного значения ячейки.  
  
## <a name="customizing-content-based-sizing-behavior"></a>Настройка размеров на основе содержимого  
 Поведение размеров можно настроить при работе с производными <xref:System.Windows.Forms.DataGridView> типов ячеек, строк и столбцов путем переопределения <xref:System.Windows.Forms.DataGridViewCell.GetPreferredSize%2A?displayProperty=nameWithType>, <xref:System.Windows.Forms.DataGridViewRow.GetPreferredHeight%2A?displayProperty=nameWithType>, или <xref:System.Windows.Forms.DataGridViewColumn.GetPreferredWidth%2A?displayProperty=nameWithType> методы или вызвав защищенные перегрузки методов изменения размеров в производном <xref:System.Windows.Forms.DataGridView> элемент управления. Защищенные перегрузки методов изменения размеров предназначены для работы в парах для достижения соотношения высоты и ширины ячейки, как избежать чрезмерно ширину или высоту ячейки. Например, если вы вызываете `AutoResizeRows(DataGridViewAutoSizeRowsMode,Boolean)` перегрузки <xref:System.Windows.Forms.DataGridView.AutoResizeRows%2A> метод и передать значение `false` для <xref:System.Boolean> параметра, перегрузка вычислит Идеальная высота и ширина для ячейки в строке, но она изменит значения высоты строк только. Затем необходимо вызвать <xref:System.Windows.Forms.DataGridView.AutoResizeColumns%2A> метод, чтобы ширина столбца в вычисляемых идеальный вариант.  
  
## <a name="content-based-sizing-options"></a>Параметры изменения размеров на основе содержимого  
 Перечисления, используемые свойствами изменения размеров и методы имеют одинаковые значения для изменения размеров на основе содержимого. Эти значения можно ограничить ячейки, которые используются для вычисления желаемые размеры. Для всех перечислений изменения размеров значения с именами, которые ссылаются на отображаемых ячеек ограничивают вычисления ячейками в отображаемых строках. За исключением строк способ позволяет избежать снижения производительности при работе с большим числом строк. Также можно ограничить вычисления значения в ячейках заголовка или ячейки.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridView.AllowUserToResizeColumns%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.AllowUserToResizeRows%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.ColumnHeadersHeightSizeMode%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.RowHeadersWidthSizeMode%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewBand.Resizable%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.AutoSizeColumnsMode%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.AutoSizeRowsMode%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewColumn.AutoSizeMode%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewColumn.InheritedAutoSizeMode%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.RowHeadersWidth%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.ColumnHeadersHeight%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewRow.Height%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewColumn.Width%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.AutoResizeColumn%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.AutoResizeColumns%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.AutoResizeColumnHeadersHeight%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.AutoResizeRow%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.AutoResizeRows%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.AutoResizeRowHeadersWidth%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewAutoSizeRowMode>
- <xref:System.Windows.Forms.DataGridViewAutoSizeRowsMode>
- <xref:System.Windows.Forms.DataGridViewAutoSizeColumnMode>
- <xref:System.Windows.Forms.DataGridViewAutoSizeColumnsMode>
- <xref:System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode>
- <xref:System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode>
- [Изменение размера столбцов и строк элемента управления DataGridView в Windows Forms](resizing-columns-and-rows-in-the-windows-forms-datagridview-control.md)
- [Установка режимов заполнения для столбцов элемента управления DataGridView в Windows Forms](column-fill-mode-in-the-windows-forms-datagridview-control.md)
- [Практическое руководство. Режимы изменения размеров элемента управления DataGridView в Windows Forms](how-to-set-the-sizing-modes-of-the-windows-forms-datagridview-control.md)

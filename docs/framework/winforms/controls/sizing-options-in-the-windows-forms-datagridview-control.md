---
title: Изменение размеров элементов DataGridView в Windows Forms
ms.date: 03/30/2017
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
---
# <a name="sizing-options-in-the-windows-forms-datagridview-control"></a>Изменение размеров элементов DataGridView в Windows Forms
Размер строк, столбцов и заголовков <xref:System.Windows.Forms.DataGridView> во многих случаях может изменяться. В следующей таблице показаны эти случаи.  
  
|Случай|Описание|  
|----------------|-----------------|  
|Изменение размера пользователем|Пользователи могут изменять размеры, перетащив или дважды щелкнув разделители строки, столбца или заголовка.|  
|Изменение размеров элемента управления|В режиме заполнения столбцов ширина столбцов изменяется при изменении ширины элемента управления, например, когда он добавлен в форму и пользователь изменяет размер родительской формы.|  
|Изменение значения ячейки|В режимах автоматического изменения размеров на основе содержимого размеры изменяются в соответствии с новым отображаемым значением.|  
|Вызов метода|Программное изменение размеров на основе содержимого позволяет добиться гибкой корректировки размеров на основе значений ячеек во время вызова метода.|  
|Изменения значения свойств|Можно также задать определенные значения высоты и ширины, присваивая значения свойств.|  
  
 По умолчанию изменение размеров пользователем включено, автоматическое изменение размеров отключено и значения ячеек, которые не помещаются в столбец по ширине, обрезаются.  
  
 Ниже приведены сценарии, которые можно использовать для изменения поведения по умолчанию или для изменения конкретных параметров размера элементов с целью достижения определенного результата.
  
|Сценарий|Реализация|  
|--------------|--------------------|  
|Использование режима заполнения столбца для отображения сходных по размеру данных при относительно небольшом количестве столбцов, которые занимают всю ширину элемента управления, без отображения горизонтальной полосы прокрутки.|Задайте для свойства <xref:System.Windows.Forms.DataGridView.AutoSizeColumnsMode%2A> значение <xref:System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill>.|  
|Использование режима заполнения столбца для отображения значений разного размера.|Задайте для свойства <xref:System.Windows.Forms.DataGridView.AutoSizeColumnsMode%2A> значение <xref:System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill>. Инициализируйте относительную ширину столбцов путем присвоения свойства столбца <xref:System.Windows.Forms.DataGridViewColumn.FillWeight%2A> или путем вызова метода <xref:System.Windows.Forms.DataGridView.AutoResizeColumns%2A> после заполнения элемента управления данными.|  
|Использование режима заполнения столбца со значениями различной важности.|Задайте для свойства <xref:System.Windows.Forms.DataGridView.AutoSizeColumnsMode%2A> значение <xref:System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill>. Задайте большое значение свойства <xref:System.Windows.Forms.DataGridViewColumn.MinimumWidth%2A> для столбцов, у которых всегда должна отображаться часть данных, или используйте параметр изменения размера, отличный от режима заполнения, для определенных столбцов.|  
|Использование режима заполнения, чтобы избежать отображения фона элемента управления.|Задайте для свойства <xref:System.Windows.Forms.DataGridViewColumn.AutoSizeMode%2A> последнего столбца значение <xref:System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill> и используйте другие параметры изменения размеров для других столбцов. Если другие столбцы используют слишком много пространства, задайте свойство <xref:System.Windows.Forms.DataGridViewColumn.MinimumWidth%2A> последнего столбца.|  
|Отобразить столбец фиксированной ширины, например столбец значка или идентификатора.|Задайте <xref:System.Windows.Forms.DataGridViewColumn.AutoSizeMode%2A> для <xref:System.Windows.Forms.DataGridViewAutoSizeColumnMode.None> и <xref:System.Windows.Forms.DataGridViewColumn.Resizable%2A> для <xref:System.Windows.Forms.DataGridViewTriState.False> для столбца. Инициализируйте его ширину, задав свойство <xref:System.Windows.Forms.DataGridViewColumn.Width%2A> или путем вызова метода <xref:System.Windows.Forms.DataGridView.AutoResizeColumn%2A> после заполнения элемента управления данными.|  
|Автоматическое изменение размеров при каждом изменении содержимого ячейки во избежание его обрезки и в целях оптимизации занимаемого ей места.|Задайте свойству автоматического изменения размера значение, представляющее режим изменения размеров на основе содержимого. Чтобы избежать снижения производительности при работе с большими объемами данных, используйте режим изменения размеров, который вычисляет только размеры только отображаемых строк.|  
|Изменение размеров в зависимости от значений в отображаемых строках, чтобы избежать снижения производительности при работе с большим количеством строк.|Используйте соответствующий режим изменения размеров значения, с автоматическим или программным изменением. Чтобы размер изменялся в зависимости от значений во вновь отображаемых строках при прокрутке, вызовите метод изменения размеров в обработчике событий <xref:System.Windows.Forms.DataGridView.Scroll>. Для настройки изменения размера пользователем двойным щелчком таким образом, чтобы только значения в отображаемых строках определяли новый размер, вызовите метод изменения размеров в обработчике событий <xref:System.Windows.Forms.DataGridView.RowDividerDoubleClick> или <xref:System.Windows.Forms.DataGridView.ColumnDividerDoubleClick>.|  
|Изменение размеров под содержимое ячейки только в определенное время, чтобы избежать снижения производительности или разрешить изменение размера при изменении данных пользователем.|Вызовите метод изменения размеров на основе содержимого в обработчике событий. Например, используйте событие  <xref:System.Windows.Forms.DataGridView.DataBindingComplete> для инициализации размеров после привязки и обработки, события  <xref:System.Windows.Forms.DataGridView.CellValidated> или <xref:System.Windows.Forms.DataGridView.CellValueChanged> для контроля размера при изменении данных пользователем или изменении значений в источнике данных.|  
|Изменение высоты строк для многострочного содержимого ячеек.|Убедитесь, что ширина столбцов подходит для отображения абзацев текста и используйте автоматический или программный метод изменения размера строк на основе содержимого для изменения высоты. Также убедитесь, что ячейки с многострочным содержимым отображаются со значением стиля ячейки <xref:System.Windows.Forms.DataGridViewCellStyle.WrapMode%2A>, установленным в <xref:System.Windows.Forms.DataGridViewTriState.True>.<br /><br /> Как правило для сохранения ширины столбцов для них задается определенная ширина, а для высоты строк используется автоматический режим изменения размеров.|  
  
## <a name="resizing-with-the-mouse"></a>Изменение размеров с помощью мыши  
 По умолчанию пользователь может изменять размер строк, столбцов и заголовков, которые не используют режим автоматического изменения размеров на основе значений ячеек. Чтобы запретить пользователям изменение размеров в других режимах, например в режиме заполнения столбцов, задайте одно или несколько из следующих свойств <xref:System.Windows.Forms.DataGridView>:  
  
-   <xref:System.Windows.Forms.DataGridView.AllowUserToResizeColumns%2A>  
  
-   <xref:System.Windows.Forms.DataGridView.AllowUserToResizeRows%2A>  
  
-   <xref:System.Windows.Forms.DataGridView.ColumnHeadersHeightSizeMode%2A>  
  
-   <xref:System.Windows.Forms.DataGridView.RowHeadersWidthSizeMode%2A>  
  
 Вы можете также запретить пользователям изменять размеры отдельных строк или столбцов, задав их свойства <xref:System.Windows.Forms.DataGridViewBand.Resizable%2A>. По умолчанию <xref:System.Windows.Forms.DataGridViewBand.Resizable%2A> зависит от значения свойства <xref:System.Windows.Forms.DataGridView.AllowUserToResizeColumns%2A> для столбцов и значения свойства <xref:System.Windows.Forms.DataGridView.AllowUserToResizeRows%2A> для строк. Если явно задать <xref:System.Windows.Forms.DataGridViewBand.Resizable%2A> в <xref:System.Windows.Forms.DataGridViewTriState.True> или <xref:System.Windows.Forms.DataGridViewTriState.False>, указанное значение переопределяет значение элемента управления — для строки или столбца. Задайте <xref:System.Windows.Forms.DataGridViewBand.Resizable%2A> значение <xref:System.Windows.Forms.DataGridViewTriState.NotSet>, чтобы восстановить унаследованное значение.  
  
 Так как <xref:System.Windows.Forms.DataGridViewTriState.NotSet> восстанавливает наследование значения, <xref:System.Windows.Forms.DataGridViewBand.Resizable%2A> не будет возвращать <xref:System.Windows.Forms.DataGridViewTriState.NotSet>, пока строка или столбец не был добавлен к элементу управления <xref:System.Windows.Forms.DataGridView>. Если вам нужно определить, унаследовано ли значение свойства <xref:System.Windows.Forms.DataGridViewBand.Resizable%2A> от строки или столбца, и проверьте его свойство <xref:System.Windows.Forms.DataGridViewElement.State%2A>. Если значение <xref:System.Windows.Forms.DataGridViewElement.State%2A> включает флаг <xref:System.Windows.Forms.DataGridViewElementStates.ResizableSet>, значение свойства <xref:System.Windows.Forms.DataGridViewBand.Resizable%2A> не является унаследованным.
  
## <a name="automatic-sizing"></a>Автоматическое изменение размеров  
 Существует два типа автоматического изменения размеров в <xref:System.Windows.Forms.DataGridView>: режим заполнения столбца и режим автоматического изменения размеров на основе содержимого.
  
 Режим заполнения столбца приводит к изменению размеров видимых столбцов в элементе управления для заполнения всей его отображаемой области. Дополнительные сведения об этом режиме см. в разделе [режим заполнения столбцов в элементе управления DataGridView Windows Forms](column-fill-mode-in-the-windows-forms-datagridview-control.md).  
  
 Можно также настроить автоматическое изменение размеров строк, столбцов и заголовков в соответствии с содержимым ячейки. В этом случае изменение размера происходит при каждом изменении содержимого ячейки.
  
> [!NOTE]
>  Если необходимо сохранить значения ячеек в кэше пользовательских данных в виртуальном режиме, автоматическое изменение размеров происходит, когда пользователь редактирует значение ячейки, но не возникает, если кэшированное значение изменяется за пределами обработчика события <xref:System.Windows.Forms.DataGridView.CellValuePushed>. В этом случае вызов <xref:System.Windows.Forms.DataGridView.UpdateCellValue%2A> предоставляет способ принудительного обновления вида ячейки и применения текущих режимов автоматического изменения размеров элемента управления.
  
 При включении автоматического изменения размеров на основе содержимого только для одного измерения — то есть, для строк, но не столбцов; или столбцов, но не строк; и включенном <xref:System.Windows.Forms.DataGridViewCellStyle.WrapMode%2A>, размер изменяется при каждом изменении другого измерения. Например, если строки, но не столбцы настроены для автоматического изменения размера и <xref:System.Windows.Forms.DataGridViewCellStyle.WrapMode%2A> включен, пользователи смогут перетаскивать разделители столбцов, и изменение ширины столбца и высоты строк автоматически настроит их размеры для полного отображения содержимого ячейки.
  
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

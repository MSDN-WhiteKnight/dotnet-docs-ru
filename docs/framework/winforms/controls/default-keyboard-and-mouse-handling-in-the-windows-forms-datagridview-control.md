---
title: Обработка событий в элементе управления Windows Forms DataGridView мыши и клавиатуры по умолчанию
ms.date: 02/13/2018
helpviewer_keywords:
- data grids [Windows Forms], mouse handling
- DataGridView control [Windows Forms], navigation keys
- keyboards [Windows Forms], default handling in DataGridView control
- DataGridView control [Windows Forms], keyboard handling
- mouse [Windows Forms], default handling in DataGridView control
- DataGridView control [Windows Forms], mouse handling
- navigation keys [Windows Forms], DataGridView control
ms.assetid: 4519b928-bfc8-4e8b-bb9c-b1e76a0ca552
ms.openlocfilehash: 56585bf91a559844f15aede4519706674357a924
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57708318"
---
# <a name="default-keyboard-and-mouse-handling-in-the-windows-forms-datagridview-control"></a>Обработка событий в элементе управления Windows Forms DataGridView мыши и клавиатуры по умолчанию

В следующих таблицах описываются, как пользователи могут взаимодействовать с <xref:System.Windows.Forms.DataGridView> управления посредством клавиатуры и мыши.  
  
> [!NOTE]
>  Чтобы настроить поведение клавиатуры, можно обрабатывать события стандартной клавиатуре например <xref:System.Windows.Forms.Control.KeyDown>. В режиме редактирования, однако размещенного элемента управления редактирования получающий ввод с клавиатуры и события клавиатуры не выполняется для <xref:System.Windows.Forms.DataGridView> элемента управления. Для обработки событий редактирования элемента управления, присоединения обработчиков к элементу управления изменениями в <xref:System.Windows.Forms.DataGridView.EditingControlShowing> обработчик событий. Кроме того, можно настроить поведение клавиатуры в <xref:System.Windows.Forms.DataGridView> подкласс путем переопределения <xref:System.Windows.Forms.DataGridView.ProcessDialogKey%2A> и <xref:System.Windows.Forms.DataGridView.ProcessDataGridViewKey%2A> методы.  
  
## <a name="default-keyboard-handling"></a>Обработка событий клавиатуры по умолчанию  
  
### <a name="basic-navigation-and-entry-keys"></a>Основные клавиши навигации и запись  
  
|Клавиши или сочетания клавиш|Описание:|  
|----------------------------|-----------------|  
|СТРЕЛКА ВНИЗ|Перемещает фокус в ячейку непосредственно под текущей ячейки. Если фокус находится в последней строке, ничего не делает.|  
|СТРЕЛКА ВЛЕВО|Перемещает фокус на предыдущую ячейку в строке. Если фокус находится в первой ячейке в строке, ничего не делает.|  
|СТРЕЛКА ВПРАВО|Перемещение фокуса к следующей ячейке в строке. Если фокус находится в последней ячейке в строке, ничего не делает.|  
|СТРЕЛКА ВВЕРХ|Перемещает фокус в ячейку непосредственно над текущей ячейки. Если фокус находится в первой строке, ничего не делает.|  
|ГЛАВНАЯ|Переход к первой ячейке в текущей строке.|  
|END|Переход к последней ячейке в текущей строке.|  
|PAGE DOWN|Прокручивает элемент управления вниз на число строк, которые отображаются полностью. Перемещает фокус на последнюю строку полностью отображается без изменения столбцов.|  
|PAGE UP|Прокручивает элемент управления вверх на число строк, которые отображаются полностью. Перемещает фокус на первую строку отображается без изменения столбцов.|  
|TAB|Если <xref:System.Windows.Forms.DataGridView.StandardTab%2A> свойство имеет значение `false`, фокус перемещается к следующей ячейке в текущей строке. Если фокус уже находится в последней ячейке строки, переход к первой ячейке в следующей строке. Если фокус находится в последней ячейке в элементе управления, перемещение фокуса к следующему элементу управления в последовательности табуляции родительского контейнера.<br /><br /> Если <xref:System.Windows.Forms.DataGridView.StandardTab%2A> свойство имеет значение `true`, фокус перемещается к следующему элементу управления в последовательности табуляции родительского контейнера.|  
|SHIFT+TAB|Если <xref:System.Windows.Forms.DataGridView.StandardTab%2A> свойство имеет значение `false`, фокус перемещается к предыдущей ячейке в текущей строке. Если фокус находится в первой ячейке строки, передает фокус в последнюю ячейку в предыдущей строке. Если фокус находится в первой ячейке в элементе управления, перемещает фокус на предыдущий элемент управления в последовательности табуляции родительского контейнера.<br /><br /> Если <xref:System.Windows.Forms.DataGridView.StandardTab%2A> свойство имеет значение `true`, фокус перемещается к предыдущему элементу управления в последовательности табуляции родительского контейнера.|  
|CTRL + TAB|Если <xref:System.Windows.Forms.DataGridView.StandardTab%2A> свойство имеет значение `false`, фокус перемещается к следующему элементу управления в последовательности табуляции родительского контейнера.<br /><br /> Если <xref:System.Windows.Forms.DataGridView.StandardTab%2A> свойство имеет значение `true`, фокус перемещается к следующей ячейке в текущей строке. Если фокус уже находится в последней ячейке строки, переход к первой ячейке в следующей строке. Если фокус находится в последней ячейке в элементе управления, перемещение фокуса к следующему элементу управления в последовательности табуляции родительского контейнера.|  
|CTRL+SHIFT+TAB|Если <xref:System.Windows.Forms.DataGridView.StandardTab%2A> свойство имеет значение `false`, фокус перемещается к предыдущему элементу управления в последовательности табуляции родительского контейнера.<br /><br /> Если <xref:System.Windows.Forms.DataGridView.StandardTab%2A> свойство имеет значение `true`, фокус перемещается к предыдущей ячейке в текущей строке. Если фокус находится в первой ячейке строки, передает фокус в последнюю ячейку в предыдущей строке. Если фокус находится в первой ячейке в элементе управления, перемещает фокус на предыдущий элемент управления в последовательности табуляции родительского контейнера.|  
|CTRL + СТРЕЛКА|Перемещает фокус самой крайней ячейке в направлении стрелки.|  
|CTRL + HOME|Переход к первой ячейке в элементе управления.|  
|CTRL + END|Перемещает фокус в последнюю ячейку в элементе управления.|  
|CTRL + PAGE ВНИЗ И ВВЕРХ|Совпадает со значением PAGE DOWN или PAGE UP.|  
|F2|Переводит текущую ячейку в режим редактирования ячейки, если <xref:System.Windows.Forms.DataGridView.EditMode%2A> свойство имеет значение <xref:System.Windows.Forms.DataGridViewEditMode.EditOnF2> или <xref:System.Windows.Forms.DataGridViewEditMode.EditOnKeystrokeOrF2>.|
|F3|Сортирует текущий столбец, если <xref:System.Windows.Forms.DataGridViewColumn.SortMode%2A?displayProperty=nameWithType> свойство имеет значение <xref:System.Windows.Forms.DataGridViewColumnSortMode.Automatic>. Это аналогично щелчку текущего заголовка столбца. Доступно с версии .NET Framework 4.7.2. Чтобы включить эту функцию, приложения должны предназначенных для .NET Framework 4.7.2 или более поздней версии или явно выбран улучшения специальных возможностей, с помощью параметров AppContext.|  
|F4|Если текущая ячейка находится <xref:System.Windows.Forms.DataGridViewComboBoxCell>, она переходит в режим редактирования и отображает стрелку раскрывающегося списка.|  
|ALT + СТРЕЛКА ВВЕРХ/ВНИЗ СТРЕЛКА|Если текущая ячейка находится <xref:System.Windows.Forms.DataGridViewComboBoxCell>, она переходит в режим редактирования и отображает стрелку раскрывающегося списка.|  
|ПРОБЕЛ|Если текущая ячейка находится <xref:System.Windows.Forms.DataGridViewButtonCell>, <xref:System.Windows.Forms.DataGridViewLinkCell>, или <xref:System.Windows.Forms.DataGridViewCheckBoxCell>, вызывает <xref:System.Windows.Forms.DataGridView.CellClick> и <xref:System.Windows.Forms.DataGridView.CellContentClick> события. Если текущая ячейка находится <xref:System.Windows.Forms.DataGridViewButtonCell>, также нажимает кнопку. Если текущая ячейка находится <xref:System.Windows.Forms.DataGridViewCheckBoxCell>, также изменяет состояние флажка.|  
|ВВОД|Фиксирует все изменения для текущей ячейки и строки и переносит фокус в ячейку непосредственно под текущей ячейки. Если фокус находится в последней строке, изменения сохраняются без перемещения фокуса.|  
|ESC|Если элемент управления находится в режиме редактирования, отменяет изменение. Если элемент управления не находится в режиме редактирования, отменяет изменения, внесенные в текущую строку, если элемент управления привязан к источнику данных, который поддерживает редактирование или реализации виртуального режима с областью фиксации на уровне строк.|  
|BACKSPACE|Удаление знака перед точкой вставки при редактировании ячейки.|  
|DELETE|Удаление знака после курсора, при редактировании ячейки.|  
|CTRL+ВВОД|Фиксирует все изменения в текущей ячейке без перемещения фокуса. Также фиксирует все изменения для текущей строки, если элемент управления привязан к источнику данных, который поддерживает режим редактирования или виртуальных была реализована с помощью на уровне строк области фиксации.|  
|CTRL+0|Вводит <xref:System.DBNull.Value?displayProperty=nameWithType> значение в текущей ячейке, если ячейки можно изменять. По умолчанию, отображаемое значение для <xref:System.DBNull> значение ячейки является значение <xref:System.Windows.Forms.DataGridViewCellStyle.NullValue%2A> свойство <xref:System.Windows.Forms.DataGridViewCellStyle> действует для текущей ячейки.|  
  
### <a name="selection-keys"></a>Выбор ключей

 Если <xref:System.Windows.Forms.DataGridView.MultiSelect%2A> свойству `false` и <xref:System.Windows.Forms.DataGridView.SelectionMode%2A> свойству <xref:System.Windows.Forms.DataGridViewSelectionMode.CellSelect>, изменение текущей ячейки с помощью клавиши навигации изменения выделения новой ячейки. SHIFT, CTRL и ALT ключи не влияют на это поведение.  
  
 Если <xref:System.Windows.Forms.DataGridView.SelectionMode%2A> присваивается <xref:System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect> или <xref:System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect>, происходит то же поведение, но со следующими дополнениями.  
  
|Клавиши или сочетания клавиш|Описание:|  
|----------------------------|-----------------|  
|SHIFT + ПРОБЕЛ|Выбор всей строки или столбца (совпадает при щелчке заголовка строки или столбца).|  
|клавиши навигации (клавиша со стрелкой, PAGE UP/DOWN, HOME, END)|Если выбран полной строки или столбца, изменение текущей ячейки в новой строке или столбце выделяет всей новой строки или столбца (в зависимости от режима выделения).|  
  
 Если <xref:System.Windows.Forms.DataGridView.MultiSelect%2A> присваивается `false` и <xref:System.Windows.Forms.DataGridView.SelectionMode%2A> присваивается <xref:System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect> или <xref:System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect>, изменение текущей ячейки в новой строке или столбце с помощью клавиатуры, чтобы перейти к полностью строки или столбца. SHIFT, CTRL и ALT ключи не влияют на это поведение.  
  
 Если <xref:System.Windows.Forms.DataGridView.MultiSelect%2A> присваивается `true`, поведение остается неизменным, но перемещение с помощью клавиатуры, удерживая нажатой клавишу SHIFT, (включая клавиши CTRL + SHIFT) измените выбора нескольких ячеек. Перед выполнением перехода, управления помечает текущую ячейку как базовую. При переходе, удерживая нажатой клавишу SHIFT, выделение включает все ячейки между базовой и текущей ячейки. Остальные ячейки в элементе управления останется выбранным, если они уже были выбраны, но они могут снимается навигации с помощью клавиатуры временно в ходе которой их между базовой и текущей ячейки.  
  
 Если <xref:System.Windows.Forms.DataGridView.MultiSelect%2A> присваивается `true` и <xref:System.Windows.Forms.DataGridView.SelectionMode%2A> присваивается <xref:System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect> или <xref:System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect>, ячейкой привязки и текущая ячейка происходит так же, но только полной строки или столбцы становится выбранным или невыбранным.  
  
## <a name="default-mouse-handling"></a>По умолчанию обработка событий мыши
  
### <a name="basic-mouse-handling"></a>Обработка основных событий мыши
  
> [!NOTE]
>  При щелчке ячейки с левой кнопки мыши всегда изменяет текущую ячейку. Щелчок по ячейке правой кнопкой мыши открывается контекстное меню, если она доступна.  
  
|Действие мыши|Описание:|  
|------------------|-----------------|  
|Левой кнопки мыши|Делает выбранная ячейка текущей ячейки и инициирует <xref:System.Windows.Forms.DataGridView.CellMouseDown?displayProperty=nameWithType> событий.|  
|Левая кнопка мыши вверх|Вызывает событие <xref:System.Windows.Forms.DataGridView.CellMouseUp?displayProperty=nameWithType>.|  
|Щелчок левой кнопкой мыши|Вызывает <xref:System.Windows.Forms.DataGridView.CellClick?displayProperty=nameWithType> и <xref:System.Windows.Forms.DataGridView.CellMouseClick?displayProperty=nameWithType> события|  
|Левой кнопки мыши и перетащите на ячейки заголовка столбца|Если <xref:System.Windows.Forms.DataGridView.AllowUserToOrderColumns%2A?displayProperty=nameWithType> свойство `true`, перемещает столбец таким образом, чтобы его можно перетаскивать в новую позицию.|  
  
### <a name="mouse-selection"></a>Выделения мышью

 Поведение выделения не связан с средняя кнопка мыши или колесиком мыши.  
  
 Если <xref:System.Windows.Forms.DataGridView.MultiSelect%2A> свойству `false` и <xref:System.Windows.Forms.DataGridView.SelectionMode%2A> свойству <xref:System.Windows.Forms.DataGridViewSelectionMode.CellSelect>, происходит следующее.  
  
|Действие мыши|Описание:|  
|------------------|-----------------|  
|Щелкните левой кнопкой мыши|Выделение только текущей ячейки, если пользователь щелкает ячейку. Поведение выделения, не появляется, если пользователь щелкает мышью заголовок строки или столбца.|  
|Щелкните правой кнопкой мыши|Отображает контекстное меню, если таковой доступен.|  
  
 Такое же поведение наблюдается при <xref:System.Windows.Forms.DataGridView.SelectionMode%2A> присваивается <xref:System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect> или <xref:System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect>, за исключением того, что, в зависимости от режима выделения при щелчке заголовка строки или столбца будет Выбор всей строки или столбца и установка значения текущей ячейки в первую ячейку в строке или столбце.  
  
 Если <xref:System.Windows.Forms.DataGridView.SelectionMode%2A> присваивается <xref:System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect> или <xref:System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect>, если щелкнуть любую ячейку в строке или столбце выберет полной строки или столбца.  
  
 Если <xref:System.Windows.Forms.DataGridView.MultiSelect%2A> присваивается `true`, удерживая нажатой клавишу CTRL или SHIFT при щелчке ячейки изменит выбора нескольких ячеек.  
  
 Если щелкнуть ячейку удерживая нажатой клавишу CTRL, ячейки изменит свое состояние выбора, все остальные ячейки, сохраняя их текущее состояние выделения.  
  
 Если щелкнуть ячейку или ряда ячеек нажатой клавишей SHIFT, выделение включает все ячейки между текущей ячейки и ячейки в привязки, расположен в позиции текущей ячейки до первого щелчка. Когда вы щелкните и перетащите указатель протащил резинку, ячейкой привязки является ячеек в начале операции перетаскивания. Последующие нажатия нажатой клавишей SHIFT изменение текущей ячейки, но не базовой ячейки. Остальные ячейки в элементе управления останется выбранным, если они уже были выбраны, но они могут снимается, если навигации мыши временно помещаются между базовой и текущей ячейки.  
  
 Если <xref:System.Windows.Forms.DataGridView.MultiSelect%2A> присваивается `true` и <xref:System.Windows.Forms.DataGridView.SelectionMode%2A> присваивается <xref:System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect> или <xref:System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect>, удерживая нажатой клавишу SHIFT при щелчке заголовка строки или столбца (в зависимости от режима выделения) изменит выделенной полных строк или столбцов, если такой Выбранный объект существует. В противном случае он будет снимите флажок и начать новый выбор полных строк или столбцов. Удерживая нажатой клавишу CTRL при щелчке заголовка строки или столбца, однако будет добавлять или удалять выбранной строки или столбца из выделенной без иного изменения текущего выделения.  
  
 Если <xref:System.Windows.Forms.DataGridView.MultiSelect%2A> присваивается `true` и <xref:System.Windows.Forms.DataGridView.SelectionMode%2A> присваивается <xref:System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect> или <xref:System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect>, удерживая нажатой клавишу SHIFT или CTRL при щелчке ячейки работает так же, за исключением этого только полных строк и столбцов будут затронуты.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- [Элемент управления DataGridView](datagridview-control-windows-forms.md)

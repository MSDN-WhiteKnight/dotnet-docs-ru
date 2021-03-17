---
title: Режимы выделения содержимого элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- selection [Windows Forms], modes in DataGridView control
- DataGridView control [Windows Forms], selection mode
ms.assetid: a3ebfd3d-0525-479d-9d96-d9e017289b36
ms.openlocfilehash: 79e13e65938252015e43b59a962d40f20963a5df
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59097282"
---
# <a name="selection-modes-in-the-windows-forms-datagridview-control"></a>Режимы выделения содержимого элемента управления DataGridView в Windows Forms
Иногда требуется приложению выполнять действия в зависимости от выбора пользователя в пределах <xref:System.Windows.Forms.DataGridView> элемента управления. В зависимости от действий может потребоваться ограничить типы выделения, которые возможны. Например предположим, что приложение можно распечатать отчет для текущей выбранной записи. В этом случае может потребоваться настроить <xref:System.Windows.Forms.DataGridView> элемент управления, щелкнув в любом месте в пределах строки выбирает всей строки, и таким образом можно выбрать только одну строку за раз.  
  
 Можно указать, разрешено, установив выбранные элементы <xref:System.Windows.Forms.DataGridView.SelectionMode%2A?displayProperty=nameWithType> задается одно из следующих <xref:System.Windows.Forms.DataGridViewSelectionMode> значений перечисления.  
  
|Значение DataGridViewSelectionMode|Описание|  
|-------------------------------------|-----------------|  
|<xref:System.Windows.Forms.DataGridViewSelectionMode.CellSelect>|При щелчке ячейки выделяется. Заголовки строк и столбцов не может использоваться для выбора.|  
|<xref:System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect>|При щелчке ячейки выделяется. При щелчке заголовка столбца выбирает весь столбец. Заголовки столбцов не может использоваться для сортировки.|  
|<xref:System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect>|При щелчке ячейки или заголовка столбца выбирает весь столбец. Заголовки столбцов не может использоваться для сортировки.|  
|<xref:System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect>|При щелчке ячейки или заголовка строки выделяется вся строка.|  
|<xref:System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect>|Режим выбора по умолчанию. При щелчке ячейки выделяется. При щелчке заголовка строки выделяется вся строка.|  
  
> [!NOTE]
>  Изменение режима выделения во время выполнения автоматически очищает текущее выделение.  
  
 По умолчанию пользователи могут выбрать несколько строк, столбцов или ячеек путем перетаскивания с помощью мыши, нажав клавишу CTRL или SHIFT во время расширения или изменения области выделения, или щелкнув ячейку заголовка в левом верхнем выделить все ячейки в элементе управления. Чтобы предотвратить такое поведение, задайте <xref:System.Windows.Forms.DataGridView.MultiSelect%2A> свойства `false`.  
  
 <xref:System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect> И <xref:System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect> режимы позволяет пользователю удалять строки, выбрав их и нажав клавишу DELETE. Пользователи могут удалить строки только в том случае, если текущая ячейка не находится в режиме редактирования, <xref:System.Windows.Forms.DataGridView.AllowUserToDeleteRows%2A> свойству `true`, и базовый источник данных поддерживает удаление строк пользователем. Обратите внимание на то, что эти параметры не препятствуют удалению строк программным.  
  
## <a name="programmatic-selection"></a>Программный выбор  
 Текущий режим выделения ограничивает возможности программного выделения, а также выбор пользователя. Текущее выделение можно изменить программно, задав `Selected` свойства ячеек, строк или столбцов в <xref:System.Windows.Forms.DataGridView> элемента управления. Можно также выделить все ячейки в элементе управления через <xref:System.Windows.Forms.DataGridView.SelectAll%2A> метод, в зависимости от режима выделения. Чтобы отменить выбор, используйте <xref:System.Windows.Forms.DataGridView.ClearSelection%2A> метод.  
  
 Если <xref:System.Windows.Forms.DataGridView.MultiSelect%2A> свойству `true`, вы можете добавить <xref:System.Windows.Forms.DataGridView> элементы или удалять их из выделения, изменяя `Selected` свойство элемента. В противном случае установка `Selected` свойства `true` для одного элемента автоматически удаляет другие элементы из выделения.  
  
 Обратите внимание, что изменение значения <xref:System.Windows.Forms.DataGridView.CurrentCell%2A> свойства не изменяет текущее выделение.  
  
 Можно получить коллекцию выделенных ячеек, строк или столбцов с помощью <xref:System.Windows.Forms.DataGridView.SelectedCells%2A>, <xref:System.Windows.Forms.DataGridView.SelectedRows%2A>, и <xref:System.Windows.Forms.DataGridView.SelectedColumns%2A> свойства <xref:System.Windows.Forms.DataGridView> элемента управления. Доступ к этим свойствам неэффективен, при выборе каждой ячейки в элементе управления. Чтобы избежать снижения производительности в этом случае, используйте <xref:System.Windows.Forms.DataGridView.AreAllCellsSelected%2A> метод первой. Кроме того доступ к этим коллекциям для определения числа выделенных ячеек, строк или столбцов может оказаться неэффективным. Вместо этого следует использовать <xref:System.Windows.Forms.DataGridView.GetCellCount%2A>, <xref:System.Windows.Forms.DataGridViewRowCollection.GetRowCount%2A>, или <xref:System.Windows.Forms.DataGridViewColumnCollection.GetColumnCount%2A> метод, передавая <xref:System.Windows.Forms.DataGridViewElementStates.Selected> значение.  
  
> [!TIP]
>  Пример кода, демонстрирующий программное использование выделенных ячеек можно найти в <xref:System.Windows.Forms.DataGridView> Общие сведения о классе.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridView.MultiSelect%2A>
- <xref:System.Windows.Forms.DataGridView.SelectionMode%2A>
- <xref:System.Windows.Forms.DataGridViewSelectionMode>
- [Выделение данных и операции с буфером обмена в элементе управления DataGridView в Windows Forms](selection-and-clipboard-use-with-the-windows-forms-datagridview-control.md)
- [Практическое руководство. Определение режима выделения для элемента управления DataGridView в Windows Forms](how-to-set-the-selection-mode-of-the-windows-forms-datagridview-control.md)

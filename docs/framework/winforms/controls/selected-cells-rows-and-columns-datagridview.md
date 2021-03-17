---
title: Практическое руководство. Получение информации о выделенных пользователем ячейках, строках и столбцах элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- selection [Windows Forms], DataGridView control [Windows Forms]
- DataGridView control [Windows Forms], getting selection
- getting selection [Windows Forms], DataGridView control [Windows Forms]
ms.assetid: d93c4b5b-498e-49bc-982a-2229d61778e4
ms.openlocfilehash: cd3e88b5b01b67f677fbe203a0db9c4de7fe67ff
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59160554"
---
# <a name="how-to-get-the-selected-cells-rows-and-columns-in-the-windows-forms-datagridview-control"></a>Практическое руководство. Получение информации о выделенных пользователем ячейках, строках и столбцах элемента управления DataGridView в Windows Forms
Можно получить выделенных ячеек, строк или столбцов из <xref:System.Windows.Forms.DataGridView> элемента управления с помощью соответствующих свойств: <xref:System.Windows.Forms.DataGridView.SelectedCells%2A>, <xref:System.Windows.Forms.DataGridView.SelectedRows%2A>, и <xref:System.Windows.Forms.DataGridView.SelectedColumns%2A>. В следующих процедурах будет получить выделенных ячеек и отображать их индексы строки и столбца в <xref:System.Windows.Forms.MessageBox>.  
  
### <a name="to-get-the-selected-cells-in-a-datagridview-control"></a>Для получения выделенных ячеек в элементе управления DataGridView  
  
-   Используйте свойство <xref:System.Windows.Forms.DataGridView.SelectedCells%2A>.  
  
    > [!NOTE]
    >  Используйте <xref:System.Windows.Forms.DataGridView.AreAllCellsSelected%2A> метод, чтобы не происходило отображение потенциально большое количество ячеек.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewSelectedCollections#10](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewSelectedCollections/CS/DataGridViewSelectedCollections.cs#10)]
     [!code-vb[System.Windows.Forms.DataGridViewSelectedCollections#10](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewSelectedCollections/VB/DataGridViewSelectedCollections.vb#10)]  
  
### <a name="to-get-the-selected-rows-in-a-datagridview-control"></a>Чтобы получить выделенные строки в элементе управления DataGridView  
  
-   Используйте свойство <xref:System.Windows.Forms.DataGridView.SelectedRows%2A>. Чтобы пользователи могли выбрать строки, необходимо задать <xref:System.Windows.Forms.DataGridView.SelectionMode%2A> свойства <xref:System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect> или <xref:System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect>.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewSelectedCollections#20](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewSelectedCollections/CS/DataGridViewSelectedCollections.cs#20)]
     [!code-vb[System.Windows.Forms.DataGridViewSelectedCollections#20](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewSelectedCollections/VB/DataGridViewSelectedCollections.vb#20)]  
  
### <a name="to-get-the-selected-columns-in-a-datagridview-control"></a>Чтобы получить из выбранных столбцов в элементе управления DataGridView  
  
-   Используйте свойство <xref:System.Windows.Forms.DataGridView.SelectedColumns%2A>. Чтобы пользователи могли выбрать столбцы, необходимо задать <xref:System.Windows.Forms.DataGridView.SelectionMode%2A> свойства <xref:System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect> или <xref:System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect>.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewSelectedCollections#30](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewSelectedCollections/CS/DataGridViewSelectedCollections.cs#30)]
     [!code-vb[System.Windows.Forms.DataGridViewSelectedCollections#30](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewSelectedCollections/VB/DataGridViewSelectedCollections.vb#30)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   <xref:System.Windows.Forms.Button> элементы управления с именем `selectedCellsButton`, `selectedRowsButton`, и `selectedColumnsButton`, каждый из которых обработчики для <xref:System.Windows.Forms.Control.Click> присоединенного события.  
  
-   элемент управления <xref:System.Windows.Forms.DataGridView> с именем `dataGridView1`;  
  
-   ссылки на сборки <xref:System?displayProperty=nameWithType>, <xref:System.Windows.Forms?displayProperty=nameWithType> и <xref:System.Text?displayProperty=nameWithType>.  
  
## <a name="robust-programming"></a>Отказоустойчивость  
 Коллекций, описанных в этом разделе не осуществляют эффективно, когда выбраны большое количество ячеек, строк или столбцов. Дополнительные сведения об использовании этих коллекций с большими объемами данных, см. в разделе [масштабирование элемента управления DataGridView в Windows Forms](best-practices-for-scaling-the-windows-forms-datagridview-control.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridView.SelectionMode%2A>
- <xref:System.Windows.Forms.DataGridView.AreAllCellsSelected%2A>
- <xref:System.Windows.Forms.DataGridView.SelectedCells%2A>
- <xref:System.Windows.Forms.DataGridView.SelectedRows%2A>
- <xref:System.Windows.Forms.DataGridView.SelectedColumns%2A>
- [Выделение данных и операции с буфером обмена в элементе управления DataGridView в Windows Forms](selection-and-clipboard-use-with-the-windows-forms-datagridview-control.md)

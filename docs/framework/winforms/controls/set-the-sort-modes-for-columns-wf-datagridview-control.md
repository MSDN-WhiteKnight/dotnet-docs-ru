---
title: Практическое руководство. Определение режимов сортировки для столбцов элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- sorting [Windows Forms], data grids
- DataGridView control [Windows Forms], sort mode
- data grids [Windows Forms], sorting data
ms.assetid: 57dfed60-a608-40d5-86f9-d65686ffb325
ms.openlocfilehash: 4894de00a323f70ca244ea877101a5af1cbb37e0
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59096372"
---
# <a name="how-to-set-the-sort-modes-for-columns-in-the-windows-forms-datagridview-control"></a>Практическое руководство. Определение режимов сортировки для столбцов элемента управления DataGridView в Windows Forms
В <xref:System.Windows.Forms.DataGridView> элемент управления, поле текстовых столбцов использовать автоматическую сортировку по умолчанию, а другие типы столбцов не имеют автоматической сортировки. Иногда требуется переопределить эти значения по умолчанию. Например можно отобразить изображения вместо текста, чисел и значений перечисления ячейки. Хотя нельзя отсортировать изображения, можно сортировать значения, которые они представляют.  
  
 В <xref:System.Windows.Forms.DataGridView> элемента управления, <xref:System.Windows.Forms.DataGridViewColumn.SortMode%2A> значение свойства столбца определяет поведение сортировки.  
  
 В следующей процедуре показан `Priority` столбец из [как: Настройка форматирования данных в элементе управления DataGridView Windows Forms](how-to-customize-data-formatting-in-the-windows-forms-datagridview-control.md). Этот столбец является столбцом образа и не поддерживает сортировку по умолчанию. Он содержит фактические значения ячеек, которые представляют собой строки, однако, поэтому его можно сортировать по алфавиту.  
  
### <a name="to-set-the-sort-mode-for-a-column"></a>Чтобы задать режим сортировки для столбца  
  
-   Задайте свойство <xref:System.Windows.Forms.DataGridViewColumn.SortMode%2A?displayProperty=nameWithType>.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewMisc#066](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMisc/CS/datagridviewmisc.cs#066)]
     [!code-vb[System.Windows.Forms.DataGridViewMisc#066](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMisc/VB/datagridviewmisc.vb#066)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   элемент управления <xref:System.Windows.Forms.DataGridView> с именем `dataGridView1`, содержащий столбец с именем `Priority`;  
  
-   ссылки на сборки <xref:System?displayProperty=nameWithType> и <xref:System.Windows.Forms?displayProperty=nameWithType>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridViewColumn.SortMode%2A?displayProperty=nameWithType>
- [Сортировка данных в элементе управления DataGridView в Windows Forms](sorting-data-in-the-windows-forms-datagridview-control.md)
- [Установка режимов сортировки для столбцов элемента управления DataGridView в Windows Forms](column-sort-modes-in-the-windows-forms-datagridview-control.md)
- [Практическое руководство. Настройка сортировки данных элемента управления DataGridView в Windows Forms](how-to-customize-sorting-in-the-windows-forms-datagridview-control.md)

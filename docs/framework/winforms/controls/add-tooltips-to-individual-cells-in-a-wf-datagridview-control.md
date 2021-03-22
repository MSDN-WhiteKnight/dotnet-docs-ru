---
title: Практическое руководство. Определение текста всплывающих подсказок для отдельных ячеек элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- tooltips [Windows Forms], adding to data grids
- DataGridView control [Windows Forms], adding tooltips
- data grids [Windows Forms], adding tooltips
ms.assetid: 2a81f9de-d58b-4ea8-bc0b-8d93c2f4cf78
ms.openlocfilehash: 3307c92a13e5730de6dce0fe45b924e44b7af554
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59119643"
---
# <a name="how-to-add-tooltips-to-individual-cells-in-a-windows-forms-datagridview-control"></a>Практическое руководство. Определение текста всплывающих подсказок для отдельных ячеек элемента управления DataGridView в Windows Forms
По умолчанию всплывающие подсказки используются для отображения значений <xref:System.Windows.Forms.DataGridView> ячеек, которые слишком малы, чтобы отображать их полное содержимое. Это поведение можно переопределить тем не менее, чтобы задать значения текст подсказки для отдельных ячеек. Это полезно для отображения дополнительных сведений пользователям о ячейке, или для предоставления пользователям альтернативное описание содержимого ячейки. Например если у вас есть строка, содержащая значки состояния, может потребоваться включение текстовых пояснений, с помощью всплывающих подсказок.  
  
 Отображение всплывающих подсказок на уровне ячейки можно также отключить, задав <xref:System.Windows.Forms.DataGridView.ShowCellToolTips%2A?displayProperty=nameWithType> свойства `false`.  
  
### <a name="to-add-a-tooltip-to-a-cell"></a>Чтобы добавить подсказку для ячейки  
  
-   Задайте свойство <xref:System.Windows.Forms.DataGridViewCell.ToolTipText%2A?displayProperty=nameWithType>.  
  
     [!code-cpp[System.Windows.Forms.DataGridViewCell.ToolTipText#1](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewCell.ToolTipText/cpp/datagridviewcell.tooltiptext.cpp#1)]
     [!code-csharp[System.Windows.Forms.DataGridViewCell.ToolTipText#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewCell.ToolTipText/CS/datagridviewcell.tooltiptext.cs#1)]
       
  
## <a name="compiling-the-code"></a>Компиляция кода  
  
-   Для этого примера требуются:  
  
-   Объект <xref:System.Windows.Forms.DataGridView> управления с именем `dataGridView1` , содержащий столбец с именем `Rating` для отображения строковых значений от одного до четырех звездочки ("*») символов. <xref:System.Windows.Forms.DataGridView.CellFormatting> События элемента управления должен быть связан с показано в примере метода обработчика событий.  
  
-   ссылки на сборки <xref:System?displayProperty=nameWithType> и <xref:System.Windows.Forms?displayProperty=nameWithType>.  
  
## <a name="robust-programming"></a>Отказоустойчивость  
 При привязке <xref:System.Windows.Forms.DataGridView> управления к внешнему источнику данных или обеспечивается реализация виртуального режима для источника данных, могут возникнуть проблемы с производительностью. Чтобы избежать снижения производительности при работе с большими объемами данных, обрабатывать <xref:System.Windows.Forms.DataGridView.CellToolTipTextNeeded> событий, а не параметр <xref:System.Windows.Forms.DataGridViewCell.ToolTipText%2A> свойство несколько ячеек. Когда вы обрабатываете это событие, получение значения ячейки <xref:System.Windows.Forms.DataGridViewCell.ToolTipText%2A> свойство вызывает событие и возвращает значение <xref:System.Windows.Forms.DataGridViewCellToolTipTextNeededEventArgs.ToolTipText%2A?displayProperty=nameWithType> свойство как указанный в событии обработчик.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridView.ShowCellToolTips%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.CellToolTipTextNeeded?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewCell>
- <xref:System.Windows.Forms.DataGridViewCell.ToolTipText%2A?displayProperty=nameWithType>
- [Программирование с использование ячеек, строк и столбцов в элементе управления DataGridView в Windows Forms](programming-with-cells-rows-and-columns-in-the-datagrid.md)

---
title: Практическое руководство. Считывание и установка значения текущей ячейки элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- DataGridView control [Windows Forms], getting current cell
- DataGridView control [Windows Forms], setting current cell
- cells [Windows Forms], getting and setting current
ms.assetid: b0e41e57-493a-4bd0-9376-a6f76723540c
ms.openlocfilehash: fb71a6e3259d3007e11f528377c95a9c4cbeb023
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59096983"
---
# <a name="how-to-get-and-set-the-current-cell-in-the-windows-forms-datagridview-control"></a>Практическое руководство. Считывание и установка значения текущей ячейки элемента управления DataGridView в Windows Forms
Взаимодействие с <xref:System.Windows.Forms.DataGridView> часто требуется программно найденные ячейки, которая в данный момент активна. Кроме того, может потребоваться изменить текущую ячейку. Можно выполнять эти задачи с помощью <xref:System.Windows.Forms.DataGridView.CurrentCell%2A> свойство.  
  
> [!NOTE]
>  Невозможно задать текущую ячейку в строке или столбце с его <xref:System.Windows.Forms.DataGridViewBand.Visible%2A> свойство значение `false`.  
  
 В зависимости от <xref:System.Windows.Forms.DataGridView> Выбор можно изменить режим выбора элемента управления, изменение текущей ячейки. Дополнительные сведения см. в разделе [режимы выделения в элементе управления DataGridView Windows Forms](selection-modes-in-the-windows-forms-datagridview-control.md).  
  
### <a name="to-get-the-current-cell-programmatically"></a>Чтобы получить текущую ячейку программным способом  
  
-   Используйте <xref:System.Windows.Forms.DataGridView> элемента управления <xref:System.Windows.Forms.DataGridView.CurrentCell%2A> свойство.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewMisc#080](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMisc/CS/datagridviewmisc.cs#080)]
       
  
### <a name="to-set-the-current-cell-programmatically"></a>Установка текущей ячейки программным способом  
  
-   Задайте <xref:System.Windows.Forms.DataGridView.CurrentCell%2A> свойство <xref:System.Windows.Forms.DataGridView> элемента управления. В следующем примере кода текущая ячейка имеет значение в строке 0, столбец 1.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewMisc#085](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMisc/CS/datagridviewmisc.cs#085)]
       
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   <xref:System.Windows.Forms.Button> элементы управления с именем `getCurrentCellButton` и `setCurrentCellButton`. В визуальном элементе C#, необходимо присоединить <xref:System.Windows.Forms.Control.Click> событий для каждой кнопки в соответствующем обработчике событий в примере кода.  
  
-   элемент управления <xref:System.Windows.Forms.DataGridView> с именем `dataGridView1`;  
  
-   ссылки на сборки <xref:System?displayProperty=nameWithType> и <xref:System.Windows.Forms?displayProperty=nameWithType>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridView.CurrentCell%2A?displayProperty=nameWithType>
- [Базовые характеристики столбцов, строк и ячеек элемента управления DataGridView в Windows Forms](basic-column-row-and-cell-features-wf-datagridview-control.md)
- [Режимы выделения содержимого элемента управления DataGridView в Windows Forms](selection-modes-in-the-windows-forms-datagridview-control.md)

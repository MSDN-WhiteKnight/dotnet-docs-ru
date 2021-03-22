---
title: Практическое руководство. Разрешение переупорядочивания столбцов элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- DataGridView control [Windows Forms], column order
- data grids [Windows Forms], reordering columns
- columns [Windows Forms], reordering
ms.assetid: cc20eae3-e4db-493f-95ce-a4215e29472a
ms.openlocfilehash: 625c4987a45ed3749284e7abc7b6cde6d24821ca
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59161477"
---
# <a name="how-to-enable-column-reordering-in-the-windows-forms-datagridview-control"></a>Практическое руководство. Разрешение переупорядочивания столбцов элемента управления DataGridView в Windows Forms
При разрешении изменения порядка столбцов в элементе управления <xref:System.Windows.Forms.DataGridView> пользователи могут переместить столбец в новое местоположение, перетащив заголовок столбца с помощью мыши. В элементе управления <xref:System.Windows.Forms.DataGridView> значение свойства <xref:System.Windows.Forms.DataGridView.AllowUserToOrderColumns%2A?displayProperty=nameWithType> определяет, могут ли пользователи перемещать столбцы.  
  
 Эта задача поддерживается в Visual Studio.  Также см. раздел [Как Включить изменение порядка столбцов в Windows Forms с помощью конструктора элемента управления DataGridView](enable-column-reordering-in-the-datagrid-using-the-designer.md).  
  
### <a name="to-enable-column-reordering-programmatically"></a>Разрешение изменения порядка столбцов программным путем  
  
-   Задайте для свойства <xref:System.Windows.Forms.DataGridView.AllowUserToOrderColumns%2A?displayProperty=nameWithType> значение `true`.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewMisc#060](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMisc/CS/datagridviewmisc.cs#060)]
       
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   элемент управления <xref:System.Windows.Forms.DataGridView> с именем `dataGridView1`;  
  
-   ссылки на сборки <xref:System?displayProperty=nameWithType> и <xref:System.Windows.Forms?displayProperty=nameWithType>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridView.AllowUserToOrderColumns%2A?displayProperty=nameWithType>
- [Базовые характеристики столбцов, строк и ячеек элемента управления DataGridView в Windows Forms](basic-column-row-and-cell-features-wf-datagridview-control.md)
- [Практическое руководство. Замораживание столбцов элемента управления DataGridView в Windows Forms](how-to-freeze-columns-in-the-windows-forms-datagridview-control.md)

---
title: Практическое руководство. Применение шаблонов строк для настройки отображения строк элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- data grids [Windows Forms], customizing rows
- DataGridView control [Windows Forms], customizing rows
ms.assetid: 6db61607-7e57-4a84-8d63-9d6a7ed7f9ff
ms.openlocfilehash: cb3a826262a49a8653e3a344bd126d434f2522dd
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59073064"
---
# <a name="how-to-use-the-row-template-to-customize-rows-in-the-windows-forms-datagridview-control"></a>Практическое руководство. Применение шаблонов строк для настройки отображения строк элемента управления DataGridView в Windows Forms
<xref:System.Windows.Forms.DataGridView> Элемент управления использует шаблон строки в качестве основы для всех строк, которые он добавляет в элемент управления путем привязки данных или при вызове <xref:System.Windows.Forms.DataGridViewRowCollection.Add%2A?displayProperty=nameWithType> метода без указания существующей строки для использования.  
  
 Шаблон строк обеспечивает больший контроль над внешний вид и поведение строк, чем <xref:System.Windows.Forms.DataGridView.RowsDefaultCellStyle%2A> предоставляет свойство. С помощью шаблонов строк, можно задать любой <xref:System.Windows.Forms.DataGridViewRow> свойств, включая <xref:System.Windows.Forms.DataGridViewRow.DefaultCellStyle%2A>.  
  
 Существуют ситуации, когда необходимо использовать шаблон строки для получения определенного результата. Например, информацию о высоте строки не могут храниться в <xref:System.Windows.Forms.DataGridViewCellStyle>, поэтому необходимо использовать шаблон строки для изменения высоты по умолчанию, используемые во всех строках. Шаблон строки удобно использовать при создании собственных классов, производным от <xref:System.Windows.Forms.DataGridViewRow> и нужно, чтобы пользовательского типа используется при добавлении новых строк к элементу управления.  
  
> [!NOTE]
>  Шаблон строки используется только в том случае, если добавляются строки. Существующие строки невозможно изменить, изменив шаблон строки.  
  
### <a name="to-use-the-row-template"></a>Использование шаблонов строк  
  
-   Задать свойства объекта, полученного из <xref:System.Windows.Forms.DataGridView.RowTemplate%2A?displayProperty=nameWithType> свойство.  
  
     
     [!code-csharp[System.Windows.Forms.DataGridView.RowTemplate#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.RowTemplate/CS/datagridviewrowtemplate.cs#1)]
       
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   элемент управления <xref:System.Windows.Forms.DataGridView> с именем `dataGridView1`;  
  
-   ссылки на сборки <xref:System?displayProperty=nameWithType>, <xref:System.Drawing?displayProperty=nameWithType> и <xref:System.Windows.Forms?displayProperty=nameWithType>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridViewCellStyle>
- <xref:System.Windows.Forms.DataGridViewRow>
- <xref:System.Windows.Forms.DataGridView.RowTemplate%2A?displayProperty=nameWithType>
- [Базовое форматирование и оформление элемента управления DataGridView в Windows Forms](basic-formatting-and-styling-in-the-windows-forms-datagridview-control.md)
- [Стили ячеек элемента управления DataGridView в Windows Forms](cell-styles-in-the-windows-forms-datagridview-control.md)

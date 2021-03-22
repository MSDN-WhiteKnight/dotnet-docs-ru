---
title: Практическое руководство. Форматирование данных элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- DataGridView control [Windows Forms], formatting data
- data [Windows Forms], formatting in DataGridView control
- data grids [Windows Forms], enabling wordwrap
- currency values [Windows Forms], formatting in data grids
- data grids [Windows Forms], currency values
- data grids [Windows Forms], formatting data
- data grids [Windows Forms], text alignment
- data grids [Windows Forms], date values
- cells [Windows Forms], text alignment
ms.assetid: 8c33543c-9c08-4636-a65a-fdf714a529b7
ms.openlocfilehash: 62701edfdb3cf2729cb401ad12a12ee4f524287b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59221304"
---
# <a name="how-to-format-data-in-the-windows-forms-datagridview-control"></a>Практическое руководство. Форматирование данных элемента управления DataGridView в Windows Forms
Следующие процедуры демонстрируют основные элементы форматирования значений ячеек с помощью <xref:System.Windows.Forms.DataGridView.DefaultCellStyle%2A> свойство <xref:System.Windows.Forms.DataGridView> управления и для определенных столбцов в элементе управления. Сведения о форматировании данных см. в разделе [как: Настройка форматирования данных в элементе управления DataGridView Windows Forms](how-to-customize-data-formatting-in-the-windows-forms-datagridview-control.md).  
  
### <a name="to-format-currency-and-date-values"></a>Для форматирования валюты и значения дат  
  
-   Задайте свойство <xref:System.Windows.Forms.DataGridViewCellStyle.Format%2A> элемента <xref:System.Windows.Forms.DataGridViewCellStyle>. В следующем примере кода задает формат для определенных столбцов с помощью <xref:System.Windows.Forms.DataGridViewColumn.DefaultCellStyle%2A> свойств столбцов. Значения в `UnitPrice` столбец отображается в текущем формате валюты с отрицательными значениями, заключенных в круглые скобки. Значения в `ShipDate` столбец отображается в текущей культуре короткого формата даты. Дополнительные сведения о <xref:System.Windows.Forms.DataGridViewCellStyle.Format%2A> значения, см. в разделе [типы форматирования](../../../standard/base-types/formatting-types.md).  
  
     [!code-csharp[System.Windows.Forms.DataGridViewMisc#071](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMisc/CS/datagridviewmisc.cs#071)]
       
  
### <a name="to-customize-the-display-of-null-database-values"></a>Для настройки отображения значений null базы данных  
  
-   Задайте свойство <xref:System.Windows.Forms.DataGridViewCellStyle.NullValue%2A> элемента <xref:System.Windows.Forms.DataGridViewCellStyle>. В следующем примере кода используется <xref:System.Windows.Forms.DataGridView.DefaultCellStyle%2A?displayProperty=nameWithType> свойство для отображения во всех ячейках, имеющих значение «Нет записи» <xref:System.DBNull.Value?displayProperty=nameWithType>.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewMisc#073](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMisc/CS/datagridviewmisc.cs#073)]
       
  
### <a name="to-enable-wordwrap-in-text-based-cells"></a>Включение переноса слов в ячейках, основанные на тексте  
  
-   Задайте <xref:System.Windows.Forms.DataGridViewCellStyle.WrapMode%2A> свойство <xref:System.Windows.Forms.DataGridViewCellStyle> к одному из <xref:System.Windows.Forms.DataGridViewTriState> значений перечисления. В следующем примере кода используется <xref:System.Windows.Forms.DataGridView.DefaultCellStyle%2A?displayProperty=nameWithType> свойство, чтобы задать режим переноса для всего элемента управления.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewMisc#074](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMisc/CS/datagridviewmisc.cs#074)]
       
  
### <a name="to-specify-the-text-alignment-of-datagridview-cells"></a>Чтобы указать выравнивание текста для ячеек элемента управления DataGridView  
  
-   Задайте <xref:System.Windows.Forms.DataGridViewCellStyle.Alignment%2A> свойство <xref:System.Windows.Forms.DataGridViewCellStyle> к одному из <xref:System.Windows.Forms.DataGridViewContentAlignment> значений перечисления. В следующем примере кода задает выравнивание для определенного столбца с помощью <xref:System.Windows.Forms.DataGridViewColumn.DefaultCellStyle%2A> свойства столбца.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewMisc#072](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMisc/CS/datagridviewmisc.cs#072)]
       
  
## <a name="example"></a>Пример  
 [!code-csharp[System.Windows.Forms.DataGridViewMisc#070](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMisc/CS/datagridviewmisc.cs#070)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этих примеров требуются:  
  
-   Объект <xref:System.Windows.Forms.DataGridView> управления с именем `dataGridView1` , содержащий столбец с именем `UnitPrice`, столбец с именем `ShipDate`и столбец с именем `CustomerName`.  
  
-   ссылки на сборки <xref:System?displayProperty=nameWithType>, <xref:System.Drawing?displayProperty=nameWithType> и <xref:System.Windows.Forms?displayProperty=nameWithType>.  
  
## <a name="robust-programming"></a>Отказоустойчивость  
 Для максимальной масштабируемости следует распределить <xref:System.Windows.Forms.DataGridViewCellStyle> объекты в нескольких строк, столбцов или ячейкам одинаковыми стилями, а не отдельно задавать свойства стилей для каждого элемента. Дополнительные сведения см. в разделе [масштабирование элемента управления DataGridView в Windows Forms](best-practices-for-scaling-the-windows-forms-datagridview-control.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView.DefaultCellStyle%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewBand.DefaultCellStyle%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewCellStyle>
- [Базовое форматирование и оформление элемента управления DataGridView в Windows Forms](basic-formatting-and-styling-in-the-windows-forms-datagridview-control.md)
- [Стили ячеек элемента управления DataGridView в Windows Forms](cell-styles-in-the-windows-forms-datagridview-control.md)
- [Форматирование данных в элементе управления DataGridView в Windows Forms](data-formatting-in-the-windows-forms-datagridview-control.md)
- [Практическое руководство. Настройка форматирования данных элемента управления DataGridView в Windows Forms](how-to-customize-data-formatting-in-the-windows-forms-datagridview-control.md)
- [Типы форматирования](../../../standard/base-types/formatting-types.md)

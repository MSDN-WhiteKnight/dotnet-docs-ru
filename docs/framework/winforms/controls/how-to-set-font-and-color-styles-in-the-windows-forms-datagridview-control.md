---
title: Практическое руководство. Настройка шрифтов и цветов в элементе управления DataGridView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- DataGridView control [Windows Forms], cell customization
- data grids [Windows Forms], customizing cells
- data grids [Windows Forms], font styles
- data grids [Windows Forms], color styles
ms.assetid: 588f2c57-d963-41b1-9c1d-d02d71818113
ms.openlocfilehash: 737a4b943125245a2916bbf6b24b8abdffa8e371
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59215350"
---
# <a name="how-to-set-font-and-color-styles-in-the-windows-forms-datagridview-control"></a>Практическое руководство. Настройка шрифтов и цветов в элементе управления DataGridView в Windows Forms
Внешний вид ячеек в элементе управления <xref:System.Windows.Forms.DataGridView> можно определять путем указания свойств класса <xref:System.Windows.Forms.DataGridViewCellStyle>. Экземпляры этого класса можно извлечь из различных свойств класса <xref:System.Windows.Forms.DataGridView> и сопутствующих классов или же можно создать экземпляры объектов <xref:System.Windows.Forms.DataGridViewCellStyle> для назначения этим свойствам.  
  
 Приведенные ниже процедуры демонстрируют основные способы настройки внешнего вида ячеек с помощью свойства <xref:System.Windows.Forms.DataGridView.DefaultCellStyle%2A>. Каждая ячейка элемента управления наследует стили, указанные с помощью этого свойства, если они не переопределены на уровне столбца, строки или ячейки. Пример наследования стиля, см. в разделе [как: Установка стилей ячейки по умолчанию для управления DataGridView в Windows Forms](how-to-set-default-cell-styles-for-the-windows-forms-datagridview-control.md). Информацию о дополнительных способах использования класса <xref:System.Windows.Forms.DataGridViewCellStyle> см. в разделах, перечисленных в разделе "См. также".  
  
 В Visual Studio предусмотрена расширенная поддержка данной задачи.  Также см. раздел [Как Установка стилей ячейки по умолчанию и форматов данных, для Windows Forms с помощью конструктора элемента управления DataGridView](default-cell-styles-datagridview.md).  
  
### <a name="to-specify-the-font-used-by-datagridview-cells"></a>Указание шрифта текста для ячеек элемента управления DataGridView  
  
-   Задайте свойство <xref:System.Windows.Forms.DataGridViewCellStyle.Font%2A> элемента <xref:System.Windows.Forms.DataGridViewCellStyle>. В примере кода ниже свойство <xref:System.Windows.Forms.DataGridView.DefaultCellStyle%2A?displayProperty=nameWithType> используется для задания шрифта для всего элемента управления.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewMisc#101](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMisc/CS/datagridviewmisc.cs#101)]
       
  
### <a name="to-specify-the-foreground-and-background-colors-of-datagridview-cells"></a>Указание цветов текста и фона для ячеек элемента управления DataGridView  
  
-   Задайте свойства <xref:System.Windows.Forms.DataGridViewCellStyle.ForeColor%2A> и <xref:System.Windows.Forms.DataGridViewCellStyle.BackColor%2A> элемента <xref:System.Windows.Forms.DataGridViewCellStyle>. В примере кода ниже свойство <xref:System.Windows.Forms.DataGridView.DefaultCellStyle%2A?displayProperty=nameWithType> используется с целью задания стилей для всего элемента управления.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewMisc#102](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMisc/CS/datagridviewmisc.cs#102)]
       
  
### <a name="to-specify-the-foreground-and-background-colors-of-selected-datagridview-cells"></a>Указание цветов текста и фона для выбранных ячеек элемента управления DataGridView  
  
-   Задайте свойства <xref:System.Windows.Forms.DataGridViewCellStyle.SelectionForeColor%2A> и <xref:System.Windows.Forms.DataGridViewCellStyle.SelectionBackColor%2A> элемента <xref:System.Windows.Forms.DataGridViewCellStyle>. В примере кода ниже свойство <xref:System.Windows.Forms.DataGridView.DefaultCellStyle%2A?displayProperty=nameWithType> используется с целью задания стилей для всего элемента управления.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewMisc#103](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMisc/CS/datagridviewmisc.cs#103)]
       
  
## <a name="example"></a>Пример  
 [!code-csharp[System.Windows.Forms.DataGridViewMisc#100](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMisc/CS/datagridviewmisc.cs#100)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   элемент управления <xref:System.Windows.Forms.DataGridView> с именем `dataGridView1`;  
  
-   ссылки на сборки <xref:System?displayProperty=nameWithType>, <xref:System.Drawing?displayProperty=nameWithType> и <xref:System.Windows.Forms?displayProperty=nameWithType>.  
  
## <a name="robust-programming"></a>Отказоустойчивость  
 Для максимальной масштабируемости объекты <xref:System.Windows.Forms.DataGridViewCellStyle> следует распределить по нескольким строкам, столбцам или ячейкам с одинаковыми стилями, чтобы не задавать свойства стилей для каждого элемента в отдельности. Дополнительные сведения см. в разделе [масштабирование элемента управления DataGridView в Windows Forms](best-practices-for-scaling-the-windows-forms-datagridview-control.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView.DefaultCellStyle%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewCellStyle>
- [Базовое форматирование и оформление элемента управления DataGridView в Windows Forms](basic-formatting-and-styling-in-the-windows-forms-datagridview-control.md)
- [Стили ячеек элемента управления DataGridView в Windows Forms](cell-styles-in-the-windows-forms-datagridview-control.md)

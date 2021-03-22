---
title: Практическое руководство. Вывод изображений в ячейках элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- cells [Windows Forms], displaying images
- data grids [Windows Forms], displaying in grids
- DataGridView control [Windows Forms], displaying images
- data grids [Windows Forms], displaying images in cells
ms.assetid: 53b13d31-1b56-476d-9ab4-18bfac138a22
ms.openlocfilehash: 90aaff419ecc2c890a8b3802f3aaf12092febb73
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59083001"
---
# <a name="how-to-display-images-in-cells-of-the-windows-forms-datagridview-control"></a>Практическое руководство. Вывод изображений в ячейках элемента управления DataGridView в Windows Forms
Рисунок или изображение — одно из значений, которые можно отобразить в строку данных. Часто эти графики принимать форму фотографию сотрудника или логотип компании.  
  
 Применение рисунков очень просто при отображении данных в пределах <xref:System.Windows.Forms.DataGridView> элемента управления. <xref:System.Windows.Forms.DataGridView> В собственном коде обработки любого формата изображений, поддерживаемых элементом управления <xref:System.Drawing.Image> класса, а также OLE рисунка формат, используемый в некоторых базах данных.  
  
 Если <xref:System.Windows.Forms.DataGridView> элемента управления источника данных со столбцом изображений, они будут отображаться автоматически <xref:System.Windows.Forms.DataGridView> элемента управления.  
  
 В следующем примере кода показано, как извлекать значок из внедренного ресурса и преобразовать его в растровое изображение для отображения во всех ячейках столбец типа image. Еще один пример, который заменяет соответствующие образы текстовые значения ячеек, см. в разделе [как: Настройка форматирования данных в элементе управления DataGridView Windows Forms](how-to-customize-data-formatting-in-the-windows-forms-datagridview-control.md).  
  
## <a name="example"></a>Пример  
 [!code-csharp[System.Windows.Forms.DataGridViewMisc#050](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMisc/CS/datagridviewmisc.cs#050)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   элемент управления <xref:System.Windows.Forms.DataGridView> с именем `dataGridView1`;  
  
-   Ресурс со встроенным значком с именем `tree.ico`.  
  
-   ссылки на сборки <xref:System?displayProperty=nameWithType>, <xref:System.Windows.Forms?displayProperty=nameWithType> и <xref:System.Drawing?displayProperty=nameWithType>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- [Базовые характеристики столбцов, строк и ячеек элемента управления DataGridView в Windows Forms](basic-column-row-and-cell-features-wf-datagridview-control.md)
- [Практическое руководство. Настройка форматирования данных элемента управления DataGridView в Windows Forms](how-to-customize-data-formatting-in-the-windows-forms-datagridview-control.md)

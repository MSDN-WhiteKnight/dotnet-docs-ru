---
title: Практическое руководство. Добавление столбца, не связанного с данными, в связанный с данными элемент управления DataGridView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- columns [Windows Forms], unbound data
- data grids [Windows Forms], adding unbound columns
- DataGridView control [Windows Forms], unbound data
ms.assetid: f7bdc4d8-ba8e-421b-ad62-82d936f01372
ms.openlocfilehash: 40308f7e8cc12dcff5b7d4393645f6a9007cc2b7
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59215843"
---
# <a name="how-to-add-an-unbound-column-to-a-data-bound-windows-forms-datagridview-control"></a>Практическое руководство. Добавление столбца, не связанного с данными, в связанный с данными элемент управления DataGridView в Windows Forms
Данные, отображаемые в элементе управления <xref:System.Windows.Forms.DataGridView>, обычно берутся из какого-либо источника данных, однако может потребоваться отобразить столбец данных, которые получены не из источника данных. Такой столбец называется непривязанным. Непривязанные столбцы могут принимать различные формы. Как правило, они используются для предоставления доступа к сведениям о строке данных.  
  
 В следующем примере кода демонстрируется создание несвязанного столбца **сведения** кнопки для отображения дочерней таблицы, связанные с определенной строкой в родительской таблице, при реализации сценария «основной/подробности». Для реакции на нажатия кнопок реализован обработчик событий <xref:System.Windows.Forms.DataGridView.CellClick?displayProperty=nameWithType>, который отображает форму, содержащую дочернюю таблицу.  
  
 Эта задача поддерживается в Visual Studio.  Также см. раздел [Как Добавление и удаление столбцов в Windows Forms с помощью конструктора элемента управления DataGridView](add-and-remove-columns-in-the-datagrid-using-the-designer.md).  
  
## <a name="example"></a>Пример  
 [!code-csharp[System.Windows.Forms.DataGridViewMisc#010](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMisc/CS/datagridviewmisc.cs#010)]
 [!code-vb[System.Windows.Forms.DataGridViewMisc#010](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMisc/VB/datagridviewmisc.vb#010)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   элемент управления <xref:System.Windows.Forms.DataGridView> с именем `dataGridView1`;  
  
-   ссылки на сборки <xref:System?displayProperty=nameWithType> и <xref:System.Windows.Forms?displayProperty=nameWithType>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- [Отображение данных с помощью элемента управления DataGridView в Windows Forms](displaying-data-in-the-windows-forms-datagridview-control.md)
- [Режимы отображения данных в элементе управления DataGridView в Windows Forms](data-display-modes-in-the-windows-forms-datagridview-control.md)

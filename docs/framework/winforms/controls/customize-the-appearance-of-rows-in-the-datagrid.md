---
title: Практическое руководство. Настройка внешнего вида строк элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- data grids [Windows Forms], customizing rows
- rows [Windows Forms], customizing in DataGridView control
- DataGridView control [Windows Forms], customizing rows
ms.assetid: d40b53d2-7e7c-48c5-8570-6e79d15c3bbb
ms.openlocfilehash: 107ec75257907b934412d9ee333b00d5df05a99c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59110323"
---
# <a name="how-to-customize-the-appearance-of-rows-in-the-windows-forms-datagridview-control"></a>Практическое руководство. Настройка внешнего вида строк элемента управления DataGridView в Windows Forms
Внешним видом строк <xref:System.Windows.Forms.DataGridView> можно управлять при помощи одного или обоих событий <xref:System.Windows.Forms.DataGridView.RowPrePaint?displayProperty=nameWithType> и <xref:System.Windows.Forms.DataGridView.RowPostPaint?displayProperty=nameWithType>. Эти события спроектированы таким образом, что вы можете отобразить только необходимое, позволяя отрисовать остальное элементу управления <xref:System.Windows.Forms.DataGridView>. Например, для рисования пользовательского фона можно обрабатывать событие <xref:System.Windows.Forms.DataGridView.RowPrePaint?displayProperty=nameWithType> и дать возможность отдельным ячейкам нарисовать собственное содержимое переднего плана. Кроме того, можно дать возможность ячейкам отрисовать себя и добавить настраиваемый основной цвет в обработчике событий <xref:System.Windows.Forms.DataGridView.RowPostPaint?displayProperty=nameWithType>. Также можно отключить прорисовку ячеек и самостоятельно нарисовать все в обработчике событий <xref:System.Windows.Forms.DataGridView.RowPrePaint?displayProperty=nameWithType>.  
  
 В следующем примере кода реализованы обработчики для обоих событий, чтобы обеспечить выбор градиентного фона и настраиваемого основного цвета для нескольких столбцов.  
  
## <a name="example"></a>Пример  
 [!code-csharp[System.Windows.Forms.DataGridViewRowPainting#00](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewRowPainting/CS/datagridviewrowpainting.cs#00)]
 [!code-vb[System.Windows.Forms.DataGridViewRowPainting#00](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewRowPainting/VB/datagridviewrowpainting.vb#00)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   ссылки на сборки System, System.Drawing и System.Windows.Forms.  
  
 Сведения о выполнении сборки этого примера из командной строки для Visual Basic или Visual C#, см. в разделе [построение из командной строки](../../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md) или [командной строки создания с помощью csc.exe](../../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md). Можно также сборке этого примера в Visual Studio путем вставки кода в новый проект.  

## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridView.RowPrePaint?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.RowPostPaint?displayProperty=nameWithType>
- [Настройка элементов управления DataGridView в Windows Forms](customizing-the-windows-forms-datagridview-control.md)
- [Архитектура элементов управления DataGridView](datagridview-control-architecture-windows-forms.md)

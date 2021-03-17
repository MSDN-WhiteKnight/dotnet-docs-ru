---
title: Сортировка данных в элементе управления Windows Forms DataGridView
ms.date: 02/13/2018
helpviewer_keywords:
- data [Windows Forms], sorting in grids
- data grids [Windows Forms], sorting data
- DataGridView control [Windows Forms], sorting data
ms.assetid: c1d4f24c-d961-4181-809d-5a5caa6122e4
ms.openlocfilehash: 606ffc7bd6136b775adaaaa79cf5042cf1e2dd70
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57724925"
---
# <a name="sorting-data-in-the-windows-forms-datagridview-control"></a>Сортировка данных в элементе управления Windows Forms DataGridView

По умолчанию пользователи могут сортировать данные в <xref:System.Windows.Forms.DataGridView> элемента управления, щелкнув заголовок столбца текстового поля (и, нажав клавишу F3, при получении фокуса ввода ячейке текстового поля на .NET Framework 4.7.2 и более поздних версий). Вы можете изменить <xref:System.Windows.Forms.DataGridViewColumn.SortMode> определенные столбцы, чтобы разрешить пользователям сортировать по другим типам столбцов, когда имеет смысл для этого свойства. Можно также сортировать данные программными средствами по любому столбцу или нескольким столбцам.

## <a name="in-this-section"></a>Содержание раздела

[Установка режимов сортировки для столбцов элемента управления DataGridView в Windows Forms](column-sort-modes-in-the-windows-forms-datagridview-control.md)  
Описание параметров сортировки данных в элементе управления.

[Практическое руководство. Определение режимов сортировки для столбцов в элементе управления DataGridView Windows Forms](set-the-sort-modes-for-columns-wf-datagridview-control.md)  
Описывает, как разрешить пользователям сортировать по столбцам, которые не поддерживает сортировку по умолчанию.

[Практическое руководство. Настройка сортировки в элементе управления DataGridView Windows Forms](how-to-customize-sorting-in-the-windows-forms-datagridview-control.md)  
Описывает способ сортировки данных программным образом и настройки сортировки с помощью <xref:System.Windows.Forms.DataGridView.SortCompare?displayProperty=nameWithType> событий либо путем реализации <xref:System.Collections.IComparer> интерфейс.

## <a name="reference"></a>Ссылка

<xref:System.Windows.Forms.DataGridView>  
Справочная документация по элементу управления <xref:System.Windows.Forms.DataGridView>.  

<xref:System.Windows.Forms.DataGridView.Sort%2A?displayProperty=nameWithType>  
Содержит справочную документацию по <xref:System.Windows.Forms.DataGridView.Sort%2A> метод.

<xref:System.Windows.Forms.DataGridViewColumn.SortMode%2A?displayProperty=nameWithType>  
Содержит справочную документацию по <xref:System.Windows.Forms.DataGridViewColumn.SortMode%2A> свойство.

<xref:System.Windows.Forms.DataGridViewColumnSortMode>  
Содержит справочную документацию по <xref:System.Windows.Forms.DataGridViewColumnSortMode> перечисления.

## <a name="see-also"></a>См. также

- [Элемент управления DataGridView](datagridview-control-windows-forms.md)
- [Типы столбцов элемента управления DataGridView в Windows Forms](column-types-in-the-windows-forms-datagridview-control.md)

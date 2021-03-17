---
title: Практическое руководство. Сортировка содержимого элемента управления ComboBox, ListBox или CheckedListBox в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- CheckedListBox control [Windows Forms], sorting
- ComboBox control [Windows Forms], sorting contents
- combo boxes [Windows Forms], sorting contents
- list boxes [Windows Forms], sorting contents
- ListBox control [Windows Forms], sorting contents
ms.assetid: c268e387-3d1d-4d86-a940-19f6673c8d06
ms.openlocfilehash: bd26d396c238bfc53858320b8f4487df84b3436a
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59312583"
---
# <a name="how-to-sort-the-contents-of-a-windows-forms-combobox-listbox-or-checkedlistbox-control"></a>Практическое руководство. Сортировка содержимого элемента управления ComboBox, ListBox или CheckedListBox в Windows Forms
Элементы управления Windows Forms не выполняют сортировку, когда они привязкой к данным. Чтобы отобразить отсортированные данные, использовать источник данных, который поддерживает сортировку и затем у источника данных, которые сортируют их. Источники данных, поддерживающих сортировку представления данных, диспетчеры представлений данных и массивы с сортировкой.  
  
 Если элемент управления не является привязкой к данным, можно сортировать его.  
  
### <a name="to-sort-the-list"></a>Чтобы отсортировать список  
  
1. Задайте для свойства `Sorted` значение `true`.  
  
     Этот параметр перемещает все существующие элементы списка в отсортированном порядке.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ComboBox>
- <xref:System.Windows.Forms.ListBox>
- <xref:System.Windows.Forms.CheckedListBox>
- [Привязка данных Windows Forms](../windows-forms-data-binding.md)
- [Практическое руководство. Добавление и удаление элементов, отображаемых в элементах управления ComboBox, ListBox и CheckedListBox в Windows Forms](add-and-remove-items-from-a-wf-combobox.md)
- [Применение элемента управления ComboBox вместо элемента управления ListBox в Windows Forms](when-to-use-a-windows-forms-combobox-instead-of-a-listbox.md)
- [Создание списка для выбора элементов в Windows Forms](windows-forms-controls-used-to-list-options.md)

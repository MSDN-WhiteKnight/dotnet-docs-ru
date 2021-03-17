---
title: Общие сведения об элементе управления ComboBox (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- ComboBox
helpviewer_keywords:
- drop-down lists [Windows Forms], Windows Forms
- ComboBox control [Windows Forms], about ComboBox control
- drop-down lists [Windows Forms], ComboBox control
- combo boxes [Windows Forms], about combo boxes
ms.assetid: a58b393f-a614-45d1-8961-857a024b5acd
ms.openlocfilehash: 80056771744c9b97828a024adf32638e545a839e
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59211585"
---
# <a name="combobox-control-overview-windows-forms"></a>Общие сведения об элементе управления ComboBox (Windows Forms)
Windows Forms <xref:System.Windows.Forms.ComboBox> элемент управления используется для отображения данных в раскрывающемся поле со списком. По умолчанию <xref:System.Windows.Forms.ComboBox> элемент управления отображается в виде двух частей: верхняя часть представляет собой текстовое поле, которое пользователь может ввести элемент списка. Вторая часть — полем со списком, отображающий список элементов, из которых пользователь может выбрать его. Дополнительные сведения о других стилях со списком, см. в разделе [необходимости использования Windows Forms ComboBox Instead of ListBox](when-to-use-a-windows-forms-combobox-instead-of-a-listbox.md).  
  
 <xref:System.Windows.Forms.ComboBox.SelectedIndex%2A> Свойство возвращает целочисленное значение, соответствующее выбранному элементу списка. Можно программно изменить выбранный элемент, изменив <xref:System.Windows.Forms.ComboBox.SelectedIndex%2A> значение в коде; соответствующего элемента в списке будет отображаться в части текстового поля со списком. Если элемент не выбран, <xref:System.Windows.Forms.ComboBox.SelectedIndex%2A> значение равно -1. Если выбран первый элемент в списке, а затем <xref:System.Windows.Forms.ComboBox.SelectedIndex%2A> значение равно 0. <xref:System.Windows.Forms.ComboBox.SelectedItem%2A> Свойства аналогична <xref:System.Windows.Forms.ComboBox.SelectedIndex%2A> , но возвращает сам элемент обычно строковое значение. <xref:System.Windows.Forms.ComboBox.ObjectCollection.Count%2A> Свойство отражает количество элементов в списке, а значение <xref:System.Windows.Forms.ComboBox.ObjectCollection.Count%2A> свойство всегда имеет один больше, чем наибольшее возможное <xref:System.Windows.Forms.ComboBox.SelectedIndex%2A> поскольку значение <xref:System.Windows.Forms.ComboBox.SelectedIndex%2A> начинается с нуля.  
  
 Для добавления или удаления элементов в <xref:System.Windows.Forms.ComboBox> управления, используйте <xref:System.Windows.Forms.ComboBox.ObjectCollection.Add%2A>, <xref:System.Windows.Forms.ComboBox.ObjectCollection.Insert%2A>, <xref:System.Windows.Forms.ComboBox.ObjectCollection.Clear%2A> или <xref:System.Windows.Forms.ComboBox.ObjectCollection.Remove%2A> метод. Кроме того, можно добавить элементы в список с помощью <xref:System.Windows.Forms.ComboBox.Items%2A> свойства в конструкторе.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ComboBox>
- [Общие сведения об элементе управления ListBox](listbox-control-overview-windows-forms.md)
- [Применение элемента управления ComboBox вместо элемента управления ListBox в Windows Forms](when-to-use-a-windows-forms-combobox-instead-of-a-listbox.md)
- [Практическое руководство. Добавление и удаление элементов, отображаемых в элементах управления ComboBox, ListBox и CheckedListBox в Windows Forms](add-and-remove-items-from-a-wf-combobox.md)
- [Практическое руководство. Сортировка содержимого элемента управления ComboBox, ListBox или CheckedListBox в Windows Forms](sort-the-contents-of-a-wf-combobox-listbox-or-checkedlistbox-control.md)
- [Практическое руководство. Получение доступа к определенным элементам в элементах управления ComboBox, ListBox или CheckedListBox в Windows Forms](access-specific-items-in-a-wf-combobox-listbox-or-checkedlistbox.md)
- [Практическое руководство. Связывание элемента управления ComboBox или ListBox с данными в Windows Forms](how-to-bind-a-windows-forms-combobox-or-listbox-control-to-data.md)
- [Создание списка для выбора элементов в Windows Forms](windows-forms-controls-used-to-list-options.md)
- [Практическое руководство. Создание таблицы подстановки для элемента управления ComboBox, ListBox или CheckedListBox в Windows Forms](create-a-lookup-table-for-a-wf-combobox-listbox.md)

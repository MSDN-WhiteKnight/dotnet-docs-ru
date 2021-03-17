---
title: Применение элемента управления ComboBox вместо элемента управления ListBox в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- ListBox control [Windows Forms], adding and removing items
- ListBox control [Windows Forms], vs. ComboBox
- bound controls [Windows Forms], combo boxes
- Windows Forms controls, data binding
- ComboBox control [Windows Forms], compared to ListBox
- combo boxes [Windows Forms], compared to list boxes
- ListBox control [Windows Forms], accessing items
- ListCount property
ms.assetid: 7bcaea58-1cfa-46db-9baf-b75a69d8f9ec
ms.openlocfilehash: 8a2429049acf1a22edde8d132ece17da4e91f1db
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59111427"
---
# <a name="when-to-use-a-windows-forms-combobox-instead-of-a-listbox"></a>Применение элемента управления ComboBox вместо элемента управления ListBox в Windows Forms
<xref:System.Windows.Forms.ComboBox> И <xref:System.Windows.Forms.ListBox> элементы управления имеют аналогичные поведения, а в некоторых случаях они взаимозаменяемы. Бывают случаи, тем не менее, если одно из них подходит больше в задачу.  
  
 Как правило поле со списком используется, когда имеется список возможных вариантов, и поле со списком подходит, если вы хотите ограничить данные, вводимые в список. Поле со списком содержит текстовое поле, поэтому варианты, отсутствующие в списке могут быть введены в. Исключение возникает, когда <xref:System.Windows.Forms.ComboBox.DropDownStyle%2A> свойству <xref:System.Windows.Forms.ComboBoxStyle.DropDownList>. В этом случае элемент управления будет выберите элемент, при вводе его первую букву.  
  
 Кроме того поля со списком экономии места в форме. Так как полный список не отображается, пока пользователь не щелкнет стрелку вниз, поле со списком можно легко разместить на небольшом пространстве, где не уместится поле со списком. Исключение возникает, когда <xref:System.Windows.Forms.ComboBox.DropDownStyle%2A> свойству <xref:System.Windows.Forms.ComboBoxStyle.Simple>: полный список и поля со списком может занимать больше места, чем поле со списком.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ComboBox>
- <xref:System.Windows.Forms.ListBox>
- [Практическое руководство. Добавление и удаление элементов, отображаемых в элементах управления ComboBox, ListBox и CheckedListBox в Windows Forms](add-and-remove-items-from-a-wf-combobox.md)
- [Практическое руководство. Сортировка содержимого элемента управления ComboBox, ListBox или CheckedListBox в Windows Forms](sort-the-contents-of-a-wf-combobox-listbox-or-checkedlistbox-control.md)
- [Создание списка для выбора элементов в Windows Forms](windows-forms-controls-used-to-list-options.md)

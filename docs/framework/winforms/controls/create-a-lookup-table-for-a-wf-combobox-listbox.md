---
title: Практическое руководство. Создание таблицы подстановки для элемента управления ComboBox, ListBox или CheckedListBox в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- CheckedListBox control [Windows Forms], creating lookup tables
- lookup tables
- list boxes [Windows Forms], lookup tables
- ListBox control [Windows Forms], lookup tables
- ComboBox control [Windows Forms], lookup table
- lookup tables [Windows Forms], creating for controls
- combo boxes [Windows Forms], lookup tables
- ListBox control [Windows Forms], creating lookup tables
ms.assetid: 4ce35f12-1f4e-4317-92d1-af8686a8cfaa
ms.openlocfilehash: a58522cc17ac379897a89a8e61485a1e271438a3
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59344108"
---
# <a name="how-to-create-a-lookup-table-for-a-windows-forms-combobox-listbox-or-checkedlistbox-control"></a>Практическое руководство. Создание таблицы подстановки для элемента управления ComboBox, ListBox или CheckedListBox в Windows Forms
Иногда полезно отображать данные в удобном для пользователя формате в форме Windows Forms и при этом сохранять их в формате, требуемом в используемой программе. Например, в бланке заказа продуктов питания могут отображаться элементы меню с названиями продуктов в списке. Однако таблица данных регистрации заказа будет содержать уникальные идентификаторы, представляющие продукты питания. В таблице ниже представлен пример хранения и отображения данных бланка заказа продуктов питания.  
  
### <a name="orderdetailstable"></a>OrderDetailsTable  
  
|OrderID|Код элемента|Количество|  
|-------------|------------|--------------|  
|4085|12|1|  
|4086|13|3|  
  
### <a name="itemtable"></a>ItemTable  
  
|ID|name|  
|--------|----------|  
|12|Картофель|  
|13|Цыпленок|  
  
 В этом случае одна таблица **OrderDetailsTable**, содержит фактические сведения, важные с отображения и сохранения. Однако с целью экономии места они представлены в неудобном для восприятия виде. Другая таблица, **ItemTable**, содержит только связанные сведения о том, какой идентификатор номер эквивалент для определения имени качества пищевых продуктов и ничего о заказах на фактический качества пищевых продуктов.  
  
 **ItemTable** подключен к <xref:System.Windows.Forms.ComboBox>, <xref:System.Windows.Forms.ListBox>, или <xref:System.Windows.Forms.CheckedListBox> управления с помощью трех свойств. `DataSource` Свойство содержит имя этой таблицы. `DisplayMember` Свойство содержит столбец данных таблицы, который будет отображаться в элементе управления (название продукта). `ValueMember` Свойство содержит столбец данных таблицы, в которой хранится информация (номер идентификатора).  
  
 **OrderDetailsTable** подключен к элементу управления с помощью коллекции привязок, через <xref:System.Windows.Forms.Control.DataBindings%2A> свойство. При добавлении объекта привязки в коллекцию свойство элемента управления соединиться элемент данных (столбец идентификаторов) в источнике данных ( **OrderDetailsTable**). Когда в элементе управления делается выбор, в этой таблице сохраняются вводимые данные.  
  
### <a name="to-create-a-lookup-table"></a>Создание таблицы подстановок  
  
1. Добавьте на форму элемент управления <xref:System.Windows.Forms.ComboBox>, <xref:System.Windows.Forms.ListBox> или <xref:System.Windows.Forms.CheckedListBox>.  
  
2. Произведите подключение к источнику данных.  
  
3. Установите связь между данными в двух таблицах. См. в разделе [Знакомство с объектами DataRelation](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/0k21zcyx(v=vs.120)).  
  
4. Задайте перечисленные ниже свойства. Их можно задать в коде или в конструкторе.  
  
    |Свойство|Параметр|  
    |--------------|-------------|  
    |<xref:System.Windows.Forms.ListControl.DataSource%2A>|Таблица, в которой содержатся сведения о том, какому коду соответствует тот или иной элемент. В приведенном выше сценарии это `ItemTable`.|  
    |<xref:System.Windows.Forms.ListControl.DisplayMember%2A>|Столбец таблицы источника данных, который необходимо отобразить в элементе управления. В приведенном выше сценарии это `"Name"` (Чтобы задать в коде, используйте кавычки).|  
    |<xref:System.Windows.Forms.ListControl.ValueMember%2A>|Столбец таблицы источника данных, который содержит сохраняемую информацию. В приведенном выше сценарии это `"ID"` (Чтобы задать в коде, используйте кавычки).|  
  
5. В процедуре вызовите метод <xref:System.Windows.Forms.ControlBindingsCollection.Add%2A> класса <xref:System.Windows.Forms.ControlBindingsCollection> для привязки свойства <xref:System.Windows.Forms.ListControl.SelectedValue%2A> элемента управления к таблице, в которой регистрируются данные, вводимые в форме. Также это можно сделать в конструкторе, а не в коде, обратившись к элемента управления <xref:System.Windows.Forms.Control.DataBindings%2A> свойство в **свойства** окна. В приведенном выше сценарии это `OrderDetailsTable`, а столбец `"ItemID"`.  
  
    ```vb  
    ListBox1.DataBindings.Add("SelectedValue", OrderDetailsTable, "ItemID")  
    ```  
  
    ```csharp  
    listBox1.DataBindings.Add("SelectedValue", OrderDetailsTable, "ItemID");  
    ```  
  
## <a name="see-also"></a>См. также

- [Связывание данных и Windows Forms](../data-binding-and-windows-forms.md)
- [Общие сведения об элементе управления ListBox](listbox-control-overview-windows-forms.md)
- [Общие сведения об элементе управления ComboBox](combobox-control-overview-windows-forms.md)
- [Общие сведения об элементе управления CheckedListBox](checkedlistbox-control-overview-windows-forms.md)
- [Создание списка для выбора элементов в Windows Forms](windows-forms-controls-used-to-list-options.md)

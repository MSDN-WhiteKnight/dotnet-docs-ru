---
title: Практическое руководство. Связывание элемента управления ComboBox или ListBox с данными в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- data [Windows Forms], binding to controls
- list boxes [Windows Forms], data binding
- ComboBox control [Windows Forms], data binding
- data binding [Windows Forms], combo boxes
- ListBox control [Windows Forms], data binding
- combo boxes [Windows Forms], data binding
- bound controls [Windows Forms], combo boxes
- Windows Forms controls, data binding
- data-bound controls [Windows Forms], Windows Forms
ms.assetid: dfd7f081-8bea-4a41-86a3-86a1934828ef
ms.openlocfilehash: b869898a20008343b6c6cbe4bc7e399fc86fb232
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59306057"
---
# <a name="how-to-bind-a-windows-forms-combobox-or-listbox-control-to-data"></a>Практическое руководство. Связывание элемента управления ComboBox или ListBox с данными в Windows Forms
Можно привязать <xref:System.Windows.Forms.ComboBox> и <xref:System.Windows.Forms.ListBox> к данным для выполнения задач, таких как просмотр данных в базе данных, ввод новых данных и изменение существующих данных.  
  
### <a name="to-bind-a-combobox-or-listbox-control"></a>Для привязки элемента управления ComboBox или ListBox  
  
1. Задайте `DataSource` свойство для объекта источника данных. Возможные источники данных <xref:System.Windows.Forms.BindingSource> привязаны к данным, таблицу данных, представление данных, набор данных, представление данных диспетчера, массив или любой класс, реализующий <xref:System.Collections.IList> интерфейс. Дополнительные сведения см. в разделе [Data Sources Supported by Windows Forms](../data-sources-supported-by-windows-forms.md).  
  
2. Если выполнить привязку к таблице, задать `DisplayMember` значения свойства имя столбца в источнике данных.  
  
     \- или -  
  
     Если при привязке к <xref:System.Collections.IList>, укажите элемент отображения общедоступного свойства типа в списке.  
  
    ```vb  
    Private Sub BindComboBox()  
      ComboBox1.DataSource = DataSet1.Tables("Suppliers")  
      ComboBox1.DisplayMember = "ProductName"  
    End Sub  
    ```  
  
    ```csharp  
    private void BindComboBox()  
    {  
      comboBox1.DataSource = dataSet1.Tables["Suppliers"];  
      comboBox1.DisplayMember = "ProductName";  
    }  
    ```  
  
    > [!NOTE]
    >  Если имеется привязка к источнику данных, который не реализует <xref:System.ComponentModel.IBindingList> интерфейса, такие как <xref:System.Collections.ArrayList>, привязанного элемента управления не обновляются при обновлении источника данных. Например, если у вас есть поле со списком привязать к <xref:System.Collections.ArrayList> и добавлении данных <xref:System.Collections.ArrayList>, эти новые элементы не будут отображаться в поле со списком. Тем не менее, вы можете принудительно поле со списком обновления путем вызова <xref:System.Windows.Forms.BindingManagerBase.SuspendBinding%2A> и <xref:System.Windows.Forms.BindingManagerBase.ResumeBinding%2A> методы в экземпляре <xref:System.Windows.Forms.BindingContext> класса, к которому привязан элемент управления.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ComboBox>
- <xref:System.Windows.Forms.ListBox>
- [Привязка данных Windows Forms](../windows-forms-data-binding.md)
- [Связывание данных и Windows Forms](../data-binding-and-windows-forms.md)
- [Создание списка для выбора элементов в Windows Forms](windows-forms-controls-used-to-list-options.md)

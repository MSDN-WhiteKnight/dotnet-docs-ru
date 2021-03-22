---
title: Практическое руководство. Отображение дополнительных данных в столбцах элемента управления ListView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- list items
- Details view
- ListView control [Windows Forms], adding ListSubItems
- subitems
ms.assetid: e465f044-cde7-4fd9-a687-788a73a0f554
ms.openlocfilehash: 318521cc1377be89ef54706d80c8b2990a6ba1b8
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59339298"
---
# <a name="how-to-display-subitems-in-columns-with-the-windows-forms-listview-control"></a>Практическое руководство. Отображение дополнительных данных в столбцах элемента управления ListView в Windows Forms
Windows Forms <xref:System.Windows.Forms.ListView> элемент управления может отображать дополнительный текст или дополнительные элементы, для каждого элемента в представлении сведений. В первом столбце отображается текст элемента, например код сотрудника. Второй, третий и последующих столбцах отображаются первый, второй и последующие связанные подэлементы.  
  
### <a name="to-add-subitems-to-a-list-item"></a>Чтобы добавить дополнительные элементы в элемент списка  
  
1. Добавьте все необходимые столбцы. Поскольку первый столбец будет отображаться элемента <xref:System.Windows.Forms.ListView.Text%2A> свойство, требуется один столбец больше, чем количество дополнительных элементов. Дополнительные сведения о добавлении столбцов см. в разделе [как: Добавление столбцов в Windows Forms элемента управления ListView](how-to-add-columns-to-the-windows-forms-listview-control.md).  
  
2. Вызовите <xref:System.Windows.Forms.ListViewItem.ListViewSubItemCollection.Add%2A> метод из коллекции, возвращаемой <xref:System.Windows.Forms.ListViewItem.SubItems%2A> свойство элемента. В примере кода ниже задает employee name и department для элемента списка.  
  
     [!code-csharp[System.Windows.Forms.ListViewLegacyTopics#61](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ListViewLegacyTopics/CS/Class1.cs#61)]
       
  
## <a name="see-also"></a>См. также

- [Общие сведения об элементе управления ListView](listview-control-overview-windows-forms.md)
- [Практическое руководство. Добавление и удаление элементов с помощью элемента управления ListView в Windows Forms](how-to-add-and-remove-items-with-the-windows-forms-listview-control.md)
- [Практическое руководство. Добавление столбцов в элемент управления ListView в Windows Forms](how-to-add-columns-to-the-windows-forms-listview-control.md)
- [Практическое руководство. Отображение значков в элементе управления ListView в Windows Forms](how-to-display-icons-for-the-windows-forms-listview-control.md)
- [Практическое руководство. Добавление пользовательских данных в элемент управления TreeView или ListView (Windows Forms)](add-custom-information-to-a-treeview-or-listview-control-wf.md)

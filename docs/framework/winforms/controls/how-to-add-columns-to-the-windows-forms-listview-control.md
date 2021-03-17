---
title: Практическое руководство. Добавление столбцов в элемент управления ListView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- ListView control [Windows Forms], adding column headers
- columns [Windows Forms], adding to ListView controls
- list views [Windows Forms], adding columns
ms.assetid: 79174274-12ee-4a5d-80db-6ec02976d010
ms.openlocfilehash: 5c87d43513f2125945145445c61f689cdd9d2aaf
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59345746"
---
# <a name="how-to-add-columns-to-the-windows-forms-listview-control"></a>Практическое руководство. Добавление столбцов в элемент управления ListView в Windows Forms
В представлении сведений о <xref:System.Windows.Forms.ListView> элемент управления может отображать несколько столбцов для каждого элемента списка. Столбцы можно использовать для отображения пользователю следующая информация о каждом элементе списка. Например в списке файлов можно отображать имя файла, тип файла, размер и Дата последнего изменения файла. Сведения о заполнении столбцов после их создания см. в разделе [как: Отображение дополнительных данных в столбцах с помощью Windows Forms элемента управления ListView](how-to-display-subitems-in-columns-with-the-windows-forms-listview-control.md).  
  
### <a name="to-add-columns-programmatically"></a>Для добавления столбцов программным образом  
  
1. Задайте в качестве <xref:System.Windows.Forms.ListView.View%2A> свойства <xref:System.Windows.Forms.View.Details>.  
  
2. Используйте <xref:System.Windows.Forms.ListView.ColumnHeaderCollection.Add%2A> метод в представлении списка <xref:System.Windows.Forms.ListView.Columns%2A> свойство.  
  
     [!code-csharp[System.Windows.Forms.ListViewLegacyTopics#31](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ListViewLegacyTopics/CS/Class1.cs#31)]
     [!code-vb[System.Windows.Forms.ListViewLegacyTopics#31](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ListViewLegacyTopics/VB/Class1.vb#31)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ListView>
- [Элемент управления ListView](listview-control-windows-forms.md)
- [Общие сведения об элементе управления ListView](listview-control-overview-windows-forms.md)

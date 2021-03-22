---
title: Практическое руководство. Отображение значков в элементе управления ListView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- ListView control [Windows Forms], displaying icons
- icons [Windows Forms], displaying for ListView controls
- lists [Windows Forms], displaying icons
- ImageList component [Windows Forms], with ListView control
- list views [Windows Forms], displaying icons
ms.assetid: 9d577542-8595-429b-99e5-078770ec9d35
ms.openlocfilehash: 8e4ae744eecbe894767114179dd63651828b191b
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59318615"
---
# <a name="how-to-display-icons-for-the-windows-forms-listview-control"></a>Практическое руководство. Отображение значков в элементе управления ListView в Windows Forms
Windows Forms <xref:System.Windows.Forms.ListView> элемент управления может отображать значки из трех списков изображений. Представления списка, подробности и SmallIcon отображение изображений из списка изображений, указанных в <xref:System.Windows.Forms.ListView.SmallImageList%2A> свойство. Представление LargeIcon показывает изображения из списка изображений, указанных в <xref:System.Windows.Forms.ListView.LargeImageList%2A> свойство. В представлении списка также может отображаться дополнительный набор значков, заданных в <xref:System.Windows.Forms.ListView.StateImageList%2A> свойство, рядом с крупных или мелких значков. Дополнительные сведения о списках изображений, см. в разделе [компонента ImageList](imagelist-component-windows-forms.md) и [как: Добавление и удаление изображений с помощью Windows Forms компонента ImageList](how-to-add-or-remove-images-with-the-windows-forms-imagelist-component.md).  
  
### <a name="to-display-images-in-a-list-view"></a>Для отображения изображений в виде списка  
  
1. Задайте соответствующее свойство —<xref:System.Windows.Forms.ListView.SmallImageList%2A>, <xref:System.Windows.Forms.ListView.LargeImageList%2A>, или <xref:System.Windows.Forms.ListView.StateImageList%2A>— к существующему <xref:System.Windows.Forms.ImageList> компонента, вы хотите использовать.  
  
     Эти свойства можно задать в конструкторе с помощью окна «Свойства» или в коде.  
  
     [!code-csharp[System.Windows.Forms.ListViewLegacyTopics#41](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ListViewLegacyTopics/CS/Class1.cs#41)]
       
  
2. Задайте <xref:System.Windows.Forms.ListViewItem.ImageIndex%2A> или <xref:System.Windows.Forms.ListViewItem.StateImageIndex%2A> свойство для каждого элемента списка, значок.  
  
     Эти свойства можно задать в коде или в **редактор коллекции ListViewItem**. Чтобы открыть **редактор коллекции ListViewItem**, нажмите кнопку с многоточием (![экрана VisualStudioEllipsesButton](../media/vbellipsesbutton.png "vbEllipsesButton")) рядом с <xref:System.Windows.Forms.ListView.Items%2A>свойство **свойства** окна.  
  
     [!code-csharp[System.Windows.Forms.ListViewLegacyTopics#42](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ListViewLegacyTopics/CS/Class1.cs#42)]
       
  
## <a name="see-also"></a>См. также

- [Общие сведения об элементе управления ListView](listview-control-overview-windows-forms.md)
- [Практическое руководство. Добавление и удаление элементов с помощью элемента управления ListView в Windows Forms](how-to-add-and-remove-items-with-the-windows-forms-listview-control.md)
- [Практическое руководство. Добавление столбцов в элемент управления ListView в Windows Forms](how-to-add-columns-to-the-windows-forms-listview-control.md)
- [Практическое руководство. Добавление пользовательских данных в элемент управления TreeView или ListView (Windows Forms)](add-custom-information-to-a-treeview-or-listview-control-wf.md)
- [Компонент ImageList](imagelist-component-windows-forms.md)

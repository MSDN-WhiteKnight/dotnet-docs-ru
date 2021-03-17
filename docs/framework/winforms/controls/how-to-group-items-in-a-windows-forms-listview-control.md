---
title: Практическое руководство. Группирование элементов в элементе управления ListView в формах Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- ListView control [Windows Forms], grouping items
- lists [Windows Forms], grouping items
- grouping
- list views [Windows Forms], grouping items
- groups
- groups [Windows Forms], in Windows Forms controls
ms.assetid: 610416a1-8da4-436c-af19-5f19e654769b
ms.openlocfilehash: f616436671da449e4f7b47c0a5d0c1b576584a1a
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59312310"
---
# <a name="how-to-group-items-in-a-windows-forms-listview-control"></a>Практическое руководство. Группирование элементов в элементе управления ListView в формах Windows Forms
Функция группирования из <xref:System.Windows.Forms.ListView> элемента управления, можно отобразить соответствующие наборы элементов в группах. Эти группы, разделенных на экране группу горизонтальных заголовков, содержащих заголовки групп. Можно использовать <xref:System.Windows.Forms.ListView> группы для упрощения просмотра больших списков, сгруппировав элементы по алфавиту, по дате или по другим критериям. На следующем рисунке показана некоторые сгруппированных элементов.  
  
 ![Группы ListView](./media/listviewgroups.gif "ListViewGroups")  
ListView сгруппированные элементы  
  
 Чтобы включить группирования, сначала необходимо создать одну или несколько групп, либо в конструкторе, либо программным способом. После определения группы можно назначить <xref:System.Windows.Forms.ListView> элементы в группу. Вы также можно перемещать элементы из одной группы в другую программным способом.  
  
> [!NOTE]
>  <xref:System.Windows.Forms.ListView> группы доступны только на [!INCLUDE[WinXpFamily](../../../../includes/winxpfamily-md.md)] когда приложение вызывает <xref:System.Windows.Forms.Application.EnableVisualStyles%2A?displayProperty=nameWithType> метод. В предыдущих версиях операционных систем любой код, относящийся к группам не влияет, и группы не будут. Дополнительные сведения см. в разделе <xref:System.Windows.Forms.ListView.Groups%2A?displayProperty=nameWithType>.  
  
### <a name="to-add-groups"></a>Чтобы добавить группы  
  
1. Используйте метод <xref:System.Windows.Forms.ListViewGroupCollection.Add%2A> коллекции <xref:System.Windows.Forms.ListView.Groups%2A> .  
  
     [!code-csharp[System.Windows.Forms.ListViewLegacyTopics#21](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ListViewLegacyTopics/CS/Class1.cs#21)]
     [!code-vb[System.Windows.Forms.ListViewLegacyTopics#21](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ListViewLegacyTopics/VB/Class1.vb#21)]  
  
### <a name="to-remove-groups"></a>Удаление групп  
  
1. Используйте <xref:System.Windows.Forms.ListViewGroupCollection.RemoveAt%2A> или <xref:System.Windows.Forms.ListViewGroupCollection.Clear%2A> метод <xref:System.Windows.Forms.ListView.Groups%2A> коллекции.  
  
     <xref:System.Windows.Forms.ListViewGroupCollection.RemoveAt%2A> Метод удаляет одну группу; <xref:System.Windows.Forms.ListViewGroupCollection.Clear%2A> метод удаляет все группы из списка.  
  
    > [!NOTE]
    >  Удаление группы не приводит к удалению элементов в этой группе.  
  
     [!code-csharp[System.Windows.Forms.ListViewLegacyTopics#22](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ListViewLegacyTopics/CS/Class1.cs#22)]
     [!code-vb[System.Windows.Forms.ListViewLegacyTopics#22](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ListViewLegacyTopics/VB/Class1.vb#22)]  
  
### <a name="to-assign-items-to-groups-or-move-items-between-groups"></a>Чтобы назначить группам элементов или перемещать элементы между группами  
  
1. Задать <xref:System.Windows.Forms.ListViewItem.Group%2A?displayProperty=nameWithType> свойства отдельных элементов.  
  
     [!code-csharp[System.Windows.Forms.ListViewLegacyTopics#23](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ListViewLegacyTopics/CS/Class1.cs#23)]
     [!code-vb[System.Windows.Forms.ListViewLegacyTopics#23](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ListViewLegacyTopics/VB/Class1.vb#23)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ListView>
- <xref:System.Windows.Forms.ListView.Groups%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.ListViewGroup>
- [Элемент управления ListView](listview-control-windows-forms.md)
- [Общие сведения об элементе управления ListView](listview-control-overview-windows-forms.md)
- [Практическое руководство. Добавление и удаление элементов с помощью элемента управления ListView в Windows Forms](how-to-add-and-remove-items-with-the-windows-forms-listview-control.md)

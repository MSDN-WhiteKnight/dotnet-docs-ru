---
title: Общие сведения об элементе управления ListView (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- ListView
helpviewer_keywords:
- lists
- ListView control [Windows Forms], about ListView control
- list views
ms.assetid: c9ef56c1-3bb1-4101-9f4e-e95e720f2756
ms.openlocfilehash: a60c415427a1be994f8081725f20e867dca66aa1
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59101885"
---
# <a name="listview-control-overview-windows-forms"></a>Общие сведения об элементе управления ListView (Windows Forms)
Элемент управления <xref:System.Windows.Forms.ListView> Windows Forms отображает список элементов со значками. Представление списка можно использовать для создания пользовательского интерфейса, аналогичного правой области окна проводника. Элемент управления имеет четыре режима представления: LargeIcon, SmallIcon, списка и сведений.  
  
## <a name="what-you-can-do-with-the-listview-control"></a>Что делать с элементом управления ListView  
  
> [!NOTE]
>  Дополнительный режим просмотра плитки, доступна только в ОС Windows Server 2003 и Windows XP. Дополнительные сведения см. в разделе [Как Включение вида мозаики в Windows Forms элемента управления ListView](how-to-enable-tile-view-in-a-windows-forms-listview-control.md).  
  
 В режиме LargeIcon отображаются крупные значки, рядом с текстом элемента; элементы появляются в нескольких столбцах, если элемент управления является достаточно большим. Режим SmallIcon аналогичен за исключением того, что отображается мелких значков. Режим списка отображаются мелкие значки, но всегда находится в одном столбце. Режим сведений отображаются элементы в нескольких столбцах. Подробную информацию см. в разделе [Практическое руководство. Добавление столбцов в Windows Forms элемента управления ListView](how-to-add-columns-to-the-windows-forms-listview-control.md). Режим представления определяется <xref:System.Windows.Forms.ListView.View%2A> свойство. Все режимы представлении можно отобразить изображения из списков изображений. Подробную информацию см. в разделе [Практическое руководство. Отображение значков Windows Forms элемента управления ListView](how-to-display-icons-for-the-windows-forms-listview-control.md).  
  
 В следующей таблице перечислены некоторые из <xref:System.Windows.Forms.ListView> члены и представления, они допустимы в.  
  
|Член ListView|Просмотр|  
|---------------------|----------|  
|<xref:System.Windows.Forms.ListView.Alignment%2A> свойство;|<xref:System.Windows.Forms.View.SmallIcon> или <xref:System.Windows.Forms.View.LargeIcon>|  
|<xref:System.Windows.Forms.ListView.AutoArrange%2A> свойство;|<xref:System.Windows.Forms.View.SmallIcon> или <xref:System.Windows.Forms.View.LargeIcon>|  
|<xref:System.Windows.Forms.ListView.AutoResizeColumn%2A> метод|<xref:System.Windows.Forms.View.Details>|  
|<xref:System.Windows.Forms.ListView.Columns%2A> свойство;|<xref:System.Windows.Forms.View.Details> или <xref:System.Windows.Forms.View.Tile>|  
|<xref:System.Windows.Forms.ListView.DrawSubItem> событие|<xref:System.Windows.Forms.View.Details>|  
|<xref:System.Windows.Forms.ListView.FindItemWithText%2A> метод|<xref:System.Windows.Forms.View.Details>, <xref:System.Windows.Forms.View.List>или <xref:System.Windows.Forms.View.Tile>|  
|<xref:System.Windows.Forms.ListView.FindNearestItem%2A> метод|<xref:System.Windows.Forms.View.SmallIcon> или <xref:System.Windows.Forms.View.LargeIcon>|  
|<xref:System.Windows.Forms.ListView.GetItemAt%2A> метод|<xref:System.Windows.Forms.View.Details> или <xref:System.Windows.Forms.View.Tile>|  
|<xref:System.Windows.Forms.ListView.Groups%2A> свойство;|Все представления, за исключением <xref:System.Windows.Forms.View.List>|  
|<xref:System.Windows.Forms.ListView.HeaderStyle%2A> свойство;|<xref:System.Windows.Forms.View.Details>.|  
|<xref:System.Windows.Forms.ListView.InsertionMark%2A> свойство;|<xref:System.Windows.Forms.View.LargeIcon>, <xref:System.Windows.Forms.View.SmallIcon>или <xref:System.Windows.Forms.View.Tile>|  
  
 Ключевое свойство <xref:System.Windows.Forms.ListView> элемент управления является <xref:System.Windows.Forms.ListView.Items%2A>, который содержит элементы, отображаемые элементом управления. <xref:System.Windows.Forms.ListView.SelectedItems%2A> Свойство содержит коллекцию элементов, выбранных в элементе управления. Пользователь может выбрать несколько элементов, например перетаскивание нескольких элементов за раз на другой элемент управления, если <xref:System.Windows.Forms.ListView.MultiSelect%2A> свойству `true`. <xref:System.Windows.Forms.ListView> Элемент управления может отображать флажки рядом с элементами, если <xref:System.Windows.Forms.ListView.CheckBoxes%2A> свойству `true`.  
  
 <xref:System.Windows.Forms.ListView.Activation%2A> Свойство определяет, какой тип действия должен выполнить пользователь для активации элемента в списке: возможные варианты: <xref:System.Windows.Forms.ItemActivation.Standard>, <xref:System.Windows.Forms.ItemActivation.OneClick>, и <xref:System.Windows.Forms.ItemActivation.TwoClick>. <xref:System.Windows.Forms.ItemActivation.OneClick> для активации требуется одним щелчком для активации элемента. <xref:System.Windows.Forms.ItemActivation.TwoClick> Активация требует от пользователя, дважды щелкните для активации элемента; одним щелчком мыши изменяет цвет текста элемента. <xref:System.Windows.Forms.ItemActivation.Standard> Активация требует от пользователя, дважды щелкните, чтобы активировать элемент, но элемент не приводит к изменению внешнего вида.  
  
 <xref:System.Windows.Forms.ListView> Управления также поддерживает стили оформления и другие функции, доступные на платформе Windows XP, включая группирование, мозаичное представление и метки вставки.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ListView>
- [Элемент управления ListView](listview-control-windows-forms.md)
- [Практическое руководство. Добавление и удаление элементов с помощью элемента управления ListView в Windows Forms](how-to-add-and-remove-items-with-the-windows-forms-listview-control.md)
- [Практическое руководство. Добавление столбцов в элемент управления ListView в Windows Forms](how-to-add-columns-to-the-windows-forms-listview-control.md)
- [Практическое руководство. Отображение значков в элементе управления ListView в Windows Forms](how-to-display-icons-for-the-windows-forms-listview-control.md)
- [Практическое руководство. Отображение дополнительных данных в столбцах элемента управления ListView в Windows Forms](how-to-display-subitems-in-columns-with-the-windows-forms-listview-control.md)
- [Практическое руководство. Выделение строки элемента управления ListView в Windows Forms](how-to-select-an-item-in-the-windows-forms-listview-control.md)
- [Практическое руководство. Группирование элементов в элементе управления ListView в формах Windows Forms](how-to-group-items-in-a-windows-forms-listview-control.md)
- [Практическое руководство. Индикация места вставки в элементе управления ListView в Windows Forms](how-to-display-an-insertion-mark-in-a-windows-forms-listview-control.md)
- [Практическое руководство. Добавление в элемент управления ListView возможностей поиска](how-to-add-search-capabilities-to-a-listview-control.md)
- [Практическое руководство. Добавление пользовательских данных в элемент управления TreeView или ListView (Windows Forms)](add-custom-information-to-a-treeview-or-listview-control-wf.md)
- [Практическое руководство. Создание пользовательского интерфейса с несколькими областями с помощью Windows Forms](how-to-create-a-multipane-user-interface-with-windows-forms.md)

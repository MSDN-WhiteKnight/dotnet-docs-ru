---
title: Практическое руководство. Группирование элементов в элементе управления ListView в формах Windows Forms с помощью конструктора
ms.date: 03/30/2017
helpviewer_keywords:
- ListView control [Windows Forms], grouping items
- grouping
- groups [Windows Forms], in Windows Forms controls
ms.assetid: 8b615000-69d9-4c64-acaf-b54fa09b69e3
ms.openlocfilehash: 7c25c012798adcf90c652beb91a7550406e5f8ff
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59321436"
---
# <a name="how-to-group-items-in-a-windows-forms-listview-control-using-the-designer"></a>Практическое руководство. Группирование элементов в элементе управления ListView в формах Windows Forms с помощью конструктора
Функция группирования элемента <xref:System.Windows.Forms.ListView> управления позволяет отображать соответствующие наборы элементов в группах. Эти группы, разделенных на экране группу горизонтальных заголовков, содержащих заголовки групп. Можно использовать <xref:System.Windows.Forms.ListView> группы для упрощения просмотра больших списков, сгруппировав элементы по алфавиту, по дате или по другим критериям. На следующем рисунке показана некоторые сгруппированных элементов.  
  
 ![Группы ListView](./media/listviewgroups.gif "ListViewGroups")  
  
 Следующая процедура требуется **приложения Windows** проекта с формой, содержащей <xref:System.Windows.Forms.ListView> элемента управления. Сведения о настройке такого проекта см. в разделе [как: Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project) и [как: Добавление элементов управления в Windows Forms](how-to-add-controls-to-windows-forms.md).  
  
 Чтобы включить группирования, необходимо сначала создать один или несколько <xref:System.Windows.Forms.ListViewGroup> объектов в конструкторе или программным способом. После определения группы можно назначить элементы.  
  
> [!NOTE]
>  <xref:System.Windows.Forms.ListView> группы доступны только на [!INCLUDE[WinXpFamily](../../../../includes/winxpfamily-md.md)] когда приложение вызывает <xref:System.Windows.Forms.Application.EnableVisualStyles%2A?displayProperty=nameWithType> метод. В предыдущих версиях операционных систем любой код, относящийся к группам не влияет, и группы не будут. Дополнительные сведения см. в разделе <xref:System.Windows.Forms.ListView.Groups%2A?displayProperty=nameWithType>.  
>   
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-add-or-remove-groups-in-the-designer"></a>Для добавления или удаления групп в конструкторе  
  
1. В **свойства** окно, нажмите кнопку **кнопку с многоточием** (![экрана VisualStudioEllipsesButton](../media/vbellipsesbutton.png "vbEllipsesButton")) рядом с полем <xref:System.Windows.Forms.ListView.Groups%2A> свойство.  
  
     **Редактор коллекции ListViewGroup** отображается.  
  
2. Чтобы добавить группу, нажмите кнопку **добавить** кнопки. Затем можно задать свойства новой группы, такие как <xref:System.Windows.Forms.ListViewGroup.Header%2A> и <xref:System.Windows.Forms.ListViewGroup.HeaderAlignment%2A> свойства. Чтобы удалить группу, выберите его и нажмите кнопку **удалить** кнопки.  
  
### <a name="to-assign-items-to-groups-in-the-designer"></a>Назначение элементов группам в конструкторе  
  
1. В **свойства** окно, нажмите кнопку **кнопку с многоточием** (![экрана VisualStudioEllipsesButton](../media/vbellipsesbutton.png "vbEllipsesButton")) рядом с полем <xref:System.Windows.Forms.ListView.Items%2A> свойство.  
  
     **Редактор коллекции ListViewItem** отображается.  
  
2. Чтобы добавить новый элемент, щелкните **добавить** кнопки. Затем можно задать свойства нового элемента, такие как <xref:System.Windows.Forms.ListViewItem.Text%2A> и <xref:System.Windows.Forms.ListViewItem.ImageIndex%2A> свойства.  
  
3. Выберите <xref:System.Windows.Forms.ListViewItem.Group%2A> свойство и выберите группу из раскрывающегося списка.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ListView>
- <xref:System.Windows.Forms.ListView.Groups%2A>
- <xref:System.Windows.Forms.ListViewGroup>
- [Элемент управления ListView](listview-control-windows-forms.md)
- [Общие сведения об элементе управления ListView](listview-control-overview-windows-forms.md)
- [Практическое руководство. Добавление и удаление элементов с помощью элемента управления ListView в Windows Forms](how-to-add-and-remove-items-with-the-windows-forms-listview-control.md)

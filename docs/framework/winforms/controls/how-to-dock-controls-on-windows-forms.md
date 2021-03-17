---
title: Практическое руководство. Закрепление элементов управления в формах Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- controls [Windows Forms], docking
- Explorer-style applications [Windows Forms], creating
- Windows Forms controls, filling client area
ms.assetid: bc11f2e4-e90a-4830-b0e2-f43b6e2b8bec
ms.openlocfilehash: d015dce7307bec092f6da1dc5ee31691a6baf1f0
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59317263"
---
# <a name="how-to-dock-controls-on-windows-forms"></a>Практическое руководство. Закрепление элементов управления в формах Windows Forms
Вы можете закрепление элементов управления по границам формы или заполнить ими контейнера элемента управления (форму или контейнерный элемент управления). Например, Windows Explorer закрепляет его <xref:System.Windows.Forms.TreeView> элемента управления в левой части окна и его <xref:System.Windows.Forms.ListView> элемента управления в правой части окна. Используйте <xref:System.Windows.Forms.Control.Dock%2A> свойство для всех видимых элементов управления Windows Forms для определения режима закрепления.  
  
> [!NOTE]
>  Элементы управления закрепляются в обратном z порядке.  
  
 <xref:System.Windows.Forms.Control.Dock%2A> Свойство взаимодействует с <xref:System.Windows.Forms.Control.AutoSize%2A> свойство. Дополнительные сведения см. в разделе [Общие](autosize-property-overview.md).  
  
### <a name="to-dock-a-control"></a>Чтобы закрепить элемент управления  
  
1. Выберите элемент управления, который требуется закрепить.  
  
2. В окне «Свойства» щелкните стрелку справа от <xref:System.Windows.Forms.Control.Dock%2A> свойство.  
  
     Отображается редактор, показывающий набор полей, соответствующих краям и центру формы.  
  
3. Нажмите кнопку, представляющий границы формы, в которой вы хотите закрепить элемент управления. Чтобы заполнить содержимое формы элемента управления или контейнерный элемент управления, щелкните поле center. Нажмите кнопку **(нет)** для запрещения закрепления.  
  
     Элемент управления изменяется автоматически в соответствии с границами закрепленной позиции.  
  
    > [!NOTE]
    >  Наследуемые элементы управления должны быть `Protected` могла быть закреплено. Чтобы изменить уровень доступа для элемента управления, установите его **модификатор** свойства в окне «Свойства».  
  
## <a name="see-also"></a>См. также

- [Элементы управления Windows Forms](index.md)
- [Расположение элементов управления в формах Windows Forms](arranging-controls-on-windows-forms.md)
- [Создание меток и назначение сочетаний клавиш для элементов управления Windows Forms](labeling-individual-windows-forms-controls-and-providing-shortcuts-to-them.md)
- [Элементы управления для использования в формах Windows Forms](controls-to-use-on-windows-forms.md)
- [Функциональная классификация элементов управления Windows Forms](windows-forms-controls-by-function.md)
- [Практическое руководство. Привязка и закрепление дочерних элементов управления в элементе управления FlowLayoutPanel](how-to-anchor-and-dock-child-controls-in-a-flowlayoutpanel-control.md)
- [Практическое руководство. Привязка и закрепление дочерних элементов управления в элементе управления TableLayoutPanel](how-to-anchor-and-dock-child-controls-in-a-tablelayoutpanel-control.md)
- [Свойство AutoSize](autosize-property-overview.md)
- [Практическое руководство. Привязка элементов управления в формах Windows Forms](how-to-anchor-controls-on-windows-forms.md)

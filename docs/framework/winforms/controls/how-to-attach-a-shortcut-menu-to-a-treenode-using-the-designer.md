---
title: Практическое руководство. Прикрепление контекстного меню к элементу управления TreeNode с помощью конструктора
ms.date: 03/30/2017
helpviewer_keywords:
- shortcut menus [Windows Forms], attaching to TreeNodes
- TreeNode [Windows Forms], attaching a shortcut menu using Designer
ms.assetid: 8e45e184-1313-4f8f-90ff-2cd5789b2268
ms.openlocfilehash: 9be633d14429bc2ceda1f0db2ff09252d55d5dd5
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59337452"
---
# <a name="how-to-attach-a-shortcut-menu-to-a-treenode-using-the-designer"></a>Практическое руководство. Прикрепление контекстного меню к элементу управления TreeNode с помощью конструктора
Windows Forms <xref:System.Windows.Forms.TreeView> элемент управления отображает иерархию узлов аналогично к файлам и папкам, отображаемым в области слева компонента Windows Explorer в операционных системах Windows. Установив <xref:System.Windows.Forms.Control.ContextMenuStrip%2A> свойство, можно предоставить контекстно-зависимые операции для пользователя при их правой кнопкой мыши <xref:System.Windows.Forms.TreeView> элемента управления. Связав <xref:System.Windows.Forms.ContextMenuStrip> компонента с отдельными <xref:System.Windows.Forms.TreeNode> элементы, можно добавить пользовательский уровень функциональности контекстное меню для вашей <xref:System.Windows.Forms.TreeView> элементов управления.  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-associate-a-shortcut-menu-with-a-treenode-at-design-time"></a>Должен быть сопоставлен элементу управления TreeNode контекстное меню во время разработки  
  
1. Добавить <xref:System.Windows.Forms.TreeView> в форму элемент управления, а затем добавить узлы в <xref:System.Windows.Forms.TreeView> при необходимости. Дополнительные сведения см. в разделе [Как Добавление и удаление узлов с использованием Windows Forms TreeView-элемент управления](how-to-add-and-remove-nodes-with-the-windows-forms-treeview-control.md).  
  
2. Добавление <xref:System.Windows.Forms.ContextMenuStrip> форму, компоненты и затем добавление элементов меню в контекстное меню, соответствующие операциям на уровне узла вы хотите сделать доступными во время выполнения. Дополнительные сведения см. в разделе [Как Добавление элементов меню в элемент управления ContextMenuStrip](how-to-add-menu-items-to-a-contextmenustrip.md).  
  
3. Снова откройте **TreeNodeEditor** диалоговое окно для <xref:System.Windows.Forms.TreeView> управления, выберите узел, чтобы изменить и установите его <xref:System.Windows.Forms.ContextMenuStrip> свойства в контекстном меню, который был добавлен.  
  
4. Если это свойство имеет значение, в контекстном меню отображается при щелчке правой кнопкой узел.  
  
     Кроме того, необходимо написать код для обработки <xref:System.Windows.Forms.ToolStripItem.Click> события для этих пунктов меню.  
  
## <a name="see-also"></a>См. также

- [Элемент управления TreeView](treeview-control-windows-forms.md)
- [Общие сведения об элементе управления TreeView](treeview-control-overview-windows-forms.md)
- [Элемент управления ContextMenuStrip](contextmenustrip-control.md)

---
title: Практическое руководство. Подключение контекстного меню к узлу элемента управления TreeView
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- shortcut menus [Windows Forms], adding to TreeView controls
- TreeView control [Windows Forms], adding shortcut menus
- tree nodes in TreeView control [Windows Forms], shortcut menus
ms.assetid: a23c6752-fd8f-44ad-b781-bab37962fc7c
ms.openlocfilehash: f818cccb3103866af993f1aff527a9c1a7c82109
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59294177"
---
# <a name="how-to-attach-a-shortcut-menu-to-a-treeview-node"></a>Практическое руководство. Подключение контекстного меню к узлу элемента управления TreeView
Windows Forms <xref:System.Windows.Forms.TreeView> элемент управления отображает иерархию узлов аналогично к файлам и папкам, отображаемым в левой части проводника Windows. Установив <xref:System.Windows.Forms.Control.ContextMenuStrip%2A> свойство, можно предоставить контекстно-зависимые операции для пользователя при их правой кнопкой мыши <xref:System.Windows.Forms.TreeView> элемента управления. Связав <xref:System.Windows.Forms.ContextMenuStrip> компонента с отдельными <xref:System.Windows.Forms.TreeNode> элементы, можно добавить пользовательский уровень функциональности контекстное меню для вашей <xref:System.Windows.Forms.TreeView> элементов управления.  
  
### <a name="to-associate-a-shortcut-menu-with-a-treenode-programmatically"></a>Чтобы связать контекстное меню с TreeNode программным способом  
  
1. Создать экземпляр <xref:System.Windows.Forms.TreeView> управления с соответствующими параметрами свойств, создайте корневой <xref:System.Windows.Forms.TreeNode>, а затем добавьте подузлы.  
  
2. Создать экземпляр <xref:System.Windows.Forms.ContextMenuStrip> компонента, а затем добавьте <xref:System.Windows.Forms.ToolStripMenuItem> для каждой операции, которые требуется сделать доступными во время выполнения.  
  
3. Задайте <xref:System.Windows.Forms.TreeNode.ContextMenuStrip%2A> свойства соответствующего <xref:System.Windows.Forms.TreeNode> в контекстное меню создания.  
  
4. Если это свойство имеет значение, в контекстном меню отображается при щелчке правой кнопкой узел.  
  
 В следующем примере кода создает базовое <xref:System.Windows.Forms.TreeView> и <xref:System.Windows.Forms.ContextMenuStrip> связанный с этим корнем <xref:System.Windows.Forms.TreeNode> из <xref:System.Windows.Forms.TreeView>. Вам потребуется подставить пункты меню, которые соответствуют <xref:System.Windows.Forms.TreeView> при разработке. Кроме того, необходимо написать код для обработки <xref:System.Windows.Forms.ToolStripItem.Click> события для этих пунктов меню.  
  
 [!code-cpp[System.Windows.Forms.TreeNodeContextMenuStrip#1](~/samples/snippets/cpp/VS_Snippets_Winforms/system.windows.forms.TreeNodeContextMenuStrip/cpp/Form1.cpp#1)]
 [!code-csharp[System.Windows.Forms.TreeNodeContextMenuStrip#1](~/samples/snippets/csharp/VS_Snippets_Winforms/system.windows.forms.TreeNodeContextMenuStrip/CS/Form1.cs#1)]
 [!code-vb[System.Windows.Forms.TreeNodeContextMenuStrip#1](~/samples/snippets/visualbasic/VS_Snippets_Winforms/system.windows.forms.TreeNodeContextMenuStrip/VB/Form1.vb#1)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ContextMenuStrip>
- [Элемент управления TreeView](treeview-control-windows-forms.md)

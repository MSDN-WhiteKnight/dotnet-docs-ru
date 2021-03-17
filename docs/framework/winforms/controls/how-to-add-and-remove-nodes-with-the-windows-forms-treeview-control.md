---
title: Практическое руководство. Добавление и удаление узлов элемента управления TreeView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- examples [Windows Forms], TreeView control
- TreeView control [Windows Forms], removing nodes
- tree nodes in TreeView control
- TreeView control [Windows Forms], adding nodes
ms.assetid: de1b82db-4905-449a-9f59-af271a6b6673
ms.openlocfilehash: 4cbb5fbdb24790a7ddbce5c38060703c7ba7024a
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59326896"
---
# <a name="how-to-add-and-remove-nodes-with-the-windows-forms-treeview-control"></a>Практическое руководство. Добавление и удаление узлов элемента управления TreeView в Windows Forms
Windows Forms <xref:System.Windows.Forms.TreeView> элемент управления сохраняет узлы верхнего уровня в его <xref:System.Windows.Forms.TreeView.Nodes%2A> коллекции. Каждый <xref:System.Windows.Forms.TreeNode> также имеет свой собственный <xref:System.Windows.Forms.TreeNode.Nodes%2A> коллекцию для хранения дочерних узлов. Оба свойства коллекции имеют тип <xref:System.Windows.Forms.TreeNodeCollection>, который предоставляет стандартные элементы коллекции, которые позволяют добавлять, удалять и изменения порядка узлов на одном уровне иерархии узла.  
  
### <a name="to-add-nodes-programmatically"></a>Чтобы добавить узлы программным способом  
  
1. Используйте <xref:System.Windows.Forms.TreeNodeCollection.Add%2A> метод представления дерева <xref:System.Windows.Forms.TreeView.Nodes%2A> свойство.  
  
    ```vb  
    ' Adds new node as a child node of the currently selected node.  
    Dim newNode As TreeNode = New TreeNode("Text for new node")  
    TreeView1.SelectedNode.Nodes.Add(newNode)  
    ```  
  
    ```csharp  
    // Adds new node as a child node of the currently selected node.  
    TreeNode newNode = new TreeNode("Text for new node");  
    treeView1.SelectedNode.Nodes.Add(newNode);  
    ```  
  
    ```cpp  
    // Adds new node as a child node of the currently selected node.  
    TreeNode ^ newNode = new TreeNode("Text for new node");  
    treeView1->SelectedNode->Nodes->Add(newNode);  
    ```  
  
### <a name="to-remove-nodes-programmatically"></a>Для удаления узлов программным способом  
  
1. Используйте <xref:System.Windows.Forms.TreeNodeCollection.Remove%2A> метод представления дерева <xref:System.Windows.Forms.TreeView.Nodes%2A> свойство, чтобы удалить только один узел, или <xref:System.Windows.Forms.TreeNodeCollection.Clear%2A> метод, чтобы удалить все узлы.  
  
    ```vb  
    ' Removes currently selected node, or root if nothing is selected.  
    TreeView1.Nodes.Remove(TreeView1.SelectedNode)  
    ' Clears all nodes.  
    TreeView1.Nodes.Clear()  
    ```  
  
    ```csharp  
    // Removes currently selected node, or root if nothing   
    // is selected.  
    treeView1.Nodes.Remove(treeView1.SelectedNode);  
    // Clears all nodes.  
    TreeView1.Nodes.Clear();  
    ```  
  
    ```cpp  
    // Removes currently selected node, or root if nothing  
    // is selected.  
    treeView1->Nodes->Remove(treeView1->SelectedNode);  
    // Clears all nodes.  
    treeView1->Nodes->Clear();  
    ```  
  
## <a name="see-also"></a>См. также

- [Элемент управления TreeView](treeview-control-windows-forms.md)
- [Общие сведения об элементе управления TreeView](treeview-control-overview-windows-forms.md)
- [Практическое руководство. Определение значков для элемента управления TreeView в Windows Forms](how-to-set-icons-for-the-windows-forms-treeview-control.md)
- [Практическое руководство. Перебор узлов элемента управления TreeView в Windows Forms](how-to-iterate-through-all-nodes-of-a-windows-forms-treeview-control.md)
- [Практическое руководство. Определение того, какой узел элемента управления TreeView был выбран щелчком мыши](how-to-determine-which-treeview-node-was-clicked-windows-forms.md)
- [Практическое руководство. Добавление пользовательских данных в элемент управления TreeView или ListView (Windows Forms)](add-custom-information-to-a-treeview-or-listview-control-wf.md)

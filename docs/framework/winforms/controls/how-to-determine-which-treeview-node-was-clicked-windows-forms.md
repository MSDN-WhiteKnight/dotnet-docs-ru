---
title: Практическое руководство. Определить, какой узел элемента управления TreeView была нажата (Windows Forms)
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
f1_keywords:
- TreeNode
helpviewer_keywords:
- examples [Windows Forms], TreeView control
- tree nodes in TreeView control [Windows Forms], determining node clicked
- TreeView control [Windows Forms], determining node clicked
ms.assetid: 06a4a191-d918-42af-9f49-956c93eff261
ms.openlocfilehash: 71f13c7b160822c92475d4d03e923b40d4f0454d
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59296736"
---
# <a name="how-to-determine-which-treeview-node-was-clicked-windows-forms"></a>Практическое руководство. Определить, какой узел элемента управления TreeView была нажата (Windows Forms)
При работе с Windows Forms <xref:System.Windows.Forms.TreeView> управления общей задачей является определение узла была нажата и реагировать соответствующим образом.  
  
### <a name="to-determine-which-treeview-node-was-clicked"></a>Чтобы определить, была нажата узла TreeView  
  
1. Используйте <xref:System.EventArgs> объекта, чтобы вернуть ссылку на объект узла, которую щелкнул пользователь.  
  
2. Определить, какой из узлов была нажата, проверив <xref:System.Windows.Forms.TreeViewEventArgs> класс, который содержит данные, относящиеся к событию.  
  
    ```vb  
    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, _  
    ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect  
       ' Determine by checking the Node property of the TreeViewEventArgs.  
       MessageBox.Show(e.Node.Text)  
    End Sub  
    ```  
  
    ```csharp  
    protected void treeView1_AfterSelect (object sender,   
    System.Windows.Forms.TreeViewEventArgs e)  
    {  
       // Determine by checking the Text property.  
       MessageBox.Show(e.Node.Text);  
    }  
    ```  
  
    ```cpp  
    private:  
       void treeView1_AfterSelect(System::Object ^  sender,  
          System::Windows::Forms::TreeViewEventArgs ^  e)  
       {  
          // Determine by checking the Text property.  
          MessageBox::Show(e->Node->Text);  
       }  
    ```  
  
    > [!NOTE]
    >  Кроме того, можно использовать <xref:System.Windows.Forms.MouseEventArgs> из <xref:System.Windows.Forms.Control.MouseDown> или <xref:System.Windows.Forms.Control.MouseUp> событие, чтобы просмотреть <xref:System.Drawing.Point.X%2A> и <xref:System.Drawing.Point.Y%2A> значения из координат <xref:System.Drawing.Point> места выполнения щелчка. Затем с помощью <xref:System.Windows.Forms.TreeView> элемента управления <xref:System.Windows.Forms.TreeView.GetNodeAt%2A> метод, чтобы определить, какой из узлов была нажата.  
  
## <a name="see-also"></a>См. также

- [Элемент управления TreeView](treeview-control-windows-forms.md)

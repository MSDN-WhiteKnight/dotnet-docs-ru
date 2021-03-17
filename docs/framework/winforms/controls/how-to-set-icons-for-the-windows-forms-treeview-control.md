---
title: Практическое руководство. Определение значков для элемента управления TreeView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- examples [Windows Forms], TreeView control
- TreeView control [Windows Forms], node icons
- ImageList component [Windows Forms], adding images
- icons [Windows Forms], setting for TreeView control
- tree nodes in TreeView control [Windows Forms], icons
ms.assetid: c14ddcc0-e5a6-4c21-a2d5-6799fd491781
ms.openlocfilehash: 1a857aade86d2366bb68ce14d716b3ce532ecb05
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59328417"
---
# <a name="how-to-set-icons-for-the-windows-forms-treeview-control"></a>Практическое руководство. Определение значков для элемента управления TreeView в Windows Forms
Windows Forms <xref:System.Windows.Forms.TreeView> элемент управления может отображать значки рядом с каждым узлом. Значки располагаются непосредственно слева от текста узла. Чтобы отобразить эти значки, необходимо связать представлении в виде дерева с <xref:System.Windows.Forms.ImageList> элемента управления. Дополнительные сведения о списках изображений, см. в разделе [компонента ImageList](imagelist-component-windows-forms.md) и [как: Добавление и удаление изображений с помощью Windows Forms компонента ImageList](how-to-add-or-remove-images-with-the-windows-forms-imagelist-component.md).  
  
> [!NOTE]
>  Ошибка в Microsoft .NET Framework версии 1.1 предотвращает появление на образы <xref:System.Windows.Forms.TreeView> узлы, когда приложение вызывает <xref:System.Windows.Forms.Application.EnableVisualStyles%2A?displayProperty=nameWithType>. Чтобы обойти эту ошибку, вызовите <xref:System.Windows.Forms.Application.DoEvents%2A?displayProperty=nameWithType> в вашей `Main` метод сразу после вызова <xref:System.Windows.Forms.Application.EnableVisualStyles%2A>. Эта ошибка исправлена в [!INCLUDE[dnprdnlong](../../../../includes/dnprdnlong-md.md)].  
  
### <a name="to-display-images-in-a-tree-view"></a>Для отображения изображений в виде дерева  
  
1. Задайте <xref:System.Windows.Forms.TreeView> элемента управления <xref:System.Windows.Forms.TreeView.ImageList%2A> к существующему полю <xref:System.Windows.Forms.ImageList> элемента управления, которые вы хотите использовать.  
  
     Эти свойства можно задать в конструкторе с помощью окна «Свойства» или в коде.  
  
    ```vb  
    TreeView1.ImageList = ImageList1  
    ```  
  
    ```csharp  
    treeView1.ImageList = imageList1;  
    ```  
  
    ```cpp  
    treeView1->ImageList = imageList1;  
    ```  
  
2. Узел набора <xref:System.Windows.Forms.TreeNode.ImageIndex%2A> и <xref:System.Windows.Forms.TreeNode.SelectedImageIndex%2A> свойства. <xref:System.Windows.Forms.TreeNode.ImageIndex%2A> Свойство определяет, изображения, отображаемого для обычного и развернутого состояний узла и <xref:System.Windows.Forms.TreeNode.SelectedImageIndex%2A> свойство определяет, изображения, отображаемого для выделенного узла.  
  
     Эти свойства можно задать в коде или в редактор узлов дерева. Чтобы открыть редактор узлов дерева, нажмите кнопку с многоточием ( ![экрана VisualStudioEllipsesButton](../media/vbellipsesbutton.png "vbEllipsesButton")) рядом с полем <xref:System.Windows.Forms.TreeView.Nodes%2A> свойство в окне «Свойства».  
  
    ```vb  
    ' (Assumes that ImageList1 contains at least two images and  
    ' the TreeView control contains a selected image.)  
    TreeView1.SelectedNode.ImageIndex = 0  
    TreeView1.SelectedNode.SelectedImageIndex = 1  
    ```  
  
    ```csharp  
    // (Assumes that imageList1 contains at least two images and  
    // the TreeView control contains a selected image.)  
    treeView1.SelectedNode.ImageIndex = 0;  
    treeView1.SelectedNode.SelectedImageIndex = 1;  
    ```  
  
    ```cpp  
    // (Assumes that imageList1 contains at least two images and  
    // the TreeView control contains a selected image.)  
    treeView1->SelectedNode->ImageIndex = 0;  
    treeView1->SelectedNode->SelectedImageIndex = 1;  
    ```  
  
## <a name="see-also"></a>См. также

- [Общие сведения об элементе управления TreeView](treeview-control-overview-windows-forms.md)
- [Практическое руководство. Добавление и удаление узлов элемента управления TreeView в Windows Forms](how-to-add-and-remove-nodes-with-the-windows-forms-treeview-control.md)
- [Практическое руководство. Перебор узлов элемента управления TreeView в Windows Forms](how-to-iterate-through-all-nodes-of-a-windows-forms-treeview-control.md)
- [Практическое руководство. Определение того, какой узел элемента управления TreeView был выбран щелчком мыши](how-to-determine-which-treeview-node-was-clicked-windows-forms.md)
- [Практическое руководство. Добавление пользовательских данных в элемент управления TreeView или ListView (Windows Forms)](add-custom-information-to-a-treeview-or-listview-control-wf.md)

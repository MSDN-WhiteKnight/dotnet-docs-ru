---
title: Практическое руководство. Добавление пользовательских данных в элемент управления TreeView или ListView (Windows Forms)
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
f1_keywords:
- ListItem
helpviewer_keywords:
- examples [Windows Forms], TreeView control
- examples [Windows Forms], ListView control
- ListView control [Windows Forms], adding custom information
- TreeView control [Windows Forms], adding custom information
ms.assetid: 68be11de-1d5b-430e-901f-cfbe48d14b19
ms.openlocfilehash: 302eb1b88d4e43b4e2bd6395e27a3a6489320085
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59344160"
---
# <a name="how-to-add-custom-information-to-a-treeview-or-listview-control-windows-forms"></a>Практическое руководство. Добавление пользовательских данных в элемент управления TreeView или ListView (Windows Forms)
В Windows Forms можно создать производный узел <xref:System.Windows.Forms.TreeView> управления или производный элемент в <xref:System.Windows.Forms.ListView> элемента управления. Наследование позволяет добавлять любые необходимые поля, а также пользовательские методы и конструкторы для их обработки. Эту возможность можно использовать для присоединения объекта Customer к каждому узлу дерева или элементу списка. Приведенные ниже примеры предназначены для <xref:System.Windows.Forms.TreeView> элемента управления, но тот же подход можно использовать для <xref:System.Windows.Forms.ListView> элемента управления.  
  
### <a name="to-derive-a-tree-node"></a>Наследование узла дерева  
  
-   Создайте новый класс узла, производный от <xref:System.Windows.Forms.TreeNode> класс, который содержит пользовательское поле для записи путь к файлу.  
  
    ```vb  
    Class myTreeNode  
       Inherits TreeNode  
  
       Public FilePath As String  
  
       Sub New(ByVal fp As String)  
          MyBase.New()  
          FilePath = fp  
          Me.Text = fp.Substring(fp.LastIndexOf("\"))  
       End Sub  
    End Class  
    ```  
  
    ```csharp  
    class myTreeNode : TreeNode  
    {  
       public string FilePath;  
  
       public myTreeNode(string fp)  
       {  
          FilePath = fp;  
          this.Text = fp.Substring(fp.LastIndexOf("\\"));  
       }  
    }  
    ```  
  
    ```cpp  
    ref class myTreeNode : public TreeNode  
    {  
    public:  
       System::String ^ FilePath;  
  
       myTreeNode(System::String ^ fp)  
       {  
          FilePath = fp;  
          this->Text = fp->Substring(fp->LastIndexOf("\\"));  
       }  
    };  
    ```  
  
### <a name="to-use-a-derived-tree-node"></a>Использование производного узла дерева  
  
1. Новый производный узел дерева можно использовать в качестве параметра для вызовов функций.  
  
     В следующем примере в качестве расположения текстового файла выбрана папка "Мои документы". Это сделано, поскольку предполагается, что большинство компьютеров, работающих под управлением операционной системы Windows, содержат эту папку. Это также позволяет пользователям с минимальным уровнем доступа к системе безопасно запускать приложение.  
  
    ```vb  
    ' You should replace the bold text file   
    ' in the sample below with a text file of your own choosing.  
    TreeView1.Nodes.Add(New myTreeNode (System.Environment.GetFolderPath _  
       (System.Environment.SpecialFolder.Personal) _  
       & "\ TextFile.txt ") )  
    ```  
  
    ```csharp  
    // You should replace the bold text file   
    // in the sample below with a text file of your own choosing.  
    // Note the escape character used (@) when specifying the path.  
    treeView1.Nodes.Add(new myTreeNode (System.Environment.GetFolderPath _  
       (System.Environment.SpecialFolder.Personal) _  
       + @"\TextFile.txt") );  
    ```  
  
    ```cpp  
    // You should replace the bold text file   
    // in the sample below with a text file of your own choosing.  
    treeView1->Nodes->Add(new myTreeNode(String::Concat(  
       System::Environment::GetFolderPath  
       (System::Environment::SpecialFolder::Personal),  
       "\\TextFile.txt")));  
    ```  
  
2. Если передается узел дерева, и он введен как <xref:System.Windows.Forms.TreeNode> класса, а затем будет необходимо выполнить приведение к своему производному классу. Приведение представляет собой явное преобразование из одного типа объекта в другой. Дополнительные сведения о приведении см. в разделе [явные и неявные преобразования](~/docs/visual-basic/programming-guide/language-features/data-types/implicit-and-explicit-conversions.md) (Visual Basic), [оператор ()](~/docs/csharp/language-reference/operators/invocation-operator.md) (Visual C#), или [оператор Cast: ()](/cpp/cpp/cast-operator-parens) ([!INCLUDE[vcprvc](../../../../includes/vcprvc-md.md)]) .  
  
    ```vb  
    Public Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect  
       Dim mynode As myTreeNode  
       mynode = CType(e.node, myTreeNode)  
       MessageBox.Show("Node selected is " & mynode.filepath)  
    End Sub  
    ```  
  
    ```csharp  
    protected void treeView1_AfterSelect (object sender,  
    System.Windows.Forms.TreeViewEventArgs e)  
    {  
       myTreeNode myNode = (myTreeNode)e.Node;  
       MessageBox.Show("Node selected is " + myNode.FilePath);  
    }  
    ```  
  
    ```cpp  
    private:  
       System::Void treeView1_AfterSelect(System::Object ^  sender,  
          System::Windows::Forms::TreeViewEventArgs ^  e)  
       {  
          myTreeNode ^ myNode = safe_cast<myTreeNode^>(e->Node);  
          MessageBox::Show(String::Concat("Node selected is ",   
             myNode->FilePath));  
       }  
    ```  
  
## <a name="see-also"></a>См. также

- [Элемент управления TreeView](treeview-control-windows-forms.md)
- [Элемент управления ListView](listview-control-windows-forms.md)

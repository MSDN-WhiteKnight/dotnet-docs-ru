---
title: Практическое руководство. Создание пользовательского интерфейса с несколькими областями с помощью Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- SplitContainer control [Windows Forms], examples
- ListView control [Windows Forms], examples
- RichTextBox control [Windows Forms], examples
- Panel control [Windows Forms], examples
- TreeView control [Windows Forms], examples
- Splitter control [Windows Forms], examples
ms.assetid: e79f6bcc-3740-4d1e-b46a-c5594d9b7327
ms.openlocfilehash: 8650ba3b8011e50779080e31d94727609f2d08f1
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59315158"
---
# <a name="how-to-create-a-multipane-user-interface-with-windows-forms"></a>Практическое руководство. Создание пользовательского интерфейса с несколькими областями с помощью Windows Forms
В следующей процедуре вы создадите несколькими областями пользовательский интерфейс, который аналогичен используемому в Microsoft Outlook с **папку** списке **сообщений** области и **предварительнойверсии** области. Это упорядочение достигается главным образом за счет закрепления элементов управления формы.  
  
 При закреплении элемента управления, вы можете определить, какие границы родительского контейнера элемента управления он прикреплен к. Таким образом Если задать <xref:System.Windows.Forms.SplitContainer.Dock%2A> свойства <xref:System.Windows.Forms.DockStyle.Right>, правый край элемента управления закрепляется по правому краю родительского элемента. Кроме того закрепленной края элемента управления изменяется в совпадали с элементом управления контейнера. Дополнительные сведения о том, как <xref:System.Windows.Forms.SplitContainer.Dock%2A> свойство работает, см. [как: Закрепление элементов управления в формах Windows Forms](how-to-dock-controls-on-windows-forms.md).  
  
 Эта процедура предназначена для расположения <xref:System.Windows.Forms.SplitContainer> и другие элементы управления в форме, а не на добавление функциональных возможностей для имитации Microsoft Outlook.  
  
 Чтобы создать этот пользовательский интерфейс, поместите все элементы управления внутри <xref:System.Windows.Forms.SplitContainer> управления, который содержит <xref:System.Windows.Forms.TreeView> элемента управления в левой панели. На правой панели <xref:System.Windows.Forms.SplitContainer> элемент управления содержит второй <xref:System.Windows.Forms.SplitContainer> было управлять с помощью <xref:System.Windows.Forms.ListView> управления выше <xref:System.Windows.Forms.RichTextBox> элемента управления. Эти <xref:System.Windows.Forms.SplitContainer> элементы управления позволяют размер других элементов управления в форме. Вы можете адаптировать способов, описанных в эту процедуру для создания пользовательских интерфейсов, собственным.  
  
### <a name="to-create-an-outlook-style-user-interface-programmatically"></a>Чтобы создать пользовательский интерфейс в стиле Outlook программным способом  
  
1. В форме объявите каждый элемент управления, который состоит из пользовательского интерфейса. В этом примере используйте <xref:System.Windows.Forms.TreeView>, <xref:System.Windows.Forms.ListView>, <xref:System.Windows.Forms.SplitContainer>, и <xref:System.Windows.Forms.RichTextBox> элементы управления для имитации пользовательского интерфейса Microsoft Outlook.  
  
    ```vb  
    Private WithEvents treeView1 As System.Windows.Forms.TreeView  
    Private WithEvents listView1 As System.Windows.Forms.ListView  
    Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox  
    Private WithEvents splitContainer1 As _  
        System.Windows.Forms.SplitContainer  
    Private WithEvents splitContainer2 As _  
        System.Windows.Forms.SplitContainer  
    ```  
  
    ```csharp  
    private System.Windows.Forms.TreeView treeView1;  
    private System.Windows.Forms.ListView listView1;  
    private System.Windows.Forms.RichTextBox richTextBox1;  
    private System.Windows.Forms. SplitContainer splitContainer2;  
    private System.Windows.Forms. SplitContainer splitContainer1;  
    ```  
  
2. Создайте процедуру, которая определяет пользовательский интерфейс. Следующий код задает свойства, чтобы форма будет вид, схожий с Microsoft Outlook. Тем не менее с помощью других элементов управления или закрепления их по-разному, так же просто, для создания других пользовательских интерфейсах, не менее гибкие.  
  
    ```vb  
    Public Sub CreateOutlookUI()  
        ' Create an instance of each control being used.  
        Me.components = New System.ComponentModel.Container()  
        Me.treeView1 = New System.Windows.Forms.TreeView()  
        Me.listView1 = New System.Windows.Forms.ListView()  
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()  
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()  
        Me.splitContainer2= New System.Windows.Forms. SplitContainer()  
  
        ' Should you develop this into a working application,  
        ' use the AddHandler method to hook up event procedures here.  
  
        ' Set properties of TreeView control.  
        ' Use the With statement to avoid repetitive code.  
        With Me.treeView1  
            .Dock = System.Windows.Forms.DockStyle.Fill  
            .TabIndex = 0  
            .Nodes.Add("treeView")  
        End With  
  
    ' Set properties of ListView control.  
       With Me.listView1  
          .Dock = System.Windows.Forms.DockStyle.Top  
          .TabIndex = 2  
          .Items.Add("listView")  
       End With  
  
    ' Set properties of RichTextBox control.  
       With Me.richTextBox1  
          .Dock = System.Windows.Forms.DockStyle.Fill  
          .TabIndex = 3  
          .Text = "richTextBox1"  
       End With  
  
        ' Set properties of the first SplitContainer control.  
        With Me.splitContainer1  
            .Dock = System.Windows.Forms.DockStyle.Fill  
            .TabIndex = 1  
            .SplitterWidth = 4  
            .SplitterDistance = 150  
            .Orientation = Orientation.Horizontal  
            .Panel1.Controls.Add(Me.listView1)  
            .Panel2.Controls.Add(Me.richTextBox1)  
    End With  
  
        ' Set properties of the second SplitContainer control.  
        With Me.splitContainer2  
            .Dock = System.Windows.Forms.DockStyle.Fill  
            .TabIndex = 4  
            .SplitterWidth = 4  
            .SplitterDistance = 100  
            .Panel1.Controls.Add(Me.treeView1)  
            .Panel2.Controls.Add(Me.SplitContainer1)  
    End With  
  
    ' Add the main SplitContainer control to the form.  
        Me.Controls.Add(Me.splitContainer2)  
        Me.Text = "Intricate UI Example"  
    End Sub  
    ```  
  
    ```csharp  
    public void createOutlookUI()  
    {  
        // Create an instance of each control being used.  
        treeView1 = new System.Windows.Forms.TreeView();  
        listView1 = new System.Windows.Forms.ListView();  
        richTextBox1 = new System.Windows.Forms.RichTextBox();  
        splitContainer2 = new System.Windows.Forms.SplitContainer();  
        splitContainer1 = new System.Windows.Forms.SplitContainer();  
  
        // Insert code here to hook up event methods.  
  
        // Set properties of TreeView control.  
        treeView1.Dock = System.Windows.Forms.DockStyle.Fill;  
        treeView1.TabIndex = 0;  
        treeView1.Nodes.Add("treeView");  
  
        // Set properties of ListView control.  
        listView1.Dock = System.Windows.Forms.DockStyle.Top;  
        listView1.TabIndex = 2;  
        listView1.Items.Add("listView");  
  
        // Set properties of RichTextBox control.  
        richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;  
        richTextBox1.TabIndex = 3;  
        richTextBox1.Text = "richTextBox1";  
  
        // Set properties of first SplitContainer control.  
        splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;  
        splitContainer2.TabIndex = 1;  
        splitContainer2.SplitterWidth = 4;  
        splitContainer2.SplitterDistance = 150;  
        splitContainer2.Orientation = Orientation.Horizontal;  
        splitContainer2.Panel1.Controls.Add(this.listView1);  
        splitContainer2.Panel1.Controls.Add(this.richTextBox1);  
  
        // Set properties of second SplitContainer control.  
        splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;  
        splitContainer2.TabIndex = 4;  
        splitContainer2.SplitterWidth = 4;  
        splitContainer2.SplitterDistance = 100;  
        splitContainer2.Panel1.Controls.Add(this.treeView1);  
        splitContainer2.Panel1.Controls.Add(this.splitContainer1);  
  
        // Add the main SplitContainer control to the form.  
        this.Controls.Add(this.splitContainer2);  
        this.Text = "Intricate UI Example";  
    }  
    ```  
  
3. В Visual Basic добавьте вызов процедуры, созданные в `New()` процедуры. В визуальном элементе C#, добавьте следующую строку кода в конструктор для класса формы.  
  
    ```vb  
    ' Add this to the New procedure.  
    CreateOutlookUI()  
    ```  
  
    ```csharp  
    // Add this to the form class's constructor.  
    createOutlookUI();  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.SplitContainer>
- [Элемент управления SplitContainer](splitcontainer-control-windows-forms.md)
- [Практическое руководство. Создание пользовательского интерфейса с несколькими областями с использованием форм Windows Forms с помощью конструктора](create-a-multipane-user-interface-with-wf-using-the-designer.md)

---
title: Практическое руководство. Выбор папки с помощью компонента FolderBrowserDialog в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- directories [Windows Forms], choosing
- FolderBrowserDialog component [Windows Forms], choosing directories
- folders [Windows Forms], selecting
- folders [Windows Forms], choosing
- directories [Windows Forms], selecting
ms.assetid: 4593670e-7c7d-4661-b46b-4ffb63258adb
ms.openlocfilehash: 050af6d10faec3dd09998349dcf96e96ea0f9201
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59306193"
---
# <a name="how-to-choose-folders-with-the-windows-forms-folderbrowserdialog-component"></a>Практическое руководство. Выбор папки с помощью компонента FolderBrowserDialog в Windows Forms
Часто в создаваемых приложениях Windows требуется предлагать пользователю выбрать папку, как правило, для сохранения набора файлов. Windows Forms <xref:System.Windows.Forms.FolderBrowserDialog> компонент позволяет легко решать эту задачу.  
  
### <a name="to-choose-folders-with-the-folderbrowserdialog-component"></a>Выбор папки с помощью компонента FolderBrowserDialog  
  
1. В процедуре проверьте <xref:System.Windows.Forms.FolderBrowserDialog> компонента <xref:System.Windows.Forms.Form.DialogResult%2A> свойство, чтобы просмотреть, как окно было закрыто и получить значение <xref:System.Windows.Forms.FolderBrowserDialog> компонента <xref:System.Windows.Forms.FolderBrowserDialog.SelectedPath%2A> свойство.  
  
2. Если необходимо выполнить набор самый верхний папку, которая будет отображаться в представлении в виде дерева диалогового окна, задайте <xref:System.Windows.Forms.FolderBrowserDialog.RootFolder%2A> свойство, которое принимает член <xref:System.Environment.SpecialFolder> перечисления.  
  
3. Кроме того, можно задать <xref:System.Windows.Forms.FolderBrowserDialog.Description%2A> свойство, которое указывает строку текста, который отображается в верхней части дерева обозревателя папок.  
  
     В следующем примере <xref:System.Windows.Forms.FolderBrowserDialog> компонент используется для выбора папки, аналогичную при создании проекта в Visual Studio и будет предложено выбрать папку для сохранения в ней. В этом примере имя папки затем отображается в <xref:System.Windows.Forms.TextBox> управления на форме. Рекомендуется поместить расположение в редактируемой области, такие как <xref:System.Windows.Forms.TextBox> таким образом, чтобы пользователь мог изменить свой выбор в случае ошибки или других проблем. В этом примере предполагается, что форма <xref:System.Windows.Forms.FolderBrowserDialog> компонента и <xref:System.Windows.Forms.TextBox> элемента управления.  
  
    ```vb  
    Public Sub ChooseFolder()  
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then  
            TextBox1.Text = FolderBrowserDialog1.SelectedPath  
        End If  
    End Sub  
    ```  
  
    ```csharp  
    public void ChooseFolder()  
    {  
        if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)   
        {  
            textBox1.Text = folderBrowserDialog1.SelectedPath;  
        }  
    }  
    ```  
  
    ```cpp  
    public:  
       void ChooseFolder()  
       {  
          if (folderBrowserDialog1->ShowDialog() == DialogResult::OK)  
          {  
             textBox1->Text = folderBrowserDialog1->SelectedPath;  
          }  
       }  
    ```  
  
    > [!IMPORTANT]
    >  Чтобы использовать этот класс, сборке требуется уровень привилегий, предоставленных <xref:System.Security.Permissions.FileIOPermissionAttribute.PathDiscovery%2A> свойство, которое входит в состав из <xref:System.Security.Permissions.FileIOPermissionAccess> перечисления. При выполнении в контексте частичного доверия процесс может выдавать исключение из-за недостаточных привилегий. Дополнительные сведения см. в разделе [Основы управления доступом для кода](../../misc/code-access-security-basics.md).  
  
 Сведения о том, как сохранить файлы, см. в разделе [как: Сохранение файлов с помощью компонента SaveFileDialog](how-to-save-files-using-the-savefiledialog-component.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.FolderBrowserDialog>
- [Общие сведения о компоненте FolderBrowserDialog (Windows Forms)](folderbrowserdialog-component-overview-windows-forms.md)
- [Компонент FolderBrowserDialog](folderbrowserdialog-component-windows-forms.md)

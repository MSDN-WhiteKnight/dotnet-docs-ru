---
title: Практическое руководство. Загрузка файлов в элемент управления RichTextBox в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- text boxes [Windows Forms], displaying files
- examples [Windows Forms], text boxes
- .rtf files [Windows Forms], opening in RichTextBox control
- RTF files [Windows Forms], opening in RichTextBox control
- text files [Windows Forms], displaying in RichTextBox control
- .rtf files [Windows Forms], displaying in RichTextBox control
- RichTextBox control [Windows Forms], opening files
- RTF files [Windows Forms], displaying in RichTextBox control
ms.assetid: c03451be-f285-4428-a71a-c41e002cc919
ms.openlocfilehash: ffbce7401f068b3d0a7fee4fd8ba04c10cb6f6b7
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59340858"
---
# <a name="how-to-load-files-into-the-windows-forms-richtextbox-control"></a>Практическое руководство. Загрузка файлов в элемент управления RichTextBox в Windows Forms
Элемент управления Windows Forms <xref:System.Windows.Forms.RichTextBox> может отображать обычный текст, обычный текст в Юникоде или файл в формате RTF. Для этого вызовите метод <xref:System.Windows.Forms.RichTextBox.LoadFile%2A> . Метод <xref:System.Windows.Forms.RichTextBox.LoadFile%2A> можно также использовать для загрузки данных из потока. Для получения дополнительной информации см. <xref:System.Windows.Forms.RichTextBox.LoadFile%28System.IO.Stream%2CSystem.Windows.Forms.RichTextBoxStreamType%29>.  
  
### <a name="to-load-a-file-into-the-richtextbox-control"></a>Загрузка файла в элемент управления RichTextBox  
  
1. Определить путь к открываемому файлу с помощью компонента <xref:System.Windows.Forms.OpenFileDialog> . Дополнительные сведения см. в разделе [Общие сведения о компоненте OpenFileDialog](openfiledialog-component-overview-windows-forms.md).  
  
2. Вызовите метод <xref:System.Windows.Forms.RichTextBox.LoadFile%2A> элемента управления <xref:System.Windows.Forms.RichTextBox> , указав загружаемый файл и при необходимости тип файла. В следующем примере загружаемый файл берется из свойства <xref:System.Windows.Forms.OpenFileDialog> компонента <xref:System.Windows.Forms.FileDialog.FileName%2A> . Если вы вызываете метод с именем файла в качестве единственного аргумента, предполагается, что тип файла должен быть RTF. Чтобы указать другой тип файла, вызовите метод со значением перечисления <xref:System.Windows.Forms.RichTextBoxStreamType> в качестве второго аргумента.  
  
     В следующем примере компонент <xref:System.Windows.Forms.OpenFileDialog> отображается при нажатии кнопки. Выбранный файл открывается и отображается в элементе управления <xref:System.Windows.Forms.RichTextBox> . В этом примере предполагается, что форма содержит кнопку`btnOpenFile`.  
  
    ```vb  
    Private Sub btnOpenFile_Click(ByVal sender As System.Object, _  
       ByVal e As System.EventArgs) Handles btnOpenFile.Click  
         If OpenFileDialog1.ShowDialog() = DialogResult.OK Then  
           RichTextBox1.LoadFile(OpenFileDialog1.FileName, _  
              RichTextBoxStreamType.RichText)  
          End If  
    End Sub  
    ```  
  
    ```csharp  
    private void btnOpenFile_Click(object sender, System.EventArgs e)  
    {  
       if(openFileDialog1.ShowDialog() == DialogResult.OK)  
       {  
         richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);  
       }  
    }  
    ```  
  
    ```cpp  
    private:  
       void btnOpenFile_Click(System::Object ^  sender,  
          System::EventArgs ^  e)  
       {  
          if(openFileDialog1->ShowDialog() == DialogResult::OK)  
          {  
             richTextBox1->LoadFile(openFileDialog1->FileName,  
                RichTextBoxStreamType::RichText);  
          }  
       }  
    ```  
  
     (Visual C# [!INCLUDE[vcprvc](../../../../includes/vcprvc-md.md)]) поместите следующий код в конструктор формы для регистрации обработчика событий.  
  
    ```csharp  
    this.btnOpenFile.Click += new System.EventHandler(this. btnOpenFile_Click);  
    ```  
  
    ```cpp  
    this->btnOpenFile->Click += gcnew   
       System::EventHandler(this, &Form1::btnOpenFile_Click);  
    ```  
  
    > [!IMPORTANT]
    >  Для запуска этого процесса сборке может потребоваться уровень привилегий, предоставляемый классом <xref:System.Security.Permissions.FileIOPermission?displayProperty=nameWithType> . При выполнении в контексте частичного доверия процесс может выдавать исключение из-за недостаточных привилегий. Дополнительные сведения см. в разделе [Основы управления доступом для кода](../../misc/code-access-security-basics.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.RichTextBox.LoadFile%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.RichTextBox>
- [Элемент управления RichTextBox](richtextbox-control-windows-forms.md)
- [Элементы управления для использования в формах Windows Forms](controls-to-use-on-windows-forms.md)

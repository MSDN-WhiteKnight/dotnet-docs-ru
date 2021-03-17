---
title: Практическое руководство. Сохранение файлов с помощью элемента управления RichTextBox в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- saving files
- RTF files [Windows Forms], saving in RichTextBox control
- examples [Windows Forms], text boxes
- saving files [Windows Forms], RichTextBox control
- files [Windows Forms], saving with RichTextBox control
- RichTextBox control [Windows Forms], saving files
- .rtf files [Windows Forms], saving in RichTextBox control
- text files [Windows Forms], saving from RichTextBox control
ms.assetid: 4a58ec19-84d1-4383-9110-298c06adcfca
ms.openlocfilehash: 4784ddd563ccec0f7e6271700781ee1b5d3ac105
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59318420"
---
# <a name="how-to-save-files-with-the-windows-forms-richtextbox-control"></a>Практическое руководство. Сохранение файлов с помощью элемента управления RichTextBox в Windows Forms
Windows Forms <xref:System.Windows.Forms.RichTextBox> управления может записывать сведения, которые отображаются в одном из следующих форматов:  
  
-   Обычный текст  
  
-   Текст в Юникоде  
  
-   Rich Text Format (RTF)  
  
-   Формат RTF с пробелами вместо объектов OLE  
  
-   Обычный текст с текстовым представлением объектов OLE  
  
 Чтобы сохранить файл, вызовите <xref:System.Windows.Forms.RichTextBox.SaveFile%2A> метод. Можно также использовать **SaveFile** метод для сохранения данных в поток. Дополнительные сведения см. в разделе <xref:System.Windows.Forms.RichTextBox.SaveFile%28System.IO.Stream%2CSystem.Windows.Forms.RichTextBoxStreamType%29>.  
  
### <a name="to-save-the-contents-of-the-control-to-a-file"></a>Чтобы сохранить содержимое элемента управления в файл  
  
1. Определите путь к файлу должен быть сохранен.  
  
     Для этого в реальном приложении обычно используется <xref:System.Windows.Forms.SaveFileDialog> компонента. Дополнительные сведения см. в разделе [Общие сведения о компоненте SaveFileDialog](savefiledialog-component-overview-windows-forms.md).  
  
2. Вызовите <xref:System.Windows.Forms.RichTextBox.SaveFile%2A> метод <xref:System.Windows.Forms.RichTextBox> управления, указав имя файла для сохранения и при необходимости тип файла. Если вызвать метод с именем файла в качестве единственного аргумента, файл будет сохранен как RTF. Чтобы указать другой тип файла, вызовите метод со значением перечисления <xref:System.Windows.Forms.RichTextBoxStreamType> в качестве второго аргумента.  
  
     В приведенном ниже примере путь задан для — расположение файла RTF- **Мои документы** папки. Это расположение используется в том случае, так как можно предположить, что большинство компьютеров под управлением ОС Windows будет включать эту папку. Эта папка также пользователи со систему с минимальным уровнем доступа могут безопасно запускать приложение. В приведенном ниже примере предполагается, что форма <xref:System.Windows.Forms.RichTextBox> управления уже добавлен.  
  
    ```vb  
    Public Sub SaveFile()  
       ' You should replace the bold file name in the   
       ' sample below with a file name of your own choosing.  
       RichTextBox1.SaveFile(System.Environment.GetFolderPath _  
       (System.Environment.SpecialFolder.Personal) _  
       & "\Testdoc.rtf", _  
          RichTextBoxStreamType.RichNoOleObjs)  
    End Sub  
    ```  
  
    ```csharp  
    public void SaveFile()  
    {  
       // You should replace the bold file name in the   
       // sample below with a file name of your own choosing.  
       // Note the escape character used (@) when specifying the path.  
       richTextBox1.SaveFile(System.Environment.GetFolderPath  
       (System.Environment.SpecialFolder.Personal)  
       + @"\Testdoc.rtf",  
          RichTextBoxStreamType.RichNoOleObjs);  
    }  
    ```  
  
    ```cpp  
    public:  
       void SaveFile()  
       {  
          // You should replace the bold file name in the   
          // sample below with a file name of your own choosing.  
          richTextBox1->SaveFile(String::Concat  
             (System::Environment::GetFolderPath  
             (System::Environment::SpecialFolder::Personal),  
             "\\Testdoc.rtf"), RichTextBoxStreamType::RichNoOleObjs);  
       }  
    ```  
  
    > [!IMPORTANT]
    >  В этом примере создается файл (если файл отсутствует). Если приложению требуется для создания файла, что ему необходимо иметь доступ для папки. Для задания разрешений используются списки управления доступом. Если файл уже существует, приложению требуется только доступ на запись, более низким уровнем. Где это возможно, безопаснее создать файл во время развертывания и только предоставить доступ на чтение к одному файлу, чем на доступ к папке. По тем же соображениям рекомендуется записывать данные в пользовательские папки, а не в коревую папку или папку Program Files.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.RichTextBox.SaveFile%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.RichTextBox>
- [Элемент управления RichTextBox](richtextbox-control-windows-forms.md)
- [Элементы управления для использования в формах Windows Forms](controls-to-use-on-windows-forms.md)

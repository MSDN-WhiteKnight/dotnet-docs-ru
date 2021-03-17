---
title: Практическое руководство. Установка изображений во время выполнения (Windows Forms)
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- pictures [Windows Forms], setting display
- examples [Windows Forms], PictureBox control
- bitmaps [Windows Forms], displaying in PictureBox control [Windows Forms]
- PictureBox control [Windows Forms], adding images
- images [Windows Forms], adding with PictureBox control [Windows Forms]
- PictureBox control [Windows Forms], adding pictures
ms.assetid: 18ca41d0-68a5-4660-985e-a6c1fbc01d76
ms.openlocfilehash: 8ed3ba9050a9117a53b5f4f1cccd26381f55ab32
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59073602"
---
# <a name="how-to-set-pictures-at-run-time-windows-forms"></a>Практическое руководство. Установка изображений во время выполнения (Windows Forms)
Можно программно установить изображения, отображаемого в формах Windows <xref:System.Windows.Forms.PictureBox> элемента управления.  
  
### <a name="to-set-a-picture-programmatically"></a>Задание рисунка программным образом  
  
-   Задайте <xref:System.Windows.Forms.PictureBox.Image%2A> свойства с помощью <xref:System.Drawing.Image.FromFile%2A> метод <xref:System.Drawing.Image> класса.  
  
     В следующем примере в расположение образа выбрана папка «Мои документы». Это делается, поскольку предполагается, что большинство компьютеров под управлением операционной системы Windows, содержат эту папку. Это также позволяет пользователям с минимальным уровнем доступа к системе безопасно запускать приложение. В приведенном ниже примере предполагается, что форма <xref:System.Windows.Forms.PictureBox> управления уже добавлен.  
  
    ```vb  
    Private Sub LoadNewPict()  
       ' You should replace the bold image   
       ' in the sample below with an icon of your own choosing.  
       PictureBox1.Image = Image.FromFile _  
       (System.Environment.GetFolderPath _  
       (System.Environment.SpecialFolder.Personal) _  
       & "\Image.gif")  
    End Sub  
    ```  
  
    ```csharp  
    private void LoadNewPict(){  
       // You should replace the bold image   
       // in the sample below with an icon of your own choosing.  
       // Note the escape character used (@) when specifying the path.  
       pictureBox1.Image = Image.FromFile  
       (System.Environment.GetFolderPath  
       (System.Environment.SpecialFolder.Personal)  
       + @"\Image.gif");  
    }  
    ```  
  
    ```cpp  
    private:  
       void LoadNewPict()  
       {  
          // You should replace the bold image   
          // in the sample below with an icon of your own choosing.  
          pictureBox1->Image = Image::FromFile(String::Concat(  
             System::Environment::GetFolderPath(  
             System::Environment::SpecialFolder::Personal),  
             "\\Image.gif"));  
       }  
    ```  
  
### <a name="to-clear-a-graphic"></a>Чтобы очистить рисунок  
  
-   Во-первых освободить память, используется образ, а затем снимите его. Сборка мусора, чтобы освободить занятую память позже Если управление памятью становится проблемой.  
  
    ```vb  
    If Not (PictureBox1.Image Is Nothing) Then  
       PictureBox1.Image.Dispose()  
       PictureBox1.Image = Nothing  
    End If  
    ```  
  
    ```csharp  
    if (pictureBox1.Image != null)   
    {  
       pictureBox1.Image.Dispose();  
       pictureBox1.Image = null;  
    }  
    ```  
  
    ```cpp  
    if (pictureBox1->Image != nullptr)  
    {  
       pictureBox1->Image->Dispose();  
       pictureBox1->Image = nullptr;  
    }  
    ```  
  
    > [!NOTE]
    >  Дополнительные сведения о том, почему следует использовать <xref:System.Drawing.Image.Dispose%2A> метод таким образом, см. в разделе [очистки неуправляемых ресурсов](../../../standard/garbage-collection/unmanaged.md).  
  
     Этот код удалит изображение, даже если рисунок был загружен в элемент управления во время разработки.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.PictureBox>
- <xref:System.Drawing.Image.FromFile%2A?displayProperty=nameWithType>
- [Общие сведения об элементе управления PictureBox](picturebox-control-overview-windows-forms.md)
- [Практическое руководство. Загрузка изображения с помощью конструктора](how-to-load-a-picture-using-the-designer-windows-forms.md)
- [Практическое руководство. Изменение размера или размещения изображения во время выполнения](how-to-modify-the-size-or-placement-of-a-picture-at-run-time-windows-forms.md)
- [Элемент управления PictureBox](picturebox-control-windows-forms.md)

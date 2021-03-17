---
title: Практическое руководство. Отображение ссылок веб-типа с помощью элемента управления RichTextBox в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- text boxes [Windows Forms], displaying Web links
- examples [Windows Forms], text boxes
- RichTextBox control [Windows Forms], linking to Web pages
ms.assetid: 95089a37-a202-4f7a-94ee-6ee312908851
ms.openlocfilehash: faaa48051c80b6dfd330f15f72a38297ff2d1b9f
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59301884"
---
# <a name="how-to-display-web-style-links-with-the-windows-forms-richtextbox-control"></a>Практическое руководство. Отображение ссылок веб-типа с помощью элемента управления RichTextBox в Windows Forms
Windows Forms <xref:System.Windows.Forms.RichTextBox> веб-ссылок может отображать элемент управления цветом и подчеркиванием. Можно написать код, который открывает окно браузера, веб-узлом, указанный в тексте ссылки, при щелчке ссылки.  
  
### <a name="to-link-to-a-web-page-with-the-richtextbox-control"></a>Чтобы связать веб-страницу с элементом управления RichTextBox  
  
1. Задайте <xref:System.Windows.Forms.RichTextBox.Text%2A> свойство на строку, которая содержит допустимый URL-адрес (например, "http://www.microsoft.com/«).  
  
2. Убедитесь, что <xref:System.Windows.Forms.RichTextBox.DetectUrls%2A> свойству `true` (по умолчанию).  
  
3. Создать новый глобальный экземпляр <xref:System.Diagnostics.Process> объекта.  
  
4. Написать обработчик событий для <xref:System.Windows.Forms.RichTextBox.LinkClicked> событий, который отправляет браузер требуемый текст.  
  
     В следующем примере <xref:System.Windows.Forms.RichTextBox.LinkClicked> событий открывает экземпляр Internet Explorer на URL-адрес, указанный в <xref:System.Windows.Forms.RichTextBox.Text%2A> свойство <xref:System.Windows.Forms.RichTextBox> элемента управления. В этом примере предполагается, что форма <xref:System.Windows.Forms.RichTextBox> элемента управления.  
  
    > [!IMPORTANT]
    >  В вызывающем <xref:System.Diagnostics.Process.Start%2A?displayProperty=nameWithType> метод, вы столкнетесь <xref:System.Security.SecurityException> исключение, если код выполняется в контексте частичного доверия из-за недостатка прав. Дополнительные сведения см. в разделе [Основы управления доступом для кода](../../misc/code-access-security-basics.md).  
  
    ```vb  
    Public p As New System.Diagnostics.Process  
    Private Sub RichTextBox1_LinkClicked _  
       (ByVal sender As Object, ByVal e As _  
       System.Windows.Forms.LinkClickedEventArgs) _  
       Handles RichTextBox1.LinkClicked  
          ' Call Process.Start method to open a browser  
          ' with link text as URL.  
          p = System.Diagnostics.Process.Start("IExplore.exe", e.LinkText)  
    End Sub  
    ```  
  
    ```csharp  
    public System.Diagnostics.Process p = new System.Diagnostics.Process();  
  
    private void richTextBox1_LinkClicked(object sender,   
    System.Windows.Forms.LinkClickedEventArgs e)  
    {  
       // Call Process.Start method to open a browser  
       // with link text as URL.  
       p = System.Diagnostics.Process.Start("IExplore.exe", e.LinkText);  
    }  
    ```  
  
    ```cpp  
    public:  
       System::Diagnostics::Process ^ p;  
  
    private:  
       void richTextBox1_LinkClicked(System::Object ^  sender,  
          System::Windows::Forms::LinkClickedEventArgs ^  e)  
       {  
          // Call Process.Start method to open a browser  
          // with link text as URL.  
          p = System::Diagnostics::Process::Start("IExplore.exe",  
             e->LinkText);  
       }  
    ```  
  
     ([!INCLUDE[vcprvc](../../../../includes/vcprvc-md.md)]) Необходимо инициализировать процесс `p`, что можно сделать, включив в конструктор формы следующую инструкцию:  
  
    ```cpp  
    p = gcnew System::Diagnostics::Process();  
    ```  
  
     (Visual C# [!INCLUDE[vcprvc](../../../../includes/vcprvc-md.md)]) поместите следующий код в конструктор формы для регистрации обработчика событий.  
  
    ```csharp  
    this.richTextBox1.LinkClicked += new   
       System.Windows.Forms.LinkClickedEventHandler  
       (this.richTextBox1_LinkClicked);  
    ```  
  
    ```cpp  
    this->richTextBox1->LinkClicked += gcnew  
       System::Windows::Forms::LinkClickedEventHandler  
       (this, &Form1::richTextBox1_LinkClicked);  
    ```  
  
     Важно, чтобы немедленно остановить процесс, который вы создали после завершения работы с ним. Ссылка на код, представленный выше, код, чтобы остановить процесс может выглядеть следующим образом:  
  
    ```vb  
    Public Sub StopWebProcess()  
       p.Kill()  
    End Sub  
    ```  
  
    ```csharp  
    public void StopWebProcess()  
    {  
       p.Kill();  
    }  
    ```  
  
    ```cpp  
    public: void StopWebProcess()  
    {  
       p->Kill();  
    }  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.RichTextBox.DetectUrls%2A>
- <xref:System.Windows.Forms.RichTextBox.LinkClicked>
- <xref:System.Windows.Forms.RichTextBox>
- [Элемент управления RichTextBox](richtextbox-control-windows-forms.md)
- [Элементы управления для использования в формах Windows Forms](controls-to-use-on-windows-forms.md)

---
title: Практическое руководство. Предварительный просмотр при печати в приложениях Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- print preview [Windows Forms], displaying
- printing [Windows Forms], print preview
- examples [Windows Forms], print preview
ms.assetid: e394134c-0886-4517-bd8d-edc4a3749eb5
ms.openlocfilehash: 22247c941eff575f0f3e5683e46376054ba13bb5
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59154366"
---
# <a name="how-to-display-print-preview-in-windows-forms-applications"></a>Практическое руководство. Предварительный просмотр при печати в приложениях Windows Forms
Можно использовать <xref:System.Windows.Forms.PrintPreviewDialog> элемента управления, чтобы пользователи могли отображение документа, часто, прежде чем он станет для печати.  
  
 Чтобы сделать это, необходимо указать экземпляр <xref:System.Drawing.Printing.PrintDocument> класса; это документа на печать. Дополнительные сведения об использовании предварительного просмотра с <xref:System.Drawing.Printing.PrintDocument> компонента, см. в разделе [как: В Windows Forms с использованием предварительного просмотра печати](../advanced/how-to-print-in-windows-forms-using-print-preview.md).  
  
> [!NOTE]
>  Чтобы использовать <xref:System.Windows.Forms.PrintPreviewDialog> элемента управления во время выполнения, пользователи должны иметь установленный на компьютере, локально или через сеть, принтер, как это отчасти как <xref:System.Windows.Forms.PrintPreviewDialog> компонент определяет, как будет выглядеть при печати документа.  
  
 <xref:System.Windows.Forms.PrintPreviewDialog> Управления использует <xref:System.Drawing.Printing.PrinterSettings> класса. Кроме того <xref:System.Windows.Forms.PrintPreviewDialog> управления использует <xref:System.Drawing.Printing.PageSettings> класса, так же, как <xref:System.Windows.Forms.PrintPreviewDialog> компонент. Печать документа, указанного в <xref:System.Windows.Forms.PrintPreviewDialog> элемента управления <xref:System.Windows.Forms.PrintPreviewControl.Document%2A> свойство ссылается на обоих экземпляров <xref:System.Drawing.Printing.PrinterSettings> и <xref:System.Drawing.Printing.PageSettings> классы, которые используются для отображения документа в окне предварительного просмотра.  
  
### <a name="to-view-pages-using-the-printpreviewdialog-control"></a>Для просмотра страниц, используя элемент управления PrintPreviewDialog  
  
-   Используйте метод <xref:System.Windows.Forms.CommonDialog.ShowDialog%2A> для отображения диалогового окна, указав используемый <xref:System.Drawing.Printing.PrintDocument> .  
  
     В следующем примере кода <xref:System.Windows.Forms.Button> элемента управления <xref:System.Windows.Forms.Control.Click> обработчик событий открывает экземпляр <xref:System.Windows.Forms.PrintPreviewDialog> элемента управления. Печать документа указывается в <xref:System.Windows.Forms.PrintDialog.Document%2A> свойство. В следующем примере указывается не печать документа.  
  
     В этом примере предполагается, что форма содержит <xref:System.Windows.Forms.Button> управления <xref:System.Drawing.Printing.PrintDocument> компонент с именем `myDocument`и <xref:System.Windows.Forms.PrintPreviewDialog> элемента управления.  
  
    ```vb  
    Private Sub Button1_Click(ByVal sender As System.Object, _  
       ByVal e As System.EventArgs) Handles Button1.Click  
       ' The print document 'myDocument' used below  
       ' is merely for an example.  
       ' You will have to specify your own print document.  
       PrintPreviewDialog1.Document = myDocument  
       PrintPreviewDialog1.ShowDialog()  
    End Sub  
    ```  
  
    ```csharp  
    private void button1_Click(object sender, System.EventArgs e)  
    {  
       // The print document 'myDocument' used below  
       // is merely for an example.  
       // You will have to specify your own print document.  
       printPreviewDialog1.Document = myDocument;  
       printPreviewDialog1.ShowDialog();  
    }  
    ```  
  
    ```cpp  
    private:  
       void button1_Click(System::Object ^ sender,  
          System::EventArgs ^ e)  
       {  
          // The print document 'myDocument' used below  
          // is merely for an example.  
          // You will have to specify your own print document.  
          printPreviewDialog1->Document = myDocument;  
          printPreviewDialog1->ShowDialog();  
       }  
    ```  
  
     (Visual C# [!INCLUDE[vcprvc](../../../../includes/vcprvc-md.md)]) поместите следующий код в конструктор формы для регистрации обработчика событий.  
  
    ```csharp  
    this.button1.Click += new System.EventHandler(this.button1_Click);  
    ```  
  
    ```cpp  
    this->button1->Click += gcnew  
       System::EventHandler(this, &Form1::button1_Click);  
    ```  
  
## <a name="see-also"></a>См. также

- [Компонент PrintDocument](printdocument-component-windows-forms.md)
- [Элемент управления PrintPreviewDialog](printpreviewdialog-control-windows-forms.md)
- [Поддержка печати в Windows Forms](../advanced/windows-forms-print-support.md)
- [Windows Forms](../index.md)

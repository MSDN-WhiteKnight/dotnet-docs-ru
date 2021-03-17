---
title: Практическое руководство. Определение свойств страницы с помощью компонента PageSetupDialog
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- page properties
- page setup
- PageSetupDialog component
ms.assetid: 6dae05bc-c0fd-4357-bb93-841a1631d98f
ms.openlocfilehash: 7c65eb54bb95b9a20cd1e43f0d491af47985f2e0
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59329210"
---
# <a name="how-to-determine-page-properties-using-the-pagesetupdialog-component"></a>Практическое руководство. Определение свойств страницы с помощью компонента PageSetupDialog
Компонент [PageSetupDialog](pagesetupdialog-component-windows-forms.md) предоставляет пользователю макет, размер бумаги и другие параметры разметки страницы для документа.  
  
 Необходимо указать экземпляр класса <xref:System.Drawing.Printing.PrintDocument> — это распечатываемый документ. Кроме того, на компьютере пользователя должен быть установлен локальный или сетевой принтер, поскольку компонент <xref:System.Windows.Forms.PageSetupDialog> использует эти сведения, чтобы определить параметры форматирования страницы, предоставляемые пользователю.  
  
 Важный аспект работы с компонентом <xref:System.Windows.Forms.PageSetupDialog> заключается в способе его взаимодействия с классом <xref:System.Drawing.Printing.PageSettings> . Класс <xref:System.Drawing.Printing.PageSettings> используется для указания параметров, которые влияют на способ печати страницы, например ориентации, размера страницы и полей. Каждый из этих параметров представлен в виде свойства класса <xref:System.Drawing.Printing.PageSettings> . Класс <xref:System.Windows.Forms.PageSetupDialog> изменяет значения этих свойств для заданного экземпляра класса <xref:System.Drawing.Printing.PageSettings> , который связан с документом (и представлен в виде свойства <xref:System.Drawing.Printing.PrintDocument.DefaultPageSettings%2A> ).  
  
### <a name="to-set-page-properties-using-the-pagesetupdialog-component"></a>Задание свойств страницы с помощью компонента PageSetupDialog  
  
1. Используйте метод <xref:System.Windows.Forms.CommonDialog.ShowDialog%2A> для отображения диалогового окна, указав используемый <xref:System.Drawing.Printing.PrintDocument> .  
  
     В следующем примере обработчик событий <xref:System.Windows.Forms.Button> элемента управления <xref:System.Windows.Forms.Control.Click> открывает экземпляр компонента <xref:System.Windows.Forms.PageSetupDialog> . Существующий документ указывается в свойстве <xref:System.Windows.Forms.PageSetupDialog.Document%2A> , а его свойство <xref:System.Drawing.Printing.PageSettings.Color%2A?displayProperty=nameWithType> имеет значение `false`.  
  
     В примере предполагается, в форме есть <xref:System.Windows.Forms.Button> управления <xref:System.Drawing.Printing.PrintDocument> компонент с именем `myDocument`и <xref:System.Windows.Forms.PageSetupDialog> компонента.  
  
    ```vb  
    Private Sub Button1_Click(ByVal sender As System.Object, _  
    ByVal e As System.EventArgs) Handles Button1.Click  
       ' The print document 'myDocument' used below  
       ' is merely for an example.  
       'You will have to specify your own print document.  
       PageSetupDialog1.Document = myDocument  
       ' Sets the print document's color setting to false,  
       ' so that the page will not be printed in color.  
       PageSetupDialog1.Document.DefaultPageSettings.Color = False  
       PageSetupDialog1.ShowDialog()  
    End Sub  
    ```  
  
    ```csharp  
    private void button1_Click(object sender, System.EventArgs e)  
    {  
       // The print document 'myDocument' used below  
       // is merely for an example.  
       // You will have to specify your own print document.  
       pageSetupDialog1.Document = myDocument;  
       // Sets the print document's color setting to false,  
       // so that the page will not be printed in color.  
       pageSetupDialog1.Document.DefaultPageSettings.Color = false;  
       pageSetupDialog1.ShowDialog();  
    }  
    ```  
  
    ```cpp  
    private:  
       System::Void button1_Click(System::Object ^  sender,  
          System::EventArgs ^  e)  
       {  
          // The print document 'myDocument' used below  
          // is merely for an example.  
          // You will have to specify your own print document.  
          pageSetupDialog1->Document = myDocument;  
          // Sets the print document's color setting to false,  
          // so that the page will not be printed in color.  
          pageSetupDialog1->Document->DefaultPageSettings->Color = false;  
          pageSetupDialog1->ShowDialog();  
       }  
    ```  
  
     (Visual C# и [!INCLUDE[vcprvc](../../../../includes/vcprvc-md.md)]) поместите следующий код в конструктор формы для регистрации обработчика событий.  
  
    ```csharp  
    this.button1.Click += new System.EventHandler(this.button1_Click);  
    ```  
  
    ```cpp  
    this->button1->Click += gcnew   
       System::EventHandler(this, &Form1::button1_Click);  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.PageSetupDialog>
- [Практическое руководство. Создание стандартных задания печати в Windows Forms](../advanced/how-to-create-standard-windows-forms-print-jobs.md)
- [Компонент PageSetupDialog](pagesetupdialog-component-windows-forms.md)

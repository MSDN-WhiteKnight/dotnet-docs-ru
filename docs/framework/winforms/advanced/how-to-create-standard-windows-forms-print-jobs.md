---
title: Практическое руководство. Создание стандартных задания печати в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- printing [Windows Forms]
- printing [Windows Forms], creating print jobs
- printing [Visual Basic], in Windows applications
ms.assetid: 03342b90-9cfe-40b2-838b-b479a13c5dea
ms.openlocfilehash: 816da93218e20f73f16c14769ed1a549dd3d8eb3
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59335411"
---
# <a name="how-to-create-standard-windows-forms-print-jobs"></a>Практическое руководство. Создание стандартных задания печати в Windows Forms
Печать в Windows Forms лежит <xref:System.Drawing.Printing.PrintDocument> компонент — в частности, <xref:System.Drawing.Printing.PrintDocument.PrintPage> событий. Путем написания кода для обработки <xref:System.Drawing.Printing.PrintDocument.PrintPage> событий, можно указать, что нужно вывести и способ печати.  
  
### <a name="to-create-a-print-job"></a>Чтобы создать задание на печать  
  
1. Добавление <xref:System.Drawing.Printing.PrintDocument> форму компонента.  
  
2. Напишите код для обработки события <xref:System.Drawing.Printing.PrintDocument.PrintPage> .  
  
     Как будет нужно код логики печати. Кроме того необходимо указать материала для печати.  
  
     В следующем примере кода создается образец рисунка в форму красного прямоугольника в <xref:System.Drawing.Printing.PrintDocument.PrintPage> обработчик событий в качестве материала для печати.  
  
    ```vb  
    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage  
       e.Graphics.FillRectangle(Brushes.Red, New Rectangle(500, 500, 500, 500))  
    End Sub  
    ```  
  
    ```csharp  
    private void printDocument1_PrintPage(object sender,   
    System.Drawing.Printing.PrintPageEventArgs e)  
    {  
       e.Graphics.FillRectangle(Brushes.Red,   
         new Rectangle(500, 500, 500, 500));  
    }  
    ```  
  
    ```cpp  
    private:  
       void printDocument1_PrintPage(System::Object ^ sender,  
          System::Drawing::Printing::PrintPageEventArgs ^ e)  
       {  
          e->Graphics->FillRectangle(Brushes::Red,  
             Rectangle(500, 500, 500, 500));  
       }  
    ```  
  
     (Visual C# и [!INCLUDE[vcprvc](../../../../includes/vcprvc-md.md)]) поместите следующий код в конструктор формы для регистрации обработчика событий.  
  
    ```csharp  
    this.printDocument1.PrintPage += new  
       System.Drawing.Printing.PrintPageEventHandler  
       (this.printDocument1_PrintPage);  
    ```  
  
    ```cpp  
    printDocument1->PrintPage += gcnew  
       System::Drawing::Printing::PrintPageEventHandler  
       (this, &Form1::printDocument1_PrintPage);  
    ```  
  
     Можно также написать код для <xref:System.Drawing.Printing.PrintDocument.BeginPrint> и <xref:System.Drawing.Printing.PrintDocument.EndPrint> события, например, целое число, представляющее общее число страниц для печати, уменьшается на единицу при печати каждой страницы.  
  
    > [!NOTE]
    >  Вы можете добавить <xref:System.Windows.Forms.PrintDialog> форму для обеспечения простого и эффективного пользовательского интерфейса (UI) для пользователей компонента. Установка <xref:System.Windows.Forms.PrintDialog.Document%2A> свойство <xref:System.Windows.Forms.PrintDialog> включает компонент, можно задать свойства, относящиеся к печати документа при работе с в форму. Дополнительные сведения о <xref:System.Windows.Forms.PrintDialog> компонента, см. в разделе [компонент PrintDialog](../controls/printdialog-component-windows-forms.md).  
  
     Дополнительные сведения об особенностях Windows Forms задания печати, включая создание задание на печать программным способом, см. в разделе <xref:System.Drawing.Printing.PrintPageEventArgs>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Printing.PrintDocument>
- [Поддержка печати в Windows Forms](windows-forms-print-support.md)

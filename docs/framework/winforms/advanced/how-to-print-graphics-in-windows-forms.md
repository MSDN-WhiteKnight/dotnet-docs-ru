---
title: Практическое руководство. Печать графических изображений в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- graphics [Windows Forms], printing
- printing [Windows Forms], graphics
ms.assetid: 32b891e6-52ff-4fea-a9ff-2ce5db20a4c6
ms.openlocfilehash: 55459482d0994c581164128b17c08a7ca90d0717
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59339103"
---
# <a name="how-to-print-graphics-in-windows-forms"></a>Практическое руководство. Печать графических изображений в Windows Forms
Часто требуется печать графических изображений в приложении Windows. <xref:System.Drawing.Graphics> Класс предоставляет методы для рисования объектов на таких устройствах, как экран или принтер.  
  
### <a name="to-print-graphics"></a>Чтобы печать графических изображений  
  
1. Добавление <xref:System.Drawing.Printing.PrintDocument> форму компонента.  
  
2. В <xref:System.Drawing.Printing.PrintDocument.PrintPage> обработчик событий, используйте <xref:System.Drawing.Printing.PrintPageEventArgs.Graphics%2A> свойство <xref:System.Drawing.Printing.PrintPageEventArgs> класса, чтобы сообщить принтеру на какого рода графики для печати.  
  
     В следующем примере кода показан обработчик событий, используемый для создания синего эллипса внутри ограничивающего прямоугольника. Прямоугольник имеет следующее расположение и размеры: начиная со 100, 150, 250 в ширину и высоту 250.  
  
    ```vb  
    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage  
       e.Graphics.FillEllipse(Brushes.Blue, New Rectangle(100, 150, 250, 250))  
    End Sub  
    ```  
  
    ```csharp  
    private void printDocument1_PrintPage(object sender,   
    System.Drawing.Printing.PrintPageEventArgs e)  
    {  
       e.Graphics.FillRectangle(Brushes.Blue,   
         new Rectangle(100, 150, 250, 250));  
    }  
    ```  
  
    ```cpp  
    private:  
       void printDocument1_PrintPage(System::Object ^ sender,  
          System::Drawing::Printing::PrintPageEventArgs ^ e)  
       {  
          e->Graphics->FillRectangle(Brushes::Blue,  
             Rectangle(100, 150, 250, 250));  
       }  
    ```  
  
     (Visual C# и [!INCLUDE[vcprvc](../../../../includes/vcprvc-md.md)]) поместите следующий код в конструктор формы для регистрации обработчика событий.  
  
    ```csharp  
    this.printDocument1.PrintPage += new  
       System.Drawing.Printing.PrintPageEventHandler  
       (this.printDocument1_PrintPage);  
    ```  
  
    ```cpp  
    this->printDocument1->PrintPage += gcnew  
       System::Drawing::Printing::PrintPageEventHandler  
       (this, &Form1::printDocument1_PrintPage);  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Graphics>
- <xref:System.Drawing.Brush>
- [Поддержка печати в Windows Forms](windows-forms-print-support.md)

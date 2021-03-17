---
title: Практическое руководство. Обработка события нажатия кнопки в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- buttons [Windows Forms], responding to Click events
- events [Windows Forms], Click events
- Click event [Windows Forms], Button control
- MouseDown event
- Button control [Windows Forms], click response
- double-clicks
- examples [Windows Forms], controls
- Click event [Windows Forms], responding to
ms.assetid: 7a4951bd-369c-4662-b246-28ad83eda484
ms.openlocfilehash: a10eaa3ea62df9301a53f5609b503bfabcb50a46
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59110075"
---
# <a name="how-to-respond-to-windows-forms-button-clicks"></a>Практическое руководство. Обработка события нажатия кнопки в Windows Forms
Самый простой способ использования форм Windows <xref:System.Windows.Forms.Button> элемент управления должен выполнять определенный код, при нажатии кнопки.  
  
 Щелкнув <xref:System.Windows.Forms.Button> создает элемент управления также ряд других событий, таких как <xref:System.Windows.Forms.Control.MouseEnter>, <xref:System.Windows.Forms.Control.MouseDown>, и <xref:System.Windows.Forms.Control.MouseUp> события. Если вы планируете присоединить обработчики событий для этих связанных событий, убедитесь, что их действия не конфликтуют. Например если нажатие кнопки удаляет сведения, которые пользователь ввел в текстовое поле, при наведении указателя мыши на кнопку не должно отображать подсказки с несуществующими сведениями.  
  
 Если пользователь пытается получить дважды щелкните <xref:System.Windows.Forms.Button> элемента управления, каждый щелчок будет обрабатываться отдельно; то есть элемент управления не поддерживает события двойного щелчка.  
  
### <a name="to-respond-to-a-button-click"></a>Реагировать на нажатие кнопки  
  
-   На кнопке панели `Click` <xref:System.EventHandler> напишите код для выполнения. `Button1_Click` должен быть привязан к элементу управления. Дополнительные сведения см. в разделе [Как Создание обработчиков событий во время выполнения для форм Windows Forms](../how-to-create-event-handlers-at-run-time-for-windows-forms.md).  
  
    ```vb  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click  
       MessageBox.Show("Button1 was clicked")  
    End Sub  
    ```  
  
    ```csharp  
    private void button1_Click(object sender, System.EventArgs e)  
    {  
       MessageBox.Show("button1 was clicked");  
    }  
    ```  
  
    ```cpp  
    private:  
       void button1_Click(System::Object ^ sender,  
          System::EventArgs ^ e)  
       {  
          MessageBox::Show("button1 was clicked");  
       }  
    ```  
  
## <a name="see-also"></a>См. также

- [Общие сведения об элементе управления Button](button-control-overview-windows-forms.md)
- [Способы активации элемента управления Button в Windows Forms](ways-to-select-a-windows-forms-button-control.md)
- [Элемент управления Button](button-control-windows-forms.md)

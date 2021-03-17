---
title: Практическое руководство. Определение текста, отображаемого элементом управления Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- Windows Forms, captions
- Button control [Windows Forms], button text
- StdFont object and CommandButton caption
- captions [Windows Forms], Windows Forms controls
- Text property [Windows Forms], Windows Forms control
- Button control [Windows Forms], text display
- labels [Windows Forms], adding to CommandButton control
- buttons [Windows Forms], text
- captions [Windows Forms], setting
- text
- examples [Windows Forms], controls
- text [Windows Forms], Windows Forms controls
- controls [Windows Forms], captions
- forms [Windows Forms], captions
ms.assetid: 36b95bff-8780-479d-b86a-f1a0673653aa
ms.openlocfilehash: 59570af89e6236e3c13866d45dc5361d52b84274
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59308527"
---
# <a name="how-to-set-the-text-displayed-by-a-windows-forms-control"></a>Практическое руководство. Определение текста, отображаемого элементом управления Windows Forms
В элементах управления Windows Forms обычно отображается текст, связанный с их основной функцией. Например, в элементе управления <xref:System.Windows.Forms.Button> обычно отображается заголовок, указывающий, какое действие выполняется при нажатии кнопки. С помощью свойства <xref:System.Windows.Forms.Control.Text%2A> можно задавать или получать текст для всех элементов управления. Шрифт можно менять с помощью свойства <xref:System.Windows.Forms.Control.Font%2A>. Также с помощью конструктора можно задавать текст.  Также см. раздел [Как Определение клавиш доступа для Windows Forms с помощью конструктора элементов управления](how-to-create-access-keys-for-windows-forms-controls-using-the-designer.md), [как: Задать текст, отображаемый элементом управления, с помощью конструктора форм Windows](how-to-set-the-text-displayed-by-a-windows-forms-control-using-the-designer.md), [как: Задайте изображения, отображаемого элементом управления, с помощью конструктора форм Windows](how-to-set-the-image-displayed-by-a-windows-forms-control-using-the-designer.md).  
  
### <a name="to-set-the-text-displayed-by-a-control-programmatically"></a>Программное задание текста, отображаемого элементом управления  
  
1. Присвойте свойству <xref:System.Windows.Forms.Control.Text%2A> строку.  
  
     Чтобы создать подчеркнутую клавишу доступа, поставьте амперсанд (&) перед буквой, которая будет использоваться ключ доступа.  
  
2. Присвойте свойству <xref:System.Windows.Forms.Control.Font%2A> объект типа <xref:System.Drawing.Font>.  
  
    ```vb  
    Button1.Text = "Click here to save changes"  
    Button1.Font = New Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point)  
    ```  
  
    ```csharp  
    button1.Text = "Click here to save changes";  
    button1.Font = new Font("Arial", 10, FontStyle.Bold,  
       GraphicsUnit.Point);  
    ```  
  
    ```cpp  
    button1->Text = "Click here to save changes";  
    button1->Font = new System::Drawing::Font("Arial",  
       10, FontStyle::Bold, GraphicsUnit::Point);  
    ```  
  
    > [!NOTE]
    >  Для отображения в элементах пользовательского интерфейса, например пунктах меню, специальных символов, которые обычно интерпретируются в них по-другому, можно использовать escape-символ. Например, следующая строка кода задает текст пункта меню для чтения «и что-то совершенно другим»:  
  
    ```vb  
    MPMenuItem.Text = "&& Now For Something Completely Different"  
    ```  
  
    ```csharp  
    mpMenuItem.Text = "&& Now For Something Completely Different";  
    ```  
  
    ```cpp  
    mpMenuItem->Text = "&& Now For Something Completely Different";  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Control.Text%2A?displayProperty=nameWithType>
- [Практическое руководство. Определение клавиш доступа для элементов управления Windows Forms](how-to-create-access-keys-for-windows-forms-controls.md)
- [Практическое руководство. Обработка события нажатия кнопки в Windows Forms](how-to-respond-to-windows-forms-button-clicks.md)

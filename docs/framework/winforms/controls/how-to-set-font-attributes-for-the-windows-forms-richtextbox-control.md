---
title: Практическое руководство. Задание атрибутов шрифта для элемента управления RichTextBox в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- .rtf files [Windows Forms], formatting in RichTextBox control
- fonts [Windows Forms], changing attributes in RichTextBox control
- RTF files [Windows Forms], formatting in RichTextBox control
- RichTextBox control [Windows Forms], setting font attributes
- text [Windows Forms]
- text boxes [Windows Forms], formatting text
- formatting [Windows Forms]
ms.assetid: 2bc23ddb-0529-4489-a1a2-ad253cb43f9a
ms.openlocfilehash: a6fe5b30c457fae2d53c946092b214f492fe5e9b
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59331212"
---
# <a name="how-to-set-font-attributes-for-the-windows-forms-richtextbox-control"></a>Практическое руководство. Задание атрибутов шрифта для элемента управления RichTextBox в Windows Forms
Windows Forms <xref:System.Windows.Forms.RichTextBox> элемент управления имеет разнообразные варианты форматирования отображаемого в нем текста. Вы можете выделить выбранные символы полужирным, подчеркнутым шрифтом или курсивом, с помощью <xref:System.Windows.Forms.RichTextBox.SelectionFont%2A> свойство. Это свойство также может использоваться для изменения размера и начертания выбранных символов. <xref:System.Windows.Forms.RichTextBox.SelectionColor%2A> Свойства можно изменить цвет выбранных символов.  
  
### <a name="to-change-the-appearance-of-characters"></a>Изменение внешнего вида символов  
  
1. Задайте <xref:System.Windows.Forms.RichTextBox.SelectionFont%2A> свойство соответствующий шрифт.  
  
     Чтобы обеспечить пользователям возможность выбора семейства шрифтов, размера и начертания в приложении, обычно используется <xref:System.Windows.Forms.FontDialog> компонента. Его обзор приведен в разделе [Общие сведения о компоненте FontDialog](fontdialog-component-overview-windows-forms.md).  
  
2. Задайте <xref:System.Windows.Forms.RichTextBox.SelectionColor%2A> свойство соответствующий цвет.  
  
     Чтобы пользователи могли установить цвет в приложении, обычно используется <xref:System.Windows.Forms.ColorDialog> компонента. Его обзор приведен в разделе [Общие сведения о компоненте ColorDialog](colordialog-component-overview-windows-forms.md).  
  
    ```vb  
    RichTextBox1.SelectionFont = New Font("Tahoma", 12, FontStyle.Bold)  
    RichTextBox1.SelectionColor = System.Drawing.Color.Red  
    ```  
  
    ```csharp  
    richTextBox1.SelectionFont = new Font("Tahoma", 12, FontStyle.Bold);  
    richTextBox1.SelectionColor = System.Drawing.Color.Red;  
    ```  
  
    ```cpp  
    richTextBox1->SelectionFont =  
       gcnew System::Drawing::Font("Tahoma", 12, FontStyle::Bold);  
    richTextBox1->SelectionColor = System::Drawing::Color::Red;  
    ```  
  
    > [!NOTE]
    >  Эти свойства влияют лишь на выделенный текст или, если никакой текст не выбран, текст, вводимый в текущей позиции курсора. Сведения о программном выборе текста см. в разделе <xref:System.Windows.Forms.TextBoxBase.Select%2A>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.RichTextBox>
- [Элемент управления RichTextBox](richtextbox-control-windows-forms.md)
- [Элементы управления для использования в формах Windows Forms](controls-to-use-on-windows-forms.md)

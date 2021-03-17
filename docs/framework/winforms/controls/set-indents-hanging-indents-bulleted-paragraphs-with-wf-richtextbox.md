---
title: Практическое руководство. Задание отступов, выступов и маркеров абзацев с помощью элемента управления RichTextBox в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- text boxes [Windows Forms], setting indents
- .rtf files [Windows Forms], formatting in RichTextBox control
- examples [Windows Forms], text boxes
- RTF files [Windows Forms], formatting in RichTextBox control
- RichTextBox control [Windows Forms], setting indents and bullets
- text boxes [Windows Forms], bullets
ms.assetid: abfb40e6-5642-4691-8ec1-9d9ae91688dc
ms.openlocfilehash: ef579923ac2b9ea9905a60000d93f6bfc90ed5b8
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59342678"
---
# <a name="how-to-set-indents-hanging-indents-and-bulleted-paragraphs-with-the-windows-forms-richtextbox-control"></a>Практическое руководство. Задание отступов, выступов и маркеров абзацев с помощью элемента управления RichTextBox в Windows Forms
Windows Forms <xref:System.Windows.Forms.RichTextBox> элемент управления имеет разнообразные варианты форматирования отображаемого в нем текста. Можно форматировать выделенные абзацы в виде маркированных списков, задав <xref:System.Windows.Forms.RichTextBox.SelectionBullet%2A> свойство. Можно также использовать <xref:System.Windows.Forms.RichTextBox.SelectionIndent%2A>, <xref:System.Windows.Forms.RichTextBox.SelectionRightIndent%2A>, и <xref:System.Windows.Forms.RichTextBox.SelectionHangingIndent%2A> свойства, чтобы задать отступ абзацев относительно левой и правой границ элемента управления и левого края остальных строк текста.  
  
### <a name="to-format-a-paragraph-as-a-bulleted-list"></a>Форматирование абзаца в виде маркированного списка  
  
1. Задайте для свойства <xref:System.Windows.Forms.RichTextBox.SelectionBullet%2A> значение `true`.  
  
    ```vb  
    RichTextBox1.SelectionBullet = True  
    ```  
  
    ```csharp  
    richTextBox1.SelectionBullet = true;  
    ```  
  
    ```cpp  
    richTextBox1->SelectionBullet = true;  
    ```  
  
### <a name="to-indent-a-paragraph"></a>Чтобы задать отступ абзаца  
  
1. Задайте <xref:System.Windows.Forms.RichTextBox.SelectionIndent%2A> свойство в целое число, представляющее расстояние в пикселях между левым краем элемента управления и левой границей текста.  
  
2. Задайте <xref:System.Windows.Forms.RichTextBox.SelectionHangingIndent%2A> свойство в целое число, представляющее расстояние в пикселях между левым краем первой строки текста в абзаце и левой границей последующих строк того же абзаца. Значение <xref:System.Windows.Forms.RichTextBox.SelectionHangingIndent%2A> свойство применяется только к строкам абзаца, следующим первой строки.  
  
3. Задайте <xref:System.Windows.Forms.RichTextBox.SelectionRightIndent%2A> свойство в целое число, представляющее расстояние в пикселях между правым краем элемента управления и правым краем текста.  
  
    ```vb  
    RichTextBox1.SelectionIndent = 8  
    RichTextBox1.SelectionHangingIndent = 3  
    RichTextBox1.SelectionRightIndent = 12  
    ```  
  
    ```csharp  
    richTextBox1.SelectionIndent = 8;  
    richTextBox1.SelectionHangingIndent = 3;  
    richTextBox1.SelectionRightIndent = 12;  
    ```  
  
    ```cpp  
    richTextBox1->SelectionIndent = 8;  
    richTextBox1->SelectionHangingIndent = 3;  
    richTextBox1->SelectionRightIndent = 12;  
    ```  
  
    > [!NOTE]
    >  Все эти свойства влияют на все абзацы, содержащие выделенный текст, а также на текст, который будет вводиться после текущей позиции курсора. Например, когда пользователь выделяет слово в абзаце и затем изменяет параметры отступа, новые параметры будут применяться ко всему абзацу, который содержит это слово, а также ко всем абзацам, которые будут введены после выделенного абзаца. Сведения о программном выборе текста см. в разделе <xref:System.Windows.Forms.TextBoxBase.Select%2A>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.RichTextBox>
- [Элемент управления RichTextBox](richtextbox-control-windows-forms.md)
- [Элементы управления для использования в формах Windows Forms](controls-to-use-on-windows-forms.md)

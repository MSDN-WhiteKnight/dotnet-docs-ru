---
title: Общие сведения об элементе управления RichTextBox (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- RichTextBox
helpviewer_keywords:
- RichTextBox control [Windows Forms], about RichTextBox control
- text boxes [Windows Forms], about text boxes
ms.assetid: 95081194-3dd4-4b84-9545-dd373e491eca
ms.openlocfilehash: 0827c1919597e9eb85bfa41721676008b76564d9
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59201602"
---
# <a name="richtextbox-control-overview-windows-forms"></a>Общие сведения об элементе управления RichTextBox (Windows Forms)
Windows Forms <xref:System.Windows.Forms.RichTextBox> элемент управления используется для отображения, ввода и обработки текста с форматированием. <xref:System.Windows.Forms.RichTextBox> Управления следит за недопущением <xref:System.Windows.Forms.TextBox> делает элемент управления, но может также отображать шрифты, цвета и ссылки; загрузить текст и встроенные изображения из файла; и находить указанные символы. <xref:System.Windows.Forms.RichTextBox> Управления обычно используется для работы с текстом и отображения функций, как для текстовых редакторов, таких как Microsoft Word. Как <xref:System.Windows.Forms.TextBox> управления <xref:System.Windows.Forms.RichTextBox> элемент управления может отображать полосы прокрутки; но в отличие от <xref:System.Windows.Forms.TextBox> элемента управления, его значение по умолчанию является отображение горизонтальных и вертикальных полос прокрутки, при необходимости, и он имеет дополнительные параметры полосы прокрутки.  
  
## <a name="working-with-the-richtextbox-control"></a>Работа с элементом управления RichTextBox  
 Как и в <xref:System.Windows.Forms.TextBox> элемента управления, отображаемый текст задается <xref:System.Windows.Forms.RichTextBox.Text%2A> свойство. <xref:System.Windows.Forms.RichTextBox> Элемент управления имеет множество свойств для форматирования текста. Дополнительные сведения об этих свойствах см. в разделе [как: Задание атрибутов шрифта для Windows Forms в элементе управления RichTextBox](how-to-set-font-attributes-for-the-windows-forms-richtextbox-control.md) и [как: Задание отступов, выступов и маркеров абзацев с помощью элемента управления RichTextBox в Windows Forms](set-indents-hanging-indents-bulleted-paragraphs-with-wf-richtextbox.md). Для работы с файлами, <xref:System.Windows.Forms.RichTextBox.LoadFile%2A> и <xref:System.Windows.Forms.RichTextBox.SaveFile%2A> методы можно отображать и записывать нескольких файловых форматов, включая обычный текст, текст в Юникоде и форматированный текст (RTF). Возможные форматы перечислены в <xref:System.Windows.Forms.RichTextBoxStreamType>. Можно использовать <xref:System.Windows.Forms.RichTextBox.Find%2A> метод для поиска строк текста или определенные символов.  
  
 Можно также использовать <xref:System.Windows.Forms.RichTextBox> управления для веб-ссылок, задав <xref:System.Windows.Forms.RichTextBox.DetectUrls%2A> свойства `true` и написание кода для обработки <xref:System.Windows.Forms.RichTextBox.LinkClicked> событий. Дополнительные сведения см. в разделе [Как Отображение веб-ссылок с помощью Windows Forms в элементе управления RichTextBox](how-to-display-web-style-links-with-the-windows-forms-richtextbox-control.md). Можно запретить пользователю управление некоторые или все текста в элементе управления, задав <xref:System.Windows.Forms.RichTextBox.SelectionProtected%2A> свойства `true`.  
  
 Можно отменять и повторять большую часть операций редактирования в <xref:System.Windows.Forms.RichTextBox> элемента управления, используя <xref:System.Windows.Forms.TextBoxBase.Undo%2A> и <xref:System.Windows.Forms.RichTextBox.Redo%2A> методы. <xref:System.Windows.Forms.RichTextBox.CanRedo%2A> Метод позволяет определить, можно ли повторно применить последнюю операцию пользователем в элемент управления.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.RichTextBox>
- [Элемент управления RichTextBox](richtextbox-control-windows-forms.md)
- [Общие сведения об элементе управления TextBox](textbox-control-overview-windows-forms.md)

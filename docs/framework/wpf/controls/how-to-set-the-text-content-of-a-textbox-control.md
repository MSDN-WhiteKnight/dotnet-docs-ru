---
title: Практическое руководство. Установка текстового содержимого для элемента управления TextBox
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- text content [WPF], setting
- TextBox control [WPF], setting text content
ms.assetid: bcd25fc7-a52f-4453-b802-2c8d2b335ab8
ms.openlocfilehash: da91e27b804d649f5b8010bc9d7c074425be26f6
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59212197"
---
# <a name="how-to-set-the-text-content-of-a-textbox-control"></a>Практическое руководство. Установка текстового содержимого для элемента управления TextBox
В этом примере показано, как использовать <xref:System.Windows.Controls.TextBox.Text%2A> свойство для задания начального текстового содержимого элемента <xref:System.Windows.Controls.TextBox> элемента управления.  
  
 **Примечание** несмотря на то что [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] использовать версию примера `<TextBox.Text>` теги вокруг текста каждой кнопки <xref:System.Windows.Controls.TextBox> содержимого, нет необходимости поскольку <xref:System.Windows.Controls.TextBox> применяется <xref:System.Windows.Markup.ContentPropertyAttribute> для атрибута <xref:System.Windows.Controls.TextBox.Text%2A> свойство. Дополнительные сведения см. в разделе [Обзор XAML (WPF)](../advanced/xaml-overview-wpf.md).  
  
## <a name="example"></a>Пример  
 [!code-xaml[TextBox_MiscCode#_TextBoxSetTextXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/TextBox_MiscCode/CSharp/Window1.xaml#_textboxsettextxaml)]  
  
## <a name="example"></a>Пример  
 [!code-csharp[TextBox_MiscCode#_TextBoxSetText](~/samples/snippets/csharp/VS_Snippets_Wpf/TextBox_MiscCode/CSharp/Window1.xaml.cs#_textboxsettext)]
   
  
## <a name="see-also"></a>См. также

- [Общие сведения о TextBox](textbox-overview.md)
- [Общие сведения о RichTextBox](richtextbox-overview.md)

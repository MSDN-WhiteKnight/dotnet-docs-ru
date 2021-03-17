---
title: Практическое руководство. Добавление водяного знака в элемент TextBox
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- displaying a background image inside a text box to aid user input [WPF]
- aid usability of a TextBox using a background image [WPF]
ms.assetid: df89bdd8-a0fb-45e0-b312-dd53332d01a8
ms.openlocfilehash: ef2536f03ba6ed08e27d2fcf30cd1f72df2cf460
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59142419"
---
# <a name="how-to-add-a-watermark-to-a-textbox"></a>Практическое руководство. Добавление водяного знака в элемент TextBox
В следующем примере показано, как расширение полезности элемента <xref:System.Windows.Controls.TextBox> , отображая пояснительного фонового изображение внутри <xref:System.Windows.Controls.TextBox> пока пользователь вводит текст, после чего соответствующий образ удаляется. Кроме того фоновое изображение восстанавливается, если пользователь удаляет входные данные. См. рисунок ниже.  
  
 ![TextBox с фоновым изображением](./media/editing-textbox-using-background-image.png "Editing_TextBox_using_background_image")  
  
> [!NOTE]
>  Причина, фоновое изображение используется в этом примере вместо применения <xref:System.Windows.Controls.TextBox.Text%2A> свойство <xref:System.Windows.Controls.TextBox>, — что фоновое изображение не будет мешать привязки данных.  
  
## <a name="example"></a>Пример  
 [!code-xaml[TextBoxMiscSnippets_snip#TextBoxBackgroundExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/TextBoxMiscSnippets_snip/csharp/textbox_with_background_image.xaml#textboxbackgroundexamplewholepage)]  
  
 [!code-csharp[TextBoxMiscSnippets_snip#TextBoxBackgroundCodeExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/TextBoxMiscSnippets_snip/csharp/textbox_with_background_image.xaml.cs#textboxbackgroundcodeexamplewholepage)]
 [!code-vb[TextBoxMiscSnippets_snip#TextBoxBackgroundCodeExampleWholePage](~/samples/snippets/visualbasic/VS_Snippets_Wpf/TextBoxMiscSnippets_snip/visualbasic/textbox_with_background_image.xaml.vb#textboxbackgroundcodeexamplewholepage)]  
  
## <a name="see-also"></a>См. также

- [Общие сведения о TextBox](textbox-overview.md)
- [Общие сведения о RichTextBox](richtextbox-overview.md)

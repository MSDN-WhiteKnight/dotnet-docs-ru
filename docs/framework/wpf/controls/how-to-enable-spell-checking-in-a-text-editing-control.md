---
title: Практическое руководство. Включение проверки орфографии в элементе управления редактирования текста
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- spellchecking [WPF]
- real-time spellchecking
- TextBox control [WPF], real-time spellchecking
- spelling checker [WPF]
- checking spelling [WPF]
ms.assetid: 6f953d2b-67e8-4012-84ce-53c0e958da47
ms.openlocfilehash: 7381bafc349506d89058581e9ed62a4348a72865
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59076852"
---
# <a name="how-to-enable-spell-checking-in-a-text-editing-control"></a>Практическое руководство. Включение проверки орфографии в элементе управления редактирования текста
В следующем примере демонстрируется включение проверки орфографии в режиме реального времени <xref:System.Windows.Controls.TextBox> с помощью <xref:System.Windows.Controls.SpellCheck.IsEnabled%2A> свойство <xref:System.Windows.Controls.SpellCheck> класса.  
  
## <a name="example"></a>Пример  
 [!code-xaml[TextBoxMiscSnippets_snip#SpellCheckExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/TextBoxMiscSnippets_snip/csharp/spellcheckexample.xaml#spellcheckexamplewholepage)]  
  
 [!code-csharp[TextBoxMiscSnippets_procedural_snip#SpellCheckCodeExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/TextBoxMiscSnippets_procedural_snip/CSharp/SpellCheckExample.cs#spellcheckcodeexamplewholepage)]
   
  
## <a name="see-also"></a>См. также

- [Использование проверки орфографии с помощью контекстного меню](how-to-use-spell-checking-with-a-context-menu.md)
- [Общие сведения о TextBox](textbox-overview.md)
- [Общие сведения о RichTextBox](richtextbox-overview.md)

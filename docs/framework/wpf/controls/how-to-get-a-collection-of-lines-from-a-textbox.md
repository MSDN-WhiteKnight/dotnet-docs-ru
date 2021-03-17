---
title: Практическое руководство. Получение коллекции строк из элемента TextBox
ms.date: 03/30/2017
helpviewer_keywords:
- lines [WPF], getting collection of
- TextBox control [WPF], getting collection of lines
ms.assetid: a12f529d-b926-47f6-92bf-cad5f17b532a
ms.openlocfilehash: b7b2f1c2e071388635fb50b1e3573fd7f44334dd
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59224641"
---
# <a name="how-to-get-a-collection-of-lines-from-a-textbox"></a>Практическое руководство. Получение коллекции строк из элемента TextBox
В этом примере показано, как получить коллекцию строк текста из <xref:System.Windows.Controls.TextBox>.  
  
## <a name="example"></a>Пример  
 В примере показан простой метод, который принимает <xref:System.Windows.Controls.TextBox> как аргумент и она возвращает <xref:System.Collections.Specialized.StringCollection> содержащих строки текста в **TextBox**.  <xref:System.Windows.Controls.TextBox.LineCount%2A> Свойство используется для определения, сколько строк находится в данный момент **TextBox**и <xref:System.Windows.Controls.TextBox.GetLineText%2A> метод затем используется для извлечения каждой строки и добавьте его в коллекцию строк.  
  
 [!code-csharp[TextBox_MiscCode#_TextBox_GetLines](~/samples/snippets/csharp/VS_Snippets_Wpf/TextBox_MiscCode/CSharp/Window1.xaml.cs#_textbox_getlines)]  
  
## <a name="see-also"></a>См. также

- [Общие сведения о TextBox](textbox-overview.md)
- [Общие сведения о RichTextBox](richtextbox-overview.md)

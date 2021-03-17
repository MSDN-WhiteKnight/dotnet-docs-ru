---
title: Практическое руководство. Перевод элемента управления TextBox в режим только для чтения
ms.date: 03/30/2017
helpviewer_keywords:
- read-only TextBox controls [WPF]
- TextBox control read-only
ms.assetid: e707ec59-8b22-473e-b77c-3060a237517a
ms.openlocfilehash: 7f24458eb98bd669d59f15c49d1d9e3beb6833b1
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59229840"
---
# <a name="how-to-make-a-textbox-control-read-only"></a>Практическое руководство. Перевод элемента управления TextBox в режим только для чтения
В этом примере показано, как настроить <xref:System.Windows.Controls.TextBox> элемента управления, чтобы запретить пользовательский ввод или изменение.  
  
## <a name="example"></a>Пример  
 Чтобы запретить пользователям изменять содержимое <xref:System.Windows.Controls.TextBox> , назначьте <xref:System.Windows.Controls.Primitives.TextBoxBase.IsReadOnly%2A> атрибут **true**.  
  
 [!code-xaml[TextBox_MiscCode#_ReadOnlyTextBoxXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/TextBox_MiscCode/CSharp/Window1.xaml#_readonlytextboxxaml)]  
  
 <xref:System.Windows.Controls.Primitives.TextBoxBase.IsReadOnly%2A> Атрибут влияет только ввод данных пользователем; он не влияет на текст, задайте [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] описание <xref:System.Windows.Controls.TextBox> управления или текст, задать программно с помощью <xref:System.Windows.Controls.TextBox.Text%2A> свойство.  
  
 Значение по умолчанию <xref:System.Windows.Controls.Primitives.TextBoxBase.IsReadOnly%2A> — **false**.  
  
## <a name="see-also"></a>См. также

- [Общие сведения о TextBox](textbox-overview.md)
- [Общие сведения о RichTextBox](richtextbox-overview.md)

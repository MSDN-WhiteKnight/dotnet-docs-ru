---
title: Изменение выделения в RichTextBox программными средствами
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- changing selections in a text box [WPF]
- changing selections in a RichTextBox [WPF]
ms.assetid: f1213205-1ad7-4cd2-b115-460173cc5aa3
ms.openlocfilehash: b8acfe7cde1fe5dae96cd6324f75c5b146be9ec9
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59096230"
---
# <a name="change-selection-in-a-richtextbox-programmatically"></a>Изменение выделения в RichTextBox программными средствами
В этом примере показано, как программно изменить текущее выделение в <xref:System.Windows.Controls.RichTextBox>. Этот параметр аналогичен так, как если бы пользователь выделил содержимое с помощью пользовательского интерфейса.  
  
## <a name="example"></a>Пример  
 Следующие XAML коде описывается элемент <xref:System.Windows.Controls.RichTextBox> элемента управления с простым содержимым.  
  
 [!code-xaml[RichTextBoxMiscSnippets_snip#ChangeSelectionProgrammaticalyExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/RichTextBoxMiscSnippets_snip/CSharp/ChangeSelectionProgrammaticaly.xaml#changeselectionprogrammaticalyexamplewholepage)]  
  
## <a name="example"></a>Пример  
 В следующем коде программно выбирается произвольный текст, когда пользователь щелкает внутри <xref:System.Windows.Controls.RichTextBox>.  
  
 [!code-csharp[RichTextBoxMiscSnippets_snip#ChangeSelectionProgrammaticalyCodeExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/RichTextBoxMiscSnippets_snip/CSharp/ChangeSelectionProgrammaticaly.xaml.cs#changeselectionprogrammaticalycodeexamplewholepage)]
   
  
## <a name="see-also"></a>См. также

- [Общие сведения о RichTextBox](richtextbox-overview.md)
- [Общие сведения о TextBox](textbox-overview.md)

---
title: Практическое руководство. Включение знаков табуляции в элементе управления TextBox
ms.date: 03/30/2017
helpviewer_keywords:
- TextBox control [WPF], enabling tab characters
- tab characters [WPF], enabling
ms.assetid: 14b1b064-61f7-4958-be63-88d85b868d03
ms.openlocfilehash: 9a01ae93d1b75c604fbe4f15f720e0a84086bd1a
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59149491"
---
# <a name="how-to-enable-tab-characters-in-a-textbox-control"></a>Практическое руководство. Включение знаков табуляции в элементе управления TextBox
В этом примере показано, как включить принятие знаков табуляции в качестве обычных входных данных в <xref:System.Windows.Controls.TextBox> элемента управления.  
  
## <a name="example"></a>Пример  
 Включение принятия знаков табуляции в качестве входных данных в <xref:System.Windows.Controls.TextBox> , назначьте <xref:System.Windows.Controls.Primitives.TextBoxBase.AcceptsTab%2A> атрибут **true**.  
  
 [!code-xaml[TextBox_EnablingTab#_AcceptsTab](~/samples/snippets/csharp/VS_Snippets_Wpf/TextBox_EnablingTab/CS/Window1.xaml#_acceptstab)]  
  
## <a name="see-also"></a>См. также

- [Общие сведения о TextBox](textbox-overview.md)
- [Общие сведения о RichTextBox](richtextbox-overview.md)

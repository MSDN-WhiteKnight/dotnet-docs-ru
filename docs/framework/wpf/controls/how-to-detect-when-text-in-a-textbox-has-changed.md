---
title: Практическое руководство. Определение изменения текста в TextBox
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- TextBox control [WPF], detecting text change
- text change [WPF], detecting
- detecting text change [WPF]
ms.assetid: 1c39ee14-e37f-49fb-a0d1-a9824ca13584
ms.openlocfilehash: 1adadb0f071815930d34f40ddf244ffc8c19131b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59091152"
---
# <a name="how-to-detect-when-text-in-a-textbox-has-changed"></a>Практическое руководство. Определение изменения текста в TextBox
В этом примере показан один из способов использования <xref:System.Windows.Controls.Primitives.TextBoxBase.TextChanged> событий для выполнения метода всякий раз, когда текст в <xref:System.Windows.Controls.TextBox> элемент управления был изменен.  
  
 В классе фонового кода для [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] , содержащий <xref:System.Windows.Controls.TextBox> элемент управления, который вы хотите отслеживать изменения, вставить метод, вызываемый каждый раз, когда <xref:System.Windows.Controls.Primitives.TextBoxBase.TextChanged> вызывает событие.  Этот метод должен иметь сигнатуру, которая соответствует ожидаемых <xref:System.Windows.Controls.TextChangedEventHandler> делегировать.  
  
 Обработчик событий вызывается всякий раз, когда содержимое <xref:System.Windows.Controls.TextBox> управления изменяются, либо пользователем, либо программным способом.  
  
 **Примечание.** Это событие возникает, когда <xref:System.Windows.Controls.TextBox> создается и изначально была заполнена текстом элемента управления.  
  
## <a name="example"></a>Пример  
 В [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] , определяющий вашей <xref:System.Windows.Controls.TextBox> управления, укажите <xref:System.Windows.Controls.Primitives.TextBoxBase.TextChanged> атрибут со значением, которое соответствует имени метода обработчика событий.  
  
 [!code-xaml[TextBox_MiscCode#_TextChangedXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/TextBox_MiscCode/CSharp/Window1.xaml#_textchangedxaml)]  
  
## <a name="example"></a>Пример  
 В классе фонового кода для [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] , содержащий <xref:System.Windows.Controls.TextBox> элемент управления, который вы хотите отслеживать изменения, вставить метод, вызываемый каждый раз, когда <xref:System.Windows.Controls.Primitives.TextBoxBase.TextChanged> вызывает событие.  Этот метод должен иметь сигнатуру, которая соответствует ожидаемых <xref:System.Windows.Controls.TextChangedEventHandler> делегировать.  
  
 [!code-csharp[TextBox_MiscCode#_TextChangedEventHandler](~/samples/snippets/csharp/VS_Snippets_Wpf/TextBox_MiscCode/CSharp/Window1.xaml.cs#_textchangedeventhandler)]
 [!code-vb[TextBox_MiscCode#_TextChangedEventHandler](~/samples/snippets/visualbasic/VS_Snippets_Wpf/TextBox_MiscCode/VisualBasic/Window1.xaml.vb#_textchangedeventhandler)]  
  
 Обработчик событий вызывается всякий раз, когда содержимое <xref:System.Windows.Controls.TextBox> управления изменяются, либо пользователем, либо программным способом.  
  
 **Примечание.** Это событие возникает, когда <xref:System.Windows.Controls.TextBox> создается и изначально была заполнена текстом элемента управления.  
  
 Комментарии  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.TextChangedEventArgs>
- [Общие сведения о TextBox](textbox-overview.md)
- [Общие сведения о RichTextBox](richtextbox-overview.md)

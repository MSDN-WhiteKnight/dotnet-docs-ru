---
title: Практическое руководство. Создание элемента управления, имеющего клавишу доступа и поддерживающего перенос текста
ms.date: 03/30/2017
helpviewer_keywords:
- access keys [WPF], control for
- controls [WPF], text wrapping
- wrapping text [WPF]
- keys [WPF], control for
- controls [WPF], access keys
- text wrapping [WPF]
ms.assetid: 205099d9-2551-4302-a25e-a15af9f67e04
ms.openlocfilehash: 48e439719afa2426b5d8f822c621080cdc32514e
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59174048"
---
# <a name="how-to-create-a-control-that-has-an-access-key-and-text-wrapping"></a>Практическое руководство. Создание элемента управления, имеющего клавишу доступа и поддерживающего перенос текста
В этом примере показано, как создать элемент управления, который имеет клавишу доступа и поддерживает обтекание текстом. В примере используется <xref:System.Windows.Controls.Label> управления для демонстрации этих понятий.  
  
## <a name="example"></a>Пример  
 **Добавление обтекания текстом для метки**  
  
 <xref:System.Windows.Controls.Label> Управления не поддерживает обтекание текстом. Если нужна метка, которая охватывает несколько строк, то можно вложить другой элемент, который поддерживает обтекание текстом, и поместить этот элемент внутрь метки. В следующем примере показано, как использовать <xref:System.Windows.Controls.TextBlock> для создания метки, которая охватывает несколько строк текста.  
  
 [!code-xaml[LabelSnippet#5](~/samples/snippets/csharp/VS_Snippets_Wpf/LabelSnippet/CS/Pane1.xaml#5)]  
  
 **Добавьте клавишу доступа и поддерживающего перенос текста для метки**  
  
 Если вам нужна <xref:System.Windows.Controls.Label> , имеет клавишу доступа (назначенную), используйте <xref:System.Windows.Controls.AccessText> элемент, который находится внутри <xref:System.Windows.Controls.Label>.  
  
 Элементы управления, например <xref:System.Windows.Controls.Label>, <xref:System.Windows.Controls.Button>, <xref:System.Windows.Controls.RadioButton>, <xref:System.Windows.Controls.CheckBox>, <xref:System.Windows.Controls.MenuItem>, <xref:System.Windows.Controls.TabItem>, <xref:System.Windows.Controls.Expander>, и <xref:System.Windows.Controls.GroupBox> имеют шаблоны элементов управления по умолчанию. Эти шаблоны содержат <xref:System.Windows.Controls.ContentPresenter>. Одно из свойств, которые можно установить на <xref:System.Windows.Controls.ContentPresenter> является <xref:System.Windows.Controls.ContentPresenter.RecognizesAccessKey%2A>= «true», который можно использовать для указания клавиши доступа для элемента управления.  
  
 В следующем примере показано, как создать <xref:System.Windows.Controls.Label> который имеет клавишу доступа и поддерживает обтекание текстом. Чтобы включить обтекание текстом, в примере задается <xref:System.Windows.Controls.AccessText.TextWrapping%2A> свойство и использует знак подчеркивания для указания клавиши доступа. (Символ, который следует сразу за символом подчеркивания, является клавишей доступа).  
  
 [!code-xaml[LabelSnippet#4](~/samples/snippets/csharp/VS_Snippets_Wpf/LabelSnippet/CS/Pane1.xaml#4)]  
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Установка целевого свойства метки](https://docs.microsoft.com/previous-versions/dotnet/netframework-3.5/ms752101(v=vs.90))

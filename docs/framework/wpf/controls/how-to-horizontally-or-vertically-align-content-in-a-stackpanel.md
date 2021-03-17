---
title: Практическое руководство. Выравнивание содержимого StackPanel по горизонтали или по вертикали
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- StackPanel control [WPF], content alignment [WPF]
- content alignment [WPF]
- aligning [WPF], content
ms.assetid: c1e8f962-72c8-4e7a-8670-7a2d7e021791
ms.openlocfilehash: 03348aa0eb5b6c1791c27683c1c6c6a5d4a8a9d4
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59186047"
---
# <a name="how-to-horizontally-or-vertically-align-content-in-a-stackpanel"></a>Практическое руководство. Выравнивание содержимого StackPanel по горизонтали или по вертикали
В этом примере показано, как настроить <xref:System.Windows.Controls.StackPanel.Orientation%2A> содержимого в <xref:System.Windows.Controls.StackPanel> элемент, а также настройка <xref:System.Windows.FrameworkElement.HorizontalAlignment%2A> и <xref:System.Windows.FrameworkElement.VerticalAlignment%2A> дочернего содержимого.  
  
## <a name="example"></a>Пример  
 В следующем примере создается три <xref:System.Windows.Controls.ListBox> элементов в [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)]. Каждый <xref:System.Windows.Controls.ListBox> представляет возможные значения <xref:System.Windows.Controls.StackPanel.Orientation%2A>, <xref:System.Windows.FrameworkElement.HorizontalAlignment%2A>, и <xref:System.Windows.FrameworkElement.VerticalAlignment%2A> свойства <xref:System.Windows.Controls.StackPanel>. Когда пользователь выбирает значение в любом из <xref:System.Windows.Controls.ListBox> элементов, связанному свойству <xref:System.Windows.Controls.StackPanel> и его дочерние <xref:System.Windows.Controls.Button> изменение элементов.  
  
 [!code-xaml[StackPanelIntroSamp#1](~/samples/snippets/csharp/VS_Snippets_Wpf/StackPanelIntroSamp/CSharp/Window1.xaml#1)]  
  
 Следующий файл кода определяет изменения на события, которые связаны с <xref:System.Windows.Controls.ListBox> изменения выделения. <xref:System.Windows.Controls.StackPanel> определяется <xref:System.Windows.FrameworkElement.Name%2A> `sp1`.  
  
 [!code-csharp[StackPanelIntroSamp#2](~/samples/snippets/csharp/VS_Snippets_Wpf/StackPanelIntroSamp/CSharp/Window1.xaml.cs#2)]
 [!code-vb[StackPanelIntroSamp#2](~/samples/snippets/visualbasic/VS_Snippets_Wpf/StackPanelIntroSamp/VisualBasic/Window1.xaml.vb#2)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.StackPanel>
- <xref:System.Windows.Controls.ListBox>
- <xref:System.Windows.FrameworkElement.HorizontalAlignment%2A>
- <xref:System.Windows.FrameworkElement.VerticalAlignment%2A>
- [Общие сведения о панелях](panels-overview.md)

---
title: Практическое руководство. Применение триггеров для определения стиля выбранных элементов в ListView
ms.date: 03/30/2017
helpviewer_keywords:
- ListView controls [WPF], styling
ms.assetid: 1e2bdce0-afe8-4507-9b18-f33de43de25a
ms.openlocfilehash: ad64382b871bae9114a1e63257de3f8595376923
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59145409"
---
# <a name="how-to-use-triggers-to-style-selected-items-in-a-listview"></a>Практическое руководство. Применение триггеров для определения стиля выбранных элементов в ListView
В этом примере показан способ определения <xref:System.Windows.Style.Triggers%2A> для <xref:System.Windows.Controls.ListViewItem> управления таким образом, когда значение свойства <xref:System.Windows.Controls.ListViewItem> изменения, <xref:System.Windows.Style> из <xref:System.Windows.Controls.ListViewItem> изменения в ответ.  
  
## <a name="example"></a>Пример  
 Если вы хотите, чтобы <xref:System.Windows.Style> из <xref:System.Windows.Controls.ListViewItem> для изменения в ответ на изменения свойств, определите <xref:System.Windows.Style.Triggers%2A> для <xref:System.Windows.Style> изменить.  
  
 В следующем примере определяется <xref:System.Windows.Trigger> , задает <xref:System.Windows.Controls.Control.Foreground%2A> свойства <xref:System.Windows.Media.Brushes.Blue%2A> и изменяет <xref:System.Windows.FrameworkElement.Cursor%2A> для отображения <xref:System.Windows.Input.CursorType.Hand> при <xref:System.Windows.UIElement.IsMouseOver%2A> изменения свойств `true`.  
  
 [!code-xaml[ListViewChkBox#ListViewItemTriggersStart](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewChkBox/CS/window1.xaml#listviewitemtriggersstart)]  
[!code-xaml[ListViewChkBox#Trigger](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewChkBox/CS/window1.xaml#trigger)]  
[!code-xaml[ListViewChkBox#ListViewItemTriggersEnd](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewChkBox/CS/window1.xaml#listviewitemtriggersend)]  
  
 В следующем примере определяется <xref:System.Windows.MultiTrigger> , задает <xref:System.Windows.Controls.Control.Foreground%2A> свойство <xref:System.Windows.Controls.ListViewItem> для <xref:System.Windows.Media.Brushes.Yellow%2A> при <xref:System.Windows.Controls.ListViewItem> является выбранным элементом и имеет фокус клавиатуры.  
  
 [!code-xaml[ListViewChkBox#ListViewItemTriggersStart](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewChkBox/CS/window1.xaml#listviewitemtriggersstart)]  
[!code-xaml[ListViewChkBox#MultiTrigger](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewChkBox/CS/window1.xaml#multitrigger)]  
[!code-xaml[ListViewChkBox#ListViewItemTriggersEnd](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewChkBox/CS/window1.xaml#listviewitemtriggersend)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.Control>
- <xref:System.Windows.Controls.ListView>
- <xref:System.Windows.Controls.GridView>
- [Практические руководства](listview-how-to-topics.md)
- [Общие сведения об элементе управления ListView](listview-overview.md)
- [Общие сведения о GridView](gridview-overview.md)

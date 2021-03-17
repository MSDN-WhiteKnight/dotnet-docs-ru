---
title: Практическое руководство. Проверка видимости GridSplitter
ms.date: 03/30/2017
helpviewer_keywords:
- GridSplitter control [WPF], ensuring visibility of
ms.assetid: 0a62a964-89c8-48f0-9023-5df721a8cf47
ms.openlocfilehash: b7543d14ba39d854b5a2c3f4d0d19b9a457ea89b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59147151"
---
# <a name="how-to-make-sure-that-a-gridsplitter-is-visible"></a>Практическое руководство. Проверка видимости GridSplitter
В этом примере показано, как убедитесь, что <xref:System.Windows.Controls.GridSplitter> элемент управления не скрыт другими элементами управления в <xref:System.Windows.Controls.Grid>.  
  
## <a name="example"></a>Пример  
 <xref:System.Windows.Controls.Panel.Children%2A> Из <xref:System.Windows.Controls.Grid> управления отображаются в порядке, в котором они определены в разметку или код. <xref:System.Windows.Controls.GridSplitter> элементы управления могут быть скрыты другими элементами управления, если их не следует определять как последними элементами в <xref:System.Windows.Controls.Panel.Children%2A> коллекции или задать для других элементов более высокое <xref:System.Windows.Controls.Panel.ZIndexProperty>.  
  
 Чтобы избежать скрытого <xref:System.Windows.Controls.GridSplitter> элементов управления, выполните одно из следующих действий.  
  
-   Убедитесь, что <xref:System.Windows.Controls.GridSplitter> элементы управления являются последнего <xref:System.Windows.Controls.Panel.Children%2A> добавляемый <xref:System.Windows.Controls.Grid>. В следующем примере показан <xref:System.Windows.Controls.GridSplitter> как последний элемент в <xref:System.Windows.Controls.Panel.Children%2A> коллекцию <xref:System.Windows.Controls.Grid>.  
  
 [!code-xaml[GridSplitterSnips#GridSplitterLastChild](~/samples/snippets/csharp/VS_Snippets_Wpf/GridSplitterSnips/CSharp/Window1.xaml#gridsplitterlastchild)]  
  
-   Задайте <xref:System.Windows.Controls.Panel.ZIndexProperty> на <xref:System.Windows.Controls.GridSplitter> будет больше, чем элемент управления, в противном случае будет скрыть его. Следующий пример дает <xref:System.Windows.Controls.GridSplitter> управления выше <xref:System.Windows.Controls.Panel.ZIndexProperty> чем <xref:System.Windows.Controls.Button> элемента управления.  
  
 [!code-xaml[GridSplitterSnips#GridSplitterZIndex](~/samples/snippets/csharp/VS_Snippets_Wpf/GridSplitterSnips/CSharp/Window1.xaml#gridsplitterzindex)]  
  
-   Установка полей элемента управления, в противном случае скроет <xref:System.Windows.Controls.GridSplitter> таким образом, чтобы <xref:System.Windows.Controls.GridSplitter> предоставляется. В следующем примере задается поля на элемент управления, в противном случае будет наложения и скрыть <xref:System.Windows.Controls.GridSplitter>.  
  
 [!code-xaml[GridSplitterSnips#GridSplitterMargin](~/samples/snippets/csharp/VS_Snippets_Wpf/GridSplitterSnips/CSharp/Window1.xaml#gridsplittermargin)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.GridSplitter>
- [Практические руководства](gridsplitter-how-to-topics.md)

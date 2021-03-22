---
title: Практическое руководство. Повышение производительности элемента управления TreeView
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- TreeView control [WPF], improving the performance
ms.assetid: b792c740-cf2b-4da8-8ba8-3d2e5a821874
ms.openlocfilehash: de1b46da2a7c6c3db0c0c19cdbb654fcf2fbbd6c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59153443"
---
# <a name="how-to-improve-the-performance-of-a-treeview"></a>Практическое руководство. Повышение производительности элемента управления TreeView
Если <xref:System.Windows.Controls.TreeView> содержит много элементов, количество времени, затрачиваемого на загрузку может привести к значительной задержке в пользовательском интерфейсе. Можно сократить время загрузки, задав `VirtualizingStackPanel.IsVirtualizing` вложенное свойство, чтобы `true`.  Пользовательский Интерфейс также может медленно реагировать при прокрутке <xref:System.Windows.Controls.TreeView> , используя колесико мыши или перетаскивания ползунка полосы прокрутки. Можно повысить производительность <xref:System.Windows.Controls.TreeView> при прокрутке, задав `VirtualizingStackPanel.VirtualizationMode` вложенное свойство, чтобы <xref:System.Windows.Controls.VirtualizationMode.Recycling?displayProperty=nameWithType>.  
  
## <a name="example"></a>Пример  
  
## <a name="description"></a>Описание  
В следующем примере создается <xref:System.Windows.Controls.TreeView> , задает `VirtualizingStackPanel.IsVirtualizing` присоединенное свойство в значение true и `VirtualizingStackPanel.VirtualizationMode` вложенное свойство, чтобы <xref:System.Windows.Controls.VirtualizationMode.Recycling?displayProperty=nameWithType> для оптимизации производительности.  
  
## <a name="code"></a>Код  
 [!code-xaml[RecycleItemContainerShippets#VirtualizingTreeView](~/samples/snippets/csharp/VS_Snippets_Wpf/RecycleItemContainerShippets/CSharp/Window1.xaml#virtualizingtreeview)]  
  
 В следующем примере показано данные в предыдущем примере.  
  
 [!code-csharp[RecycleItemContainerShippets#TreeViewData](~/samples/snippets/csharp/VS_Snippets_Wpf/RecycleItemContainerShippets/CSharp/Window1.xaml.cs#treeviewdata)]
   
  
## <a name="see-also"></a>См. также

- [Элементы управления](../advanced/optimizing-performance-controls.md)

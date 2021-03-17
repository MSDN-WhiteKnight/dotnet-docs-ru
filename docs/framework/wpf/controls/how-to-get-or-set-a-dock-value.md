---
title: Практическое руководство. Получение или определение значения Dock
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Dock values [WPF], setting
- Dock values [WPF], getting
ms.assetid: fcf4ab8a-c7cd-4835-8d04-de1c999ab4a8
ms.openlocfilehash: fb6c8a7d62aa09a6e1d82cb4079d1425a7f39f8c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59160744"
---
# <a name="how-to-get-or-set-a-dock-value"></a>Практическое руководство. Получение или определение значения Dock
В следующем примере показано, как назначить <xref:System.Windows.Controls.Dock> значение для объекта. В примере используется <xref:System.Windows.Controls.DockPanel.GetDock%2A> и <xref:System.Windows.Controls.DockPanel.SetDock%2A> методы <xref:System.Windows.Controls.DockPanel>.  
  
## <a name="example"></a>Пример  
 В примере создается экземпляр <xref:System.Windows.Controls.TextBlock> элемент, `txt1`и назначает <xref:System.Windows.Controls.Dock> значение `Top` с помощью <xref:System.Windows.Controls.DockPanel.SetDock%2A> метод <xref:System.Windows.Controls.DockPanel>. Затем он устанавливает значение <xref:System.Windows.Controls.Dock> свойства <xref:System.Windows.Controls.TextBlock.Text%2A> из <xref:System.Windows.Controls.TextBlock> элемента с помощью <xref:System.Windows.Controls.DockPanel.GetDock%2A> метод. Наконец, в примере добавляется <xref:System.Windows.Controls.TextBlock> элемент родителю <xref:System.Windows.Controls.DockPanel>, `dp1`.  
  
 [!code-csharp[DockPanelSetDock#1](~/samples/snippets/csharp/VS_Snippets_Wpf/DockPanelSetDock/CSharp/DockPanel_SetDock.cs#1)]
 [!code-vb[DockPanelSetDock#1](~/samples/snippets/visualbasic/VS_Snippets_Wpf/DockPanelSetDock/VisualBasic/DockPanel_SetDock.vb#1)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.DockPanel>
- <xref:System.Windows.Controls.DockPanel.GetDock%2A>
- <xref:System.Windows.Controls.DockPanel.SetDock%2A>
- [Общие сведения о панелях](panels-overview.md)

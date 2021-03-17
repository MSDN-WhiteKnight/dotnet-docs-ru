---
title: Практическое руководство. Отслеживание наведения указателя мыши на элемент ToolStripItem
ms.date: 03/30/2017
helpviewer_keywords:
- toolbars [Windows Forms], detecting mouse movement
- ToolStrip control [Windows Forms], detecting mouse movement
- ToolStripItem class [Windows Forms], detecting mouse movement
- mouse [Windows Forms], detecting movement on toolbars
ms.assetid: d38b5082-aba7-4f6c-841b-bd9714e307fd
ms.openlocfilehash: 09fd9f2f9b8cc44b6c04b829bf2854bea4aa8cf7
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59220050"
---
# <a name="how-to-detect-when-the-mouse-pointer-is-over-a-toolstripitem"></a>Практическое руководство. Отслеживание наведения указателя мыши на элемент ToolStripItem
Используйте следующую процедуру, чтобы определить, когда указатель мыши находится над <xref:System.Windows.Forms.ToolStripItem>.  
  
### <a name="to-detect-when-the-pointer-is-over-a-toolstripitem"></a>Чтобы определить, когда указатель наведен на элемент ToolStripItem  
  
-   Используйте <xref:System.Windows.Forms.ToolStripItem.Selected%2A> свойства для элементов, в котором <xref:System.Windows.Forms.ToolStripItem.CanSelect%2A> является `true`.  
  
     Это избавит вас от необходимости синхронизации <xref:System.Windows.Forms.ToolStripItem.MouseEnter> и <xref:System.Windows.Forms.ToolStripItem.MouseLeave> события.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ToolStripItem>
- <xref:System.Windows.Forms.ToolStripItem.Selected%2A>
- [Общие сведения об элементе управления ToolStrip](toolstrip-control-overview-windows-forms.md)

---
title: Практическое руководство. Разрешение переупорядочения элементов ToolStrip во время выполнения в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- ToolStrip control [Windows Forms], examples
- examples [Windows Forms], toolbars
- toolbars [Windows Forms], rearranging controls
- ToolStrip control [Windows Forms], reordering items
ms.assetid: 8480b69a-379f-4dc2-8dcf-365ed93692b2
ms.openlocfilehash: daff9d6d351db514d552225853f977775f8e3204
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59220413"
---
# <a name="how-to-enable-reordering-of-toolstrip-items-at-run-time-in-windows-forms"></a>Практическое руководство. Разрешение переупорядочения элементов ToolStrip во время выполнения в Windows Forms
Вы можете включить пользователя для изменения порядка <xref:System.Windows.Forms.ToolStripItem> элементов управления в <xref:System.Windows.Forms.ToolStrip>.  
  
### <a name="to-enable-toolstripitem-rearrangement-at-run-time"></a>Для включения элементов ToolStripItem во время выполнения  
  
-   Задайте для свойства <xref:System.Windows.Forms.ToolStrip.AllowItemReorder%2A> значение `true`. По умолчанию <xref:System.Windows.Forms.ToolStrip.AllowItemReorder%2A> является `false`.  
  
     Во время выполнения пользователь удерживает клавишу ALT и левую кнопку мыши для перетаскивания <xref:System.Windows.Forms.ToolStripItem> в другое расположение на <xref:System.Windows.Forms.ToolStrip>.  
  
    ```vb  
    toolStrip1.AllowItemReorder = True  
    ```  
  
    ```csharp  
    toolStrip1.AllowItemReorder = true;  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ToolStrip>
- <xref:System.Windows.Forms.ToolStrip.AllowItemReorder%2A>
- [Общие сведения об элементе управления ToolStrip](toolstrip-control-overview-windows-forms.md)
- [Архитектура элемента управления ToolStrip](toolstrip-control-architecture.md)
- [Технологии, положенные в основу работы элемента управления ToolStrip](toolstrip-technology-summary.md)

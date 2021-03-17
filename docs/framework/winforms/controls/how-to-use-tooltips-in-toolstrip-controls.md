---
title: Практическое руководство. Использование всплывающих подсказок в элементах управления ToolStrip
ms.date: 03/30/2017
helpviewer_keywords:
- ToolStrip control [Windows Forms], adding tooltips
- toolbars [Windows Forms], adding tooltips
- tooltips [Windows Forms], adding
ms.assetid: c5d86024-a7c5-44ee-8b3f-2daf53d80d3e
ms.openlocfilehash: ffaf859fafc87131de525f7bf2f52db421a208c0
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59317003"
---
# <a name="how-to-use-tooltips-in-toolstrip-controls"></a>Практическое руководство. Использование всплывающих подсказок в элементах управления ToolStrip
Можно отобразить <xref:System.Windows.Forms.ToolTip> для <xref:System.Windows.Forms.ToolStrip> элемента управления, присвоив элемента управления <xref:System.Windows.Forms.ToolStrip.ShowItemToolTips%2A> свойства `true`.  
  
### <a name="to-display-a-tooltip"></a>Для отображения всплывающей подсказки  
  
-   Задайте <xref:System.Windows.Forms.ToolStrip.ShowItemToolTips%2A> свойство элемента управления, `true`.  
  
     Значение по умолчанию <xref:System.Windows.Forms.ToolStrip.ShowItemToolTips%2A?displayProperty=nameWithType> — `true`и значение по умолчанию <xref:System.Windows.Forms.MenuStrip.ShowItemToolTips%2A?displayProperty=nameWithType> и <xref:System.Windows.Forms.StatusStrip.ShowItemToolTips%2A?displayProperty=nameWithType> является `false`.  
  
### <a name="to-use-the-tooltiptext-property-for-the-tooltip-text-of-a-toolstripbutton"></a>Чтобы использовать свойство ToolTipText для текста подсказки ToolStripButton  
  
1. Задайте <xref:System.Windows.Forms.ToolStrip.ShowItemToolTips%2A> свойство кнопки `true`.  
  
2. Задайте <xref:System.Windows.Forms.ToolStripButton.AutoToolTip%2A?displayProperty=nameWithType> свойство кнопки `false`.  
  
     `AutoToolTip` Свойство `true` по умолчанию для <xref:System.Windows.Forms.ToolStripButton>, <xref:System.Windows.Forms.ToolStripDropDownButton>, и <xref:System.Windows.Forms.ToolStripSplitButton>.  
  
     Объект <xref:System.Windows.Forms.ToolStripButton> использует его `Text` свойство для <xref:System.Windows.Forms.ToolTip> текст по умолчанию. Эта процедура используется для отображения пользовательского текста в <xref:System.Windows.Forms.ToolStripButton><xref:System.Windows.Forms.ToolTip>.  
  
> [!NOTE]
>  Если задать <xref:System.Windows.Forms.ToolStripItemDisplayStyle> для <xref:System.Windows.Forms.ToolStripItemDisplayStyle.None> или <xref:System.Windows.Forms.ToolStripItemDisplayStyle.Image>, текст не будет отображаться на кнопке, но по-прежнему отображается всплывающая подсказка.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ToolStrip.ShowItemToolTips%2A>
- <xref:System.Windows.Forms.ToolStripButton>
- <xref:System.Windows.Forms.ToolStripDropDownButton>
- <xref:System.Windows.Forms.ToolStripSplitButton>
- [Общие сведения об элементе управления ToolStrip](toolstrip-control-overview-windows-forms.md)

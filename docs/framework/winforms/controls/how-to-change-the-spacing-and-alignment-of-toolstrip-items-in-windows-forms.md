---
title: Практическое руководство. Изменение расстояния между элементами и способа их выравнивания для элемента управления ToolStrip в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- ToolStrip control [Windows Forms], aligning items
- examples [Windows Forms], toolbars
- toolbars [Windows Forms], aligning items
ms.assetid: cd483466-0f49-43df-addf-e2b5fcd64027
ms.openlocfilehash: bed943466348447e30947c170e27027f324342c6
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59323178"
---
# <a name="how-to-change-the-spacing-and-alignment-of-toolstrip-items-in-windows-forms"></a>Практическое руководство. Изменение расстояния между элементами и способа их выравнивания для элемента управления ToolStrip в Windows Forms
<xref:System.Windows.Forms.ToolStrip> Управления полностью поддерживает функции макета, такие как определения размера, расстояние между <xref:System.Windows.Forms.ToolStripItem> элементов управления относительно друг друга, размещения элементов управления в <xref:System.Windows.Forms.ToolStrip>и расстояние между элементами управления <xref:System.Windows.Forms.ToolStrip>.  
  
 Так как значение по умолчанию <xref:System.Windows.Forms.ToolStripItem.AutoSize%2A> свойство `true`, элементов управления изменяются автоматически, если не задать <xref:System.Windows.Forms.ToolStripItem.AutoSize%2A> свойства `false`.  
  
### <a name="to-manually-size-a-toolstripitem"></a>Чтобы вручную размер ToolStripItem  
  
1. Задайте <xref:System.Windows.Forms.ToolStripItem.AutoSize%2A> свойства `false` для сопоставленного элемента управления.  
  
    ```vb  
    ToolStripButton1.AutoSize = False  
    ```  
  
    ```csharp  
    toolStripButton1.AutoSize = false;  
    ```  
  
2. Задайте <xref:System.Windows.Forms.ToolStripItem.Size%2A> свойства, как нужно для связанного <xref:System.Windows.Forms.ToolStripItem>.  
  
### <a name="to-set-the-spacing-of-a-toolstripitem"></a>Чтобы задать расстояние между ToolStripItem  
  
1. Вставьте нужные значения в пикселях <xref:System.Windows.Forms.ToolStripItem.Margin%2A> свойства сопоставленного элемента управления.  
  
     Значения <xref:System.Windows.Forms.ToolStripItem.Margin%2A> свойства укажите расстояние между элементом и соседними элементами в следующем порядке: Слева, сверху, справа и нижней.  
  
    ```vb  
    ToolStripTextBox1.Margin = New System.Windows.Forms.Padding _  
        (3, 0, 3, 0)  
    ```  
  
    ```csharp  
    toolStripTextBox1.Margin = new System.Windows.Forms.Padding   
        (3, 0, 3, 0);  
    ```  
  
### <a name="to-align-a-toolstripitem-to-the-right-side-of-the-toolstrip"></a>Чтобы выровнять ToolStripItem в правой части панели инструментов  
  
1. Задайте <xref:System.Windows.Forms.ToolStripItem.Alignment%2A> свойства <xref:System.Windows.Forms.ToolStripItemAlignment.Right> для сопоставленного элемента управления. По умолчанию <xref:System.Windows.Forms.ToolStripItem.Alignment%2A> присваивается <xref:System.Windows.Forms.ToolStripItemAlignment.Left>, который элементы управления выравниваются по левому краю <xref:System.Windows.Forms.ToolStrip>.  
  
    ```vb  
    ToolStripSplitButton1.Alignment = _  
        System.Windows.Forms.ToolStripItemAlignment.Right  
    ```  
  
    ```csharp  
    toolStripSplitButton1.Alignment =   
        System.Windows.Forms.ToolStripItemAlignment.Right;  
    ```  
  
### <a name="to-arrange-toolstrip-items-on-the-toolstrip"></a>Чтобы упорядочить элементы ToolStrip на панели инструментов  
  
-   Задайте <xref:System.Windows.Forms.ToolStrip.LayoutStyle%2A> свойства к значению <xref:System.Windows.Forms.ToolStripLayoutStyle> нужную.  
  
    ```vb  
    ToolStripDropDown1.LayoutStyle = _  
        System.Windows.Forms.ToolStripLayoutStyle.Flow  
    ```  
  
    ```csharp  
    toolStripDropDown1.LayoutStyle =   
        System.Windows.Forms.ToolStripLayoutStyle.Flow;  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ToolStrip>
- <xref:System.Windows.Forms.Control.Layout>
- <xref:System.Windows.Forms.ToolStrip.LayoutCompleted>
- <xref:System.Windows.Forms.ToolStrip.LayoutSettings%2A>
- <xref:System.Windows.Forms.ToolStripItem.TextImageRelation%2A>
- <xref:System.Windows.Forms.ToolStripItem.Placement%2A>
- <xref:System.Windows.Forms.ToolStrip.CanOverflow%2A>
- [Общие сведения об элементе управления ToolStrip](toolstrip-control-overview-windows-forms.md)
- [Архитектура элемента управления ToolStrip](toolstrip-control-architecture.md)
- [Технологии, положенные в основу работы элемента управления ToolStrip](toolstrip-technology-summary.md)

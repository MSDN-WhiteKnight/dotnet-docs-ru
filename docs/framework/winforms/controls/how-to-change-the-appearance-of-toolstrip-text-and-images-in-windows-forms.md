---
title: Практическое руководство. Изменение внешнего вида текста и изображений элемента управления ToolStrip в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- ToolStrip control [Windows Forms], appearance
- toolbars [Windows Forms], images
- examples [Windows Forms], toolbars
- toolbars [Windows Forms], appearance
- ToolStrip control [Windows Forms], images
- ToolStrip control [Windows Forms], text
- toolbars [Windows Forms], text
ms.assetid: d62dc9d1-2edd-4dfa-aed7-1335d6e13d86
ms.openlocfilehash: 5c326c8f6a56c934d317305f85f4c88e95e75f8b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59088487"
---
# <a name="how-to-change-the-appearance-of-toolstrip-text-and-images-in-windows-forms"></a>Практическое руководство. Изменение внешнего вида текста и изображений элемента управления ToolStrip в Windows Forms
Можно управлять, отображаются ли текст и изображения на <xref:System.Windows.Forms.ToolStripItem> и как они выравниваются относительно друг друга и <xref:System.Windows.Forms.ToolStrip>.  
  
### <a name="to-define-what-is-displayed-on-a-toolstripitem"></a>Чтобы определить, отображаемые на ToolStripItem  
  
-   Задайте <xref:System.Windows.Forms.ToolStripItem.DisplayStyle%2A> свойство нужное значение. Возможные значения — `Image`, `ImageAndText`, `None`, и `Text`. Значение по умолчанию — `ImageAndText`.  
  
    ```vb  
    ToolStripButton2.DisplayStyle = _  
        System.Windows.Forms.ToolStripItemDisplayStyle.Image  
    ```  
  
    ```csharp  
    toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;  
    ```  
  
### <a name="to-align-text-on-a-toolstripitem"></a>Для выравнивания текста на ToolStripItem  
  
-   Задайте <xref:System.Windows.Forms.ToolStripItem.TextAlign%2A> свойство нужное значение. Возможные значения — любое сочетание сверху "," Средний "и" нижний left, center и right. Значение по умолчанию — `MiddleCenter`.  
  
    ```vb  
    ToolStripSplitButton1.TextAlign = _  
        System.Drawing.ContentAlignment.MiddleRight  
    ```  
  
    ```csharp  
    toolStripSplitButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;  
    ```  
  
### <a name="to-align-an-image-on-a-toolstripitem"></a>Чтобы выровнять изображение на ToolStripItem  
  
-   Задайте <xref:System.Windows.Forms.ToolStripItem.ImageAlign%2A> свойство нужное значение. Возможные значения — любое сочетание сверху "," Средний "и" нижний left, center и right. Значение по умолчанию — `MiddleLeft`.  
  
    ```vb  
    ToolStripSplitButton1.ImageAlign = _  
        System.Drawing.ContentAlignment.MiddleRight  
    ```  
  
    ```csharp  
    toolStripSplitButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;  
    ```  
  
### <a name="to-define-how-toolstripitem-text-and-images-are-displayed-relative-to-each-other"></a>Чтобы определить способ отображения выравниванием текста и изображения относительно друг друга  
  
-   Задайте <xref:System.Windows.Forms.ToolStripItem.TextImageRelation%2A> свойство нужное значение. Возможные значения — `ImageAboveText`, `ImageBeforeText`, `Overlay`, `TextAboveImage`, и `TextBeforeImage`. Значение по умолчанию — `ImageBeforeText`.  
  
    ```vb  
    ToolStripButton1.TextImageRelation = _  
        System.Windows.Forms.TextImageRelation.ImageAboveText  
    ```  
  
    ```csharp  
    toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ToolStrip>
- [Общие сведения об элементе управления ToolStrip](toolstrip-control-overview-windows-forms.md)
- [Архитектура элемента управления ToolStrip](toolstrip-control-architecture.md)
- [Технологии, положенные в основу работы элемента управления ToolStrip](toolstrip-technology-summary.md)

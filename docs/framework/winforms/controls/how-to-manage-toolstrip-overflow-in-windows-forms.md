---
title: Практическое руководство. Управление переполнения элемента управления ToolStrip в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- ToolStrip control [Windows Forms], managing overflow
- toolbars [Windows Forms], managing overflow
- examples [Windows Forms], toolbars
- CanOverflow property
ms.assetid: fa10e0ad-4cbf-4c0d-9082-359c2f855d4e
ms.openlocfilehash: 53f610a728925d454a8833a49e705818f027aec5
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57707278"
---
# <a name="how-to-manage-toolstrip-overflow-in-windows-forms"></a>Практическое руководство. Управление переполнения элемента управления ToolStrip в Windows Forms

Когда все элементы на <xref:System.Windows.Forms.ToolStrip> управления не помещаются в отведенное место, возможность переполнения можно включить на <xref:System.Windows.Forms.ToolStrip> и определить поведение определенных <xref:System.Windows.Forms.ToolStripItem>s.

При добавлении <xref:System.Windows.Forms.ToolStripItem>, которые занимают больше места, выделенного для <xref:System.Windows.Forms.ToolStrip> текущий размер формы, <xref:System.Windows.Forms.ToolStripOverflowButton> автоматически отображается на <xref:System.Windows.Forms.ToolStrip>. <xref:System.Windows.Forms.ToolStripOverflowButton> Появляется, и поддержкой переполнения элементы перемещаются в меню переполнения раскрывающегося списка. Это позволяет настраивать и определять их приоритеты как вашей <xref:System.Windows.Forms.ToolStrip> элементы соответствии с изменением размеров формы. Можно также изменить внешний вид элементов, когда они переходят в области переполнения с помощью <xref:System.Windows.Forms.ToolStripItem.Placement%2A> и <xref:System.Windows.Forms.ToolStripOverflow.DisplayedItems%2A?displayProperty=nameWithType> свойства и <xref:System.Windows.Forms.ToolStrip.LayoutCompleted> событий. Если вы увеличите формы во время разработки или во время выполнения, более <xref:System.Windows.Forms.ToolStripItem>s могут быть отображены на основном <xref:System.Windows.Forms.ToolStrip> и <xref:System.Windows.Forms.ToolStripOverflowButton> исчезать даже в том случае, пока не уменьшить размер формы.

## <a name="to-enable-overflow-on-a-toolstrip-control"></a>Включение переполнения для элемента управления ToolStrip

- Убедитесь, что <xref:System.Windows.Forms.ToolStrip.CanOverflow%2A> не задано значение `false` для <xref:System.Windows.Forms.ToolStrip>. Значение по умолчанию — `True`.

     Когда <xref:System.Windows.Forms.ToolStrip.CanOverflow%2A> является `True` (по умолчанию), <xref:System.Windows.Forms.ToolStripItem> отправляется в меню переполнения раскрывающегося списка при содержание <xref:System.Windows.Forms.ToolStripItem> превышает ширину горизонтального <xref:System.Windows.Forms.ToolStrip> или высоту вертикального <xref:System.Windows.Forms.ToolStrip>.

## <a name="to-specify-overflow-behavior-of-a-specific-toolstripitem"></a>Чтобы указать поведение при переполнении отдельного элемента ToolStripItem

- Задайте <xref:System.Windows.Forms.ToolStripItem.Overflow%2A> свойство <xref:System.Windows.Forms.ToolStripItem> нужное значение. Возможные значения — `Always`, `Never`, и `AsNeeded`. Значение по умолчанию — `AsNeeded`.

    ```vb
    toolStripTextBox1.Overflow = _
    System.Windows.Forms.ToolStripItemOverflow.Never
    ```

    ```csharp
    toolStripTextBox1.Overflow = _
    System.Windows.Forms.ToolStripItemOverflow.Never;
    ```

## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ToolStrip>
- <xref:System.Windows.Forms.ToolStripOverflowButton>
- <xref:System.Windows.Forms.ToolStripItem.Overflow%2A>
- <xref:System.Windows.Forms.ToolStrip.CanOverflow%2A>
- [Общие сведения об элементе управления ToolStrip](toolstrip-control-overview-windows-forms.md)
- [Архитектура элемента управления ToolStrip](toolstrip-control-architecture.md)
- [Технологии, положенные в основу работы элемента управления ToolStrip](toolstrip-technology-summary.md)

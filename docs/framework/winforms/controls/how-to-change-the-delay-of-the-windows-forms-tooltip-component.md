---
title: Практическое руководство. Изменение значения задержки для компонента ToolTip в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- ToolTip component [Windows Forms], delay values
- tooltips [Windows Forms], delay values
- examples [Windows Forms], tooltips
ms.assetid: 08979ba7-dd84-477b-ab17-8d06e759be99
ms.openlocfilehash: cf257cccd272c16c3d7c3d403456265444fc8ac8
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59345486"
---
# <a name="how-to-change-the-delay-of-the-windows-forms-tooltip-component"></a>Практическое руководство. Изменение значения задержки для компонента ToolTip в Windows Forms
Существует несколько значений задержки, которые можно задать для форм Windows <xref:System.Windows.Forms.ToolTip> компонента. Единица измерения для этих свойств — миллисекунд. <xref:System.Windows.Forms.ToolTip.InitialDelay%2A> Свойство определяет, как долго пользователь должен указывать на элементом управления, чтобы появилась строка подсказки. <xref:System.Windows.Forms.ToolTip.ReshowDelay%2A> Свойство задает время в миллисекундах, затрачиваемое последующие строки подсказки будут выводиться при перемещении мыши от одного элемента управления связанный всплывающей подсказки в другой. <xref:System.Windows.Forms.ToolTip.AutoPopDelay%2A> Определяет продолжительность времени, строки всплывающей подсказки. Эти значения можно задать по отдельности, или установив значение <xref:System.Windows.Forms.ToolTip.AutomaticDelay%2A> свойство; другие свойства задаются с учетом на значение, присваиваемое задержка <xref:System.Windows.Forms.ToolTip.AutomaticDelay%2A> свойство. Например, если <xref:System.Windows.Forms.ToolTip.AutomaticDelay%2A> присваивается значение N, <xref:System.Windows.Forms.ToolTip.InitialDelay%2A> имеет значение N, <xref:System.Windows.Forms.ToolTip.ReshowDelay%2A> присваивается значение <xref:System.Windows.Forms.ToolTip.AutomaticDelay%2A> деленное на пять (или N/5), и <xref:System.Windows.Forms.ToolTip.AutoPopDelay%2A> присваивается значение, пять раз значение <xref:System.Windows.Forms.ToolTip.AutomaticDelay%2A> свойство (или 5N).  
  
### <a name="to-set-the-delay"></a>Чтобы задать задержку  
  
1. Задайте следующие свойства, как показано в следующем примере.  
  
    ```vb  
    ToolTip1.InitialDelay = 500  
    ToolTip1.ReshowDelay = 100  
    ToolTip1.AutoPopDelay = 5000  
    ```  
  
    ```csharp  
    ToolTip1.InitialDelay = 500;  
    ToolTip1.ReshowDelay = 100;  
    ToolTip1.AutoPopDelay = 5000;  
    ```  
  
    ```cpp  
    toolTip1->InitialDelay = 500;  
    toolTip1->ReshowDelay = 100;  
    toolTip1->AutoPopDelay = 5000;  
    ```  
  
## <a name="see-also"></a>См. также

- [Общие сведения об элементе управления ToolTip](tooltip-component-overview-windows-forms.md)
- [Практическое руководство. Определение всплывающих подсказок для элементов управления в Windows Forms во время разработки](how-to-set-tooltips-for-controls-on-a-windows-form-at-design-time.md)
- [Компонент ToolTip](tooltip-component-windows-forms.md)

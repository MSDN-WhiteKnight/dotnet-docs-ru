---
title: Общие сведения об элементах управления HScrollBar и VScrollBar (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- HScrollBar
- VScrollBar
helpviewer_keywords:
- ScrollBar control [Windows Forms]
- HScrollBar control [Windows Forms], about HScrollBar
- VScrollBar control [Windows Forms], about VScrollBar control
- ScrollBar control [Windows Forms], about ScrollBar control
- scroll bars [Windows Forms], about scroll bars
ms.assetid: 8b307679-1cae-41d8-99aa-3d1efd207cd6
ms.openlocfilehash: d4a7912a5781fc583357affa728f7d81059b5cf9
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59097321"
---
# <a name="hscrollbar-and-vscrollbar-controls-overview-windows-forms"></a>Общие сведения об элементах управления HScrollBar и VScrollBar (Windows Forms)
Windows Forms <xref:System.Windows.Forms.ScrollBar> элементы управления используются для обеспечения удобного просмотра длинных списков элементов или большого объема информации с либо горизонтальной или вертикальной прокрутки окна приложения либо элемента управления. Полосы прокрутки — это распространенный элемент интерфейса Windows, поэтому <xref:System.Windows.Forms.ScrollBar> управления часто используется с элементами управления, которые не являются производными от <xref:System.Windows.Forms.ScrollableControl> класса. Аналогично, многие разработчики решили внедрить <xref:System.Windows.Forms.ScrollBar> управления собственных пользовательских элементов управления.  
  
 <xref:System.Windows.Forms.HScrollBar> (По горизонтали) и <xref:System.Windows.Forms.VScrollBar> (по вертикали) элементы управления, работать независимо от других элементов управления и имеют свой собственный набор событий, свойств и методов. <xref:System.Windows.Forms.ScrollBar> элементы управления не совпадает с встроенными полосами прокрутки, прикрепленных к текстовые поля, списки, поля со списком или MDI-форм ( <xref:System.Windows.Forms.TextBox> элемент управления имеет <xref:System.Windows.Forms.TextBox.ScrollBars%2A> свойство для отображения или скрытия полос прокрутки, прикрепленных к элементу управления).  
  
 <xref:System.Windows.Forms.ScrollBar> Элементы управления используют <xref:System.Windows.Forms.ScrollBar.Scroll> событие для наблюдения за перемещение ползунка полосы прокрутки (иногда называется бегунком) вдоль полосы прокрутки. С помощью <xref:System.Windows.Forms.ScrollBar.Scroll> событий предоставляет доступ к строке значение прокрутки, как он перетаскивается.  
  
## <a name="value-property"></a>Свойство Value  
 <xref:System.Windows.Forms.ScrollBar.Value%2A> Свойство (которое по умолчанию равно 0) является `integer` значение, соответствующее положение ползунка полосы прокрутки в полосе прокрутки. Когда положения минимальное значение, он перемещается крайняя левая позиция (на горизонтальной полосе прокрутки) или положение верхнего края (на вертикальной полосе прокрутки). Если ползунок полосы прокрутки находится в максимальное значение, крайнего правого ползунка или нижнее положение. Аналогичным образом значение в середине диапазона между минимальным и максимальным пределами помещает передней границы ползунка полосы прокрутки в середину полосы прокрутки.  
  
 Помимо использования щелчков мыши для изменения значения панель прокрутки, пользователь также можно перетащить ползунок полосы прокрутки на любой момент на полосе. Результирующее значение зависит от положения ползунка полосы прокрутки, но он всегда находится в диапазоне <xref:System.Windows.Forms.ScrollBar.Minimum%2A> для <xref:System.Windows.Forms.ScrollBar.Maximum%2A> свойства, заданные пользователем.  
  
## <a name="largechange-and-smallchange-properties"></a>LargeChange и SmallChange свойства  
 Когда пользователь нажимает клавишу PAGE UP или PAGE DOWN или щелкает в дорожки полосы прокрутки с обеих сторон ползунка полосы прокрутки, <xref:System.Windows.Forms.ScrollBar.Value%2A> изменения свойств в соответствии с значением <xref:System.Windows.Forms.ScrollBar.LargeChange%2A> свойство.  
  
 Когда пользователь нажимает одну стрелки стрелками или нажимает одну из кнопок полосы прокрутки, <xref:System.Windows.Forms.ScrollBar.Value%2A> изменения свойств в соответствии с значением <xref:System.Windows.Forms.ScrollBar.SmallChange%2A> свойство.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.HScrollBar>
- <xref:System.Windows.Forms.VScrollBar>
- [Элементы управления для использования в формах Windows Forms](controls-to-use-on-windows-forms.md)

---
title: Общие сведения об элементе управления Panel (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- Panel
helpviewer_keywords:
- grouping controls [Windows Forms], Panel control
- Panel control [Windows Forms], about Panel control
ms.assetid: b6b83636-2c39-4dad-89d6-f0fa41049a74
ms.openlocfilehash: d4976b3725d04162ac10242c486f57c4d2598769
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59086368"
---
# <a name="panel-control-overview-windows-forms"></a>Общие сведения об элементе управления Panel (Windows Forms)
Windows Forms <xref:System.Windows.Forms.Panel> элементы управления используются для предоставления возможность идентифицируемой группировки других элементов управления. Как правило панели используются для разделения формы функцией. Например возможно с формой заказа, указаны параметры доставки почты ночное для использования. Объединение всех параметров панели предоставляет пользователю логическую визуальную подсказку. В режиме разработки все элементы управления можно легко переместить — при перемещении <xref:System.Windows.Forms.Panel> контролируете, все его вложенные элементы управления. Элементы управления, сгруппированные на панели можно получить с помощью его <xref:System.Windows.Forms.Control.Controls%2A> свойство. Это свойство возвращает коллекцию <xref:System.Windows.Forms.Control> экземпляров, поэтому обычно необходимо будет привести элемент управления полученный таким образом, для ее определенного типа.  
  
## <a name="panel-versus-groupbox"></a>Панель и GroupBox  
 <xref:System.Windows.Forms.Panel> Управления аналогичен <xref:System.Windows.Forms.GroupBox> управления; тем не менее, только <xref:System.Windows.Forms.Panel> элемент управления может иметь полосы прокрутки и только <xref:System.Windows.Forms.GroupBox> управления отображается заголовок.  
  
## <a name="key-properties"></a>Ключевые свойства  
 Чтобы отобразить полосы прокрутки, задайте <xref:System.Windows.Forms.ScrollableControl.AutoScroll%2A> свойства `true`. Также можно настроить внешний вид панели, задав <xref:System.Windows.Forms.Control.BackColor%2A>, <xref:System.Windows.Forms.Control.BackgroundImage%2A>, и <xref:System.Windows.Forms.Panel.BorderStyle%2A> свойства. Дополнительные сведения о <xref:System.Windows.Forms.Control.BackColor%2A> и <xref:System.Windows.Forms.Control.BackgroundImage%2A> свойства, см. в разделе [как: Меняем цвет фона панели](how-to-set-the-background-of-a-windows-forms-panel.md). <xref:System.Windows.Forms.Panel.BorderStyle%2A> Свойство определяет, если панели описан с видимая граница отсутствует (<xref:System.Windows.Forms.BorderStyle.None>), простой линии (<xref:System.Windows.Forms.BorderStyle.FixedSingle>), или строку замещенных (<xref:System.Windows.Forms.BorderStyle.Fixed3D>).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Panel>
- [Элемент управления GroupBox](groupbox-control-windows-forms.md)
- [Практическое руководство. Группирование элементов управление с элементом управления Panel в формах Windows Forms с помощью конструктора](group-controls-with-wf-panel-control-using-the-designer.md)
- [Практическое руководство. Установка фона панели формы Windows Forms с помощью конструктора](how-to-set-the-background-of-a-windows-forms-panel-using-the-designer.md)

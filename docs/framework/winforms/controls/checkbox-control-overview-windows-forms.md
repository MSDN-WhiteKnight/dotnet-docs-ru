---
title: Общие сведения об элементе управления CheckBox (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- CheckBox
helpviewer_keywords:
- CheckBox control [Windows Forms], about CheckBox control
- data binding [Windows Forms], checkbox controls
- check boxes [Windows Forms], about check boxes
ms.assetid: 085a4e0b-9046-473f-b141-d0edddfb2ebb
ms.openlocfilehash: 2a18327d9836d1dbbcd5d5d6e73f217637736d20
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59121801"
---
# <a name="checkbox-control-overview-windows-forms"></a>Общие сведения об элементе управления CheckBox (Windows Forms)
Элемент управления <xref:System.Windows.Forms.CheckBox> Windows Forms указывает, включено или отключено какое-либо условие. Обычно он используется для предоставления пользователю выбора типа "Да/Нет" или "Истина/Ложь". Элементы управления типа "флажок" можно объединять в группы для предоставления нескольких вариантов ответа, из которых пользователь может выбрать один или несколько.  
  
 Элемент управления "флажок" аналогична элемент управления переключателя в том, что каждый используется для указания выбора, сделанного пользователем. Они отличаются, в которые одновременно можно выбрать только один переключатель в группе. Тем не менее, с помощью элемента управления "флажок" любое количество флажки может быть выбран.  
  
 Типа "флажок" может быть подключен к элементам в базе данных с помощью простой привязки данных. Можно объединить несколько флажков с помощью <xref:System.Windows.Forms.GroupBox> элемента управления. Это полезно для внешний вид, а также по разработке пользовательского интерфейса, так как сгруппированных элементов управления можно перемещать одновременно в конструкторе форм. Дополнительные сведения см. в разделе [привязки данных Windows Forms](../windows-forms-data-binding.md) и [управления GroupBox](groupbox-control-windows-forms.md).  
  
 <xref:System.Windows.Forms.CheckBox> Элемент управления имеет два важных свойства <xref:System.Windows.Forms.CheckBox.Checked%2A> и <xref:System.Windows.Forms.CheckBox.CheckState%2A>. <xref:System.Windows.Forms.CheckBox.Checked%2A> Свойство возвращает либо `true` или `false`. <xref:System.Windows.Forms.CheckBox.CheckState%2A> Свойство возвращает либо <xref:System.Windows.Forms.CheckState.Checked> или <xref:System.Windows.Forms.CheckState.Unchecked>; или, если <xref:System.Windows.Forms.CheckBox.ThreeState%2A> свойству `true`, <xref:System.Windows.Forms.CheckBox.CheckState%2A> могут также возвращать <xref:System.Windows.Forms.CheckState.Indeterminate>. В неопределенном состоянии поле отображается затененным, чтобы указать, что этот параметр недоступен.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.CheckBox>
- [Практическое руководство. Задание параметров с помощью элементов управления CheckBox в Windows Forms](how-to-set-options-with-windows-forms-checkbox-controls.md)
- [Практическое руководство. Обработка события щелчка элемента управления CheckBox в Windows Forms](how-to-respond-to-windows-forms-checkbox-clicks.md)
- [Элемент управления CheckBox](checkbox-control-windows-forms.md)

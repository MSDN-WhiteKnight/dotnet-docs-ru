---
title: Общие сведения об элементе управления RadioButton (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- RadioButton
helpviewer_keywords:
- RadioButton control [Windows Forms], about RadioButton control
- RadioButton control [Windows Forms], determining state
- radio buttons [Windows Forms], determining state
- radio buttons [Windows Forms], about radio buttons
ms.assetid: cd11f0c2-d098-4022-adf9-1455bc166a13
ms.openlocfilehash: 1210658226d9bcacbf4904fdc90a9908c34f5b73
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59129120"
---
# <a name="radiobutton-control-overview-windows-forms"></a>Общие сведения об элементе управления RadioButton (Windows Forms)
Windows Forms <xref:System.Windows.Forms.RadioButton> элементов управления пользователь получает набор из двух или более взаимоисключающих вариантов. Переключатели и флажки могут показаться работают так же, является важным отличием: при выборе типа "переключатель", другие переключатели в той же группе, не могут быть выбраны также. Напротив можно выбрать любое количество флажки. Сообщает пользователю, определив группу переключателей, «Вот набор вариантов, которые можно выбрать один и только один».  
  
## <a name="using-the-control"></a>Использование элемента управления  
 Когда <xref:System.Windows.Forms.RadioButton> нажатии элемента управления, его <xref:System.Windows.Forms.RadioButton.Checked%2A> свойству `true` и <xref:System.Windows.Forms.Control.Click> вызывается обработчик события. <xref:System.Windows.Forms.RadioButton.CheckedChanged> События при значение <xref:System.Windows.Forms.RadioButton.Checked%2A> изменения свойств. Если <xref:System.Windows.Forms.RadioButton.AutoCheck%2A> свойству `true` (по умолчанию), если выбран переключатель всем другим элементам в группе очищаются автоматически. Это свойство обычно имеет значение только в `false` при использовании кода проверки для убедитесь, что этот переключатель — это допустимый параметр. Текст, отображаемый в элементе управления задается с помощью <xref:System.Windows.Forms.Control.Text%2A> свойство, которое может содержать клавиши быстрого доступа. Ключ доступа позволяет пользователю «click» элемента управления с помощью клавиши ALT ключом доступа. Дополнительные сведения см. в разделе [Как Определение клавиш доступа для Windows Forms, элементы управления](how-to-create-access-keys-for-windows-forms-controls.md) и [как: Задать текст, отображаемый элементом управления форм Windows](how-to-set-the-text-displayed-by-a-windows-forms-control.md).  
  
 <xref:System.Windows.Forms.RadioButton> Может отображаться как кнопка команд, который отображается при выбранном, если элемент управления <xref:System.Windows.Forms.RadioButton.Appearance%2A> свойству <xref:System.Windows.Forms.Appearance.Button>. Переключатели также можно выводить изображения с использованием <xref:System.Windows.Forms.ButtonBase.Image%2A> и <xref:System.Windows.Forms.ButtonBase.ImageList%2A> свойства. Дополнительные сведения см. в разделе [Как Задайте изображения, отображаемого элементом управления форм Windows](how-to-set-the-image-displayed-by-a-windows-forms-control.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.RadioButton>
- [Общие сведения об элементе управления Panel](panel-control-overview-windows-forms.md)
- [Общие сведения об элементе управления GroupBox](groupbox-control-overview-windows-forms.md)
- [Общие сведения об элементе управления CheckBox](checkbox-control-overview-windows-forms.md)
- [Практическое руководство. Определение клавиш доступа для элементов управления Windows Forms](how-to-create-access-keys-for-windows-forms-controls.md)
- [Практическое руководство. Определение текста, отображаемого элементом управления Windows Forms](how-to-set-the-text-displayed-by-a-windows-forms-control.md)
- [Практическое руководство. Создание переключателя для выбора одной из нескольких установок на базе элементов управления RadioButton в Windows Forms](how-to-group-windows-forms-radiobutton-controls-to-function-as-a-set.md)
- [Элемент управления RadioButton](radiobutton-control-windows-forms.md)

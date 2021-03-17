---
title: Общие сведения об элементе управления Button (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- Button
helpviewer_keywords:
- Button control [Windows Forms], about Button control
- buttons [Windows Forms], about buttons
ms.assetid: 255b291b-51a9-4a92-a1a4-2400cd82443f
ms.openlocfilehash: 1ded871fdfab83407d8022ca0c4ce6b2c8a6c67c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59076553"
---
# <a name="button-control-overview-windows-forms"></a>Общие сведения об элементе управления Button (Windows Forms)
Элемент управления Windows Forms <xref:System.Windows.Forms.Button> позволяет пользователю щелкнуть его для выполнения действия. При щелчке кнопки мышью элемент управления выглядит так, как будто его нажимают и отпускают. Каждый раз, когда пользователь нажимает кнопку, <xref:System.Windows.Forms.Control.Click> вызывается обработчик событий. Поместите код в <xref:System.Windows.Forms.Control.Click> обработчик событий может выполнять любые действия.  
  
 Текст, отображаемый на кнопке, содержащийся в <xref:System.Windows.Forms.Control.Text%2A> свойство. Если текста превышает ширину кнопки, он переходит на следующую строку. Тем не менее он будет обрезана, если элемент управления не может вместить высота. Дополнительные сведения см. в разделе [Как Задать текст, отображаемый элементом управления форм Windows](how-to-set-the-text-displayed-by-a-windows-forms-control.md). <xref:System.Windows.Forms.Control.Text%2A> Свойство может содержать ключ доступа, который позволяет пользователю «click» элемента управления с помощью клавиши ALT ключом доступа. Подробную информацию см. в разделе [Практическое руководство. Определение клавиш доступа для Windows Forms, элементы управления](how-to-create-access-keys-for-windows-forms-controls.md). Внешний вид текста определяется <xref:System.Windows.Forms.Control.Font%2A> свойство и <xref:System.Windows.Forms.ButtonBase.TextAlign%2A> свойство.  
  
 <xref:System.Windows.Forms.Button> Управления также можно выводить изображения с использованием <xref:System.Windows.Forms.ButtonBase.Image%2A> и <xref:System.Windows.Forms.ButtonBase.ImageList%2A> свойства. Дополнительные сведения см. в разделе [Как Задайте изображения, отображаемого элементом управления форм Windows](how-to-set-the-image-displayed-by-a-windows-forms-control.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Button>
- [Практическое руководство. Обработка события нажатия кнопки в Windows Forms](how-to-respond-to-windows-forms-button-clicks.md)
- [Способы активации элемента управления Button в Windows Forms](ways-to-select-a-windows-forms-button-control.md)
- [Практическое руководство. Создание кнопки принятия в формах Windows Forms с помощью конструктора](designate-a-wf-button-as-the-accept-button-using-the-designer.md)
- [Практическое руководство. Создание кнопки отмены в формах Windows Forms с помощью конструктора](designate-a-wf-button-as-the-cancel-button-using-the-designer.md)
- [Элемент управления Button](button-control-windows-forms.md)

---
title: Элемент управления DomainUpDown (Windows Forms)
ms.date: 03/30/2017
helpviewer_keywords:
- DomainUpDown control [Windows Forms]
- spin button control [Windows Forms], up-down controls
- up-down controls
- spin button control
- up-down controls [Windows Forms], spin button controls
ms.assetid: fb7cf017-e931-4a95-9d21-8caee4ee122a
ms.openlocfilehash: 83d674e3fb7ff7e715b75c635b891cd4e9703a21
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57704547"
---
# <a name="domainupdown-control-windows-forms"></a>Элемент управления DomainUpDown (Windows Forms)
Windows Forms <xref:System.Windows.Forms.DomainUpDown> элемент управления выглядит как сочетание текстового поля и пары кнопок для перемещения вверх или вниз по списку. Он выводит и задает строку текста из списка вариантов. Пользователь может выбрать строки, щелкнув кнопок со стрелками вверх по списку, клавиши со стрелками вверх и вниз или введя строку, совпадающую с элементом в списке. Один из возможных способов использования для этого элемента управления можно выбрать элементы в алфавитном порядке отсортированный список имен. (Чтобы отсортировать список, установите <xref:System.Windows.Forms.DomainUpDown.Sorted%2A> свойства `true`.) Функция этого элемента управления является очень похожа на поле со списком или поле со списком, но занимает очень мало места.  
  
 Ключевые свойства элемента управления являются <xref:System.Windows.Forms.DomainUpDown.Items%2A>, <xref:System.Windows.Forms.UpDownBase.ReadOnly%2A>, и <xref:System.Windows.Forms.DomainUpDown.Wrap%2A>. <xref:System.Windows.Forms.DomainUpDown.Items%2A> Свойство содержит список объектов, текстовые значения отображаются в элементе управления. Если <xref:System.Windows.Forms.UpDownBase.ReadOnly%2A> присваивается `false`, элемент управления автоматически завершает текст, пользователь и сопоставляет его значение в списке. Если <xref:System.Windows.Forms.DomainUpDown.Wrap%2A> присваивается `true`, прокрутка пройден последний элемент, можно перейти первый элемент в списке и наоборот. Основные методы элемента управления являются <xref:System.Windows.Forms.DomainUpDown.UpButton%2A> и <xref:System.Windows.Forms.DomainUpDown.DownButton%2A>.  
  
 Этот элемент управления отображает только текстовые строки. Элемент управления, отображающий числовые значения, используйте <xref:System.Windows.Forms.NumericUpDown> элемента управления. Дополнительные сведения см. в разделе [элемент управления NumericUpDown](numericupdown-control-windows-forms.md) .  
  
## <a name="in-this-section"></a>В этом разделе  
 [Общие сведения об элементе управления DomainUpDown](domainupdown-control-overview-windows-forms.md)  
 Основные понятия <xref:System.Windows.Forms.DomainUpDown> управления, который позволяет пользователям просматривать и выбирать из списка текстовых строк.  
  
 [Практическое руководство. Добавление элементов управления DomainUpDown Windows Forms программными средствами](how-to-add-items-to-windows-forms-domainupdown-controls-programmatically.md)  
 Описывает способ задания текстовых строк <xref:System.Windows.Forms.DomainUpDown> элемент управления должен отображать.  
  
 [Практическое руководство. Удаление элементов из элемента управления DomainUpDown Windows Forms](how-to-remove-items-from-windows-forms-domainupdown-controls.md)  
 Описывает удаление элементов из <xref:System.Windows.Forms.DomainUpDown> элемента управления в коде.  
  
## <a name="reference"></a>Ссылка  
 <xref:System.Windows.Forms.DomainUpDown>  
 Описание класса и всех его членов.  
  
 <xref:System.Windows.Forms.NumericUpDown>  
 Описывает данный класс и содержит ссылки на все его члены...  
  
## <a name="related-sections"></a>Связанные разделы  
 [Элементы управления для использования в формах Windows Forms](controls-to-use-on-windows-forms.md)  
 Полный список элементов управления Windows Forms со ссылками на информацию об их применении.

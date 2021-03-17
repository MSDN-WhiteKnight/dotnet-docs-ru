---
title: Общие сведения об элементе управления DomainUpDown (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- DomainUpDown
helpviewer_keywords:
- spin button control [Windows Forms], about spin button
- DomainUpDown control [Windows Forms], about DomainUpDown control
ms.assetid: 3f40f9c1-20ad-4331-b9b5-b0127eb36eb3
ms.openlocfilehash: bfe3e7239f77c6f1a0d9bb46a96c704653b43364
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59102860"
---
# <a name="domainupdown-control-overview-windows-forms"></a>Общие сведения об элементе управления DomainUpDown (Windows Forms)
Windows Forms <xref:System.Windows.Forms.DomainUpDown> элемент управления является набором текстового поля и пары кнопок для перемещения вверх или вниз по списку. Он выводит и задает строку текста из списка вариантов. Пользователь может выбрать строки, щелкнув кнопок со стрелками вверх по списку, клавиши со стрелками вверх и вниз или введя строку, совпадающую с элементом в списке. Один из возможных способов использования для этого элемента управления можно выбрать элементы в алфавитном порядке отсортированный список имен.  
  
> [!NOTE]
>  Чтобы отсортировать список, установите <xref:System.Windows.Forms.DomainUpDown.Sorted%2A> свойства `true`.  
  
 Функция этого элемента управления является очень похожа на поле со списком или поле со списком, но занимает очень мало места.  
  
## <a name="key-properties"></a>Ключевые свойства  
 Ключевые свойства элемента управления являются <xref:System.Windows.Forms.DomainUpDown.Items%2A>, <xref:System.Windows.Forms.UpDownBase.ReadOnly%2A>, и <xref:System.Windows.Forms.DomainUpDown.Wrap%2A>. <xref:System.Windows.Forms.DomainUpDown.Items%2A> Свойство содержит список объектов, текстовые значения отображаются в элементе управления. Если <xref:System.Windows.Forms.UpDownBase.ReadOnly%2A> присваивается `false`, элемент управления автоматически завершает текст, пользователь и сопоставляет его значение в списке. Если <xref:System.Windows.Forms.DomainUpDown.Wrap%2A> присваивается `true`, прокрутка пройден последний элемент, можно перейти первый элемент в списке и наоборот. Основные методы элемента управления являются <xref:System.Windows.Forms.DomainUpDown.UpButton%2A> и <xref:System.Windows.Forms.DomainUpDown.DownButton%2A>.  
  
 Этот элемент управления отображает только текстовые строки. Элемент управления, отображающий числовые значения, используйте <xref:System.Windows.Forms.NumericUpDown> элемента управления. Дополнительные сведения см. в разделе [Обзор элемента управления NumericUpDown](numericupdown-control-overview-windows-forms.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DomainUpDown>
- [Элемент управления DomainUpDown](domainupdown-control-windows-forms.md)

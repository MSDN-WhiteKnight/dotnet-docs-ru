---
title: Общие сведения об элементе управления NumericUpDown (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- NumericUpDown
helpviewer_keywords:
- numeric spin button control [Windows Forms], Windows Forms
- NumericUpDown control [Windows Forms], about NumericUpDown control
- spin button control [Windows Forms], Windows Forms
ms.assetid: cff3cf30-4d46-4381-87df-37bfe83c71c5
ms.openlocfilehash: 218eb685e546acac76a18450612a1601ab87276b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59109880"
---
# <a name="numericupdown-control-overview-windows-forms"></a>Общие сведения об элементе управления NumericUpDown (Windows Forms)
<xref:System.Windows.Forms.NumericUpDown> Элемент управления выглядит как сочетание текстового поля и пары кнопок со стрелками, которые пользователь может щелкнуть для корректировки значения пользователем. Он выводит и задает отдельное числовое значение из списка основных вариантов числовых значений. Пользователь может увеличить и уменьшить число вверх и вниз стрелки, клавиши со стрелками вверх и вниз или введя число в части текстового поля элемента управления. Нажав клавишу Стрелка вверх перемещает число увеличивается до максимума; нажав клавишу Стрелка вниз перемещение номера уменьшается до минимума.  
  
 Из-за его универсальным функциональным возможностям этот элемент управления является очевидным выбором, например, если вы хотите создать регулятор громкости для приложения музыкального проигрывателя. <xref:System.Windows.Forms.NumericUpDown> Элемент управления используется во многих приложениях панели управления Windows.  
  
## <a name="key-properties-and-methods"></a>Ключевые свойства и методы  
 Числа, отображаемые в текстовом поле элемента управления могут находиться в различных форматах, включая шестнадцатеричное. Дополнительные сведения см. в разделе [Как Задайте формат для Windows Forms элемента управления NumericUpDown](how-to-set-the-format-for-the-windows-forms-numericupdown-control.md). Ключевые свойства элемента управления являются <xref:System.Windows.Forms.NumericUpDown.Value%2A>, <xref:System.Windows.Forms.NumericUpDown.Maximum%2A> (значение по умолчанию 100), <xref:System.Windows.Forms.NumericUpDown.Minimum%2A> (значение по умолчанию 0), и <xref:System.Windows.Forms.NumericUpDown.Increment%2A> (значение 1 по умолчанию). <xref:System.Windows.Forms.NumericUpDown.Value%2A> Свойство задает текущий номер выбран в элементе управления. <xref:System.Windows.Forms.NumericUpDown.Increment%2A> Свойство задает значение, что число изменяется, когда пользователь щелкает вверх или Стрелка вниз. Когда фокус покидает элемент управления, любые введенные данные будет проверена на соответствие минимальным и максимальным числовые значения. Можно ускорить, элемент управления перемещается через чисел, когда пользователь нажимает постоянно вверх или Стрелка вниз, с помощью <xref:System.Windows.Forms.NumericUpDown.Accelerations%2A> свойство. Основные методы элемента управления являются <xref:System.Windows.Forms.NumericUpDown.UpButton%2A> и <xref:System.Windows.Forms.NumericUpDown.DownButton%2A>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.NumericUpDown>
- [Элемент управления NumericUpDown](numericupdown-control-windows-forms.md)
- [Практическое руководство. Определение формата элемента управления NumericUpDown в Windows Forms](how-to-set-the-format-for-the-windows-forms-numericupdown-control.md)
- [Элемент управления TextBox](textbox-control-windows-forms.md)

---
title: Практическое руководство. Определение клавиш доступа с помощью элементов управления Label в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- controls [Windows Forms], access keys
- dialog box controls [Windows Forms], mnemonics
- access keys [Windows Forms], creating for controls
- Label control [Windows Forms], creating access keys
- mnemonics [Windows Forms], adding to dialog box controls
- mnemonics
- Windows Forms controls, access keys
- UseMnemonic property [Windows Forms], Label control
- keyboard shortcuts [Windows Forms], creating for controls
- access keys [Windows Forms], Windows Forms
ms.assetid: 5ee8f823-80be-4a4f-96a4-412671e2e306
ms.openlocfilehash: ffe4bf6fb29e82b04938e2ba9a2d9d21e5eabcde
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59314312"
---
# <a name="how-to-create-access-keys-with-windows-forms-label-controls"></a>Практическое руководство. Определение клавиш доступа с помощью элементов управления Label в Windows Forms
Windows Forms <xref:System.Windows.Forms.Label> элементы управления могут использоваться для определения ключей доступа для других элементов управления. При определении ключ доступа в элемент управления label, пользователь может нажать клавишу ALT, а также символ, который будет использоваться перемещение фокуса к элементу управления, что следующий за ним в последовательности табуляции. Поскольку метки не может получать фокус, фокус автоматически перемещается к следующему элементу управления в последовательности табуляции. Этот метод используется для присвоения ключи доступа для текстовых полей, поля со списком, списков и сетки данных.  
  
### <a name="to-assign-an-access-key-to-a-control-with-a-label"></a>Чтобы назначить клавиши доступа к элементу управления с меткой  
  
1. Сначала нарисуйте метки, а затем другой элемент управления.  
  
     -или-  
  
     Нарисуйте элементы управления в любом порядке и задайте <xref:System.Windows.Forms.Control.TabIndex%2A> метки на единицу меньше, чем другой элемент управления.  
  
2. Задание метки <xref:System.Windows.Forms.Label.UseMnemonic%2A> свойства `true`.  
  
3. Используйте амперсанд (&) в метке <xref:System.Windows.Forms.Label.Text%2A> свойство, чтобы назначить клавиши доступа для метки. Дополнительные сведения см. в разделе [Создание сочетаний клавиш для элементов управления Windows Forms](how-to-create-access-keys-for-windows-forms-controls.md).  
  
    > [!NOTE]
    >  Может потребоваться отобразить амперсанды в элементе управления label, а не использовать их для создания ключей доступа. Это может произойти, если выполняется привязка элемента управления label к полю в наборе записей, включающем амперсанды. Для отображения в элементе управления label амперсанды задайте <xref:System.Windows.Forms.Label.UseMnemonic%2A> свойства `false`. Если вы хотите отобразить амперсанды, а также иметь ключ доступа, задайте <xref:System.Windows.Forms.Label.UseMnemonic%2A> свойства `true` и указать ключ доступа с помощью одного амперсанда (&) и знака амперсанд должно отображаться с два амперсанда.  
  
    ```vb  
    Label1.UseMnemonic = True  
    Label1.Text = "&Print"  
    Label2.UseMnemonic = True  
    Label2.Text = "&Copy && Paste"  
    ```  
  
    ```csharp  
    label1.UseMnemonic = true;  
    label1.Text = "&Print";  
    label2.UseMnemonic = true;  
    label2.Text = "&Copy && Paste";  
    ```  
  
    ```cpp  
    label1->UseMnemonic = true;  
    label1->Text = "&Print";  
    label2->UseMnemonic = true;  
    label2->Text = "&Copy && Paste";  
    ```  
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Приведение размера элемента управления Label в соответствие с его содержимым в Windows Forms](how-to-size-a-windows-forms-label-control-to-fit-its-contents.md)
- [Общие сведения об элементе управления Label](label-control-overview-windows-forms.md)
- [Элемент управления Label](label-control-windows-forms.md)

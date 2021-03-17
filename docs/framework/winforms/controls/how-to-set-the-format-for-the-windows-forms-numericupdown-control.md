---
title: Практическое руководство. Определение формата элемента управления NumericUpDown в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- NumericUpDown control [Windows Forms], formatting values
- up-down controls [Windows Forms], formatting numeric values
ms.assetid: fa7c5557-6bfb-45b2-975d-8887b23b0ba0
ms.openlocfilehash: 5957a44c7b07aa1b8d8df32667f023c0873ec1de
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59186154"
---
# <a name="how-to-set-the-format-for-the-windows-forms-numericupdown-control"></a>Практическое руководство. Определение формата элемента управления NumericUpDown в Windows Forms
Можно настроить способ отображения значения в Windows Forms <xref:System.Windows.Forms.NumericUpDown> элемента управления. <xref:System.Windows.Forms.NumericUpDown.DecimalPlaces%2A> Свойство определяет, сколько номеров появляются после десятичной запятой значение по умолчанию — 0. <xref:System.Windows.Forms.NumericUpDown.ThousandsSeparator%2A> Ли между каждой из трех цифр вставляется разделитель определяет значение по умолчанию — `false`. Элемент управления может отображать значения в шестнадцатеричном формате вместо десятичного формата, если <xref:System.Windows.Forms.NumericUpDown.Hexadecimal%2A> свойству `true`; по умолчанию используется `false`.  
  
### <a name="to-format-the-numeric-value"></a>Чтобы отформатировать числовое значение  
  
-   Отобразить значение десятичного числа, задав <xref:System.Windows.Forms.NumericUpDown.DecimalPlaces%2A> свойство целочисленное значение, а параметр <xref:System.Windows.Forms.NumericUpDown.ThousandsSeparator%2A> свойства `true` или `false`.  
  
    ```vb  
    NumericUpDown1.DecimalPlaces = 2  
    NumericUpDown1.ThousandsSeparator = True  
    ```  
  
    ```csharp  
    numericUpDown1.DecimalPlaces = 2;  
    numericUpDown1.ThousandsSeparator = true;  
    ```  
  
    ```cpp  
    numericUpDown1->DecimalPlaces = 2;  
    numericUpDown1->ThousandsSeparator = true;  
    ```  
  
     -или-  
  
-   Отобразите шестнадцатеричное число, задав <xref:System.Windows.Forms.NumericUpDown.Hexadecimal%2A> свойства `true`.  
  
    ```vb  
    NumericUpDown1.Hexadecimal = True  
    ```  
  
    ```csharp  
    numericUpDown1.Hexadecimal = true;  
    ```  
  
    ```cpp  
    numericUpDown1->Hexadecimal = true;  
    ```  
  
    > [!NOTE]
    >  Даже если значение отображается в форме как шестнадцатеричное значение, все тесты, выполните на <xref:System.Windows.Forms.NumericUpDown.Value%2A> свойство будет тестироваться его десятичное значение.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.NumericUpDown>
- [Элемент управления NumericUpDown](numericupdown-control-windows-forms.md)
- [Общие сведения об элементе управления NumericUpDown](numericupdown-control-overview-windows-forms.md)

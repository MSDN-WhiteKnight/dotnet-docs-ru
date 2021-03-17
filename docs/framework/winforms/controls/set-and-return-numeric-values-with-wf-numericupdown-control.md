---
title: Практическое руководство. Ввод числовых значений с помощью элемента управления NumericUpDown в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- numeric values [Windows Forms], Windows Forms
- Windows Forms, numeric values
- Windows Forms controls, NumericUpDown
- NumericUpDown control [Windows Forms], setting and returning values
ms.assetid: 5bd8f8cd-4c12-49ea-9cc3-2a647d064689
ms.openlocfilehash: c73200eb1c373f1d723ba82f2e6be5b625496b59
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59300506"
---
# <a name="how-to-set-and-return-numeric-values-with-the-windows-forms-numericupdown-control"></a>Практическое руководство. Ввод числовых значений с помощью элемента управления NumericUpDown в Windows Forms
Числовое значение в Windows Forms <xref:System.Windows.Forms.NumericUpDown> управления определяется его <xref:System.Windows.Forms.NumericUpDown.Value%2A> свойство. Можно написать проверок условий для значения элемента управления так же, как и в любое другое свойство. Один раз <xref:System.Windows.Forms.NumericUpDown.Value%2A> свойству, ее можно изменить непосредственно путем написания кода для выполнения над ним операций или вы можете вызвать <xref:System.Windows.Forms.NumericUpDown.UpButton%2A> и <xref:System.Windows.Forms.NumericUpDown.DownButton%2A> методы.  
  
### <a name="to-set-the-numeric-value"></a>Чтобы задать числовое значение  
  
1. Присвойте значение <xref:System.Windows.Forms.NumericUpDown.Value%2A> свойства в коде или в окне «Свойства».  
  
    ```vb  
    NumericUpDown1.Value = 55  
    ```  
  
    ```csharp  
    numericUpDown1.Value = 55;  
    ```  
  
    ```cpp  
    numericUpDown1->Value = 55;  
    ```  
  
     -или-  
  
2. Вызовите <xref:System.Windows.Forms.NumericUpDown.UpButton%2A> или <xref:System.Windows.Forms.NumericUpDown.DownButton%2A> метод, чтобы увеличить или уменьшить значение величину, указанную в <xref:System.Windows.Forms.NumericUpDown.Increment%2A> свойство.  
  
    ```vb  
    NumericUpDown1.UpButton()  
    ```  
  
    ```csharp  
    numericUpDown1.UpButton();  
    ```  
  
    ```cpp  
    numericUpDown1->UpButton();  
    ```  
  
### <a name="to-return-the-numeric-value"></a>Чтобы вернуть числовое значение  
  
-   Доступ <xref:System.Windows.Forms.NumericUpDown.Value%2A> свойства в коде.  
  
    ```vb  
    If NumericUpDown1.Value >= 65 Then  
       MessageBox.Show("Age is: " & NumericUpDown1.Value.ToString)  
    Else  
       MessageBox.Show("The customer is ineligible for a senior citizen discount.")  
    End If  
    ```  
  
    ```csharp  
    if(numericUpDown1.Value >= 65)  
    {  
       MessageBox.Show("Age is: " + numericUpDown1.Value.ToString());  
    }  
    else  
    {  
       MessageBox.Show("The customer is ineligible for a senior citizen discount.");  
    }  
    ```  
  
    ```cpp  
    if(numericUpDown1->Value >= 65)  
    {  
       MessageBox::Show(String::Concat("Age is: ",  
          numericUpDown1->Value.ToString()));  
    }  
    else  
    {  
       MessageBox::Show  
          ("The customer is ineligible for a senior citizen discount.");  
    }  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.NumericUpDown>
- <xref:System.Windows.Forms.NumericUpDown.Value%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.NumericUpDown.Increment%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.NumericUpDown.UpButton%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.NumericUpDown.DownButton%2A?displayProperty=nameWithType>
- [Элемент управления NumericUpDown](numericupdown-control-windows-forms.md)
- [Общие сведения об элементе управления NumericUpDown](numericupdown-control-overview-windows-forms.md)

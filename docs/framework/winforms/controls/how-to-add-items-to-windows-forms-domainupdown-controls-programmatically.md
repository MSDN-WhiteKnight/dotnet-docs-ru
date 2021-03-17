---
title: Практическое руководство. Добавление элементов в элемент управления DomainUpDown в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- spin button control [Windows Forms], adding items
- DomainUpDown control [Windows Forms], adding items to
ms.assetid: fd31d314-33eb-4181-90f8-d32ed0c4e072
ms.openlocfilehash: ef44a9e68b8007d57fc7442a178ae98322747c99
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59343679"
---
# <a name="how-to-add-items-to-windows-forms-domainupdown-controls-programmatically"></a>Практическое руководство. Добавление элементов в элемент управления DomainUpDown в Windows Forms
Можно добавить элементы Windows Forms <xref:System.Windows.Forms.DomainUpDown> элемента управления в коде. Вызовите <xref:System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection.Add%2A> или <xref:System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection.Insert%2A> метод <xref:System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection> класса для добавления элементов к элементу управления <xref:System.Windows.Forms.DomainUpDown.Items%2A> свойство. <xref:System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection.Add%2A> Метод добавляет элемент в конец коллекции, хотя <xref:System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection.Insert%2A> метод добавляет элемент в указанной позиции.  
  
### <a name="to-add-a-new-item"></a>Чтобы добавить новый элемент  
  
1. Используйте <xref:System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection.Add%2A> метод, чтобы добавить элемент в конец списка элементов.  
  
    ```vb  
    DomainUpDown1.Items.Add("noodles")  
    ```  
  
    ```csharp  
    domainUpDown1.Items.Add("noodles");  
    ```  
  
    ```cpp  
    domainUpDown1->Items->Add("noodles");  
    ```  
  
     -или-  
  
2. Используйте <xref:System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection.Insert%2A> метод для вставки элемента в списке в указанной позиции.  
  
    ```vb  
    ' Inserts an item at the third position in the list  
    DomainUpDown1.Items.Insert(2, "rice")  
    ```  
  
    ```csharp  
    // Inserts an item at the third position in the list  
    domainUpDown1.Items.Insert(2, "rice");  
    ```  
  
    ```cpp  
    // Inserts an item at the third position in the list  
    domainUpDown1->Items->Insert(2, "rice");  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DomainUpDown>
- <xref:System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection.Add%2A?displayProperty=nameWithType>
- <xref:System.Collections.ArrayList.Insert%2A?displayProperty=nameWithType>
- [Элемент управления DomainUpDown](domainupdown-control-windows-forms.md)
- [Общие сведения об элементе управления DomainUpDown](domainupdown-control-overview-windows-forms.md)

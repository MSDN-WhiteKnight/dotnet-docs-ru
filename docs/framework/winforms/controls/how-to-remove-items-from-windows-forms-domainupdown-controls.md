---
title: Практическое руководство. Удаление элементов из элемента управления DomainUpDown в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- DomainUpDown control [Windows Forms], removing items from
- spin button control [Windows Forms], removing items
ms.assetid: e70f5cbc-b497-41a9-975a-344c00e56ed2
ms.openlocfilehash: 0c07365f5be2e419b4049a466949fed2d884d897
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59131408"
---
# <a name="how-to-remove-items-from-windows-forms-domainupdown-controls"></a>Практическое руководство. Удаление элементов из элемента управления DomainUpDown в Windows Forms
Можно удалить элементы из Windows Forms <xref:System.Windows.Forms.DomainUpDown> элемента управления, используя <xref:System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection.Remove%2A> или <xref:System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection.RemoveAt%2A> метод <xref:System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection> класса. <xref:System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection.Remove%2A> Метод удаляет определенный элемент, пока <xref:System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection.RemoveAt%2A> метод удаляет элемент по его позиции.  
  
### <a name="to-remove-an-item"></a>Удаление элемента  
  
-   Используйте <xref:System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection.Remove%2A> метод <xref:System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection> класса для удаления элемента по имени.  
  
    ```vb  
    DomainUpDown1.Items.Remove("noodles")  
    ```  
  
    ```csharp  
    domainUpDown1.Items.Remove("noodles");  
    ```  
  
    ```cpp  
    domainUpDown1->Items->Remove("noodles");  
    ```  
  
     -или-  
  
-   Используйте <xref:System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection.RemoveAt%2A> метод для удаления элемента по его позиции.  
  
    ```vb  
    ' Removes the first item in the list.  
    DomainUpDown1.Items.RemoveAt(0)  
    ```  
  
    ```csharp  
    // Removes the first item in the list.  
    domainUpDown1.Items.RemoveAt(0);  
    ```  
  
    ```cpp  
    // Removes the first item in the list.  
    domainUpDown1->Items->RemoveAt(0);  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DomainUpDown>
- <xref:System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection.Remove%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection.RemoveAt%2A?displayProperty=nameWithType>
- [Элемент управления DomainUpDown](domainupdown-control-windows-forms.md)
- [Общие сведения об элементе управления DomainUpDown](domainupdown-control-overview-windows-forms.md)

---
title: Практическое руководство. Группировка элементов управления с помощью элемента управления GroupBox в формах Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- controls [Windows Forms], grouping
- GroupBox control [Windows Forms], grouping controls
- Windows Forms controls, grouping
ms.assetid: 0bda316d-bd2a-43aa-ac73-342453303169
ms.openlocfilehash: d2bad0020d18cd262bc2fe3489a00209308bd7b9
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59335879"
---
# <a name="how-to-group-controls-with-the-windows-forms-groupbox-control"></a>Практическое руководство. Группировка элементов управления с помощью элемента управления GroupBox в формах Windows Forms
Windows Forms <xref:System.Windows.Forms.GroupBox> элементы управления используются для группировки других элементов управления. Существуют три причины для группировки элементов управления:  
  
-   Чтобы создать визуальную группировку элементов связанных форм для упрощения пользовательского интерфейса.  
  
-   Чтобы создать программный группирование (переключателей, например).  
  
-   Перемещение элементов управления как единое целое во время разработки.  
  
### <a name="to-create-a-group-of-controls"></a>Чтобы создать группу элементов управления  
  
1. Рисование <xref:System.Windows.Forms.GroupBox> управления на форме.  
  
2. Добавьте другие элементы управления «группы», рисования каждого элемента внутри поля группы.  
  
     Если у вас есть существующие элементы управления, которые вы хотите включить в группу, можно выбрать все элементы управления, вырезать их в буфер обмена, выберите <xref:System.Windows.Forms.GroupBox> управления, а затем вставьте их в группу. Также можно перетащить их в группу.  
  
3. Задайте <xref:System.Windows.Forms.GroupBox.Text%2A> свойство поля группы, соответствующий заголовок.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.GroupBox>
- [Элемент управления GroupBox](groupbox-control-windows-forms.md)

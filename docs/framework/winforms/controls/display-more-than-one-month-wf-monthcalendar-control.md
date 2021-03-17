---
title: Практическое руководство. Отображение нескольких месяцев в элементе управления MonthCalendar в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- calendars [Windows Forms], formatting display
- examples [Windows Forms], calendar controls
- calendars [Windows Forms], multiple months
- MonthCalendar control [Windows Forms], formatting display
ms.assetid: d197caa2-38a5-4cb4-acc3-562130c2ace3
ms.openlocfilehash: 79100b52d8e0a5b651edb9d6555a4497287ed858
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59209558"
---
# <a name="how-to-display-more-than-one-month-in-the-windows-forms-monthcalendar-control"></a>Практическое руководство. Отображение нескольких месяцев в элементе управления MonthCalendar в Windows Forms
Windows Forms <xref:System.Windows.Forms.MonthCalendar> элемент управления может отображать до 12 месяцев, за раз. По умолчанию элемент управления отображает только один месяц, но можно указать количество месяцев, отображаются и их размещение в элементе управления. Когда вы изменяете размеры календаря, размер, поэтому убедитесь, что имеется достаточно места в форме для новых измерений.  
  
### <a name="to-display-multiple-months"></a>Чтобы отобразить несколько месяцев  
  
-   Задайте <xref:System.Windows.Forms.MonthCalendar.CalendarDimensions%2A> количество месяцев, отображаемых по горизонтали и вертикали.  
  
    ```vb  
    MonthCalendar1.CalendarDimensions = New System.Drawing.Size (3,2)  
    ```  
  
    ```csharp  
    monthCalendar1.CalendarDimensions = new System.Drawing.Size (3,2);  
    ```  
  
    ```cpp  
    monthCalendar1->CalendarDimensions = System::Drawing::Size (3,2);  
    ```  
  
## <a name="see-also"></a>См. также

- [Элемент управления MonthCalendar](monthcalendar-control-windows-forms.md)
- [Практическое руководство. Выбор диапазона дат в элементе управления MonthCalendar в Windows Forms](how-to-select-a-range-of-dates-in-the-windows-forms-monthcalendar-control.md)
- [Практическое руководство. Изменение внешнего вида элемента управления MonthCalendar в Windows Forms](how-to-change-monthcalendar-control-appearance.md)

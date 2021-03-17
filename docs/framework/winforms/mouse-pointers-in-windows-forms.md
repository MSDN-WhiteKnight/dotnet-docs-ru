---
title: Указатели мыши в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- pointers [Windows Forms], setting
- mouse pointers
- mouse cursors
- mouse pointers [Windows Forms], setting
- cursors [Windows Forms], setting
- mouse [Windows Forms], cursors
ms.assetid: c3400d85-de5b-42e8-abc3-d6088d69ee53
ms.openlocfilehash: e9b572ba40618a72b8db58917008ebd61a23de79
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59122789"
---
# <a name="mouse-pointers-in-windows-forms"></a>Указатели мыши в Windows Forms
Указатель мыши *указатель*, которые иногда называют курсор, — это битовая карта, задает точку фокуса на экране для ввода данных пользователем с помощью мыши. В этом разделе представлен обзор указателя мыши в Windows Forms и описаны некоторые из способов изменения и управления указатель мыши.  
  
## <a name="accessing-the-mouse-pointer"></a>Обращение к указателю мыши  
 Указатель мыши представленного <xref:System.Windows.Forms.Cursor> класс и все <xref:System.Windows.Forms.Control> имеет <xref:System.Windows.Forms.Control.Cursor%2A?displayProperty=nameWithType> свойство, которое указывает указатель для этого элемента управления. <xref:System.Windows.Forms.Cursor> Класс содержит свойства, описывающие указатель, такие как <xref:System.Windows.Forms.Cursor.Position%2A> и <xref:System.Windows.Forms.Cursor.HotSpot%2A> свойства и методы, которые могут изменять внешний вид указателя, такие как <xref:System.Windows.Forms.Cursor.Show%2A>, <xref:System.Windows.Forms.Cursor.Hide%2A>, и <xref:System.Windows.Forms.Cursor.DrawStretched%2A> методы.  
  
## <a name="controlling-the-mouse-pointer"></a>Управление указателем мыши  
 Иногда может потребоваться ограничить область, в котором указатель мыши, можно использовать, или изменить его позицию мыши. Вы можете получить или задать текущее положение мыши с помощью <xref:System.Windows.Forms.Cursor.Position%2A> свойство <xref:System.Windows.Forms.Cursor>. Кроме того, можно ограничить область, можно использовать указатель мыши на режим, <xref:System.Windows.Forms.Cursor.Clip%2A> свойство. Область клипа, по умолчанию является весь экран.  
  
## <a name="changing-the-mouse-pointer"></a>Изменение указателя мыши  
 Изменение указателя мыши является важным способом предоставления отклика для пользователя. Например, можно изменить указатель мыши в обработчиках <xref:System.Windows.Forms.Control.MouseEnter> и <xref:System.Windows.Forms.Control.MouseLeave> события, информирующее пользователя о выполнении вычислений и ограничить взаимодействие с пользователем в элементе управления. В некоторых случаях указатель мыши изменится из-за событий системы, например когда приложение участвует в операции перетаскивания и вставки.  
  
 Является основным способом изменить указатель мыши, задав <xref:System.Windows.Forms.Control.Cursor%2A?displayProperty=nameWithType> или <xref:System.Windows.Forms.Control.DefaultCursor%2A> свойства элемента управления в новый <xref:System.Windows.Forms.Cursor>. Примеры изменения указателя мыши, см. в примере кода в <xref:System.Windows.Forms.Cursor> класса. Кроме того <xref:System.Windows.Forms.Cursors> класс предоставляет набор <xref:System.Windows.Forms.Cursor> объектов для различных типов указателей, такие как указатель в виде руки. Для отображения указателя ожидания, который имеет вид со значком песочных часов, каждый раз, когда указатель мыши находится на элементе управления, используйте <xref:System.Windows.Forms.Control.UseWaitCursor%2A> свойство <xref:System.Windows.Forms.Control> класса.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Cursor>
- [Ввод данных мышью в приложении Windows Forms](mouse-input-in-a-windows-forms-application.md)
- [Функциональная возможность перетаскивания в Windows Forms](drag-and-drop-functionality-in-windows-forms.md)

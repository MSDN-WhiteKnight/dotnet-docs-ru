---
title: Обработка введенных пользователем данных
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- custom controls [Windows Forms], user input using code
- custom controls [Windows Forms], keyboard events using code
- custom controls [Windows Forms], mouse events using code
ms.assetid: d9b12787-86f6-4022-8e0f-e12d312c4af2
ms.openlocfilehash: 3ebe82fc18deba52fafe76da7ff85fb247446e46
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59074959"
---
# <a name="handling-user-input"></a>Обработка введенных пользователем данных
В этом разделе описываются основные события клавиатуры и мыши, предоставляемые <xref:System.Windows.Forms.Control?displayProperty=nameWithType>. При обработке события разработчики элементов управления должны переопределить защищенный `On` метод *EventName*, а не подключить делегат к событию. Сведения о событиях см. в разделе [Инициирование событий из компонента](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/sh2e3k5z(v=vs.120)).  
  
> [!NOTE]
>  Если нет данных связанные с событием, экземпляр базового класса <xref:System.EventArgs> передается в качестве аргумента для `On` *EventName* метод.  
  
## <a name="keyboard-events"></a>События клавиатуры  
 Общими событиями клавиатуры, которые может обрабатывать элемент управления, <xref:System.Windows.Forms.Control.KeyDown>, <xref:System.Windows.Forms.Control.KeyPress>, и <xref:System.Windows.Forms.Control.KeyUp>.  
  
|Имя события|Метод для переопределения|Описание события|  
|----------------|------------------------|--------------------------|  
|`KeyDown`|`void OnKeyDown(KeyEventArgs)`|Возникает только при первоначальном нажатии клавиши.|  
|`KeyPress`|`void OnKeyPress`<br /><br /> `(KeyPressEventArgs)`|Возникает при каждом нажатии клавиши. Если удерживается клавиша, <xref:System.Windows.Forms.Control.KeyPress> события с частотой повторения, определенные операционной системой.|  
|`KeyUp`|`void OnKeyUp(KeyEventArgs)`|Возникает при отпускании клавиши.|  
  
> [!NOTE]
>  Обработка ввода с клавиатуры значительно сложнее, чем переопределение событий в предыдущей таблице и в данном разделе не рассматривается. Дополнительные сведения см. в разделе [Ввод данных пользователем в Windows Forms](../user-input-in-windows-forms.md).  
  
## <a name="mouse-events"></a>События мыши  
 События мыши, которые может обрабатывать элемент управления: <xref:System.Windows.Forms.Control.MouseDown>, <xref:System.Windows.Forms.Control.MouseEnter>, <xref:System.Windows.Forms.Control.MouseHover>, <xref:System.Windows.Forms.Control.MouseLeave>, <xref:System.Windows.Forms.Control.MouseMove>, и <xref:System.Windows.Forms.Control.MouseUp>.  
  
|Имя события|Метод для переопределения|Описание события|  
|----------------|------------------------|--------------------------|  
|`MouseDown`|`void OnMouseDown(MouseEventArgs)`|Возникает при нажатии кнопки мыши, когда указатель мыши находится на элементе управления.|  
|`MouseEnter`|`void OnMouseEnter(EventArgs)`|Возникает, когда указатель мыши впервые входит в область элемента управления.|  
|`MouseHover`|`void OnMouseHover(EventArgs)`|Возникает, когда указатель мыши наводится на элемент управления.|  
|`MouseLeave`|`void OnMouseLeave(EventArgs)`|Возникает, когда указатель мыши покидает область элемента управления.|  
|`MouseMove`|`void OnMouseMove(MouseEventArgs)`|Возникает, когда указатель мыши перемещается в область элемента управления.|  
|`MouseUp`|`void OnMouseUp(MouseEventArgs)`|Возникает при отпускании кнопки мыши, когда указатель мыши находится на элементе управления или покидает область элемента управления.|  
  
 В следующем фрагменте кода показан пример переопределения <xref:System.Windows.Forms.Control.MouseDown> событий.  
  
 [!code-csharp[System.Windows.Forms.FlashTrackBar#7](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/CS/FlashTrackBar.cs#7)]
 [!code-vb[System.Windows.Forms.FlashTrackBar#7](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/VB/FlashTrackBar.vb#7)]  
  
 В следующем фрагменте кода показан пример переопределения <xref:System.Windows.Forms.Control.MouseMove> событий.  
  
 [!code-csharp[System.Windows.Forms.FlashTrackBar#8](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/CS/FlashTrackBar.cs#8)]
 [!code-vb[System.Windows.Forms.FlashTrackBar#8](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/VB/FlashTrackBar.vb#8)]  
  
 В следующем фрагменте кода показан пример переопределения <xref:System.Windows.Forms.Control.MouseUp> событий.  
  
 [!code-csharp[System.Windows.Forms.FlashTrackBar#9](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/CS/FlashTrackBar.cs#9)]
 [!code-vb[System.Windows.Forms.FlashTrackBar#9](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/VB/FlashTrackBar.vb#9)]  
  
 Полный исходный код для `FlashTrackBar` пример, см. в разделе [как: Создание элемента управления Windows Forms, показывающего прогресс](how-to-create-a-windows-forms-control-that-shows-progress.md).  
  
## <a name="see-also"></a>См. также

- [События элементов управления Windows Forms](events-in-windows-forms-controls.md)
- [Определение событий](defining-an-event-in-windows-forms-controls.md)
- [События](../../../standard/events/index.md)
- [Ввод данных пользователем в Windows Forms](../user-input-in-windows-forms.md)

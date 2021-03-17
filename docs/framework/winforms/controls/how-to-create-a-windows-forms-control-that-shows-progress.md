---
title: Практическое руководство. Создание элемента управления, показывающего прогресс в форме Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- controls [Windows Forms], progress tracking
- controls [Windows Forms], creating
- progress [Windows Forms], reporting [Windows Forms]
- FlashTrackBar custom control
ms.assetid: 24c5a2e3-058c-4b8d-a217-c06e6a130c2f
ms.openlocfilehash: 1f457d6e2b0eb73da7a16dc93ea80a14ddb4b2c2
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59202018"
---
# <a name="how-to-create-a-windows-forms-control-that-shows-progress"></a>Практическое руководство. Создание элемента управления, показывающего прогресс в форме Windows Forms
В следующем примере кода показан пользовательский элемент управления `FlashTrackBar`, который позволяет показывать пользователю уровень или ход выполнения приложения. Ход выполнения отображается с помощью градиента.  
  
 Элемент управления `FlashTrackBar` иллюстрирует следующие концепции.  
  
-   Определение пользовательских свойств.  
  
-   Определение пользовательских событий. (`FlashTrackBar` определяет событие `ValueChanged`.)  
  
-   Переопределение <xref:System.Windows.Forms.Control.OnPaint%2A> метод для предоставления логики для отрисовки элемента управления.  
  
-   Расчет области, доступной для рисования элемента управления с помощью его <xref:System.Windows.Forms.Control.ClientRectangle%2A> свойство. `FlashTrackBar` делает это в его `OptimizedInvalidate` метод.  
  
-   Реализация сериализации (устойчивости) для свойства при его изменении в конструкторе Windows Forms. `FlashTrackBar` Определяет `ShouldSerializeStartColor` и `ShouldSerializeEndColor` методы для сериализации его `StartColor` и `EndColor` свойства.  
  
 В приведенной ниже таблице показаны пользовательские свойства, которые определяет `FlashTrackBar`.  
  
|Свойство|Описание|  
|--------------|-----------------|  
|`AllowUserEdit`|Указывает, может ли пользователь изменить значение полосы прокрутки флеш-памяти, щелкнув его и перетащив.|  
|`EndColor`|Определяет конечный цвет полосы прокрутки.|  
|`DarkenBy`|Определяет степень затемнения фона относительно градиента переднего плана.|  
|`Max`|Определяет максимальное значение полосы прокрутки.|  
|`Min`|Определяет минимальное значение полосы прокрутки.|  
|`StartColor`|Определяет начальный цвет градиента.|  
|`ShowPercentage`|Указывает, следует ли отображать процент поверх градиента.|  
|`ShowValue`|Указывает, следует ли отображать текущее значение поверх градиента.|  
|`ShowGradient`|Указывает, следует ли отображать на полосе прокрутки цветной градиент, отображающий текущее значение.|  
|-   `Value`|Определяет текущее значение полосы ползунка.|  
  
 В следующей таблице показаны дополнительные элементы, определяемые событием изменения свойства `FlashTrackBar:` и методом, который вызывает это событие.  
  
|Член|Описание|  
|------------|-----------------|  
|`ValueChanged`|Событие, которое возникает при изменении свойства `Value` полосы ползунка.|  
|`OnValueChanged`|Метод, который вызывает событие `ValueChanged`.|  
  
> [!NOTE]
>  `FlashTrackBar` использует <xref:System.EventArgs> класс данных события и <xref:System.EventHandler> для делегата события.  
  
 Для обработки соответствующих *EventName* события, `FlashTrackBar` переопределяет следующие методы, которые он наследует от <xref:System.Windows.Forms.Control?displayProperty=nameWithType>:  
  
-   <xref:System.Windows.Forms.Control.OnPaint%2A>  
  
-   <xref:System.Windows.Forms.Control.OnMouseDown%2A>  
  
-   <xref:System.Windows.Forms.Control.OnMouseMove%2A>  
  
-   <xref:System.Windows.Forms.Control.OnMouseUp%2A>  
  
-   <xref:System.Windows.Forms.Control.OnResize%2A>  
  
 Для обработки соответствующих событий изменения свойств `FlashTrackBar` переопределяет следующие методы, которые он наследует от <xref:System.Windows.Forms.Control?displayProperty=nameWithType>:  
  
-   <xref:System.Windows.Forms.Control.OnBackColorChanged%2A>  
  
-   <xref:System.Windows.Forms.Control.OnBackgroundImageChanged%2A>  
  
-   <xref:System.Windows.Forms.Control.OnTextChanged%2A>  
  
## <a name="example"></a>Пример  
 Элемент управления `FlashTrackBar` определяет два редактора типов пользовательского интерфейса, `FlashTrackBarValueEditor` и `FlashTrackBarDarkenByEditor`, указанные в приведенных ниже листингах кода. Класс `HostApp` использует элемент управления `FlashTrackBar` в форме Windows.  
  
 [!code-csharp[System.Windows.Forms.FlashTrackBar#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/CS/FlashTrackBar.cs#1)]
 [!code-vb[System.Windows.Forms.FlashTrackBar#1](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/VB/FlashTrackBar.vb#1)]  
  
 [!code-csharp[System.Windows.Forms.FlashTrackBar#10](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/CS/FlashTrackBarDarkenByEditor.cs#10)]
 [!code-vb[System.Windows.Forms.FlashTrackBar#10](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/VB/FlashTrackBarDarkenByEditor.vb#10)]  
  
 [!code-csharp[System.Windows.Forms.FlashTrackBar#20](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/CS/FlashTrackBarValueEditor.cs#20)]
 [!code-vb[System.Windows.Forms.FlashTrackBar#20](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/VB/FlashTrackBarValueEditor.vb#20)]  
  
 [!code-csharp[System.Windows.Forms.FlashTrackBar#30](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/CS/HostApp.cs#30)]
 [!code-vb[System.Windows.Forms.FlashTrackBar#30](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/VB/HostApp.vb#30)]  
  
## <a name="see-also"></a>См. также

- [Расширение поддержки времени разработки](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/37899azc(v=vs.120))
- [Основы разработки элементов управления форм Windows Forms](windows-forms-control-development-basics.md)

---
title: Практическое руководство. Многоуровневое расположение объектов в формах Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- Windows Forms controls, layering
- controls [Windows Forms], layering
- z order
- controls [Windows Forms], positioning
- z-order
ms.assetid: 1acc4281-2976-4715-86f4-bda68134baaf
ms.openlocfilehash: 8d0abbf0f71ac176d17261a0ae863938c575bdaf
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59311666"
---
# <a name="how-to-layer-objects-on-windows-forms"></a>Практическое руководство. Многоуровневое расположение объектов в формах Windows Forms
При создании сложного пользовательского интерфейса, или работать с формой многодокументного интерфейса (MDI), часто требуется слоя элементы управления и дочерние формы для создания более сложных интерфейсов пользователя (UI). Чтобы переместить и хранить список элементов управления и окон в контексте группы, управлять z порядком. *Z-порядок* является видимое расположение элементов управления на форме вдоль оси z формы (глубина). Окно, в верхней части z порядок перекрывает все остальные окна. Все остальные окна перекрывают окно в нижней части z порядка.  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-layer-controls-at-design-time"></a>Чтобы расположить элементы управления во время разработки  
  
1. Выберите элемент управления, который вы хотите слоев.  
  
2. На **формат** последовательно выберите пункты **порядок**, а затем нажмите кнопку **на передний** или **на задний**.  
  
### <a name="to-layer-controls-programmatically"></a>Чтобы расположить элементы управления программными средствами  
  
-   Используйте <xref:System.Windows.Forms.Control.BringToFront%2A> и <xref:System.Windows.Forms.Control.SendToBack%2A> методы для управления z порядок элементов управления.  
  
     Например если <xref:System.Windows.Forms.TextBox> элемента управления, `txtFirstName`, находится под другим элементом управления и необходимо переместить его вверх, используйте следующий код:  
  
    ```vb  
    txtFirstName.BringToFront()  
    ```  
  
    ```csharp  
    txtFirstName.BringToFront();  
    ```  
  
    ```cpp  
    txtFirstName->BringToFront();  
    ```  
  
> [!NOTE]
>  Windows Forms поддерживает *вложении элементов управления*. Включение элементов управления заключается в размещении нескольких элементов управления внутри элемента управления, такие как ряд <xref:System.Windows.Forms.RadioButton> внутри элементов управления <xref:System.Windows.Forms.GroupBox> элемента управления. Можно размещать элементы управления внутри содержащего элемента управления. Перемещение группы перемещает элементы управления, так как они содержатся внутри него.  
  
## <a name="see-also"></a>См. также

- [Элементы управления Windows Forms](index.md)
- [Расположение элементов управления в формах Windows Forms](arranging-controls-on-windows-forms.md)
- [Создание меток и назначение сочетаний клавиш для элементов управления Windows Forms](labeling-individual-windows-forms-controls-and-providing-shortcuts-to-them.md)
- [Элементы управления для использования в формах Windows Forms](controls-to-use-on-windows-forms.md)
- [Функциональная классификация элементов управления Windows Forms](windows-forms-controls-by-function.md)

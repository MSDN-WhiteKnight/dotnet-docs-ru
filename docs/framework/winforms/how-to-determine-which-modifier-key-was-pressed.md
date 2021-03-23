---
title: Практическое руководство. Определение нажатой управляющей клавиши
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- keyboard input
- shift keys
- events [Windows Forms], mouse
- Keys.ControlKey enumeration member
- keys [Windows Forms], control keys
- user input [Windows Forms], checking for keyboard
- keys [Windows Forms], determining last pressed
- keys [Windows Forms], shift keys
- keys [Windows Forms], modifier keys
- control keys
- keys [Windows Forms], alt keys
- alt keys
- Keys.Shift enumeration member
- events [Windows Forms], keyboard
- keyboards [Windows Forms], keyboard input
- Keys.Alt enumeration member
- modifier keys
ms.assetid: 1e184048-0ae3-4067-a200-d4ba31dbc2cb
ms.openlocfilehash: 571af49cdf82b876cfb72a7c7636874c8d155fb7
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59213940"
---
# <a name="how-to-determine-which-modifier-key-was-pressed"></a>Практическое руководство. Определение нажатой управляющей клавиши
При создании приложения, которое принимает нажатия клавиш пользователем, можно также отслеживать за нажатием клавиш клавиши SHIFT, ALT и CTRL. При нажатии в сочетании с другими клавишами или с помощью щелчков мыши, приложение может реагировать соответствующим образом. Например если нажата буквы S, это может просто вызвать «s» для отображения на экране, но при нажатии клавиш CTRL + S, текущий документ может быть сохранен. Если вы обрабатываете <xref:System.Windows.Forms.Control.KeyDown> событий, <xref:System.Windows.Forms.KeyEventArgs.Modifiers%2A> свойство <xref:System.Windows.Forms.KeyEventArgs> полученных событием обработчик определяет нажатии клавиши-модификаторы. Кроме того <xref:System.Windows.Forms.KeyEventArgs.KeyData%2A> свойство <xref:System.Windows.Forms.KeyEventArgs> определяет символ, который также была нажата в сочетании с операцию побитового или любые клавиши-модификаторы. Тем не менее если обрабатывается <xref:System.Windows.Forms.Control.KeyPress> события или события мыши, обработчик событий не получает эти сведения. В этом случае необходимо использовать <xref:System.Windows.Forms.Control.ModifierKeys%2A> свойство <xref:System.Windows.Forms.Control> класса. В любом случае необходимо выполнить операцию побитового и соответствующего <xref:System.Windows.Forms.Keys> значения и значения, вы тестируете. <xref:System.Windows.Forms.Keys> Перечисление предоставляет варианты каждого ключа модификатор, поэтому очень важно выполнить побитового и с правильным значением. Например, клавиша SHIFT представляется <xref:System.Windows.Forms.Keys.Shift>, <xref:System.Windows.Forms.Keys.ShiftKey>, <xref:System.Windows.Forms.Keys.RShiftKey> и <xref:System.Windows.Forms.Keys.LShiftKey> правильное значение для тестирования является клавиша SHIFT <xref:System.Windows.Forms.Keys.Shift>. Аналогичным образом, для проверки CTRL и ALT качестве модификаторов вы должны использовать <xref:System.Windows.Forms.Keys.Control> и <xref:System.Windows.Forms.Keys.Alt> соответственно.  
  
> [!NOTE]
>  Программистов Visual Basic также доступны сведения о ключе через <xref:Microsoft.VisualBasic.Devices.Computer.Keyboard%2A> свойство  
  
### <a name="to-determine-which-modifier-key-was-pressed"></a>Чтобы определение нажатой управляющей клавиши  
  
-   Используйте побитовый `AND` оператор с <xref:System.Windows.Forms.Control.ModifierKeys%2A> свойство и значение <xref:System.Windows.Forms.Keys> перечисления, чтобы определить, нажата ли клавиша определенного модификатор. В следующем примере кода показано, как определить, нажата ли клавиша SHIFT в <xref:System.Windows.Forms.Control.KeyPress> обработчик событий.  
  
     
     [!code-csharp[System.Windows.Forms.DetermineModifierKey#5](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DetermineModifierKey/CS/form1.cs#5)]
       
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Keys>
- <xref:System.Windows.Forms.Control.ModifierKeys%2A>
- [Ввод с клавиатуры в приложении Windows Forms](keyboard-input-in-a-windows-forms-application.md)
- [Практическое руководство. Определить, что если CapsLock включен в Visual Basic](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/9c9d1fz9(v=vs.100))

---
title: Принцип работы ввод с клавиатуры
ms.date: 03/30/2017
helpviewer_keywords:
- keyboard input [Windows Forms], about keyboard input
- keyboards [Windows Forms], keyboard input
- Windows Forms, keyboard input
ms.assetid: 9a29433c-a180-49bb-b74c-d187786584c8
ms.openlocfilehash: ddc2f3338b231ab3ae59e65bc82c00bb8f663540
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59342177"
---
# <a name="how-keyboard-input-works"></a>Принцип работы ввод с клавиатуры
Ввод с клавиатуры обрабатывается в Windows Forms посредством вызова событий клавиатуры в ответ на сообщения Windows. В большинстве приложений Windows Forms для обработки ввода с клавиатуры используются только события клавиатуры. Тем не менее, чтобы реализовать более сложные сценарии ввода с клавиатуры, например перехват клавиш до того, как они достигнут элемента управления, необходимо понимать, как работают сообщения клавиатуры. В этом разделе описываются типы данных ключа, распознаваемых приложением Windows Forms, и приводятся общие сведения о маршрутизацией сообщений клавиатуры. Сведения о событиях клавиатуры см. в разделе [Использование событий клавиатуры](using-keyboard-events.md).  
  
## <a name="types-of-keys"></a>Типы ключей  
 Windows Forms идентифицирует ввод с клавиатуры как коды виртуальных клавиш, представленные побитового <xref:System.Windows.Forms.Keys> перечисления. С помощью <xref:System.Windows.Forms.Keys> перечисления, можно объединять несколько нажатых клавиш в одно значение. Эти значения соответствуют значениям, сопровождающим сообщения Windows WM_KEYDOWN и WM_SYSKEYDOWN. Нажатие большинства физических клавиш можно обнаружить путем обработки <xref:System.Windows.Forms.Control.KeyDown> или <xref:System.Windows.Forms.Control.KeyUp> события. Клавиши знаков являются подмножеством <xref:System.Windows.Forms.Keys> перечисления и соответствуют значениям, сопровождающим сообщения WM_CHAR и WM_SYSCHAR Windows. Если сочетание нажатых клавиш образует знак, его можно определить символ путем обработки <xref:System.Windows.Forms.Control.KeyPress> событий. Кроме того, можно использовать <xref:Microsoft.VisualBasic.Devices.Keyboard>, предоставляемый интерфейсом программирования Visual Basic, обнаруживать, какие клавиши были нажаты и отправлять ключи. Дополнительные сведения см. в разделе [Доступ к клавиатуре](~/docs/visual-basic/developing-apps/programming/computer-resources/accessing-the-keyboard.md).  
  
## <a name="order-of-keyboard-events"></a>Порядок событий клавиатуры  
 Как было показано ранее, в элементе управления могут возникать 3 связанных с клавиатурой события. Общий порядок событий показывает следующая последовательность:  
  
1. Пользователь помещает клавиша «», предварительно обрабатывается, подготавливается к отправке и <xref:System.Windows.Forms.Control.KeyDown> событием.  
  
2. Пользователь удерживает клавиша «», предварительно обрабатывается, подготавливается к отправке и <xref:System.Windows.Forms.Control.KeyPress> событием.  
  
     Пока пользователь удерживает нажатой данную клавишу, это событие возникает несколько раз.  
  
3. Пользователь отпускает клавиша «», ключ она предварительно обрабатывается, отправляется и <xref:System.Windows.Forms.Control.KeyUp> событием.  
  
## <a name="preprocessing-keys"></a>Предварительная обработка сообщений клавиатуры  
 Как и другие сообщения, обработка сообщений клавиатуры выполняется в <xref:System.Windows.Forms.Control.WndProc%2A> метод формы или элемента управления. Тем не менее, прежде чем клавиатуры обработки сообщений, <xref:System.Windows.Forms.Control.PreProcessMessage%2A> метод вызывает один или несколько методов, которые могут быть переопределены для обработки специальных символов и физических клавиш. Эти методы можно переопределить для обнаружения и фильтрации определенных клавиш перед обработкой сообщения элементом управления. В следующей таблице показаны выполняемые действия и связанные методы в порядке их осуществления.  
  
### <a name="preprocessing-for-a-keydown-event"></a>Предварительная обработка события KeyDown  
  
|Действие|Связанный метод|Примечания|  
|------------|--------------------|-----------|  
|Проверка клавиши для команд, например ярлыка для сочетаний клавиш или меню.|<xref:System.Windows.Forms.Control.ProcessCmdKey%2A>|Этот метод обрабатывает клавишу для команд, которая имеет приоритет над обычными клавишами. Если этот метод возвращает `true`, сообщение о нажатии клавиши не отправляется, и событие клавиши не возникает. Если он возвращает `false`, <xref:System.Windows.Forms.Control.IsInputKey%2A> называется`.`|  
|Проверка наличия специальной клавишей, требующей предварительной обработки или обычной клавиши знака, должен вызывать <xref:System.Windows.Forms.Control.KeyDown> событий и отправляться в элемент управления.|<xref:System.Windows.Forms.Control.IsInputKey%2A>|Если метод возвращает `true`, это означает, что элемент управления является обычный символ и <xref:System.Windows.Forms.Control.KeyDown> события. Если `false`, <xref:System.Windows.Forms.Control.ProcessDialogKey%2A> вызывается. **Примечание.**  Чтобы элемент управления получает клавишу или сочетание клавиш, можно обрабатывать <xref:System.Windows.Forms.Control.PreviewKeyDown> событий и набор <xref:System.Windows.Forms.PreviewKeyDownEventArgs.IsInputKey%2A> из <xref:System.Windows.Forms.PreviewKeyDownEventArgs> для `true` для ключ или ключи, которые вы хотите.|  
|Проверка клавиши навигации (ESC, TAB, ВВОД или клавиши со стрелками).|<xref:System.Windows.Forms.Control.ProcessDialogKey%2A>|Этот метод обрабатывает физическую клавишу со специальными функциональными возможностями в элементе управления, например переключение фокуса между элементом управления и его родительским объектом. Если непосредственный элемент управления не обрабатывает ключ, <xref:System.Windows.Forms.Control.ProcessDialogKey%2A> вызывается для родительского элемента управления и так далее до самого верхнего элемента управления в иерархии. Если этот метод возвращает `true`, предварительная обработка завершается, и событие клавиатуры не возникает. Если он возвращает `false`, <xref:System.Windows.Forms.Control.KeyDown> событием.|  
  
### <a name="preprocessing-for-a-keypress-event"></a>Предварительная обработка события KeyPress  
  
|Действие|Связанный метод|Примечания|  
|------------|--------------------|-----------|  
|Убедитесь, что клавиша является обычным символом, который должен быть обработан элементом управления|<xref:System.Windows.Forms.Control.IsInputChar%2A>|Если символ является обычный символ, этот метод возвращает `true`, <xref:System.Windows.Forms.Control.KeyPress> события и последующая предварительная обработка не выполняется. В противном случае <xref:System.Windows.Forms.Control.ProcessDialogChar%2A> будет вызываться.|  
|Проверьте, не является ли символ назначенной клавишей (например, &OK на кнопке)|<xref:System.Windows.Forms.Control.ProcessDialogChar%2A>|Этот метод, схожий с <xref:System.Windows.Forms.Control.ProcessDialogKey%2A>, будет вызываться по иерархии элементов управления. Если элемент управления является контейнерным, он проверяет наличие назначенных клавиш путем вызова <xref:System.Windows.Forms.Control.ProcessMnemonic%2A> на себя и своих дочерних элементах управления. Если <xref:System.Windows.Forms.Control.ProcessDialogChar%2A> возвращает `true`, <xref:System.Windows.Forms.Control.KeyPress> событие не происходит.|  
  
## <a name="processing-keyboard-messages"></a>Обработка сообщений клавиатуры  
 После сообщения клавиатуры достигают <xref:System.Windows.Forms.Control.WndProc%2A> метод формы или элемента управления, они обрабатываются с помощью набора методов, которые могут быть переопределены. Каждый из этих методов возвращает <xref:System.Boolean> значение, указывающее, имеет ли сообщение клавиатуры обработано и использовано элементом управления. Если один из методов возвращает `true`, сообщение считается обработанным и не передается в базовый или родительский объект элемента управления для дальнейшей обработки. В противном случае сообщение остается в очереди сообщений и может быть обработано в другом методе в базовом или родительском объекте элемента управления. В следующей таблице представлены методы, обеспечивающие обработку сообщений клавиатуры.  
  
|Метод|Примечания|  
|------------|-----------|  
|<xref:System.Windows.Forms.Control.ProcessKeyMessage%2A>|Этот метод обрабатывает все сообщения клавиатуры, которые получены <xref:System.Windows.Forms.Control.WndProc%2A> метод элемента управления.|  
|<xref:System.Windows.Forms.Control.ProcessKeyPreview%2A>|Этот метод отправляет сообщение клавиатуры в родительский объект элемента управления. Если <xref:System.Windows.Forms.Control.ProcessKeyPreview%2A> возвращает `true`, событие клавиатуры не создается <xref:System.Windows.Forms.Control.ProcessKeyEventArgs%2A> вызывается.|  
|<xref:System.Windows.Forms.Control.ProcessKeyEventArgs%2A>|Этот метод вызывает <xref:System.Windows.Forms.Control.KeyDown>, <xref:System.Windows.Forms.Control.KeyPress>, и <xref:System.Windows.Forms.Control.KeyUp> соответствующие события.|  
  
## <a name="overriding-keyboard-methods"></a>Переопределение методов клавиатуры  
 Существует множество методов переопределения, когда выполняется предварительная и основная обработка сообщений клавиатуры. Тем не менее некоторые методы отличаются большим удобством. В таблице ниже приведены задачи, которые может быть необходимо выполнить, и оптимальные способы переопределения методов для сообщений клавиатуры. Дополнительные сведения о переопределении методов см. в разделе [переопределение свойств и методов в производных классах](~/docs/visual-basic/programming-guide/language-features/objects-and-classes/inheritance-basics.md#overriding-properties-and-methods-in-derived-classes).  
  
|Задача|Метод|  
|----------|------------|  
|Перехват клавиши навигации и создание <xref:System.Windows.Forms.Control.KeyDown> событий. Например, в текстовом поле необходимо обработать клавиши TAB и Return.|Переопределите метод <xref:System.Windows.Forms.Control.IsInputKey%2A>. **Примечание.**  Кроме того, можно обработать <xref:System.Windows.Forms.Control.PreviewKeyDown> событий и набор <xref:System.Windows.Forms.PreviewKeyDownEventArgs.IsInputKey%2A> из <xref:System.Windows.Forms.PreviewKeyDownEventArgs> для `true` для ключ или ключи, которые вы хотите.|  
|Выполнение специальной обработки ввода или навигации в элементе управления. Например, необходимо использовать клавиши со стрелками в элементе управления "Список", чтобы изменить выбранный элемент.|Переопределение <xref:System.Windows.Forms.Control.ProcessDialogKey%2A>|  
|Перехват клавиши навигации и создание <xref:System.Windows.Forms.Control.KeyPress> событий. Например, в элементе управления регулятора требуется выполнение нескольких нажатий клавиши со стрелкой для ускорения перехода между элементами.|Переопределите метод <xref:System.Windows.Forms.Control.IsInputChar%2A>.|  
|Выполнение специальной обработки ввода или навигации во время <xref:System.Windows.Forms.Control.KeyPress> событий. Например, в элементе управления "Список" при удержании нажатой клавиши "r" следует переходить между элементами, которые начинаются с буквы "r".|Переопределение <xref:System.Windows.Forms.Control.ProcessDialogChar%2A>|  
|Выполнение обработки пользовательских назначенных клавиш. Например, необходимо обрабатывать назначенные клавиши на кнопках, нарисованных владельцем, содержащихся на панели инструментов.|Переопределите метод <xref:System.Windows.Forms.Control.ProcessMnemonic%2A>.|  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Keys>
- <xref:System.Windows.Forms.Control.WndProc%2A>
- <xref:System.Windows.Forms.Control.PreProcessMessage%2A>
- [Объект My.Computer.Keyboard](~/docs/visual-basic/language-reference/objects/my-computer-keyboard-object.md)
- [Доступ к клавиатуре](~/docs/visual-basic/developing-apps/programming/computer-resources/accessing-the-keyboard.md)
- [Использование событий клавиатуры](using-keyboard-events.md)

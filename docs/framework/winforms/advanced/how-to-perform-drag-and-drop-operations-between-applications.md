---
title: Практическое руководство. Выполнение операции перетаскивания между приложениями
ms.date: 03/30/2017
helpviewer_keywords:
- drag and drop [Windows Forms], between applications
ms.assetid: fa347436-2b12-4dd6-8507-59d7241f6a06
ms.openlocfilehash: 9aac3a0efd6359c25a6972f0e0b52dd489ec31db
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59327533"
---
# <a name="how-to-perform-drag-and-drop-operations-between-applications"></a>Практическое руководство. Выполнение операции перетаскивания между приложениями
Выполнение операций перетаскивания между приложениями не отличается от реализации этой операции внутри приложения до тех пор, пока поведение участвующих приложений соответствует "контракту" между свойствами <xref:System.Windows.Forms.DragEventArgs.AllowedEffect%2A> и <xref:System.Windows.Forms.DragEventArgs.Effect%2A>.  
  
 В следующей процедуре будет использоваться созданное вами приложение Windows и текстовый редактора WordPad, который входит в состав операционной системы Windows, для выполнения операций перетаскивания между приложениями. WordPad имеет определенный набор допустимых действий для перетаскивания текста; приложение Windows, для которого будет написан код, будет использовать эти действия для успешного завершения операции перетаскивания.  
  
### <a name="to-perform-a-drag-and-drop-procedure-between-applications"></a>Выполнение операции перетаскивания между приложениями  
  
1. Создайте новое приложение Windows Forms.  
  
2. Добавьте элемент управления <xref:System.Windows.Forms.TextBox> в форму.  
  
3. Настройте элемент управления <xref:System.Windows.Forms.TextBox> для получения сброшенных данных.  
  
     Дополнительные сведения см. в разделе [Пошаговое руководство: Выполнение операции перетаскивания и вставки в Windows Forms](walkthrough-performing-a-drag-and-drop-operation-in-windows-forms.md).  
  
4. Запустите приложение Windows и во время выполнения приложения запустите WordPad.  
  
     WordPad — это текстовый редактор, установленный операционной системой Windows, который позволяет выполнять операции перетаскивания. Его можно открыть с помощь.клавиш **запустить** кнопку, выбрав **запуска**и введя `WordPad` в текстовом поле **запуска** диалоговое окно и щелкнув **ОК**.  
  
5. После открытия WordPad введите в нем строку текста.  
  
6. Используя мышь, выделите текст и перетащите выделенный текст на элемент управления <xref:System.Windows.Forms.TextBox> в приложение Windows.  
  
     Обратите внимание, что, когда указатель мыши находится над элементом управления <xref:System.Windows.Forms.TextBox>, (и, следовательно, инициируется событие <xref:System.Windows.Forms.Control.DragEnter>), курсор изменяется и можно отпустить выделенный текст на элемент управления <xref:System.Windows.Forms.TextBox>.  
  
     Кроме того, можно настроить элемент управления <xref:System.Windows.Forms.TextBox> так, чтобы можно было перетаскивать текстовые строки в WordPad. Дополнительные сведения см. в разделе [Пошаговое руководство: Выполнение операции перетаскивания и вставки в Windows Forms](walkthrough-performing-a-drag-and-drop-operation-in-windows-forms.md).  
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Добавление данных в буфер обмена](how-to-add-data-to-the-clipboard.md)
- [Практическое руководство. Извлечение данных из буфера обмена](how-to-retrieve-data-from-the-clipboard.md)
- [Операции перетаскивания и поддержка буфера обмена](drag-and-drop-operations-and-clipboard-support.md)

---
title: Практическое руководство. Определение клавиш доступа для элементов управления Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- controls [Windows Forms], access keys
- Button control [Windows Forms], access keys
- dialog box controls [Windows Forms], mnemonics
- access keys [Windows Forms], creating for controls
- mnemonics [Windows Forms], adding to dialog box controls
- mnemonics
- ampersand character in shortcut key
- Windows Forms controls, access keys
- examples [Windows Forms], controls
- Text property [Windows Forms], specifying access keys for controls
- keyboard shortcuts [Windows Forms], creating for controls
- access keys [Windows Forms], Windows Forms
- ALT key
ms.assetid: 4faa0991-28ec-4eca-91db-51dc2cd6a7ac
ms.openlocfilehash: e6c829553163359301bad2cd896fc43562ee8069
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59334462"
---
# <a name="how-to-create-access-keys-for-windows-forms-controls"></a>Практическое руководство. Определение клавиш доступа для элементов управления Windows Forms
*Ключ доступа* , подчеркивается в тексте элемента меню, пункт меню или метка элемента управления, такого как кнопка. С помощью ключа доступа пользователь может «щелкните» кнопки с помощью клавиши ALT и клавишу с буквой. Например, если кнопка запускает процесс печати формы и поэтому его `Text` свойство имеет значение «Print», добавив амперсанд перед буквой «P» приводит к буква «P» будет подчеркнут в тексте кнопки во время выполнения. Пользователь может выполнять команда, связанная с кнопкой, нажав клавиши ALT + P. Не может иметь ключ доступа для элемента управления, который не может получить фокус.  
  
### <a name="to-create-an-access-key-for-a-control"></a>Чтобы создать ключ доступа для элемента управления  
  
1. Задайте `Text` свойство на строку, которая включает знак амперсанда (&) перед буквой, которая будет использоваться в сочетании клавиш.  
  
    ```vb  
    ' Set the letter "P" as an access key.  
    Button1.Text = "&Print"  
    ```  
  
    ```csharp  
    // Set the letter "P" as an access key.  
    button1.Text = "&Print";  
    ```  
  
    ```cpp  
    // Set the letter "P" as an access key.  
    button1->Text = "&Print";  
    ```  
  
    > [!NOTE]
    >  Чтобы включить знак амперсанда в захвате без создания ключа доступа, добавьте два амперсанда (& &). Один знак амперсанда отображается в заголовке, и никакие символы не будут подчеркнуты.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Button>
- [Практическое руководство. Обработка события нажатия кнопки в Windows Forms](how-to-respond-to-windows-forms-button-clicks.md)
- [Практическое руководство. Определение текста, отображаемого элементом управления Windows Forms](how-to-set-the-text-displayed-by-a-windows-forms-control.md)
- [Создание меток и назначение сочетаний клавиш для элементов управления Windows Forms](labeling-individual-windows-forms-controls-and-providing-shortcuts-to-them.md)

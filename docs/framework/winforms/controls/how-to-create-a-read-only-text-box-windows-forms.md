---
title: Практическое руководство. Создать только для чтения текстовое поле (Windows Forms)
ms.date: 03/30/2017
helpviewer_keywords:
- TextBox control [Windows Forms], read-only
- read-only text boxes
- text boxes [Windows Forms], read-only
ms.assetid: 60baa9ab-fa57-44ad-bb7c-61b05aa64296
ms.openlocfilehash: 72dc188993474ad4b39f0cfa74cadffdb99ff46f
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59308579"
---
# <a name="how-to-create-a-read-only-text-box-windows-forms"></a>Практическое руководство. Создать только для чтения текстовое поле (Windows Forms)
Изменяемое поле текста в Windows Forms можно преобразовать в элемент управления только для чтения. Например текстовое поле может отобразить значение обычно изменяется, но в настоящее время не может быть из-за состояния приложения.  
  
### <a name="to-create-a-read-only-text-box"></a>Чтобы создать поле только для чтения текста  
  
1. Задайте <xref:System.Windows.Forms.TextBox> элемента управления <xref:System.Windows.Forms.TextBoxBase.ReadOnly%2A> свойства `true`. Со свойством, имеющим значение `true`, пользователи могут прокручивать и выделите текст в текстовом поле, не позволяя изменять. Объект **копирования** команда работает в текстовом поле, но **Вырезать** и **вставить** команд не.  
  
    > [!NOTE]
    >  <xref:System.Windows.Forms.TextBoxBase.ReadOnly%2A> Свойство оказывает влияние на взаимодействие с пользователем во время выполнения. По-прежнему изменением содержимого текстового поля программными средствами во время выполнения, изменив <xref:System.Windows.Forms.TextBox.Text%2A> свойства текстового поля.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.TextBox>
- [Общие сведения об элементе управления TextBox](textbox-control-overview-windows-forms.md)
- [Практическое руководство. Управление положением курсора в элементе управления TextBox в Windows Forms](how-to-control-the-insertion-point-in-a-windows-forms-textbox-control.md)
- [Практическое руководство. Создание текстового поля для ввода пароля с помощью элемента управления TextBox в Windows Forms](how-to-create-a-password-text-box-with-the-windows-forms-textbox-control.md)
- [Практическое руководство. Добавление кавычек в строку](how-to-put-quotation-marks-in-a-string-windows-forms.md)
- [Практическое руководство. Выделение текста в элементе управления TextBox в Windows Forms](how-to-select-text-in-the-windows-forms-textbox-control.md)
- [Практическое руководство. Многострочные элементы управления TextBox в Windows Forms](how-to-view-multiple-lines-in-the-windows-forms-textbox-control.md)
- [Элемент управления TextBox](textbox-control-windows-forms.md)

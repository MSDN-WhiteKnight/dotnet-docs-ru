---
title: Практическое руководство. Отображение всплывающей справки
ms.date: 03/30/2017
helpviewer_keywords:
- pop-up Help
- Help [Windows Forms], pop-up Help
- Windows Forms, displaying Help
- forms [Windows Forms], displaying Help
- modal dialog boxes [Windows Forms], pop-up Help
- F1 Help [Windows Forms], in dialog boxes
- HelpProvider component [Windows Forms]
- Help [Windows Forms], adding to dialog boxes
ms.assetid: 218aa81e-e87e-4d67-af05-11627bbdce3b
ms.openlocfilehash: f805840ea3b1a8aef6a289dba064c468a4da0cb0
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59331485"
---
# <a name="how-to-display-pop-up-help"></a>Практическое руководство. Отображение всплывающей справки
Один из способов отображения справки в Windows Forms — через **помочь** кнопки, расположенной в правой части строки заголовка, доступной через <xref:System.Windows.Forms.Form.HelpButton%2A> свойство. Этот способ вывода справки хорошо подходит при работе с диалоговыми окнами. Модальные диалоговые окна (с методом <xref:System.Windows.Forms.Form.ShowDialog%2A>) затрудняют работу внешних справочных систем, так как их нужно закрывать, чтобы перенести фокус на другое окно. Кроме того, с помощью **помочь** кнопку требует отсутствия не **свернуть** кнопку или **развернуть** кнопки в строке заголовка. Это стандартное соглашение стандартным диалоговым окном, формах обычно есть **свернуть** и **развернуть** кнопки.  
  
 Следует помнить, что компонент <xref:System.Windows.Forms.HelpProvider> можно также использовать, чтобы связать элементы управления с файлами справочной системы, даже если применяется всплывающая справка. Дополнительные сведения см. в разделе [предоставление справки в приложении Windows](how-to-provide-help-in-a-windows-application.md).  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-display-pop-up-help"></a>Отображение всплывающей справки  
  
1. Перетащите [HelpProvider](../controls/helpprovider-component-windows-forms.md) компонент из области элементов в форму.  
  
     Он разместится в нижней части конструктора Windows Forms.  
  
2. В окне "Свойства" присвойте свойству <xref:System.Windows.Forms.Form.HelpButton%2A> значение `true`. При этом в правой части строки заголовка формы появится кнопка с вопросительным знаком.  
  
3. Для отображения <xref:System.Windows.Forms.Form.HelpButton%2A> свойствам <xref:System.Windows.Forms.Form.MinimizeBox%2A> и <xref:System.Windows.Forms.Form.MaximizeBox%2A> формы нужно присвоить значение `false`, свойству <xref:System.Windows.Forms.Form.ControlBox%2A> — значение `true`, а свойству <xref:System.Windows.Forms.Form.FormBorderStyle%2A> — одно из следующих значений: <xref:System.Windows.Forms.FormBorderStyle.FixedSingle>, <xref:System.Windows.Forms.FormBorderStyle.Fixed3D>, <xref:System.Windows.Forms.FormBorderStyle.FixedDialog> или <xref:System.Windows.Forms.FormBorderStyle.Sizable>.  
  
4. Выберите элемент управления, для которого нужно отображать справку в форме, и укажите строку справки в окне "Свойства". Это строка текста, который будет отображаться в окне, аналогичном окну [подсказки](../controls/tooltip-component-windows-forms.md).  
  
5. Нажмите клавишу **F5**.  
  
6. Нажмите клавишу **помочь** в строке заголовка кнопку и щелкните элемент управления, для которого была задана строка справки.  
  
## <a name="see-also"></a>См. также

- [Отображение справки по элементам управления с помощью всплывающих подсказок](control-help-using-tooltips.md)
- [Интеграция справки пользователя в формы Windows Forms](integrating-user-help-in-windows-forms.md)
- [Windows Forms](../index.md)

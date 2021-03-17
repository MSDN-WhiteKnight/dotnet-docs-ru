---
title: Практическое руководство. Создание кнопки отмены в формах Windows Forms с помощью конструктора
ms.date: 03/30/2017
helpviewer_keywords:
- buttons [Windows Forms], cancel buttons
- Button control [Windows Forms], designating as cancel button
ms.assetid: 30e77d9c-d565-4ab5-a84a-62c043af8822
ms.openlocfilehash: f127a1a74643c975aea73b24896c098b365aa327
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59327546"
---
# <a name="how-to-designate-a-windows-forms-button-as-the-cancel-button-using-the-designer"></a>Практическое руководство. Создание кнопки отмены в формах Windows Forms с помощью конструктора
В любой форме Windows, можно назначить <xref:System.Windows.Forms.Button> отображения элемента управления кнопки "Отмена". Каждый раз, когда пользователь нажимает клавишу ESC, независимо от того, что другой элемент управления в форме имеет фокус, нажатии кнопки "Отмена". Такая кнопка обычно создается, чтобы пользователи могли быстро прервать операцию, не выполняя никаких действий.  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-designate-the-cancel-button"></a>Чтобы создать кнопку «Отмена»  
  
1. Выберите форму, в которой находится кнопка.  
  
2. В **свойства** формы задайте окне <xref:System.Windows.Forms.Form.CancelButton%2A> свойства <xref:System.Windows.Forms.Button> имя элемента управления.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Form.CancelButton%2A>
- [Общие сведения об элементе управления Button](button-control-overview-windows-forms.md)
- [Способы активации элемента управления Button в Windows Forms](ways-to-select-a-windows-forms-button-control.md)
- [Практическое руководство. Обработка события нажатия кнопки в Windows Forms](how-to-respond-to-windows-forms-button-clicks.md)
- [Практическое руководство. Создание кнопки принятия в формах Windows Forms с помощью конструктора](designate-a-wf-button-as-the-accept-button-using-the-designer.md)
- [Элемент управления Button](button-control-windows-forms.md)

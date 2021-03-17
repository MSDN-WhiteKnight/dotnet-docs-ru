---
title: Практическое руководство. Скрытие объектов ToolStripMenuItem с помощью конструктора
ms.date: 03/30/2017
helpviewer_keywords:
- ToolStripMenuItems [Windows Forms], hiding menu items in designer
- MenuStrip control [Windows Forms], hiding menu items in designer
- menu items [Windows Forms], hiding
ms.assetid: 8f1b057e-3d8a-4f11-88df-935f7b29a836
ms.openlocfilehash: 31c597a0e2cbf41484f19c8d4179823e9fb929ba
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59317679"
---
# <a name="how-to-hide-toolstripmenuitems-using-the-designer"></a>Практическое руководство. Скрытие объектов ToolStripMenuItem с помощью конструктора
Скрытие пунктов меню — это способ управления пользовательским интерфейсом (UI) приложения и ограничить команды пользователя. Часто требуется скрыть меню целиком, когда все элементы меню на нем будут недоступны. Это меньше отвлекаться для пользователя. Кроме того можно скрыть и отключить меню или пункта меню, как скрытие не запрещает пользователю доступ к команде меню с помощью сочетания клавиш. Дополнительные сведения об отключении пунктов меню см. в разделе [как: Отключение объектов ToolStripMenuItem с помощью конструктора](how-to-disable-toolstripmenuitems-using-the-designer.md).  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-hide-a-top-level-menu-and-its-submenu-items"></a>Чтобы скрыть меню верхнего уровня и пунктов подменю  
  
1. Выберите пункт меню верхнего уровня и задайте его <xref:System.Windows.Forms.ToolStripItem.Visible%2A> или <xref:System.Windows.Forms.ToolStripItem.Available%2A> свойства `false`.  
  
     Если скрыть элемент меню верхнего уровня, все пункты меню внутри этого меню также скрыты. Если щелкнуть в любом месте за пределами <xref:System.Windows.Forms.MenuStrip> после задания <xref:System.Windows.Forms.ToolStripItem.Visible%2A> для `false`, элемент целиком меню верхнего уровня и пунктов подменю исчезнут из формы, поэтому отображается результат выполнения этого действия. Для отображения скрытых меню верхнего уровня элемента во время разработки, щелкните <xref:System.Windows.Forms.MenuStrip> в **область компонентов**в **Структура документа**, или в верхней части сетки свойств.  
  
> [!NOTE]
>  Редко предстоит скрыть меню целиком за исключением нескольких меню дочерние интерфейса (MDI) документа в сценарии слияния.  
  
### <a name="to-hide-a-submenu-item"></a>Чтобы скрыть элемент вложенного меню  
  
1. Выберите элемент и задайте его <xref:System.Windows.Forms.ToolStripItem.Visible%2A> свойства `false`.  
  
     Если скрыть пункт подменю, он остается видимым в форме во время разработки, то можно легко выделить для дальнейшей работы. Он будет скрыт во время выполнения.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ToolStripItem.Visible%2A>
- <xref:System.Windows.Forms.MenuStrip>
- <xref:System.Windows.Forms.ToolStripMenuItem.Enabled%2A>
- <xref:System.Windows.Forms.ToolStripItem.Available%2A>
- <xref:System.Windows.Forms.ToolStripMenuItem.Overflow%2A>
- [Общие сведения об элементе управления MenuStrip](menustrip-control-overview-windows-forms.md)
- [Практическое руководство. Отключение объектов ToolStripMenuItem с помощью конструктора](how-to-disable-toolstripmenuitems-using-the-designer.md)

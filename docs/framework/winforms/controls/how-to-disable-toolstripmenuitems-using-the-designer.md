---
title: Практическое руководство. Отключение объектов ToolStripMenuItem с помощью конструктора
ms.date: 03/30/2017
helpviewer_keywords:
- ToolStripMenuItems [Windows Forms], disabling in designer
- MenuStrip control [Windows Forms], disabling menu items in designer
- menu items [Windows Forms], disabling
- menus [Windows Forms], disabling items
ms.assetid: 985e311e-7d67-4205-b5a3-d045b68a4a03
ms.openlocfilehash: 9965825458afcd50b29699c3b89ed506078e04d9
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59338063"
---
# <a name="how-to-disable-toolstripmenuitems-using-the-designer"></a>Практическое руководство. Отключение объектов ToolStripMenuItem с помощью конструктора
Можно ограничить или расширить набор команд, которые может выполнять пользователь, включение и отключение элементов меню в ответ на действия пользователя. Пункты меню включены по умолчанию, когда они создаются, но его можно настроить через <xref:System.Windows.Forms.ToolStripMenuItem.Enabled%2A> свойство. Можно изменить значение этого свойства во время разработки в **свойства** окна или программным способом, задав его в код. Дополнительные сведения см. в разделе [Как Отключение объектов ToolStripMenuItem](how-to-disable-toolstripmenuitems.md).  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-disable-a-menu-item-at-design-time"></a>Чтобы отключить пункт меню во время разработки  
  
1. Выберите элемент меню в форме, установите <xref:System.Windows.Forms.ToolStripMenuItem.Enabled%2A> свойства `false`.  
  
    > [!TIP]
    >  При отключении элемента меню первый или верхнего уровня в меню отключаются все пункты меню, содержащихся в меню. Аналогичным образом отключение элемента меню, который имеет вложенное отключает элементы вложенного меню. Если все команды конкретного меню недоступны для пользователя, он считается хорошим стилем программирования, как скрыть и отключить всего меню, как это представляет собой интерфейс пользователя. Как следует скрыть и отключить меню, как скрытие не запрещает доступ к командам меню с помощью сочетаний клавиш. Задайте <xref:System.Windows.Forms.ToolStripItem.Visible%2A> свойство пункта меню верхнего уровня к `false` скрыть меню целиком.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.MenuStrip>
- <xref:System.Windows.Forms.ToolStripMenuItem>
- [Практическое руководство. Скрытие объектов ToolStripMenuItem](how-to-hide-toolstripmenuitems.md)
- [Общие сведения об элементе управления MenuStrip](menustrip-control-overview-windows-forms.md)

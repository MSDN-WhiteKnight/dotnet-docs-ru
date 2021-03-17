---
title: Общие сведения о компоненте ContextMenu (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- ContextMenu
helpviewer_keywords:
- ContextMenu component [Windows Forms], about ContextMenu component
- context menus [Windows Forms], ContextMenu component
- shortcut menus [Windows Forms], ContextMenu component
ms.assetid: 49d6398f-d3c4-4679-84fa-1de07b68b05e
ms.openlocfilehash: 2acbcc9197a630a993471c22e572a4f3ed682c64
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59090567"
---
# <a name="contextmenu-component-overview-windows-forms"></a>Общие сведения о компоненте ContextMenu (Windows Forms)
> [!IMPORTANT]
>  Несмотря на то что <xref:System.Windows.Forms.MenuStrip> и <xref:System.Windows.Forms.ContextMenuStrip> заменяют и расширяют функциональные возможности для <xref:System.Windows.Forms.MainMenu> и <xref:System.Windows.Forms.ContextMenu> элементы управления из предыдущих версий <xref:System.Windows.Forms.MainMenu> и <xref:System.Windows.Forms.ContextMenu> можно сохранить для обратной совместимости и использования в будущем, если выбран.  
  
 С помощью Windows Forms <xref:System.Windows.Forms.ContextMenu> компонента, вы можете предоставить пользователям доступного контекстного меню часто используемых команд, которые связаны с выбранным объектом. Элементы в контекстном меню часто представляют собой подмножество элементов из главного меню, которые отображаются в другом месте в приложении. Как правило, пользователь может открыть контекстное меню щелчком правой кнопки мыши. В Windows Forms контекстные меню связаны с элементами управления.  
  
## <a name="key-properties"></a>Ключевые свойства  
 Контекстное меню можно связать с элементом управления, задав элемента управления <xref:System.Windows.Forms.Control.ContextMenu%2A> свойства <xref:System.Windows.Forms.ContextMenu> компонента. Одно контекстное меню можно связать с несколькими элементами управления, но каждый элемент управления может иметь только один контекстное меню.  
  
 Ключевое свойство <xref:System.Windows.Forms.ContextMenu> компонент является <xref:System.Windows.Forms.Menu.MenuItems%2A> свойство. Можно добавить элементы меню, создание программным путем <xref:System.Windows.Forms.MenuItem> объектов и добавления их в <xref:System.Windows.Forms.Menu.MenuItemCollection> контекстного меню. Так как элементы в контекстном меню, обычно являются производными от других меню, наиболее часто добавляются элементы в контекстное меню, скопировав их.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ContextMenu>
- <xref:System.Windows.Forms.MenuStrip>
- <xref:System.Windows.Forms.ContextMenuStrip>

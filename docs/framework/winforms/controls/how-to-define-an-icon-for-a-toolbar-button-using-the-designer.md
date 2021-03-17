---
title: Практическое руководство. Определение значка для кнопки на панели инструментов с помощью конструктора
ms.date: 03/30/2017
helpviewer_keywords:
- toolbars [Windows Forms], adding icons to buttons
- examples [Windows Forms], toolbars
- images [Windows Forms], toolbar buttons
- buttons [Windows Forms], images
- icons [Windows Forms], toolbar buttons
- ToolBar control [Windows Forms], adding icons to buttons
ms.assetid: d848f38e-67f2-49d4-8e88-01c845c06c02
ms.openlocfilehash: 19d0b284238ed662b25627d6077c1ebe6ecc6e86
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59323711"
---
# <a name="how-to-define-an-icon-for-a-toolbar-button-using-the-designer"></a>Практическое руководство. Определение значка для кнопки на панели инструментов с помощью конструктора
> [!NOTE]
>  Элемент управления <xref:System.Windows.Forms.ToolStrip> заменяет элемент управления <xref:System.Windows.Forms.ToolBar> и расширяет его функциональные возможности; однако при необходимости элемент управления <xref:System.Windows.Forms.ToolBar> можно сохранить для обратной совместимости и использования в будущем.  
  
 <xref:System.Windows.Forms.ToolBar> кнопки, могут отображать значки для упрощения идентификации пользователей. Это достигается с помощью добавления изображений к <xref:System.Windows.Forms.ImageList> компонента и его сопоставления с <xref:System.Windows.Forms.ToolBar> элемента управления.  
  
 Следующая процедура требуется **приложения Windows** проекта с формой, содержащей <xref:System.Windows.Forms.ToolBar> управления и <xref:System.Windows.Forms.ImageList> компонента. Сведения о настройке такого проекта см. в разделе [как: Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project) и [как: Добавление элементов управления в Windows Forms](how-to-add-controls-to-windows-forms.md).  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-set-an-icon-for-a-toolbar-button-at-design-time"></a>Чтобы задать значок для кнопки панели инструментов во время разработки  
  
1. Добавление изображений к <xref:System.Windows.Forms.ImageList> компонента. Дополнительные сведения см. в разделе [Как Добавление или удаление изображений из компонента ImageList с помощью конструктора](how-to-add-or-remove-imagelist-images-with-the-designer.md).  
  
2. Выберите <xref:System.Windows.Forms.ToolBar> элемент управления в форме.  
  
3. В **свойства** окне <xref:System.Windows.Forms.ToolBar> элемента управления <xref:System.Windows.Forms.ToolBar.ImageList%2A> свойства <xref:System.Windows.Forms.ImageList> компонента.  
  
4. Нажмите кнопку <xref:System.Windows.Forms.ToolBar> элемента управления <xref:System.Windows.Forms.ToolBar.Buttons%2A> свойство, чтобы выбрать его и нажмите кнопку с многоточием (![экрана VisualStudioEllipsesButton](../media/vbellipsesbutton.png "vbEllipsesButton")) кнопку, чтобы открыть **Редактора коллекции**.  
  
5. Используйте **добавить** , чтобы добавить кнопки для <xref:System.Windows.Forms.ToolBar> элемента управления.  
  
6. В **свойства** окно, которое появляется на правой стороне панели **редактора коллекции**, задайте <xref:System.Windows.Forms.ToolBarButton.ImageIndex%2A> свойства каждой кнопки панели инструментов, одно из значений в списке, который извлекается из образов, добавленных к <xref:System.Windows.Forms.ImageList> компонента.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ToolBar>
- [Практическое руководство. Генерирование событий меню для кнопок элемента управления Toolbar](how-to-trigger-menu-events-for-toolbar-buttons.md)
- [Элемент управления ToolBar](toolbar-control-windows-forms.md)
- [Компонент ImageList](imagelist-component-windows-forms.md)

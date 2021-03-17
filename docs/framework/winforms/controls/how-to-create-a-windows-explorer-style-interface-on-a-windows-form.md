---
title: Практическое руководство. Создание интерфейса в стиле проводника в форме Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- Windows Explorer [Windows Forms], creating with Windows Forms
- SplitContainer control [Windows Forms], Explorer-style interface
- forms [Windows Forms], Windows Explorer type
ms.assetid: 9a3d5f4f-5dda-4350-9ad5-57ce5976dc47
ms.openlocfilehash: dd70feaba29e29748ac56729632fa359582a6914
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59327377"
---
# <a name="how-to-create-a-windows-explorerstyle-interface-on-a-windows-form"></a>Практическое руководство. Создание интерфейса в стиле проводника в форме Windows Forms
Windows Explorer является распространенным вариантом пользовательского интерфейса для приложений из-за его хорошо знаком всем пользователям.  
  
 Windows Explorer является, по сути, <xref:System.Windows.Forms.TreeView> управления и <xref:System.Windows.Forms.ListView> на отдельных панелях. Панелей вносятся можно изменять с помощью разделителя. Это упорядочение элементов управления является весьма эффективным для отображения и просмотра информации.  
  
 Ниже показано, как расположить элементы управления в форме проводника Windows. Они не демонстрируют Добавление функций просмотра файлов приложения Windows Explorer.  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-create-a-windows-explorer-style-windows-form"></a>Для создания формы Windows проводника Windows  
  
1. Создайте новый проект приложения Windows (**файл** > **New** > **проекта** > **Visual C#** или **Visual Basic** > **классический рабочий стол** > **Windows Forms Application**).  
  
2. Из **элементов**:  
  
    1.  Перетащите <xref:System.Windows.Forms.SplitContainer> управления на форму.  
  
    2.  Перетащите <xref:System.Windows.Forms.TreeView> управления в **SplitterPanel1** (панели <xref:System.Windows.Forms.SplitContainer> управления, помеченных как **Panel1**).  
  
    3.  Перетащите <xref:System.Windows.Forms.ListView> управления в **SplitterPanel2** (панели <xref:System.Windows.Forms.SplitContainer> управления, помеченных как **Panel2**).  
  
3. Выберите все три элемента управления, нажав клавишу CTRL и щелкая их в свою очередь. При выборе <xref:System.Windows.Forms.SplitContainer> управлять, щелкните вешку разбивки, а не панели.  
  
    > [!NOTE]
    >  Не используйте **выбрать все** команды **изменить** меню. Если это сделать, то свойство, необходимое на следующем шаге будет отсутствовать в **свойства** окна.  
  
4. В окне **Свойства** присвойте свойству <xref:System.Windows.Forms.SplitContainer.Dock%2A> значение <xref:System.Windows.Forms.DockStyle.Fill>.  
  
5. Нажмите клавишу F5 для запуска приложения.  
  
     Форма отображает двух частей пользовательского интерфейса, аналогичную, проводника Windows.  
  
    > [!NOTE]
    >  При перетаскивании разделителя панели Изменение размеров.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.SplitContainer>
- [Практическое руководство. Создание пользовательского интерфейса с несколькими областями с помощью Windows Forms](how-to-create-a-multipane-user-interface-with-windows-forms.md)
- [Практическое руководство. Определение способа изменения размеров и позиционирования в окне с перемещаемым разделителем](how-to-define-resize-and-positioning-behavior-in-a-split-window.md)
- [Практическое руководство. Разделение окна по горизонтали](how-to-split-a-window-horizontally.md)
- [Элемент управления SplitContainer](splitcontainer-control-windows-forms.md)

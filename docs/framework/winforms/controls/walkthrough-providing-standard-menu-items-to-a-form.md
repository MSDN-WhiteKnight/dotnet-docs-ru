---
title: Пошаговое руководство. Связывание стандартных элементов меню с формой
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- menu items [Windows Forms], standard
- toolbars [Windows Forms], walkthroughs
- StatusStrip control [Windows Forms]
- ToolStrip control [Windows Forms]
ms.assetid: dac37d98-589e-4d6d-9673-6437e8943122
ms.openlocfilehash: b4957a3f2efcb31594806a188e3d3bb10c2dac09
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59296398"
---
# <a name="walkthrough-providing-standard-menu-items-to-a-form"></a>Пошаговое руководство. Связывание стандартных элементов меню с формой
С помощью элемента управления <xref:System.Windows.Forms.MenuStrip> можно создавать стандартные меню для форм.  
  
 В этом пошаговом руководстве демонстрируется использование <xref:System.Windows.Forms.MenuStrip> элементу управления создавать стандартные меню. Также форма изменяется при выборе пользователем пункта меню. В этом пошаговом руководстве показаны следующие задачи:  
  
-   Создание проекта Windows Forms.  
  
-   Создание стандартного меню.  
  
-   Создание <xref:System.Windows.Forms.StatusStrip> элемента управления.  
  
-   Управление выбором элементов меню.  
  
 Когда вы закончите, вы получите формы, содержащей стандартное меню, в котором отображаются выбранные элементы меню в <xref:System.Windows.Forms.StatusStrip> элемента управления.  
  
 Чтобы скопировать код из этого раздела единым блоком, см. раздел [Практическое руководство. Обеспечивают стандартные пункты меню к форме](how-to-provide-standard-menu-items-to-a-form.md).  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
## <a name="prerequisites"></a>Предварительные требования  
 Для выполнения данного пошагового руководства требуется:  
  
-   Разрешения, необходимые для создания и выполнения проектов приложений Windows Forms на компьютере, на котором установлена Visual Studio.  
  
## <a name="creating-the-project"></a>Создание проекта  
 Первым шагом является создание проекта и настройка формы.  
  
#### <a name="to-create-the-project"></a>Создание проекта  
  
1. Создайте проект приложения Windows с именем **StandardMenuForm** (**файл** > **New** > **проекта**  >  **Visual C#** или **Visual Basic** > **классический рабочий стол** > **Windows Forms Приложение**).  
  
2. В конструкторе Windows Forms выберите форму.  
  
## <a name="creating-a-standard-menu"></a>Создание стандартного меню  
 В конструкторе Windows Forms позволяет автоматически заполнять <xref:System.Windows.Forms.MenuStrip> элемента управления с помощью стандартных элементов меню.  
  
#### <a name="to-create-a-standard-menu"></a>Создание стандартного меню  
  
1. Из **элементов**, перетащите <xref:System.Windows.Forms.MenuStrip> управления на форму.  
  
2. Нажмите кнопку <xref:System.Windows.Forms.MenuStrip> глиф смарт-тега элемента управления (![глиф смарт-тега](./media/vs-winformsmttagglyph.gif "VS_WinFormSmtTagGlyph")) и выберите **вставить стандартные элементы**.  
  
     <xref:System.Windows.Forms.MenuStrip> Заполнением стандартные пункты меню элемента управления.  
  
3. Нажмите кнопку **файл** элемент меню, чтобы увидеть его элементы меню по умолчанию и соответствующие значки.  
  
## <a name="creating-a-statusstrip-control"></a>Создание элемента управления StatusStrip  
 Используйте <xref:System.Windows.Forms.StatusStrip> управления для отображения состояния для приложений Windows Forms. В этом примере элементы меню, выбранный пользователем отображаются в <xref:System.Windows.Forms.StatusStrip> элемента управления.  
  
#### <a name="to-create-a-statusstrip-control"></a>Создание элемента управления StatusStrip  
  
1. Из **элементов**, перетащите <xref:System.Windows.Forms.StatusStrip> управления на форму.  
  
     <xref:System.Windows.Forms.StatusStrip> Автоматически прикреплен к нижней части формы.  
  
2. Нажмите кнопку <xref:System.Windows.Forms.StatusStrip> кнопку раскрывающегося списка элемента управления и выберите **StatusLabel** добавление <xref:System.Windows.Forms.ToolStripStatusLabel> управления <xref:System.Windows.Forms.StatusStrip> элемента управления.  
  
## <a name="handling-item-selection"></a>Управление выбором элементов  
 Обрабатывать <xref:System.Windows.Forms.ToolStripDropDownItem.DropDownItemClicked> событий, чтобы ответить, когда пользователь выбирает пункт меню.  
  
#### <a name="to-handle-item-selection"></a>Чтобы управлять выбором элементов  
  
1. Нажмите кнопку **файл** пункт меню, который вы создали при создании стандартного раздела меню.  
  
2. В окне **Свойства** выберите **События**.  
  
3. Дважды щелкните <xref:System.Windows.Forms.ToolStripDropDownItem.DropDownItemClicked> событий.  
  
     В конструкторе Windows Forms создает обработчик событий для <xref:System.Windows.Forms.ToolStripDropDownItem.DropDownItemClicked> событий.  
  
4. Вставьте следующий код в обработчик событий.  
  
     [!code-csharp[System.Windows.Forms.ToolStrip.StandardMenu#3](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.StandardMenu/CS/Form1.cs#3)]
     [!code-vb[System.Windows.Forms.ToolStrip.StandardMenu#3](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.StandardMenu/VB/Form1.vb#3)]  
  
5. Вставить `UpdateStatus` определение служебного метода в форму.  
  
     [!code-csharp[System.Windows.Forms.ToolStrip.StandardMenu#2](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.StandardMenu/CS/Form1.cs#2)]
     [!code-vb[System.Windows.Forms.ToolStrip.StandardMenu#2](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.StandardMenu/VB/Form1.vb#2)]  
  
## <a name="checkpoint"></a>Контрольная точка  
  
#### <a name="to-test-your-form"></a>Для проверки формы  
  
1. Нажмите клавишу F5, чтобы скомпилировать и запустить в форму.  
  
2. Нажмите кнопку **файл** пункт меню, чтобы открыть меню.  
  
3. На **файл** меню, выберите один из элементов, чтобы выбрать его.  
  
     <xref:System.Windows.Forms.StatusStrip> Элемент управления отображает выбранный элемент.  
  
## <a name="next-steps"></a>Следующие шаги  
 В этом пошаговом руководстве вы создали формы, содержащей стандартное меню. Можно использовать <xref:System.Windows.Forms.ToolStrip> семейства элементов управления, для многих других целей:  
  
-   Создать контекстное меню для элементов управления с <xref:System.Windows.Forms.ContextMenuStrip>. Дополнительные сведения см. в разделе [Общие сведения о компоненте ContextMenu](contextmenu-component-overview-windows-forms.md).  
  
-   Создайте форму многодокументного интерфейса (MDI) закрепленный <xref:System.Windows.Forms.ToolStrip> элементов управления. Дополнительные сведения см. в разделе [Пошаговое руководство: Создание формы MDI путем слияния меню и элементов управления ToolStrip](walkthrough-creating-an-mdi-form-with-menu-merging-and-toolstrip-controls.md).  
  
-   Предоставить вашей <xref:System.Windows.Forms.ToolStrip> управляет профессиональный вид. Дополнительные сведения см. в разделе [Как Назначение средства визуализации компоненту ToolStrip для приложения](how-to-set-the-toolstrip-renderer-for-an-application.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.MenuStrip>
- <xref:System.Windows.Forms.ToolStrip>
- <xref:System.Windows.Forms.StatusStrip>
- [Элемент управления MenuStrip](menustrip-control-windows-forms.md)

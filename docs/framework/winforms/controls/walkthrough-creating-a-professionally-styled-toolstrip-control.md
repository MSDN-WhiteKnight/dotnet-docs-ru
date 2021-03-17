---
title: Пошаговое руководство. Создание профессионально оформленного элемента управления ToolStrip
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- ToolStripProfessionalRenderer class [Windows Forms]
- ToolStripRenderer class [Windows Forms]
- toolbars [Windows Forms], walkthroughs
- ToolStrip control [Windows Forms], creating professionally styled controls
ms.assetid: b52339ae-f1d3-494e-996e-eb455614098a
ms.openlocfilehash: 526cb509d780abdbf3db6e15504616de19daae83
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59336555"
---
# <a name="walkthrough-creating-a-professionally-styled-toolstrip-control"></a>Пошаговое руководство. Создание профессионально оформленного элемента управления ToolStrip
Можно предоставить приложения <xref:System.Windows.Forms.ToolStrip> управляет профессиональный вид и поведение, написав собственный класс, производный от <xref:System.Windows.Forms.ToolStripProfessionalRenderer> типа.  
  
 В этом пошаговом руководстве демонстрируется использование <xref:System.Windows.Forms.ToolStrip> элементы управления для создания составного элемента управления, которая напоминает **редактируемую** в Microsoft® Outlook®. В этом пошаговом руководстве показаны следующие задачи:  
  
-   Создание проекта библиотеки элементов управления Windows.  
  
-   Проектирование StackView элемента управления.  
  
-   Реализация пользовательского модуля отрисовки.  
  
 Когда вы закончите, имеется элемент управления для повторного использования настраиваемых клиентских с профессиональный внешний вид элемента управления Microsoft Office® XP.  
  
 Чтобы скопировать код из этого раздела единым блоком, см. раздел [Практическое руководство. Создание профессионально оформленного элемента управления ToolStrip](how-to-create-a-professionally-styled-toolstrip-control.md).  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
## <a name="prerequisites"></a>Предварительные требования  
 Для выполнения данного пошагового руководства требуется:  
  
-   Разрешения, необходимые для создания и выполнения проектов приложений Windows Forms на компьютере, на котором установлена Visual Studio.  
  
## <a name="creating-a-windows-control-library-project"></a>Создание проекта библиотеки элементов управления Windows  
 Первым шагом является создание проекта библиотеки элементов управления.  
  
#### <a name="to-create-the-control-library-project"></a>Чтобы создать проект библиотеки элементов управления  
  
1. Создайте новый проект библиотеки элементов управления Windows с именем `StackViewLibrary`.  
  
2. В **обозревателе решений**, удалите элемент управления проекта по умолчанию, удаляя исходный файл с именем «UserControl1.cs» или «UserControl1.vb» в зависимости от выбранного языка.  
  
     Дополнительные сведения см. в разделе [Как Удалить, удаление и исключить элементы](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/0ebzhwsk(v=vs.100)).  
  
3. Добавьте новый <xref:System.Windows.Forms.UserControl> элемент **StackViewLibrary** проекта. Назовите новый исходный файл базового объекта `StackView`.  
  
## <a name="designing-the-stackview-control"></a>Проектирование элемента управления StackView  
 `StackView` Элемент управления является составного элемента управления с одним дочерним <xref:System.Windows.Forms.ToolStrip> элемента управления. Дополнительные сведения о составных элементов управления, см. в разделе [разновидности пользовательских элементов управления](varieties-of-custom-controls.md).  
  
#### <a name="to-design-the-stackview-control"></a>Чтобы разработать элемент управления StackView  
  
1. Из **элементов**, перетащите <xref:System.Windows.Forms.ToolStrip> элемента управления в область конструктора.  
  
2. В **свойства** окне <xref:System.Windows.Forms.ToolStrip> свойства элемента управления согласно следующей таблице.  
  
    |Свойство|Значение|  
    |--------------|-----------|  
    |name|`stackStrip`|  
    |CanOverflow|`false`|  
    |Закрепить|<xref:System.Windows.Forms.DockStyle.Bottom>|  
    |Шрифт|`Tahoma, 10pt, style=Bold`|  
    |Стиль захвата|<xref:System.Windows.Forms.ToolStripGripStyle.Hidden>|  
    |LayoutStyle|<xref:System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow>|  
    |Заполнение|`0, 7, 0, 0`|  
    |Отображается как|<xref:System.Windows.Forms.ToolStripRenderMode.Professional>|  
  
3. В конструкторе Windows Forms, нажмите кнопку <xref:System.Windows.Forms.ToolStrip> элемента управления **добавить** и добавьте <xref:System.Windows.Forms.ToolStripButton> для `stackStrip` элемента управления.  
  
4. В **свойства** окне <xref:System.Windows.Forms.ToolStripButton> свойства элемента управления согласно следующей таблице.  
  
    |Свойство|Значение|  
    |--------------|-----------|  
    |name|`mailStackButton`|  
    |CheckOnClick|true|  
    |Свойство CheckState|<xref:System.Windows.Forms.CheckState.Checked>|  
    |DisplayStyle|<xref:System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText>|  
    |ImageAlign|<xref:System.Drawing.ContentAlignment.MiddleLeft>|  
    |ImageScaling|<xref:System.Windows.Forms.ToolStripItemImageScaling.None>|  
    |ImageTransparentColor|`238, 238, 238`|  
    |Поля|`0, 0, 0, 0`|  
    |Заполнение|`3, 3, 3, 3`|  
    |Текста|**Почта**|  
    |TextAlign|<xref:System.Drawing.ContentAlignment.MiddleLeft>|  
  
5. Повторите шаг 7 для три раза <xref:System.Windows.Forms.ToolStripButton> элементов управления.  
  
     Присвоение имен элементам управления `calendarStackButton`, `contactsStackButton`, и `tasksStackButton`. Установите для параметра <xref:System.Windows.Forms.Control.Text%2A> свойства **календаря**, **контакты**, и **задачи**, соответственно.  
  
## <a name="handling-events"></a>Обработка событий  
 Важны два события сделать `StackView` корректного поведения элемента управления. Обрабатывать <xref:System.Windows.Forms.UserControl.Load> событий, чтобы правильно разместить элемент управления. Обрабатывать <xref:System.Windows.Forms.ToolStripItem.Click> событий для каждого <xref:System.Windows.Forms.ToolStripButton> для предоставления `StackView` управления поведением состояния, аналогичную <xref:System.Windows.Forms.RadioButton> элемента управления.  
  
#### <a name="to-handle-events"></a>Для обработки событий  
  
1. В конструкторе Windows Forms выберите `StackView` элемента управления.  
  
2. В окне **Свойства** выберите **События**.  
  
3. Дважды щелкните событие Load для создания `StackView_Load` обработчик событий.  
  
4. Скопируйте и вставьте в обработчике события `StackView_Load` следующий код.  
  
     [!code-csharp[System.Windows.Forms.ToolStrip.StackView#3](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.StackView/CS/StackView.cs#3)]
     [!code-vb[System.Windows.Forms.ToolStrip.StackView#3](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.StackView/VB/StackView.vb#3)]  
  
5. В конструкторе Windows Forms выберите `mailStackButton` элемента управления.  
  
6. В окне **Свойства** выберите **События**.  
  
7. Дважды щелкните событие Click.  
  
     Конструктор Windows Forms создает `mailStackButton_Click` обработчик событий.  
  
8. Переименуйте `mailStackButton_Click` в обработчике событий `stackButton_Click`.  
  
     Дополнительные сведения см. в разделе [переименование рефакторинга кода символа](/visualstudio/ide/reference/rename).  
  
9. Вставьте следующий код в `stackButton_Click` обработчик событий.  
  
     [!code-csharp[System.Windows.Forms.ToolStrip.StackView#4](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.StackView/CS/StackView.cs#4)]
     [!code-vb[System.Windows.Forms.ToolStrip.StackView#4](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.StackView/VB/StackView.vb#4)]  
  
10. В конструкторе Windows Forms выберите `calendarStackButton` элемента управления.  
  
11. В **свойства** окна, задайте событие Click `stackButton_Click` обработчик событий.  
  
12. Повторите шаги 10 и 11 for `contactsStackButton` и `tasksStackButton` элементов управления.  
  
## <a name="defining-icons"></a>Определение значков  
 Каждый `StackView` кнопка имеет значок. Для удобства каждый значок представлен как строка в кодировке Base64, которая десериализуется до <xref:System.Drawing.Bitmap> создается из него. В рабочей среде данные растрового изображения хранятся в виде ресурса и значки отображаются в конструкторе Windows Forms. Дополнительные сведения см. в разделе [Как Добавление фоновых изображений в формы Windows Forms](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/dff9f95f(v=vs.100)).  
  
#### <a name="to-define-icons"></a>Чтобы определить значки  
  
1. В редакторе кода вставьте следующий код в `StackView` определение класса. Этот код инициализирует точечные рисунки для <xref:System.Windows.Forms.ToolStripButton> значков.  
  
     [!code-csharp[System.Windows.Forms.ToolStrip.StackView#2](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.StackView/CS/StackView.cs#2)]
     [!code-vb[System.Windows.Forms.ToolStrip.StackView#2](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.StackView/VB/StackView.vb#2)]  
  
2. Добавьте вызов `InitializeImages` метод в `StackView` конструктора класса.  
  
     [!code-csharp[System.Windows.Forms.ToolStrip.StackView#5](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.StackView/CS/StackView.cs#5)]
     [!code-vb[System.Windows.Forms.ToolStrip.StackView#5](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.StackView/VB/StackView.vb#5)]  
  
## <a name="implementing-a-custom-renderer"></a>Реализация пользовательского средства отрисовки  
 Можно настроить большинство элементов `StackView` управления, реализовав класс, производный от <xref:System.Windows.Forms.ToolStripRenderer> класса. В этой процедуре вы реализуете <xref:System.Windows.Forms.ToolStripProfessionalRenderer> класс, используемый для настройки захвата и изображения градиентного фона для <xref:System.Windows.Forms.ToolStripButton> элементов управления.  
  
#### <a name="to-implement-a-custom-renderer"></a>Чтобы реализовать пользовательское средство отрисовки  
  
1. Вставьте следующий код в `StackView` управлять определением.  
  
     Это определение для `StackRenderer` класс, переопределяющий <xref:System.Windows.Forms.ToolStripRenderer.RenderGrip>, <xref:System.Windows.Forms.ToolStripRenderer.RenderToolStripBorder>, и <xref:System.Windows.Forms.ToolStripRenderer.RenderButtonBackground> методы для получения пользовательское оформление.  
  
     [!code-csharp[System.Windows.Forms.ToolStrip.StackView#10](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.StackView/CS/StackView.cs#10)]
     [!code-vb[System.Windows.Forms.ToolStrip.StackView#10](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.StackView/VB/StackView.vb#10)]  
  
2. В `StackView` конструктора элемента управления, создайте новый экземпляр класса `StackRenderer` класса и присвойте этот экземпляр `stackStrip` элемента управления <xref:System.Windows.Forms.ToolStrip.Renderer%2A> свойство.  
  
     [!code-csharp[System.Windows.Forms.ToolStrip.StackView#5](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.StackView/CS/StackView.cs#5)]
     [!code-vb[System.Windows.Forms.ToolStrip.StackView#5](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.StackView/VB/StackView.vb#5)]  
  
## <a name="testing-the-stackview-control"></a>Тестирование элемента управления StackView  
 `StackView` Элемент управления наследуется от <xref:System.Windows.Forms.UserControl> класса. Таким образом, можно проверить элемент управления с **тестового контейнера UserControl**. Дополнительные сведения см. в разделе [Как Тестирование во время выполнения поведения элемента UserControl](how-to-test-the-run-time-behavior-of-a-usercontrol.md).  
  
#### <a name="to-test-the-stackview-control"></a>Чтобы протестировать элемент управления StackView  
  
1. Нажмите клавишу F5, чтобы создать проект и запустить **тестовом контейнере элементов управления**.  
  
2. Наведите указатель на кнопки `StackView` управления и нажмите кнопку для просмотра внешнего вида выбранного состояния.  
  
## <a name="next-steps"></a>Следующие шаги  
 В этом пошаговом руководстве вы создали повторно используемый пользовательский клиентский элемент управления с профессиональный внешний вид элемента управления Office XP. Можно использовать <xref:System.Windows.Forms.ToolStrip> семейства элементов управления, для многих других целей:  
  
-   Создать контекстное меню для элементов управления с <xref:System.Windows.Forms.ContextMenuStrip>. Дополнительные сведения см. в разделе [Общие сведения о компоненте ContextMenu](contextmenu-component-overview-windows-forms.md).  
  
-   Создайте форму с автоматически заполненные стандартным меню. Дополнительные сведения см. в разделе [Пошаговое руководство: Создание стандартных пунктов меню для формы](walkthrough-providing-standard-menu-items-to-a-form.md).  
  
-   Создайте форму многодокументного интерфейса (MDI) закрепленный <xref:System.Windows.Forms.ToolStrip> элементов управления. Дополнительные сведения см. в разделе [Как Создание формы MDI путем слияния меню и элементов управления ToolStrip](how-to-create-an-mdi-form-with-menu-merging-and-toolstrip-controls.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.MenuStrip>
- <xref:System.Windows.Forms.ToolStrip>
- <xref:System.Windows.Forms.StatusStrip>
- [Элемент управления ToolStrip](toolstrip-control-windows-forms.md)
- [Практическое руководство. Связывание с формой стандартных элементов меню](how-to-provide-standard-menu-items-to-a-form.md)

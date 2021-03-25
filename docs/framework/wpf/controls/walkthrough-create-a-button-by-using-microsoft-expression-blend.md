---
title: Пошаговое руководство. Создание кнопки с помощью Microsoft Expression Blend
ms.date: 03/30/2017
helpviewer_keywords:
- buttons [WPF]
- converting [WPF], shape to button
- Expression Blend [WPF Designer]
ms.assetid: ff5037c2-bba7-4cae-8abb-6475b686c48e
ms.openlocfilehash: 3cf9d133aee5a2c3d93c1a464c96fdaebcf230f3
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59300465"
---
# <a name="walkthrough-create-a-button-by-using-microsoft-expression-blend"></a>Пошаговое руководство. Создание кнопки с помощью Microsoft Expression Blend
В этом пошаговом руководстве пошагово продемонстрирует процесс создания WPF настраиваемая кнопка, с помощью Microsoft Expression Blend.  
  
> [!IMPORTANT]
>  Microsoft Expression Blend работает путем создания XAML , который затем компилируется для получения исполняемой программы. Если работать с XAML напрямую, есть другой Пошаговое руководство, которое создает то же приложение, как это, используя XAML с Visual Studio, а не в Blend. См. в разделе [Создание кнопки с помощью XAML](walkthrough-create-a-button-by-using-xaml.md) Дополнительные сведения.  
  
 На следующем рисунке настраиваемая кнопка вы создадите.  
  
 ![Настраиваемая кнопка, которая будет создан](./media/custom-button-blend-intro.jpg "custom_button_blend_Intro")  
  
## <a name="convert-a-shape-to-a-button"></a>Преобразование фигуры в кнопку  
 В первой части этого пошагового руководства вы создадите пользовательский вид настраиваемой кнопки. Чтобы сделать это, сначала преобразуйте прямоугольник к кнопке. После этого добавить дополнительные фигуры к шаблону кнопки, создание более сложных внешнего вида кнопки. Почему бы не начать с обычной кнопки и ее настраивать? Поскольку кнопка имеет встроенные функции, не требуется; для пользовательских кнопок проще начать с прямоугольника.  
  
#### <a name="to-create-a-new-project-in-expression-blend"></a>Чтобы создать новый проект в Expression Blend  
  
1. Запустите Expression Blend. (Щелкните **запустить**, пункты **все программы**, пункты **Microsoft Expression**, а затем нажмите кнопку **Microsoft Expression Blend**.)  
  
2. Разверните приложение, при необходимости.  
  
3. В меню **Файл** выберите пункт **Создать проект**.  
  
4. Выберите **стандартное приложение (.exe)**.  
  
5. Назовите проект `CustomButton` и нажмите клавишу **ОК**.  
  
 На этом этапе имеется пустой WPF проекта. Можно нажать F5, чтобы запустить приложение. Как можно догадаться, приложение состоит из пустое окно. Затем создайте прямоугольник с закругленными углами и преобразовать его в кнопку.  
  
#### <a name="to-convert-a-rectangle-to-a-button"></a>Преобразуемый прямоугольник к кнопке  
  
1. **Задайте для свойства фона окна на черный.** Выберите окно, нажмите кнопку **вкладка "Свойства"** и задайте <xref:System.Windows.Controls.Control.Background%2A> свойства `Black`.  
  
     ![Как задать фоновый цвет кнопки на черный](./media/custom-button-blend-changebackground.png "custom_button_blend_ChangeBackground")  
  
2. **Нарисуйте прямоугольник приблизительного размера кнопки в окне:** Выберите прямоугольник на панели инструментов слева и перетащите прямоугольник в окне.  
  
     ![Рисование прямоугольника](./media/custom-button-blend-drawrect.png "custom_button_blend_DrawRect")  
  
3. **Скруглите углы прямоугольника:** Перетащите контрольные точки прямоугольника или непосредственная установка <xref:System.Windows.Shapes.Rectangle.RadiusX%2A> и <xref:System.Windows.Shapes.Rectangle.RadiusY%2A> свойства. Задайте значения свойств <xref:System.Windows.Shapes.Rectangle.RadiusX%2A> и <xref:System.Windows.Shapes.Rectangle.RadiusY%2A> до 20.  
  
     ![Как сделать углов прямоугольника round](./media/custom-button-blend-roundcorners.png "custom_button_blend_RoundCorners")  
  
4. **Измените прямоугольник в кнопке:** Выберите прямоугольник. На **средства** меню, щелкните **создать кнопку**.  
  
     ![Как сделать фигуры в кнопку](./media/custom-button-blend-makebutton.png "custom_button_blend_MakeButton")  
  
5. **Укажите область стиля или шаблона:** Откроется диалоговое окно следующим образом.  
  
     ![Диалоговое окно «Создание ресурса стиля»](./media/custom-button-blend-makebutton2.gif "custom_button_blend_MakeButton2")  
  
     Для **имя ресурса (ключ)** выберите **применить ко всем**.  Это сделает полученного стиля и шаблона кнопки, которые применяются ко всем объектам, которые являются кнопками. Для **определить в**выберите **приложения**. Это сделает полученного стиля и шаблона кнопки имеют область видимости отказа всего приложения. Этот шаблон используется при задании значений в этих двух полей, стиля и шаблона применяются ко всем кнопкам в приложении и любой кнопки, создаваемые в приложении, по умолчанию.  
  
## <a name="edit-the-button-template"></a>Изменение шаблона кнопки  
 Теперь у вас есть прямоугольник, который был изменен на кнопке. В этом разделе вы измените шаблон кнопки и настроить его внешний вид.  
  
#### <a name="to-edit-the-button-template-to-change-the-button-appearance"></a>Чтобы изменить шаблон кнопки, чтобы изменить внешний вид кнопки  
  
1. **Перейдите в представление редактирования шаблона:** Чтобы настроить внешний вид кнопки, необходимо изменить шаблон кнопки. Этот шаблон был создан в результате преобразования прямоугольника в кнопку. Чтобы изменить шаблон кнопки, правой кнопкой мыши и выберите **изменить части элемента управления (шаблон)** и затем **изменить шаблон**.  
  
     ![Изменение шаблона](./media/custom-button-blend-edittemplate.jpg "custom_button_blend_EditTemplate")  
  
     В редакторе шаблона, обратите внимание на то, что теперь делятся на кнопки <xref:System.Windows.Shapes.Rectangle> и <xref:System.Windows.Controls.ContentPresenter>. <xref:System.Windows.Controls.ContentPresenter> Используется для представления содержимого кнопки (например, строка «Кнопка»). Оба прямоугольника и <xref:System.Windows.Controls.ContentPresenter> располагаются внутри <xref:System.Windows.Controls.Grid>.  
  
     ![Компоненты в представлении прямоугольника](./media/custom-button-blend-templatepanel.png "custom_button_blend_TemplatePanel")  
  
2. **Измените имена компонентов шаблона:** Щелкните правой кнопкой мыши прямоугольник в перечне шаблона, изменение <xref:System.Windows.Shapes.Rectangle> имя из «[прямоугольник]» на «скопировав outerRectangle» и измените «[ContentPresenter]» на «myContentPresenter».  
  
     ![Переименование компонента шаблона](./media/custom-button-blend-renamecomponents.png "custom_button_blend_RenameComponents")  
  
3. **ALTER прямоугольника, так как это пустой внутри (например, кольцо):** Выберите **скопировав outerRectangle** и задайте <xref:System.Windows.Shapes.Shape.Fill%2A> «Transparent» и <xref:System.Windows.Shapes.Shape.StrokeThickness%2A> до 5.  
  
     ![Как сделать пустым прямоугольник](./media/custom-button-blend-changerectproperties.png "custom_button_blend_ChangeRectProperties")  
  
     Затем установите <xref:System.Windows.Shapes.Shape.Stroke%2A> все, что шаблон будет цвету. Для этого щелкните небольшой белый квадрат рядом **Stroke**выберите **CustomExpression**и введите «{TemplateBinding фона}» в диалоговом окне.  
  
     ![Как задать использование цвета шаблона](./media/custom-button-blend-templatestroke.png "custom_button_blend_TemplateStroke")  
  
4. **Создайте внутренний прямоугольник:** Теперь создайте другого прямоугольника (назовите его «innerRectangle») и разместите его симметрично внутри **скопировав outerRectangle** . Для такой работы может потребоваться установить масштаб увеличить кнопку в области редактирования.  
  
    > [!NOTE]
    >  Прямоугольник может выглядеть отличается от того, на рисунке (например, он может иметь скругленные углы).  
  
     ![Создание прямоугольника в прямоугольнике](./media/custom-button-blend-innerrectangleproperties.png "custom_button_blend_innerRectangleProperties")  
  
5. **Переместите вверх ContentPresenter:** На этом этапе вполне возможно, что текст «Button» не будет отображаться больше. Если Да, это обусловлено **innerRectangle** — на основе **myContentPresenter**. Чтобы устранить эту проблему, перетащите **myContentPresenter** ниже **innerRectangle**. Изменить положение прямоугольников и **myContentPresenter** чтобы выглядеть аналогично приведенному ниже.  
  
    > [!NOTE]
    >  Кроме того, можно также разместить **myContentPresenter** в верхней части, щелкнув его и нажав клавишу **отправить Далее**.  
  
     ![Перемещение одной кнопки на другую](./media/custom-button-blend-innerrectangle2.png "custom_button_blend_innerRectangle2")  
  
6. **Изменение внешнего вида innerRectangle:** Задайте <xref:System.Windows.Shapes.Rectangle.RadiusX%2A>, <xref:System.Windows.Shapes.Rectangle.RadiusY%2A>, и <xref:System.Windows.Shapes.Shape.StrokeThickness%2A> значения до 20. Кроме того, задайте <xref:System.Windows.Shapes.Shape.Fill%2A> фона для шаблона с помощью пользовательского выражения «{TemplateBinding фона}») и задайте <xref:System.Windows.Shapes.Shape.Stroke%2A> для «прозрачный». Обратите внимание, что параметры для <xref:System.Windows.Shapes.Shape.Fill%2A> и <xref:System.Windows.Shapes.Shape.Stroke%2A> из **innerRectangle** противоположны для **скопировав outerRectangle**.  
  
     ![Как изменить внешний вид прямоугольника](./media/custom-button-blend-glassrectangleproperties1.png "custom_button_blend_glassRectangleProperties1")  
  
7. **Добавьте прозрачный слой в верхней части:** Заключительная часть настройки внешнего вида кнопки является добавление прозрачный слой в верхней части. Этот прозрачный слой состоит из третьего прямоугольника. Так как прозрачный будут рассмотрены всю кнопку, прозрачный прямоугольник аналогична по измерения, которые необходимо **скопировав outerRectangle**. Таким образом, создать прямоугольник, просто копию **скопировав outerRectangle**. Выделите **скопировав outerRectangle** и используйте сочетание клавиш CTRL + C и CTRL + V для создания копии. Назовите этот новый прямоугольник «glassCube».  
  
8. **При необходимости изменить положение glassCube:** Если **glassCube** — еще не находится, чтобы он охватывал весь кнопки, перетащите его в нужное место.  
  
9. **Присвойте glassCube немного другой форме по сравнению скопировав outerRectangle:** Изменение свойств **glassCube**. Начните с изменения <xref:System.Windows.Shapes.Rectangle.RadiusX%2A> и <xref:System.Windows.Shapes.Rectangle.RadiusY%2A> свойства до 10 и <xref:System.Windows.Shapes.Shape.StrokeThickness%2A> до 2.  
  
     ![Параметры отображения для glassCube](./media/custom-button-blend-glasscubeappearance.gif "custom_button_blend_GlassCubeAppearance")  
  
10. **Сделайте glassCube стекла следующий вид:** Задайте <xref:System.Windows.Shapes.Shape.Fill%2A> для стеклянного вида с помощью линейного градиента, который составляет 75% непрозрачный и переключается между белым и прозрачным более чем 6 примерно равномерно расположенных интервалов времени. Это, какое значение позиции градиента:  
  
    -   Ступень градиента 1: Белый цвет с альфа-значение 75%  
  
    -   Ограничение градиента 2: Прозрачный  
  
    -   Ограничение градиента 3: Белый цвет с альфа-значение 75%  
  
    -   Ограничение градиента 4: Прозрачный  
  
    -   Ограничение градиента 5: Белый цвет с альфа-значение 75%  
  
    -   Ограничение градиента 6: Прозрачный  
  
     При этом создается вид «волнистой» прозрачного стекла.  
  
     ![Прямоугольник, который выглядит как стекла](./media/custom-button-blend-glassrectangleproperties2.png "custom_button_blend_glassRectangleProperties2")  
  
11. **Скрыть прозрачный слой:** Теперь, когда вы видите, как выглядит стеклянного слоя, перейдите в **внешний вид области** из **панель "Свойства"** и установить прозрачность 0%, чтобы скрыть его. В разделах мы будем использовать триггеры свойств и событий для отображения и управления прозрачный слой.  
  
     ![Как скрыть прозрачный прямоугольник](./media/custom-button-glassrectangleproperties3.gif "custom_button_glassRectangleProperties3")  
  
## <a name="customize-the-button-behavior"></a>Настройте поведение кнопки  
 На этом этапе вы уже настроили представление кнопки, изменив его шаблона, но кнопка не реагирует на действия пользователя как обычные кнопки (например, изменение внешнего вида при наведении, получает фокус и щелкнув.) В следующих двух процедурах показано как построить таким поведением, как их в настраиваемой кнопки. Мы начнем с простых триггеров свойства и затем добавление триггеров событий и анимации.  
  
#### <a name="to-set-property-triggers"></a>Чтобы задать триггеры свойств  
  
1. **Создайте новый триггер свойства:** С помощью **glassCube** , щелкните **+ свойство** в **триггеры** панели (см. в разделе к рисунку, который следует за следующий шаг). Это создает триггер свойства с триггером свойства по умолчанию.  
  
2. **Создайте свойство IsMouseOver, используемое триггером:** Измените значение свойства на <xref:System.Windows.UIElement.IsMouseOver%2A>. В результате при активации триггера свойств <xref:System.Windows.UIElement.IsMouseOver%2A> свойство `true` (при наведении указателя мыши на кнопку мыши).  
  
     ![Практическое задание триггера свойства](./media/custom-button-blend-ismousedoverpropertytrigger.png "custom_button_blend_IsMousedOverPropertyTrigger")  
  
3. **Непрозрачность 100% для glassCube триггеров IsMouseOver:** Обратите внимание, что **записи триггера** (см. предыдущий рисунок). Это означает, что любые изменения, внесенные в значения свойств **glassCube** во время записи станет действие, происходящее при <xref:System.Windows.UIElement.IsMouseOver%2A> является `true`. Во время записи, изменить <xref:System.Windows.UIElement.Opacity%2A> из **glassCube** до 100%.  
  
     ![Как задать прозрачность кнопки](./media/custom-button-blend-ismousedoverpropertytrigger2.gif "custom_button_blend_IsMousedOverPropertyTrigger2")  
  
     Вы создали первый триггер свойства. Обратите внимание, что **панель "триггеры"** записанные редактора <xref:System.Windows.UIElement.Opacity%2A> изменен на 100%.  
  
     ![Панель “Триггеры”](./media/custom-button-blend-propertytriggerinfo.png "custom_button_blend_PropertyTriggerInfo")  
  
     Нажмите клавишу F5, чтобы запустить приложение и наведите указатель мыши над и кнопки включения и выключения. Вы должны увидеть прозрачный слой отображается, когда вы Наведение указателя мыши для кнопки и исчезают, когда указатель покидает.  
  
4. **Изменение значения штриха триггеров IsMouseOver:** Давайте свяжем некоторые другие действия с <xref:System.Windows.UIElement.IsMouseOver%2A> триггера. Во время записи, переключение сделанный выбор из **glassCube** для **скопировав outerRectangle**. Затем установите <xref:System.Windows.Shapes.Shape.Stroke%2A> из **скопировав outerRectangle** на пользовательское выражение «{DynamicResource {x: Static SystemColors.HighlightBrushKey}}». Этот параметр задает <xref:System.Windows.Shapes.Shape.Stroke%2A> чтобы типичное выделите цвет кнопок. Нажмите клавишу F5, чтобы увидеть результат, когда указатель мыши находится над кнопкой.  
  
     ![Установка штриха цвет выделения для](./media/custom-button-blend-ismousedoverpropertytrigger3.png "custom_button_blend_IsMousedOverPropertyTrigger3")  
  
5. **Размытый текст триггеров IsMouseOver:** Давайте свяжем одного дополнительные действия для <xref:System.Windows.UIElement.IsMouseOver%2A> триггер свойства. Сделайте содержимое кнопки быть немного нечеткими, когда появляется прозрачный над ней. Чтобы сделать это, мы применяем размытия <xref:System.Windows.Media.Effects.BitmapEffect> для <xref:System.Windows.Controls.ContentPresenter> (**myContentPresenter**).  
  
     ![Размытие содержимого кнопки](./media/custom-button-blend-propertytriggerwithbitmapeffect.png "custom_button_blend_PropertyTriggerWithBitMapEffect")  
  
    > [!NOTE]
    >  Для возврата **панель "Свойства"** обратно которое он имел до вас поиск <xref:System.Windows.Media.Effects.BitmapEffect>, удалите текст из **поле поиска**.  
  
     На этом этапе мы использовали триггер свойства с несколькими связанными действиями для создания поведения для, когда указатель мыши входит и покидает область кнопок. Другим обычным поведением для кнопки — Выделить с фокусом (например, после щелчка). Мы можем добавить такое поведение, добавив еще один триггер свойства для <xref:System.Windows.UIElement.IsFocused%2A> свойство.  
  
6. **Создание триггера свойств для IsFocused:** Используя ту же процедуру, что и для <xref:System.Windows.UIElement.IsMouseOver%2A> (см. первый шаг в этом разделе), создайте другой триггер свойства для <xref:System.Windows.UIElement.IsFocused%2A> свойство. Хотя **записи триггера**, добавьте следующие действия в триггер:  
  
    -   **glassCube** получает <xref:System.Windows.UIElement.Opacity%2A> 100%.  
  
    -   **скопировав outerRectangle** получает <xref:System.Windows.Shapes.Shape.Stroke%2A> пользовательское выражение значения «{DynamicResource {x: Static SystemColors.HighlightBrushKey}}».  
  
 Завершающем этапе в этом пошаговом руководстве мы добавим анимации к кнопке. Эти анимации будет вызвано событиями, в частности, <xref:System.Windows.UIElement.MouseEnter> и <xref:System.Windows.Controls.Primitives.ButtonBase.Click> события.  
  
#### <a name="to-use-event-triggers-and-animations-to-add-interactivity"></a>Использование триггеров событий и анимации для обеспечения интерактивности  
  
1. **Создание триггера события MouseEnter:** Добавьте новый триггер события и выберите <xref:System.Windows.UIElement.MouseEnter> как событие для использования в триггере.  
  
     ![Создание триггера события MouseEnter](./media/custom-button-blend-mouseovereventtrigger.png "custom_button_blend_MouseOverEventTrigger")  
  
2. **Создайте временную шкалу анимации.** Теперь необходимо связать временную шкалу анимации для <xref:System.Windows.UIElement.MouseEnter> событий.  
  
     ![Как добавить временную шкалу анимации на событие](./media/custom-button-blend-mouseovereventtrigger2.png "custom_button_blend_MouseOverEventTrigger2")  
  
     После нажатия клавиши **ОК** для создания новой временной шкалы, **временная шкала** отображается и «Временная шкала записи» отображается в панели конструктора. Это означает, что мы можем запустить записи изменений свойств на временной шкале (изменения свойств анимации).  
  
    > [!NOTE]
    >  Может потребоваться изменить размер окна и/или панели для просмотра отображения.  
  
     ![Временная шкала](./media/custom-button-blend-mouseovereventtrigger3.png "custom_button_blend_MouseOverEventTrigger3")  
  
3. **Создание опорного кадра:** Для создания анимации, выделите объект, который вы хотите анимировать, создание двух или более опорные кадры на временной шкале, а также для этих опорных кадров, задайте значения свойств, анимация для интерполяции. Следующий рисунок поможет выполнить создание опорного кадра.  
  
     ![Создание опорного кадра](./media/custom-button-blend-mouseovereventtrigger4.png "custom_button_blend_MouseOverEventTrigger4")  
  
4. **Сжать glassCube в данного опорного кадра:** Второй ключевой кадр выбран, уменьшить размер **glassCube** 90 процентов от его полный размер с помощью **преобразования размер**.  
  
     ![Как уменьшить размер кнопки](./media/custom-button-blend-sizetransform.png "custom_button_blend_SizeTransform")  
  
     Нажмите клавишу F5 для запуска приложения. Наведите указатель мыши на кнопку. Обратите внимание, что прозрачный слой сжимается поверх кнопки.  
  
5. **Создайте еще один триггер события и свяжите с ним другой анимации:** Давайте добавим одну анимацию. Используйте аналогичную процедуру, чтобы вы использовали для создания предыдущей анимации триггера события:  
  
    1.  Создать новый триггер события с помощью <xref:System.Windows.Controls.Primitives.ButtonBase.Click> событий.  
  
    2.  Связать новую временную шкалу с <xref:System.Windows.Controls.Primitives.ButtonBase.Click> событий.  
  
     ![Как создать новую временную шкалу](./media/custom-button-blend-clickeventtrigger1.png "custom_button_blend_ClickEventTrigger1")  
  
    1.  Для этой временной шкалы создайте двумя опорными кадрами, один на 0,0 секунде, а второй на 0.3 секунде.  
  
    2.  Ключевой кадр на 0,3 секунде, установите **угол поворота преобразования** до 360 градусов.  
  
     ![Создание преобразования вращения](./media/custom-button-blend-rotatetransform.gif "custom_button_blend_RotateTransform")  
  
    1.  Нажмите клавишу F5 для запуска приложения. Нажмите кнопку. Обратите внимание, что прозрачный слой вращается.  
  
## <a name="conclusion"></a>Заключение  
 Завершена настройка кнопки. Вы сделали, это с помощью шаблона кнопки, которая была применена ко всем кнопкам в приложении. Если оставить режим редактирования шаблонов (см. следующий рисунок) и создать дополнительные кнопки, вы увидите, что они выглядят и ведут себя подобно настраиваемой кнопки, а не как кнопка по умолчанию.  
  
 ![Шаблон настраиваемой кнопки](./media/custom-button-blend-scopeup.gif "custom_button_blend_ScopeUp")  
  
 ![Несколько кнопок, использующих тот же шаблон](./media/custom-button-blend-createmultiplebuttons.png "custom_button_blend_CreateMultipleButtons")  
  
 Нажмите клавишу F5 для запуска приложения. Нажмите кнопки и обратите внимание на то, как все они ведут себя одинаково.  
  
 Помните, хотя Настройка шаблона, установить <xref:System.Windows.Shapes.Shape.Fill%2A> свойство **innerRectangle** и <xref:System.Windows.Shapes.Shape.Stroke%2A> свойство **скопировав outerRectangle** шаблона фона ({} TemplateBinding фона}). По этой причине при установке цвет фона отдельных кнопок, фон будет использоваться для соответствующих свойств. Попробуйте изменить фон сейчас. На рисунке ниже используются различные градиенты. Таким образом несмотря на то, что шаблон полезен для общей настройки элементов управления, таких как кнопки, элементы управления с помощью шаблонов можно по-прежнему изменить чтобы они отличались друг от друга.  
  
 ![Кнопки с общим шаблоном, найдите другой](./media/custom-button-blend-blendconclusion.jpg "custom_button_blend_BlendConclusion")  
  
 В заключение процедуру настройки шаблона кнопки вы узнали, как для выполните следующие действия в Microsoft Expression Blend:  
  
-   Настройте внешний вид элемента управления.  
  
-   Установка триггеров свойств. Триггеры свойств очень полезны, так как они могут использоваться для большинства объектов, а не только для элементов управления.  
  
-   Установка триггеров событий. Триггеры событий очень полезны, так как они могут использоваться для большинства объектов, а не только для элементов управления.  
  
-   Создание анимаций.  
  
-   Создание градиентов, добавление BitmapEffects, использование преобразований и набор основных свойств объектов.  
  
## <a name="see-also"></a>См. также

- [Создание кнопки с помощью XAML](walkthrough-create-a-button-by-using-xaml.md)
- [Стилизация и использование шаблонов](styling-and-templating.md)
- [Общие сведения об эффектах анимации](../graphics-multimedia/animation-overview.md)
- [Общие сведения о закраске сплошным цветом и градиентом](../graphics-multimedia/painting-with-solid-colors-and-gradients-overview.md)
- [Общие сведения об эффектах для точечных рисунков](../graphics-multimedia/bitmap-effects-overview.md)

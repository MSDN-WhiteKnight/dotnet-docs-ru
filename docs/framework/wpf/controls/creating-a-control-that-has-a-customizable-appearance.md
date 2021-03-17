---
title: Создание элемента управления с настраиваемым внешним видом
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- controls [WPF], customizing
- VisualStateManager [WPF], managing the state of a control
- ControlTemplate [WPF], customizing appearance
- controls [WPF], defining the visual structure and behavior of
- customizing appearance [WPF], ControlTemplate
- managing control states [WPF], VisualStateManager
- VisualStateManager [WPF], best practice
ms.assetid: 9e356d3d-a3d0-4b01-a25f-2d43e4d53fe5
ms.openlocfilehash: a5d7c06502b66298d530d0180ffaf63862b9fc28
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59298348"
---
# <a name="creating-a-control-that-has-a-customizable-appearance"></a>Создание элемента управления с настраиваемым внешним видом
<a name="introduction"></a>
[!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] дает возможность создать внешний вид которых можно настроить элемент управления. Например, можно изменить внешний вид <xref:System.Windows.Controls.CheckBox> Кроме какие настройки свойств будет сделать путем создания нового <xref:System.Windows.Controls.ControlTemplate>. На следующем рисунке показано <xref:System.Windows.Controls.CheckBox> , по умолчанию использует <xref:System.Windows.Controls.ControlTemplate> и <xref:System.Windows.Controls.CheckBox> , использующий пользовательский <xref:System.Windows.Controls.ControlTemplate>.  
  
 ![Флажок с шаблоном элемента управления по умолчанию. ](./media/ndp-checkboxdefault.png "NDP_CheckBoxDefault")  
Элемент управления CheckBox, использующий шаблон элемента управления по умолчанию  
  
 ![Флажок с пользовательским шаблоном элемента управления. ](./media/ndp-checkboxcustom.png "NDP_CheckBoxCustom")  
Элемент управления CheckBox, использующий пользовательский шаблон элемента управления  
  
 Если вы следуете части и состояния модели, при создании элемента управления, внешнего вида элемента управления будет настраиваемым. Средства конструктора, таких как Microsoft Expression Blend поддерживает части и состояния модели, поэтому при выполнении этой модели элемент управления будет можно настраивать в таких типах приложений.  В этом разделе описывается, части и состояния модели и как следовать ему при создании собственного элемента управления. В этом разделе используется пример пользовательского элемента управления, `NumericUpDown`для иллюстрации идеи, лежащие в этой модели.  `NumericUpDown` Элемент управления отображает числовое значение, которое пользователь может увеличить или уменьшить, нажимая кнопки элемента управления.  На следующем рисунке показано `NumericUpDown` элемент управления, который рассматривается в этом разделе.  
  
 ![Пользовательский элемент управления NumericUpDown. ](./media/ndp-numericupdown.png "NDP_NumericUPDown")  
Пользовательский элемент управления NumericUpDown  
  
 В этом разделе содержатся следующие подразделы.  
  
-   [Предварительные требования](#prerequisites)  
  
-   [Модель частей и состояний](#parts_and_states_model)  
  
-   [Определение визуальную структуру и визуальное поведение элемента управления в ControlTemplate](#defining_the_visual_structure_and_visual_behavior_of_a_control_in_a_controltemplate)  
  
-   [Части шаблона элемента управления в коде](#using_parts_of_the_controltemplate_in_code)  
  
-   [Предоставление контракта элемента управления](#providing_the_control_contract)  
  
-   [Полный пример](#complete_example)  
  
<a name="prerequisites"></a>   
## <a name="prerequisites"></a>Предварительные требования  
 В этом разделе предполагается, что вы знаете, как создать новую <xref:System.Windows.Controls.ControlTemplate> для существующего элемента управления, уже есть опыт каковы элементы в контракте элемента управления и понимать концепции, описанные в [Настройка внешнего вида существующего элемента управления, Создания объекта ControlTemplate](customizing-the-appearance-of-an-existing-control.md).  
  
> [!NOTE]
>  Чтобы создать элемент управления, который может быть настраиваемым внешним видом, необходимо создать элемент управления, который наследует от <xref:System.Windows.Controls.Control> класс или один из его подклассов, отличных от <xref:System.Windows.Controls.UserControl>.  Элемент управления, который наследует от <xref:System.Windows.Controls.UserControl> является элементом управления, можно создать очень быстро, но он не использует <xref:System.Windows.Controls.ControlTemplate> и не может настроить его внешний вид.  
  
<a name="parts_and_states_model"></a>   
## <a name="parts-and-states-model"></a>Модель частей и состояний  
 Части и состояния модели указывает способ определения визуальную структуру и визуальное поведение элемента управления. Чтобы выполнить части и состояния модели, поступайте следующим:  
  
-   Определите визуальную структуру и визуальное поведение в <xref:System.Windows.Controls.ControlTemplate> элемента управления.  
  
-   Выполните определенные рекомендации, когда логика элемента управления взаимодействует с частями шаблона элемента управления.  
  
-   Укажите контракт элемента управления, чтобы указать, что должны быть включены в <xref:System.Windows.Controls.ControlTemplate>.  
  
 При определении визуальную структуру и визуальное поведение в <xref:System.Windows.Controls.ControlTemplate> элемента управления, разработчики приложения могут изменять визуальную структуру и визуальное поведение элемента управления путем создания нового <xref:System.Windows.Controls.ControlTemplate> вместо написания кода.   Необходимо предоставить разработчикам контракт элемента управления, который сообщает приложению о том, какие <xref:System.Windows.FrameworkElement> объектов и состояний должны быть определены в <xref:System.Windows.Controls.ControlTemplate>. Вы должны следовать некоторым рекомендациям при взаимодействии с частями в <xref:System.Windows.Controls.ControlTemplate> таким образом, элемент управления правильно обрабатывал неполное <xref:System.Windows.Controls.ControlTemplate>.  Если вы следуете этим трем принципам, разработчики приложений будут иметь возможность создавать <xref:System.Windows.Controls.ControlTemplate> для элемента управления просто так же легко, как только они могут для элементов управления, поставляемые с [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)].  В следующем разделе объясняется каждый из этих рекомендаций, подробно.  
  
<a name="defining_the_visual_structure_and_visual_behavior_of_a_control_in_a_controltemplate"></a>   
## <a name="defining-the-visual-structure-and-visual-behavior-of-a-control-in-a-controltemplate"></a>Определение визуальную структуру и визуальное поведение элемента управления в ControlTemplate  
 При создании пользовательского элемента управления с помощью модели части и состояния, определении визуальную структуру и визуальное поведение элемента управления его <xref:System.Windows.Controls.ControlTemplate> вместо в своей логике.  Визуальную структуру элемента управления состоит из <xref:System.Windows.FrameworkElement> объекты, составляющие элемента управления.  Визуальное поведение — это способ отображения элемента управления, когда он находится в определенном состоянии.   Дополнительные сведения о создании <xref:System.Windows.Controls.ControlTemplate> , который указывает визуальную структуру и визуальное поведение элемента управления, см. в разделе [Настройка внешнего вида существующего элемента управления путем создания объекта ControlTemplate](customizing-the-appearance-of-an-existing-control.md).  
  
 В примере `NumericUpDown` элемента управления, визуальная структура включает в себя два <xref:System.Windows.Controls.Primitives.RepeatButton> элементов управления и <xref:System.Windows.Controls.TextBlock>.  При добавлении этих элементов управления в коде `NumericUpDown` управления--в конструкторе, например положение этих элементов управления может быть неизменяемым.  Вместо определения визуальную структуру и визуальное поведение элемента управления в его код, можно задать его в <xref:System.Windows.Controls.ControlTemplate>.  Затем разработчик приложения может настроить расположение кнопок и <xref:System.Windows.Controls.TextBlock> и указать поведение при `Value` отрицательное поскольку <xref:System.Windows.Controls.ControlTemplate> можно заменить.  
  
 Следующий пример показывает визуальную структуру элемента `NumericUpDown` элемент управления, который включает в себя <xref:System.Windows.Controls.Primitives.RepeatButton> для увеличения `Value`, <xref:System.Windows.Controls.Primitives.RepeatButton> уменьшение `Value`и <xref:System.Windows.Controls.TextBlock> для отображения `Value`.  
  
 [!code-xaml[VSMCustomControl#VisualStructure](~/samples/snippets/csharp/VS_Snippets_Wpf/vsmcustomcontrol/csharp/window1.xaml#visualstructure)]  
  
 Визуальное поведение элемента `NumericUpDown` элемент управления является то, что значение является красным цветом, если отрицательное.  При изменении <xref:System.Windows.Controls.TextBlock.Foreground%2A> из <xref:System.Windows.Controls.TextBlock> в программном коде `Value` отрицательное, `NumericUpDown` всегда будет отображаться красный отрицательное значение. Укажите визуальное поведение элемента управления в <xref:System.Windows.Controls.ControlTemplate> , добавив <xref:System.Windows.VisualState> объектов <xref:System.Windows.Controls.ControlTemplate>.  В следующем примере показан <xref:System.Windows.VisualState> объектов для `Positive` и `Negative` состояний.  `Positive` и `Negative` являются взаимоисключающими (элемент управления всегда находится в одном из двух), поэтому в примере <xref:System.Windows.VisualState> объекты в единую <xref:System.Windows.VisualStateGroup>.  Когда элемент управления переходит в `Negative` состояние, <xref:System.Windows.Controls.TextBlock.Foreground%2A> из <xref:System.Windows.Controls.TextBlock> станет красным.  Если элемент управления находится в `Positive` состояние, <xref:System.Windows.Controls.TextBlock.Foreground%2A> ему возвращается исходное значение.  Определение <xref:System.Windows.VisualState> объекты в <xref:System.Windows.Controls.ControlTemplate> подробнее рассматривается в [Настройка внешнего вида существующего элемента управления путем создания объекта ControlTemplate](customizing-the-appearance-of-an-existing-control.md).  
  
> [!NOTE]
>  Не забудьте задать <xref:System.Windows.VisualStateManager.VisualStateGroups%2A?displayProperty=nameWithType> присоединенного свойства в корне <xref:System.Windows.FrameworkElement> из <xref:System.Windows.Controls.ControlTemplate>.  
  
 [!code-xaml[VSMCustomControl#ValueStates](~/samples/snippets/csharp/VS_Snippets_Wpf/vsmcustomcontrol/csharp/window1.xaml#valuestates)]  
  
<a name="using_parts_of_the_controltemplate_in_code"></a>   
## <a name="using-parts-of-the-controltemplate-in-code"></a>Части шаблона элемента управления в коде  
 Объект <xref:System.Windows.Controls.ControlTemplate> автор может опустить <xref:System.Windows.FrameworkElement> или <xref:System.Windows.VisualState> объектов, намеренно или по ошибке, но логика элемента управления могут понадобиться эти части правильной. Модель части и состояния указывает, что элемент управления должен быть устойчив к <xref:System.Windows.Controls.ControlTemplate> , где отсутствует <xref:System.Windows.FrameworkElement> или <xref:System.Windows.VisualState> объектов.  Элемент управления не должны вызывать исключение или сообщение ошибку если <xref:System.Windows.FrameworkElement>, <xref:System.Windows.VisualState>, или <xref:System.Windows.VisualStateGroup> отсутствует <xref:System.Windows.Controls.ControlTemplate>. В этом разделе описываются рекомендации по взаимодействию с <xref:System.Windows.FrameworkElement> объектов и управление состояниями.  
  
### <a name="anticipate-missing-frameworkelement-objects"></a>Предвидеть отсутствие FrameworkElement объектов  
 При определении <xref:System.Windows.FrameworkElement> объекты в <xref:System.Windows.Controls.ControlTemplate>, логика элемента управления может потребоваться взаимодействовать с некоторыми из них.  Например `NumericUpDown` управления подписывается на кнопки <xref:System.Windows.Controls.Primitives.ButtonBase.Click> событий, чтобы увеличить или уменьшить `Value` и задает <xref:System.Windows.Controls.TextBlock.Text%2A> свойство <xref:System.Windows.Controls.TextBlock> для `Value`. Если пользовательский <xref:System.Windows.Controls.ControlTemplate> опускает <xref:System.Windows.Controls.TextBlock> или кнопки, это допустимо, что элемент управления теряет часть ее функциональных возможностей, но следует убедиться, что элемент управления не вызывает ошибку. Например если <xref:System.Windows.Controls.ControlTemplate> не содержит кнопки для изменения `Value`, `NumericUpDown` теряет свою функциональность, но приложение, использующее <xref:System.Windows.Controls.ControlTemplate> будет продолжать работу.  
  
 Следующие рекомендации убедитесь, что элемент управления правильно реагирует на отсутствует <xref:System.Windows.FrameworkElement> объектов:  
  
1. Задайте `x:Name` атрибут для каждого <xref:System.Windows.FrameworkElement> , необходимо ссылаться в коде.  
  
2. Определите частные свойства для каждого <xref:System.Windows.FrameworkElement> , вам понадобится взаимодействовать с.  
  
3. Подписаться и Отмена подписки на события, которые обрабатывает элемент управления в <xref:System.Windows.FrameworkElement> доступа set свойства.  
  
4. Задайте <xref:System.Windows.FrameworkElement> свойства, которые были определены на этапе 2 в <xref:System.Windows.FrameworkElement.OnApplyTemplate%2A> метод. Это связано с самой ранней, <xref:System.Windows.FrameworkElement> в <xref:System.Windows.Controls.ControlTemplate> доступен для элемента управления. Используйте `x:Name` из <xref:System.Windows.FrameworkElement> для получения их из <xref:System.Windows.Controls.ControlTemplate>.  
  
5. Убедитесь, что <xref:System.Windows.FrameworkElement> не `null` перед обращением к их элементам.  Если это `null`, не сообщает об ошибке.  
  
 В следующих примерах показывается как `NumericUpDown` элемент управления взаимодействует с <xref:System.Windows.FrameworkElement> объектов в соответствии с рекомендациями в списке выше.  
  
 В примере, который определяет визуальную структуру элемента `NumericUpDown` контролировать <xref:System.Windows.Controls.ControlTemplate>, <xref:System.Windows.Controls.Primitives.RepeatButton> , увеличивающий `Value` имеет его `x:Name` атрибут `UpButton`.  В следующем примере объявляется свойство с именем `UpButtonElement` , представляющий <xref:System.Windows.Controls.Primitives.RepeatButton> , объявленным в <xref:System.Windows.Controls.ControlTemplate>. `set` Доступа сначала отменяет подписку на кнопку <xref:System.Windows.Controls.Primitives.ButtonBase.Click> событий Если `UpDownElement` не `null`, задает свойство, и затем подписывается на <xref:System.Windows.Controls.Primitives.ButtonBase.Click> событий. Также имеется свойство определен, но не отображается, для других <xref:System.Windows.Controls.Primitives.RepeatButton>, который называется `DownButtonElement`.  
  
 [!code-csharp[VSMCustomControl#UpButtonProperty](~/samples/snippets/csharp/VS_Snippets_Wpf/vsmcustomcontrol/csharp/numericupdown.cs#upbuttonproperty)]
 [!code-vb[VSMCustomControl#UpButtonProperty](~/samples/snippets/visualbasic/VS_Snippets_Wpf/vsmcustomcontrol/visualbasic/numericupdown.vb#upbuttonproperty)]  
  
 В следующем примере показан <xref:System.Windows.FrameworkElement.OnApplyTemplate%2A> для `NumericUpDown` элемента управления.  В примере используется <xref:System.Windows.FrameworkElement.GetTemplateChild%2A> метод для получения <xref:System.Windows.FrameworkElement> объектов из <xref:System.Windows.Controls.ControlTemplate>.  Обратите внимание, что в примере предотвращаются ситуации, когда <xref:System.Windows.FrameworkElement.GetTemplateChild%2A> находит <xref:System.Windows.FrameworkElement> с указанным именем, которое не относится к ожидаемому типу. Это также рекомендуемый способ игнорирования элементов, имеющих указанный `x:Name` , но имеет неправильный тип.  
  
 [!code-csharp[VSMCustomControl#ApplyTemplate](~/samples/snippets/csharp/VS_Snippets_Wpf/vsmcustomcontrol/csharp/numericupdown.cs#applytemplate)]
 [!code-vb[VSMCustomControl#ApplyTemplate](~/samples/snippets/visualbasic/VS_Snippets_Wpf/vsmcustomcontrol/visualbasic/numericupdown.vb#applytemplate)]  
  
 Следуя рекомендациям, показанные в предыдущих примерах, убедитесь, что элемент управления будет продолжать выполняться, когда <xref:System.Windows.Controls.ControlTemplate> отсутствует <xref:System.Windows.FrameworkElement>.  
  
### <a name="use-the-visualstatemanager-to-manage-states"></a>Использование VisualStateManager для управления состояниями  
 <xref:System.Windows.VisualStateManager> Отслеживает состояния элемента управления и выполняет логику, необходимую для перехода между состояниями. При добавлении <xref:System.Windows.VisualState> объектов <xref:System.Windows.Controls.ControlTemplate>, их следует добавить <xref:System.Windows.VisualStateGroup> и добавьте <xref:System.Windows.VisualStateGroup> для <xref:System.Windows.VisualStateManager.VisualStateGroups%2A?displayProperty=nameWithType> вложенного свойства зависимостей, чтобы <xref:System.Windows.VisualStateManager> имеет доступ к ним.  
  
 В следующем примере повторяется предыдущий пример, в котором показано <xref:System.Windows.VisualState> объекты, которые соответствуют `Positive` и `Negative` состояний элемента управления. <xref:System.Windows.Media.Animation.Storyboard> В `Negative`<xref:System.Windows.VisualState> включает <xref:System.Windows.Controls.TextBlock.Foreground%2A> из <xref:System.Windows.Controls.TextBlock> красным.   Когда `NumericUpDown` элемент управления находится в `Negative` state, раскадровки в `Negative` состояние начинается.  Затем <xref:System.Windows.Media.Animation.Storyboard> в `Negative` состояние останавливается, когда элемент управления возвращается `Positive` состояния.  `Positive`<xref:System.Windows.VisualState> Не содержать <xref:System.Windows.Media.Animation.Storyboard> так как при <xref:System.Windows.Media.Animation.Storyboard> для `Negative` останавливается, <xref:System.Windows.Controls.TextBlock.Foreground%2A> возвращает исходного цвета.  
  
 [!code-xaml[VSMCustomControl#ValueStates](~/samples/snippets/csharp/VS_Snippets_Wpf/vsmcustomcontrol/csharp/window1.xaml#valuestates)]  
  
 Обратите внимание, что <xref:System.Windows.Controls.TextBlock> присваивается имя, но <xref:System.Windows.Controls.TextBlock> не находится в контракте элемента управления для `NumericUpDown` так как логика элемента управления никогда не ссылается на <xref:System.Windows.Controls.TextBlock>.  Элементы, которые упоминаются в <xref:System.Windows.Controls.ControlTemplate> имеют имена, но не обязательно должны быть частью контракта элемента управления, так как новый <xref:System.Windows.Controls.ControlTemplate> для элемента управления не может потребоваться ссылка на этот элемент.  Например, человек, который создает новую <xref:System.Windows.Controls.ControlTemplate> для `NumericUpDown` может решить указать, что не `Value` путем изменения <xref:System.Windows.Controls.Control.Foreground%2A>.  В этом случае ни код, ни <xref:System.Windows.Controls.ControlTemplate> ссылки <xref:System.Windows.Controls.TextBlock> по имени.  
  
 Логика элемента управления отвечает за изменение состояния элемента управления. В следующем примере показано, что `NumericUpDown` контролирующие вызовы, <xref:System.Windows.VisualStateManager.GoToState%2A> метод в `Positive` состояние при `Value` 0 или больше и `Negative` состояние при `Value` меньше 0.  
  
 [!code-csharp[VSMCustomControl#ValueStateChange](~/samples/snippets/csharp/VS_Snippets_Wpf/vsmcustomcontrol/csharp/numericupdown.cs#valuestatechange)]
 [!code-vb[VSMCustomControl#ValueStateChange](~/samples/snippets/visualbasic/VS_Snippets_Wpf/vsmcustomcontrol/visualbasic/numericupdown.vb#valuestatechange)]  
  
 <xref:System.Windows.VisualStateManager.GoToState%2A> Метод выполняет логику, необходимую для запуска и остановки раскадровки соответствующим образом. Когда элемент управления вызывает <xref:System.Windows.VisualStateManager.GoToState%2A> для изменения его состояния <xref:System.Windows.VisualStateManager> делает следующее:  
  
-   Если <xref:System.Windows.VisualState> требуется элемент управления имеет <xref:System.Windows.Media.Animation.Storyboard>, раскадровки. Затем, если <xref:System.Windows.VisualState> откуда элемент управления имеет <xref:System.Windows.Media.Animation.Storyboard>, завершения раскадровки.  
  
-   Если элемент управления уже находится в состоянии, которое указано, <xref:System.Windows.VisualStateManager.GoToState%2A> не предпринимает никаких действий и возвращает `true`.  
  
-   Если указанное состояние не существует в <xref:System.Windows.Controls.ControlTemplate> из `control`, <xref:System.Windows.VisualStateManager.GoToState%2A> не предпринимает никаких действий и возвращает `false`.  
  
#### <a name="best-practices-for-working-with-the-visualstatemanager"></a>Рекомендации по работе с VisualStateManager  
 Рекомендуется выполнить следующую команду, чтобы поддерживать состояний элемента управления.  
  
-   Свойства можно используйте для отслеживания состояния.  
  
-   Создайте вспомогательный метод для перехода между состояниями.  
  
 `NumericUpDown` Управления использует его `Value` свойства для отслеживания, является ли он в `Positive` или `Negative` состояния.  `NumericUpDown` Управления также определяет `Focused` и `UnFocused` очевидно из записей <xref:System.Windows.UIElement.IsFocused%2A> свойство. Если вы используете состояния, которые не соответствуют естественным образом свойство элемента управления, можно определить частное свойство для отслеживания состояния.  
  
 Один метод, который обновляет все состояния, централизованно выполняет вызовы <xref:System.Windows.VisualStateManager> и сохраняет код управляемым. В следующем примере показан `NumericUpDown` вспомогательный метод элемента управления, `UpdateStates`. Когда `Value` больше или равно 0, <xref:System.Windows.Controls.Control> в `Positive` состояние.  Когда `Value` — меньше 0, элемент управления находится в `Negative` состояние.  Когда <xref:System.Windows.UIElement.IsFocused%2A> — `true`, элемент управления находится в `Focused` состояния; в противном случае он находится в `Unfocused` состояние.  Элемент управления может вызывать `UpdateStates` каждый раз, когда необходимо изменить свое состояние, независимо от состояния.  
  
 [!code-csharp[VSMCustomControl#UpdateStates](~/samples/snippets/csharp/VS_Snippets_Wpf/vsmcustomcontrol/csharp/numericupdown.cs#updatestates)]
 [!code-vb[VSMCustomControl#UpdateStates](~/samples/snippets/visualbasic/VS_Snippets_Wpf/vsmcustomcontrol/visualbasic/numericupdown.vb#updatestates)]  
  
 Если передать имя состояния для <xref:System.Windows.VisualStateManager.GoToState%2A> когда элемент управления уже находится в этом состоянии <xref:System.Windows.VisualStateManager.GoToState%2A> ничего не делает, поэтому не нужно проверить текущее состояние элемента управления.  Например если `Value` изменяется от одного отрицательного числа на другое отрицательное число, раскадровка для `Negative` состояние не прерывается, и пользователь не увидит изменений в элементе управления.  
  
 <xref:System.Windows.VisualStateManager> Использует <xref:System.Windows.VisualStateGroup> объектов, чтобы определить, какое состояние, чтобы завершить работу при вызове <xref:System.Windows.VisualStateManager.GoToState%2A>. Элемент управления всегда находится в одном состоянии для каждой <xref:System.Windows.VisualStateGroup> , определенный в его <xref:System.Windows.Controls.ControlTemplate> и покидает это состояние только при переходе в другое состояние с использованием того же <xref:System.Windows.VisualStateGroup>. Например <xref:System.Windows.Controls.ControlTemplate> из `NumericUpDown` управления определяет `Positive` и `Negative`<xref:System.Windows.VisualState> объектов в одном <xref:System.Windows.VisualStateGroup> и `Focused` и `Unfocused`<xref:System.Windows.VisualState> объекты в другой. (Вы увидите `Focused` и `Unfocused`<xref:System.Windows.VisualState> определенные в [полный пример](#complete_example) в этой статье, когда элемент управления переходит из `Positive` состояние `Negative` состояние, или наоборот, элемент управления остается в либо `Focused` или `Unfocused` состояния.  
  
 Существует три типичные места, где может изменить состояние элемента управления:  
  
-   Когда <xref:System.Windows.Controls.ControlTemplate> применяется к <xref:System.Windows.Controls.Control>.  
  
-   При изменении свойства.  
  
-   При возникновении события.  
  
 В следующих примерах демонстрируется обновление состояния `NumericUpDown` элемента управления в таких случаях.  
  
 Необходимо обновить состояние элемента управления в <xref:System.Windows.FrameworkElement.OnApplyTemplate%2A> метод отображения элемента управления в правильное состояние при <xref:System.Windows.Controls.ControlTemplate> применяется. В следующем примере вызывается `UpdateStates` в <xref:System.Windows.FrameworkElement.OnApplyTemplate%2A> чтобы убедиться в правильности состояния элемента управления.  Например, предположим, создаваемые `NumericUpDown` и затем задать его <xref:System.Windows.Controls.Control.Foreground%2A> зеленый цвет и `Value` значению -5.  Если вы не вызываете `UpdateStates` при <xref:System.Windows.Controls.ControlTemplate> применяется к `NumericUpDown` элемент управления, элемент управления отсутствует в `Negative` состояние и значение отображается зеленым цветом, вместо red.  Необходимо вызвать `UpdateStates` для размещения этого элемента управления `Negative` состояние.  
  
 [!code-csharp[VSMCustomControl#ApplyTemplate](~/samples/snippets/csharp/VS_Snippets_Wpf/vsmcustomcontrol/csharp/numericupdown.cs#applytemplate)]
 [!code-vb[VSMCustomControl#ApplyTemplate](~/samples/snippets/visualbasic/VS_Snippets_Wpf/vsmcustomcontrol/visualbasic/numericupdown.vb#applytemplate)]  
  
 Часто требуется для обновления состояния элемента управления при изменении свойства. В следующем примере показан весь `ValueChangedCallback` метод. Так как `ValueChangedCallback` вызывается, когда `Value` изменяется, вызывается метод `UpdateStates` в случае, если `Value` изменилось с положительным, отрицательным или наоборот. Это допустимо для вызова `UpdateStates` при `Value` изменяется, но остается положительным или отрицательным, поскольку в этом случае элемент управления не изменяет состояние.  
  
 [!code-csharp[VSMCustomControl#EntireValueChangedCallback](~/samples/snippets/csharp/VS_Snippets_Wpf/vsmcustomcontrol/csharp/numericupdown.cs#entirevaluechangedcallback)]
 [!code-vb[VSMCustomControl#EntireValueChangedCallback](~/samples/snippets/visualbasic/VS_Snippets_Wpf/vsmcustomcontrol/visualbasic/numericupdown.vb#entirevaluechangedcallback)]  
  
 Может также потребоваться обновить состояния при возникновении события. В следующем примере показано, что `NumericUpDown` вызовы `UpdateStates` на <xref:System.Windows.Controls.Control> для обработки <xref:System.Windows.UIElement.GotFocus> событий.  
  
 [!code-csharp[VSMCustomControl#OnGotFocus](~/samples/snippets/csharp/VS_Snippets_Wpf/vsmcustomcontrol/csharp/numericupdown.cs#ongotfocus)]
 [!code-vb[VSMCustomControl#OnGotFocus](~/samples/snippets/visualbasic/VS_Snippets_Wpf/vsmcustomcontrol/visualbasic/numericupdown.vb#ongotfocus)]  
  
 <xref:System.Windows.VisualStateManager> Помогает управлять состояний элемента управления. С помощью <xref:System.Windows.VisualStateManager>, убедитесь, что элемент управления правильные переходы между состояниями.  Если вы выполните рекомендации, описанные в этом разделе, для работы с <xref:System.Windows.VisualStateManager>, код элемента управления будет оставаться читаемым и простым в обслуживании.  
  
<a name="providing_the_control_contract"></a>   
## <a name="providing-the-control-contract"></a>Предоставление контракта элемента управления  
 Укажите контракт элемента управления, чтобы <xref:System.Windows.Controls.ControlTemplate> авторы будет знать, какие нужно указать в шаблоне. Контракт элемента управления имеет три элемента:  
  
-   визуальный элемент, используемый логикой элемента управления;  
  
-   состояния элемента управления и группа, к которой принадлежит каждое состояние;  
  
-   общие свойства, визуально воздействующие на элемент управления.  
  
 Кто-то, которое создает новый <xref:System.Windows.Controls.ControlTemplate> должен знать, что <xref:System.Windows.FrameworkElement> объектов логикой элемента управления, новые типы этих объектов и их имена. Объект <xref:System.Windows.Controls.ControlTemplate> автор также необходимо знать имя каждого возможного состояния элемента управления, а какие <xref:System.Windows.VisualStateGroup> состояние имеет значение.  
  
 Возвращаясь к `NumericUpDown` примере элемент управления ожидает <xref:System.Windows.Controls.ControlTemplate> быть следующие <xref:System.Windows.FrameworkElement> объектов:  
  
-   Объект <xref:System.Windows.Controls.Primitives.RepeatButton> вызывается `UpButton`.  
  
-   Объект <xref:System.Windows.Controls.Primitives.RepeatButton> вызывается `DownButton.`  
  
 Размер элемента управления можно в следующих состояниях:  
  
-   В поле `ValueStates`<xref:System.Windows.VisualStateGroup>  
  
    -   `Positive`  
  
    -   `Negative`  
  
-   В поле `FocusStates`<xref:System.Windows.VisualStateGroup>  
  
    -   `Focused`  
  
    -   `Unfocused`  
  
 Указать, что <xref:System.Windows.FrameworkElement> ожидает, что объекты элемента управления, использовать <xref:System.Windows.TemplatePartAttribute>, который указывает имя и тип ожидаемых элементов.  Для указания возможных состояний элемента управления, используется <xref:System.Windows.TemplateVisualStateAttribute>, который указывает имя состояния, а какие <xref:System.Windows.VisualStateGroup> он принадлежит.  Поместите <xref:System.Windows.TemplatePartAttribute> и <xref:System.Windows.TemplateVisualStateAttribute> в определении класса элемента управления.  
  
 Любое открытое свойство, которое влияет на внешний вид элемента управления также является частью контракта элемента управления.  
  
 В следующем примере задается <xref:System.Windows.FrameworkElement> объекта и состояний для `NumericUpDown` элемента управления.  
  
 [!code-csharp[VSMCustomControl#ControlContract](~/samples/snippets/csharp/VS_Snippets_Wpf/vsmcustomcontrol/csharp/numericupdown.cs#controlcontract)]
 [!code-vb[VSMCustomControl#ControlContract](~/samples/snippets/visualbasic/VS_Snippets_Wpf/vsmcustomcontrol/visualbasic/numericupdown.vb#controlcontract)]  
  
<a name="complete_example"></a>   
## <a name="complete-example"></a>Полный пример  
 Ниже приведен весь <xref:System.Windows.Controls.ControlTemplate> для `NumericUpDown` элемента управления.  
  
 [!code-xaml[VSMCustomControl#NUDTemplate](~/samples/snippets/csharp/VS_Snippets_Wpf/vsmcustomcontrol/csharp/themes/generic.xaml#nudtemplate)]  
  
 В следующем примере показано логику для `NumericUpDown`.  
  
 [!code-csharp[VSMCustomControl#ControlLogic](~/samples/snippets/csharp/VS_Snippets_Wpf/vsmcustomcontrol/csharp/numericupdown.cs#controllogic)]
 [!code-vb[VSMCustomControl#ControlLogic](~/samples/snippets/visualbasic/VS_Snippets_Wpf/vsmcustomcontrol/visualbasic/numericupdown.vb#controllogic)]  
  
## <a name="see-also"></a>См. также

- [Настройка внешнего вида существующего элемента управления путем создания объекта ControlTemplate](customizing-the-appearance-of-an-existing-control.md)
- [Настройка элементов управления](control-customization.md)

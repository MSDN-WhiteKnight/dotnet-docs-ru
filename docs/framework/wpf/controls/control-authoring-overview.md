---
title: Общие сведения о разработке элементов управления
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- controls [WPF], authoring overview
- authoring overview for controls [WPF]
ms.assetid: 3d864748-cff0-4e63-9b23-d8e5a635b28f
ms.openlocfilehash: bb35a4d47f583aad710e178bdb12cb9adf6321e0
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59340026"
---
# <a name="control-authoring-overview"></a>Общие сведения о разработке элементов управления
Расширяемость модели элементов управления Windows Presentation Foundation (WPF) значительно уменьшает необходимость создания новых элементов управления. Однако в некоторых случаях может потребоваться создать пользовательский элемент управления. В этом разделе обсуждаются функции, которые уменьшают необходимость создания пользовательских элементов управления, а также различные модели создания элементов управления в Windows Presentation Foundation (WPF). Также здесь демонстрируется создание нового элемента управления.  

<a name="when_to_write_a_new_control"></a>   
## <a name="alternatives-to-writing-a-new-control"></a>Альтернативы написанию нового элемента управления  
 Исторически сложилось, что если нужно настроить вид существующего элемента управления, то ограничиваются изменением его стандартных свойств, таких как цвет фона, ширина границы и размер шрифта. Если необходимо расширить внешний вид или поведение элемента управления за пределы этих предопределенных параметров, то необходимо создать новый элемент управления, как правило, путем наследования от существующего элемента управления и переопределения метода, ответственного за отрисовку элемента управления.  Кроме того, WPF позволяет настраивать существующие элементы управления с помощью модели форматированного содержимого, стилей, шаблонов и триггеров. Ниже представлены примеры использования этих функций для создания настраиваемых и согласованных функциональных возможностей без необходимости создания нового элемента управления.  
  
-   **Форматированное содержимое.** Многие стандартные элементы управления WPF поддерживают форматированное содержимое. Например, свойство содержимого <xref:System.Windows.Controls.Button> имеет тип <xref:System.Object>, поэтому теоретически все может отображаться на <xref:System.Windows.Controls.Button>.  Чтобы в кнопке отображалось изображение и текст, можно добавить изображение и <xref:System.Windows.Controls.TextBlock> для <xref:System.Windows.Controls.StackPanel> и назначить <xref:System.Windows.Controls.StackPanel> для <xref:System.Windows.Controls.ContentControl.Content%2A> свойство. Поскольку элементы управления могут отображать визуальные элементы WPF и произвольные данные, это уменьшает необходимость создания нового элемента управления или изменения существующего для поддержки сложной визуализации. Дополнительные сведения о модели содержимого для <xref:System.Windows.Controls.Button> и других моделях содержимого в WPF, см. в разделе [модель содержимого WPF](wpf-content-model.md).  
  
-   **Стили.** Объект <xref:System.Windows.Style> — это совокупность значений, представляющих свойства для элемента управления. С помощью стилей можно создать повторно используемое представление нужного внешнего вида и поведения элемента управления без написания нового элемента управления. Например, предположим, что все ваши <xref:System.Windows.Controls.TextBlock> элементам управления иметь красный, сделанные шрифтом Arial с размером шрифта из 14. Можно создать стиль как ресурс и задать соответствующие свойства. Каждый <xref:System.Windows.Controls.TextBlock> добавить в приложение будет выглядеть одинаково.  
  
-   **Шаблоны данных.** Объект <xref:System.Windows.DataTemplate> позволяет настроить способ отображения данных в элементе управления. Например <xref:System.Windows.DataTemplate> может использоваться для указания способа отображения данных в <xref:System.Windows.Controls.ListBox>.  Пример см. в разделе [Общие сведения о шаблонах данных](../data/data-templating-overview.md).  В дополнение к настройке внешнего вида данных, <xref:System.Windows.DataTemplate> может включать элементы пользовательского интерфейса, который обеспечивает большую гибкость в пользовательских интерфейсах.  Например, с помощью <xref:System.Windows.DataTemplate>, можно создать <xref:System.Windows.Controls.ComboBox> в котором каждый элемент содержит типа "флажок".  
  
-   **Шаблоны элементов управления.** Многие элементы управления в WPF использовать <xref:System.Windows.Controls.ControlTemplate> для определения структуры элемента управления и внешний вид, который отделяет внешний вид элемента управления от функциональности элемента управления. Можно существенно изменить внешний вид элемента управления путем переопределения его <xref:System.Windows.Controls.ControlTemplate>.  Предположим, что нужен элемент управления, который выглядит как светофор. Этот элемент управления имеет простой пользовательский интерфейс и функциональные возможности.  Элемент управления состоит из трех кругов, из которых одновременно загорается только один. Позже вы можете осознать, <xref:System.Windows.Controls.RadioButton> предлагает функциональные возможности выбора только один раз, но внешний вид по умолчанию <xref:System.Windows.Controls.RadioButton> похож индикаторы на светофор.  Так как <xref:System.Windows.Controls.RadioButton> использует шаблон элемента управления для определения внешнего вида, он может легко переопределить <xref:System.Windows.Controls.ControlTemplate> согласно требованиям элемента управления и использовать переключатели, чтобы сделать Светофор.  
  
    > [!NOTE]
    >  Несмотря на то что <xref:System.Windows.Controls.RadioButton> можно использовать <xref:System.Windows.DataTemplate>, <xref:System.Windows.DataTemplate> не хватает в этом примере.  <xref:System.Windows.DataTemplate> Определяет внешний вид содержимого элемента управления. В случае использования <xref:System.Windows.Controls.RadioButton>, содержимое отображается справа от круга, который указывает ли <xref:System.Windows.Controls.RadioButton> выбран.  В примере светофора переключатель должен быть тем кругом, который может "загораться". Так как требования к внешнему вида для светофора отличаются от внешнего вида по умолчанию <xref:System.Windows.Controls.RadioButton>, необходимо переопределить <xref:System.Windows.Controls.ControlTemplate>.  В целом <xref:System.Windows.DataTemplate> используется для определения содержимого (или данных) элемента управления, а также <xref:System.Windows.Controls.ControlTemplate> используется для определения того, как структурирован элемент управления.  
  
-   **Триггеры.** Объект <xref:System.Windows.Trigger> позволяет динамически изменять внешний вид и поведение элемента управления без создания нового элемента управления. Например, предположим, имеется несколько <xref:System.Windows.Controls.ListBox> элементы управления в приложении и элементы в каждом <xref:System.Windows.Controls.ListBox> должен выделяться полужирным красным при их выборе. Очевидным может быть попытка создать класс, наследующий от <xref:System.Windows.Controls.ListBox> и переопределить <xref:System.Windows.Controls.Primitives.Selector.OnSelectionChanged%2A> способ изменения внешнего вида выбранного элемента, но более эффективный подход — добавить триггер к стилю <xref:System.Windows.Controls.ListBoxItem> , изменяет внешний вид Выбранный элемент. Триггер позволяет изменять значения свойств или выполнять действия в зависимости от значения свойства. <xref:System.Windows.EventTrigger> Позволяет выполнять действия при возникновении события.  
  
 Дополнительные сведения о стилях, шаблонах и триггерах см. в разделе [Использование стилей и шаблонов](styling-and-templating.md).  
  
 В целом, если элемент управления отражает функциональность существующего элемента управления, но должен выглядеть по-другому, сначала следует рассмотреть возможность использования какого-либо из методов, описанных в этом разделе, для изменения внешнего вида существующего элемента.  
  
<a name="models_for_control_authoring"></a>   
## <a name="models-for-control-authoring"></a>Модели для создания элементов управления  
 Модель форматированного содержимого, стили, шаблоны и триггеры уменьшают необходимость создания новых элементов управления. Тем не менее, если необходимо создать новый элемент управления, важно понимать различные модели создания элементов управления в WPF. WPF предоставляет три общих модели для создания элементов управления, каждый из которых имеет собственный набор функций и уровень гибкости. Базовыми классами для трех моделей <xref:System.Windows.Controls.UserControl>, <xref:System.Windows.Controls.Control>, и <xref:System.Windows.FrameworkElement>.  
  
### <a name="deriving-from-usercontrol"></a>Создание производных классов от UserControl  
 Самый простой способ создания элемента управления в WPF является наследование от <xref:System.Windows.Controls.UserControl>. При создании элемента управления, который наследует от <xref:System.Windows.Controls.UserControl>, вы добавляете существующие компоненты к <xref:System.Windows.Controls.UserControl>компонентам имя и ссылки на обработчики событий в XAML. Затем можно ссылаться на именованные элементы и определять обработчики событий в коде. Эта модель разработки очень схожа с моделью, используемой для разработки приложений в WPF.  
  
 При правильном, построении <xref:System.Windows.Controls.UserControl> можно воспользоваться преимуществами форматированного содержимого, стилей и триггеров. Тем не менее если элемент управления наследуется из <xref:System.Windows.Controls.UserControl>, люди, использующие элемент управления не будет иметь возможность использовать <xref:System.Windows.DataTemplate> или <xref:System.Windows.Controls.ControlTemplate> для настройки внешнего вида.  Это необходимо для являются производными от <xref:System.Windows.Controls.Control> класс или один из его производных классов (отличное от <xref:System.Windows.Controls.UserControl>) для создания пользовательского элемента управления, поддерживающего шаблоны.  
  
#### <a name="benefits-of-deriving-from-usercontrol"></a>Преимущества использования производного класса от UserControl  
 Рассмотрите возможность наследования от <xref:System.Windows.Controls.UserControl> применимости всем следующим условиям:  
  
-   Нужно создать элемент управления аналогично созданию приложения.  
  
-   Элемент управления состоит только из существующих компонентов.  
  
-   Не нужно поддерживать сложные настройки.  
  
### <a name="deriving-from-control"></a>Создание производного от элемента управления  
 Наследование от <xref:System.Windows.Controls.Control> класс является модель, используемая в большинстве существующих WPF элементов управления. При создании элемента управления, который наследует от <xref:System.Windows.Controls.Control> класса, его внешний вид определяется с помощью шаблонов. Таким образом, можно отделить рабочую логику от визуального представления. Также можно обеспечить разделение пользовательского интерфейса и логики с помощью команд и привязок вместо событий и использования ссылок на элементы в <xref:System.Windows.Controls.ControlTemplate> по возможности.  Если пользовательский Интерфейс и логика элемента управления правильно разделены, пользователи элемента управления могут переопределить элемент управления <xref:System.Windows.Controls.ControlTemplate> для настройки внешнего вида. Несмотря на то, что построение пользовательского <xref:System.Windows.Controls.Control> не так просто, как строительные <xref:System.Windows.Controls.UserControl>, пользовательский <xref:System.Windows.Controls.Control> обеспечивает наибольшую гибкость.  
  
#### <a name="benefits-of-deriving-from-control"></a>Преимущества использования производного от элемента управления  
 Рассмотрите возможность наследования от <xref:System.Windows.Controls.Control> вместо использования <xref:System.Windows.Controls.UserControl> класса, если выполняется одно из следующих условий:  
  
-   Внешний вид элемента управления нужно настраивать через <xref:System.Windows.Controls.ControlTemplate>.  
  
-   Элемент управления должен поддерживать различные темы.  
  
### <a name="deriving-from-frameworkelement"></a>Создание производного от FrameworkElement  
 Элементы управления, которые являются производными от <xref:System.Windows.Controls.UserControl> или <xref:System.Windows.Controls.Control> основываются на сочетании существующих элементов. Во многих сценариях это приемлемое решение, так как любой объект, который наследует <xref:System.Windows.FrameworkElement> может находиться в <xref:System.Windows.Controls.ControlTemplate>. Однако бывают случаи, когда для внешнего вида элемента управления требуется больше, чем функциональность простой композиции элементов. В таких случаях компонент создание на основе <xref:System.Windows.FrameworkElement> является правильным выбором.  
  
 Существует два стандартных метода построения <xref:System.Windows.FrameworkElement>-компонентов на основе: прямая отрисовка и пользовательская композиция элемента. Прямая отрисовка включает переопределение <xref:System.Windows.UIElement.OnRender%2A> метод <xref:System.Windows.FrameworkElement> и предоставляя <xref:System.Windows.Media.DrawingContext> операций, которые явно определяют графические параметры компонента. Это метод, используемый <xref:System.Windows.Controls.Image> и <xref:System.Windows.Controls.Border>. Пользовательская композиция элемента включает использование объектов типа <xref:System.Windows.Media.Visual> для создания внешнего вида компонента. Например, см. раздел [Использование объектов DrawingVisual](../graphics-multimedia/using-drawingvisual-objects.md). <xref:System.Windows.Controls.Primitives.Track> является примером элемента управления в WPF , использует пользовательскую композицию элемента. Можно также комбинировать прямую отрисовку и пользовательскую композицию элемента в одном элементе управления.  
  
#### <a name="benefits-of-deriving-from-frameworkelement"></a>Преимущества использования производного от FrameworkElement  
 Рассмотрите возможность наследования от <xref:System.Windows.FrameworkElement> Если какой-либо из указанных ниже условий:  
  
-   Требуется точный контроль над внешним видом элемента управления помимо того, который обеспечивается простой композицией элемента.  
  
-   Необходимо определить внешний вид элемента управления путем определения собственной логики отрисовки.  
  
-   Требуется построить существующие элементы нестандартными способами, выходящими за рамки возможностей в средстве <xref:System.Windows.Controls.UserControl> и <xref:System.Windows.Controls.Control>.  
  
<a name="control_authoring_basics"></a>   
## <a name="control-authoring-basics"></a>Основы создания элементов управления  
 Как обсуждалось выше, одной из наиболее мощных функций WPF является возможность выхода за пределы задания базовых свойств элемента управления, чтобы изменить его внешний вид и поведение, но без необходимости создания пользовательского элемента управления. Функции стилей, привязки данных и триггеров предоставляются системой свойств WPF и системой событий WPF. В следующих разделах описаны некоторые рекомендации, которым нужно следовать независимо от модели, используемой для создания пользовательского элемента управления. Это необходимо, чтобы пользователи вашего пользовательского элемента управления могли использовать эти функции точно так же, как для элемента управления, входящего в WPF.  
  
### <a name="use-dependency-properties"></a>Использование свойств зависимостей  
 Если свойство является свойством зависимостей, то можно сделать следующее:  
  
-   Установить свойство в стиле.  
  
-   Привязать свойство к источнику данных.  
  
-   Использовать динамический ресурс в качестве значения свойства.  
  
-   Анимировать свойство.  
  
 Если свойство элемента управления должно поддерживать подобную функциональность, то следует реализовать его как свойство зависимостей. В следующем примере определяется свойство зависимостей с именем `Value` следующим способом:  
  
-   Определение <xref:System.Windows.DependencyProperty> идентификатор с именем `ValueProperty` как `public` `static` `readonly` поля.  
  
-   Зарегистрируйте имя свойства в системе свойств с помощью метода <xref:System.Windows.DependencyProperty.Register%2A?displayProperty=nameWithType>, чтобы указать следующее:  
  
    -   Имя свойства.  
  
    -   Тип свойства.  
  
    -   Тип, к которому принадлежит это свойство.  
  
    -   Метаданные для свойства. Метаданные содержат значение свойства по умолчанию, <xref:System.Windows.CoerceValueCallback> и <xref:System.Windows.PropertyChangedCallback>.  
  
-   Определите свойство программы-оболочки CLR с именем `Value`, которое используется для регистрации свойства зависимостей, путем реализации методов доступа `get` и `set` свойства. Обратите внимание, что `get` и `set` вызывать только методы доступа <xref:System.Windows.DependencyObject.GetValue%2A> и <xref:System.Windows.DependencyObject.SetValue%2A> соответственно. Рекомендуется, чтобы методы доступа свойств зависимостей не содержали дополнительной логики, так как клиенты и WPF может обойти методы доступа и вызов <xref:System.Windows.DependencyObject.GetValue%2A> и <xref:System.Windows.DependencyObject.SetValue%2A> напрямую. Например, если свойство привязано к источнику данных, то метод доступа `set` свойства не вызывается.  Вместо добавления дополнительной логики для получения и установки методов доступа, используйте <xref:System.Windows.ValidateValueCallback>, <xref:System.Windows.CoerceValueCallback>, и <xref:System.Windows.PropertyChangedCallback> реагировать на них или проверьте значение, при его изменении делегаты.  Дополнительные сведения об этих обратных вызовах см. в разделе [Проверка и обратные вызовы свойства зависимостей](../advanced/dependency-property-callbacks-and-validation.md).  
  
-   Определите метод для <xref:System.Windows.CoerceValueCallback> с именем `CoerceValue`. `CoerceValue` гарантирует, что `Value` больше или равно `MinValue` и меньше или равно `MaxValue`.  
  
-   Определите метод для <xref:System.Windows.PropertyChangedCallback>с именем `OnValueChanged`. `OnValueChanged` Создает <xref:System.Windows.RoutedPropertyChangedEventArgs%601> объекта и готовится к `ValueChanged` перенаправленного события. Перенаправляемые события рассматриваются в следующем разделе.  
  
 [!code-csharp[UserControlNumericUpDown#DependencyProperty](~/samples/snippets/csharp/VS_Snippets_Wpf/UserControlNumericUpDown/CSharp/NumericUpDown.xaml.cs#dependencyproperty)]
   
  
 Дополнительные сведения см. в разделе [Пользовательские свойства зависимостей](../advanced/custom-dependency-properties.md).  
  
### <a name="use-routed-events"></a>Использование перенаправляемых событий  
 Аналогично тому, как свойства зависимостей расширяют представление свойств CLR дополнительной функциональностью, перенаправляемые события расширяют представление стандартных событий CLR. При создании нового элемента управления WPF рекомендуется также реализовывать событие как перенаправляемое, так как такие события поддерживают следующее поведение:  
  
-   События могут обрабатываться в родительском элементе нескольких элементов управления. Если событие является событием восходящей маршрутизации, то один родительский элемент в дереве элементов может подписаться на это событие. Разработчики приложений могут использовать один обработчик для реагирования на событие нескольких элементов управления. Например, если элемент управления является частью каждого элемента в <xref:System.Windows.Controls.ListBox> (так как он включен в <xref:System.Windows.DataTemplate>), разработчик приложения может определить обработчик событий для события элемента управления на <xref:System.Windows.Controls.ListBox>. Обработчик событий вызывается при возникновении события в любом элементе управления.  
  
-   Перенаправленные события могут использоваться в <xref:System.Windows.EventSetter>, что позволяет разработчикам приложений указать обработчик события в стиле.  
  
-   Перенаправленные события могут использоваться в <xref:System.Windows.EventTrigger>, что удобно для анимации свойств с помощью XAML. Более подробную информацию см. в разделе [Общие сведения об эффектах анимации](../graphics-multimedia/animation-overview.md).  
  
 Следующий пример определяет перенаправляемое событие:  
  
-   Определение <xref:System.Windows.RoutedEvent> идентификатор с именем `ValueChangedEvent` как `public` `static` `readonly` поля.  
  
-   Зарегистрируйте перенаправляемое событие путем вызова <xref:System.Windows.EventManager.RegisterRoutedEvent%2A?displayProperty=nameWithType> метод. В примере указывается следующие сведения при вызове <xref:System.Windows.EventManager.RegisterRoutedEvent%2A>:  
  
    -   Имя события `ValueChanged`.  
  
    -   Стратегия маршрутизации <xref:System.Windows.RoutingStrategy.Bubble>, что означает, что сначала вызывается обработчик событий в источнике (объект, вызывающий событие) и затем вызываются обработчики событий родительских элементов источника подряд, начиная с обработчика события для ближайшего родительский элемент.  
  
    -   Тип обработчика событий — <xref:System.Windows.RoutedPropertyChangedEventHandler%601>, созданный с <xref:System.Decimal> типа.  
  
    -   Тип — владелец события — `NumericUpDown`.  
  
-   Объявите общее событие с именем `ValueChanged`, которое включает объявления метода доступа к событию. В примере вызывается <xref:System.Windows.UIElement.AddHandler%2A> в `add` объявление метода доступа и <xref:System.Windows.UIElement.RemoveHandler%2A> в `remove` объявление метода доступа для использования WPF служб событий.  
  
-   Создайте защищенный виртуальный метод с именем `OnValueChanged`, вызывающий событие `ValueChanged`.  
  
 [!code-csharp[UserControlNumericUpDown#RoutedEvent](~/samples/snippets/csharp/VS_Snippets_Wpf/UserControlNumericUpDown/CSharp/NumericUpDown.xaml.cs#routedevent)]
   
  
 Дополнительные сведения см. в разделах [Общие сведения о перенаправляемых событиях](../advanced/routed-events-overview.md) и [Создание пользовательских перенаправляемых событий](../advanced/how-to-create-a-custom-routed-event.md).  
  
### <a name="use-binding"></a>Использование привязки  
 Для отделения пользовательского интерфейса от логики элемента управления можно использовать привязку данных. Это особенно важно в том случае, если внешний вид элемента управления с помощью <xref:System.Windows.Controls.ControlTemplate>. При использовании привязки данных можно избавиться от необходимости ссылаться на определенные части пользовательского интерфейса из кода. Рекомендуется избегать ссылок на элементы в <xref:System.Windows.Controls.ControlTemplate> потому, что если код ссылается на элементы в <xref:System.Windows.Controls.ControlTemplate> и <xref:System.Windows.Controls.ControlTemplate> изменяется, указанный ссылками элемент должен быть включен в новом <xref:System.Windows.Controls.ControlTemplate>.  
  
 В следующем примере обновляется <xref:System.Windows.Controls.TextBlock> из `NumericUpDown` элемента управления, присвоение имени и ссылается на текстовое поле по имени в коде.  
  
 [!code-xaml[UserControlNumericUpDownSimple#UIRefMarkup](~/samples/snippets/csharp/VS_Snippets_Wpf/UserControlNumericUpDownSimple/CSharp/NumericUpDown.xaml#uirefmarkup)]  
  
 [!code-csharp[UserControlNumericUpDownSimple#UIRefCode](~/samples/snippets/csharp/VS_Snippets_Wpf/UserControlNumericUpDownSimple/CSharp/NumericUpDown.xaml.cs#uirefcode)]
   
  
 Следующий пример использует привязку для достижения такого же результата.  
  
 [!code-xaml[UserControlNumericUpDown#Binding](~/samples/snippets/csharp/VS_Snippets_Wpf/UserControlNumericUpDown/CSharp/NumericUpDown.xaml#binding)]  
  
 Дополнительные сведения о привязке данных см. в разделе [Общие сведения о привязке данных](../data/data-binding-overview.md).  
  
### <a name="design-for-designers"></a>Разработка для конструкторов  
 Чтобы получить поддержку пользовательских элементов управления WPF в [!INCLUDE[wpfdesigner_current_long](../../../../includes/wpfdesigner-current-long-md.md)] (например, редактирование свойства с помощью окна "Свойства"), следуйте приведенным ниже рекомендациям.  Дополнительные сведения о разработке для [!INCLUDE[wpfdesigner_current_short](../../../../includes/wpfdesigner-current-short-md.md)], см. в разделе [конструктора XAML в Visual Studio](/visualstudio/designers/designing-xaml-in-visual-studio).  
  
#### <a name="dependency-properties"></a>Свойства зависимостей  
 Следует реализовать методы доступа CLR `get` и `set`, как описано ранее в разделе "Использование свойств зависимостей". Конструкторы могут использовать программы-оболочки для обнаружения свойства зависимостей, но им, как WPF и клиентам элемента управления, не требуется вызывать методы доступа при получении или настройке свойства.  
  
#### <a name="attached-properties"></a>Вложенные свойства  
 При реализации вложенных свойств в пользовательских элементах управления учитывайте следующие рекомендации:  
  
-   У `public` `static` `readonly` <xref:System.Windows.DependencyProperty> формы *PropertyName* `Property` , создании с помощью <xref:System.Windows.DependencyProperty.RegisterAttached%2A> метод. Имя свойства, которое передается <xref:System.Windows.DependencyProperty.RegisterAttached%2A> должно соответствовать *PropertyName*.  
  
-   Реализуйте пару методов CLR `public` `static` с именем `Set`*PropertyName* и `Get`*PropertyName*. Оба метода должны принимать производный класс от <xref:System.Windows.DependencyProperty> качестве первого аргумента. Метод `Set`*PropertyName* также принимает аргумент, тип которого соответствует зарегистрированному типу данных для свойства. Метод `Get`*PropertyName* должен возвращать значение такого же типа. Если метод `Set` *PropertyName* отсутствует, свойство отмечается как "только для чтения".  
  
-   `Set` **PropertyName* и `Get` *PropertyName* должны перенаправляться непосредственно в <xref:System.Windows.DependencyObject.GetValue%2A> и <xref:System.Windows.DependencyObject.SetValue%2A> методы от зависимости целевого объекта, соответственно.DРазработчики могут получить доступ к вложенному свойству, вызвав программу-оболочку метода или с помощью прямого вызова целевого объекта зависимостей.  
  
 Дополнительные сведения о вложенных свойствах см. в разделе [Общие сведения о вложенных свойствах](../advanced/attached-properties-overview.md).  
  
### <a name="define-and-use-shared-resources"></a>Определение и использование общих ресурсов  
 Можно включить элемент управления в ту же сборку, что и приложение, или упаковать его в отдельную сборку, которая может использоваться в нескольких приложениях. В большинстве случаев сведения, рассматриваемые в данном разделе, применяются независимо от используемого метода.  Однако есть одно отличие, о котором следует упомянуть.  При помещении элемента управления в ту же сборку, что и приложение, можно добавить глобальные ресурсы в файл App.xaml. Но не сборку, содержащую только элементы управления <xref:System.Windows.Application> объект, связанный с ним, поэтому файл App.xaml недоступно.  
  
 Приложение выполняет поиск ресурса на трех уровнях в следующем порядке:  
  
1. Уровень элемента.  
  
     Система начинает с элемента, который ссылается на ресурс, а затем ищет ресурсы логического родительского элемента и так далее, пока не будет достигнут корневой элемент.  
  
2. Уровень приложения.  
  
     Ресурсы, определенные в <xref:System.Windows.Application> объекта.  
  
3. Уровень темы.  
  
     Словари уровня темы хранятся в подпапке "Темы".  Файлы в папке "Темы" соответствуют темам.  Например, могут присутствовать файлы Aero.NormalColor.xaml, Luna.NormalColor.xaml, Royale.NormalColor.xaml и т. д.  Также может присутствовать файл с именем generic.xaml.  Когда система ищет ресурс на уровне темы, она сначала ищет его в файле конкретной темы, а затем в файле generic.xaml.  
  
 Если элемент управления находится в сборке отдельно от приложения, глобальные ресурсы необходимо поместить на уровень элемента или на уровень темы. Оба метода имеют свои преимущества.  
  
#### <a name="defining-resources-at-the-element-level"></a>Определение ресурсов на уровне элемента  
 Общие ресурсы на уровне элемента можно определить путем создания пользовательского словаря ресурсов и его объединения со словарем ресурсов элемента управления.  При использовании этого метода можно присвоить файлу ресурсов любое имя и его можно поместить в одну папку с элементами управления. Ресурсы на уровне элемента также могут использовать простые строки как ключи. В следующем примере создается <xref:System.Windows.Media.LinearGradientBrush> файл ресурсов с именем Dictionary1.xaml.  
  
 [!code-xaml[SharedResources#1](~/samples/snippets/csharp/VS_Snippets_Wpf/SharedResources/CS/Dictionary1.xaml#1)]  
  
 После определения словаря необходимо его объединить со словарем ресурсов элемента управления.  Это можно сделать с помощью XAML или кода.  
  
 Следующий пример объединяет словарь ресурса с помощью XAML.  
  
 [!code-xaml[SharedResources#2](~/samples/snippets/csharp/VS_Snippets_Wpf/SharedResources/CS/ShapeResizer.xaml#2)]  
  
 Недостаток этого подхода заключается в том, <xref:System.Windows.ResourceDictionary> создается каждый раз, ссылки на объект.  Например, если у вас 10 пользовательских элементов управления в библиотеке и объединение словарей общих ресурсов для каждого элемента управления с помощью XAML, будут созданы 10 идентичных <xref:System.Windows.ResourceDictionary> объектов.  Этого можно избежать, создав статический класс, который объединяет ресурсы в коде и возвращает результат в виде <xref:System.Windows.ResourceDictionary>.  
  
 В следующем примере создается класс, который возвращает общий <xref:System.Windows.ResourceDictionary>.  
  
 [!code-csharp[SharedResources#3](~/samples/snippets/csharp/VS_Snippets_Wpf/SharedResources/CS/SharedDictionaryManager.cs#3)]  
  
 В следующем примере общий ресурс объединяется с ресурсами пользовательского элемента управления в конструкторе элемента управления, прежде чем он вызывает `InitializeComponent`.  Так как `SharedDictionaryManager.SharedDictionary` является статическим свойством, <xref:System.Windows.ResourceDictionary> создается только один раз. Поскольку словарь ресурсов был объединен до вызова `InitializeComponent`, ресурсы доступны для элемента управления в его файле XAML.  
  
 [!code-csharp[SharedResources#4](~/samples/snippets/csharp/VS_Snippets_Wpf/SharedResources/CS/ShapeResizer.xaml.cs#4)]  
  
#### <a name="defining-resources-at-the-theme-level"></a>Определение ресурсов на уровне темы  
 WPF позволяет создавать ресурсы для разных тем Windows.  Как разработчик элемента управления, вы можете определить ресурс для определенной темы, чтобы изменить внешний вид элемента управления в зависимости от того, какая тема используется. Например, внешний вид <xref:System.Windows.Controls.Button> в классическом Windows темы (тема по умолчанию для Windows 2000) отличается от <xref:System.Windows.Controls.Button> в теме Windows Luna (тема по умолчанию для Windows XP) так как <xref:System.Windows.Controls.Button> использует другое <xref:System.Windows.Controls.ControlTemplate> для каждой темы.  
  
 Ресурсы, относящиеся к теме, хранятся в словаре ресурсов с заданным именем файла. Эти файлы должны находиться в папке с именем `Themes`, которая является подпапкой папки, содержащей элемент управления. В следующей таблице перечислены файлы словаря ресурсов и темы, связанные с каждым файлом.  
  
|Имя файла словаря ресурсов|Тема Windows|  
|-----------------------------------|-------------------|  
|`Classic.xaml`|Классический вид Windows 9x/2000 для Windows XP|  
|`Luna.NormalColor.xaml`|Синяя тема по умолчанию в Windows XP|  
|`Luna.Homestead.xaml`|Оливковая тема в Windows XP|  
|`Luna.Metallic.xaml`|Серебристая тема в Windows XP|  
|`Royale.NormalColor.xaml`|Тема по умолчанию в Windows XP Media Center Edition|  
|`Aero.NormalColor.xaml`|Тема по умолчанию в Windows Vista|  
  
 Не нужно определять ресурс для каждой темы. Если ресурс не определен для конкретной темы, элемент управления проверяет `Classic.xaml` для ресурса. Если ресурс не определен в файле, соответствующем текущей теме, или в `Classic.xaml`, то элемент управления использует общий ресурс, который находится в файле словаря ресурса с именем `generic.xaml`.  Файл `generic.xaml` расположен в той же папке, что и файлы словаря ресурсов, связанные с темами. Хотя `generic.xaml` не соответствует конкретной теме Windows, он по-прежнему является словарем уровня темы.  
  
 [Пример пользовательского элемента управления NumericUpDown с темами и поддержкой автоматизации пользовательского интерфейса](https://go.microsoft.com/fwlink/?LinkID=160025) содержит два словаря ресурсов для элемента управления `NumericUpDown`: один — в файле generic.xaml, а второй — в Luna.NormalColor.xaml.  Можно запустить приложение и переключаться между серебристой темой в Windows XP и другой темой, чтобы увидеть разницу между двумя шаблонами элемента управления. (Если вы используете Windows Vista, можно переименовать Luna.NormalColor.xaml в Aero.NormalColor.xaml и переключаться между двумя темами, например между классической и темой по умолчанию для Windows Vista.)  
  
 При переводе <xref:System.Windows.Controls.ControlTemplate> в любом из файлы словарей тематических ресурсов, необходимо создать статический конструктор для элемента управления и вызвать <xref:System.Windows.DependencyProperty.OverrideMetadata%28System.Type%2CSystem.Windows.PropertyMetadata%29> метод <xref:System.Windows.FrameworkElement.DefaultStyleKey%2A>, как показано в следующем примере.  
  
 [!code-csharp[CustomControlNumericUpDownOneProject#StaticConstructor](~/samples/snippets/csharp/VS_Snippets_Wpf/CustomControlNumericUpDownOneProject/CSharp/NumericUpDown.cs#staticconstructor)]
   
  
##### <a name="defining-and-referencing-keys-for-theme-resources"></a>Определение и создание ссылок на ключи для ресурсов тем  
 При определении ресурса на уровне элемента можно назначить строку в качестве его ключа и получить доступ к ресурсу через эту строку. При определении ресурса на уровне темы необходимо использовать <xref:System.Windows.ComponentResourceKey> как ключ.  В следующем примере определяется ресурс в файле generic.xaml.  
  
 [!code-xaml[ThemeResourcesControlLibrary#5](~/samples/snippets/csharp/VS_Snippets_Wpf/ThemeResourcesControlLibrary/CS/Themes/generic.xaml#5)]  
  
 Следующий пример ссылается на ресурс, указав <xref:System.Windows.ComponentResourceKey> как ключ.  
  
 [!code-xaml[ThemeResourcesControlLibrary#6](~/samples/snippets/csharp/VS_Snippets_Wpf/ThemeResourcesControlLibrary/CS/NumericUpDown.xaml#6)]  
  
##### <a name="specifying-the-location-of-theme-resources"></a>Определение местоположения ресурсов тем  
 Чтобы найти ресурсы для элемента управления, ведущее приложение должно знать, что сборка содержит ресурсы для элемента управления. Можно сделать, добавив <xref:System.Windows.ThemeInfoAttribute> на сборку, содержащую элемент управления. <xref:System.Windows.ThemeInfoAttribute> Имеет <xref:System.Windows.ThemeInfoAttribute.GenericDictionaryLocation%2A> свойство, указывающее местоположение общих ресурсов и <xref:System.Windows.ThemeInfoAttribute.ThemeDictionaryLocation%2A> свойство, указывающее расположение тематических ресурсов.  
  
 В следующем примере задается <xref:System.Windows.ThemeInfoAttribute.GenericDictionaryLocation%2A> и <xref:System.Windows.ThemeInfoAttribute.ThemeDictionaryLocation%2A> свойства <xref:System.Windows.ResourceDictionaryLocation.SourceAssembly>, чтобы указать, что универсальных и тематических ресурсы находятся в той же сборке, в качестве элемента управления.  
  
 [!code-csharp[CustomControlNumericUpDown#ThemesSection](~/samples/snippets/csharp/VS_Snippets_Wpf/CustomControlNumericUpDown/CSharp/CustomControlLibrary/Properties/AssemblyInfo.cs#themessection)]
   
  
## <a name="see-also"></a>См. также

- [Проектирование XAML в Visual Studio](/visualstudio/designers/designing-xaml-in-visual-studio)
- [URI типа "pack" в WPF](../app-development/pack-uris-in-wpf.md)
- [Настройка элементов управления](control-customization.md)

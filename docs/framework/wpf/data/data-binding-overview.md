---
title: Общие сведения о привязке данных
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- data conversion for binding [WPF]
- binding data [WPF], about data binding
- data binding [WPF], about data binding
- conversion for data binding [WPF]
ms.assetid: c707c95f-7811-401d-956e-2fffd019a211
ms.openlocfilehash: f849cf306f4de0cbaa7623ded4ab7045bb5112a6
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59315326"
---
# <a name="data-binding-overview"></a>Общие сведения о привязке данных
Windows Presentation Foundation (WPF) Привязка данных обеспечивает простой и последовательный способ представления и взаимодействия с данными приложениях. Можно связывать элементы с данными из различных источников данных в виде объектов [!INCLUDE[TLA#tla_clr](../../../../includes/tlasharptla-clr-md.md)] и [!INCLUDE[TLA#tla_xml](../../../../includes/tlasharptla-xml-md.md)]. <xref:System.Windows.Controls.ContentControl>например <xref:System.Windows.Controls.Button> и <xref:System.Windows.Controls.ItemsControl>, например <xref:System.Windows.Controls.ListBox> и <xref:System.Windows.Controls.ListView> у встроенной возможностью включения гибких стилей для отдельных элементов данных и коллекций элементов данных. Представления сортировки, фильтрации и группировки могут быть организованы поверх данных.  
  
 Функции привязки данных в WPF имеют несколько преимуществ перед традиционными моделями, включая широкий диапазон свойств, которые внутренне поддерживают привязку данных, гибкое представление данных UI и четкое разделение бизнес-логики и UI.  
  
 В этом разделе сначала будут рассмотрены основные для понятия WPF привязки данных, а затем — использование <xref:System.Windows.Data.Binding> класс и других возможностей привязки данных.  

<a name="what_is_data_binding"></a>   
## <a name="what-is-data-binding"></a>Понятие привязки данных  
 Привязка данных — это процесс установки соединения между UI приложения и бизнес-логикой. Если для привязки заданы правильные настройки, а изменения значений данных сопровождаются правильными уведомлениями, привязанные к данным элементы автоматически отражают изменения. Привязка данных может также означать, что, если внешнее представление данных в элементе изменяется, то базовые данные могут автоматически обновляться для отражения изменений. Например, если пользователь изменяет значение в <xref:System.Windows.Controls.TextBox> элемент, базовое значение данных автоматически обновляется в соответствии с изменениями.  
  
 Привязка к данным обычно используется для того, чтобы поместить серверный или локальные данные конфигурации в формы или другие элементы управления UI. В WPF эта концепция расширяется и уже включает привязку широкого диапазона свойств к различным источникам данных. В WPF свойства зависимости элементов могут быть привязаны к объектам [!INCLUDE[TLA2#tla_clr](../../../../includes/tla2sharptla-clr-md.md)] (включая объекты [!INCLUDE[TLA#tla_adonet](../../../../includes/tlasharptla-adonet-md.md)] или объекты, связанные с веб-службами и веб-свойства) и к данным [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)].  
  
 Привязку данных можно рассмотреть на примере следующего UI приложения со страницы [примера привязки данных](https://go.microsoft.com/fwlink/?LinkID=163703).  
  
 ![Снимок экрана примера привязки данных](./media/databinding-databindingdemo.png "DataBinding_DataBindingDemo")  
  
 Выше приведен UI приложения, который отображает список лотов аукциона. Приложение демонстрирует следующие возможности привязки данных.  
  
-   Содержание <xref:System.Windows.Controls.ListBox> привязан к коллекции *AuctionItem* объектов. Объект *AuctionItem* имеет такие свойства, как *Description*, *StartPrice*, *StartDate*, *Category*, *SpecialFeatures* и т. д.  
  
-   Данные (*AuctionItem* объектов) в <xref:System.Windows.Controls.ListBox> является шаблоном, чтобы описание и текущая цена были показаны для каждого элемента. Это делается с помощью <xref:System.Windows.DataTemplate>. Кроме того, внешний вид каждого элемента зависит от значения *SpecialFeatures* отображаемого объекта *AuctionItem*. Если значением *SpecialFeatures* объекта *AuctionItem* является *Color*, элемент имеет синюю границу. Если значением является *Highlight*, элемент имеет оранжевые границы и помечается звездочкой. Раздел [Создание шаблонов данных](#data_templating) содержит сведения о создании шаблонов данных.  
  
-   Пользователя можно группировать, фильтровать или сортировать данные с помощью <xref:System.Windows.Controls.CheckBox>предоставленных. На приведенном выше рисунке, «Группировать по категории» и «Сортировать по категориям и дате» <xref:System.Windows.Controls.CheckBox>выбраны. Можно увидеть, что данные группируются по категориям продуктов, а имена категорий приводятся в алфавитном порядке. Из рисунка трудно заметить, что элементы в каждой категории также сортируются по начальной дате. Это делается с помощью *представления коллекции*. Представления коллекций рассматриваются в разделе [Привязка к коллекциям](#binding_to_collections).  
  
-   Когда пользователь выбирает элемент, <xref:System.Windows.Controls.ContentControl> отображает сведения о выбранного элемента. Это называется *Сценарий привязки "основной-подробности"*. Сведения об этом типе скрипта привязки см. в разделе [Сценарий привязки "основной-подробности"](#master_detail_scenario).  
  
-   Тип *StartDate* свойство <xref:System.DateTime>, который возвращает дату, включая время с точностью до миллисекунды. В этом приложении пользовательский преобразователь использовался для отображения даты в укороченном формате. Сведения о преобразователях см. в разделе [Преобразование данных](#data_conversion).  
  
 При нажатии кнопки *Добавить продукт* появляется следующая форма.  
  
 ![Добавить страницу списка продуктов](./media/databinding-demo-addproductlisting.png "DataBinding_Demo_AddProductListing")  
  
 Пользователь может изменить поля формы, просмотреть список продуктов с помощью панелей краткого предварительного просмотра и подробного предварительного просмотра и нажать кнопку *Отправить*, для добавления данных нового продукта. К новой записи будут применимы все существующие функциональные возможности группировки, фильтрации и сортировки. В этом конкретном случае элемент, введенный на приведенном выше рисунке, будет отображаться как второй элемент в категории *Компьютер*.  
  
 Не на этом рисунке приведена логика проверки, предоставленная в *Дата начала* <xref:System.Windows.Controls.TextBox>. Если пользователь вводит недопустимую дату (недопустимый формат или прошедшую дату), пользователь будет уведомлен с помощью <xref:System.Windows.Controls.ToolTip> и красным восклицательным знаком рядом с полем <xref:System.Windows.Controls.TextBox>. Сведения о создании логики проверки см. в разделе [Проверка данных](#data_validation).  
  
 Прежде чем перейти к другим описанным выше возможностям связывания данных, в следующем разделе обсудим основные понятия, важные для понимания привязки данных WPF.  
  
## <a name="basic-data-binding-concepts"></a>Основные понятия привязки данных  
  
 Независимо от того, какой элемент привязывается и какой источник данных используется, каждая привязка всегда соответствует модели, показанной на следующем рисунке.  
  
 ![Схема, показывающая модель привязки данных.](./media/data-binding-overview/basic-data-binding-diagram.png)  
  
 Как показано на приведенном выше рисунке, привязка данных является по существу мостом между целью привязки и источником привязки. На рисунке представлены следующие основные концепции привязки данных WPF.  
  
-   Как правило, каждая привязка имеет четыре компонента: объект цели привязки, свойство цели, источник привязки и путь к значению используемого источника привязки. Например, если требуется привязать содержимое <xref:System.Windows.Controls.TextBox> для *имя* свойство *сотрудника* объекта является целевым объектом <xref:System.Windows.Controls.TextBox>, целевым свойством является <xref:System.Windows.Controls.TextBox.Text%2A> свойство, используйте значение *имя*, и исходный объект является *сотрудника* объекта.  
  
-   Целевое свойство должно быть свойством зависимостей. Большинство <xref:System.Windows.UIElement> свойств являются свойствами зависимостей, и большинство свойств зависимостей, за исключением доступных только для чтения, по умолчанию поддерживает привязку данных. (Только <xref:System.Windows.DependencyObject> типы могут определять свойства зависимостей и все <xref:System.Windows.UIElement>являются производными от <xref:System.Windows.DependencyObject>.)  
  
-   Несмотря на то что это не указано на рисунке, следует отметить, что источник привязки не обязан быть пользовательским объектом [!INCLUDE[TLA2#tla_clr](../../../../includes/tla2sharptla-clr-md.md)]. WPF Привязка данных поддерживает данные в виде [!INCLUDE[TLA2#tla_clr](../../../../includes/tla2sharptla-clr-md.md)] объектов и [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)]. Представлены некоторые, возможно, источнике привязки <xref:System.Windows.UIElement>, любой объект списка [!INCLUDE[TLA2#tla_clr](../../../../includes/tla2sharptla-clr-md.md)] объекта, связанного с [!INCLUDE[TLA#tla_adonet](../../../../includes/tlasharptla-adonet-md.md)] данных или веб-службы или XmlNode, содержащий ваш [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)] данных. Дополнительные сведения см. в разделе [Общие сведения об источниках привязки](binding-sources-overview.md).  
  
 В процессе чтения других разделов [!INCLUDE[TLA#tla_sdk](../../../../includes/tlasharptla-sdk-md.md)] важно помнить, что при связывании цель привязки *привязывается к* источнику привязки. Например, при отображении некоторых базовых [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)] данные в <xref:System.Windows.Controls.ListBox> с использованием привязки данных, выполняется привязка к <xref:System.Windows.Controls.ListBox> для [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)] данных.  
  
 Чтобы установить привязку, используйте <xref:System.Windows.Data.Binding> объекта. В остальной части этого раздела обсуждаются многие понятия, связанные с некоторые свойства и использование <xref:System.Windows.Data.Binding> объекта.  
  
<a name="direction_of_data_flow"></a>   
### <a name="direction-of-the-data-flow"></a>Направление потока данных  
 Как упоминалось ранее и как показывает стрелка на приведенном выше рисунке, поток данных привязки можно перейти от целевого объекта привязки к источнику привязки (например, исходное значение изменяется, когда пользователь редактирует значение <xref:System.Windows.Controls.TextBox>) и (или) от источника привязки целевой объект привязки (например, ваш <xref:System.Windows.Controls.TextBox> содержимое обновляется с изменениями в источнике привязки), если источник привязки предоставляет соответствующие уведомления.  
  
 Возможно, требуется, чтобы в приложении пользователи могли изменить данные и передать их обратно объекту источника. Или может потребоваться не предоставлять пользователям возможности обновления источника данных. Это можно управлять, задав <xref:System.Windows.Data.Binding.Mode%2A> свойство вашей <xref:System.Windows.Data.Binding> объекта. На следующем рисунке показаны различные типы потоков данных.  
  
 ![Поток данных привязки данных](./media/databinding-dataflow.png "DataBinding_DataFlow")  
  
-   <xref:System.Windows.Data.BindingMode.OneWay> Привязка передает изменения свойства источника для автоматического обновления целевого свойства, но изменения свойства цели не передаются обратно к свойству источника. Этот тип привязки подходит, если привязываемый элемент управления неявно доступен только для чтения. Например, можно привязаться к источнику, такому как биржевые сводки, или, возможно, свойство цели не имеет интерфейса для внесения изменений, например цвета фона привязанной к данным таблицы. Если нет необходимости отслеживать изменения целевого свойства, можно работать в режиме привязки <xref:System.Windows.Data.BindingMode.OneWay> — в этом случае удастся избежать издержек режима привязки <xref:System.Windows.Data.BindingMode.TwoWay>.  
  
-   <xref:System.Windows.Data.BindingMode.TwoWay> связывание вызывает изменения в свойство источника или целевого свойства для автоматического обновления другого. Этот тип привязки подходит для изменяемых форм или других полностью интерактивных сценариев UI. Большинство свойств по умолчанию <xref:System.Windows.Data.BindingMode.OneWay> привязки, но некоторые свойства зависимостей (обычно свойства изменяемых пользователем элементов управления, такие как <xref:System.Windows.Controls.TextBox.Text%2A> свойство <xref:System.Windows.Controls.TextBox> и <xref:System.Windows.Controls.Primitives.ToggleButton.IsChecked%2A> свойство <xref:System.Windows.Controls.CheckBox>) по умолчанию для <xref:System.Windows.Data.BindingMode.TwoWay> привязки. Существует способ определить программно, использует ли свойство зависимостей односторонние или двухсторонние привязки по умолчанию: для этого нужно получить метаданные этого свойства, воспользовавшись методом <xref:System.Windows.DependencyProperty.GetMetadata%2A>, а затем проверить логическое значение свойства <xref:System.Windows.FrameworkPropertyMetadata.BindsTwoWayByDefault%2A>.  
  
-   <xref:System.Windows.Data.BindingMode.OneWayToSource> является обратным <xref:System.Windows.Data.BindingMode.OneWay> связывание; он обновляет свойство источника при изменении свойства цели. Одним из примеров является пересчет исходного значения из UI.  
  
-   Не показано на рисунке является <xref:System.Windows.Data.BindingMode.OneTime> привязки, который вызывает инициализировать целевое свойство источника, но последующие изменения не распространяются. Это означает, что, если в контексте данных производятся изменения или меняется объект, это изменение не отражается в целевом свойстве. Этот тип привязки подходит при использовании данных там, где приемлемо использовать снимок текущего состояния или данные действительно являются статичными. Этот тип привязки также является полезным, если нужно инициализировать целевое свойство с использованием какого-либо значения из исходного свойства, а контекст данных заранее неизвестен. Это, по сути, упрощенная форма привязки <xref:System.Windows.Data.BindingMode.OneWay>, которая обеспечивает более высокую производительность в случаях, когда исходное значение не меняется.  
  
 Обратите внимание, что для обнаружения изменений в источнике (применимо к <xref:System.Windows.Data.BindingMode.OneWay> и <xref:System.Windows.Data.BindingMode.TwoWay> привязок), источник должен реализовывать механизм уведомлений об изменениях соответствующее свойство <xref:System.ComponentModel.INotifyPropertyChanged>. См. в разделе [реализация уведомления об изменении свойства](how-to-implement-property-change-notification.md) пример <xref:System.ComponentModel.INotifyPropertyChanged> реализации.  
  
 <xref:System.Windows.Data.Binding.Mode%2A> Страницу свойств предоставляет дополнительные сведения о режимах привязки и пример того, как указать направление привязки.  
  
<a name="what_triggers_source_updates"></a>   
### <a name="what-triggers-source-updates"></a>Что инициирует обновления источника  
 Привязки становятся <xref:System.Windows.Data.BindingMode.TwoWay> или <xref:System.Windows.Data.BindingMode.OneWayToSource> отслеживать изменения в свойство цели и распространять их в источнике. Это называется обновлением источника. Например, можно изменять текст элемента TextBox для изменения базового значение источника. Как описано в предыдущем разделе, направление потока данных определяется по значению <xref:System.Windows.Data.Binding.Mode%2A> свойства привязки.  
  
 Однако обновляется ли значение источника при изменении текста или после завершения изменения текста и отвода указателя мыши от элемента TextBox? <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A> Свойство привязки определяет, что инициирует обновления источника. Точки стрелок вправо на следующем рисунке показывают роль <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A> свойство:  
  
 ![Схема, показывающая роль свойство UpdateSourceTrigger.](./media/data-binding-overview/data-binding-updatesource-trigger.png)  
  
 Если <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A> значение <xref:System.Windows.Data.UpdateSourceTrigger.PropertyChanged>, затем значение указывает правую стрелку действия <xref:System.Windows.Data.BindingMode.TwoWay> или <xref:System.Windows.Data.BindingMode.OneWayToSource> привязки обновляется сразу, как изменения целевого свойства. Тем не менее если <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A> значение <xref:System.Windows.Data.UpdateSourceTrigger.LostFocus>, а затем это значение обновляется только новое значение при свойство цели теряет фокус.  
  
 Аналогичную <xref:System.Windows.Data.Binding.Mode%2A> свойство, различные свойства зависимостей имеют различное <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A> значения. Значение по умолчанию для большинства свойств зависимостей — <xref:System.Windows.Data.UpdateSourceTrigger.PropertyChanged>, а свойство <xref:System.Windows.Controls.TextBox.Text%2A> имеет значение по умолчанию <xref:System.Windows.Data.UpdateSourceTrigger.LostFocus>. Это означает, что источник обновления обычно происходят при изменении изменения свойства цели, что подходит для <xref:System.Windows.Controls.CheckBox>es и других простых элементов управления. Однако для текстовых полей обновления после каждого нажатия клавиши уменьшают производительность и не дают пользователю обычной возможности удаления предыдущего символа и исправления ошибок ввода до того, как новое значение будет зафиксировано. Вот почему <xref:System.Windows.Controls.TextBox.Text%2A> свойство имеет значение по умолчанию <xref:System.Windows.Data.UpdateSourceTrigger.LostFocus> вместо <xref:System.Windows.Data.UpdateSourceTrigger.PropertyChanged>.  
  
 См. в разделе <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A> сведения о том, как найти значение по умолчанию <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A> значение свойства зависимостей.  
  
 Следующая таблица содержит пример сценария для каждого <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A> с использованием синтаксиса <xref:System.Windows.Controls.TextBox> в качестве примера:  
  
|Значение UpdateSourceTrigger|Когда обновляется значение источника|Пример сценария для TextBox|  
|-------------------------------|----------------------------------------|----------------------------------|  
|LostFocus (значение по умолчанию для <xref:System.Windows.Controls.TextBox.Text%2A?displayProperty=nameWithType>)|Возникает при потере фокуса элементом управления TextBox|Объект <xref:System.Windows.Controls.TextBox> , связанный с логикой проверки (см. в разделе Проверка данных)|  
|Свойство изменено|При вводе в <xref:System.Windows.Controls.TextBox>|<xref:System.Windows.Controls.TextBox> элементы управления в окне чата|  
|Явные|Когда приложение вызывает <xref:System.Windows.Data.BindingExpression.UpdateSource%2A>|<xref:System.Windows.Controls.TextBox> элементы управления в редактируемой форме (обновляет значения источника только в том случае, когда пользователь нажимает кнопку «Отправить»)|  
  
 Пример см. в разделе [Практическое руководство. Управление обновлением источника из поля TextBox](how-to-control-when-the-textbox-text-updates-the-source.md).  
  
<a name="creating_a_binding"></a>   
## <a name="creating-a-binding"></a>Создание привязки  
  
 Подводя итог некоторым понятиям, описанным в предыдущих разделах, установить привязку с помощью <xref:System.Windows.Data.Binding> объекта и каждая привязка обычно состоит из четырех компонентов: привязка целевой, свойство цели, источник привязки и путь к используемому значению источника. Этот раздел описывает установку привязки.  
  
 Рассмотрим следующий пример, в котором объектом источника привязки является класс с именем *MyData*, определенный в пространстве имен *SDKSample*. В качестве демонстрационного примера класс *MyData* имеет строковое свойство с именем *ColorName* со значением Red. Таким образом, в этом примере создается кнопка с красным фоном.  
  
 [!code-xaml[BindNonTextProperty#1](~/samples/snippets/csharp/VS_Snippets_Wpf/BindNonTextProperty/CS/Page1.xaml#1)]  
  
 Дополнительные сведения о синтаксисе объявления привязки и примеры настройки привязки в коде см. в разделе [Общие сведения об объявлении привязок](binding-declarations-overview.md).  
  
 Если применить этот пример к основной диаграмме, полученное изображение будет выглядеть следующим образом. Это <xref:System.Windows.Data.BindingMode.OneWay> привязке, так как свойство Background поддерживает <xref:System.Windows.Data.BindingMode.OneWay> привязки по умолчанию.  
  
 ![Схема, показывающая свойства Background привязки данных.](./media/data-binding-overview/data-binding-button-background-example.png)  
  
 Может возникнуть вопрос, почему это работает, даже если *ColorName* свойство имеет строковый тип при <xref:System.Windows.Controls.Control.Background%2A> свойство имеет тип <xref:System.Windows.Media.Brush>. Это происходит в результате преобразования типов по умолчанию, которое обсуждается в разделе [Преобразование данных](#data_conversion).  
  
<a name="specifying_the_binding_source"></a>   
### <a name="specifying-the-binding-source"></a>Указание источника привязки  
 Обратите внимание на то, что в предыдущем примере источник привязки определялся установкой <xref:System.Windows.FrameworkElement.DataContext%2A> свойство <xref:System.Windows.Controls.DockPanel> элемент. <xref:System.Windows.Controls.Button> Затем наследует <xref:System.Windows.FrameworkElement.DataContext%2A> значение из <xref:System.Windows.Controls.DockPanel>, который является его родительским элементом. Повторим, что объект источника привязки является одним из четырех необходимых компонентов привязки. Таким образом, без указания объекта источника привязки эта привязка не имела бы смысла.  
  
 Есть несколько способов для указания объекта источника привязки. С помощью <xref:System.Windows.FrameworkElement.DataContext%2A> на родительский элемент может быть удобно при привязке нескольких свойств к одному источнику. Однако иногда удобнее указывать источник привязки в отдельных объявлениях привязки. Для предыдущего примера, вместо использования <xref:System.Windows.FrameworkElement.DataContext%2A> свойство, можно указать источник привязки, задав <xref:System.Windows.Data.Binding.Source%2A> свойства непосредственно в объявлении привязки кнопки, как показано в следующем примере:  
  
 [!code-xaml[BindNonTextProperty#BackgroundBindingCompact](~/samples/snippets/csharp/VS_Snippets_Wpf/BindNonTextProperty/CS/Page2.xaml#backgroundbindingcompact)]  
  
 Кроме установки <xref:System.Windows.FrameworkElement.DataContext%2A> свойство на элементе напрямую, наследование <xref:System.Windows.FrameworkElement.DataContext%2A> от предка (например, кнопки в первом примере) и явного указания источника привязки, задав <xref:System.Windows.Data.Binding.Source%2A> свойство <xref:System.Windows.Data.Binding> (например, кнопки в последнем примере), можно также использовать <xref:System.Windows.Data.Binding.ElementName%2A> свойство или <xref:System.Windows.Data.Binding.RelativeSource%2A> свойство, чтобы указать источник привязки. <xref:System.Windows.Data.Binding.ElementName%2A> Свойство полезно, если при привязке к другим элементам в приложении, например при использовании ползунка для настройки ширины кнопки. <xref:System.Windows.Data.Binding.RelativeSource%2A> Свойство полезно, если привязка задается в <xref:System.Windows.Controls.ControlTemplate> или <xref:System.Windows.Style>. Дополнительные сведения см. в разделе [Указание источника привязки](how-to-specify-the-binding-source.md).  
  
<a name="specifying_the_path_to_the_value"></a>   
### <a name="specifying-the-path-to-the-value"></a>Указание пути к значению  
 Если источник привязки является объектом, то использовать <xref:System.Windows.Data.Binding.Path%2A> свойство, чтобы указать значение, используемое для привязки. Если при привязке к [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)] данных, использовать <xref:System.Windows.Data.Binding.XPath%2A> свойство, чтобы указать значение. В некоторых случаях, возможно, применяемой к использованию <xref:System.Windows.Data.Binding.Path%2A> свойство даже в том случае, когда база данных находится [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)]. Например, если вы хотите получить доступ к свойству Name возвращаемого XmlNode (в результате запроса XPath), следует использовать <xref:System.Windows.Data.Binding.Path%2A> свойства в дополнение к <xref:System.Windows.Data.Binding.XPath%2A> свойство.  
  
 Сведения о синтаксисе и примеры см. в разделе <xref:System.Windows.Data.Binding.Path%2A> и <xref:System.Windows.Data.Binding.XPath%2A> страницы свойств.  
  
 Обратите внимание, что, несмотря на то, что мы и подчеркнули, <xref:System.Windows.Data.Binding.Path%2A> к используемому значению является одним из четырех необходимых компонентов привязки, в сценариях, когда вы хотите выполнить привязку ко всему объекту, используемое значение будет таким же, как объект источника привязки. В таком случае это касается и не указывайте <xref:System.Windows.Data.Binding.Path%2A>. Рассмотрим следующий пример.  
  
 [!code-xaml[MasterDetail#EmptyBinding](~/samples/snippets/csharp/VS_Snippets_Wpf/MasterDetail/CSharp/Page1.xaml#emptybinding)]  
  
 В приведенном выше примере используется синтаксис пустой привязки: {Binding}. В этом случае <xref:System.Windows.Controls.ListBox> наследует DataContext от родительского элемента DockPanel (не показано в следующем примере). Если путь не указан, по умолчанию производится привязка ко всему объекту. Другими словами, в этом примере путь был указан, так как выполняется привязка <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A> свойство ко всему объекту. (Подробное описание см. в разделе [Привязка к коллекциям](#binding_to_collections).)  
  
 Кроме привязки к коллекции, этот сценарий полезен также для привязки ко всему объекту, а не только к одному свойству объекта. Например, если объект источника является объектом строкового типа и всего лишь нужна привязка к самой строке. Другим распространенным сценарием является необходимость привязки элемента к объекту с несколькими свойствами.  
  
 Обратите внимание, что может потребоваться применить пользовательскую логику, чтобы данные имели смысл для свойства целевого объекта привязки. Пользовательская логика может иметь вид пользовательского преобразователя (если тип преобразования по умолчанию не существует). Сведения о преобразователях см. в разделе [Преобразование данных](#data_conversion).  
  
<a name="binding_bindingexpression"></a>   
### <a name="binding-and-bindingexpression"></a>Привязка и класс BindingExpression  
 До разъяснения других функций и использования привязки данных, было бы полезно рассказать <xref:System.Windows.Data.BindingExpression> класса. Как видно в предыдущих разделах, <xref:System.Windows.Data.Binding> класс является классом высокого уровня для объявления привязки; <xref:System.Windows.Data.Binding> класс предоставляет множество свойств, которые позволяют указать характеристики привязки. Связанный класс, <xref:System.Windows.Data.BindingExpression>, является базовым объектом, поддерживающим связь между источником и целью. Привязка содержит всю информацию, которая может использоваться совместно в нескольких выражениях привязки. Объект <xref:System.Windows.Data.BindingExpression> представляет собой экземпляр выражения, который нельзя использовать совместно и содержит все сведения об экземпляре <xref:System.Windows.Data.Binding>.  
  
 Например, рассмотрим следующую команду, где *myDataObject* является экземпляром класса *MyData* класс, *myBinding* является источником <xref:System.Windows.Data.Binding> объекта и *MyData* класс представляет собой определенный класс, который содержит строковое свойство с именем *MyDataProperty*. В этом примере привязывается текстовое содержимое *mytext*, экземпляр <xref:System.Windows.Controls.TextBlock>, *MyDataProperty*.  
  
 [!code-csharp[CodeOnlyBinding#1](~/samples/snippets/csharp/VS_Snippets_Wpf/CodeOnlyBinding/CSharp/binding.cs#1)]
   
  
 Один и тот же объект *myBinding* можно использовать для создания других привязок. Например, можно использовать объект *myBinding* для привязки текстового содержимого флажка к *MyDataProperty*. В этом сценарии будут два экземпляра <xref:System.Windows.Data.BindingExpression> совместное использование *myBinding* объекта.  
  
 Объект <xref:System.Windows.Data.BindingExpression> объекта можно получить с помощью возвращаемого значения метода <xref:System.Windows.Data.BindingOperations.GetBindingExpression%2A> в объекте с привязкой к данным. В следующих разделах описываются некоторые примеры использования <xref:System.Windows.Data.BindingExpression> класса:  
  
-   [Получение объекта привязки из свойства целевого объекта привязки](how-to-get-the-binding-object-from-a-bound-target-property.md)  
  
-   [Управление обновлением источника из поля TextBox](how-to-control-when-the-textbox-text-updates-the-source.md)  
  
<a name="data_conversion"></a>   
## <a name="data-conversion"></a>Преобразование данных  
 В предыдущем примере кнопка красная так как его <xref:System.Windows.Controls.Control.Background%2A> свойство привязано к строковому свойству со значением «Красный». Это работает, поскольку преобразователь типов присутствует на <xref:System.Windows.Media.Brush> тип преобразовать строковое значение для <xref:System.Windows.Media.Brush>.  
  
 Если добавить эти сведения в рисунок из раздела [Создание привязки](#creating_a_binding), схема будет выглядеть следующим образом.  
  
 ![Схема, показывающая свойство привязки данных по умолчанию.](./media/data-binding-overview/data-binding-button-default-conversion.png)  
  
 Однако, что делать, если вместо свойства строкового типа объект источника привязки имеет *цвет* свойство типа <xref:System.Windows.Media.Color>? В этом случае в порядке для создания привязки необходимо включить первый *цвет* значение свойства в нечто, <xref:System.Windows.Controls.Control.Background%2A> значение свойства. Необходимо создать пользовательский преобразователь, реализовав <xref:System.Windows.Data.IValueConverter> интерфейс, как показано в следующем примере:  
  
 [!code-csharp[ColorPicker_snip#16](~/samples/snippets/csharp/VS_Snippets_Wpf/ColorPicker_snip/CSharp/ColorPickerLib/ColorPicker.cs#16)]
   
  
 <xref:System.Windows.Data.IValueConverter> Справочной странице предоставляет дополнительные сведения.  
  
 Теперь пользовательский преобразователь используется вместо преобразования по умолчанию и схема выглядит следующим образом.  
  
 ![Схема, показывающая пользовательский преобразователь привязки данных.](./media/data-binding-overview/data-binding-converter-color-example.png)  
  
 Таким образом, преобразования по умолчанию могут быть доступны благодаря преобразователям типов, присутствующим в типе, к которому производится привязка. Такое поведение будет зависеть от того, какие преобразователи типов доступны в целевом объекте. Если существуют какие-то сомнением, создайте свой собственный преобразователь.  
  
 Ниже приведены некоторые типовые сценарии, где имеет смысл реализация преобразователя данных.  
  
-   Данные должны отображаться по-разному в зависимости от региональных стандартов. Например, можно реализовать преобразователь валюты или преобразователь даты/времени в календаре на основе значений или стандартов, используемых в определенных региональных стандартах.  
  
-   Используемые данные не обязательно предназначены для изменения текстового значения свойства, а предназначены для изменения некоторых других значений, например источника изображения, цвета или стиля отображаемого текста. Преобразователи могут использоваться в данном экземпляре для преобразования привязки неподходящего свойства, например привязки текстового поля к свойству Background ячейки таблицы.  
  
-   К одним и тем же данным может быть привязано несколько элементов управления или несколько свойств элементов управления. В этом случае основная привязка может просто отображать текст, тогда как другие привязки обрабатывают специфичные проблемы отображения, но они по-прежнему используют одну и ту же привязку в качестве исходных данных.  
  
-   Пока мы еще не рассматривали <xref:System.Windows.Data.MultiBinding>, где свойство цели имеет коллекцию привязок. В случае использования <xref:System.Windows.Data.MultiBinding>, следует использовать пользовательский <xref:System.Windows.Data.IMultiValueConverter> для получения окончательного значения из значений привязок. Например, цвет может быть вычислен из соотношения красного, синего и зеленого значений, которые могут быть значениями одних и тех же или разных объектов источника привязки. См. в разделе <xref:System.Windows.Data.MultiBinding> класс страницы, примеры и Дополнительные сведения.  
  
<a name="binding_to_collections"></a>   
## <a name="binding-to-collections"></a>Привязка к коллекциям  
  
 Объект источника привязки может рассматриваться как отдельный объект, свойства которого содержат данные, или как коллекция данных полиморфных объектов, часто группируемых вместе (например, в результате запроса к базе данных). Пока еще мы обсуждали привязку только к одному объекту, однако привязка к коллекции данных является распространенным сценарием. Например, распространенным сценарием является использование <xref:System.Windows.Controls.ItemsControl> например <xref:System.Windows.Controls.ListBox>, <xref:System.Windows.Controls.ListView>, или <xref:System.Windows.Controls.TreeView> для отображения коллекции данных, такие как в приложении, показанном в [новые возможности привязки данных?](#what_is_data_binding) раздел.  
  
 К счастью, наша основная схема по-прежнему применима. При связывании <xref:System.Windows.Controls.ItemsControl> коллекции, то диаграмма будет выглядеть следующим образом:  
  
 ![Схема, показывающая объект ItemsControl привязки данных.](./media/data-binding-overview/data-binding-itemscontrol.png)  
  
 Как показано на этой схеме для привязки <xref:System.Windows.Controls.ItemsControl> на объект коллекции <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A> свойством является свойство для использования. Можно представить себе <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A> свойство как содержимое <xref:System.Windows.Controls.ItemsControl>. Обратите внимание, что привязка <xref:System.Windows.Data.BindingMode.OneWay> поскольку <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A> поддерживает свойство <xref:System.Windows.Data.BindingMode.OneWay> привязки по умолчанию.  
  
<a name="how_to_implement_collections"></a>   
### <a name="how-to-implement-collections"></a>Способы реализации коллекций  
 Пользователь может выполнить перечисление любой коллекции, реализующей <xref:System.Collections.IEnumerable> интерфейс. Тем не менее чтобы настроить динамические привязки таким образом, чтобы обновить вставки и удаления элементов в коллекции UI автоматически, в коллекции должен быть реализован <xref:System.Collections.Specialized.INotifyCollectionChanged> интерфейс. Этот интерфейс предоставляет событие, которое должно вызываться при каждом изменении коллекции.  
  
 WPF предоставляет <xref:System.Collections.ObjectModel.ObservableCollection%601> класс, который является встроенной реализацией коллекции данных, предоставляющей <xref:System.Collections.Specialized.INotifyCollectionChanged> интерфейс. Обратите внимание, что для полной поддержки передачи значений данных от объектов источника для целевых объектов, каждый объект в коллекции, который поддерживает свойства связывания должен также реализовывать <xref:System.ComponentModel.INotifyPropertyChanged> интерфейс. Дополнительные сведения см. в разделе [Общие сведения об источниках привязки](binding-sources-overview.md).  
  
 Перед реализацией свою собственную коллекцию, рассмотрите возможность использования <xref:System.Collections.ObjectModel.ObservableCollection%601> или один из существующей коллекции классов, таких как <xref:System.Collections.Generic.List%601>, <xref:System.Collections.ObjectModel.Collection%601>, и <xref:System.ComponentModel.BindingList%601>, среди прочих. Если имеется расширенный скрипт и требуется реализовать свою собственную коллекцию, рассмотрите возможность использования <xref:System.Collections.IList>, который предоставляет неуниверсальную коллекцию объектов, которые можно получить индивидуальный доступ по индексу и, следовательно, максимальную производительность.  
  
<a name="collection_views"></a>   
### <a name="collection-views"></a>Представления коллекций  
 Один раз в <xref:System.Windows.Controls.ItemsControl> привязан к коллекции данных, может потребоваться сортировка, фильтрация и группировать данные. Чтобы сделать это, используйте представления коллекций, которые являются классами, реализующими <xref:System.ComponentModel.ICollectionView> интерфейс.  

#### <a name="what-are-collection-views"></a>Понятие о представлениях коллекций  
 Представление коллекции — это слой, расположенный в верхней части связанной исходной коллекции, с помощью которого можно перемещаться по исходной коллекции и просматривать ее содержимое на основе запросов сортировки, фильтрации и группировки, не изменяя саму коллекцию. В представлении коллекции также поддерживается указатель на текущий элемент коллекции. Если в исходной коллекции реализован <xref:System.Collections.Specialized.INotifyCollectionChanged> интерфейс, изменения, инициированные <xref:System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged> событие, передаются представлениям.  
  
 Так как представления не меняют базовые исходные коллекции, каждая исходная коллекция может иметь несколько связанных с ней представлений. Например, имеется коллекция объектов *Task*. С помощью представлений можно отображать одни и те же данные различными способами. Например, в левой части страницы можно отображать задачи, отсортированные по приоритету, а справа — сгруппированные по областям.  
  
<a name="how_to_create_a_view"></a>   
#### <a name="how-to-create-a-view"></a>Создание представления  
 Одним из способов создания и использования представления является непосредственное создание объекта представления и затем использование его в качестве источника привязки. В качестве примера рассмотрим приложение [Пример привязки данных](https://go.microsoft.com/fwlink/?LinkID=163703), показанное в подразделе [Понятие привязки данных](#what_is_data_binding). Приложение реализовано таким образом, чтобы <xref:System.Windows.Controls.ListBox> привязывается к представлению коллекции данных, а не в коллекции данных напрямую. Следующий пример извлекается из приложения [Пример привязки данных](https://go.microsoft.com/fwlink/?LinkID=163703). <xref:System.Windows.Data.CollectionViewSource> Класс является XAML прокси-сервера, который наследует от класса <xref:System.Windows.Data.CollectionView>. В данном конкретном примере <xref:System.Windows.Data.CollectionViewSource.Source%2A> представления привязан к *AuctionItems* коллекции (типа <xref:System.Collections.ObjectModel.ObservableCollection%601>) текущего объекта приложения.  
  
 [!code-xaml[DataBindingLab#WindowResources1](~/samples/snippets/csharp/VS_Snippets_Wpf/DataBindingLab/CSharp/MainWindow.xaml#windowresources1)]  
[!code-xaml[DataBindingLab#CollectionViewSource](~/samples/snippets/csharp/VS_Snippets_Wpf/DataBindingLab/CSharp/MainWindow.xaml#collectionviewsource)]  
[!code-xaml[DataBindingLab#WindowResources2](~/samples/snippets/csharp/VS_Snippets_Wpf/DataBindingLab/CSharp/MainWindow.xaml#windowresources2)]  
  
 Ресурс *listingDataView* выступает в качестве источника привязки для элементов в приложении, такие как <xref:System.Windows.Controls.ListBox>:  
  
 [!code-xaml[DataBindingLab#Master1](~/samples/snippets/csharp/VS_Snippets_Wpf/DataBindingLab/CSharp/MainWindow.xaml#master1)]  
[!code-xaml[DataBindingLab#Master2](~/samples/snippets/csharp/VS_Snippets_Wpf/DataBindingLab/CSharp/MainWindow.xaml#master2)]  
  
 Чтобы создать другое представление для той же коллекции, можно создать другое <xref:System.Windows.Data.CollectionViewSource> экземпляра и присвоить ему другое `x:Key` имя.  
  
 В следующей таблице показано, какие типы данных представления создаются в качестве представления коллекции по умолчанию или с помощью <xref:System.Windows.Data.CollectionViewSource> зависимости от типа исходной коллекции.  
  
|Тип исходной коллекции|Тип представления коллекции|Примечания|  
|----------------------------|--------------------------|-----------|  
|<xref:System.Collections.IEnumerable>|Внутренний тип, основанный на <xref:System.Windows.Data.CollectionView>|Невозможно группировать элементы.|  
|<xref:System.Collections.IList>|<xref:System.Windows.Data.ListCollectionView>|Самый быстрый.|  
|<xref:System.ComponentModel.IBindingList>|<xref:System.Windows.Data.BindingListCollectionView>||  
  
##### <a name="using-a-default-view"></a>Использование представления по умолчанию  
 Один из способов создания и использования представления коллекции заключается в указании представления коллекции в качестве источника привязки. WPF также создает представление коллекции по умолчанию для каждой коллекции, используемой в качестве источника привязки. Если выполнить привязку непосредственно к коллекции, WPF выполняет привязку к представлению коллекции по умолчанию. Обратите внимание, что данное представление по умолчанию совместно используется всеми привязками к одной и той же коллекции, поэтому изменения, внесенные в представление по умолчанию одним привязанным элементом управления либо кодом (например, сортировка или изменение указателя на текущий элемент, что будет рассмотрено ниже), распространяются на все привязки к одной коллекции.  
  
 Чтобы получить представление по умолчанию, используйте <xref:System.Windows.Data.CollectionViewSource.GetDefaultView%2A> метод. Пример см. в разделе [Практическое руководство. Получение представления по умолчанию для коллекции данных](how-to-get-the-default-view-of-a-data-collection.md).  
  
##### <a name="collection-views-with-adonet-datatables"></a>Использование представлений коллекций с таблицами данных ADO.NET  
 Для повышения производительности представления коллекций для ADO.NET <xref:System.Data.DataTable> или <xref:System.Data.DataView> объектов делегируют функции сортировки и фильтрации для <xref:System.Data.DataView>. При этом функции сортировки и фильтрации совместно используются всеми представлениями коллекции для источника данных. Чтобы включить для независимой сортировки и фильтрации для каждого представления коллекции, инициализируйте каждое представление коллекции с собственным <xref:System.Data.DataView> объекта.  
  
#### <a name="sorting"></a>Сортировка  
 Как уже отмечалось ранее, представления могут применять сортировку для коллекции. Так как данные находятся в базовой коллекции, они могут иметь или не иметь некий порядок следования. Представление коллекции позволяет установить порядок или изменить порядок, используемый по умолчанию, на основе введенных признаков сравнения. Так как это представление данных на стороне клиента, распространенным скриптом является сортировка пользователем столбцов табличных данных по значениям, содержащимся в столбце. С использованием представлений управляемая пользователем сортировка может применяться еще раз без необходимости внесения изменений в основную коллекцию или создания повторного запроса к содержимому коллекции. Пример см. в разделе [Практическое руководство. Сортировка столбцов GridView при нажатии на заголовок](../controls/how-to-sort-a-gridview-column-when-a-header-is-clicked.md).  
  
 В следующем примере показано логика сортировки «Сортировать по категориям и дате» <xref:System.Windows.Controls.CheckBox> приложения UI в [новые возможности привязки данных?](#what_is_data_binding) раздел:  
  
 [!code-csharp[DataBindingLab#8](~/samples/snippets/csharp/VS_Snippets_Wpf/DataBindingLab/CSharp/MainWindow.xaml.cs#8)]
   
  
#### <a name="filtering"></a>Фильтрация  
 Представления могут применять к коллекции фильтр. Это означает, что несмотря на то что элемент может существовать в коллекции, его конкретное представление предназначено для отображения только некоторого подмножества полной коллекции. Возможна фильтрация по условию в данных. Например, как показано в приложение в [новые возможности привязки данных?](#what_is_data_binding) разделе «Показывать только товары по сниженным ценам» <xref:System.Windows.Controls.CheckBox> содержит логику фильтрации товаров с ценой 25 долл. Следующий код выполняется для установки *ShowOnlyBargainsFilter* как <xref:System.Windows.Data.CollectionViewSource.Filter> обработчик событий при, <xref:System.Windows.Controls.CheckBox> выбран:  
  
 [!code-csharp[DataBindingLab#10](~/samples/snippets/csharp/VS_Snippets_Wpf/DataBindingLab/CSharp/MainWindow.xaml.cs#10)]
   
  
 Обработчик события *ShowOnlyBargainsFilter* реализуется следующим образом.  
  
 [!code-csharp[DataBindingLab#5](~/samples/snippets/csharp/VS_Snippets_Wpf/DataBindingLab/CSharp/MainWindow.xaml.cs#5)]
   
  
 Если вы используете один из <xref:System.Windows.Data.CollectionView> классы напрямую вместо того <xref:System.Windows.Data.CollectionViewSource>, использовалась бы <xref:System.Windows.Data.CollectionView.Filter%2A> свойство, чтобы указать обратный вызов. Пример см. в разделе [Практическое руководство. Фильтрация данных в представлении](how-to-filter-data-in-a-view.md).  
  
#### <a name="grouping"></a>Группирование  
 За исключением внутреннего класса, <xref:System.Collections.IEnumerable> коллекции, все представления коллекций поддерживают функцию группировки, которая позволяет разбить коллекцию в представлении коллекции на логические группы. Группы могут быть явными, если пользователь предоставляет список групп, или неявными, если эти группы создаются динамически в зависимости от данных.  
  
 В следующем примере показано логику «Группировать по категории» <xref:System.Windows.Controls.CheckBox>:  
  
 [!code-csharp[DataBindingLab#6](~/samples/snippets/csharp/VS_Snippets_Wpf/DataBindingLab/CSharp/MainWindow.xaml.cs#6)]
   
  
 Другой пример группировки см. в разделе [Практическое руководство. Группировка элементов в объекте ListView, реализующем GridView](../controls/how-to-group-items-in-a-listview-that-implements-a-gridview.md).  
  
#### <a name="current-item-pointers"></a>Указатели на текущий элемент  
 В представлениях также присутствует понятие текущего элемента. Существует возможность перемещаться по объектам в представлении коллекции. При переходе перемещается указатель элемента, позволяющий извлечь объект, расположенный в определенном месте в коллекции. Пример см. в разделе [Перемещение по объектам в Data CollectionView](how-to-navigate-through-the-objects-in-a-data-collectionview.md).  
  
 Поскольку WPF выполняет привязку к коллекции только с помощью представления (либо указанного пользователем, либо представления коллекции по умолчанию), для всех привязок к коллекциям имеется указатель на текущий элемент. При привязке к представлению символ косой черты ("/") в значении `Path` указывает на текущий элемент представления. В следующем примере контекст данных является представлением коллекции. В первой строке выполняется привязка к коллекции. Во второй строке выполняется привязка к текущему элементу коллекции. В третьей строке выполняется привязка к свойству `Description` текущего элемента коллекции.  
  
```xaml  
<Button Content="{Binding }" />  
<Button Content="{Binding Path=/}" />  
<Button Content="{Binding Path=/Description}" />   
```  
  
 Косую черту и синтаксис свойства также можно комбинировать для обработки иерархии коллекций. В приведенном ниже примере выполняется привязка к текущему элементу коллекции `Offices`, который является свойством текущего элемента исходной коллекции.  
  
```xaml  
<Button Content="{Binding /Offices/}" />  
```  
  
 На указатель текущего элемента влияют примененные к коллекции операции сортировки и фильтрации. При сортировке указатель текущего элемента устанавливается на последний выбранный элемент, однако представление коллекции перестраивается относительно его. (Возможно, до этого выбранный элемент был в начале списка, но теперь выбранный элемент может оказаться где-нибудь в середине.) При фильтрации выбранный элемент сохраняется, если данный выбор остается в представлении после фильтрации. В противном случае указатель текущего элемента устанавливается на первый элемент отфильтрованного представления коллекции.  
  
<a name="master_detail_scenario"></a>   
#### <a name="master-detail-binding-scenario"></a>Сценарий "основной — подробности"  
 Понятие текущего элемента применимо не только для перемещения элементов в коллекции, но также для сценария привязки "основной — подробности". Еще раз рассмотрим UI приложения из подраздела [Понятие привязки данных](#what_is_data_binding). В этом приложении выделение в <xref:System.Windows.Controls.ListBox> определяет содержимое, показанное в <xref:System.Windows.Controls.ContentControl>. Чтобы поместить его в другой способ, при <xref:System.Windows.Controls.ListBox> элемент выделен, <xref:System.Windows.Controls.ContentControl> отображает сведения о выбранного элемента.  
  
 Для реализации этого сценария необходимо наличие двух или более элементов управления, привязанных к одному и тому же представлению. В следующем примере из [пример привязки данных](https://go.microsoft.com/fwlink/?LinkID=163703) показана разметка элементов <xref:System.Windows.Controls.ListBox> и <xref:System.Windows.Controls.ContentControl> появится в приложении UI в [новые возможности привязки данных?](#what_is_data_binding) раздел:  
  
 [!code-xaml[DataBindingLab#Master1](~/samples/snippets/csharp/VS_Snippets_Wpf/DataBindingLab/CSharp/MainWindow.xaml#master1)]  
[!code-xaml[DataBindingLab#Master2](~/samples/snippets/csharp/VS_Snippets_Wpf/DataBindingLab/CSharp/MainWindow.xaml#master2)]  
[!code-xaml[DataBindingLab#Detail](~/samples/snippets/csharp/VS_Snippets_Wpf/DataBindingLab/CSharp/MainWindow.xaml#detail)]  
  
 Обратите внимание, что оба элемента управления привязаны к одному источнику, статическому ресурсу *listingDataView* (просмотреть определение этого ресурса можно в подразделе [Создание представления](#how_to_create_a_view)). Это работает, поскольку если объект одноэлементного множества ( <xref:System.Windows.Controls.ContentControl> в данном случае) связан с представлением коллекции, он автоматически привязывается к <xref:System.Windows.Data.CollectionView.CurrentItem%2A> представления. Обратите внимание, что <xref:System.Windows.Data.CollectionViewSource> объекты автоматически синхронизировать денежного формата и выделение. Если элемент управления списка не привязан к <xref:System.Windows.Data.CollectionViewSource> объект как в этом примере, то необходимо задать его <xref:System.Windows.Controls.Primitives.Selector.IsSynchronizedWithCurrentItem%2A> свойства `true` для правильной работы.  
  
 Другие примеры см. в разделах [Практическое руководство. Привязка к коллекции и вывод сведений в зависимости от выделенного элемента](how-to-bind-to-a-collection-and-display-information-based-on-selection.md) и [Практическое руководство. Использование шаблона "главный — подчиненный" с иерархическими данными](how-to-use-the-master-detail-pattern-with-hierarchical-data.md).  
  
 Можно заметить, что в приведенном выше примере используется шаблон. На самом деле, данные не будут отображаться выбранным способом без использования шаблонов (один явно используется элементом <xref:System.Windows.Controls.ContentControl> и неявно используется <xref:System.Windows.Controls.ListBox>). К шаблонам данных мы перейдем в следующем разделе.  
  
<a name="data_templating"></a>   
## <a name="data-templating"></a>Шаблоны данных  
 Без использования шаблонов данных UI приложения в подразделе [Понятие привязки данных](#what_is_data_binding) будет выглядеть следующим образом.  
  
 ![Демонстрация привязки данных без шаблонов данных](./media/data-binding-overview/data-binding-demo-templates.png)  
  
 Как показано в примере в предыдущем разделе, как <xref:System.Windows.Controls.ListBox> управления и <xref:System.Windows.Controls.ContentControl> привязаны к всему объекту коллекции (или точнее, представление объекта коллекции) из *AuctionItem*s. Отсутствии особых инструкций по способу отображения сбора данных <xref:System.Windows.Controls.ListBox> отображает строковое представление каждого объекта в базовой коллекции и <xref:System.Windows.Controls.ContentControl> отображает строковое представление объекта, он связан.  
  
 Чтобы решить эту проблему, приложение определяет <xref:System.Windows.DataTemplate>s. Как показано в примере в предыдущем разделе, <xref:System.Windows.Controls.ContentControl> явным образом использует *detailsProductListingTemplate*<xref:System.Windows.DataTemplate>. <xref:System.Windows.Controls.ListBox> Управления неявно использует следующий <xref:System.Windows.DataTemplate> при отображении *AuctionItem* объектов в коллекции:  
  
 [!code-xaml[DataBindingLab#AuctionItemDataTemplate](~/samples/snippets/csharp/VS_Snippets_Wpf/DataBindingLab/CSharp/DataBindingLabApp.xaml#auctionitemdatatemplate)]  
  
 С помощью этих двух <xref:System.Windows.DataTemplate>, результирующий пользовательский Интерфейс имеет, описанной в [новые возможности привязки данных?](#what_is_data_binding) раздел. Как видно из этого снимка, в дополнение к возможности размещать данные в элементах управления, <xref:System.Windows.DataTemplate>s позволяют определять подходящие визуальные элементы для данных. Например <xref:System.Windows.DataTrigger>s используются выше <xref:System.Windows.DataTemplate> таким образом, чтобы *AuctionItem*s с *SpecialFeatures* значение *выделите* отображались с Оранжевые границы и помечается звездочкой.  
  
 Дополнительные сведения о шаблонах данных см. в разделе [Общие сведения о шаблонах данных](data-templating-overview.md).  
  
<a name="data_validation"></a>   
## <a name="data-validation"></a>Проверка данных  
  
 Для большинства приложений, принимающих входные данные от пользователя, необходима логика проверки, чтобы убедиться, что пользователь ввел ожидаемые данные. Проверка может основываться на типе, диапазоне, формате или других требованиях конкретного приложения. В этом разделе рассматривается, как работает проверка данных в WPF.  
  
### <a name="associating-validation-rules-with-a-binding"></a>Связь правил проверки и привязки  
 WPF Модель привязки данных, вы сможете связать <xref:System.Windows.Data.Binding.ValidationRules%2A> с вашей <xref:System.Windows.Data.Binding> объекта. Например, следующий пример связывает <xref:System.Windows.Controls.TextBox> к свойству с именем `StartPrice` и добавляет <xref:System.Windows.Controls.ExceptionValidationRule> объект <xref:System.Windows.Data.Binding.ValidationRules%2A?displayProperty=nameWithType> свойство.  
  
 [!code-xaml[DataBindingLab#DefaultValidation](~/samples/snippets/csharp/VS_Snippets_Wpf/DataBindingLab/CSharp/AddProductWindow.xaml#defaultvalidation)]  
  
 Объект <xref:System.Windows.Controls.ValidationRule> объект проверяет, является ли допустимым значение свойства. WPF имеются следующие два встроенных <xref:System.Windows.Controls.ValidationRule> объектов:  
  
-   Объект <xref:System.Windows.Controls.ExceptionValidationRule> проверяет исключения, возникшие во время обновления свойства источника привязки. В предыдущем примере `StartPrice` имеет тип integer. Когда пользователь вводит значение, которое невозможно преобразовать в целое число, создается исключение, приводящее к тому, что привязка будет помечена как недопустимая. Альтернативный синтаксис параметра <xref:System.Windows.Controls.ExceptionValidationRule> явным образом заключается в задании <xref:System.Windows.Data.Binding.ValidatesOnExceptions%2A> свойства `true` на вашей <xref:System.Windows.Data.Binding> или <xref:System.Windows.Data.MultiBinding> объекта.  
  
-   Объект <xref:System.Windows.Controls.DataErrorValidationRule> выполняет проверку ошибок, вызываемых объектами, реализующими <xref:System.ComponentModel.IDataErrorInfo> интерфейс. Пример использования этого правила проверки, см. в разделе <xref:System.Windows.Controls.DataErrorValidationRule>. Альтернативный синтаксис параметра <xref:System.Windows.Controls.DataErrorValidationRule> явным образом заключается в задании <xref:System.Windows.Data.Binding.ValidatesOnDataErrors%2A> свойства `true` на вашей <xref:System.Windows.Data.Binding> или <xref:System.Windows.Data.MultiBinding> объекта.  
  
 Можно также создать свои собственные правила проверки путем наследования от <xref:System.Windows.Controls.ValidationRule> класса и реализации <xref:System.Windows.Controls.ValidationRule.Validate%2A> метод. В следующем примере показано правило, используемое элементом *Добавление списка продуктов* «Дата начала» <xref:System.Windows.Controls.TextBox> из [новые возможности привязки данных?](#what_is_data_binding) раздел:  
  
 [!code-csharp[DataBindingLab#2](~/samples/snippets/csharp/VS_Snippets_Wpf/DataBindingLab/CSharp/FutureDateRule.cs#2)]
   
  
 *StartDateEntryForm* <xref:System.Windows.Controls.TextBox> использует этот *FutureDateRule*, как показано в следующем примере:  
  
 [!code-xaml[DataBindingLab#CustomValidation](~/samples/snippets/csharp/VS_Snippets_Wpf/DataBindingLab/CSharp/AddProductWindow.xaml#customvalidation)]  
  
 Обратите внимание, что поскольку <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A> значение <xref:System.Windows.Data.UpdateSourceTrigger.PropertyChanged>, механизм привязки обновляет значение источника при каждом нажатии клавиши, то есть он также проверяет каждое правило в <xref:System.Windows.Data.Binding.ValidationRules%2A> коллекцию при каждом нажатии клавиши. Это будет обсуждаться далее в разделе "Процесс проверки".  
  
<a name="invalidation_feedback"></a>   
### <a name="providing-visual-feedback"></a>Предоставление визуального отклика  
 Если пользователь вводит недопустимое значение, можно сформировать отклик приложения UI на ошибку. Один из способов обеспечения такого отклика является установление <xref:System.Windows.Controls.Validation.ErrorTemplate%2A?displayProperty=nameWithType> присоединенное свойство пользовательского <xref:System.Windows.Controls.ControlTemplate>. Как показано в предыдущем подразделе, *StartDateEntryForm* <xref:System.Windows.Controls.TextBox> использует <xref:System.Windows.Controls.Validation.ErrorTemplate%2A> вызывается *validationTemplate*. В следующем примере показано определение элемента *validationTemplate*.  
  
 [!code-xaml[DataBindingLab#1](~/samples/snippets/csharp/VS_Snippets_Wpf/DataBindingLab/CSharp/AddProductWindow.xaml#1)]  
  
 <xref:System.Windows.Controls.AdornedElementPlaceholder> Элемент указывает, где должен размещаться элемент управления.  
  
 Кроме того, можно также использовать <xref:System.Windows.Controls.ToolTip> отображение сообщений об ошибках. Оба *StartDateEntryForm* и *StartPriceEntryForm*<xref:System.Windows.Controls.TextBox>используют стиль *textStyleTextBox*, который создает <xref:System.Windows.Controls.ToolTip> , Отображает сообщение об ошибке. В следующем примере показано определение элемента *textStyleTextBox*. Присоединенное свойство <xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> является `true` когда один или несколько привязок к свойствам связанного элемента находятся в ошибки.  
  
 [!code-xaml[DataBindingLab#14](~/samples/snippets/csharp/VS_Snippets_Wpf/DataBindingLab/CSharp/DataBindingLabApp.xaml#14)]  
  
 С помощью пользовательского <xref:System.Windows.Controls.Validation.ErrorTemplate%2A> и <xref:System.Windows.Controls.ToolTip>, *StartDateEntryForm* <xref:System.Windows.Controls.TextBox> при ошибке проверки выглядит следующим образом:  
  
 ![Ошибка проверки привязки данных](./media/databindingdemo-validation.PNG "DataBindingDemo_Validation")  
  
 Если ваш <xref:System.Windows.Data.Binding> имеет правила проверки, но вы не укажете <xref:System.Windows.Controls.Validation.ErrorTemplate%2A> на связанный элемент управления, по умолчанию <xref:System.Windows.Controls.Validation.ErrorTemplate%2A> будет использоваться для уведомления пользователей об ошибке проверки. Значение по умолчанию <xref:System.Windows.Controls.Validation.ErrorTemplate%2A> — это шаблон элемента управления, определяющий красную границу графического уровня. По умолчанию <xref:System.Windows.Controls.Validation.ErrorTemplate%2A> и <xref:System.Windows.Controls.ToolTip>, UI из *StartPriceEntryForm* <xref:System.Windows.Controls.TextBox> при ошибке проверки выглядит следующим образом:  
  
 ![Ошибка проверки привязки данных](./media/databindingdemo-validationdefault.PNG "DataBindingDemo_ValidationDefault")  
  
 Пример предоставления логики проверки всех элементов управления в диалоговом окне см. в подразделе "Пользовательские диалоговые окна" раздела [Общие сведения о диалоговых окнах](../app-development/dialog-boxes-overview.md).  
  
### <a name="validation-process"></a>Процесс проверки  
 Проверка обычно выполняется, когда целевое значение передается свойству источника привязки. Эта операция выполняется по <xref:System.Windows.Data.BindingMode.TwoWay> и <xref:System.Windows.Data.BindingMode.OneWayToSource> привязки. Таким образом, что причина обновления источника зависит от значения <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A> свойства, как описано в разделе [что инициирует обновления источника](#what_triggers_source_updates) раздел.  
  
 Ниже описан процесс *проверки*. Обратите внимание, что при возникновении ошибки проверки или ошибки другого типа на любом этапе данного процесса процесс будет прерван.  
  
1. Обработчик привязки проверяет наличие пользовательских <xref:System.Windows.Controls.ValidationRule> объекты, определенные, <xref:System.Windows.Controls.ValidationRule.ValidationStep%2A> присваивается <xref:System.Windows.Controls.ValidationStep.RawProposedValue> для этого <xref:System.Windows.Data.Binding>, в этом случае он вызывает <xref:System.Windows.Controls.ValidationRule.Validate%2A> метод на каждом <xref:System.Windows.Controls.ValidationRule> пока не будет запущен один из них произошла ошибка или пока не будут выполнены все из них.  
  
2. Обработчик привязки вызывает преобразователь, если таковой существует.  
  
3. При успешном завершении работы преобразователя обработчик привязки проверяет наличие пользовательских <xref:System.Windows.Controls.ValidationRule> объекты, определенные, <xref:System.Windows.Controls.ValidationRule.ValidationStep%2A> присваивается <xref:System.Windows.Controls.ValidationStep.ConvertedProposedValue> для этого <xref:System.Windows.Data.Binding>, в этом случае он вызывает <xref:System.Windows.Controls.ValidationRule.Validate%2A> метод на каждом <xref:System.Windows.Controls.ValidationRule> с <xref:System.Windows.Controls.ValidationRule.ValidationStep%2A> присвоено <xref:System.Windows.Controls.ValidationStep.ConvertedProposedValue> пока не будет запущен один из них в ошибку или пока не будут выполнены все из них.  
  
4. Обработчик привязки присваивает значение исходному свойству.  
  
5. Обработчик привязки проверяет наличие пользовательских <xref:System.Windows.Controls.ValidationRule> объекты, определенные, <xref:System.Windows.Controls.ValidationRule.ValidationStep%2A> присваивается <xref:System.Windows.Controls.ValidationStep.UpdatedValue> для этого <xref:System.Windows.Data.Binding>, в этом случае он вызывает <xref:System.Windows.Controls.ValidationRule.Validate%2A> метод на каждом <xref:System.Windows.Controls.ValidationRule> с <xref:System.Windows.Controls.ValidationRule.ValidationStep%2A> значение <xref:System.Windows.Controls.ValidationStep.UpdatedValue> пока не будет запущен один из них в ошибку или пока не будут выполнены все из них. Если <xref:System.Windows.Controls.DataErrorValidationRule> связан с привязкой и его <xref:System.Windows.Controls.ValidationRule.ValidationStep%2A> имеет значение по умолчанию, <xref:System.Windows.Controls.ValidationStep.UpdatedValue>, <xref:System.Windows.Controls.DataErrorValidationRule> установлен на этом этапе. Это также является точкой при привязки, в которых <xref:System.Windows.Data.Binding.ValidatesOnDataErrors%2A> присвоено `true` проверяются.  
  
6. Обработчик привязки проверяет наличие пользовательских <xref:System.Windows.Controls.ValidationRule> объекты, определенные, <xref:System.Windows.Controls.ValidationRule.ValidationStep%2A> присваивается <xref:System.Windows.Controls.ValidationStep.CommittedValue> для этого <xref:System.Windows.Data.Binding>, в этом случае он вызывает <xref:System.Windows.Controls.ValidationRule.Validate%2A> метод на каждом <xref:System.Windows.Controls.ValidationRule> с <xref:System.Windows.Controls.ValidationRule.ValidationStep%2A> значение <xref:System.Windows.Controls.ValidationStep.CommittedValue> пока не будет запущен один из них в ошибку или пока не будут выполнены все из них.  
  
 Если <xref:System.Windows.Controls.ValidationRule> не передает в любое время, во время этого процесса, обработчик привязки создает <xref:System.Windows.Controls.ValidationError> и добавляет его к <xref:System.Windows.Controls.Validation.Errors%2A?displayProperty=nameWithType> коллекции привязанного элемента. Перед привязкой запускается ядро <xref:System.Windows.Controls.ValidationRule> объектов на любом этапе, удаляет все <xref:System.Windows.Controls.ValidationError> , добавленный <xref:System.Windows.Controls.Validation.Errors%2A?displayProperty=nameWithType> присоединенное свойство привязанного элемента во время выполнения этого шага. Например если <xref:System.Windows.Controls.ValidationRule> которого <xref:System.Windows.Controls.ValidationRule.ValidationStep%2A> присваивается <xref:System.Windows.Controls.ValidationStep.UpdatedValue> сбой, в следующий раз, происходит процесс проверки, обработчик привязки удалит <xref:System.Windows.Controls.ValidationError> непосредственно перед вызовом любого <xref:System.Windows.Controls.ValidationRule> с <xref:System.Windows.Controls.ValidationRule.ValidationStep%2A> значение <xref:System.Windows.Controls.ValidationStep.UpdatedValue>.  
  
 Когда <xref:System.Windows.Controls.Validation.Errors%2A?displayProperty=nameWithType> не является пустым, <xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> присоединенное свойство элемента имеет значение `true`. Кроме того Если <xref:System.Windows.Data.Binding.NotifyOnValidationError%2A> свойство <xref:System.Windows.Data.Binding> присваивается `true`, то обработчик привязки вызывает <xref:System.Windows.Controls.Validation.Error?displayProperty=nameWithType> присоединенного события в элементе.  
  
 Также Обратите внимание, что при передаче допустимого значения в любом направлении (от целевого объекта к источнику и от источника к целевому объекту) очищается <xref:System.Windows.Controls.Validation.Errors%2A?displayProperty=nameWithType> вложенного свойства зависимостей.  
  
 Если привязки задано <xref:System.Windows.Controls.ExceptionValidationRule> связанные с ней, или было <xref:System.Windows.Data.Binding.ValidatesOnExceptions%2A> свойству `true` и создается исключение при обработчик привязки задает источник, обработчик привязки проверяет наличие <xref:System.Windows.Data.Binding.UpdateSourceExceptionFilter%2A>. У вас есть возможность использовать <xref:System.Windows.Data.Binding.UpdateSourceExceptionFilter%2A> обратного вызова, чтобы предоставить пользовательский обработчик для обработки исключений. Если <xref:System.Windows.Data.Binding.UpdateSourceExceptionFilter%2A> не указан в <xref:System.Windows.Data.Binding>, обработчик привязки создает <xref:System.Windows.Controls.ValidationError> с исключением и добавляет ее к <xref:System.Windows.Controls.Validation.Errors%2A?displayProperty=nameWithType> коллекции привязанного элемента.  
  
## <a name="debugging-mechanism"></a>Механизм отладки  
 Можно задать присоединенное свойство <xref:System.Diagnostics.PresentationTraceSources.TraceLevel%2A?displayProperty=nameWithType> связанные с привязкой объекта для получения сведений о состоянии конкретной привязки.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.DataErrorValidationRule>
- [Новые возможности WPF версии 4.5](../getting-started/whats-new.md)
- [Привязка к результатам запроса LINQ](how-to-bind-to-the-results-of-a-linq-query.md)
- [Привязка данных](../advanced/optimizing-performance-data-binding.md)
- [Пример привязки данных](https://go.microsoft.com/fwlink/?LinkID=163703)
- [Практические руководства](data-binding-how-to-topics.md)
- [Привязка к источнику данных ADO.NET](how-to-bind-to-an-ado-net-data-source.md)

---
title: Новые возможности WPF версии 4.5
ms.date: 03/30/2017
helpviewer_keywords:
- Windows Presentation Foundation [WPF], what's new
- WPF [WPF], what's new
ms.assetid: db086ae4-70bb-4862-95db-2eaca5216bc3
ms.openlocfilehash: 03f785da018cacdec643fa196bdd0c6d5d7c7f70
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59325830"
---
# <a name="whats-new-in-wpf-version-45"></a>Новые возможности WPF версии 4.5
<a name="introduction"></a> Этот раздел содержит сведения о новых и усовершенствованных возможностях [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] версии 4.5.  
  
 В этом разделе содержатся следующие подразделы.  
  
-   [Элемент управления ленты](#ribbon_control)  
  
-   [Повышение производительности при отображении больших наборов сгруппированных данных](#grouped_virtualization)  
  
-   [Новые возможности VirtualizingPanel](#VirtualizingPanel)  
  
-   [Привязка к статическим свойствам](#static_properties)  
  
-   [Доступ к коллекциям в потоках без пользовательского интерфейса](#xthread_access)  
  
-   [Синхронная и асинхронная проверка данных](#INotifyDataErrorInfo)  
  
-   [Автоматическое обновление источника привязки данных](#delay)  
  
-   [Привязки к типам, реализующим ICustomTypeProvider](#ICustomTypeProvider)  
  
-   [Получение сведений о привязке данных из выражения привязки](#binding_state)  
  
-   [Проверка наличия допустимого объекта DataContext](#DisconnectedSource)  
  
-   [Изменение расположения данных по мере изменения их значений (формирование данных в реальном времени)](#live_shaping)  
  
-   [Улучшенная поддержка установления слабой ссылки на событие](#weak_event_pattern)  
  
-   [Новые методы для класса Dispatcher](#async)  
  
-   [Расширения разметки для событий](#events_markup_extenions)  
  
<a name="ribbon_control"></a>   
## <a name="ribbon-control"></a>Элемент управления ленты  
 WPF 4.5 поставляется с <xref:System.Windows.Controls.Ribbon.Ribbon> элемента управления, в которой размещаются панель быстрого доступа, меню приложения и вкладки.  Дополнительные сведения см. в разделе [Общие сведения об ленте](/visualstudio/vsto/ribbon-overview).  
  
<a name="grouped_virtualization"></a>   
## <a name="improved-performance-when-displaying-large-sets-of-grouped-data"></a>Повышение производительности при отображении больших наборов сгруппированных данных  
 Когда подмножество элементов пользовательского интерфейса создается из большего количества элементов данных в зависимости от того, какие из элементов отображаются на экране, происходит виртуализация пользовательского интерфейса. <xref:System.Windows.Controls.VirtualizingPanel> Определяет <xref:System.Windows.Controls.VirtualizingPanel.IsVirtualizingWhenGrouping%2A> присоединенное свойство, обеспечивающее виртуализацию пользовательского интерфейса для сгруппированных данных.  Дополнительные сведения о группировании данных см. в разделе как: Сортировка и группировка данных с помощью представления в XAML.  Дополнительные сведения о виртуализации сгруппированных данных, см. в разделе <xref:System.Windows.Controls.VirtualizingPanel.IsVirtualizingWhenGrouping%2A> вложенного свойства зависимостей.  
  
<a name="VirtualizingPanel"></a>   
## <a name="new-features-for-the-virtualizingpanel"></a>Новые возможности VirtualizingPanel  
  
1. Можно указать ли <xref:System.Windows.Controls.VirtualizingPanel>, такие как <xref:System.Windows.Controls.VirtualizingStackPanel>, отображать частичные элементы с помощью <xref:System.Windows.Controls.VirtualizingPanel.ScrollUnit%2A> вложенного свойства зависимостей. Если <xref:System.Windows.Controls.VirtualizingPanel.ScrollUnit%2A> присваивается <xref:System.Windows.Controls.ScrollUnit.Item>, <xref:System.Windows.Controls.VirtualizingPanel> будут отображаться только полностью видимые элементы. Если <xref:System.Windows.Controls.VirtualizingPanel.ScrollUnit%2A> присваивается <xref:System.Windows.Controls.ScrollUnit.Pixel>, <xref:System.Windows.Controls.VirtualizingPanel> можно отобразить частично видимые элементы.  
  
2. Можно указать размер кэша до и после окна просмотра при <xref:System.Windows.Controls.VirtualizingPanel> с помощью <xref:System.Windows.Controls.VirtualizingPanel.CacheLength%2A> вложенного свойства зависимостей.  Кэш — это объем области, расположенной выше или ниже окна просмотра, элементы в котором не являются виртуальными.  Используя кэш, чтобы предотвратить создание элементов пользовательского интерфейса по мере их прокрутки, можно повысить производительность. Кэш заполняется с низким приоритетом, так что приложение не перестает отвечать на запросы во время этой операции. <xref:System.Windows.Controls.VirtualizingPanel.CacheLengthUnit%2A?displayProperty=nameWithType> Свойство определяет единицу измерения, которая используется <xref:System.Windows.Controls.VirtualizingPanel.CacheLength%2A?displayProperty=nameWithType>.  
  
<a name="static_properties"></a>   
## <a name="binding-to-static-properties"></a>Привязка к статическим свойствам  
 Статические свойства могут служить источником привязки данных. Когда возникает статическое событие, механизм привязки данных распознает изменение в значении подобного свойства.  Например, если класс `SomeClass` определяет статическое свойство с именем `MyProperty`, `SomeClass` может определять статическое событие, которое вызывается при изменении значения `MyProperty`.  Статическое событие может использовать одну из следующих сигнатур.  
  
-   `public static event EventHandler MyPropertyChanged;`  
  
-   `public static event EventHandler<PropertyChangedEventArgs> StaticPropertyChanged;`  
  
 Обратите внимание, что в первом случае класс предоставляет статическое событие с именем *PropertyName* `Changed` , прошедший <xref:System.EventArgs> обработчику событий.  Во втором случае класс предоставляет статическое событие с именем `StaticPropertyChanged` , прошедший <xref:System.ComponentModel.PropertyChangedEventArgs> обработчику событий. Класс, реализующий статическое свойство, может выдавать уведомления об изменениях в свойства, используя любой из этих методов.  
  
<a name="xthread_access"></a>   
## <a name="accessing-collections-on-non-ui-threads"></a>Доступ к коллекциям в потоках без пользовательского интерфейса  
 WPF позволяет получать доступ к коллекциям данных в потоках, отличных от потоков, создавших эти коллекции, и вносить в них изменения.  Это позволяет получать данные из внешнего источника, например базы данных, в фоновый поток и отображать данные в потоке пользовательского интерфейса.  Если для изменения коллекции используется другой поток, пользовательский интерфейс продолжает отвечать на команды пользователя.  
  
<a name="INotifyDataErrorInfo"></a>   
## <a name="synchronously-and-asynchronously-validating-data"></a>Синхронная и асинхронная проверка данных  
 <xref:System.ComponentModel.INotifyDataErrorInfo> Интерфейс позволяет классами сущностей данных реализовывать пользовательские правила проверки и предоставлять результаты проверки асинхронно. Этот интерфейс также поддерживает объекты специальных ошибок, нескольких ошибок для каждого свойства, ошибок нескольких свойств и ошибок на уровне сущности.  Дополнительные сведения см. в разделе <xref:System.ComponentModel.INotifyDataErrorInfo>.  
  
<a name="delay"></a>   
## <a name="automatically-updating-the-source-of-a-data-binding"></a>Автоматическое обновление источника привязки данных  
 Если вы используете привязку данных для обновления источника данных, можно использовать <xref:System.Windows.Data.BindingBase.Delay%2A> свойство, чтобы указать количество времени для передачи после изменения свойства на целевом объекте, прежде чем источник.  Например, предположим, что у вас есть <xref:System.Windows.Controls.Slider> с его <xref:System.Windows.Controls.Primitives.RangeBase.Value%2A> свойство двусторонней привязкой данных к свойству объекта данных и <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A> свойству <xref:System.Windows.Data.UpdateSourceTrigger.PropertyChanged>.  В этом примере, когда пользователь перемещает <xref:System.Windows.Controls.Slider>, обновления источника для каждого пикселя, <xref:System.Windows.Controls.Slider> перемещает.  Исходный объект обычно требуется значение ползунка только тогда, когда ползунка <xref:System.Windows.Controls.Primitives.RangeBase.Value%2A> перестает изменяться.  Чтобы предотвратить обновление источника слишком часто, используйте <xref:System.Windows.Data.BindingBase.Delay%2A> для указания, что источник не должны быть обновлены, до истечения отведенного времени после бегунок перестанет перемещаться.  
  
<a name="ICustomTypeProvider"></a>   
## <a name="binding-to-types-that-implement-icustomtypeprovider"></a>Привязки к типам, реализующим ICustomTypeProvider  
 WPF поддерживает привязку данных к объектам, реализующим <xref:System.Reflection.ICustomTypeProvider>, известной также как пользовательские типы.  Пользовательские типы можно использовать в следующих случаях:  
  
1. Как <xref:System.Windows.PropertyPath> в привязке данных. Например <xref:System.Windows.Data.Binding.Path%2A> свойство <xref:System.Windows.Data.Binding> может ссылаться на свойство пользовательского типа.  
  
2. Для параметра <xref:System.Windows.DataTemplate.DataType%2A> свойство.  
  
3. Как тип, определяющий автоматически создаваемые столбцы в <xref:System.Windows.Controls.DataGrid>.  
  
<a name="binding_state"></a>   
## <a name="retrieving-data-binding-information-from-a-binding-expression"></a>Получение сведений о привязке данных из выражения привязки  
 В некоторых случаях может появиться <xref:System.Windows.Data.BindingExpression> из <xref:System.Windows.Data.Binding> и нуждаетесь в сведениях об исходном и целевом объектах привязки.  Новые интерфейсы API позволят вам получить исходный и целевой объект или связанное свойство.  При наличии <xref:System.Windows.Data.BindingExpression>, используйте следующие интерфейсы API для получения сведений о целевом и исходном.  
  
|Чтобы найти это значение привязки|Используйте этот API|  
|---------------------------------------|------------------|  
|Целевой объект|<xref:System.Windows.Data.BindingExpressionBase.Target%2A?displayProperty=nameWithType>|  
|Целевое свойство|<xref:System.Windows.Data.BindingExpressionBase.TargetProperty%2A?displayProperty=nameWithType>|  
|Исходный объект|<xref:System.Windows.Data.BindingExpression.ResolvedSource%2A?displayProperty=nameWithType>|  
|Исходное свойство|<xref:System.Windows.Data.BindingExpression.ResolvedSourcePropertyName%2A?displayProperty=nameWithType>|  
|Ли <xref:System.Windows.Data.BindingExpression> принадлежит <xref:System.Windows.Data.BindingGroup>|<xref:System.Windows.Data.BindingExpressionBase.BindingGroup%2A?displayProperty=nameWithType>|  
|Владелец <xref:System.Windows.Data.BindingGroup>|<xref:System.Windows.Data.BindingGroup.Owner%2A>|  
  
<a name="DisconnectedSource"></a>   
## <a name="checking-for-a-valid-datacontext-object"></a>Проверка наличия допустимого объекта DataContext  
 Бывают случаи, где <xref:System.Windows.FrameworkElement.DataContext%2A> контейнера элемента в <xref:System.Windows.Controls.ItemsControl> будет отключен.  Контейнер элементов — это элемент пользовательского интерфейса, который отображает элемент в <xref:System.Windows.Controls.ItemsControl>.  Когда <xref:System.Windows.Controls.ItemsControl> — это данные, привязан к коллекции, для каждого элемента создается контейнер элементов. В некоторых случаях контейнеры элементов удаляются из визуального дерева. Два типичные случаи, в которой удаляется контейнер элементов: при удалении элемента из базовой коллекции, и когда виртуализация включена на <xref:System.Windows.Controls.ItemsControl>. В этих случаях <xref:System.Windows.FrameworkElement.DataContext%2A> контейнера элементов будет установлено сигнальный объект, возвращаемый <xref:System.Windows.Data.BindingOperations.DisconnectedSource%2A?displayProperty=nameWithType> статическое свойство.  Стоит ли <xref:System.Windows.FrameworkElement.DataContext%2A> равен <xref:System.Windows.Data.BindingOperations.DisconnectedSource%2A> объект перед доступом к <xref:System.Windows.FrameworkElement.DataContext%2A> контейнера элемента.  
  
<a name="live_shaping"></a>   
## <a name="repositioning-data-as-the-datas-values-change-live-shaping"></a>Изменение расположения данных по мере изменения их значений (формирование данных в реальном времени)  
 Коллекцию данных можно группировать, сортировать и фильтровать. WPF 4.5 позволяет изменять порядок данных при их изменении. Например, предположим, что приложение использует <xref:System.Windows.Controls.DataGrid> Чтобы получить список акций на фондовой биржи и акции сортируются по стоимости акции. Если сортировка в реальном времени с включенной акции <xref:System.Windows.Data.CollectionView>, положение акции в <xref:System.Windows.Controls.DataGrid> перемещения, когда значение акции становится больше или меньше, чем других акций.   Дополнительные сведения см. в разделе <xref:System.ComponentModel.ICollectionViewLiveShaping> интерфейс.  
  
<a name="weak_event_pattern"></a>   
## <a name="improved-support-for-establishing-a-weak-reference-to-an-event"></a>Улучшенная поддержка установления слабой ссылки на событие  
 Реализация шаблона слабых событий стала проще, поскольку подписчики на события теперь могут принимать в ней участие без реализации дополнительного интерфейса.  Универсальный <xref:System.Windows.WeakEventManager> класс также позволяет подписчикам участвовать в шаблоне слабых событий, если выделенный <xref:System.Windows.WeakEventManager> для определенного события не существует.  Дополнительные сведения см. в разделе [Шаблоны слабых событий](../advanced/weak-event-patterns.md).  
  
<a name="async"></a>   
## <a name="new-methods-for-the-dispatcher-class"></a>Новые методы для класса Dispatcher  
 Класс Dispatcher определяет новые методы для синхронных и асинхронных операций.  Синхронный <xref:System.Windows.Threading.Dispatcher.Invoke%2A> метод определяет перегрузки, принимающие <xref:System.Action> или <xref:System.Func%601> параметра. Новый асинхронный метод <xref:System.Windows.Threading.Dispatcher.InvokeAsync%2A>, также принимает <xref:System.Action> или <xref:System.Func%601> как параметр обратного вызова и она возвращает <xref:System.Windows.Threading.DispatcherOperation> или <xref:System.Windows.Threading.DispatcherOperation%601>.   <xref:System.Windows.Threading.DispatcherOperation> И <xref:System.Windows.Threading.DispatcherOperation%601> классы определяют <xref:System.Threading.Tasks.Task> свойство.  При вызове <xref:System.Windows.Threading.Dispatcher.InvokeAsync%2A>, можно использовать `await` ключевого слова with либо <xref:System.Windows.Threading.DispatcherOperation> или связанного <xref:System.Threading.Tasks.Task>. Если требуется синхронно дождаться <xref:System.Threading.Tasks.Task> , возвращаемый <xref:System.Windows.Threading.DispatcherOperation> или <xref:System.Windows.Threading.DispatcherOperation%601>, вызовите <xref:System.Windows.Threading.TaskExtensions.DispatcherOperationWait%2A> метода расширения. Вызов <xref:System.Threading.Tasks.Task.Wait%2A?displayProperty=nameWithType> будет привести к взаимоблокировке, если операция помещается в очередь в вызывающий поток. Дополнительные сведения об использовании <xref:System.Threading.Tasks.Task> для выполнения асинхронных операций, см. в разделе [параллелизм задач (библиотека параллельных задач)](../../../standard/parallel-programming/task-based-asynchronous-programming.md).  
  
<a name="events_markup_extenions"></a>   
## <a name="markup-extensions-for-events"></a>Расширения разметки для событий  
 WPF 4.5 поддерживает расширения разметки для событий.  Несмотря на то, что WPF не определяет расширение разметки для применения с событиями, третьи стороны могут создавать расширение разметки, которое можно использовать с событиями.  
  
## <a name="see-also"></a>См. также

- [Новые возможности .NET Framework](../../whats-new/index.md)

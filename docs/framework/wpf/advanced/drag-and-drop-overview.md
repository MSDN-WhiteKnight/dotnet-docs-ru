---
title: Общие сведения о перетаскивании
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- drag-and-drop [WPF], implementing
- drag sources [WPF], drag-and-drop
- data transfer [WPF], drag-and-drop
- drag-and-drop [WPF], about
- drag-and-drop [WPF], events
- drop targets [WPF], drag-and-drop
ms.assetid: 1a5b27b0-0ac5-4cdf-86c0-86ac0271fa64
ms.openlocfilehash: 2b76c8fd3e2c6961b6ebdddc9b7ff9649f5196f4
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59301403"
---
# <a name="drag-and-drop-overview"></a>Общие сведения о перетаскивании
В этой статье приведены общие сведения о поддержке перетаскивания в приложениях [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)]. Перетаскиванием обычно называют метод передачи данных, который реализуется с помощью мыши (или другого указывающего устройства) для выбора одного или нескольких объектов и перетаскивания их в цель перетаскивания в [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)].  

<a name="Drag_and_Drop_Support"></a>   
## <a name="drag-and-drop-support-in-wpf"></a>Поддержка перетаскивания в WPF  
 В операциях перетаскивания обычно участвуют две стороны: источник перетаскивания, из которого происходит перетаскиваемый объект, и цель перетаскивания, которая получает перетаскиваемый объект.  Источник перетаскивания и цель перетаскивания могут быть элементами пользовательского интерфейса в одном приложении или в разных приложениях.  
  
 Можно перетаскивать совершенно произвольные типы и количества объектов. Например, в качестве наиболее распространенных объектов перетаскивания можно назвать файлы, папки, выбранное содержимое.  
  
 Конкретные действия, выполняемые во время операции перетаскивания, зависят от приложения и часто определяются контекстом.  Например, при перетаскивании выбранных файлов из одной папки в другую на одном запоминающем устройстве эти файлы по умолчанию перемещаются, тогда как при перетаскивании файлов из общего ресурса [!INCLUDE[TLA#tla_unc](../../../../includes/tlasharptla-unc-md.md)] в локальную папку эти файлы по умолчанию копируются.  
  
 В средствах перетаскивания, предоставляемых [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], предусмотрена высокая гибкость и возможность настройки с целью поддержки различных сценариев перетаскивания.  Перетаскивание поддерживает управление объектами в рамках одного приложения или в разных приложениях. Перетаскивание мышью между [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] приложений и других приложений Windows также полностью поддерживается.  
  
 В [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] любые элементы <xref:System.Windows.UIElement> или <xref:System.Windows.ContentElement> могут участвовать в операциях перетаскивания. События и методы, необходимые для операций перетаскивания, определяются в классе <xref:System.Windows.DragDrop>. Классы <xref:System.Windows.UIElement> и <xref:System.Windows.ContentElement> содержат псевдонимы для вложенных событий <xref:System.Windows.DragDrop>, чтобы эти события отображались в списке членов класса, когда <xref:System.Windows.UIElement> или <xref:System.Windows.ContentElement> наследуется как базовый элемент. Обработчики событий, связанные с этими событиями, присоединяются к основному вложенному событию <xref:System.Windows.DragDrop> и получают один и тот же экземпляр данных события. Дополнительные сведения см. в описании события <xref:System.Windows.UIElement.Drop?displayProperty=nameWithType>.  
  
> [!IMPORTANT]
>  Перетаскивание OLE не работает в зоне Интернета.  
  
<a name="Data_Transfer"></a>   
## <a name="data-transfer"></a>Передача данных  
 Перетаскивание является частью более общей сферы передачи данных. Передача данных включает операции перетаскивания и операции копирования и вставки. Операция перетаскивания аналогична операции копирования и вставки или вырезания и вставки, которая используется для передачи данных из одного объекта или приложения в другое с использованием буфера обмена. В обоих типах операций требуется:  
  
-   исходный объект, предоставляющий данные;  
  
-   способ временного хранения передаваемых данных;  
  
-   целевой объект, который получает данные.  
  
 В операции копирования и вставки для временного хранения передаваемых данных используется системный буфер обмена; в операции перетаскивания для хранения данных используется <xref:System.Windows.DataObject>. Концептуально объект данных состоит из одной или нескольких пар <xref:System.Object>, содержащих фактические данные и соответствующий идентификатор формата данных.  
  
 Источник перетаскивания инициирует операцию перетаскивания путем вызова статического метода <xref:System.Windows.DragDrop.DoDragDrop%2A?displayProperty=nameWithType> и передачи в него передаваемых данных. Метод <xref:System.Windows.DragDrop.DoDragDrop%2A> будет автоматически включать данные в <xref:System.Windows.DataObject> при необходимости. Для большего контроля над форматом данных можно включать данные в <xref:System.Windows.DataObject> перед их передачей в метод <xref:System.Windows.DragDrop.DoDragDrop%2A>. Цель перетаскивания отвечает за извлечение данных из <xref:System.Windows.DataObject>. Дополнительные сведения о работе с объектами данных см. в разделе [Данные и объекты данных](data-and-data-objects.md).  
  
 Исходный и целевой объекты операции перетаскивания являются элементами пользовательского интерфейса; однако данные, которые в действительности передаются, обычно не имеют визуального представления. Вы можете написать код для визуального представления перетаскиваемых данных, например такого, которое происходит при перетаскивании файлов в проводнике. По умолчанию взаимодействие предоставляется пользователю путем изменения курсора для представления воздействия, которое операция перетаскивания оказывает на данные: например, перемещаются данные или копируются.  
  
### <a name="drag-and-drop-effects"></a>Эффекты перетаскивания  
 Операции перетаскивания могут по-разному воздействовать на передаваемые данные. Например, данные могут копироваться или перемещаться. [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] Определяет <xref:System.Windows.DragDropEffects> перечисления, которое можно использовать для указания эффекта операции перетаскивания и вставки. В источнике перетаскивания можно указать эффекты, которые он разрешает, в методе <xref:System.Windows.DragDrop.DoDragDrop%2A>. В цели перетаскивания можно определить ожидаемый эффект в свойстве <xref:System.Windows.DragEventArgs.Effects%2A> класса <xref:System.Windows.DragEventArgs>. Если в цели перетаскивания ожидаемый эффект задан в событии <xref:System.Windows.DragDrop.DragOver>, то информация передается обратно в источник перетаскивания в событии <xref:System.Windows.DragDrop.GiveFeedback>. Источник перетаскивания использует эти сведения для информирования пользователей, какое воздействие на данные ожидает цель перетаскивания. Когда данные вставляются, цель перетаскивания указывает фактический эффект в событии <xref:System.Windows.DragDrop.Drop>. Эти сведения передаются обратно в источник перетаскивания в качестве возвращаемого значения метода <xref:System.Windows.DragDrop.DoDragDrop%2A>. Если цель перетаскивания возвращает эффект, которого нет в списке `allowedEffects` источников перетаскивания, операция перетаскивания отменяется без фактической передачи данных.  
  
 Важно помнить, что в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] значения <xref:System.Windows.DragDropEffects> используются только для обеспечения взаимодействия между источником перетаскивания и целью перетаскивания относительно эффектов операции перетаскивания. Фактический эффект операции перетаскивания зависит от соответствующего кода, написанного вами в приложении.  
  
 Например, цель перетаскивания может указывать, что в результате перетаскивания в него данных должно происходить перемещение данных. Однако для перемещения данных они должны добавляться в целевой элемент и удаляться из исходного элемента. Исходный элемент может указывать, что он разрешает перемещение данных, но если вы не предоставите код для удаления данных из исходного элемента, данные в итоге будут копироваться, а не перемещаться.  
  
<a name="Drag_and_Drop_Events"></a>   
## <a name="drag-and-drop-events"></a>События перетаскивания  
 Операции перетаскивания поддерживают модель управления событиями.  Источник и цель перетаскивания используют стандартный набор событий для обработки операций перетаскивания.  В следующих таблицах приведены стандартные события перетаскивания. Это вложенные события в классе <xref:System.Windows.DragDrop>. Дополнительные сведения о вложенных событиях см. в разделе [Общие сведения о вложенных событиях](attached-events-overview.md).  
  
### <a name="drag-source-events"></a>События источника перетаскивания  
  
|событие|Сводка|  
|-----------|-------------|  
|<xref:System.Windows.DragDrop.GiveFeedback>|Это событие возникает постоянно во время операции перетаскивания и позволяет источнику перетаскивания предоставлять пользователю сведения о взаимодействии. Взаимодействие обычно демонстрируется путем изменения вида курсора мыши, чтобы указать разрешенные целью перетаскивания эффекты операции перетаскивания.  Это событие восходящей маршрутизации.|  
|<xref:System.Windows.DragDrop.QueryContinueDrag>|Это событие возникает при изменении состояния клавиши клавиатуры или кнопки мыши во время операции перетаскивания и позволяет источнику перетаскивания отменить операцию перетаскивания в зависимости от состояния клавиши или кнопки. Это событие восходящей маршрутизации.|  
|<xref:System.Windows.DragDrop.PreviewGiveFeedback>|Это версия нисходящей маршрутизации события <xref:System.Windows.DragDrop.GiveFeedback>.|  
|<xref:System.Windows.DragDrop.PreviewQueryContinueDrag>|Это версия нисходящей маршрутизации события <xref:System.Windows.DragDrop.QueryContinueDrag>.|  
  
### <a name="drop-target-events"></a>События цели перетаскивания  
  
|событие|Сводка|  
|-----------|-------------|  
|<xref:System.Windows.DragDrop.DragEnter>|Это событие происходит, когда объект перетаскивается в границы цели перетаскивания. Это событие восходящей маршрутизации.|  
|<xref:System.Windows.DragDrop.DragLeave>|Это событие происходит, когда объект перетаскивается за пределы цели перетаскивания.  Это событие восходящей маршрутизации.|  
|<xref:System.Windows.DragDrop.DragOver>|Это событие происходит постоянно, когда объект перетаскивается (перемещается) в границы цели перетаскивания. Это событие восходящей маршрутизации.|  
|<xref:System.Windows.DragDrop.Drop>|Это событие происходит, когда объект вставляется в цель перетаскивания.  Это событие восходящей маршрутизации.|  
|<xref:System.Windows.DragDrop.PreviewDragEnter>|Это версия нисходящей маршрутизации события <xref:System.Windows.DragDrop.DragEnter>.|  
|<xref:System.Windows.DragDrop.PreviewDragLeave>|Это версия нисходящей маршрутизации события <xref:System.Windows.DragDrop.DragLeave>.|  
|<xref:System.Windows.DragDrop.PreviewDragOver>|Это версия нисходящей маршрутизации события <xref:System.Windows.DragDrop.DragOver>.|  
|<xref:System.Windows.DragDrop.PreviewDrop>|Это версия нисходящей маршрутизации события <xref:System.Windows.DragDrop.Drop>.|  
  
 Для обработки событий перетаскивания для экземпляров объекта добавьте обработчики событий, перечисленных в таблицах выше. Для обработки событий перетаскивания на уровне класса переопределите соответствующие виртуальные методы On*Event и On\*PreviewEvent. Дополнительные сведения см. в разделе [Маркировка перенаправленных событий как обработанных и обработка классов](marking-routed-events-as-handled-and-class-handling.md#Class_Handling_of_Routed_Events).  
  
<a name="Implementing_Drag_And_Drop"></a>   
## <a name="implementing-drag-and-drop"></a>Реализация перетаскивания  
 Элемент пользовательского интерфейса может быть источником перетаскивания, целью перетаскивания или и тем, и другим. Чтобы реализовать базовое перетаскивание, необходимо написать код для инициирования операции перетаскивания и обработки перетаскиваемых данных. Вы можете улучшить взаимодействие перетаскивания путем обработки дополнительных событий перетаскивания.  
  
 Для реализации базового перетаскивания вы будете выполнять следующие задачи.  
  
-   Определение элемента, который будет источником перетаскивания. Источник перетаскивания может быть <xref:System.Windows.UIElement> или <xref:System.Windows.ContentElement>.  
  
-   Создание обработчика событий в источнике перетаскивания, который будет инициировать операцию перетаскивания. Это событие обычно является событием <xref:System.Windows.UIElement.MouseMove>.  
  
-   Вызов метода <xref:System.Windows.DragDrop.DoDragDrop%2A> в обработчике событий источника перетаскивания для инициации операции перетаскивания. Указание источника перетаскивания, передаваемых данных и разрешенные эффекты в вызове метода <xref:System.Windows.DragDrop.DoDragDrop%2A>.  
  
-   Определение элемента, который будет целью перетаскивания. Целью перетаскивания может быть <xref:System.Windows.UIElement> или <xref:System.Windows.ContentElement>.  
  
-   В цели перетаскивания установите свойство <xref:System.Windows.UIElement.AllowDrop%2A> в значение `true`.  
  
-   В цели перетаскивания создайте обработчик событий <xref:System.Windows.DragDrop.Drop> для обработки перетаскиваемых данных.  
  
-   В обработчике событий <xref:System.Windows.DragDrop.Drop> извлеките данные из <xref:System.Windows.DragEventArgs> с помощью методов <xref:System.Windows.DataObject.GetDataPresent%2A> и <xref:System.Windows.DataObject.GetData%2A>.  
  
-   В обработчике событий <xref:System.Windows.DragDrop.Drop> используйте эти данные для выполнения требуемой операции перетаскивания.  
  
 Вы можете улучшить реализацию перетаскивания путем создания пользовательского объекта <xref:System.Windows.DataObject> и обработки дополнительных событий источника и цели перетаскивания, как показано в следующих задачах.  
  
-   Чтобы передать пользовательские данные или несколько элементов данных, создайте объект <xref:System.Windows.DataObject> для передачи в метод <xref:System.Windows.DragDrop.DoDragDrop%2A>.  
  
-   Для выполнения дополнительных действий в процессе перетаскивания обработайте события <xref:System.Windows.DragDrop.DragEnter>, <xref:System.Windows.DragDrop.DragOver> и <xref:System.Windows.DragDrop.DragLeave> в цели перетаскивания.  
  
-   Чтобы изменить вид курсора мыши, обработайте событие <xref:System.Windows.DragDrop.GiveFeedback> в источнике перетаскивания.  
  
-   Для изменения способа отмены операции перетаскивания обработайте событие <xref:System.Windows.DragDrop.QueryContinueDrag> в источнике перетаскивания.  
  
<a name="Drag_And_Drop_Example"></a>   
## <a name="drag-and-drop-example"></a>Пример перетаскивания  
 В этом разделе описывается реализация перетаскивания для элемента <xref:System.Windows.Shapes.Ellipse>. Элемент <xref:System.Windows.Shapes.Ellipse> является как источником, так и целью перетаскивания. Передаваемые данные — это строковое представление свойства <xref:System.Windows.Shapes.Shape.Fill%2A> эллипса. В следующем XAML показан элемент <xref:System.Windows.Shapes.Ellipse> и связанные с перетаскиванием события, которые он обрабатывает. Полное описание действий по реализации перетаскивания и вставки, см. в разделе [Пошаговое руководство: Включение перетаскивания для пользовательского элемента управления](walkthrough-enabling-drag-and-drop-on-a-user-control.md).  
  
 [!code-xaml[DragDropSnippets#EllipseXaml](~/samples/snippets/csharp/VS_Snippets_Wpf/dragdropsnippets/cs/mainwindow.xaml#ellipsexaml)]  
  
### <a name="enabling-an-element-to-be-a-drag-source"></a>Включение элемента в качестве источника перетаскивания  
 Объект, являющийся источником перетаскивания, отвечает за:  
  
-   определение момента начала перетаскивания;  
  
-   инициализацию операции перетаскивания;  
  
-   определение передаваемых данных;  
  
-   указание разрешенного воздействия операции перетаскивания на передаваемые данные.  
  
 Источник перетаскивания может также предоставить пользователю сведения о разрешенных действиях (перемещение, копирование или отсутствие действий) и может отменять операцию перетаскивания на основании дополнительного пользовательского ввода, например нажатия клавиши ESC во время перетаскивания.  
  
 Ваше приложение должно определить, когда происходит перетаскивание, а затем инициировать операцию перетаскивания путем вызова метода <xref:System.Windows.DragDrop.DoDragDrop%2A>. Обычно это происходит, когда возникает событие <xref:System.Windows.UIElement.MouseMove> в перетаскиваемом элементе при нажатой клавише мыши. В следующем примере показано, как инициировать операцию перетаскивания в обработчике событий <xref:System.Windows.UIElement.MouseMove> элемента <xref:System.Windows.Shapes.Ellipse>, чтобы сделать его источником перетаскивания. Передаваемые данные — это строковое представление свойства <xref:System.Windows.Shapes.Shape.Fill%2A> эллипса.  
  
 [!code-csharp[DragDropSnippets#DoDragDrop](~/samples/snippets/csharp/VS_Snippets_Wpf/dragdropsnippets/cs/mainwindow.xaml.cs#dodragdrop)]
 [!code-vb[DragDropSnippets#DoDragDrop](~/samples/snippets/visualbasic/VS_Snippets_Wpf/dragdropsnippets/vb/mainwindow.xaml.vb#dodragdrop)]  
  
 В обработчике событий <xref:System.Windows.UIElement.MouseMove> вызовите метод <xref:System.Windows.DragDrop.DoDragDrop%2A> для инициации операции перетаскивания. Метод <xref:System.Windows.DragDrop.DoDragDrop%2A> принимает три следующих параметра.  
  
-   `dragSource` — Ссылка на объект зависимости, который является источником передаваемых данных; Обычно это источник <xref:System.Windows.UIElement.MouseMove> событий.  
  
-   `data` -Объект, содержащий передаваемые данные, заключенные в <xref:System.Windows.DataObject>.  
  
-   `allowedEffects` — Одно из <xref:System.Windows.DragDropEffects> значений перечисления, которое определяет разрешенные эффекты операции перетаскивания и вставки.  
  
 В параметр `data` может быть передан любой сериализуемый объект. Если данные еще не заключены в объект <xref:System.Windows.DataObject>, они автоматически заключаются в новый объект <xref:System.Windows.DataObject>. Для передачи нескольких элементов данных вы должны создать объект <xref:System.Windows.DataObject> самостоятельно и передать его в метод <xref:System.Windows.DragDrop.DoDragDrop%2A>. Дополнительные сведения см. в разделе [Данные и объекты данных](data-and-data-objects.md).  
  
 Параметр `allowedEffects` используется для указания, какие действия с передаваемыми данными источник перетаскивания будет разрешать цели перетаскивания. Обычные значения для источника перетаскивания — <xref:System.Windows.DragDropEffects.Copy>, <xref:System.Windows.DragDropEffects.Move> и <xref:System.Windows.DragDropEffects.All>.  
  
> [!NOTE]
>  Цель перетаскивания также может указывать ожидаемые эффекты перетаскивания данных. Например, если цель перетаскивания не распознает тип вставляемых данных, то она может отклонить эти данные, задав <xref:System.Windows.DragDropEffects.None> в качестве разрешенных эффектов. Обычно она делает это в своем обработчике событий <xref:System.Windows.DragDrop.DragOver>.  
  
 Источник перетаскивания может также обрабатывать события <xref:System.Windows.DragDrop.GiveFeedback> и <xref:System.Windows.DragDrop.QueryContinueDrag>. Эти события имеют обработчики по умолчанию, которые используются, если события не помечены как обработанные. Обычно эти события игнорируются, если нет особой необходимости изменения их поведения по умолчанию.  
  
 Событие <xref:System.Windows.DragDrop.GiveFeedback> возникает постоянно, пока выполняется перетаскивание источника перетаскивания. Обработчик по умолчанию для этого события проверяет, находится ли источник перетаскивания над допустимым конечным расположением сброса. Если это так, то он проверяет разрешенные эффекты цели перетаскивания. Затем он предоставляет конечному пользователю отзыв относительно разрешенных эффектов перетаскивания. Обычно это выполняется путем изменения курсора мыши, чтобы указать запрет перетаскивания, копирование или перемещение. Это событие следует обрабатывать, только если необходимо использовать пользовательские курсоры для предоставления отзыва пользователю. Если вы обрабатываете это событие, не забудьте помечать его как обработанное, чтобы обработчик по умолчанию не переопределил ваш обработчик.  
  
 Событие <xref:System.Windows.DragDrop.QueryContinueDrag> возникает постоянно, пока выполняется перетаскивание источника перетаскивания. Можно обработать это событие, чтобы определить, какое действие завершает операцию перетаскивания, на основе состояния клавиш ESC, SHIFT, CTRL и ALT, а также состояния кнопок мыши. Обработчик по умолчанию для этого события отменяет операцию перетаскивания при нажатии клавиши ESC и сбрасывает данные при отпускании кнопки мыши.  
  
> [!CAUTION]
>  Эти события возникают постоянно во время операции перетаскивания. Поэтому следует избегать ресурсоемких задач в обработчиках событий.  Например, используйте кэшированный курсор вместо создания нового курсора при каждом возникновении события <xref:System.Windows.DragDrop.GiveFeedback>.  
  
### <a name="enabling-an-element-to-be-a-drop-target"></a>Включение элемента в качестве цели перетаскивания  
 Объект, являющийся целью перетаскивания, отвечает за:  
  
-   указание, что он является допустимой целью перетаскивания;  
  
-   реакцию на источник перетаскивания, когда он перетаскивается над целевым объектом;  
  
-   проверку, что передаваемые данные находятся в формате, который он может получить;  
  
-   обработку вставляемых данных.  
  
 Чтобы указать, что элемент является целью перетаскивания, его свойство <xref:System.Windows.UIElement.AllowDrop%2A> устанавливается в значение `true`. Затем в этом элементе будут возникать события цели перетаскивания, чтобы их можно было обработать. Во время операции перетаскивания в цели перетаскивания возникает следующая последовательность событий:  
  
1. <xref:System.Windows.DragDrop.DragEnter>  
  
2. <xref:System.Windows.DragDrop.DragOver>  
  
3. <xref:System.Windows.DragDrop.DragLeave> или <xref:System.Windows.DragDrop.Drop>  
  
 Событие <xref:System.Windows.DragDrop.DragEnter> возникает, когда данные перетаскиваются в границы цели перетаскивания. Обычно вы обрабатываете это событие, чтобы обеспечить предварительный просмотр эффектов операции перетаскивания, если это требуется для вашего приложения. Не устанавливайте свойство <xref:System.Windows.DragEventArgs.Effects%2A?displayProperty=nameWithType> в событии <xref:System.Windows.DragDrop.DragEnter>, так как оно будет переопределено в событии <xref:System.Windows.DragDrop.DragOver>.  
  
 В следующем примере показан обработчик событий <xref:System.Windows.DragDrop.DragEnter> для элемента <xref:System.Windows.Shapes.Ellipse>. Этот код выполняет предварительный просмотр эффектов операции перетаскивания путем сохранения текущей кисти <xref:System.Windows.Shapes.Shape.Fill%2A>. Затем он использует метод <xref:System.Windows.DataObject.GetDataPresent%2A> для проверки, содержит ли объект <xref:System.Windows.DataObject>, перетаскиваемый над эллипсом, строковые данные, которые можно преобразовать в <xref:System.Windows.Media.Brush>. Если да, то данные извлекаются с помощью метода <xref:System.Windows.DataObject.GetData%2A> Затем они преобразуются в <xref:System.Windows.Media.Brush> и применяются к эллипсу. Это изменение отменяется в обработчике событий <xref:System.Windows.DragDrop.DragLeave>. Если данные невозможно преобразовать в <xref:System.Windows.Media.Brush>, никакие действия не выполняются.  
  
 [!code-csharp[DragDropSnippets#DragEnter](~/samples/snippets/csharp/VS_Snippets_Wpf/dragdropsnippets/cs/mainwindow.xaml.cs#dragenter)]
 [!code-vb[DragDropSnippets#DragEnter](~/samples/snippets/visualbasic/VS_Snippets_Wpf/dragdropsnippets/vb/mainwindow.xaml.vb#dragenter)]  
  
 Событие <xref:System.Windows.DragDrop.DragOver> постоянно возникает при перетаскивании данных на цель перетаскивания. Это событие является спаренным с событием <xref:System.Windows.DragDrop.GiveFeedback> в источнике перетаскивания. В обработчике событий <xref:System.Windows.DragDrop.DragOver>, как правило, используются методы <xref:System.Windows.DataObject.GetDataPresent%2A> и <xref:System.Windows.DataObject.GetData%2A> для проверки, имеют ли передаваемые данные формат, который может обработать цель перетаскивания. Можно также проверить, нажаты ли клавиши-модификаторы, которые обычно указывают, какую операцию предполагает выполнять пользователь — перемещения или копирования. После выполнения этих проверок вы устанавливаете свойство <xref:System.Windows.DragEventArgs.Effects%2A?displayProperty=nameWithType>, чтобы уведомить источник перетаскивания о том, какой эффект окажет сброс данных. Источник перетаскивания получает эти сведения в аргументах события <xref:System.Windows.DragDrop.GiveFeedback> и может задать соответствующий курсор, чтобы обеспечить отзыв для пользователя.  
  
 В следующем примере показан обработчик событий <xref:System.Windows.DragDrop.DragOver> для элемента <xref:System.Windows.Shapes.Ellipse>. В этом коде проверяется, содержит ли объект <xref:System.Windows.DataObject>, перетаскиваемый над эллипсом, строковые данные, которые можно преобразовать в <xref:System.Windows.Media.Brush>. Если содержит, то код устанавливает для свойства <xref:System.Windows.DragEventArgs.Effects%2A?displayProperty=nameWithType> значение <xref:System.Windows.DragDropEffects.Copy>. Это указывает источнику перетаскивания, что данные можно скопировать в эллипс. Если данные невозможно преобразовать в <xref:System.Windows.Media.Brush>, для свойства <xref:System.Windows.DragEventArgs.Effects%2A?displayProperty=nameWithType> устанавливается значение <xref:System.Windows.DragDropEffects.None>. Это указывает источнику перетаскивания, что эллипс не является допустимым конечным расположением сброса для данных.  
  
 [!code-csharp[DragDropSnippets#DragOver](~/samples/snippets/csharp/VS_Snippets_Wpf/dragdropsnippets/cs/mainwindow.xaml.cs#dragover)]
 [!code-vb[DragDropSnippets#DragOver](~/samples/snippets/visualbasic/VS_Snippets_Wpf/dragdropsnippets/vb/mainwindow.xaml.vb#dragover)]  
  
 Событие <xref:System.Windows.DragDrop.DragLeave> возникает, когда данные перетаскиваются за границу целевого объекта без сбрасывания. Обработка этого события позволяет отменить любые действия, которые были выполнены в обработчике событий <xref:System.Windows.DragDrop.DragEnter>.  
  
 В следующем примере показан обработчик событий <xref:System.Windows.DragDrop.DragLeave> для элемента <xref:System.Windows.Shapes.Ellipse>. Этот код отменяет предварительный просмотр, выполненный в обработчике событий <xref:System.Windows.DragDrop.DragEnter>, путем применения сохраненного объекта <xref:System.Windows.Media.Brush> к эллипсу.  
  
 [!code-csharp[DragDropSnippets#DragLeave](~/samples/snippets/csharp/VS_Snippets_Wpf/dragdropsnippets/cs/mainwindow.xaml.cs#dragleave)]
 [!code-vb[DragDropSnippets#DragLeave](~/samples/snippets/visualbasic/VS_Snippets_Wpf/dragdropsnippets/vb/mainwindow.xaml.vb#dragleave)]  
  
 Событие <xref:System.Windows.DragDrop.Drop> возникает при сбросе данных в цель перетаскивания; по умолчанию это происходит при отпускании кнопки мыши. В обработчике событий <xref:System.Windows.DragDrop.Drop> вы используете метод <xref:System.Windows.DataObject.GetData%2A> для извлечения передаваемых данных из объекта <xref:System.Windows.DataObject> и выполнения обработки данных, необходимой для вашего приложения. Событие <xref:System.Windows.DragDrop.Drop> завершает операцию перетаскивания.  
  
 В следующем примере показан обработчик событий <xref:System.Windows.DragDrop.Drop> для элемента <xref:System.Windows.Shapes.Ellipse>. Этот код применяет эффекты операции перетаскивания. Он аналогичен коду в обработчике событий <xref:System.Windows.DragDrop.DragEnter>. Он проверяет, содержит ли объект <xref:System.Windows.DataObject>, перетаскиваемый над эллипсом, строковые данные, которые можно преобразовать в <xref:System.Windows.Media.Brush>. Если это так, то к эллипсу применяется объект <xref:System.Windows.Media.Brush>. Если данные невозможно преобразовать в <xref:System.Windows.Media.Brush>, никакие действия не выполняются.  
  
 [!code-csharp[DragDropSnippets#Drop](~/samples/snippets/csharp/VS_Snippets_Wpf/dragdropsnippets/cs/mainwindow.xaml.cs#drop)]
 [!code-vb[DragDropSnippets#Drop](~/samples/snippets/visualbasic/VS_Snippets_Wpf/dragdropsnippets/vb/mainwindow.xaml.vb#drop)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Clipboard>
- [Пошаговое руководство. Включение перетаскивания для пользовательского элемента управления](walkthrough-enabling-drag-and-drop-on-a-user-control.md)
- [Практические руководства](drag-and-drop-how-to-topics.md)
- [Перетаскивание](drag-and-drop.md)

---
title: 'Оптимизация производительности: Поведение объекта'
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- user interface virtualization [WPF]
- dependency properties [WPF], performance
- event handlers [WPF]
- object performance considerations [WPF]
- Freezable objects [WPF], performance
ms.assetid: 73aa2f47-1d73-439a-be1f-78dc4ba2b5bd
ms.openlocfilehash: 49318059435c5f5669510f7cf3fb7c93a4bc05e1
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59137440"
---
# <a name="optimizing-performance-object-behavior"></a>Оптимизация производительности: Поведение объекта
Понимание внутреннего поведения объектов [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] поможет найти оптимальное сочетание функциональных возможностей и производительности.  

<a name="Not_Removing_Event_Handlers"></a>   
## <a name="not-removing-event-handlers-on-objects-may-keep-objects-alive"></a>Не удаление обработчиков событий для объектов может поддерживать объекты в активном состоянии  
 Делегат, который объект передает в свое событие, фактически является ссылкой на этот объект. Таким образом, обработчики событий могут поддерживать объекты в активном состоянии дольше, чем планировалось. При выполнении очистки объекта, зарегистрированного для прослушивания события объекта, необходимо удалить этот делегат перед освобождением объекта. Сохранение ненужных объектов в активном состоянии увеличивает потребление памяти. Это особенно важно в тех случаях, когда объект является корневым элементом логического дерева или визуального дерева.  
  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] предоставляет шаблон прослушивателя слабых событий для событий, которые могут быть полезны в ситуациях, когда трудно отслеживать отношения между источником и прослушивателем во время существования объекта. Некоторые существующие события [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] используют этот шаблон. При реализации объектов с пользовательскими событиями этот шаблон может вам пригодиться. Дополнительные сведения см. в разделе [Шаблоны слабых событий](weak-event-patterns.md).  
  
 Существует несколько инструментов, таких как профилировщик CLR и Working Set Viewer, которые могут предоставлять сведения об использовании памяти указанным процессом. Профилировщик CLR включает ряд очень полезных представлений профиля выделения, включая гистограмму выделенных типов, диаграммы выделения и вызова, временную шкалу, показывающую сборку мусора разных поколений и итоговое состояние управляемой кучи после этих сборок, а также дерево вызовов, показывающее распределения по методам и загрузки сборок. Дополнительные сведения см. в разделе [Центр разработчиков .NET Framework](https://go.microsoft.com/fwlink/?LinkId=117435).  
  
<a name="DPs_and_Objects"></a>   
## <a name="dependency-properties-and-objects"></a>Свойства и объекты зависимостей  
 Как правило, доступ к свойству зависимостей из <xref:System.Windows.DependencyObject> не медленнее, чем [!INCLUDE[TLA2#tla_clr](../../../../includes/tla2sharptla-clr-md.md)] свойство. Хотя существуют небольшие издержки производительности при задании значения свойства, получение значения происходит так же быстро, как получение значения из свойства [!INCLUDE[TLA2#tla_clr](../../../../includes/tla2sharptla-clr-md.md)]. Издержки производительности компенсируются за счет того, что свойства зависимостей поддерживают надежные функции, такие как привязка данных, анимация, наследование и задание стилей. Дополнительные сведения см. в [обзоре свойств зависимостей](dependency-properties-overview.md).  
  
### <a name="dependencyproperty-optimizations"></a>Оптимизация DependencyProperty  
 Свойства зависимостей в приложении следует определять очень внимательно. Если ваш <xref:System.Windows.DependencyProperty> например затрагивает только отображение параметров метаданных типа, а не другие параметры метаданных <xref:System.Windows.FrameworkPropertyMetadata.AffectsMeasure%2A>, следует пометить его как таковое путем переопределения его метаданных. Дополнительные сведения о переопределении и получении метаданных свойства см. в разделе [Метаданные свойств зависимостей](dependency-property-metadata.md).  
  
 Возможно, более рационально использовать обработчик изменений свойств, чтобы аннулировать передачу размера, упорядочения и отображения вручную, если не все изменения свойств фактически влияют на размер, упорядочение и отображение. Например, вы можете решить заново отображать фон, только когда значение выше установленного ограничения. В этом случае обработчик изменений свойств будет аннулировать отображение, только когда значение превышает установленное ограничение.  
  
### <a name="making-a-dependencyproperty-inheritable-is-not-free"></a>Наследуемость DependencyProperty не обходится даром  
 По умолчанию зарегистрированные свойства зависимостей не являются наследуемыми. Тем не менее вы можете явно сделать любое свойство наследуемым. Хотя это полезная возможность, преобразование свойства в наследуемое негативно влияет на производительность, увеличивая интервал времени для аннулирования свойства.  
  
### <a name="use-registerclasshandler-carefully"></a>Используйте RegisterClassHandler с осторожностью  
 Во время вызова методов <xref:System.Windows.EventManager.RegisterClassHandler%2A> позволяет сохранить состояние экземпляра, важно Имейте в виду, что обработчик вызывается в каждом экземпляре, что может вызвать проблемы производительности. Использовать только <xref:System.Windows.EventManager.RegisterClassHandler%2A> Если вашему приложению требуется сохранять состояние экземпляра.  
  
### <a name="set-the-default-value-for-a-dependencyproperty-during-registration"></a>Установка значения по умолчанию для DependencyProperty во время регистрации  
 При создании <xref:System.Windows.DependencyProperty> , должен иметь значение по умолчанию, задайте значение с помощью метаданных по умолчанию, передаваемый в качестве параметра для <xref:System.Windows.DependencyProperty.Register%2A> метод <xref:System.Windows.DependencyProperty>. Рекомендуется использовать именно этот метод вместо настройки значения свойства в конструкторе или в каждом экземпляре элемента.  
  
### <a name="set-the-propertymetadata-value-using-register"></a>Установка значения PropertyMetadata с помощью реестра  
 При создании <xref:System.Windows.DependencyProperty>, у вас есть возможность задания <xref:System.Windows.PropertyMetadata> одним <xref:System.Windows.DependencyProperty.Register%2A> или <xref:System.Windows.DependencyProperty.OverrideMetadata%2A> методы. Несмотря на то, что объект может иметь статический конструктор для вызова <xref:System.Windows.DependencyProperty.OverrideMetadata%2A>, это не является оптимальным решением и повлияет на производительность. Для наилучшей производительности значение <xref:System.Windows.PropertyMetadata> во время вызова <xref:System.Windows.DependencyProperty.Register%2A>.  
  
<a name="Freezable_Objects"></a>   
## <a name="freezable-objects"></a>Объекты Freezable  
 Объект <xref:System.Windows.Freezable> — это специальный тип объекта, имеющий два состояния: фиксированное и нефиксированное. Фиксация объектов везде, где это возможно, улучшает производительность приложения и уменьшает его рабочий набор. Дополнительные сведения см. в разделе [Общие сведения об объектах класса Freezable](freezable-objects-overview.md).  
  
 Каждый <xref:System.Windows.Freezable> имеет <xref:System.Windows.Freezable.Changed> событие, возникающее при каждом его изменении. Однако уведомления об изменениях обходятся дорого с точки зрения производительности приложения.  
  
 Рассмотрим следующий пример, в котором каждый <xref:System.Windows.Shapes.Rectangle> использует тот же <xref:System.Windows.Media.Brush> объекта:  
  
 [!code-csharp[Performance#PerformanceSnippet2](~/samples/snippets/csharp/VS_Snippets_Wpf/Performance/CSharp/Window1.xaml.cs#performancesnippet2)]
 [!code-vb[Performance#PerformanceSnippet2](~/samples/snippets/visualbasic/VS_Snippets_Wpf/Performance/visualbasic/window1.xaml.vb#performancesnippet2)]  
  
 По умолчанию [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] предоставляет обработчик событий для <xref:System.Windows.Media.SolidColorBrush> объекта <xref:System.Windows.Freezable.Changed> событий, чтобы сделать недействительным <xref:System.Windows.Shapes.Rectangle> объекта <xref:System.Windows.Shapes.Shape.Fill%2A> свойство. В этом случае каждый раз, когда <xref:System.Windows.Media.SolidColorBrush> приходится запускать его <xref:System.Windows.Freezable.Changed> событий, необходимо вызывать функцию обратного вызова для каждого <xref:System.Windows.Shapes.Rectangle>— совокупность этих вызовов функции обратного вызова накладывают к значительному снижению производительности. Кроме того, довольно затратно с точки зрения производительности добавлять и удалять обработчики на этом этапе, так как приложению потребуется пройти по всему списку, чтобы сделать это. Если сценарий приложения никогда не меняется <xref:System.Windows.Media.SolidColorBrush>, вы будете нести затраты на поддержку <xref:System.Windows.Freezable.Changed> обработчики событий без необходимости.  
  
 Замораживание <xref:System.Windows.Freezable> позволяет повысить его производительность, поскольку он больше не требуется тратить ресурсы на уведомления об изменениях. В следующей таблице показан размер простого объекта <xref:System.Windows.Media.SolidColorBrush> при его <xref:System.Windows.Freezable.IsFrozen%2A> свойству `true`, если он недопустим по сравнению с. Это предполагает применение одной кисти к <xref:System.Windows.Shapes.Shape.Fill%2A> свойство десяти <xref:System.Windows.Shapes.Rectangle> объектов.  
  
|**Регион**|**Размер**|  
|---------------|--------------|  
|FROZEN <xref:System.Windows.Media.SolidColorBrush>|212 байт|  
|Нефиксированный <xref:System.Windows.Media.SolidColorBrush>|972 байта|  
  
 Следующий пример кода демонстрирует эту концепцию.  
  
 [!code-csharp[Performance#PerformanceSnippet3](~/samples/snippets/csharp/VS_Snippets_Wpf/Performance/CSharp/Window1.xaml.cs#performancesnippet3)]
 [!code-vb[Performance#PerformanceSnippet3](~/samples/snippets/visualbasic/VS_Snippets_Wpf/Performance/visualbasic/window1.xaml.vb#performancesnippet3)]  
  
### <a name="changed-handlers-on-unfrozen-freezables-may-keep-objects-alive"></a>Обработчики событий изменений Changed в нефиксированных объектах Freezable могут поддерживать объекты в активном состоянии  
 Делегат, который объект передает в <xref:System.Windows.Freezable> объекта <xref:System.Windows.Freezable.Changed> событий является ссылкой на этот объект. Таким образом <xref:System.Windows.Freezable.Changed> обработчики событий могут поддерживать объекты в активном состоянии больше, чем ожидалось. При выполнении очистки объекта, зарегистрированного для прослушивания <xref:System.Windows.Freezable> объекта <xref:System.Windows.Freezable.Changed> событий, очень важно удалить этот делегат перед освобождением объекта.  
  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] также подключает <xref:System.Windows.Freezable.Changed> события внутренним образом. Например, все свойства зависимостей принимающие <xref:System.Windows.Freezable> как значение будет прослушивать <xref:System.Windows.Freezable.Changed> события автоматически. <xref:System.Windows.Shapes.Shape.Fill%2A> Свойство, которое принимает <xref:System.Windows.Media.Brush>, иллюстрирует эту концепцию.  
  
 [!code-csharp[Performance#PerformanceSnippet4](~/samples/snippets/csharp/VS_Snippets_Wpf/Performance/CSharp/Window1.xaml.cs#performancesnippet4)]
 [!code-vb[Performance#PerformanceSnippet4](~/samples/snippets/visualbasic/VS_Snippets_Wpf/Performance/visualbasic/window1.xaml.vb#performancesnippet4)]  
  
 При назначении `myBrush` для `myRectangle.Fill`делегат, указывающий обратно <xref:System.Windows.Shapes.Rectangle> добавляется объект <xref:System.Windows.Media.SolidColorBrush> объекта <xref:System.Windows.Freezable.Changed> событий. Это означает, что следующий код в действительности не разрешает `myRect` сборку мусора.  
  
 [!code-csharp[Performance#PerformanceSnippet5](~/samples/snippets/csharp/VS_Snippets_Wpf/Performance/CSharp/Window1.xaml.cs#performancesnippet5)]
 [!code-vb[Performance#PerformanceSnippet5](~/samples/snippets/visualbasic/VS_Snippets_Wpf/Performance/visualbasic/window1.xaml.vb#performancesnippet5)]  
  
 В этом случае `myBrush` по-прежнему сохраняет `myRectangle` активном состоянии и снова вызовет его при его срабатывании его <xref:System.Windows.Freezable.Changed> событий. Обратите внимание, что при назначении `myBrush` для <xref:System.Windows.Shapes.Shape.Fill%2A> свойства нового <xref:System.Windows.Shapes.Rectangle> будет просто добавляться другой обработчик событий в `myBrush`.  
  
 Рекомендуемый способ очистки этих типов объектов должно быть удаление <xref:System.Windows.Media.Brush> из <xref:System.Windows.Shapes.Shape.Fill%2A> свойство, которое в свою очередь приведет к удалению <xref:System.Windows.Freezable.Changed> обработчик событий.  
  
 [!code-csharp[Performance#PerformanceSnippet6](~/samples/snippets/csharp/VS_Snippets_Wpf/Performance/CSharp/Window1.xaml.cs#performancesnippet6)]
 [!code-vb[Performance#PerformanceSnippet6](~/samples/snippets/visualbasic/VS_Snippets_Wpf/Performance/visualbasic/window1.xaml.vb#performancesnippet6)]  
  
<a name="User_Interface_Virtualization"></a>   
## <a name="user-interface-virtualization"></a>Виртуализация пользовательского интерфейса  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] также предоставляет разновидность <xref:System.Windows.Controls.StackPanel> элемент, который автоматически «виртуализирует» привязкой к данным дочернего содержимого. В данном контексте слово «виртуализация» означает способ, с помощью которого подмножество объектов создается из большего количества элементов данных в зависимости от того, какие из элементов отображаются на экране. Как для памяти, так и для процессора затратно создавать большое число элементов пользовательского интерфейса, при том что только несколько из них могут отображаться на экране одновременно. <xref:System.Windows.Controls.VirtualizingStackPanel> (с помощью функций, предоставляемых <xref:System.Windows.Controls.VirtualizingPanel>) подсчитывает видимые элементы и работает с <xref:System.Windows.Controls.ItemContainerGenerator> из <xref:System.Windows.Controls.ItemsControl> (такие как <xref:System.Windows.Controls.ListBox> или <xref:System.Windows.Controls.ListView>) создавать только элементы для видимых элементов.  
  
 Для оптимизации производительности визуальные объекты для этих элементов создаются или поддерживаются в активном состоянии, только если они будут отображаться на экране. Если они больше не находятся в видимой области элемента управления, визуальные объекты могут быть удалены. Это не следует путать с виртуализацией данных, где не все объекты данных присутствуют в локальной коллекции, а скорее, передаются в потоке при необходимости.  
  
 В следующей таблице показано затраченное время, добавление и отрисовку 5000 <xref:System.Windows.Controls.TextBlock> элементы <xref:System.Windows.Controls.StackPanel> и <xref:System.Windows.Controls.VirtualizingStackPanel>. В этом случае измеряется время между присоединением текстовой строки для <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A> свойство <xref:System.Windows.Controls.ItemsControl> и временем, когда элементы panel отображением этой текстовой строки.  
  
|**Главная панель**|**Время отрисовки (мс)**|  
|--------------------|----------------------------|  
|<xref:System.Windows.Controls.StackPanel>|3210|  
|<xref:System.Windows.Controls.VirtualizingStackPanel>|46|  
  
## <a name="see-also"></a>См. также

- [Улучшение производительности приложений WPF](optimizing-wpf-application-performance.md)
- [Планирование производительности приложения](planning-for-application-performance.md)
- [Использование преимуществ оборудования](optimizing-performance-taking-advantage-of-hardware.md)
- [Разметка и разработка](optimizing-performance-layout-and-design.md)
- [Двумерная графика и изображения](optimizing-performance-2d-graphics-and-imaging.md)
- [Ресурсы приложений](optimizing-performance-application-resources.md)
- [Текста](optimizing-performance-text.md)
- [Привязка данных](optimizing-performance-data-binding.md)
- [Дополнительные рекомендации по повышению производительности](optimizing-performance-other-recommendations.md)

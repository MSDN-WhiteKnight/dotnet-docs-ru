---
title: События времени жизни объекта
ms.date: 03/30/2017
helpviewer_keywords:
- events [WPF], ContentRendered
- events [WPF], Deactivated
- events [WPF], Unloaded
- Activated events [WPF]
- events [WPF], Loaded
- Application objects [WPF], lifetime events
- events [WPF], Activated
- ContentRendered events [WPF]
- Deactivated events [WPF]
- events [WPF], Initialized
- events [WPF], Closing
- Unloaded events [WPF]
- exit events [WPF]
- objects' lifetime events [WPF]
- Loaded events [WPF]
- Closing events [WPF]
- events [WPF], Closed
- Initialized events [WPF]
- Closed events [WPF]
- startup events [WPF]
- lifetime events of objects [WPF]
ms.assetid: face6fc7-465b-4502-bfe5-e88d2e729a78
ms.openlocfilehash: 8ecc3f716061dfd08ac95652d1a9d8e06e26d949
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59175797"
---
# <a name="object-lifetime-events"></a>События времени жизни объекта
В этом разделе описываются определенные события WPF, обозначающие этапы создания, использования и удаления времени жизни объекта.  

<a name="prerequisites"></a>   
## <a name="prerequisites"></a>Предварительные требования  
 Предполагается, что вы имеете представление о свойствах зависимостей с точки зрения потребителя существующих свойств зависимостей в классах Windows Presentation Foundation (WPF) и ознакомились с разделом [Общие сведения о свойствах зависимостей](dependency-properties-overview.md). Чтобы выполнить примеры в этом разделе, следует также иметь представление о XAML (см. раздел [Обзор XAML (WPF)](xaml-overview-wpf.md)) и знать, как создаются приложения WPF.  
  
<a name="intro"></a>   
## <a name="object-lifetime-events"></a>События времени жизни объекта  
 Все объекты в управляемым кодом Microsoft .NET Framework выполните аналогичный набор этапов жизни, создания, использования и удаления. Многие объекты также имеют этап завершения, который возникает как часть этапа удаления. WPF объекты, дополнительные, особенно визуальные объекты, WPF определяет как элементы, также имеют набор общих этапов жизни объекта. Модель приложений и модель программирования WPF предоставляют эти этапы как последовательность событий. В WPF существует четыре основных типа объектов, связанных с событиями времени жизни: элементы в целом, элементы окна, узлы навигации и объекты приложения. Узлы окон и навигации также входят в более крупные группы визуальных объектов (элементов). В этом разделе описываются события времени жизни, которые являются общими для всех элементов, а затем даются общие сведения о конкретных событиях, которые относятся к определениям приложений, узлам окон или навигации.  
  
<a name="common_events"></a>   
## <a name="common-lifetime-events-for-elements"></a>Общие события времени жизни для элементов  
 Любой элемент уровня инфраструктуры WPF (объекты, производные от либо <xref:System.Windows.FrameworkElement> или <xref:System.Windows.FrameworkContentElement>) имеет три общих события времени жизни: <xref:System.Windows.FrameworkElement.Initialized>, <xref:System.Windows.FrameworkElement.Loaded>, и <xref:System.Windows.FrameworkElement.Unloaded>.  
  
### <a name="initialized"></a>инициализированные  
 <xref:System.Windows.FrameworkElement.Initialized> возникает первым и примерно соответствует инициализации объекта путем вызова его конструктора. Поскольку событие происходит в ответ на инициализацию, можно гарантировать, что все свойства объекта установлены. (Исключением является использование таких выражений, как динамические ресурсы или привязки; это будут необработанные выражения.) В результате требование установки всех свойств, последовательность <xref:System.Windows.FrameworkElement.Initialized> , вызванных вложенных элементов, которые определены в разметке отображается в порядке вложенности элементов в дереве элементов, во-первых, затем от родительского элемента к корню. Этот порядок обусловлен тем, что отношения и вложения «родитель/потомок» являются свойствами, и поэтому родитель не может завершить инициализацию, пока дочерние элементы, указанные в свойстве, не будут полностью инициализированы.  
  
 При написании обработчика в ответ на <xref:System.Windows.FrameworkElement.Initialized> событий, необходимо учитывать, что нет никакой гарантии, что все остальные элементы в дереве элементов (логическом или визуальном дереве) вокруг где присоединяется обработчик, были созданы, особенно родительские элементы. Переменные члены могут быть null, или источники данных могут быть еще не заполненными через базовую привязку (даже на уровне выражения).  
  
### <a name="loaded"></a>Загружен  
 <xref:System.Windows.FrameworkElement.Loaded> Далее вызывается. <xref:System.Windows.FrameworkElement.Loaded> События перед окончательной отрисовкой, но после система макета вычислила все необходимые значения для подготовки к просмотру. <xref:System.Windows.FrameworkElement.Loaded> предполагает, что логическое дерево, элемент, содержащийся в завершена и подключается к источнику представления, который предоставляет HWND и поверхность для отрисовки. Стандартная привязка данных (привязка к локальному источнику, например другие свойства или явно определенным источникам данных) произойдет до <xref:System.Windows.FrameworkElement.Loaded>. Асинхронная привязка данных (к внешним или динамическим источникам) может произойти, но по определению асинхронности не обязательно произойдет.  
  
 Механизм, по которому <xref:System.Windows.FrameworkElement.Loaded> события отличается от <xref:System.Windows.FrameworkElement.Initialized>. <xref:System.Windows.FrameworkElement.Initialized> Событие является вызывается элементом за элементом, без прямого согласования с завершенным деревом элементов. Напротив <xref:System.Windows.FrameworkElement.Loaded> событие вызывается в качестве согласованного усилия по всему дереву элементов (в частности, логическое дерево). Если все элементы в дереве находятся в состоянии, когда они считаются загружены <xref:System.Windows.FrameworkElement.Loaded> сначала события в корневом элементе. <xref:System.Windows.FrameworkElement.Loaded> Событий затем вызывается последовательно для каждого дочернего элемента.  
  
> [!NOTE]
>  Такое поведение может внешне напоминать туннелирование для перенаправленного события. Тем не менее информация не переносится от события к событию. Каждый элемент всегда имеет возможность обработать его <xref:System.Windows.FrameworkElement.Loaded> событий и пометка данных события как обработанных не оказывает влияния за пределами этого элемента.  
  
### <a name="unloaded"></a>Выгружен  
 <xref:System.Windows.FrameworkElement.Unloaded> вызывается последним и инициируется либо источником представления, либо удаляемым визуальным родителем. Когда <xref:System.Windows.FrameworkElement.Unloaded> возникает и обрабатывается, элемент, который является родителем источника события (что определяется <xref:System.Windows.FrameworkElement.Parent%2A> свойства) или любой конкретный элемент в логических или визуальных деревьях может уже быть сброшен, это означает, что связывание данных, ссылки на ресурсы , и стили могут быть установлены не в обычное или последнее известное значение времени выполнения.  
  
<a name="application_model_elements"></a>   
## <a name="lifetime-events-application-model-elements"></a>Элементы модели приложений событий времени жизни  
 Основываясь на общих события времени жизни для элементов являются следующие элементы модели приложений: <xref:System.Windows.Application>, <xref:System.Windows.Window>, <xref:System.Windows.Controls.Page>, <xref:System.Windows.Navigation.NavigationWindow>, и <xref:System.Windows.Controls.Frame>. Они расширяют общие события времени жизни дополнительными событиями, которые связаны с их конкретными целями. Эти темы подробно рассматриваются в следующих разделах.  
  
-   <xref:System.Windows.Application>: [Общие сведения об управлении приложением](../app-development/application-management-overview.md).  
  
-   <xref:System.Windows.Window>: [Общие сведения о Windows WPF](../app-development/wpf-windows-overview.md).  
  
-   <xref:System.Windows.Controls.Page>, <xref:System.Windows.Navigation.NavigationWindow>, и <xref:System.Windows.Controls.Frame>: [Общие сведения о переходах](../app-development/navigation-overview.md).  
  
## <a name="see-also"></a>См. также

- [Приоритет значения свойств зависимостей](dependency-property-value-precedence.md)
- [Общие сведения о перенаправленных событиях](routed-events-overview.md)

---
title: Общие сведения о базовых элементах
ms.date: 03/30/2017
helpviewer_keywords:
- base elements [WPF]
ms.assetid: 2c997092-72c6-4767-bc84-74267f4eee72
ms.openlocfilehash: 0cd69a4d2d6087c1ebf93bb5931511f32a4c9c5f
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59110062"
---
# <a name="base-elements-overview"></a>Общие сведения о базовых элементах
Большое количество классов в [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] являются производными от четырех классов, которые обычно называются в документации по [!INCLUDE[TLA2#tla_sdk](../../../../includes/tla2sharptla-sdk-md.md)] базовыми классами элементов. Эти классы являются <xref:System.Windows.UIElement>, <xref:System.Windows.FrameworkElement>, <xref:System.Windows.ContentElement>, и <xref:System.Windows.FrameworkContentElement>. <xref:System.Windows.DependencyObject> Класс также имеет отношение, так как это общий базовый класс обоих <xref:System.Windows.UIElement> и <xref:System.Windows.ContentElement>  

<a name="base_apis"></a>   
## <a name="base-element-apis-in-wpf-classes"></a>Интерфейсы API базовых элементов в классах WPF  
 Оба <xref:System.Windows.UIElement> и <xref:System.Windows.ContentElement> являются производными от <xref:System.Windows.DependencyObject>, через несколько различных путей. Разбиение на этом уровне имеет дело с тем, как <xref:System.Windows.UIElement> или <xref:System.Windows.ContentElement> используются в пользовательском интерфейсе и какой целью они применяются в приложении. <xref:System.Windows.UIElement> также имеет <xref:System.Windows.Media.Visual> в своей иерархии класс — это класс, который предоставляет низкоуровневые графические основной поддержки [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)]. <xref:System.Windows.Media.Visual> предоставляет платформу для отображения, определяя независимые прямоугольные области экрана. На практике <xref:System.Windows.UIElement> для элементов, поддерживающих модель больших объектов, для отрисовки и макетов в областях, которые можно описать как прямоугольные области экрана, и где модель содержимого намеренно более открыта, чтобы разрешить разные сочетания элементов. <xref:System.Windows.ContentElement> является производным от <xref:System.Windows.Media.Visual>; его модель <xref:System.Windows.ContentElement> потреблял бы что-то еще, скажем, для чтения или просмотра, который затем будет интерпретировать элементы и создавать полный <xref:System.Windows.Media.Visual> для [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] для использования. Определенные <xref:System.Windows.UIElement> классы предназначены для размещения содержимого: они обеспечивают размещение и отображение для одного или нескольких <xref:System.Windows.ContentElement> классы (<xref:System.Windows.Controls.DocumentViewer> является примером такого класса). <xref:System.Windows.ContentElement> используется как базовый класс для элементов с меньшими объектными моделями и текста, сведения или содержимого документов, которые могут размещаться в <xref:System.Windows.UIElement>.  
  
### <a name="framework-level-and-core-level"></a>Уровень платформы и уровень ядра  
 <xref:System.Windows.UIElement> служит базовым классом для <xref:System.Windows.FrameworkElement>, и <xref:System.Windows.ContentElement> служит базовым классом для <xref:System.Windows.FrameworkContentElement>. Назначением этого следующего уровня классов является поддержка уровня ядра WPF, существующего отдельно от уровня платформы WPF. Аналогичное разделение существуют в [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)], где разделены между собой сборки PresentationCore и PresentationFramework. Уровень платформы WPF предоставляет более полное удовлетворение потребностей основного приложения, включая реализацию диспетчера макетов для представления. Уровень ядра WPF позволяет использовать по максимуму возможности [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], не прибегая к затратам на дополнительные сборки. Различия между этими уровнями обычно не имеют значения в типичных сценариях разработки приложений, и в целом следует рассматривать [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)] как единое целое. Различия между уровнем платформы WPF и уровнем ядра не должны волновать разработчиков. Различия в уровнях следует учитывать в том случае, если при разработке приложения решено заменить значительное количество функций уровня платформы WPF, например если общее решение уже имеет свои собственные реализации композиции и макета [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)].  
  
<a name="subclassing_elements"></a>   
## <a name="choosing-which-element-to-derive-from"></a>Выбор элемента для наследования  
 Наиболее удобным способом создания другого класса, расширяющего возможности [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], является наследование от одного из классов [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]. Тогда вы получаете максимально возможное количество наследуемых функций благодаря существующей иерархии классов. В этом разделе перечислены возможности, предоставляемые тремя наиболее важными классами элементов. Эти сведения помогут вам решить, какой класс использовать для наследования.  
  
 При реализации элемента управления, который в действительности является одним из наиболее распространенных причин для создания производного от [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] класса, может потребоваться являются производными от класса, который является практическим управления семейства базовый класс элемента управления, или на как минимум <xref:System.Windows.Controls.Control> базового класса. Некоторые рекомендации и практические примеры см. в разделе [Общие сведения о разработке элементов управления](../controls/control-authoring-overview.md).  
  
 Если вы не создаете элемент управления, а хотите создать производный класс от класса, который находится выше по иерархии, в следующих разделах вы найдете рекомендации по определению характеристик для каждого базового класса элементов.  
  
 Если вы создаете класс, производный от <xref:System.Windows.DependencyObject>, вы наследуете следующие функциональные возможности:  
  
-   <xref:System.Windows.DependencyObject.GetValue%2A> и <xref:System.Windows.DependencyObject.SetValue%2A> поддержки и общая системная поддержка свойств.  
  
-   Возможность использования свойств зависимостей и вложенных свойств, которые реализуются как свойства зависимостей.  
  
 Если вы создаете класс, производный от <xref:System.Windows.UIElement>, вы наследуете следующие функциональные возможности, предоставляемые <xref:System.Windows.DependencyObject>:  
  
-   Базовая поддержка для анимируемых значений свойств. Более подробную информацию см. в разделе [Общие сведения об эффектах анимации](../graphics-multimedia/animation-overview.md).  
  
-   Базовая поддержка событий ввода и поддержка команд. Дополнительные сведения см. в разделе [Общие сведения о вводе данных](input-overview.md) и [Общие сведения о системе команд](commanding-overview.md).  
  
-   Виртуальные методы, которые можно переопределить для передачи данных в систему макета.  
  
 Если вы создаете класс, производный от <xref:System.Windows.FrameworkElement>, вы наследуете следующие функциональные возможности, предоставляемые <xref:System.Windows.UIElement>:  
  
-   Поддержка стилей и раскадровок. Дополнительные сведения см. в разделе <xref:System.Windows.Style> и [Общие сведения о раскадровках](../graphics-multimedia/storyboards-overview.md).  
  
-   Поддержка привязки данных. Более подробную информацию см. в разделе [Общие сведения о связывании данных](../data/data-binding-overview.md).  
  
-   Поддержка ссылок на динамические ресурсы. Дополнительные сведения см. в разделе [Ресурсы XAML](xaml-resources.md).  
  
-   Поддержка наследования значений свойств и других флагов в метаданных, которые помогают передавать сведения о состоянии свойств в службы платформы, такие как привязка данных, управление стилями и реализация структуры макета. Дополнительные сведения см. в разделе [Метаданные свойств платформы](framework-property-metadata.md).  
  
-   Понятие логического дерева. Дополнительные сведения см. в разделе [Деревья в WPF](trees-in-wpf.md).  
  
-   Поддержка практической реализации уровня платформы WPF система макета, включая <xref:System.Windows.FrameworkElement.OnPropertyChanged%2A> переопределения, которое может обнаружить изменения в свойствах, влияющих на макет.  
  
 Если вы создаете класс, производный от <xref:System.Windows.ContentElement>, вы наследуете следующие функциональные возможности, предоставляемые <xref:System.Windows.DependencyObject>:  
  
-   Поддержка анимации. Более подробную информацию см. в разделе [Общие сведения об эффектах анимации](../graphics-multimedia/animation-overview.md).  
  
-   Базовая поддержка событий ввода и поддержка команд. Дополнительные сведения см. в разделе [Общие сведения о вводе данных](input-overview.md) и [Общие сведения о системе команд](commanding-overview.md).  
  
 Если вы создаете класс, производный от <xref:System.Windows.FrameworkContentElement>, вы получаете следующие функциональные возможности, предоставляемые <xref:System.Windows.ContentElement>:  
  
-   Поддержка стилей и раскадровок. Дополнительные сведения см. в разделе <xref:System.Windows.Style> и [Общие сведения об анимации](../graphics-multimedia/animation-overview.md).  
  
-   Поддержка привязки данных. Более подробную информацию см. в разделе [Общие сведения о связывании данных](../data/data-binding-overview.md).  
  
-   Поддержка ссылок на динамические ресурсы. Дополнительные сведения см. в разделе [Ресурсы XAML](xaml-resources.md).  
  
-   Поддержка наследования значений свойств и других флагов в метаданных, которые помогают передавать сведения о состоянии свойств в службы платформы, такие как привязка данных, управление стилями и реализация структуры макета. Дополнительные сведения см. в разделе [Метаданные свойств платформы](framework-property-metadata.md).  
  
-   Вы не наследуете доступ к изменениям системы макета (таких как <xref:System.Windows.FrameworkElement.ArrangeOverride%2A>). Реализации системы макета доступны только на <xref:System.Windows.FrameworkElement>. Однако вы наследуете <xref:System.Windows.FrameworkElement.OnPropertyChanged%2A> переопределения, которое может обнаружить изменения в свойства, которые влияют на макет и о них любым узлам содержимого.  
  
 Модели содержимого описаны в документации для различных классов. Модель содержимого, принятая для класса, возможно, является тем фактором, который следует рассмотреть при выборе подходящего класса для наследования. Дополнительные сведения см. в разделе [Модель содержимого WPF](../controls/wpf-content-model.md).  
  
<a name="other_base_classes"></a>   
## <a name="other-base-classes"></a>Другие базовые классы  
  
### <a name="dispatcherobject"></a>DispatcherObject  
 <xref:System.Windows.Threading.DispatcherObject> обеспечивает поддержку для [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] модели и включает все объекты, созданные для работы с потоками [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] приложений, которым будет связана <xref:System.Windows.Threading.Dispatcher>. Даже если вы не являются производными от <xref:System.Windows.UIElement>, <xref:System.Windows.DependencyObject>, или <xref:System.Windows.Media.Visual>, рекомендуется наследование от <xref:System.Windows.Threading.DispatcherObject> для получения поддержки потоковой модели. Дополнительные сведения см. в разделе [Модель потоков](threading-model.md).  
  
### <a name="visual"></a>Визуальный элемент  
 <xref:System.Windows.Media.Visual> реализует концепцию двумерного объекта, который обычно требует визуального представления в приблизительно прямоугольной области. Реальное отображение объекта <xref:System.Windows.Media.Visual> происходит в других классах (не автономный), но <xref:System.Windows.Media.Visual> класс предоставляет известный тип, который используется в процессах отображения на разных уровнях. <xref:System.Windows.Media.Visual> реализует проверку попадания курсора, но он не предоставляет события, сообщающие положительных результатах проверки (они находятся в <xref:System.Windows.UIElement>). Дополнительные сведения см. в разделе [Программирование визуального слоя](../graphics-multimedia/visual-layer-programming.md).  
  
### <a name="freezable"></a>Freezable  
 <xref:System.Windows.Freezable> имитирует постоянство в изменяемом объекте, предоставляя средства для создания копий объекта, когда требуется постоянный объект или необходим для повышения производительности. <xref:System.Windows.Freezable> Тип обеспечивает общую основу для определенных графических элементов, таких геометрических объектов и кисти, а также анимации. В частности <xref:System.Windows.Freezable> не <xref:System.Windows.Media.Visual>; он может содержать свойства, которые становятся дочерними свойствами при <xref:System.Windows.Freezable> применяется для заполнения значения свойства другого объекта, и эти дочерние свойства могут влиять на отрисовку. Дополнительные сведения см. в разделе [Общие сведения об объектах класса Freezable](freezable-objects-overview.md).  
  
 <xref:System.Windows.Media.Animation.Animatable>  
  
 <xref:System.Windows.Media.Animation.Animatable> является <xref:System.Windows.Freezable> производного класса, который специально добавляет уровень управления анимацией и некоторые служебные члены таким образом, в настоящее время анимационные свойства можно отличить свойства от неанимированных.  
  
### <a name="control"></a>Элемент управления  
 <xref:System.Windows.Controls.Control> является предполагаемым базовым классом для типа объекта, который называется элемент управления или компонент, в зависимости от технологии. Как правило, классы элементов управления [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] — это классы, которые либо непосредственно представляют элемент управления пользовательского интерфейса, либо близко участвуют в его композиции. Основные функциональные возможности, <xref:System.Windows.Controls.Control> включает является шаблон элемента управления.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.Control>
- [Общие сведения о свойствах зависимости](dependency-properties-overview.md)
- [Общие сведения о разработке элементов управления](../controls/control-authoring-overview.md)
- [Архитектура WPF](wpf-architecture.md)

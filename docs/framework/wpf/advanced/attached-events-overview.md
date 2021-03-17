---
title: Общие сведения о вложенных событиях
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- handling attached events [WPF]
- defining attached events as routed events [WPF]
- attached events [WPF], scenarios for
- attached events vs. routed events [WPF]
- backing attached events with routed events [WPF]
- attached events [WPF], definition
ms.assetid: 2c40eae3-80e4-4a45-ae09-df6c9ab4d91e
ms.openlocfilehash: 7b7b0fcc9612994803bb23e985f44c483e708857
ms.sourcegitcommit: 438919211260bb415fc8f96ca3eabc33cf2d681d
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/16/2019
ms.locfileid: "59613594"
---
# <a name="attached-events-overview"></a>Общие сведения о вложенных событиях
[!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] определяет компонент языка и тип события, называемый *присоединенным событием*. Концепция присоединенного события позволяет добавить обработчик для конкретного события в произвольный элемент, а не в элемент, который фактически определяет или наследует событие. В этом случае ни объект, потенциально вызывающий событие, ни конечный обрабатывающий экземпляр не определяет или иным образом не "владеет" событием.  

<a name="prerequisites"></a>   
## <a name="prerequisites"></a>Предварительные требования  
 Предполагается, что вы ознакомились с разделами [Общие сведения о перенаправленных событиях](routed-events-overview.md) и [Обзор XAML (WPF)](xaml-overview-wpf.md).  
  
<a name="Syntax"></a>   
## <a name="attached-event-syntax"></a>Синтаксис присоединенных событий  
 Присоединенные события имеют синтаксис [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] и шаблон кодирования, который должен использоваться резервным кодом для поддержки использования присоединенных событий.  
  
 В синтаксисе [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] присоединенное событие указывается не только по имени события, но и по типу владельца и имени события, разделенным символом точки (.). Так как имя события квалифицируется с помощью имени типа, которому оно принадлежит, синтаксис присоединенных событий позволяет подключить любое присоединенное событие к любому элементу, для которого может быть создан экземпляр.  
  
 Например, ниже приведен синтаксис [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] для подключения обработчика для пользовательского присоединенного события `NeedsCleaning`.  
  
 [!code-xaml[WPFAquariumSln#AE](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAquariumSln/CSharp/WPFAquarium/Window1.xaml#ae)]  
  
 Обратите внимание на префикс `aqua:`. Префикс необходим в этом случае, поскольку присоединенное событие является пользовательским событием, которое поступает из пользовательского сопоставленного xmlns.  
  
<a name="WPFImplements"></a>   
## <a name="how-wpf-implements-attached-events"></a>Реализация присоединенных событий в WPF  
 В [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]присоединенные события, обеспечиваются <xref:System.Windows.RoutedEvent> поле и перенаправляются через дерево, после их возникновения. Как правило, источником присоединенного события (объектом, вызывающим событие) является система или служба, и таким образом, объект, который выполняет код, порождающий это событие, не является непосредственной частью дерева элементов.  
  
<a name="Scenarios"></a>   
## <a name="scenarios-for-attached-events"></a>Сценарии для присоединенных событий  
 В [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]присоединенные события присутствуют в определенных функциональных областях там, где имеется абстракция уровня службы, такие как для событий, включаемых статическим <xref:System.Windows.Input.Mouse> класса или <xref:System.Windows.Controls.Validation> класса. Классы, которые взаимодействуют со службой или используют ее, могут использовать событие в синтаксисе присоединенных событий или предоставить присоединенное событие как перенаправленное событие, которое является частью процесса интеграции возможностей службы классом.  
  
 Хотя [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] определяет количество присоединенных событий, ситуации, в которых вы будете использовать или обрабатывать присоединенное событие напрямую, очень ограничены. Как правило, присоединенное событие служит в качестве архитектурного элемента, однако затем оно передается в неприсоединенное (поддерживаемое "оболочкой" события [!INCLUDE[TLA2#tla_clr](../../../../includes/tla2sharptla-clr-md.md)]) перенаправленное событие.  
  
 К примеру, присоединенное событие основной <xref:System.Windows.Input.Mouse.MouseDown?displayProperty=nameWithType> может намного легче обрабатываться на любой заданной <xref:System.Windows.UIElement> с помощью <xref:System.Windows.UIElement.MouseDown> об этом <xref:System.Windows.UIElement> вместо работы с синтаксисом присоединенных событий, либо в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] или кода. Присоединенное событие выполняет определенную роль в архитектуре, поскольку оно обеспечивает будущее расширение типов устройств ввода. Гипотетическому устройству нужно будет только вызвать <xref:System.Windows.Input.Mouse.MouseDown?displayProperty=nameWithType> в чтобы имитировать ввод от мыши и не может быть производным от <xref:System.Windows.Input.Mouse> для этого. Однако этот сценарий включает обработку кода события, а обработка [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] присоединенного события не относится к этому сценарию.  
  
<a name="Handling"></a>   
## <a name="handling-an-attached-event-in-wpf"></a>Обработка присоединенного события в WPF  
 Процесс для обработки присоединенного события и код обработчика, который вы будете писать, по сути аналогичны перенаправленному событию.  
  
 Как правило, присоединенное событие [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] не сильно отличается от перенаправленного события [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]. Различие заключается в выборе источника события и его представления классом в качестве члена (что также влияет на синтаксис обработчика [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)]).  
  
 Тем не менее, как было отмечено ранее, существующие присоединенные события [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] не предназначены для обработки в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]. Гораздо чаще целью событий является включение составного элемента для передачи состояния в родительский элемент при компоновке. В этом случае событие обычно вызывается в коде и зависит от обработки класса в соответствующем родительском классе. Например, элементы в пределах <xref:System.Windows.Controls.Primitives.Selector> ожидаются для вызова присоединенного <xref:System.Windows.Controls.Primitives.Selector.Selected> обрабатываются события, который затем класс <xref:System.Windows.Controls.Primitives.Selector> класса и дальнейшим потенциальным преобразованием классом <xref:System.Windows.Controls.Primitives.Selector> класс в другое перенаправленное событие, <xref:System.Windows.Controls.Primitives.Selector.SelectionChanged> . Дополнительные сведения о перенаправленных событиях и обработке классов см. в разделе [Маркировка перенаправленных событий как обработанных и обработка классов](marking-routed-events-as-handled-and-class-handling.md).  
  
<a name="Custom"></a>   
## <a name="defining-your-own-attached-events-as-routed-events"></a>Определение собственных присоединенных событий как перенаправленных событий  
 При наследовании от общих базовых классов [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] можно реализовать собственные присоединенные события, включив определенные методы шаблонов в собственный класс и используя вспомогательные методы, которые уже присутствуют в базовых классах.  
  
 Шаблон выглядит следующим образом.  
  
-   Метод **добавить*EventName*обработчик** с двумя параметрами. Первый параметр является экземпляром, к которому добавляется обработчик событий. Вторым параметром является добавляемый обработчик событий. Этот метод должен быть `public` и `static`, не возвращая значения.  
  
-   Метод **удалить*EventName*обработчик** с двумя параметрами. Первый параметр является экземпляр, из которого удаляется обработчик событий. Второй параметр — удаляемый обработчик событий. Этот метод должен быть `public` и `static`, не возвращая значения.  
  
 **Добавить*EventName*обработчик** метод доступа упрощает [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] обработку в таких случаях обработчика присоединенного события атрибуты объявляются в элементе. **Добавить*EventName*обработчик** и **удалить*EventName*обработчик** методы также обеспечивают доступ кода к хранилищу обработчика событий для вложенное событие.  
  
 Этот общий шаблон еще недостаточно точен для практической реализации в структуре, поскольку реализация любого заданного модуля чтения [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] может иметь разные схемы для идентификации базовых событий в поддерживающем языке и архитектуре. Это одна из причин, [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] реализует присоединенные события как перенаправленные события; идентификатор, используемый для события (<xref:System.Windows.RoutedEvent>) уже определен [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] системой событий. Кроме того, перенаправление события является естественным расширением реализации для концепции уровня языка [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] присоединенного события.  
  
 **Добавить*EventName*обработчик** внедрению [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] присоединенное событие состоит из вызова метода <xref:System.Windows.UIElement.AddHandler%2A> с перенаправленным событием и обработчиком в качестве аргументов.  
  
 Эта стратегия реализации и система перенаправленных событий в общем ограничивают обработку присоединенных событий либо <xref:System.Windows.UIElement> производные классы или <xref:System.Windows.ContentElement> производные классы, поскольку только эти классы имеют <xref:System.Windows.UIElement.AddHandler%2A> реализаций.  
  
 Например, следующий код определяет присоединенное событие `NeedsCleaning` в классе владельца`Aquarium`, используя стратегию присоединенных событий [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] для объявления присоединенного события как перенаправленного события.  
  
 [!code-csharp[WPFAquariumSln#AECode](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAquariumSln/CSharp/WPFAquariumObjects/Class1.cs#aecode)]
 [!code-vb[WPFAquariumSln#AECode](~/samples/snippets/visualbasic/VS_Snippets_Wpf/WPFAquariumSln/visualbasic/wpfaquariumobjects/class1.vb#aecode)]  
  
 Обратите внимание, что метод, используемый для установления поля идентификатора присоединенного события, <xref:System.Windows.EventManager.RegisterRoutedEvent%2A>, является фактически тот же метод, который используется для регистрации неприсоединенных перенаправленных событий. Все присоединенные события и перенаправленные события регистрируются в централизованном внутреннем хранилище. Эта реализация хранилища событий обеспечивает поддержку режима "события в качестве интерфейса", который рассматривается в разделе [Общие сведения о перенаправленных событиях](routed-events-overview.md).  
  
<a name="Raising"></a>   
## <a name="raising-a-wpf-attached-event"></a>Вызов присоединенного события WPF  
 Как правило, вам не требуется вызывать существующие определенные присоединенные события [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] в коде. Эти события выполните общей концептуальной модели «служба» и классы служб, таких как <xref:System.Windows.Input.InputManager> несут ответственность за вызов событий.  
  
 Тем не менее при определении пользовательского присоединенного события на основе [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] модель создания вложенных событий на <xref:System.Windows.RoutedEvent>, можно использовать <xref:System.Windows.UIElement.RaiseEvent%2A> для вызова присоединенного события из любого <xref:System.Windows.UIElement> или <xref:System.Windows.ContentElement>. Вызов перенаправленного события (присоединенного или нет) требует объявления конкретного элемента в дереве элементов в качестве источника события; Этот источник указывается как <xref:System.Windows.UIElement.RaiseEvent%2A> вызывающего объекта. За определение того, какой элемент передается как источник в дереве, отвечает служба.  
  
## <a name="see-also"></a>См. также

- [Общие сведения о перенаправленных событиях](routed-events-overview.md)
- [Подробное описание синтаксиса XAML](xaml-syntax-in-detail.md)
- [Код XAML и пользовательские классы для WPF](xaml-and-custom-classes-for-wpf.md)

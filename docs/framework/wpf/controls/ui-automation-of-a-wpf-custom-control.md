---
title: Модель автоматизации пользовательского интерфейса пользовательского элемента управления WPF
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- custom controls [WPF], applying UI automation
- accessibility [WPF], applying to custom controls
- custom controls [WPF], improving accessibility
- UI Automation [WPF], using with custom controls
ms.assetid: 47b310fc-fbd5-4ce2-a606-22d04c6d4911
ms.openlocfilehash: 0d663acc195b36fdc95c196f2233ae997fbd9195
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59132773"
---
# <a name="ui-automation-of-a-wpf-custom-control"></a>Модель автоматизации пользовательского интерфейса пользовательского элемента управления WPF
[!INCLUDE[TLA#tla_uiautomation](../../../../includes/tlasharptla-uiautomation-md.md)] предоставляет единый общий интерфейс, который клиенты могут использовать для проверки или использования пользовательских интерфейсов различных платформ и инфраструктур автоматизации. [!INCLUDE[TLA2#tla_uiautomation](../../../../includes/tla2sharptla-uiautomation-md.md)] обеспечивает проверку кода качества (тестирования), так и приложениями со специальными возможностями, такие как средства чтения с экрана для проверки элементов пользовательского интерфейса и моделирования пользовательского взаимодействия с ними из другого кода. Сведения о [!INCLUDE[TLA2#tla_uiautomation](../../../../includes/tla2sharptla-uiautomation-md.md)] на всех платформах см. в разделе, посвященном специальным возможностям.  
  
 В этом разделе описывается реализация серверного поставщика автоматизации пользовательского интерфейса для пользовательского элемента управления, применяемого в приложении WPF. WPF поддерживает [!INCLUDE[TLA2#tla_uiautomation](../../../../includes/tla2sharptla-uiautomation-md.md)] с помощью дерева одноранговых объектов автоматизации, которое сопутствует дереву элементов интерфейса пользователя. Тестовый код и приложения с поддержкой специальных возможностей могут использовать одноранговые объекты автоматизации напрямую (для внутрипроцессного кода) или через универсальный интерфейс, предоставляемый [!INCLUDE[TLA2#tla_uiautomation](../../../../includes/tla2sharptla-uiautomation-md.md)].  

<a name="AutomationPeerClasses"></a>   
## <a name="automation-peer-classes"></a>Одноранговые классы автоматизации  
 Элементы управления WPF поддерживают [!INCLUDE[TLA2#tla_uiautomation](../../../../includes/tla2sharptla-uiautomation-md.md)] посредством дерева одноранговых классов, производных от <xref:System.Windows.Automation.Peers.AutomationPeer>. В соответствии с соглашением имена одноранговых классов начинаются с имени класса элемента управления, к которому добавляется строка "AutomationPeer". Например <xref:System.Windows.Automation.Peers.ButtonAutomationPeer> — это одноранговый класс для <xref:System.Windows.Controls.Button> класс элемента управления. Одноранговые классы примерно похожи на типы элементов управления [!INCLUDE[TLA2#tla_uiautomation](../../../../includes/tla2sharptla-uiautomation-md.md)], но относятся к элементам WPF. Код автоматизации, обращающийся к приложениям WPF через интерфейс [!INCLUDE[TLA2#tla_uiautomation](../../../../includes/tla2sharptla-uiautomation-md.md)], не использует одноранговые классы автоматизации напрямую, но код автоматизации в том же пространстве процесса может использовать их напрямую.  
  
<a name="BuiltInAutomationPeerClasses"></a>   
## <a name="built-in-automation-peer-classes"></a>Встроенные одноранговые классы автоматизации  
 Элементы реализуют одноранговый класс автоматизации, если они принимают взаимодействие пользователя с интерфейсом или содержат информацию, необходимую пользователям приложений для чтения с экрана. Не все визуальные элементы WPF имеют одноранговые классы автоматизации. Примеры классов, реализующих одноранговые объекты автоматизации: <xref:System.Windows.Controls.Button>, <xref:System.Windows.Controls.TextBox>, и <xref:System.Windows.Controls.Label>. Примерами классов, не реализующих одноранговые объекты автоматизации являются классами, производными от <xref:System.Windows.Controls.Decorator>, такие как <xref:System.Windows.Controls.Border>и классы, основанные на <xref:System.Windows.Controls.Panel>, такие как <xref:System.Windows.Controls.Grid> и <xref:System.Windows.Controls.Canvas>.  
  
 Базовый <xref:System.Windows.Controls.Control> класс не имеет соответствующего однорангового класса. Если требуется, чтобы одноранговый класс соответствовал пользовательскому элементу управления, производный от <xref:System.Windows.Controls.Control>, необходимо создать производный класс пользовательского однорангового <xref:System.Windows.Automation.Peers.FrameworkElementAutomationPeer>.  
  
<a name="SecurityConsiderations"></a>   
## <a name="security-considerations-for-derived-peers"></a>Вопросы безопасности для производных одноранговых классов  
 Одноранговые классы автоматизации должны работать в среде с частичным доверием. Код в сборке UIAutomationClient не настроен для выполнения в среде с частичным доверием и код однорангового класса автоматизации не должен ссылаться на эту сборку. Вместо этого следует использовать классы в сборке UIAutomationTypes. Например, следует использовать <xref:System.Windows.Automation.AutomationElementIdentifiers> класса из сборки UIAutomationTypes, который соответствует <xref:System.Windows.Automation.AutomationElement> класс в сборке UIAutomationClient. В коде однорангового класса автоматизации можно безопасно ссылаться на сборку UIAutomationTypes.  
  
<a name="PeerNavigation"></a>   
## <a name="peer-navigation"></a>Навигация по одноранговым объектам  
 После обнаружения однорангового объекта автоматизации, внутрипроцессный код может перемещаться по дереву одноранговых путем вызова объекта <xref:System.Windows.Automation.Peers.AutomationPeer.GetChildren%2A> и <xref:System.Windows.Automation.Peers.AutomationPeer.GetParent%2A> методы. Перемещение между WPF элементов в элементе управления поддерживается реализацией однорангового узла <xref:System.Windows.Automation.Peers.AutomationPeer.GetChildrenCore%2A> метод. Система модели автоматизации пользовательского интерфейса вызывает этот метод для построения дерева подэлементов, содержащихся в элементе управления (например, элементов списка в элементе управления "список" (ListBox)). Значение по умолчанию <xref:System.Windows.Automation.Peers.UIElementAutomationPeer.GetChildrenCore%2A?displayProperty=nameWithType> метод обходит визуальное дерево элементов для построения дерева одноранговых объектов автоматизации. Пользовательские элементы управления переопределяют этот метод для предоставления дочерних элементов клиентам автоматизации, возвращая одноранговые объекты автоматизации элементов, которые передают информацию или разрешают взаимодействие с пользователем.  
  
<a name="Customizations"></a>   
## <a name="customizations-in-a-derived-peer"></a>Настройка производного однорангового класса  
 Все классы, производные от <xref:System.Windows.UIElement> и <xref:System.Windows.ContentElement> содержат защищенный виртуальный метод <xref:System.Windows.UIElement.OnCreateAutomationPeer%2A>. WPF вызывает <xref:System.Windows.UIElement.OnCreateAutomationPeer%2A> для получения однорангового объекта автоматизации для каждого элемента управления. Код автоматизации может использовать одноранговый объект для получения информации о характеристиках и функциях элемента управления и моделирования интерактивного использования. Пользовательский элемент управления, поддерживающий автоматизацию необходимо переопределить <xref:System.Windows.UIElement.OnCreateAutomationPeer%2A> и возвращать экземпляр класса, производного от <xref:System.Windows.Automation.Peers.AutomationPeer>. Например, если пользовательский элемент управления является производным от <xref:System.Windows.Controls.Primitives.ButtonBase> класса, то объект, возвращенный <xref:System.Windows.UIElement.OnCreateAutomationPeer%2A> должен быть производным от <xref:System.Windows.Automation.Peers.ButtonBaseAutomationPeer>.  
  
 При реализации пользовательского элемента управления необходимо переопределить методы "Core" базового однорангового класса автоматизации, которые описывают специфическое поведение пользовательского элемента управления.  
  
### <a name="override-oncreateautomationpeer"></a>Переопределение метода OnCreateAutomationPeer  
 Переопределить <xref:System.Windows.UIElement.OnCreateAutomationPeer%2A> метод для пользовательского элемента управления так, чтобы он возвращал объект поставщика, который должен прямо или косвенно наследующие от <xref:System.Windows.Automation.Peers.AutomationPeer>.  
  
### <a name="override-getpattern"></a>Переопределение метода GetPattern  
 Одноранговые классы автоматизации упрощают некоторые аспекты реализации поставщиков [!INCLUDE[TLA2#tla_uiautomation](../../../../includes/tla2sharptla-uiautomation-md.md)] на стороне сервера, но одноранговые классы автоматизации пользовательских элементов управления по-прежнему должны обрабатывать интерфейсы шаблонов. Как и поставщиках, отличных от WPF, одноранговые классы поддерживают шаблоны элементов управления, предоставляя реализации интерфейсов в <xref:System.Windows.Automation.Provider?displayProperty=nameWithType> пространства имен, такие как <xref:System.Windows.Automation.Provider.IInvokeProvider>. Интерфейсы шаблонов элементов управления могут быть реализованы самим одноранговым классом или другим объектом. Реализация однорангового узла <xref:System.Windows.Automation.Peers.AutomationPeer.GetPattern%2A> возвращает объект, который поддерживает указанный шаблон. [!INCLUDE[TLA2#tla_uiautomation](../../../../includes/tla2sharptla-uiautomation-md.md)] код вызывает <xref:System.Windows.Automation.Peers.UIElementAutomationPeer.GetPattern%2A> метода с указанием <xref:System.Windows.Automation.Peers.PatternInterface> значение перечисления. Переопределенный <xref:System.Windows.Automation.Peers.UIElementAutomationPeer.GetPattern%2A> должен возвращать объект, который реализует заданный шаблон. Если элемент управления не имеет пользовательской реализации шаблона, можно вызвать реализацию базового типа <xref:System.Windows.Automation.Peers.AutomationPeer.GetPattern%2A> для извлечения его реализации или значение null, если шаблон не поддерживается для данного типа элемента управления. Например, пользовательский элемент управления NumericUpDown может быть присвоено значение в диапазоне, поэтому его [!INCLUDE[TLA2#tla_uiautomation](../../../../includes/tla2sharptla-uiautomation-md.md)] одноранговый <xref:System.Windows.Automation.Provider.IRangeValueProvider> интерфейс. В следующем примере показан способ однорангового узла <xref:System.Windows.Automation.Peers.UIElementAutomationPeer.GetPattern%2A> метод переопределяется, чтобы реагировать на них <xref:System.Windows.Automation.Peers.PatternInterface.RangeValue?displayProperty=nameWithType> значение.  
  
 [!code-csharp[CustomControlNumericUpDown#GetPattern](~/samples/snippets/csharp/VS_Snippets_Wpf/CustomControlNumericUpDown/CSharp/CustomControlLibrary/NumericUpDown.cs#getpattern)]
   
  
 Объект <xref:System.Windows.Automation.Peers.UIElementAutomationPeer.GetPattern%2A> метод также может указывать подэлемент в качестве поставщика шаблона. В следующем коде показано, как <xref:System.Windows.Controls.ItemsControl> передает обработку шаблона в одноранговый своих внутренних прокрутки <xref:System.Windows.Controls.ScrollViewer> элемента управления.  
  
```csharp  
public override object GetPattern(PatternInterface patternInterface)  
{  
    if (patternInterface == PatternInterface.Scroll)  
    {  
        ItemsControl owner = (ItemsControl) base.Owner;  
  
        // ScrollHost is internal to the ItemsControl class  
        if (owner.ScrollHost != null)  
        {  
            AutomationPeer peer = UIElementAutomationPeer.CreatePeerForElement(owner.ScrollHost);  
            if ((peer != null) && (peer is IScrollProvider))  
            {  
                peer.EventsSource = this;  
                return (IScrollProvider) peer;  
            }  
        }  
    }  
    return base.GetPattern(patternInterface);  
}  
```  
  
```vb  
Public Class Class1  
    Public Overrides Function GetPattern(ByVal patternInterface__1 As PatternInterface) As Object  
        If patternInterface1 = PatternInterface.Scroll Then  
            Dim owner As ItemsControl = DirectCast(MyBase.Owner, ItemsControl)  
  
            ' ScrollHost is internal to the ItemsControl class  
            If owner.ScrollHost IsNot Nothing Then  
                Dim peer As AutomationPeer = UIElementAutomationPeer.CreatePeerForElement(owner.ScrollHost)  
                If (peer IsNot Nothing) AndAlso (TypeOf peer Is IScrollProvider) Then  
                    peer.EventsSource = Me  
                    Return DirectCast(peer, IScrollProvider)  
                End If  
            End If  
        End If  
        Return MyBase.GetPattern(patternInterface1)  
    End Function  
End Class  
```  
  
 Чтобы указать подэлемент для обработки шаблона, этот код получает объект подэлемента, создает одноранговый объект с помощью <xref:System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement%2A> задает метод, <xref:System.Windows.Automation.Peers.AutomationPeer.EventsSource%2A> свойства нового однорангового текущему одноранговому узлу и возвращает новый одноранговый элемент. Установка <xref:System.Windows.Automation.Peers.AutomationPeer.EventsSource%2A> на подэлемент подэлементе предотвращает появление в дереве одноранговых классов автоматизации и определяет все события, вызванные вложенного элемента как исходящие из элемента управления, указанного в <xref:System.Windows.Automation.Peers.AutomationPeer.EventsSource%2A>. <xref:System.Windows.Controls.ScrollViewer> Управления не отображается в дереве модели автоматизации, а события прокрутки, которые она создает выглядят как исходящие от <xref:System.Windows.Controls.ItemsControl> объекта.  
  
### <a name="override-core-methods"></a>Переопределение методов "Core"  
 Код автоматизации получает информацию о вашем элементе управления, вызывая открытые методы однорангового класса. Чтобы предоставить информацию о своем элементе управления, переопределите все методы, имена которых заканчиваются на "Core", если ваша реализация элемента управления отличается от той, которая имеется в базовом одноранговом классе автоматизации. Как минимум, необходимо реализовать <xref:System.Windows.Automation.Peers.AutomationPeer.GetClassNameCore%2A> и <xref:System.Windows.Automation.Peers.AutomationPeer.GetAutomationControlTypeCore%2A> методы, как показано в следующем примере.  
  
 [!code-csharp[CustomControlNumericUpDown#CoreOverrides](~/samples/snippets/csharp/VS_Snippets_Wpf/CustomControlNumericUpDown/CSharp/CustomControlLibrary/NumericUpDown.cs#coreoverrides)]
   
  
 Реализация <xref:System.Windows.Automation.Peers.AutomationPeer.GetAutomationControlTypeCore%2A> описывает ваш элемент управления, возвращая <xref:System.Windows.Automation.ControlType> значение. Хотя вы можете вернуть <xref:System.Windows.Automation.ControlType.Custom?displayProperty=nameWithType>, следует возвращать один более конкретные типы элементов управления, если он точно описывает ваш элемент управления. Возвращаемое значение, равное <xref:System.Windows.Automation.ControlType.Custom?displayProperty=nameWithType> требует дополнительной работы поставщика, чтобы реализовать [!INCLUDE[TLA2#tla_uiautomation](../../../../includes/tla2sharptla-uiautomation-md.md)], и [!INCLUDE[TLA2#tla_uiautomation](../../../../includes/tla2sharptla-uiautomation-md.md)] клиентские продукты не могут предвидеть структуру элемента управления, взаимодействие с клавиатурой и возможных шаблонах элементов управления.  
  
 Реализуйте <xref:System.Windows.Automation.Peers.AutomationPeer.IsContentElementCore%2A> и <xref:System.Windows.Automation.Peers.AutomationPeer.IsControlElementCore%2A> методов для обозначения ли элемент управления содержимым данных или выполняет интерактивную роль в пользовательском интерфейсе (или оба). По умолчанию оба метода возвращают значение `true`. Эти параметры повышают удобство использования средств автоматизации (например, средств чтения с экрана), которые могут использовать эти методы для фильтрации дерева автоматизации. Если ваш <xref:System.Windows.Automation.Peers.AutomationPeer.GetPattern%2A> метод передает обработку шаблона в одноранговый объект подэлемента однорангового элемента <xref:System.Windows.Automation.Peers.AutomationPeer.IsControlElementCore%2A> метод может возвращать значение false, чтобы скрыть одноранговый узел подэлемента в дереве автоматизации. Например, прокрутка в <xref:System.Windows.Controls.ListBox> обрабатывается <xref:System.Windows.Controls.ScrollViewer>и одноранговый элемент автоматизации для <xref:System.Windows.Automation.Peers.PatternInterface.Scroll?displayProperty=nameWithType> возвращается <xref:System.Windows.Automation.Peers.AutomationPeer.GetPattern%2A> метод <xref:System.Windows.Automation.Peers.ScrollViewerAutomationPeer> , связанный с <xref:System.Windows.Automation.Peers.ListBoxAutomationPeer>. Таким образом <xref:System.Windows.Automation.Peers.AutomationPeer.IsControlElementCore%2A> метод <xref:System.Windows.Automation.Peers.ScrollViewerAutomationPeer> возвращает `false`, так что <xref:System.Windows.Automation.Peers.ScrollViewerAutomationPeer> не отображается в дереве модели автоматизации.  
  
 Одноранговый класс автоматизации должен предоставлять необходимые значения по умолчанию для вашего элемента управления. Обратите внимание, что XAML, который ссылается на элемент управления может переопределить реализации базовых методов путем включения <xref:System.Windows.Automation.AutomationProperties> атрибуты. Например, следующий код XAML создает кнопку, которая имеет два настраиваемых свойства [!INCLUDE[TLA2#tla_uiautomation](../../../../includes/tla2sharptla-uiautomation-md.md)].  
  
```xaml  
<Button AutomationProperties.Name="Special"   
    AutomationProperties.HelpText="This is a special button."/>  
```  
  
### <a name="implement-pattern-providers"></a>Реализация поставщиков шаблонов  
 Интерфейсы, реализованные с помощью пользовательского поставщика, объявляются явно в том случае, если элемент-владелец является производным непосредственно от <xref:System.Windows.Controls.Control>. Например, в следующем коде объявляется одноранговый объект для объекта <xref:System.Windows.Controls.Control> , реализующий значение диапазона.  
  
```csharp  
public class RangePeer1 : FrameworkElementAutomationPeer, IRangeValueProvider { }  
```  
  
```vb  
Public Class RangePeer1  
    Inherits FrameworkElementAutomationPeer  
    Implements IRangeValueProvider  
End Class  
```  
  
 Владелец-элемент управления, производного от определенного типа элемента управления, такие как <xref:System.Windows.Controls.Primitives.RangeBase>, одноранговый узел может быть производным от эквивалентного производного однорангового класса. В этом случае одноранговый узел будет наследовать от класса <xref:System.Windows.Automation.Peers.RangeBaseAutomationPeer>, который предоставляет базовую реализацию <xref:System.Windows.Automation.Provider.IRangeValueProvider>. В следующем коде показано объявление такого однорангового класса.  
  
```csharp  
public class RangePeer2 : RangeBaseAutomationPeer { }  
```  
  
```vb  
Public Class RangePeer2  
    Inherits RangeBaseAutomationPeer  
End Class  
```  
  
 Пример реализации см. в разделе [Пример пользовательского элемента управления NumericUpDown с темой и поддержкой модели автоматизации пользовательского интерфейса](https://go.microsoft.com/fwlink/?LinkID=160025).  
  
### <a name="raise-events"></a>Создание событий  
 Клиенты автоматизации могут подписаться на события автоматизации. Пользовательские элементы управления должны сообщать об изменениях для управления состоянием, вызвав <xref:System.Windows.Automation.Peers.AutomationPeer.RaiseAutomationEvent%2A> метод. Аналогично, при изменении значения свойства следует вызывать <xref:System.Windows.Automation.Peers.AutomationPeer.RaisePropertyChangedEvent%2A> метод. В приведенном ниже коде показано, как получить одноранговый объект из кода элемента управления и вызвать метод для создания события. В качестве меры оптимизации код также определяет, имеются ли прослушиватели для этого типа событий. Создание событий только при наличии соответствующих прослушивателей позволяет избежать лишней нагрузки и помогает сохранять должную скорость отклика элемента управления.  
  
 [!code-csharp[CustomControlNumericUpDown#RaiseEventFromControl](~/samples/snippets/csharp/VS_Snippets_Wpf/CustomControlNumericUpDown/CSharp/CustomControlLibrary/NumericUpDown.cs#raiseeventfromcontrol)]
   
  
## <a name="see-also"></a>См. также

- [Общие сведения о модели автоматизации пользовательского интерфейса](../../ui-automation/ui-automation-overview.md)
- [Пользовательского элемента управления NumericUpDown с темой и пример Поддержка автоматизации пользовательского интерфейса](https://go.microsoft.com/fwlink/?LinkID=160025)
- [Реализация поставщика автоматизации пользовательского интерфейса на стороне сервера](../../ui-automation/server-side-ui-automation-provider-implementation.md)

---
title: Перехват ввода, осуществляемого пером
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- 'architecture [WPF], '
- ', '
- ', '
- ', '
ms.assetid: 791bb2f0-4e5c-4569-ac3c-211996808d44
ms.openlocfilehash: 5c22c2862ae8b948787fd5e6ca16109aa2f52aef
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59218775"
---
# <a name="intercepting-input-from-the-stylus"></a>Перехват ввода, осуществляемого пером
<xref:System.Windows.Input.StylusPlugIns> Архитектура предоставляет механизм для реализации низкоуровневого управления <xref:System.Windows.Input.Stylus> входных данных и создание рукописный ввод <xref:System.Windows.Ink.Stroke> объектов. <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn> Класс предоставляет механизм для реализации пользовательского поведения и применения его к потоку данных, поступающих от устройства пера, для обеспечения оптимальной производительности.  
  
 В этом разделе содержатся следующие подразделы:  
  
-   [Архитектура](#Architecture)  
  
-   [Реализация подключаемых модулей пера](#ImplementingStylusPlugins)  
  
-   [Добавление подключаемого модуля к объекту класса InkCanvas](#AddingYourPluginToAnInkCanvas)  
  
-   [Заключение](#Conclusion)  
  
<a name="Architecture"></a>   
## <a name="architecture"></a>Архитектура  
 <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn> Развитие [потоке](https://go.microsoft.com/fwlink/?LinkId=50753&clcid=0x409) API-интерфейсы, описанные в [получение и управление с помощью пера](https://go.microsoft.com/fwlink/?LinkId=50752&clcid=0x409)в [Microsoft Windows XP Tablet PC Edition программного обеспечения Комплект SDK 1.7](https://go.microsoft.com/fwlink/?linkid=11782&clcid=0x409).  
  
 Каждый <xref:System.Windows.UIElement> имеет <xref:System.Windows.UIElement.StylusPlugIns%2A> свойства, которое является <xref:System.Windows.Input.StylusPlugIns.StylusPlugInCollection>. Вы можете добавить <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn> к элементу <xref:System.Windows.UIElement.StylusPlugIns%2A> свойства для управления <xref:System.Windows.Input.StylusPoint> данных, так как он создается. <xref:System.Windows.Input.StylusPoint> данные состоят из всех свойств, поддерживаемых дигитайзером системы, включая <xref:System.Windows.Input.StylusPoint.X%2A> и <xref:System.Windows.Input.StylusPoint.Y%2A> точки данных, а также <xref:System.Windows.Input.StylusPoint.PressureFactor%2A> данных.  
  
 Ваш <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn> объектов вставляются непосредственно в поток данных, поступающих от <xref:System.Windows.Input.Stylus> устройства при добавлении <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn> для <xref:System.Windows.UIElement.StylusPlugIns%2A> свойство. Порядок, в котором подключаемые модули добавляются <xref:System.Windows.UIElement.StylusPlugIns%2A> коллекции определяет порядок, в котором они получат <xref:System.Windows.Input.StylusPoint> данных. Например, если добавить подключаемый модуль фильтра, ограничивающий входные данные для определенного региона и затем добавить подключаемый модуль, который распознает жесты, так как они записаны, подключаемый модуль, который распознает жесты будет получать отфильтрованные <xref:System.Windows.Input.StylusPoint> данных.  
  
<a name="ImplementingStylusPlugins"></a>   
## <a name="implementing-stylus-plug-ins"></a>Реализация подключаемых модулей пера  
 Для реализации подключаемого модуля, являются производными от класса <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn>. Этот класс является o применяется к потоку данных, как поступающие из <xref:System.Windows.Input.Stylus>. В этом классе можно изменить значения <xref:System.Windows.Input.StylusPoint> данных.  
  
> [!CAUTION]
>  Если <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn> создает или вызывает исключение, приложение будет закрыто. Необходимо тщательно протестировать элементы управления, которые используют <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn> и использовать элемент управления, только если вы уверены, <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn> не вызовет исключение.  
  
 В следующем примере показан подключаемый модуль, который ограничивает ввод с помощью пера, изменив <xref:System.Windows.Input.StylusPoint.X%2A> и <xref:System.Windows.Input.StylusPoint.Y%2A> значения в <xref:System.Windows.Input.StylusPoint> данных по мере поступают из <xref:System.Windows.Input.Stylus> устройства.  
  
 [!code-csharp[AdvancedInkTopicsSamples#19](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/DynamicRenderer.cs#19)]
   
[!code-csharp[AdvancedInkTopicsSamples#3](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/DynamicRenderer.cs#3)]
  
  
<a name="AddingYourPluginToAnInkCanvas"></a>   
## <a name="adding-your-plug-in-to-an-inkcanvas"></a>Добавление подключаемого модуля к объекту класса InkCanvas  
 Самый простой способ использовать пользовательский подключаемый модуль должен реализовать класс, производный от InkCanvas и добавьте его в <xref:System.Windows.UIElement.StylusPlugIns%2A> свойство.  
  
 В следующем примере показано пользовательское <xref:System.Windows.Controls.InkCanvas> , фильтрующее рукописный ввод.  
  
 [!code-csharp[AdvancedInkTopicsSamples#4](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/Window1.xaml.cs#4)]  
  
 Если вы добавите `FilterInkCanvas` к приложению и запустить его, вы заметите, что рукописные данные не ограничены областью, пока пользователь не завершит штрих. Это обусловлено <xref:System.Windows.Controls.InkCanvas> имеет <xref:System.Windows.Controls.InkCanvas.DynamicRenderer%2A> свойство, являющееся <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn> и уже является членом <xref:System.Windows.UIElement.StylusPlugIns%2A> коллекции. Пользовательский <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn> добавленные <xref:System.Windows.UIElement.StylusPlugIns%2A> Получает коллекцию <xref:System.Windows.Input.StylusPoint> данных после <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> получает данные. В результате <xref:System.Windows.Input.StylusPoint> данные не будут фильтроваться до, после пользователь отрывает перо, чтобы завершить штриха. Чтобы отфильтровать рукописный ввод, когда пользователь рисует его, необходимо вставить `FilterPlugin` перед <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer>.  
  
 Следующий код C# демонстрирует пользовательский <xref:System.Windows.Controls.InkCanvas> , фильтрующее рукописный ввод, так как он отрисовывается.  
  
 [!code-csharp[AdvancedInkTopicsSamples#5](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/Window1.xaml.cs#5)]  
  
<a name="Conclusion"></a>   
## <a name="conclusion"></a>Заключение  
 Путем наследования своих собственных <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn> классы и вставки их в <xref:System.Windows.Input.StylusPlugIns.StylusPlugInCollection> коллекций, можно значительно улучшить обработку цифровых рукописных данных. У вас есть доступ к <xref:System.Windows.Input.StylusPoint> данных, как оно создается, дает возможность настроить <xref:System.Windows.Input.Stylus> ввода. Так как у вас есть такой низкоуровневый доступ к <xref:System.Windows.Input.StylusPoint> данных, можно реализовать коллекцию чернил и подготовки к просмотру, обеспечивающих оптимальную производительность для вашего приложения.  
  
## <a name="see-also"></a>См. также

- [Дополнительная обработка рукописных данных](advanced-ink-handling.md)
- [Доступ и управление с помощью пера](https://go.microsoft.com/fwlink/?LinkId=50752&clcid=0x409)

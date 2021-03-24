---
title: Общие сведения о декоративных элементах
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- adorners [WPF], about adorners
ms.assetid: 33d4c5c2-2daf-4e45-ba9a-5b673e2b8280
ms.openlocfilehash: 6b710df45379ccce4daf340b4dbe2701d3c96604
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59320474"
---
# <a name="adorners-overview"></a>Общие сведения о декоративных элементах
Графические элементы — это специальный тип <xref:System.Windows.FrameworkElement>, которое используется для предоставления визуальных сигналов пользователю. Помимо прочего, декоративные элементы можно использовать для добавления функциональных дескрипторов к элементам или предоставления информации о состоянии элемента управления.  

<a name="about_Adorners"></a>   
## <a name="about-adorners"></a>Сведения о декоративных элементах  
 <xref:System.Windows.Documents.Adorner> Является пользовательским <xref:System.Windows.FrameworkElement> , привязанный к <xref:System.Windows.UIElement>. Графические элементы отображаются в <xref:System.Windows.Documents.AdornerLayer>, который является поверхностью отрисовки, всегда находится на вершине декорируемого элемента или коллекции настроенных элементов. Отрисовка декоративного элемента не зависит от отрисовки <xref:System.Windows.UIElement> , к которому привязан декоративный элемент. Декоративный элемент обычно располагается относительно элемента, к которому он привязан, с использованием стандартной двухмерной системы координат с началом отсчета в левом верхнем углу графического элемента.  
  
 Типичные сценарии использования декоративных элементов:  
  
-   Добавление функциональных обработчиков к <xref:System.Windows.UIElement> , позволяющие пользователю свободно манипулировать элементом (изменять размеры, вращать, перемещать, и т.д.).  
  
-   Обеспечение визуальной обратной связи для указания различных состояний или в ответ на различные события.  
  
-   Наложение визуальных декоративных эффектов на <xref:System.Windows.UIElement>.  
  
-   Визуальная маскировка или переопределение, частично или полностью <xref:System.Windows.UIElement>.  
  
 Windows Presentation Foundation (WPF) Предоставляет базовую среду для декоративных визуальных элементов. В следующей таблице перечислены основные типы, используемые при настройке объектов, и их назначение. Ниже приведено несколько примеров использования.  
  
|||  
|-|-|  
|<xref:System.Windows.Documents.Adorner>|Абстрактный базовый класс, из которого наследуются все конкретные реализации декоративного элемента.|  
|<xref:System.Windows.Documents.AdornerLayer>|Класс, представляющий слой отрисовки декоративного элемента одного или нескольких настроенных элементов.|  
|<xref:System.Windows.Documents.AdornerDecorator>|Класс, который позволяет ассоциировать слой декоративного элемента с коллекцией элементов.|  
  
<a name="implement_custom_Adorner"></a>   
## <a name="implementing-a-custom-adorner"></a>Реализация пользовательского декоративного элемента  
 Среда декоративных элементов, предоставляемая Windows Presentation Foundation (WPF), предназначена в первую очередь для поддержки создания пользовательских декоративных элементов. Пользовательский декоративный элемент создается путем реализации класс, наследующий от абстрактного <xref:System.Windows.Documents.Adorner> класса.  
  
> [!NOTE]
>  Родительский <xref:System.Windows.Documents.Adorner> — <xref:System.Windows.Documents.AdornerLayer> , отображающий <xref:System.Windows.Documents.Adorner>, не оформляемого элемента.  
  
 В следующем примере показан класс, который реализует простой декоративный элемент. В примере декоративный элемент просто украшает углы <xref:System.Windows.UIElement> закруглениями.  
  
 [!code-csharp[Adorners_SimpleCircleAdorner#_SimpleCircleAdornerBody](~/samples/snippets/csharp/VS_Snippets_Wpf/Adorners_SimpleCircleAdorner/CSharp/Window1.xaml.cs#_simplecircleadornerbody)]
   
  
 На следующем рисунке показана SimpleCircleAdorner, применяется к <xref:System.Windows.Controls.TextBox>.  
  
 ![Снимок экрана, показывающий декорируемого текстовое поле.](./media/adorners-overview/simplecircleadorner-textbox.png)  
  
<a name="rendering_behavior_for_Adorners"></a>   
## <a name="rendering-behavior-for-adorners"></a>Поведение отрисовки для декоративных элементов  
 Важно отметить, что декоративные элементы не включают какое-либо обязательное поведение отрисовки. За результат применения декоративного элемента отвечает его автор.   Распространенным способом реализации поведения отрисовки является переопределение <xref:System.Windows.UIElement.OnRender%2A> метод и использование одного или нескольких <xref:System.Windows.Media.DrawingContext> объекты для отрисовки декоративных элементов по мере необходимости (как показано в приведенном выше примере).  
  
> [!NOTE]
>  Все, что помещено в слой декоративного элемента, отрисовывается поверх остальных установленных стилей. Другими словами, декоративные элементы всегда визуально находятся сверху и не могут быть переопределены с помощью упорядочения по z-координате.  
  
<a name="adorner_events_hittest"></a>   
## <a name="events-and-hit-testing"></a>События и проверка нажатия  
 Декоративные элементы получают входные события так же, как и любой другой <xref:System.Windows.FrameworkElement>.  Так как декоративный элемент всегда имеет высокий z порядок, чем элемент, который он декорирует, получает входящие события (такие как <xref:System.Windows.UIElement.Drop> или <xref:System.Windows.UIElement.MouseMove>), могут быть предназначены для базового декорируемого элемента.  Декоративный элемент может отслеживать определенные события ввода и передавать их в базовый декорированный элемент, повторно запуская событие.  
  
 Чтобы включить сквозную проверку нажатия элементов под декоративным элементом, задайте нажатия <xref:System.Windows.UIElement.IsHitTestVisible%2A> свойства **false** декоративного элемента.  Дополнительные сведения о проверке нажатия см. в разделе  
  
 [Проверка нажатия в визуальном слое](../graphics-multimedia/hit-testing-in-the-visual-layer.md).  
  
<a name="adorn_single_element"></a>   
## <a name="adorning-a-single-uielement"></a>Декорирование одного элемента пользовательского интерфейса  
 Для привязки декоративного элемента к конкретному <xref:System.Windows.UIElement>, выполните следующие действия:  
  
1. Вызовите статический метод <xref:System.Windows.Documents.AdornerLayer.GetAdornerLayer%2A> для получения <xref:System.Windows.Documents.AdornerLayer> для объекта <xref:System.Windows.UIElement> декорируемого. <xref:System.Windows.Documents.AdornerLayer.GetAdornerLayer%2A> Пошаговое описание вверх по визуальному дереву, начиная с указанного <xref:System.Windows.UIElement>и возвращает первый слой графических элементов, которые найдет. (Если слои декоративных элементов не найдены, метод возвращает значение 0.)  
  
2. Вызовите <xref:System.Windows.Documents.AdornerLayer.Add%2A> метод для привязки декоративного элемента к целевому объекту <xref:System.Windows.UIElement>.  
  
 Следующий пример связывает SimpleCircleAdorner (как показано выше) для <xref:System.Windows.Controls.TextBox> с именем *myTextBox*.  
  
 [!code-csharp[Adorners_SimpleCircleAdorner#_AdornSingleElement](~/samples/snippets/csharp/VS_Snippets_Wpf/Adorners_SimpleCircleAdorner/CSharp/Window1.xaml.cs#_adornsingleelement)]
   
  
> [!NOTE]
>  Использование [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] для привязки декоративного элемента к другому элементу в настоящее время не поддерживается.  
  
<a name="adorn_children_panel"></a>   
## <a name="adorning-the-children-of-a-panel"></a>Декорирование дочерних объектов панели  
 Для привязки декоративного элемента к дочерним элементам <xref:System.Windows.Controls.Panel>, выполните следующие действия:  
  
1. Вызовите `static` метод <xref:System.Windows.Documents.AdornerLayer.GetAdornerLayer%2A> найти слой графических элементов для элемента, дочерние элементы которого нужно декорировать.  
  
2. Перечислите дочерние элементы родительского элемента и вызовите <xref:System.Windows.Documents.AdornerLayer.Add%2A> метод для привязки декоративного элемента для каждого дочернего элемента.  
  
 Следующий пример связывает SimpleCircleAdorner (как показано выше) к дочерним элементам <xref:System.Windows.Controls.StackPanel> с именем *myStackPanel*.  
  
 [!code-csharp[Adorners_SimpleCircleAdorner#_AdornChildren](~/samples/snippets/csharp/VS_Snippets_Wpf/Adorners_SimpleCircleAdorner/CSharp/Window1.xaml.cs#_adornchildren)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.AdornerHitTestResult>
- [Обзор фигур и базовых средств рисования в приложении WPF](../graphics-multimedia/shapes-and-basic-drawing-in-wpf-overview.md)
- [Рисование с помощью объектов Image, Drawing и Visual](../graphics-multimedia/painting-with-images-drawings-and-visuals.md)
- [Обзор объектов Drawing](../graphics-multimedia/drawing-objects-overview.md)
- [Практические руководства](adorners-how-to-topics.md)

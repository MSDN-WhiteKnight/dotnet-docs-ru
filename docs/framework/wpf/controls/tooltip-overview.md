---
title: Общие сведения о всплывающих подсказках
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- ToolTip control [WPF], about ToolTip control
- controls [WPF], ToolTip
ms.assetid: f06c1603-e9cb-4809-8a62-234607fc52f7
ms.openlocfilehash: 08b30d8be83ef9d814d17c5d4ec0c95a26bacdad
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59170109"
---
# <a name="tooltip-overview"></a>Общие сведения о всплывающих подсказках
Подсказка — это небольшое всплывающее окно, которое отображается, когда пользователь задерживает указатель мыши над элементом, например, на <xref:System.Windows.Controls.Button>. В этом разделе рассказывается о всплывающих подсказках и о том, как создавать и настраивать их содержимое.  

<a name="what_is_a_tooltip"></a>   
## <a name="what-is-a-tooltip"></a>Что такое всплывающая подсказка?  
 Когда пользователь наводит указатель мыши на элемент, для которого имеется всплывающая подсказка, окно с содержимым этой подсказки (например, текстом, описывающим функции этого элемента управления) отображается в течение заданного периода времени. Когда пользователь перемещает указатель мыши за пределы элемента управления, это окно исчезает, так как теперь фокус не направлен на содержимое подсказки.  
  
 Содержимым подсказки может быть одна или несколько строк текста, изображения, фигуры или другие видимые элементы. Чтобы задать всплывающую подсказку для элемента управления, нужно задать одно из следующих свойств содержимого этой всплывающей подсказки.  
  
-   <xref:System.Windows.FrameworkContentElement.ToolTip%2A?displayProperty=nameWithType>  
  
-   <xref:System.Windows.FrameworkElement.ToolTip%2A?displayProperty=nameWithType>  
  
 Какое свойство можно использовать зависит от того, является ли элемент управления, определяющий подсказку наследует от <xref:System.Windows.FrameworkContentElement> или <xref:System.Windows.FrameworkElement> класса.  
  
<a name="create_tooltip"></a>   
## <a name="creating-a-tooltip"></a>Создание всплывающей подсказки  
 В следующем примере показано, как создать простую всплывающую подсказку, присвоив <xref:System.Windows.FrameworkElement.ToolTip%2A> свойство для <xref:System.Windows.Controls.Button> элемента управления в текстовую строку.  
  
 [!code-xaml[GroupBoxSnippet#ToolTipString](~/samples/snippets/csharp/VS_Snippets_Wpf/GroupBoxSnippet/CS/Window1.xaml#tooltipstring)]  
  
 Можно также определить подсказку как <xref:System.Windows.Controls.ToolTip> объекта. В следующем примере используется [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] для указания <xref:System.Windows.Controls.ToolTip> объект как подсказку <xref:System.Windows.Controls.TextBox> элемент. Обратите внимание, что в примере указывается <xref:System.Windows.Controls.ToolTip> , задав <xref:System.Windows.FrameworkElement.ToolTip%2A?displayProperty=nameWithType> свойство.  
  
 [!code-xaml[ToolTipSimple#ToolTip](~/samples/snippets/csharp/VS_Snippets_Wpf/ToolTipSimple/CSharp/Pane1.xaml#tooltip)]  
  
 В следующем примере кода используется для создания <xref:System.Windows.Controls.ToolTip> объекта. В примере создается <xref:System.Windows.Controls.ToolTip> (`tt`) и связывает его с <xref:System.Windows.Controls.Button>.  
  
 [!code-csharp[ToolTipSimple#2](~/samples/snippets/csharp/VS_Snippets_Wpf/ToolTipSimple/CSharp/Pane1.xaml.cs#2)]
   
  
 Можно также создать содержимое подсказки, который не определен как <xref:System.Windows.Controls.ToolTip> объекта путем заключения содержимое подсказки в макет элемента, например <xref:System.Windows.Controls.DockPanel>. В следующем примере показано, как задать <xref:System.Windows.FrameworkElement.ToolTip%2A> свойство <xref:System.Windows.Controls.TextBox> к содержимому, которое заключено в <xref:System.Windows.Controls.DockPanel> элемента управления.  
  
 [!code-xaml[GroupBoxSnippet#ToolTipDockPanel](~/samples/snippets/csharp/VS_Snippets_Wpf/GroupBoxSnippet/CS/Window1.xaml#tooltipdockpanel)]  
  
<a name="Using_the_ToolTip_and_ToolTipService_Properties"></a>   
## <a name="using-the-properties-of-the-tooltip-and-tooltipservice-classes"></a>Использование свойств классов ToolTip и ToolTipService  
 Содержимое всплывающей подсказки можно настроить, задавая его визуальные свойства и применяя стили. Если вы определяете содержимое подсказки как <xref:System.Windows.Controls.ToolTip> объекта, можно задать визуальные свойства <xref:System.Windows.Controls.ToolTip> объекта. В противном случае необходимо задать аналогичные присоединенные свойства на <xref:System.Windows.Controls.ToolTipService> класса.  
  
 Например, как настроить свойства, чтобы указать положение содержимого всплывающей подсказки с помощью <xref:System.Windows.Controls.ToolTip> и <xref:System.Windows.Controls.ToolTipService> свойства, см. в разделе [положения всплывающей подсказки](how-to-position-a-tooltip.md).  
  
<a name="StylingToolTip"></a>   
## <a name="styling-a-tooltip"></a>Задание стиля всплывающей подсказки  
 Задать стиль <xref:System.Windows.Controls.ToolTip> , определив пользовательский объект <xref:System.Windows.Style>. В следующем примере определяется <xref:System.Windows.Style> вызывается `Simple` , показано, как изменить расположение <xref:System.Windows.Controls.ToolTip> и изменить его внешний вид, задав <xref:System.Windows.Controls.Control.Background%2A>, <xref:System.Windows.Controls.Control.Foreground%2A>, <xref:System.Windows.Controls.Control.FontSize%2A>, и <xref:System.Windows.Controls.Control.FontWeight%2A>.  
  
 [!code-xaml[ToolTipSimple#Style](~/samples/snippets/csharp/VS_Snippets_Wpf/ToolTipSimple/CSharp/Pane1.xaml#style)]  
  
<a name="UsingtheToolTipServiceTimeIntervalProperties"></a>   
## <a name="using-the-time-interval-properties-of-tooltipservice"></a>Использование свойств интервала времени элемента ToolTipService  
 <xref:System.Windows.Controls.ToolTipService> Класс предоставляет следующие свойства для задания подсказки отображения времени: <xref:System.Windows.Controls.ToolTipService.InitialShowDelay%2A>, <xref:System.Windows.Controls.ToolTipService.BetweenShowDelay%2A>, и <xref:System.Windows.Controls.ToolTipService.ShowDuration%2A>.  
  
 Используйте <xref:System.Windows.Controls.ToolTipService.InitialShowDelay%2A> и <xref:System.Windows.Controls.ToolTipService.ShowDuration%2A> свойства для указания задержки, как правило, короткой, перед <xref:System.Windows.Controls.ToolTip> отображается и Кроме того, чтобы указать, как долго <xref:System.Windows.Controls.ToolTip> остается видимым. Дополнительные сведения см. в разделе [Как Задержка отображения всплывающей подсказки](https://docs.microsoft.com/previous-versions/dotnet/netframework-3.5/ms747264(v=vs.90)).  
  
 <xref:System.Windows.Controls.ToolTipService.BetweenShowDelay%2A> Свойство определяет, если всплывающие подсказки для различных элементов управления отображаться без начальной задержки при перемещении указателя мыши быстро между ними. Дополнительные сведения о <xref:System.Windows.Controls.ToolTipService.BetweenShowDelay%2A> свойство, см. в разделе [использование свойства BetweenShowDelay](how-to-use-the-betweenshowdelay-property.md).  
  
 В примере ниже показано, как задать эти свойства для всплывающих подсказок.  
  
 [!code-xaml[ToolTipService#ToolTip](~/samples/snippets/csharp/VS_Snippets_Wpf/ToolTipService/CSharp/Pane1.xaml#tooltip)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.ToolTipService>
- <xref:System.Windows.Controls.ToolTip>
- <xref:System.Windows.Controls.ToolTipEventArgs>
- <xref:System.Windows.Controls.ToolTipEventHandler>
- [Практические руководства](tooltip-how-to-topics.md)

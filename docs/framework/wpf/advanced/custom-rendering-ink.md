---
title: Пользовательская отрисовка рукописных данных
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- custom-rendering ink
- ink [WPF], custom-rendering
- classes [WPF], InkCanvas
ms.assetid: 65c978a7-0ee0-454f-ac7f-b1bd2efecac5
ms.openlocfilehash: b41ded25bd4eb704c6f0d67c8da1c0e6643cac5b
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59323724"
---
# <a name="custom-rendering-ink"></a>Пользовательская отрисовка рукописных данных
<xref:System.Windows.Ink.Stroke.DrawingAttributes%2A> Свойство штриха позволяет задавать внешний вид штриха, включая его размер, цвет и форму, но могут возникнуть ситуации, которые вы хотите настроить внешний вид что <xref:System.Windows.Ink.Stroke.DrawingAttributes%2A> разрешить. Может потребоваться настроить отображение рукописного фрагмента с эффектом аэрографа, масляной живописи и т. д. Windows Presentation Foundation (WPF) позволяет настроить отрисовку рукописных фрагментов путем реализации пользовательского <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> и <xref:System.Windows.Ink.Stroke> объекта.  
  
 В этом разделе содержатся следующие подразделы:  
  
-   [Архитектура](#Architecture)  
  
-   [Реализация динамического отрисовщика](#ImplementingADynamicRenderer)  
  
-   [Реализация пользовательских штрихов](#ImplementingCustomStrokes)  
  
-   [Реализация пользовательского объекта InkCanvas](#ImplementingACustomInkCanvas)  
  
-   [Заключение](#Conclusion)  
  
<a name="Architecture"></a>   
## <a name="architecture"></a>Архитектура  
 Отрисовка рукописных фрагментов происходит два раза: когда пользователь осуществляет рукописный ввод на поверхности рукописного ввода, а затем еще раз после добавления штриха в область с поддержкой рукописного ввода. <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> Отрисовывает рукописные фрагменты при перемещении пера планшета по дигитайзеру, а <xref:System.Windows.Ink.Stroke> отрисовывает сам себя после его добавления в элемент.  
  
 Предусмотрено три класса для реализации динамической отрисовки рукописных фрагментов.  
  
1. **DynamicRenderer**: Реализация класса, унаследованного от класса <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer>. Этот класс является специализированным <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn> , отображающий штрих, так как он отрисовывается. <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> Осуществляет отрисовку в отдельном потоке, поэтому поверхность рукописного ввода появляется для сбора рукописных фрагментов даже при блокировке потока пользовательского интерфейса приложения. Дополнительные сведения о потоковой модели см. в статье [Потоковая модель рукописного ввода](the-ink-threading-model.md). Чтобы настроить динамическую отрисовку штриха, переопределите <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer.OnDraw%2A> метод.  
  
2. **Stroke**: Реализация класса, унаследованного от класса <xref:System.Windows.Ink.Stroke>. Этот класс отвечает за статическую отрисовку <xref:System.Windows.Input.StylusPoint> данные после преобразования в <xref:System.Windows.Ink.Stroke> объекта. Переопределить <xref:System.Windows.Ink.Stroke.DrawCore%2A> согласуется метод, чтобы гарантировать статической отрисовки штриха с динамической отрисовкой.  
  
3. **InkCanvas:** Реализация класса, унаследованного от класса <xref:System.Windows.Controls.InkCanvas>. Назначьте пользовательский <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> для <xref:System.Windows.Controls.InkCanvas.DynamicRenderer%2A> свойство. Переопределить <xref:System.Windows.Controls.InkCanvas.OnStrokeCollected%2A> метод и добавьте пользовательский штрих в <xref:System.Windows.Controls.InkCanvas.Strokes%2A> свойство. Это гарантирует согласованность внешнего вида рукописных фрагментов.  
  
<a name="ImplementingADynamicRenderer"></a>   
## <a name="implementing-a-dynamic-renderer"></a>Реализация динамического отрисовщика  
 Несмотря на то что <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> класс является стандартной частью [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], для осуществления более специализированной отрисовки, необходимо создать настроенный динамический отрисовщик, производный от <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> и переопределить <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer.OnDraw%2A> метод.  
  
 В следующем примере настраиваемый <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> , который выполняет отрисовку рукописного ввода с эффектом кисти линейного градиента.  
  
 [!code-csharp[AdvancedInkTopicsSamples#19](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/DynamicRenderer.cs#19)]
 [!code-vb[AdvancedInkTopicsSamples#19](~/samples/snippets/visualbasic/VS_Snippets_Wpf/AdvancedInkTopicsSamples/VisualBasic/DynamicRenderer.vb#19)]  
[!code-csharp[AdvancedInkTopicsSamples#1](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/DynamicRenderer.cs#1)]
[!code-vb[AdvancedInkTopicsSamples#1](~/samples/snippets/visualbasic/VS_Snippets_Wpf/AdvancedInkTopicsSamples/VisualBasic/DynamicRenderer.vb#1)]  
  
<a name="ImplementingCustomStrokes"></a>   
## <a name="implementing-custom-strokes"></a>Реализация пользовательских штрихов  
 Реализация класса, унаследованного от класса <xref:System.Windows.Ink.Stroke>. Этот класс отвечает за отрисовку <xref:System.Windows.Input.StylusPoint> данные после преобразования в <xref:System.Windows.Ink.Stroke> объекта. Переопределить <xref:System.Windows.Ink.Stroke.DrawCore%2A> класс для фактического рисования.  
  
 Класс Stroke также может хранить пользовательские данные с помощью <xref:System.Windows.Ink.Stroke.AddPropertyData%2A> метод. Эти данные хранятся с данными штриха при сохранении.  
  
 <xref:System.Windows.Ink.Stroke> Класс также может выполнять проверку нажатия. Вы также можете реализовать собственный алгоритм проверки совпадений путем переопределения <xref:System.Windows.Ink.Stroke.HitTest%2A> метода в текущем классе.  
  
 Следующие C# код демонстрирует пользовательский <xref:System.Windows.Ink.Stroke> класс, который выполняет визуализацию <xref:System.Windows.Input.StylusPoint> данные в виде трехмерного штриха.  
  
 [!code-csharp[AdvancedInkTopicsSamples#19](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/DynamicRenderer.cs#19)]
 [!code-vb[AdvancedInkTopicsSamples#19](~/samples/snippets/visualbasic/VS_Snippets_Wpf/AdvancedInkTopicsSamples/VisualBasic/DynamicRenderer.vb#19)]  
[!code-csharp[AdvancedInkTopicsSamples#2](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/DynamicRenderer.cs#2)]
[!code-vb[AdvancedInkTopicsSamples#2](~/samples/snippets/visualbasic/VS_Snippets_Wpf/AdvancedInkTopicsSamples/VisualBasic/DynamicRenderer.vb#2)]  
  
<a name="ImplementingACustomInkCanvas"></a>   
## <a name="implementing-a-custom-inkcanvas"></a>Реализация пользовательского объекта InkCanvas  
 Самый простой способ применения пользовательского <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> и штриха является реализация класса, производного от <xref:System.Windows.Controls.InkCanvas> и использует эти классы. <xref:System.Windows.Controls.InkCanvas> Имеет <xref:System.Windows.Controls.InkCanvas.DynamicRenderer%2A> свойство, которое указывает, каким образом отображается штрих, когда пользователь рисует его.  
  
 Для отображения пользовательских штрихов на <xref:System.Windows.Controls.InkCanvas> выполните следующие действия:  
  
-   Создайте класс, производный от <xref:System.Windows.Controls.InkCanvas>.  
  
-   Назначьте пользовательский <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> для <xref:System.Windows.Controls.InkCanvas.DynamicRenderer%2A?displayProperty=nameWithType> свойство.  
  
-   Переопределите метод <xref:System.Windows.Controls.InkCanvas.OnStrokeCollected%2A> . В этом методе удалите исходный штрих, который был добавлен в InkCanvas. Затем создайте пользовательский штрих, добавьте ее в <xref:System.Windows.Controls.InkCanvas.Strokes%2A> и вызовите базовый класс с новым <xref:System.Windows.Controls.InkCanvasStrokeCollectedEventArgs> , содержащим пользовательский штрих.  
  
 Следующие C# код демонстрирует пользовательский <xref:System.Windows.Controls.InkCanvas> класс, который использует настраиваемый <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> и сбор пользовательских штрихов.  
  
 [!code-csharp[AdvancedInkTopicsSamples#9](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/Window1.xaml.cs#9)]  
  
 <xref:System.Windows.Controls.InkCanvas> Может иметь несколько <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer>. Можно добавить несколько <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> объектов <xref:System.Windows.Controls.InkCanvas> , добавив их в <xref:System.Windows.UIElement.StylusPlugIns%2A> свойство.  
  
<a name="Conclusion"></a>   
## <a name="conclusion"></a>Заключение  
 Можно настроить отображение рукописного фрагмента путем наследования своих собственных <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer>, <xref:System.Windows.Ink.Stroke>, и <xref:System.Windows.Controls.InkCanvas> классы. Вместе эти классы гарантируют согласованность внешнего вида штриха в момент, когда пользователь рисует штрих, и после его сбора.  
  
## <a name="see-also"></a>См. также

- [Дополнительная обработка рукописных данных](advanced-ink-handling.md)

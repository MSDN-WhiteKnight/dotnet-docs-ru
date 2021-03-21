---
title: Практическое руководство. Выбор рукописного ввода из пользовательского элемента управления
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- controls [WPF], ink selection
- ink [WPF], selecting from custom control
- custom controls [WPF], ink selection
ms.assetid: 5f3a45c6-6d40-4017-9b47-933f134ceba3
ms.openlocfilehash: 5c9b2f3d64e4cbb309772d6a1d9fa88f589df84c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59173604"
---
# <a name="how-to-select-ink-from-a-custom-control"></a>Практическое руководство. Выбор рукописного ввода из пользовательского элемента управления
Добавив <xref:System.Windows.Ink.IncrementalLassoHitTester> в элемент управления, вы можете включить элемент управления, чтобы пользователь мог выбрать рукописного ввода с помощью лассо, аналогично тому, как <xref:System.Windows.Controls.InkCanvas> выбирает рукописный ввод с помощью лассо.  
  
 В этом примере предполагается, что вы умеете создавать пользовательский элемент управления, поддержкой рукописного ввода.  Чтобы создать пользовательский элемент управления, который принимает рукописный ввод, см. в разделе [Создание элемента управления рукописным вводом](creating-an-ink-input-control.md).  
  
## <a name="example"></a>Пример  
 Когда пользователь рисует лассо, <xref:System.Windows.Ink.IncrementalLassoHitTester> прогнозирует, какие штрихи будут в пределах границ пути лассо, как только пользователь завершит лассо.  Росчерки, которые определены как в пределах границ пути лассо может рассматриваться как выбранные.  Выделенные штрихи можно также снимается.  Например, если пользователь меняет направление при рисовании лассо <xref:System.Windows.Ink.IncrementalLassoHitTester> может отменить выбор некоторых штрихов.  
  
 <xref:System.Windows.Ink.IncrementalLassoHitTester> Вызывает <xref:System.Windows.Ink.IncrementalLassoHitTester.SelectionChanged> событие, которое позволяет реагировать, пока пользователь рисует лассо пользовательского элемента управления.  Например можно изменить внешний вид штрихов, как пользователь выбирает и снимает выделение с них.  
  
## <a name="managing-the-ink-mode"></a>Управление режимом рукописного ввода  
 Это полезными, если лассо отображается иначе, чем рукописные данные в элемент управления. Для этого пользовательского элемента управления должен хранить список ли пользователь запись или выбрав рукописного ввода. Самый простой способ это сделать, — для объявления перечисления с двумя значениями: один столбец указывает, что пользователь записывает рукописный ввод и один столбец указывает, что пользователь является выбор рукописного ввода.  
  
 [!code-csharp[HowToSelectInk#2](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToSelectInk/CSharp/InkSelector.cs#2)]
   
  
 Добавьте два <xref:System.Windows.Ink.DrawingAttributes> к классу: из них следует использовать, когда пользователь осуществляет рукописный ввод, из них следует использовать, когда пользователь выбирает рукописного ввода.  В конструкторе, инициализировать <xref:System.Windows.Ink.DrawingAttributes> и приложите оба <xref:System.Windows.Ink.DrawingAttributes.AttributeChanged> событий тот же обработчик событий. Затем установите <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer.DrawingAttributes%2A> свойство <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> на рукописный ввод <xref:System.Windows.Ink.DrawingAttributes>.  
  
 [!code-csharp[HowToSelectInk#3](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToSelectInk/CSharp/InkSelector.cs#3)]
   
[!code-csharp[HowToSelectInk#4](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToSelectInk/CSharp/InkSelector.cs#4)]
  
  
 Добавьте свойство, которое предоставляет режим выделения. Когда пользователь изменяет режим выбора, задайте <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer.DrawingAttributes%2A> свойство <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> к соответствующему <xref:System.Windows.Ink.DrawingAttributes> объекта, а затем — <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer.RootVisual%2A> свойства <xref:System.Windows.Controls.InkPresenter>.  
  
 [!code-csharp[HowToSelectInk#5](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToSelectInk/CSharp/InkSelector.cs#5)]
   
  
 Предоставлять <xref:System.Windows.Ink.DrawingAttributes> как свойства, чтобы приложения могли определить внешний вид рукописных штрихов и штрихов выделенного фрагмента.  
  
 [!code-csharp[HowToSelectInk#6](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToSelectInk/CSharp/InkSelector.cs#6)]
   
  
 Когда свойство <xref:System.Windows.Ink.DrawingAttributes> изменения, объекта <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer.RootVisual%2A> необходимо повторно подключить <xref:System.Windows.Controls.InkPresenter>.  В обработчике событий для <xref:System.Windows.Ink.DrawingAttributes.AttributeChanged> событий, снова присоедините <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer.RootVisual%2A> для <xref:System.Windows.Controls.InkPresenter>.  
  
 [!code-csharp[HowToSelectInk#7](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToSelectInk/CSharp/InkSelector.cs#7)]
   
  
## <a name="using-the-incrementallassohittester"></a>С помощью IncrementalLassoHitTester  
 Создание и инициализация <xref:System.Windows.Ink.StrokeCollection> , содержащее выделенные штрихи.  
  
 [!code-csharp[HowToSelectInk#8](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToSelectInk/CSharp/InkSelector.cs#8)]
   
  
 Когда пользователь начинает рисовать штрих, рукописного ввода или Лассо, снимите флажки для всех выделенных штрихов. Затем, если пользователь рисует лассо, создайте <xref:System.Windows.Ink.IncrementalLassoHitTester> путем вызова <xref:System.Windows.Ink.StrokeCollection.GetIncrementalLassoHitTester%2A>, Подпишитесь на <xref:System.Windows.Ink.IncrementalLassoHitTester.SelectionChanged> событий и вызовов <xref:System.Windows.Ink.IncrementalHitTester.AddPoints%2A>. Этот код может быть отдельный метод и вызывать из <xref:System.Windows.UIElement.OnStylusDown%2A> и <xref:System.Windows.UIElement.OnMouseDown%2A> методы.  
  
 [!code-csharp[HowToSelectInk#9](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToSelectInk/CSharp/InkSelector.cs#9)]
   
  
 Добавление точки пера, которые <xref:System.Windows.Ink.IncrementalLassoHitTester> пока пользователь рисует лассо.  Вызовите следующий метод из <xref:System.Windows.UIElement.OnStylusMove%2A>, <xref:System.Windows.UIElement.OnStylusUp%2A>, <xref:System.Windows.UIElement.OnMouseMove%2A>, и <xref:System.Windows.UIElement.OnMouseLeftButtonUp%2A> методы.  
  
 [!code-csharp[HowToSelectInk#10](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToSelectInk/CSharp/InkSelector.cs#10)]
   
  
 Обрабатывать <xref:System.Windows.Ink.IncrementalLassoHitTester.SelectionChanged?displayProperty=nameWithType> событий, чтобы ответить, когда пользователь выбирает и отменяет выделение штрихов.  <xref:System.Windows.Ink.LassoSelectionChangedEventArgs> Класс имеет <xref:System.Windows.Ink.LassoSelectionChangedEventArgs.SelectedStrokes%2A> и <xref:System.Windows.Ink.LassoSelectionChangedEventArgs.DeselectedStrokes%2A> свойства, получающие штрихи, которые были выбраны и не выбрано, соответственно.  
  
 [!code-csharp[HowToSelectInk#11](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToSelectInk/CSharp/InkSelector.cs#11)]
   
  
 Когда пользователь заканчивает рисование лассо, отменить подписку на <xref:System.Windows.Ink.IncrementalLassoHitTester.SelectionChanged> событий и вызовов <xref:System.Windows.Ink.IncrementalHitTester.EndHitTesting%2A>.  
  
 [!code-csharp[HowToSelectInk#12](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToSelectInk/CSharp/InkSelector.cs#12)]
   
  
## <a name="putting-it-all-together"></a>Объединение.  
 Ниже приведен пользовательский элемент управления, позволяющий пользователю выбрать рукописный ввод с помощью лассо.  
  
 [!code-csharp[HowToSelectInk#1](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToSelectInk/CSharp/InkSelector.cs#1)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Ink.IncrementalLassoHitTester>
- <xref:System.Windows.Ink.StrokeCollection>
- <xref:System.Windows.Input.StylusPointCollection>
- [Создание элемента управления рукописным вводом](creating-an-ink-input-control.md)

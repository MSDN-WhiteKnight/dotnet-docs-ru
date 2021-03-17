---
title: Создание элемента управления рукописным вводом
ms.date: 03/30/2017
helpviewer_keywords:
- ink strokes [WPF], managing
- managing ink strokes [WPF]
- ink input control [WPF]
- input from mouse [WPF], accepting
- mouse input [WPF], accepting
- ink [WPF], rendering
- ink strokes [WPF], collecting
- rendering ink [WPF]
- collecting ink strokes [WPF]
- DynamicRenderer objects [WPF]
- StylusPlugIn objects [WPF]
ms.assetid: c31f3a67-cb3f-4ded-af9e-ed21f6575b26
ms.openlocfilehash: 105a44f90c1c654a21fc8920a149ad63b2dabc99
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59323854"
---
# <a name="creating-an-ink-input-control"></a>Создание элемента управления рукописным вводом
Вы можете создать пользовательский элемент управления, динамически и статически отображает рукописные данные. То есть отрисовку рукописных фрагментов, как пользователь рисует штрих, вызывая рукописный ввод «поток» от планшетного пера и отображения рукописного ввода после него добавляется к элементу управления, либо с помощью пера, вставленный из буфера обмена, или загрузить из файла. Для динамического отображения рукописного ввода, необходимо использовать элемент управления <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer>. Для статического отображения рукописного ввода, необходимо переопределить методы событий пера (<xref:System.Windows.UIElement.OnStylusDown%2A>, <xref:System.Windows.UIElement.OnStylusMove%2A>, и <xref:System.Windows.UIElement.OnStylusUp%2A>) для сбора <xref:System.Windows.Input.StylusPoint> данные, создавать штрихи и добавить их в <xref:System.Windows.Controls.InkPresenter> (отображает рукописные данные в элементе управления).  
  
 В этом разделе содержатся следующие подразделы:  
  
-   [Практическое руководство. Сбор данных точек пера и создание рукописных штрихов](#CollectingStylusPointDataAndCreatingInkStrokes)  
  
-   [Практическое руководство. Включить элемент управления принимать ввод от мыши](#EnablingYourControlToAcceptInputTromTheMouse)  
  
-   [Сводная информация](#PuttingItTogether)  
  
-   [С помощью дополнительных подключаемых модулей и DynamicRenderers](#UsingAdditionalPluginsAndDynamicRenderers)  
  
-   [Заключение](#AdvancedInkHandling_Conclusion)  
  
<a name="CollectingStylusPointDataAndCreatingInkStrokes"></a>   
## <a name="how-to-collect-stylus-point-data-and-create-ink-strokes"></a>Практическое руководство. Сбор данных точек пера и создание рукописных штрихов  
 Чтобы создать элемент управления, который собирает и управляет рукописного ввода штрихов сделайте следующее:  
  
1. Наследуйте класс от <xref:System.Windows.Controls.Control> или одного из классов, производный от <xref:System.Windows.Controls.Control>, такие как <xref:System.Windows.Controls.Label>.  
  
     [!code-csharp[AdvancedInkTopicsSamples#20](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/StylusControl.cs#20)]  
    [!code-csharp[AdvancedInkTopicsSamples#14](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/StylusControlSnippets.cs#14)]  
    [!code-csharp[AdvancedInkTopicsSamples#15](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/StylusControlSnippets.cs#15)]  
  
2. Добавить <xref:System.Windows.Controls.InkPresenter> в классе и задайте <xref:System.Windows.Controls.ContentControl.Content%2A> свойство к новому <xref:System.Windows.Controls.InkPresenter>.  
  
     [!code-csharp[AdvancedInkTopicsSamples#16](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/StylusControlSnippets.cs#16)]  
  
3. Присоединение <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer.RootVisual%2A> из <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> для <xref:System.Windows.Controls.InkPresenter> путем вызова <xref:System.Windows.Controls.InkPresenter.AttachVisuals%2A> метод и добавьте <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> для <xref:System.Windows.UIElement.StylusPlugIns%2A> коллекции. Это позволяет <xref:System.Windows.Controls.InkPresenter> отображать рукописные данные по мере сбора данных точек пера элементом управления.  
  
     [!code-csharp[AdvancedInkTopicsSamples#17](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/StylusControlSnippets.cs#17)]  
    [!code-csharp[AdvancedInkTopicsSamples#18](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/StylusControlSnippets.cs#18)]  
  
4. Переопределите метод <xref:System.Windows.UIElement.OnStylusDown%2A> .  В этом методе, захватывающий перо вызовом <xref:System.Windows.Input.Stylus.Capture%2A>. При захвате пера, элемент управления будет продолжать получать <xref:System.Windows.UIElement.StylusMove> и <xref:System.Windows.UIElement.StylusUp> события даже в том случае, если перо покидает границы элемента управления. Это не является строго обязательным, но почти всегда желательно для удобства работы пользователей. Создайте новый <xref:System.Windows.Input.StylusPointCollection> для сбора <xref:System.Windows.Input.StylusPoint> данных. Наконец, добавьте начального набора <xref:System.Windows.Input.StylusPoint> данные <xref:System.Windows.Input.StylusPointCollection>.  
  
     [!code-csharp[AdvancedInkTopicsSamples#7](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/StylusControl.cs#7)]  
  
5. Переопределить <xref:System.Windows.UIElement.OnStylusMove%2A> метод и добавьте <xref:System.Windows.Input.StylusPoint> данные <xref:System.Windows.Input.StylusPointCollection> объект, который был создан ранее.  
  
     [!code-csharp[AdvancedInkTopicsSamples#8](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/StylusControl.cs#8)]  
  
6. Переопределить <xref:System.Windows.UIElement.OnStylusUp%2A> метод и создайте новый <xref:System.Windows.Ink.Stroke> с <xref:System.Windows.Input.StylusPointCollection> данных. Добавьте новые <xref:System.Windows.Ink.Stroke> созданной вами для <xref:System.Windows.Controls.InkPresenter.Strokes%2A> коллекцию <xref:System.Windows.Controls.InkPresenter> и освободить захват пера.  
  
     [!code-csharp[AdvancedInkTopicsSamples#10](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/StylusControl.cs#10)]  
  
<a name="EnablingYourControlToAcceptInputTromTheMouse"></a>   
## <a name="how-to-enable-your-control-to-accept-input-from-the-mouse"></a>Практическое руководство. Включить элемент управления принимать ввод от мыши  
 Если добавить предыдущий элемент управления в приложение, запустите его и использовать мышь в качестве устройства ввода, можно заметить, что штрихов не сохраняются. Для сохранения штрихов, когда указатель мыши используется как устройство ввода сделайте следующее:  
  
1. Переопределить <xref:System.Windows.UIElement.OnMouseLeftButtonDown%2A> и создайте новый <xref:System.Windows.Input.StylusPointCollection> получать положение указателя мыши при происхождении события и создавать <xref:System.Windows.Input.StylusPoint> точки данных и добавьте <xref:System.Windows.Input.StylusPoint> для <xref:System.Windows.Input.StylusPointCollection>.  
  
     [!code-csharp[AdvancedInkTopicsSamples#11](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/StylusControl.cs#11)]  
  
2. Переопределите метод <xref:System.Windows.UIElement.OnMouseMove%2A> . Получите положение указателя мыши при происхождении события и создайте <xref:System.Windows.Input.StylusPoint> с использованием точки данных.  Добавить <xref:System.Windows.Input.StylusPoint> для <xref:System.Windows.Input.StylusPointCollection> объект, который был создан ранее.  
  
     [!code-csharp[AdvancedInkTopicsSamples#12](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/StylusControl.cs#12)]  
  
3. Переопределите метод <xref:System.Windows.UIElement.OnMouseLeftButtonUp%2A> .  Создайте новый <xref:System.Windows.Ink.Stroke> с <xref:System.Windows.Input.StylusPointCollection> данных и добавьте новые <xref:System.Windows.Ink.Stroke> созданной вами для <xref:System.Windows.Controls.InkPresenter.Strokes%2A> коллекцию <xref:System.Windows.Controls.InkPresenter>.  
  
     [!code-csharp[AdvancedInkTopicsSamples#13](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/StylusControl.cs#13)]  
  
<a name="PuttingItTogether"></a>   
## <a name="putting-it-together"></a>Сводная информация  
 Ниже приведен пользовательский элемент управления, сбора данных рукописного ввода при использовании пользователем мыши или пера.  
  
 [!code-csharp[AdvancedInkTopicsSamples#20](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/StylusControl.cs#20)]  
[!code-csharp[AdvancedInkTopicsSamples#6](~/samples/snippets/csharp/VS_Snippets_Wpf/AdvancedInkTopicsSamples/CSharp/StylusControl.cs#6)]  
  
<a name="UsingAdditionalPluginsAndDynamicRenderers"></a>   
## <a name="using-additional-plug-ins-and-dynamicrenderers"></a>С помощью дополнительных подключаемых модулей и DynamicRenderers  
 Как и InkCanvas, пользовательский элемент управления может иметь пользовательские <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn> и дополнительные <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> объектов. Добавить шаблоны в <xref:System.Windows.UIElement.StylusPlugIns%2A> коллекции. Порядок <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn> объекты в <xref:System.Windows.Input.StylusPlugIns.StylusPlugInCollection> влияет на внешний вид рукописного ввода при его отрисовке. Предположим, что у вас есть <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> вызывается `dynamicRenderer` и пользовательское <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn> вызывается `translatePlugin` , offsets рукописный ввод от пера. Если `translatePlugin` является первым <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn> в <xref:System.Windows.Input.StylusPlugIns.StylusPlugInCollection>, и `dynamicRenderer` является вторым, будет смещаться рукописный текст, который «потоки», когда пользователь перемещает перо. Если `dynamicRenderer` является первым, и `translatePlugin` является вторым, не будет смещаться рукописный ввод, пока пользователь отрывает перо.  
  
<a name="AdvancedInkHandling_Conclusion"></a>   
## <a name="conclusion"></a>Заключение  
 Можно создать элемент управления, который собирает и отображает рукописные данные, переопределив методы событий пера. Создав собственный элемент управления, создания своих собственных производных <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn> классы и их вставка в <xref:System.Windows.Input.StylusPlugIns.StylusPlugInCollection>, можно реализовать практически для любых аспектов поведения, возможное сопоставление с рукописный ввод. У вас есть доступ к <xref:System.Windows.Input.StylusPoint> данных, как оно создается, дает возможность настроить <xref:System.Windows.Input.Stylus> входных данных и их вывода на экран, подходящие для вашего приложения. Так как у вас есть такой низкоуровневый доступ к <xref:System.Windows.Input.StylusPoint> данных, можно реализовать коллекцию рукописного ввода и отображать ее с оптимальной производительности приложения.  
  
## <a name="see-also"></a>См. также

- [Дополнительная обработка рукописных данных](advanced-ink-handling.md)
- [Доступ и управление с помощью пера](https://go.microsoft.com/fwlink/?LinkId=50752&clcid=0x409)

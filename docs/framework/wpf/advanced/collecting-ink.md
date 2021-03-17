---
title: Сбора рукописных данных в приложениях WPF
ms.date: 08/15/2018
dev_langs:
- csharp
- vb
helpviewer_keywords:
- ink [WPF], collecting
- InkCanvas element [WPF]
- properties [WPF], DrawingAttributes
- collecting digital ink [WPF]
- digital ink [WPF], collecting
- properties [WPF], DefaultDrawingAttributes
- DefaultDrawingAttributes property [WPF]
ms.assetid: 66a3129d-9577-43eb-acbd-56c147282016
ms.openlocfilehash: 0d0796eae469f8a40e01e3de02c00149eb3f00c7
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57374678"
---
# <a name="collect-ink"></a>Сбора рукописных фрагментов

Платформа [Windows Presentation Foundation](../index.md) выполняет сбор цифровых рукописных фрагментов, что является одной из основных ее функций. В этом разделе обсуждаются методы сбора рукописных данных в Windows Presentation Foundation (WPF).

## <a name="prerequisites"></a>Предварительные требования

Чтобы использовать в следующих примерах, сначала необходимо установить Visual Studio и [!INCLUDE[TLA2#tla_winfxsdk](../../../../includes/tla2sharptla-winfxsdk-md.md)]. Следует также понять, как создавать приложения для WPF. Дополнительные сведения о начале работы с WPF, см. в разделе [Пошаговое руководство: Создание первого классического приложения WPF](../getting-started/walkthrough-my-first-wpf-desktop-application.md).

## <a name="use-the-inkcanvas-element"></a>Использование элемента InkCanvas

<xref:System.Windows.Controls.InkCanvas?displayProperty=fullName> Элемент предоставляет самый простой способ сбора рукописных данных в WPF. Используйте <xref:System.Windows.Controls.InkCanvas> элемент для получения и отображения рукописного ввода. Рукописный ввод, как правило, осуществляется с помощью пера, которое взаимодействует с дигитайзером для создания рукописных штрихов. Кроме того, вместо пера можно использовать мышь. Созданные штрихи представляются в виде <xref:System.Windows.Ink.Stroke> объекты и их можно управлять программно или пользователем ввода данных. <xref:System.Windows.Controls.InkCanvas> Позволяет пользователям выбор, изменение или удаление существующего <xref:System.Windows.Ink.Stroke>.

С помощью XAML, вы можно настроить сбор рукописных фрагментов, просто добавив **InkCanvas** к дереву. В следующем примере добавляется <xref:System.Windows.Controls.InkCanvas> в проект WPF по умолчанию, созданные в Visual Studio:

[!code-xaml[DigitalInkTopics#6](~/samples/snippets/csharp/VS_Snippets_Wpf/DigitalInkTopics/CSharp/Window2.xaml#6)]

**InkCanvas** элемент также может содержать дочерние элементы, что позволяет добавлять функции рукописных заметок практически любого типа элемента XAML. Например, чтобы добавить возможности рукописного ввода в текстовый элемент, просто сделайте его дочерним элементом <xref:System.Windows.Controls.InkCanvas>:

[!code-xaml[DigitalInkTopics#5](~/samples/snippets/csharp/VS_Snippets_Wpf/DigitalInkTopics/CSharp/Window2.xaml#5)]

Добавление поддержки пометки изображений с помощью рукописного ввода выполняется так же просто:

[!code-xaml[DigitalInkTopics#7](~/samples/snippets/csharp/VS_Snippets_Wpf/DigitalInkTopics/CSharp/Window2.xaml#7)]

### <a name="inkcollection-modes"></a>Режимы InkCollection

<xref:System.Windows.Controls.InkCanvas> Обеспечивает поддержку различных режимов ввода с помощью его <xref:System.Windows.Controls.InkCanvas.EditingMode%2A> свойство.

### <a name="manipulate-ink"></a>Рукописным вводом

<xref:System.Windows.Controls.InkCanvas> Обеспечивает поддержку многих операций редактирования рукописных данных. Например <xref:System.Windows.Controls.InkCanvas> стереть поддерживает назад пера, и требуется дополнительный код для добавления функций к элементу.

#### <a name="selection"></a>Выбранное

Установка режима выбора сводится параметр <xref:System.Windows.Controls.InkCanvasEditingMode> свойства **выберите**.

Следующий код устанавливает режим редактирования на основе значения из <xref:System.Windows.Forms.CheckBox>:

[!code-csharp[DigitalInkTopics#8](~/samples/snippets/csharp/VS_Snippets_Wpf/DigitalInkTopics/CSharp/Window1.xaml.cs#8)]
[!code-vb[DigitalInkTopics#8](~/samples/snippets/visualbasic/VS_Snippets_Wpf/DigitalInkTopics/VisualBasic/Window1.xaml.vb#8)]

#### <a name="drawingattributes"></a>DrawingAttributes

Используйте <xref:System.Windows.Ink.Stroke.DrawingAttributes%2A> свойство для изменения внешнего вида рукописных штрихов. Например <xref:System.Windows.Ink.DrawingAttributes.Color%2A> членом <xref:System.Windows.Ink.DrawingAttributes> задает цвет отображаемого объекта <xref:System.Windows.Ink.Stroke>.

В следующем примере изменяется цвет выбранных штрихов на красный:

[!code-csharp[DigitalInkTopics#9](~/samples/snippets/csharp/VS_Snippets_Wpf/DigitalInkTopics/CSharp/Window1.xaml.cs#9)]
[!code-vb[DigitalInkTopics#9](~/samples/snippets/visualbasic/VS_Snippets_Wpf/DigitalInkTopics/VisualBasic/Window1.xaml.vb#9)]

### <a name="defaultdrawingattributes"></a>DefaultDrawingAttributes

<xref:System.Windows.Controls.InkCanvas.DefaultDrawingAttributes%2A> Свойство предоставляет доступ к свойствам, например высоту, ширину и цвет штрихов, создаваемых в <xref:System.Windows.Controls.InkCanvas>. После перевода <xref:System.Windows.Controls.InkCanvas.DefaultDrawingAttributes%2A>, все следующие штрихи, введенные в <xref:System.Windows.Controls.InkCanvas> подготавливаются к просмотру с новыми значениями свойства.

А также изменения <xref:System.Windows.Controls.InkCanvas.DefaultDrawingAttributes%2A> в файле кода, можно использовать синтаксис XAML для указания <xref:System.Windows.Controls.InkCanvas.DefaultDrawingAttributes%2A> свойства.

Далее примере показано, как задать <xref:System.Windows.Ink.DrawingAttributes.Color%2A> свойства. Чтобы использовать этот код, создайте новый проект WPF с именем «HelloInkCanvas» в Visual Studio. Замените код в *MainWindow.xaml* файла следующим кодом:

[!code-xaml[HelloInkCanvas#1](~/samples/snippets/csharp/VS_Snippets_Wpf/HelloInkCanvas/CSharp/Window1.xaml#1)]

Затем добавьте следующие обработчики событий для кнопки в файл кода программной части, внутри класса MainWindow:

[!code-csharp[HelloInkCanvas#2](~/samples/snippets/csharp/VS_Snippets_Wpf/HelloInkCanvas/CSharp/Window1.xaml.cs#2)]

После копирования этого кода нажмите клавишу **F5** в Visual Studio для запуска программы в отладчике.

Обратите внимание, что как <xref:System.Windows.Controls.StackPanel> размещает кнопки вверху <xref:System.Windows.Controls.InkCanvas>. При попытке рукописного ввода поверх кнопок, <xref:System.Windows.Controls.InkCanvas> собирает и отображает рукописные данные позади кнопок. Это обусловлено кнопок являются одноранговыми с <xref:System.Windows.Controls.InkCanvas> в отличие от дочерних элементов. Кроме того, кнопки находятся выше в z-порядке, поэтому рукописные фрагменты отображаются позади них.

## <a name="see-also"></a>См. также

- <xref:System.Windows.Ink.DrawingAttributes>
- <xref:System.Windows.Controls.InkCanvas.DefaultDrawingAttributes%2A>
- <xref:System.Windows.Ink>
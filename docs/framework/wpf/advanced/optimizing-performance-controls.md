---
title: 'Оптимизация производительности: Элементы управления - WPF'
ms.date: 03/30/2017
helpviewer_keywords:
- controls [WPF], improving performance
- container recycling [WPF]
- user interface virtualization [WPF]
ms.assetid: 45a31c43-ea8a-4546-96c8-0631b9934179
ms.openlocfilehash: 20b2b20c2f7f37b4ae01159e70bc8c0945777152
ms.sourcegitcommit: 14355b4b2fe5bcf874cac96d0a9e6376b567e4c7
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 01/30/2019
ms.locfileid: "55286433"
---
# <a name="optimizing-performance-controls"></a>Оптимизация производительности: Элементы управления

Windows Presentation Foundation (WPF) включает множество общих компонентов пользовательского интерфейса (UI), которые используются в большинстве приложений Windows. В этом разделе описываются методы повышения производительности пользовательского интерфейса.

## <a name="displaying-large-data-sets"></a>Отображение больших наборов данных

Элементы управления WPF, такие как <xref:System.Windows.Controls.ListView> и <xref:System.Windows.Controls.ComboBox> используются для отображения списков элементов в приложении. Если отображаемый список большой, это может повлиять на производительность приложения. Причина этого в том, что стандартная система макета создает контейнер макета для каждого элемента, связанного с элементом управления «Список», и вычисляет размер и положение его макета. Как правило, не требуется отображать все элементы одновременно; можно отображать подмножество элементов, и пользователь будет прокручивать список. В этом случае имеет смысл использовать *виртуализацию* пользовательского интерфейса, что означает, что создание контейнера элемента и вычисление связанной разметки для элемента откладывается до тех пор, пока этот элемент не станет видимым.

Виртуализация пользовательского интерфейса является важным аспектом элементов управления «Список». Не следует путать виртуализацию пользовательского интерфейса с виртуализацией данных. Виртуализация пользовательского интерфейса хранит в памяти только видимые элементы, но в сценариях привязки данных хранит в памяти всю структуру данных. В отличие от этого виртуализация данных хранит в памяти только элементы данных, которые отображаются.

По умолчанию Виртуализация пользовательского интерфейса включена для <xref:System.Windows.Controls.ListView> и <xref:System.Windows.Controls.ListBox> элементы управления, если их элементы списка привязаны к данным. <xref:System.Windows.Controls.TreeView> виртуализацию можно включить, задав <xref:System.Windows.Controls.VirtualizingStackPanel.IsVirtualizing%2A?displayProperty=nameWithType> вложенное свойство, чтобы `true`. Если вы хотите включить виртуализацию пользовательского интерфейса для пользовательских элементов управления, которые являются производными от <xref:System.Windows.Controls.ItemsControl> или существующих элементов управления, использующих <xref:System.Windows.Controls.StackPanel> класс, например <xref:System.Windows.Controls.ComboBox>, можно задать <xref:System.Windows.Controls.ItemsControl.ItemsPanel%2A> для <xref:System.Windows.Controls.VirtualizingStackPanel> и задайте <xref:System.Windows.Controls.VirtualizingPanel.IsVirtualizing%2A> для `true`. К сожалению, вы можете отключить виртуализацию пользовательского интерфейса для этих элементов управления, не осознавая этого. Ниже приведен список условий, отключающих виртуализацию пользовательского интерфейса.

- Контейнеры элементов добавляются непосредственно к <xref:System.Windows.Controls.ItemsControl>. Например, если приложение явно добавляет <xref:System.Windows.Controls.ListBoxItem> объектов <xref:System.Windows.Controls.ListBox>, <xref:System.Windows.Controls.ListBox> не виртуализирует <xref:System.Windows.Controls.ListBoxItem> объектов.

- Элемент контейнеров в <xref:System.Windows.Controls.ItemsControl> принадлежат разным типам. Например <xref:System.Windows.Controls.Menu> , использующий <xref:System.Windows.Controls.Separator> объектов не может реализовать повторное использование элементов, так как <xref:System.Windows.Controls.Menu> содержит объекты типа <xref:System.Windows.Controls.Separator> и <xref:System.Windows.Controls.MenuItem>.

- Установка <xref:System.Windows.Controls.ScrollViewer.CanContentScroll%2A> для `false`.

- Установка <xref:System.Windows.Controls.VirtualizingStackPanel.IsVirtualizing%2A> для `false`.

Важным аспектом при виртуализации контейнеров элементов является наличие информации о дополнительном состоянии, связанной с контейнером элемента, принадлежащим этому элементу. В этом случае необходимо сохранить это дополнительное состояние. Например, возможно, элемент, содержащийся в <xref:System.Windows.Controls.Expander> управления и <xref:System.Windows.Controls.Expander.IsExpanded%2A> состоянии привязан к контейнеру элемента, а не сам элемент. Когда контейнер используется повторно для нового элемента, текущее значение <xref:System.Windows.Controls.Expander.IsExpanded%2A> используется для нового элемента. Кроме того, старый элемент теряет правильное <xref:System.Windows.Controls.Expander.IsExpanded%2A> значение.

В настоящее время элементы управления WPF не предоставляют встроенную поддержку виртуализации данных.

## <a name="container-recycling"></a>Повторное использование контейнера

Оптимизация виртуализации пользовательского интерфейса, добавленные в .NET Framework 3.5 SP1 для элементов управления, которые наследуют <xref:System.Windows.Controls.ItemsControl> — *повторное использование контейнера,* также, что может повысить быстродействие прокрутки. Когда <xref:System.Windows.Controls.ItemsControl> , использующий виртуализацию пользовательского интерфейса, заполняется, он создает контейнер для каждого элемента, который попадает в представление и уничтожает контейнеры для каждого элемента, которые не попадают в представление. *Повторное использование контейнера* позволяет элементу управления повторно использовать существующие контейнеры элементов для различных элементов данных, это позволит контейнеры элементов не нужно постоянно создаются и уничтожаются при прокрутке пользователем <xref:System.Windows.Controls.ItemsControl>. Вы можете активировать элемент, установив <xref:System.Windows.Controls.VirtualizingPanel.VirtualizationMode%2A> вложенное свойство, чтобы <xref:System.Windows.Controls.VirtualizationMode.Recycling>.

Любой <xref:System.Windows.Controls.ItemsControl> , поддерживаемые виртуализации можно повторно использовать контейнер. Пример того, как включить повторное использование контейнера на <xref:System.Windows.Controls.ListBox>, см. в разделе [повышения производительности прокрутки ListBox](../controls/how-to-improve-the-scrolling-performance-of-a-listbox.md).

## <a name="supporting-bidirectional-virtualization"></a>Поддержка двунаправленной виртуализации

<xref:System.Windows.Controls.VirtualizingStackPanel> предлагает встроенную поддержку виртуализации пользовательского интерфейса в одном направлении, горизонтально или вертикально. Если вы хотите использовать для элементов управления двунаправленную виртуализацию, необходимо реализовать пользовательскую панель, расширяющую <xref:System.Windows.Controls.VirtualizingStackPanel> класса. <xref:System.Windows.Controls.VirtualizingStackPanel> Класс предоставляет виртуальные методы, такие как <xref:System.Windows.Controls.VirtualizingStackPanel.OnViewportSizeChanged%2A>, <xref:System.Windows.Controls.VirtualizingStackPanel.LineUp%2A>, <xref:System.Windows.Controls.VirtualizingStackPanel.PageUp%2A>, и <xref:System.Windows.Controls.VirtualizingStackPanel.MouseWheelUp%2A>. Эти виртуальные методы позволяют обнаружить изменение в видимой части списка и обработать его соответствующим образом.

## <a name="optimizing-templates"></a>Оптимизация шаблонов

Визуальное дерево содержит все визуальные элементы приложения. В дополнение к непосредственно созданным объектам оно также содержит объекты, возникшие из-за расширения шаблона. Например, при создании <xref:System.Windows.Controls.Button>, вы также получаете <xref:Microsoft.Windows.Themes.ClassicBorderDecorator> и <xref:System.Windows.Controls.ContentPresenter> объектов в визуальном дереве. Без оптимизации шаблонов элементов управления может быть создано большое число дополнительных ненужных объектов в визуальном дереве. Дополнительные сведения см. в разделе [Общие сведения об отрисовке графики в WPF](../graphics-multimedia/wpf-graphics-rendering-overview.md).

## <a name="deferred-scrolling"></a>Отложенная прокрутка

По умолчанию, когда пользователь перетаскивает бегунок в полосе прокрутки, представление содержимого постоянно обновляется. Если скорость прокрутки в элементе управления низкая, рассмотрите возможность использования отложенной прокрутки. При отложенной прокрутке содержимое обновляется только в том случае, когда пользователь отпускает бегунок.

Чтобы реализовать отложенную прокрутку, задайте <xref:System.Windows.Controls.ScrollViewer.IsDeferredScrollingEnabled%2A> свойства `true`. <xref:System.Windows.Controls.ScrollViewer.IsDeferredScrollingEnabled%2A> является присоединенным свойством и может устанавливаться на <xref:System.Windows.Controls.ScrollViewer> и любой элемент управления, имеющий <xref:System.Windows.Controls.ScrollViewer> в своем шаблоне элемента управления.

## <a name="controls-that-implement-performance-features"></a>Элементы управления, реализующие функции производительности

В следующей таблице приведены общие элементы управления для отображения данных и их поддержка функций производительности. Сведения о том, как включать эти функции, см. в предыдущих разделах.

|Элемент управления|Виртуализация|Повторное использование контейнера|Отложенная прокрутка|
|-------------|--------------------|-------------------------|------------------------|
|<xref:System.Windows.Controls.ComboBox>|Можно включить|Можно включить|Можно включить|
|<xref:System.Windows.Controls.ContextMenu>|Можно включить|Можно включить|Можно включить|
|<xref:System.Windows.Controls.DocumentViewer>|Недоступно|Недоступно|Можно включить|
|<xref:System.Windows.Controls.ListBox>|Значение по умолчанию|Можно включить|Можно включить|
|<xref:System.Windows.Controls.ListView>|Значение по умолчанию|Можно включить|Можно включить|
|<xref:System.Windows.Controls.TreeView>|Можно включить|Можно включить|Можно включить|
|<xref:System.Windows.Controls.ToolBar>|Недоступно|Недоступно|Можно включить|

> [!NOTE]
> Пример того, как включить виртуализацию и повторное использование контейнера в <xref:System.Windows.Controls.TreeView>, см. в разделе [повысить производительность элемента управления TreeView](../controls/how-to-improve-the-performance-of-a-treeview.md).

## <a name="see-also"></a>См. также

- [Макет](layout.md)
- [Разметка и разработка](optimizing-performance-layout-and-design.md)
- [Привязка данных](optimizing-performance-data-binding.md)
- [Элементы управления](../controls/index.md)
- [Стилизация и использование шаблонов](../controls/styling-and-templating.md)
- [Пошаговое руководство: Кэширование данных приложения WPF](walkthrough-caching-application-data-in-a-wpf-application.md)
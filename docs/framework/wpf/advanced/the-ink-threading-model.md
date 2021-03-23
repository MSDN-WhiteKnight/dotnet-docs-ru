---
title: Потоковая модель рукописного ввода
ms.date: 03/30/2017
helpviewer_keywords:
- application user interface thread [WPF]
- stylus plug-in
- ink threading model [WPF]
- ink [WPF], rendering
- pen thread [WPF]
- threading model [WPF]
- rendering ink [WPF]
- dynamic rendering thread [WPF]
- ink collection plug-in
- plug-ins [WPF], for ink
ms.assetid: c85fcad1-cb50-4431-847c-ac4145a35c89
ms.openlocfilehash: 80e7ef202c46a23069766512cf4e67bb21a49564
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59335326"
---
# <a name="the-ink-threading-model"></a>Потоковая модель рукописного ввода
Одним из преимуществ рукописного ввода на планшетном ПК является, что его сходство с записи с помощью регулярного пера и бумаги.  В этой ситуации планшетное перо получать входные данные гораздо быстрее мыши и отображает рукописные данные как записи пользователя.  Поток пользовательского интерфейса (UI) приложения недостаточно для сбора данных пера и отрисовка рукописных данных, так как он может быть заблокирован.  Чтобы устранить эту проблему, WPF приложение использует два дополнительных потока, когда пользователь осуществляет рукописный ввод.  
  
 Ниже перечислены потоки, примите участие в сборе и отображении рукописный ввод.  
  
-   Поток пера - поток, который принимает ввод от пера.  (На самом деле это пул потоков, но в этом разделе он называется пуле потоков пера.)  
  
-   Поток пользовательского интерфейса приложения - поток, который определяет пользовательский интерфейс приложения.  
  
-   Поток динамической отрисовки - поток, который отображает рукописные данные при пользователь рисует штрих. Поток динамической отрисовки отличается от потока, отображающего другие элементы пользовательского интерфейса для приложения, как упоминалось в Windows Presentation Foundation [потоковая модель](threading-model.md).  
  
 Модель рукописного ввода совпадает ли приложение использует <xref:System.Windows.Controls.InkCanvas> или пользовательский элемент управления, аналогичный показанному на [Создание элемента управления рукописным ввода](creating-an-ink-input-control.md).  Несмотря на то, что в этом разделе обсуждается создание потоков на основе <xref:System.Windows.Controls.InkCanvas>, те же принципы применяются при создании пользовательского элемента управления.  
  
## <a name="threading-overview"></a>Работа с потоками Обзор  
 На следующей схеме показана модель потоков, когда пользователь рисует штрих:  
  
 ![Потоковая модель во время отрисовки мазка. ](./media/inkthreading-drawingink.png "InkThreading_DrawingInk")  
  
1. Действия, происходящие во время пользователь рисует штрих  
  
    1.  Когда пользователь рисует штрих, точки пера поставляются потоке пера.  Подключаемые модули пера, включая <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer>примите точки пера в потоке пера и иметь возможность изменить их перед <xref:System.Windows.Controls.InkCanvas> их получает.  
  
    2.  <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> Отображает точки пера в поток динамической отрисовки. Это происходит в то же время на предыдущем шаге.  
  
    3.  <xref:System.Windows.Controls.InkCanvas> Получает точки пера в потоке пользовательского интерфейса.  
  
2. Действия, происходящие после пользователь завершает штрих  
  
    1.  Когда пользователь заканчивает рисование штриха, <xref:System.Windows.Controls.InkCanvas> создает <xref:System.Windows.Ink.Stroke> и добавляет его к <xref:System.Windows.Controls.InkPresenter>, который статически его отображает.  
  
    2.  Поток пользовательского интерфейса оповещает <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> , статически выполняется отрисовка росчерка пера, поэтому <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> удаляет его визуальное представление штриха.  
  
## <a name="ink-collection-and-stylus-plug-ins"></a>Сбор рукописных фрагментов и подключаемых модулей пера  
 Каждый <xref:System.Windows.UIElement> имеет <xref:System.Windows.Input.StylusPlugIns.StylusPlugInCollection>.  <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn> Объекты в <xref:System.Windows.Input.StylusPlugIns.StylusPlugInCollection> получать и изменять точки пера в потоке пера. <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn> Объекты получают точки пера, в соответствии с их порядок в <xref:System.Windows.Input.StylusPlugIns.StylusPlugInCollection>.  
  
 На следующей схеме показана гипотетическую ситуацию где <xref:System.Windows.UIElement.StylusPlugIns%2A> коллекцию <xref:System.Windows.UIElement> содержит `stylusPlugin1`, <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer>, и `stylusPlugin2`в этом порядке.  
  
 ![Порядок модулей пера влияет на выходные данные. ](./media/inkthreading-pluginorder.png "InkThreading_PluginOrder")  
  
 На предыдущей диаграмме происходит следующее поведение:  
  
1. `StylusPlugin1` изменения значений x и y.  
  
2. <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> Получает измененные точки пера и отображает их в поток динамической отрисовки.  
  
3. `StylusPlugin2` Получает измененные точки пера и дальнейшие изменения значений x и y.  
  
4. Приложение собирает точки пера и, когда пользователь заканчивает штриха, статически отображает штрих.  
  
 Предположим, что `stylusPlugin1` ограничивает точки пера в прямоугольник и `stylusPlugin2` переносит точки пера вправо.  В приведенном выше сценарии <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> принимает ограниченные, но не перенесенные точки пера.  Когда пользователь рисует штрих, выполняется отрисовка росчерка пера в границах прямоугольника, но он не доступен для перевода, пока пользователь отрывает перо.  
  
### <a name="performing-operations-with-a-stylus-plug-in-on-the-ui-thread"></a>Выполнение операций с помощью пера, подключаемый модуль, в потоке пользовательского интерфейса  
 Так как точные попадания не может выполняться в потоке пера, некоторые элементы могут иногда получать пера, предназначенный для других элементов. Если требуется, чтобы убедиться в том, правильно направлен входных данных перед выполнением операции, подписаться на и выполнить операцию в <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn.OnStylusDownProcessed%2A>, <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn.OnStylusMoveProcessed%2A>, или <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn.OnStylusUpProcessed%2A> метод. Эти методы вызываются потоком приложения после точной проверки нажатия. Чтобы подписаться на эти методы, вызов <xref:System.Windows.Input.StylusPlugIns.RawStylusInput.NotifyWhenProcessed%2A> метод в методе, который генерируется в потоке пера.  
  
 На следующей схеме показана связь между потоком пера и поток пользовательского интерфейса по отношению к событиям пера <xref:System.Windows.Input.StylusPlugIns.StylusPlugIn>.  
  
 ![Потоковые модели рукописного ввода &#40;пользовательский Интерфейс и перо&#41;](./media/inkthreading-plugincallbacks.png "InkThreading_PluginCallbacks")  
  
## <a name="rendering-ink"></a>Отрисовка рукописных данных  
 Когда пользователь рисует штрих, <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> отображает рукописные данные в отдельном потоке, поэтому данные для «поток» от пера даже в том случае, если поток пользовательского интерфейса занят.  <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> Строит визуальное дерево на поток динамической отрисовки, так как он собирает точки пера.  Когда пользователь заканчивает штриха, <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> запрашивает получать уведомления, когда приложение выполняет следующего прохода отрисовки.  После следующего прохода отрисовки, завершения работы приложения <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> очищает его визуального дерева.  Следующая диаграмма иллюстрирует этот процесс.  
  
 ![Рукописный ввод, схема потоков](./media/inkthreading-visualtree.png "InkThreading_VisualTree")  
  
1. Пользователь начинает штриха.  
  
    1.  <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> Создает визуальное дерево.  
  
2. Пользователь рисует штрих.  
  
    1.  <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> Строит визуальное дерево.  
  
3. Пользователь завершает штриха.  
  
    1.  <xref:System.Windows.Controls.InkPresenter> Добавляет штрих в визуальном дереве.  
  
    2.  Уровень интеграции мультимедиа (MIL) статически отображает штрихи.  
  
    3.  <xref:System.Windows.Input.StylusPlugIns.DynamicRenderer> Очищает визуальные элементы.

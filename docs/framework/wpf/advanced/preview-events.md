---
title: События предварительного просмотра
ms.date: 03/30/2017
helpviewer_keywords:
- Preview events [WPF]
- suppressing events [WPF]
- events [WPF], Preview
- events [WPF], suppressing
ms.assetid: b5032308-aa9c-4d02-af11-630ecec8df7e
ms.openlocfilehash: 75165df94aa8b508ef85cf970933efb98b9d62ca
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59211402"
---
# <a name="preview-events"></a>События предварительного просмотра
События предварительного просмотра, также известный как события, нисходящей маршрутизации – это маршрутизированные события, где направление маршрута перемещается из корня приложения в сторону элемента, вызвавшего событие оно выводится как источник в данных события. Не для всех сценариев события поддержки или требования события предварительного просмотра; в этом разделе описываются ситуации, где существуют события предварительного просмотра, как приложений или компонентов, их обработки, и случаи, где Создание события предварительного просмотра в пользовательских компонентов или классов можно использовать.  
  
## <a name="preview-events-and-input"></a>События предварительного просмотра и входных данных  
 При обработке событий в общем случае будьте осторожны при предварительной версии пометки события обработки событий данных. Обработка события предварительного просмотра для любого элемента, отличные от элемента, вызвавшего его (элемент, который передается в качестве источника данных события) имеет возможность обработать событие, которое они были созданы не предоставления элемента. Иногда это нужного результата, особенно в том случае, если существуют указанные элементы в с компоновкой элемента управления.  
  
 Для событий ввода в частности, события предварительного просмотра также предоставлять экземпляров данных событий с помощью эквивалентных событий восходящей маршрутизации. При использовании класса обработчика просмотра событий для пометки входного события как обработанного обработчика класса входного события восходящей маршрутизации не будет вызываться. Или, если вы используете экземпляр обработчика просмотра событий чтобы пометить событие как обработанное, обработчики для событий восходящей маршрутизации будет обычно не вызываются. Обработчики классов или обработчиков экземпляров может быть зарегистрирован или присоединены с возможностью вызываемого даже если событие помечено как обработанное, но этот метод обычно не используется.  
  
 Дополнительные сведения об обработке классов и его связь с события предварительного просмотра см. в разделе [маркировка перенаправленных событий как обработанных и обработка классов](marking-routed-events-as-handled-and-class-handling.md).  
  
### <a name="working-around-event-suppression-by-controls"></a>Обход скрытия события элементами управления  
 Один сценарий, где обычно используются события предварительного просмотра предназначен для обработки событий ввода составной элемент управления. В некоторых случаях разработчик элемента управления подавляет некоторые события от прежнего из их контроля, возможно, чтобы заменить на определяемое компонентом событие, которое содержит дополнительные сведения или подразумевает более конкретное поведение. Например Windows Presentation Foundation (WPF) <xref:System.Windows.Controls.Button> подавляет <xref:System.Windows.UIElement.MouseLeftButtonDown> и <xref:System.Windows.UIElement.MouseRightButtonDown> восходящей маршрутизации событий, вызванных <xref:System.Windows.Controls.Button> или его составными элементами для регистрации действий мыши и вызов <xref:System.Windows.Controls.Primitives.ButtonBase.Click> событие, которое вызывается всегда <xref:System.Windows.Controls.Button> сам. События и его данные по-прежнему в маршруте, но так как <xref:System.Windows.Controls.Button> помечает данные событий в виде <xref:System.Windows.RoutedEventArgs.Handled%2A>, только обработчики для событий, в которых явно указана, они должны работать в `handledEventsToo` вызываются.  Если другие элементы к корню приложения по-прежнему требуется возможность обработать событие запрещенное элемента управления, альтернативой является присоединение обработчиков в коде с помощью `handledEventsToo` указанный в виде `true`. Однако часто более простой способ изменить направление маршрутизации, обрабатывать события ввода эквивалентом предварительной версии. Например если элемент управления подавляет <xref:System.Windows.UIElement.MouseLeftButtonDown>, попробуйте присоединения обработчика для <xref:System.Windows.UIElement.PreviewMouseLeftButtonDown> вместо этого. Этот метод подходит только для событий ввода базовых элементов например <xref:System.Windows.UIElement.MouseLeftButtonDown>. Эти входные события используют пары нисходящей и восходящей, вызовет оба события и совместно использовать данные события.  
  
 Каждый из этих методов имеет побочные эффекты или ограничения. Побочный эффект — обработка события предварительного просмотра является обработка события в этот момент может отключить обработчики, которые должны обрабатывать событие восходящей маршрутизации, что таким образом ограничение — это обычно не рекомендуется пометить событие как обработанное, хотя по-прежнему Previ новые возможности часть маршрута. Ограничение `handledEventsToo` бывает, что нельзя указать `handledEventsToo` обработчик в XAML как атрибут, необходимо зарегистрировать обработчик событий в коде после получения ссылку на элемент, где должен быть связан обработчик.  
  
## <a name="see-also"></a>См. также

- [Маркировка перенаправленных событий как обработанных и обработка классов](marking-routed-events-as-handled-and-class-handling.md)
- [Общие сведения о перенаправленных событиях](routed-events-overview.md)

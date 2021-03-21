---
title: Практическое руководство. Добавление обработки классов для перенаправленных событий
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- routed events [WPF], class handlers
- task_core_add_class_handling_routed_properties [WPF]
- class handlers [WPF], routed events
ms.assetid: 15b7b06c-9112-4ee5-b30a-65d10c5c5df6
ms.openlocfilehash: 7b897954cbdab461dc0305c6290e67c1af5282c3
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59224277"
---
# <a name="how-to-add-class-handling-for-a-routed-event"></a>Практическое руководство. Добавление обработки классов для перенаправленных событий
Перенаправленные события могут быть обработаны с помощью обработчики классов или экземпляров на заданного узла в маршруте. Обработчики классов вызываются первыми, а также может использоваться реализациями класса для подавления событий обработчиков экземпляров или введения вариантов поведения других событий для события, которые принадлежат базовых классов. В этом примере показаны два тесно связанные методы для реализации обработчиков класса.  
  
## <a name="example"></a>Пример  
 В этом примере пользовательский класс, основанный на <xref:System.Windows.Controls.Canvas> панели. Основной замысел приложения является то, что пользовательский класс представляет поведение его дочерних элементов, включая перехват, нажатии любой кнопки мыши и маркировки, их обработки, прежде чем будет вызван дочернего элемента класса или любого обработчика экземпляров на нем.  
  
 <xref:System.Windows.UIElement> Класс предоставляет виртуальный метод, позволяющий обработки класса в <xref:System.Windows.UIElement.PreviewMouseLeftButtonDown> событие, просто переопределив метод события. Это самый простой способ реализовать обработку класса, если виртуальный метод доступен где-то в иерархии класса. В следующем коде показан <xref:System.Windows.UIElement.OnPreviewMouseLeftButtonDown%2A> реализацию в «MyEditContainer», который является производным от <xref:System.Windows.Controls.Canvas>. Реализация помечает событие как обработанное в аргументах, а затем добавляет часть кода для предоставления основное видимое изменение исходного элемента.  
  
 [!code-csharp[ClassHandling#OnStarClassHandler](~/samples/snippets/csharp/VS_Snippets_Wpf/ClassHandling/CSharp/SDKSampleLibrary/class1.cs#onstarclasshandler)]
   
  
 Если нет виртуальных базовых классов или для этого конкретного метода, обработка класса можно добавить непосредственно с помощью служебной программы метод <xref:System.Windows.EventManager> класса <xref:System.Windows.EventManager.RegisterClassHandler%2A>. Этот метод должен вызываться только внутри статической инициализации классов, которые используют обработку классов. В этом примере добавляется еще один обработчик для <xref:System.Windows.UIElement.PreviewMouseLeftButtonDown> , и в этом случае зарегистрированный класс является пользовательским классом. Напротив, при использовании виртуальных методов, зарегистрированный класс является <xref:System.Windows.UIElement> базового класса. В случаях, где базовых классов и подклассов зарегистрировать обработку класса обработчики подклассов вызываются первыми. Поведение в приложении бы, что сначала этот обработчик отобразит окно сообщения, а затем будет показано визуальное изменение в обработчике виртуального метода.  
  
 [!code-csharp[ClassHandling#StaticAndRegisterClassHandler](~/samples/snippets/csharp/VS_Snippets_Wpf/ClassHandling/CSharp/SDKSampleLibrary/class1.cs#staticandregisterclasshandler)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.EventManager>
- [Маркировка перенаправленных событий как обработанных и обработка классов](marking-routed-events-as-handled-and-class-handling.md)
- [Обработка перенаправленных событий](how-to-handle-a-routed-event.md)
- [Общие сведения о перенаправленных событиях](routed-events-overview.md)

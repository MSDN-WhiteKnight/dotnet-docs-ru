---
title: Практическое руководство. Поиск элемента источника в обработчике событий
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- source element in event handlers [WPF]
- event handlers [WPF], finding source element in
ms.assetid: 85f71c5a-b714-4c65-9711-7d905c2bbe98
ms.openlocfilehash: 9a49878c9ad8313903df4506796998fd43e2e749
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59104563"
---
# <a name="how-to-find-the-source-element-in-an-event-handler"></a>Практическое руководство. Поиск элемента источника в обработчике событий
В этом примере показано, как поиск элемента источника в обработчике событий.  
  
## <a name="example"></a>Пример  
 В следующем примере показан <xref:System.Windows.Controls.Primitives.ButtonBase.Click> обработчик событий, который объявлен в файле кода. Когда пользователь щелкает кнопку, чтобы присоединен обработчик, обработчик изменяет значение свойства. В коде обработчика используется <xref:System.Windows.RoutedEventArgs.Source%2A> свойство, указанное в отчетах в аргументах событий для изменения данных перенаправленное событие <xref:System.Windows.FrameworkElement.Width%2A> значение свойства на <xref:System.Windows.RoutedEventArgs.Source%2A> элемент.  
  
 [!code-xaml[RoutedEventSource#XAMLHandler](~/samples/snippets/csharp/VS_Snippets_Wpf/RoutedEventSource/CSharp/default.xaml#xamlhandler)]  
  
 [!code-csharp[RoutedEventSource#Handler](~/samples/snippets/csharp/VS_Snippets_Wpf/RoutedEventSource/CSharp/default.xaml.cs#handler)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.RoutedEventArgs>
- [Общие сведения о перенаправленных событиях](routed-events-overview.md)
- [Практические руководства](events-how-to-topics.md)

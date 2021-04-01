---
title: Практическое руководство. Добавление обработчика событий с помощью кода
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- event handlers [WPF], adding
- XAML [WPF], adding event handlers
ms.assetid: 269c61e0-6bd9-4291-9bed-1c5ee66da486
ms.openlocfilehash: 10f8e0899e61d5d54589c910bdcbcd92d8ee947c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59129367"
---
# <a name="how-to-add-an-event-handler-using-code"></a>Практическое руководство. Добавление обработчика событий с помощью кода
В этом примере показано, как добавить обработчик событий к элементу с помощью кода.  
  
 Если вы хотите добавить обработчик событий к XAML элемент и разметка страницы, которая содержит элемент уже был загружен, необходимо добавить обработчик с помощью кода. Кроме того Если вы создаете вверх по дереву элементов, для приложения, используя только код и не объявляет никаких элементов, используя XAML, можно вызывать методы, определенные для добавления обработчиков событий в построенное дерево элементов.  
  
## <a name="example"></a>Пример  
 В следующем примере добавляется новый <xref:System.Windows.Controls.Button> на существующую страницу, которая изначально определена в XAML. Файл с выделенным кодом реализует метод обработчика событий и добавляет этот метод как новый обработчик событий на <xref:System.Windows.Controls.Button>.  
  
 C# Примере `+=` оператор присвоения обработчика события. Это тот же оператор, который используется для назначения обработчика в [!INCLUDE[TLA#tla_clr](../../../../includes/tlasharptla-clr-md.md)] модели обработки событий. Microsoft Visual Basic не поддерживает этот оператор как средства для добавления обработчиков событий. Вместо этого требуется один из двух способов:  
  
-   Используйте <xref:System.Windows.UIElement.AddHandler%2A> метод совместно с `AddressOf` оператор, для ссылки на реализацию обработчика событий.  
  
-   Используйте `Handles` ключевое слово как часть определения обработчика событий. Этот способ не показан здесь. см. в разделе [Visual Basic и обработка событий WPF](visual-basic-and-wpf-event-handling.md).  
  
 [!code-xaml[RoutedEventAddRemoveHandler#XAML](~/samples/snippets/csharp/VS_Snippets_Wpf/RoutedEventAddRemoveHandler/CSharp/default.xaml#xaml)]  
  
 [!code-csharp[RoutedEventAddRemoveHandler#Handler](~/samples/snippets/csharp/VS_Snippets_Wpf/RoutedEventAddRemoveHandler/CSharp/default.xaml.cs#handler)]
   
  
> [!NOTE]
>  Добавление обработчика событий в изначально разобранную XAML страницы намного проще. В элементе объекта, где вы хотите добавить обработчик событий добавьте атрибут, который совпадает с именем события, которое необходимо обработать. Затем укажите значение этого атрибута в качестве имени метода обработчика событий, определенные в файле кода программной XAML страницы. Дополнительные сведения см. в разделе [Обзор XAML (WPF)](xaml-overview-wpf.md) или [Routed Events Overview](routed-events-overview.md).  
  
## <a name="see-also"></a>См. также

- [Общие сведения о перенаправленных событиях](routed-events-overview.md)
- [Практические руководства](events-how-to-topics.md)

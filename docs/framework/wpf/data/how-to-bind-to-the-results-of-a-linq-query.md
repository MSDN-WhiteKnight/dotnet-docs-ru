---
title: Практическое руководство. Привязка к результатам запроса LINQ
ms.date: 03/30/2017
helpviewer_keywords:
- running a LINQ query [WPF], bind to results
- binding to LINQ query results [WPF]
ms.assetid: ff2844d9-17ed-4ea6-aab1-5111af0bc684
ms.openlocfilehash: 5464ee9c59a7c99a83774a7535b9b3c422c1d2e1
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59185904"
---
# <a name="how-to-bind-to-the-results-of-a-linq-query"></a>Практическое руководство. Привязка к результатам запроса LINQ
В этом примере показано, как выполнить запрос LINQ, а затем привязать к результатам.  
  
## <a name="example"></a>Пример  
 В следующем примере создается два окна. Первый список содержит три элемента списка.  
  
 [!code-xaml[LinqExample#UI](~/samples/snippets/csharp/VS_Snippets_Wpf/LinqExample/CSharp/Window1.xaml#ui)]  
  
 Выбор элемента из первого списка вызывает следующий обработчик событий. В этом примере `Tasks` — это коллекция `Task` объектов. `Task` Класс имеет свойство с именем `Priority`. Этот обработчик событий запускает запрос LINQ, возвращающий коллекцию `Task` объекты, которые имеют значение выбранного приоритета, а затем устанавливает его в качестве <xref:System.Windows.FrameworkElement.DataContext%2A>:  
  
 [!code-csharp[LinqExample#Using](~/samples/snippets/csharp/VS_Snippets_Wpf/LinqExample/CSharp/Window1.xaml.cs#using)]  
[!code-csharp[LinqExample#Tasks](~/samples/snippets/csharp/VS_Snippets_Wpf/LinqExample/CSharp/Window1.xaml.cs#tasks)]  
[!code-csharp[LinqExample#Handler](~/samples/snippets/csharp/VS_Snippets_Wpf/LinqExample/CSharp/Window1.xaml.cs#handler)]  
  
 Второй список привязывается к этой коллекции, так как его <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A> имеет значение `{Binding}`. Таким образом, он отображает возвращаемой коллекции (на основе `myTaskTemplate`<xref:System.Windows.DataTemplate>).  
  
## <a name="see-also"></a>См. также

- [Обеспечение доступности данных для привязки в XAML](how-to-make-data-available-for-binding-in-xaml.md)
- [Привязка к коллекции и вывод сведений в зависимости от выделенного элемента](how-to-bind-to-a-collection-and-display-information-based-on-selection.md)
- [Новые возможности WPF версии 4.5](../getting-started/whats-new.md)
- [Общие сведения о привязке данных](data-binding-overview.md)
- [Практические руководства](data-binding-how-to-topics.md)

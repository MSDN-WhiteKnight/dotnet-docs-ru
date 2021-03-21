---
title: Практическое руководство. Обработка перенаправленных событий
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- routed events [WPF], handling
- bubbling events [WPF]
ms.assetid: 157787b4-f469-4047-8777-5b034145f32e
ms.openlocfilehash: edb3d6724af89b7e85986c50b579084e3c4e5070
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59211599"
---
# <a name="how-to-handle-a-routed-event"></a>Практическое руководство. Обработка перенаправленных событий
В этом примере показаны принципы работы восходящей маршрутизации событий и создания обработчика, который может обрабатывать данные перенаправленных событий.  
  
## <a name="example"></a>Пример  
 В [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] элементы упорядочены в структуру типа "дерево элементов". Родительский элемент может участвовать в обработке событий, которые изначально вызываются его дочерними элементами в дереве элементов. Это становится возможным из-за маршрутизации событий.  
  
 Перенаправленные события обычно обрабатываются с использованием одной из двух стратегий маршрутизации: восходящей или нисходящей. В этом примере рассматривается событие восходящей маршрутизации и использует <xref:System.Windows.Controls.Primitives.ButtonBase.Click?displayProperty=nameWithType> событие, чтобы показать, как работает маршрутизация.  
  
 В следующем примере создается два <xref:System.Windows.Controls.Button> определяет и использует [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] синтаксис для присоединения обработчика событий к стандартному родительскому элементу, который в данном примере — атрибута <xref:System.Windows.Controls.StackPanel>. Вместо того чтобы прикреплять отдельные обработчики событий для каждого <xref:System.Windows.Controls.Button> дочерний элемент, в примере используется синтаксис атрибутов для прикрепления обработчика событий к <xref:System.Windows.Controls.StackPanel> родительского элемента. Этот шаблон обработки событий показывает, как использовать маршрутизацию событий в качестве техники для уменьшения количества элементов, к которым прикреплен обработчик. Все события восходящей маршрутизации для каждого <xref:System.Windows.Controls.Button> маршрутов через родительский элемент.  
  
 Обратите внимание, что в родительском <xref:System.Windows.Controls.StackPanel> элемент, <xref:System.Windows.Controls.Primitives.ButtonBase.Click> имя события, указанные в виде атрибута, частично определяется путем именования <xref:System.Windows.Controls.Button> класса. <xref:System.Windows.Controls.Button> Класс является <xref:System.Windows.Controls.Primitives.ButtonBase> производным классом, имеющим <xref:System.Windows.Controls.Primitives.ButtonBase.Click> событие в списке его участников. Необходимо использовать этот метод частичного определения для прикрепления обработчика событий, если обрабатываемое событие не существует в списке участников элемента, к которому прикреплен обработчик перенаправленного события.  
  
 [!code-xaml[RoutedEventHandle#XAML](~/samples/snippets/csharp/VS_Snippets_Wpf/RoutedEventHandle/CSharp/default.xaml#xaml)]  
  
 В следующем примере показана обработка <xref:System.Windows.Controls.Primitives.ButtonBase.Click> событий.  В этом примере сообщается, какой элемент обрабатывает событие, а какой — вызывает. Обработчик событий выполняется, когда пользователь нажимает одну из кнопок.  
  
 [!code-csharp[RoutedEventHandle#Handler](~/samples/snippets/csharp/VS_Snippets_Wpf/RoutedEventHandle/CSharp/default.xaml.cs#handler)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.RoutedEvent>
- [Общие сведения о входных данных](input-overview.md)
- [Общие сведения о перенаправленных событиях](routed-events-overview.md)
- [Практические руководства](events-how-to-topics.md)
- [Подробное описание синтаксиса XAML](xaml-syntax-in-detail.md)

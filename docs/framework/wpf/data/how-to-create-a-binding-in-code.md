---
title: Практическое руководство. Создание привязки в коде
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- binding data [WPF], creating
- data binding [WPF], creating
ms.assetid: 1a606db9-cf5f-42ed-a1c5-9e4722ec77a0
ms.openlocfilehash: 57ec845c5c9a5bddb801428b9ecde035a97cf447
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59089267"
---
# <a name="how-to-create-a-binding-in-code"></a>Практическое руководство. Создание привязки в коде
В этом примере показано, как создать и задать <xref:System.Windows.Data.Binding> в коде.  
  
## <a name="example"></a>Пример  
 <xref:System.Windows.FrameworkElement> Класс и <xref:System.Windows.FrameworkContentElement> предоставляют `SetBinding` метод. При привязке элемента, наследующего от любого из этих классов, можно вызвать <xref:System.Windows.FrameworkElement.SetBinding%2A> метод напрямую.  
  
 В следующем примере создается класс с именем, `MyData`, который содержит свойство с именем `MyDataProperty`.  
  
 [!code-csharp[CodeOnlyBinding#DataObject](~/samples/snippets/csharp/VS_Snippets_Wpf/CodeOnlyBinding/CSharp/MyData.cs#dataobject)]
 [!code-vb[CodeOnlyBinding#DataObject](~/samples/snippets/visualbasic/VS_Snippets_Wpf/CodeOnlyBinding/VisualBasic/MyData.vb#dataobject)]  
  
 Приведенный ниже показано, как создать объект binding, чтобы указать источник привязки.  В примере используется <xref:System.Windows.FrameworkElement.SetBinding%2A> для привязки <xref:System.Windows.Controls.TextBlock.Text%2A> свойство `myText`, который является <xref:System.Windows.Controls.TextBlock> определяют, к `MyDataProperty`.  
  
 [!code-csharp[CodeOnlyBinding#1](~/samples/snippets/csharp/VS_Snippets_Wpf/CodeOnlyBinding/CSharp/binding.cs#1)]
 [!code-vb[CodeOnlyBinding#1](~/samples/snippets/visualbasic/VS_Snippets_Wpf/CodeOnlyBinding/VisualBasic/App.vb#1)]  
  
 Полный пример кода, см. в разделе [только код пример привязки](https://docs.microsoft.com/previous-versions/dotnet/netframework-3.5/ms771500(v=vs.90)).  
  
 Вместо вызова метода <xref:System.Windows.FrameworkElement.SetBinding%2A>, можно использовать <xref:System.Windows.Data.BindingOperations.SetBinding%2A> статический метод <xref:System.Windows.Data.BindingOperations> класса. Следующий пример, вызовы <xref:System.Windows.Data.BindingOperations.SetBinding%2A?displayProperty=nameWithType> вместо <xref:System.Windows.FrameworkElement.SetBinding%2A?displayProperty=nameWithType> для привязки `myText` для `myDataProperty`.  
  
 [!code-csharp[CodeOnlyBinding#BOSetBinding](~/samples/snippets/csharp/VS_Snippets_Wpf/CodeOnlyBinding/CSharp/binding.cs#bosetbinding)]
 [!code-vb[CodeOnlyBinding#BOSetBinding](~/samples/snippets/visualbasic/VS_Snippets_Wpf/CodeOnlyBinding/VisualBasic/App.vb#bosetbinding)]  
  
## <a name="see-also"></a>См. также

- [Общие сведения о привязке данных](data-binding-overview.md)
- [Практические руководства](data-binding-how-to-topics.md)

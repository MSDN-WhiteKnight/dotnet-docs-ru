---
title: Практическое руководство. Очистка привязок
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- bindings [WPF], clearing
- clearing bindings [WPF]
- data binding [WPF], clearing bindings
ms.assetid: 73962a93-32a9-4bcd-9240-bcfbb239093a
ms.openlocfilehash: 8140928d44555e399ddf4ebd73407a251ad3cffe
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59101423"
---
# <a name="how-to-clear-bindings"></a>Практическое руководство. Очистка привязок
В этом примере показано, как удалять привязки к объекту.  
  
## <a name="example"></a>Пример  
 Чтобы удалить привязку из отдельного свойства объекта, вызовите <xref:System.Windows.Data.BindingOperations.ClearBinding%2A> как показано в следующем примере. Следующий пример удаляет привязку из <xref:System.Windows.Controls.TextBlock.TextProperty> из *mytext*, <xref:System.Windows.Controls.TextBlock> объекта.  
  
 [!code-csharp[CodeOnlyBinding#ClearBinding](~/samples/snippets/csharp/VS_Snippets_Wpf/CodeOnlyBinding/CSharp/binding.cs#clearbinding)]
   
  
 Очистка привязки удаляет привязку так, что значение свойства зависимостей изменяется на то значение, которое было бы без привязки. Это значение может быть значением по умолчанию, унаследованным или значением из привязки шаблона данных.  
  
 Чтобы удалить привязки из всех возможных свойств объекта, используйте <xref:System.Windows.Data.BindingOperations.ClearAllBindings%2A>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Data.BindingOperations>
- [Общие сведения о привязке данных](data-binding-overview.md)
- [Практические руководства](data-binding-how-to-topics.md)

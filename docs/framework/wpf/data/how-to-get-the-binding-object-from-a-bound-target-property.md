---
title: Практическое руководство. Получение объекта привязки из свойства целевого объекта привязки
ms.date: 03/30/2017
helpviewer_keywords:
- data binding [WPF], getting binding objects from bound target properties
- properties [WPF], getting binding objects from
ms.assetid: 87974c5f-136b-4de7-b07d-9285b62ab123
ms.openlocfilehash: 7c7392bc11af57b2e9f27e2302f36efb59d40e9d
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59083118"
---
# <a name="how-to-get-the-binding-object-from-a-bound-target-property"></a>Практическое руководство. Получение объекта привязки из свойства целевого объекта привязки
В этом примере показано, как получить объект привязки из свойства целевого связанного объекта.  
  
## <a name="example"></a>Пример  
 Можно выполнить следующую команду, чтобы получить <xref:System.Windows.Data.Binding> объекта:  
  
 [!code-csharp[BindValidation#GetBinding](~/samples/snippets/csharp/VS_Snippets_Wpf/BindValidation/CSharp/Window1.xaml.cs#getbinding)]  
  
> [!NOTE]
>  Необходимо указать свойство зависимости для необходимой привязки, поскольку возможно, что привязка данных используется в нескольких (а не в одном) свойствах целевого объекта.  
  
 Кроме того, можно получить <xref:System.Windows.Data.BindingExpression> , а затем получите значение <xref:System.Windows.Data.BindingExpression.ParentBinding%2A> свойства.  
  
 Полный пример см. в разделе [Пример проверки привязки](https://go.microsoft.com/fwlink/?LinkID=159972).  
  
> [!NOTE]
>  Если привязка представляет <xref:System.Windows.Data.MultiBinding>, использовать <xref:System.Windows.Data.BindingOperations>.<xref:System.Windows.Data.BindingOperations.GetMultiBinding%2A>. Если это <xref:System.Windows.Data.PriorityBinding>, использовать <xref:System.Windows.Data.BindingOperations>.<xref:System.Windows.Data.BindingOperations.GetPriorityBinding%2A>. Если вы не уверены, привязке целевого свойства с помощью <xref:System.Windows.Data.Binding>, <xref:System.Windows.Data.MultiBinding>, или <xref:System.Windows.Data.PriorityBinding>, можно использовать <xref:System.Windows.Data.BindingOperations>.<xref:System.Windows.Data.BindingOperations.GetBindingBase%2A>.  
  
## <a name="see-also"></a>См. также

- [Создание привязки в коде](how-to-create-a-binding-in-code.md)
- [Практические руководства](data-binding-how-to-topics.md)

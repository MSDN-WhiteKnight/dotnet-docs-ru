---
title: Практическое руководство. Определение фиксации объекта Freezable
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Freezable objects [WPF], determining if frozen
ms.assetid: 92e58baa-ee12-4a9e-ac3a-ca458807a8b2
ms.openlocfilehash: 6a63862d35f2c40289ea6445eb3dab8a2abe4a61
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59197065"
---
# <a name="how-to-determine-whether-a-freezable-is-frozen"></a>Практическое руководство. Определение фиксации объекта Freezable
В этом примере показано, как определить, является ли <xref:System.Windows.Freezable> объект заморожен. Если попытаться изменить зафиксированный <xref:System.Windows.Freezable> объекта, он выдает <xref:System.InvalidOperationException>. Чтобы избежать возникновения этого исключения, используйте <xref:System.Windows.Freezable.IsFrozen%2A> свойство <xref:System.Windows.Freezable> объектом, чтобы определить, зафиксирован ли он.  
  
## <a name="example"></a>Пример  
 В следующем примере фиксируется <xref:System.Windows.Media.SolidColorBrush> и затем проверяется с помощью <xref:System.Windows.Freezable.IsFrozen%2A> свойства, чтобы определить, зафиксирован ли он.  
  
 [!code-csharp[freezablesample_procedural#CheckIsFrozenExample](~/samples/snippets/csharp/VS_Snippets_Wpf/freezablesample_procedural/CSharp/freezablesample.cs#checkisfrozenexample)]
 [!code-vb[freezablesample_procedural#CheckIsFrozenExample](~/samples/snippets/visualbasic/VS_Snippets_Wpf/freezablesample_procedural/visualbasic/freezablesample.vb#checkisfrozenexample)]  
  
 Дополнительные сведения о <xref:System.Windows.Freezable> объектов, см. в разделе [Freezable Общие сведения об объектах](freezable-objects-overview.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Freezable>
- <xref:System.Windows.Freezable.IsFrozen%2A>
- [Общие сведения об объектах класса Freezable](freezable-objects-overview.md)
- [Практические руководства](base-elements-how-to-topics.md)

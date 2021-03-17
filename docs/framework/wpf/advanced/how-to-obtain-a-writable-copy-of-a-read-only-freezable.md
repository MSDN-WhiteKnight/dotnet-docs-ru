---
title: Практическое руководство. Получение копии с возможностью записи объекта Freezable только для чтения
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- cloning Freezable objects [WPF]
- Freezable objects [WPF], modifiable clones
ms.assetid: d028de61-bbe9-4d62-b656-8fe3b1b2ca24
ms.openlocfilehash: 910c5dada6ca82f68992722e4df6b35f9f7497c7
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59206477"
---
# <a name="how-to-obtain-a-writable-copy-of-a-read-only-freezable"></a>Практическое руководство. Получение копии с возможностью записи объекта Freezable только для чтения
В этом примере показано, как использовать <xref:System.Windows.Freezable.Clone%2A> метод, чтобы создать копию только для чтения <xref:System.Windows.Freezable>.  
  
 После <xref:System.Windows.Freezable> объект помечен как доступный только для чтения («замороженным»), его нельзя изменять. Тем не менее, можно использовать <xref:System.Windows.Freezable.Clone%2A> метод для создания Модифицируемая копия зафиксированного объекта.  
  
## <a name="example"></a>Пример  
 В следующем примере создается Модифицируемая копия зафиксированного <xref:System.Windows.Media.SolidColorBrush> объекта.  
  
 [!code-csharp[freezablesample_procedural#CloneExample](~/samples/snippets/csharp/VS_Snippets_Wpf/freezablesample_procedural/CSharp/freezablesample.cs#cloneexample)]
 [!code-vb[freezablesample_procedural#CloneExample](~/samples/snippets/visualbasic/VS_Snippets_Wpf/freezablesample_procedural/visualbasic/freezablesample.vb#cloneexample)]  
  
 Дополнительные сведения о <xref:System.Windows.Freezable> объектов, см. в разделе [Freezable Общие сведения об объектах](freezable-objects-overview.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Freezable>
- <xref:System.Windows.Freezable.CloneCurrentValue%2A>
- [Общие сведения об объектах класса Freezable](freezable-objects-overview.md)
- [Практические руководства](base-elements-how-to-topics.md)

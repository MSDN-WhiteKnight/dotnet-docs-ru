---
title: Практическое руководство. Реализация свойства зависимостей
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- dependency properties [WPF], backing properties with
- properties [WPF], backing with dependency properties
ms.assetid: 855fd6d7-19ac-493c-bf5e-2f40b57cdc92
ms.openlocfilehash: e2f18cb3941be2ebf4315a844c05b91ff49c6aa2
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59223805"
---
# <a name="how-to-implement-a-dependency-property"></a>Практическое руководство. Реализация свойства зависимостей
В этом примере показано, как создавать резервные [!INCLUDE[TLA#tla_clr](../../../../includes/tlasharptla-clr-md.md)] свойство с <xref:System.Windows.DependencyProperty> поля, определив тем самым свойство зависимости. Если вы определяете собственные свойства и хотите, чтобы они поддерживали множество аспектов функциональности Windows Presentation Foundation (WPF), включая стили, привязку данных, наследование, анимацию и значения по умолчанию, следует реализовать их как свойства зависимостей.  
  
## <a name="example"></a>Пример  
 В следующем примере сначала регистрируется свойство зависимости путем вызова <xref:System.Windows.DependencyProperty.Register%2A> метод. Поле идентификатора, которое используется для хранения имени и характеристик свойства зависимости должно быть имя <xref:System.Windows.DependencyProperty.Name%2A> вы выбрали для свойства зависимостей, как часть <xref:System.Windows.DependencyProperty.Register%2A> вызова, добавлением строковый литерал `Property`. Например при регистрации свойства зависимостей с <xref:System.Windows.DependencyProperty.Name%2A> из `Location`, то поле идентификатора, определяемое для свойства зависимостей должны именоваться `LocationProperty`.  
  
 В этом примере имя свойства зависимостей и его [!INCLUDE[TLA2#tla_clr](../../../../includes/tla2sharptla-clr-md.md)] метод доступа является `State`; поле идентификатора называется `StateProperty`; тип свойства — <xref:System.Boolean>; и тип, регистрирующий свойство зависимостей является `MyStateControl`.  
  
 Если не следовать этому шаблону именования, конструкторы могут неправильно обработать свойство и определенные аспекты применения стиля в системе свойств могут работать не так, как ожидалось.  
  
 Для свойства зависимости можно также указать используемые по умолчанию метаданные. В этом примере в качестве значения по умолчанию для свойства зависимости `State` регистрируется значение `false`.  
  
 [!code-csharp[PropertySystemEsoterics#MyStateControl](~/samples/snippets/csharp/VS_Snippets_Wpf/PropertySystemEsoterics/CSharp/SDKSampleLibrary/class1.cs#mystatecontrol)]
   
  
 Дополнительные сведения о том, как и зачем реализовывать свойство зависимости вместо предоставления закрытого поля для свойства [!INCLUDE[TLA2#tla_clr](../../../../includes/tla2sharptla-clr-md.md)], см. в разделе [Общие сведения о свойствах зависимости](dependency-properties-overview.md).  
  
## <a name="see-also"></a>См. также

- [Общие сведения о свойствах зависимости](dependency-properties-overview.md)
- [Практические руководства](properties-how-to-topics.md)

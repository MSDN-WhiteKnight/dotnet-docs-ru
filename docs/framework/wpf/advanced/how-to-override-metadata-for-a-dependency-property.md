---
title: Практическое руководство. Переопределение метаданных для свойств зависимостей
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- metadata [WPF], overriding for dependency properties
- dependency properties [WPF], overriding metadata for
- overriding metadata for dependency properties [WPF]
ms.assetid: f90f026e-60d8-428a-933d-edf0dba4441f
ms.openlocfilehash: 7f20708722660aa4f86462efd50939935f840613
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59209441"
---
# <a name="how-to-override-metadata-for-a-dependency-property"></a>Практическое руководство. Переопределение метаданных для свойств зависимостей
В этом примере показано, как переопределить метаданные свойства зависимостей по умолчанию, которое поступает из наследуемого класса, путем вызова <xref:System.Windows.DependencyProperty.OverrideMetadata%2A> с указанием конкретного типа метаданных.  
  
## <a name="example"></a>Пример  
 Определив его <xref:System.Windows.PropertyMetadata>, класс может определить поведение свойства зависимости, например, значение и свойство системы обратные вызовы по умолчанию. Многие классы свойств зависимостей уже имеют метаданные по умолчанию, заданные во время процесса их регистрации. К ним относятся свойства зависимостей, которые являются частью API WPF. Класс, который наследует свойство зависимости при наследовании класса, может переопределить исходные метаданные, так что характеристики свойства, которые могут изменяться посредством метаданных, будут соответствовать любым особым требованиям подкласса.  
  
 Переопределение метаданных в свойстве зависимости должно быть выполнено до того, как свойство начнет использоваться системой свойств (то есть до того момента, когда будут созданы определенные экземпляры объектов, регистрирующие свойство). Вызовы <xref:System.Windows.DependencyProperty.OverrideMetadata%2A> должны быть выполнены в статических конструкторах типа, предоставляющего себя в качестве `forType` параметр <xref:System.Windows.DependencyProperty.OverrideMetadata%2A>. При попытке изменить метаданные существующих экземпляров типа-владельца не возникнет исключения, но это приведет к несогласованному поведению системы свойств. Кроме того, метаданные могут переопределяться один раз для каждого типа. Последующие попытки переопределить метаданные для того же типа вызовут исключение.  
  
 В приведенном ниже примере пользовательский класс `MyAdvancedStateControl` переопределяет метаданные, предоставленные свойству `StateProperty` классом `MyAdvancedStateControl`, новыми метаданными свойства. Например, значение `StateProperty` по умолчанию теперь является `true`, если это свойство запрашивается для нового экземпляра `MyAdvancedStateControl`.  
  
 [!code-csharp[PropertySystemEsoterics#MyStateControl](~/samples/snippets/csharp/VS_Snippets_Wpf/PropertySystemEsoterics/CSharp/SDKSampleLibrary/class1.cs#mystatecontrol)]
   
[!code-csharp[PropertySystemEsoterics#MyAdvancedStateControl](~/samples/snippets/csharp/VS_Snippets_Wpf/PropertySystemEsoterics/CSharp/SDKSampleLibrary/class1.cs#myadvancedstatecontrol)]
  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.DependencyProperty>
- [Общие сведения о свойствах зависимости](dependency-properties-overview.md)
- [Пользовательские свойства зависимостей](custom-dependency-properties.md)
- [Практические руководства](properties-how-to-topics.md)

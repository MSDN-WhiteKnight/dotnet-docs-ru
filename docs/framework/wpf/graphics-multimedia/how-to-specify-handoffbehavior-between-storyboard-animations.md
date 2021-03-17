---
title: Практическое руководство. Задание значения свойства HandoffBehavior для анимаций раскадровки
ms.date: 03/30/2017
helpviewer_keywords:
- Storyboards [WPF], handoff behavior between animations
- animation [WPF], handoff behavior between
ms.assetid: 97bd6842-929b-49d9-813e-46553ae46472
ms.openlocfilehash: d7129d6a48bdf31dc4953bb450267ad3b38fdd17
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59083885"
---
# <a name="how-to-specify-handoffbehavior-between-storyboard-animations"></a>Практическое руководство. Задание значения свойства HandoffBehavior для анимаций раскадровки
В этом примере показано, как указать переадресуемое поведение между анимациями раскадровки. <xref:System.Windows.Media.Animation.BeginStoryboard.HandoffBehavior%2A> Свойство <xref:System.Windows.Media.Animation.BeginStoryboard> указывает, как новая анимация взаимодействовать с любыми существующими анимациями, уже примененные к свойству.  
  
## <a name="example"></a>Пример  
 В следующем примере создается две кнопки, увеличить размер при движении курсора мыши над ними и уменьшаются при движении курсора немедленно. Если указатель мыши на кнопку и быстро удалить курсор, вторая анимация будет применяться до завершения первого. При перекрытии двух объектов анимации так, как можно видеть разницу между <xref:System.Windows.Media.Animation.BeginStoryboard.HandoffBehavior%2A> значения <xref:System.Windows.Media.Animation.HandoffBehavior.Compose> и <xref:System.Windows.Media.Animation.HandoffBehavior.SnapshotAndReplace>. Значение <xref:System.Windows.Media.Animation.HandoffBehavior.Compose> объединяет перекрывающихся анимаций, вызывая плавный переход между анимациями при значение <xref:System.Windows.Media.Animation.HandoffBehavior.SnapshotAndReplace> приводит к новой анимации немедленно заменить ранее перекрывающиеся анимации.  
  
 [!code-xaml[timingbehaviors_snip#HandoffBehaviorWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/timingbehaviors_snip/CSharp/HandoffBehaviorExample.xaml#handoffbehaviorwholepage)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Animation.BeginStoryboard>
- <xref:System.Windows.Media.Animation.BeginStoryboard.HandoffBehavior%2A>
- [Общие сведения об эффектах анимации](animation-overview.md)
- [Разделы руководства по анимации и таймерам](animation-and-timing-how-to-topics.md)

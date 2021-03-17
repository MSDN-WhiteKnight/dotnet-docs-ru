---
title: Практическое руководство. Определение автоматического реверса для шкалы времени
ms.date: 03/30/2017
helpviewer_keywords:
- AutoReverse property of timelines [WPF]
- Timelines [WPF], AutoReverse property
ms.assetid: 1648dd90-1bee-409a-ac69-ac729867f557
ms.openlocfilehash: 0fe2d337d8afa5197475e5b9ee40950226596e8b
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57354210"
---
# <a name="how-to-specify-whether-a-timeline-automatically-reverses"></a>Практическое руководство. Определение автоматического реверса для шкалы времени
Временной шкалы <xref:System.Windows.Media.Animation.Timeline.AutoReverse%2A> свойство определяет, будет ли он воспроизводиться в обратном порядке после завершения прямой итерации. В следующем примере показано несколько анимаций с идентичной длительностью и целевыми значениями, но с разными <xref:System.Windows.Media.Animation.Timeline.AutoReverse%2A> параметры. Чтобы продемонстрировать, как <xref:System.Windows.Media.Animation.Timeline.AutoReverse%2A> свойство ведет себя с различными <xref:System.Windows.Media.Animation.Timeline.RepeatBehavior%2A> , некоторых анимаций настроены для повторения. Последняя анимация показывает как <xref:System.Windows.Media.Animation.Timeline.AutoReverse%2A> свойство работает с вложенными временными шкалами.  
  
## <a name="example"></a>Пример  
 [!code-xaml[timingbehaviors_snip#AutoReverseAndRepeatBehaviorExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/timingbehaviors_snip/CSharp/AutoReverseExample.xaml#autoreverseandrepeatbehaviorexamplewholepage)]

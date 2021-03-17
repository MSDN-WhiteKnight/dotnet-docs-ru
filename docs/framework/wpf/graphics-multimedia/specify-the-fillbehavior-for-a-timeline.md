---
title: Практическое руководство. Определение режима FillBehavior для временной шкалы, достигшей конца периода активности
ms.date: 03/30/2017
helpviewer_keywords:
- FillBehavior property for inactive timelines [WPF]
- Timelines [WPF], FillBehavior property
ms.assetid: db805f59-d513-4dac-af15-47005dae3199
ms.openlocfilehash: 9f03c5b8d4585c32e0a9f119649dd15a23523033
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59091131"
---
# <a name="how-to-specify-the-fillbehavior-for-a-timeline-that-has-reached-the-end-of-its-active-period"></a>Практическое руководство. Определение режима FillBehavior для временной шкалы, достигшей конца периода активности
В этом примере показано, как указать <xref:System.Windows.Media.Animation.Timeline.FillBehavior%2A> для неактивного <xref:System.Windows.Media.Animation.Timeline> анимированного свойства.  
  
## <a name="example"></a>Пример  
 <xref:System.Windows.Media.Animation.Timeline.FillBehavior%2A> Свойство <xref:System.Windows.Media.Animation.Timeline> определяет, что происходит с значение анимированного свойства, если оно не анимировано, то есть когда <xref:System.Windows.Media.Animation.Timeline> неактивна, но его родительский <xref:System.Windows.Media.Animation.Timeline> находится в своем активном периоде или периоде удержания. Например, она анимированного свойства по-прежнему со своей стороны значение после окончания анимации или делает это вернуться к значению, которое было до начала анимации?  
  
 В следующем примере используется <xref:System.Windows.Media.Animation.DoubleAnimation> для анимации <xref:System.Windows.FrameworkElement.Width%2A> двух прямоугольников. Каждый прямоугольник использует другое <xref:System.Windows.Media.Animation.Timeline> объекта.  
  
 Один <xref:System.Windows.Media.Animation.Timeline> имеет <xref:System.Windows.Media.Animation.Timeline.FillBehavior%2A> , имеет значение <xref:System.Windows.Media.Animation.FillBehavior.Stop>, чего ширина прямоугольника, вернуться к его не анимированное значение, если <xref:System.Windows.Media.Animation.Timeline> заканчивается. Другой <xref:System.Windows.Media.Animation.Timeline> имеет <xref:System.Windows.Media.Animation.Timeline.FillBehavior%2A> из <xref:System.Windows.Media.Animation.FillBehavior.HoldEnd>, чего ширина оставаться в конце значения при <xref:System.Windows.Media.Animation.Timeline> заканчивается.  
  
 [!code-xaml[timingbehaviors_snip#FillBehaviorWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/timingbehaviors_snip/CSharp/FillBehaviorExample.xaml#fillbehaviorwholepage)]  
  
 Полный пример см. в разделе [Коллекция примеров анимации](https://go.microsoft.com/fwlink/?LinkID=159969).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Animation.DoubleAnimation>
- <xref:System.Windows.FrameworkElement.Width%2A>
- <xref:System.Windows.Media.Animation.Timeline>
- <xref:System.Windows.Media.Animation.Timeline.FillBehavior%2A>
- <xref:System.Windows.Media.Animation.FillBehavior.Stop>
- <xref:System.Windows.Media.Animation.FillBehavior.HoldEnd>
- [Общие сведения об эффектах анимации](animation-overview.md)
- [Разделы руководства по анимации и таймерам](animation-and-timing-how-to-topics.md)

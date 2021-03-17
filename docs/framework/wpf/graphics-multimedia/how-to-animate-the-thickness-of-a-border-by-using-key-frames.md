---
title: Практическое руководство. Анимация толщины границы с помощью ключевых кадров
ms.date: 03/30/2017
helpviewer_keywords:
- animation [WPF], border thickness with key frames
- key frames [WPF], animating border thickness with
- border thickness [WPF], animating with key frames
ms.assetid: 3a9cb463-0a63-407d-aae7-3fbb1a559947
ms.openlocfilehash: 101fd077bf125faadbd9a0186c2282e4b20ee78f
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59301793"
---
# <a name="how-to-animate-the-thickness-of-a-border-by-using-key-frames"></a>Практическое руководство. Анимация толщины границы с помощью ключевых кадров
В этом примере демонстрируется анимация <xref:System.Windows.Controls.Control.BorderThickness%2A> свойство <xref:System.Windows.Controls.Border>.  
  
## <a name="example"></a>Пример  
 В следующем примере используется <xref:System.Windows.Media.Animation.ThicknessAnimationUsingKeyFrames> класс для анимации <xref:System.Windows.Controls.Control.BorderThickness%2A> свойство <xref:System.Windows.Controls.Border>. Эта анимация использует три ключевых кадра следующим образом:  
  
1. В течение первой половины секунды используется экземпляр <xref:System.Windows.Media.Animation.LinearThicknessKeyFrame> класс для постепенного увеличения толщины границы. В примере используется <xref:System.Windows.Media.Animation.LinearThicknessKeyFrame> для создания гладкого линейного увеличения между значениями.  
  
2. В конце следующей половины секунды используется экземпляр <xref:System.Windows.Media.Animation.DiscreteThicknessKeyFrame> класс для резкого увеличения толщины границы. Дискретные ключевые кадры, подобные производным от <xref:System.Windows.Media.Animation.DiscreteThicknessKeyFrame> , создают скачкообразные переходы между значениями, то есть, перемещение анимация выполняется рывками.  
  
3. В течение последних двух секунд используется экземпляр <xref:System.Windows.Media.Animation.SplineThicknessKeyFrame> класс для уменьшения толщины границы. Ключевые кадры сплайна, подобные производным от <xref:System.Windows.Media.Animation.SplineThicknessKeyFrame> , создают переменный переход между значениями в соответствии со значениями из <xref:System.Windows.Media.Animation.SplineThicknessKeyFrame.KeySpline%2A> свойство. В этом опорном кадре анимация начинается медленно и экспоненциально ускоряется к концу временного сегмента.  
  
 [!code-xaml[keyframes_snip#ThicknessAnimationUsingKeyFramesWholePage](~/samples/snippets/xaml/VS_Snippets_Wpf/keyframes_snip/XAML/ThicknessAnimationUsingKeyFramesExample.xaml#thicknessanimationusingkeyframeswholepage)]  
  
 Описание полного примера см. в разделе [Пример анимации по ключевым кадрам](https://go.microsoft.com/fwlink/?LinkID=160012).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Animation.LinearThicknessKeyFrame>
- <xref:System.Windows.Media.Animation.DiscreteThicknessKeyFrame>
- <xref:System.Windows.Media.Animation.SplineThicknessKeyFrame>
- [Общие сведения об анимации по ключевым кадрам](key-frame-animations-overview.md)
- [Практические руководства, посвященные анимации по ключевым кадрам](key-frame-animation-how-to-topics.md)
- [Анимирование значения BorderThickness](../controls/how-to-animate-a-borderthickness-value.md)

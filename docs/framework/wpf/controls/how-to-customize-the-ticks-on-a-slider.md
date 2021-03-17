---
title: Практическое руководство. Настройка делений на ползунке
ms.date: 03/30/2017
helpviewer_keywords:
- TickBar [WPF]
- Slider control [WPF], creating with TickBar
ms.assetid: 4fa694f2-a620-4b15-be78-5f4286f89361
ms.openlocfilehash: 3b32bbedb5f654ce75e90a827eb0c4dba1d4d345
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59164246"
---
# <a name="how-to-customize-the-ticks-on-a-slider"></a>Практическое руководство. Настройка делений на ползунке
В этом примере показано, как создать <xref:System.Windows.Controls.Slider> элемента управления, содержащий деления.  
  
## <a name="example"></a>Пример  
 <xref:System.Windows.Controls.Primitives.TickBar> Отображается в случае <xref:System.Windows.Controls.Slider.TickPlacement%2A> присваивается значение, отличное от <xref:System.Windows.Controls.Primitives.TickPlacement.None>, который является значением по умолчанию.  
  
 В следующем примере показано, как создать <xref:System.Windows.Controls.Slider> с <xref:System.Windows.Controls.Primitives.TickBar> отображает метки деления. <xref:System.Windows.Controls.Slider.TickPlacement%2A> И <xref:System.Windows.Controls.Slider.TickFrequency%2A> определяют расположение меток делений и интервал между ними. При перемещении <xref:System.Windows.Controls.Primitives.Thumb>, всплывающие подсказки отображают значение <xref:System.Windows.Controls.Slider>. <xref:System.Windows.Controls.Slider.AutoToolTipPlacement%2A> Свойство определяет, где появляется подсказка. <xref:System.Windows.Controls.Primitives.Thumb> Перемещений соответствуют расположению меток делений поскольку <xref:System.Windows.Controls.Slider.IsSnapToTickEnabled%2A> присваивается `true`.  
  
 В следующем примере показано, как использовать <xref:System.Windows.Controls.Slider.Ticks%2A> свойства для создания метки вдоль делений <xref:System.Windows.Controls.Slider> через нерегулярные интервалы времени.  
  
 [!code-xaml[Slider#4](~/samples/snippets/xaml/VS_Snippets_Wpf/Slider/xaml/window1.xaml#4)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.Slider>
- <xref:System.Windows.Controls.Primitives.TickBar>
- <xref:System.Windows.Controls.Slider.TickPlacement%2A>
- [Практическое руководство. Привязка ползунка к значению свойства](https://docs.microsoft.com/previous-versions/dotnet/netframework-3.5/ms788716(v=vs.90))

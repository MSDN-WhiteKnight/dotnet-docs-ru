---
title: Практическое руководство. Использование свойства BetweenShowDelay
ms.date: 03/30/2017
helpviewer_keywords:
- ToolTip control [WPF], BetweenShowDelay time property
- BetweenShowDelay time property [WPF]
ms.assetid: 984ea76d-f2a2-4326-a02e-f97ec3d036d6
ms.openlocfilehash: b6d55c72c8264546949833fc086937a8b1fe2540
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59139598"
---
# <a name="how-to-use-the-betweenshowdelay-property"></a>Практическое руководство. Использование свойства BetweenShowDelay
В этом примере показано, как использовать <xref:System.Windows.Controls.ToolTipService.BetweenShowDelay%2A> свойства времени, чтобы подсказки отображаются быстро — с минимальными задержками или без, когда пользователь перемещает указатель мыши из одна подсказка непосредственно в другой.  
  
## <a name="example"></a>Пример  
 В следующем примере <xref:System.Windows.Controls.ToolTipService.InitialShowDelay%2A> свойству одну секунду (1000 миллисекунд) и <xref:System.Windows.Controls.ToolTipService.BetweenShowDelay%2A> задано значение двух секунд (2000 мс) для подсказок обоих <xref:System.Windows.Shapes.Ellipse> элементов управления. Если отображение всплывающей подсказки для одного из эллипсов и затем наведите указатель мыши на другой эллипс в две секунды и приостановки на нем, сразу же появляется подсказка второго эллипса.  
  
 В любом из следующих сценариев <xref:System.Windows.Controls.ToolTipService.InitialShowDelay%2A> применяется, чего подсказка для второго эллипса ожидания одной секунды до появления:  
  
-   Если время, необходимое для перемещения вторая кнопка является более двух секунд.  
  
-   Если подсказка не отображается в начале периода времени, для первого эллипса.  
  
 [!code-xaml[ToolTipService#ToolTip](~/samples/snippets/csharp/VS_Snippets_Wpf/ToolTipService/CSharp/Pane1.xaml#tooltip)]  
[!code-xaml[ToolTipService#NoToolTip](~/samples/snippets/csharp/VS_Snippets_Wpf/ToolTipService/CSharp/Pane1.xaml#notooltip)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.ToolTip>
- <xref:System.Windows.Controls.ToolTipService>
- [Практические руководства](tooltip-how-to-topics.md)
- [Общие сведения о всплывающих подсказках](tooltip-overview.md)

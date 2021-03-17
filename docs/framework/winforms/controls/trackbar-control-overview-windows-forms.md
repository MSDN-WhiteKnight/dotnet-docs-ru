---
title: Общие сведения об элементе управления TrackBar (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- TrackBar
helpviewer_keywords:
- sliders [Windows Forms], about sliders
- TrackBar control [Windows Forms], about TrackBar control
- slider controls [Windows Forms], about slider controls
ms.assetid: 95910ecb-8a4c-4776-89fa-206c89ed6973
ms.openlocfilehash: 1606db73485944f3dfa8b9c084bffda817520c7c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59200640"
---
# <a name="trackbar-control-overview-windows-forms"></a>Общие сведения об элементе управления TrackBar (Windows Forms)
Windows Forms <xref:System.Windows.Forms.TrackBar> элемент управления (также элемент управления «ползунок») используется для просмотра сведений большого объема или для визуальной настройки числовых параметров. <xref:System.Windows.Forms.TrackBar> Управления состоит из двух частей: ползунка и делений. Бегунок является часть, которая может настраиваться. Его положение соответствует <xref:System.Windows.Forms.TrackBar.Value%2A> свойство. Деления — это визуальные индикаторы, расположенные с регулярными интервалами. Ползунок перемещается с шагом, которые могут быть выровнены горизонтально или вертикально. Например можно использовать полосы прокрутки для управления мерцания курсора скорость или мыши скорости для системы.  
  
## <a name="key-properties"></a>Ключевые свойства  
 Ключевые свойства <xref:System.Windows.Forms.TrackBar> управления <xref:System.Windows.Forms.TrackBar.Value%2A>, <xref:System.Windows.Forms.TrackBar.TickFrequency%2A>, <xref:System.Windows.Forms.TrackBar.Minimum%2A>, и <xref:System.Windows.Forms.TrackBar.Maximum%2A>. <xref:System.Windows.Forms.TrackBar.TickFrequency%2A> — это интервал делений. <xref:System.Windows.Forms.TrackBar.Minimum%2A> и <xref:System.Windows.Forms.TrackBar.Maximum%2A> — это наименьшее и наибольшее значения, которые могут быть представлены на полосе прокрутки.  
  
 Два важных свойства: <xref:System.Windows.Forms.TrackBar.SmallChange%2A> и <xref:System.Windows.Forms.TrackBar.LargeChange%2A>. Значение <xref:System.Windows.Forms.TrackBar.SmallChange%2A> свойство — количество позиций, перемещается в ответ на нажатии клавиши влево или Стрелка вправо. Значение <xref:System.Windows.Forms.TrackBar.LargeChange%2A> свойство — количество позиций бегунка переходит в ответ на нажатии клавиши PAGE UP или PAGE DOWN или в ответ на мыши, нажимает на любой стороны от бегунка полосы прокрутки.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.TrackBar>
- [Элемент управления TrackBar](trackbar-control-windows-forms.md)

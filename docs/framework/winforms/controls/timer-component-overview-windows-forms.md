---
title: Общие сведения о компоненте Timer (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- Timer
helpviewer_keywords:
- Timer component [Windows Forms], about Timer components
- timers [Windows Forms], about timers
ms.assetid: e672c05b-a8b6-4b26-9e4d-9223aa9e3873
ms.openlocfilehash: 5bef0ba87d6a496acf7575965128be2b20b437ab
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59074213"
---
# <a name="timer-component-overview-windows-forms"></a>Общие сведения о компоненте Timer (Windows Forms)
Компонент Windows Forms <xref:System.Windows.Forms.Timer> вызывает событие через определенные интервалы времени. Этот компонент предназначен для работы в среде Windows Forms. Если вам требуется таймер, подходящий для серверной среды, см. раздел [Общие сведения о серверных таймерах](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2008/tb9yt5e6(v=vs.90)).  
  
## <a name="key-properties-methods-and-events"></a>Ключевые свойства, методы и события  
 Длина в интервале, заданном параметром <xref:System.Windows.Forms.Timer.Interval%2A> свойство, значение которого указывается в миллисекундах. При включении компонента <xref:System.Windows.Forms.Timer.Tick> события во время каждого интервала. Это, где необходимо добавить код, который будет выполнен. Дополнительные сведения см. в разделе [Как Выполните процедуры, заданной периодичностью с помощью компонента Timer в Windows Forms](run-procedures-at-set-intervals-with-wf-timer-component.md). Основные методы класса <xref:System.Windows.Forms.Timer> компонент <xref:System.Windows.Forms.Timer.Start%2A> и <xref:System.Windows.Forms.Timer.Stop%2A>, который включать таймер и отключать. При выключении таймера, он сбрасывает; Невозможно приостановить <xref:System.Windows.Forms.Timer> компонента.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Timer>
- [Компонент Timer](timer-component-windows-forms.md)
- [Ограничения свойства Interval компонента Timer в Windows Forms](limitations-of-the-timer-component-interval-property.md)

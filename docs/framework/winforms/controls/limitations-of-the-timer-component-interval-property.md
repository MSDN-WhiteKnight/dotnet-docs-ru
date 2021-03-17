---
title: Ограничения свойства Interval компонента Timer в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- timers [Windows Forms], event intervals
- Interval property [Windows Forms], limitations
- timers [Windows Forms], Windows-based
- Timer component [Windows Forms], limitations of Interval property
ms.assetid: 7e5fb513-77e7-4046-a8e8-aab94e61ca0f
ms.openlocfilehash: 54782c4e0460ba1ba9b8a870b8f60f08a76340b3
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59125176"
---
# <a name="limitations-of-the-windows-forms-timer-components-interval-property"></a>Ограничения свойства Interval компонента Timer в Windows Forms
Windows Forms <xref:System.Windows.Forms.Timer> компонент имеет <xref:System.Windows.Forms.Timer.Interval%2A> свойство, которое указывает количество миллисекунд, которые проходят между событие одного таймера, а также следующие. Если компонент отключен, таймер для получения <xref:System.Windows.Forms.Timer.Tick> событий через приблизительно равные интервалы времени.  
  
 Этот компонент предназначен для работы в среде Windows Forms. Если вам требуется таймер, подходящий для серверной среды, см. раздел [Общие сведения о серверных таймерах](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2008/tb9yt5e6(v=vs.90)).  
  
## <a name="the-interval-property"></a>Свойство «интервал»  
 <xref:System.Windows.Forms.Timer.Interval%2A> Свойство имеет несколько ограничений, которые следует учитывать при программировании <xref:System.Windows.Forms.Timer> компонента:  
  
-   Если приложение или другое приложение интенсивно потребляет системы — например длинные циклы, с большим объемом вычислений, или диска, сети или доступа к портам — приложение не может получить события таймера так часто, как <xref:System.Windows.Forms.Timer.Interval%2A> указывает свойство.  
  
-   Интервал истечет точно вовремя не гарантируется. Для обеспечения точности, таймер следует проверить системные часы, при необходимости, а не повторите для отслеживания накопленные временные внутренним образом.  
  
-   Точность <xref:System.Windows.Forms.Timer.Interval%2A> свойство указывается в миллисекундах. Некоторые компьютеры имеют счетчик высокого разрешения, более высокую точность разрешение. Доступность такого счетчика зависит от оборудования процессора компьютера.
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Timer>
- [Компонент Timer](timer-component-windows-forms.md)
- [Общие сведения о компоненте Timer](timer-component-overview-windows-forms.md)

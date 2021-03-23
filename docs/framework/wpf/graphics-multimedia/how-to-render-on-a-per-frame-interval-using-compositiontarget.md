---
title: Практическое руководство. Визуализация каждого кадра с помощью CompositionTarget
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- CompositionTarget objects [WPF], rendering per frame
- rendering per frame using CompositionTarget objects [WPF]
ms.assetid: 701246cd-66b7-4d69-ada9-17b3b433d95d
ms.openlocfilehash: 00b416d423a4bdc8bab576add2d77fd305ea6e0f
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59089423"
---
# <a name="how-to-render-on-a-per-frame-interval-using-compositiontarget"></a>Практическое руководство. Визуализация каждого кадра с помощью CompositionTarget
Подсистема анимации WPF предоставляет множество возможностей для создания анимации на основе кадров. Однако существуют сценарии приложений, в которых необходим детальный контроль отрисовки каждого кадра. <xref:System.Windows.Media.CompositionTarget> Предоставляет возможность создания пользовательской анимации на основе покадрового обратного вызова.  
  
 <xref:System.Windows.Media.CompositionTarget> является статическим классом, который представляет отображаемую поверхность, на котором рисуется приложение. <xref:System.Windows.Media.CompositionTarget.Rendering> Событие возникает каждый раз при рисовании сцены приложения. Частота кадров отрисовки — это количество отрисовок сцены за секунду.  
  
> [!NOTE]
>  Пример полного кода с использованием <xref:System.Windows.Media.CompositionTarget>, см. в разделе [пример использования CompositionTarget](https://go.microsoft.com/fwlink/?LinkID=160045).  
  
## <a name="example"></a>Пример  
 <xref:System.Windows.Media.CompositionTarget.Rendering> Событие запускается во время WPF процесс подготовки отчета. В следующем примере показано, как зарегистрировать <xref:System.EventHandler> делегировать статического <xref:System.Windows.Media.CompositionTarget.Rendering> метод <xref:System.Windows.Media.CompositionTarget>.  
  
 [!code-csharp[CompositionTargetSample#CompositionTarget1](~/samples/snippets/csharp/VS_Snippets_Wpf/CompositionTargetSample/CSharp/Window1.xaml.cs#compositiontarget1)]
   
  
 Можно использовать собственный метод обработчика событий отрисовки для создания пользовательского графического содержимого. Метод обработчика событий вызывается один раз для каждого кадра. Каждый раз, когда WPF выполняет маршалинг сохраненных данных отрисовки в визуальном дереве через граф сцены композиции, вызывается метод обработчика событий. Кроме того, если изменения в визуальном дереве принудительно обновляют граф сцены композиции, метод обработчика событий также вызывается. Обратите внимание, что метод обработчика событий вызывается после вычисления макета. Однако можно изменить макет в методе обработчика событий, что означает повторное вычисление макета перед отрисовкой.  
  
 В следующем примере показано как можно реализовать пользовательское рисование <xref:System.Windows.Media.CompositionTarget> метод обработчика событий. В данном случае цвет фона <xref:System.Windows.Controls.Canvas> рисуется пером значение цвета на основе координат положения указателя мыши. При перемещении указателя мыши внутри <xref:System.Windows.Controls.Canvas>, ее изменения цвета фона. Кроме того вычисляется средняя частота кадров, на основе текущего значения прошедшего времени и общего числа отрисованных кадров.  
  
 [!code-csharp[CompositionTargetSample#CompositionTarget2](~/samples/snippets/csharp/VS_Snippets_Wpf/CompositionTargetSample/CSharp/Window1.xaml.cs#compositiontarget2)]
   
  
 Может оказаться, что пользовательское рисование выполняется на разных компьютерах с разной скоростью. Это потому, что пользовательское рисование не является независимым от частоты кадров. В зависимости от используемой системы и рабочей нагрузки этой системы <xref:System.Windows.Media.CompositionTarget.Rendering> событие может вызываться Разное количество раз в секунду. Дополнительные сведения об определении возможностей графического оборудования и производительности для устройства, которое запускает приложение WPF см. в разделе [Уровни отрисовки графики](../advanced/graphics-rendering-tiers.md).  
  
 Добавление или удаление визуализации <xref:System.EventHandler> делегата во время срабатывания события будет отложено до момента завершения события обработки. Это согласуется с тем, как <xref:System.MulticastDelegate>-на основе события обрабатываются в Common Language Runtime (CLR). Также обратите внимание, что порядок вызова событий отрисовки не гарантируется. Если имеется несколько <xref:System.EventHandler> делегаты, которые зависят от определенного порядка, необходимо зарегистрировать один <xref:System.Windows.Media.CompositionTarget.Rendering> событий и мультиплексировать делегаты в правильном порядке.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.CompositionTarget>
- [Общие сведения об отрисовке графики в WPF](wpf-graphics-rendering-overview.md)

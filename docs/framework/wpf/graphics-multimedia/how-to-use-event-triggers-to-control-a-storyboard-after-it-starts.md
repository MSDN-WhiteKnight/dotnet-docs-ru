---
title: Практическое руководство. Использование триггеров событий для управления раскадровкой после ее запуска
ms.date: 03/30/2017
helpviewer_keywords:
- triggers [WPF], controlling Storyboards
- event triggers [WPF], controlling Storyboards
- Storyboards [WPF], controlling after start
ms.assetid: 3b115594-6a93-4972-b24d-61aa16f1c15f
ms.openlocfilehash: d444349f8bc9236e1d15f484f35b1326c77e2425
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59170655"
---
# <a name="how-to-use-event-triggers-to-control-a-storyboard-after-it-starts"></a>Практическое руководство. Использование триггеров событий для управления раскадровкой после ее запуска
В этом примере показано, как управлять <xref:System.Windows.Media.Animation.Storyboard> после ее запуска. Чтобы запустить <xref:System.Windows.Media.Animation.Storyboard> с помощью [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)], использовать <xref:System.Windows.Media.Animation.BeginStoryboard>, которая распределяет анимации объектов и свойств и затем запускает раскадровку. Если вы предоставите <xref:System.Windows.Media.Animation.BeginStoryboard> имя, указав его <xref:System.Windows.Media.Animation.BeginStoryboard.Name%2A> свойство, можно упростить управляемой раскадровки. Вы можете затем интерактивно управлять раскадровкой после ее запуска.  
  
 Используйте следующие действия раскадровки вместе с <xref:System.Windows.EventTrigger> объектов для управления раскадровкой.  
  
-   <xref:System.Windows.Media.Animation.PauseStoryboard>: Приостанавливает раскадровку.  
  
-   <xref:System.Windows.Media.Animation.ResumeStoryboard>: Возобновляет приостановленную раскадровку.  
  
-   <xref:System.Windows.Media.Animation.SetStoryboardSpeedRatio>: Изменяет скорость раскадровки.  
  
-   <xref:System.Windows.Media.Animation.SkipStoryboardToFill>: Перемещает раскадровку в конец ее периода заполнения, если он имеется.  
  
-   <xref:System.Windows.Media.Animation.StopStoryboard>: Останавливает раскадровку.  
  
-   <xref:System.Windows.Media.Animation.RemoveStoryboard>: Удаляет раскадровку, освобождает ресурсы.  
  
## <a name="example"></a>Пример  
 В следующем примере действий для управляемой раскадровки для интерактивного управления раскадровкой.  
  
 **Примечание.** Пример управления раскадровкой с помощью кода, см. в разделе [управления раскадровки после он начинается с помощью его интерактивных методов](how-to-control-a-storyboard-after-it-starts.md).  
  
 [!code-xaml[timingbehaviors_snip#ControlStoryboardExampleUsingWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/timingbehaviors_snip/CSharp/ControlStoryboardExample.xaml#controlstoryboardexampleusingwholepage)]  
  
 Дополнительные примеры см. в разделе [Коллекция примеров анимации](https://go.microsoft.com/fwlink/?LinkID=159969).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Animation.ResumeStoryboard>
- <xref:System.Windows.Media.Animation.SetStoryboardSpeedRatio>
- <xref:System.Windows.Media.Animation.SkipStoryboardToFill>
- <xref:System.Windows.Media.Animation.PauseStoryboard>
- <xref:System.Windows.Media.Animation.StopStoryboard>
- <xref:System.Windows.Media.Animation.SeekStoryboard>
- [Управление раскадровкой после ее запуска с помощью интерактивных методов](how-to-control-a-storyboard-after-it-starts.md)
- [Общие сведения об эффектах анимации](animation-overview.md)
- [Общие сведения о Storyboard](storyboards-overview.md)

---
title: Практическое руководство. Применение анимаций к тексту
ms.date: 03/30/2017
helpviewer_keywords:
- typography [WPF], animations
- animation [WPF], text
ms.assetid: eec3d26c-0a21-420f-8012-671621c47089
ms.openlocfilehash: 38aa432fecc5b5e10d8eb90be9c1c596728ed613
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59108216"
---
# <a name="how-to-apply-animations-to-text"></a>Практическое руководство. Применение анимаций к тексту
Анимации могут менять отображение и внешний вид текста в приложении. В следующих примерах используются различные виды анимации влияющие на отображение текста в <xref:System.Windows.Controls.TextBlock> элемента управления.  
  
## <a name="example"></a>Пример  
 В следующем примере используется <xref:System.Windows.Media.Animation.DoubleAnimation> для анимации ширины текстового блока. Значение ширины за 10 секунд меняется с ширины текстового блока до 0, затем значения ширины меняются местами и анимация продолжается. Этот тип анимации создает эффект очистки.  
  
 [!code-xaml[TextAnimationSample#TextAnimationSample1](~/samples/snippets/csharp/VS_Snippets_Wpf/TextAnimationSample/CS/Window1.xaml#textanimationsample1)]  
  
 В следующем примере используется <xref:System.Windows.Media.Animation.DoubleAnimation> для анимации прозрачности текстового блока. Значение прозрачности меняется с 1,0 до 0 в течение 5 секунд, затем значения меняются местами и анимация продолжается.  
  
 [!code-xaml[TextAnimationSample#TextAnimationSample2](~/samples/snippets/csharp/VS_Snippets_Wpf/TextAnimationSample/CS/Window1.xaml#textanimationsample2)]  
  
 В примере ниже показан эффект <xref:System.Windows.Controls.TextBlock> управления, прозрачность которого меняется с `1.00` для `0.00` во время 5-секундный интервал, определяемый <xref:System.Windows.Media.Animation.Timeline.Duration%2A>.  
  
 ![Изменение непрозрачности текста с 1,00 до 0,00.](./media/how-to-apply-animations-to-text/faded-text-opacity-change.png)  
   
 В следующем примере используется <xref:System.Windows.Media.Animation.ColorAnimation> для анимации основного цвета текстового блока. Значение основного цвета меняется с первого цвета на второй в течение 5 секунд, затем значения цвета меняются местами и анимация продолжается.  
  
 [!code-xaml[TextAnimationSample#TextAnimationSample3](~/samples/snippets/csharp/VS_Snippets_Wpf/TextAnimationSample/CS/Window1.xaml#textanimationsample3)]  
  
 В следующем примере используется <xref:System.Windows.Media.Animation.DoubleAnimation> для вращения текстового блока. Текстовый блок выполняет полный поворот за 20 секунд, а затем повторяет вращение.  
  
 [!code-xaml[TextAnimationSample#TextAnimationSample4](~/samples/snippets/csharp/VS_Snippets_Wpf/TextAnimationSample/CS/Window1.xaml#textanimationsample4)]  
  
## <a name="see-also"></a>См. также

- [Общие сведения об эффектах анимации](../graphics-multimedia/animation-overview.md)

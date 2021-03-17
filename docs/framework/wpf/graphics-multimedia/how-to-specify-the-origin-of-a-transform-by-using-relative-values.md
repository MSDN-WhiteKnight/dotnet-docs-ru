---
title: Практическое руководство. Определение источника преобразования с помощью относительных значений
ms.date: 03/30/2017
helpviewer_keywords:
- origins of Transforms [WPF]
- Transforms [WPF], origins of
- graphics [WPF], origins of Transforms
ms.assetid: f4dbc29d-93c7-41cd-96d8-5cfd8624b470
ms.openlocfilehash: 48b3b0df8dab8516873495a996074eae57ffe00f
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59082962"
---
# <a name="how-to-specify-the-origin-of-a-transform-by-using-relative-values"></a>Практическое руководство. Определение источника преобразования с помощью относительных значений
В этом примере показано, как использовать относительные значения для указания источника <xref:System.Windows.UIElement.RenderTransform%2A> , применяемый к <xref:System.Windows.FrameworkElement>.  
  
 При повороте, масштабирование или наклон <xref:System.Windows.FrameworkElement> с помощью <xref:System.Windows.UIElement.RenderTransform%2A> свойство, значение по умолчанию применяет преобразование в верхний левый угол элемента. Если требуется выполнить поворот, масштабирование или наклон в центре элемента, можно скорректировать действие, задав центр преобразования в центре элемента. Но для этого способа требуется знание размера элемента. Более простой способ применить преобразование к центру элемента является установка его <xref:System.Windows.UIElement.RenderTransformOrigin%2A> значение (0,5, 0,5), а не задавать значение центра преобразования.  
  
## <a name="example"></a>Пример  
 В следующем примере используется <xref:System.Windows.Media.RotateTransform> для поворота <xref:System.Windows.Controls.Button> 45 градусов по часовой стрелке. Так как в примере не задана центральная точка, то кнопка поворачивается вокруг точки (0, 0), т. е. левого верхнего угла. <xref:System.Windows.Media.RotateTransform> Применяется к <xref:System.Windows.UIElement.RenderTransform%2A> свойство.  
  
 Ниже показан результат преобразования для следующего примера.  
  
 ![Кнопка, преобразованная с использованием RenderTransform](./media/graphicsmm-rendertransformwithdefaultcenter.png "graphicsmm_RenderTransformWithDefaultCenter")  
Поворот по часовой стрелке на 45 градусов с использованием свойства RenderTransform  
  
 [!code-xaml[Transforms_snip#GraphicsMMRotateButtonExample1](~/samples/snippets/csharp/VS_Snippets_Wpf/Transforms_snip/CS/ButtonRotateTransformExample.xaml#graphicsmmrotatebuttonexample1)]  
  
 В следующем примере также используется <xref:System.Windows.Media.RotateTransform> для поворота <xref:System.Windows.Controls.Button> 45 градусов по часовой стрелке, однако в этом примере устанавливается <xref:System.Windows.UIElement.RenderTransformOrigin%2A> кнопки значение (0,5, 0,5). В результате кнопка поворачивается вокруг центра, а не вокруг левого верхнего угла.  
  
 Ниже показан результат преобразования для следующего примера.  
  
 ![Кнопка, преобразованная относительно ее центра](./media/graphicsmm-rendertransformrelativecenter.png "graphicsmm_RenderTransformRelativeCenter")  
Поворот на 45 градусов с использованием свойства RenderTransform с заданным для RenderTransformOrigin значением (0,5, 0,5)  
  
 [!code-xaml[Transforms_snip#GraphicsMMRotateButtonExample2](~/samples/snippets/csharp/VS_Snippets_Wpf/Transforms_snip/CS/ButtonRotateTransformExample.xaml#graphicsmmrotatebuttonexample2)]  
  
 Дополнительные сведения о преобразовании <xref:System.Windows.FrameworkElement> объектов, см. в разделе [Общие сведения о преобразованиях](transforms-overview.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Transform>
- [Общие сведения о классах Transform](transforms-overview.md)
- [Практические руководства](transformations-how-to-topics.md)

---
title: Практическое руководство. Масштабирование элемента
ms.date: 03/30/2017
helpviewer_keywords:
- scaling [WPF], elements
- graphics [WPF], scaling elements
ms.assetid: 18158d94-bbe7-4f6a-814e-84d27fa748bf
ms.openlocfilehash: 607b3a11085f746503c1b82552f1740b49d9ef5d
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59131707"
---
# <a name="how-to-scale-an-element"></a>Практическое руководство. Масштабирование элемента
В этом примере показано, как использовать <xref:System.Windows.Media.ScaleTransform> для масштабирования элемента.  
  
 Используйте <xref:System.Windows.Media.ScaleTransform.ScaleX%2A> и <xref:System.Windows.Media.ScaleTransform.ScaleY%2A> свойства для изменения размеров элемента с определенным коэффициентом. Например <xref:System.Windows.Media.ScaleTransform.ScaleX%2A> значение 1,5 увеличивает элемент на 150 процентов от его исходной ширины. Объект <xref:System.Windows.Media.ScaleTransform.ScaleY%2A> значение 0,5 уменьшает элемент на 50 процентов.  
  
 Используйте <xref:System.Windows.Media.ScaleTransform.CenterX%2A> и <xref:System.Windows.Media.ScaleTransform.CenterY%2A> свойства для указания точки, которая будет центром операции масштабирования. По умолчанию <xref:System.Windows.Media.ScaleTransform> центрируется в точке (0,0), который соответствует верхнего левого угла прямоугольника. Это приводит к перемещению элемента, а также делает его размер больше, поскольку при применении <xref:System.Windows.Media.Transform>, измените пространство координат, в которой находится объект.  
  
 В следующем примере используется <xref:System.Windows.Media.ScaleTransform> размера 50 на 50 <xref:System.Windows.Shapes.Rectangle>. <xref:System.Windows.Media.ScaleTransform> Имеет значение 0 (по умолчанию) для <xref:System.Windows.Media.ScaleTransform.CenterX%2A> и <xref:System.Windows.Media.ScaleTransform.CenterY%2A>.  
  
## <a name="example"></a>Пример  
 [!code-xaml[transformsSample#21](~/samples/snippets/csharp/VS_Snippets_Wpf/transformsSample/CS/ScaleTransformExample.xaml#21)]  
  
 Обычно задается <xref:System.Windows.Media.ScaleTransform.CenterX%2A> и <xref:System.Windows.Media.ScaleTransform.CenterY%2A> относительно центральной части масштабируемого объекта: (<xref:System.Windows.FrameworkElement.Width%2A>/2,  <xref:System.Windows.FrameworkElement.Height%2A> /2).  
  
 В следующем примере показан другой <xref:System.Windows.Shapes.Rectangle> который удваивается в размере; Однако это <xref:System.Windows.Media.ScaleTransform> имеет значение 25 для <xref:System.Windows.Media.ScaleTransform.CenterX%2A> и <xref:System.Windows.Media.ScaleTransform.CenterY%2A>, что соответствует центру прямоугольника.  
  
 [!code-xaml[transformsSample#22](~/samples/snippets/csharp/VS_Snippets_Wpf/transformsSample/CS/ScaleTransformExample.xaml#22)]  
  
 Ниже показано различие между двумя <xref:System.Windows.Media.ScaleTransform> операций. Пунктирная линия показывает размер и положение прямоугольника до масштабирования.  
  
 ![двукратное масштабирование с разными центральными точками](./media/wcpsdk-graphicsmm-scalecenter.gif "wcpsdk_graphicsmm_scalecenter")  
Две операции ScaleTransform с одинаковыми значениями свойств ScaleX и ScaleY, но с разными центрами  
  
 Полный пример см. в разделе [Примеры двумерных преобразований](https://go.microsoft.com/fwlink/?LinkID=158252).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Transform>
- <xref:System.Windows.Media.ScaleTransform>
- [Общие сведения о классах Transform](transforms-overview.md)
- [Практические руководства](transformations-how-to-topics.md)

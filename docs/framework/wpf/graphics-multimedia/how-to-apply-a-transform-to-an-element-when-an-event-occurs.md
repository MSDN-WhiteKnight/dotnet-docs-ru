---
title: Практическое руководство. Применение преобразования к элементу при возникновении события
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- graphics [WPF], transformations as event responses
- properties [WPF], LayoutTransform
- transformations as event responses [WPF]
- properties [WPF], RenderTransform
- LayoutTransform property [WPF]
ms.assetid: 71e4327e-ca57-444c-a3cf-09fb381491a0
ms.openlocfilehash: 973b9267eaef5d55176633ee80a1dc7f8b043909
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59126442"
---
# <a name="how-to-apply-a-transform-to-an-element-when-an-event-occurs"></a>Практическое руководство. Применение преобразования к элементу при возникновении события
В этом примере показано, как применить <xref:System.Windows.Media.ScaleTransform> при наступлении определенного события. Показанный подход аналогичен тому, который используется при применении других типов преобразований. Дополнительные сведения о доступных типах преобразований см. в разделе <xref:System.Windows.Media.Transform> класса или [Общие сведения о преобразованиях](transforms-overview.md).  
  
 Преобразование можно применить к элементу любым из двух следующих способов:  
  
-   В этом случае *не* преобразование влияло на макет, используйте <xref:System.Windows.UIElement.RenderTransform%2A> свойство элемента.  
  
-   Если вы хотите, чтобы преобразование влияло на макет, используйте <xref:System.Windows.FrameworkElement.LayoutTransform%2A> свойство элемента.  
  
 В следующем примере применяется <xref:System.Windows.Media.ScaleTransform> для <xref:System.Windows.UIElement.RenderTransform%2A> свойства кнопки. При перемещении указателя мыши над кнопкой, <xref:System.Windows.Media.ScaleTransform.ScaleX%2A> и <xref:System.Windows.Media.ScaleTransform.ScaleY%2A> свойства <xref:System.Windows.Media.ScaleTransform> присваивается `2`, что приводит к увеличению кнопки. Когда указатель мыши покидает кнопку, <xref:System.Windows.Media.ScaleTransform.ScaleX%2A> и <xref:System.Windows.Media.ScaleTransform.ScaleY%2A> присваивается `1`, которое вызывает кнопки для возврата к исходному размеру.  
  
## <a name="example"></a>Пример  
 [!code-xaml[ButtonTransform#1](~/samples/snippets/csharp/VS_Snippets_Wpf/ButtonTransform/CSharp/ButtonTransformExample.xaml#1)]  
  
 [!code-csharp[ButtonTransform#1cb](~/samples/snippets/csharp/VS_Snippets_Wpf/ButtonTransform/CSharp/ButtonTransformExample.xaml.cs#1cb)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Transform>
- <xref:System.Windows.Media.ScaleTransform>
- [Общие сведения о классах Transform](transforms-overview.md)
- [Практические руководства](transformations-how-to-topics.md)
- [Общие сведения о перенаправленных событиях](../advanced/routed-events-overview.md)

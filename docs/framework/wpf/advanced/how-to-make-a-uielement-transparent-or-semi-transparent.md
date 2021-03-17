---
title: Практическое руководство. Создание прозрачного или полупрозрачного элемента UIElement
ms.date: 03/30/2017
helpviewer_keywords:
- UIElements [WPF], transparency
- opacity [WPF], of UIElements
- transparency of UIElements [WPF]
- UIElements [WPF], opacity
ms.assetid: a49fc8d6-7b32-4f28-9122-39b632a19b4b
ms.openlocfilehash: 1de9a7e11fee241ecb71242e9808e77b7e5e63b0
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57370531"
---
# <a name="how-to-make-a-uielement-transparent-or-semi-transparent"></a>Практическое руководство. Создание прозрачного или полупрозрачного элемента UIElement
В этом примере показано, как сделать <xref:System.Windows.UIElement> прозрачным или полупрозрачным. Чтобы сделать элемент прозрачным или полупрозрачным, задайте его <xref:System.Windows.UIElement.Opacity%2A> свойство. Значение `0.0` делает элемент полностью прозрачной, а значение `1.0` делает элемент полностью непрозрачным. Значение `0.5` делает элемент 50% непрозрачный и т. д. Элемента <xref:System.Windows.UIElement.Opacity%2A> присваивается `1.0` по умолчанию.  
  
## <a name="example"></a>Пример  
 В следующем примере задается <xref:System.Windows.UIElement.Opacity%2A> кнопки `0.25`, что делает ее и ее содержимое (в данном случае текст кнопки) на 25% непрозрачной.  
  
 [!code-xaml[brushsamples_snip#2](~/samples/snippets/csharp/VS_Snippets_Wpf/brushsamples_snip/CS/OpacityExample.xaml#2)]  
  
 [!code-csharp[brushsamples_procedural_snip#2](~/samples/snippets/csharp/VS_Snippets_Wpf/brushsamples_procedural_snip/CSharp/OpacityExample.cs#2)]  
  
 Если содержимое элемента имеют свой собственный <xref:System.Windows.UIElement.Opacity%2A> параметры, эти значения при умножении на содержащего элементы массива <xref:System.Windows.UIElement.Opacity%2A>.  
  
 В следующем примере задается кнопки <xref:System.Windows.UIElement.Opacity%2A> для `0.25`и <xref:System.Windows.UIElement.Opacity%2A> из <xref:System.Windows.Controls.Image> содержащегося в кнопку, чтобы `0.5`. В результате изображение отображается 12,5% непрозрачным: 0.25 * 0.5 = 0.125.  
  
 [!code-xaml[brushsamples_snip#3](~/samples/snippets/csharp/VS_Snippets_Wpf/brushsamples_snip/CS/OpacityExample.xaml#3)]  
  
 [!code-csharp[brushsamples_procedural_snip#3](~/samples/snippets/csharp/VS_Snippets_Wpf/brushsamples_procedural_snip/CSharp/OpacityExample.cs#3)]  
  
 Другой способ управления прозрачностью элемента является установка прозрачности <xref:System.Windows.Media.Brush> , рисует элемент. Такой подход позволяет выборочно изменять непрозрачность частей элемента и дает выигрыш в производительности по сравнению с использованием этого элемента <xref:System.Windows.UIElement.Opacity%2A> свойство. В следующем примере задается <xref:System.Windows.Media.Brush.Opacity%2A> из <xref:System.Windows.Media.SolidColorBrush> используется для закрашивания кнопки <xref:System.Windows.Controls.Control.Background%2A> присваивается `0.25`. В результате кисти фона является непрозрачным на 25%, но его содержимое (текст кнопки) остаются 100% непрозрачный.  
  
 [!code-xaml[brushsamples_snip#4](~/samples/snippets/csharp/VS_Snippets_Wpf/brushsamples_snip/CS/OpacityExample.xaml#4)]  
  
 [!code-csharp[brushsamples_procedural_snip#4](~/samples/snippets/csharp/VS_Snippets_Wpf/brushsamples_procedural_snip/CSharp/OpacityExample.cs#4)]  
  
 Вы также можете управлять непрозрачности отдельных цветов в кисти. Дополнительные сведения о цвета и кисти, см. в разделе [закраске сплошным цветом и градиентом Обзор](../graphics-multimedia/painting-with-solid-colors-and-gradients-overview.md). Пример, показывающий, как анимировать непрозрачности элемента, см. в разделе [Анимация прозрачности элемента или кисти](../graphics-multimedia/how-to-animate-the-opacity-of-an-element-or-brush.md).

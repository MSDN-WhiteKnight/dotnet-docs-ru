---
title: Практическое руководство. Отражение объекта UIElement по горизонтали или вертикали
ms.date: 03/30/2017
helpviewer_keywords:
- flipping UIElements [WPF]
- UIElements [WPF], flipping
ms.assetid: 02c6730f-65c0-40d5-a553-4cb663721882
ms.openlocfilehash: 6b3da322493d17e4f8e36a35b9a0e40fdc9dc685
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59215525"
---
# <a name="how-to-flip-a-uielement-horizontally-or-vertically"></a>Практическое руководство. Отражение объекта UIElement по горизонтали или вертикали
В этом примере показано, как использовать <xref:System.Windows.Media.ScaleTransform> перевернуть <xref:System.Windows.UIElement> горизонтально или вертикально. В этом примере <xref:System.Windows.Controls.Button> управления (разновидность <xref:System.Windows.UIElement>) изменилось, применяя <xref:System.Windows.Media.ScaleTransform> для его <xref:System.Windows.UIElement.RenderTransform%2A> свойство.  
  
## <a name="example"></a>Пример  
 Ниже показан кнопка для отражения.  
  
 ![Кнопка без преобразования](./media/graphicsmm-buttonflipbeforeflip.gif "graphicsmm_buttonflipbeforeflip")  
UIElement, чтобы отразить  
  
 Ниже показан код, создающий кнопки.  
  
 [!code-xaml[Transforms_snip#GraphicsMMButtonWithoutFlip](~/samples/snippets/csharp/VS_Snippets_Wpf/Transforms_snip/CS/FlipExample.xaml#graphicsmmbuttonwithoutflip)]  
  
## <a name="example"></a>Пример  
 Чтобы отразить кнопку горизонтально, создайте <xref:System.Windows.Media.ScaleTransform> и задайте его <xref:System.Windows.Media.ScaleTransform.ScaleX%2A> свойство в значение -1. Применить <xref:System.Windows.Media.ScaleTransform> на кнопку <xref:System.Windows.UIElement.RenderTransform%2A> свойство.  
  
 [!code-xaml[Transforms_snip#GraphicsMMFlipButtonExample1](~/samples/snippets/csharp/VS_Snippets_Wpf/Transforms_snip/CS/FlipExample.xaml#graphicsmmflipbuttonexample1)]  
  
 ![Кнопка, перевернута горизонтально &#40;0,0&#41;](./media/graphicsmm-buttonfliphorizontalflip-displaced.gif "graphicsmm_buttonfliphorizontalflip_displaced")  
Кнопка после применения ScaleTransform  
  
## <a name="example"></a>Пример  
 Как видно из предыдущего рисунка, кнопка была отражена, но также была перемещена. Том, что кнопка была отражена от верхнего левого угла. Чтобы отразить кнопку на месте, необходимо применить <xref:System.Windows.Media.ScaleTransform> его центр, а не его угла. Простой способ применить <xref:System.Windows.Media.ScaleTransform> к кнопкам center — присвоить кнопки <xref:System.Windows.UIElement.RenderTransformOrigin%2A> значение 0,5, 0,5.  
  
 [!code-xaml[Transforms_snip#GraphicsMMFlipButtonExample2](~/samples/snippets/csharp/VS_Snippets_Wpf/Transforms_snip/CS/FlipExample.xaml#graphicsmmflipbuttonexample2)]  
  
 ![Кнопка, перевернута горизонтально по центру](./media/graphicsmm-buttonfliphorizontalflip-inplace.gif "graphicsmm_buttonfliphorizontalflip_inplace")  
Кнопка с заданным для rendertransformorigin значением 0,5, 0,5  
  
## <a name="example"></a>Пример  
 Чтобы отразить вертикально кнопку, задайте <xref:System.Windows.Media.ScaleTransform> объекта <xref:System.Windows.Media.ScaleTransform.ScaleY%2A> свойства вместо его <xref:System.Windows.Media.ScaleTransform.ScaleX%2A> свойство.  
  
 [!code-xaml[Transforms_snip#GraphicsMMVerticalFlipButtonExample2](~/samples/snippets/csharp/VS_Snippets_Wpf/Transforms_snip/CS/FlipExample.xaml#graphicsmmverticalflipbuttonexample2)]  
  
 ![Кнопка, перевернута вертикально по центру](./media/graphicsmm-buttonflipverticalflip-inplace.gif "graphicsmm_buttonflipverticalflip_inplace")  
Вертикально отраженная кнопка  
  
## <a name="see-also"></a>См. также

- [Общие сведения о классах Transform](../graphics-multimedia/transforms-overview.md)

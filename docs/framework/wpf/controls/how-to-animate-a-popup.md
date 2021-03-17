---
title: Практическое руководство. Анимация контекстного меню
ms.date: 03/30/2017
helpviewer_keywords:
- Popup control [WPF], animating
- animation [WPF], Popup controls
ms.assetid: acaa2a0a-6137-4efd-9cd1-75ece222e390
ms.openlocfilehash: b70d9c4cb1bca26a6c77d3a7c50add517ca8ef92
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59150115"
---
# <a name="how-to-animate-a-popup"></a>Практическое руководство. Анимация контекстного меню
В этом примере показаны два способа анимировать <xref:System.Windows.Controls.Primitives.Popup> элемента управления.  
  
## <a name="example"></a>Пример  
 В следующем примере задается <xref:System.Windows.Controls.Primitives.PopupAnimation> свойство в значение <xref:System.Windows.Controls.Primitives.PopupAnimation.Slide>, чего <xref:System.Windows.Controls.Primitives.Popup> для «слайд в» когда он появится.  
  
 Для смены <xref:System.Windows.Controls.Primitives.Popup>, этот пример назначает <xref:System.Windows.Media.RotateTransform> для <xref:System.Windows.UIElement.RenderTransform%2A> свойство <xref:System.Windows.Controls.Canvas>, который является дочерним элементом элемента <xref:System.Windows.Controls.Primitives.Popup>.  
  
 Для корректной работы преобразования, в примере необходимо присвоить <xref:System.Windows.Controls.Primitives.Popup.AllowsTransparency%2A> свойства `true`. Кроме того <xref:System.Windows.FrameworkElement.Margin%2A> на <xref:System.Windows.Controls.Canvas> содержимого необходимо указать достаточно места для <xref:System.Windows.Controls.Primitives.Popup> для поворота.  
  
 [!code-xaml[AnimatedPopup#RotateTransform2](~/samples/snippets/csharp/VS_Snippets_Wpf/AnimatedPopup/CS/Window1.xaml#rotatetransform2)]  
  
 В следующем примере показан как <xref:System.Windows.Controls.Primitives.ButtonBase.Click> событие, возникающее при <xref:System.Windows.Controls.Button> нажатии триггеры <xref:System.Windows.Media.Animation.Storyboard> , запускает анимацию.  
  
 [!code-xaml[AnimatedPopup#RotateTransform1](~/samples/snippets/csharp/VS_Snippets_Wpf/AnimatedPopup/CS/Window1.xaml#rotatetransform1)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.UIElement.RenderTransform%2A>
- <xref:System.Windows.Controls.Primitives.BulletDecorator>
- <xref:System.Windows.Media.RotateTransform>
- <xref:System.Windows.Media.Animation.Storyboard>
- <xref:System.Windows.Controls.Primitives.Popup>
- [Практические руководства](popup-how-to-topics.md)
- [Общие сведения о контекстном меню](popup-overview.md)

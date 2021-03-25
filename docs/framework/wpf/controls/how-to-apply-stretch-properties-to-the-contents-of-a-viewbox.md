---
title: Практическое руководство. Применение свойства Stretch к содержимому элемента Viewbox
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- StretchDirection properties [WPF]
- Stretch properties [WPF]
- controls [WPF], Viewbox
- Viewbox control [WPF]
ms.assetid: b9c22ef4-bce4-4300-9e0c-8260b7db83cc
ms.openlocfilehash: 08358ea07e0c41e3b7cdf52251a3ed4296035e2d
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59209883"
---
# <a name="how-to-apply-stretch-properties-to-the-contents-of-a-viewbox"></a>Практическое руководство. Применение свойства Stretch к содержимому элемента Viewbox
## <a name="example"></a>Пример  
 В этом примере показано, как изменить значение <xref:System.Windows.Controls.Viewbox.StretchDirection%2A> и <xref:System.Windows.Controls.Viewbox.Stretch%2A> свойства <xref:System.Windows.Controls.Viewbox>.  
  
 В первом примере используется XAML для определения <xref:System.Windows.Controls.Viewbox> элемент. Он назначает <xref:System.Windows.FrameworkElement.MaxWidth%2A> и <xref:System.Windows.FrameworkElement.MaxHeight%2A> 400. Примере показаны вложенные <xref:System.Windows.Controls.Image> сервисном <xref:System.Windows.Controls.Viewbox>. <xref:System.Windows.Controls.Button> элементы, соответствующие значения свойств для <xref:System.Windows.Controls.Viewbox.Stretch%2A> и <xref:System.Windows.Controls.StretchDirection> перечисления управляют растяжением вложенного <xref:System.Windows.Controls.Image>.  
  
 [!code-xaml[viewboxStretchLayoutSamp#1](~/samples/snippets/csharp/VS_Snippets_Wpf/viewboxStretchLayoutSamp/CSharp/Window1.xaml#1)]  
  
 Следующий файл кода обрабатывает <xref:System.Windows.Controls.Button> <xref:System.Windows.Controls.Primitives.ButtonBase.Click> события, предыдущий [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] примере определяется.  
  
 [!code-csharp[viewboxStretchLayoutSamp#2](~/samples/snippets/csharp/VS_Snippets_Wpf/viewboxStretchLayoutSamp/CSharp/Window1.xaml.cs#2)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.Viewbox>
- <xref:System.Windows.Media.Stretch>
- <xref:System.Windows.Controls.StretchDirection>

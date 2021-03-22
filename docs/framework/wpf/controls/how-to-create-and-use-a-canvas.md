---
title: Практическое руководство. Создание и использование холста
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- controls [WPF], Canvas
- Canvas control [WPF], creating
- Canvas control [WPF], using
ms.assetid: 420b9487-9a15-477c-9489-a22a4dec7779
ms.openlocfilehash: 33b98024699a88f56d27b7e5ab8d5216c906e7ec
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59190773"
---
# <a name="how-to-create-and-use-a-canvas"></a>Практическое руководство. Создание и использование холста
В этом примере показано, как создать и использовать экземпляр <xref:System.Windows.Controls.Canvas>.  
  
## <a name="example"></a>Пример  
 Следующий пример явным образом располагает два <xref:System.Windows.Controls.TextBlock> элементов с помощью <xref:System.Windows.Controls.Canvas.SetTop%2A> и <xref:System.Windows.Controls.Canvas.SetLeft%2A> методы <xref:System.Windows.Controls.Canvas>. В примере также назначается <xref:System.Windows.Controls.Control.Background%2A> цвет `LightSteelBlue` для <xref:System.Windows.Controls.Canvas>.  
  
> [!NOTE]
>  При использовании [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] позицию <xref:System.Windows.Controls.TextBlock> элементы, используют <xref:System.Windows.Controls.Canvas.Top%2A> и <xref:System.Windows.Controls.Canvas.Left%2A> свойства.  
  
 [!code-csharp[CanvasCode#1](~/samples/snippets/csharp/VS_Snippets_Wpf/CanvasCode/CSharp/Canvas_Code.cs#1)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.Canvas>
- <xref:System.Windows.Controls.TextBlock>
- <xref:System.Windows.Controls.Canvas.SetTop%2A>
- <xref:System.Windows.Controls.Canvas.SetLeft%2A>
- <xref:System.Windows.Controls.Canvas.Top%2A>
- <xref:System.Windows.Controls.Canvas.Left%2A>
- [Общие сведения о панелях](panels-overview.md)
- [Практические руководства](canvas-how-to-topics.md)

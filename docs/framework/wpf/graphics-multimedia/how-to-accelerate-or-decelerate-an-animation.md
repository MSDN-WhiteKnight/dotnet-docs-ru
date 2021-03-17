---
title: Практическое руководство. Ускорение или замедление анимации
ms.date: 03/30/2017
helpviewer_keywords:
- decelerating animation [WPF]
- accelerating animation [WPF]
- animation [WPF], accelerating
- animation [WPF], decelerating
ms.assetid: 4f383b2c-f94d-4a4e-9a06-f56f5dae95f9
ms.openlocfilehash: d4fcaf4a684c37590f27d603ef5cb2c86a6fb854
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57376251"
---
# <a name="how-to-accelerate-or-decelerate-an-animation"></a>Практическое руководство. Ускорение или замедление анимации
В этом примере показано, как выполнять анимацию ускорения и замедления времени. В следующем примере несколько прямоугольников анимируются по анимации с различными <xref:System.Windows.Media.Animation.Timeline.AccelerationRatio%2A> и <xref:System.Windows.Media.Animation.Timeline.DecelerationRatio%2A> параметры.  
  
## <a name="example"></a>Пример  
 [!code-xaml[timingbehaviors_snip#1](~/samples/snippets/csharp/VS_Snippets_Wpf/timingbehaviors_snip/CSharp/AccelDecelExample.xaml#1)]  
  
 В этом примере отсутствует код. Для получения полного кода см. в разделе [поведение анимации с учетом времени (C#)](https://github.com/dotnet/samples/tree/master/snippets/csharp/VS_Snippets_Wpf/timingbehaviors_procedural_snip/CSharp) или [поведение анимации с учетом времени (Visual Basic)](https://github.com/dotnet/samples/tree/master/snippets/visualbasic/VS_Snippets_Wpf/timingbehaviors_procedural_snip/visualbasic).

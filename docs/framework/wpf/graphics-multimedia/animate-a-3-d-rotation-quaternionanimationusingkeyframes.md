---
title: Практическое руководство. Анимация трехмерного поворота с помощью ключевых кадров (QuaternionAnimationUsingKeyFrames)
ms.date: 03/30/2017
helpviewer_keywords:
- 3-D translations [WPF], animating [WPF], with key frames (QuaternionAnimationUsingKeyFrames)
- key frames [WPF], QuaternionAnimationUsingKeyFrames
- animation [WPF], 3-D translations [WPF], with key frames (QuaternionAnimationUsingKeyFrames)
ms.assetid: 09e5707b-7523-4a08-9aa7-bb13cbedccdf
ms.openlocfilehash: 87176df26405a69cb2c3d63620def0575b750b52
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59338024"
---
# <a name="how-to-animate-a-3-d-rotation-using-key-frames-quaternionanimationusingkeyframes"></a>Практическое руководство. Анимация трехмерного поворота с помощью ключевых кадров (QuaternionAnimationUsingKeyFrames)
В следующем примере <xref:System.Windows.Media.Animation.QuaternionAnimationUsingKeyFrames> используется для поворота трехмерного объекта. Эта анимация использует следующие ключевые кадры:  
  
1. <xref:System.Windows.Media.Animation.LinearRotation3DKeyFrame> используется для создания гладкой, линейной интерполяции между значениями.  
  
2. <xref:System.Windows.Media.Animation.DiscreteRotation3DKeyFrame> используется для создания скачкообразные «переходы» между значениями (без интерполяции).  
  
3. <xref:System.Windows.Media.Animation.SplineRotation3DKeyFrame> используется для, создают переменный переход между значениями в зависимости от <xref:System.Windows.Media.Animation.SplineRotation3DKeyFrame.KeySpline%2A> свойство. В следующем примере эта часть анимация начинается медленно, но к концу временного сегмента, экспоненциально ускоряется.  
  
## <a name="example"></a>Пример  
 [!code-xaml[Animation3DGallery_snip#QuaternionAnimationUsingKeyFramesExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/Animation3DGallery_snip/CS/QuaternionAnimationUsingKeyFramesExample.xaml#quaternionanimationusingkeyframesexamplewholepage)]  
  
## <a name="see-also"></a>См. также

- [Анимация трехмерного вращения с помощью раскадровки](how-to-animate-a-3-d-rotation-using-storyboards.md)
- [Анимация трехмерного поворота с помощью Rotation3DAnimation](how-to-animate-a-3-d-rotation-using-rotation3danimation.md)
- [Анимация трехмерного вращения с помощью кватернионов](how-to-animate-a-3-d-rotation-using-quaternions.md)
- [Анимация трехмерного поворота с помощью ключевых кадров (Rotation3DAnimationUsingKeyFrames)](how-to-animate-a-3-d-rotation-using-key-frames.md)
- [Обзор трехмерной графики](3-d-graphics-overview.md)
- [Общие сведения об анимации по ключевым кадрам](key-frame-animations-overview.md)

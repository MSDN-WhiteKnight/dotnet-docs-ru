---
title: Практическое руководство. Анимация трехмерного вращения с помощью ключевых кадров
ms.date: 03/30/2017
helpviewer_keywords:
- animation [WPF], 3-D translations [WPF], with key frames (Rotation3DAnimation)
- key frames [WPF], Rotation3DAnimation
- 3-D translations [WPF], animating [WPF], with key frames (Rotation3DAnimation)
ms.assetid: 6f671b95-7f30-4836-9a4f-aeb7dc30121f
ms.openlocfilehash: e72ec94f830f0f5001a77e7492aa1326a47b309d
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59297997"
---
# <a name="how-to-animate-a-3-d-rotation-using-key-frames"></a>Практическое руководство. Анимация трехмерного вращения с помощью ключевых кадров
В следующем примере <xref:System.Windows.Media.Animation.Rotation3DAnimationUsingKeyFrames> используется для создания трехмерный поворот объекта во время его ось вращения анимирует приводит к «Иванин». Эта анимация использует следующие ключевые кадры:  
  
1. <xref:System.Windows.Media.Animation.LinearRotation3DKeyFrame> используется для создания гладкой, линейной интерполяции между значениями.  
  
2. <xref:System.Windows.Media.Animation.DiscreteRotation3DKeyFrame> используется для создания скачкообразные «переходы» между значениями (без интерполяции).  
  
3. <xref:System.Windows.Media.Animation.SplineRotation3DKeyFrame> используется для, создают переменный переход между значениями в зависимости от <xref:System.Windows.Media.Animation.SplineRotation3DKeyFrame.KeySpline%2A> свойство. В следующем примере эта часть анимация начинается медленно, но к концу временного сегмента, экспоненциально ускоряется.  
  
## <a name="example"></a>Пример  
 [!code-xaml[Animation3DGallery_snip#Rotation3DAnimationUsingKeyFramesExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/Animation3DGallery_snip/CS/Rotation3DAnimationUsingKeyFramesExample.xaml#rotation3danimationusingkeyframesexamplewholepage)]  
  
## <a name="see-also"></a>См. также

- [Обзор трехмерной графики](3-d-graphics-overview.md)
- [Общие сведения об анимации по ключевым кадрам](key-frame-animations-overview.md)
- [Анимация трехмерного вращения с помощью раскадровки](how-to-animate-a-3-d-rotation-using-storyboards.md)
- [Анимация трехмерного поворота с помощью Rotation3DAnimation](how-to-animate-a-3-d-rotation-using-rotation3danimation.md)
- [Анимация трехмерного вращения с помощью кватернионов](how-to-animate-a-3-d-rotation-using-quaternions.md)
- [Анимация трехмерного поворота с помощью ключевых кадров (QuaternionAnimationUsingKeyFrames)](animate-a-3-d-rotation-quaternionanimationusingkeyframes.md)

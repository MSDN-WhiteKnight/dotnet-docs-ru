---
title: Практическое руководство. Анимация трехмерного вращения с помощью раскадровки
ms.date: 03/30/2017
helpviewer_keywords:
- Storyboards [WPF]
- 3-D translations [WPF], animating [WPF], with Storyboards
- animation [WPF], 3-D translations [WPF], with Storyboards
ms.assetid: 1020e44e-e21e-49a8-be53-53cbc1910e83
ms.openlocfilehash: 03b01205f1a31426a01b09533b350682c384df4b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59146202"
---
# <a name="how-to-animate-a-3-d-rotation-using-storyboards"></a>Практическое руководство. Анимация трехмерного вращения с помощью раскадровки
Приведенный ниже показано, как сделать трехмерный поворот во время его «качания» с помощью анимации объекта <xref:System.Windows.Media.Media3D.AxisAngleRotation3D.Angle%2A> и <xref:System.Windows.Media.Media3D.AxisAngleRotation3D.Axis%2A> свойства <xref:System.Windows.Media.Media3D.AxisAngleRotation3D> объекта. Это <xref:System.Windows.Media.Media3D.AxisAngleRotation3D> объект задает преобразование поворота трехмерного объекта, и поэтому анимация его свойства создает эффект поворота большие усилия. В раскадровке <xref:System.Windows.Media.Animation.DoubleAnimation> используется для анимации <xref:System.Windows.Media.Media3D.AxisAngleRotation3D.Angle%2A> свойство при <xref:System.Windows.Media.Animation.Vector3DAnimation> используется для анимации <xref:System.Windows.Media.Media3D.AxisAngleRotation3D.Axis%2A> свойство.  
  
## <a name="example"></a>Пример  
 [!code-xaml[Animation3DGallery_snip#Rotate3DUsingAxisAngleRotation3DExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/Animation3DGallery_snip/CS/Rotat3DUsingAxisAngleRotation3DExample.xaml#rotate3dusingaxisanglerotation3dexamplewholepage)]  
  
## <a name="see-also"></a>См. также

- [Анимация трехмерного поворота с помощью Rotation3DAnimation](how-to-animate-a-3-d-rotation-using-rotation3danimation.md)
- [Анимация трехмерного поворота с помощью ключевых кадров (Rotation3DAnimationUsingKeyFrames)](how-to-animate-a-3-d-rotation-using-key-frames.md)
- [Обзор трехмерной графики](3-d-graphics-overview.md)
- [Общие сведения о Storyboard](storyboards-overview.md)

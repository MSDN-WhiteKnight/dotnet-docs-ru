---
title: Практическое руководство. Анимация трехмерного вращения с помощью кватернионов
ms.date: 03/30/2017
helpviewer_keywords:
- quaternions [WPF]
- animation [WPF], 3-D translations [WPF], with quaternions
- 3-D translations [WPF], animating [WPF], with quaternions
ms.assetid: adca9cb1-066b-4de8-abbb-6b4007579ee7
ms.openlocfilehash: d994ac2ae67fd366f27f123d5bd15f14d5ac7abe
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59183226"
---
# <a name="how-to-animate-a-3-d-rotation-using-quaternions"></a>Практическое руководство. Анимация трехмерного вращения с помощью кватернионов
В этом примере демонстрируется анимация поворота трехмерного объекта с помощью кватернионов.  
  
 В коде ниже показан <xref:System.Windows.Media.Media3D.QuaternionRotation3D> используется в качестве значения для <xref:System.Windows.Media.Media3D.RotateTransform3D.Rotation%2A> свойство <xref:System.Windows.Media.Media3D.RotateTransform3D>.  
  
 [!code-xaml[Animation3DGallery_snip#QuaternionAnimationExampleInline1](~/samples/snippets/csharp/VS_Snippets_Wpf/Animation3DGallery_snip/CS/QuaternionAnimationExample.xaml#quaternionanimationexampleinline1)]  
  
 Это <xref:System.Windows.Media.Media3D.QuaternionRotation3D> анимируется с <xref:System.Windows.Media.Animation.QuaternionAnimation> в <xref:System.Windows.Media.Animation.Storyboard> с помощью следующего кода.  
  
 [!code-xaml[Animation3DGallery_snip#QuaternionAnimationExampleInline2](~/samples/snippets/csharp/VS_Snippets_Wpf/Animation3DGallery_snip/CS/QuaternionAnimationExample.xaml#quaternionanimationexampleinline2)]  
  
## <a name="example"></a>Пример  
 В следующем коде показано весь пример.  
  
 [!code-xaml[Animation3DGallery_snip#QuaternionAnimationExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/Animation3DGallery_snip/CS/QuaternionAnimationExample.xaml#quaternionanimationexamplewholepage)]  
  
## <a name="see-also"></a>См. также

- [Общие сведения об эффектах анимации](animation-overview.md)
- [Создание трехмерной сцены](how-to-create-a-3-d-scene.md)
- [Обзор трехмерной графики](3-d-graphics-overview.md)
- [Общие сведения о классах Transform](transforms-overview.md)
- [Анимация трехмерного вращения с помощью раскадровки](how-to-animate-a-3-d-rotation-using-storyboards.md)
- [Анимация трехмерного поворота с помощью Rotation3DAnimation](how-to-animate-a-3-d-rotation-using-rotation3danimation.md)

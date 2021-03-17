---
title: Практическое руководство. Анимация положения и направления камеры в трехмерной сцене
ms.date: 03/30/2017
helpviewer_keywords:
- animation [WPF], camera position in 3-D scenes
- camera direction [WPF], animating in 3-D scenes
- 3-D scenes [WPF], animating camera position
- 3-D scenes [WPF], animating camera direction
- camera position [WPF], animating in 3-D scenes
- animation [WPF], camera direction in 3-D scenes
ms.assetid: 480224b7-a5e5-4165-ba7f-ef760ddff94a
ms.openlocfilehash: b64263a495ffe845a76317aad8f5b4a14e11b31e
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59146007"
---
# <a name="how-to-animate-camera-position-and-direction-in-a-3d-scene"></a>Практическое руководство. Анимация положения и направления камеры в трехмерной сцене
В следующем примере показано, как анимация позиции камеры и направления в трехмерной сцене. Это делается с помощью <xref:System.Windows.Media.Animation.Point3DAnimation> и <xref:System.Windows.Media.Animation.Vector3DAnimation> для анимации <xref:System.Windows.Media.Media3D.ProjectionCamera.Position%2A> и <xref:System.Windows.Media.Media3D.ProjectionCamera.LookDirection%2A> свойства соответственно <xref:System.Windows.Media.Media3D.PerspectiveCamera>. Чтобы изменить наблюдения сцены в ответ на событие можно использовать анимации следующим образом.  
  
## <a name="example"></a>Пример  
 [!code-xaml[Animation3DGallery_snip#PointVector3DAnimationExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/Animation3DGallery_snip/CS/PointVector3DAnimationExample.xaml#pointvector3danimationexamplewholepage)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Animation.Vector3DAnimation>
- <xref:System.Windows.Media.Animation.Point3DAnimation>
- [Анимация положения и направления камеры с помощью ключевых кадров](how-to-animate-camera-position-and-direction-using-key-frames.md)
- [Обзор трехмерной графики](3-d-graphics-overview.md)

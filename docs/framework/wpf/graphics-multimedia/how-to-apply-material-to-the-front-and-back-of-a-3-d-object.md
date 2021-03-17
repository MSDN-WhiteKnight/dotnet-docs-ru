---
title: Практическое руководство. Применение материала к лицевой и обратной стороне трехмерного объекта
ms.date: 03/30/2017
helpviewer_keywords:
- 3-D objects [WPF], applying Material class
- Material class [WPF], applying to both sides of 3-D object
- classes [WPF], Material
ms.assetid: d93c8ad6-4939-4d29-9544-4d16d98093c1
ms.openlocfilehash: 1d3f6a0622b5e0ccccf14af99782bb78dfe87ccb
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59168055"
---
# <a name="how-to-apply-material-to-the-front-and-back-of-a-3-d-object"></a>Практическое руководство. Применение материала к лицевой и обратной стороне трехмерного объекта
В следующем примере показано, как применить <xref:System.Windows.Media.Media3D.Material> к лицевой и обратной стороне трехмерного объекта и анимация объекта для отображения обеих сторон объекта. <xref:System.Windows.Media.Media3D.GeometryModel3D.Material%2A> Свойство <xref:System.Windows.Media.Media3D.GeometryModel3D> используется для применения красной <xref:System.Windows.Media.Brush> к передней части объекта и <xref:System.Windows.Media.Media3D.GeometryModel3D.BackMaterial%2A> свойство <xref:System.Windows.Media.Media3D.GeometryModel3D> используется для применения синим <xref:System.Windows.Media.Brush> к обратной стороне объекта. В приведенном ниже коде показано применение материалов к объекту:  
  
 [!code-xaml[Animation3DGallery_snip#BackMaterialAnimationExampleInline1](~/samples/snippets/csharp/VS_Snippets_Wpf/Animation3DGallery_snip/CS/BackMaterialAnimationExample.xaml#backmaterialanimationexampleinline1)]  
  
## <a name="example"></a>Пример  
 В следующем коде показано весь пример.  
  
 [!code-xaml[Animation3DGallery_snip#BackMaterialAnimationExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/Animation3DGallery_snip/CS/BackMaterialAnimationExample.xaml#backmaterialanimationexamplewholepage)]  
  
## <a name="see-also"></a>См. также

- [Создание трехмерной сцены](how-to-create-a-3-d-scene.md)
- [Обзор трехмерной графики](3-d-graphics-overview.md)
- [Анимация свойств материалов в трехмерной сцене](how-to-animate-material-properties-in-a-3-d-scene.md)
- [Применение эмиссионного материала к трехмерному объекту](how-to-apply-emissive-material-to-a-3-d-object.md)

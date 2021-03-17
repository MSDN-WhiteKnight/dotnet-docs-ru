---
title: Практическое руководство. Анимация трехмерных преобразований
ms.date: 03/30/2017
helpviewer_keywords:
- animation [WPF], 3-D translations
- 3-D translations [WPF], animating
ms.assetid: d4eece1f-0cd2-4a2c-8370-293354c380e4
ms.openlocfilehash: 3e27c2d5f0cd44235a1d897b1b8f057808ae6bd8
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59168276"
---
# <a name="how-to-animate-3-d-translations"></a>Практическое руководство. Анимация трехмерных преобразований
В этом разделе показано, как анимировать преобразования перевода на [!INCLUDE[TLA#tla_3d](../../../../includes/tlasharptla-3d-md.md)] модели.  
  
 В приведенном ниже коде показано применение <xref:System.Windows.Media.Media3D.TranslateTransform3D> объект <xref:System.Windows.Media.Media3D.Model3D.Transform%2A> свойство <xref:System.Windows.Media.Media3D.GeometryModel3D>.  
  
 [!code-xaml[Animation3DGallery_snip#Translation3DAnimationInline1](~/samples/snippets/csharp/VS_Snippets_Wpf/Animation3DGallery_snip/CS/Translation3DAnimationExample.xaml#translation3danimationinline1)]  
  
 <xref:System.Windows.Media.Media3D.TranslateTransform3D.OffsetX%2A> Свойства данного объекта <xref:System.Windows.Media.Media3D.TranslateTransform3D> объекта анимируется с помощью следующего кода.  
  
 [!code-xaml[Animation3DGallery_snip#Translation3DAnimationInline2](~/samples/snippets/csharp/VS_Snippets_Wpf/Animation3DGallery_snip/CS/Translation3DAnimationExample.xaml#translation3danimationinline2)]  
  
## <a name="example"></a>Пример  
 В следующем коде показано весь пример.  
  
 [!code-xaml[Animation3DGallery_snip#Translation3DAnimationExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/Animation3DGallery_snip/CS/Translation3DAnimationExample.xaml#translation3danimationexamplewholepage)]  
  
## <a name="see-also"></a>См. также

- [Общие сведения об эффектах анимации](animation-overview.md)
- [Создание трехмерной сцены](how-to-create-a-3-d-scene.md)
- [Обзор трехмерной графики](3-d-graphics-overview.md)
- [Общие сведения о классах Transform](transforms-overview.md)

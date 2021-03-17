---
title: Практическое руководство. Преобразование масштаба трехмерной модели
ms.date: 03/30/2017
helpviewer_keywords:
- scaling [WPF], 3-D objects
- 3-D objects [WPF], scaling
ms.assetid: f3fdfe33-f7dc-44b0-84a5-e43b89947f35
ms.openlocfilehash: 6d668de08201d819ce9f8752bedf6c388a6bc718
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59165091"
---
# <a name="how-to-transform-the-scale-of-a-3-d-model"></a>Практическое руководство. Преобразование масштаба трехмерной модели
В этом примере показано, как масштабировать трехмерного объекта. Чтобы увеличить трехмерного объекта, используйте <xref:System.Windows.Media.Media3D.ScaleTransform3D>. <xref:System.Windows.Media.Media3D.ScaleTransform3D.ScaleX%2A>, <xref:System.Windows.Media.Media3D.ScaleTransform3D.ScaleY%2A>, И <xref:System.Windows.Media.Media3D.ScaleTransform3D.ScaleZ%2A> свойства изменения размеров элемента с определенным коэффициентом. Например <xref:System.Windows.Media.Media3D.ScaleTransform3D.ScaleX%2A> значение 1,5 объект увеличивается на 150 процентов от его исходной ширины. Объект <xref:System.Windows.Media.Media3D.ScaleTransform3D.ScaleY%2A> значение 0,5 сжимает высоту объекта на 50 процентов. В приведенном ниже коде показано использование <xref:System.Windows.Media.Media3D.ScaleTransform3D> как преобразование для <xref:System.Windows.Media.Media3D.GeometryModel3D>.  
  
 [!code-xaml[3DGallery_snip#ScaleTransform3DExampleInline1](~/samples/snippets/csharp/VS_Snippets_Wpf/3DGallery_snip/CS/ScaleTransform3DExample.xaml#scaletransform3dexampleinline1)]  
  
## <a name="example"></a>Пример  
 В следующем коде показано весь пример.  
  
 [!code-xaml[3DGallery_snip#ScaleTransform3DExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/3DGallery_snip/CS/ScaleTransform3DExample.xaml#scaletransform3dexamplewholepage)]  
  
## <a name="see-also"></a>См. также

- [Анимация трехмерных преобразований](how-to-animate-3-d-translations.md)
- [Создание трехмерной сцены](how-to-create-a-3-d-scene.md)
- [Обзор трехмерной графики](3-d-graphics-overview.md)

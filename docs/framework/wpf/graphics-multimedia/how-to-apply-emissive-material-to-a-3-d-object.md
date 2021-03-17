---
title: Практическое руководство. Применение эмиссионного материала к трехмерному объекту
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- EmissiveMaterial [WPF], applying to 3-D objects
- 3-D objects [WPF], applying EmissiveMaterial
ms.assetid: fd442cc2-5adc-487a-ba70-e45ed54bb3b4
ms.openlocfilehash: b898148fa07950e3ad1eddcaf9206f7d6a837241
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59163128"
---
# <a name="how-to-apply-emissive-material-to-a-3-d-object"></a>Практическое руководство. Применение эмиссионного материала к трехмерному объекту
В следующем примере показано, как использовать <xref:System.Windows.Media.Media3D.EmissiveMaterial> добавить цвет в существующий материал, равный цвету кисти EmissiveMaterial. В коде ниже показан <xref:System.Windows.Media.Media3D.DiffuseMaterial> и <xref:System.Windows.Media.Media3D.EmissiveMaterial> примененные вместе для добавления синего цвета во внешний вид DiffuseMaterial.  
  
 [!code-xaml[3DGallery_snip#EmmisiveMaterialAnimationExampleInline1](~/samples/snippets/csharp/VS_Snippets_Wpf/3DGallery_snip/CS/EmissiveMaterialExample.xaml#emmisivematerialanimationexampleinline1)]  
  
 В процедурном коде:  
  
 [!code-csharp[3DGallery_procedural_snip#EmissiveMaterialCodeExampleInline1](~/samples/snippets/csharp/VS_Snippets_Wpf/3DGallery_procedural_snip/CSharp/EmissiveMaterialExample.cs#emissivematerialcodeexampleinline1)]
 [!code-vb[3DGallery_procedural_snip#EmissiveMaterialCodeExampleInline1](~/samples/snippets/visualbasic/VS_Snippets_Wpf/3DGallery_procedural_snip/visualbasic/emissivematerialexample.vb#emissivematerialcodeexampleinline1)]  
  
## <a name="example"></a>Пример  
 В следующем коде показано весь пример в XAML.  
  
 [!code-xaml[3DGallery_snip#EmissiveMaterialExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/3DGallery_snip/CS/EmissiveMaterialExample.xaml#emissivematerialexamplewholepage)]  
  
## <a name="example"></a>Пример  
 Ниже приведен пример целиком в процедурном коде.  
  
 [!code-csharp[3DGallery_procedural_snip#EmissiveMaterialCodeExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/3DGallery_procedural_snip/CSharp/EmissiveMaterialExample.cs#emissivematerialcodeexamplewholepage)]
 [!code-vb[3DGallery_procedural_snip#EmissiveMaterialCodeExampleWholePage](~/samples/snippets/visualbasic/VS_Snippets_Wpf/3DGallery_procedural_snip/visualbasic/emissivematerialexample.vb#emissivematerialcodeexamplewholepage)]  
  
## <a name="see-also"></a>См. также

- [Создание трехмерной сцены](how-to-create-a-3-d-scene.md)
- [Обзор трехмерной графики](3-d-graphics-overview.md)
- [Анимация свойств материалов в трехмерной сцене](how-to-animate-material-properties-in-a-3-d-scene.md)
- [Применение материала к лицевой и обратной стороне трехмерного объекта](how-to-apply-material-to-the-front-and-back-of-a-3-d-object.md)

---
title: Практическое руководство. Применение рисования к трехмерной модели
ms.date: 03/30/2017
helpviewer_keywords:
- drawings [WPF], applying to 3-D models
- 3-D models [WPF], applying drawings to
ms.assetid: 68357577-b7fc-446e-8be9-a8cc7df3a350
ms.openlocfilehash: a20b89a7359fc85d9790ac02dd2b173452df8c22
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59125038"
---
# <a name="how-to-apply-a-drawing-to-a-3-d-model"></a>Практическое руководство. Применение рисования к трехмерной модели
В этом примере показано, как использовать <xref:System.Windows.Media.DrawingBrush> как <xref:System.Windows.Media.Media3D.Material> применяется к 3D модели.  
  
 В следующем коде определяется <xref:System.Windows.Media.DrawingGroup> как содержимое <xref:System.Windows.Media.DrawingBrush>.  <xref:System.Windows.Media.DrawingBrush> Задается как <xref:System.Windows.Media.Media3D.DiffuseMaterial.Brush%2A> свойство <xref:System.Windows.Media.Media3D.DiffuseMaterial> применяется к [!INCLUDE[TLA2#tla_3d](../../../../includes/tla2sharptla-3d-md.md)] плоскости.  
  
 **Примечание.** Часто желательно, чтобы определить сложные объекты и значения, как на рисунке ниже как ресурсы, которые можно использовать повторно и упростить код. См. в разделе [ресурсы XAML](../advanced/xaml-resources.md) Дополнительные сведения.  
  
 [!code-xaml[3DGallery_snip#ApplyDrawingToMaterialInline1](~/samples/snippets/csharp/VS_Snippets_Wpf/3DGallery_snip/CS/ApplyDrawingToMaterialExample.xaml#applydrawingtomaterialinline1)]  
  
## <a name="example"></a>Пример  
 В следующем коде показано весь пример.  
  
 [!code-xaml[3DGallery_snip#ApplyDrawingToMaterialExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/3DGallery_snip/CS/ApplyDrawingToMaterialExample.xaml#applydrawingtomaterialexamplewholepage)]  
  
## <a name="see-also"></a>См. также

- [Ресурсы XAML](../advanced/xaml-resources.md)
- [Создание трехмерной сцены](how-to-create-a-3-d-scene.md)
- [Обзор объектов Drawing](drawing-objects-overview.md)
- [Обзор трехмерной графики](3-d-graphics-overview.md)

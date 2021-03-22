---
title: Практическое руководство. Создание трехмерной сцены
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- scenes [WPF], 3-D
- 3-D scenes
ms.assetid: adb4a598-71a2-4dd5-b677-ea3fc11b78b2
ms.openlocfilehash: 8e176cb437055787da86d56770dd71323134fa33
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59126234"
---
# <a name="how-to-create-a-3-d-scene"></a>Практическое руководство. Создание трехмерной сцены
В этом примере демонстрируется создание трехмерного объекта, который выглядит как плоский листа бумаги, вращающийся. Объект <xref:System.Windows.Controls.Viewport3D> вместе с следующие компоненты, используются для создания этой простой трехмерной сцены:  
  
-   Камера создается с помощью <xref:System.Windows.Media.Media3D.PerspectiveCamera>. Камеры указывает, какая часть трехмерной сцены можно просматривать.  
  
-   Сетка создается для задания формы трехмерного объекта (лист бумаги) с помощью <xref:System.Windows.Media.Media3D.GeometryModel3D.Geometry%2A> свойство <xref:System.Windows.Media.Media3D.GeometryModel3D>.  
  
-   Материал указывается отображаемый на поверхности объекта (линейного градиента в этом образце) с помощью <xref:System.Windows.Media.Media3D.GeometryModel3D.Material%2A> свойство <xref:System.Windows.Media.Media3D.GeometryModel3D>.  
  
-   Источник света создается для освещения объекта с помощью <xref:System.Windows.Media.Media3D.DirectionalLight>.  
  
## <a name="example"></a>Пример  
 В приведенном ниже коде показано, как создание трехмерной сцены в XAML.  
  
 [!code-xaml[3DGallery_snip#Basic3DShapeExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/3DGallery_snip/CS/Basic3DShapeExample.xaml#basic3dshapeexamplewholepage)]  
  
## <a name="example"></a>Пример  
 В приведенном ниже коде показано создание одной и той же трехмерной сцены в процедурном коде.  
  
 [!code-csharp[3DGallery_procedural_snip#Basic3DShapeCodeExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/3DGallery_procedural_snip/CSharp/Basic3DShapeExample.cs#basic3dshapecodeexamplewholepage)]
   
  
## <a name="see-also"></a>См. также

- [Обзор трехмерной графики](3-d-graphics-overview.md)

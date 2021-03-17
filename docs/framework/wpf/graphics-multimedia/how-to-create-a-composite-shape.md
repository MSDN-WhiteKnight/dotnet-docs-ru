---
title: Практическое руководство. Создание составной фигуры
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- shapes [WPF], composite
- composite shapes [WPF]
- graphics [WPF], composite shapes
ms.assetid: 8e5c7ef4-d7ed-4c43-afc9-ca01325c300b
ms.openlocfilehash: de9f7972c7a51ea623c3630fe62bb48f6109317e
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57353495"
---
# <a name="how-to-create-a-composite-shape"></a>Практическое руководство. Создание составной фигуры
В этом примере демонстрируется создание составной фигуры, применив <xref:System.Windows.Media.Geometry> объектов и отобразить их с помощью <xref:System.Windows.Shapes.Path> элемент. В следующем примере <xref:System.Windows.Media.LineGeometry>, <xref:System.Windows.Media.EllipseGeometry>и <xref:System.Windows.Media.RectangleGeometry> используются с <xref:System.Windows.Media.GeometryGroup> Создание составной фигуры. Затем рисуются фигуры с помощью <xref:System.Windows.Shapes.Path> элемент.  
  
## <a name="example"></a>Пример  
 [!code-xaml[GeometrySample#19](~/samples/snippets/csharp/VS_Snippets_Wpf/GeometrySample/CS/combininggeometriesexample.xaml#19)]  
  
 [!code-csharp[GeometriesMiscSnippets_procedural_snip#CompositeShapeCodeExampleInline1](~/samples/snippets/csharp/VS_Snippets_Wpf/GeometriesMiscSnippets_procedural_snip/CSharp/CompositeShapeExample.cs#compositeshapecodeexampleinline1)]
 [!code-vb[GeometriesMiscSnippets_procedural_snip#CompositeShapeCodeExampleInline1](~/samples/snippets/visualbasic/VS_Snippets_Wpf/GeometriesMiscSnippets_procedural_snip/visualbasic/compositeshapeexample.vb#compositeshapecodeexampleinline1)]  
  
 На следующем рисунке показана фигура, созданная в предыдущем примере.  
  
 ![Составной геометрический объект, созданная с использованием GeometryGroup](./media/wcpsdk-graphicsmm-compositegeometryexample1.jpg "wcpsdk_graphicsmm_compositegeometryexample1")  
Составные геометрические объекты  
  
 Более сложные фигуры, например, многоугольники и фигур с помощью сегментов кривых могут быть созданы с помощью <xref:System.Windows.Media.PathGeometry>. Пример, демонстрирующий создание фигуры с помощью <xref:System.Windows.Media.PathGeometry>, см. в разделе [Создание фигуры с помощью PathGeometry](how-to-create-a-shape-by-using-a-pathgeometry.md).  Несмотря на то, что в этом примере отображает фигуру на экране при помощи <xref:System.Windows.Shapes.Path> элемент, <xref:System.Windows.Media.Geometry> объектов может также использоваться для описания содержимого <xref:System.Windows.Media.GeometryDrawing> или <xref:System.Windows.Media.DrawingContext>. Они также могут использоваться для обрезки и проверки нажатия.  
  
 Этот пример является частью большего примера; полный пример см. в разделе [Пример геометрических объектов](https://go.microsoft.com/fwlink/?LinkID=159989).

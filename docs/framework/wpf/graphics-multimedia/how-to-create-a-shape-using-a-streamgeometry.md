---
title: Практическое руководство. Создание фигуры с помощью объекта StreamGeometry
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- graphics [WPF], shapes
- shapes [WPF], creating with StreamGeometry class
ms.assetid: 08f7c8ce-074b-49cd-9aba-cc9592d4ee51
ms.openlocfilehash: fd191e4cfdfa33c144389d4871a9641e9c811ed3
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59108606"
---
# <a name="how-to-create-a-shape-using-a-streamgeometry"></a>Практическое руководство. Создание фигуры с помощью объекта StreamGeometry
<xref:System.Windows.Media.StreamGeometry> — Упрощенная альтернатива <xref:System.Windows.Media.PathGeometry> для создания геометрических фигур. Используйте <xref:System.Windows.Media.StreamGeometry> для описания сложной геометрии, но не требуется поддержка привязки данных, анимации или изменения. Например, из-за своей эффективности <xref:System.Windows.Media.StreamGeometry> класс хорошо подходит для описания графических элементов.  
  
## <a name="example"></a>Пример  
 В следующем примере синтаксис атрибутов для создания треугольного <xref:System.Windows.Media.StreamGeometry> в XAML.  
  
 [!code-xaml[GeometriesMiscSnippets_snip#StreamGeometryTriangleExampleWholePage](~/samples/snippets/xaml/VS_Snippets_Wpf/GeometriesMiscSnippets_snip/XAML/StreamGeometryExample.xaml#streamgeometrytriangleexamplewholepage)]  
  
 Дополнительные сведения о <xref:System.Windows.Media.StreamGeometry> синтаксис атрибута, см. в разделе [синтаксис разметки пути](path-markup-syntax.md) страницы.  
  
## <a name="example"></a>Пример  
 В следующем примере используется <xref:System.Windows.Media.StreamGeometry> для определения треугольника в коде. Во-первых, в примере создается <xref:System.Windows.Media.StreamGeometry>, затем получает <xref:System.Windows.Media.StreamGeometryContext> и использует его для описания треугольника.  
  
 [!code-csharp[GeometriesMiscSnippets_procedural_snip#StreamGeometryTriangleExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/GeometriesMiscSnippets_procedural_snip/CSharp/StreamGeometryTriangleExample.cs#streamgeometrytriangleexamplewholepage)]
   
  
## <a name="example"></a>Пример  
 В следующем примере создается метод, который использует <xref:System.Windows.Media.StreamGeometry> и <xref:System.Windows.Media.StreamGeometryContext> для определения геометрической фигуры на основе указанных параметров.  
  
 [!code-csharp[GeometriesMiscSnippets_procedural_snip#StreamGeometryExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/GeometriesMiscSnippets_procedural_snip/CSharp/StreamGeometryExample.cs#streamgeometryexamplewholepage)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.PathGeometry>
- <xref:System.Windows.Media.StreamGeometry>
- <xref:System.Windows.Media.StreamGeometryContext>
- [Создание фигуры с помощью объекта PathGeometry](how-to-create-a-shape-by-using-a-pathgeometry.md)
- [Общие сведения о классе Geometry](geometry-overview.md)

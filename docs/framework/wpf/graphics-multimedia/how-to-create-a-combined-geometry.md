---
title: Практическое руководство. Создание объединенных геометрических объектов
ms.date: 03/30/2017
helpviewer_keywords:
- combining geometries [WPF]
- graphics [WPF], combining geometries
- geometries [WPF], combining
ms.assetid: 54c3277c-6b6e-4b25-91be-fda0bbc706b4
ms.openlocfilehash: c5ebe87abd4c2cf70f8fa17f1fcc773293f3ad27
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57364792"
---
# <a name="how-to-create-a-combined-geometry"></a>Практическое руководство. Создание объединенных геометрических объектов
В этом примере показано, как для объединения геометрических объектов. Чтобы объединить два геометрических объекта, используйте <xref:System.Windows.Media.CombinedGeometry> объекта. Задать его <xref:System.Windows.Media.CombinedGeometry.Geometry1%2A> и <xref:System.Windows.Media.CombinedGeometry.Geometry2%2A> свойства два геометрических объекта для объединения и установить <xref:System.Windows.Media.CombinedGeometry.GeometryCombineMode%2A> свойство, которое определяет, каким образом геометрические объекты будут объединяться, чтобы `Union`, `Intersect`, `Exclude`, или `Xor`.  
  
 Чтобы создать составной геометрический объект из двух или более геометрических объектов, используйте <xref:System.Windows.Media.GeometryGroup>.  
  
## <a name="example"></a>Пример  
 В следующем примере <xref:System.Windows.Media.CombinedGeometry> определяется с режимом объединения геометрических `Exclude`.  Оба <xref:System.Windows.Media.CombinedGeometry.Geometry1%2A> и <xref:System.Windows.Media.CombinedGeometry.Geometry2%2A> определяются как круги одного радиуса, но со смещением центров на 50.  
  
 [!code-xaml[GeometrySample#21](~/samples/snippets/csharp/VS_Snippets_Wpf/GeometrySample/CS/combininggeometriesexample.xaml#21)]  
  
 ![Исключить результаты объединенного режима](./media/mil-task-combined-geometry-exclude.PNG "mil_task_combined_geometry_exclude")  
Исключить объединенных геометрических объектов  
  
 В следующей разметке <xref:System.Windows.Media.CombinedGeometry> определяется с режимом объединения `Intersect`.  Оба <xref:System.Windows.Media.CombinedGeometry.Geometry1%2A> и <xref:System.Windows.Media.CombinedGeometry.Geometry2%2A> определяются как круги одного радиуса, но со смещением центров на 50.  
  
 [!code-xaml[GeometrySample#22](~/samples/snippets/csharp/VS_Snippets_Wpf/GeometrySample/CS/combininggeometriesexample.xaml#22)]  
  
 ![Intersect результаты объединенного режима](./media/mil-task-combined-geometry-intersect.PNG "mil_task_combined_geometry_intersect")  
Intersect объединенных геометрических объектов  
  
 В следующей разметке <xref:System.Windows.Media.CombinedGeometry> определяется с режимом объединения `Union`.  Оба <xref:System.Windows.Media.CombinedGeometry.Geometry1%2A> и <xref:System.Windows.Media.CombinedGeometry.Geometry2%2A> определяются как круги одного радиуса, но со смещением центров на 50.  
  
 [!code-xaml[GeometrySample#23](~/samples/snippets/csharp/VS_Snippets_Wpf/GeometrySample/CS/combininggeometriesexample.xaml#23)]  
  
 ![Результаты объединения в режиме Union ](./media/mil-task-combined-geometry-union.PNG "mil_task_combined_geometry_union")  
Объединение объединенных геометрических объектов  
  
 В следующей разметке <xref:System.Windows.Media.CombinedGeometry> определяется с режимом объединения `Xor`.  Оба <xref:System.Windows.Media.CombinedGeometry.Geometry1%2A> и <xref:System.Windows.Media.CombinedGeometry.Geometry2%2A> определяются как круги одного радиуса, но со смещением центров на 50.  
  
 [!code-xaml[GeometrySample#24](~/samples/snippets/csharp/VS_Snippets_Wpf/GeometrySample/CS/combininggeometriesexample.xaml#24)]  
  
 ![Результаты объединения в режиме Xor ](./media/mil-task-combined-geometry-xor.PNG "mil_task_combined_geometry_xor")  
Xor объединенных геометрических объектов

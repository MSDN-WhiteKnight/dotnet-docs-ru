---
title: Практическое руководство. Проверка нажатия с использованием геометрии в качестве параметра
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- hit tests [WPF], on visual objects using Geometry objects [WPF]
- visual objects [WPF], hit tests on
- Geometry objects [WPF], hit tests on visual objects [WPF]
ms.assetid: 6c8bdbf2-19e0-4fbb-bf89-c1252b2ebc61
ms.openlocfilehash: 73420d6ae1386676ed900e91b3951df9e0934db8
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59100968"
---
# <a name="how-to-hit-test-using-geometry-as-a-parameter"></a>Практическое руководство. Проверка нажатия с использованием геометрии в качестве параметра
В этом примере показано, как выполнить проверку попадания для визуального объекта с помощью <xref:System.Windows.Media.Geometry> параметра проверки нажатия.  
  
## <a name="example"></a>Пример  
 Приведенный ниже показано, как выполнить настройку проверки попадания с помощью <xref:System.Windows.Media.GeometryHitTestParameters> для <xref:System.Windows.Media.VisualTreeHelper.HitTest%2A> метод. <xref:System.Windows.Point> Значение, передаваемое `OnMouseDown` метод используется для создания <xref:System.Windows.Media.Geometry> объекта для расширения диапазона проверки попадания.  
  
 [!code-csharp[HitTestingOverview#HitTestingOverviewSnippet10](~/samples/snippets/csharp/VS_Snippets_Wpf/HitTestingOverview/CSharp/GeometryHitTest.cs#hittestingoverviewsnippet10)]
 [!code-vb[HitTestingOverview#HitTestingOverviewSnippet10](~/samples/snippets/visualbasic/VS_Snippets_Wpf/HitTestingOverview/visualbasic/geometryhittest.vb#hittestingoverviewsnippet10)]  
  
 <xref:System.Windows.Media.GeometryHitTestResult.IntersectionDetail%2A> Свойство <xref:System.Windows.Media.GeometryHitTestResult> предоставляет сведения о результатах проверки нажатия, который использует <xref:System.Windows.Media.Geometry> параметра проверки нажатия. На следующем рисунке показана связь между геометрическим объектом проверки нажатия (синий круг) и отображенным содержимым целевого визуального объекта (красный квадрат).  
  
 ![Схема, показывающая IntersectionDetail, используемая в проверке нажатия.](./media/how-to-hit-test-using-geometry-as-a-parameter/intersectiondetail-hit-test.png)  
  
 Приведенный ниже показано, как реализовать обратный вызов проверки нажатия при <xref:System.Windows.Media.Geometry> используется в качестве параметра проверки нажатия. `result` Параметр приводится к <xref:System.Windows.Media.GeometryHitTestResult> для извлечения значения <xref:System.Windows.Media.GeometryHitTestResult.IntersectionDetail%2A> свойство. Это значение позволяет определить, если <xref:System.Windows.Media.Geometry> параметр проверки нажатия полностью или частично содержится в отображаемом содержимом целевого объекта проверки нажатия. В этом случае пример кода только добавляет результаты проверки попадания в список визуальных объектов, которые полностью содержатся в пределах границ целевого объекта.  
  
 [!code-csharp[HitTestingOverview#HitTestingOverviewSnippet11](~/samples/snippets/csharp/VS_Snippets_Wpf/HitTestingOverview/CSharp/GeometryHitTest.cs#hittestingoverviewsnippet11)]
 [!code-vb[HitTestingOverview#HitTestingOverviewSnippet11](~/samples/snippets/visualbasic/VS_Snippets_Wpf/HitTestingOverview/visualbasic/geometryhittest.vb#hittestingoverviewsnippet11)]  
  
> [!NOTE]
>  <xref:System.Windows.Media.HitTestResult> Обратного вызова не должен быть вызван, если пересечения — <xref:System.Windows.Media.IntersectionDetail.Empty>.  
  
## <a name="see-also"></a>См. также

- [Проверка попадания на визуальном уровне](hit-testing-in-the-visual-layer.md)
- [Проверка попадания геометрического объекта в визуальный объект](how-to-hit-test-geometry-in-a-visual.md)

---
title: 'Оптимизация производительности: Ресурсы приложений'
ms.date: 03/30/2017
helpviewer_keywords:
- application resources [WPF], performance
- resources [WPF], performance
- static resources [WPF]
- sharing resources [WPF]
- brushes [WPF], performance
- sharing brushes without copying [WPF]
ms.assetid: 62b88488-c08e-4804-b7de-a1c34fbe929c
ms.openlocfilehash: 362d0f0fd3282365e5e05dcd43c49a9fd2ddc9a7
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59139429"
---
# <a name="optimizing-performance-application-resources"></a>Оптимизация производительности: Ресурсы приложений
[!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] позволяет совместно использовать ресурсы приложения таким образом, можно поддерживать согласованный вид или поведение с помощью элементов одинакового типа. Этот раздел содержит несколько рекомендаций в этой области, которые могут помочь повысить производительность приложений.  
  
 Дополнительные сведения о ресурсах см. в разделе [Ресурсы XAML](xaml-resources.md).  
  
## <a name="sharing-resources"></a>Совместное использование ресурсов  
 Если приложение использует пользовательские элементы управления и определяет ресурсы в <xref:System.Windows.ResourceDictionary> (или узел ресурсов XAML), рекомендуется определить ресурсы на <xref:System.Windows.Application> или <xref:System.Windows.Window> объекта уровень, или их определения в тему по умолчанию для пользовательские элементы управления. Определение ресурсов в пользовательский элемент управления <xref:System.Windows.ResourceDictionary> оказывает влияние на производительность для каждого экземпляра этого элемента управления. Например при наличии кисть производительность операций, определенных как часть определения ресурсов для пользовательского элемента управления и несколько экземпляров пользовательского элемента управления, рабочего набора приложения будет значительно увеличить.  
  
 Чтобы проиллюстрировать это, необходимо учитывайте следующее. Предположим, вы разрабатываете карточки игр с помощью [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]. Для большинства карточных игр необходимо 52 карты с 52 разных лиц. Вы решили реализовать пользовательский элемент управления карты и определить 52 кисти (каждый из которых представляет лицевой стороны) в ресурсах карты пользовательского элемента управления. В главном приложении первоначально создается 52 экземпляра этого элемента управления. Каждый экземпляр элемента управления создает 52 экземпляра <xref:System.Windows.Media.Brush> объекты, которые в итоге 52 * 52 дает <xref:System.Windows.Media.Brush> объектов в приложении. Перемещая кисти из ресурсов пользовательского элемента управления к <xref:System.Windows.Application> или <xref:System.Windows.Window> уровне объекта или определяя их в тему по умолчанию для пользовательского элемента управления, можно уменьшить рабочего набора приложения, так как теперь общего 52 кисти 52 экземпляра элемента управления.  
  
## <a name="sharing-a-brush-without-copying"></a>Совместное использование кистей без копирования  
 Если у вас есть несколько элементов, используя те же <xref:System.Windows.Media.Brush> объекта, определение кисть как ресурс и создание ссылки, но не определение встроенной кисти в [!INCLUDE[TLA#tla_titlexaml](../../../../includes/tlasharptla-titlexaml-md.md)]. Этот метод будет создать один экземпляр и повторно использует его, тогда как определение встроенной кисти в [!INCLUDE[TLA#tla_titlexaml](../../../../includes/tlasharptla-titlexaml-md.md)] создает новый экземпляр для каждого элемента.  
  
 В следующем примере разметки показано этой точки.  
  
 [!code-xaml[Performance#PerformanceSnippet7](~/samples/snippets/csharp/VS_Snippets_Wpf/Performance/CSharp/BrushResource.xaml#performancesnippet7)]  
  
## <a name="use-static-resources-when-possible"></a>Используйте статические ресурсы, когда это возможно  
 Статический ресурс обеспечивает значение для любого атрибута свойства XAML, поиска ссылки на уже определенный ресурс. Поведение подстановки для этого ресурса является аналогом во время компиляции.  
  
 Динамический ресурс, с другой стороны, создаст временное выражение во время первоначальной компиляции и таким образом, отложит для ресурсов, пока значение запрошенного ресурса не нужен для создания объекта. Поведение подстановки для этого ресурса аналогичен во время выполнения, который оказывает влияние на производительность. Используйте статические ресурсы, когда это возможно в приложении, с помощью динамические ресурсы только при необходимости.  
  
 В следующем примере разметки показано использование обоих типов ресурсов:  
  
 [!code-xaml[Performance#PerformanceSnippet8](~/samples/snippets/csharp/VS_Snippets_Wpf/Performance/CSharp/DynamicResource.xaml#performancesnippet8)]  
  
## <a name="see-also"></a>См. также

- [Улучшение производительности приложений WPF](optimizing-wpf-application-performance.md)
- [Планирование производительности приложения](planning-for-application-performance.md)
- [Использование преимуществ оборудования](optimizing-performance-taking-advantage-of-hardware.md)
- [Разметка и разработка](optimizing-performance-layout-and-design.md)
- [Двумерная графика и изображения](optimizing-performance-2d-graphics-and-imaging.md)
- [Поведение объекта](optimizing-performance-object-behavior.md)
- [Текста](optimizing-performance-text.md)
- [Привязка данных](optimizing-performance-data-binding.md)
- [Дополнительные рекомендации по повышению производительности](optimizing-performance-other-recommendations.md)

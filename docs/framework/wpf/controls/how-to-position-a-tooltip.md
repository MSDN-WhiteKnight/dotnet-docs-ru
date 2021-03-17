---
title: Практическое руководство. Определение положения всплывающей подсказки
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- ToolTip control [WPF], positioning
- positioning ToolTip controls [WPF]
ms.assetid: cddf3757-9e5f-4ce3-a6eb-44489cf3804a
ms.openlocfilehash: 811818fe6e7c0d8ce9e2aa058b42bf592ada4b92
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59212353"
---
# <a name="how-to-position-a-tooltip"></a>Практическое руководство. Определение положения всплывающей подсказки
В этом примере показано, как для указания положения всплывающей подсказки на экране.  
  
## <a name="example"></a>Пример  
 Можно положения всплывающей подсказки с помощью набора пять свойств, которые определены в обоих <xref:System.Windows.Controls.ToolTip> и <xref:System.Windows.Controls.ToolTipService> классы. В следующей таблице показаны эти два набора пять свойств и ссылки на справочную документацию в соответствии с классом.  
  
### <a name="corresponding-tooltip-properties-according-to-class"></a>Соответствующие свойства всплывающей подсказки в соответствии с классом  
  
|<xref:System.Windows.Controls.ToolTip?displayProperty=nameWithType> свойствами класса,|<xref:System.Windows.Controls.ToolTipService?displayProperty=nameWithType> свойствами класса,|  
|--------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------|  
|<xref:System.Windows.Controls.ToolTip.Placement%2A?displayProperty=nameWithType>|<xref:System.Windows.Controls.ToolTipService.Placement%2A?displayProperty=nameWithType>|  
|<xref:System.Windows.Controls.ToolTip.PlacementTarget%2A?displayProperty=nameWithType>|<xref:System.Windows.Controls.ToolTipService.PlacementTarget%2A?displayProperty=nameWithType>|  
|<xref:System.Windows.Controls.ToolTip.PlacementRectangle%2A?displayProperty=nameWithType>|<xref:System.Windows.Controls.ToolTipService.PlacementRectangle%2A?displayProperty=nameWithType>|  
|<xref:System.Windows.Controls.ToolTip.HorizontalOffset%2A?displayProperty=nameWithType>|<xref:System.Windows.Controls.ToolTipService.HorizontalOffset%2A?displayProperty=nameWithType>|  
|<xref:System.Windows.Controls.ToolTip.VerticalOffset%2A?displayProperty=nameWithType>|<xref:System.Windows.Controls.ToolTipService.VerticalOffset%2A?displayProperty=nameWithType>|  
  
 Если определить содержимое всплывающей подсказки с помощью <xref:System.Windows.Controls.ToolTip> объекта, можно использовать свойства любого класса, однако <xref:System.Windows.Controls.ToolTipService> свойства имеют приоритет. Используйте <xref:System.Windows.Controls.ToolTipService> свойства для подсказки, которые не определены как <xref:System.Windows.Controls.ToolTip> объектов.  
  
 На следующих рисунках положения всплывающей подсказки с помощью этих свойств. Несмотря на то что, [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] примерах в этих примерах показано, как задать свойства, которые определяются <xref:System.Windows.Controls.ToolTip> класса, соответствующего свойства <xref:System.Windows.Controls.ToolTipService> класс следуют тем же правилам макета. Дополнительные сведения о возможных значениях свойства размещения см. в разделе [поведение при размещении контекстного меню](popup-placement-behavior.md).  
 
 На следующем рисунке показано положение подсказки с помощью свойства размещения:  
  
 ![Схема, показывающая положение подсказки с помощью свойства размещения.](./media/how-to-position-a-tooltip/tooltip-placement-property.png)
 
 На следующем рисунке показано положение подсказки с помощью свойства размещения и PlacementRectangle:   

 ![Схема, показывающая положение подсказки с помощью свойства PlacementRectangle.](./media/how-to-position-a-tooltip/tooltip-placement-rectangle-property.png)  
 
 На следующем рисунке показано положение подсказки с помощью свойств Placement, PlacementRectangle и смещение:   
  
 ![Схема, показывающая положение подсказки с помощью свойства смещение.](./media/how-to-position-a-tooltip/tooltip-placement-offset-property.png)

 В следующем примере показано, как использовать <xref:System.Windows.Controls.ToolTip> свойства для указания положения всплывающей подсказки, содержимое которых <xref:System.Windows.Controls.ToolTip> объекта.  
  
 [!code-xaml[ToolTipService#ToolTip](~/samples/snippets/csharp/VS_Snippets_Wpf/ToolTipService/CSharp/Pane1.xaml#tooltip)]  
  
 [!code-csharp[ToolTipService#ToolTipCode](~/samples/snippets/csharp/VS_Snippets_Wpf/ToolTipService/CSharp/Pane1.xaml.cs#tooltipcode)]
 [!code-vb[ToolTipService#ToolTipCode](~/samples/snippets/visualbasic/VS_Snippets_Wpf/ToolTipService/visualbasic/pane1.xaml.vb#tooltipcode)]  
  
 В следующем примере показано, как использовать <xref:System.Windows.Controls.ToolTipService> свойства для указания положения всплывающей подсказки, содержимое которых не <xref:System.Windows.Controls.ToolTip> объекта.  
  
 [!code-xaml[ToolTipService#NoToolTip](~/samples/snippets/csharp/VS_Snippets_Wpf/ToolTipService/CSharp/Pane1.xaml#notooltip)]  
  
 [!code-csharp[ToolTipService#NoToolTipCode](~/samples/snippets/csharp/VS_Snippets_Wpf/ToolTipService/CSharp/Pane1.xaml.cs#notooltipcode)]
 [!code-vb[ToolTipService#NoToolTipCode](~/samples/snippets/visualbasic/VS_Snippets_Wpf/ToolTipService/visualbasic/pane1.xaml.vb#notooltipcode)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.ToolTip>
- <xref:System.Windows.Controls.ToolTipService>
- [Практические руководства](tooltip-how-to-topics.md)
- [Общие сведения о всплывающих подсказках](tooltip-overview.md)

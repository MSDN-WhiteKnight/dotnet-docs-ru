---
title: Практическое руководство. Определение пользовательского расположения контекстного меню
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Popup control [WPF], specifying custom position
ms.assetid: 28c24f39-d3aa-4ee2-b950-384b4a5dab92
ms.openlocfilehash: dc516f0eb1cfcbac6662497eb4019041eefec2a9
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59200588"
---
# <a name="how-to-specify-a-custom-popup-position"></a>Практическое руководство. Определение пользовательского расположения контекстного меню
В этом примере показано, как указать положение условных <xref:System.Windows.Controls.Primitives.Popup> управления <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> свойству <xref:System.Windows.Controls.Primitives.PlacementMode.Custom>.  
  
## <a name="example"></a>Пример  
 Когда <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> свойству <xref:System.Windows.Controls.Primitives.PlacementMode.Custom>, <xref:System.Windows.Controls.Primitives.Popup> вызывает определенный экземпляр <xref:System.Windows.Controls.Primitives.CustomPopupPlacementCallback> делегировать. Этот делегат возвращает набор возможных точек относительно верхнего левого угла области назначения и в верхний левый угол <xref:System.Windows.Controls.Primitives.Popup>. <xref:System.Windows.Controls.Primitives.Popup> Размещения происходит в момент, который предоставляет наилучшую видимость.  
  
 В следующем примере показано, как определить положение <xref:System.Windows.Controls.Primitives.Popup> , задав <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> свойства <xref:System.Windows.Controls.Primitives.PlacementMode.Custom>. Также показано, как создать и назначить <xref:System.Windows.Controls.Primitives.CustomPopupPlacementCallback> делегат для расположения <xref:System.Windows.Controls.Primitives.Popup>.  Делегат обратного вызова возвращает два <xref:System.Windows.Controls.Primitives.CustomPopupPlacement> объектов.  Если <xref:System.Windows.Controls.Primitives.Popup> скрыта за границу экрана позиции первого <xref:System.Windows.Controls.Primitives.Popup> помещается во второе положение.  
  
 [!code-xaml[PopupCustomPlacement#CustomPlacement](~/samples/snippets/csharp/VS_Snippets_Wpf/PopupCustomPlacement/CSharp/Window1.xaml#customplacement)]  
  
 [!code-csharp[PopupCustomPlacement#DelegateInstance](~/samples/snippets/csharp/VS_Snippets_Wpf/PopupCustomPlacement/CSharp/Window1.xaml.cs#delegateinstance)]
 [!code-vb[PopupCustomPlacement#DelegateInstance](~/samples/snippets/visualbasic/VS_Snippets_Wpf/PopupCustomPlacement/visualbasic/window1.xaml.vb#delegateinstance)]  
  
 [!code-csharp[PopupCustomPlacement#DelegateDefinition](~/samples/snippets/csharp/VS_Snippets_Wpf/PopupCustomPlacement/CSharp/Window1.xaml.cs#delegatedefinition)]
 [!code-vb[PopupCustomPlacement#DelegateDefinition](~/samples/snippets/visualbasic/VS_Snippets_Wpf/PopupCustomPlacement/visualbasic/window1.xaml.vb#delegatedefinition)]  
  
 Полный пример см. в разделе [пример размещения всплывающего окна](https://go.microsoft.com/fwlink/?LinkID=160032).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.Primitives.Popup>
- [Общие сведения о контекстном меню](popup-overview.md)
- [Практические руководства](popup-how-to-topics.md)

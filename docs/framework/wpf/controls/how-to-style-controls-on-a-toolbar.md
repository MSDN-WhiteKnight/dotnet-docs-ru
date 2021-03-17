---
title: Практическое руководство. Определение стиля элементов управления на панели инструментов
ms.date: 03/30/2017
helpviewer_keywords:
- styling controls on toolbar [WPF]
- toolbars [WPF]
- customizing controls on toolbar [WPF]
ms.assetid: ba6ae056-d6a9-4c24-90f8-467ab0bc0b1a
ms.openlocfilehash: 580b56ebb47aa7bd50da0a966ccf60f7ea9fb2a7
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59217787"
---
# <a name="how-to-style-controls-on-a-toolbar"></a>Практическое руководство. Определение стиля элементов управления на панели инструментов
<xref:System.Windows.Controls.ToolBar> Определяет <xref:System.Windows.ResourceKey> объектов для задания стиля элементов управления в <xref:System.Windows.Controls.ToolBar>.  Для стиля элемента управления в <xref:System.Windows.Controls.ToolBar>, задайте `x:key` атрибута стиля для <xref:System.Windows.ResourceKey> определенные в <xref:System.Windows.Controls.ToolBar>.  
  
 <xref:System.Windows.Controls.ToolBar> Определяет следующие <xref:System.Windows.ResourceKey> объектов:  
  
-   <xref:System.Windows.Controls.ToolBar.ButtonStyleKey%2A>  
  
-   <xref:System.Windows.Controls.ToolBar.CheckBoxStyleKey%2A>  
  
-   <xref:System.Windows.Controls.ToolBar.ComboBoxStyleKey%2A>  
  
-   <xref:System.Windows.Controls.ToolBar.MenuStyleKey%2A>  
  
-   <xref:System.Windows.Controls.ToolBar.RadioButtonStyleKey%2A>  
  
-   <xref:System.Windows.Controls.ToolBar.SeparatorStyleKey%2A>  
  
-   <xref:System.Windows.Controls.ToolBar.TextBoxStyleKey%2A>  
  
-   <xref:System.Windows.Controls.ToolBar.ToggleButtonStyleKey%2A>  
  
## <a name="example"></a>Пример  
 В следующем примере определяется стили для элементов управления в пределах <xref:System.Windows.Controls.ToolBar>.  
  
 [!code-xaml[ToolBar_snip#ToolBarAllStyles](~/samples/snippets/csharp/VS_Snippets_Wpf/ToolBar_snip/CS/pane1.xaml#toolbarallstyles)]  
[!code-xaml[ToolBar_snip#ToolBar](~/samples/snippets/csharp/VS_Snippets_Wpf/ToolBar_snip/CS/pane1.xaml#toolbar)]  
  
## <a name="see-also"></a>См. также

- [Стилизация и использование шаблонов](styling-and-templating.md)

---
title: Общие сведения об элементе управления ToolStripContainer
ms.date: 03/30/2017
f1_keywords:
- ToolStripContainer
helpviewer_keywords:
- toolbars [Windows Forms], built-in rafting
- ToolStripContainer control [Windows Forms], about ToolStripContainer control
ms.assetid: c7d63bff-64e2-4a63-bd89-d31bc96dacb8
ms.openlocfilehash: c279316c2a372a1498707b27ec8658813306304b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59191267"
---
# <a name="toolstripcontainer-control-overview"></a>Общие сведения об элементе управления ToolStripContainer
Объект <xref:System.Windows.Forms.ToolStripContainer> содержит панели на левой, правой, верхней и нижней сторонах для размещения и нависания <xref:System.Windows.Forms.ToolStrip>, <xref:System.Windows.Forms.MenuStrip>, и <xref:System.Windows.Forms.StatusStrip> элементов управления. Несколько элементов управления <xref:System.Windows.Forms.ToolStrip> располагаются по вертикали, если поместить их в левый или правый контейнер <xref:System.Windows.Forms.ToolStripContainer>. Они располагаются по горизонтали, если поместить их в верхний или нижний контейнер <xref:System.Windows.Forms.ToolStripContainer>. Для размещения традиционных элементов управления в форме может использоваться центральная панель <xref:System.Windows.Forms.ToolStripContentPanel> из контейнера <xref:System.Windows.Forms.ToolStripContainer>.  
  
 Все элементы управления <xref:System.Windows.Forms.ToolStripContainer> непосредственно доступны для выбора во время разработки и могут быть удалены. Каждая панель <xref:System.Windows.Forms.ToolStripContainer> может разворачиваться и сворачиваться и изменять размеры элементов управления, содержащимися в ней.  
  
### <a name="important-toolstripcontainer-members"></a>ToolStripContainer важные члены  
  
|name|Описание|  
|----------|-----------------|  
|<xref:System.Windows.Forms.ToolStripContainer.BottomToolStripPanel%2A>|Получает нижнюю панель <xref:System.Windows.Forms.ToolStripContainer>.|  
|<xref:System.Windows.Forms.ToolStripContainer.BottomToolStripPanelVisible%2A>|Возвращает или задает значение, указывающее, является ли нижняя панель <xref:System.Windows.Forms.ToolStripContainer> является видимым.|  
|<xref:System.Windows.Forms.ToolStripContainer.LeftToolStripPanel%2A>|Получает левую панель <xref:System.Windows.Forms.ToolStripContainer>.|  
|<xref:System.Windows.Forms.ToolStripContainer.LeftToolStripPanelVisible%2A>|Возвращает или задает значение, указывающее, является ли левая панель <xref:System.Windows.Forms.ToolStripContainer> является видимым.|  
|<xref:System.Windows.Forms.ToolStripContainer.RightToolStripPanel%2A>|Получает правую панель контейнера <xref:System.Windows.Forms.ToolStripContainer>.|  
|<xref:System.Windows.Forms.ToolStripContainer.RightToolStripPanelVisible%2A>|Возвращает или задает значение, указывающее, является ли правая панель <xref:System.Windows.Forms.ToolStripContainer> является видимым.|  
|<xref:System.Windows.Forms.ToolStripContainer.TopToolStripPanel%2A>|Получает верхнюю панель контейнера <xref:System.Windows.Forms.ToolStripContainer>.|  
|<xref:System.Windows.Forms.ToolStripContainer.TopToolStripPanelVisible%2A>|Возвращает или задает значение, указывающее, является ли верхняя панель <xref:System.Windows.Forms.ToolStripContainer> является видимым.|  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ToolStripContainer>
- <xref:System.Windows.Forms.ToolStripContentPanel>

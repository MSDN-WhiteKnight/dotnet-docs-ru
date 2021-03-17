---
title: Общие сведения об элементе управления StatusStrip
ms.date: 03/30/2017
f1_keywords:
- StatusStrip
helpviewer_keywords:
- StatusStrip control [Windows Forms], about StatusStrip control
- status bars [Windows Forms], about status bars
ms.assetid: c0d9bcbb-f8b8-46ef-bae2-4146b8c8ce99
ms.openlocfilehash: f6f2d4b19b7ec91c964c72e3aca85e0253c7cc22
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59129718"
---
# <a name="statusstrip-control-overview"></a>Общие сведения об элементе управления StatusStrip
Элемент управления <xref:System.Windows.Forms.StatusStrip> отображает сведения об объекте, который просматривается в <xref:System.Windows.Forms.Form>, компонентах объекта или информации о контексте, относящиеся к работе объекта внутри приложения. Как правило, элемент управления <xref:System.Windows.Forms.StatusStrip> состоит из объектов <xref:System.Windows.Forms.ToolStripStatusLabel>, каждый из которых отображает текст, значок, либо и текст и значок. <xref:System.Windows.Forms.StatusStrip> также могут содержать элементы управления <xref:System.Windows.Forms.ToolStripDropDownButton>, <xref:System.Windows.Forms.ToolStripSplitButton> и <xref:System.Windows.Forms.ToolStripProgressBar>.  
  
 По умолчанию в <xref:System.Windows.Forms.StatusStrip> панели отсутствуют. Чтобы добавить панели в <xref:System.Windows.Forms.StatusStrip>, используйте метод <xref:System.Windows.Forms.ToolStripItemCollection.AddRange%2A?displayProperty=nameWithType>.  
  
 Существует расширенная поддержка обработки элементов <xref:System.Windows.Forms.StatusStrip> и общих команд в Visual Studio.  
  
 Также см. в разделе [редактор коллекции элементов StatusStrip](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/ms233631(v=vs.100)) и [диалоговое окно задач StatusStrip](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/ms233642(v=vs.100)).  
  
 Хотя <xref:System.Windows.Forms.StatusStrip> заменяет и расширяет элемент управления <xref:System.Windows.Forms.StatusBar> предыдущих версий, <xref:System.Windows.Forms.StatusBar> сохраняется для обеспечения обратной совместимости и использования в будущем при его выборе.  
  
### <a name="important-statusstrip-members"></a>Важные члены StatusStrip  
  
|name|Описание|  
|----------|-----------------|  
|<xref:System.Windows.Forms.StatusStrip.CanOverflow%2A>|Возвращает или задает значение, которое указывает, поддерживает ли <xref:System.Windows.Forms.StatusStrip> область переполнения.|  
|<xref:System.Windows.Forms.StatusStrip.Stretch%2A>|Возвращает или задает значение, которое указывает, растягивается ли элемент управления <xref:System.Windows.Forms.StatusStrip> во всю длину в своем контейнере <xref:System.Windows.Forms.ToolStripContainer>.|  
  
### <a name="important-statusstrip-companion-classes"></a>Важные сопутствующие классы StatusStrip  
  
|name|Описание|  
|----------|-----------------|  
|<xref:System.Windows.Forms.ToolStripStatusLabel>|Представляет панель элемента управления <xref:System.Windows.Forms.StatusStrip>.|  
|<xref:System.Windows.Forms.ToolStripDropDownButton>|Отображает связанный <xref:System.Windows.Forms.ToolStripDropDown>, из которого пользователь может выбрать единичный элемент.|  
|<xref:System.Windows.Forms.ToolStripSplitButton>|Представляет элемент управления, состоящий из двух частей, которые являются обычной кнопкой и раскрывающимся меню.|  
|<xref:System.Windows.Forms.ToolStripProgressBar>|Отображает состояние завершения процесса.|  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.StatusStrip>
- <xref:System.Windows.Forms.ToolStripStatusLabel>
- <xref:System.Windows.Forms.ToolStripStatusLabel.Spring%2A>

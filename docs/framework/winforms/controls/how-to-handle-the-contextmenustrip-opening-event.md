---
title: Практическое руководство. Обработка события Opening компонента ContextMenuStrip
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- ContextMenuStrip control [Windows Forms]
- context menus [Windows Forms], event handling
- ToolStrip control [Windows Forms]
- event handling [Windows Forms], context menus
- shortcut menus [Windows Forms], event handling
ms.assetid: b661b3dd-7815-4cc2-a1aa-a9a391ab3427
ms.openlocfilehash: 3001480959ef90cb31048cbcf70aeff1632979fb
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59170722"
---
# <a name="how-to-handle-the-contextmenustrip-opening-event"></a>Практическое руководство. Обработка события Opening компонента ContextMenuStrip
Можно настроить поведение вашей <xref:System.Windows.Forms.ContextMenuStrip> управления путем обработки <xref:System.Windows.Forms.ToolStripDropDown.Opening> событий.  
  
## <a name="example"></a>Пример  
 В следующем примере кода показано, как обрабатывать <xref:System.Windows.Forms.ToolStripDropDown.Opening> событий. Обработчик событий добавляет элементы динамически в <xref:System.Windows.Forms.ContextMenuStrip> элемента управления. Полный пример кода, см. в разделе [как: Динамическое добавление элементов ToolStrip](how-to-add-toolstrip-items-dynamically.md).  
  
 [!code-csharp[System.Windows.Forms.ToolStrip.Misc#42](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.Misc/CS/Program.cs#42)]
   
  
 Задайте <xref:System.ComponentModel.CancelEventArgs.Cancel%2A?displayProperty=nameWithType> свойства `true` чтобы препятствовать открытию меню.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ContextMenuStrip>
- <xref:System.ComponentModel.CancelEventArgs.Cancel%2A>
- <xref:System.Windows.Forms.ToolStripDropDown>
- [Элемент управления ToolStrip](toolstrip-control-windows-forms.md)

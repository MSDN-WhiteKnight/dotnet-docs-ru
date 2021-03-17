---
title: Общие сведения об элементе управления MenuStrip (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- MenuStrip
helpviewer_keywords:
- MenuStrip control [Windows Forms], about MenuStrip control
- menus [Windows Forms], creating
ms.assetid: f45516e5-bf01-4468-b851-d45f4c33c055
ms.openlocfilehash: 7cd761697a09205294727043efc6cf73816803ce
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59144356"
---
# <a name="menustrip-control-overview-windows-forms"></a>Общие сведения об элементе управления MenuStrip (Windows Forms)
Меню предоставлять функциональные возможности для пользователей, команд, сгруппированные по общей теме.  
  
 <xref:System.Windows.Forms.MenuStrip> Элемент управления является новой возможностью в этой версии Visual Studio и .NET Framework. С помощью элемента управления можно легко создать меню, например, используемых в Microsoft Office.  
  
 <xref:System.Windows.Forms.MenuStrip> Элемент управления поддерживает многодокументного интерфейса (MDI) и слияние меню, всплывающие подсказки и переполнения. Можно улучшить удобство использования и меню, добавив ключи доступа, сочетания клавиш, метки, изображения и разделителей.  
  
 <xref:System.Windows.Forms.MenuStrip> Управления заменяет и расширяет его функциональные возможности <xref:System.Windows.Forms.MainMenu> управления; Однако <xref:System.Windows.Forms.MainMenu> элемент управления можно сохранить для обратной совместимости и использования в будущем, если выбран.  
  
## <a name="ways-to-use-the-menustrip-control"></a>Способы использования элемента управления MenuStrip  
 Используйте <xref:System.Windows.Forms.MenuStrip> управления:  
  
-   Создание легко настраиваемых, стандартных меню, которые поддерживают Расширенный пользовательский интерфейс и структура функции, такие как текст и изображения упорядочение и выравнивание, операции перетаскивания и вставки, MDI, переполнения и альтернативные режимы доступа к пунктам меню.  
  
-   Поддерживает типичные внешний вид и поведение операционной системы.  
  
-   Согласованная обработка событий для всех контейнеров и вложенными элементами, так же, обработки событий для других элементов управления.  
  
 В следующей таблице показаны некоторые особенно важно свойства <xref:System.Windows.Forms.MenuStrip> и связанные классы.  
  
|Свойство|Описание|  
|--------------|-----------------|  
|<xref:System.Windows.Forms.MenuStrip.MdiWindowListItem%2A>|Возвращает или задает <xref:System.Windows.Forms.ToolStripMenuItem> , используемый для отображения списка дочерних форм интерфейса MDI.|  
|<xref:System.Windows.Forms.ToolStripItem.MergeAction%2A?displayProperty=nameWithType>|Возвращает или задает способ слияния дочерних меню с родительскими меню в приложениях MDI.|  
|<xref:System.Windows.Forms.ToolStripItem.MergeIndex%2A?displayProperty=nameWithType>|Возвращает или задает положение элемента при слиянии в меню в приложениях MDI.|  
|<xref:System.Windows.Forms.Form.IsMdiContainer%2A?displayProperty=nameWithType>|Возвращает или задает значение, указывающее, находится ли форма контейнером для дочерних MDI-форм.|  
|<xref:System.Windows.Forms.MenuStrip.ShowItemToolTips%2A>|Возвращает или задает значение, указывающее, отображаются ли всплывающие подсказки для <xref:System.Windows.Forms.MenuStrip>.|  
|<xref:System.Windows.Forms.MenuStrip.CanOverflow%2A>|Возвращает или задает значение, которое указывает, поддерживает ли <xref:System.Windows.Forms.MenuStrip> область переполнения.|  
|<xref:System.Windows.Forms.ToolStripMenuItem.ShortcutKeys%2A>|Возвращает или задает сочетания клавиш, связанные с <xref:System.Windows.Forms.ToolStripMenuItem>.|  
|<xref:System.Windows.Forms.ToolStripMenuItem.ShowShortcutKeys%2A>|Получает или задает значение, указывающее, является ли сочетание клавиш, связанных с <xref:System.Windows.Forms.ToolStripMenuItem> , отображаться рядом с <xref:System.Windows.Forms.ToolStripMenuItem>.|  
  
 В следующей таблице показаны важные <xref:System.Windows.Forms.MenuStrip> сопутствующих классов.  
  
|Класс|Описание|  
|-----------|-----------------|  
|<xref:System.Windows.Forms.ToolStripMenuItem>|Представляет отдельные пункты, отображаемые на <xref:System.Windows.Forms.MenuStrip> или <xref:System.Windows.Forms.ContextMenuStrip>.|  
|<xref:System.Windows.Forms.ContextMenuStrip>|Представляет контекстное меню.|  
|<xref:System.Windows.Forms.ToolStripDropDown>|Представляет элемент управления, позволяющий пользователю выбрать один элемент из списка, который отображается, когда пользователь щелкает <xref:System.Windows.Forms.ToolStripDropDownButton> или пункта меню более высокого уровня.|  
|<xref:System.Windows.Forms.ToolStripDropDownItem>|Предоставляет базовую функциональность для элементов управления, производных от <xref:System.Windows.Forms.ToolStripItem> , отображения элементов раскрывающегося списка при нажатии.|  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ToolStrip>
- <xref:System.Windows.Forms.MenuStrip>
- <xref:System.Windows.Forms.ContextMenuStrip>
- <xref:System.Windows.Forms.StatusStrip>
- <xref:System.Windows.Forms.ToolStripItem>
- <xref:System.Windows.Forms.ToolStripDropDown>

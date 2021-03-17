---
title: Общие сведения об элементе управления ToolStrip (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- Toolstrip
helpviewer_keywords:
- ToolStrip control [Windows Forms], about ToolStrip control
- toolbars [Windows Forms], what's new in Windows Forms
- toolbars [Windows Forms]
- what's new [Windows Forms], toolbars
ms.assetid: 81d067ed-297c-4dad-90de-1bcac15336ec
ms.openlocfilehash: 3e532b040d3c7859220b7f73958b63e7208b988c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59144577"
---
# <a name="toolstrip-control-overview-windows-forms"></a>Общие сведения об элементе управления ToolStrip (Windows Forms)
Windows Forms <xref:System.Windows.Forms.ToolStrip> управления и связанные с ним классы предоставляют общую инфраструктуру для объединения элементов пользовательского интерфейса в панели инструментов, строк состояния и меню. <xref:System.Windows.Forms.ToolStrip> элементы управления предлагают широкие возможности разработки, включающий встроенной активации и редактирования, пользовательский макет и нависания, который является возможность совместного использования горизонтального или вертикального пространства панели инструментов.  
  
 Несмотря на то что <xref:System.Windows.Forms.ToolStrip> заменяет и расширяет функциональные возможности управления в предыдущих версиях <xref:System.Windows.Forms.ToolBar> сохраняется для обратной совместимости и использования в будущем при необходимости.  
  
## <a name="features-of-the-toolstrip-controls"></a>Функции элементов управления ToolStrip  
 Используйте <xref:System.Windows.Forms.ToolStrip> управления:  
  
-   Представить общий пользовательский интерфейс в контейнерах.  
  
-   Создание легко настраиваемых, стандартных панелей инструментов, которые поддерживают дополнительные возможности пользовательского интерфейса и макет, такими как кнопки прикрепления, наслоения, текст и изображения, кнопки раскрывающегося списка и элементы управления, overflow кнопки и изменение порядка выполнения <xref:System.Windows.Forms.ToolStrip> элементы.  
  
-   Поддерживает переполнения и переупорядочения элементов во время выполнения. Функция переполнения перемещает элементы в раскрывающемся меню, если не хватает места, чтобы отобразить их в <xref:System.Windows.Forms.ToolStrip>.  
  
-   Поддерживает типичные внешний вид и поведение операционной системы через общую модель подготовки к просмотру.  
  
-   Согласованная обработка событий для всех контейнеров и вложенными элементами, так же, обработки событий для других элементов управления.  
  
-   Перетащите элементы из одного <xref:System.Windows.Forms.ToolStrip> в другую или в <xref:System.Windows.Forms.ToolStrip>.  
  
-   Создание элементов управления раскрывающегося списка и редакторы типов интерфейса с расширенными <xref:System.Windows.Forms.ToolStripDropDown>.  
  
 Используйте <xref:System.Windows.Forms.ToolStripControlHost> класс для использования других элементов управления на <xref:System.Windows.Forms.ToolStrip> получить <xref:System.Windows.Forms.ToolStrip> функциональные возможности для них.  
  
 Можно расширить функциональные возможности и изменять внешний вид и поведение с помощью <xref:System.Windows.Forms.ToolStripRenderer>, <xref:System.Windows.Forms.ToolStripProfessionalRenderer>, и <xref:System.Windows.Forms.ToolStripManager> вместе с <xref:System.Windows.Forms.ToolStripRenderMode> и <xref:System.Windows.Forms.ToolStripManagerRenderMode> перечисления.  
  
 <xref:System.Windows.Forms.ToolStrip> Управления высокой настраиваемых и расширяемых и предоставляет множество свойств, методов и событий для настройки внешнего вида и поведения. Ниже приведены некоторые значимые члены.  
  
### <a name="important-toolstrip-members"></a>Члены важные ToolStrip  
  
|name|Описание|  
|----------|-----------------|  
|<xref:System.Windows.Forms.ToolStrip.Dock%2A>|Получает или задает край родительского контейнера <xref:System.Windows.Forms.ToolStrip> закреплены.|  
|<xref:System.Windows.Forms.ToolStrip.AllowItemReorder%2A>|Возвращает или задает значение, указывающее, будут ли операции перетаскивания и переупорядочения элементов обрабатываться классом <xref:System.Windows.Forms.ToolStrip> в закрытом режиме.|  
|<xref:System.Windows.Forms.ToolStrip.LayoutStyle%2A>|Возвращает или задает значение, указывающее, каким образом <xref:System.Windows.Forms.ToolStrip> размещает ее элементов.|  
|<xref:System.Windows.Forms.ToolStripItem.Overflow%2A>|Возвращает или задает ли <xref:System.Windows.Forms.ToolStripItem> присоединяется к <xref:System.Windows.Forms.ToolStrip> или <xref:System.Windows.Forms.ToolStripOverflowButton> или он может перемещаться между ними.|  
|<xref:System.Windows.Forms.ToolStrip.IsDropDown%2A>|Получает значение, указывающее, является ли <xref:System.Windows.Forms.ToolStripItem> отображает другие элементы в раскрывающемся списке список <xref:System.Windows.Forms.ToolStripItem> нажатии.|  
|<xref:System.Windows.Forms.ToolStrip.OverflowButton%2A>|Возвращает значение элемента <xref:System.Windows.Forms.ToolStripItem>, который является кнопкой переполнения для элемента управления <xref:System.Windows.Forms.ToolStrip> с включенной функцией переполнения.|  
|<xref:System.Windows.Forms.ToolStrip.Renderer%2A>|Возвращает или задает <xref:System.Windows.Forms.ToolStripRenderer> позволяет настраивать внешний вид и поведение (оформление) <xref:System.Windows.Forms.ToolStrip>.|  
|<xref:System.Windows.Forms.ToolStrip.RenderMode%2A>|Возвращает или задает стили оформления элемента управления для применения к <xref:System.Windows.Forms.ToolStrip>.|  
|<xref:System.Windows.Forms.ToolStrip.RendererChanged>|Вызывается, когда <xref:System.Windows.Forms.ToolStrip.Renderer%2A> изменения свойств.|  
  
 <xref:System.Windows.Forms.ToolStrip> Гибкость элемента управления реализуется с помощью ряд сопутствующих классов. Ниже приведены некоторые из наиболее значимых.  
  
### <a name="important-toolstrip-companion-classes"></a>Важные сопутствующие ToolStrip классы  
  
|name|Описание|  
|----------|-----------------|  
|<xref:System.Windows.Forms.MenuStrip>|Заменяет и расширяет его функциональные возможности <xref:System.Windows.Forms.MainMenu> класса.|  
|<xref:System.Windows.Forms.StatusStrip>|Заменяет и расширяет его функциональные возможности <xref:System.Windows.Forms.StatusBar> класса.|  
|<xref:System.Windows.Forms.ContextMenuStrip>|Заменяет и расширяет его функциональные возможности <xref:System.Windows.Forms.ContextMenu> класса.|  
|<xref:System.Windows.Forms.ToolStripItem>|Абстрактный базовый класс, который управляет событиями и структурой всех элементов, <xref:System.Windows.Forms.ToolStrip>, <xref:System.Windows.Forms.ToolStripControlHost>, или <xref:System.Windows.Forms.ToolStripDropDown> может содержать.|  
|<xref:System.Windows.Forms.ToolStripContainer>|Предоставляет контейнер с панели на каждой стороне формы, в котором элементы управления могут быть размещены в различных способов.|  
|<xref:System.Windows.Forms.ToolStripRenderer>|Обрабатывает функции рисования для <xref:System.Windows.Forms.ToolStrip> объектов.|  
|<xref:System.Windows.Forms.ToolStripProfessionalRenderer>|Предоставляет внешний вид стиле Microsoft Office.|  
|<xref:System.Windows.Forms.ToolStripManager>|Элементы управления <xref:System.Windows.Forms.ToolStrip> отрисовки и нависания и объединение <xref:System.Windows.Forms.MenuStrip>, <xref:System.Windows.Forms.ToolStripDropDownMenu>, и <xref:System.Windows.Forms.ToolStripMenuItem> объектов.|  
|<xref:System.Windows.Forms.ToolStripManagerRenderMode>|Указывает стиль оформления (пользовательские, Windows XP или Microsoft Office Professional), применяемый к нескольким <xref:System.Windows.Forms.ToolStrip> объектов, содержащихся в форме.|  
|<xref:System.Windows.Forms.ToolStripRenderMode>|Указывает стиль оформления (пользовательские, Windows XP или Microsoft Office Professional), применяемый к одному <xref:System.Windows.Forms.ToolStrip> объект, содержащийся в форме.|  
|<xref:System.Windows.Forms.ToolStripControlHost>|Размещает другие элементы управления, которые не являются <xref:System.Windows.Forms.ToolStrip> элементов управления, но для которого необходимо <xref:System.Windows.Forms.ToolStrip> функциональные возможности.|  
|<xref:System.Windows.Forms.ToolStripItemPlacement>|Указывает ли <xref:System.Windows.Forms.ToolStripItem> будет располагаться в главном <xref:System.Windows.Forms.ToolStrip>, в случае переполнения <xref:System.Windows.Forms.ToolStrip>, или ни одного.|  
  
 Дополнительные сведения см. в разделе [ToolStrip, технологии, положенные](toolstrip-technology-summary.md) и [архитектура элемента управления ToolStrip](toolstrip-control-architecture.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ToolStrip>
- <xref:System.Windows.Forms.MenuStrip>
- <xref:System.Windows.Forms.ContextMenuStrip>
- <xref:System.Windows.Forms.StatusStrip>
- <xref:System.Windows.Forms.ToolStripItem>
- <xref:System.Windows.Forms.ToolStripDropDown>

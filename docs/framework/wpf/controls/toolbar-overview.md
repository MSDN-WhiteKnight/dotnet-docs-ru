---
title: Общие сведения о панели инструментов ToolBar
ms.date: 03/30/2017
helpviewer_keywords:
- controls [WPF], ToolBar
- ToolBar control [WPF]
ms.assetid: a8edb32c-118d-4f31-b6e6-8899082b504b
ms.openlocfilehash: 711d55e46fb548787976a1f966c9fbf6dc7f12d8
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59105331"
---
# <a name="toolbar-overview"></a>Общие сведения о панели инструментов ToolBar
<xref:System.Windows.Controls.ToolBar> элементы управления являются контейнерами для группы команд или элементов управления, которые обычно связаны в их функции. Объект <xref:System.Windows.Controls.ToolBar> обычно содержит кнопки, которые активируют команды.  

<a name="ToolBarControl"></a>   
## <a name="toolbar-control"></a>Элемент управления ToolBar  
 <xref:System.Windows.Controls.ToolBar> Управления планка панель в одну строку или столбец ряд кнопок или других элементов управления. WPF <xref:System.Windows.Controls.ToolBar> элементы управления обеспечивают механизм переполнения, который помещает все элементы, не попадающие в ограничения по размеру объекта <xref:System.Windows.Controls.ToolBar> в специальную область переполнения. Кроме того WPF <xref:System.Windows.Controls.ToolBar> обычно используются элементы управления со связанным <xref:System.Windows.Controls.ToolBarTray> элемент управления, который обеспечивает особый механизм размещения, а также поддержка для инициированного пользователем изменение размера и упорядочивание панелей инструментов.  
  
<a name="Creating_ToolBars"></a>   
## <a name="specifying-the-position-of-toolbars-in-a-toolbartray"></a>Задание положения элементов управления ToolBar в элементе управления ToolBarTray  
 Используйте <xref:System.Windows.Controls.ToolBar.Band%2A> и <xref:System.Windows.Controls.ToolBar.BandIndex%2A> свойства для размещения <xref:System.Windows.Controls.ToolBar> в <xref:System.Windows.Controls.ToolBarTray>. <xref:System.Windows.Controls.ToolBar.Band%2A> Указывает позицию, в котором <xref:System.Windows.Controls.ToolBar> помещается в его родительском элементе <xref:System.Windows.Controls.ToolBarTray>. <xref:System.Windows.Controls.ToolBar.BandIndex%2A> Указывает порядок, в котором <xref:System.Windows.Controls.ToolBar> помещается в пределах его полосы. В следующем примере показан как использовать это свойство для размещения <xref:System.Windows.Controls.ToolBar> элементы управления внутри <xref:System.Windows.Controls.ToolBarTray>.  
  
 [!code-xaml[ToolBarExample#2](~/samples/snippets/csharp/VS_Snippets_Wpf/ToolBarExample/CS/Pane1.xaml#2)]  
  
<a name="ToolBars_with_Overflow_Items"></a>   
## <a name="toolbars-with-overflow-items"></a>Элементы управления ToolBar с элементами в области переполнения  
 Часто <xref:System.Windows.Controls.ToolBar> содержит больше элементов, чем может поместиться в размер панели инструментов. В этом случае <xref:System.Windows.Controls.ToolBar> отображается кнопка переполнения. Для просмотра элементов переполнения пользователь нажимает кнопку переполнения, и эти элементы отображаются во всплывающем окне ниже <xref:System.Windows.Controls.ToolBar>. Показано на следующем рисунке <xref:System.Windows.Controls.ToolBar> с элементами в области переполнения:  
  
 ![Снимок экрана, показывающий элемент toolbar с элементами в области переполнения.](./media/toolbar-overview/toolbar-overflow-items.png)  
  
 Можно указать при помещении элемента на панели инструментов в области переполнения, установив <xref:System.Windows.Controls.ToolBar.OverflowMode%2A?displayProperty=nameWithType> вложенное свойство, чтобы <xref:System.Windows.Controls.OverflowMode.Always?displayProperty=nameWithType>, <xref:System.Windows.Controls.OverflowMode.Never?displayProperty=nameWithType>, или <xref:System.Windows.Controls.OverflowMode.AsNeeded?displayProperty=nameWithType>. В следующем примере показано, что последние четыре кнопки панели инструментов всегда должны быть в области переполнения.  
  
 [!code-xaml[ToolBarExample#3](~/samples/snippets/csharp/VS_Snippets_Wpf/ToolBarExample/CS/Pane1.xaml#3)]  
  
 <xref:System.Windows.Controls.ToolBar> Использует <xref:System.Windows.Controls.Primitives.ToolBarPanel> и <xref:System.Windows.Controls.Primitives.ToolBarOverflowPanel> в его <xref:System.Windows.Controls.ControlTemplate>.  <xref:System.Windows.Controls.Primitives.ToolBarPanel> Отвечает за размещение элементов на панели инструментов.  <xref:System.Windows.Controls.Primitives.ToolBarOverflowPanel> Отвечает за размещение элементов, которые не помещаются на <xref:System.Windows.Controls.ToolBar>. Пример <xref:System.Windows.Controls.ControlTemplate> для <xref:System.Windows.Controls.ToolBar>, см. в разделе  
  
 [Стили и шаблоны элемента ToolBar](toolbar-styles-and-templates.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.Primitives.ToolBarPanel>
- <xref:System.Windows.Controls.Primitives.ToolBarOverflowPanel>
- [Определение стиля элементов управления на панели инструментов](how-to-style-controls-on-a-toolbar.md)
- [Пример коллекции элементов управления WPF](https://go.microsoft.com/fwlink/?LinkID=160053)

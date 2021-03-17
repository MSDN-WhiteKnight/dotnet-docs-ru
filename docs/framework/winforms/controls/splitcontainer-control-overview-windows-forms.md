---
title: Общие сведения об элементе управления SplitContainer (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- SplitContainer
helpviewer_keywords:
- SplitContainer control [Windows Forms], about SplitContainer control
ms.assetid: 6de5a5f7-97a5-402d-be6d-7e2785483db5
ms.openlocfilehash: 4afdd764b2f6ef7f15e8bd26459f0fa4c7d345e1
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59219425"
---
# <a name="splitcontainer-control-overview-windows-forms"></a>Общие сведения об элементе управления SplitContainer (Windows Forms)
Элемент управления Windows Forms <xref:System.Windows.Forms.SplitContainer> состоит из двух панелей, разделенных подвижной полосой. При наведении указателя мыши на полосу его форма изменяется, показывая, что полоса является перемещаемой.  
  
> [!IMPORTANT]
>  В **элементов**, <xref:System.Windows.Forms.SplitContainer> элемент управления заменяет <xref:System.Windows.Forms.Splitter> элемента управления, который имелся в предыдущей версии Visual Studio. Элемент управления <xref:System.Windows.Forms.SplitContainer> намного предпочтительнее, чем элемент управления <xref:System.Windows.Forms.Splitter>. <xref:System.Windows.Forms.Splitter> Класс по-прежнему включен в [!INCLUDE[dnprdnshort](../../../../includes/dnprdnshort-md.md)] для совместимости с существующими приложениями, но мы настоятельно рекомендуем использовать <xref:System.Windows.Forms.SplitContainer> управления для новых проектов.  
  
 С помощью <xref:System.Windows.Forms.SplitContainer> элемента управления, вы можете создавать сложные пользовательские интерфейсы; часто выбор на одной панели определяет объекты, отображаемые на панели. Такой подход является весьма эффективным для отображения и просмотра информации. Две панели для сбора информации в областях, а также панели, или «разделитель», упрощают изменение размера панелей.  
  
 Более одного <xref:System.Windows.Forms.SplitContainer> управления также могут быть вложенными, со вторым <xref:System.Windows.Forms.SplitContainer> управления ориентирован горизонтально, создайте верхней и нижней панели.  
  
 Имейте в виду, что <xref:System.Windows.Forms.SplitContainer> управления клавиатуры по умолчанию; пользователи могут нажимайте клавиши со стрелками для перемещения разделителя, если <xref:System.Windows.Forms.SplitContainer.IsSplitterFixed%2A> свойству `false`.  
  
 <xref:System.Windows.Forms.SplitContainer.Orientation%2A> Свойство <xref:System.Windows.Forms.SplitContainer> управления определяет направление разделителя, а не сам элемент управления. Таким образом, если этому свойству присвоено <xref:System.Windows.Forms.Orientation.Vertical>, разделитель выполняется сверху вниз, создание левой и правой панели.  
  
 Кроме того, следует помнить, значение <xref:System.Windows.Forms.SplitContainer.SplitterRectangle%2A> свойство изменяется в зависимости от значения <xref:System.Windows.Forms.SplitContainer.Orientation%2A> свойство. Дополнительные сведения см. в разделе <xref:System.Windows.Forms.SplitContainer.SplitterRectangle%2A> свойство.  
  
 Также можно ограничить размер и перемещения <xref:System.Windows.Forms.SplitContainer> элемента управления. <xref:System.Windows.Forms.SplitContainer.FixedPanel%2A> Свойство определяет, какая панель останется на тот же размер после <xref:System.Windows.Forms.SplitContainer> изменения размеров элемента управления и <xref:System.Windows.Forms.SplitContainer.IsSplitterFixed%2A> свойство определяет, если разделитель является перемещаемым, клавиатуры или мыши.  
  
> [!NOTE]
>  Даже если <xref:System.Windows.Forms.SplitContainer.IsSplitterFixed%2A> свойству `true`, разделитель может по-прежнему быть перемещен программных средств; например, с помощью <xref:System.Windows.Forms.SplitContainer.SplitterDistance%2A> свойство.  
  
 Наконец, каждой панели <xref:System.Windows.Forms.SplitContainer> элемент управления имеет свойства, чтобы определить его размер отдельных.  
  
## <a name="commonly-used-properties-methods-and-events"></a>Часто используемые свойства, методы и события  
  
|name|Описание|  
|----------|-----------------|  
|<xref:System.Windows.Forms.SplitContainer.FixedPanel%2A> свойство;|Определяет, какая из панелей не меняется размер после <xref:System.Windows.Forms.SplitContainer> размер элемента управления.|  
|<xref:System.Windows.Forms.SplitContainer.IsSplitterFixed%2A> свойство;|Определяет, если разделитель можно перемещать с помощью клавиатуры или мыши.|  
|<xref:System.Windows.Forms.SplitContainer.Orientation%2A> свойство;|Определяет, если расположение разделителя вертикально или горизонтально.|  
|<xref:System.Windows.Forms.SplitContainer.SplitterDistance%2A> свойство;|Определяет расстояние в пикселях от левого или верхнего края для перемещаемой полосы-разделителя.|  
|<xref:System.Windows.Forms.SplitContainer.SplitterIncrement%2A> свойство;|Определяет минимальное расстояние в пикселях, что разделитель может быть перемещен пользователем.|  
|<xref:System.Windows.Forms.SplitContainer.SplitterWidth%2A> свойство;|Определяет ширину в пикселях разделителя.|  
|<xref:System.Windows.Forms.SplitContainer.SplitterMoving> событие|Происходит, когда разделитель является перемещение.|  
|<xref:System.Windows.Forms.SplitContainer.SplitterMoved> событие|Происходит при перемещении разделителя.|  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.SplitContainer>
- [Элемент управления SplitContainer](splitcontainer-control-windows-forms.md)
- [Пример элемента управления SplitContainer](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2008/0ffz7d1b(v=vs.90))

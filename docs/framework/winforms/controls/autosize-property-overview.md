---
title: Свойство AutoSize
ms.date: 03/30/2017
helpviewer_keywords:
- sizing [Windows Forms], automatic
- layout [Windows Forms], AutoSize
- automatic sizing
- AutoSizeMode property
ms.assetid: 62fd82a2-9565-4f65-925b-9d1e66dc4e7d
ms.openlocfilehash: 6d5c4a22f186ddc5811c4a4d5e79776decea9e50
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59173632"
---
# <a name="autosize-property-overview"></a>Свойство AutoSize
<xref:System.Windows.Forms.Control.AutoSize%2A> Свойство включает элемент управления изменить его размер, при необходимости, чтобы достичь значению, заданному в <xref:System.Windows.Forms.Control.PreferredSize%2A> свойство. Настроить поведение при изменении размера для определенного элемента управления, присвоив `AutoSizeMode` свойство.  
  
## <a name="autosize-behavior"></a>Автоматическое изменение размеров  
 Некоторые элементы управления поддерживают <xref:System.Windows.Forms.Control.AutoSize%2A> свойство. Кроме того, некоторые элементы управления, которые поддерживают <xref:System.Windows.Forms.Control.AutoSize%2A> свойство также поддерживает `AutoSizeMode` свойство.  
  
 <xref:System.Windows.Forms.Control.AutoSize%2A> Свойство такое поведение, немного отличаются, в зависимости от типа элемента управления и значение `AutoSizeMode` свойства, если свойство существует. В следующей таблице описаны особенности поведения, которые всегда являются true и предоставляет краткое описание каждого из них:  
  
|Всегда значение true, поведение|Описание|  
|--------------------------|-----------------|  
|Автоматическое изменение размеров — это функция времени выполнения.|Это означает, что он никогда не роста или уменьшения размеров элемента управления и затем имеет не влияет.|  
|Если элемент управления изменяет свой размер значение его <xref:System.Windows.Forms.Control.Location%2A> свойства всегда остается постоянным.|Если содержимое элемента управления приводит ему увеличиваться, размеры элемента управления, направо и сверху вниз. Элементы управления не задействуют слева.|  
|<xref:System.Windows.Forms.Control.Dock%2A> И <xref:System.Windows.Forms.Control.Anchor%2A> свойства соблюдаются, когда <xref:System.Windows.Forms.Control.AutoSize%2A> является `true`.|Значение элемента управления <xref:System.Windows.Forms.Control.Location%2A> настройки правильное значение свойства.<br /><br /> **Примечание** <xref:System.Windows.Forms.Label> элемент управления является исключением из этого правила. Если выбрано значение закрепленного <xref:System.Windows.Forms.Label> элемента управления <xref:System.Windows.Forms.Control.AutoSize%2A> свойства `true`, <xref:System.Windows.Forms.Label> не растягивается, элемент управления.|  
|Элемент управления <xref:System.Windows.Forms.Control.MaximumSize%2A> и <xref:System.Windows.Forms.Control.MinimumSize%2A> свойства учитываются всегда, независимо от значения его <xref:System.Windows.Forms.Control.AutoSize%2A> свойство.|<xref:System.Windows.Forms.Control.MaximumSize%2A> И <xref:System.Windows.Forms.Control.MinimumSize%2A> свойства не затрагивает <xref:System.Windows.Forms.Control.AutoSize%2A> свойство.|  
|Минимальный размер, значение по умолчанию не установлен.|Это означает, что если элемент управления имеет значение для сжатия в разделе <xref:System.Windows.Forms.Control.AutoSize%2A> и он не имеет содержимого, значение его <xref:System.Windows.Forms.Control.Size%2A> свойство — 0,0. В этом случае элемент управления будет сжат до точки, и он не будет невидимым.|  
|Если элемент управления не реализует <xref:System.Windows.Forms.Control.GetPreferredSize%2A> метод, <xref:System.Windows.Forms.Control.GetPreferredSize%2A> метод возвращает последнее значение, присваиваемое <xref:System.Windows.Forms.Control.Size%2A> свойство.|Это значит, что параметр <xref:System.Windows.Forms.Control.AutoSize%2A> для `true` не окажет никакого воздействия.|  
|Элемент управления в <xref:System.Windows.Forms.TableLayoutPanel> всегда ячейки сжимается, заполняя в ячейке до его <xref:System.Windows.Forms.Control.MinimumSize%2A> достижения.|Этот размер применяется как максимальный размер. Это не так, если ячейка является частью <xref:System.Windows.Forms.SizeType.AutoSize> строки или столбца.|  
  
## <a name="autosizemode-property"></a>AutoSizeMode-свойство  
 `AutoSizeMode` Свойство обеспечивает более точный контроль над по умолчанию <xref:System.Windows.Forms.Control.AutoSize%2A> поведение. `AutoSizeMode` Свойство определяет, каким образом размера элемента управления к его содержимому. Содержимое, например, может представлять собой текст для <xref:System.Windows.Forms.Button> элемента управления или дочерние элементы управления для контейнера.  
  
 В следующей таблице показаны <xref:System.Windows.Forms.AutoSizeMode> elicits описание поведения каждого параметра.  
  
|AutoSizeMode-параметр|Поведение|  
|--------------------------|--------------|  
|GrowAndShrink|Элемент управления увеличиваются или уменьшаются по помещалось все содержимое.<br /><br /> <xref:System.Windows.Forms.Control.MinimumSize%2A> И <xref:System.Windows.Forms.Control.MaximumSize%2A> учитываются значения, но текущее значение <xref:System.Windows.Forms.Control.Size%2A> свойство учитывается.<br /><br /> Это отличается от элементов управления с помощью <xref:System.Windows.Forms.Control.AutoSize%2A> свойство и нет `AutoSizeMode` свойство.|  
|GrowOnly|Элемент управления могут увеличиваться настолько, насколько помещалось все содержимое, но он будет не уменьшаются до значения, указанного в его <xref:System.Windows.Forms.Control.Size%2A> свойство.<br /><br /> Это значение по умолчанию для `AutoSizeMode`.|  
  
## <a name="controls-that-support-the-autosize-property"></a>Элементы управления, поддерживающие свойство AutoSize  
 В следующей таблице перечислены элементы управления, которые поддерживают <xref:System.Windows.Forms.Control.AutoSize%2A> и `AutoSizeMode` свойства.  
  
|Поддержка AutoSize|Тип элемента управления|  
|----------------------|------------------|  
|-   <xref:System.Windows.Forms.Control.AutoSize%2A> свойство поддерживается.<br />— Должен отсутствовать `AutoSizeMode` свойство.|<xref:System.Windows.Forms.CheckBox><br /><br /> <xref:System.Windows.Forms.DomainUpDown><br /><br /> <xref:System.Windows.Forms.Label><br /><br /> <xref:System.Windows.Forms.LinkLabel><br /><br /> <xref:System.Windows.Forms.MaskedTextBox> (<xref:System.Windows.Forms.TextBox> базовый)<br /><br /> <xref:System.Windows.Forms.NumericUpDown><br /><br /> <xref:System.Windows.Forms.RadioButton><br /><br /> <xref:System.Windows.Forms.TextBox><br /><br /> <xref:System.Windows.Forms.TrackBar>|  
|-   <xref:System.Windows.Forms.Control.AutoSize%2A> свойство поддерживается.<br />-   `AutoSizeMode` свойство поддерживается.|<xref:System.Windows.Forms.Button><br /><br /> <xref:System.Windows.Forms.CheckedListBox><br /><br /> <xref:System.Windows.Forms.FlowLayoutPanel><br /><br /> <xref:System.Windows.Forms.Form><br /><br /> <xref:System.Windows.Forms.GroupBox><br /><br /> <xref:System.Windows.Forms.Panel><br /><br /> <xref:System.Windows.Forms.TableLayoutPanel>|  
|— Должен отсутствовать <xref:System.Windows.Forms.Control.AutoSize%2A> свойство.|<xref:System.Windows.Forms.CheckedListBox><br /><br /> <xref:System.Windows.Forms.ComboBox><br /><br /> <xref:System.Windows.Forms.DataGridView><br /><br /> <xref:System.Windows.Forms.DateTimePicker><br /><br /> <xref:System.Windows.Forms.ListBox><br /><br /> <xref:System.Windows.Forms.ListView><br /><br /> <xref:System.Windows.Forms.MaskedTextBox><br /><br /> <xref:System.Windows.Forms.MonthCalendar><br /><br /> <xref:System.Windows.Forms.ProgressBar><br /><br /> <xref:System.Windows.Forms.PropertyGrid><br /><br /> <xref:System.Windows.Forms.RichTextBox><br /><br /> <xref:System.Windows.Forms.SplitContainer><br /><br /> <xref:System.Windows.Forms.TabControl><br /><br /> <xref:System.Windows.Forms.TabPage><br /><br /> <xref:System.Windows.Forms.TreeView><br /><br /> <xref:System.Windows.Forms.WebBrowser><br /><br /> <xref:System.Windows.Forms.ScrollBar>|  
  
## <a name="autosize-in-the-design-environment"></a>Автоматическое изменение размеров в среде разработки  
 В следующей таблице описаны поведение при изменении размера элемента управления во время разработки на основе значения из его <xref:System.Windows.Forms.Control.AutoSize%2A> и `AutoSizeMode` свойства.  
  
 Переопределить <xref:System.Windows.Forms.Design.ControlDesigner.SelectionRules%2A> свойство, чтобы определить, является ли пользователь изменять размер состояние заданного элемента управления. В следующей таблице, «не может» означает, что <xref:System.Windows.Forms.Design.SelectionRules.Moveable> только «может» означает <xref:System.Windows.Forms.Design.SelectionRules.AllSizeable> и <xref:System.Windows.Forms.Design.SelectionRules.Moveable>.  
  
|Параметры AutoSize|Операция изменения размера во время разработки|  
|-----------------------|---------------------------------|  
|-   <xref:System.Windows.Forms.Control.AutoSize%2A> = `true`<br />— Должен отсутствовать `AutoSizeMode` свойство.|Пользователь не может изменить размер элемента управления во время разработки, за исключением следующих элементов управления:<br /><br /> -   <xref:System.Windows.Forms.TextBox><br />-   <xref:System.Windows.Forms.MaskedTextBox><br />-   <xref:System.Windows.Forms.RichTextBox><br />-   <xref:System.Windows.Forms.TrackBar>|  
|-   <xref:System.Windows.Forms.Control.AutoSize%2A> = `true`<br />-   `AutoSizeMode` = <xref:System.Windows.Forms.AutoSizeMode.GrowAndShrink>|Пользователь не может изменить размер элемента управления во время разработки.|  
|-   <xref:System.Windows.Forms.Control.AutoSize%2A> = `true`<br />-   `AutoSizeMode` = <xref:System.Windows.Forms.AutoSizeMode.GrowOnly>|Пользователь может изменить размер элемента управления во время разработки. Когда <xref:System.Windows.Forms.Control.Size%2A> свойство задано, пользователь может только увеличить размер элемента управления.|  
|-   <xref:System.Windows.Forms.Control.AutoSize%2A> = `false`, или <xref:System.Windows.Forms.Control.AutoSize%2A> свойство отображается.|Пользователь может изменить размер элемента управления во время разработки.|  
  
> [!NOTE]
>  Для достижения максимальной производительности, конструктор Windows Forms теней <xref:System.Windows.Forms.Control.AutoSize%2A> свойство <xref:System.Windows.Forms.Form> класса. Во время разработки, как если бы поведение формы <xref:System.Windows.Forms.Control.AutoSize%2A> свойству `false`, независимо от фактической настройки. Во время выполнения, оптимизация не производится и <xref:System.Windows.Forms.Control.AutoSize%2A> свойство применяется, заданные значения этого свойства.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Control.AutoSize%2A>
- <xref:System.Windows.Forms.Control.PreferredSize%2A>
- <xref:System.Windows.Forms.Control.GetPreferredSize%2A>

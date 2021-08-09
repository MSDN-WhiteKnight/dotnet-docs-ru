---
title: Сопоставление свойств Windows Forms и WPF
ms.date: 03/30/2017
helpviewer_keywords:
- property mapping [WPF interoperability]
- Windows Forms [WPF], interoperability with
- Windows Forms [WPF], WPF interoperation
- interoperability [WPF], Windows Forms
- WindowsFormsHost element property mapping [WPF]
ms.assetid: 999d8298-9c04-467d-a453-86e41002057d
ms.openlocfilehash: a7d78837a141ed322da42629501cee6dcc9143e1
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59088825"
---
# <a name="windows-forms-and-wpf-property-mapping"></a>Сопоставление свойств Windows Forms и WPF
Windows Forms И WPF технологий есть две модели похожие, но разные свойства. *Сопоставление свойств* поддерживает взаимодействие между этими двумя архитектурами и предоставляет следующие возможности:  
  
-   Упрощает сопоставление изменений соответствующего свойства в среде узла для размещаемого элемента управления или элемента.  
  
-   Предоставляет значение по умолчанию для сопоставления наиболее часто используемые свойства.  
  
-   Позволяет легко удалять, переопределять или расширять свойств по умолчанию.  
  
-   Гарантирует, что изменения значений свойств на узле автоматически обнаруживаются и преобразованный в размещенный элемент управления или элемент.  
  
> [!NOTE]
>  События изменения свойств не распространяются вверх размещения элемента управления или элемент иерархии. Преобразование свойства выполняется не в том случае, если локальное значение свойства не будет изменяться из-за прямую настройку, Управление стилями, наследования, привязки данных и другие механизмы, которые изменяют значение свойства.  
  
 Используйте <xref:System.Windows.Forms.Integration.WindowsFormsHost.PropertyMap%2A> свойство <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент и <xref:System.Windows.Forms.Integration.ElementHost.PropertyMap%2A> свойство <xref:System.Windows.Forms.Integration.ElementHost> элемента управления для доступа к сопоставление свойств.  
  
## <a name="property-mapping-with-the-windowsformshost-element"></a>Сопоставление свойств с помощью элемента WindowsFormsHost  
 <xref:System.Windows.Forms.Integration.WindowsFormsHost> Элемент преобразует значение по умолчанию WPF свойства, чтобы их Windows Forms эквиваленты, с помощью следующей таблицы преобразования.  
  
|Размещение Windows Presentation Foundation|Windows Forms|Возможности взаимодействия|  
|---------------------------------------------|-------------------|-----------------------------|  
|<xref:System.Windows.Controls.Control.Background%2A><br /><br /> (<xref:System.Windows.Media.Brush?displayProperty=nameWithType>)|<xref:System.Windows.Forms.Control.BackColor%2A><br /><br /> (<xref:System.Drawing.Color?displayProperty=nameWithType>)|<xref:System.Windows.Forms.Integration.WindowsFormsHost> Наборов элементов <xref:System.Windows.Forms.Control.BackColor%2A> свойств размещаемого элемента управления и <xref:System.Windows.Forms.Control.BackgroundImage%2A> свойств размещаемого элемента управления. Сопоставление выполняется с помощью следующих правил:<br /><br /> Если <xref:System.Windows.Controls.Control.Background%2A> представляет собой сплошной цвет, он преобразуется и используемый для задания <xref:System.Windows.Forms.Control.BackColor%2A> свойств размещаемого элемента управления. <xref:System.Windows.Forms.Control.BackColor%2A> Свойство не задано размещаемого элемента управления, поскольку размещаемый элемент управления может наследовать значение <xref:System.Windows.Forms.Control.BackColor%2A> свойства. **Примечание.**  Размещаемый элемент управления не поддерживает прозрачность. Любой цвет, назначенный <xref:System.Windows.Forms.Control.BackColor%2A> должен быть полностью непрозрачным, со значением альфа 0xFF. <br /><br /> Если <xref:System.Windows.Controls.Control.Background%2A> не сплошным цветом, <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент управления создает точечный рисунок из <xref:System.Windows.Controls.Control.Background%2A> свойство. <xref:System.Windows.Forms.Integration.WindowsFormsHost> Управления назначает этой битовой карты для <xref:System.Windows.Forms.Control.BackgroundImage%2A> свойств размещаемого элемента управления. Это дает результат, который аналогичен прозрачности. **Примечание.**  Это поведение можно переопределить или удалением <xref:System.Windows.Controls.Control.Background%2A> сопоставление свойств.|  
|<xref:System.Windows.FrameworkElement.Cursor%2A>|<xref:System.Windows.Forms.Control.Cursor%2A>|Если не была переназначена сопоставление по умолчанию, <xref:System.Windows.Forms.Integration.WindowsFormsHost> управления проходит по иерархии предков, пока не найдет узел-предок с его <xref:System.Windows.FrameworkElement.Cursor%2A> набор свойств. Это значение преобразуется в ближайший соответствующий Windows Forms курсора.<br /><br /> Если сопоставление по умолчанию для <xref:System.Windows.FrameworkElement.ForceCursor%2A> свойство не было назначено заново, поиск завершается на первого предка с <xref:System.Windows.FrameworkElement.ForceCursor%2A> присвоено `true`.|  
|<xref:System.Windows.FrameworkElement.FlowDirection%2A><br /><br /> (<xref:System.Windows.FlowDirection?displayProperty=nameWithType>)|<xref:System.Windows.Forms.Control.RightToLeft%2A><br /><br /> (<xref:System.Windows.Forms.RightToLeft?displayProperty=nameWithType>)|<xref:System.Windows.FlowDirection.LeftToRight> сопоставляется <xref:System.Windows.Forms.RightToLeft.No>.<br /><br /> <xref:System.Windows.FlowDirection.RightToLeft> сопоставляется <xref:System.Windows.Forms.RightToLeft.Yes>.<br /><br /> <xref:System.Windows.Forms.RightToLeft.Inherit> не сопоставлен.<br /><br /> <xref:System.Windows.FlowDirection.RightToLeft?displayProperty=nameWithType> сопоставляется <xref:System.Windows.Forms.RightToLeft.Yes?displayProperty=nameWithType>.|  
|<xref:System.Windows.Controls.Control.FontStyle%2A>|<xref:System.Drawing.Font.Style%2A> размещаемого элемента управления <xref:System.Drawing.Font?displayProperty=nameWithType>|Набор WPF свойства преобразуется в соответствующий <xref:System.Drawing.Font>. При изменении одного из этих свойств, новый <xref:System.Drawing.Font> создается. Для <xref:System.Windows.FontStyles.Normal%2A>: <xref:System.Drawing.FontStyle.Italic> отключена. Для <xref:System.Windows.FontStyles.Italic%2A> или <xref:System.Windows.FontStyles.Oblique%2A>: <xref:System.Drawing.FontStyle.Italic> включен.|  
|<xref:System.Windows.Controls.Control.FontWeight%2A>|<xref:System.Drawing.Font.Style%2A> размещаемого элемента управления <xref:System.Drawing.Font?displayProperty=nameWithType>|Набор WPF свойства преобразуется в соответствующий <xref:System.Drawing.Font>. При изменении одного из этих свойств, новый <xref:System.Drawing.Font> создается. Для <xref:System.Windows.FontWeights.Black%2A>, <xref:System.Windows.FontWeights.Bold%2A>, <xref:System.Windows.FontWeights.DemiBold%2A>, <xref:System.Windows.FontWeights.ExtraBold%2A>, <xref:System.Windows.FontWeights.Heavy%2A>, <xref:System.Windows.FontWeights.Medium%2A>, <xref:System.Windows.FontWeights.SemiBold%2A>, или <xref:System.Windows.FontWeights.UltraBold%2A>: <xref:System.Drawing.FontStyle.Bold> включен. Для <xref:System.Windows.FontWeights.ExtraLight%2A>, <xref:System.Windows.FontWeights.Light%2A>, <xref:System.Windows.FontWeights.Normal%2A>, <xref:System.Windows.FontWeights.Regular%2A>, <xref:System.Windows.FontWeights.Thin%2A>, или <xref:System.Windows.FontWeights.UltraLight%2A>: <xref:System.Drawing.FontStyle.Bold> отключена.|  
|<xref:System.Windows.Controls.Control.FontFamily%2A><br /><br /> <xref:System.Windows.Controls.Control.FontSize%2A><br /><br /> <xref:System.Windows.Controls.Control.FontStretch%2A><br /><br /> <xref:System.Windows.Controls.Control.FontStyle%2A><br /><br /> <xref:System.Windows.Controls.Control.FontWeight%2A>|<xref:System.Windows.Forms.Control.Font%2A><br /><br /> (<xref:System.Drawing.Font?displayProperty=nameWithType>)|Набор WPF свойства преобразуется в соответствующий <xref:System.Drawing.Font>. При изменении одного из этих свойств, новый <xref:System.Drawing.Font> создается. Размещаемый Windows Forms элемент управления на основе размера шрифта.<br /><br /> Размер шрифта в WPF выражается как одну девяносто шестую дюйма, а в Windows Forms как одна секунда семьдесят дюйма. Является соответствующее преобразование:<br /><br /> Windows Forms размер шрифта = WPF размер шрифта * 72,0 / 96,0.|  
|<xref:System.Windows.Controls.Control.Foreground%2A><br /><br /> (<xref:System.Windows.Media.Brush?displayProperty=nameWithType>)|<xref:System.Windows.Forms.Control.ForeColor%2A><br /><br /> (<xref:System.Drawing.Color?displayProperty=nameWithType>)|<xref:System.Windows.Controls.Control.Foreground%2A> Сопоставление свойств выполняется с помощью следующих правил:<br /><br /> Если <xref:System.Windows.Controls.Control.Foreground%2A> — <xref:System.Windows.Media.SolidColorBrush>, использовать <xref:System.Windows.Media.SolidColorBrush.Color%2A> для <xref:System.Windows.Forms.Control.ForeColor%2A>.<br />Если <xref:System.Windows.Controls.Control.Foreground%2A> — <xref:System.Windows.Media.GradientBrush>, использование цвета <xref:System.Windows.Media.GradientStop> с наименьшим значением смещения для <xref:System.Windows.Forms.Control.ForeColor%2A>.<br />— Для любого другого <xref:System.Windows.Media.Brush> введите, оставьте <xref:System.Windows.Forms.Control.ForeColor%2A> без изменений. Это означает, что используется значение по умолчанию.|  
|<xref:System.Windows.UIElement.IsEnabled%2A>|<xref:System.Windows.Forms.Control.Enabled%2A>|Когда <xref:System.Windows.UIElement.IsEnabled%2A> имеет значение, <xref:System.Windows.Forms.Integration.WindowsFormsHost> наборов элементов <xref:System.Windows.Forms.Control.Enabled%2A> свойств размещаемого элемента управления.|  
|<xref:System.Windows.Controls.Control.Padding%2A>|<xref:System.Windows.Forms.Control.Padding%2A>|Все четыре значения <xref:System.Windows.Forms.Control.Padding%2A> свойство размещаемого Windows Forms управления устанавливаются на тот же <xref:System.Windows.Thickness> значение.<br /><br /> -Значения, превышающие <xref:System.Int32.MaxValue> присваивается <xref:System.Int32.MaxValue>.<br />-Значения меньше, чем <xref:System.Int32.MinValue> присваивается <xref:System.Int32.MinValue>.|  
|<xref:System.Windows.UIElement.Visibility%2A>|<xref:System.Windows.Forms.Control.Visible%2A>|-   <xref:System.Windows.Visibility.Visible> сопоставляется <xref:System.Windows.Forms.Control.Visible%2A>  =  `true`. Размещаемый Windows Forms элемент управления является видимым. Явная установка <xref:System.Windows.Forms.Control.Visible%2A> свойств размещаемого элемента управления к `false` не рекомендуется.<br />-   <xref:System.Windows.Visibility.Collapsed> сопоставляется <xref:System.Windows.Forms.Control.Visible%2A>  =  `true` или `false`. Размещаемый Windows Forms элемент управления не создается, и его область свернута.<br />-   <xref:System.Windows.Visibility.Hidden> : Размещаемый Windows Forms управления занимает место в макете, но не отображается. В этом случае <xref:System.Windows.Forms.Control.Visible%2A> свойству `true`. Явная установка <xref:System.Windows.Forms.Control.Visible%2A> свойств размещаемого элемента управления к `false` не рекомендуется.|  
  
 Вложенные свойства элементов контейнера полностью поддерживаются <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент.  
  
 Дополнительные сведения см. в разделе [Пошаговое руководство: Сопоставление свойств с помощью элемента WindowsFormsHost](walkthrough-mapping-properties-using-the-windowsformshost-element.md).  
  
## <a name="updates-to-parent-properties"></a>Обновление свойств родительского элемента  
 Изменения для большинства свойств родительского вызвать уведомления размещенной дочернему элементу управления. Ниже перечислены свойства, которые не вызывают уведомления при изменении их значений.  
  
-   <xref:System.Windows.Controls.Control.Background%2A>  
  
-   <xref:System.Windows.FrameworkElement.Cursor%2A>  
  
-   <xref:System.Windows.FrameworkElement.ForceCursor%2A>  
  
-   <xref:System.Windows.UIElement.Visibility%2A>  
  
 Например, если изменить значение <xref:System.Windows.Controls.Control.Background%2A> свойство <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент, <xref:System.Windows.Forms.Control.BackColor%2A> свойств размещаемого элемента управления остается неизменным.  
  
## <a name="property-mapping-with-the-elementhost-control"></a>Сопоставление свойств с помощью элемента управления ElementHost  
 Следующие свойства предоставляют встроенные уведомления об изменении. Не вызывайте <xref:System.Windows.FrameworkElement.OnPropertyChanged%2A> метод при сопоставлении этих свойств:  
  
-   AutoSize  
  
-   BackColor  
  
-   BackgroundImage  
  
-   BackgroundImageLayout  
  
-   BindingContext  
  
-   CausesValidation  
  
-   ContextMenu  
  
-   ContextMenuStrip  
  
-   Курсор  
  
-   Закрепить  
  
-   Включено  
  
-   Шрифт  
  
-   ForeColor  
  
-   Расположение  
  
-   Поля  
  
-   Заполнение  
  
-   Родительский  
  
-   Region  
  
-   RightToLeft  
  
-   Размер  
  
-   TabIndex  
  
-   TabStop  
  
-   Текста  
  
-   Видимый  
  
 <xref:System.Windows.Forms.Integration.ElementHost> Управления преобразует значение по умолчанию Windows Forms свойства, чтобы их WPF эквиваленты с помощью следующей таблицы преобразования.  
  
 Дополнительные сведения см. в разделе [Пошаговое руководство: Сопоставление свойств с помощью элемента управления ElementHost](walkthrough-mapping-properties-using-the-elementhost-control.md).  
  
|Windows Forms размещения|Windows Presentation Foundation|Возможности взаимодействия|  
|---------------------------|-------------------------------------|-----------------------------|  
|<xref:System.Windows.Forms.Control.BackColor%2A><br /><br /> (<xref:System.Drawing.Color?displayProperty=nameWithType>)|<xref:System.Windows.Controls.Control.Background%2A><br /><br /> (<xref:System.Windows.Media.Brush?displayProperty=nameWithType>) размещаемого элемента|Задание этого свойства принудительно перекрашивает с <xref:System.Windows.Media.ImageBrush>. Если <xref:System.Windows.Forms.Integration.ElementHost.BackColorTransparent%2A> свойству `false` (значение по умолчанию), это <xref:System.Windows.Media.ImageBrush> зависит от вида <xref:System.Windows.Forms.Integration.ElementHost> управления, включая его <xref:System.Windows.Forms.Control.BackColor%2A>, <xref:System.Windows.Forms.Control.BackgroundImage%2A>, <xref:System.Windows.Forms.Control.BackgroundImageLayout%2A> свойства и все присоединенные рисования обработчики.<br /><br /> Если <xref:System.Windows.Forms.Integration.ElementHost.BackColorTransparent%2A> свойству `true`, <xref:System.Windows.Media.ImageBrush> зависит от вида <xref:System.Windows.Forms.Integration.ElementHost> родительского элемента управления, включая родительского элемента <xref:System.Windows.Forms.Control.BackColor%2A>, <xref:System.Windows.Forms.Control.BackgroundImage%2A>, <xref:System.Windows.Forms.Control.BackgroundImageLayout%2A> свойства и все присоединенные рисования обработчики.|  
|<xref:System.Windows.Forms.Control.BackgroundImage%2A><br /><br /> (<xref:System.Drawing.Image?displayProperty=nameWithType>)|<xref:System.Windows.Controls.Control.Background%2A><br /><br /> (<xref:System.Windows.Media.Brush?displayProperty=nameWithType>) размещаемого элемента|Это свойство, то же поведение, описанным для <xref:System.Windows.Forms.Control.BackColor%2A> сопоставления.|  
|<xref:System.Windows.Forms.Control.BackgroundImageLayout%2A>|<xref:System.Windows.Controls.Control.Background%2A><br /><br /> (<xref:System.Windows.Media.Brush?displayProperty=nameWithType>) размещаемого элемента|Это свойство, то же поведение, описанным для <xref:System.Windows.Forms.Control.BackColor%2A> сопоставления.|  
|<xref:System.Windows.Forms.Control.Cursor%2A><br /><br /> (<xref:System.Windows.Forms.Cursor?displayProperty=nameWithType>)|<xref:System.Windows.FrameworkElement.Cursor%2A><br /><br /> (<xref:System.Windows.Input.Cursor?displayProperty=nameWithType>)|Windows Forms Стандартный курсор преобразуется в соответствующий WPF стандартным курсором. Если Windows Forms не является стандартным курсором, назначается значение по умолчанию.|  
|<xref:System.Windows.Forms.Control.Enabled%2A>|<xref:System.Windows.UIElement.IsEnabled%2A>|Когда <xref:System.Windows.Forms.Control.Enabled%2A> имеет значение, <xref:System.Windows.Forms.Integration.ElementHost> задает <xref:System.Windows.UIElement.IsEnabled%2A> свойств размещаемого элемента.|  
|<xref:System.Windows.Forms.Control.Font%2A><br /><br /> (<xref:System.Drawing.Font?displayProperty=nameWithType>)|<xref:System.Windows.Controls.Control.FontFamily%2A><br /><br /> <xref:System.Windows.Controls.Control.FontSize%2A><br /><br /> <xref:System.Windows.Controls.Control.FontStretch%2A><br /><br /> <xref:System.Windows.Controls.Control.FontStyle%2A><br /><br /> <xref:System.Windows.Controls.Control.FontWeight%2A>|<xref:System.Windows.Forms.Control.Font%2A> Значение преобразуется в соответствующий набор WPF свойств шрифта.|  
|<xref:System.Drawing.Font.Bold%2A>|<xref:System.Windows.Controls.Control.FontWeight%2A> размещаемого элемента|Если значение <xref:System.Drawing.Font.Bold%2A> равно `true`, то <xref:System.Windows.Controls.Control.FontWeight%2A> присваивается значение <xref:System.Windows.FontWeights.Bold%2A>.<br /><br /> Если значение <xref:System.Drawing.Font.Bold%2A> равно `false`, то <xref:System.Windows.Controls.Control.FontWeight%2A> присваивается значение <xref:System.Windows.FontWeights.Normal%2A>.|  
|<xref:System.Drawing.Font.Italic%2A>|<xref:System.Windows.Controls.Control.FontStyle%2A> размещаемого элемента|Если значение <xref:System.Drawing.Font.Italic%2A> равно `true`, то <xref:System.Windows.Controls.Control.FontStyle%2A> присваивается значение <xref:System.Windows.FontStyles.Italic%2A>.<br /><br /> Если значение <xref:System.Drawing.Font.Italic%2A> равно `false`, то <xref:System.Windows.Controls.Control.FontStyle%2A> присваивается значение <xref:System.Windows.FontStyles.Normal%2A>.|  
|<xref:System.Drawing.Font.Strikeout%2A>|<xref:System.Windows.TextDecorations> размещаемого элемента|Применимо только в том случае, если размещение <xref:System.Windows.Controls.TextBlock> элемента управления.|  
|<xref:System.Drawing.Font.Underline%2A>|<xref:System.Windows.TextDecorations> размещаемого элемента|Применимо только в том случае, если размещение <xref:System.Windows.Controls.TextBlock> элемента управления.|  
|<xref:System.Windows.Forms.Control.RightToLeft%2A><br /><br /> (<xref:System.Windows.Forms.RightToLeft?displayProperty=nameWithType>)|<xref:System.Windows.FrameworkElement.FlowDirection%2A><br /><br /> (<xref:System.Windows.FlowDirection>)|<xref:System.Windows.Forms.RightToLeft.No> сопоставляется <xref:System.Windows.FlowDirection.LeftToRight>.<br /><br /> <xref:System.Windows.Forms.RightToLeft.Yes> сопоставляется <xref:System.Windows.FlowDirection.RightToLeft>.|  
|<xref:System.Windows.Forms.Control.Visible%2A>|<xref:System.Windows.UIElement.Visibility%2A>|<xref:System.Windows.Forms.Integration.ElementHost> Задает <xref:System.Windows.UIElement.Visibility%2A> свойств размещаемого элемента с помощью следующих правил:<br /><br /> -   <xref:System.Windows.Forms.Control.Visible%2A> = `true` сопоставляется <xref:System.Windows.Visibility.Visible>.<br />-   <xref:System.Windows.Forms.Control.Visible%2A> = `false` сопоставляется <xref:System.Windows.Visibility.Hidden>.|  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Integration.ElementHost>
- <xref:System.Windows.Forms.Integration.WindowsFormsHost>
- [Взаимодействие WPF и Win32](wpf-and-win32-interoperation.md)
- [Взаимодействие WPF и Windows Forms](wpf-and-windows-forms-interoperation.md)
- [Пошаговое руководство. Сопоставление свойств с помощью элемента WindowsFormsHost](walkthrough-mapping-properties-using-the-windowsformshost-element.md)
- [Пошаговое руководство. Сопоставление свойств с помощью элемента управления ElementHost](walkthrough-mapping-properties-using-the-elementhost-control.md)

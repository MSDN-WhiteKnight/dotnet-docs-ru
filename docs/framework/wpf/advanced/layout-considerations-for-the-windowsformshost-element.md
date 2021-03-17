---
title: Вопросы, связанные с макетом элемента WindowsFormsHost
ms.date: 03/30/2017
helpviewer_keywords:
- Windows Forms [WPF], interoperability with
- Windows Forms [WPF], WPF interoperation
- interoperability [WPF], Windows Forms
- WindowsFormsHost element layout considerations [WPF]
- dynamic layout [WPF interoperability]
- device-independent pixels
ms.assetid: 3c574597-bbde-440f-95cc-01371f1a5d9d
ms.openlocfilehash: 93aaa8e21ef483fc21297e29189d86f93fbe138a
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59327858"
---
# <a name="layout-considerations-for-the-windowsformshost-element"></a>Вопросы, связанные с макетом элемента WindowsFormsHost
Здесь описывается, как <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент взаимодействует с [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] система макета.  
  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] и [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] поддержки различных, но очень похожие логики для изменения размеров и положения элементов на форму или страницу. При создании гибридного пользовательский интерфейс (UI), на котором размещена [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементов управления в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент интегрирует две схемы макета.  
  
## <a name="differences-in-layout-between-wpf-and-windows-forms"></a>Различия в макет WPF и Windows Forms  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] использует независимой от разрешения макета. Все [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] измерения макета указываются с помощью *аппаратно независимых пикселях*. Аппаратно независимый пиксель — один девяносто шестую дюйма размера и разрешения, чтобы получить аналогичные результаты независимо от того, выполняется отрисовка монитор 72 dpi или на принтер 19200 dpi.  
  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] также основана на *динамический макет*. Это означает, что элемент пользовательского интерфейса располагается на формы или страницы в соответствии с его содержимое, макет его родительского контейнера и размер экрана. Динамический макет упрощает локализацию, используя автоматическую корректировку размера и положения элементов пользовательского интерфейса, изменении длины строки, которые они содержат.  
  
 Макет в [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] зависящие от устройства и скорее всего, будут статическими. Как правило [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] абсолютного позиционирования элементов управления формы с помощью измерений, указанных в аппаратно зависимые пиксели. Тем не менее [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] поддерживают некоторые функции динамического макета, как описано в следующей таблице.  
  
|Функция макета|Описание|  
|--------------------|-----------------|  
|Автоматическое изменение размера|Некоторые [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] изменение размера элементов управления, с целью отображения их содержимое должным образом. Дополнительные сведения см. в разделе [Общие](../../winforms/controls/autosize-property-overview.md).|  
|Привязка и закрепление|[!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементы управления поддерживают размещение и изменение размера, основанное на родительском контейнере. Дополнительные сведения см. в разделах <xref:System.Windows.Forms.Control.Anchor%2A?displayProperty=nameWithType> и <xref:System.Windows.Forms.Control.Dock%2A?displayProperty=nameWithType>.|  
|Автоматическое масштабирование|Контейнерные элементы управления, измените размер себя и своих потомков в зависимости от разрешения на устройство вывода или размер в пикселях шрифта контейнера по умолчанию. Дополнительные сведения см. в разделе [автоматическое масштабирование в Windows Forms](../../winforms/automatic-scaling-in-windows-forms.md).|  
|Контейнеры макета|<xref:System.Windows.Forms.FlowLayoutPanel> И <xref:System.Windows.Forms.TableLayoutPanel> элементы управления, упорядочить их дочерние элементы управления и размер самостоятельно, в соответствии с их содержимое.|  
  
## <a name="layout-limitations"></a>Ограничения макета  
 В общем случае [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементы управления нельзя масштабировать и преобразуются в той степени, возможных в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]. Ниже перечислены известные ограничения при <xref:System.Windows.Forms.Integration.WindowsFormsHost> пытается интегрировать вложенный элемент [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] управления в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] системы макета.  
  
-   В некоторых случаях размеры элемента управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] изменять нельзя, или же их можно изменять, но только в фиксированных пределах. Например [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] <xref:System.Windows.Forms.ComboBox> элемент управления поддерживает только одну высоту, которая определяется размером шрифта элемента управления. В [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] динамический макет, где элементы можно растянуть по вертикали, вложенный <xref:System.Windows.Forms.ComboBox> управления не растягивается, как ожидалось.  
  
-   [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементы управления нельзя поворачивать или неравномерным. <xref:System.Windows.Forms.Integration.WindowsFormsHost> — Вызывает <xref:System.Windows.Forms.Integration.WindowsFormsHost.LayoutError> событий при применении преобразования Искажение или поворот. Если не обработать <xref:System.Windows.Forms.Integration.WindowsFormsHost.LayoutError> событий, <xref:System.InvalidOperationException> возникает.  
  
-   В большинстве случаев элементы управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] не поддерживают пропорциональное масштабирование. Несмотря на то, что общий размер элемента управления масштабируется, дочерние элементы управления и компоненты элемента управления могут изменять размеры не так, как ожидается. Это ограничение зависит от поддержки масштабирования каждым элементом управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)]. Кроме того, нельзя масштабировать [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементов управления до размера, равные 0 пикселей.  
  
-   [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементы управления поддерживают автоматическое масштабирование, в котором формы автоматически будут изменены и его элементы управления, в зависимости от размера шрифта. В пользовательском интерфейсе [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] изменение размера шрифта не влечет за собой изменение размера всего макета, хотя отдельные элементы могут динамически изменять размер.  
  
### <a name="z-order"></a>Z-порядка  
 В пользовательском интерфейсе [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] можно изменить z-порядок элементов для контроля поведения перекрывания. Вложенный элемент управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] рисуется в отдельном HWND, причем он всегда рисуется поверх элементов [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)].  
  
 Вложенный [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] также прорисовывается поверх любого <xref:System.Windows.Documents.Adorner> элементов.  
  
## <a name="layout-behavior"></a>Поведение макета  
 В следующих разделах описываются отдельные аспекты поведения макета при размещении [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементов управления в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)].  
  
### <a name="scaling-unit-conversion-and-device-independence"></a>Масштабирование, преобразование единиц измерения и независимость от оборудования  
 Каждый раз, когда <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент выполняет операции, связанные с [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] и [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] связанных измерений, две системы координат: аппаратно независимых пикселях для [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] и аппаратно зависимые пиксели для [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)]. Таким образом необходимо применить соответствующие модульные и преобразования масштабирования, чтобы добиться согласованного макета.  
  
 Преобразование между системами координат зависит от текущего разрешения устройства и любого макета или преобразований отрисовки, примененных к <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемента или к его предкам.  
  
 Если устройство вывода имеет 96 точек на дюйм и без масштабирования применен к <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент, один аппаратно независимый пиксель равен одному пикселю оборудования.  
  
 Во всех остальных случаях требуется масштабирование системы координат. Размещаемый элемент управления не изменяется. Вместо этого <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент пытается масштабирования размещаемого элемента управления и все его дочерние элементы управления. Так как [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] не полностью поддерживает масштабирование, <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент масштабируется в степени, поддерживаемой конкретных элементов управления.  
  
 Переопределить <xref:System.Windows.Forms.Integration.WindowsFormsHost.ScaleChild%2A> метод для предоставления пользовательского поведения масштабирования для размещаемого элемента управления Windows Forms.  
  
 Кроме масштабирования, <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент обрабатывает случаи округления и переполнения, как описано в следующей таблице.  
  
|Проблема преобразования|Описание|  
|----------------------|-----------------|  
|Округление|[!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] аппаратно независимых пикселах задаются в виде `double`, и [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] оборудования размеры указываются в виде `int`. В случаях, где `double`-измерения, основанные на преобразуются в `int`-на основе измерения, <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент использует стандартное округление, таким образом, чтобы меньше 0,5 дробные значения округляются до 0.|  
|Переполнение|При <xref:System.Windows.Forms.Integration.WindowsFormsHost> преобразует элемент из `double` значения `int` значения, возможна переполнения. Значения, размер которых превышает <xref:System.Int32.MaxValue> присваивается <xref:System.Int32.MaxValue>.|  
  
### <a name="layout-related-properties"></a>Свойства, связанные с макетом  
 Свойства, управляющие поведением макета в [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементов управления и [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] элементов сопоставляются соответствующим образом с <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент. Дополнительные сведения см. в разделе [Сопоставление свойств Windows Forms и WPF](windows-forms-and-wpf-property-mapping.md).  
  
### <a name="layout-changes-in-the-hosted-control"></a>Изменения макета в размещенный элемент управления  
 Изменения макета в размещаемом [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] управления распространяются на [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] для запуска обновлений макета. <xref:System.Windows.UIElement.InvalidateMeasure%2A> Метод <xref:System.Windows.Forms.Integration.WindowsFormsHost> гарантирует, что изменения макета в размещенный элемент управления вызывает [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] обработчик макетов для запуска.  
  
### <a name="continuously-sized-windows-forms-controls"></a>Постоянно размера элементов управления Windows Forms  
 [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементы управления, которые поддерживают непрерывное масштабирование, полностью взаимодействовать с [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] система макета. <xref:System.Windows.Forms.Integration.WindowsFormsHost> Элемент использует <xref:System.Windows.FrameworkElement.MeasureOverride%2A> и <xref:System.Windows.FrameworkElement.ArrangeOverride%2A> методы обычным образом для определения размеров и расположения размещенного [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элемента управления.  
  
### <a name="sizing-algorithm"></a>Алгоритм определения  
 <xref:System.Windows.Forms.Integration.WindowsFormsHost> Элемент использует следующую процедуру для изменения размера размещенного элемента управления:  
  
1. <xref:System.Windows.Forms.Integration.WindowsFormsHost> Переопределяет <xref:System.Windows.FrameworkElement.MeasureOverride%2A> и <xref:System.Windows.FrameworkElement.ArrangeOverride%2A> методы.  
  
2. Чтобы определить размер размещаемого элемента управления, <xref:System.Windows.FrameworkElement.MeasureOverride%2A> размещенного элемента управления вызывает метод <xref:System.Windows.Forms.Control.GetPreferredSize%2A> метод с ограничением, полученным от ограничения, передаваемый <xref:System.Windows.FrameworkElement.MeasureOverride%2A> метод.  
  
3. <xref:System.Windows.FrameworkElement.ArrangeOverride%2A> Метод пытается присвоить ограничения заданного размера размещенного элемента управления.  
  
4. Если размещенного элемента управления <xref:System.Windows.Forms.Control.Size%2A> соответствует указанным ограничениям, размещаемого элемента управления изменяется в соответствии с ограничением.  
  
 Если <xref:System.Windows.Forms.Control.Size%2A> свойство не соответствует указанным ограничениям, размещаемый элемент управления не поддерживает постоянное изменение размера. Например <xref:System.Windows.Forms.MonthCalendar> элемент управления допускает только дискретные размеры. Допустимые размеры для данного элемента управления состоят из целых чисел (который представляет количество месяцев) для высоты и ширины. В подобных случаях <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент ведет себя следующим образом:  
  
-   Если <xref:System.Windows.Forms.Control.Size%2A> свойство возвращает большего размера, чем указанное ограничение, <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент обрезает размещенный элемент управления. Высота и ширина обрабатываются отдельно, поэтому размещаемый элемент управления может быть ограничен в любом направлении.  
  
-   Если <xref:System.Windows.Forms.Control.Size%2A> свойство возвращает меньший размер, чем указанное ограничение, <xref:System.Windows.Forms.Integration.WindowsFormsHost> принимает это значение размера и возвращает значение для [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] системы макета.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Integration.ElementHost>
- <xref:System.Windows.Forms.Integration.WindowsFormsHost>
- [Пошаговое руководство. Упорядочение элементов управления Windows Forms в WPF](walkthrough-arranging-windows-forms-controls-in-wpf.md)
- [Элементы управления упорядочение Windows Forms в WPF](https://go.microsoft.com/fwlink/?LinkID=159971)
- [Сопоставление свойств Windows Forms и WPF](windows-forms-and-wpf-property-mapping.md)
- [Миграция и взаимодействие систем](migration-and-interoperability.md)

---
title: Стили и шаблоны элемента TreeView
ms.date: 03/30/2017
helpviewer_keywords:
- ControlTemplate [WPF], TreeView
- templates [WPF], TreeView
- parts [WPF], TreeView
- states [WPF], TreeView
- styles [WPF], TreeView
- TreeView [WPF], styles and templates
ms.assetid: a49adb77-0202-4caa-b94a-8bb110d7fa9a
ms.openlocfilehash: 01841bb828594dd4cac0c179d70495fe392c8de5
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59142711"
---
# <a name="treeview-styles-and-templates"></a>Стили и шаблоны элемента TreeView
В этом разделе описываются стили и шаблоны для <xref:System.Windows.Controls.TreeView> элемента управления. Вы можете изменить значение по умолчанию <xref:System.Windows.Controls.ControlTemplate> предоставить уникальный внешний вид элемента управления. Подробнее см. в разделе [Настройка внешнего вида существующего элемента управления путем создания объекта ControlTemplate](customizing-the-appearance-of-an-existing-control.md).  
  
## <a name="treeview-parts"></a>Части элемента управления TreeView  
 <xref:System.Windows.Controls.TreeView> Управления не имеет частей с именами.  
  
 При создании <xref:System.Windows.Controls.ControlTemplate> для <xref:System.Windows.Controls.TreeView>, шаблон может содержать <xref:System.Windows.Controls.ItemsPresenter> в <xref:System.Windows.Controls.ScrollViewer>. ( <xref:System.Windows.Controls.ItemsPresenter> Отображает каждый элемент в <xref:System.Windows.Controls.TreeView>; <xref:System.Windows.Controls.ScrollViewer> дает возможность прокрутки в элементе управления).  Если <xref:System.Windows.Controls.ItemsPresenter> не является прямым потомком <xref:System.Windows.Controls.ScrollViewer>, необходимо предоставить <xref:System.Windows.Controls.ItemsPresenter> имя `ItemsPresenter`.  
  
## <a name="treeview-states"></a>Состояния элемента управления TreeView  
 В следующей таблице перечислены визуальные состояния <xref:System.Windows.Controls.TreeView> элемента управления.  
  
|Имя VisualState|Имя VisualStateGroup|Описание|  
|-|-|-|  
|Valid|ValidationStates|Элемент управления использует <xref:System.Windows.Controls.Validation> класс и <xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> присоединенное свойство `false`.|  
|InvalidFocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления имеет фокус.|  
|InvalidUnfocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления не имеет фокуса.|  
  
## <a name="treeviewitem-parts"></a>Элементы TreeViewItem  
 В следующей таблице перечислены именованные части <xref:System.Windows.Controls.TreeViewItem> элемента управления.  
  
|Отделение|Тип|Описание|  
|----------|----------|-----------------|  
|PART_Header|<xref:System.Windows.FrameworkElement>|Визуальный элемент, который содержит заголовок, содержимое <xref:System.Windows.Controls.TreeView> элемента управления.|  
  
## <a name="treeviewitem-states"></a>Состояния элемента TreeViewItem  
 В следующей таблице перечислены визуальные состояния <xref:System.Windows.Controls.TreeViewItem> элемента управления.  
  
|Имя VisualState|Имя VisualStateGroup|Описание|  
|----------------------|---------------------------|-----------------|  
|Норм.|CommonStates|Состояние по умолчанию.|  
|MouseOver|CommonStates|Указатель мыши наведен на <xref:System.Windows.Controls.TreeViewItem>.|  
|Отключено|CommonStates|<xref:System.Windows.Controls.TreeViewItem> Отключена.|  
|Focused|FocusStates|<xref:System.Windows.Controls.TreeViewItem> Имеет фокус.|  
|Без фокуса ввода|FocusStates|<xref:System.Windows.Controls.TreeViewItem> Не имеет фокуса.|  
|Разреженный|ExpansionStates|<xref:System.Windows.Controls.TreeViewItem> Элемент управления развернут.|  
|Свернуто|ExpansionStates|<xref:System.Windows.Controls.TreeViewItem> Элемент управления свернут.|  
|Hasitems, доступное|HasItemsStates|<xref:System.Windows.Controls.TreeViewItem> Содержит элементы.|  
|NoItems|HasItemsStates|<xref:System.Windows.Controls.TreeViewItem> Не имеет элементов.|  
|Selected|SelectionStates|<xref:System.Windows.Controls.TreeViewItem> Выбран.|  
|SelectedInactive|SelectionStates|<xref:System.Windows.Controls.TreeViewItem> Выбран, но не активен.|  
|Unselected|SelectionStates|<xref:System.Windows.Controls.TreeViewItem> Не выбран.|  
|Valid|ValidationStates|Элемент управления использует <xref:System.Windows.Controls.Validation> класс и <xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> присоединенное свойство `false`.|  
|InvalidFocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления имеет фокус.|  
|InvalidUnfocused|ValidationStates|<xref:System.Windows.Controls.Validation.HasError%2A?displayProperty=nameWithType> Присоединенное свойство `true` имеет элемент управления не имеет фокуса.|  
  
## <a name="treeview-controltemplate-example"></a>Пример шаблона элемента управления TreeView  
 В следующем примере показано определение <xref:System.Windows.Controls.ControlTemplate> для <xref:System.Windows.Controls.TreeView> элемента управления и его связанных типов.  
  
 [!code-xaml[ControlTemplateExamples#TreeView](~/samples/snippets/csharp/VS_Snippets_Wpf/ControlTemplateExamples/CS/resources/treeview.xaml#treeview)]  
  
 В предыдущем примере используется один или несколько из следующих ресурсов.  
  
 [!code-xaml[ControlTemplateExamples#Resources](~/samples/snippets/csharp/VS_Snippets_Wpf/ControlTemplateExamples/CS/resources/shared.xaml#resources)]  
  
 Полный пример см. в разделе [Пример задания стиля с помощью ControlTemplates](https://github.com/Microsoft/WPF-Samples/tree/master/Styles%20&%20Templates/IntroToStylingAndTemplating).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.FrameworkElement.Style%2A>
- <xref:System.Windows.Controls.ControlTemplate>
- [Стили и шаблоны элемента Control](control-styles-and-templates.md)
- [Настройка элементов управления](control-customization.md)
- [Стилизация и использование шаблонов](styling-and-templating.md)
- [Настройка внешнего вида существующего элемента управления путем создания объекта ControlTemplate](customizing-the-appearance-of-an-existing-control.md)

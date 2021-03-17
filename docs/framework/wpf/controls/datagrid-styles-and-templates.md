---
title: Стили и шаблоны элемента DataGrid
ms.date: 03/30/2017
helpviewer_keywords:
- states [WPF], DataGrid
- ControlTemplate [WPF], DataGrid
- DataGrid [WPF], styles and templates
- templates [WPF], DataGrid
- styles [WPF], DataGrid
- parts [WPF], DataGrid
ms.assetid: 9cb31d63-f148-4d25-b079-816e73f988c7
ms.openlocfilehash: dacc1222958ab05971c9681d33a0c431b72d0531
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59218463"
---
# <a name="datagrid-styles-and-templates"></a>Стили и шаблоны элемента DataGrid
В этом разделе описываются стили и шаблоны для <xref:System.Windows.Controls.DataGrid> элемента управления. Вы можете изменить значение по умолчанию <xref:System.Windows.Controls.ControlTemplate> предоставить уникальный внешний вид элемента управления. Подробнее см. в разделе [Настройка внешнего вида существующего элемента управления путем создания объекта ControlTemplate](customizing-the-appearance-of-an-existing-control.md).  
  
## <a name="datagrid-parts"></a>Элементы управления DataGrid  
 В следующей таблице перечислены именованные части <xref:System.Windows.Controls.DataGrid> элемента управления.  
  
|Отделение|Тип|Описание|  
|-|-|-|  
|PART_ColumnHeadersPresenter|<xref:System.Windows.Controls.Primitives.DataGridColumnHeadersPresenter>|Строки, содержащей заголовки столбцов.|  
  
 При создании <xref:System.Windows.Controls.ControlTemplate> для <xref:System.Windows.Controls.DataGrid>, шаблон может содержать <xref:System.Windows.Controls.ItemsPresenter> в <xref:System.Windows.Controls.ScrollViewer>. ( <xref:System.Windows.Controls.ItemsPresenter> Отображает каждый элемент в <xref:System.Windows.Controls.DataGrid>; <xref:System.Windows.Controls.ScrollViewer> дает возможность прокрутки в элементе управления).  Если <xref:System.Windows.Controls.ItemsPresenter> не является прямым потомком <xref:System.Windows.Controls.ScrollViewer>, необходимо предоставить <xref:System.Windows.Controls.ItemsPresenter> имя `ItemsPresenter`.  
  
 Шаблон по умолчанию для <xref:System.Windows.Controls.DataGrid> содержит <xref:System.Windows.Controls.ScrollViewer> элемента управления. Дополнительные сведения об элементах, определяется <xref:System.Windows.Controls.ScrollViewer>, см. в разделе [ScrollViewer стили и шаблоны](scrollviewer-styles-and-templates.md).  
  
## <a name="datagrid-states"></a>Состояния DataGrid  
 В следующей таблице перечислены визуальные состояния <xref:System.Windows.Controls.DataGrid> элемента управления.  
  
|Имя VisualState|Имя VisualStateGroup|Описание|  
|-|-|-|  
|Норм.|CommonStates|Состояние по умолчанию.|  
|Отключено|CommonStates|Элемент управления отключен.|  
|InvalidFocused|ValidationStates|Элемент управления не является допустимым и имеет фокус.|  
|InvalidUnfocused|ValidationStates|Элемент управления не является допустимым и не имеет фокуса.|  
|Valid|ValidationStates|Элемент управления является допустимым.|  
  
## <a name="datagridcell-parts"></a>DataGridCell частей  
 <xref:System.Windows.Controls.DataGridCell> Элемент не имеет частей с именами.  
  
## <a name="datagridcell-states"></a>DataGridCell состояний  
 В следующей таблице перечислены визуальные состояния <xref:System.Windows.Controls.DataGridCell> элемент.  
  
|Имя VisualState|Имя VisualStateGroup|Описание|  
|-|-|-|  
|Норм.|CommonStates|Состояние по умолчанию.|  
|MouseOver|CommonStates|Указатель мыши наведен на ячейку.|  
|Focused|FocusStates|Ячейка имеет фокус.|  
|Без фокуса ввода|FocusStates|Ячейка не имеет фокуса|  
|Текущие|CurrentStates|Ячейка является текущей ячейкой.|  
|Регулярное|CurrentStates|Ячейка не содержится текущая ячейка.|  
|Отображение|InteractionStates|Ячейка находится в режиме отображения.|  
|Редактирование|InteractionStates|Ячейка находится в режиме правки.|  
|Selected|SelectionStates|Выбрана ячейка.|  
|Unselected|SelectionStates|Не выбрана ячейка.|  
|InvalidFocused|ValidationStates|Ячейка не является допустимым и имеет фокус.|  
|InvalidUnfocused|ValidationStates|Ячейка не является допустимым и не имеет фокуса.|  
|Valid|ValidationStates|Ячейка является допустимой.|  
  
## <a name="datagridrow-parts"></a>DataGridRow частей  
 <xref:System.Windows.Controls.DataGridRow> Элемент не имеет частей с именами.  
  
## <a name="datagridrow-states"></a>DataGridRow состояний  
 В следующей таблице перечислены визуальные состояния <xref:System.Windows.Controls.DataGridRow> элемент.  
  
|Имя VisualState|Имя VisualStateGroup|Описание|  
|-|-|-|  
|Норм.|CommonStates|Состояние по умолчанию.|  
|MouseOver|CommonStates|Указатель мыши наведен на строку.|  
|MouseOver_Editing|CommonStates|Указатель мыши наведен на строку и строка находится в режиме правки.|  
|MouseOver_Selected|CommonStates|Указатель мыши наведен на строки и выбрана строка.|  
|MouseOver_Unfocused_Editing|CommonStates|Указатель мыши наведен на строку, строка находится в режиме редактирования и не имеет фокуса.|  
|MouseOver_Unfocused_Selected|CommonStates|Указатель мыши наведен на строку, строка выбрана и не имеет фокуса.|  
|Normal_AlternatingRow|CommonStates|Строка является чередующейся.|  
|Normal_Editing|CommonStates|Строка находится в режиме правки.|  
|Normal_Selected|CommonStates|Выбрана строка.|  
|Unfocused_Editing|CommonStates|Строка находится в режиме редактирования и не имеет фокуса.|  
|Unfocused_Selected|CommonStates|Строка выбрана и не имеет фокуса.|  
|InvalidFocused|ValidationStates|Элемент управления не является допустимым и имеет фокус.|  
|InvalidUnfocused|ValidationStates|Элемент управления не является допустимым и не имеет фокуса.|  
|Valid|ValidationStates|Элемент управления является допустимым.|  
  
## <a name="datagridrowheader-parts"></a>DataGridRowHeader частей  
 В следующей таблице перечислены именованные части <xref:System.Windows.Controls.Primitives.DataGridRowHeader> элемент.  
  
|Отделение|Тип|Описание|  
|-|-|-|  
|PART_TopHeaderGripper|<xref:System.Windows.Controls.Primitives.Thumb>|Элемент, который используется для изменения размера заголовка строки сверху.|  
|PART_BottomHeaderGripper|<xref:System.Windows.Controls.Primitives.Thumb>|Элемент, который используется для изменения размера заголовка строки в нижней части.|  
  
## <a name="datagridrowheader-states"></a>DataGridRowHeader состояний  
 В следующей таблице перечислены визуальные состояния <xref:System.Windows.Controls.Primitives.DataGridRowHeader> элемент.  
  
|Имя VisualState|Имя VisualStateGroup|Описание|  
|-|-|-|  
|Норм.|CommonStates|Состояние по умолчанию.|  
|MouseOver|CommonStates|Указатель мыши наведен на строку.|  
|MouseOver_CurrentRow|CommonStates|Указатель мыши наведен на строку, и строка является текущей строки.|  
|MouseOver_CurrentRow_Selected|CommonStates|Указатель мыши наведен на строку, и строка является текущей и выбранной.|  
|MouseOver_EditingRow|CommonStates|Указатель мыши наведен на строку и строка находится в режиме правки.|  
|MouseOver_Selected|CommonStates|Указатель мыши наведен на строки и выбрана строка.|  
|MouseOver_Unfocused_CurrentRow_Selected|CommonStates|Указатель мыши наведен на строку, текущей и выбранной строки и не имеет фокуса.|  
|MouseOver_Unfocused_EditingRow|CommonStates|Указатель мыши наведен на строку, строка находится в режиме редактирования и не имеет фокуса.|  
|MouseOver_Unfocused_Selected|CommonStates|Указатель мыши наведен на строку, строка выбрана и не имеет фокуса.|  
|Normal_CurrentRow|CommonStates|Строка является текущей строки.|  
|Normal_CurrentRow_Selected|CommonStates|Строка является текущей и выбран.|  
|Normal_EditingRow|CommonStates|Строка находится в режиме правки.|  
|Normal_Selected|CommonStates|Выбрана строка.|  
|Unfocused_CurrentRow_Selected|CommonStates|Строка является текущей, выбран и не имеет фокуса.|  
|Unfocused_EditingRow|CommonStates|Строка находится в режиме редактирования и не имеет фокуса.|  
|Unfocused_Selected|CommonStates|Строка выбрана и не имеет фокуса.|  
|InvalidFocused|ValidationStates|Элемент управления не является допустимым и имеет фокус.|  
|InvalidUnfocused|ValidationStates|Элемент управления не является допустимым и не имеет фокуса.|  
|Valid|ValidationStates|Элемент управления является допустимым.|  
  
## <a name="datagridcolumnheaderspresenter-parts"></a>DataGridColumnHeadersPresenter частей  
 В следующей таблице перечислены именованные части <xref:System.Windows.Controls.Primitives.DataGridColumnHeadersPresenter> элемент.  
  
|Отделение|Тип|Описание|  
|-|-|-|  
|PART_FillerColumnHeader|<xref:System.Windows.Controls.Primitives.DataGridColumnHeader>|Заполнитель для заголовков столбцов.|  
  
## <a name="datagridcolumnheaderspresenter-states"></a>DataGridColumnHeadersPresenter состояний  
 В следующей таблице перечислены визуальные состояния <xref:System.Windows.Controls.Primitives.DataGridColumnHeadersPresenter> элемент.  
  
|Имя VisualState|Имя VisualStateGroup|Описание|  
|-|-|-|  
|InvalidFocused|ValidationStates|Ячейка не является допустимым и имеет фокус.|  
|InvalidUnfocused|ValidationStates|Ячейка не является допустимым и не имеет фокуса.|  
|Valid|ValidationStates|Ячейка является допустимой.|  
  
## <a name="datagridcolumnheader-parts"></a>DataGridColumnHeader частей  
 В следующей таблице перечислены именованные части <xref:System.Windows.Controls.Primitives.DataGridColumnHeader> элемент.  
  
|Отделение|Тип|Описание|  
|-|-|-|  
|PART_LeftHeaderGripper|<xref:System.Windows.Controls.Primitives.Thumb>|Элемент, который используется для изменения размера заголовка столбца слева.|  
|PART_RightHeaderGripper|<xref:System.Windows.Controls.Primitives.Thumb>|Элемент, который используется для изменения размера заголовка столбца из правого входа.|  
  
## <a name="datagridcolumnheader-states"></a>DataGridColumnHeader состояний  
 В следующей таблице перечислены визуальные состояния <xref:System.Windows.Controls.Primitives.DataGridColumnHeader> элемент.  
  
|Имя VisualState|Имя VisualStateGroup|Описание|  
|-|-|-|  
|Норм.|CommonStates|Состояние по умолчанию.|  
|MouseOver|CommonStates|Указатель мыши расположен в элементе управления.|  
|Нажато|CommonStates|Элемент управления нажат.|  
|SortAscending|SortStates|Столбец сортируется в порядке возрастания.|  
|SortDescending|SortStates|Столбец сортируется в порядке убывания.|  
|Без сортировки|SortStates|Столбец не отсортирован.|  
|InvalidFocused|ValidationStates|Элемент управления не является допустимым и имеет фокус.|  
|InvalidUnfocused|ValidationStates|Элемент управления не является допустимым и не имеет фокуса.|  
|Valid|ValidationStates|Элемент управления является допустимым.|  
  
## <a name="datagrid-controltemplate-example"></a>Пример шаблона элемента управления DataGrid  
 В следующем примере показано определение <xref:System.Windows.Controls.ControlTemplate> для <xref:System.Windows.Controls.DataGrid> элемента управления и его связанных типов.  
  
 [!code-xaml[ControlTemplateExamples#DataGrid](~/samples/snippets/csharp/VS_Snippets_Wpf/ControlTemplateExamples/CS/resources/datagrid.xaml#datagrid)]  
  
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

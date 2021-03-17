---
title: DataGrid
ms.date: 03/30/2017
helpviewer_keywords:
- DataGrid column types [WPF]
- DataGrid scenarios [WPF]
- DataGrid control [WPF]
- controls [WPF], DataGrid
- DataGrid [WPF], common tasks for
- DataGrid [WPF], customizing the appearance of
- DataGrid columns [WPF], using
ms.assetid: bf89ea63-79b6-422b-bc9f-0485ad803216
ms.openlocfilehash: dda712d58a4ff956de074ecd416402ba0aece5f4
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59197156"
---
# <a name="datagrid"></a>DataGrid
<xref:System.Windows.Controls.DataGrid> Элемент управления позволяет отображать и редактировать данные из множества различных источников, таких как базы данных SQL, LINQ-запрос или любой другой источник привязки данных. Дополнительные сведения см. в разделе [Общие сведения об источниках привязки](../data/binding-sources-overview.md).  
  
 Столбцы могут отображать текст, элементы управления, такие как <xref:System.Windows.Controls.ComboBox>, или любое другое содержимое WPF, такие как изображения, кнопки или любое содержимое, содержащихся в шаблоне. Можно использовать <xref:System.Windows.Controls.DataGridTemplateColumn> для отображения данных, определенных в шаблоне. Ниже перечислены типы столбцов, которые предоставляются по умолчанию.  
  
|Тип создаваемого столбца|Тип данных|  
|---------------------------|---------------|  
|<xref:System.Windows.Controls.DataGridTextColumn>|<xref:System.String>|  
|<xref:System.Windows.Controls.DataGridCheckBoxColumn>|<xref:System.Boolean>|  
|<xref:System.Windows.Controls.DataGridComboBoxColumn>|<xref:System.Enum>|  
|<xref:System.Windows.Controls.DataGridHyperlinkColumn>|<xref:System.Uri>|  
  
 <xref:System.Windows.Controls.DataGrid> можно настраивать внешний вид, например ячейки шрифт, цвет и размер. <xref:System.Windows.Controls.DataGrid> поддерживает все функциональные возможности стилизации и других элементов управления WPF. <xref:System.Windows.Controls.DataGrid> также включает по умолчанию и настраиваемые расширения функциональности для редактирования, сортировки и проверки.  
  
 В следующей таблице перечислены некоторые из наиболее распространенных задач <xref:System.Windows.Controls.DataGrid> и способах их выполнения. Просматривая соответствующий API, можно найти дополнительные сведения и пример кода.  
  
|Сценарий|Подход|  
|--------------|--------------|  
|Чередующиеся фоновые цвета|Задайте <xref:System.Windows.Controls.ItemsControl.AlternationIndex%2A> значение 2 или более, а затем назначьте <xref:System.Windows.Media.Brush> для <xref:System.Windows.Controls.DataGrid.RowBackground%2A> и <xref:System.Windows.Controls.DataGrid.AlternatingRowBackground%2A> свойства.|  
|Определение поведения выбора ячейки и строки|Задайте свойства <xref:System.Windows.Controls.DataGrid.SelectionMode%2A> и <xref:System.Windows.Controls.DataGrid.SelectionUnit%2A>.|  
|Настройка внешнего вида заголовков, ячеек и строк|Применить новый <xref:System.Windows.Style> для <xref:System.Windows.Controls.DataGrid.ColumnHeaderStyle%2A>, <xref:System.Windows.Controls.DataGrid.RowHeaderStyle%2A>, <xref:System.Windows.Controls.DataGrid.CellStyle%2A>, или <xref:System.Windows.Controls.DataGrid.RowStyle%2A> свойства.|  
|Задание параметров изменения размера|Задайте <xref:System.Windows.FrameworkElement.Height%2A>, <xref:System.Windows.FrameworkElement.MaxHeight%2A>, <xref:System.Windows.FrameworkElement.MinHeight%2A>, <xref:System.Windows.FrameworkElement.Width%2A>, <xref:System.Windows.FrameworkElement.MaxWidth%2A>, или <xref:System.Windows.FrameworkElement.MinWidth%2A> свойства. Дополнительные сведения см. в разделе [параметров изменения размеров элемента управления DataGrid](sizing-options-in-the-datagrid-control.md).|  
|Доступ к выбранным элементам|Проверьте <xref:System.Windows.Controls.DataGrid.SelectedCells%2A> свойство для получения выделенных ячеек и <xref:System.Windows.Controls.Primitives.MultiSelector.SelectedItems%2A> свойства выбранных строк. Дополнительные сведения см. в разделе <xref:System.Windows.Controls.DataGrid.SelectedCells%2A>.|  
|Настройка взаимодействия|Задайте <xref:System.Windows.Controls.DataGrid.CanUserAddRows%2A>, <xref:System.Windows.Controls.DataGrid.CanUserDeleteRows%2A>, <xref:System.Windows.Controls.DataGrid.CanUserReorderColumns%2A>, <xref:System.Windows.Controls.DataGrid.CanUserResizeColumns%2A>, <xref:System.Windows.Controls.DataGrid.CanUserResizeRows%2A>, и <xref:System.Windows.Controls.DataGrid.CanUserSortColumns%2A> свойства.|  
|Отменить или изменить автоматически созданных столбцов|Обрабатывать <xref:System.Windows.Controls.DataGrid.AutoGeneratingColumn> событий.|  
|Закрепить столбец|Задайте <xref:System.Windows.Controls.DataGrid.FrozenColumnCount%2A> свойство 1 и переместите столбец в крайней левой позиции, задав <xref:System.Windows.Controls.DataGridColumn.DisplayIndex%2A> значение 0.|  
|Использование XML-данных в качестве источника данных|Привязать <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A> на <xref:System.Windows.Controls.DataGrid> к запросу XPath, который представляет коллекцию элементов. Создайте каждый столбец в <xref:System.Windows.Controls.DataGrid>. Выполнить привязку каждого столбца, задав для привязки к запросу, который возвращает свойство источника элемента XPath. Пример см. в разделе <xref:System.Windows.Controls.DataGridTextColumn>.|  
  
## <a name="related-topics"></a>См. также  
  
|Заголовок|Описание|  
|-----------|-----------------|  
|[Пошаговое руководство. Отображение данных из базы данных SQL Server в элементе управления DataGrid](walkthrough-display-data-from-a-sql-server-database-in-a-datagrid-control.md)|Описывается, как настроить новый проект WPF, добавьте элемент Entity Framework, в качестве источника указывается и отображения данных в <xref:System.Windows.Controls.DataGrid>.|  
|[Практическое руководство. Добавление сведений о строках в элемент управления DataGrid](how-to-add-row-details-to-a-datagrid-control.md)|Описывает способы создания сведений о строках для <xref:System.Windows.Controls.DataGrid>.|  
|[Практическое руководство. Реализация проверки с помощью элемента управления DataGrid](how-to-implement-validation-with-the-datagrid-control.md)|Содержит описание способов проверки значений в <xref:System.Windows.Controls.DataGrid> ячеек и строк и отображения результатов проверки.|  
|[Поведение мыши и клавиатуры по умолчанию в элементе управления DataGrid](default-keyboard-and-mouse-behavior-in-the-datagrid-control.md)|Описывает способы взаимодействия с <xref:System.Windows.Controls.DataGrid> элемента управления с помощью клавиатуры и мыши.|  
|[Практическое руководство. Группировка, сортировка и фильтрация данных в элементе управления DataGrid](how-to-group-sort-and-filter-data-in-the-datagrid-control.md)|Описывается, как просматривать данные в <xref:System.Windows.Controls.DataGrid> по-разному, группирования, сортировки и фильтрации данных.|  
|[Параметры изменения размеров элемента управления DataGrid](sizing-options-in-the-datagrid-control.md)|Описывает управление абсолютными и автоматического изменения размера в <xref:System.Windows.Controls.DataGrid>.|  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.DataGrid>
- [Стилизация и использование шаблонов](styling-and-templating.md)
- [Общие сведения о привязке данных](../data/data-binding-overview.md)
- [Общие сведения о шаблонах данных](../data/data-templating-overview.md)
- [Элементы управления](index.md)
- [Модель содержимого WPF](wpf-content-model.md)

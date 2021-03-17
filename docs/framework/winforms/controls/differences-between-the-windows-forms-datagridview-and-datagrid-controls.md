---
title: Различия элементов управления DataGridView и DataGrid в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- data grids [Windows Forms
- DataGrid control [Windows Forms], DataGridView control compared
- DataGridView control [Windows Forms], DataGrid control compared
ms.assetid: d412c786-140e-4210-8a56-a68467530a55
ms.openlocfilehash: 6802ef375d8d15826725e68f5065317192523178
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59095676"
---
# <a name="differences-between-the-windows-forms-datagridview-and-datagrid-controls"></a>Различия элементов управления DataGridView и DataGrid в Windows Forms
<xref:System.Windows.Forms.DataGridView> Элемент управления является элемент управления, который заменяет <xref:System.Windows.Forms.DataGrid> элемента управления. <xref:System.Windows.Forms.DataGridView> Элемент управления предоставляет множество основных и дополнительных компонентов, отсутствующих в <xref:System.Windows.Forms.DataGrid> элемента управления. Кроме того, архитектура <xref:System.Windows.Forms.DataGridView> управления значительно упрощает для расширения и настройки, чем <xref:System.Windows.Forms.DataGrid> элемента управления.  
  
 В следующей таблице описаны некоторые из основных функций, доступных в <xref:System.Windows.Forms.DataGridView> элемент управления, который отсутствует <xref:System.Windows.Forms.DataGrid> элемента управления.  
  
|Функция управления DataGridView|Описание|  
|----------------------------------|-----------------|  
|Несколько типов столбцов|<xref:System.Windows.Forms.DataGridView> Управления предоставляет большее количество встроенных типов столбцов, чем <xref:System.Windows.Forms.DataGrid> элемента управления. Типы столбцов соответствуют потребностям наиболее распространенных сценариев, но могут оказаться проще расширить или заменить чем типов столбцов в <xref:System.Windows.Forms.DataGrid> элемента управления. Дополнительные сведения см. в разделе [типы столбцов элемента управления DataGridView в Windows Forms](column-types-in-the-windows-forms-datagridview-control.md).|  
|Различные способы отображения данных|<xref:System.Windows.Forms.DataGrid> , Элемент управления имеет ограничение в отображении данных из внешнего источника данных. <xref:System.Windows.Forms.DataGridView> Элемент управления, тем не менее, может отображать данные, хранящиеся в элементе управления, данные из привязанного источника данных или данных связанных и несвязанных друг с другом. Вы также можете реализовать виртуальный режим в <xref:System.Windows.Forms.DataGridView> управления для управления данными. Дополнительные сведения см. в разделе [режимы отображения данных в элементе управления DataGridView Windows Forms](data-display-modes-in-the-windows-forms-datagridview-control.md).|  
|Несколько способов настройки отображения данных|<xref:System.Windows.Forms.DataGridView> Элемент управления предоставляет множество свойств и событий, которые позволяют указать, каким образом данные форматирования и отображения. Например можно изменить внешний вид ячеек, строк и столбцов в зависимости от данных, которые они содержат, или вы можете заменить данные одного типа данных другого типа. Дополнительные сведения см. в разделе [форматирования данных в элементе управления DataGridView Windows Forms](data-formatting-in-the-windows-forms-datagridview-control.md).|  
|Различные возможности изменения внешнего вида ячеек, строк, столбцов и заголовка и поведения|<xref:System.Windows.Forms.DataGridView> Управления позволяет работать с отдельными компонентами таблицы различными способами. Например можно закрепить заголовок строки и столбцы, чтобы предотвратить их прокрутку; скрытие строк, столбцов и заголовков; Изменение способа настраиваются размеры строк, столбцов и заголовков; изменить способ пользователям выбирать; и всплывающие подсказки и контекстные меню для отдельных ячеек, строк и столбцов.|  
  
 <xref:System.Windows.Forms.DataGrid> Элемент управления можно сохранить для обратной совместимости и использования в определенных случаях. В целях почти все следует использовать <xref:System.Windows.Forms.DataGridView> элемента управления. Единственная функция, которая доступна в <xref:System.Windows.Forms.DataGrid> элемент управления, который недоступен в <xref:System.Windows.Forms.DataGridView> управления — иерархическое отображение данных из двух связанных таблиц в одном элементе управления. Необходимо использовать два <xref:System.Windows.Forms.DataGridView> элементы управления для отображения данных из двух таблиц, которые находятся в отношение "основной/подробности".  
  
## <a name="upgrading-to-the-datagridview-control"></a>Обновление к элементу управления DataGridView  
 При наличии существующих приложений, использующих <xref:System.Windows.Forms.DataGrid> элемента управления в простом сценарии с привязкой к данным без настройки, можно просто заменить старый элемент управления с помощью нового элемента управления. Оба элемента управления используют стандартную архитектуру привязки данных Windows Forms, поэтому <xref:System.Windows.Forms.DataGridView> элемент управления будет отображать связанные данные без дополнительной настройки. Может потребоваться рассмотреть использование преимуществ усовершенствования привязки данных, тем не менее, путем привязки данных к <xref:System.Windows.Forms.BindingSource> компонент, который затем можно привязать к <xref:System.Windows.Forms.DataGridView> элемента управления. Дополнительные сведения см. в разделе [компонент BindingSource](bindingsource-component.md).  
  
 Так как <xref:System.Windows.Forms.DataGridView> элемент управления имеет совершенно новой архитектуры, нет пути несложный процесс преобразования, которое позволит вам использовать <xref:System.Windows.Forms.DataGrid> изменений при помощи <xref:System.Windows.Forms.DataGridView> элемента управления. Многие <xref:System.Windows.Forms.DataGrid> настройки являются ненужными <xref:System.Windows.Forms.DataGridView> управления, однако из-за встроенных функциях, доступных в новый элемент управления. Если вы создали пользовательские типы столбцов для <xref:System.Windows.Forms.DataGrid> элемент управления, который вы хотите использовать с <xref:System.Windows.Forms.DataGridView> элемента управления, необходимо реализовать снова с помощью новой архитектуры. Дополнительные сведения см. в разделе [Настройка элемента управления DataGridView в Windows Forms](customizing-the-windows-forms-datagridview-control.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGrid>
- <xref:System.Windows.Forms.BindingSource>
- [Элемент управления DataGridView](datagridview-control-windows-forms.md)
- [Элемент управления DataGrid](datagrid-control-windows-forms.md)
- [Компонент BindingSource](bindingsource-component.md)
- [Типы столбцов элемента управления DataGridView в Windows Forms](column-types-in-the-windows-forms-datagridview-control.md)
- [Стили ячеек элемента управления DataGridView в Windows Forms](cell-styles-in-the-windows-forms-datagridview-control.md)
- [Режимы отображения данных в элементе управления DataGridView в Windows Forms](data-display-modes-in-the-windows-forms-datagridview-control.md)
- [Форматирование данных в элементе управления DataGridView в Windows Forms](data-formatting-in-the-windows-forms-datagridview-control.md)
- [Изменение размеров управления DataGridView в Windows Forms](sizing-options-in-the-windows-forms-datagridview-control.md)
- [Установка режимов сортировки для столбцов элемента управления DataGridView в Windows Forms](column-sort-modes-in-the-windows-forms-datagridview-control.md)
- [Режимы выделения содержимого элемента управления DataGridView в Windows Forms](selection-modes-in-the-windows-forms-datagridview-control.md)
- [Настройка элементов управления DataGridView в Windows Forms](customizing-the-windows-forms-datagridview-control.md)

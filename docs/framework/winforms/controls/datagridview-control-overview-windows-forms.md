---
title: Общие сведения об элементе управления DataGridView (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- DataGridView
helpviewer_keywords:
- DataGridView control [Windows Forms], about DataGridView control
- grid controls [Windows Forms]
- tables [Windows Forms], displaying in DataGridView control
- tables [Windows Forms], binding to DataGridView control
- columns [Windows Forms], DataGridView control
- bound controls [Windows Forms], dataGridView control
- datasets [Windows Forms], binding to DataGridView control
- data grids [Windows Forms], about data grids
- data [Windows Forms], resorting
- data [Windows Forms], navigating
- grids [Windows Forms]
- data binding [Windows Forms], DataGridView control
- data sources [Windows Forms], binding to DataGridView control
- DataGridView control [Windows Forms], data binding
ms.assetid: 0a45c661-89dc-4390-9cc6-c47eee501488
ms.openlocfilehash: 095c89fd305b1eeb73e2919760abe48e848c6aa0
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59112883"
---
# <a name="datagridview-control-overview-windows-forms"></a>Общие сведения об элементе управления DataGridView (Windows Forms)
> [!NOTE]
>  Элемент управления <xref:System.Windows.Forms.DataGridView> заменяет элемент управления <xref:System.Windows.Forms.DataGrid> и расширяет его функциональные возможности; однако при необходимости элемент управления <xref:System.Windows.Forms.DataGrid> можно сохранить для обратной совместимости и использования в будущем. Дополнительные сведения см. в разделе [Различия элементов управления DataGridView и DataGrid в Windows Forms](differences-between-the-windows-forms-datagridview-and-datagrid-controls.md).  
  
 С помощью <xref:System.Windows.Forms.DataGridView> элемента управления, можно отображать и редактирования табличных данных с использованием разного рода источников данных.  
  
 Привязка данных к <xref:System.Windows.Forms.DataGridView> управления представляет собой простой и интуитивно понятный и во многих случаях это простой установке <xref:System.Windows.Forms.DataGridView.DataSource%2A> свойство. При привязке к источнику данных, который содержит несколько списков или таблиц, задайте <xref:System.Windows.Forms.DataGridView.DataMember%2A> строковое значение, указывающее список или таблицу для привязки.  
  
 <xref:System.Windows.Forms.DataGridView> Элемент управления поддерживает стандартную Windows Forms модель привязки данных, поэтому он выполняет привязку к экземплярам классов, описанных в следующем списке:  
  
-   Любой класс, реализующий <xref:System.Collections.IList> интерфейса, включая одномерные массивы.  
  
-   Любой класс, реализующий <xref:System.ComponentModel.IListSource> интерфейса, такие как <xref:System.Data.DataTable> и <xref:System.Data.DataSet> классы.  
  
-   Любой класс, реализующий <xref:System.ComponentModel.IBindingList> интерфейса, такие как <xref:System.ComponentModel.BindingList%601> класса.  
  
-   Любой класс, реализующий <xref:System.ComponentModel.IBindingListView> интерфейса, такие как <xref:System.Windows.Forms.BindingSource> класса.  
  
 <xref:System.Windows.Forms.DataGridView> Управления поддерживает привязку данных к открытым свойствам объекта объектов, возвращенных эти интерфейсы или свойства коллекцию, возвращаемую <xref:System.ComponentModel.ICustomTypeDescriptor> интерфейс, если реализован в возвращаемых объектов.  
  
 Как правило, необходимо привязать к <xref:System.Windows.Forms.BindingSource> компонента и bind <xref:System.Windows.Forms.BindingSource> компонент на другой источник данных или ее заполнение бизнес-объектов. <xref:System.Windows.Forms.BindingSource> Компонент является предпочтительным, так как его можно привязать к самых разнообразных источников данных и может автоматически разрешать различные проблемы привязки данных. Дополнительные сведения см. в разделе [компонент BindingSource](bindingsource-component.md).  
  
 <xref:System.Windows.Forms.DataGridView> Управления также может использоваться в *несвязанного* режим без базового хранилища данных. Пример кода, использующего несвязанного <xref:System.Windows.Forms.DataGridView> управления, см. в разделе [Пошаговое руководство: Создание не связанного с данными Windows Forms элемента управления DataGridView](walkthrough-creating-an-unbound-windows-forms-datagridview-control.md).  
  
 <xref:System.Windows.Forms.DataGridView> Управления высокой настраиваемых и расширяемых и предоставляет множество свойств, методов и событий для настройки внешнего вида и поведения. Если требуется, чтобы приложение Windows Forms для отображения табличных данных, рассмотрите возможность использования <xref:System.Windows.Forms.DataGridView> управления перед другими пользователями (например, <xref:System.Windows.Forms.DataGrid>). При отображении небольшой сетки значений только для чтения, или если при выдаче пользователю возможность править таблицу с миллионами записей, <xref:System.Windows.Forms.DataGridView> управления предоставит вам легко программируемый, эффективно использующую память решения.  
  
## <a name="in-this-section"></a>В этом разделе  
 [Технологическая сводка по элементам управления DataGridView](datagridview-control-technology-summary-windows-forms.md)  
 Перечислены <xref:System.Windows.Forms.DataGridView> управления понятия и использование связанных классов.  
  
 [Архитектура элементов управления DataGridView](datagridview-control-architecture-windows-forms.md)  
 Описывает архитектуру <xref:System.Windows.Forms.DataGridView> элемента управления, объясняя, его структура типа иерархия и наследование.  
  
 [Сценарии использования элементов управления DataGridView](datagridview-control-scenarios-windows-forms.md)  
 Описание наиболее распространенных сценариев, в которых <xref:System.Windows.Forms.DataGridView> используются элементы управления.  
  
 [Примеры кода для элемента управления DataGridView](datagridview-control-code-directory-windows-forms.md)  
 Ссылки на примеры кода в документации для различных <xref:System.Windows.Forms.DataGridView> задачи. Примеры распределены на категории по типам задач.  
  
## <a name="related-sections"></a>Связанные разделы  
 [Типы столбцов элемента управления DataGridView в Windows Forms](column-types-in-the-windows-forms-datagridview-control.md)  
 Описание типов столбцов в Windows Forms <xref:System.Windows.Forms.DataGridView> управления, используемый для отображения сведений и разрешить пользователям изменять или добавлять данные.  
  
 [Отображение данных с помощью элемента управления DataGridView в Windows Forms](displaying-data-in-the-windows-forms-datagridview-control.md)  
 Разделы, описывающие заполнение элемента управления данными вручную или из внешнего источника данных.  
  
 [Настройка элементов управления DataGridView в Windows Forms](customizing-the-windows-forms-datagridview-control.md)  
 Разделы, описывающие пользовательскую отрисовку ячеек и строк <xref:System.Windows.Forms.DataGridView>, а также создание производных ячеек, столбцов и типов строк.  
  
 [Оптимизация производительности элемента управления DataGridView в Windows Forms](performance-tuning-in-the-windows-forms-datagridview-control.md)  
 Разделы, описывающие, как эффективно использовать элемент управления, чтобы избежать снижения производительности при работе с большими объемами данных.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.BindingSource>
- [Элемент управления DataGridView](datagridview-control-windows-forms.md)
- [Стандартная функциональность элемента управления DataGridView в Windows Forms](default-functionality-in-the-windows-forms-datagridview-control.md)
- [Выполняемая по умолчанию обработка событий мыши и клавиатуры элементом управления DataGridView в Windows Forms](default-keyboard-and-mouse-handling-in-the-windows-forms-datagridview-control.md)

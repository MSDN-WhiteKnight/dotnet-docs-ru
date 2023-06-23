---
title: Технологическая сводка по элементам управления DataGridView (Windows Forms)
ms.date: 03/30/2017
helpviewer_keywords:
- DataGridView control [Windows Forms], about DataGridView control
- data grids [Windows Forms], about data grids
ms.assetid: 094498c3-a126-4a3f-83fe-f69e96c7717b
ms.openlocfilehash: ca8268137f2a154c782388d0f13cdd02504cbb64
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59217423"
---
# <a name="datagridview-control-technology-summary-windows-forms"></a>Технологическая сводка по элементам управления DataGridView (Windows Forms)
В этом разделе содержится сводная информация о системе управления `DataGridView` и классах, поддерживающих ее использование.  
  
 Отображение данных в табличном формате — это задача, которые чаще всего для выполнения часто. `DataGridView` Элемент управления предназначен для законченное решение для представления данных в виде таблицы.  
  
## <a name="keywords"></a>Ключевые слова  
 DataGridView, BindingSource, таблица, ячейки, привязка данных и виртуальный режим  
  
## <a name="namespaces"></a>Пространства имен  
 <xref:System.Windows.Forms?displayProperty=nameWithType>  
  
 <xref:System.Data?displayProperty=nameWithType>  
  
## <a name="related-technologies"></a>Связанные технологии  
 `BindingSource`  
  
## <a name="background"></a>Фон  
 Конструкторы пользовательского интерфейса (UI) часто найти необходимые для отображения табличных данных пользователям. .NET Framework Предоставляет несколько способов отображения данных в виде таблицы или сетки. `DataGridView` Управления представляет собой новейшее развитие этой технологии для приложений Windows Forms.  
  
 `DataGridView` Элемент управления может отображать строки данных из хранилища данных. Поддерживаются различные типы хранилищ данных. Хранилище данных может содержать простые, нетипизированные данные, такие как одномерный массив, или он может содержать типизированных данных, таких как <xref:System.Data.DataSet>. Дополнительные сведения см. в разделе [Как Привязка данных к Windows Forms элемента управления DataGridView](how-to-bind-data-to-the-windows-forms-datagridview-control.md).  
  
 Элемент управления `DataGridView` предоставляет мощный и гибкий способ отображения данных в табличном формате. Элемент управления можно использовать для отображения представлений небольшого и очень больших наборов данных только для чтения или редактирования.  
  
 Вы можете расширить `DataGridView` управления несколькими способами, чтобы реализовать пользовательское поведение в приложениях. Например, можно программно задать собственные алгоритмы сортировки, можно создать собственные типы ячеек. Внешний вид элемента управления `DataGridView` легко настраивается заданием значений нескольких свойств. Различные типы хранилищ данных может использоваться в качестве источника данных, или `DataGridView` элемент управления может работать без привязанного к нему источника данных.  
  
## <a name="implementing-datagridview-classes"></a>Реализация классов DataGridView  
 Существует несколько способов, позволяющих воспользоваться преимуществами `DataGridView` функций расширения элемента управления. Можно настроить многие аспекты элемента управления с помощью событий и свойств, но некоторые настройки требуется создание новых классов, производных от существующих `DataGridView` классы.  
  
 Наиболее часто используемые базовые классы являются `DataGridViewCell` и `DataGridViewColumn`. Можно создать собственный класс ячейки с производный `DataGridViewCell` или любого из его дочерних классов. Несмотря на то, что любой тип ячейки можно добавить на любой столбец, будут обычно также дополнительное столбец класс наследуется из `DataGridViewColumn` , на котором размещается ячейки пользовательского типа по умолчанию.  
  
 Вы можете реализовать `IDataGridViewEditingCell` интерфейс в производная ячейка класс и создать тип ячейки, которые функции редактирования, но не размещен элемент управления в режиме редактирования. Чтобы создать элемент управления, который можно разместить в ячейке в режиме редактирования, можно реализовать `IDataGridViewEditingControl` интерфейса в классе, производных от <xref:System.Windows.Forms.Control>.  
  
 Дополнительные сведения см. в разделе [Как Ячеек и столбцов в Windows Forms элемента управления DataGridView с видом и поведением](customize-cells-and-columns-in-the-datagrid-by-extending-behavior.md) и [как: Ведущие элементы управления в формах Windows Forms ячеек элемента управления DataGridView](how-to-host-controls-in-windows-forms-datagridview-cells.md).  
  
## <a name="datagridview-classes-at-a-glance"></a>Классы DataGridView с первого взгляда  
 <xref:System.Windows.Forms>  
  
|Область технологий|Классы, интерфейсы, элементы конфигурации|  
|---------------------|-------------------------------------------------|  
|Привязка данных|<xref:System.Windows.Forms.BindingSource>|  
|Представление данных|<xref:System.Windows.Forms.DataGridView><br /><br /> <xref:System.Windows.Forms.DataGridViewCell> и производные классы<br /><br /> <xref:System.Windows.Forms.DataGridViewRow> и производные классы<br /><br /> <xref:System.Windows.Forms.DataGridViewColumn> и производные классы<br /><br /> <xref:System.Windows.Forms.DataGridViewCellStyle>|  
|<xref:System.Windows.Forms.DataGridView> Расширение среды|<xref:System.Windows.Forms.DataGridViewCell> и производные классы<br /><br /> <xref:System.Windows.Forms.DataGridViewColumn> и производные классы<br /><br /> <xref:System.Windows.Forms.IDataGridViewEditingCell><br /><br /> <xref:System.Windows.Forms.IDataGridViewEditingControl>|  
  
## <a name="whats-new"></a>Новые возможности  
 <xref:System.Windows.Forms.DataGridView> Элемент управления предназначен для законченное решение для отображения табличных данных с помощью Windows Forms. Следует рассмотреть возможность использования <xref:System.Windows.Forms.DataGridView> управлять перед другими решениями, такими как <xref:System.Windows.Forms.DataGrid>, при создании нового приложения. Дополнительные сведения см. в разделе [Различия элементов управления DataGridView и DataGrid в Windows Forms](differences-between-the-windows-forms-datagridview-and-datagrid-controls.md).  
  
 <xref:System.Windows.Forms.DataGridView> Управления может работать в сочетании с <xref:System.Windows.Forms.BindingSource> компонента. Данный компонент разработан в качестве источника данных формы. Его можно управлять взаимодействием между <xref:System.Windows.Forms.DataGridView> управления и ее источник данных, независимо от того, данные типа источника.  
  
## <a name="see-also"></a>См. также

- [Общие сведения об элементе управления DataGridView](datagridview-control-overview-windows-forms.md)
- [Архитектура элементов управления DataGridView](datagridview-control-architecture-windows-forms.md)
- [Защита сведений о подключении](../../data/adonet/protecting-connection-information.md)

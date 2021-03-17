---
title: Источники данных, поддерживаемые Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- collections [Windows Forms], binding to
- OLE DB providers [Windows Forms], Windows Forms
- DataTable class [Windows Forms], binding and Windows Forms
- Windows Forms, data binding
- DataView class [Windows Forms], binding and Windows Forms
- DataViewManager class [Windows Forms], binding and Windows Forms
- Windows Forms, source data
- arrays [Windows Forms]
- data sources [Windows Forms]
- data providers [Windows Forms]
- DataSet class [Windows Forms], binding and Windows Forms
- data [Windows Forms], data providers
ms.assetid: 3d2c43f6-462b-4d35-9c86-13e9afe012e1
ms.openlocfilehash: b648d62c9128f0864d60ace1ca56700f594b78c5
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59124622"
---
# <a name="data-sources-supported-by-windows-forms"></a>Источники данных, поддерживаемые Windows Forms
В большинстве случаев привязки данных используется в приложениях для использования данных, хранящихся в базах данных. Привязки данных Windows Forms, предоставляет доступ к данным из баз данных, а также данные в других структурах, таких как массивы и коллекции, до тех пор, пока определенные минимальные требования будут соблюдены.  
  
## <a name="structures-to-bind-to"></a>Структуры для привязки  
 В Windows Forms, можно привязать к самые разнообразные структур, от простых объектов (простая привязка) до сложных списков, таких как таблицы данных ADO.NET (сложная привязка). Для простой привязки Windows Forms поддерживает привязку к общим свойствам простого объекта. Привязки на основе списка Windows Forms обычно требуется, чтобы объект поддерживал <xref:System.Collections.IList> интерфейс или <xref:System.ComponentModel.IListSource> интерфейс. Кроме того при связывании с помощью <xref:System.Windows.Forms.BindingSource> компонента, можно привязать к объекту, который поддерживает <xref:System.Collections.IEnumerable> интерфейс. Дополнительные сведения об интерфейсах, связанных с привязкой данных, см. в разделе [интерфейсах, которые относятся к привязке данных](interfaces-related-to-data-binding.md).  
  
 Ниже перечислены структуры можно привязать к в Windows Forms.  
  
 <xref:System.Windows.Forms.BindingSource>  
 Объект <xref:System.Windows.Forms.BindingSource> является наиболее распространенным источником данных Windows Forms и выступает посредником между источником данных и элементы управления Windows Forms. Общие <xref:System.Windows.Forms.BindingSource> шаблон использования: привязать элементы управления <xref:System.Windows.Forms.BindingSource> и привязать <xref:System.Windows.Forms.BindingSource> к источнику данных (например, таблицу данных ADO.NET или бизнес-объекта). <xref:System.Windows.Forms.BindingSource> Предоставляет службы и позволяет повысить уровень поддержки привязки данных. Например, Windows Forms на основе списков элементов управления например <xref:System.Windows.Forms.DataGridView> и <xref:System.Windows.Forms.ComboBox> непосредственно не поддерживает привязку к <xref:System.Collections.IEnumerable> источников данных тем не менее, вы можете включить этот сценарий путем привязки через <xref:System.Windows.Forms.BindingSource>. В этом случае <xref:System.Windows.Forms.BindingSource> преобразует источник данных для <xref:System.Collections.IList>.  
  
 Простые объекты  
 Windows Forms поддерживает свойства элемента управления привязки данных к общим свойствам экземпляра объекта с помощью <xref:System.Windows.Forms.Binding> типа. Windows Forms также поддерживает привязка элементов управления на основе списка, таких как <xref:System.Windows.Forms.ListControl> экземпляре, когда к объекту <xref:System.Windows.Forms.BindingSource> используется.  
  
 массива или коллекции  
 В качестве источника данных, список должен реализовывать <xref:System.Collections.IList> интерфейс; один примера можно привести массив, который является экземпляром класса <xref:System.Array> класса. Дополнительные сведения о массивах см. в разделе [как: Создайте массив объектов (Visual Basic)](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/487y7874(v=vs.100)).  
  
 В общем случае следует использовать <xref:System.ComponentModel.BindingList%601> при создании списков объектов для привязки данных. <xref:System.ComponentModel.BindingList%601> — Это универсальная версия <xref:System.ComponentModel.IBindingList> интерфейс. <xref:System.ComponentModel.IBindingList> Интерфейс расширяет <xref:System.Collections.IList> интерфейса путем добавления свойства, методы и события, необходимые для двусторонней привязки данных.  
  
 <xref:System.Collections.IEnumerable>  
 Элементы управления Windows Forms можно привязать к источникам данных, которые поддерживают только <xref:System.Collections.IEnumerable> интерфейс, если они связаны через <xref:System.Windows.Forms.BindingSource> компонента.  
  
 [!INCLUDE[vstecado](../../../includes/vstecado-md.md)] объекты данных  
 [!INCLUDE[vstecado](../../../includes/vstecado-md.md)] предоставляет несколько структур данных, к которым можно выполнить привязку. Предлагает разные его сложности и сложность.  
  
-   <xref:System.Data.DataColumn>. Объект <xref:System.Data.DataColumn> является основным стандартным блоком из <xref:System.Data.DataTable>, в том, что количество столбцов образуют таблицу. Каждый <xref:System.Data.DataColumn> имеет <xref:System.Data.DataColumn.DataType%2A> свойство, которое определяет, какие данные содержит столбец (например, производителей автомобилей в таблице с описанием автомобилей). Можно выполнить простую привязку элемента управления (такие как <xref:System.Windows.Forms.TextBox> элемента управления <xref:System.Windows.Forms.Control.Text%2A> свойство) к столбцу в таблице данных.  
  
-   <xref:System.Data.DataTable>. Объект <xref:System.Data.DataTable> — это представление таблицы, состоящей из строк и столбцов, в [!INCLUDE[vstecado](../../../includes/vstecado-md.md)]. Таблица данных содержит две коллекции: <xref:System.Data.DataColumn>, представляющую столбцы данных в данной таблице (столбцы однозначно определяют типы данных, которые можно ввести в таблицу), и <xref:System.Data.DataRow>, представляющий строки данных в конкретной таблице. Вы можете сложную привязку элемента управления к сведениям, содержащимся в таблице данных (например, привязка <xref:System.Windows.Forms.DataGridView> элемента управления к таблице данных). Тем не менее, при выполнении привязки <xref:System.Data.DataTable>, действительно выполняется привязка к представлению таблицы по умолчанию.  
  
-   <xref:System.Data.DataView>. Объект <xref:System.Data.DataView> имеет настроенное представление в одну таблицу данных, можно отфильтровать или упорядочить. Представление данных — «моментальный снимок», используемый элементами управления сложной привязкой данных. Вы можете простую привязку или сложную привязку к данным в представлении данных, но имейте в виду, что привязка осуществляется на фиксированный «рисунок» данные, а не по источнику чистую и обновления данных.  
  
-   <xref:System.Data.DataSet>. Объект <xref:System.Data.DataSet> — это коллекция таблиц, связей и ограничений данных в базе данных. Вы можете простую привязку или сложную привязку к данным в наборе данных, но имейте в виду, что привязка осуществляется по умолчанию <xref:System.Data.DataViewManager> для <xref:System.Data.DataSet> (см. следующий пункт).  
  
-   <xref:System.Data.DataViewManager>. Объект <xref:System.Data.DataViewManager> — это настраиваемое представление для всего <xref:System.Data.DataSet>, аналогично <xref:System.Data.DataView>, но с отношениями, которые включены. С помощью <xref:System.Data.DataViewManager.DataViewSettings%2A> коллекции, можно задать фильтры по умолчанию и параметры сортировки для всех представлений, <xref:System.Data.DataViewManager> имеет для данной таблицы.  
  
## <a name="see-also"></a>См. также

- [Получение уведомления об изменении данных, связанных с элементом управления, в Windows Forms](change-notification-in-windows-forms-data-binding.md)
- [Связывание данных и Windows Forms](data-binding-and-windows-forms.md)
- [Привязка данных Windows Forms](windows-forms-data-binding.md)

---
description: 'Дополнительные сведения: Добавление связей DataRelation'
title: Добавление отношений DataRelation
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: a4a564fb-c1c4-4135-b6c2-b030e51195e4
ms.openlocfilehash: 56438c9b69fab71c4843582b6cfea50fa057eb44
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99725224"
---
# <a name="adding-datarelations"></a>Добавление отношений DataRelation

В наборе <xref:System.Data.DataSet> с несколькими объектами <xref:System.Data.DataTable> можно использовать объекты <xref:System.Data.DataRelation> для связи таблиц друг с другом, для перехода по таблицам, а также для возвращения дочерних или родительских строк из связанной таблицы.  
  
 Аргументы, необходимые для создания **DataRelation** , — это имя создаваемого объекта **DataRelation** , а также массив из одной или нескольких <xref:System.Data.DataColumn> ссылок на столбцы, которые служат в качестве родительских и дочерних столбцов связи. После создания объекта **DataRelation** его можно использовать для перехода между таблицами и получения значений.  
  
 Добавление **DataRelation** в <xref:System.Data.DataSet> добавляет по умолчанию объект <xref:System.Data.UniqueConstraint> в родительскую таблицу и в <xref:System.Data.ForeignKeyConstraint> дочернюю таблицу. Дополнительные сведения об этих ограничениях по умолчанию см. в разделе [ограничения DataTable](datatable-constraints.md).  
  
 В следующем примере кода создается **отношение DataRelation** с использованием двух <xref:System.Data.DataTable> объектов в <xref:System.Data.DataSet> . Каждый <xref:System.Data.DataTable> содержит столбец с именем **CustID**, который служит связью между двумя <xref:System.Data.DataTable> объектами. В примере добавляется единичное **отношение DataRelation** к коллекции **отношений** объекта <xref:System.Data.DataSet> . Первый аргумент в примере указывает имя создаваемого объекта **DataRelation** . Второй аргумент задает родительский **столбец** данных, а третий аргумент задает дочерний **столбец** данных.  
  
```vb  
customerOrders.Relations.Add("CustOrders", _  
  customerOrders.Tables("Customers").Columns("CustID"), _  
  customerOrders.Tables("Orders").Columns("CustID"))  
```  
  
```csharp  
customerOrders.Relations.Add("CustOrders",  
  customerOrders.Tables["Customers"].Columns["CustID"],  
  customerOrders.Tables["Orders"].Columns["CustID"]);  
```  
  
 Объект **DataRelation** также имеет **вложенное** свойство, которое, если оно имеет значение **true**, приводит к тому, что строки из дочерней таблицы будут вложены в связанную строку из родительской таблицы при записи в виде XML-элементов с помощью <xref:System.Data.DataSet.WriteXml%2A> . Дополнительные сведения см. в статье [Использование XML в наборах данных](using-xml-in-a-dataset.md).  
  
## <a name="see-also"></a>См. также

- [Наборы данных, таблицы данных и объекты DataView](index.md)
- [Общие сведения об ADO.NET](../ado-net-overview.md)

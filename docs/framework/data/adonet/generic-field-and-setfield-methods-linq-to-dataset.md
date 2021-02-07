---
description: 'Дополнительные сведения: универсальные методы полей и SetField (LINQ to DataSet)'
title: Универсальные методы Field и SetField (LINQ to DataSet)
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: 1883365f-9d6c-4ccb-9187-df309f47706d
ms.openlocfilehash: 2dfbb7377d782525170d47f59a5577f96caadbb6
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99724015"
---
# <a name="generic-field-and-setfield-methods-linq-to-dataset"></a>Универсальные методы Field и SetField (LINQ to DataSet)

LINQ to DataSet предоставляет методы расширения <xref:System.Data.DataRow> классу для доступа к значениям столбцов: <xref:System.Data.DataRowExtensions.Field%2A> метод и <xref:System.Data.DataRowExtensions.SetField%2A> метод. Эти методы обеспечивают разработчикам более простой доступ к значениям столбцов, особенно это касается значений NULL. <xref:System.Data.DataSet>Использует <xref:System.DBNull.Value?displayProperty=nameWithType> для представления значений NULL, тогда как LINQ использует <xref:System.Nullable> <xref:System.Nullable%601> типы и. При использовании существующего метода доступа к столбцу в необходимо <xref:System.Data.DataRow> привести возвращаемый объект к соответствующему типу. Если конкретное поле в <xref:System.Data.DataRow> может иметь значение null, необходимо явно проверить значение null, так как при возврате <xref:System.DBNull.Value?displayProperty=nameWithType> и неявном приведении его к другому типу возникает исключение <xref:System.InvalidCastException> . В следующем примере, если <xref:System.Data.DataRow.IsNull%2A?displayProperty=nameWithType> метод не использовался для проверки наличия значения NULL, при возвращении индексатора <xref:System.DBNull.Value?displayProperty=nameWithType> и попытке привести его к типу возникнет исключение <xref:System.String> .  
  
 [!code-csharp[DP LINQ to DataSet Examples#WhereIsNull](../../../../samples/snippets/csharp/VS_Snippets_ADO.NET/DP LINQ to DataSet Examples/CS/Program.cs#whereisnull)]
 [!code-vb[DP LINQ to DataSet Examples#WhereIsNull](../../../../samples/snippets/visualbasic/VS_Snippets_ADO.NET/DP LINQ to DataSet Examples/VB/Module1.vb#whereisnull)]  
  
 Метод <xref:System.Data.DataRowExtensions.Field%2A> предоставляет доступ к значениям столбцов в <xref:System.Data.DataRow>, а метод <xref:System.Data.DataRowExtensions.SetField%2A> устанавливает значения столбцов в <xref:System.Data.DataRow>. <xref:System.Data.DataRowExtensions.Field%2A>Метод и <xref:System.Data.DataRowExtensions.SetField%2A> метод обработают типы значений, допускающие значение null, поэтому нет необходимости явно проверять значения NULL, как в предыдущем примере. Оба метода являются универсальными, поэтому приводить возвращенное значение к определенному типу не нужно.  
  
 В следующем примере используется метод <xref:System.Data.DataRowExtensions.Field%2A>.  
  
 [!code-csharp[DP LINQ to DataSet Examples#Where3](../../../../samples/snippets/csharp/VS_Snippets_ADO.NET/DP LINQ to DataSet Examples/CS/Program.cs#where3)]
 [!code-vb[DP LINQ to DataSet Examples#Where3](../../../../samples/snippets/visualbasic/VS_Snippets_ADO.NET/DP LINQ to DataSet Examples/VB/Module1.vb#where3)]  
  
 Обратите внимание, что тип данных, определяемый в универсальном параметре `T` метода <xref:System.Data.DataRowExtensions.Field%2A> и метода <xref:System.Data.DataRowExtensions.SetField%2A>, должен совпадать с типом базового значения. В противном случае возникнет исключение <xref:System.InvalidCastException>. Указанное имя столбца также должно совпадать с именем столбца в <xref:System.Data.DataSet>, в противном случае возникнет исключение <xref:System.ArgumentException>. В обоих случаях исключения возникают во время выполнения при перечислении данных в ходе выполнения запроса.  
  
 Метод <xref:System.Data.DataRowExtensions.SetField%2A> сам по себе не выполняет преобразования типов. Однако это не означает, что преобразование типов не происходит. <xref:System.Data.DataRowExtensions.SetField%2A>Метод предоставляет ADO.NET поведение <xref:System.Data.DataRow> класса. Преобразование типа может быть выполнено <xref:System.Data.DataRow> объектом, а преобразованное значение будет сохранено в <xref:System.Data.DataRow> объект.  
  
## <a name="see-also"></a>См. также

- <xref:System.Data.DataRowExtensions>

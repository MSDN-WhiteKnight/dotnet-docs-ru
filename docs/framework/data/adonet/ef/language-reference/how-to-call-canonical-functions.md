---
description: Дополнительные сведения см. в статье как вызывать канонические функции.
title: Практическое руководство. Вызов канонических функций
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: b3d84873-7403-4957-8e20-b4ae39f50214
ms.openlocfilehash: d1e2310bccd6cc60177dba9a2e4c3a104702ba0c
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99696845"
---
# <a name="how-to-call-canonical-functions"></a>Практическое руководство. Вызов канонических функций

Класс <xref:System.Data.Objects.EntityFunctions> содержит методы, предоставляющие доступ к каноническим функциям для использования в запросах LINQ to Entities. Сведения о канонических функциях см. в разделе [Канонические функции](canonical-functions.md).  
  
> [!NOTE]
> Методы <xref:System.Data.Objects.EntityFunctions.AsUnicode%2A> и <xref:System.Data.Objects.EntityFunctions.AsNonUnicode%2A> в классе <xref:System.Data.Objects.EntityFunctions> не имеют эквивалентных канонических функций.  
  
 Канонические функции, которые производят вычисление по ряду значений и возвращают одиночное значение (известные также как статистические канонические функции), могут вызываться напрямую. Другие канонические функции могут вызываться только в составе запроса LINQ to Entities. Чтобы вызвать агрегатную функцию напрямую, ей необходимо передать экземпляр <xref:System.Data.Objects.ObjectQuery%601>. Дополнительные сведения см. в приведенном ниже втором примере.  
  
 Некоторые канонические функции можно вызвать с помощью методов среды CLR в запросах LINQ to Entities. Список методов CLR, соответствующих каноническим функциям, см. [в разделе Сопоставление методов CLR с каноническими](clr-method-to-canonical-function-mapping.md)функциями.  
  
## <a name="example"></a>Пример  

 В следующем примере используется [модель AdventureWorks Sales](https://github.com/Microsoft/sql-server-samples/releases/tag/adventureworks). В этом примере выполняется запрос LINQ to Entities, в котором используется метод <xref:System.Data.Objects.EntityFunctions.DiffDays%2A> для возврата всех продуктов, для которых разница между датами `SellEndDate` и `SellStartDate` меньше 365 суток:  
  
 [!code-csharp[DP L2E CanonicalAndStoreFunctions#1](../../../../../../samples/snippets/csharp/VS_Snippets_Data/dp l2e canonicalandstorefunctions/cs/program.cs#1)]
 [!code-vb[DP L2E CanonicalAndStoreFunctions#1](../../../../../../samples/snippets/visualbasic/VS_Snippets_Data/dp l2e canonicalandstorefunctions/vb/module1.vb#1)]  
  
## <a name="example"></a>Пример  

 В следующем примере используется [модель AdventureWorks Sales](https://github.com/Microsoft/sql-server-samples/releases/tag/adventureworks). В этом примере напрямую вызывается статистическая функция <xref:System.Data.Objects.EntityFunctions.StandardDeviation%2A> для возврата стандартного отклонения промежуточных итогов `SalesOrderHeader`. Обратите внимание, что в функцию передается экземпляр <xref:System.Data.Objects.ObjectQuery%601>, что позволяет вызывать ее, хотя она и не входит в состав запроса LINQ to Entities.  
  
 [!code-csharp[DP L2E CanonicalAndStoreFunctions#2](../../../../../../samples/snippets/csharp/VS_Snippets_Data/dp l2e canonicalandstorefunctions/cs/program.cs#2)]
 [!code-vb[DP L2E CanonicalAndStoreFunctions#2](../../../../../../samples/snippets/visualbasic/VS_Snippets_Data/dp l2e canonicalandstorefunctions/vb/module1.vb#2)]  
  
## <a name="see-also"></a>См. также

- [Вызов функций в запросах LINQ to Entities](calling-functions-in-linq-to-entities-queries.md)
- [Запросы в LINQ to Entities](queries-in-linq-to-entities.md)

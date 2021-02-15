---
description: Дополнительные сведения см. в статье синтаксис выражений запросов для стандартных операторов запросов (Visual Basic)
title: Синтаксис выражений запроса для стандартных операторов запроса
ms.date: 07/20/2015
ms.assetid: eb978d86-d3b5-497b-95ce-a054bea8f510
ms.openlocfilehash: c891482506f45278d9ecbe037a516b3de3fe97b7
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100477493"
---
# <a name="query-expression-syntax-for-standard-query-operators-visual-basic"></a>Синтаксис выражений запросов для стандартных операторов запросов (Visual Basic)

Некоторые из наиболее часто используемых стандартных операторов запросов имеют выделенный синтаксис ключевого слова Visual Basic языка, который позволяет вызывать их как часть *выражения запроса*. Выражение запроса является более удобочитаемой формой задания запроса, чем его *основанный на методах* эквивалент. Предложения выражений запросов преобразуются в вызовы методов запросов во время компиляции.  
  
## <a name="query-expression-syntax-table"></a>Таблица синтаксиса выражений запросов  

 В следующей таблице приводится список стандартных операторов запросов, имеющих эквивалентные предложения выражений запросов.  
  
|Метод|Синтаксис выражения запроса Visual Basic|  
|------------|------------------------------------------|  
|<xref:System.Linq.Enumerable.All%2A>|`Aggregate … In … Into All(…)`<br /><br /> (Дополнительные сведения см. в разделе [предложение Aggregate](../../../language-reference/queries/aggregate-clause.md).)|  
|<xref:System.Linq.Enumerable.Any%2A>|`Aggregate … In … Into Any()`<br /><br /> (Дополнительные сведения см. в разделе [предложение Aggregate](../../../language-reference/queries/aggregate-clause.md).)|  
|<xref:System.Linq.Enumerable.Average%2A>|`Aggregate … In … Into Average()`<br /><br /> (Дополнительные сведения см. в разделе [предложение Aggregate](../../../language-reference/queries/aggregate-clause.md).)|  
|<xref:System.Linq.Enumerable.Cast%2A>|`From … As …`<br /><br /> (Дополнительные сведения см. [в разделе предложение from](../../../language-reference/queries/from-clause.md).)|  
|<xref:System.Linq.Enumerable.Count%2A>|`Aggregate … In … Into Count()`<br /><br /> (Дополнительные сведения см. в разделе [предложение Aggregate](../../../language-reference/queries/aggregate-clause.md).)|  
|<xref:System.Linq.Enumerable.Distinct%60%601%28System.Collections.Generic.IEnumerable%7B%60%600%7D%29>|`Distinct`<br /><br /> (Дополнительные сведения см. в разделе [предложение DISTINCT](../../../language-reference/queries/distinct-clause.md).)|  
|<xref:System.Linq.Enumerable.GroupBy%2A>|`Group … By … Into …`<br /><br /> (Дополнительные сведения см. в разделе [предложение GROUP BY](../../../language-reference/queries/group-by-clause.md).)|  
|<xref:System.Linq.Enumerable.GroupJoin%60%604%28System.Collections.Generic.IEnumerable%7B%60%600%7D%2CSystem.Collections.Generic.IEnumerable%7B%60%601%7D%2CSystem.Func%7B%60%600%2C%60%602%7D%2CSystem.Func%7B%60%601%2C%60%602%7D%2CSystem.Func%7B%60%600%2CSystem.Collections.Generic.IEnumerable%7B%60%601%7D%2C%60%603%7D%29>|`Group Join … In … On …`<br /><br /> (Дополнительные сведения см. в разделе [предложение Group Join](../../../language-reference/queries/group-join-clause.md).)|  
|<xref:System.Linq.Enumerable.Join%60%604%28System.Collections.Generic.IEnumerable%7B%60%600%7D%2CSystem.Collections.Generic.IEnumerable%7B%60%601%7D%2CSystem.Func%7B%60%600%2C%60%602%7D%2CSystem.Func%7B%60%601%2C%60%602%7D%2CSystem.Func%7B%60%600%2C%60%601%2C%60%603%7D%29>|`From x In …, y In … Where x.a = b.a`<br /><br /> -или-<br /><br /> `Join … [As …]In … On …`<br /><br /> (Дополнительные сведения см. в разделе [предложение Join](../../../language-reference/queries/join-clause.md).)|  
|<xref:System.Linq.Enumerable.LongCount%2A>|`Aggregate … In … Into LongCount()`<br /><br /> (Дополнительные сведения см. в разделе [предложение Aggregate](../../../language-reference/queries/aggregate-clause.md).)|  
|<xref:System.Linq.Enumerable.Max%2A>|`Aggregate … In … Into Max()`<br /><br /> (Дополнительные сведения см. в разделе [предложение Aggregate](../../../language-reference/queries/aggregate-clause.md).)|  
|<xref:System.Linq.Enumerable.Min%2A>|`Aggregate … In … Into Min()`<br /><br /> (Дополнительные сведения см. в разделе [предложение Aggregate](../../../language-reference/queries/aggregate-clause.md).)|  
|<xref:System.Linq.Enumerable.OrderBy%60%602%28System.Collections.Generic.IEnumerable%7B%60%600%7D%2CSystem.Func%7B%60%600%2C%60%601%7D%29>|`Order By`<br /><br /> (Дополнительные сведения см. в разделе [предложение ORDER BY](../../../language-reference/queries/order-by-clause.md).)|  
|<xref:System.Linq.Enumerable.OrderByDescending%60%602%28System.Collections.Generic.IEnumerable%7B%60%600%7D%2CSystem.Func%7B%60%600%2C%60%601%7D%29>|`Order By … Descending`<br /><br /> (Дополнительные сведения см. в разделе [предложение ORDER BY](../../../language-reference/queries/order-by-clause.md).)|  
|<xref:System.Linq.Enumerable.Select%2A>|`Select`<br /><br /> (Дополнительные сведения см. в разделе [предложение SELECT](../../../language-reference/queries/select-clause.md).)|  
|<xref:System.Linq.Enumerable.SelectMany%2A>|Несколько `From` предложений<br /><br /> (Дополнительные сведения см. [в разделе предложение from](../../../language-reference/queries/from-clause.md).)|  
|<xref:System.Linq.Enumerable.Skip%2A>|`Skip`<br /><br /> (Дополнительные сведения см. в разделе [предложение Skip](../../../language-reference/queries/skip-clause.md).)|  
|<xref:System.Linq.Enumerable.SkipWhile%2A>|`Skip While`<br /><br /> (Дополнительные сведения см. в разделе [предложение Skip While](../../../language-reference/queries/skip-while-clause.md).)|  
|<xref:System.Linq.Enumerable.Sum%2A>|`Aggregate … In … Into Sum()`<br /><br /> (Дополнительные сведения см. в разделе [предложение Aggregate](../../../language-reference/queries/aggregate-clause.md).)|  
|<xref:System.Linq.Enumerable.Take%2A>|`Take`<br /><br /> (Дополнительные сведения см. в разделе [предложение Take](../../../language-reference/queries/take-clause.md).)|  
|<xref:System.Linq.Enumerable.TakeWhile%2A>|`Take While`<br /><br /> (Дополнительные сведения см. в описании [предложения Take While](../../../language-reference/queries/take-while-clause.md).)|  
|<xref:System.Linq.Enumerable.ThenBy%60%602%28System.Linq.IOrderedEnumerable%7B%60%600%7D%2CSystem.Func%7B%60%600%2C%60%601%7D%29>|`Order By …, …`<br /><br /> (Дополнительные сведения см. в разделе [предложение ORDER BY](../../../language-reference/queries/order-by-clause.md).)|  
|<xref:System.Linq.Enumerable.ThenByDescending%60%602%28System.Linq.IOrderedEnumerable%7B%60%600%7D%2CSystem.Func%7B%60%600%2C%60%601%7D%29>|`Order By …, … Descending`<br /><br /> (Дополнительные сведения см. в разделе [предложение ORDER BY](../../../language-reference/queries/order-by-clause.md).)|  
|<xref:System.Linq.Enumerable.Where%2A>|`Where`<br /><br /> (Дополнительные сведения см. в разделе [предложение WHERE](../../../language-reference/queries/where-clause.md).)|  
  
## <a name="see-also"></a>См. также раздел

- <xref:System.Linq.Enumerable>
- <xref:System.Linq.Queryable>
- [Общие сведения о стандартных операторах запроса (Visual Basic)](standard-query-operators-overview.md)
- [Классификация стандартных операторов запросов по способу выполнения (Visual Basic)](classification-of-standard-query-operators-by-manner-of-execution.md)

---
description: 'Дополнительные сведения: задание операций (Visual Basic)'
title: Операции над множествами
ms.date: 07/20/2015
ms.assetid: 2b06e822-e030-438f-9db7-ee402bd3a706
ms.openlocfilehash: 9c75c9e029ba260917f59c7d2ea0341c157bf406
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100471673"
---
# <a name="set-operations-visual-basic"></a>Операции с наборами (Visual Basic)

Операции над множествами в LINQ — это операции запросов, результирующие наборы которых основываются на наличии или отсутствии эквивалентных элементов в одной или другой коллекции (или наборе).

Методы стандартных операторов запросов, которые выполняют операции над множествами, перечислены в следующем разделе.

## <a name="methods"></a>Методы

|Имя метода|Описание|Синтаксис выражения запроса Visual Basic|Дополнительные сведения|
|-----------------|-----------------|------------------------------------------|----------------------|
|Distinct|Удаляет повторяющиеся значения из коллекции.|`Distinct`|<xref:System.Linq.Enumerable.Distinct%2A?displayProperty=nameWithType><br /><br /> <xref:System.Linq.Queryable.Distinct%2A?displayProperty=nameWithType>|
|Исключения|Возвращает разность множеств, т. е. элементы одной коллекции, которые отсутствуют во второй.|Не применяется|<xref:System.Linq.Enumerable.Except%2A?displayProperty=nameWithType><br /><br /> <xref:System.Linq.Queryable.Except%2A?displayProperty=nameWithType>|
|Пересечение|Возвращает пересечение множеств, т. е. элементы, присутствующие в каждой из двух коллекций.|Не применяется|<xref:System.Linq.Enumerable.Intersect%2A?displayProperty=nameWithType><br /><br /> <xref:System.Linq.Queryable.Intersect%2A?displayProperty=nameWithType>|
|Объединение|Возвращает объединение множеств, т. е. уникальные элементы, присутствующие в одной из двух коллекций.|Не применяется|<xref:System.Linq.Enumerable.Union%2A?displayProperty=nameWithType><br /><br /> <xref:System.Linq.Queryable.Union%2A?displayProperty=nameWithType>|

## <a name="comparison-of-set-operations"></a>Сравнение операций над множествами

### <a name="distinct"></a>Distinct

На следующем рисунке показано поведение метода <xref:System.Linq.Enumerable.Distinct%2A?displayProperty=nameWithType> применительно к последовательности символов. Возвращаемая последовательность содержит уникальные элементы из входной последовательности.

![График, демонстрирующий поведение Distinct&#40;&#41;.](./media/set-operations/distinct-method-behavior.png)

### <a name="except"></a>Исключения

На следующем рисунке показано поведение <xref:System.Linq.Enumerable.Except%2A?displayProperty=nameWithType>. Возвращаемая последовательность содержит только те элементы из первой входной последовательности, которых нет во второй.

![График, отображающий действие Except&#40;&#41;.](./media/set-operations/except-behavior-graphic.png "Демонстрирует поведение Except.")

### <a name="intersect"></a>Пересечение

На следующем рисунке показано поведение <xref:System.Linq.Enumerable.Intersect%2A?displayProperty=nameWithType>. Возвращаемая последовательность содержит элементы, общие для обеих входных последовательностей.

![График, отображающий пересечение двух последовательностей.](./media/set-operations/intersection-two-sequences.png)

### <a name="union"></a>Объединение

На следующем рисунке показана операция объединения двух последовательностей символов. Возвращаемая последовательность содержит уникальные элементы из обеих входных последовательностей.

![График, показывающий объединение двух последовательностей.](./media/set-operations/union-operation-two-sequences.png)

## <a name="query-expression-syntax-example"></a>Пример синтаксиса выражения запроса

В следующем примере `Distinct` предложение в запросе LINQ используется для возврата уникальных чисел из списка целых чисел.

[!code-vb[CsLINQSetOps#1](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/CsLINQSetOps/VB/setops.vb#1)]

## <a name="see-also"></a>См. также раздел

- <xref:System.Linq>
- [Общие сведения о стандартных операторах запроса (Visual Basic)](standard-query-operators-overview.md)
- [Предложение Distinct](../../../language-reference/queries/distinct-clause.md)
- [Практические руководства. объединение и сравнение коллекций строк (LINQ) (Visual Basic)](how-to-combine-and-compare-string-collections-linq.md)
- [Как найти разность множеств между двумя списками (LINQ) (Visual Basic)](how-to-find-the-set-difference-between-two-lists-linq.md)

---
description: 'Дополнительные сведения: Операции квантификаторов (Visual Basic)'
title: Операции, использующие квантификаторы
ms.date: 07/20/2015
ms.assetid: ae1a2b73-503c-4f4b-a3fd-31b5adbee67c
ms.openlocfilehash: 7cbd8a9cf18a0ad8b70ada58d7fa6602dce4bd1b
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100430096"
---
# <a name="quantifier-operations-visual-basic"></a>Операции квантификаторов (Visual Basic)

Квантификаторы возвращают значение <xref:System.Boolean>, которое указывает, удовлетворяют ли условию некоторые или все элементы в последовательности.  
  
 На приведенном ниже рисунке показаны два различных квантификатора, примененные к двум разным исходным последовательностям. Первая операция проверяет, является ли один или несколько элементов буквой "А"; результатом является `true`. Вторая операция проверяет, являются ли все элементы буквой "А"; результатом является `true`.  
  
 ![Операции, использующие квантификаторы LINQ](./media/quantifier-operations/linq-quantifier-operations.png)  
  
 В следующем разделе перечислены методы стандартных операторов запросов, которые выполняют операции с использованием квантификаторов.  
  
## <a name="methods"></a>Методы  
  
|Имя метода|Описание|Синтаксис выражения запроса Visual Basic|Дополнительные сведения|  
|-----------------|-----------------|------------------------------------------|----------------------|  
|Все|Определяет, все ли элементы последовательности удовлетворяют условию.|`Aggregate … In … Into All(…)`|<xref:System.Linq.Enumerable.All%2A?displayProperty=nameWithType><br /><br /> <xref:System.Linq.Queryable.All%2A?displayProperty=nameWithType>|  
|Любой|Определяет, удовлетворяют ли условию какие-либо элементы последовательности.|`Aggregate … In … Into Any()`|<xref:System.Linq.Enumerable.Any%2A?displayProperty=nameWithType><br /><br /> <xref:System.Linq.Queryable.Any%2A?displayProperty=nameWithType>|  
|Содержит|Определяет, содержит ли последовательность указанный элемент.|Не применяется|<xref:System.Linq.Enumerable.Contains%2A?displayProperty=nameWithType><br /><br /> <xref:System.Linq.Queryable.Contains%2A?displayProperty=nameWithType>|  
  
## <a name="query-expression-syntax-examples"></a>Примеры синтаксиса выражений запросов  

 В этих примерах используется `Aggregate` предложение в Visual Basic в качестве части условия фильтрации в запросе LINQ.  
  
 В следующем примере используется `Aggregate` предложение и <xref:System.Linq.Enumerable.All%2A> метод расширения для возврата из коллекции тех, чьи пользователи, pets все старше указанного возраста.  
  
 [!code-vb[CsLINQAnyAll#1](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/CsLINQAnyAll/VB/AnyAll.vb#1)]  
  
 В следующем примере используется `Aggregate` предложение и <xref:System.Linq.Enumerable.Any%2A> метод расширения для возврата из коллекции пользователей, у которых есть по крайней мере один Pet, который старше указанного возраста.  
  
 [!code-vb[CsLINQAnyAll#2](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/CsLINQAnyAll/VB/AnyAll.vb#2)]  
  
## <a name="see-also"></a>См. также раздел

- <xref:System.Linq>
- [Общие сведения о стандартных операторах запроса (Visual Basic)](standard-query-operators-overview.md)
- [Aggregate Clause](../../../language-reference/queries/aggregate-clause.md)
- [Практическое руководство. Запрос к предложениям, содержащим указанный набор слов (LINQ) (Visual Basic)](how-to-query-for-sentences-that-contain-a-specified-set-of-words.md)

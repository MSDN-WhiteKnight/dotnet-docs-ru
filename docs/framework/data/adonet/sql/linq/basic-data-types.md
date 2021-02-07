---
description: 'Дополнительные сведения: основные типы данных'
title: Базовые типы данных
ms.date: 03/30/2017
ms.assetid: eca2c472-9548-4800-bd31-5d8d9f11752b
ms.openlocfilehash: d0236bc315c884d9e70c3c4a75755c3b66b1f2e4
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99712614"
---
# <a name="basic-data-types"></a>Базовые типы данных

Поскольку запросы LINQ to SQL преобразуются на язык Transact-SQL перед их выполнением на Microsoft SQL Server, LINQ to SQL поддерживает встроенные функции, во многом сходные с теми, которые SQL Server использует для основных типов данных.  
  
## <a name="casting"></a>Приведение  

 Явное или неявное приведение исходных типов CLR к целевым типам CLR возможно, если существует аналогичное допустимое преобразование в рамках SQL Server. Дополнительные сведения о приведении среды CLR см. в разделе [функции CType](../../../../../visual-basic/language-reference/functions/ctype-function.md) (Visual Basic) и [операторы проверки и приведения типов](../../../../../csharp/language-reference/operators/type-testing-and-cast.md). После преобразования приведение изменяет работу операций, выполняемых над выражением CLR, чтобы они соответствовали поведению других выражений CLR, которые естественным образом сопоставлены с целевым типом. Преобразование приведений типов также возможно в контексте сопоставления наследования. Объекты могут приводиться к более конкретным подтипам сущностей, чтобы обеспечить доступ к данным, характерным для их подтипа.  
  
## <a name="equality-operators"></a>Операторы равенства  

 LINQ to SQL поддерживает следующие операторы равенства для основных типов данных в запросах LINQ to SQL.  
  
- Оператор равенства и неравенства: операторы равенства и неравенства поддерживаются для числовых типов,, <xref:System.Boolean> <xref:System.DateTime> и <xref:System.TimeSpan> . Дополнительные сведения об операторах Visual Basic `=` и `<>` см. в разделе [Операторы сравнения](../../../../../visual-basic/language-reference/operators/comparison-operators.md). Дополнительные сведения об операторах сравнения C# `==` и `!=` см. в разделе [Операторы равенства](../../../../../csharp/language-reference/operators/equality-operators.md).
  
- Оператор Is: для оператора `IS` имеется поддерживаемый перевод, когда используется сопоставление наследования. Он может использоваться вместо прямой проверки столбца дискриминатора для выяснения, относится ли объект к определенному типу сущности и преобразуется ли он в проверку для столбца дискриминатора. Дополнительные сведения о Visual Basic и C# являются операторами, см. в разделе [оператор is](../../../../../visual-basic/language-reference/operators/is-operator.md) и [is](../../../../../csharp/language-reference/operators/type-testing-and-cast.md#is-operator).  
  
## <a name="see-also"></a>См. также

- [Сопоставление типов SQL-CLR](sql-clr-type-mapping.md)
- [Типы данных и функции](data-types-and-functions.md)

---
description: 'Дополнительные сведения о: BC36593: выражение типа <type> не может быть доступно для запросов'
title: Выражение типа <type> не доступно для запроса
ms.date: 07/20/2015
f1_keywords:
- bc36593
- vbc36593
helpviewer_keywords:
- BC36593
ms.assetid: 6f1f5860-bf97-4885-9ebb-bc87d028095c
ms.openlocfilehash: b2fc6c81ee34c1f8e251ac65ba582fde1c6a7b9d
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99796357"
---
# <a name="bc36593-expression-of-type-type-is-not-queryable"></a>BC36593: выражение типа \<type> не может быть доступно для запросов

Выражение типа \<type> не может быть доступно для запросов. Убедитесь, что отсутствует ссылка на сборку и (или) импорт пространства имен для поставщика LINQ.

 Запрашиваемые типы определяются в <xref:System.Linq> <xref:System.Data.Linq> <xref:System.Xml.Linq> пространствах имен, и. Для выполнения запросов LINQ необходимо импортировать одно или несколько из этих пространств имен.

 <xref:System.Linq>Пространство имен позволяет запрашивать объекты, такие как коллекции и массивы, с помощью LINQ.

 Это <xref:System.Data.Linq> пространство имен позволяет запрашивать наборы данных ADO.NET и SQL Server с помощью LINQ.

 <xref:System.Xml.Linq>Пространство имен позволяет запрашивать XML-код с помощью LINQ и использовать функции XML в Visual Basic.

 **Идентификатор ошибки:** BC36593

## <a name="to-correct-this-error"></a>Исправление ошибки

1. Добавьте `Import` оператор для <xref:System.Linq> <xref:System.Data.Linq> <xref:System.Xml.Linq> пространства имен, или в файл кода. Также можно импортировать пространства имен для проекта с помощью страницы **ссылки** в конструкторе проектов (**Мой проект**).

2. Убедитесь, что тип, определенный в качестве источника запроса, является запрашиваемым типом. То есть тип, реализующий <xref:System.Collections.Generic.IEnumerable%601> или <xref:System.Linq.IQueryable%601> .

## <a name="see-also"></a>См. также

- <xref:System.Linq>
- <xref:System.Data.Linq>
- <xref:System.Xml.Linq>
- [Introduction to LINQ in Visual Basic](../../programming-guide/language-features/linq/introduction-to-linq.md) (Знакомство с LINQ в Visual Basic)
- [LINQ](../../programming-guide/language-features/linq/index.md)
- [XML](../../programming-guide/language-features/xml/index.md)
- [Ссылки и оператор Imports](../../programming-guide/program-structure/references-and-the-imports-statement.md)
- [Оператор Imports (пространство имен .NET и тип)](../statements/imports-statement-net-namespace-and-type.md)
- [Страница "Ссылки" в конструкторе проектов (Visual Basic)](/visualstudio/ide/reference/references-page-project-designer-visual-basic)

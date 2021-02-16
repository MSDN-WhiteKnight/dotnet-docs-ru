---
description: Дополнительные сведения см. в статье Введение в LINQ (Visual Basic).
title: Введение в LINQ
ms.date: 07/20/2015
ms.assetid: c6339c12-9b2d-433e-961c-0d2b7f0091c2
ms.openlocfilehash: b6be93bbf9b458ca19068961617ee08f67601edc
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100426794"
---
# <a name="introduction-to-linq-visual-basic"></a>Знакомство с LINQ (Visual Basic)

LINQ (Language-Integrated Query) — это новая возможность, появившаяся в .NET Framework версии 3.5, которая соединяет мир объектов с миром данных.  
  
 Традиционно запросы к данным выражаются в виде простых строк без проверки типов при компиляции или поддержки IntelliSense. Кроме того, разработчику приходится изучать различные языки запросов для каждого типа источников данных: баз данных SQL, XML-документов, различных веб-служб и т. д. LINQ делает *запрос* к конструкции языка первого класса в Visual Basic. Вы создаете запросы к строго типизированным коллекциям объектов с помощью ключевых слов языка и знакомых операторов.  
  
 Можно писать запросы LINQ в Visual Basic для SQL Server баз данных, XML-документов, наборов данных ADO.NET и любой коллекции объектов, поддерживающих <xref:System.Collections.IEnumerable> или универсальный <xref:System.Collections.Generic.IEnumerable%601> интерфейс. Кроме того, сторонние разработчики обеспечивают поддержку LINQ для множества веб-служб и других реализаций баз данных.  
  
 Запросы LINQ можно использовать в новых проектах или параллельно с запросами, не относящимися к LINQ, в существующих проектах. Единственное требование: проект должен разрабатываться для платформы .NET Framework версии 3.5 или более поздней.  
  
 На приведенном ниже рисунке показан частично выполненный запрос LINQ к базе данных SQL Server в C# и Visual Basic с полной проверкой типов и поддержкой IntelliSense.  
  
 ![Схема, показывающая запрос LINQ с Intellisense.](./media/introduction-to-linq/linq-query-intellisense.png)  
  
## <a name="next-steps"></a>Next Steps  

 Чтобы получить дополнительные сведения о LINQ, начните с ознакомления с некоторыми основными понятиями в начало работы разделе [Начало работы с LINQ в Visual Basic](getting-started-with-linq.md), а затем прочитайте документацию по интересующей вас технологии LINQ:  
  
- Базы данных SQL Server: [LINQ to SQL](../../../../framework/data/adonet/sql/linq/index.md)  
  
- XML-документы: [LINQ to XML (Visual Basic)](../../../../standard/linq/linq-xml-overview.md)  
  
- Наборы данных ADO.NET: [LINQ to DataSet](../../../../framework/data/adonet/linq-to-dataset.md)  
  
- Коллекции .NET, файлы, строки и т. д. [LINQ to Objects (Visual Basic)](linq-to-objects.md)  
  
## <a name="see-also"></a>См. также раздел

- [LINQ (Visual Basic)](index.md)

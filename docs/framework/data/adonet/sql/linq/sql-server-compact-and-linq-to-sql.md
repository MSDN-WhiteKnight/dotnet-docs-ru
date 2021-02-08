---
description: 'Дополнительные сведения: SQL Server Compact и LINQ to SQL'
title: SQL Server Compact и LINQ to SQL
ms.date: 03/30/2017
ms.assetid: 59022359-a5a2-4c42-9a6a-5c0259c3ad17
ms.openlocfilehash: ae7965db1685d7682b643662df8fb1c1376a7154
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99803715"
---
# <a name="sql-server-compact-and-linq-to-sql"></a>SQL Server Compact и LINQ to SQL

SQL Server Compact — это база данных по умолчанию, устанавливаемая вместе с Visual Studio. Дополнительные сведения см. [в разделе использование SQL Server Compact (Visual Studio)](/previous-versions/visualstudio/visual-studio-2012/aa983321(v=vs.110)).  
  
 В этом разделе описываются основные различия в использовании, конфигурации, наборах функций и области [!INCLUDE[vbtecdlinq](../../../../../../includes/vbtecdlinq-md.md)] поддержки.  
  
## <a name="characteristics-of-sql-server-compact-in-relation-to-linq-to-sql"></a>Характеристики SQL Server Compact относительно LINQ to SQL  

 По умолчанию SQL Server Compact устанавливается для всех выпусков Visual Studio и, следовательно, доступен на компьютере разработчика для использования с [!INCLUDE[vbtecdlinq](../../../../../../includes/vbtecdlinq-md.md)] . Но развертывание приложения, которое использует SQL Server Compact и [!INCLUDE[vbtecdlinq](../../../../../../includes/vbtecdlinq-md.md)] отличается от этого для SQL Server приложения. SQL Server Compact не является частью платформы .NET Framework. Этот компонент должен быть упакован в состав приложения или загружен отдельно с веб-сайта Майкрософт.  
  
 Обратите внимание на следующие характеристики.  
  
- SQL Server Compact упаковывается в виде DLL-файла, который может использоваться непосредственно в файлах базы данных (расширение SDF).  
  
- SQL Server Compact выполняется в тех же процессах, что и клиентское приложение. Таким образом, эффективность взаимодействия с SQL Server Compact может быть значительно выше, чем связь с SQL Server. С другой стороны, для SQL Server Compact не требуется взаимодействие управляемого и неуправляемого кода с сопутствующими расходами.  
  
- Размер DLL-библиотеки SQL Server Compact невелик. Данная функция сокращает общий размер приложения.  
  
- Среда выполнения [!INCLUDE[vbtecdlinq](../../../../../../includes/vbtecdlinq-md.md)] и средство командной строки SQLMetal поддерживают SQL Server Compact.  
  
- Реляционный конструктор объектов не поддерживает SQL Server Compact.  
  
## <a name="feature-set"></a>Набор возможностей  

 Набор функций SQL Server Compact намного проще, чем набор функций SQL Server следующими способами, которые могут повлиять на [!INCLUDE[vbtecdlinq](../../../../../../includes/vbtecdlinq-md.md)] приложения:  
  
- SQL Server Compact не поддерживает хранимые процедуры или представления.  
  
- SQL Server Compact поддерживает только подмножество типов данных и функций SQL.  
  
- SQL Server Compact поддерживает только подмножество конструкций SQL.  
  
- SQL Server Compact предоставляет только минимальный оптимизатор. Существует возможность истечения времени ожидания некоторых запросов.  
  
- SQL Server Compact не поддерживает частичное доверие.  
  
## <a name="see-also"></a>См. также

- [Ссылки](reference.md)

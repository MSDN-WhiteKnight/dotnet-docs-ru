---
description: 'Дополнительные сведения о: SqlClient для Entity Framework'
title: SqlClient для Entity Framework
ms.date: 03/30/2017
ms.assetid: 9a5d6d39-d955-43a5-a5c2-931c239398f1
ms.openlocfilehash: eba5602c13f66d1ee4404bbc27035304e34c1cd0
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99673132"
---
# <a name="sqlclient-for-the-entity-framework"></a>SqlClient для Entity Framework

В этом разделе описан поставщик данных .NET Framework для SQL Server (SqlClient), который позволяет платформе Entity Framework работать с сервером Microsoft SQL Server.  
  
## <a name="provider-schema-attribute"></a>Атрибут Provider элемента Schema  

 `Provider` является атрибутом элемента `Schema` в языке SSDL.  
  
 Для использования SqlClient нужно присвоить атрибуту `Provider` элемента `Schema` значение в виде строки «System.Data.SqlClient».  
  
## <a name="providermanifesttoken-schema-attribute"></a>Атрибут ProviderManifestToken элемента Schema  

 `ProviderManifestToken` - обязательный атрибут элемента `Schema` в SSDL. Этот маркер используется для загрузки манифеста поставщика при автономном использовании. Дополнительные сведения об `ProviderManifestToken` атрибуте см. в разделе [элемент Schema (SSDL)](/ef/ef6/modeling/designer/advanced/edmx/ssdl-spec#schema-element-ssdl).  
  
 SqlClient можно использовать в качестве поставщика данных для разных версий SQL Server. Эти версии имеют разные возможности. Например, SQL Server 2000 не поддерживает `varchar(max)` `nvarchar(max)` типы и, которые появились в SQL Server 2005.  
  
 SqlClient формирует и принимает следующие маркеры манифеста поставщика для различных версий SQL Server.  
  
|SQL Server 2000|SQL Server 2005|SQL Server 2008|  
|-|-|-|  
|2000|2005|2008|  
  
> [!NOTE]
> Начиная с Visual Studio 2010 [средства ADO.NET EDM](/previous-versions/dotnet/netframework-4.0/bb399249(v=vs.100)) не поддерживают SQL Server 2000.  
  
## <a name="provider-namespace-name"></a>Имя пространства имен поставщика  

 Все поставщики должны указывать пространство имен. Это свойство сообщает платформе Entity Framework о том, какой префикс используется поставщиком для конкретных конструкций, таких как типы или функции. Пространством имен для манифестов поставщика SqlClient является `SqlServer`. Дополнительные сведения о пространствах имен см. в разделе [пространства имен](./language-reference/namespaces-entity-sql.md).  
  
## <a name="types"></a>Типы  

 Поставщик SqlClient для платформы Entity Framework предоставляет сведения о сопоставлении между типами концептуальной модели и типами SQL Server. Дополнительные сведения см. в разделе [SqlClient для Entity Framework](sqlclient-for-ef-types.md).  
  
## <a name="functions"></a>Функции  

 Поставщик SqlClient для платформы Entity Framework определяет список функций, поддерживаемых поставщиком. Список поддерживаемых функций см. в разделе [SqlClient for Entity Framework functions](sqlclient-for-ef-functions.md).  
  
## <a name="in-this-section"></a>В этом разделе  

 [Функции SqlClient для Entity Framework](sqlclient-for-ef-functions.md)  
  
 [Типы SqlClient для Entity Framework](sqlclient-for-ef-types.md)  
  
 [Известные проблемы SqlClient для Entity Framework](known-issues-in-sqlclient-for-entity-framework.md)  
  
## <a name="see-also"></a>См. также

- [Язык Entity SQL](./language-reference/entity-sql-language.md)
- [Справочник по языку](./language-reference/index.md)
- [Известные проблемы в поставщике SqlClient для Entity Framework](sqlclient-for-the-entity-framework.md)

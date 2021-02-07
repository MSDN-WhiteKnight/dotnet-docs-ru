---
description: Дополнительные сведения о настройке службы данных (службы данных WCF)
title: Настройка службы данных (службы данных WCF)
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- WCF Data Services, configuring
ms.assetid: 59efd4c8-cc7a-4800-a0a4-d3f8abe6c55c
ms.openlocfilehash: 72bd0de5319cc4b19fd831f4ee302e073106c74b
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99766197"
---
# <a name="configuring-the-data-service-wcf-data-services"></a>Настройка службы данных (службы данных WCF)

[!INCLUDE [wcf-deprecated](~/includes/wcf-deprecated.md)]

С помощью службы данных WCF можно создавать службы данных, предоставляющие доступ к каналам Open Data Protocol (OData). В этих каналах могут находиться данные из различных источников данных. Службы данных WCF использует поставщики данных для предоставления этих данных в качестве веб-канала OData. В число таких поставщиков входят поставщик Entity Framework, поставщик отражения, а также набор пользовательских интерфейсов поставщиков служб данных. Реализация поставщика определяет модель данных для службы. Дополнительные сведения см. в разделе [поставщики служб данных](data-services-providers-wcf-data-services.md).  
  
 В службы данных WCF служба данных — это класс, который наследует от <xref:System.Data.Services.DataService%601> класса, где тип службы данных является контейнером сущностей модели данных. Этот контейнер сущностей имеет одно или несколько свойств, возвращающих интерфейс <xref:System.Linq.IQueryable%601>, которые используются для доступа к наборам сущностей модели данных.  
  
 Поведение службы данных определяется членами класса <xref:System.Data.Services.DataServiceConfiguration> и класса <xref:System.Data.Services.DataServiceBehavior>, доступ к которому осуществляется через свойство <xref:System.Data.Services.DataServiceConfiguration.DataServiceBehavior%2A> класса <xref:System.Data.Services.DataServiceConfiguration>. Класс <xref:System.Data.Services.DataServiceConfiguration> предоставляется методу `InitializeService`, реализуемому службой данных, как показано в следующей реализации службы данных Northwind.  
  
[!code-csharp[Astoria Northwind Service#DataServiceConfigComplete](../../../../samples/snippets/csharp/VS_Snippets_Misc/astoria_northwind_service/cs/northwind.svc.cs#dataserviceconfigcomplete)]  
[!code-vb[Astoria Northwind Service#DataServiceConfigComplete](../../../../samples/snippets/visualbasic/VS_Snippets_Misc/astoria_northwind_service/vb/northwind.svc.vb#dataserviceconfigcomplete)]  
  
## <a name="data-service-configuration-settings"></a>Параметры конфигурации службы данных  

 Класс <xref:System.Data.Services.DataServiceConfiguration> позволяет задать следующее поведение службы данных.  
  
|Член|Поведение|  
|------------|--------------|  
|<xref:System.Data.Services.DataServiceBehavior.AcceptCountRequests%2A>|Позволяет отключить запросы количества, передаваемые службе данных при использовании сегмента пути `$count` и параметра запроса `$inlinecount`. Дополнительные сведения см. в разделе [OData: соглашения об URI](https://www.odata.org/documentation/odata-version-2-0/uri-conventions/).|  
|<xref:System.Data.Services.DataServiceBehavior.AcceptProjectionRequests%2A>|Позволяет отключить поддержку проекции данных в запросах, передаваемых службе данных при использовании параметра запроса `$select`. Дополнительные сведения см. в разделе [OData: соглашения об URI](https://www.odata.org/documentation/odata-version-2-0/uri-conventions/).|  
|<xref:System.Data.Services.DataServiceConfiguration.EnableTypeAccess%2A>|Включает тип данных, предоставляемый в метаданных для динамического поставщика метаданных, определенного с помощью интерфейса <xref:System.Data.Services.Providers.IDataServiceMetadataProvider>.|  
|<xref:System.Data.Services.DataServiceConfiguration.EnableTypeConversion%2A>|Позволяет указать, должна ли среда выполнения службы данных преобразовывать тип, содержащийся в полезных данных, в фактический тип свойства, указанный в запросе.|  
|<xref:System.Data.Services.DataServiceBehavior.InvokeInterceptorsOnLinkDelete%2A>|Позволяет указать, следует ли вызывать перехватчиков зарегистрированных изменений для связанных сущностей при удалении ссылки связи между двумя сущностями.|  
|<xref:System.Data.Services.DataServiceConfiguration.MaxBatchCount%2A>|Позволяет ограничить число наборов изменений и операций запросов, разрешенных в одном пакете. Дополнительные сведения см. в разделе [OData: пакетная](https://www.odata.org/documentation/odata-version-2-0/batch-processing/) обработка и [операции пакетной обработки](batching-operations-wcf-data-services.md).|  
|<xref:System.Data.Services.DataServiceConfiguration.MaxChangesetCount%2A>|Позволяет ограничить количество изменений, которые могут быть включены в один набор изменений. Дополнительные сведения см. [в разделе Практические руководства. Включение разбиения результатов службы данных](how-to-enable-paging-of-data-service-results-wcf-data-services.md).|  
|<xref:System.Data.Services.DataServiceConfiguration.MaxExpandCount%2A>|Позволяет ограничить размер ответа путем ограничения количества связанных сущностей, которые могут быть включены в один запрос при использовании оператора запроса `$expand`. Дополнительные сведения см. в разделе [OData: соглашения об URI](https://www.odata.org/documentation/odata-version-2-0/uri-conventions/) и [Загрузка отложенного содержимого](loading-deferred-content-wcf-data-services.md).|  
|<xref:System.Data.Services.DataServiceConfiguration.MaxExpandDepth%2A>|Позволяет ограничить размер ответа путем ограничения глубины графа связанных сущностей, которые могут быть включены в один запрос при использовании оператора запроса `$expand`. Дополнительные сведения см. в разделе [OData: соглашения об URI](https://www.odata.org/documentation/odata-version-2-0/uri-conventions/) и [Загрузка отложенного содержимого](loading-deferred-content-wcf-data-services.md).|  
|<xref:System.Data.Services.DataServiceConfiguration.MaxObjectCountOnInsert%2A>|Позволяет ограничить количество вставляемых сущностей, которые могут содержаться в одном запросе POST.|  
|<xref:System.Data.Services.DataServiceBehavior.MaxProtocolVersion%2A>|Определяет версию протокола Atom, используемую службой данных. Если значение параметра <xref:System.Data.Services.DataServiceBehavior.MaxProtocolVersion%2A> равно значению, меньшему максимальному значению <xref:System.Data.Services.Common.DataServiceProtocolVersion> , то последняя функциональность службы данных WCF недоступна для клиентов, обращающихся к службе данных. Дополнительные сведения см. в разделе [Управление версиями службы данных](data-service-versioning-wcf-data-services.md).|  
|<xref:System.Data.Services.DataServiceConfiguration.MaxResultsPerCollection%2A>|Позволяет ограничить размер ответа путем ограничения количества сущностей в каждом наборе сущностей, возвращаемом в виде канала данных.|  
|<xref:System.Data.Services.DataServiceConfiguration.RegisterKnownType%2A>|Добавляет тип данных в список типов, распознаваемых службой данных.|  
|<xref:System.Data.Services.DataServiceConfiguration.SetEntitySetAccessRule%2A>|Задает права доступа для ресурсов набора сущностей, доступных в службе данных. Значение «звездочка» (`*`) может использоваться в параметре имени для задания доступа того же уровня для всех остальных наборов сущностей. Для предоставления минимального уровня прав доступа к ресурсам службы данных, необходимым клиентским приложениям рекомендуется задавать доступ к наборам сущностей. Дополнительные сведения см. в разделе [Securing WCF Data Services](securing-wcf-data-services.md). Примеры минимальных прав доступа, необходимых для данного URI и действия HTTP, см. в таблице в разделе [требования к минимальному доступу к ресурсам](configuring-the-data-service-wcf-data-services.md#accessRequirements) .|  
|<xref:System.Data.Services.DataServiceConfiguration.SetEntitySetPageSize%2A>|Задает максимальный размер страницы для ресурса набора сущностей. Дополнительные сведения см. [в разделе Практические руководства. Включение разбиения результатов службы данных](how-to-enable-paging-of-data-service-results-wcf-data-services.md).|  
|<xref:System.Data.Services.DataServiceConfiguration.SetServiceOperationAccessRule%2A>|Задает права доступа для операций службы, определенных в службе данных. Дополнительные сведения см. в разделе [операции службы](service-operations-wcf-data-services.md). Значение «звездочка» (`*`) может использоваться в параметре имени для задания доступа того же уровня для всех остальных операций службы. Рекомендуется задавать операциям службы минимальный уровень прав доступа к ресурсам службы данных, необходимых клиентским приложениям. Дополнительные сведения см. в разделе [Securing WCF Data Services](securing-wcf-data-services.md).|  
|<xref:System.Data.Services.DataServiceConfiguration.UseVerboseErrors%2A>|Этот параметр настройки упрощает процесс устранения неполадок службы данных, возвращая дополнительные сведения в ответном сообщении об ошибке. Параметр не предназначен для использования в рабочей среде. Дополнительные сведения см. в разделе [Разработка и развертывание службы данных WCF](developing-and-deploying-wcf-data-services.md).|  
  
<a name="accessRequirements"></a>

## <a name="minimum-resource-access-requirements"></a>Минимальные требования для доступа к ресурсам  

 В следующих сведениях о таблице указаны минимальные права набора сущностей, которые необходимо предоставить для выполнения определенной операции. Примеры путей основаны на службе данных Northwind, которая создается при завершении [краткого руководства](quickstart-wcf-data-services.md). Поскольку перечисления <xref:System.Data.Services.EntitySetRights> и <xref:System.Data.Services.ServiceOperationRights> определяются с помощью <xref:System.FlagsAttribute>, для указания нескольких разрешений для одного набора сущностей или операции можно использовать логический оператор OR. Дополнительные сведения см. [в разделе инструкции. Включение доступа к службе данных](how-to-enable-access-to-the-data-service-wcf-data-services.md).  
  
|Путь/действие|`GET`|`DELETE`|`MERGE`|`POST`|`PUT`|  
|------------------|-----------|--------------|-------------|------------|-----------|  
|`/Customers`|<xref:System.Data.Services.EntitySetRights.ReadMultiple>|Не поддерживается|Не поддерживается|<xref:System.Data.Services.EntitySetRights.WriteAppend>|Не поддерживается|  
|`/Customers('ALFKI')`|<xref:System.Data.Services.EntitySetRights.ReadSingle>|<xref:System.Data.Services.EntitySetRights.ReadSingle> и <xref:System.Data.Services.EntitySetRights.WriteDelete>|<xref:System.Data.Services.EntitySetRights.ReadSingle> и <xref:System.Data.Services.EntitySetRights.WriteMerge>|Недоступно|<xref:System.Data.Services.EntitySetRights.ReadSingle> и <xref:System.Data.Services.EntitySetRights.WriteReplace>|  
|`/Customers('ALFKI')/Orders`|`Customers`: <xref:System.Data.Services.EntitySetRights.ReadSingle><br /><br /> - и -<br /><br /> `Orders`: <xref:System.Data.Services.EntitySetRights.ReadMultiple>|Не поддерживается|Не поддерживается|`Customers`: <xref:System.Data.Services.EntitySetRights.ReadSingle> и <xref:System.Data.Services.EntitySetRights.WriteMerge> или <xref:System.Data.Services.EntitySetRights.WriteReplace><br /><br /> - и -<br /><br /> `Orders``:`и<xref:System.Data.Services.EntitySetRights.WriteAppend>|Не поддерживается|  
|`/Customers('ALFKI')/Orders(10643)`|`Customers`: <xref:System.Data.Services.EntitySetRights.ReadSingle><br /><br /> - и -<br /><br /> `Orders`: <xref:System.Data.Services.EntitySetRights.ReadSingle>|`Customers`: <xref:System.Data.Services.EntitySetRights.ReadSingle><br /><br /> - и -<br /><br /> `Orders`: <xref:System.Data.Services.EntitySetRights.ReadSingle> и <xref:System.Data.Services.EntitySetRights.WriteDelete>|`Customers`: <xref:System.Data.Services.EntitySetRights.ReadSingle><br /><br /> - и -<br /><br /> `Orders`: <xref:System.Data.Services.EntitySetRights.ReadSingle> и <xref:System.Data.Services.EntitySetRights.WriteMerge>|Не поддерживается|`Customers`: <xref:System.Data.Services.EntitySetRights.ReadSingle><br /><br /> - и -<br /><br /> `Orders`: <xref:System.Data.Services.EntitySetRights.ReadSingle> и <xref:System.Data.Services.EntitySetRights.WriteReplace>|  
|`/Orders(10643)/Customer`|`Customers`: <xref:System.Data.Services.EntitySetRights.ReadSingle><br /><br /> - и -<br /><br /> `Orders`: <xref:System.Data.Services.EntitySetRights.ReadSingle>|`Customers`: <xref:System.Data.Services.EntitySetRights.ReadSingle> и <xref:System.Data.Services.EntitySetRights.WriteDelete><br /><br /> - и -<br /><br /> `Orders`: <xref:System.Data.Services.EntitySetRights.ReadSingle>|`Customers`: <xref:System.Data.Services.EntitySetRights.ReadSingle> и <xref:System.Data.Services.EntitySetRights.WriteMerge>;<br /><br /> - и -<br /><br /> `Orders`: <xref:System.Data.Services.EntitySetRights.ReadSingle>|`Customers`: <xref:System.Data.Services.EntitySetRights.WriteAppend><br /><br /> - и -<br /><br /> `Orders`: <xref:System.Data.Services.EntitySetRights.WriteAppend> и <xref:System.Data.Services.EntitySetRights.ReadSingle>|Не поддерживается|  
|`/Customers('ALFKI')/$links/Orders`|`Customers`: <xref:System.Data.Services.EntitySetRights.ReadSingle><br /><br /> - и -<br /><br /> `Orders`: <xref:System.Data.Services.EntitySetRights.ReadMultiple>|Не поддерживается|Не поддерживается|`Customers`: <xref:System.Data.Services.EntitySetRights.ReadSingle> и <xref:System.Data.Services.EntitySetRights.WriteMerge> или <xref:System.Data.Services.EntitySetRights.WriteReplace><br /><br /> - и -<br /><br /> `Orders`: <xref:System.Data.Services.EntitySetRights.ReadSingle>|Не поддерживается|  
|`/Customers('ALFKI')/$links/Orders(10643)`|`Customers`: <xref:System.Data.Services.EntitySetRights.ReadSingle><br /><br /> - и -<br /><br /> `Orders`: <xref:System.Data.Services.EntitySetRights.ReadSingle>|`Customers`: <xref:System.Data.Services.EntitySetRights.ReadSingle> и <xref:System.Data.Services.EntitySetRights.WriteMerge> или <xref:System.Data.Services.EntitySetRights.WriteReplace><br /><br /> - и -<br /><br /> `Orders`: <xref:System.Data.Services.EntitySetRights.ReadSingle>|Не поддерживается|Не поддерживается|Не поддерживается|  
|`/Orders(10643)/$links/Customer`|`Customers`: <xref:System.Data.Services.EntitySetRights.ReadSingle><br /><br /> - и -<br /><br /> `Orders`: <xref:System.Data.Services.EntitySetRights.ReadSingle>|`Orders`: <xref:System.Data.Services.EntitySetRights.ReadSingle> и <xref:System.Data.Services.EntitySetRights.WriteMerge> или <xref:System.Data.Services.EntitySetRights.WriteReplace>|`Customers`: <xref:System.Data.Services.EntitySetRights.ReadSingle><br /><br /> - и -<br /><br /> `Orders`: <xref:System.Data.Services.EntitySetRights.ReadSingle> и <xref:System.Data.Services.EntitySetRights.WriteMerge>|Не поддерживается|`Customers`: <xref:System.Data.Services.EntitySetRights.ReadSingle>;<br /><br /> - и -<br /><br /> `Orders`: <xref:System.Data.Services.EntitySetRights.ReadSingle> и <xref:System.Data.Services.EntitySetRights.WriteReplace>|  
|`/Customers/$count`|<xref:System.Data.Services.EntitySetRights.ReadMultiple>|Не поддерживается|Не поддерживается|Не поддерживается|Не поддерживается|  
|`/Customers('ALFKI')/ContactName`|<xref:System.Data.Services.EntitySetRights.ReadSingle>|Не поддерживается|<xref:System.Data.Services.EntitySetRights.WriteMerge>|Не поддерживается|<xref:System.Data.Services.EntitySetRights.WriteReplace>|  
|`/Customers('ALFKI')/Address/StreetAddress/$value` <sup>1</sup>|<xref:System.Data.Services.EntitySetRights.ReadSingle>|<xref:System.Data.Services.EntitySetRights.WriteDelete>|Не поддерживается|Не поддерживается|Не поддерживается|  
|`/Customers('ALFKI')/ContactName/$value`|<xref:System.Data.Services.EntitySetRights.ReadSingle>|<xref:System.Data.Services.EntitySetRights.ReadSingle> и <xref:System.Data.Services.EntitySetRights.WriteDelete>|<xref:System.Data.Services.EntitySetRights.WriteMerge>|Не поддерживается|<xref:System.Data.Services.EntitySetRights.WriteReplace>|  
|`/Customers('ALFKI')/$value` <sup>2</sup>|<xref:System.Data.Services.EntitySetRights.ReadSingle>|Не поддерживается|Не поддерживается|Не поддерживается|<xref:System.Data.Services.EntitySetRights.WriteReplace>|  
|`/Customers?$select=Orders/*&$expand=Orders`|`Customers`: <xref:System.Data.Services.EntitySetRights.ReadSingle><br /><br /> - и -<br /><br /> `Orders`: <xref:System.Data.Services.EntitySetRights.ReadMultiple>|Не поддерживается|Не поддерживается|`Customers`: <xref:System.Data.Services.EntitySetRights.WriteAppend>|Не поддерживается|  
|`/Customers('ALFKI')?$select=Orders/*&$expand=Orders`|`Customers`: <xref:System.Data.Services.EntitySetRights.ReadSingle><br /><br /> - и -<br /><br /> `Orders`: <xref:System.Data.Services.EntitySetRights.ReadMultiple>|Не поддерживается|Не поддерживается|Не поддерживается|Не поддерживается|  
  
 <sup>1</sup> в этом примере `Address` представляет свойство сложного типа `Customers` сущности, имеющей свойство с именем `StreetAddress` . Модель, которая используется службой данных Northwind, не определяет этот сложный тип явно. Если модель данных определяется с помощью поставщика Entity Framework, такой сложный тип можно определить с помощью средств модели EDM. Дополнительные сведения см. [в разделе инструкции. Создание и изменение сложных типов](/previous-versions/dotnet/netframework-4.0/dd456820(v=vs.100)).  
  
 <sup>2</sup> этот URI поддерживается, если свойство, возвращающее большой двоичный объект (BLOB), определено как ресурс мультимедиа, принадлежащий сущности, которая является записью ссылки на носитель, в данном случае — `Customers` . Дополнительные сведения см. в разделе [Streaming Provider](streaming-provider-wcf-data-services.md).  
  
<a name="versioning"></a>

## <a name="versioning-requirements"></a>Требования к управлению версиями  

 Для следующих поведений конфигурации службы данных требуется версия 2 протокола OData или более поздние версии:  
  
- Поддержка числа запросов.  
  
- Поддержка параметра запроса $select для проекции.  
  
 Дополнительные сведения см. в разделе [Управление версиями службы данных](data-service-versioning-wcf-data-services.md).  
  
## <a name="see-also"></a>См. также

- [Определение служб данных WCF](defining-wcf-data-services.md)
- [Размещение службы данных](hosting-the-data-service-wcf-data-services.md)

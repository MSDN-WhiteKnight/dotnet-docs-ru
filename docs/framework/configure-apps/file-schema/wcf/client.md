---
description: 'Дополнительные сведения: <client>'
title: <client>
ms.date: 03/30/2017
f1_keywords:
- http://schemas.microsoft.com/.NetConfiguration/v2.0#configuration/system.ServiceModel/client
- http://schemas.microsoft.com/.NetConfiguration/v2.0#client
ms.assetid: bf0f7031-76c8-4e7e-a6c6-9ad9119134be
ms.openlocfilehash: 9765460602738f49963ea521b3f00ed7c63cc568
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99638864"
---
# \<client>

Элемент `client` определяет список конечных точек, к которым может подключаться клиент.

[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<system.serviceModel>**](system-servicemodel.md)\
&nbsp;&nbsp;&nbsp;&nbsp;**\<client>**

## <a name="syntax"></a>Синтаксис

```xml
<system.serviceModel>
  <client>
    <endpoint>
    </endpoint>
    <metadata>
    </metadata>
  </client>
</system.serviceModel>
```

## <a name="attributes-and-elements"></a>Атрибуты и элементы

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.

### <a name="attributes"></a>Атрибуты

 None

### <a name="child-elements"></a>Дочерние элементы

|Элемент|Описание|
|-------------|-----------------|
|[\<endpoint>](endpoint-of-client.md)|Содержит коллекцию элементов Endpoint, указывающих конечные точки, к которым может подключаться этот клиент.|
|[\<metadata>](metadata.md)|Содержит параметры обработки метаданных.|

### <a name="parent-elements"></a>Родительские элементы

|Элемент|Описание|
|-------------|-----------------|
|[\<system.serviceModel>](system-servicemodel.md)|Корневой элемент всех элементов конфигурации Windows Communication Foundation (WCF).|

## <a name="remarks"></a>Remarks

 В разделе `client` определяется список конечных точек, к которым может подключаться клиент. Каждая конечная точка, указанная в разделе клиента, определяет свои собственные привязку, поведение и контракт. Она однозначно определяется сочетанием атрибутов `name` и `contract`. В коде клиента указывается атрибут `name` для подключения к конечной точке службы, выполняемой клиентом. Если атрибут `name` отсутствует, конечная точка действует как конечная точка по умолчанию для контракта, который она реализует.

 Кроме того, в данном разделе также задаются параметры обработки метаданных.

## <a name="example"></a>Пример

```xml
<client>
  <endpoint address="/HelloWorld/"
            bindingConfiguration="usingDefaults"
            name="MyBinding"
            binding="customBinding"
            contract="HelloWorld">
    <addressProperties actingAs="http://www.microsoft.com/TestActor"
                       identityData="BasicReadWrite"
                       identityType="Spn"
                       isAddressPrivate="false">
  </endpoint>
</client>
```

## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Configuration.ClientSection>
- <xref:System.ServiceModel.Configuration.MetadataElement>
- [Конфигурация клиента WCF](../../../wcf/feature-details/client-configuration.md)
- [Клиенты](../../../wcf/feature-details/clients.md)

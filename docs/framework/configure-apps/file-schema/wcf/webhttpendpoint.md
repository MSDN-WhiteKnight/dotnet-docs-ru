---
description: 'Дополнительные сведения: <webHttpEndpoint>'
title: <webHttpEndpoint>
ms.date: 03/30/2017
ms.assetid: ecaaeb6f-ebd0-411d-8b53-92477cd45347
ms.openlocfilehash: d1bcda1fc97dece833c8163e5facbefe614af0ac
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99682596"
---
# \<webHttpEndpoint>

Этот элемент конфигурации определяет стандартную конечную точку с фиксированной [\<webHttpBinding>](webhttpbinding.md) привязкой, которая автоматически добавляет [\<webHttp>](webhttp.md) поведение. Используйте эту конечную точку при написании службы REST.  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<system.serviceModel>**](system-servicemodel.md)\
&nbsp;&nbsp;&nbsp;&nbsp;[**\<standardEndpoints>**](standardendpoints.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<webHttpEndpoint>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<system.serviceModel>
  <standardEndpoints>
    <webHttpEndpoint>
      <standardEndpoint automaticFormatSelectionEnabled="String"
                        defaultOutgoingResponseFormat="Xml/Json"
                        helpEnabled="Boolean"
                        webEndpointType="String" />
    </webHttpEndpoint>
  </standardEndpoints>
</system.serviceModel>
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|automaticFormatSelectionEnabled|Логическое значение, указывающее, включен ли автоматический выбор формата.<br /><br /> Если автоматический выбор формата включен, инфраструктура выполняет синтаксический анализ заголовка `Accept` сообщения запроса и определяет наиболее подходящий формат ответа. Если в заголовке `Accept` не указан подходящий формат ответа, инфраструктура использует тип `Content-Type` сообщения запроса или формат ответа, заданный для этой операции по умолчанию.|  
|defaultOutgoingResponseFormat|Атрибут, определяющий формат исходящего ответа по умолчанию. Это атрибут типа <xref:System.ServiceModel.Web.WebMessageFormat>.|  
|helpEnabled|Логическое значение, указывающее, включена ли страница справки HTTP для конечной точки.|  
|webEndpointType|Строка, указывающая тип конечной точки.|  
  
### <a name="child-elements"></a>Дочерние элементы  

 Отсутствует.  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<standardEndpoints>](standardendpoints.md)|Коллекция стандартных конечных точек, одно или несколько свойств которых (адрес, привязка, контракт) являются фиксированными.|  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Description.WebHttpEndpoint>
- <xref:System.ServiceModel.Configuration.WebHttpEndpointElement>

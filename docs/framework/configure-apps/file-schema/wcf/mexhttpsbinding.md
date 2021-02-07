---
description: 'Дополнительные сведения: <mexHttpsBinding>'
title: <mexHttpsBinding>
ms.date: 03/30/2017
ms.assetid: f2ed3774-78b9-4a15-b79b-655f1ad68b86
ms.openlocfilehash: 1e6eb66e1379cb8f351e34d4fd406dd3cc1f9a4e
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99684338"
---
# \<mexHttpsBinding>

Задает параметры для привязки, используемой для обмена сообщениями WS-MetadataExchange (WS-MEX) посредством HTTPS.  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<system.serviceModel>**](system-servicemodel.md)\
&nbsp;&nbsp;&nbsp;&nbsp;[**\<bindings>**](bindings.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<mexHttpsBinding>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<mexHttpsBinding>
  <binding closeTimeout="TimeSpan"
            name="string"
            openTimeout="TimeSpan"
            receiveTimeout="TimeSpan"
            sendTimeout="TimeSpan">
  </binding>
</mexHttpsBinding>
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|`closeTimeout`|Значение <xref:System.TimeSpan>, которое задает длительность времени ожидания для завершения операции закрытия. Это значение должно быть больше или равно <xref:System.TimeSpan.Zero>. Значение по умолчанию - 00:01:00.|  
|`name`|Строка, содержащая имя конфигурации привязки. Это значение должно быть уникальным, поскольку оно используется в качестве идентификатора привязки. Начиная с платформа .NET Framework 4, привязки и поведения не обязательно должны иметь имя. Дополнительные сведения о конфигурации по умолчанию и привязках и поведении, которые не имеют имен, см. в разделе [упрощенная конфигурация](../../../wcf/simplified-configuration.md) и [упрощенная конфигурация для служб WCF](../../../wcf/samples/simplified-configuration-for-wcf-services.md).|  
|`openTimeout`|Значение <xref:System.TimeSpan>, которое задает длительность времени ожидания для завершения операции открытия. Это значение должно быть больше или равно <xref:System.TimeSpan.Zero>. Значение по умолчанию - 00:01:00.|  
|`receiveTimeout`|Значение <xref:System.TimeSpan>, которое задает длительность времени ожидания для завершения операции получения. Это значение должно быть больше или равно <xref:System.TimeSpan.Zero>. Значение по умолчанию - 00:10:00.|  
|`sendTimeout`|Значение <xref:System.TimeSpan>, которое задает длительность времени ожидания для завершения операции отправки. Это значение должно быть больше или равно <xref:System.TimeSpan.Zero>. Значение по умолчанию - 00:01:00.|  
  
### <a name="child-elements"></a>Дочерние элементы  

 Отсутствует.  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<bindings>](bindings.md)|Этот элемент содержит коллекцию стандартных и пользовательских привязок.|  
  
## <a name="remarks"></a>Remarks  

 Эта привязка по существу является привязкой `WSHttpBinding`, которая поддерживает безопасность уровня транспорта с помощью сертификатов. Дополнительные сведения о настройке и использовании такой конечной точки метаданных см. в разделе [как настроить настраиваемую привязку WS-Metadata Exchange](../../../wcf/extending/how-to-configure-a-custom-ws-metadata-exchange-binding.md), [как получить метаданные через ПРИвязку обмена метаданными](../../../wcf/extending/how-to-retrieve-metadata-over-a-non-mex-binding.md), а также как образец [настраиваемой конечной точки безопасных метаданных](../../../wcf/samples/custom-secure-metadata-endpoint.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Description.MetadataExchangeBindings.CreateMexHttpsBinding%2A>
- <xref:System.ServiceModel.Configuration.MexHttpsBindingElement>
- [Практическое руководство. Публикация метаданных для службы с использованием файла конфигурации](../../../wcf/feature-details/how-to-publish-metadata-for-a-service-using-a-configuration-file.md)
- [Публикация и получение метаданных через пользовательскую привязку](../../../wcf/extending/publishing-and-retrieving-metadata-over-a-custom-binding.md)
- [Практическое руководство. Настройка пользовательской привязки для обмена WS-Metadata](../../../wcf/extending/how-to-configure-a-custom-ws-metadata-exchange-binding.md)
- [Практическое руководство. Получение метаданных через привязку, не использующую MEX](../../../wcf/extending/how-to-retrieve-metadata-over-a-non-mex-binding.md)
- [Пользовательская конечная точка защищенных метаданных](../../../wcf/samples/custom-secure-metadata-endpoint.md)
- [Метаданные](../../../wcf/feature-details/metadata.md)
- [Привязки](../../../wcf/bindings.md)
- [Настройка привязок, предоставляемых системой](../../../wcf/feature-details/configuring-system-provided-bindings.md)
- [Использование привязок для настройки служб и клиентов](../../../wcf/using-bindings-to-configure-services-and-clients.md)
- [\<binding>](bindings.md)

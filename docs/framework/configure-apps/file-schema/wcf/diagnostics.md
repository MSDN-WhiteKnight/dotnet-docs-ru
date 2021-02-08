---
description: 'Дополнительные сведения: <diagnostics>'
title: <diagnostics>
ms.date: 03/30/2017
ms.assetid: 0c2f95c4-cc12-4fb5-a70c-7fc6fa95db58
ms.openlocfilehash: d1651d949cdc095e630e9cde0bacbe51a5eb6062
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99782160"
---
# \<diagnostics>

Элемент `diagnostics` определяет параметры, которые могут быть использованы администратором для проверки и контроля времени выполнения.  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<system.serviceModel>**](system-servicemodel.md)\
&nbsp;&nbsp;&nbsp;&nbsp;**\<diagnostics>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<system.serviceModel>
  <diagnostics etwProviderId="String"
               performanceCounters="Off/ServiceOnly/All/Default"
               wmiProviderEnabled="Boolean">
    <endToEndTracing activityTracing="Boolean"
                     messageFlowTracing="Boolean"
                     propagateActivity="Boolean" />
    <messageLogging logEntireMessage="Boolean"
                    logMalformedMessages="Boolean"
                    logMessagesAtServiceLevel="Boolean"
                    logMessagesAtTransportLevel="Boolean"
                    maxMessagesToLog="Integer"
                    maxSizeOfMessageToLog="Integer">
      <filters>
        <clear />
      </filters>
    </messageLogging>
  </diagnostics>
</system.serviceModel>
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|etwProviderId|Строка, которая задает идентификатор для поставщика отслеживания событий, который записывает события в сеансы ETW.|  
|performanceCounters|Указывает, включены ли счетчики производительности для сборки. Допустимы следующие значения:<br /><br /> -Off: счетчики производительности отключены.<br />-Сервицеонли: включены только счетчики производительности, относящиеся к этой службе.<br />-ALL: счетчики производительности можно просматривать во время выполнения.<br />-Default: создается отдельный экземпляр счетчика производительности _WCF_Admin. Данный экземпляр используется, чтобы включить коллекцию данных SQM для использования инфраструктурой. Значения счетчика для данного экземпляра не обновляются и, соответственно, остаются нулевыми. Если для WCF не задана конфигурация, это значение используется по умолчанию.|  
|wmiProviderEnabled|Логическое значение, определяющее, включен ли поставщик WMI для сборки. Данный поставщик WMI требуется пользователю, чтобы на время выполнения получить доступ к функциональным возможностям проверки и контроля Windows Communication Foundation (WCF). Значение по умолчанию — `false`.|  
  
### <a name="child-elements"></a>Дочерние элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<endToEndTracing>](endtoendtracing.md)|Элемент конфигурации, который позволяет включать и отключать различные аспекты сквозной отслеживания во время выполнения приложения службы.|  
|[\<messageLogging>](messagelogging.md)|Описывает параметры ведения журнала сообщений WCF.|  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|serviceModel|Корневой элемент всех элементов конфигурации WCF.|  
  
## <a name="remarks"></a>Remarks  

 В разделе `diagnostics` определяются параметры диагностики для всех служб, содержащихся в сборке. Отдельные параметры диагностики можно определить на уровне службы, только если сборка содержит одну службу. Атрибуты заданы в соответствии с требованиями раздела.  
  
## <a name="example"></a>Пример  
  
```xml  
<diagnostics wmiProviderEnabled="false"
             performanceCounters="all">
  <messageLogging logEntireMessage="true"
                  logMalformedMessages="true"
                  logMessagesAtServiceLevel="true"
                  logMessagesAtTransportLevel="true"
                  maxMessagesToLog="42"
                  maxSizeOfMessageToLog="42">
    <filters>
      <clear />
    </filters>
  </messageLogging>
</diagnostics>
```  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Configuration.DiagnosticSection>
- <xref:System.ServiceModel.Diagnostics>

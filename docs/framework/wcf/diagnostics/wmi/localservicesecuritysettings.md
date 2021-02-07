---
description: 'Дополнительные сведения о: Локалсервицесекуритисеттингс'
title: LocalServiceSecuritySettings
ms.date: 03/30/2017
ms.assetid: 490aa0e5-5242-4f8d-b505-5ec6287633b4
ms.openlocfilehash: f7220e8253c6ab218414c1be7ed90e5d593b4692
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99743945"
---
# <a name="localservicesecuritysettings"></a>LocalServiceSecuritySettings

LocalServiceSecuritySettings  
  
## <a name="syntax"></a>Синтаксис  
  
```csharp
class LocalServiceSecuritySettings  
{  
  boolean DetectReplays;  
  datetime InactivityTimeout;  
  datetime IssuedCookieLifetime;  
  sint32 MaxCachedCookies;  
  datetime MaxClockSkew;  
  sint32 MaxPendingSessions;  
  sint32 MaxStatefulNegotiations;  
  datetime NegotiationTimeout;  
  boolean ReconnectTransportOnFailure;  
  sint32 ReplayCacheSize;  
  datetime ReplayWindow;  
  datetime SessionKeyRenewalInterval;  
  datetime SessionKeyRolloverInterval;  
  datetime TimestampValidityDuration;  
};  
```  
  
## <a name="methods"></a>Методы  

 Класс LocalServiceSecuritySettings не определяет никаких методов.  
  
## <a name="properties"></a>Свойства  

 Класс LocalServiceSecuritySettings имеет следующие свойства.  
  
### <a name="detectreplays"></a>DetectReplays  

 Тип данных: boolean  
  
 Тип доступа: только для чтения  
  
 Логическое значение, показывающее, будут ли атаки с повторением обнаружены и ликвидированы на канале автоматически.  
  
### <a name="inactivitytimeout"></a>InactivityTimeout  

 Тип данных: datetime  
  
 Тип доступа: только для чтения  
  
 Максимальное количество ожидающих безопасных сеансов, поддерживаемое службой.  
  
### <a name="issuedcookielifetime"></a>IssuedCookieLifetime  

 Тип данных: datetime  
  
 Тип доступа: только для чтения  
  
 Значение типа TimeSpan, которое задает время существования для всех новых файлов безопасности cookie.  
  
### <a name="maxcachedcookies"></a>MaxCachedCookies  

 Тип данных: sint32  
  
 Тип доступа: только для чтения  
  
 Максимальное количество файлов cookie, которые могут быть кэшированы.  
  
### <a name="maxclockskew"></a>MaxClockSkew  

 Тип данных: datetime  
  
 Тип доступа: только для чтения  
  
 Значение типа TimeSpan, указывающее максимальный разброс времени между системными часами взаимодействующих сторон.  
  
### <a name="maxpendingsessions"></a>MaxPendingSessions  

 Тип данных: sint32  
  
 Тип доступа: только для чтения  
  
 Максимальное количество ожидающих подключений к службе.  
  
### <a name="maxstatefulnegotiations"></a>MaxStatefulNegotiations  

 Тип данных: sint32  
  
 Тип доступа: только для чтения  
  
 Количество одновременно выполняемых согласований режима безопасности.  
  
### <a name="negotiationtimeout"></a>NegotiationTimeout  

 Тип данных: datetime  
  
 Тип доступа: только для чтения  
  
 Значение типа TimeSpan, указывающее максимальную длительность этапа согласования режима безопасности между сервером и клиентом.  
  
### <a name="reconnecttransportonfailure"></a>ReconnectTransportOnFailure  

 Тип данных: boolean  
  
 Тип доступа: только для чтения  
  
 Логическое значение, указывающее, будут ли подключения, использующие режим обмена сообщениями WS-Reliable, пытаться восстановиться после транспортных сбоев.  
  
### <a name="replaycachesize"></a>ReplayCacheSize  

 Тип данных: sint32  
  
 Тип доступа: только для чтения  
  
 Количество кэшированных параметров nonce, используемых для определения ответов.  
  
### <a name="replaywindow"></a>ReplayWindow  

 Тип данных: datetime  
  
 Тип доступа: только для чтения  
  
 Значение типа TimeSpan, которое указывает срок действия параметров nonce отдельного сообщения.  
  
### <a name="sessionkeyrenewalinterval"></a>SessionKeyRenewalInterval  

 Тип данных: datetime  
  
 Тип доступа: только для чтения  
  
 Значение типа TimeSpan, которое задает интервал времени, по истечении которого инициатор обновляет ключ сеанса безопасности.  
  
### <a name="sessionkeyrolloverinterval"></a>SessionKeyRolloverInterval  

 Тип данных: datetime  
  
 Тип доступа: только для чтения  
  
 Значение типа TimeSpan, которое задает интервал времени, указывающий период, в течение которого предыдущий сеансовый ключ остается действительным для входящих сообщений, пока выполняется обновление ключа.  
  
### <a name="timestampvalidityduration"></a>TimestampValidityDuration  

 Тип данных: datetime  
  
 Тип доступа: только для чтения  
  
 Значение типа TimeSpan, которое определяет интервал времени, указывающий срок действия отметки времени.  
  
## <a name="requirements"></a>Требования  
  
|MOF|Объявлено в файле Servicemodel.mof.|  
|---------|-----------------------------------|  
|Пространство имен|Определено в root\ServiceModel.|  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Channels.LocalServiceSecuritySettings>

---
description: 'Дополнительные сведения: <cookieHandler>'
title: <cookieHandler>
ms.date: 03/30/2017
ms.assetid: bfdc127f-8d94-4566-8bef-f583c6ae7398
author: BrucePerlerMS
ms.openlocfilehash: 036646ca5c8aaedebba9466ecb8c9232e87a773d
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99786581"
---
# \<cookieHandler>

Настраивает <xref:System.IdentityModel.Services.CookieHandler> , что <xref:System.IdentityModel.Services.SessionAuthenticationModule> (SAM) использует для чтения и записи файлов cookie.  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<system.identityModel.services>**](system-identitymodel-services.md)\
&nbsp;&nbsp;&nbsp;&nbsp;[**\<federationConfiguration>**](federationconfiguration.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<cookieHandler>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<system.identityModel.services>  
  <federationConfiguration>  
    <cookieHandler name=xs:string  
        path=Path  
        mode="Chunked||Custom||Default"  
        persistentSessionLifetime=xs:string  
        hideFromScript=xs:boolean  
        requireSSL=xs:boolean  
        domain=xs:string  
      <chunkedCookieHandler size=xs:int />  
      <customCookieHandler type="MyNamespace.MyCustomCookieHandler, MyAssembly" />  
    </cookieHandler>  
  </federationConfiguration>  
</system.identityModel.services>  
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|name|Указывает базовое имя для всех записанных файлов cookie. Значение по умолчанию — FedAuth.|  
|path|Указывает значение пути для всех записанных файлов cookie. Значение по умолчанию — HttpRuntime. Аппдомаинаппвиртуалпас.|  
|mode|Одно из <xref:System.IdentityModel.Services.CookieHandlerMode> значений, указывающее тип обработчика файлов cookie, используемый SAM. Можно использовать следующие значения:<br /><br /> -"Default" — то же, что и "фрагментированный".<br />-"Фрагментированный" — использует экземпляр <xref:System.IdentityModel.Services.ChunkedCookieHandler> класса. Этот обработчик файлов cookie гарантирует, что отдельные файлы cookie не превышают установленный максимальный размер. Это достигается за счет потенциального «фрагментирования» одного логического файла cookie в несколько файлов cookie в сети.<br />-"Custom" — использует экземпляр пользовательского класса, производного от <xref:System.IdentityModel.Services.CookieHandler> . На производный класс ссылается `<customCookieHandler>` дочерний элемент.<br /><br /> Значение по умолчанию — "по умолчанию".|  
|персистентсессионлифетиме|Указывает время существования постоянных сеансов. Если значение равно нулю, всегда используются временные сеансы. Значение по умолчанию — "0:0:0", которое указывает временный сеанс. Максимальное значение — "365:0:0", которое указывает сеанс в 365 дней. Значение должно быть указано в соответствии со следующим ограничением: `<xs:pattern value="([0-9.]+:){0,1}([0-9]+:){0,1}[0-9.]+" />` , где самое левое значение указывает дни, среднее значение (при наличии) указывает часы, а самое правое значение (при наличии) указывает минуты.|  
|requireSsl|Указывает, порождается ли флаг "Secure" для всех записанных файлов cookie. Если это значение задано, то файлы cookie сеанса входа будут доступны только по протоколу HTTPS. Значение по умолчанию - "true".|  
|хидефромскрипт|Определяет, порождается ли флаг "HttpOnly" для всех записанных файлов cookie. Некоторые веб-браузеры используют этот флаг, так как клиентский сценарий получает доступ к значению cookie. Значение по умолчанию - "true".|  
|домен|Значение домена для всех записанных файлов cookie. По умолчанию используется значение "".|  
  
### <a name="child-elements"></a>Дочерние элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<chunkedCookieHandler>](chunkedcookiehandler.md)|Настраивает <xref:System.IdentityModel.Services.ChunkedCookieHandler> . Этот элемент может присутствовать только в том случае, если `mode` атрибут `<cookieHandler>` элемента имеет значение "default" или "фрагментированный".|  
|[\<customCookieHandler>](customcookiehandler.md)|Задает тип обработчика пользовательских файлов cookie. Этот элемент должен присутствовать, если `mode` атрибут `<cookieHandler>` элемента имеет значение Custom. Он не может присутствовать ни для каких других значений `mode` атрибута. Пользовательский тип должен быть производным от <xref:System.IdentityModel.Services.CookieHandler> класса.|  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<federationConfiguration>](federationconfiguration.md)|Содержит параметры, которые настраивают свойства <xref:System.IdentityModel.Services.WSFederationAuthenticationModule> (всфам) и <xref:System.IdentityModel.Services.SessionAuthenticationModule> (SAM).|  
  
## <a name="remarks"></a>Remarks  

 Компонент <xref:System.IdentityModel.Services.CookieHandler> отвечает за чтение и запись необработанных файлов cookie на уровне протокола HTTP. Можно настроить либо <xref:System.IdentityModel.Services.ChunkedCookieHandler> пользовательский обработчик файлов cookie, производный от <xref:System.IdentityModel.Services.CookieHandler> класса.  
  
 Чтобы настроить обработчик фрагментированных файлов cookie, установите для атрибута mode значение "фрагментированный" или "по умолчанию". Размер фрагмента по умолчанию составляет 2000 байт, но при необходимости можно указать другой размер блока, включив `<chunkedCookieHandler>` дочерний элемент.  
  
 Чтобы настроить пользовательский обработчик файлов cookie, установите для атрибута mode значение Custom. Необходимо также указать `<customCookieHandler>` дочерний элемент, который ссылается на тип пользовательского обработчика.  
  
 `<cookieHandler>`Элемент представлен <xref:System.IdentityModel.Services.CookieHandlerElement> классом. Обработчик файлов cookie, указанный в конфигурации, доступен из <xref:System.IdentityModel.Services.Configuration.FederationConfiguration.CookieHandler%2A> свойства <xref:System.IdentityModel.Services.Configuration.FederationConfiguration> объекта, установленного для <xref:System.IdentityModel.Services.FederatedAuthentication.FederationConfiguration%2A?displayProperty=nameWithType> Свойства.  
  
## <a name="example"></a>Пример  

 В следующем коде XML показан `<cookieHandler>` элемент. В этом примере, поскольку `mode` атрибут не задан, SAM будет использовать обработчик файлов cookie по умолчанию. Это экземпляр <xref:System.IdentityModel.Services.ChunkedCookieHandler> класса. Так как `<chunkedCookieHandler>` дочерний элемент не указан, будет использоваться размер фрагмента данных по умолчанию. Протокол HTTPS не будет требоваться, поскольку `requireSsl` задан атрибут `false` .  
  
> [!WARNING]
> В этом примере протокол HTTPS не требуется для записи файлов cookie сеанса. Это обусловлено тем, что `requireSsl` атрибут `<cookieHandler>` элемента имеет значение `false` . Этот параметр не рекомендуется для большинства рабочих сред, так как может представлять угрозу безопасности.  
  
```xml  
<cookieHandler requireSsl="false" />  
```  
  
## <a name="see-also"></a>См. также

- <xref:System.IdentityModel.Services.CookieHandler>
- <xref:System.IdentityModel.Services.ChunkedCookieHandler>
- <xref:System.IdentityModel.Services.SessionAuthenticationModule>

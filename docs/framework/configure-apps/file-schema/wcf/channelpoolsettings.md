---
description: 'Дополнительные сведения: <channelPoolSettings>'
title: <channelPoolSettings>
ms.date: 03/30/2017
ms.assetid: 4755f3d3-4213-4c68-ae7f-45b67d744459
ms.openlocfilehash: 85220cac360aaf32195c0b0f1d2866729e11c442
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99638981"
---
# \<channelPoolSettings>

Задает параметры пула каналов для пользовательской привязки.  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<system.serviceModel>**](system-servicemodel.md)\
&nbsp;&nbsp;&nbsp;&nbsp;[**\<bindings>**](bindings.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<customBinding>**](custombinding.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<binding>**\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<oneWay>**](oneway.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<channelPoolSettings>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<channelPoolSettings idleTimeout="TimeSpan"
                     leaseTimeout="TimeSpan"
                     maxOutboundConnectionsPerEndpoint="Integer" />
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|`idleTimeout`|Положительное значение <xref:System.TimeSpan>, указывающее максимальное время бездействия канала в пуле перед отключением. Значение по умолчанию - 00:02:00.|  
|`leaseTimeout`|Значение <xref:System.TimeSpan>, которое задает интервал времени, после которого канал закрывается при возвращении в пул. Значение по умолчанию - 00:10:00.|  
|`maxOutboundChannelsPerEndpoint`|Положительное целое число, задающее максимальное количество каналов, которое можно хранить в пуле для каждой удаленной конечной точки. Значение по умолчанию равно 10.|  
  
### <a name="child-elements"></a>Дочерние элементы  

 Отсутствует.  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<oneWay>](oneway.md)|Включает маршрутизацию пакетов для пользовательской привязки.|  
  
## <a name="remarks"></a>Remarks  

 Квоты используются как механизм политики, служащий для предотвращения чрезмерного потребления ресурсов. Они препятствуют злонамеренным или неумышленным атакам типа «отказ в обслуживании» (DoS). Этот элемент используется при установке квот на пользовательском канале.  
  
 `ChannelPoolSettings` задает три квоты.  
  
- Квота `idleTimeout` используется для ослабления эффекта атак типа «отказ в обслуживании» (DoS) на сервере, при котором ресурсы блокируются на продолжительный период времени. На клиенте установка правильного значения может повысить надежность соединения со службой. Значение по умолчанию основано на консервативно умеренном выделении ресурсов. Это подходит для среды разработки и небольших сценариев установок. Администраторы должны обновлять значение, если данной установке начинает не хватать ресурсов или если число подключений ограничено, несмотря на доступность дополнительных ресурсов.  
  
- Квота `leaseTimeout` используется для интеграции с механизмами балансировки нагрузки и для повышения надежности. Значение по умолчанию основано на консервативном выделении ресурсов. Это подходит для среды разработки и небольших сценариев установок. Администраторы должны обновлять значение, если данной установке начинает не хватать ресурсов или если число подключений ограничено, несмотря на доступность дополнительных ресурсов.  
  
- Квота `maxOutboundChannelsPerEndpoint` устанавливает предельные значения кэша на сервере и на клиенте и используется для повышения надежности. Значение по умолчанию основано на консервативно умеренном выделении ресурсов, которое подходит для среды разработки и небольших установок. Администраторы должны обновлять значение, если данной установке начинает не хватать ресурсов или если число подключений ограничено, несмотря на доступность дополнительных ресурсов.  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Channels.OneWayBindingElement.ChannelPoolSettings%2A>
- <xref:System.ServiceModel.Channels.ChannelPoolSettings>
- <xref:System.ServiceModel.Configuration.OneWayElement.ChannelPoolSettings%2A>
- <xref:System.ServiceModel.Configuration.ChannelPoolSettingsElement>
- <xref:System.ServiceModel.Channels.CustomBinding>
- [\<oneWay>](oneway.md)
- [Привязки](../../../wcf/bindings.md)
- [Расширение привязок](../../../wcf/extending/extending-bindings.md)
- [Пользовательские привязки](../../../wcf/extending/custom-bindings.md)
- [\<customBinding>](custombinding.md)

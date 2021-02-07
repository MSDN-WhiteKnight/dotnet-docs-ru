---
description: 'Дополнительные сведения <udpTransportSettings> о: <udpAnnouncementEndpoint>'
title: <udpTransportSettings> из <udpAnnouncementEndpoint>
ms.date: 03/30/2017
ms.assetid: a7ddff1a-5eed-4bbc-8580-b95ef8890e1f
ms.openlocfilehash: 2997004e162728b20daa4f137e1edf132cd33d52
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99749211"
---
# <a name="udptransportsettings-of-udpannouncementendpoint"></a>\<udpTransportSettings> из \<udpAnnouncementEndpoint>

Этот элемент конфигурации предоставляет параметры транспорта UDP для [\<udpAnnouncementEndpoint>](udpannouncementendpoint.md) .  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<system.serviceModel>**](system-servicemodel.md)\
&nbsp;&nbsp;&nbsp;&nbsp;[**\<standardEndpoints>**](standardendpoints.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<udpAnnouncementEndpoint>**](udpannouncementendpoint.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<updTransportSettings>**  

## <a name="syntax"></a>Синтаксис  
  
```xml  
<system.serviceModel>
  <standardEndpoints>
    <udpAnnouncementEndpoint>
      <standardEndpoint>
        <updTransportSettings duplicateMessageHistoryLength="Integer"
                              maxBufferPoolSize="Integer"
                              maxMulticastRetransmitCount="Integer"
                              maxPendingMessageCount="Integer"
                              maxReceivedMessageSize="Integer"
                              maxUnicastRetransmitCount="Integer"
                              multicastInterfaceId="String"
                              socketReceiveBufferSize="Integer"
                              timeToLive="Integer" />
      </standardEndpoint>
    </udpAnnouncementEndpoint>
  </standardEndpoints>
</system.serviceModel>
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|duplicateMessageHistoryLength|Целое число, указывающее максимальное количество хэшей сообщений, используемых транспортом для идентификации повторяющихся сообщений.  Обнаружение повторяющихся сообщений выполняется на уровне TransportManager. Если этому свойству задать значение 0, обнаружение повторяющихся сообщений будет отключено.<br /><br /> Этот атрибут позволяет системным администраторам и разработчикам выключать алгоритмы обнаружения повторяющихся сообщений. Это полезно, если требуется реализовать собственный алгоритм обнаружения повторяющихся сообщений.<br /><br /> Значение по умолчанию — 4112.|  
|maxBufferPoolSize|Целое число, задающее максимальный размер буферных пулов, используемых транспортом.|  
|maxMulticastRetransmitCount|Целое число, задающее максимальное число отправок сообщения (помимо первой отправки).<br /><br /> Значение по умолчанию — 2|  
|maxPendingMessageCount|Целое число, задающее для отдельно взятого экземпляра канала максимальное число сообщений, полученных, но еще не удаленных из очереди InputQueue.  Если очередь InputQueue достигает верхнего предела числа ожидающих сообщений, сообщение будет сброшено.<br /><br /> Значение по умолчанию — 32.|  
|maxReceivedMessageSize|Целое число, указывающее максимальный размер сообщения, которое может быть обработано привязкой.<br /><br /> Значение по умолчанию — 65507.|  
|maxUnicastRetransmitCount|Целое число, задающее максимальное число отправок сообщения (помимо первой отправки).  Если сообщение отправлено по адресу одноадресной рассылки и получено ответное сообщение с соответствующим заголовком RelatesTo, повторная передача может завершиться рано (до того, как будет повторно отправлено заданное число сообщений).<br /><br /> Значение по умолчанию — 1.|  
|multicastInterfaceId|Строка, служащая уникальным идентификатором сетевого адаптера, который должен использоваться при отправке и получении многоадресного трафика на многосетевых компьютерах. Во время выполнения транспорт использует это значение атрибута для поиска индекса интерфейса, который, в свою очередь, используется для установки параметров сокета `IP_MULTICAST_IF` и `IPV6_MULTICAST_IF`.  Этот же индекс интерфейса, если это применимо, используется при присоединении к многоадресной группе.<br /><br /> Значение по умолчанию — `null`.|  
|socketReceiveBufferSize|Целое число, задающее максимальный размер буфера получения в базовом сокете WinSock.<br /><br /> Пользователь канала получения может использовать этот атрибут на привязке для управления поведением системы при получении данных.  Например, если приложение получает максимальное количество входящих сообщений WCF, то использование большего значения для этого атрибута позволит сообщениям накапливаться в буфере WinSock в ожидании обработки со стороны приложения.  А использование меньшего значения в схожей ситуации приведет к удалению сообщений. Этот атрибут открывает доступ к базовому параметру сокета WinSock `SO_RCVBUF`. Значение этого атрибута должно быть, как минимум, равно размеру `maxReceivedMessageSize`.   Если задать атрибуту значение, меньшее, чем `maxReceivedMessageSize`, то во время выполнения возникнет исключение.<br /><br /> Значение по умолчанию — 65536.|  
|timeToLive|Целое число, указывающее количество прыжков между сетевыми сегментами, которые может выполнить многоадресный пакет.  Этот атрибут предоставляет функции, связанные с параметрами сокета `IP_MULTICAST_TTL` и `IP_TTL`.<br /><br /> Значение по умолчанию — 1.|  
  
### <a name="child-elements"></a>Дочерние элементы  

 Отсутствует.  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<udpAnnouncementEndpoint>](udpannouncementendpoint.md)|Стандартная конечная точка, имеющая фиксированный контракт объявления и транспортную привязку UDP.|  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Discovery.UdpTransportSettings>

---
description: 'Дополнительные сведения: <tcpTransport>'
title: <tcpTransport>
ms.date: 03/30/2017
ms.assetid: 8fcd18c1-9958-42e7-b442-7903f7bdb563
ms.openlocfilehash: b660443ac58e8ed72d70adb5bf9e9e87b060e3af
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99786620"
---
# \<tcpTransport>

Определяет транспорт TCP, который может использоваться каналом для передачи сообщений для пользовательской привязки.  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<system.serviceModel>**](system-servicemodel.md)\
&nbsp;&nbsp;&nbsp;&nbsp;[**\<bindings>**](bindings.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<customBinding>**](custombinding.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<binding>**\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<tcpTransport>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<tcpTransport channelInitializationTimeout="TimeSpan"
              connectionBufferSize="Integer"
              hostNameComparisonMode="StrongWildcard/Exact/WeakWildcard"
              listenBacklog="Integer"
              manualAddressing="Boolean"
              maxBufferPoolSize="Integer"
              maxBufferSize="Integer"
              maxOutputDelay="TimeSpan"
              maxPendingAccepts="Integer"
              maxPendingConnections="Integer"
              maxReceivedMessageSize="Integer"
              portSharingEnabled="Boolean"
              teredoEnabled="Boolean"
              transferMode="Buffered/Streamed/StreamedRequest/StreamedResponse" >
  <connectionPoolSettings groupName="String"
                          idleTimeout="TimeSpan"
                          leaseTimeout="TimeSpan"
                          maxOutboundConnectionsPerEndpoint="Integer" />
</tcpTransport>
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|channelInitializationTimeout|Возвращает или задает ограничение по времени для приема инициализации канала.  Максимальное время в секундах, в течение которого канал может находиться в состоянии инициализации, прежде чем будет отключен. Эта квота включает в себя время, которое TCP-подключение может пройти для проверки подлинности с помощью протокола кадрирования сообщений .NET. Клиенту необходимо отправить некоторые исходные данные, прежде чем сервер получит достаточно сведений для аутентификации. По умолчанию это 30 секунд.|  
|коннектионбуфферсизе|Возвращает или задает размер буфера, используемого для передачи фрагмента сериализованного сообщения от клиента серверу по сети.|  
|hostNameComparisonMode|Возвращает или задает значение, указывающее, используется ли имя узла для доступа к службе при сопоставлении по универсальному коду ресурса (URI).|  
|listenBacklog|Максимальное количество запросов на соединение в очереди, которые могут ожидать обработки веб-службой. Атрибут `connectionLeaseTimeout` ограничивает время ожидания подключения клиентом до создания исключения подключения. Это свойство уровня сокетов, которое определяет максимальное количество запросов на подключение в очереди, которые могут ожидать обработки веб-службой. Если Листенбакклог имеет слишком малое значение, WCF перестанет принимать запросы и, следовательно, удалит новые подключения, пока сервер не подтвердит некоторые существующие соединения в очереди. Значение по умолчанию — 16 * число процессоров.|  
|manualAddressing|Возвращает или задает значение, показывающее, требуется ли создание адреса сообщения вручную.|  
|maxBufferPoolSize|Возвращает или задает максимальное значение буферных пулов, используемых транспортом.|  
|maxBufferSize|Возвращает или задает максимальный размер используемого буфера. Для потоковых сообщений это значение не должно быть меньше максимального возможного размера заголовков сообщения, считываемых в режиме буферизации.|  
|максаутпутделай|Возвращает или задает максимальный промежуток времени, в течение которого фрагмент сообщения или все сообщение может оставаться в буфере перед отправкой.|  
|maxPendingAccepts|Возвращает или задает максимальное число ожидающих асинхронных операций приема, доступных для обработки входящих подключений к службе.|  
|maxPendingConnections|Возвращает или задает максимальное число подключений, ожидающих распределения в службе.|  
|maxReceivedMessageSize|Возвращает и задает максимально допустимый размер принимаемого сообщения.|  
|portSharingEnabled|Логическое значение, определяющее, включено ли совместное использование порта TCP для этого подключения. Если атрибут имеет значение `false`, каждая привязка будет использовать уникальный порт. Значение по умолчанию — `false`.<br /><br /> Этот параметр действителен только для служб. Клиенты не затрагиваются.<br /><br /> Использование этого параметра требует включения службы общего доступа к портам TCP Windows Communication Foundation (WCF) путем изменения типа запуска на «Вручную» или «Авто».|  
|teredoEnabled|Логическое значение, указывающее, используется ли Teredo (технология адресации клиентов, защищенных брандмауэром). Значение по умолчанию — `false`.<br /><br /> Это свойство включает использование Teredo для базового сокета TCP. Дополнительные сведения см. в разделе [Общие сведения о Teredo](/previous-versions/windows/it-pro/windows-xp/bb457011(v=technet.10)).<br /><br /> Это свойство применимо только в Windows XP с пакетом обновления 2 (SP2) и Windows Server 2003. В Windows Vista используется параметр конфигурации на уровне компьютера для Teredo, поэтому при запуске Vista это свойство игнорируется. Для Teredo необходимо, чтобы на компьютере, где работает служба, и на компьютере-клиенте был установлен и настроен правильно для использования Teredo стек протокола Microsoft IPv6.|  
|transferMode|Возвращает или задает значение, указывающее, следует ли помещать сообщения в буфер или передавать их потоком с использованием транспорта, ориентированного на подключение.|  
|connectionPoolSettings|Задает дополнительные параметры пула подключений для привязки именованного канала.|  
  
### <a name="child-elements"></a>Дочерние элементы  

 None  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<binding>](bindings.md)|Определяет все возможности пользовательской привязки.|  
  
## <a name="remarks"></a>Remarks  

 Этот транспорт использует универсальные коды ресурсов (URI) вида net.tcp://hostname:port/path. Другие элементы универсального кода ресурса (URI) не обязательны.  
  
 Элемент `tcpTransport` является начальной точкой для создания пользовательской привязки, реализующей транспортный протокол TCP. Этот транспорт оптимизирован для взаимодействия между службами WCF.  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Configuration.TcpTransportElement>
- <xref:System.ServiceModel.Channels.TcpTransportBindingElement>
- <xref:System.ServiceModel.Channels.TransportBindingElement>
- <xref:System.ServiceModel.Channels.CustomBinding>
- [Транспорты](../../../wcf/feature-details/transports.md)
- [Выбор транспортов](../../../wcf/feature-details/choosing-a-transport.md)
- [Привязки](../../../wcf/bindings.md)
- [Расширение привязок](../../../wcf/extending/extending-bindings.md)
- [Пользовательские привязки](../../../wcf/extending/custom-bindings.md)
- [\<customBinding>](custombinding.md)

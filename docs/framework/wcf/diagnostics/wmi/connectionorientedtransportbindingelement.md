---
description: 'Дополнительные сведения о: Коннектионориентедтранспортбиндинжелемент'
title: ConnectionOrientedTransportBindingElement
ms.date: 03/30/2017
ms.assetid: c1308313-f0e2-49e6-977d-6b4ce9ad35d1
ms.openlocfilehash: bd0c05fc86ad7bc95837cee7e22ea83975369b62
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99757583"
---
# <a name="connectionorientedtransportbindingelement"></a>ConnectionOrientedTransportBindingElement

ConnectionOrientedTransportBindingElement  
  
## <a name="syntax"></a>Синтаксис  
  
```csharp
class ConnectionOrientedTransportBindingElement : TransportBindingElement  
{  
  datetime ChannelInitializationTimeout;  
  sint32 ConnectionBufferSize;  
  string HostNameComparisonMode;  
  sint32 MaxBufferSize;  
  datetime MaxOutputDelay;  
  sint32 MaxPendingAccepts;  
  sint32 MaxPendingConnections;  
  string TransferMode;  
};  
```  
  
## <a name="methods"></a>Методы  

 Класс ConnectionOrientedTransportBindingElement не определяет никакие методы.  
  
## <a name="properties"></a>Свойства  

 Класс ConnectionOrientedTransportBindingElement имеет следующие свойства.  
  
### <a name="channelinitializationtimeout"></a>ChannelInitializationTimeout  

 Тип данных: datetime  
  
 Тип доступа: только для чтения  
  
 Задает интервал времени, который выделяется для инициализации канала до возникновения тайм-аута.  
  
### <a name="connectionbuffersize"></a>ConnectionBufferSize  

 Тип данных: sint32  
  
 Тип доступа: только для чтения  
  
 Размер буфера, используемого для передачи по сети фрагмента сериализованного сообщения от клиента серверу.  
  
### <a name="hostnamecomparisonmode"></a>HostNameComparisonMode  

 Тип данных: строка  
  
 Тип доступа: только для чтения  
  
 Значение, указывающее, используется ли имя узла для доступа к службе при сопоставлении по универсальному коду ресурса (URI).  
  
### <a name="maxbuffersize"></a>MaxBufferSize  

 Тип данных: sint32  
  
 Тип доступа: только для чтения  
  
 Максимально используемый размер буфера.  
  
### <a name="maxoutputdelay"></a>MaxOutputDelay  

 Тип данных: datetime  
  
 Тип доступа: только для чтения  
  
 Максимальный промежуток времени, в течение которого фрагмент сообщения или все сообщение может оставаться в буфере перед отправкой.  
  
### <a name="maxpendingaccepts"></a>MaxPendingAccepts  

 Тип данных: sint32  
  
 Тип доступа: только для чтения  
  
 Максимальное число ожидающих асинхронных потоков приема, доступных для обработки входящих подключений к службе.  
  
### <a name="maxpendingconnections"></a>MaxPendingConnections  

 Тип данных: sint32  
  
 Тип доступа: только для чтения  
  
 Максимальное количество ожидающих подключений.  
  
### <a name="transfermode"></a>TransferMode  

 Тип данных: строка  
  
 Тип доступа: только для чтения  
  
 Значение, указывающее, следует ли буферизировать сообщения, или передавать их потоком с использованием транспорта, ориентированного на подключения.  
  
## <a name="requirements"></a>Требования  
  
|MOF|Объявлено в файле Servicemodel.mof.|  
|---------|-----------------------------------|  
|Пространство имен|Определено в root\ServiceModel.|  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Channels.ConnectionOrientedTransportBindingElement>

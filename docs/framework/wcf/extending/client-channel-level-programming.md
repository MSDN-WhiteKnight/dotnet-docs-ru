---
description: 'Дополнительные сведения: программирование Channel-Level клиента'
title: Программирование клиентов на уровне канала
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: 3b787719-4e77-4e77-96a6-5b15a11b995a
ms.openlocfilehash: 7e4e977231339fbbede7111e38a67054eb24eed9
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99803000"
---
# <a name="client-channel-level-programming"></a>Программирование клиентов на уровне канала

В этом разделе описывается Написание клиентского приложения Windows Communication Foundation (WCF) без использования <xref:System.ServiceModel.ClientBase%601?displayProperty=nameWithType> класса и связанной с ним объектной модели.  
  
## <a name="sending-messages"></a>отправка сообщений  

 Чтобы подготовиться к отправке сообщений и получению и обработке ответов, необходимы следующие действия.  
  
1. Создайте привязку.  
  
2. Создайте фабрику каналов.  
  
3. Создание канала.  
  
4. Отправьте запрос и прочитайте ответ.  
  
5. Закройте все объекты каналов.  
  
#### <a name="creating-a-binding"></a>Создание привязки  

 Как и в случае с получением (см. [службу Channel-Level программирование](service-channel-level-programming.md)), отправка сообщений начинается с создания привязки. В данном примере создается новая привязка <xref:System.ServiceModel.Channels.CustomBinding?displayProperty=nameWithType>, и в коллекцию ее элементов добавляется элемент <xref:System.ServiceModel.Channels.HttpTransportBindingElement?displayProperty=nameWithType>.  
  
#### <a name="building-a-channelfactory"></a>Создание фабрики каналов  

 На этот раз вместо того чтобы создавать прослушиватель каналов <xref:System.ServiceModel.Channels.IChannelListener?displayProperty=nameWithType>, следует создать производство каналов <xref:System.ServiceModel.ChannelFactory%601?displayProperty=nameWithType> вызовом метода <xref:System.ServiceModel.ChannelFactory.CreateFactory%2A?displayProperty=nameWithType> в привязке с параметром типа <xref:System.ServiceModel.Channels.IRequestChannel?displayProperty=nameWithType>. Прослушиватели каналов используются ожидающей входящих сообщений стороной, а фабрики каналов - стороной, которая инициирует связь для создания канала. Точно так же, как при работе с прослушивателями каналов, фабрики каналов можно использовать только после того, как они будут открыты.  
  
#### <a name="creating-a-channel"></a>Создание канала  

 Затем, чтобы создать канал <xref:System.ServiceModel.ChannelFactory%601.CreateChannel%2A?displayProperty=nameWithType>, необходимо вызвать метод <xref:System.ServiceModel.Channels.IRequestChannel>. Этот вызов принимает адрес конечной точки, с которой необходимо установить связь, используя вновь создаваемый канал. После создания канала необходимо вызвать для него функцию "Открыть", чтобы подготовить его к взаимодействию. В зависимости от особенностей транспорта подобный вызов функции "Открыть" может инициировать соединение с целевой конечной точкой или не выполнить никаких действий в сети.  
  
#### <a name="sending-a-request-and-reading-the-reply"></a>Отправка запроса и чтение ответа  

 После открытия канала можно создать сообщение, воспользоваться методом запроса канала для отправки запроса и ожидать ответа. По возвращении этого метода приходит ответное сообщение, прочитав которое, можно узнать, каков был ответ конечной точки.  
  
#### <a name="closing-objects"></a>Закрытие объектов  

 Во избежание утечки ресурсов следует закрывать объекты, используемые во взаимодействии, если они больше не требуются.  
  
 В следующем примере кода показан основной клиент, использующий фабрику каналов для отправки сообщения и чтения ответа.  
  
 [!code-csharp[ChannelProgrammingBasic#2](../../../../samples/snippets/csharp/VS_Snippets_CFX/channelprogrammingbasic/cs/clientprogram.cs#2)]
 [!code-vb[ChannelProgrammingBasic#2](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/channelprogrammingbasic/vb/clientprogram.vb#2)]

---
description: 'Дополнительные сведения: программирование Channel-Level служб'
title: Программирование служб на уровне канала
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: 8d8dcd85-0a05-4c44-8861-4a0b3b90cca9
ms.openlocfilehash: 9d89b073430ccdf80bdcbdfc50fd1e002fc807ff
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99644065"
---
# <a name="service-channel-level-programming"></a>Программирование служб на уровне канала

В этом разделе описывается написание приложения службы Windows Communication Foundation (WCF) без использования <xref:System.ServiceModel.ServiceHost?displayProperty=nameWithType> и связанной с ним объектной модели.  
  
## <a name="receiving-messages"></a>получение сообщений  

 Для того чтобы подготовиться к получению и обработке сообщений, необходимо выполнить следующие действия.  
  
1. Создайте привязку.  
  
2. Создайте прослушиватель каналов.  
  
3. Откройте прослушиватель каналов.  
  
4. Прочтите запрос и отправьте ответ.  
  
5. Закройте все объекты каналов.  
  
#### <a name="creating-a-binding"></a>Создание привязки  

 Первым шагом для прослушивания и получения сообщений является создание привязки. WCF поставляется с несколькими встроенными или предоставляемыми системой привязками, которые можно использовать непосредственно, создавая один из них. Кроме того, всегда можно создать собственную пользовательскую привязку, создав класс CustomBinding, что и делает код в примере 1.  
  
 Пример кода, показанный ниже, создает экземпляр класса <xref:System.ServiceModel.Channels.CustomBinding?displayProperty=nameWithType> и добавляет элемент <xref:System.ServiceModel.Channels.HttpTransportBindingElement?displayProperty=nameWithType> в его коллекцию элементов, то есть коллекцию элементов привязки, используемую для построения стека канала. Поскольку коллекция элементов в этом примере состоит только из экземпляров класса <xref:System.ServiceModel.Channels.HttpTransportBindingElement>, у получившегося стека канала имеется только канал транспорта HTTP.  
  
#### <a name="building-a-channellistener"></a>Создание прослушивателя каналов  

 После создания привязки вызывается метод <xref:System.ServiceModel.Channels.Binding.BuildChannelListener%2A?displayProperty=nameWithType>, с помощью которого создается прослушиватель канала, параметр Type которого указывает форму создаваемого канала. В этом примере используется интерфейс <xref:System.ServiceModel.Channels.IReplyChannel?displayProperty=nameWithType>, поскольку требуется ожидать передачи данных для входящих сообщений в рамках шаблона обмена сообщениями запрос-ответ.  
  
 Интерфейс <xref:System.ServiceModel.Channels.IReplyChannel> используется для приема сообщений запросов и отправки обратно сообщений ответов. Вызов метода <xref:System.ServiceModel.Channels.IReplyChannel.ReceiveRequest%2A?displayProperty=nameWithType> возвращает интерфейс <xref:System.ServiceModel.Channels.IRequestChannel?displayProperty=nameWithType>, с помощью которого можно принимать сообщения запросов и отправлять обратно сообщения ответов.  
  
 При создании прослушивателя передается сетевой адрес, на котором он ожидает передачи данных, в данном случае `http://localhost:8080/channelapp`. В общем случае каждый канал транспорта поддерживает одну или, возможно, несколько схем адресов, например HTTP-транспорт поддерживает как схему HTTP, так и HTTPS.  
  
 Также при создании прослушивателя передается пустая коллекция <xref:System.ServiceModel.Channels.BindingParameterCollection?displayProperty=nameWithType>. Параметр привязки - механизм передачи параметра, который определяет, как будет устроен прослушиватель. В нашем примере параметры такого рода не используются, поэтому передается пустая коллекция.  
  
#### <a name="listening-for-incoming-messages"></a>Ожидание передачи входящих сообщений  

 Затем вызывается метод прослушивателя <xref:System.ServiceModel.ICommunicationObject.Open%2A?displayProperty=nameWithType> и запускается прием каналов. Поведение метода <xref:System.ServiceModel.Channels.IChannelListener%601.AcceptChannel%2A?displayProperty=nameWithType> зависит от того, использует транспорт подключения или нет. В случае транспортов, использующих подключения, метод <xref:System.ServiceModel.Channels.IChannelListener%601.AcceptChannel%2A> блокируется до тех пор, пока не поступит запрос на новое соединение; в этот момент он возвращает новый канал, представляющий новое соединение. Для транспортов, не использующих подключение, например HTTP, метод <xref:System.ServiceModel.Channels.IChannelListener%601.AcceptChannel%2A> немедленно возвращает один и единственный канал, созданный прослушивателем транспорта.  
  
 В данном примере прослушиватель возвращает канал, реализующий интерфейс <xref:System.ServiceModel.Channels.IReplyChannel>. Для получения сообщений на этом канале в первую очередь необходимо вызвать для него метод <xref:System.ServiceModel.ICommunicationObject.Open%2A?displayProperty=nameWithType>, чтобы перевести его в состояние готовности к взаимодействию. Затем вызвать метод <xref:System.ServiceModel.Channels.IReplyChannel.ReceiveRequest%2A>, который блокируется до прибытия сообщения.  
  
#### <a name="reading-the-request-and-sending-a-reply"></a>Чтение запроса и отправка ответа  

 Когда метод <xref:System.ServiceModel.Channels.IReplyChannel.ReceiveRequest%2A> возвращает объект <xref:System.ServiceModel.Channels.RequestContext>, можно получить принятое сообщение из его свойства <xref:System.ServiceModel.Channels.RequestContext.RequestMessage%2A>. Можно сохранить действие сообщения и содержимое его тела (предполагая, что это строка).  
  
 Для отправки ответа создается новое сообщение, в данном случае передающее обратно строковые данные, полученные в запросе. Затем вызывается метод <xref:System.ServiceModel.Channels.RequestContext.Reply%2A> для отправки ответного сообщения.  
  
#### <a name="closing-objects"></a>Закрытие объектов  

 Во избежание утечки ресурсов очень важно закрывать объекты, используемые во взаимодействии, если они больше не требуются. В данном примере закрываются сообщение запроса, контекст запроса, канал и прослушиватель.  
  
 В следующем примере показана базовая служба: прослушиватель канала принимает одно сообщение. Реальная служба продолжает прием каналов и получение сообщений до своего завершения.  
  
 [!code-csharp[ChannelProgrammingBasic#1](../../../../samples/snippets/csharp/VS_Snippets_CFX/channelprogrammingbasic/cs/serviceprogram.cs#1)]
 [!code-vb[ChannelProgrammingBasic#1](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/channelprogrammingbasic/vb/serviceprogram.vb#1)]

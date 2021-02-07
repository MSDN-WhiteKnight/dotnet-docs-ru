---
description: 'Дополнительные сведения: создание элемента BindingElement'
title: Создание элемента привязки BindingElement
ms.date: 03/30/2017
ms.assetid: 01a35307-a41f-4ef6-a3db-322af40afc99
ms.openlocfilehash: de5ef045f2e83985cabd36c53652d46536889fa2
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99735430"
---
# <a name="creating-a-bindingelement"></a>Создание элемента привязки BindingElement

Привязки и элементы привязки (объекты, которые расширяют <xref:System.ServiceModel.Channels.Binding?displayProperty=nameWithType> и <xref:System.ServiceModel.Channels.BindingElement?displayProperty=nameWithType> , соответственно) — это место, где модель приложения Windows Communication Foundation (WCF) связана с фабриками каналов и прослушивателями каналов. Без привязок для использования пользовательских каналов требуется программирование на уровне канала, как описано в разделе [сервис Channel-Level программирование](service-channel-level-programming.md) и [программирование клиентских Channel-Level](client-channel-level-programming.md). В этом разделе обсуждаются минимальные требования для включения использования канала в WCF, разработки <xref:System.ServiceModel.Channels.BindingElement> для канала и включения использования из приложения, как описано в шаге 4 раздела [Разработка каналов](developing-channels.md).  
  
## <a name="overview"></a>Обзор  

 Создание <xref:System.ServiceModel.Channels.BindingElement> для канала позволяет разработчикам использовать его в приложении WCF. <xref:System.ServiceModel.Channels.BindingElement> объекты можно использовать из <xref:System.ServiceModel.ServiceHost?displayProperty=nameWithType> класса для подключения приложения WCF к каналу без необходимости точной информации о типе канала.  
  
 После <xref:System.ServiceModel.Channels.BindingElement> создания можно включить дополнительные функциональные возможности в зависимости от требований, следуя оставшимся шагам разработки канала, описанным в разделе [Разработка каналов](developing-channels.md).  
  
## <a name="adding-a-binding-element"></a>Добавление элемента привязки  

 Чтобы реализовать настраиваемый элемент <xref:System.ServiceModel.Channels.BindingElement>, напишите класс, наследуемый от <xref:System.ServiceModel.Channels.BindingElement>. Например, если разработан канал `ChunkingChannel`, который может разделять большие сообщения на блоки и восстанавливать сообщения на другой стороне, этот канал можно использовать в любой привязке, реализуя элемент <xref:System.ServiceModel.Channels.BindingElement> и настраивая привязку для использования этого элемента. Далее в этом разделе канал `ChunkingChannel` используется в качестве примера для демонстрации требований к реализации элемента привязки.  
  
 Элемент `ChunkingBindingElement` отвечает за создание фабрики `ChunkingChannelFactory` и прослушивателя `ChunkingChannelListener`. Он переопределяет реализации <xref:System.ServiceModel.Channels.BindingElement.CanBuildChannelFactory%2A> и <xref:System.ServiceModel.Channels.BindingElement.CanBuildChannelListener%2A> и проверяет, что параметром типа является <xref:System.ServiceModel.Channels.IDuplexSessionChannel> (в данном примере это единственная форма канала, поддерживаемая каналом `ChunkingChannel`) и что другие элементы привязки поддерживают эту форму канала.  
  
 <xref:System.ServiceModel.Channels.BindingElement.BuildChannelFactory%2A> сначала проверяет возможность создания затребованной формы канала, затем получает список действий, которые должны быть выполнены для разделения сообщения на блоки, после чего создает новую фабрику `ChunkingChannelFactory`, передавая ее фабрике внутреннего канала. (В случае создания элемента привязки транспорта этот элемент является последним элементом в стеке привязок и, следовательно, должен создать прослушиватель канала или фабрику канала).  
  
 <xref:System.ServiceModel.Channels.BindingElement.BuildChannelListener%2A> имеет аналогичную реализацию для создания прослушивателя `ChunkingChannelListener` и передаче его прослушивателю внутреннего канала.  
  
 В качестве другого примера использования транспортного канала образец [Transport: UDP](../samples/transport-udp.md) обеспечивает следующее переопределение.  
  
 В этом примере в качестве элемента привязки выступает элемент `UdpTransportBindingElement`, являющийся производным элемента <xref:System.ServiceModel.Channels.TransportBindingElement>. Он переопределяет следующие методы для создания фабрик, связанных с каналом.  
  
```csharp  
public IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context)  
{  
    return (IChannelFactory<TChannel>)(object)new UdpChannelFactory(this, context);  
}  
  
public IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context)  
{  
    return (IChannelListener<TChannel>)(object)new UdpChannelListener(this, context);  
}  
```  
  
 Он также содержит члены для клонирования элемента `BindingElement` и возврата схемы (soap.udp).  
  
#### <a name="protocol-binding-elements"></a>Элементы привязки протоколов  

 Новые элементы привязки могут заменять или дополнять любые из включенных элементов привязки, добавляя новые типы транспорта, кодирования или протоколы верхних уровней. Чтобы создать новый элемент привязки протокола, начните с расширения класса <xref:System.ServiceModel.Channels.BindingElement>. Как минимум, необходимо реализовать <xref:System.ServiceModel.Channels.BindingElement.Clone%2A?displayProperty=nameWithType> и реализовать `ChannelProtectionRequirements` с помощью <xref:System.ServiceModel.Channels.IChannel.GetProperty%2A?displayProperty=nameWithType> . В результате будут возвращены требования <xref:System.ServiceModel.Security.ChannelProtectionRequirements> для этого элемента привязки.  Для получения дополнительной информации см. <xref:System.ServiceModel.Security.ChannelProtectionRequirements>.  
  
 Метод <xref:System.ServiceModel.Channels.BindingElement.Clone%2A> должен вернуть новую копию данного элемента привязки. Авторам элемента привязки рекомендуется реализовать метод <xref:System.ServiceModel.Channels.BindingElement.Clone%2A>, используя конструктор копии, который вызывает базовый конструктор копии и затем клонирует любые дополнительные поля в этом классе.  
  
#### <a name="transport-binding-elements"></a>Элементы привязки транспорта  

 Чтобы создать новый элемент привязки транспорта, расширьте интерфейс <xref:System.ServiceModel.Channels.TransportBindingElement>. Затем, как минимум, необходимо реализовать метод <xref:System.ServiceModel.Channels.BindingElement.Clone%2A> и свойство <xref:System.ServiceModel.Channels.TransportBindingElement.Scheme%2A?displayProperty=nameWithType>.  
  
 <xref:System.ServiceModel.Channels.BindingElement.Clone%2A>. Этот метод должен вернуть новую копию данного элемента привязки.  Авторам элемента привязки рекомендуется реализовать метод Clone с помощью конструктора копии, который вызывает базовый конструктор копии и затем клонирует любые дополнительные поля в этом классе.  
  
 <xref:System.ServiceModel.Channels.TransportBindingElement.Scheme%2A>. Свойство получения схемы <xref:System.ServiceModel.Channels.TransportBindingElement.Scheme%2A> возвращает схему универсального кода ресурса (URI) для транспортного протокола, представленного элементом привязки. Например, <xref:System.ServiceModel.Channels.HttpTransportBindingElement?displayProperty=nameWithType> и <xref:System.ServiceModel.Channels.TcpTransportBindingElement?displayProperty=nameWithType> возвращает значения "http" и "net. TCP" из соответствующих <xref:System.ServiceModel.Channels.TransportBindingElement.Scheme%2A> свойств.  
  
#### <a name="encoding-binding-elements"></a>Элементы привязки кодирования  

 Чтобы создать новые элементы привязки кодирования, начните с расширения класса <xref:System.ServiceModel.Channels.BindingElement> и реализации класса <xref:System.ServiceModel.Channels.MessageEncodingBindingElement?displayProperty=nameWithType>. Затем, как минимум, необходимо реализовать методы <xref:System.ServiceModel.Channels.BindingElement.Clone%2A>, <xref:System.ServiceModel.Channels.MessageEncodingBindingElement.CreateMessageEncoderFactory%2A?displayProperty=nameWithType> и свойство <xref:System.ServiceModel.Channels.MessageEncodingBindingElement.MessageVersion%2A?displayProperty=nameWithType>.  
  
- <xref:System.ServiceModel.Channels.BindingElement.Clone%2A>. Возвращает новую копию этого элемента привязки. Авторам элемента привязки рекомендуется реализовать метод <xref:System.ServiceModel.Channels.BindingElement.Clone%2A>, используя конструктор копии, который вызывает базовый конструктор копии и затем клонирует любые дополнительные поля в этом классе.  
  
- <xref:System.ServiceModel.Channels.MessageEncodingBindingElement.CreateMessageEncoderFactory%2A>. Возвращает фабрику <xref:System.ServiceModel.Channels.MessageEncoderFactory>, предоставляющую дескриптор фактическому классу, который реализует новый кодировщик и должен расширить кодировщик <xref:System.ServiceModel.Channels.MessageEncoder>. Дополнительные сведения см. в разделах <xref:System.ServiceModel.Channels.MessageEncoderFactory> и <xref:System.ServiceModel.Channels.MessageEncoder>.  
  
- <xref:System.ServiceModel.Channels.MessageEncodingBindingElement.MessageVersion%2A>. Возвращает версию <xref:System.ServiceModel.Channels.MessageVersion>, применяемую в данной кодировке, которая представляет используемые версии протокола SOAP и WS-Addressing.  
  
 Полный список необязательных методов и свойств для определяемых пользователем элементов привязки кодирования см. в разделе <xref:System.ServiceModel.Channels.MessageEncodingBindingElement>.  
  
 Дополнительные сведения о создании нового элемента привязки см. в разделе [Создание привязок User-Defined](creating-user-defined-bindings.md).  
  
 После создания элемента привязки для канала вернитесь к разделу [Разработка каналов](developing-channels.md) , чтобы узнать, требуется ли добавить поддержку файла конфигурации в элемент привязки, если и как добавить поддержку публикации метаданных и как создать пользовательскую привязку, использующую элемент привязки.  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Channels.BindingElement>
- [Разработка каналов](developing-channels.md)
- [Транспорт: UDP](../samples/transport-udp.md)

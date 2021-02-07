---
description: 'Дополнительные сведения: Разработка каналов'
title: Разработка каналов
ms.date: 03/30/2017
ms.assetid: 0513af9f-a0c2-457b-9a50-5b6bfee48513
ms.openlocfilehash: 7fd6dc68a72d5167868c3ccee0f53c1ba3090322
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99743750"
---
# <a name="developing-channels"></a>Разработка каналов

Для разработки протокола или канала транспорта, которые могут использоваться с уровнем приложения Windows Communication Foundation (WCF), требуется выполнить несколько шагов. В этом разделе описываются эти действия и указываются конкретные разделы для получения дополнительных сведений. Сведения о модели канала и различных типах, упомянутых в этом разделе, см. в разделе [Обзор модели каналов](channel-model-overview.md). Полный пример транспортного канала см. в разделе [Transport: UDP](../samples/transport-udp.md).  
  
## <a name="the-channel-development-task-list"></a>Список задач разработки канала  

 Чтобы создать канал, определенный пользователем, выполните следующие действия (для всех каналов).  
  
1. Решите, какой из шаблонов обмена сообщениями по каналу (<xref:System.ServiceModel.Channels.IOutputChannel>, <xref:System.ServiceModel.Channels.IInputChannel>, <xref:System.ServiceModel.Channels.IDuplexChannel>, <xref:System.ServiceModel.Channels.IRequestChannel> или <xref:System.ServiceModel.Channels.IReplyChannel>) будет поддерживаться фабрикой <xref:System.ServiceModel.Channels.IChannelFactory> и прослушивателем <xref:System.ServiceModel.Channels.IChannelListener>, а также, будет ли этот шаблон поддерживать связанные с сеансами разновидности указанных интерфейсов. Дополнительные сведения см. [в разделе Выбор шаблона обмена сообщениями](choosing-a-message-exchange-pattern.md).  
  
2. Создайте фабрику и прослушиватель каналов (<xref:System.ServiceModel.Channels.IChannelFactory> и <xref:System.ServiceModel.Channels.IChannelListener>), которые поддерживают выбранный шаблон обмена сообщениями. Дополнительные сведения о разработке фабрик см. в статье [Клиент: фабрики каналов и каналы](client-channel-factories-and-channels.md). Дополнительные сведения о разработке прослушивателей см. в статье [служба: прослушиватели каналов и каналы](service-channel-listeners-and-channels.md).  
  
3. Обеспечьте, чтобы любые исключения, связанные с сетью, нормализовались либо в <xref:System.TimeoutException?displayProperty=nameWithType>, либо в соответствующий класс, унаследованный от <xref:System.ServiceModel.CommunicationException>. Дополнительные сведения см. в разделе [обработка исключений и ошибок](handling-exceptions-and-faults.md).  
  
4. Чтобы разрешить использование из прикладного уровня, добавьте элемент <xref:System.ServiceModel.Channels.BindingElement>, добавляющий пользовательский канал в стек каналов. Дополнительные сведения см. [в разделе Создание элемента BindingElement](creating-a-bindingelement.md).  
  
 Чтобы включить более полную поддержку на прикладном уровне, необходимо выполнить следующие дополнительные действия.  
  
1. Добавьте раздел расширения элементов привязки, чтобы представить новый элемент привязки системе конфигурации. Дополнительные сведения см. в разделе [Поддержка конфигурации и метаданных](configuration-and-metadata-support.md).  
  
2. Добавьте расширения метаданных, чтобы сообщить о возможностях в другие конечные точки. Дополнительные сведения см. в разделе [Поддержка конфигурации и метаданных](configuration-and-metadata-support.md).  
  
3. Добавьте привязку, которая предварительно настраивает стек элементов привязки в соответствии с четко определенным профилем. Дополнительные сведения см. в разделе [Создание привязок User-Defined](creating-user-defined-bindings.md).  
  
4. Добавьте раздел привязки и элемент конфигурации привязки, чтобы представить привязку системе конфигурации. Дополнительные сведения см. в разделе [Поддержка конфигурации и метаданных](configuration-and-metadata-support.md).  
  
## <a name="see-also"></a>См. также

- [Расширение привязок](extending-bindings.md)

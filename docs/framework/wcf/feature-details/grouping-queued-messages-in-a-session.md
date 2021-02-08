---
description: 'Дополнительные сведения: Группирование сообщений в очереди в сеансе'
title: Группирование сообщений в очереди в рамках сеанса
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- queues [WCF]. grouping messages
ms.assetid: 63b23b36-261f-4c37-99a2-cc323cd72a1a
ms.openlocfilehash: 5a23133090ebfd5db9f59bb37a69cdca83ce2bc0
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99793848"
---
# <a name="grouping-queued-messages-in-a-session"></a>Группирование сообщений в очереди в рамках сеанса

Windows Communication Foundation (WCF) предоставляет сеанс, позволяющий объединять набор связанных сообщений для обработки одним принимающим приложением. Сообщения, являющиеся частью сеанса, должны быть часть одной транзакции. Так как все сообщения являются частью одной транзакции, в случае сбоя обработки одного сообщения производится откат всего сеанса. Сеансы имеют аналогичные поведения в отношении очередей недоставленных сообщений и очередей подозрительных сообщений. Свойство "срок жизни" (TTL), заданное в настроенной для сеансов привязке, поддерживающей очередь, применяется ко всему сеансу. Если до истечения срока TTL отправлена только часть сообщений из сеанса, весь сеанс помещается в очередь недоставленных сообщений. Аналогично, если сообщения из сеанса не отправлены приложению из очереди приложения, весь сеанс помещается в очередь подозрительных сообщений (при наличии).  
  
## <a name="message-grouping-example"></a>Пример группирования сообщений  

 Один из примеров, где удобно группировать сообщения, полезен при реализации приложения обработки заказов в качестве службы WCF. Например, клиент передает в это приложение заказ, содержащий несколько позиций. Для каждой позиции клиент вызывает службу, что приводит к отправке отдельного сообщения. Возможно, что первая позиция будет получена сервером A, а вторая позиция - сервером B. При каждом добавлении позиции сервер, обрабатывающий эту позицию, должен найти соответствующий заказ и добавить в него позицию, что крайне неэффективно. Низкая эффективность работы сохраняется и в случае, когда все запросы обрабатываются одним сервером, так как сервер должен отслеживать все текущие обрабатываемые заказы и определять, к какому из них относится новая позиция. Группирование всех запросов для одного заказа значительно упрощает реализацию такого приложения. Клиентское приложение отправляет все позиции для одного заказа в сеансе, поэтому когда служба обрабатывает заказ, она обрабатывает сразу весь сеанс. \  
  
## <a name="procedures"></a>Процедуры  
  
#### <a name="to-set-up-a-service-contract-to-use-sessions"></a>Настройка контракта службы для использования сеансов  
  
1. Определите контракт службы, для которого требуются сеансы. Это можно сделать с помощью <xref:System.ServiceModel.ServiceContractAttribute> атрибута, указав:  
  
    ```csharp
    SessionMode=SessionMode.Required  
    ```  
  
2. Пометьте операции в контракте как односторонние, так как эти методы ничего не возвращают. Это делается с помощью <xref:System.ServiceModel.OperationContractAttribute> атрибута, указав:  
  
    ```csharp  
    [OperationContract(IsOneWay = true)]  
    ```  
  
3. Реализуйте контракт службы и укажите для <xref:System.ServiceModel.ServiceBehaviorAttribute.InstanceContextMode> значение <xref:System.ServiceModel.InstanceContextMode.PerSession?displayProperty=nameWithType>. В результате для каждого сеанса создается только один экземпляр службы.  
  
    ```csharp  
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerSession)]  
    ```  
  
4. Для каждой операции службы требуется транзакция. Это задается с помощью атрибута <xref:System.ServiceModel.OperationBehaviorAttribute>. Для операции, завершающей транзакцию, параметр <xref:System.ServiceModel.OperationBehaviorAttribute.TransactionAutoComplete> должен иметь значение `true`.  
  
    ```csharp  
    [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
    ```  
  
5. Настройте конечную точку, использующую предоставляемую системой привязку `NetMsmqBinding`.  
  
6. Создайте очередь транзакций с использованием <xref:System.Messaging>. Можно также создать очередь с помощью MSMQ или MMC. В таком случае создайте транзакционную очередь.  
  
7. Создайте узел для данной службы с помощью <xref:System.ServiceModel.ServiceHost>.  
  
8. Откройте узел службы для обеспечения доступности службы.  
  
9. Закройте узел службы.  
  
#### <a name="to-set-up-a-client"></a>Настройка клиента  
  
1. Создайте область транзакции для записи в транзакционную очередь.  
  
2. Создайте клиент WCF с помощью средства [служебной программы метаданных ServiceModel (Svcutil.exe)](../servicemodel-metadata-utility-tool-svcutil-exe.md) .  
  
3. Сделайте заказ.  
  
4. Закройте клиент WCF.  
  
## <a name="example"></a>Пример  
  
### <a name="description"></a>Описание  

 В следующем примере приводится код для службы `IProcessOrder` и клиента, использующего эту службу. В нем показано, как WCF использует сеансы в очереди для обеспечения поведения группирования.  
  
### <a name="code-for-the-service"></a>Код для службы  

 [!code-csharp[S_Msmq_Session#1](../../../../samples/snippets/csharp/VS_Snippets_CFX/s_msmq_session/cs/service.cs#1)]
 [!code-vb[S_Msmq_Session#1](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/s_msmq_session/vb/service.vb#1)]  

### <a name="code-for-the-client"></a>Код для клиента  

 [!code-csharp[S_Msmq_Session#3](../../../../samples/snippets/csharp/VS_Snippets_CFX/s_msmq_session/cs/client.cs#3)]
 [!code-vb[S_Msmq_Session#3](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/s_msmq_session/vb/client.vb#3)]  

## <a name="see-also"></a>См. также

- [Сеансы и очереди](../samples/sessions-and-queues.md)
- [Общие сведения об очередях](queues-overview.md)

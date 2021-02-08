---
description: Дополнительные сведения см. в статье как обмениваться сообщениями в очереди с помощью конечных точек WCF.
title: Практическое руководство. Обмен сообщениями в очереди с конечными точками WCF
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: 938e7825-f63a-4c3d-b603-63772fabfdb3
ms.openlocfilehash: fe7195719c57454cb0035c1b6f06134cf3380a46
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99802896"
---
# <a name="how-to-exchange-queued-messages-with-wcf-endpoints"></a>Практическое руководство. Обмен сообщениями в очереди с конечными точками WCF

Очереди обеспечивают надежный обмен сообщениями между клиентом и службой Windows Communication Foundation (WCF), даже если служба недоступна во время обмена данными. В следующих процедурах показано, как обеспечить устойчивое взаимодействие между клиентом и службой с помощью стандартной привязки в очереди при реализации службы WCF.  
  
 В этом разделе объясняется, как использовать <xref:System.ServiceModel.NetMsmqBinding> для обмена данными между клиентом WCF и службой WCF.  
  
### <a name="to-use-queuing-in-a-wcf-service"></a>Использование очередей в службе WCF.  
  
1. Определите контракт службы с использованием интерфейса, отмеченного атрибутом <xref:System.ServiceModel.ServiceContractAttribute>. Пометьте операции в интерфейсе, которые являются частью контракта службы с <xref:System.ServiceModel.OperationContractAttribute> и задайте их как односторонние, так как методу ответ не возвращается. Следующий код представляет пример контракта службы и определение его операций.  
  
     [!code-csharp[S_Msmq_Transacted#1](../../../../samples/snippets/csharp/VS_Snippets_CFX/s_msmq_transacted/cs/service.cs#1)]
     [!code-vb[S_Msmq_Transacted#1](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/s_msmq_transacted/vb/service.vb#1)]  
  
2. Необходимо определить контракты данных для определяемых пользователем типов, если их передает контракт службы. В следующем коде показано два контракта данных - `PurchaseOrder` и `PurchaseOrderLineItem`. Эти два типа определяют данные, отправляемые службе. (Обратите внимание, что классы, определяющие этот контракт данных, определяют и число методов. Эти методы не являются частью контракта данных. Частью контракта данных являются только члены, объявленные с атрибутом <xref:System.Runtime.Serialization.DataMemberAttribute>.)  
  
     [!code-csharp[S_Msmq_Transacted#2](../../../../samples/snippets/csharp/VS_Snippets_CFX/s_msmq_transacted/cs/service.cs#2)]
     [!code-vb[S_Msmq_Transacted#2](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/s_msmq_transacted/vb/service.vb#2)]  
  
3. Реализуйте методы контракта службы, определенные в интерфейсе в классе.  
  
     [!code-csharp[S_Msmq_Transacted#3](../../../../samples/snippets/csharp/VS_Snippets_CFX/s_msmq_transacted/cs/service.cs#3)]
     [!code-vb[S_Msmq_Transacted#3](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/s_msmq_transacted/vb/service.vb#3)]  
  
     Заметьте, что в методе <xref:System.ServiceModel.OperationBehaviorAttribute> указывается атрибут `SubmitPurchaseOrder`. Это значит, что данная операция должна вызываться в рамках транзакции, которая автоматически завершается при завершении метода.  
  
4. Создайте очередь транзакций с использованием <xref:System.Messaging>. Вместо этого можно создать очередь с использованием консоли управления (MMC) «Очередь сообщений Майкрософт (MSMQ)». В этом случае убедитесь, что создается очередь транзакций.  
  
     [!code-csharp[S_Msmq_Transacted#4](../../../../samples/snippets/csharp/VS_Snippets_CFX/s_msmq_transacted/cs/hostapp.cs#4)]
     [!code-vb[S_Msmq_Transacted#4](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/s_msmq_transacted/vb/hostapp.vb#4)]  
  
5. Определите класс <xref:System.ServiceModel.Description.ServiceEndpoint> в конфигурации, которая задает адрес службы и использует стандартную привязку <xref:System.ServiceModel.NetMsmqBinding>. Дополнительные сведения об использовании конфигурации WCF см. в разделе [Настройка служб WCF](../configuring-services.md).  

6. Создайте узел для службы `OrderProcessing` с использованием <xref:System.ServiceModel.ServiceHost>, считывающий и обрабатывающий сообщения из очереди. Откройте узел службы для обеспечения доступности службы. Выведите для пользователя сообщение о том, что нужно нажать любую клавишу для завершения службы. Вызовите метод `ReadLine`, чтобы включить ожидания нажатия клавиши, а затем закройте службу.  
  
     [!code-csharp[S_Msmq_Transacted#6](../../../../samples/snippets/csharp/VS_Snippets_CFX/s_msmq_transacted/cs/hostapp.cs#6)]
     [!code-vb[S_Msmq_Transacted#6](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/s_msmq_transacted/vb/hostapp.vb#6)]  
  
### <a name="to-create-a-client-for-the-queued-service"></a>Создание клиента для службы в очереди  
  
1. В следующем примере показано, как запустить приложение размещения и использовать средство Svcutil.exe для создания клиента WCF.  
  
    ```console
    svcutil http://localhost:8000/ServiceModelSamples/service  
    ```  
  
2. Определите объект <xref:System.ServiceModel.Description.ServiceEndpoint> в конфигурации, которая указывает адрес и использует стандартную привязку <xref:System.ServiceModel.NetMsmqBinding>, как показано в следующем примере.  

3. Создайте область транзакции для записи в транзакционную очередь, вызовите `SubmitPurchaseOrder` операцию и закройте клиент WCF, как показано в следующем примере.  
  
     [!code-csharp[S_Msmq_Transacted#8](../../../../samples/snippets/csharp/VS_Snippets_CFX/s_msmq_transacted/cs/client.cs#8)]
     [!code-vb[S_Msmq_Transacted#8](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/s_msmq_transacted/vb/client.vb#8)]  
  
## <a name="example"></a>Пример  

 В следующих примерах показан код службы, ведущее приложение, файл App.config и код клиента для этого примера.  
  
 [!code-csharp[S_Msmq_Transacted#9](../../../../samples/snippets/csharp/VS_Snippets_CFX/s_msmq_transacted/cs/service.cs#9)]
 [!code-vb[S_Msmq_Transacted#9](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/s_msmq_transacted/vb/service.vb#9)]  
  
 [!code-csharp[S_Msmq_Transacted#10](../../../../samples/snippets/csharp/VS_Snippets_CFX/s_msmq_transacted/cs/hostapp.cs#10)]
 [!code-vb[S_Msmq_Transacted#10](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/s_msmq_transacted/vb/hostapp.vb#10)]  

 [!code-csharp[S_Msmq_Transacted#12](../../../../samples/snippets/csharp/VS_Snippets_CFX/s_msmq_transacted/cs/client.cs#12)]
 [!code-vb[S_Msmq_Transacted#12](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/s_msmq_transacted/vb/client.vb#12)]  

## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.NetMsmqBinding>
- [Привязка MSMQ с поддержкой транзакций](../samples/transacted-msmq-binding.md)
- [Очереди в WCF](queuing-in-wcf.md)
- [Практическое руководство. Обмен сообщениями с конечными точками WCF и приложениями очереди сообщений](how-to-exchange-messages-with-wcf-endpoints-and-message-queuing-applications.md)
- [Отправка сообщений из приложения Windows Communication Foundation в приложение MSMQ](../samples/wcf-to-message-queuing.md)
- [Установка системы очередей сообщений (MSMQ)](../samples/installing-message-queuing-msmq.md)
- [Передача сообщений из приложения MSMQ в приложение Windows Communication Foundation](../samples/message-queuing-to-wcf.md)
- [Безопасность сообщений при использовании очереди сообщений](../samples/message-security-over-message-queuing.md)

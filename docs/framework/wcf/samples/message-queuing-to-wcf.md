---
description: Дополнительные сведения см. в статье очередь сообщений для Windows Communication Foundation
title: Передача сообщений из приложения MSMQ в приложение Windows Communication Foundation
ms.date: 03/30/2017
ms.assetid: 6d718eb0-9f61-4653-8a75-d2dac8fb3520
ms.openlocfilehash: 53c535379584bcb8fa50d1b550f87ea7acc15175
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99704008"
---
# <a name="message-queuing-to-windows-communication-foundation"></a>Передача сообщений из приложения MSMQ в приложение Windows Communication Foundation

В этом примере показано, как приложение очереди сообщений (MSMQ) может отправить сообщение MSMQ в службу Windows Communication Foundation (WCF). Служба представляет собой резидентное консольное приложение, позволяющее наблюдать за получением службой сообщений из очереди.

 Контракт службы `IOrderProcessor` определяет одностороннюю службу, которую можно использовать с очередями. Сообщение MSMQ не содержит заголовка Action, поэтому автоматически соотнести различные сообщения MSMQ с контрактами операций невозможно. Поэтому может существовать только один контракт операции. Если нужно определить для службы несколько контрактов операций, приложение должно сообщать, какой заголовок сообщения MSMQ (например, метку или correlationID) можно использовать для выбора контракта операции.

 Сообщение MSMQ не содержит сведений о том, какие заголовки соответствуют различным параметрам контракта операции. Параметр имеет тип <xref:System.ServiceModel.MsmqIntegration.MsmqMessage%601>(`MsmqMessage<T>`), содержащий сообщение MSMQ. Тип "T" в классе <xref:System.ServiceModel.MsmqIntegration.MsmqMessage%601>(`MsmqMessage<T>`) представляет данные, сериализованные в основную часть сообщения MSMQ. В этом образце тип `PurchaseOrder` сериализован в основную часть сообщения MSMQ.

 В следующем образце кода показан контракт службы, обрабатывающей заказы.

```csharp
// Define a service contract.
[ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
[ServiceKnownType(typeof(PurchaseOrder))]
public interface IOrderProcessor
{
    [OperationContract(IsOneWay = true, Action = "*")]
    void SubmitPurchaseOrder(MsmqMessage<PurchaseOrder> msg);
}
```

 Служба является резидентной. При работе с MSMQ используемую очередь следует создавать заранее. Это можно сделать вручную или с помощью кода. В данном образце служба проверяет наличие очереди и создает ее, если это необходимо. Имя очереди считывается из файла конфигурации.

```csharp
public static void Main()
{
    // Get the MSMQ queue name from the application settings in
    // configuration.
    string queueName = ConfigurationManager.AppSettings["queueName"];
    // Create the MSMQ queue if necessary.
    if (!MessageQueue.Exists(queueName))
        MessageQueue.Create(queueName, true);
    …
}
```

 Служба создает и открывает <xref:System.ServiceModel.ServiceHost> для службы `OrderProcessorService`, как показано в следующем образце кода.

```csharp
using (ServiceHost serviceHost = new ServiceHost(typeof(OrderProcessorService)))
{
    serviceHost.Open();
    Console.WriteLine("The service is ready.");
    Console.WriteLine("Press <ENTER> to terminate service.");
    Console.ReadLine();
    serviceHost.Close();
}
```

 Имя очереди MSMQ задается в разделе appSettings файла конфигурации, как показано в следующем образце конфигурации.

> [!NOTE]
> В имени очереди для определения локального компьютера используется точка (.), а в пути в качестве разделителей используются символы обратной косой черты. Адрес конечной точки WCF указывает схему MSMQ. formatname и использует localhost для локального компьютера. Адрес очереди для каждого имени формата MSMQ по рекомендациям о создании адресов следует схеме msmq.formatname.

```xml
<appSettings>
    <add key="orderQueueName" value=".\private$\Orders" />
</appSettings>
```

 Клиентское приложение — это приложение MSMQ, использующее метод <xref:System.Messaging.MessageQueue.Send%2A> для отправки в очередь устойчивого и транзакционного сообщения, как показано в следующем образце кода.

```csharp
//Connect to the queue.
MessageQueue orderQueue = new MessageQueue(ConfigurationManager.AppSettings["orderQueueName"]);

// Create the purchase order.
PurchaseOrder po = new PurchaseOrder();
po.CustomerId = "somecustomer.com";
po.PONumber = Guid.NewGuid().ToString();

PurchaseOrderLineItem lineItem1 = new PurchaseOrderLineItem();
lineItem1.ProductId = "Blue Widget";
lineItem1.Quantity = 54;
lineItem1.UnitCost = 29.99F;

PurchaseOrderLineItem lineItem2 = new PurchaseOrderLineItem();
lineItem2.ProductId = "Red Widget";
lineItem2.Quantity = 890;
lineItem2.UnitCost = 45.89F;

po.orderLineItems = new PurchaseOrderLineItem[2];
po.orderLineItems[0] = lineItem1;
po.orderLineItems[1] = lineItem2;

// Submit the purchase order.
Message msg = new Message();
msg.Body = po;
//Create a transaction scope.
using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required))
{

    orderQueue.Send(msg, MessageQueueTransactionType.Automatic);
    // Complete the transaction.
    scope.Complete();

}
Console.WriteLine("Placed the order:{0}", po);
Console.WriteLine("Press <ENTER> to terminate client.");
Console.ReadLine();
```

 При выполнении образца действия клиента и службы отображаются в окнах консоли как службы, так и клиента. Можно видеть, как служба получает сообщения от клиента. Нажмите клавишу ВВОД в каждом окне консоли, чтобы закрыть службу и клиент. Обратите внимание, что поскольку используется очередь, клиенту и службе не обязательно быть запущенными и работать одновременно. Например, можно запустить клиент, выключить его, а затем запустить службу и все равно получить сообщения клиента.

## <a name="set-up-build-and-run-the-sample"></a>Настройка, сборка и запуск примера

1. Убедитесь, что вы выполнили [однократную процедуру настройки для Windows Communication Foundation примеров](one-time-setup-procedure-for-the-wcf-samples.md).

2. При первом запуске служба проверит наличие очереди. Если очередь отсутствует, служба ее создаст. Можно сначала запустить службу, чтобы создать очередь, либо создать ее с помощью диспетчера очередей MSMQ. Чтобы создать очередь в Windows 2008, выполните следующие шаги.

    1. Откройте диспетчер сервера в Visual Studio 2012.

    2. Разверните вкладку **функции** .

    3. Щелкните правой кнопкой мыши **частные очереди сообщений** и выберите **создать**, **Частная очередь**.

    4. Установите флажок **транзакционная** .

    5. Введите в `ServiceModelSamplesTransacted` качестве имени новой очереди.

3. Чтобы создать выпуск решения на языке C# или Visual Basic .NET, следуйте инструкциям в разделе [Building the Windows Communication Foundation Samples](building-the-samples.md).

4. Чтобы запустить пример в конфигурации с одним компьютером, следуйте инструкциям в разделе [выполнение примеров Windows Communication Foundation](running-the-samples.md).

## <a name="run-the-sample-across-computers"></a>Запуск примера на нескольких компьютерах

1. Скопируйте на компьютер службы файлы служебной программы из папки \service\bin\ в папку языка.

2. Скопируйте на клиентские компьютеры файлы из папки \client\bin\ в папку языка.

3. В файле Client.exe.config измените orderQueueName, указав имя компьютера службы вместо «.».

4. На компьютере службы запустите из командной строки программу Service.exe.

5. На клиентском компьютере из командной строки запустите программу Client.exe.

> [!IMPORTANT]
> Образцы уже могут быть установлены на компьютере. Перед продолжением проверьте следующий каталог (по умолчанию).
>
> `<InstallDrive>:\WF_WCF_Samples`
>
> Если этот каталог не существует, перейдите к [примерам Windows Communication Foundation (WCF) и Windows Workflow Foundation (WF) для платформа .NET Framework 4](https://www.microsoft.com/download/details.aspx?id=21459) , чтобы скачать все Windows Communication Foundation (WCF) и [!INCLUDE[wf1](../../../../includes/wf1-md.md)] примеры. Этот образец расположен в следующем каталоге.
>
> `<InstallDrive>:\WF_WCF_Samples\WCF\Basic\Binding\MSMQIntegration\MsmqToWcf`

## <a name="see-also"></a>См. также

- [Очереди в WCF](../feature-details/queues-in-wcf.md)
- [Практическое руководство. Обмен сообщениями с конечными точками WCF и приложениями очереди сообщений](../feature-details/how-to-exchange-messages-with-wcf-endpoints-and-message-queuing-applications.md)
- [служба очередей сообщений](/previous-versions/windows/desktop/legacy/ms711472(v=vs.85))

---
description: 'Дополнительные сведения о: типизированном клиенте'
title: Типизированный клиент
ms.date: 03/30/2017
ms.assetid: 62c40e8f-e9b4-4b1a-939a-93c37393d343
ms.openlocfilehash: 2d6f8743f3587800fbd9ec64d90e9ac1ab82d02a
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99685469"
---
# <a name="typed-client"></a>Типизированный клиент

В примере показано, как получить сведения от типизированного клиента, созданного с помощью [средства служебной программы метаданных ServiceModel (Svcutil.exe)](../servicemodel-metadata-utility-tool-svcutil-exe.md). Этот образец основан на [Начало работы](getting-started-sample.md) , который реализует службу калькулятора. В этом образце клиентом является консольное приложение (EXE), а служба размещается в службах IIS.  
  
> [!NOTE]
> Процедура настройки и инструкции по построению для данного образца приведены в конце этого раздела.  
  
 Свойство `Endpoint` клиента обеспечивает доступ к информации о конечной точке службы, с которой взаимодействует клиент - включая адрес, привязку и информацию о контракте. Свойство `InnerChannel` клиента является экземпляром класса <xref:System.ServiceModel.IClientChannel>, который обеспечивает доступ к информации об используемом канале, такой как его состояние и идентификатор сеанса.  
  
```csharp
// Create a client.  
CalculatorClient client = new CalculatorClient();  
...  
Console.WriteLine("Client - endpoint:  " + client.Endpoint.Address);  
Console.WriteLine("Client - binding:  " + client.Endpoint.Binding.Name);  
Console.WriteLine("Client - contract: " + client.Endpoint.Contract.Name);  
  
IClientChannel channel = client.InnerChannel;  
Console.WriteLine("Client channel - state: " + channel.State);  
Console.WriteLine("Client channel - session identifier: " + channel.SessionId);  
  
//Closing the client gracefully closes the connection and cleans up resources.  
client.Close();  
```  
  
 При выполнении примера запросы и ответы операций отображаются в окне консоли клиента. Чтобы закрыть клиент, нажмите клавишу ВВОД в окне клиента.  
  
```console  
Add(100,15.99) = 115.99  
Subtract(145,76.54) = 68.46  
Multiply(9,81.25) = 731.25  
Divide(22,7) = 3.14285714285714  
  
Client - endpoint:  http://localhost/servicemodelsamples/service.svc  
Client - binding:  WSHttpBinding  
Client - contract: ICalculator  
Client channel - state: Opened  
Client channel - session identifier: urn:uuid:ae16fbc4-2964-4e87-9fb1-c5aa78fc567e  
  
Press <ENTER> to terminate client.  
```  
  
### <a name="to-set-up-build-and-run-the-sample"></a>Настройка, сборка и выполнение образца  
  
1. Убедитесь, что вы выполнили [однократную процедуру настройки для Windows Communication Foundation примеров](one-time-setup-procedure-for-the-wcf-samples.md).  
  
2. Чтобы создать выпуск решения на языке C# или Visual Basic .NET, следуйте инструкциям в разделе [Building the Windows Communication Foundation Samples](building-the-samples.md).  
  
3. Чтобы запустить пример в конфигурации с одним или несколькими компьютерами, следуйте инструкциям в разделе [выполнение примеров Windows Communication Foundation](running-the-samples.md).  
  
> [!IMPORTANT]
> Образцы уже могут быть установлены на компьютере. Перед продолжением проверьте следующий каталог (по умолчанию).  
>
> `<InstallDrive>:\WF_WCF_Samples`  
>
> Если этот каталог не существует, перейдите к [примерам Windows Communication Foundation (WCF) и Windows Workflow Foundation (WF) для платформа .NET Framework 4](https://www.microsoft.com/download/details.aspx?id=21459) , чтобы скачать все Windows Communication Foundation (WCF) и [!INCLUDE[wf1](../../../../includes/wf1-md.md)] примеры. Этот образец расположен в следующем каталоге.  
>
> `<InstallDrive>:\WF_WCF_Samples\WCF\Basic\Client\TypedClient`  

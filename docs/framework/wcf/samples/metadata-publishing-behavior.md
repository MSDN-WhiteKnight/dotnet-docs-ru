---
description: 'Дополнительные сведения: поведение публикации метаданных'
title: Поведение публикации метаданных
ms.date: 03/30/2017
helpviewer_keywords:
- service behaviors, metadata publishing sample
- Metadata Publishing Behaviors Sample [Windows Communication Foundation]
ms.assetid: 78c13633-d026-4814-910e-1c801cffdac7
ms.openlocfilehash: 13e52e5f2a8d301eac3100cbf2350cc5a089aa34
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99752243"
---
# <a name="metadata-publishing-behavior"></a>Поведение публикации метаданных

Образец поведения публикации метаданных демонстрирует, как управлять возможностями публикации метаданных службы. Чтобы предотвратить непреднамеренное раскрытие потенциально конфиденциальных метаданных службы, конфигурация по умолчанию для служб Windows Communication Foundation (WCF) отключает публикацию метаданных. Такое расширение функциональности по умолчанию защищено, но это также означает, что при этом невозможно использовать средство импорта метаданных (например, Svcutil.exe) для создания клиентского кода, необходимого для вызова службы, если поведение публикации не включено явно в конфигурации.  
  
> [!IMPORTANT]
> Для ясности этот образец демонстрирует создание незащищенной конечной точки публикации метаданных. Такие конечные точки являются потенциально доступными для анонимных не прошедших проверку подлинности потребителей, поэтому перед развертыванием таких конечных точек следует соблюдать осторожность и убедиться, что публичное раскрытие метаданных службы уместно. Пример, который защищает конечную точку метаданных, см. в примере [пользовательской конечной точки защищенных метаданных](custom-secure-metadata-endpoint.md) .  
  
 Образец основан на [Начало работы](getting-started-sample.md), который реализует `ICalculator` контракт службы. В этом образце клиентом является консольное приложение (EXE), а служба размещается в службах IIS.  
  
> [!NOTE]
> Процедура настройки и инструкции по построению для данного образца приведены в конце этого раздела.  
  
 Чтобы отобразить метаданные для службы, параметр <xref:System.ServiceModel.Description.ServiceMetadataBehavior> должен быть сконфигурирован в службе. При наличии такого поведения можно публиковать метаданные, конфигурируя конечную точку для предоставления контракта <xref:System.ServiceModel.Description.IMetadataExchange> как реализации протокола WS-MetadataExchange (MEX). Для удобства этому контракту присвоено сокращенное имя конфигурации "IMetadataExchange". В этом образце используется привязка `mexHttpBinding`, являющаяся удобной стандартной привязкой, эквивалентной `wsHttpBinding` с режимом безопасности, которому присвоено значение `None`. В конечной точке используется относительный адрес MEX, который при разрешении по базовому адресу служб приводит к адресу конечной точки `http://localhost/servicemodelsamples/service.svc/mex` . Ниже приводится конфигурация поведения:  
  
```xml  
<behaviors>  
  <serviceBehaviors>  
    <behavior name="CalculatorServiceBehavior">  
      <!-- The serviceMetadata behavior publishes metadata through   
           the IMetadataExchange contract. When this behavior is   
           present, you can expose this contract through an endpoint   
           as shown below. Setting httpGetEnabled to true publishes   
           the service's WSDL at the <baseaddress>?wsdl, for example,  
           http://localhost/servicemodelsamples/service.svc?wsdl -->  
      <serviceMetadata httpGetEnabled="True"/>  
      <serviceDebug includeExceptionDetailInFaults="False" />  
    </behavior>  
  </serviceBehaviors>  
</behaviors>  
```  
  
 Ниже приводится описание конечной точки MEX.  
  
```xml  
<!-- the MEX endpoint is exposed at   
     http://localhost/servicemodelsamples/service.svc/mex   
     To expose the IMetadataExchange contract, you   
     must enable the serviceMetadata behavior as demonstrated                           
     previously. -->  
<endpoint address="mex"  
          binding="mexHttpBinding"  
          contract="IMetadataExchange" />  
```  
  
 Этот образец присваивает свойству <xref:System.ServiceModel.Description.ServiceMetadataBehavior.HttpGetEnabled%2A> логическое значение `true`, а также предоставляет метаданные службы, используя HTTP GET. Чтобы включить конечную точку метаданных HTTP GET, службе должен быть присвоен базовый HTTP-адрес. Для доступа к метаданным используется строка запроса `?wsdl` для базового адреса службы. Например, чтобы просмотреть WSDL для службы в веб-браузере, используйте адрес `http://localhost/servicemodelsamples/service.svc?wsdl` . Кроме того, можно использовать это поведение, чтобы предоставить метаданные по протоколу HTTPS, присваивая свойству <xref:System.ServiceModel.Description.ServiceMetadataBehavior.HttpsGetEnabled%2A> логическое значение `true`. Это потребует наличия базового HTTPS-адреса.  
  
 Чтобы получить доступ к конечной точке обмена метаданными службы, используйте [служебную программу метаданных ServiceModel (Svcutil.exe)](../servicemodel-metadata-utility-tool-svcutil-exe.md).  
  
 `svcutil.exe /n:"http://Microsoft.ServiceModel.Samples,Microsoft.ServiceModel.Samples" http://localhost/servicemodelsamples/service.svc/mex /out:generatedClient.cs`  
  
 Это позволит создать клиент, основанный на метаданных службы.  
  
 Чтобы получить доступ к метаданным службы с помощью HTTP GET, перейдите в браузере к `http://localhost/servicemodelsamples/service.svc?wsdl` .  
  
 При удалении этого поведения и попытке открыть службу будет получено исключение. Происходит ошибка, поскольку конечная точка, настроенная с контрактом `IMetadataExchange`, не имеет реализации при отсутствии поведения.  
  
 Если свойству `HttpGetEnabled` присваивается логическое значение `false`, будет отображена справочная страница CalculatorService вместо метаданных службы.  
  
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
> `<InstallDrive>:\WF_WCF_Samples\WCF\Basic\Services\Behaviors\Metadata`  

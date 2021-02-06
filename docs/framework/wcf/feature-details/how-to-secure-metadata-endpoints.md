---
description: Дополнительные сведения см. в статье как защитить конечные точки метаданных.
title: Практическое руководство. Защита конечных точек метаданных
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: 9f71b6ae-737c-4382-8d89-0a7b1c7e182b
ms.openlocfilehash: bcce3fd0708049435c791cae5064f84133dfd612
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99643310"
---
# <a name="how-to-secure-metadata-endpoints"></a>Практическое руководство. Защита конечных точек метаданных

Метаданные для службы могут содержать конфиденциальные сведения о приложении, которые могут быть использованы злоумышленником. Потребителям службы может также потребоваться безопасный механизм получения метаданных о службе. Поэтому необходимо время от времени публиковать метаданные с помощью защищенной конечной точки.

Конечные точки метаданных обычно защищаются с помощью стандартных механизмов безопасности, определенных в Windows Communication Foundation (WCF) для защиты конечных точек приложений. Дополнительные сведения см. в [обзоре безопасности](security-overview.md).

В этом разделе содержится пошаговое руководство по созданию конечной точки, безопасность которой обеспечивается SSL-сертификатом, то есть конечной точкой HTTPS.

### <a name="to-create-a-secure-https-get-metadata-endpoint-in-code"></a>Добавление защищенной конечной точки метаданных HTTPS GET в код

1. Настройте порт с соответствующим сертификатом X.509. Сертификат должен быть получен из надежного центра сертификации и должен предназначаться для авторизации службы. Для привязки сертификата к конкретному порту используйте средство HttpCfg.exe. См. раздел [как настроить порт с помощью SSL-сертификата](how-to-configure-a-port-with-an-ssl-certificate.md).

    > [!IMPORTANT]
    > Субъект сертификата или его служба доменных имен (DNS) должны соответствовать имени компьютера. Это важно, так как одним из первых шагов механизма HTTPS является проверка соответствия сертификата универсальному коду ресурса (URI) и адресу, для которого он вызван.

2. Создайте новый экземпляр класса <xref:System.ServiceModel.Description.ServiceMetadataBehavior>.

3. Задайте свойству <xref:System.ServiceModel.Description.ServiceMetadataBehavior.HttpsGetEnabled%2A> класса <xref:System.ServiceModel.Description.ServiceMetadataBehavior> значение `true`.

4. Присвойте свойству <xref:System.ServiceModel.Description.ServiceMetadataBehavior.HttpsGetUrl%2A> соответствующее значение URL-адреса. Обратите внимание, что при указании абсолютного адреса URL-адрес должен начинаться с схемы `https://` . При указании относительного адреса необходимо определить базовый адрес HTTPS узла службы. Если это свойство службы не задано, за адрес по умолчанию принимается "" или непосредственно базовый адрес HTTPS службы.

5. Создайте экземпляр коллекции поведений, который возвращает свойство <xref:System.ServiceModel.Description.ServiceDescription.Behaviors%2A> класса <xref:System.ServiceModel.Description.ServiceDescription> в соответствии со следующим кодом.

    [!code-csharp[c_HowToSecureEndpoint#1](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_howtosecureendpoint/cs/source.cs#1)]
    [!code-vb[c_HowToSecureEndpoint#1](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_howtosecureendpoint/vb/source.vb#1)]

### <a name="to-create-a-secure-https-get-metadata-endpoint-in-configuration"></a>Добавление защищенной конечной точки метаданных HTTPS GET в конфигурацию

1. Добавьте [\<behaviors>](../../configure-apps/file-schema/wcf/behaviors.md) элемент в [\<system.serviceModel>](../../configure-apps/file-schema/wcf/system-servicemodel.md) элемент файла конфигурации для службы.

2. Добавьте [\<serviceBehaviors>](../../configure-apps/file-schema/wcf/servicebehaviors.md) элемент в [\<behaviors>](../../configure-apps/file-schema/wcf/behaviors.md) элемент.

3. Добавьте [\<behavior>](../../configure-apps/file-schema/wcf/behavior-of-servicebehaviors.md) элемент в `<serviceBehaviors>` элемент.

4. Задайте атрибуту `name` элемента `<behavior>` соответствующее значение. Атрибут `name` является обязательным. В приведенном ниже примере используется значение `mySvcBehavior`.

5. Добавьте в [\<serviceMetadata>](../../configure-apps/file-schema/wcf/servicemetadata.md) `<behavior>` элемент.

6. Задайте атрибуту `httpsGetEnabled` элемента `<serviceMetadata>` значение `true`.

7. Задайте атрибуту `httpsGetUrl` элемента `<serviceMetadata>` соответствующее значение. Обратите внимание, что при указании абсолютного адреса URL-адрес должен начинаться с схемы `https://` . При указании относительного адреса необходимо определить базовый адрес HTTPS узла службы. Если это свойство службы не задано, за адрес по умолчанию принимается "" или непосредственно базовый адрес HTTPS службы.

8. Чтобы использовать поведение службы, присвойте `behaviorConfiguration` атрибуту [\<service>](../../configure-apps/file-schema/wcf/service.md) элемента значение атрибута Name элемента Behavior. В следующем примере приводится полный код конфигурации.

    ```xml
    <?xml version="1.0" encoding="utf-8" ?>
    <configuration>
     <system.serviceModel>
      <behaviors>
       <serviceBehaviors>
        <behavior name="mySvcBehavior">
         <serviceMetadata httpsGetEnabled="true"
              httpsGetUrl="https://localhost:8036/calcMetadata" />
        </behavior>
       </serviceBehaviors>
      </behaviors>
     <services>
      <service behaviorConfiguration="mySvcBehavior"
            name="Microsoft.Security.Samples.Calculator">
       <endpoint address="http://localhost:8037/ServiceModelSamples/calculator"
       binding="wsHttpBinding" bindingConfiguration=""
       contract="Microsoft.Security.Samples.ICalculator" />
      </service>
     </services>
    </system.serviceModel>
    </configuration>
    ```

## <a name="example"></a>Пример

В следующем примере создается экземпляр класса <xref:System.ServiceModel.ServiceHost> и добавляется конечная точка. Затем создается экземпляр класса <xref:System.ServiceModel.Description.ServiceMetadataBehavior> и задаются свойства для создания защищенной точки обмена метаданными.

[!code-csharp[c_HowToSecureEndpoint#0](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_howtosecureendpoint/cs/source.cs#0)]
[!code-vb[c_HowToSecureEndpoint#0](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_howtosecureendpoint/vb/source.vb#0)]

## <a name="compiling-the-code"></a>Компиляция кода

В примере кода используются следующие пространства имен:

- <xref:System.ServiceModel?displayProperty=nameWithType>

- <xref:System.ServiceModel.Description?displayProperty=nameWithType>

## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Description.ServiceMetadataBehavior.HttpsGetEnabled%2A>
- <xref:System.ServiceModel.Description.ServiceMetadataBehavior>
- <xref:System.ServiceModel.Description.ServiceMetadataBehavior.HttpsGetUrl%2A>
- [Практическое руководство. Настройка порта с использованием SSL-сертификата](how-to-configure-a-port-with-an-ssl-certificate.md)
- [Работа с сертификатами](working-with-certificates.md)
- [Вопросы безопасности при использовании метаданных](security-considerations-with-metadata.md)
- [Защита служб и клиентов](securing-services-and-clients.md)

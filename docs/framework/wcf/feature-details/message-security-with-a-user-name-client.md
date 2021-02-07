---
description: 'Дополнительные сведения: защита сообщений с помощью клиента имени пользователя'
title: Безопасность сообщений при использовании клиентом учетных данных пользователя
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: 36335cb9-76b8-4443-92c7-44f081eabb21
ms.openlocfilehash: 4502635df3b52ba069c19fca7a73cc9395dd105d
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99756114"
---
# <a name="message-security-with-a-user-name-client"></a>Безопасность сообщений при использовании клиентом учетных данных пользователя

На следующем рисунке показана служба Windows Communication Foundation (WCF) и клиент защищены с помощью безопасности на уровне сообщений. Служба проходит проверку подлинности с использованием сертификата X.509. Подлинность клиента проверяется с помощью имени и пароля пользователя.  
  
 Пример приложения см. в разделе [Message Security имя пользователя](../samples/message-security-user-name.md).  
  
 ![Безопасность сообщений с использованием проверки подлинности имени пользователя](media/1fb10a61-7e1d-42f5-b1af-195bfee5b3c6.gif "1fb10a61-7e1d-42f5-b1af-195bfee5b3c6")  
  
|Характеристика|Описание|  
|--------------------|-----------------|  
|Режим безопасности|Сообщение|  
|Совместимость|Только Windows Communication Foundation (WCF)|  
|Проверка подлинности (сервера)|Первоначальное согласование возможно только после проверки подлинности сервера|  
|Проверка подлинности (клиента)|Имя пользователя/пароль|  
|Целостность|Да, используется общий контекст безопасности|  
|Конфиденциальность|Да, используется общий контекст безопасности|  
|Транспорт|HTTP|  
|Привязка|<xref:System.ServiceModel.WSHttpBinding>|  
  
## <a name="service"></a>Служба  

 Предполагается, что представленные ниже код и конфигурация выполняются независимо. Выполните одно из следующих действий.  
  
- Создайте автономную службу, используя код без конфигурации.  
  
- Создайте службу, используя предоставленную конфигурацию, но не определяйте конечные точки.  
  
### <a name="code"></a>Код  

 В следующем коде показано, как создать конечную точку службы, которая использует безопасность сообщений.  
  
 [!code-csharp[C_SecurityScenarios#9](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_securityscenarios/cs/source.cs#9)]
 [!code-vb[C_SecurityScenarios#9](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_securityscenarios/vb/source.vb#9)]  
  
### <a name="configuration"></a>Конфигурация  

 Вместо кода можно использовать следующую конфигурацию:  
  
```xml  
<?xml version="1.0" encoding="utf-8"?>  
<configuration>  
  <system.serviceModel>  
    <behaviors>  
      <serviceBehaviors>  
        <behavior name="ServiceCredentialsBehavior">  
          <serviceCredentials>  
            <serviceCertificate findValue="Contoso.com"
                                storeLocation="LocalMachine"  
                                storeName="My"
                                x509FindType="FindBySubjectName" />  
          </serviceCredentials>  
        </behavior>  
      </serviceBehaviors>  
    </behaviors>  
    <services>  
      <service behaviorConfiguration="ServiceCredentialsBehavior"  
               name="ServiceModel.Calculator">  
        <endpoint address="http://localhost/Calculator"  
                  binding="wsHttpBinding"  
                  bindingConfiguration="MessageAndUserName"  
                  name="SecuredByTransportEndpoint"  
                  contract="ServiceModel.ICalculator" />  
      </service>  
    </services>  
    <bindings>  
      <wsHttpBinding>  
        <binding name="MessageAndUserName">  
          <security mode="Message">
            <message clientCredentialType="UserName" />  
          </security>  
        </binding>  
      </wsHttpBinding>  
    </bindings>  
    <client />  
  </system.serviceModel>  
</configuration>  
```  
  
## <a name="client"></a>Клиент  
  
### <a name="code"></a>Код  

 Следующий код служит для создания клиента. Привязка осуществляется к безопасности режима сообщений, и типу учетных данных клиента присваивается значение `UserName`. Указать имя пользователя и пароль можно только с помощью кода (они не подлежат настройке). Здесь не показан код, который возвращает имя пользователя и пароль, потому что это происходит на уровне приложения. Например, диалоговое окно Windows Forms используется для того, чтобы запросить пользователя о данных.  
  
 [!code-csharp[C_SecurityScenarios#16](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_securityscenarios/cs/source.cs#16)]
 [!code-vb[C_SecurityScenarios#16](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_securityscenarios/vb/source.vb#16)]  
  
### <a name="configuration"></a>Конфигурация  

 Следующий код служит для настройки клиента. Привязка осуществляется к безопасности режима сообщений, и типу учетных данных клиента присваивается значение `UserName`. Указать имя пользователя и пароль можно только с помощью кода (они не подлежат настройке).  
  
```xml  
<?xml version="1.0" encoding="utf-8"?>  
<configuration>  
  <system.serviceModel>  
    <bindings>  
      <wsHttpBinding>  
        <binding name="WSHttpBinding_ICalculator" >  
          <security mode="Message">  
            <message clientCredentialType="UserName" />  
          </security>  
        </binding>  
      </wsHttpBinding>  
    </bindings>  
    <client>  
      <endpoint address="http://machineName/Calculator"
                binding="wsHttpBinding"  
                bindingConfiguration="WSHttpBinding_ICalculator"
                contract="ICalculator"  
                name="WSHttpBinding_ICalculator">  
        <identity>  
          <dns value ="Contoso.com" />  
        </identity>  
      </endpoint>  
    </client>  
  </system.serviceModel>  
</configuration>  
```  
  
## <a name="see-also"></a>См. также

- [Обзор безопасности](security-overview.md)
- [Безопасность сообщений с использованием имени пользователя](../samples/message-security-user-name.md)
- [Идентификация и проверка подлинности службы](service-identity-and-authentication.md)
- [\<identity>](../../configure-apps/file-schema/wcf/identity.md)
- [Модель безопасности для Windows Server App Fabric](/previous-versions/appfabric/ee677202(v=azure.10))

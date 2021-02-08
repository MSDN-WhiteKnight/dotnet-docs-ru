---
description: 'Дополнительные сведения: режимы проверки подлинности SecurityBindingElement'
title: Режимы проверки подлинности SecurityBindingElement
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: 12300bf4-c730-4405-9f65-d286f68b5a43
ms.openlocfilehash: bf91f0fbb112e8a0fcd4d03fe7dd82a3a4eebbd0
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99793588"
---
# <a name="securitybindingelement-authentication-modes"></a>Режимы проверки подлинности SecurityBindingElement

Windows Communication Foundation (WCF) предоставляет несколько режимов, с помощью которых клиенты и службы проходят проверку подлинности друг за другом. Для этих режимов проверки подлинности можно создать привязки безопасности с помощью статических методов класса <xref:System.ServiceModel.Channels.SecurityBindingElement> или с помощью конфигурации. В этом разделе кратко описано 18 режимов проверки подлинности.  
  
 Пример использования элемента для одного из режимов проверки подлинности см. в разделе [инструкции. Создание SecurityBindingElement для указанного режима проверки подлинности](how-to-create-a-securitybindingelement-for-a-specified-authentication-mode.md).  
  
## <a name="basic-configuration-programming"></a>Базовое программирование конфигурации  

 Ниже описано, как задать режим проверки подлинности в файле конфигурации.  
  
#### <a name="to-set-the-authentication-mode-in-configuration"></a>Задание режима проверки подлинности в файле конфигурации  
  
1. К [\<bindings>](../../configure-apps/file-schema/wcf/bindings.md) элементу добавьте [\<customBinding>](../../configure-apps/file-schema/wcf/custombinding.md) .  
  
2. В качестве дочернего элемента добавьте [\<binding>](../../configure-apps/file-schema/wcf/bindings.md) элемент в `<customBinding>` элемент.  
  
3. Добавьте элемент `<security>` в элемент `<binding>`.  
  
4. Задайте для атрибута `authenticationMode` одно из описанных ниже значений. Например, следующий код задает режим `AnonymousForCertificate`.  
  
    ```xml  
    <bindings>  
      <customBinding>  
        <binding name="SecureCustomBinding">  
         <security authenticationMode ="AnonymousForCertificate" />  
        </binding>  
      </customBinding>  
    </bindings>  
    ```  
  
#### <a name="to-set-the-mode-programmatically"></a>Задание режима программным образом  
  
1. Определите возвращаемый тип, который может быть следующим: <xref:System.ServiceModel.Channels.SymmetricSecurityBindingElement>, <xref:System.ServiceModel.Channels.TransportSecurityBindingElement>, <xref:System.ServiceModel.Channels.AsymmetricSecurityBindingElement> или <xref:System.ServiceModel.Channels.SecurityBindingElement>.  
  
2. Вызовите соответствующий статический метод класса <xref:System.ServiceModel.Channels.SecurityBindingElement>. Например, в следующем фрагменте кода вызывается метод <xref:System.ServiceModel.Channels.SecurityBindingElement.CreateAnonymousForCertificateBindingElement%2A>.  
  
     [!code-csharp[c_CustomBindingsAuthMode#3](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_custombindingsauthmode/cs/source.cs#3)]
     [!code-vb[c_CustomBindingsAuthMode#3](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_custombindingsauthmode/vb/source.vb#3)]  
  
3. С помощью элемента привязки создайте пользовательскую привязку. Дополнительные сведения см. в разделе [пользовательские привязки](../extending/custom-bindings.md).  
  
## <a name="mode-descriptions"></a>Описание режимов  
  
### <a name="anonymousforcertificate"></a>AnonymousForCertificate  

 В этом режиме проверки подлинности клиент является анонимным, а проверка подлинности службы осуществляется с использованием сертификата X.509. Элементом привязки безопасности является элемент <xref:System.ServiceModel.Channels.SymmetricSecurityBindingElement>, возвращаемый методом <xref:System.ServiceModel.Channels.SecurityBindingElement.CreateAnonymousForCertificateBindingElement%2A>. Кроме того, можно установить `authenticationMode` атрибут элемента <`security`> в значение `AnonymousForCertificate` .  
  
### <a name="anonymousforsslnegotiated"></a>AnonymousForSslNegotiated  

 В этом режиме проверки подлинности клиент является анонимным, а проверка подлинности службы осуществляется с использованием сертификата X.509, который определяется во время выполнения. Элементом привязки безопасности является объект <xref:System.ServiceModel.Channels.SymmetricSecurityBindingElement>, возвращаемый методом <xref:System.ServiceModel.Channels.SecurityBindingElement.CreateSslNegotiationBindingElement%2A>, если в качестве первого параметра передается значение `false`. Можно также задать для атрибута `authenticationMode` значение `AnonymousForSslNegotiated`.  
  
### <a name="certificateovertransport"></a>CertificateOverTransport  

 В этом режиме проверка подлинности клиента осуществляется с использованием сертификата X.509, который доступен на уровне SOAP в качестве разрешающего вспомогательного маркера, т. е. маркера, которым подписана подпись сообщения. Служба проходит проверку подлинности с использованием сертификата X.509 на транспортном уровне. Элементом привязки безопасности является элемент <xref:System.ServiceModel.Channels.TransportSecurityBindingElement>, возвращаемый методом <xref:System.ServiceModel.Channels.SecurityBindingElement.CreateCertificateOverTransportBindingElement%2A>. Можно также задать для атрибута `authenticationMode` значение `CertificateOverTransport`.  
  
### <a name="issuedtoken"></a>IssuedToken  

 В этом режиме проверки подлинности клиент не проходит проверку подлинности на стороне службы; вместо этого клиент проходит проверку на стороне службы маркеров безопасности, получает маркер SAML, который затем представляет серверу, и, тем самым, подтверждает набор знаний общего ключа. Служба не проходит как таковую проверку подлинности на стороне клиента, но служба маркеров безопасности шифрует общий ключ в рамках выдаваемого маркера, чтобы только служба могла расшифровать этот ключ. Элементом привязки безопасности является элемент <xref:System.ServiceModel.Channels.SymmetricSecurityBindingElement>, возвращаемый методом <xref:System.ServiceModel.Channels.SecurityBindingElement.CreateIssuedTokenBindingElement%2A>. Можно также задать для атрибута `authenticationMode` значение `IssuedToken`.  
  
### <a name="issuedtokenforcertificate"></a>IssuedTokenForCertificate  

 В этом режиме проверки подлинности клиент не проходит проверку подлинности на стороне службы; вместо этого клиент проходит проверку на стороне службы маркеров безопасности, получает маркер SAML, который затем представляет серверу, и, тем самым, подтверждает набор знаний общего ключа. Выданный маркер доступен на уровне SOAP в качестве разрешающего вспомогательного маркера либо в качестве маркера, не являющегося подтверждающим, т. е. маркера, которым подписана сигнатура сообщения. Проверка подлинности службы на стороне клиента осуществляется с помощью сертификата X.509. Элементом привязки безопасности является элемент <xref:System.ServiceModel.Channels.SymmetricSecurityBindingElement>, возвращаемый методом <xref:System.ServiceModel.Channels.SecurityBindingElement.CreateIssuedTokenForCertificateBindingElement%2A>. Можно также задать для атрибута `authenticationMode` значение `IssuedTokenForCertificate`.  
  
### <a name="issuedtokenforsslnegotiated"></a>IssuedTokenForSslNegotiated  

 В этом режиме проверки подлинности клиент не проходит проверку подлинности на стороне службы; вместо этого клиент проходит проверку на стороне службы маркеров безопасности, получает маркер SAML, который затем представляет серверу, и, тем самым, подтверждает набор знаний общего ключа. Выданный маркер доступен на уровне SOAP в качестве разрешающего вспомогательного маркера либо в качестве маркера, не являющегося подтверждающим, т. е. маркера, которым подписана сигнатура сообщения. Служба проходит проверку подлинности с использованием сертификата X.509. Элементом привязки безопасности является элемент <xref:System.ServiceModel.Channels.SymmetricSecurityBindingElement>, возвращаемый методом <xref:System.ServiceModel.Channels.SecurityBindingElement.CreateIssuedTokenForSslBindingElement%2A>. Можно также задать для атрибута `authenticationMode` значение `IssuedTokenForSslnegotiated`.  
  
### <a name="issuedtokenovertransport"></a>IssuedTokenOverTransport  

 В этом режиме проверки подлинности клиент не проходит проверку подлинности на стороне службы; вместо этого клиент проходит проверку на стороне службы маркеров безопасности, получает маркер SAML, который затем представляет серверу, и, тем самым, подтверждает набор знаний общего ключа. Выданный маркер доступен на уровне SOAP в качестве разрешающего вспомогательного маркера либо в качестве маркера, не являющегося подтверждающим, т. е. маркера, которым подписана сигнатура сообщения. Служба проходит проверку подлинности с использованием сертификата X.509 на транспортном уровне. Элементом привязки безопасности является элемент `TransportSecurityBindingElement`, возвращаемый методом <xref:System.ServiceModel.Channels.SecurityBindingElement.CreateIssuedTokenOverTransportBindingElement%2A>. Можно также задать для атрибута `authenticationMode` значение `IssuedTokenOverTransport`.  
  
### <a name="kerberos"></a>Kerberos  

 В этом режиме проверка подлинности клиента на стороне службы осуществляется с использованием билета Kerberos. Этот же билет обеспечивает проверку подлинности сервера. Элементом привязки безопасности является элемент `SymmetricSecurityBindingElement`, возвращаемый методом <xref:System.ServiceModel.Channels.SecurityBindingElement.CreateKerberosBindingElement%2A>. Можно также задать для атрибута `authenticationMode` значение `Kerberos`.  
  
> [!NOTE]
> Для использования этого режима проверки подлинности учетная запись службы должна быть связана с именем субъекта-службы (SPN). Для этого запустите службу от имени учетной записи NETWORK SERVICE или LOCAL SYSTEM. Для создания для учетной записи службы имени участника-службы также можно воспользоваться средством SetSpn.exe. В любом случае клиент должен использовать правильное имя субъекта-службы в [\<servicePrincipalName>](../../configure-apps/file-schema/wcf/serviceprincipalname.md) элементе или с помощью <xref:System.ServiceModel.EndpointAddress> конструктора. Дополнительные сведения см. в статье [удостоверение службы и проверка подлинности](service-identity-and-authentication.md).  
  
> [!NOTE]
> При использовании режима проверки подлинности `Kerberos` уровни олицетворения <xref:System.Security.Principal.TokenImpersonationLevel.Anonymous> и <xref:System.Security.Principal.TokenImpersonationLevel.Delegation> не поддерживаются.  
  
### <a name="kerberosovertransport"></a>KerberosOverTransport  

 В этом режиме проверка подлинности клиента на стороне службы осуществляется с использованием билета Kerberos. Маркер Kerberos доступен на уровне SOAP в качестве разрешающего вспомогательного маркера, т. е. маркера, которым подписана подпись сообщения. Служба проходит проверку подлинности с использованием сертификата X.509 на транспортном уровне. Элементом привязки безопасности является элемент `TransportSecurityBindingElement`, возвращаемый методом <xref:System.ServiceModel.Channels.SecurityBindingElement.CreateKerberosOverTransportBindingElement%2A>. Можно также задать для атрибута `authenticationMode` значение `KerberosOverTransport`.  
  
> [!NOTE]
> Для использования этого режима проверки подлинности учетная запись службы должна быть связана с именем участника-службы (SPN). Для этого запустите службу от имени учетной записи NETWORK SERVICE или LOCAL SYSTEM. Для создания для учетной записи службы имени участника-службы также можно воспользоваться средством SetSpn.exe. В любом случае клиент должен использовать правильное имя субъекта-службы в [\<servicePrincipalName>](../../configure-apps/file-schema/wcf/serviceprincipalname.md) элементе или с помощью <xref:System.ServiceModel.EndpointAddress> конструктора. Дополнительные сведения см. в статье [удостоверение службы и проверка подлинности](service-identity-and-authentication.md).  
  
### <a name="mutualcertificate"></a>MutualCertificate  

 В этом режиме проверка подлинности клиента осуществляется с использованием сертификата X.509, который доступен на уровне SOAP в качестве разрешающего вспомогательного маркера, т. е. маркера, которым подписана подпись сообщения. Служба также проходит проверку подлинности с использованием сертификата X.509. Элементом привязки безопасности является элемент `SymmetricSecurityBindingElement`, возвращаемый методом <xref:System.ServiceModel.Channels.SecurityBindingElement.CreateMutualCertificateBindingElement%2A>. Можно также задать для атрибута `authenticationMode` значение `MutualCertificate`.  
  
### <a name="mutualcertificateduplex"></a>MutualCertificateDuplex  

 В этом режиме проверка подлинности клиента осуществляется с использованием сертификата X.509, который доступен на уровне SOAP в качестве разрешающего вспомогательного маркера, т. е. маркера, которым подписана подпись сообщения. Служба также проходит проверку подлинности с использованием сертификата X.509. Привязкой является элемент `AsymmetricSecurityBindingElement`, возвращаемый методом <xref:System.ServiceModel.Channels.SecurityBindingElement.CreateMutualCertificateDuplexBindingElement%2A>. Можно также задать для атрибута `authenticationMode` значение `MutualCertificateDuplex`.  
  
### <a name="mutualsslnegotiated"></a>MutualSslNegotiated  

 В этом режиме проверка подлинности клиента и службы осуществляется с использованием сертификатов X.509. Элементом привязки безопасности является объект `SymmetricSecurityBindingElement`, возвращаемый методом <xref:System.ServiceModel.Channels.SecurityBindingElement.CreateSslNegotiationBindingElement%2A>, если в качестве первого параметра передается значение `true`. Можно также задать для атрибута `authenticationMode` значение `MutualSslNegotiated`.  
  
### <a name="secureconversation"></a>SecureConversation  

 Элементом привязки безопасности является элемент `SymmetricSecurityBindingElement`, возвращаемый методом <xref:System.ServiceModel.Channels.SecurityBindingElement.CreateSecureConversationBindingElement%2A>. Этот метод принимает в качестве параметра объект <xref:System.ServiceModel.Channels.SecurityBindingElement>, который используется во время инициализации для установки защищенного сеанса. Можно также задать для атрибута `authenticationMode` значение `SecureConversation`.  
  
 Если привязка начальной загрузки не задана, то для начальной загрузки используется режим проверки подлинности `SspiNegotiated`.  
  
### <a name="sspinegotiation"></a>SspiNegotiation  

 В этом режиме для проверки подлинности клиента и сервера используется протокол согласования. Если это возможно, используется протокол Kerberos, в противном случае - протокол NT LanMan (NTLM). Элементом привязки безопасности является элемент `SymmetricSecurityBindingElement`, возвращаемый методом <xref:System.ServiceModel.Channels.SecurityBindingElement.CreateSspiNegotiationBindingElement%2A>. Можно также задать для атрибута `authenticationMode` значение `SspiNegotiated`.  
  
### <a name="sspinegotiatedovertransport"></a>SspiNegotiatedOverTransport  

 В этом режиме для проверки подлинности клиента и сервера используется протокол согласования. Если это возможно, используется протокол Kerberos, в противном случае - протокол NTLM. Результирующий маркер доступен на уровне SOAP в качестве разрешающего вспомогательного маркера, т. е. маркера, которым подписана подпись сообщения. Служба проходит дополнительную проверку подлинности на транспортном уровне с использованием сертификата X.509. Элементом привязки безопасности является элемент `TransportSecurityBindingElement`, возвращаемый методом <xref:System.ServiceModel.Channels.SecurityBindingElement.CreateSspiNegotiationOverTransportBindingElement%2A>. Можно также задать для атрибута `authenticationMode` значение `SspiNegotiatedOverTransport`.  
  
### <a name="usernameforcertificate"></a>UserNameForCertificate  

 В этом режиме проверка подлинности клиента на стороне службы осуществляется с использованием маркера имени пользователя, который доступен на уровне SOAP в качестве подписанного вспомогательного маркера, т. е. маркера, который подписан подписью сообщения. Проверка подлинности службы на стороне клиента осуществляется с помощью сертификата X.509. Элементом привязки безопасности является элемент `SymmetricSecurityBindingElement`, возвращаемый методом <xref:System.ServiceModel.Channels.SecurityBindingElement.CreateUserNameForCertificateBindingElement%2A>. Можно также задать для атрибута `authenticationMode` значение `UserNameForCertificate`.  
  
 В режиме проверки подлинности `UserNameForCertificate` клиент и служба должны использовать протокол WS-Security 1.1.  
  
### <a name="usernameforsslnegotiated"></a>UserNameForSslNegotiated  

 В этом режиме проверка подлинности клиента осуществляется с использованием маркера имени пользователя, который доступен на уровне SOAP в качестве подписанного вспомогательного маркера, т. е. маркера, который подписан подписью сообщения. Служба проходит проверку подлинности с использованием сертификата X.509. Элементом привязки безопасности является элемент `SymmetricSecurityBindingElement`, возвращаемый методом <xref:System.ServiceModel.Channels.SecurityBindingElement.CreateUserNameForSslBindingElement%2A>. Можно также задать для атрибута `authenticationMode` значение `UserNameForSslNegotiated`.  
  
### <a name="usernameovertransport"></a>UserNameOverTransport  

 В этом режиме проверка подлинности клиента осуществляется с использованием маркера имени пользователя, который доступен на уровне SOAP в качестве подписанного вспомогательного маркера, т. е. маркера, который подписан подписью сообщения. Служба проходит проверку подлинности с использованием сертификата X.509 на транспортном уровне. Элементом привязки безопасности является элемент `TransportSecurityBindingElement`, возвращаемый методом <xref:System.ServiceModel.Channels.SecurityBindingElement.CreateUserNameOverTransportBindingElement%2A>. Можно также задать для атрибута `authenticationMode` значение `UserNameOverTransport`.  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Channels.SecurityBindingElement>
- [Практическое руководство. Создание SecurityBindingElement для заданного режима проверки подлинности](how-to-create-a-securitybindingelement-for-a-specified-authentication-mode.md)

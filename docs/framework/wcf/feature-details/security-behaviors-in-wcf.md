---
description: Дополнительные сведения см. в статье поведение безопасности в WCF.
title: Поведения безопасности в WCF
ms.date: 03/30/2017
ms.assetid: 513232c0-39fd-4409-bda6-5ebd5e0ea7b0
ms.openlocfilehash: a9ebdc44b3770ab4d0cf931db4bf23c9a4cd8e4e
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99779859"
---
# <a name="security-behaviors-in-wcf"></a>Поведения безопасности в WCF

В Windows Communication Foundation (WCF) поведение изменяют поведение во время выполнения на уровне службы или на уровне конечной точки. (Дополнительные сведения о поведении в целом см. в разделе [Указание поведения службы Run-Time](../specifying-service-run-time-behavior.md).) *Поведения безопасности* позволяют управлять учетными данными, проверкой подлинности, авторизацией и журналами аудита. Поведения можно использовать путем программирования или через конфигурацию. В этом разделе основное внимание уделяется настройке следующих поведений, связанных с функциями безопасности:  
  
- [\<serviceCredentials>](../../configure-apps/file-schema/wcf/servicecredentials.md).  
  
- [\<clientCredentials>](../../configure-apps/file-schema/wcf/clientcredentials.md).  
  
- [\<serviceAuthorization>](../../configure-apps/file-schema/wcf/serviceauthorization-element.md).  
  
- [\<serviceSecurityAudit>](../../configure-apps/file-schema/wcf/servicesecurityaudit.md).  
  
- [\<serviceMetadata>](../../configure-apps/file-schema/wcf/servicemetadata.md), который также позволяет указать защищенную конечную точку, к которой клиенты могут обращаться для метаданных.  
  
## <a name="setting-credentials-with-behaviors"></a>Задание учетных данных с помощью поведений  

 Используйте [\<serviceCredentials>](../../configure-apps/file-schema/wcf/servicecredentials.md) и [\<clientCredentials>](../../configure-apps/file-schema/wcf/clientcredentials.md) для установки значений учетных данных для службы или клиента. Необходимость задания учетных данных определяется конфигурацией используемой привязки. Например, если задан режим безопасности `None`, ни клиенты, ни службы не проверяют подлинность друг друга и не требуют учетных данных какого-либо типа.  
  
 С другой стороны, привязка службы может требовать тип учетных данных клиента. В этом случае может потребоваться задать значение учетных данных с помощью поведения. (Дополнительные сведения о возможных типах учетных данных см. [в разделе Выбор типа учетных данных](selecting-a-credential-type.md).) В некоторых случаях, например при использовании учетных данных Windows для проверки подлинности, среда автоматически устанавливает фактическое значение учетных данных, и вам не нужно явно задавать значение учетных данных (если не требуется указывать другой набор учетных данных).  
  
 Все учетные данные службы обнаруживаются как дочерние элементы объекта [\<serviceBehaviors>](../../configure-apps/file-schema/wcf/servicebehaviors.md) . В следующем примере показан сертификат, используемый в качестве учетных данных службы.  
  
```xml  
<configuration>  
 <system.serviceModel>  
  <behaviors>  
   <serviceBehaviors>  
    <behavior name="ServiceBehavior1">  
     <serviceCredentials>  
      <serviceCertificate findValue="000000000000000000000000000"
                          storeLocation="CurrentUser"  
      storeName="Root" x509FindType="FindByThumbprint" />  
     </serviceCredentials>  
    </behavior>  
   </serviceBehaviors>  
  </behaviors>  
 </system.serviceModel>  
</configuration>  
```  
  
## <a name="service-credentials"></a>Учетные данные службы  

 [\<serviceCredentials>](../../configure-apps/file-schema/wcf/servicecredentials.md)Содержит четыре дочерних элемента. Эти элементы и их применение рассматриваются в следующих подразделах.  
  
### <a name="servicecertificate-element"></a>Элемент \<serviceCertificate>  

 Этот элемент используется для задания сертификата X.509, который используется для проверки подлинности службы при подключении к клиентам в режиме безопасности сообщений. Если используется сертификат, который периодически обновляется, то его отпечаток изменяется. В этом случае следует использовать имя субъекта в виде `X509FindType`, поскольку сертификат может быть выдан повторно с тем же именем субъекта.  
  
 Дополнительные сведения об использовании элемента см. в разделе [инструкции. Указание значений учетных данных клиента](../how-to-specify-client-credential-values.md).  
  
### <a name="certificate-of-clientcertificate-element"></a>\<certificate> элемента \<clientCertificate>  

 Используйте [\<certificate>](../../configure-apps/file-schema/wcf/certificate-of-clientcertificate-element.md) элемент, если служба должна заранее получить сертификат клиента, чтобы обеспечить безопасное взаимодействие с клиентом. Это характерно для дуплексного обмена данными. В более распространенном варианте "запрос/ответ" клиент включает сертификат в запрос, который используется службой для обеспечения безопасности отклика, направляемого назад клиенту. Однако при дуплексном обмене данными запросы и ответы не используются. Служба не может логически вывести сертификат клиента из передаваемых данных, поэтому служба должна заранее получить сертификат клиента, чтобы обеспечить безопасность сообщений для клиента. Необходимо получить сертификат клиента при согласовании вне диапазона и указать сертификат с помощью этого элемента. Дополнительные сведения о дуплексных службах см. [в разделе инструкции. Создание дуплексного контракта](how-to-create-a-duplex-contract.md).  
  
### <a name="authentication-of-clientcertificate-element"></a>\<authentication> элемента \<clientCertificate>  

 [\<authentication>](../../configure-apps/file-schema/wcf/authentication-of-clientcertificate-element.md)Элемент позволяет настроить проверку подлинности клиентов. Для атрибута `CertificateValidationMode` можно задать значение `None`, `ChainTrust`, `PeerOrChainTrust`, `PeerTrust` или `Custom`. По умолчанию уровень имеет значение `ChainTrust` , которое указывает, что каждый сертификат должен быть найден в иерархии сертификатов, которые заканчиваются *корневым центром* в верхней части цепочки. Это наиболее безопасный режим. Также можно установить значение `PeerOrChainTrust`, в этом случае будут приниматься как самостоятельно выдаваемые сертификаты (доверие одноранговой группы), так и сертификаты, которые находятся в цепи доверия. Данное значение используется при разработке и отладке клиентов и служб, так как самостоятельно выданные сертификаты не нужно приобретать у доверенного центра сертификации. При развертывании клиента вместо этого значения следует использовать значение `ChainTrust`. Также можно установить значение `Custom`. При установке значения `Custom` необходимо также задать атрибут `CustomCertificateValidatorType` для сборки и тип, который используется при проверке сертификата. Для создания собственного пользовательского модуля проверки необходимо наследование от абстрактного класса <xref:System.IdentityModel.Selectors.X509CertificateValidator>.  
  
### <a name="issuedtokenauthentication-element"></a>Элемент \<issuedTokenAuthentication>  

 В сценарии с выданным маркером имеется три этапа. На первом этапе клиент, пытающийся получить доступ к службе, ссылается на *службу токенов безопасности* (STS). Затем служба маркеров безопасности проводит проверку подлинности клиента и выдает клиенту маркер, обычно на языке Security Assertions Markup Language (SAML). После этого клиент возвращается к службе с этим маркером. Служба проверяет наличие в маркере данных, позволяющих проверить подлинность маркера и, соответственно, самого клиента. Для проверки подлинности маркера сертификат, используемый службой маркеров безопасности, должен быть известен службе. [\<issuedTokenAuthentication>](../../configure-apps/file-schema/wcf/issuedtokenauthentication-of-servicecredentials.md)Элемент является репозиторием для всех таких сертификатов службы безопасных маркеров. Чтобы добавить сертификаты, используйте [\<knownCertificates>](../../configure-apps/file-schema/wcf/knowncertificates.md) . Вставьте [\<add>](../../configure-apps/file-schema/wcf/add-of-knowncertificates.md) для каждого сертификата, как показано в следующем примере.  
  
```xml  
<issuedTokenAuthentication>  
   <knownCertificates>  
      <add findValue="www.contoso.com"
           storeLocation="LocalMachine" storeName="My"
           X509FindType="FindBySubjectName" />  
    </knownCertificates>  
</issuedTokenAuthentication>  
```  
  
 По умолчанию сертификаты должны быть получены от службы маркеров безопасности. Эти "известные" сертификаты гарантируют, что доступ к службе могут получить только допустимые клиенты.  
  
 Эту коллекцию следует использовать [\<allowedAudienceUris>](../../configure-apps/file-schema/wcf/allowedaudienceuris.md) в Федеративной приложении, использующем *службу токенов* безопасности (STS), которая выдает `SamlSecurityToken` маркеры защиты. При выпуске маркера безопасности служба STS также может указать универсальный код ресурса (URI) веб-служб, для которых предназначен маркер безопасности, добавив выражение `SamlAudienceRestrictionCondition` к маркеру безопасности. Это позволяет коду `SamlSecurityTokenAuthenticator` для веб-службы получателя проверить, что выданный маркер безопасности предназначен для данной службы, указав на необходимость выполнения соответствующей проверки. Для этого выполните следующие действия.  
  
- Задайте `audienceUriMode` для атрибута значение [\<issuedTokenAuthentication>](../../configure-apps/file-schema/wcf/issuedtokenauthentication-of-servicecredentials.md) `Always` или `BearerKeyOnly` .  
  
- Задайте набор допустимых универсальных кодов ресурса (URI), добавив их в данную коллекцию. Для этого вставьте [\<add>](../../configure-apps/file-schema/wcf/add-of-allowedaudienceuris.md) для каждого URI  
  
 Для получения дополнительной информации см. <xref:System.IdentityModel.Selectors.SamlSecurityTokenAuthenticator>.  
  
 Дополнительные сведения об использовании этого элемента конфигурации см. в разделе [как настроить учетные данные на служба федерации](how-to-configure-credentials-on-a-federation-service.md).  
  
#### <a name="allowing-anonymous-cardspace-users"></a>Разрешение анонимных пользователей CardSpace  

 Если для атрибута `AllowUntrustedRsaIssuers` элемента `<IssuedTokenAuthentication>` явно задано значение `true`, любой клиент может представить самостоятельно выданный маркер, подписанный произвольной парой ключей RSA. Поставщик не является *доверенным* , так как с ключом не связаны данные издателя. Пользователь CardSpace может создать собственную карточку, включающую собственные утверждения идентификации. Эту возможность следует использовать с осторожностью. Используя эту функцию, считайте открытый ключ RSA просто более безопасным паролем, который должен храниться в базе данных вместе с именем пользователя. Прежде чем разрешить клиенту доступ к службе, проверьте представленный клиентом открытый ключ RSA, сравнив его с хранящимся открытым ключом для указанного имени пользователя. Это подразумевает, что организован процесс регистрации, в котором пользователи могут регистрировать свои имена пользователя и связывать их с самостоятельно изданными открытыми ключами RSA.  
  
## <a name="client-credentials"></a>Учетные данные клиента  

 Учетные данные клиента используются для проверки подлинности клиента при подключении к службам в случаях, когда требуется взаимная проверка подлинности. Данный раздел можно использовать для задания сертификатов служб для сценариев, где клиент должен обеспечить защиту сообщений, передаваемых службе, с помощью сертификатов службы.  
  
 В рамках сценария федерации также можно настроить в клиенте использование токенов, выданных службой токенов безопасности или локальным источником токенов. Дополнительные сведения о федеративных сценариях см. в разделе [Федерация и выданные токены](federation-and-issued-tokens.md). Все учетные данные клиента находятся в [\<endpointBehaviors>](../../configure-apps/file-schema/wcf/endpointbehaviors.md) , как показано в следующем коде.  
  
```xml  
<behaviors>  
 <endpointBehaviors>  
  <behavior name="EndpointBehavior1">  
   <clientCredentials>  
    <clientCertificate findValue="cn=www.contoso.com"
        storeLocation="LocalMachine"  
        storeName="AuthRoot" x509FindType="FindBySubjectName" />  
    <serviceCertificate>  
     <defaultCertificate findValue="www.cohowinery.com"
                    storeLocation="LocalMachine"  
                    storeName="Root" x509FindType="FindByIssuerName" />  
    <authentication revocationMode="Online"  
                    trustedStoreLocation="LocalMachine" />  
    </serviceCertificate>  
   </clientCredentials>  
  </behavior>  
 </endpointBehaviors>  
</behaviors>  
```  
  
#### <a name="clientcertificate-element"></a>Элемент \<clientCertificate>  

 Задает сертификат, используемый для проверки подлинности клиента с помощью этого элемента. Дополнительные сведения см. [в разделе инструкции. Указание значений учетных данных клиента](../how-to-specify-client-credential-values.md).  
  
#### \<httpDigest>  

 Эта функция должна быть включена с помощью Active Directory в Windows и службах IIS. Дополнительные сведения см. [в статье дайджест-проверка подлинности в IIS 6,0](/previous-versions/windows/it-pro/windows-server-2003/cc782661(v=ws.10)).  
  
#### <a name="issuedtoken-element"></a>Элемент \<issuedToken>  

 [\<issuedToken>](../../configure-apps/file-schema/wcf/issuedtoken.md)Содержит элементы, используемые для настройки локального издателя маркеров или поведения, используемые в службе маркеров безопасности. Инструкции по настройке клиента для использования локального издателя см. [в разделе как настроить локальный издатель](how-to-configure-a-local-issuer.md).  
  
#### \<localIssuerAddress>  

 Задает адрес службы маркеров безопасности по умолчанию. Используется, когда не <xref:System.ServiceModel.WSFederationHttpBinding> предоставляет URL-адрес для службы маркеров безопасности или если адрес издателя Федеративной привязки — `http://schemas.microsoft.com/2005/12/ServiceModel/Addressing/Anonymous` или `null` . В этих случаях необходимо настроить объект <xref:System.ServiceModel.Description.ClientCredentials> с использованием адреса локального издателя и привязки, с помощью которой будет осуществляться взаимодействие с этим издателем.  
  
#### \<issuerChannelBehaviors>  

 Используйте [\<issuerChannelBehaviors>](../../configure-apps/file-schema/wcf/issuerchannelbehaviors-element.md) для добавления поведения клиента WCF, используемого при взаимодействии со службой маркеров безопасности. Определите поведение клиента в [\<endpointBehaviors>](../../configure-apps/file-schema/wcf/endpointbehaviors.md) разделе. Чтобы использовать определенное поведение, добавьте `add` элемент> <в `<issuerChannelBehaviors>` элемент с двумя атрибутами. Задайте в атрибуте `issuerAddress` URL-адрес службы маркеров безопасности, а в атрибуте `behaviorConfiguration` - имя определенного поведения конечной точки, как показано в следующем примере.  
  
```xml  
<clientCredentials>  
   <issuedToken>  
      <issuerChannelBehaviors>  
         <add issuerAddress="http://www.contoso.com"  
               behaviorConfiguration="clientBehavior1" />
      </issuerChannelBehaviors>  
   </issuedToken>  
</clientCredentials>
```  
  
#### <a name="servicecertificate-element"></a>Элемент \<serviceCertificate>  

 Этот элемент служит для управления проверкой подлинности сертификатов службы.  
  
 [\<defaultCertificate>](../../configure-apps/file-schema/wcf/defaultcertificate-element.md)Элемент может хранить один сертификат, используемый, если служба не указывает сертификат.  
  
 Используйте [\<scopedCertificates>](../../configure-apps/file-schema/wcf/scopedcertificates-element.md) и [\<add>](../../configure-apps/file-schema/wcf/add-of-scopedcertificates-element.md) для установки сертификатов служб, связанных с конкретными службами. Элемент `<add>` содержит атрибут `targetUri`, который служит для связывания сертификата со службой.  
  
 [\<authentication>](../../configure-apps/file-schema/wcf/authentication-of-servicecertificate-element.md)Элемент определяет уровень доверия, используемый для проверки подлинности сертификатов. По умолчанию для уровня устанавливается значение ChainTrust, указывающее, что каждый сертификат должен находиться в иерархии сертификатов, которая на самом верху цепи завершается доверенным центром сертификации. Это наиболее безопасный режим. Также можно установить значение PeerOrChainTrust. В этом случае будут приниматься как самостоятельно выдаваемые сертификаты (доверие одноранговой группы), так и сертификаты, которые находятся в цепочке доверия. Данное значение используется при разработке и отладке клиентов и служб, так как самостоятельно выданные сертификаты не нужно приобретать у доверенного центра сертификации. При развертывании клиента вместо этого значения следует использовать значение "ChainTrust". Также можно задать значение "Custom" или "None". Чтобы использовать значение "Custom", необходимо также установить для атрибута `CustomCertificateValidatorType` значение сборки и типа, которые используются при проверке сертификата. Для создания собственного пользовательского модуля проверки необходимо наследование от абстрактного класса <xref:System.IdentityModel.Selectors.X509CertificateValidator>. Дополнительные сведения см. [в разделе инструкции. Создание службы, использующей пользовательский проверяющий элемент управления для сертификатов](../extending/how-to-create-a-service-that-employs-a-custom-certificate-validator.md).  
  
 [\<authentication>](../../configure-apps/file-schema/wcf/authentication-of-servicecertificate-element.md)Элемент включает `RevocationMode` атрибут, указывающий способ проверки сертификатов для отзыва. По умолчанию используется значение online, которое указывает, что проверка отзыва сертификата выполняется автоматически. Дополнительные сведения см. в разделе [Работа с сертификатами](working-with-certificates.md).  
  
## <a name="serviceauthorization"></a>ServiceAuthorization  

 [\<serviceAuthorization>](../../configure-apps/file-schema/wcf/serviceauthorization-element.md)Элемент содержит элементы, влияющие на авторизацию, поставщиков пользовательских ролей и олицетворение.  
  
 Класс <xref:System.Security.Permissions.PrincipalPermissionAttribute> применяется к методу службы. Этот атрибут указывает группы пользователей, которые следует использовать при авторизации использования защищенного метода. Значение по умолчанию - "UseWindowsGroups". Оно указывает, что при попытке доступа к ресурсу поиск идентификации выполняется в таких группах Windows, как "Администраторы" или "Пользователи". Можно также указать "UseAspNetRoles", чтобы использовать пользовательский поставщик ролей, настроенный в `system.web` элементе <>, как показано в следующем коде.  
  
```xml  
<system.web>  
  <membership defaultProvider="SqlProvider"
   userIsOnlineTimeWindow="15">  
     <providers>  
       <clear />  
       <add
          name="SqlProvider"
          type="System.Web.Security.SqlMembershipProvider"
          connectionStringName="SqlConn"  
          applicationName="MembershipProvider"  
          enablePasswordRetrieval="false"  
          enablePasswordReset="false"  
          requiresQuestionAndAnswer="false"  
          requiresUniqueEmail="true"  
          passwordFormat="Hashed" />  
     </providers>  
   </membership>  
  <!-- Other configuration code not shown.-->  
</system.web>  
```  
  
 В следующем примере показано использование элемента `roleProviderName` с атрибутом `principalPermissionMode`.  
  
```xml  
<behaviors>  
 <behavior name="ServiceBehaviour">
  <serviceAuthorization principalPermissionMode ="UseAspNetRoles"
                        roleProviderName ="SqlProvider" />  
</behavior>
   <!-- Other configuration code not shown. -->  
</behaviors>  
```  
  
## <a name="configuring-security-audits"></a>Настройка аудита безопасности  

 Используйте, [\<serviceSecurityAudit>](../../configure-apps/file-schema/wcf/servicesecurityaudit.md) чтобы указать записываемый журнал и типы событий для записи в журнал. Дополнительные сведения см. в разделе [Audit](auditing-security-events.md).  
  
```xml  
<behaviors>
 <serviceBehaviors>  
  <behavior name="NewBehavior">  
    <serviceSecurityAudit auditLogLocation="Application"
             suppressAuditFailure="true"  
             serviceAuthorizationAuditLevel="Success"
             messageAuthenticationAuditLevel="Success" />  
  </behavior>  
 </serviceBehaviors>  
</behaviors>  
```  
  
## <a name="secure-metadata-exchange"></a>Безопасный обмен метаданными  

 Экспорт метаданных в клиенты удобен для разработчиков служб и клиентов, так как позволяет загружать конфигурацию и код клиента. Для снижения подверженности службы действиям недобросовестных пользователей перенос можно защитить с помощью механизма SSL по протоколу HTTP (HTTPS). Для этого необходимо вначале выполнить привязку подходящего сертификата X.509 к конкретному порту компьютера, на котором размещена служба. (Дополнительные сведения см. в разделе [Работа с сертификатами](working-with-certificates.md).) Во-вторых, добавьте в [\<serviceMetadata>](../../configure-apps/file-schema/wcf/servicemetadata.md) конфигурацию службы и присвойте `HttpsGetEnabled` атрибуту значение `true` . После этого следует присвоить атрибуту `HttpsGetUrl` URL-адрес конечной точки метаданных службы, как показано в следующем примере.  
  
```xml  
<behaviors>  
 <serviceBehaviors>  
  <behavior name="NewBehavior">  
    <serviceMetadata httpsGetEnabled="true"
     httpsGetUrl="https://myComputerName/myEndpoint" />  
  </behavior>  
 </serviceBehaviors>  
</behaviors>  
```  
  
## <a name="see-also"></a>См. также

- [Аудит](auditing-security-events.md)
- [Модель безопасности для Windows Server App Fabric](/previous-versions/appfabric/ee677202(v=azure.10))

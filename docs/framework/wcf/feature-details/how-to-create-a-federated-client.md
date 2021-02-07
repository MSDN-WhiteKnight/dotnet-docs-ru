---
description: Дополнительные сведения о том, как создать федеративный клиент.
title: Практическое руководство. Создание федеративного клиента
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- WCF, federation
- federation
ms.assetid: 56ece47e-98bf-4346-b92b-fda1fc3b4d9c
ms.openlocfilehash: 0078a07ff23dd364dcb8513a55e4ea6a54df40db
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99734742"
---
# <a name="how-to-create-a-federated-client"></a>Практическое руководство. Создание федеративного клиента

В Windows Communication Foundation (WCF) создание клиента для *федеративной службы* состоит из трех основных этапов:  
  
1. Настройте [\<wsFederationHttpBinding>](../../configure-apps/file-schema/wcf/wsfederationhttpbinding.md) или аналогичную пользовательскую привязку. Дополнительные сведения о создании подходящей привязки см. в разделе [инструкции. Создание WSFederationHttpBinding](how-to-create-a-wsfederationhttpbinding.md). Кроме того, запустите [служебную программу метаданных ServiceModel (Svcutil.exe)](../servicemodel-metadata-utility-tool-svcutil-exe.md) в конечной точке метаданных федеративной службы, чтобы создать файл конфигурации для взаимодействия с федеративной службой и одной или нескольких служб маркеров безопасности.  
  
2. Задайте свойства <xref:System.ServiceModel.Security.IssuedTokenClientCredential>, управляющие различными аспектами взаимодействия клиента со службой маркеров безопасности.  
  
3. Задайте свойства <xref:System.ServiceModel.Security.X509CertificateRecipientClientCredential>, разрешающие сертификаты, необходимые для безопасного обмена данными с определенными конечными точками, такими как служба маркеров безопасности.  
  
> [!NOTE]
> Исключение <xref:System.Security.Cryptography.CryptographicException> может возникнуть, если клиент использует олицетворенные учетные данные, привязку <xref:System.ServiceModel.WSFederationHttpBinding> или выданный пользовательский маркер и асимметричные ключи. Асимметричные ключи используются с привязкой <xref:System.ServiceModel.WSFederationHttpBinding> и выданными пользовательскими маркерами, если для свойств <xref:System.ServiceModel.FederatedMessageSecurityOverHttp.IssuedKeyType%2A> и <xref:System.ServiceModel.Security.Tokens.IssuedSecurityTokenParameters.KeyType%2A> соответственно задано значение <xref:System.IdentityModel.Tokens.SecurityKeyType.AsymmetricKey>. Исключение <xref:System.Security.Cryptography.CryptographicException> возникает, когда клиент пытается отправить сообщение, а для идентификации, которую олицетворяет клиент, отсутствует профиль пользователя. Чтобы подавить эту проблему, перед отправкой сообщения войдите в систему на клиентском компьютере или вызовите метод `LoadUserProfile`.  
  
 В этом разделе приведены подробные сведения об этих процедурах. Дополнительные сведения о создании подходящей привязки см. в разделе [инструкции. Создание WSFederationHttpBinding](how-to-create-a-wsfederationhttpbinding.md). Дополнительные сведения о работе федеративной службы см. в разделе [Федерация](federation.md).  
  
### <a name="to-generate-and-examine-the-configuration-for-a-federated-service"></a>Создание и проверка конфигурации для федеративной службы  
  
1. Запустите [средство служебной программы метаданных ServiceModel (Svcutil.exe)](../servicemodel-metadata-utility-tool-svcutil-exe.md) с адресом URL-адреса метаданных службы в качестве параметра командной строки.  
  
2. Откройте созданный файл конфигурации в подходящем редакторе.  
  
3. Изучите атрибуты и содержимое всех созданных [\<issuer>](../../configure-apps/file-schema/wcf/issuer.md) [\<issuerMetadata>](../../configure-apps/file-schema/wcf/issuermetadata.md) элементов и. Они находятся внутри [\<security>](../../configure-apps/file-schema/wcf/security-of-wsfederationhttpbinding.md) элементов для [\<wsFederationHttpBinding>](../../configure-apps/file-schema/wcf/wsfederationhttpbinding.md) элементов или пользовательских привязок. Убедитесь, что адреса содержат ожидаемые имена доменов или другую адресную информацию. Важно проверить эту информацию, так как клиент проверяет свою подлинность по этим адресам, и возможно раскрытие такой информации, как пары "имя пользователя-пароль". Если адреса отличаются от ожидаемых, это может привести к передаче информации неправильному получателю.  
  
4. Изучите дополнительные элементы в элементе [\<issuedTokenParameters>](../../configure-apps/file-schema/wcf/issuedtokenparameters.md) <> с комментарием `alternativeIssuedTokenParameters` . Если при использовании средства Svcutil.exe для создания конфигурации для федеративной службы эта федеративная служба или любая промежуточная служба маркеров безопасности указывает не адрес издателя, а адрес метаданных для службы маркеров безопасности с несколькими конечными точками, получающийся файл конфигурации ссылается на первую конечную точку. Дополнительные конечные точки находятся в файле конфигурации как <> элементов с комментариями `alternativeIssuedTokenParameters` .  
  
     Определите, является ли один из этих <`issuedTokenParameters`> предпочтительным для того, который уже существует в конфигурации. Например, клиент может предпочесть проверку подлинности в службе маркеров безопасности с помощью маркера Windows CardSpace, а не пары имя пользователя и пароль.  
  
    > [!NOTE]
    > Если перед началом взаимодействия со службой необходимо пройти через несколько служб маркеров безопасности, промежуточная служба маркеров безопасности может направить клиента в неправильную службу маркеров безопасности. Поэтому убедитесь, что конечная точка службы маркеров безопасности в [\<issuedTokenParameters>](../../configure-apps/file-schema/wcf/issuedtokenparameters.md) является ожидаемой службой маркеров безопасности, а не неизвестной службой маркеров безопасности.  
  
### <a name="to-configure-an-issuedtokenclientcredential-in-code"></a>Настройка IssuedTokenClientCredential в коде  
  
1. Получите доступ к <xref:System.ServiceModel.Security.IssuedTokenClientCredential> через свойство <xref:System.ServiceModel.Description.ClientCredentials.IssuedToken%2A> класса <xref:System.ServiceModel.Description.ClientCredentials> (возвращается свойством <xref:System.ServiceModel.ClientBase%601.ClientCredentials%2A> класса <xref:System.ServiceModel.ClientBase%601> или через класс <xref:System.ServiceModel.ChannelFactory>), как показано в следующем примере кода.  
  
     [!code-csharp[c_CreateSTS#9](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_creatests/cs/source.cs#9)]
     [!code-vb[c_CreateSTS#9](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_creatests/vb/source.vb#9)]  
  
2. Если кэширование маркера не требуется, установите для свойства <xref:System.ServiceModel.Security.IssuedTokenClientCredential.CacheIssuedTokens%2A> значение `false`. Свойство <xref:System.ServiceModel.Security.IssuedTokenClientCredential.CacheIssuedTokens%2A> определяет, будут ли кэшироваться такие маркеры, полученные от службы маркеров безопасности. Если для этого свойства задано значение `false`, клиент запрашивает новый маркер у службы маркеров безопасности каждый раз, когда ему требуется заново подтвердить свою подлинность в федеративной службе, независимо от того, действует ли еще предыдущий маркер. Если для этого свойства задано значение `true`, клиент повторно использует существующий маркер, когда ему требуется заново подтвердить свою подлинность в федеративной службе (до тех пор, пока не истечет срок действия этого маркера). Значение по умолчанию — `true`.  
  
3. Если для кэшированных маркеров требуется ограничение по времени, задайте для свойства <xref:System.ServiceModel.Security.IssuedTokenClientCredential.MaxIssuedTokenCachingTime%2A> значение <xref:System.TimeSpan>. Это свойство указывает, как долго маркер может оставаться в кэше. По истечении указанного времени маркер удаляется из кэша клиента. По умолчанию время нахождения маркеров в кэше не ограничено. В следующем примере задается промежуток времени 10 минут.  
  
     [!code-csharp[c_CreateSTS#15](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_creatests/cs/source.cs#15)]
     [!code-vb[c_CreateSTS#15](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_creatests/vb/source.vb#15)]  
  
4. Необязательный элемент. Задайте для <xref:System.ServiceModel.Security.IssuedTokenClientCredential.IssuedTokenRenewalThresholdPercentage%2A> значение в процентах. По умолчанию используется значение 60 процентов. Это свойство задается в процентах от срока действия маркера. Например, если срок действия выданного маркера составляет 10 часов, и для параметра <xref:System.ServiceModel.Security.IssuedTokenClientCredential.IssuedTokenRenewalThresholdPercentage%2A> задано значение 80, маркер обновляется через 8 часов. В следующем примере задается значение 80 процентов.  
  
     [!code-csharp[c_CreateSTS#16](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_creatests/cs/source.cs#16)]
     [!code-vb[c_CreateSTS#16](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_creatests/vb/source.vb#16)]  
  
     Интервал обновления, заданный сроком действия маркера и значением `IssuedTokenRenewalThresholdPercentage`, заменяется значением `MaxIssuedTokenCachingTime`, если время кэширования меньше порогового времени обновления. Например, если произведение `IssuedTokenRenewalThresholdPercentage` и срока действия маркера равно восьми часам, а значение `MaxIssuedTokenCachingTime` равно 10 минутам, клиент обращается в службу маркеров безопасности за обновленным маркером каждые 10 минут.  
  
5. Если для привязки требуется режим энтропии ключа, отличный от <xref:System.ServiceModel.Security.SecurityKeyEntropyMode.CombinedEntropy>, и при этом привязка не использует безопасность сообщений или безопасность транспорта с учетными данными сообщения (например, в привязке отсутствует элемент <xref:System.ServiceModel.Channels.SecurityBindingElement>), задайте свойству <xref:System.ServiceModel.Security.IssuedTokenClientCredential.DefaultKeyEntropyMode%2A> соответствующее значение. Режим *энтропии* определяет, можно ли управлять симметричными ключами с помощью <xref:System.ServiceModel.Security.IssuedTokenClientCredential.DefaultKeyEntropyMode%2A> Свойства. По умолчанию используется значение <xref:System.ServiceModel.Security.SecurityKeyEntropyMode.CombinedEntropy>, когда и клиент, и издатель маркера предоставляют данные, совместно используемые для создания фактического ключа. Также предусмотрены значения <xref:System.ServiceModel.Security.SecurityKeyEntropyMode.ClientEntropy> и <xref:System.ServiceModel.Security.SecurityKeyEntropyMode.ServerEntropy>, которые означают, что весь ключ задается клиентом или сервером соответственно. В следующем примере свойству задается значение, означающее, что для ключа используются только данные сервера.  
  
     [!code-csharp[c_CreateSTS#17](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_creatests/cs/source.cs#17)]
     [!code-vb[c_CreateSTS#17](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_creatests/vb/source.vb#17)]  
  
    > [!NOTE]
    > Если в привязке службы маркеров безопасности или службы присутствует элемент <xref:System.ServiceModel.Channels.SecurityBindingElement>, параметр <xref:System.ServiceModel.Security.IssuedTokenClientCredential.DefaultKeyEntropyMode%2A> со значением <xref:System.ServiceModel.Security.IssuedTokenClientCredential> переопределяется свойством <xref:System.ServiceModel.Channels.SecurityBindingElement.KeyEntropyMode%2A> элемента `SecurityBindingElement`.  
  
6. Настройте все поведения конечных точек, специфичных для издателя, добавив эти поведения в коллекцию, возвращаемую свойством <xref:System.ServiceModel.Security.IssuedTokenClientCredential.IssuerChannelBehaviors%2A>.  
  
     [!code-csharp[c_CreateSTS#14](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_creatests/cs/source.cs#14)]
     [!code-vb[c_CreateSTS#14](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_creatests/vb/source.vb#14)]  
  
### <a name="to-configure-the-issuedtokenclientcredential-in-configuration"></a>Настройка IssuedTokenClientCredential в конфигурации  
  
1. Создание [\<issuedToken>](../../configure-apps/file-schema/wcf/issuedtoken.md) элемента в качестве дочернего элемента [\<issuedToken>](../../configure-apps/file-schema/wcf/issuedtoken.md) в поведении конечной точки.  
  
2. Если кэширование маркеров не требуется, задайте `cacheIssuedTokens` атрибуту (элемента> <`issuedToken` ) значение `false` .  
  
3. Если для кэшированных токенов требуется ограничение по времени, задайте `maxIssuedTokenCachingTime` для атрибута в `issuedToken` элементе <> соответствующее значение. Пример:  
    `<issuedToken maxIssuedTokenCachingTime='00:10:00' />`  
  
4. Если предпочтительным является значение, отличное от значения по умолчанию, установите `issuedTokenRenewalThresholdPercentage` атрибут для `issuedToken` элемента <> в соответствующее значение, например:  
  
    ```xml  
    <issuedToken issuedTokenRenewalThresholdPercentage = "80" />  
    ```  
  
5. Если для привязки, не использующей безопасность сообщений или безопасность транспорта с учетными данными сообщения (например, в привязке отсутствует элемент `CombinedEntropy`), требуется режим энтропии ключа, отличный от `SecurityBindingElement`, задайте для атрибута `defaultKeyEntropyMode` элемента `<issuedToken>` требуемое значение `ServerEntropy` или `ClientEntropy`.  
  
    ```xml  
    <issuedToken defaultKeyEntropyMode = "ServerEntropy" />  
    ```  
  
6. Необязательный элемент. Настройте поведение пользовательской конечной точки, зависящей от поставщика, создав `issuerChannelBehaviors` элемент <> в качестве дочернего элемента <`issuedToken`>. Для каждого поведения создайте `add` элемент> <как дочерний элемент `issuerChannelBehaviors` элемента <>. Укажите адрес издателя поведения, задав `issuerAddress` атрибут для `add` элемента <>. Укажите поведение самостоятельно, задав `behaviorConfiguration` атрибут для `add` элемента <>.  
  
    ```xml  
    <issuerChannelBehaviors>  
    <add issuerAddress="http://fabrikam.org/sts" behaviorConfiguration="FabrikamSTS" />  
    </issuerChannelBehaviors>  
    ```  
  
### <a name="to-configure-an-x509certificaterecipientclientcredential-in-code"></a>Настройка X509CertificateRecipientClientCredential в коде  
  
1. Обратитесь к <xref:System.ServiceModel.Security.X509CertificateRecipientClientCredential> через свойство <xref:System.ServiceModel.Description.ClientCredentials.ServiceCertificate%2A> свойства <xref:System.ServiceModel.ClientBase%601.ClientCredentials%2A> класса <xref:System.ServiceModel.ClientBase%601> или свойство <xref:System.ServiceModel.ChannelFactory>.  
  
     [!code-csharp[c_CreateSTS#18](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_creatests/cs/source.cs#18)]
     [!code-vb[c_CreateSTS#18](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_creatests/vb/source.vb#18)]  
  
2. Если для сертификата для определенной конечной точки имеется экземпляр <xref:System.Security.Cryptography.X509Certificates.X509Certificate2>, используйте метод <xref:System.Collections.Generic.ICollection%601.Add%2A> коллекции, возвращаемой свойством <xref:System.ServiceModel.Security.X509CertificateRecipientClientCredential.ScopedCertificates%2A>.  
  
     [!code-csharp[c_CreateSTS#19](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_creatests/cs/source.cs#19)]
     [!code-vb[c_CreateSTS#19](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_creatests/vb/source.vb#19)]  
  
3. Если экземпляр <xref:System.Security.Cryptography.X509Certificates.X509Certificate2> отсутствует, используйте метод <xref:System.ServiceModel.Security.X509CertificateRecipientClientCredential.SetScopedCertificate%2A> класса <xref:System.ServiceModel.Security.X509CertificateRecipientClientCredential>, как показано в следующем примере.  
  
     [!code-csharp[c_CreateSTS#20](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_creatests/cs/source.cs#20)]
     [!code-vb[c_CreateSTS#20](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_creatests/vb/source.vb#20)]  
  
### <a name="to-configure-an-x509certificaterecipientclientcredential-in-configuration"></a>Настройка X509CertificateRecipientClientCredential в конфигурации  
  
1. Создайте [\<scopedCertificates>](../../configure-apps/file-schema/wcf/scopedcertificates-element.md) элемент в качестве дочернего элемента для [\<serviceCertificate>](../../configure-apps/file-schema/wcf/servicecertificate-of-clientcredentials-element.md) элемента, который сам является дочерним по отношению к [\<clientCredentials>](../../configure-apps/file-schema/wcf/clientcredentials.md) элементу в поведении конечной точки.  
  
2. Создайте элемент `<add>`, являющийся дочерним для элемента `<scopedCertificates>`. Задайте значения атрибутов `storeLocation`, `storeName`, `x509FindType` и `findValue`, указывающие на соответствующий сертификат. Задайте для атрибута `targetUri` значение, предоставляющее адрес конечной точки, для которой предназначен сертификат, как показано в следующем примере.  
  
    ```xml  
    <scopedCertificates>  
     <add targetUri="http://fabrikam.com/sts"
          storeLocation="CurrentUser"  
          storeName="TrustedPeople"  
          x509FindType="FindBySubjectName"  
          findValue="FabrikamSTS" />  
    </scopedCertificates>  
    ```  
  
## <a name="example"></a>Пример  

 В следующем примере кода экземпляр класса <xref:System.ServiceModel.Security.IssuedTokenClientCredential> настраивается в коде.  
  
 [!code-csharp[c_FederatedClient#2](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_federatedclient/cs/source.cs#2)]
 [!code-vb[c_FederatedClient#2](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_federatedclient/vb/source.vb#2)]  
  
## <a name="net-framework-security"></a>Безопасность .NET Framework  

 Для исключения возможного раскрытия информации клиенты, запускающие средство Svcutil.exe для обработки метаданных от федеральных конечных точек, должны проверять, что получающиеся адреса служб маркеров безопасности соответствуют ожидаемым. Это особенно важно, если служба маркеров безопасности предоставляет несколько конечных точек, так как средство Svcutil.exe задает в создаваемом файле конфигурации первую такую конечную точку, которая может отличаться от конечной точки, которую должен использовать клиент.  
  
## <a name="localissuer-required"></a>Требуется LocalIssuer  

 Если требуется, чтобы клиенты всегда использовали локального издателя, обратите внимание на следующее: выходные данные средства Svcutil.exe по умолчанию задают, что локальный издатель не используется, если в предпоследней службе маркеров безопасности в цепочке указан адрес издателя или адрес метаданных издателя.  
  
 Дополнительные сведения о настройке <xref:System.ServiceModel.Security.IssuedTokenClientCredential.LocalIssuerAddress%2A> <xref:System.ServiceModel.Security.IssuedTokenClientCredential.LocalIssuerBinding%2A> свойств, и класса см <xref:System.ServiceModel.Security.IssuedTokenClientCredential.LocalIssuerChannelBehaviors%2A> <xref:System.ServiceModel.Security.IssuedTokenClientCredential> . [в разделе как настроить локальный издатель](how-to-configure-a-local-issuer.md).  
  
## <a name="scoped-certificates"></a>Сертификаты с областью действия  

 Если требуется задать сертификаты службы для взаимодействия с любыми службами маркеров безопасности (обычно в связи с тем, что не используется согласование сертификатов), их можно задать с помощью свойства <xref:System.ServiceModel.Security.X509CertificateRecipientClientCredential.ScopedCertificates%2A> класса <xref:System.ServiceModel.Security.X509CertificateRecipientClientCredential>. Метод <xref:System.ServiceModel.Security.X509CertificateRecipientClientCredential.SetDefaultCertificate%2A> принимает в качестве параметров <xref:System.Uri> и <xref:System.Security.Cryptography.X509Certificates.X509Certificate2>. Указанный сертификат используется при взаимодействии с конечными точками по указанному универсальному коду ресурса (URI). В качестве альтернативы можно с помощью метода <xref:System.ServiceModel.Security.X509CertificateRecipientClientCredential.SetScopedCertificate%2A> добавить сертификат в коллекцию, возвращаемую свойством <xref:System.ServiceModel.Security.X509CertificateRecipientClientCredential.ScopedCertificates%2A>.  
  
> [!NOTE]
> Концепция сертификатов клиента, область действия которых ограничена только определенным универсальным кодом ресурса (URI), применима только к приложениям, производящим исходящие вызовы служб, предоставляющих конечные точки по этим универсальным кодам ресурса (URI). Он не применяется к сертификатам, которые используются для подписывания выданных маркеров, например, настроенных на сервере в коллекции, возвращаемой <xref:System.ServiceModel.Security.IssuedTokenServiceCredential.KnownCertificates%2A> <xref:System.ServiceModel.Security.IssuedTokenServiceCredential> классом. Дополнительные сведения см. в разделе [инструкции. Настройка учетных данных на служба федерации](how-to-configure-credentials-on-a-federation-service.md).  
  
## <a name="see-also"></a>См. также

- [Пример федерации](../samples/federation-sample.md)
- [Практическое руководство. Порядок отключения безопасных сеансов в WSFederationHttpBinding](how-to-disable-secure-sessions-on-a-wsfederationhttpbinding.md)
- [Практическое руководство. Создание WSFederationHttpBinding](how-to-create-a-wsfederationhttpbinding.md)
- [Практическое руководство. Настройка учетных данных службы федерации](how-to-configure-credentials-on-a-federation-service.md)
- [Практическое руководство. Настройка локального издателя](how-to-configure-a-local-issuer.md)
- [Вопросы безопасности при использовании метаданных](security-considerations-with-metadata.md)
- [Практическое руководство. Защита конечных точек метаданных](how-to-secure-metadata-endpoints.md)

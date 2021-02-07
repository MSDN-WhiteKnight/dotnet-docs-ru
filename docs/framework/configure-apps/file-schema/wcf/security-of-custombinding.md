---
description: 'Дополнительные сведения <security> о: <customBinding>'
title: <security> из <customBinding>
ms.date: 03/30/2017
ms.assetid: 243a5148-bbd1-447f-a8a5-6e7792c0a3f1
ms.openlocfilehash: 0c7a534754f19d46984911ba1dec60d9c517e6b6
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99683246"
---
# <a name="security-of-custombinding"></a>\<security> из \<customBinding>

Задает параметры безопасности для пользовательской привязки.  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<system.serviceModel>**](system-servicemodel.md)\
&nbsp;&nbsp;&nbsp;&nbsp;[**\<bindings>**](bindings.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<customBinding>**](custombinding.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<binding>**\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<security>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<security allowSerializedSigningTokenOnReply="Boolean"
          authenticationMode="AuthenticationMode"
          defaultAlgorithmSuite="SecurityAlgorithmSuite"
          includeTimestamp="Boolean"
          requireDerivedKeys="Boolean"
          keyEntropyMode="ClientEntropy/ServerEntropy/CombinedEntropy"
          messageProtectionOrder="SignBeforeEncrypt/SignBeforeEncryptAndEncryptSignature/EncryptBeforeSign"
          messageSecurityVersion="WSSecurityJan2004/WSSecurityXXX2005"
          requireDerivedKeys="Boolean"
          requireSecurityContextCancellation="Boolean"
          requireSignatureConfirmation="Boolean"
          securityHeaderLayout="Strict/Lax/LaxTimestampFirst/LaxTimestampLast">
   <issuedTokenParameters />
   <localClientSettings />
   <localServiceSettings />
   <secureConversationBootstrap />
</security>
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описываются атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|allowSerializedSigningTokenOnReply|Необязательный элемент. Логическое значение, определяющее, может ли в ответе использоваться сериализованный маркер. Значение по умолчанию — `false`. При использовании двойной привязки для всех параметров, имеющих значение по умолчанию `true`, пропускаются любые заданные параметры.|  
|authenticationMode|Необязательный элемент. Указывает режим проверки подлинности, используемый между инициатором и отвечающим устройством. Список значений приведен ниже.<br /><br /> Значение по умолчанию — `sspiNegotiated`.|  
|defaultAlgorithmSuite|Необязательный элемент. Задает алгоритмы шифрования сообщений и ключей. Алгоритмы и размеры ключей определяются классом <xref:System.ServiceModel.Security.SecurityAlgorithmSuite>. Эти алгоритмы соответствуют алгоритмам, заданным в спецификации языка политики безопасности (WS-SecurityPolicy).<br /><br /> Допустимые значения приведены ниже. Значение по умолчанию — `Basic256`.<br /><br /> Этот атрибут используется при работе с другой платформой, которая использует набор алгоритмов, отличный от набора по умолчанию. При внесении изменений в параметры настройки необходимо знать о сильных и слабых сторонах соответствующих алгоритмов. Это атрибут типа <xref:System.ServiceModel.Security.SecurityAlgorithmSuite>.|  
|includeTimestamp|Логическое значение, определяющее, включается ли в каждое сообщение отметка времени. Значение по умолчанию — `true`.|  
|keyEntropyMode|Указывает способ вычисления ключей для защиты сообщений. Ключи могут быть основаны только на данных ключа клиента, только на данных ключа службы или на сочетании обоих типов данных. Допустимы следующие значения:<br /><br /> -   `ClientEntropy`: Ключ сеанса основан на данных ключа, предоставленных клиентом.<br />-   `ServerEntropy`: Сеансовый ключ основан на данных ключей, предоставляемых сервером.<br />-   `CombinedEntropy`: Ключ сеанса основан на данных ключа, предоставляемых клиентом и службой.<br /><br /> Значение по умолчанию — `CombinedEntropy`.<br /><br /> Это атрибут типа <xref:System.ServiceModel.Security.SecurityKeyEntropyMode>.|  
|messageProtectionOrder|Определяет порядок, в котором к сообщению применяются алгоритмы безопасности уровня сообщения. Допустимые значения.<br /><br /> -   `SignBeforeEncrypt`: Сначала Подпишитесь, а затем зашифруйте.<br />-   `SignBeforeEncryptAndEncryptSignature`: Сначала подпишите, зашифруйте, а затем зашифруйте подпись.<br />-   `EncryptBeforeSign`: Сначала зашифруйте, а затем Sign.<br /><br /> Значение по умолчанию зависит от используемой версии WS-Security. Значение по умолчанию - `SignBeforeEncryptAndEncryptSignature`, если используется WS-Security 1,1. Значение по умолчанию - `SignBeforeEncrypt`, если используется WS-Security 1.0.<br /><br /> Это атрибут типа <xref:System.ServiceModel.Security.MessageProtectionOrder>.|  
|messageSecurityVersion|Необязательный элемент. Задает используемую версию WS-Security. Допустимые значения.<br /><br /> - WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11<br />- WSSecurity10WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11BasicSecurityProfile10<br />- WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11BasicSecurityProfile10<br /><br /> Значение по умолчанию - WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11, которое может быть выражено в формате XML просто как `Default`. Это атрибут типа <xref:System.ServiceModel.MessageSecurityVersion>.|  
|requireDerivedKeys|Логическое значение, которое указывает, могут ли ключи быть производными от исходных ключей проверки. Значение по умолчанию — `true`.|  
|requireSecurityContextCancellation|Необязательный элемент. Логическое значение, определяющее, следует ли отменять и завершать контекст безопасности, когда он больше не нужен. Значение по умолчанию — `true`.|  
|requireSignatureConfirmation|Необязательный элемент. Логическое значение, определяющее, включено ли подтверждение сигнатуры WS-Security. Если установлено значение `true`, то сигнатуры сообщений подтверждаются респондентом.  Если пользовательская привязка настроена для использования взаимных сертификатов или выданных маркеров (привязки WSS 1.1), то этот атрибут имеет значение по умолчанию `true`. В противном случае значение по умолчанию — `false`.<br /><br /> Подтверждение сигнатуры используется для подтверждения того, что служба отвечает, получив запрос полностью.|  
|securityHeaderLayout|Необязательный элемент. Определяет порядок расположения элементов в заголовке безопасности. Допустимы следующие значения:<br /><br /> -   `Strict`: Элементы добавляются в заголовок безопасности в соответствии с общим принципом "объявление перед использованием".<br />-   `Lax`: Элементы добавляются в заголовок безопасности в любом порядке, который подтверждает безопасность сообщений WSS: SOAP.<br />-   `LaxWithTimestampFirst`: Элементы добавляются в заголовок безопасности в любом порядке, который подтверждает безопасность сообщений WSS: SOAP, за исключением того, что первым элементом в заголовке безопасности должен быть элемент wsse: timestamp.<br />-   `LaxWithTimestampLast`: Элементы добавляются в заголовок безопасности в любом порядке, который подтверждает безопасность сообщений WSS: SOAP, за исключением того, что последним элементом в заголовке безопасности должен быть элемент wsse: timestamp.<br /><br /> Значение по умолчанию — `Strict`.<br /><br /> Это элемент типа <xref:System.ServiceModel.Channels.SecurityHeaderLayout>.|  
  
## <a name="authenticationmode-attribute"></a>Атрибут authenticationMode  
  
|Значение|Описание|  
|-----------|-----------------|  
|Строка|`AnonymousForCertificate`<br /><br /> `AnonymousForSslNegotiated`<br /><br /> `CertificateOverTransport`<br /><br /> `IssuedToken`<br /><br /> `IssuedTokenForCertificate`<br /><br /> `IssuedTokenForSslNegotiated`<br /><br /> `IssuedTokenOverTransport`<br /><br /> `Kerberos`<br /><br /> `KerberosOverTransport`<br /><br /> `MutualCertificate`<br /><br /> `MutualCertificateDuplex`<br /><br /> `MutualSslNegotiated`<br /><br /> `SecureConversation`<br /><br /> `SspiNegotiated`<br /><br /> `UserNameForCertificate`<br /><br /> `UserNameForSslNegotiated`<br /><br /> `UserNameOverTransport`<br /><br /> `SspiNegotiatedOverTransport`|  
  
## <a name="defaultalgorithm-attribute"></a>Атрибут defaultAlgorithm  
  
|Значение|Описание|  
|-----------|-----------------|  
|Basic128|Используется шифрование Aes128, Sha1 для хэша и Rsa-oaep-mgf1p для шифрования ключа.|  
|Basic192|Используется шифрование Aes192, Sha1 для хэша и Rsa-oaep-mgf1p для шифрования ключа.|  
|Basic256|Используется шифрование Aes256, Sha1 для хэш-кода и Rsa-oaep-mgf1p для шифрования ключа.|  
|Basic256Rsa15|Используется Aes256 для шифрования сообщения, Sha1 для хэш-кода и Rsa15 для шифрования ключа.|  
|Basic192Rsa15|Используется Aes192 для шифрования сообщения, Sha1 для хэш-кода и Rsa15 для шифрования ключа.|  
|TripleDes|Используется шифрование TripleDes, Sha1 для хэша и Rsa-oaep-mgf1p для шифрования ключа.|  
|Basic128Rsa15|Используется Aes128 для шифрования сообщения, Sha1 для хэш-кода и Rsa15 для шифрования ключа.|  
|TripleDesRsa15|Используется TripleDes для шифрования сообщения, Sha1 для хэш-кода и Rsa15 для шифрования ключа.|  
|Basic128Sha256|Используется Aes256 для шифрования сообщения, Sha256 для хэша и Rsa-oaep-mgf1p для шифрования ключа.|  
|Basic192Sha256|Используется Aes192 для шифрования сообщения, Sha256 для хэш-кода и Rsa-oaep-mgf1p для шифрования ключа.|  
|Basic256Sha256|Используется Aes256 для шифрования сообщения, Sha256 для хэша и Rsa-oaep-mgf1p для шифрования ключа.|  
|TripleDesSha256|Используется TripleDes для шифрования сообщения, Sha256 для хэш-кода и Rsa-oaep-mgf1p для шифрования ключа.|  
|Basic128Sha256Rsa15|Используется Aes128 для шифрования сообщения, Sha256 для хэш-кода и Rsa15 для шифрования ключа.|  
|Basic192Sha256Rsa15|Используется Aes192 для шифрования сообщения, Sha256 для хэш-кода и Rsa15 для шифрования ключа.|  
|Basic256Sha256Rsa15|Используется Aes256 для шифрования сообщения, Sha256 для хэша и Rsa15 для шифрования ключа.|  
|TripleDesSha256Rsa15|Используется TripleDes для шифрования сообщения, Sha256 для хэш-кода и Rsa15 для шифрования ключа.|  
  
### <a name="child-elements"></a>Дочерние элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<issuedTokenParameters>](issuedtokenparameters.md)|Определяет текущий выданный маркер. Это элемент типа <xref:System.ServiceModel.Configuration.IssuedTokenParametersElement>.|  
|[\<localClientSettings>](localclientsettings-element.md)|Задает параметры безопасности локального клиента для этой привязки. Это элемент типа <xref:System.ServiceModel.Configuration.LocalClientSecuritySettingsElement>.|  
|[\<localServiceSettings>](localservicesettings-element.md)|Задает параметры безопасности локальной службы для этой привязки. Это элемент типа <xref:System.ServiceModel.Configuration.LocalServiceSecuritySettingsElement>.|  
|[\<secureConversationBootstrap>](secureconversationbootstrap.md)|Задает значения по умолчанию, используемые для инициализации службы безопасного обмена данными.|  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<binding>](bindings.md)|Определяет все возможности пользовательской привязки.|  
  
## <a name="remarks"></a>Remarks  

 Дополнительные сведения об использовании этого элемента см. в статьях [режимы проверки подлинности SecurityBindingElement](../../../wcf/feature-details/securitybindingelement-authentication-modes.md) и [инструкции: создание пользовательской привязки с помощью SecurityBindingElement](../../../wcf/feature-details/how-to-create-a-custom-binding-using-the-securitybindingelement.md).  
  
## <a name="example"></a>Пример  

 В следующем примере показано, как настроить параметры безопасности с помощью настраиваемой привязки. Здесь показано, как использовать пользовательскую привязку для включения безопасности на уровне сообщений вместе с безопасным транспортом. Это полезно, когда требуется передавать сообщения между клиентом и службой с помощью безопасного транспорта с одновременным обеспечением безопасности на уровне сообщений. Эта конфигурация не поддерживается привязками, предоставляемыми системой.  
  
 Конфигурация службы определяет настраиваемую привязку, которая поддерживает обмен данными по протоколу TCP с защитой протоколом TLS/SSL и системой безопасности сообщений Windows. Пользовательская привязка использует сертификат службы для проверки подлинности службы на уровне транспорта и для защиты сообщений при передаче между клиентом и службой. Это достигается [\<sslStreamSecurity>](sslstreamsecurity.md) элементом Binding. Сертификат службы настраивается с помощью поведения службы.  
  
 Кроме того, пользовательская привязка использует безопасность сообщений с типом учетных данных Windows, который является типом учетных данных по умолчанию. Это достигается элементом привязки [безопасности](security-of-custombinding.md) . Если доступен механизм проверки подлинности Kerberos, то проверка подлинности как клиента, так и службы выполняется с использованием безопасности уровня сообщений. Если механизм проверки подлинности Kerberos недоступен, используется проверка подлинности NTLM. NTLM выполняет проверку подлинности клиента при подключении к службе, но не выполняет проверку подлинности службы при подключении к клиенту. Элемент привязки [безопасности](security-of-custombinding.md) настраивается для использования `SecureConversation` authenticationType, что приводит к созданию сеанса безопасности на клиенте и в службе. Это требуется для обеспечения работы дуплексного контракта службы. Дополнительные сведения о выполнении этого примера см. в разделе [Безопасность пользовательской привязки](../../../wcf/samples/custom-binding-security.md).  
  
```xml  
<configuration>
  <system.serviceModel>
    <services>
      <service name="Microsoft.ServiceModel.Samples.CalculatorService"
               behaviorConfiguration="CalculatorServiceBehavior">
        <host>
          <baseAddresses>
            <!-- use following base address -->
            <add baseAddress="net.tcp://localhost:8000/ServiceModelSamples/Service"/>
          </baseAddresses>
        </host>
        <endpoint address=""
                  binding="customBinding"
                  bindingConfiguration="Binding1"
                  contract="Microsoft.ServiceModel.Samples.ICalculatorDuplex" />
        <!-- the mex endpoint is exposed at net.tcp://localhost:8000/ServiceModelSamples/service/mex -->
        <endpoint address="mex"
                  binding="mexTcpBinding"
                  contract="IMetadataExchange" />
      </service>
    </services>
    <bindings>
      <!-- configure a custom binding -->
      <customBinding>
        <binding name="Binding1">
          <security authenticationMode="SecureConversation"
                    requireSecurityContextCancellation="true">
          </security>
          <textMessageEncoding messageVersion="Soap12WSAddressing10"
                               writeEncoding="utf-8" />
          <sslStreamSecurity requireClientCertificate="false" />
          <tcpTransport />
        </binding>
      </customBinding>
    </bindings>
    <!--For debugging purposes set the includeExceptionDetailInFaults attribute to true-->
    <behaviors>
      <serviceBehaviors>
        <behavior name="CalculatorServiceBehavior">
          <serviceMetadata />
          <serviceDebug includeExceptionDetailInFaults="False" />
          <serviceCredentials>
            <serviceCertificate findValue="localhost"
                                storeLocation="LocalMachine"
                                storeName="My"
                                x509FindType="FindBySubjectName" />
          </serviceCredentials>
        </behavior>
      </serviceBehaviors>
    </behaviors>
  </system.serviceModel>
</configuration>
```  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Configuration.SecurityElement>
- <xref:System.ServiceModel.Channels.SecurityBindingElement>
- <xref:System.ServiceModel.Channels.CustomBinding>
- [Привязки](../../../wcf/bindings.md)
- [Расширение привязок](../../../wcf/extending/extending-bindings.md)
- [Пользовательские привязки](../../../wcf/extending/custom-bindings.md)
- [\<customBinding>](custombinding.md)
- [Практическое руководство. Создание пользовательской привязки с использованием элемента SecurityBindingElement](../../../wcf/feature-details/how-to-create-a-custom-binding-using-the-securitybindingelement.md)
- [Безопасность пользовательской привязки](../../../wcf/samples/custom-binding-security.md)

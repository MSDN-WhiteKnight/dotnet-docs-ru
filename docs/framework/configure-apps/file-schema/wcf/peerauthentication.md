---
description: 'Дополнительные сведения: <peerAuthentication>'
title: <peerAuthentication>
ms.date: 03/30/2017
ms.assetid: ad545e6f-f06e-4549-ac92-09d758d5c636
ms.openlocfilehash: b640b4aac296c40fadcc5f4070ba58e5f92fd265
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99683662"
---
# \<peerAuthentication>

Задает параметры проверки подлинности для сертификата однорангового узла, используемого одноранговым узлом.  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<system.serviceModel>**](system-servicemodel.md)\
&nbsp;&nbsp;&nbsp;&nbsp;[**\<behaviors>**](behaviors.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<serviceBehaviors>**](servicebehaviors.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<behavior>**](behavior-of-servicebehaviors.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<serviceCredentials>**](servicecredentials.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<peer>**](peer-of-servicecredentials.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<peerAuthentication>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<peerAuthentication customCertificateValidatorType="namespace.typeName, [,AssemblyName] [,Version=version number] [,Culture=culture] [,PublicKeyToken=token]"
                    certificateValidationMode="ChainTrust/None/PeerTrust/PeerOrChainTrust/Custom"
                    revocationMode="NoCheck/Online/Offline"
                    trustedStoreLocation="CurrentUser/LocalMachine" />
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|`certificateValidationMode`|Необязательное перечисление. Задает один из трех режимов для проверки учетных данных. Это атрибут типа <xref:System.ServiceModel.Security.X509CertificateValidationMode>. Если свойству присвоено значение `Custom`, также необходимо указать свойство `customCertificateValidator`.|  
|`customCertificateValidatorType`|Необязательная строка. Задает тип и сборку, используемые для проверки пользовательского типа. Этот атрибут должен быть задан, когда `certificateValidationMode` имеет значение `Custom`. Это атрибут типа <xref:System.IdentityModel.Selectors.X509CertificateValidator>. Windows Communication Foundation (WCF) предоставляет средство проверки однорангового сертификата по умолчанию, которое проверяет одноранговый сертификат в хранилище доверенных лиц. Он также проверяет цепочку сертификатов вплоть до действительного корня. Можно реализовать пользовательский модуль проверки для задания другого поведения и использовать этот атрибут для указания на пользовательский модуль проверки.|  
|`revocationMode`|Необязательное перечисление. Задает режим отзыва сертификатов. Это атрибут типа <xref:System.Security.Cryptography.X509Certificates.X509RevocationMode>. Система проверяет, что одноранговый сертификат не отозван, проводя его поиск в списке отозванных сертификатов. Эта проверка выполняется либо в сети, либо в кэшированном списке отзыва. Проверку отзыва сертификатов можно отключить, задав этому атрибуту значение NoCheck.|  
|`trustedStoreLocation`|Необязательное перечисление. Указывает расположение доверенного хранилища, в котором система безопасности WCF проверяет сертификат однорангового узла. Это атрибут типа <xref:System.Security.Cryptography.X509Certificates.StoreLocation>.|  
  
### <a name="child-elements"></a>Дочерние элементы  

 Отсутствует.  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<peer>](peer-of-servicecredentials.md)|Задает текущие учетные данные для однорангового узла.|  
  
## <a name="remarks"></a>Remarks  

 Элемент `<authentication>` соответствует классу <xref:System.ServiceModel.Security.X509PeerCertificateAuthentication>. Этот элемент задает модуль проверки, который вызывается во время проверки подлинности «от соседа к соседу» в сетке. Когда новый одноранговый узел пытается установить соединение с соседним узлом, он передает свои учетные данные в отвечающий одноранговый узел. Для проверки учетных данных удаленной стороны вызывается проверяющий элемент управления отвечающего узла. Как только в сетке устанавливается одноранговое соединение, оба одноранговых узла выполняют взаимную проверку подлинности. Это означает, что вызываются проверяющие элементы управления на обоих концах.  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Configuration.PeerCredentialElement>
- <xref:System.ServiceModel.Security.X509PeerCertificateAuthentication>
- <xref:System.ServiceModel.Security.PeerCredential.PeerAuthentication%2A>
- <xref:System.ServiceModel.Configuration.PeerCredentialElement.PeerAuthentication%2A>
- <xref:System.ServiceModel.Configuration.X509PeerCertificateAuthenticationElement>
- [Работа с сертификатами](../../../wcf/feature-details/working-with-certificates.md)
- [Одноранговая сеть](../../../wcf/feature-details/peer-to-peer-networking.md)
- [Проверка подлинности сообщений для однорангового канала](/previous-versions/dotnet/netframework-3.5/aa967730(v=vs.90))
- [Пользовательской проверка подлинности для однорангового канала](/previous-versions/dotnet/netframework-3.5/ms751447(v=vs.90))
- [Защита приложений одноранговых каналов](../../../wcf/feature-details/securing-peer-channel-applications.md)

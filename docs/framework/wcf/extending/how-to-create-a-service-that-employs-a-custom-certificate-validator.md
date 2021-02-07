---
description: Дополнительные сведения о том, как создать службу, использующую настраиваемый проверяющий сертификат.
title: Практическое руководство. Создание службы, использующей пользовательский проверяющий элемент управления для сертификатов
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- WCF, authentication
ms.assetid: bb0190ff-0738-4e54-8d22-c97d343708bf
ms.openlocfilehash: 8ed5d23143b7b69768cc556d9fd5663e46fd7da7
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99668985"
---
# <a name="how-to-create-a-service-that-employs-a-custom-certificate-validator"></a>Практическое руководство. Создание службы, использующей пользовательский проверяющий элемент управления для сертификатов

В данном разделе показано, как реализовать пользовательский проверяющий элемент управления для сертификата и как настроить учетные данные клиента или службы, чтобы заменить логику проверки сертификата по умолчанию пользовательским проверяющим элементом управления для сертификата.  
  
 Если сертификат X. 509 используется для проверки подлинности клиента или службы, Windows Communication Foundation (WCF) по умолчанию использует хранилище сертификатов Windows и API шифрования, чтобы проверить сертификат и убедиться, что он является доверенным. Иногда встроенных функциональных возможностей проверки сертификатов недостаточно, их необходимо изменить. WCF предоставляет простой способ изменения логики проверки, позволяя пользователям добавлять пользовательские средства проверки сертификатов. Если указан пользовательский проверяющий элемент управления для сертификата, WCF не использует встроенную логику проверки сертификата, но использует вместо этого пользовательский проверяющий элемент управления.  
  
## <a name="procedures"></a>Процедуры  
  
#### <a name="to-create-a-custom-certificate-validator"></a>Создание пользовательского проверяющего элемента управления для сертификата  
  
1. Определите новый производный класс на основе класса <xref:System.IdentityModel.Selectors.X509CertificateValidator>.  
  
2. Реализуйте абстрактный метод <xref:System.IdentityModel.Selectors.X509CertificateValidator.Validate%2A>. Сертификат, который необходимо проверить, передается методу как аргумент. Если переданный сертификат недопустим согласно логике проверки, этот метод создает исключение <xref:System.IdentityModel.Tokens.SecurityTokenValidationException>. Если сертификат действителен, метод возвращает его вызывающей стороне.  
  
    > [!NOTE]
    > Чтобы вернуть ошибки проверки подлинности клиенту, создайте исключение <xref:System.ServiceModel.FaultException> в методе <xref:System.IdentityModel.Selectors.UserNamePasswordValidator.Validate%2A>.  
  
 [!code-csharp[c_CustomCertificateValidator#2](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_customcertificatevalidator/cs/source.cs#2)]
 [!code-vb[c_CustomCertificateValidator#2](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_customcertificatevalidator/vb/source.vb#2)]  
  
#### <a name="to-specify-a-custom-certificate-validator-in-service-configuration"></a>Задание пользовательского проверяющего элемента управления для сертификата в конфигурации службы  
  
1. Добавьте [\<behaviors>](../../configure-apps/file-schema/wcf/behaviors.md) элемент и в [\<serviceBehaviors>](../../configure-apps/file-schema/wcf/servicebehaviors.md) [\<system.serviceModel>](../../configure-apps/file-schema/wcf/system-servicemodel.md) элемент.  
  
2. Добавьте [\<behavior>](../../configure-apps/file-schema/wcf/behavior-of-endpointbehaviors.md) и задайте `name` для атрибута соответствующее значение.  
  
3. Добавьте в [\<serviceCredentials>](../../configure-apps/file-schema/wcf/servicecredentials.md) `<behavior>` элемент.  
  
4. Добавьте элемент `<clientCertificate>` в элемент `<serviceCredentials>`.  
  
5. Добавьте [\<authentication>](../../configure-apps/file-schema/wcf/authentication-of-clientcertificate-element.md) в `<clientCertificate>` элемент.  
  
6. Задайте для атрибута `customCertificateValidatorType` тип проверяющего элемента управления. В следующем примере для атрибута задано значение пространства имен и имени типа.  
  
7. Задайте для атрибута `certificateValidationMode` значение `Custom`.  
  
    ```xml  
    <configuration>  
     <system.serviceModel>  
      <behaviors>  
       <serviceBehaviors>  
        <behavior name="ServiceBehavior">  
         <serviceCredentials>  
          <clientCertificate>  
          <authentication certificateValidationMode="Custom" customCertificateValidatorType="Samples.MyValidator, service" />  
          </clientCertificate>  
         </serviceCredentials>  
        </behavior>  
       </serviceBehaviors>  
      </behaviors>  
    </system.serviceModel>  
    </configuration>  
    ```  
  
#### <a name="to-specify-a-custom-certificate-validator-using-configuration-on-the-client"></a>Задание пользовательского проверяющего элемента управления для сертификата с использованием конфигурации на стороне клиента  
  
1. Добавьте [\<behaviors>](../../configure-apps/file-schema/wcf/behaviors.md) элемент и в [\<serviceBehaviors>](../../configure-apps/file-schema/wcf/servicebehaviors.md) [\<system.serviceModel>](../../configure-apps/file-schema/wcf/system-servicemodel.md) элемент.  
  
2. Добавьте [\<endpointBehaviors>](../../configure-apps/file-schema/wcf/endpointbehaviors.md) элемент.  
  
3. Добавьте элемент `<behavior>` и присвойте атрибуту `name` соответствующее значение.  
  
4. Добавьте [\<clientCredentials>](../../configure-apps/file-schema/wcf/clientcredentials.md) элемент.  
  
5. Добавьте [\<serviceCertificate>](../../configure-apps/file-schema/wcf/servicecertificate-of-clientcredentials-element.md) .  
  
6. Добавьте, [\<authentication>](../../configure-apps/file-schema/wcf/authentication-of-servicecertificate-element.md) как показано в следующем примере.  
  
7. Задайте для атрибута `customCertificateValidatorType` тип проверяющего элемента управления.  
  
8. Задайте для атрибута `certificateValidationMode` значение `Custom`. В следующем примере для атрибута задано значение пространства имен и имени типа.  
  
    ```xml  
    <configuration>  
     <system.serviceModel>  
      <behaviors>  
       <endpointBehaviors>  
        <behavior name="clientBehavior">  
         <clientCredentials>  
          <serviceCertificate>  
           <authentication certificateValidationMode="Custom"
                  customCertificateValidatorType=  
             "Samples.CustomX509CertificateValidator, client"/>  
          </serviceCertificate>  
         </clientCredentials>  
        </behavior>  
       </endpointBehaviors>  
      </behaviors>  
     </system.serviceModel>  
    </configuration>  
    ```  
  
#### <a name="to-specify-a-custom-certificate-validator-using-code-on-the-service"></a>Задание пользовательского проверяющего элемента управления для сертификата с использованием кода на стороне службы  
  
1. Задайте пользовательский проверяющий элемент управления для сертификата в свойстве <xref:System.ServiceModel.Description.ServiceCredentials.ClientCertificate%2A>. Получить доступ к учетным данным службы можно с помощью свойства <xref:System.ServiceModel.ServiceHostBase.Credentials%2A>.  
  
2. Задайте для свойства <xref:System.ServiceModel.Security.X509ClientCertificateAuthentication.CertificateValidationMode%2A> значение <xref:System.ServiceModel.Security.X509CertificateValidationMode.Custom>.  
  
 [!code-csharp[c_CustomCertificateValidator#1](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_customcertificatevalidator/cs/source.cs#1)]
 [!code-vb[c_CustomCertificateValidator#1](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_customcertificatevalidator/vb/source.vb#1)]  
  
#### <a name="to-specify-a-custom-certificate-validator-using-code-on-the-client"></a>Задание пользовательского проверяющего элемента управления для сертификата с использованием кода на стороне клиента  
  
1. Задайте пользовательский проверяющий элемент управления для сертификата в свойстве <xref:System.ServiceModel.Security.X509ServiceCertificateAuthentication.CustomCertificateValidator%2A>. Получить доступ к учетным данным клиента можно с помощью свойства <xref:System.ServiceModel.ServiceHostBase.Credentials%2A>. (Клиентский класс, созданный с помощью [служебной программы метаданных ServiceModel (Svcutil.exe)](../servicemodel-metadata-utility-tool-svcutil-exe.md) , всегда является производным от <xref:System.ServiceModel.ClientBase%601> класса.)  
  
2. Задайте для свойства <xref:System.ServiceModel.Security.X509ServiceCertificateAuthentication.CertificateValidationMode%2A> значение <xref:System.ServiceModel.Security.X509CertificateValidationMode.Custom>.  
  
## <a name="example"></a>Пример  
  
### <a name="description"></a>Описание  

 В следующем примере показана реализация пользовательского проверяющего элемента управления для сертификата и его использование на стороне службы.  
  
### <a name="code"></a>Код  

 [!code-csharp[c_CustomCertificateValidator#3](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_customcertificatevalidator/cs/source.cs#3)]
 [!code-vb[c_CustomCertificateValidator#3](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_customcertificatevalidator/vb/source.vb#3)]  
  
## <a name="see-also"></a>См. также

- <xref:System.IdentityModel.Selectors.X509CertificateValidator>

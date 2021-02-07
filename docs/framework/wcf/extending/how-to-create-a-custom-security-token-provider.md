---
description: Дополнительные сведения см. в статье как создать настраиваемый поставщик маркеров безопасности.
title: Практическое руководство. Создание поставщика пользовательских маркеров безопасности
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- security [WCF], providing credentials
ms.assetid: db8cb478-aa43-478b-bf97-c6489ad7c7fd
ms.openlocfilehash: 4e0970ff01be74d0eb9f4ae8968bd100a0dafe00
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99735040"
---
# <a name="how-to-create-a-custom-security-token-provider"></a>Практическое руководство. Создание поставщика пользовательских маркеров безопасности

В этом разделе показано, как создавать новые типы маркеров с помощью поставщика пользовательских маркеров безопасности и как интегрировать поставщик с диспетчером пользовательских маркеров безопасности.  
  
> [!NOTE]
> Поставщик пользовательских маркеров следует создавать, если предоставляемые системой маркеры в пространстве имен <xref:System.IdentityModel.Tokens> не соответствуют требованиям.  
  
 Поставщик маркеров безопасности создает представление маркера безопасности на основании сведений в учетных данных клиента или службы. Чтобы использовать пользовательский поставщик маркеров безопасности в безопасности Windows Communication Foundation (WCF), необходимо создать пользовательские учетные данные и реализации диспетчера маркеров безопасности.  
  
 Дополнительные сведения о пользовательских учетных данных и диспетчере маркеров безопасности см. в разделе [Пошаговое руководство. Создание настраиваемых учетных данных клиента и службы](walkthrough-creating-custom-client-and-service-credentials.md).  
  
### <a name="to-create-a-custom-security-token-provider"></a>Создание поставщика пользовательских маркеров безопасности  
  
1. Определите новый класс, производный от класса <xref:System.IdentityModel.Selectors.SecurityTokenProvider>.  
  
2. Выполните метод <xref:System.IdentityModel.Selectors.SecurityTokenProvider.GetTokenCore%28System.TimeSpan%29>. Этот метод отвечает за создание и возвращение экземпляра маркера безопасности. В следующем примере создается класс с именем `MySecurityTokenProvider` и переопределяется метод <xref:System.IdentityModel.Selectors.SecurityTokenProvider.GetTokenCore%28System.TimeSpan%29>, чтобы он возвращал экземпляр класса <xref:System.IdentityModel.Tokens.X509SecurityToken>. Конструктору класса требуется экземпляр класса <xref:System.Security.Cryptography.X509Certificates.X509Certificate2>.  
  
     [!code-csharp[c_CustomTokenProvider#1](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_customtokenprovider/cs/source.cs#1)]
     [!code-vb[c_CustomTokenProvider#1](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_customtokenprovider/vb/source.vb#1)]  
  
### <a name="to-integrate-a-custom-security-token-provider-with-a-custom-security-token-manager"></a>Интеграция поставщика пользовательских маркеров безопасности с диспетчером пользовательских маркеров безопасности  
  
1. Определите новый класс, производный от класса <xref:System.IdentityModel.Selectors.SecurityTokenManager>. (В следующем примере кода создается класс <xref:System.ServiceModel.ClientCredentialsSecurityTokenManager>, наследуемый от класса <xref:System.IdentityModel.Selectors.SecurityTokenManager>.)  
  
2. Переопределите метод <xref:System.IdentityModel.Selectors.SecurityTokenManager.CreateSecurityTokenProvider%28System.IdentityModel.Selectors.SecurityTokenRequirement%29>, если он еще не переопределен.  
  
     <xref:System.IdentityModel.Selectors.SecurityTokenManager.CreateSecurityTokenProvider%28System.IdentityModel.Selectors.SecurityTokenRequirement%29>Метод отвечает за возврат экземпляра <xref:System.IdentityModel.Selectors.SecurityTokenProvider> класса, соответствующего <xref:System.IdentityModel.Selectors.SecurityTokenRequirement> параметру, переданному в метод платформой безопасности WCF. Измените метод, чтобы он возвращал реализацию поставщика пользовательских маркеров безопасности (созданную перед этим), когда этот метод вызывается с соответствующим параметром маркера безопасности. Дополнительные сведения о диспетчере маркеров безопасности см. в разделе [Пошаговое руководство. Создание настраиваемых учетных данных клиента и службы](walkthrough-creating-custom-client-and-service-credentials.md).  
  
3. Добавьте в метод соответствующие инструкции, чтобы он мог возвращать поставщик пользовательских маркеров безопасности на основании параметра <xref:System.IdentityModel.Selectors.SecurityTokenRequirement>. В следующем примере метод возвращает поставщик пользовательских маркеров безопасности, если выполняются требования маркера. Требования включают маркер безопасности X.509 и направление сообщения (маркер используется для вывода сообщений). Во всех остальных случаях код вызывает базовый класс для поддержки предоставляемого системой поведения для требований других маркеров безопасности.  
  
 [!code-csharp[c_CustomTokenProvider#2](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_customtokenprovider/cs/source.cs#2)]
 [!code-vb[c_CustomTokenProvider#2](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_customtokenprovider/vb/source.vb#2)]  
  
## <a name="example"></a>Пример  

 Ниже показана полная реализация поставщика <xref:System.IdentityModel.Selectors.SecurityTokenProvider>, а также соответствующая реализация диспетчера <xref:System.IdentityModel.Selectors.SecurityTokenManager>.  
  
 [!code-csharp[c_CustomTokenProvider#0](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_customtokenprovider/cs/source.cs#0)]
 [!code-vb[c_CustomTokenProvider#0](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_customtokenprovider/vb/source.vb#0)]  
  
## <a name="see-also"></a>См. также

- <xref:System.IdentityModel.Selectors.SecurityTokenProvider>
- <xref:System.IdentityModel.Selectors.SecurityTokenRequirement>
- <xref:System.IdentityModel.Selectors.SecurityTokenManager>
- <xref:System.IdentityModel.Tokens.X509SecurityToken>
- [Пошаговое руководство. Создание пользовательских учетных данных для клиента и службы](walkthrough-creating-custom-client-and-service-credentials.md)
- [Практическое руководство. Создание пользовательской структуры проверки подлинности маркера безопасности](how-to-create-a-custom-security-token-authenticator.md)

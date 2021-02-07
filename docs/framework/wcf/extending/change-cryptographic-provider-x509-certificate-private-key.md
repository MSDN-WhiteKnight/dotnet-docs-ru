---
description: Дополнительные сведения см. в статье как изменить поставщик служб шифрования для закрытого ключа сертификата X. 509.
title: Практическое руководство. Изменение поставщика служб шифрования для закрытого ключа сертификата X.509
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- cryptographic provider [WCF], changing
- cryptographic provider [WCF]
ms.assetid: b4254406-272e-4774-bd61-27e39bbb6c12
ms.openlocfilehash: e68f4ffb5626a2c332853bd97eb513516401a185
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99756712"
---
# <a name="how-to-change-the-cryptographic-provider-for-an-x509-certificates-private-key"></a>Практическое руководство. Изменение поставщика служб шифрования для закрытого ключа сертификата X.509

В этом разделе показано, как изменить поставщик служб шифрования, используемый для предоставления закрытого ключа сертификата X. 509, и как интегрировать поставщик в платформу безопасности Windows Communication Foundation (WCF). Дополнительные сведения об использовании сертификатов см. [в разделе Работа с сертификатами](../feature-details/working-with-certificates.md).  
  
 Платформа безопасности WCF предоставляет способ создания новых типов маркеров безопасности, как описано в разделе [как создать пользовательский маркер](how-to-create-a-custom-token.md). Пользовательский маркер также можно использовать для замены существующих типов маркеров, предоставляемых системой.  
  
 В этом разделе описывается замена предоставляемого системой маркера безопасности X.509 пользовательским маркером X.509, что делает возможным иную реализацию закрытого ключа сертификата. Эта возможность оказывается полезной, если фактический закрытый ключ предоставляется другим поставщиком служб шифрования, а не поставщиком служб шифрования Windows по умолчанию. В качестве примера альтернативного поставщика служб шифрования можно назвать аппаратный модуль безопасности, выполняющий все операции шифрования с закрытым ключом и не сохраняющий закрытые ключи в памяти, тем самым повышая уровень безопасности системы.  
  
 Следующий пример используется только в качестве демонстрации. В этом примере не описывается замена поставщика служб шифрования Windows по умолчанию, а показывается, куда можно интегрировать этого поставщика.  
  
## <a name="procedures"></a>Процедуры  

 Каждый маркер безопасности, имеющий связанный ключ или ключи безопасности, должен реализовать свойство <xref:System.IdentityModel.Tokens.SecurityToken.SecurityKeys%2A>, возвращающее коллекцию ключей из экземпляра маркера безопасности. Если маркер является маркером безопасности X.509, коллекция содержит единственный экземпляр класса <xref:System.IdentityModel.Tokens.X509AsymmetricSecurityKey>, представляющего как открытые, так и закрытые ключи, связанные с сертификатом. Для замены поставщика служб шифрования по умолчанию, предоставляющего ключи сертификата, необходимо создать новую реализацию данного класса.  
  
#### <a name="to-create-a-custom-x509-asymmetric-key"></a>Создание пользовательского асимметричного ключа X.509  
  
1. Определите новый класс, производный от класса <xref:System.IdentityModel.Tokens.X509AsymmetricSecurityKey>.  
  
2. Переопределите свойство <xref:System.IdentityModel.Tokens.SecurityKey.KeySize%2A>, доступное только для чтения. Это свойство возвращает фактический размер ключа пары ключей сертификата (открытого и закрытого).  
  
3. Переопределите метод <xref:System.IdentityModel.Tokens.SecurityKey.DecryptKey%2A> . Этот метод вызывается платформой безопасности WCF для расшифровки симметричного ключа с закрытым ключом сертификата. (Ранее этот ключ был зашифрован с помощью открытого ключа сертификата).  
  
4. Переопределите метод <xref:System.IdentityModel.Tokens.AsymmetricSecurityKey.GetAsymmetricAlgorithm%2A> . Этот метод вызывается платформой безопасности WCF для получения экземпляра <xref:System.Security.Cryptography.AsymmetricAlgorithm> класса, представляющего поставщика служб шифрования для закрытого или открытого ключа сертификата, в зависимости от параметров, передаваемых в метод.  
  
5. Необязательный элемент. Переопределите метод <xref:System.IdentityModel.Tokens.AsymmetricSecurityKey.GetHashAlgorithmForSignature%2A> . Переопределите этот метод, если требуется иная реализация класса <xref:System.Security.Cryptography.HashAlgorithm>.  
  
6. Переопределите метод <xref:System.IdentityModel.Tokens.AsymmetricSecurityKey.GetSignatureFormatter%2A> . Этот метод возвращает экземпляр класса <xref:System.Security.Cryptography.AsymmetricSignatureFormatter>, связанного с закрытым ключом сертификата.  
  
7. Переопределите метод <xref:System.IdentityModel.Tokens.SecurityKey.IsSupportedAlgorithm%2A> . Этот метод используется, чтобы указать, поддерживается ли конкретный алгоритм шифрования данной реализацией ключа безопасности.  
  
     [!code-csharp[c_CustomX509Token#1](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_customx509token/cs/source.cs#1)]
     [!code-vb[c_CustomX509Token#1](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_customx509token/vb/source.vb#1)]  
  
 В следующей процедуре показано, как интегрировать пользовательскую реализацию асимметричного ключа безопасности X. 509, созданную в предыдущей процедуре, с платформой безопасности WCF, чтобы заменить предоставленный системой маркер безопасности X. 509.  
  
#### <a name="to-replace-the-system-provided-x509-security-token-with-a-custom-x509-asymmetric-security-key-token"></a>Замена предоставляемого системой маркера безопасности X.509 пользовательским маркером асимметричного ключа безопасности X.509  
  
1. Создайте пользовательский маркер безопасности X.509, возвращающий пользовательский асимметричный ключ безопасности X.509 вместо предоставляемого системой ключа безопасности, как показано в следующем примере. Дополнительные сведения о настраиваемых маркерах безопасности см. [в разделе как создать настраиваемый токен](how-to-create-a-custom-token.md).  
  
     [!code-csharp[c_CustomX509Token#2](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_customx509token/cs/source.cs#2)]
     [!code-vb[c_CustomX509Token#2](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_customx509token/vb/source.vb#2)]  
  
2. Создайте пользовательский поставщик маркеров безопасности, возвращающий пользовательский маркер безопасности X.509, как показано в примере. Дополнительные сведения о настраиваемых поставщиках маркеров безопасности см. [в разделе как создать настраиваемый поставщик маркеров безопасности](how-to-create-a-custom-security-token-provider.md).  
  
     [!code-csharp[c_CustomX509Token#3](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_customx509token/cs/source.cs#3)]
     [!code-vb[c_CustomX509Token#3](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_customx509token/vb/source.vb#3)]  
  
3. Если пользовательский ключ безопасности необходимо использовать на стороне инициатора, создайте пользовательский диспетчер маркеров безопасности клиента и пользовательские классы учетных данных клиента, как показано в следующем примере. Дополнительные сведения о настраиваемых учетных данных клиента и диспетчере маркеров Client Security см. в разделе [Пошаговое руководство. Создание настраиваемых учетных данных клиента и службы](walkthrough-creating-custom-client-and-service-credentials.md).  
  
     [!code-csharp[c_CustomX509Token#4](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_customx509token/cs/source.cs#4)]
     [!code-vb[c_CustomX509Token#4](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_customx509token/vb/source.vb#4)]  
  
     [!code-csharp[c_CustomX509Token#6](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_customx509token/cs/source.cs#6)]
     [!code-vb[c_CustomX509Token#6](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_customx509token/vb/source.vb#6)]  
  
4. Если пользовательский ключ безопасности необходимо использовать на стороне получателя, создайте пользовательский диспетчер маркеров безопасности службы и пользовательские учетные данные службы, как показано в следующем примере. Дополнительные сведения о пользовательских учетных данных службы и диспетчере маркеров безопасности службы см. в разделе [Пошаговое руководство. Создание настраиваемых учетных данных клиента и службы](walkthrough-creating-custom-client-and-service-credentials.md).  
  
     [!code-csharp[c_CustomX509Token#5](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_customx509token/cs/source.cs#5)]
     [!code-vb[c_CustomX509Token#5](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_customx509token/vb/source.vb#5)]  
  
     [!code-csharp[c_CustomX509Token#7](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_customx509token/cs/source.cs#7)]
     [!code-vb[c_CustomX509Token#7](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_customx509token/vb/source.vb#7)]  
  
## <a name="see-also"></a>См. также

- <xref:System.IdentityModel.Tokens.X509AsymmetricSecurityKey>
- <xref:System.IdentityModel.Tokens.AsymmetricSecurityKey>
- <xref:System.IdentityModel.Tokens.SecurityKey>
- <xref:System.Security.Cryptography.AsymmetricAlgorithm>
- <xref:System.Security.Cryptography.HashAlgorithm>
- <xref:System.Security.Cryptography.AsymmetricSignatureFormatter>
- [Пошаговое руководство. Создание пользовательских учетных данных для клиента и службы](walkthrough-creating-custom-client-and-service-credentials.md)
- [Практическое руководство. Создание пользовательской структуры проверки подлинности маркера безопасности](how-to-create-a-custom-security-token-authenticator.md)
- [Практическое руководство. Создание поставщика пользовательских маркеров безопасности](how-to-create-a-custom-security-token-provider.md)
- [Практическое руководство. Создание пользовательского токена](how-to-create-a-custom-token.md)

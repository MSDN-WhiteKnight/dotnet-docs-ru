---
description: Дополнительные сведения см. в статье как олицетворять клиент в службе.
title: Практическое руководство. Олицетворение клиента в рамках службы
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- WCF, impersonation
- impersonation
- WCF, security
ms.assetid: 431db851-a75b-4009-9fe2-247243d810d3
ms.openlocfilehash: 84d50b0c22161a829da66e42b4b3bbf004b68487
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99779378"
---
# <a name="how-to-impersonate-a-client-on-a-service"></a>Практическое руководство. Олицетворение клиента в рамках службы

Олицетворение клиента в службе Windows Communication Foundation (WCF) позволяет службе выполнять действия от имени клиента. В случае действий, для которых предусмотрены проверки списка управления доступом (ACL), таким как доступ к каталогам и файлам на компьютере или доступ к базе данных SQL Server, проверка ACL выполняется с использованием клиентской учетной записи пользователя. В данном разделе представлены основные этапы установки клиентом уровня олицетворения клиента в домене Windows. Рабочий пример см. в разделе [Impersonating the Client](./samples/impersonating-the-client.md). Дополнительные сведения о олицетворении клиента см. в разделе [Делегирование и олицетворение](./feature-details/delegation-and-impersonation-with-wcf.md).  
  
> [!NOTE]
> Если клиент и служба выполняются на одном компьютере и клиент выполняется от имени системной учетной записи (например, `Local System` или `Network Service`), клиент невозможно олицетворить, если установлен безопасный сеанс с маркерами контекста безопасности с отслеживанием состояния. WinForms или консольное приложение, как правило, выполняется от имени текущей зарегистрированной учетной записи, что позволяет олицетворить учетную запись по умолчанию. Однако если клиент является страницей ASP.NET и эта страница размещается в IIS 6,0 или IIS 7,0, то клиент по `Network Service` умолчанию работает под учетной записью. Все предоставляемые системой привязки, поддерживающие защищенные сеансы, по умолчанию используют маркер контекста безопасности без отслеживания состояния. Однако если клиент является страницей ASP.NET и используются безопасные сеансы с токенами контекста безопасности с отслеживанием состояния, то клиент не сможет выполнить олицетворение. Дополнительные сведения об использовании токенов контекста безопасности с отслеживанием состояния в безопасном сеансе см. в разделе [как создать маркер контекста безопасности для безопасного сеанса](./feature-details/how-to-create-a-security-context-token-for-a-secure-session.md).  
  
### <a name="to-enable-impersonation-of-a-client-from-a-cached-windows-token-on-a-service"></a>Включение олицетворения клиента из кэшированного маркера Windows в службе  
  
1. Создайте службу. Дополнительные сведения по этой базовой процедуре см. в разделе [Getting Started Tutorial](getting-started-tutorial.md).  
  
2. Используйте привязку, использующую проверку подлинности Windows, и создайте сеанс, такой как <xref:System.ServiceModel.NetTcpBinding> или <xref:System.ServiceModel.WSHttpBinding>.  
  
3. При создании реализации интерфейса службы примените класс <xref:System.ServiceModel.OperationBehaviorAttribute> к методу, требующему олицетворения клиента. Задайте для свойства <xref:System.ServiceModel.OperationBehaviorAttribute.Impersonation%2A> значение <xref:System.ServiceModel.ImpersonationOption.Required>.  
  
     [!code-csharp[c_SimpleImpersonation#2](../../../samples/snippets/csharp/VS_Snippets_CFX/c_simpleimpersonation/cs/source.cs#2)]
     [!code-vb[c_SimpleImpersonation#2](../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_simpleimpersonation/vb/source.vb#2)]  
  
### <a name="to-set-the-allowed-impersonation-level-on-the-client"></a>Установка допустимого уровня олицетворения на стороне клиента  
  
1. Создайте код клиента службы с помощью средства [ServiceModel Metadata Utility Tool (Svcutil.exe)](servicemodel-metadata-utility-tool-svcutil-exe.md). Дополнительные сведения см. [в разделе доступ к службам с помощью клиента WCF](accessing-services-using-a-wcf-client.md).  
  
2. После создания клиента WCF задайте <xref:System.ServiceModel.Security.WindowsClientCredential.AllowedImpersonationLevel%2A> <xref:System.ServiceModel.Security.WindowsClientCredential> для свойства класса одно из <xref:System.Security.Principal.TokenImpersonationLevel> значений перечисления.  
  
    > [!NOTE]
    > Для использования <xref:System.Security.Principal.TokenImpersonationLevel.Delegation>необходимо использовать согласованную проверку подлинности Kerberos (иногда называемую *многоступенчатой* или *многоэтапной* проверкой Kerberos). Описание того, как это реализовать, см. в статье рекомендации [по обеспечению безопасности](./feature-details/best-practices-for-security-in-wcf.md).  
  
     [!code-csharp[c_SimpleImpersonation#1](../../../samples/snippets/csharp/VS_Snippets_CFX/c_simpleimpersonation/cs/source.cs#1)]
     [!code-vb[c_SimpleImpersonation#1](../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_simpleimpersonation/vb/source.vb#1)]  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.OperationBehaviorAttribute>
- <xref:System.Security.Principal.TokenImpersonationLevel>
- [Олицетворение клиента](./samples/impersonating-the-client.md)
- [Делегирование и олицетворение](./feature-details/delegation-and-impersonation-with-wcf.md)

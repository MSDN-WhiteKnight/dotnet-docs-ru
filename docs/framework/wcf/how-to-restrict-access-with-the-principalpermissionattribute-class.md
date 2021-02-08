---
description: Дополнительные сведения см. в статье как ограничить доступ с помощью класса PrincipalPermissionAttribute.
title: Практическое руководство. Ограничение доступа с использованием класса PrincipalPermissionAttribute
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- PrincipalPermissionAttribute class
- WCF, authorization
- WCF, security
ms.assetid: 5162f5c4-8781-4cc4-9425-bb7620eaeaf4
ms.openlocfilehash: 533bd3358d5e337071c6419264d1dac03b8987ca
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99779352"
---
# <a name="how-to-restrict-access-with-the-principalpermissionattribute-class"></a>Практическое руководство. Ограничение доступа с использованием класса PrincipalPermissionAttribute

Управление доступом к ресурсам компьютера Windows-домена - это базовая задача обеспечения безопасности. Например, только определенные пользователи должны иметь возможность просматривать конфиденциальные данные, такие как платежные ведомости. В этом разделе рассматривается, как ограничить доступ к методу, потребовав, чтобы пользователь принадлежал к заранее заданной группе. Рабочий пример см. в разделе [авторизация доступа к операциям службы](./samples/authorizing-access-to-service-operations.md).  
  
 Эта задача состоит из двух отдельных процедур. Первая создает группу и заносит в нее пользователей. Вторая применяет класс <xref:System.Security.Permissions.PrincipalPermissionAttribute>, чтобы задать группу.  
  
### <a name="to-create-a-windows-group"></a>Создание группы Windows  
  
1. Откройте консоль **управления компьютером** .  
  
2. На панели слева щелкните **Локальные пользователи и группы**.  
  
3. Щелкните правой кнопкой мыши элемент **группы** и выберите команду **создать группу**.  
  
4. В поле **имя группы** введите имя новой группы.  
  
5. В поле **Описание** введите описание новой группы.  
  
6. Нажмите кнопку **Добавить** , чтобы добавить новых членов в группу.  
  
7. Если вы добавили себя в группу и хотите протестировать приведенный ниже код, необходимо выйти из системы и снова войти в нее, чтобы быть включенным в группу.  
  
### <a name="to-demand-user-membership"></a>Требование членства пользователя  
  
1. Откройте файл кода Windows Communication Foundation (WCF), содержащий реализованный код контракта службы. Дополнительные сведения о реализации контракта см. в разделе [реализация контрактов служб](implementing-service-contracts.md).  
  
2. Примените атрибут <xref:System.Security.Permissions.PrincipalPermissionAttribute> к каждому методу, доступ к которому необходимо ограничить определенной группой. Задайте для свойства <xref:System.Security.Permissions.SecurityAttribute.Action%2A> значение <xref:System.Security.Permissions.SecurityAction.Demand>, а для свойства <xref:System.Security.Permissions.PrincipalPermissionAttribute.Role%2A> задайте имя группы. Пример:  
  
     [!code-csharp[c_PrincipalPermissionAttribute#1](../../../samples/snippets/csharp/VS_Snippets_CFX/c_principalpermissionattribute/cs/source.cs#1)]
     [!code-vb[c_PrincipalPermissionAttribute#1](../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_principalpermissionattribute/vb/source.vb#1)]  
  
    > [!NOTE]
    > Если применить атрибут <xref:System.Security.Permissions.PrincipalPermissionAttribute> к контракту, возникает исключение <xref:System.Security.SecurityException>. Этот атрибут может применяться только на уровне метода.  
  
## <a name="using-a-certificate-to-control-access-to-a-method"></a>Использование сертификата для управления доступом к методу  

 Для управления доступом к методу можно также использовать класс `PrincipalPermissionAttribute`, если типом учетных данных клиента является сертификат. Для этого необходимо иметь субъект и отпечаток сертификата.  
  
 Сведения о проверке сертификата для его свойств см. в разделе [как просматривать сертификаты с помощью оснастки MMC](./feature-details/how-to-view-certificates-with-the-mmc-snap-in.md). Чтобы найти значение отпечатка, см. статью [как получить отпечаток сертификата](./feature-details/how-to-retrieve-the-thumbprint-of-a-certificate.md).  
  
#### <a name="to-control-access-using-a-certificate"></a>Управление доступом с помощью сертификата  
  
1. Примените класс <xref:System.Security.Permissions.PrincipalPermissionAttribute> к методу, доступ к которому требуется ограничить.  
  
2. Задайте для действия атрибута значение <xref:System.Security.Permissions.SecurityAction.Demand?displayProperty=nameWithType>.  
  
3. Задайте для свойства `Name` строку, состоящую из имени субъект и отпечатка сертификата. Эти два значения должны разделяться точкой с запятой и пробелом, как показано в следующем примере:  
  
     [!code-csharp[c_PrincipalPermissionAttribute#2](../../../samples/snippets/csharp/VS_Snippets_CFX/c_principalpermissionattribute/cs/source.cs#2)]
     [!code-vb[c_PrincipalPermissionAttribute#2](../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_principalpermissionattribute/vb/source.vb#2)]  
  
4. Задайте для свойства <xref:System.ServiceModel.Description.ServiceAuthorizationBehavior.PrincipalPermissionMode%2A> значение <xref:System.ServiceModel.Description.PrincipalPermissionMode.UseAspNetRoles>, как показано в следующем примере конфигурации:  
  
    ```xml  
    <behaviors>  
      <serviceBehaviors>  
      <behavior name="SvcBehavior1">  
      <serviceAuthorization principalPermissionMode="UseAspNetRoles" />  
      </behavior>  
      </serviceBehaviors>  
    </behaviors>  
    ```  
  
     Задание для этого параметра значения `UseAspNetRoles` означает, что свойство `Name` атрибута `PrincipalPermissionAttribute` будет использоваться для строкового сравнения. Если сертификат используется в качестве учетных данных клиента, по умолчанию WCF объединяет общее имя сертификата и отпечаток с точкой с запятой, чтобы создать уникальное значение для первичного удостоверения клиента. Если в службе для режима `UseAspNetRoles` задано значение `PrincipalPermissionMode`, для определения прав доступа пользователя это значение первичной идентификации сравнивается со значением свойства `Name`.  
  
     При создании резидентной службы можно также задать свойство <xref:System.ServiceModel.Description.ServiceAuthorizationBehavior.PrincipalPermissionMode%2A> в коде, как показано в следующем коде:  
  
     [!code-csharp[c_PrincipalPermissionAttribute#3](../../../samples/snippets/csharp/VS_Snippets_CFX/c_principalpermissionattribute/cs/source.cs#3)]
     [!code-vb[c_PrincipalPermissionAttribute#3](../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_principalpermissionattribute/vb/source.vb#3)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Security.Permissions.PrincipalPermissionAttribute>
- <xref:System.Security.Permissions.SecurityAction.Demand>
- <xref:System.Security.Permissions.PrincipalPermissionAttribute.Role%2A>
- [Авторизация доступа к операциям службы](./samples/authorizing-access-to-service-operations.md)
- [Обзор безопасности](./feature-details/security-overview.md)
- [Реализация контрактов служб](implementing-service-contracts.md)

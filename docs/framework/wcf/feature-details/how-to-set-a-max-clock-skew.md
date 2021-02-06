---
description: Дополнительные сведения см. в статье как задать максимальную отклонения времени.
title: Практическое руководство. Установка максимальной разницы в показаниях часов
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- MaxClockSkew property
- WCF, custom bindings
ms.assetid: 491d1705-eb29-43c2-a44c-c0cf996f74eb
ms.openlocfilehash: 688be1bb42dd7b30fce577082992741b76819e3e
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99643206"
---
# <a name="how-to-set-a-max-clock-skew"></a>Практическое руководство. Установка максимальной разницы в показаниях часов

Если настройки времени в двух компьютерах различаются, возможен сбой критичных по времени функций. Чтобы устранить такую возможность, можно задать для свойства `MaxClockSkew` значение <xref:System.TimeSpan>. Это свойство предусмотрено в двух классах.  
  
 <xref:System.ServiceModel.Channels.LocalClientSecuritySettings>  
  
 <xref:System.ServiceModel.Channels.LocalServiceSecuritySettings>  
  
> [!IMPORTANT]
> Для безопасного диалога изменения `MaxClockSkew` свойства должны быть сделаны при начальной загрузке службы или клиента. Для этого необходимо задать свойство для свойства, <xref:System.ServiceModel.Channels.SecurityBindingElement> возвращаемого <xref:System.ServiceModel.Security.Tokens.SecureConversationSecurityTokenParameters.BootstrapSecurityBindingElement%2A?displayProperty=nameWithType> свойством.  
  
 Чтобы изменить это свойство в одной из привязок, предоставляемых системой, необходимо найти элемент привязки безопасности в коллекции привязок и задать для свойства `MaxClockSkew` новое значение. От класса <xref:System.ServiceModel.Channels.SecurityBindingElement> наследуют два класса: <xref:System.ServiceModel.Channels.SymmetricSecurityBindingElement> и <xref:System.ServiceModel.Channels.AsymmetricSecurityBindingElement>. При извлечении привязки безопасности из коллекции необходимо приведение к одному из этих типов, чтобы правильно задать свойство `MaxClockSkew`. В следующем примере используется привязка <xref:System.ServiceModel.WSHttpBinding>, которая использует класс <xref:System.ServiceModel.Channels.SymmetricSecurityBindingElement>. Список, указывающий тип привязки безопасности, используемый в каждой предоставляемой системой привязке, см. в разделе [привязки, предоставляемые системой](../system-provided-bindings.md).  
  
## <a name="to-create-a-custom-binding-with-a-new-clock-skew-value-in-code"></a>Создание пользовательской привязки с новым значением разницы в показаниях часов в коде  
  
> [!WARNING]
> Добавьте ссылки на следующие пространства имен в коде: <xref:System.ServiceModel.Channels> , <xref:System.ServiceModel.Description> , <xref:System.Security.Permissions> и <xref:System.ServiceModel.Security.Tokens> .  
  
1. Создайте новый экземпляр класса <xref:System.ServiceModel.WSHttpBinding> и задайте для него режим безопасности <xref:System.ServiceModel.SecurityMode.Message?displayProperty=nameWithType>.  
  
2. Создайте новый экземпляр класса <xref:System.ServiceModel.Channels.BindingElementCollection>, вызвав метод <xref:System.ServiceModel.WSHttpBinding.CreateBindingElements%2A>.  
  
3. С помощью метода <xref:System.ServiceModel.Channels.BindingElementCollection.Find%2A> класса <xref:System.ServiceModel.Channels.BindingElementCollection> найдите требуемый элемент привязки безопасности.  
  
4. При использовании метода <xref:System.ServiceModel.Channels.BindingElementCollection.Find%2A> выполните приведение к фактическому типу. В приведенном ниже примере производится приведение к типу <xref:System.ServiceModel.Channels.SymmetricSecurityBindingElement>.  
  
5. Задайте свойство <xref:System.ServiceModel.Channels.LocalServiceSecuritySettings.MaxClockSkew%2A> в элементе привязки безопасности.  
  
6. Создайте <xref:System.ServiceModel.ServiceHost> с требуемыми типом и базовым адресом службы.  
  
7. С помощью метода <xref:System.ServiceModel.ServiceHost.AddServiceEndpoint%2A> добавьте конечную точку и включите <xref:System.ServiceModel.Channels.CustomBinding>.  
  
     [!code-csharp[c_MaxClockSkew#1](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_maxclockskew/cs/source.cs#1)]
     [!code-vb[c_MaxClockSkew#1](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_maxclockskew/vb/source.vb#1)]  
  
## <a name="to-set-the-maxclockskew-in-configuration"></a>Задание MaxClockSkew в конфигурации  
  
1. Создайте [\<customBinding>](../../configure-apps/file-schema/wcf/custombinding.md) в [\<bindings>](../../configure-apps/file-schema/wcf/bindings.md) разделе Element.  
  
2. Создайте [\<binding>](../../configure-apps/file-schema/wcf/bindings.md) элемент и присвойте `name` атрибуту соответствующее значение. В следующем примере задается значение `MaxClockSkewBinding`.  
  
3. Добавьте элемент кодирования. В приведенном ниже примере добавляется [\<textMessageEncoding>](../../configure-apps/file-schema/wcf/textmessageencoding.md) .  
  
4. Добавьте [\<security>](../../configure-apps/file-schema/wcf/security-of-custombinding.md) элемент и задайте `authenticationMode` для атрибута соответствующий параметр. В следующем примере для этого атрибута задается значение `Kerberos`, чтобы задать, что в службе используется проверка подлинности Windows.  
  
5. Добавьте [\<localServiceSettings>](../../configure-apps/file-schema/wcf/localservicesettings-element.md) и присвойте `maxClockSkew` атрибуту значение в виде `"##:##:##"` . В следующем примере задается значение 7 минут. При необходимости добавьте [\<localServiceSettings>](../../configure-apps/file-schema/wcf/localservicesettings-element.md) и задайте `maxClockSkew` для атрибута соответствующий параметр.  
  
6. Добавьте транспортный элемент. В следующем примере используется [\<httpTransport>](../../configure-apps/file-schema/wcf/httptransport.md) .  
  
7. Для безопасного диалога параметры безопасности должны выполняться при начальной загрузке в [\<secureConversationBootstrap>](../../configure-apps/file-schema/wcf/secureconversationbootstrap.md) элементе.  
  
    ```xml  
    <bindings>  
      <customBinding>  
        <binding name="MaxClockSkewBinding">  
            <textMessageEncoding />  
            <security authenticationMode="Kerberos">  
               <localClientSettings maxClockSkew="00:07:00" />  
               <localServiceSettings maxClockSkew="00:07:00" />  
               <secureConversationBootstrap>  
                  <localClientSettings maxClockSkew="00:30:00" />  
                  <localServiceSettings maxClockSkew="00:30:00" />  
               </secureConversationBootstrap>  
            </security>  
            <httpTransport />  
        </binding>  
      </customBinding>  
    </bindings>  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Channels.LocalClientSecuritySettings>
- <xref:System.ServiceModel.Channels.LocalServiceSecuritySettings>
- <xref:System.ServiceModel.Channels.CustomBinding>
- [Практическое руководство. Создание пользовательской привязки с использованием элемента SecurityBindingElement](how-to-create-a-custom-binding-using-the-securitybindingelement.md)

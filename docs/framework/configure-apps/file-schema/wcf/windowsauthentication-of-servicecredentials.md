---
description: 'Дополнительные сведения <windowsAuthentication> о: <serviceCredentials>'
title: <windowsAuthentication> из <serviceCredentials>
ms.date: 03/30/2017
ms.assetid: e0709473-0997-4de3-8f49-783527309a48
ms.openlocfilehash: 94f5804ac22a8c3ee1b8fc646ece8521ff639aec
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99682414"
---
# <a name="windowsauthentication-of-servicecredentials"></a>\<windowsAuthentication> из \<serviceCredentials>

Задает параметры учетной записи службы Windows.  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<system.serviceModel>**](system-servicemodel.md)\
&nbsp;&nbsp;&nbsp;&nbsp;[**\<behaviors>**](behaviors.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<serviceBehaviors>**](servicebehaviors.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<behavior>**](behavior-of-servicebehaviors.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<serviceCredentials>**](servicecredentials.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<windowsAuthentication>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<windowsAuthentication allowAnonymousLogons="Boolean"
                       includeWindowsGroups="Boolean" />
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|`includeWindowsGroups`|Необязательный логический атрибут, который задает, включает ли система группы Windows в контекст безопасности. Значение по умолчанию — `true`.<br /><br /> Установка для этого атрибута значения `true` влияет на производительность, поскольку приводит к расширению всей группы. Если нет необходимости устанавливать список групп, к которым принадлежит пользователь, установите для этого атрибута значение `false`.|  
|`allowAnonymousLogons`|Необязательный логический атрибут, который указывает, разрешены ли анонимные, не прошедшие проверку подлинности вызывающие объекты. Значение по умолчанию — `false`.<br /><br /> Когда атрибуту `clientCredentialType` привязки задано значение `Windows`, система не разрешает анонимные вызывающие объекты. Это значит, что доступ к системе разрешен только прошедшим проверку подлинности вызывающим объектам домена или рабочей группы. Это поведение можно переопределить с помощью данного атрибута.<br /><br /> Используйте этот режим с особой осторожностью.|  
  
### <a name="child-elements"></a>Дочерние элементы  

 Отсутствует.  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<serviceCredentials>](servicecredentials.md)|Задает учетные данные, используемые при проверке подлинности службы, а также параметры, относящиеся к проверке учетных данных клиента.|  
  
## <a name="remarks"></a>Remarks  

 Этот элемент используется, чтобы указать, разрешается ли доступ анонимных пользователей Windows путем установки атрибута `allowAnonymousLogons`. Также можно указать, включать ли сведения о группе, к которой принадлежат пользователи в AuthorizationContext, путем установки атрибута `includeWindowsGroups`. Если атрибуту задано значение `true` (по умолчанию), служба может определить группы Windows, к которым принадлежит клиент.  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Configuration.WindowsServiceElement>
- <xref:System.ServiceModel.Configuration.ServiceCredentialsElement.WindowsAuthentication%2A>
- <xref:System.ServiceModel.Description.ServiceCredentials.WindowsAuthentication%2A>
- <xref:System.ServiceModel.Security.WindowsServiceCredential>

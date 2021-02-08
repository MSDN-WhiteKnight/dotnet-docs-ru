---
description: 'Дополнительные сведения о: <publisherPolicy> element'
title: Элемент <publisherPolicy>
ms.date: 03/30/2017
f1_keywords:
- http://schemas.microsoft.com/.NetConfiguration/v2.0#configuration/runtime/assemblyBinding/publisherPolicy
- http://schemas.microsoft.com/.NetConfiguration/v2.0#configuration/runtime/assemblyBinding/dependentAssembly/publisherPolicy
- http://schemas.microsoft.com/.NetConfiguration/v2.0#publisherPolicy
helpviewer_keywords:
- publisherPolicy element
- container tags, <publisherPolicy> element
- <publisherPolicy> element
ms.assetid: 4613407e-d0a8-4ef2-9f81-a6acb9fdc7d4
ms.openlocfilehash: 35d729d5b195e010a80e7272312f14ac5802001b
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99802441"
---
# <a name="publisherpolicy-element"></a>Элемент \<publisherPolicy>

Указывает, применяет ли среда выполнения политику издателя.  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<runtime>**](runtime-element.md)\
&nbsp;&nbsp;&nbsp;&nbsp;[**\<assemblyBinding>**](assemblybinding-element-for-runtime.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<dependentAssembly>**](dependentassembly-element.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<publisherPolicy>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<publisherPolicy apply="yes|no"/>  
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|`apply`|Указывает, следует ли применять политику издателя.|  
  
## <a name="apply-attribute"></a>применить атрибут  
  
|Значение|Описание|  
|-----------|-----------------|  
|`yes`|Применяет политику издателя. Это параметр по умолчанию.|  
|`no`|Политика издателя не применяется.|  
  
### <a name="child-elements"></a>Дочерние элементы  

Отсутствует.  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|`assemblyBinding`|Содержит сведения о перенаправлении версии сборки и о расположениях сборок.|  
|`configuration`|Корневой элемент в любом файле конфигурации, используемом средой CLR и приложениями .NET Framework.|  
|`dependentAssembly`|Инкапсулирует политику привязки и расположение каждой сборки. `<dependentAssembly>`Для каждой сборки используется один элемент.|  
|`runtime`|Содержит сведения о привязке сборок и сборке мусора.|  
  
## <a name="remarks"></a>Remarks  

 Когда поставщик компонента выпускает новую версию сборки, поставщик может включить политику издателя, чтобы приложения, использующие старую версию, теперь использовали новую версию. Чтобы указать, следует ли применять политику издателя для определенной сборки, поставьте **\<publisherPolicy>** элемент в **\<dependentAssembly>** элемент.  
  
 Значение по умолчанию для атрибута **Apply** — **Да**. Присвоение атрибуту **Apply** значения **No** переопределяет любые предыдущие параметры **Yes** для сборки.  
  
 Чтобы приложение явно игнорировало политику издателя с помощью [\<publisherPolicy apply="no"/>](publisherpolicy-element.md) элемента в файле конфигурации приложения, требуется разрешение. Разрешение предоставляется путем установки <xref:System.Security.Permissions.SecurityPermissionFlag> флага для <xref:System.Security.Permissions.SecurityPermission> . Дополнительные сведения см. в статье [разрешение безопасности перенаправления привязки сборок](../../assembly-binding-redirection-security-permission.md).  
  
## <a name="example"></a>Пример  

 В следующем примере отключается политика издателя для сборки `myAssembly` .  
  
```xml  
<configuration>  
   <runtime>  
      <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">  
         <dependentAssembly>  
            <assemblyIdentity name="myAssembly"  
                                    publicKeyToken="32ab4ba45e0a69a1"  
                                    culture="neutral" />  
            <publisherPolicy apply="no"/>  
         </dependentAssembly>  
      </assemblyBinding>  
   </runtime>  
</configuration>  
```  
  
## <a name="see-also"></a>См. также

- [Схема параметров среды выполнения](index.md)
- [Схема файла конфигурации](../index.md)
- [Обнаружение сборок в среде выполнения](../../../deployment/how-the-runtime-locates-assemblies.md)
- [Перенаправление версий сборки](../../redirect-assembly-versions.md)

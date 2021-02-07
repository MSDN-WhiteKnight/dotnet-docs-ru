---
description: 'Дополнительные сведения о: <bindingRedirect> element'
title: Элемент <bindingRedirect>
ms.date: 03/30/2017
f1_keywords:
- http://schemas.microsoft.com/.NetConfiguration/v2.0#configuration/runtime/assemblyBinding/dependentAssembly/bindingRedirect
- http://schemas.microsoft.com/.NetConfiguration/v2.0#bindingRedirect
helpviewer_keywords:
- <bindingRedirect> element
- container tags, <bindingRedirect> element
- bindingRedirect element
ms.assetid: 67784ecd-9663-434e-bd6a-26975e447ac0
ms.openlocfilehash: 833ee73fa11d179ac855f3ac4d2bca8d7a2226ac
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99719179"
---
# <a name="bindingredirect-element"></a>Элемент \<bindingRedirect>

Перенаправляет одну версию сборки на другую.  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<runtime>**](runtime-element.md)\
&nbsp;&nbsp;&nbsp;&nbsp;[**\<assemblyBinding>**](assemblybinding-element-for-runtime.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<dependentAssembly>**](dependentassembly-element.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<bindingRedirect>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
   <bindingRedirect
oldVersion="existing assembly version"  
newVersion="new assembly version"/>  
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|`oldVersion`|Обязательный атрибут.<br /><br /> Задает первоначально запрошенную версию сборки. Номер версии сборки имеет формат *основной. дополнительный. сборка. Редакция*. Допустимые значения для каждой части этого номера версии — от 0 до 65535.<br /><br /> Диапазон версий можно также задать в следующем формате:<br /><br /> *n. n. n. n-n. n. n. n*|  
|`newVersion`|Обязательный атрибут.<br /><br /> Указывает версию сборки, используемую вместо первоначально запрошенной версии в формате: *n. n. n. n*<br /><br /> Это значение может указывать более раннюю версию, чем `oldVersion`.|  
  
### <a name="child-elements"></a>Дочерние элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|None||  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|`assemblyBinding`|Содержит сведения о перенаправлении версии сборки и о расположениях сборок.|  
|`configuration`|Корневой элемент в любом файле конфигурации, используемом средой CLR и приложениями .NET Framework.|  
|`dependentAssembly`|Инкапсулирует политику привязки и расположение каждой сборки. Для каждой сборки используется только один элемент dependentAssembly.|  
|`runtime`|Содержит сведения о привязке сборок и сборке мусора.|  
  
## <a name="remarks"></a>Remarks  

 При сборке приложения .NET Framework с использованием сборки со строгим именем приложение во время выполнения по умолчанию будет использовать эту версию сборки, даже если доступна новая версия. Однако приложение можно настроить для выполнения с новой версией сборки. Дополнительные сведения о том, как среда выполнения использует эти файлы для определения используемой версии сборки, см. в разделе [как среда выполнения находит сборки](../../../deployment/how-the-runtime-locates-assemblies.md).  
  
 Перенаправление нескольких версий сборок можно выполнить, включив в элемент `bindingRedirect` несколько элементов `dependentAssembly`. Можно также выполнить перенаправление с более новой версии на более раннюю версию сборки.  
  
 Для явного перенаправления привязки сборки в файле конфигурации приложения необходимо разрешение безопасности. Это относится к перенаправлению как сборок платформы .NET Framework, так и сторонних сборок. Разрешение предоставляется путем установки <xref:System.Security.Permissions.SecurityPermissionFlag> флага для <xref:System.Security.Permissions.SecurityPermission> . Дополнительные сведения см. в статье [разрешение безопасности перенаправления привязки сборок](../../assembly-binding-redirection-security-permission.md).  
  
## <a name="example"></a>Пример  

 В следующем примере показан способ перенаправления одной версии сборки на другую.  
  
```xml  
<configuration>  
   <runtime>  
      <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">  
         <dependentAssembly>  
            <assemblyIdentity name="myAssembly"  
                              publicKeyToken="32ab4ba45e0a69a1"  
                              culture="neutral" />  
            <bindingRedirect oldVersion="1.0.0.0"  
                             newVersion="2.0.0.0"/>  
         </dependentAssembly>  
      </assemblyBinding>  
   </runtime>  
</configuration>  
```  
  
## <a name="see-also"></a>См. также

- [Схема параметров среды выполнения](index.md)
- [Схема файла конфигурации](../index.md)
- [Перенаправление версий сборки](../../redirect-assembly-versions.md)

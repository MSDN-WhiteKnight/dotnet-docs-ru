---
description: 'Дополнительные сведения о: <disableCachingBindingFailures> element'
title: Элемент <disableCachingBindingFailures>
ms.date: 03/30/2017
f1_keywords:
- http://schemas.microsoft.com/.NetConfiguration/v2.0#disableCachingBindingFailures
- http://schemas.microsoft.com/.NetConfiguration/v2.0#configuration/runtime/disableCachingBindingFailures
helpviewer_keywords:
- assemblies [.NET Framework],caching binding failures
- caching assembly binding failures
- <disableCachingBindingFailures> element
- disableCachingBindingFailures element
ms.assetid: bf598873-83b7-48de-8955-00b0504fbad0
ms.openlocfilehash: b1f36f6a8fc7c78a0dc90ecc78ad725b677fdf40
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99787114"
---
# <a name="disablecachingbindingfailures-element"></a>Элемент \<disableCachingBindingFailures>

Указывает, следует ли отключать кэширование ошибок привязки, возникающих из-за того, что сборка не была найдена проверкой.  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<runtime>**](runtime-element.md)\
&nbsp;&nbsp;&nbsp;&nbsp;**\<disableCachingBindingFailures>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<disableCachingBindingFailures enabled="0|1"/>  
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|Включено|Обязательный атрибут.<br /><br /> Указывает, следует ли отключать кэширование ошибок привязки, возникающих из-за того, что сборка не была найдена проверкой.|  
  
## <a name="enabled-attribute"></a>Атрибут enabled  
  
|Значение|Описание|  
|-----------|-----------------|  
|0|Не отключайте кэширование ошибок привязки, возникающих из-за того, что сборка не была найдена проверкой. Это поведение привязки по умолчанию, начинающееся с платформа .NET Framework версии 2,0.|  
|1|Отключите кэширование ошибок привязки, возникающих из-за того, что сборка не была найдена проверкой. Этот параметр восстанавливает поведение привязки платформа .NET Framework версии 1,1.|  
  
### <a name="child-elements"></a>Дочерние элементы  

 Отсутствует.  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|`configuration`|Корневой элемент в любом файле конфигурации, используемом средой CLR и приложениями .NET Framework.|  
|`runtime`|Содержит сведения о привязке сборок и сборке мусора.|  
  
## <a name="remarks"></a>Remarks  

 Начиная с версии платформа .NET Framework 2,0, поведением по умолчанию для загрузки сборок является кэширование всех ошибок привязки и загрузки. То есть если попытка загрузить сборку завершается ошибкой, последующие запросы на загрузку одной и той же сборки будут завершаться сбоем немедленно, без каких-либо попыток нахождение сборки. Этот элемент отключает поведение по умолчанию для сбоев привязки, возникающих из-за того, что сборка не найдена в пути поиска. Эти ошибки вызываются <xref:System.IO.FileNotFoundException> .  
  
 Этот элемент не влияет на некоторые ошибки привязки и загрузки и всегда кэшируется. Эти сбои возникают из-за того, что сборка найдена, но не может быть загружена. Они создают <xref:System.BadImageFormatException> или <xref:System.IO.FileLoadException> . В следующем списке приведены некоторые примеры таких сбоев.  
  
- Если попытка загрузить файл не является допустимой сборкой, последующие попытки загрузки сборки завершатся ошибкой, даже если поврежденный файл заменяется правильной сборкой.  
  
- При попытке загрузить сборку, заблокированную файловой системой, последующие попытки загрузки сборки завершатся ошибкой даже после того, как сборка будет освобождена файловой системой.  
  
- Если одна или несколько версий сборки, которые вы пытаетесь загрузить, находятся в пути поиска, но конкретная Запрашиваемая версия не существует, последующие попытки загрузки этой версии завершатся ошибкой, даже если в путь поиска проверки перемещается правильная версия.  
  
## <a name="example"></a>Пример  

 В следующем примере показано, как отключить кэширование ошибок привязки сборок, возникающих из-за того, что сборка не была найдена проверкой.  
  
```xml  
<configuration>  
   <runtime>  
      <disableCachingBindingFailures enabled="1" />  
   </runtime>  
</configuration>  
```  
  
## <a name="see-also"></a>См. также

- [Схема параметров среды выполнения](index.md)
- [Схема файла конфигурации](../index.md)
- [Обнаружение сборок в среде выполнения](../../../deployment/how-the-runtime-locates-assemblies.md)

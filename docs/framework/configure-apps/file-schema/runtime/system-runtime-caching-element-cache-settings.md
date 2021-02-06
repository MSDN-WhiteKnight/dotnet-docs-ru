---
description: 'Дополнительные сведения: <System. Runtime. Caching> элемент (параметры кэша)'
title: Элемент <system.runtime.caching> (параметры кэша)
ms.date: 03/30/2017
helpviewer_keywords:
- <system.runtime.caching> element
- caching [.NET Framework], configuration
- system.runtime.caching element
ms.assetid: 9b44daee-874a-4bd1-954e-83bf53565590
ms.openlocfilehash: 602d863caedef5c1334948b25b0caa2b0e35f685
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99652735"
---
# <a name="systemruntimecaching-element-cache-settings"></a>Элемент \<system.runtime.caching> (параметры кэша)

Обеспечивает настройку реализации <xref:System.Runtime.Caching.ObjectCache> в памяти по умолчанию посредством записи `memoryCache` в файле конфигурации.  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;**\<system.runtime.caching>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<system.runtime.caching >  
   <!-- child elements -->  
</system.runtime.caching >  
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы

В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты

`None`  

### <a name="child-elements"></a>Дочерние элементы

|Элемент|Описание|  
|-------------|-----------------|  
|[\<memoryCache>](memorycache-element-cache-settings.md)|Определяет элемент, используемый для настройки кэша, который основан на классе <xref:System.Runtime.Caching.MemoryCache> .|  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<configuration>](../configuration-element.md)|Указывает корневой элемент в каждом файле конфигурации, который используется средой CLR и платформа .NET Framework приложениями.|  
  
## <a name="remarks"></a>Remarks

Классы в этом пространстве имен предоставляют способ использования средств кэширования, например таких, которые имеются в ASP.NET, но без зависимости от сборки `System.Web` . Для получения дополнительной информации см. [Caching in .NET Framework Applications](../../../performance/caching-in-net-framework-applications.md).  
  
> [!NOTE]
> Функции кэширования вывода и типы в <xref:System.Runtime.Caching> пространстве имен являются новыми в платформа .NET Framework 4.  
  
## <a name="example"></a>Пример

В следующем примере кода показано, как настроить кэш, основанный на классе <xref:System.Runtime.Caching.MemoryCache> . В примере показано, как построить экземпляр записи `namedCaches` для кэша памяти. Для имени кэша задается имя записи кэша по умолчанию, присвоенное `name` атрибуту значения "default".  
  
Атрибутам `cacheMemoryLimitMegabytes` и `physicalMemoryPercentage` присваивается нулевое значение. Это означает, что эвристика автомасштабирования <xref:System.Runtime.Caching.MemoryCache> используется по умолчанию. Реализация кэша должна каждые две минуты сравнивать текущую загрузку памяти с абсолютными и процентными ограничениями по памяти.  
  
```xml  
<configuration>  
  <system.runtime.caching>  
    <memoryCache>  
      <namedCaches>  
          <add name="Default"
               cacheMemoryLimitMegabytes="0"
               physicalMemoryLimitPercentage="0"  
               pollingInterval="00:02:00" />  
      </namedCaches>  
    </memoryCache>  
  </system.runtime.caching>  
</configuration>  
```  
  
## <a name="see-also"></a>См. также

- [\<memoryCache> Элемент (параметры кэша)](memorycache-element-cache-settings.md)

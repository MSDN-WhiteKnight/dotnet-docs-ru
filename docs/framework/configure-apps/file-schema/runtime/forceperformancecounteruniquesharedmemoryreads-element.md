---
description: 'Дополнительные сведения о: <forcePerformanceCounterUniqueSharedMemoryReads> element'
title: Элемент <forcePerformanceCounterUniqueSharedMemoryReads>
ms.date: 03/30/2017
helpviewer_keywords:
- forcePerformanceCounterUniqueSharedMemoryReads element
- <forcePerformanceCounterUniqueSharedMemoryReads> element
ms.assetid: 91149858-4810-4f65-9b48-468488172c9b
ms.openlocfilehash: 63fe695cc993faa851a9ea3196294397d2992c45
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99787036"
---
# <a name="forceperformancecounteruniquesharedmemoryreads-element"></a>Элемент \<forcePerformanceCounterUniqueSharedMemoryReads>

Указывает, использует ли файл PerfCounter.dll параметр реестра CategoryOptions в приложении .NET Framework версии 1.1, чтобы определить, следует ли загружать данные счетчиков производительности из общей памяти конкретной категории или глобальной памяти.  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<runtime>**](runtime-element.md)\
&nbsp;&nbsp;&nbsp;&nbsp;**\<forcePerformanceCounterUniqueSharedMemoryReads>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<forcePerformanceCounterUniqueSharedMemoryReads
enabled="true|false"/>  
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|`enabled`|Обязательный атрибут.<br /><br /> Указывает, использует ли PerfCounter.dll параметр реестра Категорйоптионс, чтобы определить, следует ли загружать данные счетчиков производительности из общей памяти конкретной категории или глобальной памяти.|  
  
## <a name="enabled-attribute"></a>Атрибут enabled  
  
|Значение|Описание|  
|-----------|-----------------|  
|`false`|PerfCounter.dll не использует параметр реестра Категорйоптионс, это значение по умолчанию.|  
|`true`|PerfCounter.dll использует параметр реестра Категорйоптионс.|  
  
### <a name="child-elements"></a>Дочерние элементы  

 Отсутствует.  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|`configuration`|Корневой элемент в любом файле конфигурации, используемом средой CLR и приложениями .NET Framework.|  
|`runtime`|Содержит сведения о привязке сборок и сборке мусора.|  
  
## <a name="remarks"></a>Remarks  

 В версиях платформа .NET Framework до платформа .NET Framework 4 версия PerfCounter.dll, которая была загружена, соответствует среде выполнения, загруженной в процессе. Если на компьютере установлены как платформа .NET Framework версии 1,1, так и платформа .NET Framework 2,0, то приложение платформа .NET Framework 1,1 загрузит платформа .NET Framework 1,1 версии PerfCounter.dll. Начиная с платформа .NET Framework 4, загружается последняя установленная версия PerfCounter.dll. Это означает, что приложение платформа .NET Framework 1,1 будет загружать версию PerfCounter.dll платформа .NET Framework 4, если на компьютере установлен платформа .NET Framework 4.  
  
 Начиная с платформа .NET Framework 4 при использовании счетчиков производительности PerfCounter.dll проверяет запись реестра Категорйоптионс для каждого поставщика, чтобы определить, должен ли он выполнять чтение из общей памяти конкретной категории или глобальной общей памяти. Платформа .NET Framework 1,1 PerfCounter.dll не считывает эту запись реестра, так как она не поддерживает общую память, относящуюся к категории. Он всегда считывает данные из глобальной общей памяти.  
  
 Для обеспечения обратной совместимости платформа .NET Framework 4 PerfCounter.dll не проверяет запись реестра Категорйоптионс при запуске в приложении платформа .NET Framework 1,1. Он просто использует глобальную общую память так же, как PerfCounter.dll платформа .NET Framework 1,1. Однако можно указать платформа .NET Framework 4 PerfCounter.dll, чтобы проверить параметр реестра, включив `<forcePerformanceCounterUniqueSharedMemoryReads>` элемент.  
  
> [!NOTE]
> Включение `<forcePerformanceCounterUniqueSharedMemoryReads>` элемента не гарантирует, что будет использоваться общая память, относящаяся к категории. Включение параметра включает `true` только PerfCounter.dll для ссылки на параметр реестра категорйоптионс. Значение по умолчанию для Категорйоптионс — использовать общую память, относящуюся к категории; Однако можно изменить Категорйоптионс, чтобы указать, что следует использовать глобальную общую память.  
  
 Раздел реестра, содержащий параметр Категорйоптионс, — HKEY_LOCAL_MACHINE\System\CurrentControlSet\Services\\<CategoryName \> \перформанце. По умолчанию Категорйоптионс имеет значение 3, что указывает PerfCounter.dll использовать общую память конкретной категории. Если Категорйоптионс имеет значение 0, PerfCounter.dll использует глобальную общую память. Данные экземпляра будут использоваться повторно только в том случае, если имя создаваемого экземпляра идентично повторно используемому экземпляру. Все версии будут иметь возможность записи в категорию. Если для Категорйоптионс задано значение 1, используется глобальная общая память, но данные экземпляра могут использоваться повторно, если длина имени категории совпадает с длиной повторно используемого категории.  
  
 Параметры 0 и 1 могут привести к утечке памяти и заполнению памяти счетчика производительности.  
  
## <a name="example"></a>Пример  

 В следующем примере показано, как указать, что PerfCounter.dll должен ссылаться на запись реестра Категорйоптионс, чтобы определить, должна ли она использовать общую память, относящуюся к определенной категории.  
  
```xml  
<configuration>  
  <runtime>  
    <forcePerformanceCounterUniqueSharedMemoryReads enabled="true"/>  
  </runtime>  
</configuration>  
```  
  
## <a name="see-also"></a>См. также

- [Схема параметров среды выполнения](index.md)
- [Схема файла конфигурации](../index.md)

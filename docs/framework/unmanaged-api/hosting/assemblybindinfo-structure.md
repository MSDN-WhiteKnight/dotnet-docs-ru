---
description: 'Дополнительные сведения о: структура Ассемблибиндинфо'
title: Структура AssemblyBindInfo
ms.date: 03/30/2017
api_name:
- AssemblyBindInfo
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- AssemblyBindInfo
helpviewer_keywords:
- AssemblyBindInfo structure [.NET Framework hosting]
ms.assetid: 6fc01e98-c2e7-49de-ab9f-95937cc89017
topic_type:
- apiref
ms.openlocfilehash: 3e11e05924ee6818737f84d9ca92394ee5313292
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99799984"
---
# <a name="assemblybindinfo-structure"></a>Структура AssemblyBindInfo

Предоставляет подробные сведения о сборке, на которую указывает ссылка.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
typedef struct _AssemblyBindInfo {  
    DWORD       dwAppDomainId;  
    LPCWSTR     lpReferencedIdentity;  
    LPCWSTR     lpPostPolicyIdentity;  
    DWORD       ePolicyLevel;  
} AssemblyBindInfo;  
```  
  
## <a name="members"></a>Члены  
  
|Член|Описание|  
|------------|-----------------|  
|`dwAppDomainId`|Уникальный идентификатор для, `IStream` возвращаемого вызовом метода [IHostAssemblyStore::P ровидеассембли](ihostassemblystore-provideassembly-method.md), из которого загружается сборка, на которую указывает ссылка.|  
|`lpReferencedIdentity`|Уникальный идентификатор сборки, на которую указывает ссылка.|  
|`lpPostPolicyIdentity`|Идентификатор сборки, на которую указывает ссылка, после применения любых значений политики привязки.|  
|`ePolicyLevel`|Одно из значений [еполициактион](epolicyaction-enumeration.md) , указывающее, какие политики управления версиями должны применяться к сборке, на которую указывает ссылка.|  
  
## <a name="remarks"></a>Remarks  

 Узел предоставляет уникальный идентификатор среде CLR `dwAppDomainId` . После `IHostAssemblyStore::ProvideAssembly` возврата вызова среда выполнения использует идентификатор, чтобы определить, `IStream` сопоставлено ли содержимое объекта. Если это так, среда выполнения загружает существующую копию вместо повторного сопоставления потока. Среда выполнения также использует этот идентификатор в качестве ключа поиска для потоков, возвращаемых из вызовов [IHostAssemblyStore::P ровидемодуле](ihostassemblystore-providemodule-method.md). Таким образом, идентификатор должен быть уникальным для запросов модуля и для запросов сборки.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** MSCorEE. idl  
  
 **Библиотека:** Включается в качестве ресурса в MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Структуры размещения](hosting-structures.md)
- [Интерфейс ICLRAssemblyIdentityManager](iclrassemblyidentitymanager-interface.md)
- [Интерфейс ICLRAssemblyReferenceList](iclrassemblyreferencelist-interface.md)
- [Интерфейс IHostAssemblyManager](ihostassemblymanager-interface.md)
- [Интерфейс IHostAssemblyStore](ihostassemblystore-interface.md)
- [Структура ModuleBindInfo](modulebindinfo-structure.md)

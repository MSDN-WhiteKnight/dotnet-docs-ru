---
description: Дополнительные сведения о перечислении Етасктипе
title: Перечисление ETaskType
ms.date: 03/30/2017
api_name:
- ETaskType
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- ETaskType
helpviewer_keywords:
- ETaskType enumeration [.NET Framework hosting]
ms.assetid: aa527b31-89d4-41f2-ad6f-63b76950b7df
topic_type:
- apiref
ms.openlocfilehash: 7cb241765b2ff3b4a3402221c6b3e2b7ff6305c1
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99785410"
---
# <a name="etasktype-enumeration"></a>Перечисление ETaskType

Содержит значения, указывающие тип задачи, представленной интерфейсом [ICLRTask](iclrtask-interface.md) или [IHostTask](ihosttask-interface.md) .  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
typedef enum ETaskType {  
    TT_DEBUGGERHELPER           = 0x1,  
    TT_GC                       = 0x2,  
    TT_FINALIZER                = 0x4,  
    TT_THREADPOOL_TIMER         = 0x8,  
    TT_THREADPOOL_GATE          = 0x10,  
    TT_THREADPOOL_WORKER        = 0x20,  
    TT_THREADPOOL_IOCOMPLETION  = 0x40,  
    TT_ADUNLOAD                 = 0x80,  
    TT_USER                     = 0x100,  
    TT_THREADPOOL_WAIT          = 0x200,  
    TT_UNKNOWN                  = 0x80000000  
} ETaskType;  
```  
  
## <a name="members"></a>Члены  
  
|Член|Описание|  
|------------|-----------------|  
|`TT_ADUNLOAD`|Интерфейс представляет задачу выгрузки домена приложения.|  
|`TT_DEBUGGERHELPER`|Интерфейс представляет вспомогательную задачу отладчика.|  
|`TT_FINALIZER`|Интерфейс представляет задачу финализатора.|  
|`TT_GC`|Интерфейс представляет задачу сборки мусора.|  
|`TT_THREADPOOL_GATE`|Интерфейс представляет задачу потока шлюза.|  
|`TT_THREADPOOL_IOCOMPLETION`|Интерфейс представляет задачу потока ввода-вывода или задачи потока порта завершения.|  
|`TT_THREADPOOL_TIMER`|Интерфейс представляет задачу потока таймера.|  
|`TT_THREADPOOL_WAIT`|Интерфейс представляет задачу потока ожидания.|  
|`TT_THREADPOOL_WORKER`|Интерфейс представляет задачу рабочего потока.|  
|`TT_UNKNOWN`|Задача неизвестна.|  
|`TT_USER`|Интерфейс представляет задачу пользователя.|  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** MSCorEE. h  
  
 **Библиотека:** MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Размещение перечислений](hosting-enumerations.md)

---
description: 'Дополнительные сведения о: структура CorDebugBlockingObject'
title: Структура CorDebugBlockingObject
ms.date: 03/30/2017
api_name:
- CorDebugBlockingObject Structure
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- CorDebugBlockingObject
helpviewer_keywords:
- CorDebugBlockingObject structure [.NET Framework debugging]
ms.assetid: 5944edd1-0914-4efa-aba0-d5a277c38b1a
topic_type:
- apiref
ms.openlocfilehash: 2b16af5eecb01067c2ee6811613f964af391f345
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99712224"
---
# <a name="cordebugblockingobject-structure"></a>Структура CorDebugBlockingObject

Определяет объект, который блокирует поток и конкретную причину блокировки потока.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
Typedef struct CorDebugBlockingObject  
{  
ICorDebugValue pBlockingObject;  
DWORD dwTimeout;  
CorDebugBlockingReason blockingReason;  
}  CorDebugBlockingObject;  
```  
  
## <a name="members"></a>Члены  
  
|Член|Описание|  
|------------|-----------------|  
|`pBlockingObject`|Объект, для которого блокируется поток. Этот объект допустим только в течение текущего синхронизированного состояния. Если два потока блокируют один и тот же объект в одном и том же синхронизированном состоянии, то, возможно, предполагается, что метод [ICorDebugValue::](icordebugvalue-getaddress-method.md) GetObject возвратит одно и то же значение. Однако интерфейсы могут и не быть эквивалентными указателями.|  
|`dwTimeout`|Время ожидания (в миллисекундах), по истечении которого операция блокирования истечет или бесконечное значение, которое указывает, что время ожидания не истечет. Значение времени ожидания указывает общий период времени для блокирующей операции, а не оставшееся время.|  
|`blockingReason`|Причина, по которой поток блокируется для этого объекта.|  
  
## <a name="remarks"></a>Remarks  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug. idl  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v40plus](../../../../includes/net-current-v40plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Структуры отладки](debugging-structures.md)
- [Отладка](index.md)

---
description: 'Дополнительные сведения о методе: ICorDebugValue3:: GetSize64'
title: Метод ICorDebugValue3::GetSize64
ms.date: 03/30/2017
api_name:
- ICorDebugValue3::GetSize64
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICorDebugValue3::GetSize64
helpviewer_keywords:
- GetSize64 method, ICorDebugValue3 interface [.NET Framework debugging]
- ICorDebugValue3::GetSize64 method [.NET Framework debugging]
ms.assetid: fee56a29-3154-4192-958d-71da2ced3740
topic_type:
- apiref
ms.openlocfilehash: ce7db5211c6a8fc16b58e0197fa3142b5b744d96
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99690201"
---
# <a name="icordebugvalue3getsize64-method"></a>Метод ICorDebugValue3::GetSize64

Возвращает размер данного объекта [ICorDebugValue3](icordebugvalue3-interface.md) в байтах.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT GetSize64(  
    [out] ULONG64 *pSize  
);  
```  
  
## <a name="parameters"></a>Параметры  

 псизе  
 заполняет Указатель на размер данного объекта в байтах.  
  
## <a name="remarks"></a>Remarks  

 Если этот тип значения является ссылочным, этот метод возвращает размер указателя, а не размер объекта.  
  
 `ICorDebugValue3::GetSize`Метод отличается от метода [ICorDebugValue:: resize](icordebugvalue-getsize-method.md) в типе выходного параметра. В [ICorDebugValue::-size](icordebugvalue-getsize-method.md)параметр Output имеет значение `ULONG32` ; в, а `ICorDebugValue3::GetSize` — `ULONG64` . Это позволяет интерфейсу [ICorDebugValue3](icordebugvalue3-interface.md) сообщать размер массивов, ПРЕВЫШАЮЩИХ 2 ГБ.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v45plus](../../../../includes/net-current-v45plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICorDebugValue3](icordebugvalue3-interface.md)
- [Интерфейсы отладки](debugging-interfaces.md)

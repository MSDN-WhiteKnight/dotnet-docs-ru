---
description: 'Дополнительные сведения о методе: ICorDebugVirtualUnwinder:: oncontext'
title: Метод ICorDebugVirtualUnwinder::GetContext
ms.date: 03/30/2017
ms.assetid: fe502a76-3068-47e5-a0a0-85ccb72dfac3
ms.openlocfilehash: 864f32ce82149658b2d4a617b08e8d7aa41fe642
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99790533"
---
# <a name="icordebugvirtualunwindergetcontext-method"></a>Метод ICorDebugVirtualUnwinder::GetContext

Получает текущий контекст этого средства очистки.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT GetContext(  
   [in] ULONG32 contextFlags,  
   [in] ULONG32 cbContextBuf,  
   [out] ULONG32* contextSize,  
   [out, size_is(cbContextBuf)] BYTE contextBuf[]  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `contextFlags`  
 [in] Флаги, указывающие, какие части контекста следует возвращать (определенные в заголовке WinNt.h).  
  
 `cbContextBuf`  
 [in] Количество байтов в `contextBuf`.  
  
 `contextSize`  
 [out] Указатель на число байтов, фактически записанных в `contextBuf`.  
  
 `contextBuf`  
 [out] Байтовый массив, содержащий текущий контекст этого средства очистки.  
  
## <a name="return-value"></a>Возвращаемое значение  

 Любое ошибочное значение HRESULT , полученное процессом mscordbi, считается неустранимым и приводит к возврату интерфейсами API ICorDebug значения `CORDBG_E_DATA_TARGET_ERROR`.  
  
## <a name="remarks"></a>Remarks  

 Начальное значение аргумента задается `contextBuf` в буфере контекста, возвращаемом путем вызова метода [икордебугстакквалк:: oncontext](icordebugstackwalk-getcontext-method.md) .  
  
> [!NOTE]
> Этот метод доступен только в машинном коде .NET.  
  
 Поскольку очистка может восстановить только подмножество регистров, например только неизменяемые регистры, контекст может не соответствовать в точности состоянию регистра во время фактического вызова метода.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_46_native](../../../../includes/net-46-native-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICorDebugMemoryBuffer](icordebugmemorybuffer-interface.md)
- [Интерфейсы отладки](debugging-interfaces.md)

---
description: 'Дополнительные сведения о методе: ICorDebugProcess:: GetThreadContext'
title: Метод ICorDebugProcess::GetThreadContext
ms.date: 03/30/2017
api_name:
- ICorDebugProcess.GetThreadContext
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICorDebugProcess::GetThreadContext
helpviewer_keywords:
- ICorDebugProcess::GetThreadContext method [.NET Framework debugging]
- GetThreadContext method, ICorDebugProcess interface [.NET Framework debugging]
ms.assetid: 5b132ef1-8d4b-4525-89b3-54123596c194
topic_type:
- apiref
ms.openlocfilehash: 4cb926183522548e924013580f207d1d0677a0d3
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99746871"
---
# <a name="icordebugprocessgetthreadcontext-method"></a>Метод ICorDebugProcess::GetThreadContext

Возвращает контекст для данного потока в этом процессе.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT GetThreadContext(  
    [in] DWORD threadID,  
    [in] ULONG32 contextSize,  
    [in, out, length_is(contextSize), size_is(contextSize)]  
    BYTE context[]);  
```  
  
## <a name="parameters"></a>Параметры  

 `threadID`  
 окне Идентификатор потока, для которого извлекается контекст.  
  
 `contextSize`  
 [in] Размер массива `context`.  
  
 `context`  
 [вход, выход] Массив байтов, описывающих контекст потока.  
  
 Контекст указывает архитектуру процессора, на котором работает поток.  
  
## <a name="remarks"></a>Remarks  

 Отладчик должен вызывать этот метод вместо `GetThreadContext` метода Win32, так как поток может находиться в состоянии "перехвачено", в котором его контекст временно изменен. Этот метод следует использовать только в том случае, если поток находится в машинном коде. Используйте [ICorDebugRegisterSet](icordebugregisterset-interface.md) для потоков в управляемом коде.  
  
 Возвращаемые данные — это структура контекста для текущей платформы. Как и в случае с `GetThreadContext` методом Win32, вызывающий объект должен инициализировать `context` параметр перед вызовом этого метода.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]

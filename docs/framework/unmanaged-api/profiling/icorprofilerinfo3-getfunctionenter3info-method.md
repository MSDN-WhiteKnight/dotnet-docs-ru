---
description: 'Дополнительные сведения о методе: ICorProfilerInfo3:: GetFunctionEnter3Info'
title: Метод ICorProfilerInfo3::GetFunctionEnter3Info
ms.date: 03/30/2017
api_name:
- ICorProfilerInfo3.GetFunctionEnter3Info Method
api_location:
- Mscorwks.dll
api_type:
- COM
f1_keywords:
- ICorProfilerInfo3::GetFunctionEnter3Info
helpviewer_keywords:
- GetFunctionEnter3Info method [.NET Framework profiling]
- ICorProfilerInfo3::GetFunctionEnter3Info method [.NET Framework profiling]
ms.assetid: 542c7c65-dd56-4651-b76f-5db2465e4a15
topic_type:
- apiref
ms.openlocfilehash: 3e6c0cfbf2518301e62ed5c57e956190066504ba
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99646820"
---
# <a name="icorprofilerinfo3getfunctionenter3info-method"></a>Метод ICorProfilerInfo3::GetFunctionEnter3Info

Предоставляет кадр стека и сведения о аргументах функции, о которой сообщается профилировщику функцией [FunctionEnter3WithInfo](functionenter3withinfo-function.md) . Этот метод может быть вызван только во время обратного вызова `FunctionEnter3WithInfo`.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT GetFunctionEnter3Info(  
            [in]  FunctionID functionId,
            [in]  COR_PRF_ELT_INFO eltInfo,  
            [out] COR_PRF_FRAME_INFO *pFrameInfo,  
            [in, out] ULONG *pcbArgumentInfo,  
            [out, size_is(*pcbArgumentInfo)]  
                  COR_PRF_FUNCTION_ARGUMENT_INFO *pArgumentInfo);  
```  
  
## <a name="parameters"></a>Параметры  

 `functionId`  
 [in] `FunctionID` функции, которая вводится.  
  
 `eltInfo`  
 [in] Непрозрачный дескриптор, представляющий сведения об указанном кадре стека. Профилировщик должен предоставить те же данные `eltInfo` , что и функция [FunctionEnter3WithInfo](functionenter3withinfo-function.md) .  
  
 `pFrameInfo`  
 [out] Непрозрачный дескриптор, представляющий универсальные сведения об указанном кадре стека. Этот дескриптор допустим только во время обратного вызова `FunctionEnter3WithInfo`, в котором профилировщик вызывал метод `GetFunctionEnter3Info`.  
  
 `pcbArgumentInfo`  
 [вход, выход] Указатель на общий размер (в байтах) структуры [COR_PRF_FUNCTION_ARGUMENT_INFO](cor-prf-function-argument-info-structure.md) (плюс все дополнительные структуры [COR_PRF_FUNCTION_ARGUMENT_RANGE](cor-prf-function-argument-range-structure.md) для диапазонов аргументов, на которые указывает параметр `pArgumentInfo` ). Если указанный размер недостаточен, то возвращается значение ERROR_INSUFFICIENT_BUFFER, и ожидаемый размер сохраняется в `pcbArgumentInfo`. Чтобы вызвать `GetFunctionEnter3Info` только для получения ожидаемого значения для `*pcbArgumentInfo`, установите `*pcbArgumentInfo`= 0 и `pArgumentInfo`= NULL.  
  
 `pArgumentInfo`  
 заполняет Указатель на структуру [COR_PRF_FUNCTION_ARGUMENT_INFO](cor-prf-function-argument-info-structure.md) , описывающую расположения аргументов функции в памяти в порядке слева направо.  
  
## <a name="remarks"></a>Remarks  

 Профилировщик должен выделить достаточно места для структуры `COR_PRF_FUNCTION_ARGUMENT_INFO` проверяемой функции, и должен указать размер в параметре `pcbArgumentInfo`.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorProf.idl, CorProf.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v40plus](../../../../includes/net-current-v40plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [FunctionEnter3WithInfo](functionenter3withinfo-function.md)
- [FunctionLeave3WithInfo](functionleave3withinfo-function.md)
- [FunctionTailcall3WithInfo](functiontailcall3withinfo-function.md)
- [Интерфейс ICorProfilerInfo3](icorprofilerinfo3-interface.md)
- [Профилирующие интерфейсы](profiling-interfaces.md)
- [Профилирование](index.md)

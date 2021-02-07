---
description: 'Дополнительные сведения о методе: метод icorprofilerinfo4:: EnumJITedFunctions2'
title: Метод ICorProfilerInfo4::EnumJITedFunctions2
ms.date: 03/30/2017
api_name:
- ICorProfilerInfo4.EnumJITedFunctions2
api_location:
- mscorwks.dll
api_type:
- COM
f1_keywords:
- ICorProfilerInfo4::EnumJITedFunctions2
helpviewer_keywords:
- EnumJITedFunctions2 method, ICorProfilerInfo4 interface [.NET Framework profiling]
- ICorProfilerInfo4::EnumJITedFunctions2 method [.NET Framework profiling]
ms.assetid: 40e9a1be-9bd2-4fad-9921-34a84b61c1e3
topic_type:
- apiref
ms.openlocfilehash: 3740236cfe2bc7ecc6cd3bbeb3345c7510dd159f
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99686951"
---
# <a name="icorprofilerinfo4enumjitedfunctions2-method"></a>Метод ICorProfilerInfo4::EnumJITedFunctions2

Возвращает перечислитель для всех функций, которые были ранее скомпилированы JIT-компилятором и повторно скомпилированы. Этот метод заменяет метод [ICorProfilerInfo3:: EnumJITedFunctions](icorprofilerinfo3-enumjitedfunctions-method.md) , который не перечисляет идентификаторы, перекомпилированные с помощью JIT-компилятора.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT EnumJITedFunctions([out] ICorProfilerFunctionEnum** ppEnum);  
```  
  
## <a name="parameters"></a>Параметры  

 `ppEnum`  
 заполняет Указатель на перечислитель [ICorProfilerFunctionEnum](icorprofilerfunctionenum-interface.md) .  
  
## <a name="remarks"></a>Remarks  

 Этот метод может пересекаться с `JITCompilation` обратными вызовами, такими как метод [ICorProfilerCallback:: JITCompilationStarted](icorprofilercallback-jitcompilationstarted-method.md) . Возвращаемое перечисление содержит значения для `COR_PRF_FUNCTION::reJitId` поля. Метод [ICorProfilerInfo3:: EnumJITedFunctions](icorprofilerinfo3-enumjitedfunctions-method.md) , который заменяет этот метод, не перечисляет идентификаторы, перекомпилированные с помощью JIT-компилятора, поскольку `COR_PRF_FUNCTION::reJitId` поле всегда имеет значение 0. `ICorProfilerInfo4::EnumJITedFunctions`Метод выполняет перечисление идентификаторов, перекомпилированных JIT-компилятором, так как `COR_PRF_FUNCTION::reJitId` поле задано правильно. Обратите внимание, что метод [метод icorprofilerinfo4:: EnumJITedFunctions2](icorprofilerinfo4-enumjitedfunctions2-method.md) может запускать сборку мусора, в то время как [метод ICorProfilerInfo3:: EnumJITedFunctions](icorprofilerinfo3-enumjitedfunctions-method.md) не будет.  Дополнительные сведения см. в разделе [CORPROF_E_UNSUPPORTED_CALL_SEQUENCE HRESULT](corprof-e-unsupported-call-sequence-hresult.md).  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorProf.idl, CorProf.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v45plus](../../../../includes/net-current-v45plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Метод EnumJITedFunctions](icorprofilerinfo3-enumjitedfunctions-method.md)
- [Интерфейс ICorProfilerInfo4](icorprofilerinfo4-interface.md)
- [Профилирующие интерфейсы](profiling-interfaces.md)
- [Профилирование](index.md)

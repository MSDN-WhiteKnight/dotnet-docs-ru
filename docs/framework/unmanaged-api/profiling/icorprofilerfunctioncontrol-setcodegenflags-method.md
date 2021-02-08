---
description: 'Дополнительные сведения о методе: Икорпрофилерфунктионконтрол:: SetCodegenFlags'
title: Метод ICorProfilerFunctionControl::SetCodegenFlags
ms.date: 03/30/2017
api_name:
- ICorProfilerFunctionControl.SetCodegenFlags
api_location:
- mscorwks.dll
api_type:
- COM
f1_keywords:
- ICorProfilerFunctionControl::SetCodegenFlags
helpviewer_keywords:
- ICorProfilerFunctionControl::SetCodegenFlags method [.NET Framework profiling]
- SetCodegenFlags method, ICorProfilerFunctionControl interface [.NET Framework profiling]
ms.assetid: a2d5daa5-b990-4ae5-bf2a-c0862fe58bd7
topic_type:
- apiref
ms.openlocfilehash: 61fa8be0993a06a3b2d352af408ac47b7b30e385
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99781627"
---
# <a name="icorprofilerfunctioncontrolsetcodegenflags-method"></a>Метод ICorProfilerFunctionControl::SetCodegenFlags

Задает один или несколько флагов из перечисления [COR_PRF_CODEGEN_FLAGS](cor-prf-codegen-flags-enumeration.md) для управления созданием кода для перекомпилированной функции JIT.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT SetCodegenFlags(  
    [in] DWORD flags);  
```  
  
## <a name="parameters"></a>Параметры  

 `flags`  
 окне Один или несколько флагов из перечисления [COR_PRF_CODEGEN_FLAGS](cor-prf-codegen-flags-enumeration.md) .  
  
## <a name="remarks"></a>Remarks  

 Профилировщик получает экземпляр этого интерфейса через обратный вызов [ICorProfilerCallback4:: жетрежитпараметерс](icorprofilercallback4-getrejitparameters-method.md) . `SetCodegenFlags` позволяет профилировщику управлять созданием кода для повторно скомпилированной функции. Как и в случае с другими параметрами повторной компиляции JIT, флаги создания кода применяются ко всем экземплярам функции.  
  
 JIT-компилятор рассматривает эти флаги компиляции вместе с другими флагами, заданными другими источниками, при компиляции функции.  Другие источники включают отладчик, глобальные флаги, заданные профилировщиком при запуске, с помощью метода [ICorProfilerInfo:: SetEventMask](icorprofilerinfo-seteventmask-method.md) (со значениями `COR_PRF_DISABLE_INLINING` и `COR_PRF_DISABLE_OPTIMIZATIONS` ) и обратного вызова [ICorProfilerCallback:: житинлининг](icorprofilercallback-jitinlining-method.md) профилировщика.  JIT-компилятор обеспечивает приоритет к источнику, который запрашивает наименьший уровень оптимизации.  Например, если профилировщик указывает при `COR_PRF_DISABLE_INLINING` запуске, но не указан `COR_PRF_CODEGEN_DISABLE_INLINING` в обратном вызове [Икорпрофилерфунктионконтрол:: SetCodegenFlags](icorprofilerfunctioncontrol-setcodegenflags-method.md) , встраивание по-прежнему отключено.  Аналогично, если профилировщик не указывает `COR_PRF_CODEGEN_DISABLE_INLINING` в `SetCodegenFlags` , а затем отключает встраивание с помощью обратного вызова [ICorProfilerCallback:: житинлининг](icorprofilercallback-jitinlining-method.md) , встраивание отключено.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorProf.idl, CorProf.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v45plus](../../../../includes/net-current-v45plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICorProfilerFunctionControl](icorprofilerfunctioncontrol-interface.md)

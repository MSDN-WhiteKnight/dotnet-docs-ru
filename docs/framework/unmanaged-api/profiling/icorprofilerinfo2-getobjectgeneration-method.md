---
description: 'Дополнительные сведения о методе: ICorProfilerInfo2:: GetObjectGeneration'
title: Метод ICorProfilerInfo2::GetObjectGeneration
ms.date: 03/30/2017
api_name:
- ICorProfilerInfo2.GetObjectGeneration
api_location:
- mscorwks.dll
api_type:
- COM
f1_keywords:
- ICorProfilerInfo2::GetObjectGeneration
helpviewer_keywords:
- GetObjectGeneration method [.NET Framework profiling]
- ICorProfilerInfo2::GetObjectGeneration method [.NET Framework profiling]
ms.assetid: b0d25f76-0bd5-4aa6-96cf-bfec0e1de28b
topic_type:
- apiref
ms.openlocfilehash: f4927c081393a11f7dad7d59cce311b82072659c
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99716435"
---
# <a name="icorprofilerinfo2getobjectgeneration-method"></a>Метод ICorProfilerInfo2::GetObjectGeneration

Возвращает сегмент кучи, который содержит указанный объект.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT GetObjectGeneration(  
    [in] ObjectID objectId,  
    [out] COR_PRF_GC_GENERATION_RANGE *range);  
```  
  
## <a name="parameters"></a>Параметры  

 `objectId`  
 окне Идентификатор объекта.  
  
 `range`  
 заполняет Указатель на структуру [COR_PRF_GC_GENERATION_RANGE](cor-prf-gc-generation-range-structure.md) , описывающую диапазон (т. е. блок) памяти в поколении, которое является сборкой мусора. Этот диапазон содержит указанный объект.  
  
## <a name="remarks"></a>Remarks  

 `GetObjectGeneration`Метод может быть вызван из любого обратного вызова профилировщика при условии, что сборка мусора не выполняется. То есть он может быть вызван из любого обратного вызова, за исключением тех, которые происходят между [ICorProfilerCallback2:: GarbageCollectionStarted](icorprofilercallback2-garbagecollectionstarted-method.md) и [ICorProfilerCallback2:: GarbageCollectionFinished](icorprofilercallback2-garbagecollectionfinished-method.md).  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorProf.idl, CorProf.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICorProfilerInfo](icorprofilerinfo-interface.md)
- [Интерфейс ICorProfilerInfo2](icorprofilerinfo2-interface.md)

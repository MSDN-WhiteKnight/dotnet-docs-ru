---
description: 'Дополнительные сведения о методе ICorProfilerCallback:: RootReferences'
title: Метод ICorProfilerCallback::RootReferences
ms.date: 03/30/2017
api_name:
- ICorProfilerCallback.RootReferences
api_location:
- mscorwks.dll
api_type:
- COM
f1_keywords:
- ICorProfilerCallback::RootReferences
helpviewer_keywords:
- RootReferences method [.NET Framework profiling]
- ICorProfilerCallback::RootReferences method [.NET Framework profiling]
ms.assetid: dbdf853b-d1a4-4828-8ef7-53d121d8e6ae
topic_type:
- apiref
ms.openlocfilehash: e09434c425784e646c9856693abdfd4ac0d49273
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99788869"
---
# <a name="icorprofilercallbackrootreferences-method"></a>Метод ICorProfilerCallback::RootReferences

Уведомляет профилировщик о получении сведений о корневых ссылках после сборки мусора.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT RootReferences(  
    [in] ULONG    cRootRefs,  
    [in, size_is(cRootRefs)] ObjectID rootRefIds[] );  
```  
  
## <a name="parameters"></a>Параметры  

 `cRootRefs`  
 окне Число ссылок в `rootRefIds` массиве.  
  
 `rootRefIds`  
 окне Массив идентификаторов объектов, ссылающихся либо на статический объект, либо на объект в стеке.  
  
## <a name="remarks"></a>Remarks  

 `RootReferences`Для уведомления профилировщика вызываются методы и [ICorProfilerCallback2:: RootReferences2](icorprofilercallback2-rootreferences2-method.md) . Профилировщики обычно реализуют один или другой, но не оба, так как передаваемые сведения `RootReferences2` являются надмножеством переданного `RootReferences` .  
  
 `rootRefIds`Массив может содержать пустой объект. Например, все ссылки на объекты, объявленные в стеке, рассматриваются сборщиком мусора как корни и всегда будут сообщать о них.  
  
 Идентификаторы объектов, возвращаемые, `RootReferences` недопустимы во время обратного вызова, так как сборка мусора может находиться в процессе перемещения объектов из старых адресов в новые адреса. Таким образом, профилировщики не должны пытаться проверять объекты во время `RootReferences` вызова. При вызове [ICorProfilerCallback2:: GarbageCollectionFinished](icorprofilercallback2-garbagecollectionfinished-method.md) все объекты были перемещены в новые расположения и могут быть безопасно проверены.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorProf.idl, CorProf.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICorProfilerCallback](icorprofilercallback-interface.md)

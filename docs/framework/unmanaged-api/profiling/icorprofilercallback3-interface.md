---
description: 'Дополнительные сведения о: интерфейс ICorProfilerCallback3'
title: Интерфейс ICorProfilerCallback3
ms.date: 03/30/2017
api_name:
- ICorProfilerCallback3
api_location:
- mscorwks.dll
api_type:
- COM
f1_keywords:
- ICorProfilerCallback3
helpviewer_keywords:
- ICorProfilerCallback3 interface [.NET Framework profiling]
ms.assetid: be83af41-3dec-4c77-8529-9dd6b8042af6
topic_type:
- apiref
ms.openlocfilehash: 70fba8768fef5da411b566d918308989a3f6e863
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99788804"
---
# <a name="icorprofilercallback3-interface"></a>Интерфейс ICorProfilerCallback3

Предоставляет методы обратного вызова, используемые средой CLR для передачи сведений о состоянии подключения и отсоединения профилировщику.  
  
## <a name="methods"></a>Методы  
  
|Метод|Описание|  
|------------|-----------------|  
|[Метод InitializeForAttach](icorprofilercallback3-initializeforattach-method.md)|Вызывается средой CLR, чтобы предоставить профилировщику возможность инициализировать свое состояние после операции присоединения.|  
|[Метод ProfilerAttachComplete](icorprofilercallback3-profilerattachcomplete-method.md)|Вызывается средой CLR для указания на то, что профилировщик теперь может вызывать методы перехвата.|  
|[Метод ProfilerDetachSucceeded](icorprofilercallback3-profilerdetachsucceeded-method.md)|Уведомляет профилировщик о том, что среда CLR намерена выгрузить библиотеку DLL профилировщика.|  
  
## <a name="remarks"></a>Remarks  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorProf.idl, CorProf.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v40plus](../../../../includes/net-current-v40plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Профилирующие интерфейсы](profiling-interfaces.md)
- [Интерфейс ICorProfilerInfo](icorprofilerinfo-interface.md)
- [Интерфейс ICorProfilerCallback2](icorprofilercallback2-interface.md)
- [Интерфейс ICorProfilerCallback4](icorprofilercallback4-interface.md)

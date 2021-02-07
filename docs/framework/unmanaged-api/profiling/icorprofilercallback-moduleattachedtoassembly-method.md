---
description: 'Дополнительные сведения о методе ICorProfilerCallback:: Модулеаттачедтоассембли'
title: Метод ICorProfilerCallback::ModuleAttachedToAssembly
ms.date: 03/30/2017
api_name:
- ICorProfilerCallback.ModuleAttachedToAssembly
api_location:
- mscorwks.dll
api_type:
- COM
f1_keywords:
- ICorProfilerCallback::ModuleAttachedToAssembly
helpviewer_keywords:
- ICorProfilerCallback::ModuleAttachedToAssembly method [.NET Framework profiling]
- ModuleAttachedToAssembly method [.NET Framework profiling]
ms.assetid: b595798a-5d40-4cac-ab4f-911c61d2c5d2
topic_type:
- apiref
ms.openlocfilehash: cc6a83188a8bdc4826232aa6ff6e416cbb8ae893
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99705601"
---
# <a name="icorprofilercallbackmoduleattachedtoassembly-method"></a>Метод ICorProfilerCallback::ModuleAttachedToAssembly

Уведомляет профилировщик о том, что модуль присоединен к своей родительской сборке.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT ModuleAttachedToAssembly(  
    [in] ModuleID   moduleId,  
    [in] AssemblyID AssemblyId);  
```  
  
## <a name="parameters"></a>Параметры  

 `moduleId`  
 окне Идентификатор присоединяемого модуля.  
  
 `AssemblyId`  
 окне ИДЕНТИФИКАТОР родительской сборки, к которой присоединен модуль.  
  
## <a name="remarks"></a>Remarks  

 Модуль можно загрузить через таблицу адресов импорта (IAT), через вызов `LoadLibrary` или через ссылку на метаданные. В результате загрузчик среды CLR имеет несколько путей кода для определения сборки, в которой находится модуль. Таким образом, после вызова метода [ICorProfilerCallback:: ModuleLoadFinished](icorprofilercallback-moduleloadfinished-method.md) модуль не знает, в какой сборке он находится, и получение идентификатора родительской сборки невозможно. `ModuleAttachedToAssembly`Метод вызывается, когда модуль присоединяется к своей родительской сборке и может быть ПОЛУЧЕН идентификатор его родительской сборки.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorProf.idl, CorProf.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICorProfilerCallback](icorprofilercallback-interface.md)

---
description: 'Дополнительные сведения о методе ICorProfilerInfo:: SetILFunctionBody'
title: Метод ICorProfilerInfo::SetILFunctionBody
ms.date: 03/30/2017
api_name:
- ICorProfilerInfo.SetILFunctionBody
api_location:
- mscorwks.dll
api_type:
- COM
f1_keywords:
- ICorProfilerInfo::SetILFunctionBody
helpviewer_keywords:
- ICorProfilerInfo::SetILFunctionBody method [.NET Framework profiling]
- SetILFunctionBody method [.NET Framework profiling]
ms.assetid: b159c712-00f4-4fc7-a990-40bf9f642e8f
topic_type:
- apiref
ms.openlocfilehash: 38e7907080065dc96d72a3d38a67227414637a70
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99647171"
---
# <a name="icorprofilerinfosetilfunctionbody-method"></a>Метод ICorProfilerInfo::SetILFunctionBody

Заменяет тело указанной функции в указанном модуле.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT SetILFunctionBody(  
    [in] ModuleID    moduleId,  
    [in] mdMethodDef methodid,  
    [in] LPCBYTE     pbNewILMethodHeader);  
```  
  
## <a name="parameters"></a>Параметры  

 `moduleId`  
 окне Идентификатор модуля, в котором находится функция.  
  
 `methodid`  
 окне Токен функции, для которой заменяется текст.  
  
 `pbNewILMethodHeader`  
 окне Новый заголовок для функции.  
  
## <a name="remarks"></a>Remarks  

 `SetILFunctionBody`Метод заменяет относительный виртуальный адрес функции в метаданных таким образом, чтобы он указывал на новый текст функции, и при необходимости корректирует все внутренние структуры данных.  
  
 `SetILFunctionBody`Метод можно вызывать только для тех функций, которые никогда не были скомпилированы JIT-компилятором.  
  
 Используйте метод [ICorProfilerInfo:: GetILFunctionBodyAllocator](icorprofilerinfo-getilfunctionbodyallocator-method.md) , чтобы выделить пространство для нового метода, чтобы обеспечить совместимость буфера.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorProf.idl, CorProf.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICorProfilerInfo](icorprofilerinfo-interface.md)

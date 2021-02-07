---
description: 'Дополнительные сведения о методе: ICorProfilerInfo2:: GetClassFromTokenAndTypeArgs'
title: Метод ICorProfilerInfo2::GetClassFromTokenAndTypeArgs
ms.date: 03/30/2017
api_name:
- ICorProfilerInfo2.GetClassFromTokenAndTypeArgs
api_location:
- mscorwks.dll
api_type:
- COM
f1_keywords:
- ICorProfilerInfo2::GetClassFromTokenAndTypeArgs
helpviewer_keywords:
- GetClassFromTokenAndTypeArgs method [.NET Framework profiling]
- ICorProfilerInfo2::GetClassFromTokenAndTypeArgs method [.NET Framework profiling]
ms.assetid: b25c88f0-71b9-443b-8eea-1c94db0a44b9
topic_type:
- apiref
ms.openlocfilehash: 810445d2617beff55e00df6bb30130d81c740ba4
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99760507"
---
# <a name="icorprofilerinfo2getclassfromtokenandtypeargs-method"></a>Метод ICorProfilerInfo2::GetClassFromTokenAndTypeArgs

Возвращает объект `ClassID` типа, используя указанный токен метаданных и `ClassID` значения любых аргументов типа.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT GetClassFromTokenAndTypeArgs(  
    [in] ModuleID moduleID,  
    [in] mdTypeDef typeDef,  
    [in] ULONG32 cTypeArgs,  
    [in, size_is(cTypeArgs)] ClassID typeArgs[],  
    [out] ClassID* pClassID);  
```  
  
## <a name="parameters"></a>Параметры  

 `moduleID`  
 окне Идентификатор модуля, в котором находится тип.  
  
 `typeDef`  
 окне `mdTypeDef` Токен метаданных, ссылающийся на тип.  
  
 `cTypeArgs`  
 окне Число параметров типа для данного типа. Для типов, не являющихся универсальными, это значение должно быть равно нулю.  
  
 `typeArgs`  
 окне Массив `ClassID` значений, каждый из которых является аргументом типа. Значение `typeArgs` может быть равно null, если `cTypeArgs` имеет значение 0.  
  
 `pClassID`  
 заполняет Указатель на объект `ClassID` указанного типа.  
  
## <a name="remarks"></a>Remarks  

 Вызов `GetClassFromTokenAndTypeArgs` метода с помощью `mdTypeRef` вместо `mdTypeDef` токена метаданных может иметь непредсказуемые результаты; вызывающие объекты должны разрешить объект `mdTypeRef` в `mdTypeDef` при передаче.  
  
 Если тип еще не загружен, вызов инициирует `GetClassFromTokenAndTypeArgs` загрузку, что является опасной операцией во многих контекстах. Например, вызов этого метода во время загрузки модулей или других типов может привести к бесконечному циклу, так как среда выполнения пытается циклически загружать вещи.  
  
 Как правило, использование параметра `GetClassFromTokenAndTypeArgs` не рекомендуется. Если профилировщики заинтересованы в событиях для определенного типа, они должны хранить и для `ModuleID` `mdTypeDef` этого типа, а также использовать [ICorProfilerInfo2:: GetClassIDInfo2](icorprofilerinfo2-getclassidinfo2-method.md) для проверки того `ClassID` , относится ли данный тип к требуемому типу.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorProf.idl, CorProf.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICorProfilerInfo](icorprofilerinfo-interface.md)
- [Интерфейс ICorProfilerInfo2](icorprofilerinfo2-interface.md)

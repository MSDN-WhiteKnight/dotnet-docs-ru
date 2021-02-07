---
description: 'Дополнительные сведения о методе ICorProfilerInfo:: Исаррайкласс'
title: Метод ICorProfilerInfo::IsArrayClass
ms.date: 03/30/2017
api_name:
- ICorProfilerInfo.IsArrayClass
api_location:
- mscorwks.dll
api_type:
- COM
f1_keywords:
- ICorProfilerInfo::IsArrayClass
helpviewer_keywords:
- IsArrayClass method [.NET Framework profiling]
- ICorProfilerInfo::IsArrayClass method [.NET Framework profiling]
ms.assetid: 7f230961-23a6-4d56-ad2d-7a876d65705f
topic_type:
- apiref
ms.openlocfilehash: 1eee0b834c63c3cfe15bd08776214ca8b2ba3f69
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99687237"
---
# <a name="icorprofilerinfoisarrayclass-method"></a>Метод ICorProfilerInfo::IsArrayClass

Определяет, является ли указанный класс классом массива.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT IsArrayClass(  
    [in]  ClassID        classId,  
    [out] CorElementType *pBaseElemType,  
    [out] ClassID        *pBaseClassId,  
    [out] ULONG          *pcRank);  
```  
  
## <a name="parameters"></a>Параметры  

 `classId`  
 окне Идентификатор анализируемого класса.  
  
 `pBaseElemType`  
 заполняет Указатель на значение перечисления Корелементтипе, указывающее тип элементов массива.  
  
 `pBaseClassId`  
 заполняет Указатель на идентификатор класса элементов массива, если он доступен.  
  
 `pcRank`  
 заполняет Указатель на целое число, указывающее ранг (то есть количество измерений) массива.  
  
## <a name="remarks"></a>Remarks  

 Если указанный класс является классом массива, `IsArrayClass` метод возвращает S_OK HRESULT и значения для любых выходных параметров, отличных от NULL. В противном случае возвращается S_FALSE.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorProf.idl, CorProf.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICorProfilerInfo](icorprofilerinfo-interface.md)

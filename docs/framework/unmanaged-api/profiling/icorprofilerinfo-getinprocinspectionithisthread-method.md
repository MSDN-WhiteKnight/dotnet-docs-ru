---
description: 'Дополнительные сведения о методе ICorProfilerInfo:: ЖетинпроЦинспектионисиссреад'
title: Метод ICorProfilerInfo::GetInprocInspectionIThisThread
ms.date: 03/30/2017
api_name:
- ICorProfilerInfo.GetInprocInspectionIThisThread
api_location:
- mscorwks.dll
api_type:
- COM
f1_keywords:
- ICorProfilerInfo::GetInprocInspectionIThisThread
helpviewer_keywords:
- ICorProfilerInfo::GetInprocInspectionIThisThread method [.NET Framework profiling]
- GetInprocInspectionIThisThread method [.NET Framework profiling]
ms.assetid: badddccd-f85c-416e-9f0f-419eab2c9d42
topic_type:
- apiref
ms.openlocfilehash: 07ff904170750976e54e623101a2552db0c7f290
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99647249"
---
# <a name="icorprofilerinfogetinprocinspectionithisthread-method"></a>Метод ICorProfilerInfo::GetInprocInspectionIThisThread

Возвращает объект, для которого можно запросить интерфейс ICorDebugThread. Этот метод является устаревшим в платформа .NET Framework версии 2,0.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT GetInprocInspectionIThisThread(  
    [out] IUnknown **ppicd);  
```  
  
## <a name="parameters"></a>Параметры  

 `ppicd`  
 [выходной](/cpp/atl/iunknown) объект, который можно запросить для `ICorDebugThread` интерфейса.  
  
## <a name="remarks"></a>Remarks  

 Службы отладки среды CLR поддерживали ограниченную внутрипроцессную отладку в платформа .NET Framework версии 1,0. В процессе отладки с помощью профилировщика можно использовать части проверки для API отладки. В результате отзывов клиентов внутрипроцессный процесс отладки был удален из платформа .NET Framework в версии 2,0 и заменен набором функциональных возможностей, которые более подробно описаны в API профилирования.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorProf.idl, CorProf.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Версия платформа .NET Framework:** 1,0  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICorProfilerInfo](icorprofilerinfo-interface.md)

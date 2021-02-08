---
description: 'Дополнительные сведения о методе IHostTask:: SetPriority'
title: Метод IHostTask::SetPriority
ms.date: 03/30/2017
api_name:
- IHostTask.SetPriority
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- IHostTask::SetPriority
helpviewer_keywords:
- IHostTask::SetPriority method [.NET Framework hosting]
- SetPriority method [.NET Framework hosting]
ms.assetid: cd8c379b-c7a0-434f-8e23-899bd26be75d
topic_type:
- apiref
ms.openlocfilehash: c3e8fee954e5cbea2d084141a4b2d22d2fa5e95b
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99784643"
---
# <a name="ihosttasksetpriority-method"></a>Метод IHostTask::SetPriority

Запрашивает у узла настройку уровня приоритета потока для задачи, представленной текущим экземпляром [IHostTask](ihosttask-interface.md) .  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT SetPriority (  
    [in] int newPriority  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `newPriority`  
 окне Целое число, представляющее запрошенное значение приоритета потока для задачи, представленной текущим `IHostTask` экземпляром.  
  
## <a name="return-value"></a>Возвращаемое значение  
  
|HRESULT|Описание:|  
|-------------|-----------------|  
|S_OK|`SetPriority` успешно возвращено.|  
|HOST_E_CLRNOTAVAILABLE|Среда CLR не была загружена в процесс, или среда CLR находится в состоянии, в котором она не может выполнить управляемый код или успешно обработать вызов.|  
|HOST_E_TIMEOUT|Время ожидания вызова истекло.|  
|HOST_E_NOT_OWNER|Вызывающий объект не владеет блокировкой.|  
|HOST_E_ABANDONED|Событие было отменено, пока заблокированный поток или волокно ожидают его.|  
|E_FAIL|Произошла неизвестная фатальная ошибка. Когда метод возвращает E_FAIL, среда CLR больше не может использоваться в процессе. Последующие вызовы методов размещения возвращают HOST_E_CLRNOTAVAILABLE.|  
  
## <a name="remarks"></a>Remarks  

 Потокам предоставляется время обработки с помощью системы циклического перебора, частично основанной на уровне приоритета потока. `SetPriority` позволяет среде CLR устанавливать этот уровень приоритета потока для текущей задачи. `newPriority`Поддерживаются следующие значения.  
  
- THREAD_PRIORITY_ABOVE_NORMAL  
  
- THREAD_PRIORITY_BELOW_NORMAL  
  
- THREAD_PRIORITY_HIGHEST  
  
- THREAD_PRIORITY_IDLE  
  
- THREAD_PRIORITY_LOWEST  
  
- THREAD_PRIORITY_NORMAL  
  
- THREAD_PRIORITY_TIME_CRITICAL  
  
 Среда CLR вызывает, `SetPriority` когда значение изменяется <xref:System.Threading.Thread.Priority%2A?displayProperty=nameWithType> с помощью пользовательского кода. Узел может определять собственные алгоритмы для назначения приоритета потоков и может без необходимости пропускать этот запрос.  
  
> [!NOTE]
> `SetPriority` не сообщает, был ли изменен уровень приоритета потока. Вызовите метод [IHostTask:: предшествовал](ihosttask-getpriority-method.md) , чтобы определить значение уровня приоритета потока задачи.  
  
 Значения уровня приоритета потока определяются функцией Win32 `SetThreadPriority` . Дополнительные сведения о приоритете потоков см. в документации по платформе Windows.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** MSCorEE. h  
  
 **Библиотека:** Включается в качестве ресурса в MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Threading.Thread>
- [Интерфейс ICLRTask](iclrtask-interface.md)
- [Интерфейс ICLRTaskManager](iclrtaskmanager-interface.md)
- [Интерфейс IHostTask](ihosttask-interface.md)
- [Метод GetPriority](ihosttask-getpriority-method.md)
- [Интерфейс IHostTaskManager](ihosttaskmanager-interface.md)

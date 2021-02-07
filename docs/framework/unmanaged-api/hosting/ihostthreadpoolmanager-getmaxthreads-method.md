---
description: 'Дополнительные сведения о методе: IHostThreadPoolManager:: GetMaxThreads'
title: Метод IHostThreadPoolManager::GetMaxThreads
ms.date: 03/30/2017
api_name:
- IHostThreadPoolManager.GetMaxThreads
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- IHostThreadPoolManager::GetMaxThreads
helpviewer_keywords:
- IHostThreadPoolManager::GetMaxThreads method [.NET Framework hosting]
- GetMaxThreads method, IHostThreadPoolManager interface [.NET Framework hosting]
ms.assetid: db268876-6178-4a81-aca3-318ee7f96001
topic_type:
- apiref
ms.openlocfilehash: e8cae2aa29a50ef58a5b87deba9e275a441d43ef
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99728388"
---
# <a name="ihostthreadpoolmanagergetmaxthreads-method"></a>Метод IHostThreadPoolManager::GetMaxThreads

Возвращает максимальное число потоков, которые обслуживается одновременно в пуле потоков.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT GetMaxThreads (  
    [out] DWORD *pdwMaxWorkerThreads  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `pdwMaxWorkerThreads`  
 заполняет Указатель на максимальное число потоков, поддерживаемых узлом в пуле потоков.  
  
## <a name="return-value"></a>Возвращаемое значение  
  
|HRESULT|Описание:|  
|-------------|-----------------|  
|S_OK|`GetMaxThreads` успешно возвращено.|  
|HOST_E_CLRNOTAVAILABLE|Общеязыковая среда выполнения (CLR не загружена в процесс, или среда CLR находится в состоянии, в котором она не может выполнить управляемый код или успешно обработать вызов.|  
|HOST_E_TIMEOUT|Время ожидания вызова истекло.|  
|HOST_E_NOT_OWNER|Вызывающий объект не владеет блокировкой.|  
|HOST_E_ABANDONED|Событие было отменено, пока заблокированный поток или волокно ожидают его.|  
|E_FAIL|Произошла неизвестная фатальная ошибка. Когда метод возвращает E_FAIL, среда CLR больше не может использоваться в процессе. Последующие вызовы методов размещения возвращают HOST_E_CLRNOTAVAILABLE.|  
|E_NOTIMPL|Узел не предоставляет реализацию `GetMaxThreads` .|  
  
## <a name="remarks"></a>Remarks  

 Вызовы CLR `GetMaxThreads` для определения общего числа потоков в пуле потоков. Метод [GetAvailableThreads](ihostthreadpoolmanager-getavailablethreads-method.md) возвращает число потоков, которые в данный момент не обрабатывают рабочие элементы. Все запросы выше возвращенного значения `pdwMaxWorkerThreads` параметра остаются в очереди до тех пор, пока потоки не станут доступными.  
  
 Если узел не предоставляет реализацию `GetMaxThreads` , он должен возвращать значение HRESULT, равное E_NOTIMPL.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** MSCorEE. h  
  
 **Библиотека:** Включается в качестве ресурса в MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Threading.ThreadPool.GetMaxThreads%2A>
- <xref:System.Threading.ThreadPool>
- [Метод GetMinThreads](ihostthreadpoolmanager-getminthreads-method.md)
- [Метод SetMaxThreads](ihostthreadpoolmanager-setmaxthreads-method.md)
- [Интерфейс IHostThreadPoolManager](ihostthreadpoolmanager-interface.md)

---
description: 'Дополнительные сведения о методе: метод ihostsyncmanager:: Createsemaphore-'
title: Метод IHostSyncManager::CreateSemaphore
ms.date: 03/30/2017
api_name:
- IHostSyncManager.CreateSemaphore
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- IHostSyncManager::CreateSemaphore
helpviewer_keywords:
- CreateSemaphore method [.NET Framework hosting]
- IHostSyncManager::CreateSemaphore method [.NET Framework hosting]
ms.assetid: 37679e94-5ff9-4173-8fa5-457febeb89bf
topic_type:
- apiref
ms.openlocfilehash: 5a03ef7532e2ac8357ec015b40cc54942f5420e5
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99784747"
---
# <a name="ihostsyncmanagercreatesemaphore-method"></a>Метод IHostSyncManager::CreateSemaphore

Создает объект [IHostSemaphore](ihostsemaphore-interface.md) для общеязыковой среды выполнения (CLR) для использования в качестве семафора для событий ожидания.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT CreateSemaphore (  
    [in]  DWORD dwInitial,  
    [in]  DWORD dwMax,  
    [out] IHostSemaphore **ppSemaphore  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `dwInitial`  
 окне Начальное число для `ppSemaphore` .  
  
 `dwMax`  
 окне Максимальное число для `ppSemaphore` .  
  
 `ppSemaphore`  
 заполняет Указатель на адрес `IHostSemaphore` экземпляра или значение null, если не удалось создать семафор.  
  
## <a name="return-value"></a>Возвращаемое значение  
  
|HRESULT|Описание:|  
|-------------|-----------------|  
|S_OK|`CreateSemaphore` успешно возвращено.|  
|HOST_E_CLRNOTAVAILABLE|Среда CLR не была загружена в процесс, или среда CLR находится в состоянии, в котором она не может выполнить управляемый код или успешно обработать вызов.|  
|HOST_E_TIMEOUT|Время ожидания вызова истекло.|  
|HOST_E_NOT_OWNER|Вызывающий объект не владеет блокировкой.|  
|HOST_E_ABANDONED|Событие было отменено, пока заблокированный поток или волокно ожидают его.|  
|E_FAIL|Произошла неизвестная фатальная ошибка. Когда метод возвращает E_FAIL, среда CLR больше не может использоваться в процессе. Последующие вызовы методов размещения возвращают HOST_E_CLRNOTAVAILABLE.|  
|E_OUTOFMEMORY|Недостаточно свободной памяти для создания запрошенного объекта события.|  
  
## <a name="remarks"></a>Remarks  

 `CreateSemaphore` отражает функцию Win32 с тем же именем. `dwInitial`Параметры и `dwMax` используют ту же семантику для счетчика семафора `lInitialCount` , что и Win32 и `lMaximumCount` параметры соответственно. `dwInitial` значение должно находиться в диапазоне от 0 до `dwMax` включительно. `dwMax` должно быть больше нуля.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** MSCorEE. h  
  
 **Библиотека:** Включается в качестве ресурса в MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICLRSyncManager](iclrsyncmanager-interface.md)
- [Интерфейс IHostSemaphore](ihostsemaphore-interface.md)
- [Интерфейс IHostSyncManager](ihostsyncmanager-interface.md)

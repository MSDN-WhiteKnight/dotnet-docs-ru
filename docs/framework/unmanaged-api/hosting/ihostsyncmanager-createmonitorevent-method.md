---
description: 'Дополнительные сведения о методе: метод ihostsyncmanager:: CreateMonitorEvent'
title: Метод IHostSyncManager::CreateMonitorEvent
ms.date: 03/30/2017
api_name:
- IHostSyncManager.CreateMonitorEvent
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- IHostSyncManager::CreateMonitorEvent
helpviewer_keywords:
- CreateMonitorEvent method [.NET Framework hosting]
- IHostSyncManager::CreateMonitorEvent method [.NET Framework hosting]
ms.assetid: 524c7fd3-9b5c-46e7-99ba-555fd2fe33f0
topic_type:
- apiref
ms.openlocfilehash: b48d0417e614cf04c3ab150f0bdda73408b7a273
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99784786"
---
# <a name="ihostsyncmanagercreatemonitorevent-method"></a>Метод IHostSyncManager::CreateMonitorEvent

Создает Отслеживаемый объект события автоматического сброса.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT CreateMonitorEvent (  
    [in]  SIZE_T cookie,  
    [out] IHostAutoEvent **ppEvent  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `cookie`  
 окне Файл cookie, связываемый с объектом события.  
  
 `ppEvent`  
 заполняет Указатель на адрес экземпляра [ихостаутоевент](ihostautoevent-interface.md) или значение null, если не удалось создать объект события.  
  
## <a name="return-value"></a>Возвращаемое значение  
  
|HRESULT|Описание:|  
|-------------|-----------------|  
|S_OK|`CreateMonitorEvent` успешно возвращено.|  
|HOST_E_CLRNOTAVAILABLE|Среда CLR не была загружена в процесс, или среда CLR находится в состоянии, в котором она не может выполнить управляемый код или успешно обработать вызов.|  
|HOST_E_TIMEOUT|Время ожидания вызова истекло.|  
|HOST_E_NOT_OWNER|Вызывающий объект не владеет блокировкой.|  
|HOST_E_ABANDONED|Событие было отменено, пока заблокированный поток или волокно ожидают его.|  
|E_FAIL|Произошла неизвестная фатальная ошибка. Когда метод возвращает E_FAIL, среда CLR больше не может использоваться в процессе. Последующие вызовы методов размещения возвращают HOST_E_CLRNOTAVAILABLE.|  
|E_OUTOFMEMORY|Недостаточно свободной памяти для создания запрошенного объекта события.|  
  
## <a name="remarks"></a>Remarks  

 `CreateMonitorEvent` Возвращает объект `IHostAutoEvent` , используемый средой CLR в реализации управляемого <xref:System.Threading.Monitor?displayProperty=nameWithType> типа. Этот метод отражает функцию Win32 `CreateEvent` со значением, `false` указанным для `bManualReset` параметра.  
  
 Узел может использовать файл cookie, чтобы определить, какая задача ожидает монитор, вызвав метод [ICLRSyncManager:: GetMonitorOwner](iclrsyncmanager-getmonitorowner-method.md) .  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** MSCorEE. h  
  
 **Библиотека:** Включается в качестве ресурса в MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICLRSyncManager](iclrsyncmanager-interface.md)
- [Интерфейс IHostAutoEvent](ihostautoevent-interface.md)
- [Интерфейс IHostSyncManager](ihostsyncmanager-interface.md)
- <xref:System.Threading.Monitor>

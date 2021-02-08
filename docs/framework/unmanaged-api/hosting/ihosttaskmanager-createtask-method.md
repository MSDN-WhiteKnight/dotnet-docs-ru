---
description: 'Дополнительные сведения о методе: IHostTaskManager:: CreateTask'
title: Метод IHostTaskManager::CreateTask
ms.date: 03/30/2017
api_name:
- IHostTaskManager.CreateTask
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- IHostTaskManager::CreateTask
helpviewer_keywords:
- CreateTask method, IHostTaskManager interface [.NET Framework hosting]
- IHostTaskManager::CreateTask method [.NET Framework hosting]
ms.assetid: a6f8ad36-61e1-42b0-9db2-add575646d18
topic_type:
- apiref
ms.openlocfilehash: c14c80ea9067b0a28e7b9186ea66eb695687bf27
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99784578"
---
# <a name="ihosttaskmanagercreatetask-method"></a>Метод IHostTaskManager::CreateTask

Запрашивает создание новой задачи узлом.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT CreateTask (  
    [in]  DWORD stacksize,
    [in]  LPTHREAD_START_ROUTINE pStartAddress,  
    [in]  PVOID pParameter,  
    [out] IHostTask **ppTask  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `stacksize`  
 окне Запрошенный размер (в байтах) запрошенного стека или 0 (ноль) для размера по умолчанию.  
  
 `pStartAddress`  
 окне Указатель на функцию, которая должна быть выполнена задачей.  
  
 `pParameter`  
 окне Указатель на пользовательские данные, передаваемые в функцию, или значение null, если функция не принимает параметры.  
  
 `ppTask`  
 заполняет Указатель на адрес экземпляра [IHostTask](ihosttask-interface.md) , созданного узлом, или значение null, если задача не может быть создана. Задача остается в приостановленном состоянии до тех пор, пока она не будет явно запущена вызовом [IHostTask:: Start](ihosttask-start-method.md).  
  
## <a name="return-value"></a>Возвращаемое значение  
  
|HRESULT|Описание:|  
|-------------|-----------------|  
|S_OK|`CreateTask` успешно возвращено.|  
|HOST_E_CLRNOTAVAILABLE|Среда CLR не была загружена в процесс, или среда CLR находится в состоянии, в котором она не может выполнить управляемый код или успешно обработать вызов.|  
|HOST_E_TIMEOUT|Время ожидания вызова истекло.|  
|HOST_E_NOT_OWNER|Вызывающий объект не владеет блокировкой.|  
|HOST_E_ABANDONED|Событие было отменено, пока заблокированный поток или волокно ожидают его.|  
|E_FAIL|Произошла неизвестная фатальная ошибка. Когда метод возвращает E_FAIL, среда CLR больше не может использоваться в процессе. Последующие вызовы методов размещения возвращают HOST_E_CLRNOTAVAILABLE.|  
|E_OUTOFMEMORY|Недостаточно свободной памяти для создания запрошенной задачи.|  
  
## <a name="remarks"></a>Remarks  

 Вызовы CLR `CreateTask` для запроса создания новой задачи узлом. Узел возвращает указатель интерфейса на `IHostTask` экземпляр. Возвращаемая задача должна оставаться приостановленной до тех пор, пока она не будет явно запущена вызовом метода `IHostTask::Start` .  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** MSCorEE. h  
  
 **Библиотека:** Включается в качестве ресурса в MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICLRTask](iclrtask-interface.md)
- [Интерфейс ICLRTaskManager](iclrtaskmanager-interface.md)
- [Интерфейс IHostTask](ihosttask-interface.md)
- [Интерфейс IHostTaskManager](ihosttaskmanager-interface.md)

---
description: 'Дополнительные сведения о: интерфейс ICLRTaskManager'
title: Интерфейс ICLRTaskManager
ms.date: 03/30/2017
api_name:
- ICLRTaskManager
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- ICLRTaskManager
helpviewer_keywords:
- ICLRTaskManager interface [.NET Framework hosting]
ms.assetid: 2bd55e0c-001b-41fd-b29d-f01670fe8216
topic_type:
- apiref
ms.openlocfilehash: 0ce3641042725bc2f3acb95933ccd7a5bbe3bc4d
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99789753"
---
# <a name="iclrtaskmanager-interface"></a>Интерфейс ICLRTaskManager

Предоставляет методы, позволяющие узлу явно запрашивать, что среда CLR создает новую задачу, получает выполняемую в данный момент задачу и задает язык и региональные параметры для задачи.  
  
## <a name="methods"></a>Методы  
  
|Метод|Описание|  
|------------|-----------------|  
|[Метод CreateTask](iclrtaskmanager-createtask-method.md)|Явно запрашивает, что среда CLR создает новый экземпляр [ICLRTask](iclrtask-interface.md) .|  
|[Метод GetCurrentTask](iclrtaskmanager-getcurrenttask-method.md)|Возвращает `ICLRTask` экземпляр, представляющий выполняемую в данный момент задачу.|  
|[Метод GetCurrentTaskType](iclrtaskmanager-getcurrenttasktype-method.md)|Возвращает тип выполняемой в данный момент задачи.|  
|[Метод SetLocale](iclrtaskmanager-setlocale-method.md)|Уведомляет среду CLR о том, что узел изменил идентификатор локали в выполняющейся задаче.|  
|[Метод SetUILocale](iclrtaskmanager-setuilocale-method.md)|Уведомляет среду CLR о том, что узел изменил идентификатор локали пользовательского интерфейса для выполняемой в данный момент задачи.|  
  
## <a name="remarks"></a>Remarks  

 Каждая задача, выполняемая в среде размещения, имеет представления на стороне размещения (экземпляр [IHostTask](ihosttask-interface.md)) и на стороне среды CLR (экземпляре [ICLRTask](iclrtask-interface.md)). Приложение или среда CLR могут инициировать создание задачи, но представление на стороне главного приложения должно быть связано с соответствующим представлением на стороне среды CLR для обеспечения успешной связи между узлом и средой CLR, относящейся к задаче. Перед выполнением управляемого кода в потоке операционной системы необходимо создать и создать экземпляры этих двух объектов.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** MSCorEE. h  
  
 **Библиотека:** Включается в качестве ресурса в MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICLRTask](iclrtask-interface.md)
- [Интерфейс IHostTask](ihosttask-interface.md)
- [Интерфейс IHostTaskManager](ihosttaskmanager-interface.md)
- [Интерфейсы размещения](hosting-interfaces.md)

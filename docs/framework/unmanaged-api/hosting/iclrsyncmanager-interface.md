---
description: 'Дополнительные сведения о: интерфейс ICLRSyncManager'
title: Интерфейс ICLRSyncManager
ms.date: 03/30/2017
api_name:
- ICLRSyncManager
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- ICLRSyncManager
helpviewer_keywords:
- ICLRSyncManager interface [.NET Framework hosting]
ms.assetid: a49f9d80-1c76-4ddd-8c49-34f913a5c596
topic_type:
- apiref
ms.openlocfilehash: 188d1c913d75666aea09b17244012401d377fa10
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99785020"
---
# <a name="iclrsyncmanager-interface"></a>Интерфейс ICLRSyncManager

Определяет методы, позволяющие узлу получать сведения о запрошенных задачах и обнаруживать взаимоблокировки в своей реализации синхронизации.  
  
## <a name="methods"></a>Методы  
  
|Метод|Описание|  
|------------|-----------------|  
|[Метод CreateRWLockOwnerIterator](iclrsyncmanager-createrwlockowneriterator-method.md)|Запрашивает, что среда CLR создает итератор для узла, который будет использоваться для определения набора задач, ожидающих блокировки чтения и записи.|  
|[Метод DeleteRWLockOwnerIterator](iclrsyncmanager-deleterwlockowneriterator-method.md)|Запрашивает удаление итератора, который был создан при вызове среды CLR `CreateRWLockOwnerIterator` .|  
|[Метод GetMonitorOwner](iclrsyncmanager-getmonitorowner-method.md)|Возвращает задачу, которая владеет указанным монитором.|  
|[Метод GetRWLockOwnerNext](iclrsyncmanager-getrwlockownernext-method.md)|Возвращает следующую задачу, ожидающую текущую блокировку модуля чтения-записи.|  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** MSCorEE. h  
  
 **Библиотека:** Включается в качестве ресурса в MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Threading.Thread>
- [Интерфейс IHostSyncManager](ihostsyncmanager-interface.md)
- [Управляемые и неуправляемые потоки](/previous-versions/dotnet/netframework-4.0/5s8ee185(v=vs.100))
- [Интерфейсы размещения](hosting-interfaces.md)

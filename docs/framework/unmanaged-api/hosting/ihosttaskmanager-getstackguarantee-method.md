---
description: 'Дополнительные сведения о методе: IHostTaskManager:: Жетстаккгуаранти'
title: Метод IHostTaskManager::GetStackGuarantee
ms.date: 03/30/2017
api_name:
- IHostTaskManager.GetStackGuarantee
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- IHostTaskManager::GetStackGuarantee
helpviewer_keywords:
- GetStackGuarantee method [.NET Framework hosting]
- IHostTaskManager::GetStackGuarantee method [.NET Framework hosting]
ms.assetid: 8176d732-c25c-4520-811d-e3310f339947
topic_type:
- apiref
ms.openlocfilehash: 6c8bd9839ea0c1fdb72fbbd296061d1a2b6edfe1
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99753800"
---
# <a name="ihosttaskmanagergetstackguarantee-method"></a>Метод IHostTaskManager::GetStackGuarantee

Возвращает объем стекового пространства, который гарантированно будет доступен после завершения операции с стеком, но до закрытия процесса.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT GetStackGuarantee(  
    [out] ULONG *pGuarantee  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `pGuarantee`  
 заполняет Указатель на количество доступных байтов.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** MSCorEE. h  
  
 **Библиотека:** Включается в качестве ресурса в MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс IHostTaskManager](ihosttaskmanager-interface.md)

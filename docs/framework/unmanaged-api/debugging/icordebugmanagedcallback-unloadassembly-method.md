---
description: 'Дополнительные сведения о методе: ICorDebugManagedCallback:: UnloadAssembly'
title: Метод ICorDebugManagedCallback::UnloadAssembly
ms.date: 03/30/2017
api_name:
- ICorDebugManagedCallback.UnloadAssembly
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICorDebugManagedCallback::UnloadAssembly
helpviewer_keywords:
- ICorDebugManagedCallback::UnloadAssembly method [.NET Framework debugging]
- UnloadAssembly method [.NET Framework debugging]
ms.assetid: 6734321c-c8a9-401f-a558-cad715ec4a77
topic_type:
- apiref
ms.openlocfilehash: b1860e90ba2bab1428a0f8559d18801136bbbb39
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99660340"
---
# <a name="icordebugmanagedcallbackunloadassembly-method"></a>Метод ICorDebugManagedCallback::UnloadAssembly

Уведомляет отладчик о том, что сборка среды CLR была выгружена.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT UnloadAssembly (  
    [in] IcorDebugAppDomain  *pAppDomain,  
    [in] ICorDebugAssembly   *pAssembly  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `pAppDomain`  
 окне Указатель на объект ICorDebugAppDomain, представляющий домен приложения, содержащий сборку.  
  
 `pAssembly`  
 окне Указатель на объект ICorDebugAssembly, представляющий сборку.  
  
## <a name="remarks"></a>Remarks  

 Сборка не должна использоваться после этого обратного вызова.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v10plus](../../../../includes/net-current-v10plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Метод LoadAssembly](icordebugmanagedcallback-loadassembly-method.md)
- [Интерфейс ICorDebugManagedCallback](icordebugmanagedcallback-interface.md)

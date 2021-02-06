---
description: 'Дополнительные сведения о методе: ICorDebugThread2:: Жетконнектионид'
title: Метод ICorDebugThread2::GetConnectionID
ms.date: 03/30/2017
api_name:
- ICorDebugThread2.GetConnectionID
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICorDebugThread2::GetConnectionID
helpviewer_keywords:
- ICorDebugThread2::GetConnectionID method [.NET Framework debugging]
- GetConnectionID method [.NET Framework debugging]
ms.assetid: 9c76b587-f941-4fa1-8b86-f3494fb10c8e
topic_type:
- apiref
ms.openlocfilehash: 0f8035e703d3638b11f4206d9c47e39fe487d71d
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99658741"
---
# <a name="icordebugthread2getconnectionid-method"></a>Метод ICorDebugThread2::GetConnectionID

Возвращает идентификатор соединения для этого объекта ICorDebugThread2.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT GetConnectionID (  
    [out] CONNID *pdwConnectionId  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `pdwConnectionId`  
 заполняет Значение типа `CONNID` , представляющее идентификатор соединения.  
  
## <a name="remarks"></a>Remarks  

 `GetConnectionID`Метод возвращает ноль в `pdwConnectionId` параметре, если этот поток не является частью соединения.  
  
 Если этот поток подключен к экземпляру Microsoft SQL Server 2005 Analysis Services (SSAS), то `CONNID` сопоставляется с идентификатором серверного процесса (SPID).  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]

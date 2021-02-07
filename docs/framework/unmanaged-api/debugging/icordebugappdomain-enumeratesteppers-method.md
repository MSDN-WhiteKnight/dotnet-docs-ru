---
description: 'Дополнительные сведения о методе: ICorDebugAppDomain:: Енумератестепперс'
title: Метод ICorDebugAppDomain::EnumerateSteppers
ms.date: 03/30/2017
api_name:
- ICorDebugAppDomain.EnumerateSteppers
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICorDebugAppDomain::EnumerateSteppers
helpviewer_keywords:
- ICorDebugAppDomain::EnumerateSteppers method [.NET Framework debugging]
- EnumerateSteppers method [.NET Framework debugging]
ms.assetid: 3f3c4503-570e-44c1-ae6a-a3c6b840c732
topic_type:
- apiref
ms.openlocfilehash: a9c7f8b1486522b4740ec18c575c9876512b7d8c
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99754255"
---
# <a name="icordebugappdomainenumeratesteppers-method"></a>Метод ICorDebugAppDomain::EnumerateSteppers

Возвращает перечислитель для всех активных шагов в домене приложения.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT EnumerateSteppers (  
    [out] ICorDebugStepperEnum   **ppSteppers  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `ppSteppers`  
 заполняет Указатель на адрес объекта Икордебугстепперенум, который является перечислителем для всех активных шагов в домене приложения.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v10plus](../../../../includes/net-current-v10plus-md.md)]

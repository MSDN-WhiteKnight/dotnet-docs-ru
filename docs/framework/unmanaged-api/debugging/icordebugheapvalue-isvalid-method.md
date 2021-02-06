---
description: 'Дополнительные сведения о методе: ICorDebugHeapValue:: IsValid'
title: Метод ICorDebugHeapValue::IsValid
ms.date: 03/30/2017
api_name:
- ICorDebugHeapValue.IsValid
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICorDebugHeapValue::IsValid
helpviewer_keywords:
- IsValid method [.NET Framework debugging]
- ICorDebugHeapValue::IsValid method [.NET Framework debugging]
ms.assetid: 68e20e62-203d-46d8-bb91-8d3c61cfacc3
topic_type:
- apiref
ms.openlocfilehash: 27eca844170b31934cd32dad5cf5fccc0b0e324e
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99660795"
---
# <a name="icordebugheapvalueisvalid-method"></a>Метод ICorDebugHeapValue::IsValid

Возвращает значение, указывающее, является ли допустимым объект, представленный этим ICorDebugHeapValue.  
  
 Этот метод не рекомендуется к использованию в платформа .NET Framework версии 2,0.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT IsValid (  
    [out] BOOL    *pbValid  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `pbValid`  
 заполняет Указатель на логическое значение, указывающее, является ли значение в куче допустимым.  
  
## <a name="remarks"></a>Remarks  

 Значение недопустимо, если оно было освобождено сборщиком мусора.  
  
 Этот метод использовать не рекомендуется. В платформа .NET Framework 2,0 все значения являются допустимыми до тех пор, пока не будет вызван метод [ICorDebugController:: Continue](icordebugcontroller-continue-method.md) , после чего значения становятся недействительными.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v10plus](../../../../includes/net-current-v10plus-md.md)]

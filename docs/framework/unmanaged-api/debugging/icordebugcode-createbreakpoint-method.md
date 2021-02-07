---
description: 'Дополнительные сведения: метод ICorDebugCode:: CreateBreakpoint'
title: Метод ICorDebugCode::CreateBreakpoint
ms.date: 03/30/2017
api_name:
- ICorDebugCode.CreateBreakpoint
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICorDebugCode::CreateBreakpoint
helpviewer_keywords:
- ICorDebugCode::CreateBreakpoint method [.NET Framework debugging]
- CreateBreakpoint method, ICorDebugCode interface [.NET Framework debugging]
ms.assetid: 46842618-0fe4-480b-871c-82fba82d23d9
topic_type:
- apiref
ms.openlocfilehash: a9285d59da3e3f34ea303413fca67bc39aff9e32
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99711379"
---
# <a name="icordebugcodecreatebreakpoint-method"></a>Метод ICorDebugCode::CreateBreakpoint

Создает точку останова в этом сегменте кода в указанном смещении.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT CreateBreakpoint (  
    [in] ULONG32     offset,  
    [out] ICorDebugFunctionBreakpoint **ppBreakpoint  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `offset`  
 окне Смещение для создания точки останова.  
  
 `ppBreakpoint`  
 заполняет Указатель на адрес объекта "ICorDebugFunctionBreakpoint", представляющего точку останова.  
  
## <a name="remarks"></a>Remarks  

 Прежде чем точка останова станет активной, ее необходимо добавить в объект Process.  
  
 Если этот код является кодом на языке MSIL и имеется JIT-скомпилированная собственная версия кода, то точка останова будет применена и в JIT-скомпилированном коде. (То же самое верно, если код компилируется позже.)  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v10plus](../../../../includes/net-current-v10plus-md.md)]

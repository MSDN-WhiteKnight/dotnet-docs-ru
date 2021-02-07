---
description: 'Дополнительные сведения: метод ICorDebugCode:: GetILToNativeMapping'
title: Метод ICorDebugCode::GetILToNativeMapping
ms.date: 03/30/2017
api_name:
- ICorDebugCode.GetILToNativeMapping
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICorDebugCode::GetILToNativeMapping
helpviewer_keywords:
- GetILToNativeMapping method, ICorDebugCode interface [.NET Framework debugging]
- ICorDebugCode::GetILToNativeMapping method [.NET Framework debugging]
ms.assetid: a8ecd8c8-9627-4356-9c6f-bd05e24637c0
topic_type:
- apiref
ms.openlocfilehash: 808ed450fced8afecc2b637a3b990a894897b350
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99711197"
---
# <a name="icordebugcodegetiltonativemapping-method"></a>Метод ICorDebugCode::GetILToNativeMapping

Возвращает массив экземпляров "COR_DEBUG_IL_TO_NATIVE_MAP", которые представляют сопоставления из смещений MSIL к собственным смещениям.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT GetILToNativeMapping (  
    [in]  ULONG32    cMap,  
    [out] ULONG32    *pcMap,  
    [out, size_is(cMap), length_is(*pcMap)]  
        COR_DEBUG_IL_TO_NATIVE_MAP map[]  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `cMap`  
 [in] Размер массива `map`.  
  
 `pcMap`  
 заполняет Указатель на фактическое число элементов, возвращаемых в `map` массиве.  
  
 `map`  
 заполняет Массив `COR_DEBUG_IL_TO_NATIVE_MAP` структур, каждый из которых представляет сопоставление смещения MSIL со смещением в машинном коде.  
  
 Порядок для массива возвращаемых элементов отсутствует.  
  
## <a name="remarks"></a>Remarks  

 `GetILToNativeMapping`Метод возвращает значимые результаты только в том случае, если этот экземпляр "ICorDebugCode" представляет машинный код, который был скомпилирован из кода MSIL в JIT-режиме.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v10plus](../../../../includes/net-current-v10plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICorDebugCode](icordebugcode-interface1.md)

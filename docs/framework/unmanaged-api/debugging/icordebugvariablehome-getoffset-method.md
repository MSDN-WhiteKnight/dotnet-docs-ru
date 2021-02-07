---
description: 'Дополнительные сведения о методе: ICorDebugVariableHome:: методом offset'
title: 'Метод ICorDebugVariableHome:: методом offset'
ms.date: 03/30/2017
api_name:
- ICorDebugVariableHome.GetOffset
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICorDebugVariableHome::GetOffset
helpviewer_keywords:
- ICorDebugVariableHome::GetOffset method [.NET Framework debugging]
- GetOffset method, ICorDebugVariableHome interface [.NET Framework debugging]
ms.assetid: f025c2e5-3f6c-4be8-9ffe-c8b214617dfe
topic_type:
- apiref
ms.openlocfilehash: 48b57856d2825dd2ea9328064a28783b4b36029b
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99728773"
---
# <a name="icordebugvariablehomegetoffset-method"></a>Метод ICorDebugVariableHome:: методом offset

Возвращает смещение от базового регистра для переменной.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT GetOffset(  
    [out] LONG *pOffset  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `pOffset`  
 заполняет Смещение от базового регистра.  
  
## <a name="return-value"></a>Возвращаемое значение  

 Метод возвращает следующие значения:  
  
|Значение|Описание|  
|-----------|-----------------|  
|`S_OK`|Переменная находится в расположении в памяти относительно регистра.|  
|`E_FAIL`|Переменная не находится в расположении в памяти относительно регистра.|  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v462plus](../../../../includes/net-current-v462plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICorDebugVariableHome](icordebugvariablehome-interface.md)

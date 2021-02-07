---
description: 'Дополнительные сведения о методе: ICorDebugModule:: EnableJITDebugging'
title: Метод ICorDebugModule::EnableJITDebugging
ms.date: 03/30/2017
api_name:
- ICorDebugModule.EnableJITDebugging
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICorDebugModule::EnableJITDebugging
helpviewer_keywords:
- ICorDebugModule::EnableJITDebugging method [.NET Framework debugging]
- EnableJITDebugging method [.NET Framework debugging]
ms.assetid: 0a65e2a4-5bb6-496c-ae6f-40474426b5a6
topic_type:
- apiref
ms.openlocfilehash: 30077bd586e1cb9cb8766290804e31f5999d9e72
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99722689"
---
# <a name="icordebugmoduleenablejitdebugging-method"></a>Метод ICorDebugModule::EnableJITDebugging

Определяет, сохраняет ли JIT-компилятор сведения об отладке для методов в этом модуле.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT EnableJITDebugging(  
    [in] BOOL bTrackJITInfo,  
    [in] BOOL bAllowJitOpts  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `bTrackJITInfo`  
 окне Установите это значение, чтобы `true` разрешить JIT-компилятору сохранять сведения о сопоставлении между версией MSIL и версией каждого метода в этом модуле, скомпилированном по требованию.  
  
 `bAllowJitOpts`  
 окне Установите это значение, чтобы `true` разрешить JIT-компилятору создавать код с определенными оптимизацией JIT для отладки.  
  
## <a name="remarks"></a>Remarks  

 JIT-отладка включается по умолчанию для всех модулей, загружаемых при активном отладчике. Программное включение или отключение параметров переопределяет глобальные параметры.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]

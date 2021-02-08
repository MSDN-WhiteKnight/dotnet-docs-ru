---
description: 'Дополнительные сведения о методе: ICorDebugILFrame2:: RemapFunction'
title: Метод ICorDebugILFrame2::RemapFunction
ms.date: 03/30/2017
api_name:
- ICorDebugILFrame2.RemapFunction
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICorDebugILFrame2::RemapFunction
helpviewer_keywords:
- ICorDebugILFrame2::RemapFunction method [.NET Framework debugging]
- RemapFunction method [.NET Framework debugging]
ms.assetid: dd639ba0-f77b-426d-9ff6-f92706840348
topic_type:
- apiref
ms.openlocfilehash: d8a6c7f966488e7b74a9661e3a18b5248df7400b
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99791298"
---
# <a name="icordebugilframe2remapfunction-method"></a>Метод ICorDebugILFrame2::RemapFunction

Повторно сопоставляет отредактированную функцию, указывая новое смещение MSIL  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT RemapFunction (  
    [in] ULONG32      newILOffset  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `newILOffset`  
 окне Новое смещение MSIL кадра стека, в которое следует поместить указатель инструкции. Это значение должно быть точкой последовательности.  
  
 Для обеспечения допустимости этого значения отвечает вызывающий объект. Например, смещение MSIL недопустимо, если оно находится вне границ функции.  
  
## <a name="remarks"></a>Remarks  

 Когда функция фрейма была изменена, отладчик может вызвать `RemapFunction` метод для замены последней версии функции кадра, чтобы ее можно было выполнить. Выполнение кода начнется с заданного смещения MSIL.  
  
> [!NOTE]
> Вызов метода `RemapFunction` , как и вызов [ICorDebugILFrame:: SetIP](icordebugilframe-setip-method.md), немедленно сделает недействительными все интерфейсы отладки, связанные с формированием трассировки стека для потока. К этим интерфейсам относятся [ICorDebugChain](icordebugchain-interface.md), ICorDebugILFrame, ICorDebugInternalFrame и ICorDebugNativeFrame.  
  
 `RemapFunction`Метод может быть вызван только в контексте текущего кадра и только в одном из следующих случаев:  
  
- После получения обратного вызова [ICorDebugManagedCallback2:: FunctionRemapOpportunity](icordebugmanagedcallback2-functionremapopportunity-method.md) , который еще не был продолжен.  
  
- Пока выполнение кода остановлено из-за события [ICorDebugManagedCallback:: EditAndContinueRemap](icordebugmanagedcallback-editandcontinueremap-method.md) для этого кадра.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]

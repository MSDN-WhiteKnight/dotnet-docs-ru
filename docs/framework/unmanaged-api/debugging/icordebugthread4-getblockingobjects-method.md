---
description: 'Дополнительные сведения о методе: ICorDebugThread4:: Жетблоккингобжектс'
title: Метод ICorDebugThread4::GetBlockingObjects
ms.date: 03/30/2017
api_name:
- ICorDebugThread4.GetBlockingObjects Method
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICorDebugThread4::GetBlockingObjects
helpviewer_keywords:
- GetBlockingObjects method [.NET Framework debugging]
- ICorDebugThread4::GetBlockingObjects method [.NET Framework debugging]
ms.assetid: a7e6c54e-7be9-4e52-bbb4-95f52458e8e4
topic_type:
- apiref
ms.openlocfilehash: 6a60ebe6f5f6dac93dcb11dad7658aba9c934329
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99800959"
---
# <a name="icordebugthread4getblockingobjects-method"></a>Метод ICorDebugThread4::GetBlockingObjects

Предоставляет упорядоченное перечисление структур [CorDebugBlockingObject](cordebugblockingobject-structure.md) , которые предоставляют сведения о блокировке потока.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT GetBlockingObjects (  
    [out] ICorDebugBlockingObjectEnum **ppBlockingObjectEnum  
```  
  
## <a name="parameters"></a>Параметры  

 `ppBlockingObjectEnum`  
 заполняет Указатель на упорядоченное перечисление структур [CorDebugBlockingObject](cordebugblockingobject-structure.md) .  
  
## <a name="remarks"></a>Remarks  

 Первый элемент в возвращенном перечислении соответствует первой структуре, блокирующей поток. Второй элемент соответствует блокирующему элементу, который обнаруживается при выполнении асинхронного вызова процедуры (APC) при блокировке в первом и т. д.  
  
 Перечисление допустимо только в течение текущего синхронизированного состояния.  
  
 Этот метод должен вызываться, когда отлаживаемый объект находится в синхронизированном состоянии.  
  
 Если не `ppBlockingObjectEnum` является допустимым указателем, результат не определен.  
  
 Если поток заблокирован и ошибка не может быть определена, метод возвращает значение HRESULT, указывающее на ошибку; в противном случае возвращается S_OK.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v40plus](../../../../includes/net-current-v40plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICorDebugThread4](icordebugthread4-interface.md)
- [Интерфейсы отладки](debugging-interfaces.md)
- [Отладка](index.md)

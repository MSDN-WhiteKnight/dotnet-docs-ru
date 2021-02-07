---
description: 'Дополнительные сведения о методе: ICorDebugProcess3:: SetEnableCustomNotification'
title: Метод ICorDebugProcess3::SetEnableCustomNotification
ms.date: 03/30/2017
api_name:
- ICorDebugProcess3.SetEnableCustomNotification Method
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICorDebugProcess3::SetEnableCustomNotification
helpviewer_keywords:
- ICorDebugProcess3::SetEnableCustomNotification method [.NET Framework debugging]
- SetEnableCustomNotification method [.NET Framework debugging]
ms.assetid: afd88ee9-2589-4461-a75a-9b6fe55a2525
topic_type:
- apiref
ms.openlocfilehash: 71d1d23b1fa4ba16b26b7c9bacf7fb5cec5e5074
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99746479"
---
# <a name="icordebugprocess3setenablecustomnotification-method"></a>Метод ICorDebugProcess3::SetEnableCustomNotification

Включает и отключает настраиваемые уведомления отладчика указанного типа.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT SetEnableCustomNotification(ICorDebugClass * pClass,  
                                    BOOL fEnable);  
```  
  
## <a name="parameters"></a>Параметры  

 `pClass`  
 окне Тип, указывающий пользовательские уведомления отладчика.  
  
 `fEnable`  
 [входные] `true` для включения настраиваемых уведомлений отладчика; `false` для отключения уведомлений. Значение по умолчанию — `false`.  
  
## <a name="remarks"></a>Примечания  

 Если параметр `fEnable` имеет значение `true` , вызовы <xref:System.Diagnostics.Debugger.NotifyOfCrossThreadDependency%2A?displayProperty=nameWithType> метода активируют обратный вызов [ICorDebugManagedCallback3:: CustomNotification](icordebugmanagedcallback3-customnotification-method.md) . По умолчанию уведомления отключены. Поэтому в отладчике должны быть указаны все типы уведомлений, о которых он знает, и требуется его обработку. Так как класс [ICorDebugClass](icordebug-interface.md) ограничивается доменом приложения, отладчик должен вызвать `SetEnableCustomNotification` для каждого домена приложения в процессе, если он хочет получить уведомление во всем процессе.  
  
 Начиная с платформа .NET Framework 4, единственным поддерживаемым уведомлением является уведомление о зависимости между потоками.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v40plus](../../../../includes/net-current-v40plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICorDebugProcess3](icordebugprocess3-interface.md)
- [Интерфейсы отладки](debugging-interfaces.md)
- [Отладка](index.md)

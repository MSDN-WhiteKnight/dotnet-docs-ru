---
description: Дополнительные сведения о перечислении Логгинглевеленум
title: Перечисление LoggingLevelEnum
ms.date: 03/30/2017
api_name:
- LoggingLevelEnum
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- LoggingLevelEnum
helpviewer_keywords:
- LoggingLevelEnum enumeration [.NET Framework debugging]
ms.assetid: 09daac08-005a-46b2-beab-408d0820c5e5
topic_type:
- apiref
ms.openlocfilehash: 7c9676fef83ea44f45a25350a2b3d325c1c22f98
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99800619"
---
# <a name="logginglevelenum-enumeration"></a>Перечисление LoggingLevelEnum

Указывает уровень важности описательного сообщения, записанного в журнале событий при регистрации события управляемым потоком.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
typedef enum LoggingLevelEnum {  
    LTraceLevel0 = 0,  
    LTraceLevel1,  
    LTraceLevel2,  
    LTraceLevel3,  
    LTraceLevel4,  
    LStatusLevel0 = 20,  
    LStatusLevel1,  
    LStatusLevel2,  
    LStatusLevel3,  
    LStatusLevel4,  
    LWarningLevel = 40,  
    LErrorLevel = 50,  
    LPanicLevel = 100  
} LoggingLevelEnum;  
```  
  
## <a name="members"></a>Члены  
  
|Член|Описание|  
|------------|-----------------|  
|`LTraceLevel0`|Сообщение является уровнем трассировки 0.|  
|`LTraceLevel1`|Сообщение является уровнем трассировки 1.|  
|`LTraceLevel2`|Сообщение является уровнем трассировки 2.|  
|`LTraceLevel3`|Сообщение имеет уровень трассировки 3.|  
|`LTraceLevel4`|Сообщение имеет уровень трассировки 4.|  
|`LStatusLevel0`|Сообщение имеет уровень состояния 0.|  
|`LStatusLevel1`|Сообщение имеет уровень состояния 1.|  
|`LStatusLevel2`|Сообщение имеет уровень состояния 2.|  
|`LStatusLevel3`|Сообщение имеет уровень состояния 3.|  
|`LStatusLevel4`|Сообщение имеет уровень состояния 4.|  
|`LWarningLevel`|Сообщение является уровнем предупреждения.|  
|`LErrorLevel`|Сообщение имеет уровень ошибки.|  
|`LPanicLevel`|Сообщение имеет уровень тревоги.|  
  
## <a name="remarks"></a>Remarks  

 Среда CLR вызывает метод [ICorDebugManagedCallback:: LogMessage](icordebugmanagedcallback-logmessage-method.md) , чтобы уведомить отладчик о том, что управляемый поток зарегистрировал событие. Среда CLR передает значение `LoggingLevelEnum` перечисления, чтобы указать степень серьезности сообщения, которое управляемый поток записал в журнал событий.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v10plus](../../../../includes/net-current-v10plus-md.md)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Diagnostics.EventLog>
- [Перечисления отладки](debugging-enumerations.md)

---
description: 'Дополнительные сведения о: интерфейс ICorDebugAssembly'
title: Интерфейс ICorDebugAssembly
ms.date: 03/30/2017
api_name:
- ICorDebugAssembly
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICorDebugAssembly
helpviewer_keywords:
- ICorDebugAssembly interface [.NET Framework debugging]
ms.assetid: 9d657a28-6984-4c5e-8a54-89d20080baff
topic_type:
- apiref
ms.openlocfilehash: 746b5f4b2f26550788708d93bf0dd50f5f495041
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99711951"
---
# <a name="icordebugassembly-interface"></a>Интерфейс ICorDebugAssembly

Представляет сборку.  
  
## <a name="methods"></a>Методы  
  
|Метод|Описание|  
|------------|-----------------|  
|[Метод EnumerateModules](icordebugassembly-enumeratemodules-method.md)|Возвращает перечислитель для модулей, содержащихся в сборке.|  
|[Метод GetAppDomain](icordebugassembly-getappdomain-method.md)|Возвращает указатель интерфейса на домен приложения, содержащий данный `ICorDebugAssembly` экземпляр.|  
|[Метод GetCodeBase](icordebugassembly-getcodebase-method.md)|Не реализовано в текущей версии платформа .NET Framework.|  
|[Метод GetName](icordebugassembly-getname-method.md)|Возвращает имя сборки.|  
|[Метод GetProcess](icordebugassembly-getprocess-method.md)|Возвращает экземпляр ICorDebugProcess, в котором выполняется сборка.|  
  
## <a name="remarks"></a>Remarks  
  
> [!NOTE]
> Этот интерфейс не поддерживает удаленные вызовы между компьютерами или между процессами.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v10plus](../../../../includes/net-current-v10plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейсы отладки](debugging-interfaces.md)

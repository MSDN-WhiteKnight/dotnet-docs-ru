---
description: 'Дополнительные сведения о: интерфейс ICorDebugManagedCallback'
title: Интерфейс ICorDebugManagedCallback
ms.date: 03/30/2017
api_name:
- ICorDebugManagedCallback
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICorDebugManagedCallback
helpviewer_keywords:
- ICorDebugManagedCallback interface [.NET Framework debugging]
ms.assetid: b47f1d61-c7dc-4196-b926-0b08c94f7041
topic_type:
- apiref
ms.openlocfilehash: 0dd33e4295caa8f5ae41c65d9bd10152737156ca
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99722819"
---
# <a name="icordebugmanagedcallback-interface"></a>Интерфейс ICorDebugManagedCallback

Предоставляет методы для обработки обратных вызовов отладчика.  
  
## <a name="methods"></a>Методы  
  
|Метод|Описание|  
|------------|-----------------|  
|[Метод Break](icordebugmanagedcallback-break-method.md)|Уведомляет отладчик о <xref:System.Reflection.Emit.OpCodes.Break> выполнении инструкции в потоке кода.|  
|[Метод Breakpoint](icordebugmanagedcallback-breakpoint-method.md)|Уведомляет отладчик об обнаружении точки останова.|  
|[Метод BreakpointSetError](icordebugmanagedcallback-breakpointseterror-method.md)|Уведомляет отладчик о том, что среде CLR не удалось точно привязать точку останова, установленную до JIT-компиляции функции.|  
|[Метод ControlCTrap](icordebugmanagedcallback-controlctrap-method.md)|Уведомляет отладчик о том, что в отлаживаемом процессе выполняется треппинг CTRL + C.|  
|[Метод CreateAppDomain](icordebugmanagedcallback-createappdomain-method.md)|Уведомляет отладчик о создании домена приложения.|  
|[Метод CreateProcess](icordebugmanagedcallback-createprocess-method.md)|Уведомляет отладчик о том, что процесс был присоединен или запущен в первый раз.|  
|[Метод CreateThread](icordebugmanagedcallback-createthread-method.md)|Уведомляет отладчик о том, что поток начал выполнение управляемого кода.|  
|[Метод DebuggerError](icordebugmanagedcallback-debuggererror-method.md)|Уведомляет отладчик о том, что произошла ошибка при попытке выполнить обработку события из среды CLR.|  
|[Метод EditAndContinueRemap](icordebugmanagedcallback-editandcontinueremap-method.md)|Не рекомендуется. Уведомляет отладчик о том, что событие повторного сопоставления было отправлено в интегрированную среду разработки.|  
|[Метод EvalComplete](icordebugmanagedcallback-evalcomplete-method.md)|Уведомляет отладчик о завершении оценки.|  
|[Метод EvalException](icordebugmanagedcallback-evalexception-method.md)|Уведомляет отладчик о завершении оценки с необработанным исключением.|  
|[Метод Exception](icordebugmanagedcallback-exception-method.md)|Уведомляет отладчик о появлении исключения из управляемого кода.|  
|[Метод ExitAppDomain](icordebugmanagedcallback-exitappdomain-method.md)|Уведомляет отладчик о завершении работы домена приложения.|  
|[Метод ExitProcess](icordebugmanagedcallback-exitprocess-method.md)|Уведомляет отладчик о завершении процесса.|  
|[Метод ExitThread](icordebugmanagedcallback-exitthread-method.md)|Уведомляет отладчик о том, что поток, который выполнял управляемый код, завершил работу.|  
|[Метод LoadAssembly](icordebugmanagedcallback-loadassembly-method.md)|Уведомляет отладчик о том, что сборка CLR была успешно загружена.|  
|[Метод LoadClass](icordebugmanagedcallback-loadclass-method.md)|Уведомляет отладчик о том, что класс был загружен.|  
|[Метод LoadModule](icordebugmanagedcallback-loadmodule-method.md)|Уведомляет отладчик о том, что модуль CLR был успешно загружен.|  
|[Метод LogMessage](icordebugmanagedcallback-logmessage-method.md)|Уведомляет отладчик о том, что управляемый поток CLR вызвал метод в <xref:System.Diagnostics.EventLog> классе для записи события в журнал.|  
|[Метод LogSwitch](icordebugmanagedcallback-logswitch-method.md)|Уведомляет отладчик о том, что управляемый поток CLR вызвал метод в <xref:System.Diagnostics.Switch> классе для создания, изменения или удаления переключателя отладки/трассировки.|  
|[Метод NameChange](icordebugmanagedcallback-namechange-method.md)|Уведомляет отладчик о том, что имя домена приложения или потока изменилось.|  
|[Метод StepComplete](icordebugmanagedcallback-stepcomplete-method.md)|Уведомляет отладчик о завершении шага.|  
|[Метод UnloadAssembly](icordebugmanagedcallback-unloadassembly-method.md)|Уведомляет отладчик о выгрузке сборки CLR.|  
|[Метод UnloadClass](icordebugmanagedcallback-unloadclass-method.md)|Уведомляет отладчик о выгрузке класса.|  
|[Метод UnloadModule](icordebugmanagedcallback-unloadmodule-method.md)|Уведомляет отладчик о выгрузке модуля CLR (DLL).|  
|[Метод UpdateModuleSymbols](icordebugmanagedcallback-updatemodulesymbols-method.md)|Уведомляет отладчик о том, что символы для модуля CLR были изменены.|  
  
## <a name="remarks"></a>Remarks  

 Все обратные вызовы сериализуются, вызываются в том же потоке и вызываются с процессом в состоянии SYNCHRONIZED.  
  
 Каждая реализация обратного вызова должна вызывать [ICorDebugController:: Continue](icordebugcontroller-continue-method.md) для возобновления выполнения. Если `ICorDebugController::Continue` метод не вызывается до возврата обратного вызова, процесс будет остановлен, а обратные вызовы событий не будут выполняться до `ICorDebugController::Continue` вызова метода.  
  
 Отладчик должен реализовать [ICorDebugManagedCallback2](icordebugmanagedcallback2-interface.md) при отладке приложений платформа .NET Framework версии 2,0. Экземпляр `ICorDebugManagedCallback` или `ICorDebugManagedCallback2` передается как объект обратного вызова в [ICorDebug:: SetManagedHandler](icordebug-setmanagedhandler-method.md).  
  
> [!NOTE]
> Этот интерфейс не поддерживает удаленные вызовы между компьютерами или между процессами.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v10plus](../../../../includes/net-current-v10plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICorDebug](icordebug-interface.md)
- [Интерфейс ICorDebugManagedCallback2](icordebugmanagedcallback2-interface.md)
- [Интерфейсы отладки](debugging-interfaces.md)

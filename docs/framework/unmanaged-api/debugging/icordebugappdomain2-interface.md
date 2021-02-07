---
description: 'Дополнительные сведения о: интерфейс ICorDebugAppDomain2'
title: Интерфейс ICorDebugAppDomain2
ms.date: 03/30/2017
api_name:
- ICorDebugAppDomain2
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICorDebugAppDomain2
helpviewer_keywords:
- ICorDebugAppDomain2 interface [.NET Framework debugging]
ms.assetid: 314d29f3-feb0-4a92-9530-b569c280cc31
topic_type:
- apiref
ms.openlocfilehash: 2f2fcc4166a0c825abaa04392f9905d17e286803
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99754192"
---
# <a name="icordebugappdomain2-interface"></a>Интерфейс ICorDebugAppDomain2

Предоставляет методы для работы с массивами, указателями, указателями функций и ссылочными типами. Этот интерфейс является расширением интерфейса ICorDebugAppDomain.  
  
## <a name="methods"></a>Методы  
  
|Метод|Описание|  
|------------|-----------------|  
|[Метод GetArrayOrPointerType](icordebugappdomain2-getarrayorpointertype-method.md)|Возвращает массив указанного типа или указатель или ссылку на указанный тип.|  
|[Метод GetFunctionPointerType](icordebugappdomain2-getfunctionpointertype-method.md)|Возвращает указатель на функцию с заданной сигнатурой.|  
  
## <a name="remarks"></a>Remarks  
  
> [!NOTE]
> Этот интерфейс не поддерживает удаленные вызовы между компьютерами или между процессами.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейсы отладки](debugging-interfaces.md)

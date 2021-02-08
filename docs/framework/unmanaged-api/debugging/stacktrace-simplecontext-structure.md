---
description: 'Дополнительные сведения: структура StackTrace_SimpleContext'
title: Структура StackTrace_SimpleContext
ms.date: 03/30/2017
api_name:
- StackTrace_SimpleContext
api_location:
- diasymreader.dll
api_type:
- COM
f1_keywords:
- SimpleContext
helpviewer_keywords:
- SimpleContext structure [.NET Framework debugging]
- StackTrace_SimpleContext structure [.NET Framework debugging]
ms.assetid: d4cef11f-a8ca-49bc-a1b8-6631f9e28f3e
topic_type:
- apiref
ms.openlocfilehash: 22a0acada5ef2d392dfdef5326953be137280d7f
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99800569"
---
# <a name="stacktrace_simplecontext-structure"></a>Структура StackTrace_SimpleContext

Обеспечивает простой контекст, который может использоваться вместо полной структуры `CONTEXT`.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
struct StackTrace_SimpleContext  
{  
    ULONG64 StackOffset;       // ESP on x86  
    ULONG64 FrameOffset;       // EBP on x86  
    ULONG64 InstructionOffset; // EIP on x86  
};  
```  
  
## <a name="members"></a>Члены  
  
|Член|Описание|  
|------------|-----------------|  
|`StackOffset`|Указатель стека или ввод указателя стека (ESP) на платформах x86.|  
|`FrameOffset`|Смещение кадра или регистр EBP на платформах x86.|  
|`InstructionOffset`|Указатель инструкции или ввод указателя инструкции (EIP) на платформах x86.|  
  
## <a name="remarks"></a>Remarks  

 Поскольку функции трассировки стека обычно должны возвращать только адрес, Смещение фрейма и адрес стека, при необходимости можно использовать `SimpleContext` структуру, а не большую `CONTEXT` структуру.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** SOS_Stacktrace. h  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Структуры отладки](debugging-structures.md)
- [Отладка](index.md)

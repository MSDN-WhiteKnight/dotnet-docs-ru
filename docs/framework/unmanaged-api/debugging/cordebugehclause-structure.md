---
description: 'Дополнительные сведения о: структура Кордебужехклаусе'
title: Структура CorDebugEHClause
ms.date: 03/30/2017
dev_langs:
- cpp
api_name:
- CorDebugEHClause
api_location:
- mscordbi.dll
api_type:
- COM
ms.assetid: 0e350a1b-6997-46d0-bfc5-962a5011ef43
topic_type:
- apiref
ms.openlocfilehash: ecb00e2a110719ab82de32fb1f1c861e2033a528
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99801674"
---
# <a name="cordebugehclause-structure"></a>Структура CorDebugEHClause

[Поддерживается в .NET Framework 4.5.2 и более поздних версиях.]  
  
 Представляет предложение обработки исключений для данного фрагмента кода промежуточного языка.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp
typedef struct _CorDebugEHClause {  
   ULONG32 Flags;  
   ULONG32 TryOffset;  
   ULONG32 TryLength;  
   ULONG32 HandlerOffset;  
   ULONG32 HandlerLength;  
   ULONG32 ClassToken;  
   ULONG32 FilterOffset;  
} CorDebugEHClause;  
```  
  
## <a name="members"></a>Члены  
  
|Член|Описание|  
|------------|-----------------|  
|`Flags`|Битовое поле, описывающее информацию об исключениях в предложении обработки исключений. Дополнительные сведения см. в разделе «Примечания».|  
|`TryOffset`|Смещение блока `try` в байтах от начала тела метода.|  
|`TryLength`|Длина блока `try` в байтах.|  
|`HandlerOffset`|Расположение обработчика для этого блока `try`.|  
|`HandlerLength`|Размер кода обработчика в байтах.|  
|`ClassToken`|Токен метаданных для обработчика исключений на основе типа.|  
|`FilterOffset`|Смещение в байтах от начала тела метода для обработчика исключений на основе фильтра.|  
  
## <a name="remarks"></a>Remarks  

 Массив `CoreDebugEHClause` значений возвращается методом [GetEHClauses](icordebugilcode-getehclauses-method.md) .  
  
 Информация о предложении обработки исключений определяется спецификацией CLI. Дополнительные сведения см. в разделе [Standard ECMA-355: Common Language Infrastructure (CLI), 6-й выпуск](https://www.ecma-international.org/publications/standards/Ecma-335.htm).  
  
 Поле `flags` может содержать следующие флаги. Обратите внимание, что они не определены в CorDebug.idl или CorDebug.h.  
  
|Флаг|Значение|Описание|  
|----------|-----------|-----------------|  
|`COR_ILEXCEPTION_CLAUSE_EXCEPTION`|0x00000000|Введенное предложение исключений.|  
|`COR_ILEXCEPTION_CLAUSE_FILTER`|0x00000001|Фильтр исключений и предложение обработчика.|  
|`COR_ILEXCEPTION_CLAUSE_FINALLY`|0x00000002|Предложение `finally`.|  
|`COR_ILEXCEPTION_CLAUSE_FAULT`|0x00000004|Неправильное предложение (предложение `finally`, которое вызывается только при возникновении исключения).|  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v452plus](../../../../includes/net-current-v452plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Метод GetEHClauses](icordebugilcode-getehclauses-method.md)
- [Структуры отладки](debugging-structures.md)

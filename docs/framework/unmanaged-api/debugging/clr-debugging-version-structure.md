---
description: 'Дополнительные сведения: структура CLR_DEBUGGING_VERSION'
title: Структура CLR_DEBUGGING_VERSION
ms.date: 03/30/2017
api_name:
- CLR_DEBUGGING_VERSION
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- CLR_DEBUGGING_VERSION
helpviewer_keywords:
- CLR_DEBUGGING_VERSION structure [.NET Framework debugging]
ms.assetid: 4d821186-3ddf-405a-ac44-d79438a9f7f3
topic_type:
- apiref
ms.openlocfilehash: 2d274a91948b98dc309cd5670c3dd3bf6cd01e2b
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99772787"
---
# <a name="clr_debugging_version-structure"></a>Структура CLR_DEBUGGING_VERSION

Определяет версию продукта среды CLR, предназначенную для отладки.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
typedef struct _CLR_DEBUGGING_VERSION  
{  
    WORD wStructVersion;
    WORD wMajor;
    WORD wMinor;
    WORD wBuild;
    WORD wRevision;
} CLR_DEBUGGING_VERSION;
```  
  
## <a name="members"></a>Члены  
  
|Член|Описание|  
|------------|-----------------|  
|`wStructVersion`|Номер версии структуры|  
|`wMajor`|Основной номер версии.|  
|`wMinor`|Дополнительный номер версии.|  
|`wBuild`|Номер построения.|  
|`wRevision`|Номер редакции сборки.|  
  
## <a name="remarks"></a>Remarks  

 Структура аналогична `CLR_DEBUGGING_VERSION` структуре COR_VERSION, однако `CLR_DEBUGGING_VERSION` Структура предоставляет дополнительное поле версии структуры ( `wStructVersion` ). В настоящее время для этого поля необходимо задать значение 0.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug. idl  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v40plus](../../../../includes/net-current-v40plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Структуры отладки](debugging-structures.md)
- [Отладка](index.md)

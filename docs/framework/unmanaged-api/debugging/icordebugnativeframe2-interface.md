---
description: 'Дополнительные сведения о: интерфейс ICorDebugNativeFrame2'
title: Интерфейс ICorDebugNativeFrame2
ms.date: 03/30/2017
api_name:
- ICorDebugNativeFrame2
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICorDebugNativeFrame2
helpviewer_keywords:
- ICorDebugNativeFrame2 interface [.NET Framework debugging]
ms.assetid: 52a80838-af36-4399-bc97-d8a4c6d76df2
topic_type:
- apiref
ms.openlocfilehash: 9ed0e20bb29bef3b210258956ebecb1ee7a96df8
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99722351"
---
# <a name="icordebugnativeframe2-interface"></a>Интерфейс ICorDebugNativeFrame2

Предоставляет методы, проверяющие для кадров наличие взаимоотношений типа "дочерний-родительский".  
  
## <a name="methods"></a>Методы  
  
|Метод|Описание|  
|------------|-----------------|  
|[Метод IsChild](icordebugnativeframe2-ischild-method.md)|Определяет, является ли текущий кадр дочерним кадром.|  
|[Метод IsMatchingParentFrame](icordebugnativeframe2-ismatchingparentframe-method.md)|Определяет, является ли указанный кадр родительским по отношению к текущему кадру.|  
|[Метод GetStackParameterSize](icordebugnativeframe2-getstackparametersize-method.md)|Возвращает совокупный размер параметров в стеке в операционных системах x86.|  
  
## <a name="remarks"></a>Remarks  

 Этот интерфейс логически расширяет интерфейс "ICorDebugNativeFrame".  
  
> [!NOTE]
> Этот интерфейс не поддерживает удаленные вызовы между компьютерами или между процессами.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v40plus](../../../../includes/net-current-v40plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейсы отладки](debugging-interfaces.md)
- [Отладка](index.md)

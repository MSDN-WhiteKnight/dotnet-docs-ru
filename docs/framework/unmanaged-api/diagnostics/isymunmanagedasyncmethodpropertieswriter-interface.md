---
description: 'Дополнительные сведения о: интерфейс метод isymunmanagedasyncmethodpropertieswriter'
title: Интерфейс ISymUnmanagedAsyncMethodPropertiesWriter
ms.date: 03/30/2017
ms.assetid: caa71820-8058-4b6a-93a2-25ee757d92d3
ms.openlocfilehash: 4c8b1bc037485e22160af28b59d751859a157499
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99790195"
---
# <a name="isymunmanagedasyncmethodpropertieswriter-interface"></a>Интерфейс ISymUnmanagedAsyncMethodPropertiesWriter

Позволяет определить дополнительные сведения о асинхронном методе для каждого символа метода. Всегда используйте с открытым методом. то есть между вызовами [метода опенмесод](isymunmanagedwriter-openmethod-method.md) и [метода клосемесод](isymunmanagedwriter-closemethod-method.md).  
  
## <a name="syntax"></a>Синтаксис  
  
```idl  
[object,uuid(FC073774-1739-4232-BD56-A027294BEC15),pointer_default(unique)]interface ISymUnmanagedAsyncMethodPropertiesWriter : IUnknown  
```  
  
## <a name="methods"></a>Методы  

 Этот интерфейс содержит следующие методы:  
  
|Метод|Описание|  
|------------|-----------------|  
|[Метод DefineAsyncStepInfo](isymunmanagedasyncmethodpropertieswriter-defineasyncstepinfo-method.md)|Определите группу асинхронных операций await в текущем методе.<br /><br /> Каждое значение yield Offset соответствует инструкции Return, определяющей потенциальный доход. Каждая `breakpointMethod` / `breakpointOffset` пара определяет, где будет возобновлена асинхронная операция. это может быть другой метод.|  
|[Метод DefineCatchHandlerILOffset](isymunmanagedasyncmethodpropertieswriter-definecatchhandleriloffset-method.md)|Задает смещение IL для обработчика catch, созданного компилятором, который создает оболочку для асинхронного метода.<br /><br /> Смещение IL созданного блока catch используется отладчиком для управления перехватом, как если бы он был непользовательским кодом, несмотря на то, что он может произойти в методе пользовательского кода. В частности, он используется в ответ на событие исключения **катчхандлерфаунд** .|  
|[Метод DefineKickoffMethod](isymunmanagedasyncmethodpropertieswriter-definekickoffmethod-method.md)|Задает начальный метод, инициирующий асинхронную операцию.|  
  
## <a name="requirements"></a>Требования  

 **Заголовок:** Корсим. idl, Корсим. h  
  
## <a name="see-also"></a>См. также

- [Интерфейсы хранилища символов диагностики](diagnostics-symbol-store-interfaces.md)

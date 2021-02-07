---
description: 'Дополнительные сведения о методе: ISymUnmanagedENCUpdate:: Упдатемесодлинес'
title: Метод ISymUnmanagedENCUpdate::UpdateMethodLines
ms.date: 03/30/2017
api_name:
- ISymUnmanagedENCUpdate.UpdateMethodLines
api_location:
- diasymreader.dll
api_type:
- COM
f1_keywords:
- ISymUnmanagedENCUpdate::UpdateMethodLines
helpviewer_keywords:
- UpdateMethodLines method [.NET Framework debugging]
- ISymUnmanagedENCUpdate::UpdateMethodLines method [.NET Framework debugging]
ms.assetid: 275ef87b-0b53-49f9-af6b-58506335dc06
topic_type:
- apiref
ms.openlocfilehash: 6174f3aa980ccf2cdc07720e3aa90b7bb74a77af
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99710066"
---
# <a name="isymunmanagedencupdateupdatemethodlines-method"></a>Метод ISymUnmanagedENCUpdate::UpdateMethodLines

Позволяет обновлять сведения о строке для метода, который не был перекомпилирован, но строки были перемещены независимо друг от друга. Допускается использование разности для каждой инструкции.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT UpdateMethodLines(  
    [in]  mdMethodDef  mdMethodToken,  
    [in, size_is(cDeltas)] INT32*  pDeltas,  
    [in]  ULONG        cDeltas);  
```  
  
## <a name="parameters"></a>Параметры  

 `mdMethodToken`  
 окне Метаданные токена метода.  
  
 `pDeltas`  
 окне Массив `INT32` значений, указывающий разность для каждой точки следования в методе.  
  
 `cDeltas`  
 окне Значение типа, `ULONG` содержащее размер `pDeltas` параметра.  
  
## <a name="return-value"></a>Возвращаемое значение  

 S_OK, если метод выполнен. в противном случае E_FAIL или другой код ошибки.  
  
## <a name="requirements"></a>Требования  

 **Заголовок:** Корсим. idl, Корсим. h  
  
## <a name="see-also"></a>См. также

- [Интерфейс ISymUnmanagedENCUpdate](isymunmanagedencupdate-interface.md)

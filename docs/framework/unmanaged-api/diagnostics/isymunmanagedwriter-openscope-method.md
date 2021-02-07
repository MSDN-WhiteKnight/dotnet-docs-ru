---
description: 'Дополнительные сведения о методе: ISymUnmanagedWriter:: OpenScope'
title: Метод ISymUnmanagedWriter::OpenScope
ms.date: 03/30/2017
api_name:
- ISymUnmanagedWriter.OpenScope
api_location:
- diasymreader.dll
api_type:
- COM
f1_keywords:
- ISymUnmanagedWriter::OpenScope
helpviewer_keywords:
- OpenScope method, ISymUnmanagedWriter interface [.NET Framework debugging]
- ISymUnmanagedWriter::OpenScope method [.NET Framework debugging]
ms.assetid: dbea0644-3873-4329-90b8-624163e87467
topic_type:
- apiref
ms.openlocfilehash: 1e47d97941b053fedcf08c7582e1083988a9fed4
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99762114"
---
# <a name="isymunmanagedwriteropenscope-method"></a>Метод ISymUnmanagedWriter::OpenScope

Открывает новую лексическую область видимости в текущем методе. Область становится новой текущей областью и помещается в стек областей. Области должны образовывать иерархию. Не допускается перекрытие одноуровневых элементов.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT OpenScope(  
    [in] ULONG32 startOffset,  
    [out, retval] ULONG32* pRetVal);  
```  
  
## <a name="parameters"></a>Параметры  

 `startOffset`  
 окне Смещение первой инструкции в лексической области в байтах от начала метода.  
  
 `pRetVal`  
 заполняет Указатель на объект `ULONG32` , который получает идентификатор области.  
  
## <a name="return-value"></a>Возвращаемое значение  

 S_OK, если метод выполнен. в противном случае E_FAIL или другой код ошибки.  
  
## <a name="remarks"></a>Remarks  

 `ISymUnmanagedWriter::OpenScope` возвращает непрозрачный идентификатор области, который можно использовать с [ISymUnmanagedWriter:: сетскоперанже](isymunmanagedwriter-setscoperange-method.md) для определения начального и конечного смещения области в более позднее время. В этом случае смещения, передаваемые в `ISymUnmanagedWriter::OpenScope` и [ISymUnmanagedWriter:: CloseScope](isymunmanagedwriter-closescope-method.md) , игнорируются. Идентификаторы областей допустимы только в текущем методе.  
  
## <a name="requirements"></a>Требования  

 **Заголовок:** Корсим. idl, Корсим. h  
  
## <a name="see-also"></a>См. также

- [Интерфейс ISymUnmanagedWriter](isymunmanagedwriter-interface.md)

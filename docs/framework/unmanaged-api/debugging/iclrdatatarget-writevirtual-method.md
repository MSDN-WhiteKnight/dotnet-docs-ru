---
description: 'Дополнительные сведения о методе: ICLRDataTarget:: WriteVirtual'
title: Метод ICLRDataTarget::WriteVirtual
ms.date: 03/30/2017
api_name:
- ICLRDataTarget.WriteVirtual
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICLRDataTarget::WriteVirtual
helpviewer_keywords:
- ICLRDataTarget::WriteVirtual method [.NET Framework debugging]
- WriteVirtual method [.NET Framework debugging]
ms.assetid: d627e8b7-a605-40ac-b9bb-da9a3f1b66d9
topic_type:
- apiref
ms.openlocfilehash: 29ff8d629c5797099dab155802fff99786f4ce15
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99794862"
---
# <a name="iclrdatatargetwritevirtual-method"></a>Метод ICLRDataTarget::WriteVirtual

Записывает данные из указанного буфера в указанный адрес виртуальной памяти.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT WriteVirtual (  
    [in] CLRDATA_ADDRESS    address,  
    [in, size_is(bytesRequested)]
        BYTE                *buffer,  
    [in] ULONG32            bytesRequested,  
    [out] ULONG32           *bytesWritten  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `address`  
 окне CLRDATA_ADDRESS, в которой хранится адрес виртуальной памяти.  
  
 `buffer`  
 окне Указатель на буфер, в котором хранятся записываемые данные.  
  
 `bytesRequested`  
 окне Число записываемых байтов.  
  
 `bytesWritten`  
 заполняет Указатель на фактическое число записанных байтов.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** Клрдата. idl, Клрдата. h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICLRDataTarget](iclrdatatarget-interface.md)

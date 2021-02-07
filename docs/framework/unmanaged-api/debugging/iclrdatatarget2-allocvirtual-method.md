---
description: 'Дополнительные сведения о методе: ICLRDataTarget2:: Аллоквиртуал'
title: Метод ICLRDataTarget2::AllocVirtual
ms.date: 03/30/2017
api_name:
- ICLRDataTarget2.AllocVirtual
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICLRDataTarget2::AllocVirtual
helpviewer_keywords:
- ICLRDataTarget2::AllocVirtual method [.NET Framework debugging]
- AllocVirtual method [.NET Framework debugging]
ms.assetid: e3226230-964b-47fb-9f53-d6fdbeda1e9e
topic_type:
- apiref
ms.openlocfilehash: d81474e4067599178285b6fa876919298617919d
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99729345"
---
# <a name="iclrdatatarget2allocvirtual-method"></a>Метод ICLRDataTarget2::AllocVirtual

Вызывается службами доступа к данным среды CLR для выделения памяти в адресном пространстве этого целевого процесса.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT AllocVirtual(  
    [in] CLRDATA_ADDRESS addr,  
    [in] ULONG32 size,  
    [in] ULONG32 typeFlags,  
    [in] ULONG32 protectFlags,  
    [out] CLRDATA_ADDRESS* virt  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `addr`  
 окне `CLRDATA_ADDRESS` Значение типа, указывающее запрошенный начальный адрес выделяемой памяти.  
  
 `size`  
 окне Размер выделяемой памяти в байтах.  
  
 `typeFlags`  
 окне Флаги, управляющие выделением памяти. См. раздел `VirtualAlloc` функция Win32.  
  
 `protectFlags`  
 окне Атрибуты защиты для выделенной памяти. См. раздел `VirtualAlloc` функция Win32.  
  
 `virt`  
 заполняет Указатель на `CLRDATA_ADDRESS` значение, указывающее фактический начальный адрес выделенной памяти.  
  
## <a name="remarks"></a>Remarks  

 `AllocVirtual`Метод служит логической оболочкой для `VirtualAlloc` функции Win32.  
  
 Этот метод реализуется модулем записи отладчика.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** Клрдата. idl, Клрдата. h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICLRDataTarget2](iclrdatatarget2-interface.md)
- [Метод FreeVirtual](iclrdatatarget2-freevirtual-method.md)

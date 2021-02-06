---
description: 'Дополнительные сведения о методе: Икордебугмутабледататаржет:: WriteVirtual'
title: Метод ICorDebugMutableDataTarget::WriteVirtual
ms.date: 03/30/2017
ms.assetid: 80833648-58a7-491a-8dc8-9a48e9bb3adc
ms.openlocfilehash: 3f3400456b7af51f4b24d7e14e35d641f03a8bfd
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99637824"
---
# <a name="icordebugmutabledatatargetwritevirtual-method"></a>Метод ICorDebugMutableDataTarget::WriteVirtual

Записывает память в адресное пространство целевого процесса.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT WriteVirtual(  
   [in] CORDB_ADDRESS address,  
   [in, size_is(bytesRequested)] const BYTE * pBuffer,  
   [in] ULONG32 bytesRequested);  
```  
  
## <a name="parameters"></a>Параметры  

 `address`  
 [in] Адрес для записи содержимого `pBuffer`.  
  
 `pBuffer`  
 [в] Указатель на массив байтов, содержащий байты для записи.  
  
 `address`  
 [in] Количество байтов в `pBuffer`.  
  
## <a name="return-value"></a>Возвращаемое значение  

 Значение `S_OK` при успешном выполнении или любое другое значение `HRESULT` в случае сбоя.  
  
## <a name="remarks"></a>Remarks  

 Если не удается записать все байты, вызов метода завершается ошибкой без изменения каких-либо байтов в целевом адресном пространстве. (В противном случае целевое адресное пространство оказалось бы в несогласованном состоянии, что сделало бы ненадежной дальнейшую отладку.)  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v46plus](../../../../includes/net-current-v46plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICorDebugMutableDataTarget](icordebugmutabledatatarget-interface.md)
- [Интерфейсы отладки](debugging-interfaces.md)

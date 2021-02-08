---
description: 'Дополнительные сведения о методе: метод iclrdatatarget3:: GetExceptionRecord'
title: Метод ICLRDataTarget3::GetExceptionRecord
ms.date: 03/30/2017
dev_langs:
- cpp
api_name:
- ICLRDataTarget3.GetExceptionRecord
api_location:
- mscordbi.dll
api_type:
- COM
ms.assetid: 6643c2af-2ee6-4789-aa25-1d8eaf500c94
topic_type:
- apiref
ms.openlocfilehash: cb816d1be72ee57b556b78dba6ed7503d941b210
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99794810"
---
# <a name="iclrdatatarget3getexceptionrecord-method"></a>Метод ICLRDataTarget3::GetExceptionRecord

Вызывается службами доступа к данным среды CLR для извлечения записи исключения, связанной с целевым процессом. Например, для целевого объекта дампа это будет эквивалентно записи исключения, передаваемой через `ExceptionParam` аргумент в функцию [Минидумпвритедумп](/windows/desktop/api/minidumpapiset/nf-minidumpapiset-minidumpwritedump) в библиотеке справки по отладке Windows (DBGHELP).  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT GetExceptionRecord(  
    [in] ULONG32 bufferSize,  
    [out] ULONG32* bufferUsed,  
    [out, size_is(bufferSize] BYTE* buffer  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `bufferSize`  
 [в] Размер входного буфера в байтах. Оно должно быть равно `sizeof(` [MINIDUMP_EXCEPTION](/windows/win32/api/minidumpapiset/ns-minidumpapiset-minidump_exception) `)` .  
  
 `bufferUsed`  
 [из] Указатель на тип `ULONG32`, который получает количество байтов, фактически записанных в буфер.  
  
 `buffer`  
 [из] Указатель на буфер памяти, который получает копию записи исключения. Запись исключения возвращается как тип [MINIDUMP_EXCEPTION](/windows/win32/api/minidumpapiset/ns-minidumpapiset-minidump_exception) .  
  
## <a name="return-value"></a>Возвращаемое значение  

 Возвращается значение `S_OK` при успешном выполнении или код ошибки `HRESULT` при сбое. Коды `HRESULT` могут включать значения, приведенные в следующей таблице.  
  
|Код возврата|Описание|  
|-----------------|-----------------|  
|`S_OK`|Метод успешно выполнен. Запись исключения скопирована в буфер вывода.|  
|`HRESULT_FROM_WIN32(ERROR_NOT_FOUND)`|Нет записей исключения, связанных с целевым объектом.|  
|`HRESULT_FROM_WIN32(ERROR_BAD_LENGTH)`|Размер входного буфера не равен `sizeof(MINIDUMP_EXCEPTION)`.|  
  
## <a name="remarks"></a>Remarks  

 [MINIDUMP_EXCEPTION](/windows/win32/api/minidumpapiset/ns-minidumpapiset-minidump_exception) — это структура, определенная в dbghelp. h и IMAGEHLP. h в Windows SDK.  
  
 Этот метод реализуется модулем записи отладчика.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** Клрдата. idl, Клрдата. h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[v451_update](../../../../includes/net-current-v451-nov-plus.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICLRDataTarget3](iclrdatatarget3-interface.md)
- [Метод GetExceptionContextRecord](iclrdatatarget3-getexceptioncontextrecord-method.md)
- [Метод GetExceptionThreadID](iclrdatatarget3-getexceptionthreadid-method.md)

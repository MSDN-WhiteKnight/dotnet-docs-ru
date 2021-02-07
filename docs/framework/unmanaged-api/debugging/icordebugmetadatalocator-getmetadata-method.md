---
description: 'Дополнительные сведения о методе: Икордебугметадаталокатор:: with MetaData'
title: Метод ICorDebugMetaDataLocator::GetMetaData
ms.date: 03/30/2017
api_name:
- ICorDebugMetaDataLocator.GetMetaData
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICorDebugMetaDataLocator::GetMetaData
helpviewer_keywords:
- ICorDebugMetaDataLocator::GetMetaData method [.NET Framework debugging]
- GetMetaData method, ICorDebugMetaDataLocator interface [.NET Framework debugging]
ms.assetid: f9b0ff22-54db-45eb-9cc3-508000a3141d
topic_type:
- apiref
ms.openlocfilehash: 419a03e42a54057ab70e31a368e918612f3a85f6
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99691696"
---
# <a name="icordebugmetadatalocatorgetmetadata-method"></a>Метод ICorDebugMetaDataLocator::GetMetaData

Запрашивает у отладчика возврат полного пути к модулю, метаданные которого необходимы для завершения запрошенной отладчиком операции.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT GetMetaData(  
      [in] LPCWSTR wszImagePath,  
      [in] DWORD   dwImageTimeStamp,  
      [in] DWORD   dwImageSize,  
      [in] ULONG32 cchPathBuffer,  
      [out] ULONG32 * pcchPathBuffer,  
      [out, size_is(cchPathBuffer), length_is(*pcchPathBuffer)]  
               WCHAR wszPathBuffer[]  
      );  
```  
  
## <a name="parameters"></a>Параметры  

 `wszImagePath`  
 [in] Завершающаяся нулевым байтом строка, представляющая полный путь к файлу. Если полный путь недоступен, имя и расширение файла (*filename*.*расширение*).  
  
 `dwImageTimeStamp`  
 [in] Временная метка из заголовков PE-файла образа. Этот параметр потенциально может использоваться для поиска сервера символов ([SymSrv](/windows/desktop/debug/using-symsrv)).  
  
 `dwImageSize`  
 [in] Размер образа из заголовков PE-файла. Этот параметр может использоваться для поиска SymSrv.  
  
 `cchPathBuffer`  
 [in] Количество символов в `wszPathBuffer`.  
  
 `pcchPathBuffer`  
 [out] Количество `WCHAR`, записанных в `wszPathBuffer`.  
  
 Если метод возвращает E_NOT_SUFFICIENT_BUFFER, содержит число `WCHAR`, необходимых для сохранения пути.  
  
 `wszPathBuffer`  
 [out] Указатель на буфер, в который отладчик будет копировать полный путь к файлу, содержащему запрошенные метаданные.  
  
 `ofReadOnly`Флаг из перечисления [коропенфлагс](../metadata/coropenflags-enumeration.md) используется для запроса доступа только для чтения к метаданным в этом файле.  
  
## <a name="return-value"></a>Возвращаемое значение  

 Этот метод возвращает следующие конкретные результаты HRESULT, а также ошибки HRESULT, которые указывают на сбой метода. Все остальные ошибочные значения HRESULT указывают, что файл не удается найти.  
  
|HRESULT|Описание:|  
|-------------|-----------------|  
|S_OK|Метод завершился успешно. `wszPathBuffer` содержит полный путь к файлу и завершается нулевым байтом.|  
|E_NOT_SUFFICIENT_BUFFER|Текущий размер `wszPathBuffer` недостаточен для хранения полного пути. В этом случае `pcchPathBuffer` содержит необходимое количество `WCHAR`, включая завершающий символ null, и `GetMetaData` вызывается второй раз с запрошенным размером буфера.|  
  
## <a name="remarks"></a>Remarks  

 Если `wszImagePath` содержит полный путь для модуля из дампа, он указывает путь с компьютера, на котором был создан дамп. Файл может не существовать в этом расположении, или по этому пути может храниться неправильный файл с тем же именем.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v40plus](../../../../includes/net-current-v40plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICorDebugThread4](icordebugthread4-interface.md)
- [Интерфейсы отладки](debugging-interfaces.md)
- [Отладка](index.md)

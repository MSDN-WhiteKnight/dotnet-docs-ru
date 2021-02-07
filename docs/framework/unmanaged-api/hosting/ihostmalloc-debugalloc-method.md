---
description: 'Дополнительные сведения о методе: IHostMAlloc::D Ебугаллок'
title: Метод IHostMAlloc::DebugAlloc
ms.date: 03/30/2017
api_name:
- IHostMAlloc.DebugAlloc
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- IHostMAlloc::DebugAlloc
helpviewer_keywords:
- DebugAlloc method [.NET Framework hosting]
- IHostMAlloc::DebugAlloc method [.NET Framework hosting]
ms.assetid: 0bfbc527-bea2-43ce-b041-69186f4440dd
topic_type:
- apiref
ms.openlocfilehash: f94ff0d6cc1e25daee12c67c38167f7f14829510
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99708220"
---
# <a name="ihostmallocdebugalloc-method"></a>Метод IHostMAlloc::DebugAlloc

Запрашивает, что узел выделяет указанный объем памяти из кучи, и дополнительно следит за местом выделения памяти.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT DebugAlloc (  
    [in]  SIZE_T  cbSize,
    [in]  EMemoryCriticalLevel dwCriticalLevel,
    [in]  char*   pszFileName,
    [in]  int     iLineNo,
    [out] void**  ppMem  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `cbSize`  
 окне Размер (в байтах) текущего запроса на выделение памяти.  
  
 `dwCriticalLevel`  
 окне Одно из значений [EMemoryCriticalLevel](ememorycriticallevel-enumeration.md) , указывающее влияние сбоя выделения.  
  
 `pszFileName`  
 окне Файл исходного кода отлаживаемого объекта.  
  
 `iLineNo`  
 окне Номер строки, в `pszFileName` которой было запрошено выделение.  
  
 `ppMem`  
 заполняет Указатель на выделенную память или значение null, если не удалось завершить запрос.  
  
## <a name="return-value"></a>Возвращаемое значение  
  
|HRESULT|Описание:|  
|-------------|-----------------|  
|S_OK|`DebugAlloc` успешно возвращено.|  
|HOST_E_CLRNOTAVAILABLE|Среда CLR не была загружена в процесс, или среда CLR находится в состоянии, в котором она не может выполнить управляемый код или успешно обработать вызов.|  
|HOST_E_TIMEOUT|Время ожидания вызова истекло.|  
|HOST_E_NOT_OWNER|Вызывающий объект не владеет блокировкой.|  
|HOST_E_ABANDONED|Событие было отменено, пока заблокированный поток или волокно ожидают его.|  
|E_FAIL|Произошла неизвестная фатальная ошибка. Когда метод возвращает E_FAIL, среда CLR больше не может использоваться в процессе. Последующие вызовы методов размещения возвращают HOST_E_CLRNOTAVAILABLE.|  
|E_OUTOFMEMORY|Недостаточно памяти для завершения запроса на выделение.|  
  
## <a name="remarks"></a>Remarks  

 Среда CLR получает указатель интерфейса на экземпляр [IHostMalloc](ihostmalloc-interface.md) , вызывая метод [IHostMemoryManager:: CreateMalloc](ihostmemorymanager-createmalloc-method.md) . `DebugAlloc` позволяет среде выполнения получать сведения о файле кода для использования во время отладки.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** MSCorEE. h  
  
 **Библиотека:** Включается в качестве ресурса в MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс IHostMemoryManager](ihostmemorymanager-interface.md)
- [Интерфейс IHostMalloc](ihostmalloc-interface.md)

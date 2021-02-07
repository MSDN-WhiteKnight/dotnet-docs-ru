---
description: 'Дополнительные сведения о методе: IHostIoCompletionManager:: Жесостоверлаппедсизе'
title: Метод IHostIoCompletionManager::GetHostOverlappedSize
ms.date: 03/30/2017
api_name:
- IHostIoCompletionManager.GetHostOverlappedSize
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- IHostIoCompletionManager::GetHostOverlappedSize
helpviewer_keywords:
- IHostIoCompletionManager::GetHostOverlappedSize method [.NET Framework hosting]
- GetHostOverlappedSize method [.NET Framework hosting]
ms.assetid: 2902578b-d5e2-4f8d-a103-0c7b6dceda9e
topic_type:
- apiref
ms.openlocfilehash: 2a2ebe1da82c5702269b634eadfe98b72739e3df
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99708571"
---
# <a name="ihostiocompletionmanagergethostoverlappedsize-method"></a>Метод IHostIoCompletionManager::GetHostOverlappedSize

Возвращает размер любых пользовательских данных, которые узел намеревается добавить к запросам ввода-вывода.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT GetHostOverlappedSize (  
    [out] DWORD *pcbSize  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `pcbSize`  
 заполняет Указатель на число байтов, которое должна выделить среда CLR в дополнение к размеру `OVERLAPPED` объекта Win32.  
  
## <a name="return-value"></a>Возвращаемое значение  
  
|HRESULT|Описание:|  
|-------------|-----------------|  
|S_OK|`GetHostOverlappedSize` успешно возвращено.|  
|HOST_E_CLRNOTAVAILABLE|Среда CLR не была загружена в процесс, или среда CLR находится в состоянии, в котором она не может выполнить управляемый код или успешно обработать вызов.|  
|HOST_E_TIMEOUT|Время ожидания вызова истекло.|  
|HOST_E_NOT_OWNER|Вызывающий объект не владеет блокировкой.|  
|HOST_E_ABANDONED|Событие было отменено, пока заблокированный поток или волокно ожидают его.|  
|E_FAIL|Произошла неизвестная фатальная ошибка. Когда метод возвращает E_FAIL, среда CLR больше не может использоваться в процессе. Последующие вызовы методов размещения возвращают HOST_E_CLRNOTAVAILABLE.|  
  
## <a name="remarks"></a>Remarks  

 Все асинхронные вызовы операций ввода-вывода в API платформы Windows принимают `OVERLAPPED` объект Win32, который предоставляет такую информацию, как расположение указателя файла. Для поддержания состояния приложения, которые выполняют асинхронные вызовы операций ввода-вывода, обычно добавляют в структуру пользовательские данные. `GetHostOverlappedSize` и [IHostIoCompletionManager:: инитиализехостоверлаппед](ihostiocompletionmanager-initializehostoverlapped-method.md) предоставляют возможность ведущему приложению включать такие пользовательские данные.  
  
 Среда CLR вызывает `GetHostOverlappedSize` метод, чтобы определить размер пользовательских данных, которые узел намеревается добавить к `OVERLAPPED` объекту.  
  
> [!NOTE]
> `GetHostOverlappedSize` вызывается только один раз. Пользовательские данные узла должны иметь одинаковый размер для каждого запроса ввода-вывода.  
  
> [!IMPORTANT]
> Размер `OVERLAPPED` самого объекта не включается в значение `pcbSize` .  
  
 Дополнительные сведения о `OVERLAPPED` структуре см. в документации по платформе Windows.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** MSCorEE. h  
  
 **Библиотека:** Включается в качестве ресурса в MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Threading.NativeOverlapped>
- [Интерфейс ICLRIoCompletionManager](iclriocompletionmanager-interface.md)
- [Интерфейс IHostIoCompletionManager](ihostiocompletionmanager-interface.md)

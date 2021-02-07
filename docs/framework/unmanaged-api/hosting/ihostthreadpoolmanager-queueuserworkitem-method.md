---
description: 'Дополнительные сведения о методе: IHostThreadPoolManager:: QueueUserWorkItem'
title: Метод IHostThreadPoolManager::QueueUserWorkItem
ms.date: 03/30/2017
api_name:
- IHostThreadPoolManager.QueueUserWorkItem
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- IHostThreadPoolManager::QueueUserWorkItem
helpviewer_keywords:
- IHostThreadPoolManager::QueueUserWorkItem method [.NET Framework hosting]
- QueueUserWorkItem method [.NET Framework hosting]
ms.assetid: 41602053-8670-4827-9d61-cbfcba509b9c
topic_type:
- apiref
ms.openlocfilehash: edfbf5cfb34473a5fd920307981237fd5deab9aa
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99753787"
---
# <a name="ihostthreadpoolmanagerqueueuserworkitem-method"></a>Метод IHostThreadPoolManager::QueueUserWorkItem

Ставит в очередь функцию для выполнения и указывает объект, содержащий данные, которые будут использоваться этой функцией. Функция выполняется, когда поток станет доступным.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT QueueUserWorkItem (  
    [in] LPTHREAD_START_ROUTINE Function,  
    [in] PVOID Context,  
    [in] ULONG Flags  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `Function`  
 окне Указатель функции, представляющий функцию для выполнения.  
  
 `Context`  
 окне Объект, содержащий данные, которые будут использоваться `Function` .  
  
 `Flags`  
 окне Одно из значений флагов, определенное для `QueueUserWorkItem` метода Win32, которое управляет выполнением.  
  
## <a name="return-value"></a>Возвращаемое значение  
  
|HRESULT|Описание:|  
|-------------|-----------------|  
|S_OK|`QueueUserWorkItem` успешно возвращено.|  
|HOST_E_CLRNOTAVAILABLE|Среда CLR не была загружена в процесс, или среда CLR находится в состоянии, в котором она не может выполнить управляемый код или успешно обработать вызов.|  
|HOST_E_TIMEOUT|Время ожидания вызова истекло.|  
|HOST_E_NOT_OWNER|Вызывающий объект не владеет блокировкой.|  
|HOST_E_ABANDONED|Событие было отменено, пока заблокированный поток или волокно ожидают его.|  
|E_FAIL|Произошла неизвестная фатальная ошибка. Когда метод возвращает E_FAIL, среда CLR больше не может использоваться в процессе. Последующие вызовы методов размещения возвращают HOST_E_CLRNOTAVAILABLE.|  
  
## <a name="remarks"></a>Remarks  

 `QueueUserWorkItem` помещает рабочий элемент в очередь в рабочий поток в пуле потоков. Его сигнатура и типы параметров идентичны параметрам соответствующей функции Win32, которая имеет то же имя. Дополнительные сведения см. в документации по платформе Windows.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** MSCorEE. h  
  
 **Библиотека:** Включается в качестве ресурса в MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Threading.ThreadPool.QueueUserWorkItem%2A>
- <xref:System.Threading.ThreadPool>
- [Интерфейс IHostThreadPoolManager](ihostthreadpoolmanager-interface.md)

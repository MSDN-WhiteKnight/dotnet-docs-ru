---
description: Дополнительные сведения о функции GetVersionFromProcess
title: Функция GetVersionFromProcess
ms.date: 03/30/2017
api_name:
- GetVersionFromProcess
api_location:
- mscoree.dll
- mscoreei.dll
api_type:
- DLLExport
f1_keywords:
- GetVersionFromProcess
helpviewer_keywords:
- GetVersionFromProcess function [.NET Framework hosting]
ms.assetid: a9f7f824-64a1-408d-8607-91c7f19d21fe
topic_type:
- apiref
ms.openlocfilehash: ab665d2984f79baf049009690b36782528094937
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99785254"
---
# <a name="getversionfromprocess-function"></a>Функция GetVersionFromProcess

Возвращает номер версии общеязыковой среды выполнения (CLR), связанной с указанным обработчиком процесса.  
  
 Эта функция является устаревшей в платформа .NET Framework 4.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT GetVersionFromProcess (  
    [in]  HANDLE  hProcess,
    [out] LPWSTR  pVersion,
    [in]  DWORD   cchBuffer,
    [out] DWORD  *dwLength  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `hProcess`  
 окне Обработчик процесса.  
  
 `pVersion`  
 заполняет Буфер, содержащий строку номера версии после успешного завершения метода.  
  
 `cchBuffer`  
 окне Длина буфера версии.  
  
 `pdwLength`  
 заполняет Указатель на длину строки номера версии.  
  
## <a name="return-value"></a>Возвращаемое значение  

 Этот метод возвращает коды стандартных ошибок модели COM, как определено в файле WinError. h, в дополнение к следующим значениям.  
  
|Код возврата|Описание|  
|-----------------|-----------------|  
|S_OK|Метод завершился успешно.|  
|E_INVALIDARG|`pVersion` имеет значение NULL и не `cchBuffer` имеет значение null, или наоборот.<br /><br /> -или-<br /><br /> `hProcess` не является допустимым маркером для процесса.<br /><br /> -или-<br /><br /> Среда CLR не загружена.|  
|ERROR_INSUFFICIENT_BUFFER|`cchBuffer` параметр имеет значение null или меньше длины строки версии.|  
|E_NOTIMPL|Этот метод недоступен в операционной системе Microsoft Windows 95, Microsoft Windows 98 или Microsoft Windows Millennium Edition.|  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** MSCorEE. h  
  
 **Библиотека:** MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Функция GetRequestedRuntimeInfo](getrequestedruntimeinfo-function.md)
- [Функция GetRequestedRuntimeVersion](getrequestedruntimeversion-function.md)
- [Устаревшие функции размещения CLR](deprecated-clr-hosting-functions.md)

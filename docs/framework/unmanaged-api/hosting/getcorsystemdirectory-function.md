---
description: Дополнительные сведения о функции GetCORSystemDirectory
title: Функция GetCORSystemDirectory
ms.date: 03/30/2017
api_name:
- GetCORSystemDirectory
api_location:
- mscoree.dll
- mscoreei.dll
api_type:
- DLLExport
f1_keywords:
- GetCORSystemDirectory
helpviewer_keywords:
- GetCORSystemDirectory function [.NET Framework hosting]
ms.assetid: 3dcd16a7-dafc-4ca8-b5cd-20ffb37db91d
topic_type:
- apiref
ms.openlocfilehash: 267736c2f8cdea03fbd9f77108a3d88193830ab4
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99785345"
---
# <a name="getcorsystemdirectory-function"></a>Функция GetCORSystemDirectory

Возвращает каталог установки среды CLR, который загружается в процесс. Каталог установки полностью квалифицирован, например "c:\windows\microsoft.net\framework\v1.0.3705".  
  
 Эта функция является устаревшей. Он заменяется методом [ICLRRuntimeInfo:: GetRuntimeDirectory](iclrruntimeinfo-getruntimedirectory-method.md) , предоставленным в платформа .NET Framework 4.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT GetCORSystemDirectory (
    [out] LPWSTR  pbuffer,
    [in]  DWORD   cchBuffer,
    [out] DWORD*  dwlength  
);
```  
  
## <a name="parameters"></a>Параметры  

 `pbuffer`  
 заполняет Буфер, в котором среда выполнения возвращает строку, содержащую полное имя каталога установки для среды выполнения, которая загружается в процесс. Если среда выполнения еще не загружена в процесс, функция возвращает соответствующие сведения о каталоге для последней версии среды выполнения, установленной на компьютере.  
  
 `cchBuffer`  
 окне Размер (в байтах) `pbuffer` .  
  
 `dwLength`  
 заполняет Число символов, возвращаемых в `pbuffer` .  
  
## <a name="remarks"></a>Remarks  
  
> [!CAUTION]
> Не используйте эту функцию в процессах, работающих в среде CLR версии 4. Если на компьютере установлена более ранняя версия среды CLR, эта функция возвращает каталог установки для этой версии.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** MSCorEE. h  
  
 **Библиотека:** MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v10plus](../../../../includes/net-current-v10plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Устаревшие функции размещения CLR](deprecated-clr-hosting-functions.md)
